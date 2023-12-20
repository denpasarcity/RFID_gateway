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
            Me.lsvTagsActive = New System.Windows.Forms.ListView()
            Me.colNum = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.colCode = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.colCodeLen = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.colCount = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.colRssi = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.colCw = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.sfd = New System.Windows.Forms.SaveFileDialog()
            Me.btnClear = New System.Windows.Forms.Button()
            Me.stdSerialData = New System.Windows.Forms.TextBox()
            Me.std = New System.Windows.Forms.OpenFileDialog()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.cmbWorkmode = New System.Windows.Forms.ComboBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Button1 = New System.Windows.Forms.Button()
            Me.TabControl1 = New System.Windows.Forms.TabControl()
            Me.TabPage1 = New System.Windows.Forms.TabPage()
            Me.cmbComBaud = New System.Windows.Forms.ComboBox()
            Me.label3 = New System.Windows.Forms.Label()
            Me.btnSportClose = New System.Windows.Forms.Button()
            Me.btnSportOpen = New System.Windows.Forms.Button()
            Me.cmbComPort = New System.Windows.Forms.ComboBox()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.TabPage2 = New System.Windows.Forms.TabPage()
            Me.groupNet = New System.Windows.Forms.GroupBox()
            Me.btnDisConnect = New System.Windows.Forms.Button()
            Me.btnConnect = New System.Windows.Forms.Button()
            Me.txbPort = New System.Windows.Forms.TextBox()
            Me.rflabel32 = New System.Windows.Forms.Label()
            Me.txbIPAddr = New System.Windows.Forms.TextBox()
            Me.rflabel33 = New System.Windows.Forms.Label()
            Me.btninvStop = New System.Windows.Forms.Button()
            Me.btnInventory = New System.Windows.Forms.Button()
            Me.TabControl1.SuspendLayout()
            Me.TabPage1.SuspendLayout()
            Me.TabPage2.SuspendLayout()
            Me.groupNet.SuspendLayout()
            Me.SuspendLayout()
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
            Me.lsvTagsActive.Location = New System.Drawing.Point(445, 12)
            Me.lsvTagsActive.Name = "lsvTagsActive"
            Me.lsvTagsActive.Size = New System.Drawing.Size(462, 154)
            Me.lsvTagsActive.TabIndex = 64
            Me.lsvTagsActive.UseCompatibleStateImageBehavior = False
            Me.lsvTagsActive.View = System.Windows.Forms.View.Details
            '
            'colNum
            '
            Me.colNum.Tag = "activecolNum"
            Me.colNum.Text = "No."
            Me.colNum.Width = 32
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
            'btnClear
            '
            Me.btnClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnClear.Location = New System.Drawing.Point(819, 276)
            Me.btnClear.Name = "btnClear"
            Me.btnClear.Size = New System.Drawing.Size(88, 25)
            Me.btnClear.TabIndex = 73
            Me.btnClear.Text = "Clear Data"
            Me.btnClear.UseVisualStyleBackColor = True
            '
            'stdSerialData
            '
            Me.stdSerialData.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.stdSerialData.Location = New System.Drawing.Point(14, 231)
            Me.stdSerialData.Margin = New System.Windows.Forms.Padding(2)
            Me.stdSerialData.Multiline = True
            Me.stdSerialData.Name = "stdSerialData"
            Me.stdSerialData.Size = New System.Drawing.Size(893, 272)
            Me.stdSerialData.TabIndex = 74
            '
            'std
            '
            Me.std.Filter = "*.bin|*.BIN"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(7, 216)
            Me.Label1.Name = "Label1"
            Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.Label1.Size = New System.Drawing.Size(33, 13)
            Me.Label1.TabIndex = 6
            Me.Label1.Text = "Logs:"
            '
            'cmbWorkmode
            '
            Me.cmbWorkmode.DisplayMember = "1"
            Me.cmbWorkmode.FormattingEnabled = True
            Me.cmbWorkmode.Items.AddRange(New Object() {"AnswerMode", "ActiveMode"})
            Me.cmbWorkmode.Location = New System.Drawing.Point(510, 175)
            Me.cmbWorkmode.Name = "cmbWorkmode"
            Me.cmbWorkmode.Size = New System.Drawing.Size(121, 21)
            Me.cmbWorkmode.TabIndex = 75
            Me.cmbWorkmode.Text = "WorkMode"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(442, 178)
            Me.Label2.Name = "Label2"
            Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.Label2.Size = New System.Drawing.Size(65, 13)
            Me.Label2.TabIndex = 76
            Me.Label2.Text = "Work mode:"
            '
            'Button1
            '
            Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Button1.Location = New System.Drawing.Point(819, 508)
            Me.Button1.Name = "Button1"
            Me.Button1.Size = New System.Drawing.Size(88, 25)
            Me.Button1.TabIndex = 77
            Me.Button1.Text = "Clear logs"
            Me.Button1.UseVisualStyleBackColor = True
            '
            'TabControl1
            '
            Me.TabControl1.Controls.Add(Me.TabPage1)
            Me.TabControl1.Controls.Add(Me.TabPage2)
            Me.TabControl1.Location = New System.Drawing.Point(10, 12)
            Me.TabControl1.Name = "TabControl1"
            Me.TabControl1.SelectedIndex = 0
            Me.TabControl1.Size = New System.Drawing.Size(415, 163)
            Me.TabControl1.TabIndex = 78
            '
            'TabPage1
            '
            Me.TabPage1.Controls.Add(Me.cmbComBaud)
            Me.TabPage1.Controls.Add(Me.label3)
            Me.TabPage1.Controls.Add(Me.btnSportClose)
            Me.TabPage1.Controls.Add(Me.btnSportOpen)
            Me.TabPage1.Controls.Add(Me.cmbComPort)
            Me.TabPage1.Controls.Add(Me.Label4)
            Me.TabPage1.Location = New System.Drawing.Point(4, 22)
            Me.TabPage1.Name = "TabPage1"
            Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPage1.Size = New System.Drawing.Size(407, 137)
            Me.TabPage1.TabIndex = 0
            Me.TabPage1.Text = "Serial"
            Me.TabPage1.UseVisualStyleBackColor = True
            '
            'cmbComBaud
            '
            Me.cmbComBaud.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.cmbComBaud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbComBaud.FormattingEnabled = True
            Me.cmbComBaud.Items.AddRange(New Object() {"9600", "19200", "38400", "57600", "115200"})
            Me.cmbComBaud.Location = New System.Drawing.Point(74, 45)
            Me.cmbComBaud.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.cmbComBaud.Name = "cmbComBaud"
            Me.cmbComBaud.Size = New System.Drawing.Size(195, 21)
            Me.cmbComBaud.TabIndex = 11
            '
            'label3
            '
            Me.label3.AutoSize = True
            Me.label3.Location = New System.Drawing.Point(18, 48)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(38, 13)
            Me.label3.TabIndex = 10
            Me.label3.Text = "Baud："
            '
            'btnSportClose
            '
            Me.btnSportClose.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.btnSportClose.Location = New System.Drawing.Point(163, 85)
            Me.btnSportClose.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.btnSportClose.Name = "btnSportClose"
            Me.btnSportClose.Size = New System.Drawing.Size(74, 30)
            Me.btnSportClose.TabIndex = 9
            Me.btnSportClose.Text = "&Close"
            Me.btnSportClose.UseVisualStyleBackColor = True
            '
            'btnSportOpen
            '
            Me.btnSportOpen.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.btnSportOpen.Location = New System.Drawing.Point(74, 85)
            Me.btnSportOpen.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.btnSportOpen.Name = "btnSportOpen"
            Me.btnSportOpen.Size = New System.Drawing.Size(74, 30)
            Me.btnSportOpen.TabIndex = 8
            Me.btnSportOpen.Text = "&Open"
            Me.btnSportOpen.UseVisualStyleBackColor = True
            '
            'cmbComPort
            '
            Me.cmbComPort.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.cmbComPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbComPort.FormattingEnabled = True
            Me.cmbComPort.Location = New System.Drawing.Point(74, 11)
            Me.cmbComPort.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.cmbComPort.Name = "cmbComPort"
            Me.cmbComPort.Size = New System.Drawing.Size(195, 21)
            Me.cmbComPort.TabIndex = 7
            '
            'Label4
            '
            Me.Label4.Location = New System.Drawing.Point(18, 14)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(50, 13)
            Me.Label4.TabIndex = 6
            Me.Label4.Text = "Port："
            '
            'TabPage2
            '
            Me.TabPage2.Controls.Add(Me.groupNet)
            Me.TabPage2.Location = New System.Drawing.Point(4, 22)
            Me.TabPage2.Name = "TabPage2"
            Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPage2.Size = New System.Drawing.Size(407, 137)
            Me.TabPage2.TabIndex = 1
            Me.TabPage2.Text = "RJ45"
            Me.TabPage2.UseVisualStyleBackColor = True
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
            Me.groupNet.Location = New System.Drawing.Point(6, 6)
            Me.groupNet.Name = "groupNet"
            Me.groupNet.Size = New System.Drawing.Size(395, 113)
            Me.groupNet.TabIndex = 18
            Me.groupNet.TabStop = False
            Me.groupNet.Text = "Net Connect"
            '
            'btnDisConnect
            '
            Me.btnDisConnect.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.btnDisConnect.Location = New System.Drawing.Point(176, 73)
            Me.btnDisConnect.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.btnDisConnect.Name = "btnDisConnect"
            Me.btnDisConnect.Size = New System.Drawing.Size(104, 30)
            Me.btnDisConnect.TabIndex = 5
            Me.btnDisConnect.Text = "&Disconnect"
            Me.btnDisConnect.UseVisualStyleBackColor = True
            '
            'btnConnect
            '
            Me.btnConnect.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.btnConnect.Location = New System.Drawing.Point(66, 73)
            Me.btnConnect.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.btnConnect.Name = "btnConnect"
            Me.btnConnect.Size = New System.Drawing.Size(104, 30)
            Me.btnConnect.TabIndex = 4
            Me.btnConnect.Text = "&Connect"
            Me.btnConnect.UseVisualStyleBackColor = True
            '
            'txbPort
            '
            Me.txbPort.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txbPort.Location = New System.Drawing.Point(66, 46)
            Me.txbPort.Name = "txbPort"
            Me.txbPort.Size = New System.Drawing.Size(322, 20)
            Me.txbPort.TabIndex = 3
            Me.txbPort.Text = "2022"
            '
            'rflabel32
            '
            Me.rflabel32.AutoSize = True
            Me.rflabel32.Location = New System.Drawing.Point(7, 49)
            Me.rflabel32.Name = "rflabel32"
            Me.rflabel32.Size = New System.Drawing.Size(32, 13)
            Me.rflabel32.TabIndex = 2
            Me.rflabel32.Text = "Port："
            '
            'txbIPAddr
            '
            Me.txbIPAddr.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txbIPAddr.Location = New System.Drawing.Point(66, 15)
            Me.txbIPAddr.Name = "txbIPAddr"
            Me.txbIPAddr.Size = New System.Drawing.Size(322, 20)
            Me.txbIPAddr.TabIndex = 1
            Me.txbIPAddr.Text = "192.168.1.200"
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
            'btninvStop
            '
            Me.btninvStop.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btninvStop.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
            Me.btninvStop.Location = New System.Drawing.Point(198, 181)
            Me.btninvStop.Name = "btninvStop"
            Me.btninvStop.Size = New System.Drawing.Size(88, 32)
            Me.btninvStop.TabIndex = 80
            Me.btninvStop.Text = "Sto&p"
            Me.btninvStop.UseVisualStyleBackColor = True
            '
            'btnInventory
            '
            Me.btnInventory.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnInventory.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
            Me.btnInventory.Location = New System.Drawing.Point(88, 181)
            Me.btnInventory.Name = "btnInventory"
            Me.btnInventory.Size = New System.Drawing.Size(88, 32)
            Me.btnInventory.TabIndex = 79
            Me.btnInventory.Text = "&Start"
            Me.btnInventory.UseVisualStyleBackColor = True
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(919, 543)
            Me.Controls.Add(Me.btninvStop)
            Me.Controls.Add(Me.btnInventory)
            Me.Controls.Add(Me.TabControl1)
            Me.Controls.Add(Me.Button1)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.cmbWorkmode)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.stdSerialData)
            Me.Controls.Add(Me.btnClear)
            Me.Controls.Add(Me.lsvTagsActive)
            Me.Margin = New System.Windows.Forms.Padding(2)
            Me.Name = "Form1"
            Me.Text = "UHF Reader"
            Me.TabControl1.ResumeLayout(False)
            Me.TabPage1.ResumeLayout(False)
            Me.TabPage1.PerformLayout()
            Me.TabPage2.ResumeLayout(False)
            Me.groupNet.ResumeLayout(False)
            Me.groupNet.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region
        Private lsvTagsActive As System.Windows.Forms.ListView
        Private colNum As System.Windows.Forms.ColumnHeader
        Private colCode As System.Windows.Forms.ColumnHeader
        Private colCodeLen As System.Windows.Forms.ColumnHeader
        Private colCount As System.Windows.Forms.ColumnHeader
        Private colRssi As System.Windows.Forms.ColumnHeader
        Private colCw As System.Windows.Forms.ColumnHeader
        Private sfd As System.Windows.Forms.SaveFileDialog
        Private WithEvents btnClear As System.Windows.Forms.Button
        Private stdSerialData As System.Windows.Forms.TextBox
        Private std As System.Windows.Forms.OpenFileDialog
        Private WithEvents Label1 As Label
        Protected WithEvents cmbWorkmode As ComboBox
        Private WithEvents Label2 As Label
        Private WithEvents Button1 As Button
        Friend WithEvents TabControl1 As TabControl
        Friend WithEvents TabPage1 As TabPage
        Friend WithEvents TabPage2 As TabPage
        Private WithEvents groupNet As GroupBox
        Private WithEvents btnDisConnect As Button
        Private WithEvents btnConnect As Button
        Private WithEvents txbPort As TextBox
        Private WithEvents rflabel32 As Label
        Private WithEvents txbIPAddr As TextBox
        Private WithEvents rflabel33 As Label
        Private WithEvents cmbComBaud As ComboBox
        Private WithEvents label3 As Label
        Public WithEvents btnSportClose As Button
        Public WithEvents btnSportOpen As Button
        Public WithEvents cmbComPort As ComboBox
        Private WithEvents Label4 As Label
        Private WithEvents btninvStop As Button
        Private WithEvents btnInventory As Button
    End Class
End Namespace

