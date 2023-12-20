Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Windows.Forms

Namespace WindowsFormsApp1
	''' <summary>
	''' 盘点到的标签项
	''' </summary>
	Public Class TagItem
		Private Shared ReadOnly s_arrEmpty(-1) As Byte

		''' <summary>
		''' 标签序号
		''' </summary>
		Private m_no As UShort
		''' <summary>
		''' 标签的PC或编码长度+编码头数据
		''' </summary>
		Private m_pc() As Byte
		''' <summary>
		''' 标签的UII或编码数据
		''' </summary>
		Private m_code() As Byte
		''' <summary>
		''' RSSI，单位：0.1dBm
		''' </summary>
		Private m_rssi As Short
		''' <summary>
		''' 天线索引
		''' </summary>
		Private m_ant As Byte
		''' <summary>
		''' 信道
		''' </summary>
		Private m_channel As Byte
		''' <summary>
		''' CRC
		''' </summary>
		Private m_crc() As Byte
		''' <summary>
		''' codelengh
		''' </summary>
		Private m_len As Byte

		''' <summary>
		''' 标签序号
		''' </summary>
		Public ReadOnly Property NO() As UShort
			Get
				Return m_no
			End Get
		End Property

		''' <summary>
		''' 标签的PC或编码长度+编码头数据
		''' </summary>
		Public ReadOnly Property PC() As Byte()
			Get
				Return m_pc
			End Get
		End Property

		''' <summary>
		''' 标签的UII或编码数据
		''' </summary>
		Public ReadOnly Property Code() As Byte()
			Get
				Return m_code
			End Get
		End Property

		''' <summary>
		''' RSSI，单位：0.1dBm
		''' </summary>
		Public ReadOnly Property Rssi() As Short
			Get
				Return m_rssi
			End Get
		End Property

		''' <summary>
		''' 天线接口序号
		''' </summary>
		Public ReadOnly Property Antenna() As Byte
			Get
				Return m_ant
			End Get
		End Property

		''' <summary>
		''' 信道
		''' </summary>
		Public ReadOnly Property Channel() As Byte
			Get
				Return m_channel
			End Get
		End Property

		''' <summary>
		''' CRC
		''' </summary>
		Public ReadOnly Property CRC() As Byte()
			Get
				Return m_crc
			End Get
		End Property

		''' <summary>
		''' len
		''' </summary>
		Public ReadOnly Property LEN() As Byte
			Get
				Return m_len
			End Get
		End Property

'INSTANT VB NOTE: The variable no was renamed since Visual Basic does not handle local variables named the same as class members well:
'INSTANT VB NOTE: The variable pc was renamed since Visual Basic does not handle local variables named the same as class members well:
'INSTANT VB NOTE: The variable code was renamed since Visual Basic does not handle local variables named the same as class members well:
'INSTANT VB NOTE: The variable rssi was renamed since Visual Basic does not handle local variables named the same as class members well:
'INSTANT VB NOTE: The variable channel was renamed since Visual Basic does not handle local variables named the same as class members well:
'INSTANT VB NOTE: The variable crc was renamed since Visual Basic does not handle local variables named the same as class members well:
'INSTANT VB NOTE: The variable len was renamed since Visual Basic does not handle local variables named the same as class members well:
		Public Sub New(ByVal no_Conflict As UShort, ByVal pc_Conflict() As Byte, ByVal codeLen As Byte, ByVal code_Conflict() As Byte, ByVal rssi_Conflict As Short, ByVal ant As Byte, ByVal channel_Conflict As Byte, ByVal crc_Conflict() As Byte, ByVal len_Conflict As Byte)
			If pc_Conflict Is Nothing Then
				Throw New ArgumentNullException("pc")
			End If
			If crc_Conflict Is Nothing Then
				Throw New ArgumentNullException("crc")
			End If
			If pc_Conflict.Length <> 2 Then
				Throw New ArgumentException("PC must be 2 Byte")
			End If
			If codeLen > 0 AndAlso code_Conflict Is Nothing Then
				Throw New ArgumentNullException("code")
			End If
			If codeLen > code_Conflict.Length Then
				Throw New ArgumentOutOfRangeException("codeLen", "codelen is over")
			End If

			m_no = no_Conflict
			m_pc = pc_Conflict
			m_rssi = rssi_Conflict
			m_ant = ant
			m_channel = channel_Conflict
			m_crc = crc_Conflict
			m_len = len_Conflict
			If codeLen > 0 Then
				m_code = New Byte(codeLen - 1){}
				Array.Copy(code_Conflict, m_code, codeLen)
			Else
				m_code = s_arrEmpty
			End If
		End Sub

		Friend Sub New(ByVal info As TagInfo)
			'if (info.PC == null)
			'    throw new ArgumentNullException("pc");
			'if (info.CRC == null)
			'    throw new ArgumentNullException("crc");
			'if (info.PC.Length != 2)
			'    throw new ArgumentException("PC must be 2 Byte");
			Dim codeLen As Byte = info.CodeLength
			If codeLen > 0 AndAlso info.Code Is Nothing Then
				Throw New ArgumentNullException("code")
			End If
			If codeLen > info.Code.Length Then
				Throw New ArgumentOutOfRangeException("codeLen", "codelen is over")
			End If

			'm_no = info.NO;
			'm_pc = info.PC;
			m_len = info.CodeLength ' 数据长度
			m_rssi = info.Rssi
			m_ant = info.Antenna
			m_channel = info.Channel
			'm_crc = info.CRC;
			If codeLen > 0 Then
				m_code = New Byte(codeLen - 1){}
				Array.Copy(info.Code, m_code, codeLen)
			Else
				m_code = s_arrEmpty
			End If
		End Sub

		Public Overrides Function GetHashCode() As Integer
			Dim hash As Integer = add(0, m_pc)
			hash = add(hash, m_crc)
			hash = add(hash, m_code)
			Return hash
		End Function

		Public Overrides Function Equals(ByVal obj As Object) As Boolean
			Dim item As TagItem = TryCast(obj, TagItem)
			If item Is Nothing Then
				Return False
			End If
			Return compare(m_crc, item.m_crc) AndAlso compare(m_code, item.m_code) AndAlso compare(m_pc, item.m_pc)
		End Function

		Private Function compare(ByVal a() As Byte, ByVal b() As Byte) As Boolean
			If a.Length <> b.Length Then
				Return False
			End If
			For i As Integer = 0 To a.Length - 1
				If a(i) <> b(i) Then
					Return False
				End If
			Next i
			Return True
		End Function

		Private Function add(ByVal hash As Integer, ByVal data() As Byte) As Integer
			For i As Integer = 0 To data.Length - 1
				If (hash And &H80000000UI) <> 0 Then
					hash = (hash << 1) + 1
				Else
					hash <<= 1
				End If
			Next i
			Return hash
		End Function
	End Class


	''' <summary>
	''' 盘点到的标签项
	''' </summary>
	Public Class ShowTagItem
		Private Shared ReadOnly s_arrEmpty(-1) As Byte

		''' <summary>
		''' 被盘点到的次数，每个天线分别统计
		''' </summary>
		Private m_counts() As Integer

		''' <summary>
		''' 标签序号
		''' </summary>
		Private m_no As UShort
		''' <summary>
		''' 标签的PC或编码长度+编码头数据
		''' </summary>
		Private m_pc() As Byte
		''' <summary>
		''' 标签的UII或编码数据
		''' </summary>
		Private m_code() As Byte
		''' <summary>
		''' RSSI，单位：0.1dBm
		''' </summary>
		Private m_rssi As Short
		''' <summary>
		''' 信道，值范围：1~4
		''' </summary>
		Private m_channel As Byte
		''' <summary>
		''' CRC
		''' </summary>
		Private m_crc() As Byte
		''' <summary>
		''' codelength
		''' </summary>
		Private m_len As Byte

		''' <summary>
		''' 标签序号
		''' </summary>
		Public ReadOnly Property NO() As UShort
			Get
				Return m_no
			End Get
		End Property

		''' <summary>
		''' 标签的PC或编码长度+编码头数据
		''' </summary>
		Public ReadOnly Property PC() As Byte()
			Get
				Return m_pc
			End Get
		End Property

		''' <summary>
		''' 标签的UII或编码数据
		''' </summary>
		Public ReadOnly Property Code() As Byte()
			Get
				Return m_code
			End Get
		End Property

		''' <summary>
		''' RSSI，单位：0.1dBm
		''' </summary>
		Public ReadOnly Property Rssi() As Short
			Get
				Return m_rssi
			End Get
		End Property

		''' <summary>
		''' 信道
		''' </summary>
		Public ReadOnly Property Channel() As Byte
			Get
				Return m_channel
			End Get
		End Property

		''' <summary>
		''' CRC
		''' </summary>
		Public ReadOnly Property CRC() As Byte()
			Get
				Return m_crc
			End Get
		End Property

		''' <summary>
		''' LEN
		''' </summary>
		Public ReadOnly Property LEN() As Byte
			Get
				Return m_len
			End Get
		End Property

		''' <summary>
		''' 被盘点到的次数
		''' </summary>
		Public ReadOnly Property Counts() As Integer()
			Get
				Return m_counts
			End Get
		End Property

		Public Sub New(ByVal item As TagItem)
			If item.Code Is Nothing Then
				Throw New ArgumentNullException("item.Code")
			End If
			If item.Antenna = 0 OrElse item.Antenna > 4 Then
				Throw New ArgumentOutOfRangeException("item.Antenna")
			End If

			m_counts = New Integer(3){}
			m_counts(item.Antenna - 1) = 1
			m_no = item.NO
			m_pc = item.PC
			m_code = item.Code
			m_rssi = item.Rssi
			m_channel = item.Channel
			m_crc = item.CRC
			m_len = item.LEN
		End Sub

