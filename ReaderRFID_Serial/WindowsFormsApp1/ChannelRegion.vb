Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace WindowsFormsApp1
	''' <summary>
	''' Radio regulation region
	''' </summary>
	Friend Enum ChannelRegion
		Custom = &H0
		USA
		Korea
		Europe
		Japan
		Malaysia
		Europe3
		China_1
		China_2

	End Enum

	Friend Class ChannelItem
		Public Shared ReadOnly EmptyArray(-1) As ChannelItem

		Private m_fFreq As Single = 0

		Public ReadOnly Property Freq() As Single
			Get
				Return m_fFreq
			End Get
		End Property

'INSTANT VB NOTE: The variable freq was renamed since Visual Basic does not handle local variables named the same as class members well:
		Public Sub New(ByVal freq_Conflict As Single)
			m_fFreq = freq_Conflict
		End Sub

		Public Overrides Function ToString() As String
			Return m_fFreq.ToString("F3")
		End Function
	End Class

	Friend Class ChannelCount
		Public Shared ReadOnly EmptyArray(-1) As ChannelCount

		Private m_iCount As Integer = 0
		Private m_region As ChannelRegionItem = Nothing

		Public Property Count() As Integer
			Get
				Return m_iCount
			End Get
			Set(ByVal value As Integer)
				m_iCount = value
			End Set
		End Property

'INSTANT VB NOTE: The variable count was renamed since Visual Basic does not handle local variables named the same as class members well:
		Public Sub New(ByVal count_Conflict As Integer, ByVal region As ChannelRegionItem)
			m_iCount = count_Conflict
			m_region = region
		End Sub

		Public Overrides Function ToString() As String
			If m_region.Value = ChannelRegion.Custom Then
				Return m_iCount.ToString()
			End If
			Return (m_region.StartFreq + (m_iCount - 1) * m_region.FreqStep / 1000F).ToString("F3")
		End Function
	End Class


	Friend Class ChannelRegionItem
		Public Shared ReadOnly USARegion As New ChannelRegionItem(ChannelRegion.USA, 902.750F, 500, 50)
		Public Shared ReadOnly KoreaRegion As New ChannelRegionItem(ChannelRegion.Korea, 917.100F, 200, 32)
		Public Shared ReadOnly EuropeRegion As New ChannelRegionItem(ChannelRegion.Europe, 865.100F, 200, 15)
		Public Shared ReadOnly JapanRegion As New ChannelRegionItem(ChannelRegion.Japan, 952.200F, 200, 8)
		Public Shared ReadOnly MalaysiaRegion As New ChannelRegionItem(ChannelRegion.Malaysia, 919.500F, 500, 7)
		Public Shared ReadOnly Europe3Region As New ChannelRegionItem(ChannelRegion.Europe3, 865.700F, 600, 4)
		Public Shared ReadOnly China1Region As New ChannelRegionItem(ChannelRegion.China_1, 840.125F, 250, 20)
		Public Shared ReadOnly CustomRegion As New ChannelRegionItem(ChannelRegion.Custom, 0F, 0, 0)
		Public Shared ReadOnly China2Region As New ChannelRegionItem(ChannelRegion.China_2, 920.125F, 250, 20)

		Public Shared ReadOnly Options() As ChannelRegionItem = { USARegion, KoreaRegion, EuropeRegion, JapanRegion, MalaysiaRegion, Europe3Region, China1Region, China2Region, CustomRegion }

		Public Shared ReadOnly OptionsStandard() As ChannelRegionItem = { USARegion, KoreaRegion, EuropeRegion, JapanRegion, MalaysiaRegion, Europe3Region, China1Region, China2Region, CustomRegion }

		Private m_value As ChannelRegion
		Private m_fFreqStart As Single
		Private m_iFreqStep As Integer
		Private m_iFreqCount As Integer

		''' <summary>
		''' 区域
		''' </summary>
		Public ReadOnly Property Value() As ChannelRegion
			Get
				Return m_value
			End Get
		End Property

		''' <summary>
		''' 起始频率
		''' </summary>
		Public ReadOnly Property StartFreq() As Single
			Get
				Return m_fFreqStart
			End Get
		End Property

		''' <summary>
		''' 信道频率间隔
		''' </summary>
		Public ReadOnly Property FreqStep() As Integer
			Get
				Return m_iFreqStep
			End Get
		End Property

