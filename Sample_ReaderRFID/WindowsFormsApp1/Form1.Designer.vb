Namespace WindowsFormsApp1
	Partial Public Class Form1
		''' <summary>
		''' 必需的设计器变量。
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' 清理所有正在使用的资源。
		''' </summary>
		''' <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows 窗体设计器生成的代码"

		''' <summary>
		''' 设计器支持所需的方法 - 不要修改
		''' 使用代码编辑器修改此方法的内容。
		''' </summary>
		Private Sub InitializeComponent()
            Me.groupNet = New System.Windows.Forms.GroupBox()
            Me.btnDisConnect = New System.Windows.Forms.Button()
            Me.btnConnect = New System.Windows.Forms.Button()
            Me.txbPort = New System.Windows.Forms.TextBox()
            Me.rflabel32 = New System.Windows.Forms.Label()
            Me.txbIPAddr = New System.Windows.Forms.TextBox()
            Me.rflabel33 = New System.Windows.Forms.Label()
            Me.gpbCom = New System.Windows.Forms.GroupBox()
            Me.cmbComBaud = New System.Windows.Forms.ComboBox()
            Me.label3 = New System.Windows.Forms.Label()
            Me.btnSportClose = New System.Windows.Forms.Button()
            Me.btnSportOpen = New System.Windows.Forms.Button()
            Me.cmbComPort = New System.Windows.Forms.ComboBox()
            Me.label2 = New System.Windows.Forms.Label()
            Me.btnSetTxPower = New System.Windows.Forms.Button()
            Me.label1 = New System.Windows.Forms.Label()
            Me.cmbTxPower = New System.Windows.Forms.ComboBox()
            Me.cmbWorkmode = New System.Windows.Forms.ComboBox()
            Me.label10 = New System.Windows.Forms.Label()
            Me.btnSetWorkMode = New System.Windows.Forms.Button()
            Me.lsvTagsActive = New System.Windows.Forms.ListView()
            Me.colNum = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.colCode = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.colCodeLen = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.colCount = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.colRssi = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.colCw = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.sfd = New System.Windows.Forms.SaveFileDialog()
            Me.btnInventory = New System.Windows.Forms.Button()
            Me.btninvStop = New System.Windows.Forms.Button()
            Me.btnClear = New System.Windows.Forms.Button()
            Me.stdSerialData = New System.Windows.Forms.TextBox()
            Me.std = New System.Windows.Forms.OpenFileDialog()
            Me.btnGetTxPower = New System.Windows.Forms.Button()
            Me.btnGetWorkMode = New System.Windows.Forms.Button()
            Me.label4 = New System.Windows.Forms.Label()
            Me.cmbRegion = New System.Windows.Forms.ComboBox()
            Me.cmbFreqStart = New System.Windows.Forms.ComboBox()
            Me.cmbFreqEnd = New System.Windows.Forms.ComboBox()
            Me.label5 = New System.Windows.Forms.Label()
            Me.label6 = New System.Windows.Forms.Label()
            Me.btnGetFreq = New System.Windows.Forms.Button()
            Me.btnSetFreq = New System.Windows.Forms.Button()
            Me.groupBox1 = New System.Windows.Forms.GroupBox()
            Me.Close_Realy = New System.Windows.Forms.Button()
            Me.Release_Realy = New System.Windows.Forms.Button()
            Me.groupusb = New System.Windows.Forms.GroupBox()
            Me.label32 = New System.Windows.Forms.Label()
            Me.btnScanUsb = New System.Windows.Forms.Button()
            Me.btnUSBopen = New System.Windows.Forms.Button()
            Me.cbxusbpath = New System.Windows.Forms.ComboBox()
            Me.btnUSBClose = New System.Windows.Forms.Button()
            Me.cmbOutInterface = New System.Windows.Forms.ComboBox()
            Me.btnGetOutInterface = New System.Windows.Forms.Button()
            Me.btnSetOutInterface = New System.Windows.Forms.Button()
            Me.label7 = New System.Windows.Forms.Label()
            Me.txTagID = New System.Windows.Forms.TextBox()
            Me.btnCheck = New System.Windows.Forms.Button()
            Me.groupNet.SuspendLayout()
            Me.gpbCom.SuspendLayout()
            Me.groupBox1.SuspendLayout()
            Me.groupusb.SuspendLayout()
            Me.SuspendLayout()
            '
            'groupNet
            '
            Me.groupNet.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.groupNet.Controls.Add(Me.btnDisConnect)
            Me.groupNet.Controls.Add(Me.btnConnect)
            Me.groupNet.Controls.Add(Me.txbPort)
            Me.groupNet.Controls.Add(Me.rflabel32)
            Me.groupNet.Controls.Add(Me.txbIPAddr)
            Me.groupNet.Controls.Add(Me.rflabel33)
            Me.groupNet.Location = New System.Drawing.Point(10, 135)
            Me.groupNet.Name = "groupNet"
            Me.groupNet.Size = New System.Drawing.Size(213, 121)
            Me.groupNet.TabIndex = 16
            Me.groupNet.TabStop = False
            Me.groupNet.Text = "Net Connect"
            '
            'btnDisConnect
            '
            Me.btnDisConnect.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.btnDisConnect.Location = New System.Drawing.Point(111, 75)
            Me.btnDisConnect.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.btnDisConnect.Name = "btnDisConnect"
            Me.btnDisConnect.Size = New System.Drawing.Size(104, 30)
            Me.btnDisConnect.TabIndex = 5
            Me.btnDisConnect.Text = "DISCONNECT(&D)"
            Me.btnDisConnect.UseVisualStyleBackColor = True
            '
            'btnConnect
            '
            Me.btnConnect.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.btnConnect.Location = New System.Drawing.Point(-1, 75)
            Me.btnConnect.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.btnConnect.Name = "btnConnect"
            Me.btnConnect.Size = New System.Drawing.Size(104, 30)
            Me.btnConnect.TabIndex = 4
            Me.btnConnect.Text = "CONNECT(&C)"
            Me.btnConnect.UseVisualStyleBackColor = True
            '
            'txbPort
            '
            Me.txbPort.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txbPort.Location = New System.Drawing.Point(66, 46)
            Me.txbPort.Name = "txbPort"
            Me.txbPort.Size = New System.Drawing.Size(140, 20)
            Me.txbPort.TabIndex = 3
            Me.txbPort.Text = "2022"
            '
            'rflabel32
            '
            Me.rflabel32.AutoSize = True
            Me.rflabel32.Location = New System.Drawing.Point(7, 49)
            Me.rflabel32.Name = "rflabel32"
            Me.rflabel32.Size = New System.Drawing.Size(31, 13)
            Me.rflabel32.TabIndex = 2
            Me.rflabel32.Text = "port："
            '
            'txbIPAddr
            '
            Me.txbIPAddr.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txbIPAddr.Location = New System.Drawing.Point(66, 15)
            Me.txbIPAddr.Name = "txbIPAddr"
            Me.txbIPAddr.Size = New System.Drawing.Size(140, 20)
            Me.txbIPAddr.TabIndex = 1
            Me.txbIPAddr.Text = "192.168.1.120"
            '
            'rflabel33
            '
            Me.rflabel33.AutoSize = True
            Me.rflabel33.Location = New System.Drawing.Point(7, 20)
            Me.rflabel33.Name = "rflabel33"
            Me.rflabel33.Size = New System.Drawing.Size(48, 13)
            Me.rflabel33.TabIndex = 0
            Me.rflabel33.Text = "IP Addr："
            '
            'gpbCom
            '
            Me.gpbCom.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.gpbCom.Controls.Add(Me.cmbComBaud)
            Me.gpbCom.Controls.Add(Me.label3)
            Me.gpbCom.Controls.Add(Me.btnSportClose)
            Me.gpbCom.Controls.Add(Me.btnSportOpen)
            Me.gpbCom.Controls.Add(Me.cmbComPort)
            Me.gpbCom.Controls.Add(Me.label2)
            Me.gpbCom.Location = New System.Drawing.Point(10, 12)
            Me.gpbCom.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.gpbCom.Name = "gpbCom"
            Me.gpbCom.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.gpbCom.Size = New System.Drawing.Size(213, 122)
            Me.gpbCom.TabIndex = 15
            Me.gpbCom.TabStop = False
            Me.gpbCom.Text = "Serial Connect"
            '
            'cmbComBaud
            '
            Me.cmbComBaud.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.cmbComBaud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbComBaud.FormattingEnabled = True
            Me.cmbComBaud.Items.AddRange(New Object() {"9600", "19200", "38400", "57600", "115200"})
            Me.cmbComBaud.Location = New System.Drawing.Point(77, 53)
            Me.cmbComBaud.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.cmbComBaud.Name = "cmbComBaud"
            Me.cmbComBaud.Size = New System.Drawing.Size(130, 21)
            Me.cmbComBaud.TabIndex = 5
            '
            'label3
            '
            Me.label3.AutoSize = True
            Me.label3.Location = New System.Drawing.Point(6, 56)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(37, 13)
            Me.label3.TabIndex = 4
            Me.label3.Text = "buad："
            '
            'btnSportClose
            '
            Me.btnSportClose.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.btnSportClose.Location = New System.Drawing.Point(125, 83)
            Me.btnSportClose.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.btnSportClose.Name = "btnSportClose"
            Me.btnSportClose.Size = New System.Drawing.Size(74, 30)
            Me.btnSportClose.TabIndex = 3
            Me.btnSportClose.Text = "CLOSE(&C)"
            Me.btnSportClose.UseVisualStyleBackColor = True
            '
            'btnSportOpen
            '
            Me.btnSportOpen.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.btnSportOpen.Location = New System.Drawing.Point(13, 83)
            Me.btnSportOpen.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.btnSportOpen.Name = "btnSportOpen"
            Me.btnSportOpen.Size = New System.Drawing.Size(74, 30)
            Me.btnSportOpen.TabIndex = 2
            Me.btnSportOpen.Text = "OPEN(&O)"
            Me.btnSportOpen.UseVisualStyleBackColor = True
            '
            'cmbComPort
            '
            Me.cmbComPort.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.cmbComPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbComPort.FormattingEnabled = True
            Me.cmbComPort.Location = New System.Drawing.Point(77, 18)
            Me.cmbComPort.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.cmbComPort.Name = "cmbComPort"
            Me.cmbComPort.Size = New System.Drawing.Size(130, 21)
            Me.cmbComPort.TabIndex = 1
            '
            'label2
            '
            Me.label2.Location = New System.Drawing.Point(6, 22)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(50, 13)
            Me.label2.TabIndex = 0
            Me.label2.Text = "port："
            '
            'btnSetTxPower
            '
            Me.btnSetTxPower.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnSetTxPower.Location = New System.Drawing.Point(547, 22)
            Me.btnSetTxPower.Name = "btnSetTxPower"
            Me.btnSetTxPower.Size = New System.Drawing.Size(75, 25)
            Me.btnSetTxPower.TabIndex = 25
            Me.btnSetTxPower.Text = "Set"
            Me.btnSetTxPower.UseVisualStyleBackColor = True
            '
            'label1
            '
            Me.label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.label1.AutoSize = True
            Me.label1.Location = New System.Drawing.Point(229, 28)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(86, 13)
            Me.label1.TabIndex = 22
            Me.label1.Text = "RfPower（dbm）："
            '
            'cmbTxPower
            '
            Me.cmbTxPower.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.cmbTxPower.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbTxPower.FormattingEnabled = True
            Me.cmbTxPower.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33"})
            Me.cmbTxPower.Location = New System.Drawing.Point(341, 24)
            Me.cmbTxPower.Name = "cmbTxPower"
            Me.cmbTxPower.Size = New System.Drawing.Size(82, 21)
            Me.cmbTxPower.TabIndex = 23
            '
            'cmbWorkmode
            '
            Me.cmbWorkmode.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.cmbWorkmode.DisplayMember = "2"
            Me.cmbWorkmode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbWorkmode.FormattingEnabled = True
            Me.cmbWorkmode.Items.AddRange(New Object() {"AnswerMode", "ActiveMode"})
            Me.cmbWorkmode.Location = New System.Drawing.Point(340, 65)
            Me.cmbWorkmode.Name = "cmbWorkmode"
            Me.cmbWorkmode.Size = New System.Drawing.Size(82, 21)
            Me.cmbWorkmode.TabIndex = 27
            '
            'label10
            '
            Me.label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.label10.AutoSize = True
            Me.label10.Location = New System.Drawing.Point(257, 68)
            Me.label10.Name = "label10"
            Me.label10.Size = New System.Drawing.Size(66, 13)
            Me.label10.TabIndex = 26
            Me.label10.Text = "WorkMode："
            '
            'btnSetWorkMode
            '
            Me.btnSetWorkMode.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnSetWorkMode.Location = New System.Drawing.Point(547, 62)
            Me.btnSetWorkMode.Name = "btnSetWorkMode"
            Me.btnSetWorkMode.Size = New System.Drawing.Size(75, 25)
            Me.btnSetWorkMode.TabIndex = 28
            Me.btnSetWorkMode.Text = "Set"
            Me.btnSetWorkMode.UseVisualStyleBackColor = True
            '
            'lsvTagsActive
            '
            Me.lsvTagsActive.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lsvTagsActive.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colNum, Me.colCode, Me.colCodeLen, Me.colCount, Me.colRssi, Me.colCw})
            Me.lsvTagsActive.FullRowSelect = True
            Me.lsvTagsActive.GridLines = True
            Me.lsvTagsActive.HideSelection = False
            Me.lsvTagsActive.Location = New System.Drawing.Point(10, 374)
            Me.lsvTagsActive.Name = "lsvTagsActive"
            Me.lsvTagsActive.Size = New System.Drawing.Size(618, 177)
            Me.lsvTagsActive.TabIndex = 64
            Me.lsvTagsActive.UseCompatibleStateImageBehavior = False
            Me.lsvTagsActive.View = System.Windows.Forms.View.Details
            '
            'colNum
            '
            Me.colNum.Tag = "activecolNum"
            Me.colNum.Text = "No."
            Me.colNum.Width = 25
            '
            'colCode
            '
            Me.colCode.Tag = "activecolCode"
            Me.colCode.Text = "Data"
            Me.colCode.Width = 230
            '
            'colCodeLen
            '
            Me.colCodeLen.Tag = "activecolCodeLen"
            Me.colCodeLen.Text = "Len"
            Me.colCodeLen.Width = 40
            '
            'colCount
            '
            Me.colCount.Tag = "activecolCount"
            Me.colCount.Text = "Cnt(Ant1/2/3/4)"
            Me.colCount.Width = 80
            '
            'colRssi
            '
            Me.colRssi.Tag = "colRssia"
            Me.colRssi.Text = "RSSI(dBm)"
            '
            'colCw
            '
            Me.colCw.Tag = "activecolCw"
            Me.colCw.Text = "Channel"
            '
            'sfd
            '
            Me.sfd.Filter = "*.txt|*.txt|*.*|*.*"
            '
            'btnInventory
            '
            Me.btnInventory.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnInventory.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
            Me.btnInventory.Location = New System.Drawing.Point(330, 248)
            Me.btnInventory.Name = "btnInventory"
            Me.btnInventory.Size = New System.Drawing.Size(90, 53)
            Me.btnInventory.TabIndex = 65
            Me.btnInventory.Text = "Start"
            Me.btnInventory.UseVisualStyleBackColor = True
            '
            'btninvStop
            '
            Me.btninvStop.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btninvStop.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
            Me.btninvStop.Location = New System.Drawing.Point(482, 248)
            Me.btninvStop.Name = "btninvStop"
            Me.btninvStop.Size = New System.Drawing.Size(90, 53)
            Me.btninvStop.TabIndex = 66
            Me.btninvStop.Text = "Stop"
            Me.btninvStop.UseVisualStyleBackColor = True
            '
            'btnClear
            '
            Me.btnClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnClear.Location = New System.Drawing.Point(540, 557)
            Me.btnClear.Name = "btnClear"
            Me.btnClear.Size = New System.Drawing.Size(88, 25)
            Me.btnClear.TabIndex = 73
            Me.btnClear.Text = "Clear"
            Me.btnClear.UseVisualStyleBackColor = True
            '
            'stdSerialData
            '
            Me.stdSerialData.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.stdSerialData.Location = New System.Drawing.Point(632, 11)
            Me.stdSerialData.Margin = New System.Windows.Forms.Padding(2)
            Me.stdSerialData.Multiline = True
            Me.stdSerialData.Name = "stdSerialData"
            Me.stdSerialData.Size = New System.Drawing.Size(183, 540)
            Me.stdSerialData.TabIndex = 74
            '
            'std
            '
            Me.std.Filter = "*.bin|*.BIN"
            '
            'btnGetTxPower
            '
            Me.btnGetTxPower.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnGetTxPower.Location = New System.Drawing.Point(457, 22)
            Me.btnGetTxPower.Name = "btnGetTxPower"
            Me.btnGetTxPower.Size = New System.Drawing.Size(75, 25)
            Me.btnGetTxPower.TabIndex = 75
            Me.btnGetTxPower.Text = "Get"
            Me.btnGetTxPower.UseVisualStyleBackColor = True
            '
            'btnGetWorkMode
            '
            Me.btnGetWorkMode.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnGetWorkMode.Location = New System.Drawing.Point(457, 63)
            Me.btnGetWorkMode.Name = "btnGetWorkMode"
            Me.btnGetWorkMode.Size = New System.Drawing.Size(75, 25)
            Me.btnGetWorkMode.TabIndex = 76
            Me.btnGetWorkMode.Text = "Get"
            Me.btnGetWorkMode.UseVisualStyleBackColor = True
            '
            'label4
            '
            Me.label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.label4.AutoSize = True
            Me.label4.Location = New System.Drawing.Point(26, 18)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(62, 13)
            Me.label4.TabIndex = 77
            Me.label4.Text = "Freq Band："
            '
            'cmbRegion
            '
            Me.cmbRegion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.cmbRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbRegion.FormattingEnabled = True
            Me.cmbRegion.Items.AddRange(New Object() {"Custom", "USA", "Korea", "Europe", "Japan", "Malaysia", "Europe3", "China_1", "China_2"})
            Me.cmbRegion.Location = New System.Drawing.Point(107, 18)
            Me.cmbRegion.Name = "cmbRegion"
            Me.cmbRegion.Size = New System.Drawing.Size(82, 21)
            Me.cmbRegion.TabIndex = 78
            '
            'cmbFreqStart
            '
            Me.cmbFreqStart.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.cmbFreqStart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbFreqStart.FormattingEnabled = True
            Me.cmbFreqStart.Location = New System.Drawing.Point(107, 65)
            Me.cmbFreqStart.Name = "cmbFreqStart"
            Me.cmbFreqStart.Size = New System.Drawing.Size(82, 21)
            Me.cmbFreqStart.TabIndex = 79
            '
            'cmbFreqEnd
            '
            Me.cmbFreqEnd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.cmbFreqEnd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbFreqEnd.FormattingEnabled = True
            Me.cmbFreqEnd.Location = New System.Drawing.Point(286, 65)
            Me.cmbFreqEnd.Name = "cmbFreqEnd"
            Me.cmbFreqEnd.Size = New System.Drawing.Size(82, 21)
            Me.cmbFreqEnd.TabIndex = 80
            '
            'label5
            '
            Me.label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.label5.AutoSize = True
            Me.label5.Location = New System.Drawing.Point(20, 68)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(59, 13)
            Me.label5.TabIndex = 81
            Me.label5.Text = "Freq Start："
            '
            'label6
            '
            Me.label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.label6.AutoSize = True
            Me.label6.Location = New System.Drawing.Point(234, 68)
            Me.label6.Name = "label6"
            Me.label6.Size = New System.Drawing.Size(32, 13)
            Me.label6.TabIndex = 82
            Me.label6.Text = "End："
            '
            'btnGetFreq
            '
            Me.btnGetFreq.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnGetFreq.Location = New System.Drawing.Point(226, 16)
            Me.btnGetFreq.Name = "btnGetFreq"
            Me.btnGetFreq.Size = New System.Drawing.Size(75, 25)
            Me.btnGetFreq.TabIndex = 83
            Me.btnGetFreq.Text = "Get"
            Me.btnGetFreq.UseVisualStyleBackColor = True
            '
            'btnSetFreq
            '
            Me.btnSetFreq.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnSetFreq.Location = New System.Drawing.Point(316, 16)
            Me.btnSetFreq.Name = "btnSetFreq"
            Me.btnSetFreq.Size = New System.Drawing.Size(75, 25)
            Me.btnSetFreq.TabIndex = 84
            Me.btnSetFreq.Text = "Set"
            Me.btnSetFreq.UseVisualStyleBackColor = True
            '
            'groupBox1
            '
            Me.groupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.groupBox1.Controls.Add(Me.label6)
            Me.groupBox1.Controls.Add(Me.btnSetFreq)
            Me.groupBox1.Controls.Add(Me.label4)
            Me.groupBox1.Controls.Add(Me.btnGetFreq)
            Me.groupBox1.Controls.Add(Me.cmbRegion)
            Me.groupBox1.Controls.Add(Me.cmbFreqStart)
            Me.groupBox1.Controls.Add(Me.label5)
            Me.groupBox1.Controls.Add(Me.cmbFreqEnd)
            Me.groupBox1.Location = New System.Drawing.Point(231, 132)
            Me.groupBox1.Name = "groupBox1"
            Me.groupBox1.Size = New System.Drawing.Size(391, 108)
            Me.groupBox1.TabIndex = 85
            Me.groupBox1.TabStop = False
            '
            'Close_Realy
            '
            Me.Close_Realy.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.Close_Realy.Location = New System.Drawing.Point(330, 307)
            Me.Close_Realy.Name = "Close_Realy"
            Me.Close_Realy.Size = New System.Drawing.Size(101, 25)
            Me.Close_Realy.TabIndex = 85
            Me.Close_Realy.Text = "Close_Realy"
            Me.Close_Realy.UseVisualStyleBackColor = True
            '
            'Release_Realy
            '
            Me.Release_Realy.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.Release_Realy.Location = New System.Drawing.Point(482, 307)
            Me.Release_Realy.Name = "Release_Realy"
            Me.Release_Realy.Size = New System.Drawing.Size(103, 25)
            Me.Release_Realy.TabIndex = 85
            Me.Release_Realy.Text = "Release_Realy"
            Me.Release_Realy.UseVisualStyleBackColor = True
            '
            'groupusb
            '
            Me.groupusb.Controls.Add(Me.label32)
            Me.groupusb.Controls.Add(Me.btnScanUsb)
            Me.groupusb.Controls.Add(Me.btnUSBopen)
            Me.groupusb.Controls.Add(Me.cbxusbpath)
            Me.groupusb.Controls.Add(Me.btnUSBClose)
            Me.groupusb.Location = New System.Drawing.Point(9, 135)
            Me.groupusb.Name = "groupusb"
            Me.groupusb.Size = New System.Drawing.Size(216, 124)
            Me.groupusb.TabIndex = 86
            Me.groupusb.TabStop = False
            Me.groupusb.Text = "USB Connet"
            '
            'label32
            '
            Me.label32.Location = New System.Drawing.Point(12, 21)
            Me.label32.Name = "label32"
            Me.label32.Size = New System.Drawing.Size(65, 13)
            Me.label32.TabIndex = 91
            Me.label32.Text = "USB PATH："
            '
            'btnScanUsb
            '
            Me.btnScanUsb.Location = New System.Drawing.Point(15, 47)
            Me.btnScanUsb.Name = "btnScanUsb"
            Me.btnScanUsb.Size = New System.Drawing.Size(74, 30)
            Me.btnScanUsb.TabIndex = 90
            Me.btnScanUsb.Text = "ScanUSB"
            Me.btnScanUsb.UseVisualStyleBackColor = True
            '
            'btnUSBopen
            '
            Me.btnUSBopen.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.btnUSBopen.Location = New System.Drawing.Point(14, 82)
            Me.btnUSBopen.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.btnUSBopen.Name = "btnUSBopen"
            Me.btnUSBopen.Size = New System.Drawing.Size(74, 30)
            Me.btnUSBopen.TabIndex = 88
            Me.btnUSBopen.Text = "OPEN(&O)"
            Me.btnUSBopen.UseVisualStyleBackColor = True
            '
            'cbxusbpath
            '
            Me.cbxusbpath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.cbxusbpath.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbxusbpath.FormattingEnabled = True
            Me.cbxusbpath.Location = New System.Drawing.Point(83, 17)
            Me.cbxusbpath.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.cbxusbpath.Name = "cbxusbpath"
            Me.cbxusbpath.Size = New System.Drawing.Size(117, 21)
            Me.cbxusbpath.TabIndex = 87
            '
            'btnUSBClose
            '
            Me.btnUSBClose.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.btnUSBClose.Location = New System.Drawing.Point(126, 82)
            Me.btnUSBClose.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.btnUSBClose.Name = "btnUSBClose"
            Me.btnUSBClose.Size = New System.Drawing.Size(74, 30)
            Me.btnUSBClose.TabIndex = 89
            Me.btnUSBClose.Text = "CLOSE(&C)"
            Me.btnUSBClose.UseVisualStyleBackColor = True
            '
            'cmbOutInterface
            '
            Me.cmbOutInterface.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbOutInterface.FormattingEnabled = True
            Me.cmbOutInterface.Items.AddRange(New Object() {"RS232", "RS485", "RJ45", "Wieggand", "WiFi", "USB", "KeyBoard", "CDC_COM"})
            Me.cmbOutInterface.Location = New System.Drawing.Point(341, 104)
            Me.cmbOutInterface.Name = "cmbOutInterface"
            Me.cmbOutInterface.Size = New System.Drawing.Size(82, 21)
            Me.cmbOutInterface.TabIndex = 87
            '
            'btnGetOutInterface
            '
            Me.btnGetOutInterface.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnGetOutInterface.Location = New System.Drawing.Point(457, 102)
            Me.btnGetOutInterface.Name = "btnGetOutInterface"
            Me.btnGetOutInterface.Size = New System.Drawing.Size(75, 25)
            Me.btnGetOutInterface.TabIndex = 89
            Me.btnGetOutInterface.Text = "Get"
            Me.btnGetOutInterface.UseVisualStyleBackColor = True
            '
            'btnSetOutInterface
            '
            Me.btnSetOutInterface.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnSetOutInterface.Location = New System.Drawing.Point(547, 101)
            Me.btnSetOutInterface.Name = "btnSetOutInterface"
            Me.btnSetOutInterface.Size = New System.Drawing.Size(75, 25)
            Me.btnSetOutInterface.TabIndex = 88
            Me.btnSetOutInterface.Text = "Set"
            Me.btnSetOutInterface.UseVisualStyleBackColor = True
            '
            'label7
            '
            Me.label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.label7.AutoSize = True
            Me.label7.Location = New System.Drawing.Point(239, 107)
            Me.label7.Name = "label7"
            Me.label7.Size = New System.Drawing.Size(72, 13)
            Me.label7.TabIndex = 90
            Me.label7.Text = "OutInterface："
            '
            'txTagID
            '
            Me.txTagID.Location = New System.Drawing.Point(24, 281)
            Me.txTagID.Name = "txTagID"
            Me.txTagID.Size = New System.Drawing.Size(263, 20)
            Me.txTagID.TabIndex = 91
            Me.txTagID.Text = "<tag id>"
            '
            'btnCheck
            '
            Me.btnCheck.Location = New System.Drawing.Point(24, 308)
            Me.btnCheck.Name = "btnCheck"
            Me.btnCheck.Size = New System.Drawing.Size(75, 23)
            Me.btnCheck.TabIndex = 92
            Me.btnCheck.Text = "Check Tag"
            Me.btnCheck.UseVisualStyleBackColor = True
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(816, 594)
            Me.Controls.Add(Me.btnCheck)
            Me.Controls.Add(Me.txTagID)
            Me.Controls.Add(Me.label7)
            Me.Controls.Add(Me.btnGetOutInterface)
            Me.Controls.Add(Me.btnSetOutInterface)
            Me.Controls.Add(Me.cmbOutInterface)
            Me.Controls.Add(Me.groupusb)
            Me.Controls.Add(Me.Release_Realy)
            Me.Controls.Add(Me.Close_Realy)
            Me.Controls.Add(Me.groupBox1)
            Me.Controls.Add(Me.btnGetWorkMode)
            Me.Controls.Add(Me.btnGetTxPower)
            Me.Controls.Add(Me.stdSerialData)
            Me.Controls.Add(Me.btnClear)
            Me.Controls.Add(Me.btninvStop)
            Me.Controls.Add(Me.btnInventory)
            Me.Controls.Add(Me.lsvTagsActive)
            Me.Controls.Add(Me.btnSetWorkMode)
            Me.Controls.Add(Me.cmbWorkmode)
            Me.Controls.Add(Me.label10)
            Me.Controls.Add(Me.btnSetTxPower)
            Me.Controls.Add(Me.label1)
            Me.Controls.Add(Me.cmbTxPower)
            Me.Controls.Add(Me.groupNet)
            Me.Controls.Add(Me.gpbCom)
            Me.Margin = New System.Windows.Forms.Padding(2)
            Me.Name = "Form1"
            Me.Text = "Form1"
            Me.groupNet.ResumeLayout(False)
            Me.groupNet.PerformLayout()
            Me.gpbCom.ResumeLayout(False)
            Me.gpbCom.PerformLayout()
            Me.groupBox1.ResumeLayout(False)
            Me.groupBox1.PerformLayout()
            Me.groupusb.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region

        Private groupNet As System.Windows.Forms.GroupBox
		Private WithEvents btnDisConnect As System.Windows.Forms.Button
		Private WithEvents btnConnect As System.Windows.Forms.Button
		Private txbPort As System.Windows.Forms.TextBox
		Private rflabel32 As System.Windows.Forms.Label
		Private txbIPAddr As System.Windows.Forms.TextBox
		Private rflabel33 As System.Windows.Forms.Label
		Private gpbCom As System.Windows.Forms.GroupBox
		Private cmbComBaud As System.Windows.Forms.ComboBox
		Private label3 As System.Windows.Forms.Label
		Public WithEvents btnSportClose As System.Windows.Forms.Button
		Public WithEvents btnSportOpen As System.Windows.Forms.Button
		Public WithEvents cmbComPort As System.Windows.Forms.ComboBox
		Private label2 As System.Windows.Forms.Label
		Private WithEvents btnSetTxPower As System.Windows.Forms.Button
		Private label1 As System.Windows.Forms.Label
		Private cmbTxPower As System.Windows.Forms.ComboBox
		Private cmbWorkmode As System.Windows.Forms.ComboBox
		Private label10 As System.Windows.Forms.Label
		Private WithEvents btnSetWorkMode As System.Windows.Forms.Button
		Private lsvTagsActive As System.Windows.Forms.ListView
		Private colNum As System.Windows.Forms.ColumnHeader
		Private colCode As System.Windows.Forms.ColumnHeader
		Private colCodeLen As System.Windows.Forms.ColumnHeader
		Private colCount As System.Windows.Forms.ColumnHeader
		Private colRssi As System.Windows.Forms.ColumnHeader
		Private colCw As System.Windows.Forms.ColumnHeader
		Private sfd As System.Windows.Forms.SaveFileDialog
		Private WithEvents btnInventory As System.Windows.Forms.Button
		Private WithEvents btninvStop As System.Windows.Forms.Button
		Private WithEvents btnClear As System.Windows.Forms.Button
		Private stdSerialData As System.Windows.Forms.TextBox
		Private std As System.Windows.Forms.OpenFileDialog
		Private WithEvents btnGetTxPower As System.Windows.Forms.Button
		Private WithEvents btnGetWorkMode As System.Windows.Forms.Button
		Private label4 As System.Windows.Forms.Label
		Private WithEvents cmbRegion As System.Windows.Forms.ComboBox
		Private WithEvents cmbFreqStart As System.Windows.Forms.ComboBox
		Private cmbFreqEnd As System.Windows.Forms.ComboBox
		Private label5 As System.Windows.Forms.Label
		Private label6 As System.Windows.Forms.Label
		Private WithEvents btnGetFreq As System.Windows.Forms.Button
		Private WithEvents btnSetFreq As System.Windows.Forms.Button
		Private groupBox1 As System.Windows.Forms.GroupBox
		Private WithEvents Close_Realy As System.Windows.Forms.Button
		Private WithEvents Release_Realy As System.Windows.Forms.Button
		Private groupusb As System.Windows.Forms.GroupBox
		Private label32 As System.Windows.Forms.Label
		Private WithEvents btnScanUsb As System.Windows.Forms.Button
		Public WithEvents btnUSBopen As System.Windows.Forms.Button
		Public cbxusbpath As System.Windows.Forms.ComboBox
		Public WithEvents btnUSBClose As System.Windows.Forms.Button
		Private cmbOutInterface As System.Windows.Forms.ComboBox
		Private WithEvents btnGetOutInterface As System.Windows.Forms.Button
		Private WithEvents btnSetOutInterface As System.Windows.Forms.Button
		Private label7 As System.Windows.Forms.Label
        Friend WithEvents txTagID As TextBox
        Friend WithEvents btnCheck As Button
    End Class
End Namespace