'INSTANT VB NOTE: The variable no was renamed since Visual Basic does not handle local variables named the same as class members well:
'INSTANT VB NOTE: The variable pc was renamed since Visual Basic does not handle local variables named the same as class members well:
'INSTANT VB NOTE: The variable code was renamed since Visual Basic does not handle local variables named the same as class members well:
'INSTANT VB NOTE: The variable rssi was renamed since Visual Basic does not handle local variables named the same as class members well:
'INSTANT VB NOTE: The variable channel was renamed since Visual Basic does not handle local variables named the same as class members well:
'INSTANT VB NOTE: The variable crc was renamed since Visual Basic does not handle local variables named the same as class members well:
'INSTANT VB NOTE: The variable len was renamed since Visual Basic does not handle local variables named the same as class members well:
		Public Sub New(ByVal no_Conflict As UShort, ByVal pc_Conflict() As Byte, ByVal code_Conflict() As Byte, ByVal rssi_Conflict As Short, ByVal ant As Byte, ByVal channel_Conflict As Byte, ByVal crc_Conflict() As Byte, ByVal len_Conflict As Byte)
			If pc_Conflict Is Nothing Then
				Throw New ArgumentNullException("pc")
			End If
			If pc_Conflict.Length <> 2 Then
				Throw New ArgumentException("PC must be 2 Byte")
			End If
			If code_Conflict Is Nothing Then
				Throw New ArgumentNullException("code")
			End If
			If ant = 0 OrElse ant > 4 Then
				Throw New ArgumentOutOfRangeException("channel")
			End If

			m_counts = New Integer(3){}
			m_counts(ant - 1) = 1
			m_no = no_Conflict
			m_rssi = rssi_Conflict
			m_channel = channel_Conflict
			m_crc = crc_Conflict
			m_code = code_Conflict
			m_len = len_Conflict
		End Sub

		''' <summary>
		''' 获取被盘点到的次数
		''' </summary>
		''' <returns></returns>
		Public Function CountsToString() As String
			Dim sb As New StringBuilder(64)
			For i As Integer = 0 To m_counts.Length - 1
				sb.Append(m_counts(i))
				sb.Append("/"c)
			Next i
			sb.Length -= 1
			Return sb.ToString()
		End Function

		Public Sub IncCount(ByVal item As TagItem)
			If item.Antenna > 0 AndAlso item.Antenna <= 4 Then
				m_counts(item.Antenna - 1) += 1
			End If

			m_no = item.NO
			m_pc = item.PC
			m_code = item.Code
			m_rssi = item.Rssi
			m_channel = item.Channel
			m_crc = item.CRC
			m_len = item.LEN
		End Sub

