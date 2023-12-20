Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Runtime.InteropServices

Namespace WindowsFormsApp1
	''' <summary>
	''' 频率信息
	''' </summary>
	<StructLayout(LayoutKind.Sequential)>
	Public Structure FreqInfo
		''' <summary>
		''' 地域索引
		''' </summary>
		Private m_region As Byte
		''' <summary>
		''' 起始频率的整数部分，单位：MHz，取值范围为：840~960
		''' </summary>
		Private m_startFreq1 As UShort
		''' <summary>
		''' 起始频率的小数部分，单位：MHz，取值范围为：0~999
		''' </summary>
		Private m_startFreq2 As UShort
		''' <summary>
		''' 频率步进,单位：KHz，取值范围为：0~500
		''' </summary>
		Private m_stepFreq As UShort
		''' <summary>
		''' 信道数，取值范围为：1~50（包括1和50）
		''' </summary>
		Private m_cnt As Byte

		''' <summary>
		''' 地域索引，取值范围：
		''' 0：China-1,
		''' 1：China-2,
		''' 2：FCC,
		''' 3：Japan,
		''' 4：Malaysia,
		''' 5：ETSI
		''' </summary>
		Public Property Region() As Byte
			Get
				Return m_region
			End Get
			Set(ByVal value As Byte)
				m_region = value
			End Set
		End Property

		''' <summary>
		''' 起始频率，单位：MHz，取值范围为：840~960
		''' </summary>
		Public Property StartFreq() As Single
			Get
				Return m_startFreq1 + m_startFreq2 / 1000.0F
			End Get
			Set(ByVal value As Single)
				m_startFreq1 = CUShort(CInt(Math.Truncate(value)))
				m_startFreq2 = CUShort(CInt(Math.Truncate((value - m_startFreq1) * 1000)))
			End Set
		End Property

		''' <summary>
		''' 频率步进,单位：KHz，取值范围为：0~500
		''' </summary>
		Public Property StepFreq() As UShort
			Get
				Return m_stepFreq
			End Get
			Set(ByVal value As UShort)
				m_stepFreq = value
			End Set
		End Property

		''' <summary>
		''' 信道数，取值范围为：1~50（包括1和50）
		''' </summary>
		Public Property Count() As Byte
			Get
				Return m_cnt
			End Get
			Set(ByVal value As Byte)
				m_cnt = value
			End Set
		End Property

	End Structure
End Namespace
