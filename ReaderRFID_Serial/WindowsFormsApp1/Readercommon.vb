Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Runtime.InteropServices
Imports System.IO

Namespace WindowsFormsApp1
	Public Enum MessageType
		Info
		Warning
		[Error]
	End Enum


	Friend Module Util
		Private ReadOnly g_pwCrc16Table() As UShort = { &H0,&H1021,&H2042,&H3063,&H4084,&H50a5,&H60c6,&H70e7, &H8108,&H9129,&Ha14a,&Hb16b,&Hc18c,&Hd1ad,&He1ce,&Hf1ef, &H1231,&H210,&H3273,&H2252,&H52b5,&H4294,&H72f7,&H62d6, &H9339,&H8318,&Hb37b,&Ha35a,&Hd3bd,&Hc39c,&Hf3ff,&He3de, &H2462,&H3443,&H420,&H1401,&H64e6,&H74c7,&H44a4,&H5485, &Ha56a,&Hb54b,&H8528,&H9509,&He5ee,&Hf5cf,&Hc5ac,&Hd58d, &H3653,&H2672,&H1611,&H630,&H76d7,&H66f6,&H5695,&H46b4, &Hb75b,&Ha77a,&H9719,&H8738,&Hf7df,&He7fe,&Hd79d,&Hc7bc, &H48c4,&H58e5,&H6886,&H78a7,&H840,&H1861,&H2802,&H3823, &Hc9cc,&Hd9ed,&He98e,&Hf9af,&H8948,&H9969,&Ha90a,&Hb92b, &H5af5,&H4ad4,&H7ab7,&H6a96,&H1a71,&Ha50,&H3a33,&H2a12, &Hdbfd,&Hcbdc,&Hfbbf,&Heb9e,&H9b79,&H8b58,&Hbb3b,&Hab1a, &H6ca6,&H7c87,&H4ce4,&H5cc5,&H2c22,&H3c03,&Hc60,&H1c41, &Hedae,&Hfd8f,&Hcdec,&Hddcd,&Had2a,&Hbd0b,&H8d68,&H9d49, &H7e97,&H6eb6,&H5ed5,&H4ef4,&H3e13,&H2e32,&H1e51,&He70, &Hff9f,&Hefbe,&Hdfdd,&Hcffc,&Hbf1b,&Haf3a,&H9f59,&H8f78, &H9188,&H81a9,&Hb1ca,&Ha1eb,&Hd10c,&Hc12d,&Hf14e,&He16f, &H1080,&Ha1,&H30c2,&H20e3,&H5004,&H4025,&H7046,&H6067, &H83b9,&H9398,&Ha3fb,&Hb3da,&Hc33d,&Hd31c,&He37f,&Hf35e, &H2b1,&H1290,&H22f3,&H32d2,&H4235,&H5214,&H6277,&H7256, &Hb5ea,&Ha5cb,&H95a8,&H8589,&Hf56e,&He54f,&Hd52c,&Hc50d, &H34e2,&H24c3,&H14a0,&H481,&H7466,&H6447,&H5424,&H4405, &Ha7db,&Hb7fa,&H8799,&H97b8,&He75f,&Hf77e,&Hc71d,&Hd73c, &H26d3,&H36f2,&H691,&H16b0,&H6657,&H7676,&H4615,&H5634, &Hd94c,&Hc96d,&Hf90e,&He92f,&H99c8,&H89e9,&Hb98a,&Ha9ab, &H5844,&H4865,&H7806,&H6827,&H18c0,&H8e1,&H3882,&H28a3, &Hcb7d,&Hdb5c,&Heb3f,&Hfb1e,&H8bf9,&H9bd8,&Habbb,&Hbb9a, &H4a75,&H5a54,&H6a37,&H7a16,&Haf1,&H1ad0,&H2ab3,&H3a92, &Hfd2e,&Hed0f,&Hdd6c,&Hcd4d,&Hbdaa,&Had8b,&H9de8,&H8dc9, &H7c26,&H6c07,&H5c64,&H4c45,&H3ca2,&H2c83,&H1ce0,&Hcc1, &Hef1f,&Hff3e,&Hcf5d,&Hdf7c,&Haf9b,&Hbfba,&H8fd9,&H9ff8, &H6e17,&H7e36,&H4e55,&H5e74,&H2e93,&H3eb2,&Hed1,&H1ef0 }


		Public ReadOnly EmptyArray(-1) As Byte

		Public Function NumberFromString(ByVal value As String) As Integer
			If value Is Nothing Then
				Throw New ArgumentNullException("value")
			End If
			value = value.Trim()

			If value.Length = 0 Then
				Throw New FormatException("无法将空字符串转换为整数")
			End If

			If value.Length > 1 AndAlso value.Chars(0) = "0"c AndAlso (value.Chars(1) = "x"c OrElse value.Chars(1) = "X"c) Then
				Return HexFromString(value)
			End If
			Dim ch As Char = value.Chars(value.Length - 1)
			If ch = "h"c OrElse ch = "H"c Then
				Return HexFromString(value)
			End If
			Return DecFromString(value)
		End Function

		Public Function DecFromString(ByVal value As String) As Integer
			If value Is Nothing Then
				Throw New ArgumentNullException("value")
			End If
			If value.Length = 0 Then
				Throw New FormatException("无法将空字符串转换为整数")
			End If

			Dim value2 As Integer = Nothing
			If Not Integer.TryParse(value, value2) Then
				Throw New FormatException("无法将十进制字符串 '" & value & "' 转换为整数")
			End If
			Return value2
		End Function

		Public Function HexFromString(ByVal value As String) As Integer
			If value Is Nothing Then
				Throw New ArgumentNullException("value")
			End If
			If value.Length = 0 Then
				Throw New FormatException("无法将空字符串转换为整数")
			End If

			Dim value2 As Integer = 0
			' 检测状态，0：尚未找到数字、正负符号或"0x"符号；1：正在转换数字；2：数字已结束
			Dim numState As Integer = 0
			Dim neg As Boolean = False
			For i As Integer = 0 To value.Length - 1
				Dim ch As Char = value.Chars(i)
				If Char.IsWhiteSpace(ch) Then
					If numState = 1 Then
						numState = 2
					End If
					Continue For
				End If
				If numState = 2 Then
					Throw New FormatException("无法将十六进制字符串 '" & value & "' 转换为整数")
				End If

				If ch = "+"c OrElse ch = "-"c Then
					If numState <> 0 Then
						Throw New FormatException("无法将十六进制字符串 '" & value & "' 转换为整数")
					End If
					neg = (ch = "-"c)
					numState = 1
					Continue For
				End If

				If (ch = "h"c OrElse ch = "H"c) Then
					If numState <> 1 Then
						Throw New FormatException("无法将十六进制字符串 '" & value & "' 转换为整数")
					End If
					numState = 2
					Continue For
				End If

				If ch >= "0"c AndAlso ch <= "9"c Then
					' 0x or 0X
					If i + 1 < value.Length AndAlso (value.Chars(i + 1) = "x"c OrElse value.Chars(i + 1) = "X"c) Then
						i += 1
						numState = 1
					Else
						value2 = value2 * 16 + AscW(ch) - AscW("0"c)
						numState = 1
					End If
					Continue For
				End If
				If ch >= "A"c AndAlso ch <= "F"c Then
					value2 = value2 * 16 + AscW(ch) - AscW("A"c) + 10
					numState = 1
					Continue For
				End If
				If ch >= "a"c AndAlso ch <= "f"c Then
					value2 = value2 * 16 + AscW(ch) - AscW("a"c) + 10
					numState = 1
					Continue For
				End If
				Throw New FormatException("无法将十六进制字符串 '" & value & "' 转换为整数")
			Next i

			If numState = 0 Then
				Throw New FormatException("无法将十六进制字符串 '" & value & "' 转换为整数")
			End If
			If neg AndAlso value2 <> 0 Then
				value2 *= -1
			End If
			Return value2
		End Function

		Public Function HexArrayToString(ByVal arrData() As Byte) As String
			Return HexArrayToString(arrData, 0, arrData.Length)
		End Function

		Public Function HexArrayToString(ByVal arrData() As Byte, ByVal index As Integer, ByVal len As Integer) As String
			If len = 0 Then
				Return String.Empty
			End If
			If len = 1 Then
				Return arrData(0).ToString("X2")
			End If
			Dim sb As New StringBuilder(len * 3)
			If arrData.Length > 0 Then
				len = index + len - 1
				For i As Integer = index To len - 1
					sb.Append(arrData(i).ToString("X2"))
					sb.Append(" "c)
				Next i
				sb.Append(arrData(len).ToString("X2"))
			End If
			Return sb.ToString()
		End Function

		Public Function HexArrayFromString(ByVal value As String) As Byte()
			If String.IsNullOrEmpty(value) Then
				Return EmptyArray
			End If

			Dim lstHex As New List(Of Byte)(1024)
			HexArrayFromString(value, lstHex)
			Return lstHex.ToArray()
		End Function

		Public Sub HexArrayFromString(ByVal value As String, ByVal lstHex As List(Of Byte))
			' 当前状态
			' ，0 表示当前字节还没数据，等待接收第一个4位数据
			' ，1 表示已经接收第一个4位数据，等待接收第二个4位数据
			Dim iState As Integer = 0
			Dim btCur As Byte = 0, btTmp As Byte = 0
			For Each ch As Char In value
				Select Case iState
					Case 0
						If IsSpec(ch) Then
							Continue For
						End If
						If Not IsHex(ch) Then
							Throw New FormatException("错误的十六进制字符串'" & value & "'")
						End If
						btCur = Char2Hex(ch)
						iState = 1
					Case 1
						If IsSpec(ch) Then
							lstHex.Add(btCur)
							iState = 0
							Continue For
						End If
						If Not IsHex(ch) Then
							Throw New FormatException("错误的十六进制字符串'" & value & "'")
						End If
						btTmp = Char2Hex(ch)
						btCur = CByte((CInt(btCur) << 4) + btTmp)
						lstHex.Add(btCur)
						iState = 0
					Case Else
						Throw New FormatException("错误的十六进制字符串'" & value & "'")
				End Select
			Next ch
			If iState = 1 Then
				lstHex.Add(btCur)
				iState = 0
			End If
		End Sub

		Public Function FormatHexString(ByVal value As String, ByRef pos As Integer) As String
			If String.IsNullOrEmpty(value) Then
				Return String.Empty
			End If

			Dim sb As New StringBuilder()
			Dim pos2 As Integer = pos
			Dim btCur As Byte = 0
			Dim i As Integer = 0
			Dim l As Integer = 0
			Dim k As Integer = 0
			Do While i < value.Length
				Dim ch As Char = value.Chars(i)
				If IsSpec(ch) Then
					If l = 0 Then
						k = i + 1
						i += 1
						Continue Do
					End If
				Else
					l += 1
					If l < 3 Then
						i += 1
						Continue Do
					End If
				End If

				If l = 1 Then
					btCur = Char2Hex(value.Chars(k))
					sb.Append(btCur.ToString("X"))
					sb.Append(" "c)

					If i >= pos2 Then
						pos = sb.Length - 1
						pos2 = Integer.MaxValue
					End If
				ElseIf l = 2 Then
					btCur = Char2Hex(value.Chars(k))
					btCur = CByte((CInt(btCur) << 4) + Char2Hex(value.Chars(k + 1)))
					sb.Append(btCur.ToString("X2"))
					sb.Append(" "c)

					If i >= pos2 Then
						pos = sb.Length - 1
						pos2 = Integer.MaxValue
					End If
				Else
					If i = pos2 + 1 Then
						btCur = Char2Hex(value.Chars(k))
						sb.Append(btCur.ToString("X"))
						sb.Append(" "c)
						btCur = Char2Hex(value.Chars(k + 1))
						btCur = CByte((CInt(btCur) << 4) + Char2Hex(value.Chars(k + 2)))
						sb.Append(btCur.ToString("X2"))
						sb.Append(" "c)

						pos = sb.Length - 4
						pos2 = Integer.MaxValue
					ElseIf i = pos2 Then
						btCur = Char2Hex(value.Chars(k))
						btCur = CByte((CInt(btCur) << 4) + Char2Hex(value.Chars(k + 1)))
						sb.Append(btCur.ToString("X2"))
						sb.Append(" "c)
						btCur = Char2Hex(value.Chars(k + 2))
						sb.Append(btCur.ToString("X"))
						sb.Append(" "c)

						pos = sb.Length - 2
						pos2 = Integer.MaxValue
					ElseIf i + 1 = pos2 Then
						btCur = Char2Hex(value.Chars(k))
						btCur = CByte((CInt(btCur) << 4) + Char2Hex(value.Chars(k + 1)))
						sb.Append(btCur.ToString("X2"))
						sb.Append(" "c)
						btCur = Char2Hex(value.Chars(k + 2))
						sb.Append(btCur.ToString("X"))
						sb.Append(" "c)

						pos = sb.Length - 1
						pos2 = Integer.MaxValue
					Else
						btCur = Char2Hex(value.Chars(k))
						btCur = CByte((CInt(btCur) << 4) + Char2Hex(value.Chars(k + 1)))
						sb.Append(btCur.ToString("X2"))
						sb.Append(" "c)
						i -= 1
					End If
				End If
				l = 0
				k = i + 1
				i += 1
			Loop
			If l > 0 Then
				If l = 1 Then
					btCur = Char2Hex(value.Chars(k))
					sb.Append(btCur.ToString("X"))
					sb.Append(" "c)

					If i >= pos2 Then
						pos = sb.Length - 1
						pos2 = Integer.MaxValue
					End If
				ElseIf l = 2 Then
					btCur = Char2Hex(value.Chars(k))
					btCur = CByte((CInt(btCur) << 4) + Char2Hex(value.Chars(k + 1)))
					sb.Append(btCur.ToString("X2"))
					sb.Append(" "c)

					If i >= pos2 Then
						pos = sb.Length - 1
						pos2 = Integer.MaxValue
					End If
				End If
			ElseIf sb.Length > 0 Then
				sb.Length -= 1
			End If
			Return sb.ToString()
		End Function

		Private Function Char2Hex(ByVal ch As Char) As Byte
			Dim btHex As Byte = 0
			If ch >= "0"c AndAlso ch <= "9"c Then
				btHex = CByte(Math.Truncate(AscW(ch) - AscW("0"c)))
			ElseIf ch >= "A"c AndAlso ch <= "Z"c Then
				btHex = CByte(Math.Truncate(AscW(ch) - AscW("A"c) + 10))
			ElseIf ch >= "a"c AndAlso ch <= "z"c Then
				btHex = CByte(Math.Truncate(AscW(ch) - AscW("a"c) + 10))
			End If
			Return btHex
		End Function

		Private Function IsHex(ByVal ch As Char) As Boolean
			Return (ch >= "0"c AndAlso ch <= "9"c) OrElse (ch >= "A"c AndAlso ch <= "F"c) OrElse (ch >= "a"c AndAlso ch <= "f"c)
		End Function

		Private Function IsSpec(ByVal ch As Char) As Boolean
			Return (ch = " "c OrElse ch = ControlChars.Tab OrElse ch = ControlChars.Cr OrElse ch = ControlChars.Lf)
		End Function

		Public Function CalcCrc16(ByVal pbtBuf() As Byte, ByVal pos As Integer, ByVal len As Integer) As UShort
			Dim wCrc As UShort = 0

			For i As Integer = 0 To len - 1
				wCrc = CUShort((CInt(wCrc) << 8) Xor g_pwCrc16Table(((CInt(wCrc) >> 8) Xor pbtBuf(pos + i))))
			Next i
			Return wCrc
		End Function
	End Module


	Friend Class API
		<DllImport("UHFPrimeReader.dll", CharSet := CharSet.Ansi)>
		Public Shared Function OpenDevice(<System.Runtime.InteropServices.Out()> ByRef m_hPort As IntPtr, ByVal strComPort As String, ByVal Baudrate As Byte) As Integer
		End Function

		<DllImport("UHFPrimeReader.dll", CharSet := CharSet.Ansi)>
		Public Shared Function OpenNetConnection(<System.Runtime.InteropServices.Out()> ByRef handler As IntPtr, ByVal ip As String, ByVal port As UShort, ByVal timeoutMs As UInteger) As Integer
		End Function

		<DllImport("UHFPrimeReader.dll", CharSet := CharSet.Ansi)>
		Public Shared Function OpenHidConnection(<System.Runtime.InteropServices.Out()> ByRef handler As IntPtr, ByVal index As UShort) As Integer
		End Function

		<DllImport("UHFPrimeReader.dll")>
		Public Shared Function CFHid_GetUsbCount() As Integer
		End Function

		<DllImport("UHFPrimeReader.dll")>
		Public Shared Function CFHid_GetUsbInfo(ByVal iIndex As UInt16, ByVal pucDeviceInfo() As Byte) As Boolean
		End Function


		<DllImport("UHFPrimeReader.dll")>
		Public Shared Function CloseDevice(ByVal m_hPort As IntPtr) As Integer
		End Function

		<DllImport("UHFPrimeReader.dll")>
		Public Shared Function GetDevicePara(ByVal m_hPort As IntPtr, <System.Runtime.InteropServices.Out()> ByRef devInfo As Devicepara) As Integer
		End Function

		<DllImport("UHFPrimeReader.dll")>
		Public Shared Function SetDevicePara(ByVal m_hPort As IntPtr, ByVal devInfo As Devicepara) As Integer
		End Function


		<DllImport("UHFPrimeReader.dll")>
		Public Shared Function SetRFPower(ByVal hComm As IntPtr, ByVal power As Byte, ByVal reserved As Byte) As Integer
		End Function


		<DllImport("UHFPrimeReader.dll")>
		Public Shared Function InventoryContinue(ByVal hComm As IntPtr, ByVal invCount As Byte, ByVal invParam As UInteger) As Integer
		End Function

		<DllImport("UHFPrimeReader.dll")>
		Public Shared Function GetTagUii(ByVal hComm As IntPtr, <System.Runtime.InteropServices.Out()> ByRef tag_info As TagInfo, ByVal timeout As UShort) As Integer
		End Function

		<DllImport("UHFPrimeReader.dll")>
		Public Shared Function InventoryStop(ByVal hComm As IntPtr, ByVal timeout As UShort) As Integer
		End Function

		<DllImport("UHFPrimeReader.dll")>
		Public Shared Function Release_Relay(ByVal hComm As IntPtr, ByVal time As Byte) As Integer
		End Function

		<DllImport("UHFPrimeReader.dll")>
		Public Shared Function Close_Relay(ByVal hComm As IntPtr, ByVal time As Byte) As Integer
		End Function

	End Class

	Public Class Reader
		Private Shared ReadOnly s_arrEmpty(-1) As Byte

		' reader handel
		Private m_handler As IntPtr = IntPtr.Zero

		' reader open status，0：close；1：open by serial；2：open by net
