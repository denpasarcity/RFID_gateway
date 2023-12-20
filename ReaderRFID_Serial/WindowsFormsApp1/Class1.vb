Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Runtime.InteropServices

Namespace WindowsFormsApp1

		<StructLayout(LayoutKind.Sequential)>
		Public Structure TagInfo
			''' <summary>
			''' 标签序号
			''' </summary>
			Private m_no As UShort
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
			<MarshalAs(UnmanagedType.ByValArray, SizeConst := 2)>
			Private m_crc() As Byte
			''' <summary>
			''' 标签的PC或编码长度+编码头数据
			''' </summary>
			<MarshalAs(UnmanagedType.ByValArray, SizeConst := 2)>
			Private m_pc() As Byte
			''' <summary>
			''' code中有效数据的长度
			''' </summary>
			Private m_len As Byte
			''' <summary>
			''' 标签的响应数据，长度255个byte
			''' </summary>
			<MarshalAs(UnmanagedType.ByValArray, SizeConst := 255)>
			Private m_code() As Byte

			''' <summary>
			''' 标签序号
			''' </summary>
			Public ReadOnly Property NO() As UShort
				Get
					Return m_no
				End Get
			End Property

			''' <summary>
			''' 标签的PC或编码长度+编码头数据，长度2个byte
			''' </summary>
			Public ReadOnly Property PC() As Byte()
				Get
					Return m_pc
				End Get
			End Property

			''' <summary>
			''' code中有效数据的长度
			''' </summary>
			Public ReadOnly Property CodeLength() As Byte
				Get
					Return m_len
				End Get
			End Property

			''' <summary>
			''' 标签的响应数据，长度255个byte
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

		End Structure


		''' <summary>
		''' 设备参数
		''' </summary>
		<StructLayout(LayoutKind.Sequential)>
		Public Structure Devicepara

			Private DEVICEARRD As Byte
			Private RFIDPRO As Byte
'INSTANT VB NOTE: The field WORKMODE was renamed since Visual Basic does not allow fields to have the same name as other class members:
			Private WORKMODE_Conflict As Byte
			Private [INTERFACE] As Byte
			Private BAUDRATE As Byte
			Private WGSET As Byte
'INSTANT VB NOTE: The field ANT was renamed since Visual Basic does not allow fields to have the same name as other class members:
			Private ANT_Conflict As Byte
'INSTANT VB NOTE: The field REGION was renamed since Visual Basic does not allow fields to have the same name as other class members:
			Private REGION_Conflict As Byte
			Private STRATFREI As UShort
			Private STRATFRED As UShort
			Private STEPFRE As UShort
			Private CN As Byte
			Private RFIDPOWER As Byte
			Private INVENTORYAREA As Byte
			Private QVALUE As Byte
'INSTANT VB NOTE: The field SESSION was renamed since Visual Basic does not allow fields to have the same name as other class members:
			Private SESSION_Conflict As Byte
			Private ACSADDR As Byte
			Private ACSDATALEN As Byte
'INSTANT VB NOTE: The field FILTERTIME was renamed since Visual Basic does not allow fields to have the same name as other class members:
			Private FILTERTIME_Conflict As Byte
'INSTANT VB NOTE: The field TRIGGLETIME was renamed since Visual Basic does not allow fields to have the same name as other class members:
			Private TRIGGLETIME_Conflict As Byte