'INSTANT VB NOTE: The variable value was renamed since Visual Basic does not handle local variables named the same as class members well:
'INSTANT VB NOTE: The variable freqStep was renamed since Visual Basic does not handle local variables named the same as class members well:
		Public Sub New(ByVal value_Conflict As ChannelRegion, ByVal freqStart As Single, ByVal freqStep_Conflict As Integer, ByVal freqCount As Integer)
			m_value = value_Conflict
			m_fFreqStart = freqStart
			m_iFreqStep = freqStep_Conflict
			m_iFreqCount = freqCount
		End Sub

		Public Function GetChannelItems() As ChannelItem()
			If m_iFreqCount = 0 Then
				Return ChannelItem.EmptyArray
			End If
			Dim freq As Single = m_fFreqStart
			Dim items(m_iFreqCount - 1) As ChannelItem
			For i As Integer = 0 To items.Length - 1
				items(i) = New ChannelItem(freq)
				freq += m_iFreqStep / 1000F
			Next i
			Return items
		End Function

		Public Function GetChanelCounts() As ChannelCount()
			If m_iFreqCount = 0 Then
				Return ChannelCount.EmptyArray
			End If
			Dim items(m_iFreqCount - 1) As ChannelCount
			For i As Integer = 0 To items.Length - 1
				items(i) = New ChannelCount(i + 1, Me)
			Next i
			Return items
		End Function

		Public Overrides Function ToString() As String
			Return RegionToString(m_value)
		End Function

'INSTANT VB NOTE: The variable value was renamed since Visual Basic does not handle local variables named the same as class members well:
		Public Shared Function RegionToString(ByVal value_Conflict As ChannelRegion) As String
			Select Case value_Conflict
				Case ChannelRegion.Korea
					Return "Korea"
				Case ChannelRegion.Europe
					Return "Europe"
				Case ChannelRegion.China_1
					Return "China_1"
				Case ChannelRegion.China_2
					Return "China_2"
				Case ChannelRegion.USA
					Return "USA"
				Case ChannelRegion.Japan
					Return "Japan"
				Case ChannelRegion.Malaysia
					Return "Malaysia"
				Case ChannelRegion.Europe3
					Return "Europe3"
				Case ChannelRegion.Custom
					Return "Custom"
			End Select
			Return "未定义值：0x" & CInt(value_Conflict).ToString("X2")
		End Function

'INSTANT VB NOTE: The variable value was renamed since Visual Basic does not handle local variables named the same as class members well:
		Public Shared Function StringToRegion(ByVal value_Conflict As String) As ChannelRegion
			Select Case value_Conflict
				Case "Korea"
					Return ChannelRegion.Korea
				Case "Europe"
					Return ChannelRegion.Europe
				Case "China_1"
					Return ChannelRegion.China_1
				Case "China_2"
					Return ChannelRegion.China_2
				Case "USA"
					Return ChannelRegion.USA
				Case "Japan"
					Return ChannelRegion.Japan
				Case "Malaysia"
					Return ChannelRegion.Malaysia
				Case "Europe3"
					Return ChannelRegion.Europe3
				Case "Custom"
					Return ChannelRegion.Custom
			End Select
			Return ChannelRegion.USA
		End Function


		Public Shared Function OptionFromValue(ByVal region As ChannelRegion, ByVal bStandard As Boolean) As ChannelRegionItem
			Dim items() As ChannelRegionItem = If(bStandard, OptionsStandard, Options)
			For Each item As ChannelRegionItem In items
				If item.Value = region Then
					Return item
				End If
			Next item
			Return Nothing
		End Function
	End Class
End Namespace