'INSTANT VB TODO TASK: There is no VB equivalent to 'volatile':
'ORIGINAL LINE: volatile int m_iState = 0;
		Private m_iState As Integer = 0
		Private m_usbindex As UShort = 0

		Private m_ip As String = String.Empty
		Private m_netPort As UShort = 0
		Private m_sport As String = String.Empty




		Private Shared s_reader As Reader = Nothing

		Public ReadOnly Property IsOpened() As Boolean
			Get
				Return m_iState <> 0
			End Get
		End Property

		Public ReadOnly Property IsOpenedAsCom() As Boolean
			Get
				Return m_iState = 1
			End Get
		End Property

		Public ReadOnly Property IsOpenedAsNetwork() As Boolean
			Get
				Return m_iState = 2
			End Get
		End Property

		Public ReadOnly Property IPAddress() As String
			Get
				Return m_ip
			End Get
		End Property

		Public ReadOnly Property NetPort() As UShort
			Get
				Return m_netPort
			End Get
		End Property

		Public ReadOnly Property PortName() As String
			Get
				Return m_sport
			End Get
		End Property

		Public Sub Open(ByVal port As String, ByVal Baudrate As Byte)
			If port Is Nothing Then
				Throw New ArgumentNullException("port(Serial)")
			End If
			port = port.Trim()
			If port.Length = 0 Then
				Throw New ArgumentException("please input serial", "port(serial)")
			End If
			If m_iState <> 0 Then
				Throw New InvalidOperationException("reader is already opened")
			End If

			If m_handler <> IntPtr.Zero Then
				Try
					API.CloseDevice(m_handler)
				Catch
				End Try
				m_handler = IntPtr.Zero
				s_reader = Nothing
			End If
			Dim state As Integer = API.OpenDevice(m_handler, port, Baudrate)
			If state <> ReaderException.ERROR_SUCCESS Then
				m_handler = IntPtr.Zero
				s_reader = Nothing
				Throw New IOException("serial '" & port & "' open fail")
			End If
			s_reader = Me
			m_sport = port
			m_iState = 1
		End Sub

		Public Sub Open(ByVal ip As String, ByVal port As UShort, ByVal timeoutMs As UInteger, ByVal throwExcpOnTimeout As Boolean)
			If ip Is Nothing Then
				Throw New ArgumentNullException("ip(addr)")
			End If
			ip = ip.Trim()
			If ip.Length = 0 Then
				Throw New ArgumentException("please input IP addr", "ip(addr)")
			End If
			If port = 0 Then
				Throw New ArgumentException("port can not be 0", "port(port )")
			End If
			If m_iState <> 0 Then
				Throw New InvalidOperationException("reader is already opened")
			End If

			If m_handler <> IntPtr.Zero Then
				Try
					API.CloseDevice(m_handler)
				Catch
				End Try
				m_handler = IntPtr.Zero
				s_reader = Nothing
			End If

			Dim state As Integer = API.OpenNetConnection(m_handler, ip, port, timeoutMs)
			If state <> ReaderException.ERROR_SUCCESS Then
				m_handler = IntPtr.Zero
				s_reader = Nothing
				If state = ReaderException.ERROR_CMD_COMM_TIMEOUT AndAlso Not throwExcpOnTimeout Then
					Return
				End If
				Throw New IOException("IP'" & ip & "' port " & port & " connecting fail")
			End If
			s_reader = Me
			m_ip = ip
			m_netPort = port
			m_iState = 2
		End Sub

		Public Sub Open(ByVal index As UShort)
			If m_iState <> 0 Then
				Throw New InvalidOperationException("Reader is already open")
			End If

			If m_handler <> IntPtr.Zero Then
				Try
					API.CloseDevice(m_handler)
				Catch
				End Try
				m_handler = IntPtr.Zero
				s_reader = Nothing
			End If

			Dim state As Integer = API.OpenHidConnection(m_handler, index)
			If state <> ReaderException.ERROR_SUCCESS Then
				m_handler = IntPtr.Zero
				s_reader = Nothing
				If state = ReaderException.ERROR_CMD_COMM_TIMEOUT Then
					Return
				End If
			End If
			s_reader = Me
			m_usbindex = index
			m_iState = 3
		End Sub




		Public Sub Close()
			If m_handler <> IntPtr.Zero Then
				Try
					API.CloseDevice(m_handler)
				Catch
				End Try
				m_handler = IntPtr.Zero
				s_reader = Nothing
			End If
			m_iState = 0
		End Sub


		' 0:未找到设备
		' 1:一个设备
		Public Function CFHid_GetUsbCount() As Integer
			Dim count As Integer = API.CFHid_GetUsbCount()
			Return count
		End Function

		Public Function CFHid_GetUsbInfo(ByVal iIndex As UInt16, ByVal pucDeviceInfo() As Byte) As Boolean
			Dim jet As Boolean = API.CFHid_GetUsbInfo(iIndex, pucDeviceInfo)
			Return jet
		End Function



		Public Function GetDevicePara() As Devicepara
			If m_iState = 0 Then
				Throw New InvalidOperationException("Reader is not open")
			End If
			Dim info As Devicepara = Nothing
			'DegbugPrint("Start GetVer");
			Dim state As Integer = API.GetDevicePara(m_handler, info)
			'DegbugPrint("End GetVer");
			If state = ReaderException.ERROR_SUCCESS Then
				Return info
			End If
			Throw New ReaderException(state)
		End Function

		Public Sub SetDevicePara(ByVal info As Devicepara)
			If m_iState = 0 Then
				Throw New InvalidOperationException("Reader is not open")
			End If
			'DegbugPrint("Start GetVer");
			Dim state As Integer = API.SetDevicePara(m_handler, info)
			'DegbugPrint("End GetVer");
			If state = ReaderException.ERROR_SUCCESS Then
				Return
			End If
			Throw New ReaderException(state)
		End Sub

		Public Sub SetRfTxPower(ByVal txPower As Byte, ByVal reserved As Byte)
			If m_iState = 0 Then
				Throw New InvalidOperationException("Reader is not open")
			End If

			Dim state As Integer = API.SetRFPower(m_handler, txPower, reserved)
			If state = ReaderException.ERROR_SUCCESS Then
				Return
			End If
			Throw New ReaderException(state)
		End Sub



		Public Sub Release_Relay(ByVal time As Byte)
			If m_iState = 0 Then
				Throw New InvalidOperationException("Reader is not open")
			End If

			Dim state As Integer = API.Release_Relay(m_handler,time)
			If state = ReaderException.ERROR_SUCCESS Then
				Return
			End If
			Throw New ReaderException(state)
		End Sub


		Public Sub Close_Relay(ByVal time As Byte)
			If m_iState = 0 Then
				Throw New InvalidOperationException("Reader is not open")
			End If

			Dim state As Integer = API.Close_Relay(m_handler, time)
			If state = ReaderException.ERROR_SUCCESS Then
				Return
			End If
			Throw New ReaderException(state)
		End Sub




		Public Sub Inventory(ByVal invCount As Byte, ByVal invParam As UInteger)
			If m_iState = 0 Then
				Throw New InvalidOperationException("Reader is not open")
			End If

			Dim state As Integer = API.InventoryContinue(m_handler, invCount, invParam)
			If state = ReaderException.ERROR_SUCCESS Then
				Return
			End If
			Throw New ReaderException(state)
		End Sub



		Public Sub InventoryStop(ByVal timeoutMs As UShort)
			If m_iState = 0 Then
				Throw New InvalidOperationException("Reader is not open")
			End If

			Dim state As Integer = API.InventoryStop(m_handler, timeoutMs)
			If state = ReaderException.ERROR_SUCCESS Then
				Return
			End If
			Throw New ReaderException(state)
		End Sub

		Public Function GetTagUii(ByVal timeoutMs As UShort) As TagItem
			If m_iState = 0 Then
				Throw New InvalidOperationException("Reader is not open")
			End If

			Dim info As TagInfo = Nothing
			Dim state As Integer = API.GetTagUii(m_handler, info, timeoutMs)
			If state = ReaderException.ERROR_CMD_NO_TAG Then
				Return Nothing
			End If
			If state = ReaderException.ERROR_SUCCESS Then
				Return New TagItem(info)
			End If
			Throw New ReaderException(state)
		End Function




		Private Shared ReadOnly PRESET_VALUE As UShort = &HFFFF
		Private Shared ReadOnly POLYNOMIAL As UShort = &H8408

'INSTANT VB TODO TASK: C# 'unsafe' code is not converted by Instant VB:
'		public unsafe ushort Crc16Cal(byte[] pucY, ushort ucX,ushort CrcValue)
'		{
'			ushort ucI, ucJ;
'			ushort uiCrcValue;
'			if (CrcValue == &HFFFF) ' first value
'			{
'				uiCrcValue = PRESET_VALUE;
'			}
'			else
'			{
'				uiCrcValue = CrcValue;
'			}
'			for (ucI = 1; ucI<ucX; ucI++)
'			{
'				uiCrcValue = (ushort)(uiCrcValue ^ pucY[ucI]);
'				for (ucJ = 0; ucJ< 8; ucJ++)
'				{
'					if ((uiCrcValue & &H1) != 0)
'					{
'						uiCrcValue = (ushort)((uiCrcValue >> 1) ^ POLYNOMIAL);
'					}
'					else
'					{
'						uiCrcValue = (ushort)(uiCrcValue >> 1);
'					}
'				}
'			}
'			Return uiCrcValue;
'		}

	End Class
End Namespace