'INSTANT VB NOTE: The field BUZZERTIME was renamed since Visual Basic does not allow fields to have the same name as other class members:
			Private BUZZERTIME_Conflict As Byte
			Private INTERNELTIME As Byte
			Public Property Addr() As Byte
				Get
					Return DEVICEARRD
				End Get
				Set(ByVal value As Byte)
					DEVICEARRD = value
				End Set
			End Property
			Public Property Protocol() As Byte
				Get
					Return RFIDPRO
				End Get
				Set(ByVal value As Byte)
					RFIDPRO = value
				End Set
			End Property
			Public Property Baud() As Byte
				Get
					Return BAUDRATE
				End Get
				Set(ByVal value As Byte)
					BAUDRATE = value
				End Set
			End Property
			Public Property Workmode() As Byte
				Get
					Return WORKMODE_Conflict
				End Get
				Set(ByVal value As Byte)
					WORKMODE_Conflict = value
				End Set
			End Property
			Public Property port() As Byte
				Get
					Return [INTERFACE]
				End Get
				Set(ByVal value As Byte)
					[INTERFACE] = value
				End Set
			End Property
			Public Property wieggand() As Byte
				Get
					Return WGSET
				End Get
				Set(ByVal value As Byte)
					WGSET = value
				End Set
			End Property
			Public Property Ant() As Byte
				Get
					Return ANT_Conflict
				End Get
				Set(ByVal value As Byte)
					ANT_Conflict = value
				End Set
			End Property
			Public Property Region() As Byte
				Get
					Return REGION_Conflict
				End Get
				Set(ByVal value As Byte)
					REGION_Conflict = value
				End Set
			End Property
			Public Property Channel() As Byte
				Get
					Return CN
				End Get
				Set(ByVal value As Byte)
					CN = value
				End Set
			End Property
			Public Property Power() As Byte
				Get
					Return RFIDPOWER
				End Get
				Set(ByVal value As Byte)
					RFIDPOWER = value
				End Set
			End Property
			Public Property Area() As Byte
				Get
					Return INVENTORYAREA
				End Get
				Set(ByVal value As Byte)
					INVENTORYAREA = value
				End Set
			End Property
			Public Property Q() As Byte
				Get
					Return QVALUE
				End Get
				Set(ByVal value As Byte)
					QVALUE = value
				End Set
			End Property
			Public Property Session() As Byte
				Get
					Return SESSION_Conflict
				End Get
				Set(ByVal value As Byte)
					SESSION_Conflict = value
				End Set
			End Property
			Public Property Startaddr() As Byte
				Get
					Return ACSADDR
				End Get
				Set(ByVal value As Byte)
					ACSADDR = value
				End Set
			End Property
			Public Property DataLen() As Byte
				Get
					Return ACSDATALEN
				End Get
				Set(ByVal value As Byte)
					ACSDATALEN = value
				End Set
			End Property
			Public Property Filtertime() As Byte
				Get
					Return FILTERTIME_Conflict
				End Get
				Set(ByVal value As Byte)
					FILTERTIME_Conflict = value
				End Set
			End Property
			Public Property Triggletime() As Byte
				Get
					Return TRIGGLETIME_Conflict
				End Get
				Set(ByVal value As Byte)
					TRIGGLETIME_Conflict = value
				End Set
			End Property
			Public Property Buzzertime() As Byte
				Get
					Return BUZZERTIME_Conflict
				End Get
				Set(ByVal value As Byte)
					BUZZERTIME_Conflict = value
				End Set
			End Property
			Public Property IntenelTime() As Byte
				Get
					Return INTERNELTIME
				End Get
				Set(ByVal value As Byte)
					INTERNELTIME = value
				End Set
			End Property

			Public Property StartFreq() As UShort
				Get

					Return CUShort(CInt(STRATFREI) >> 8 Or CInt(STRATFREI) << 8)

				End Get
				Set(ByVal value As UShort)
					STRATFREI = CUShort(CInt(value) >> 8 Or CInt(value) << 8) '大小端转换
				End Set
			End Property
			Public Property StartFreqde() As UShort
				Get
					Return CUShort(CInt(STRATFRED) >> 8 Or CInt(STRATFRED) << 8)
				End Get
				Set(ByVal value As UShort)
					STRATFRED = CUShort(CInt(value) >> 8 Or CInt(value) << 8) '大小端转换
				End Set
			End Property
			Public Property Stepfreq() As UShort
				Get
					Return CUShort(CInt(STEPFRE) >> 8 Or CInt(STEPFRE) << 8)
				End Get
				Set(ByVal value As UShort)
					STEPFRE = CUShort(CInt(value) >> 8 Or CInt(value) << 8) '大小端转换
				End Set
			End Property
		End Structure

End Namespace