'INSTANT VB NOTE: The variable code was renamed since Visual Basic does not handle local variables named the same as class members well:
		Public Function CompareCode(ByVal code_Conflict() As Byte) As Boolean
			If code_Conflict Is Nothing Then
				Return False
			End If
			If m_code Is code_Conflict Then
				Return True
			End If
			If m_code.Length <> code_Conflict.Length Then
				Return False
			End If
			For i As Integer = 0 To code_Conflict.Length - 1
				If m_code(i) <> code_Conflict(i) Then
					Return False
				End If
			Next i
			Return True
		End Function

		Public Overrides Function ToString() As String
			Return Util.HexArrayToString(m_code)
		End Function
	End Class

	Friend Class TagCodeCompare
        Implements IEqualityComparer(Of Byte())

        '      Public Function Equals(ByVal x() As Byte, ByVal y() As Byte) As Boolean
        '          If x Is y Then
        '              Return True
        '          End If
        '          If x Is Nothing OrElse y Is Nothing Then
        '              Return False
        '          End If

        '          If x.Length <> y.Length Then
        '              Return False
        '          End If
        '          For i As Integer = 0 To x.Length - 1
        '              If x(i) <> y(i) Then
        '                  Return False
        '              End If
        '          Next i
        '          Return True
        '      End Function

        '      Public Function GetHashCode(ByVal obj() As Byte) As Integer
        '	If obj Is Nothing Then
        '		Return 0
        '	End If
        '	If obj.Length = 0 Then
        '		Return 0
        '	End If
        '	Dim hash As Integer = 17
        '	For i As Integer = 0 To obj.Length - 1
        '		hash = (hash << 1) + obj(i)
        '	Next i
        '	Return hash
        'End Function

        Private Function IEqualityComparer_Equals(x() As Byte, y() As Byte) As Boolean Implements IEqualityComparer(Of Byte()).Equals
            If x Is y Then
                Return True
            End If
            If x Is Nothing OrElse y Is Nothing Then
                Return False
            End If

            If x.Length <> y.Length Then
                Return False
            End If
            For i As Integer = 0 To x.Length - 1
                If x(i) <> y(i) Then
                    Return False
                End If
            Next i
            Return True
        End Function

        Private Function IEqualityComparer_GetHashCode(obj() As Byte) As Integer Implements IEqualityComparer(Of Byte()).GetHashCode
            If obj Is Nothing Then
                Return 0
            End If
            If obj.Length = 0 Then
                Return 0
            End If
            Dim hash As Integer = 17
            For i As Integer = 0 To obj.Length - 1
                hash = (hash << 1) + obj(i)
            Next i
            Return hash
        End Function
    End Class
End Namespace
