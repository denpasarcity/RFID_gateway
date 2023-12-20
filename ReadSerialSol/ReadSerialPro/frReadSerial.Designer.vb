<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frReadSerial
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnRead = New System.Windows.Forms.Button()
        Me.cmbPortList = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rtxResult = New System.Windows.Forms.RichTextBox()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.rtbPure = New System.Windows.Forms.RichTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbBaud = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnRead
        '
        Me.btnRead.Location = New System.Drawing.Point(323, 13)
        Me.btnRead.Name = "btnRead"
        Me.btnRead.Size = New System.Drawing.Size(75, 23)
        Me.btnRead.TabIndex = 0
        Me.btnRead.Text = "Read"
        Me.btnRead.UseVisualStyleBackColor = True
        '
        'cmbPortList
        '
        Me.cmbPortList.FormattingEnabled = True
        Me.cmbPortList.Location = New System.Drawing.Point(80, 13)
        Me.cmbPortList.Name = "cmbPortList"
        Me.cmbPortList.Size = New System.Drawing.Size(237, 21)
        Me.cmbPortList.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Select Port:"
        '
        'rtxResult
        '
        Me.rtxResult.Location = New System.Drawing.Point(12, 87)
        Me.rtxResult.Name = "rtxResult"
        Me.rtxResult.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.rtxResult.Size = New System.Drawing.Size(757, 167)
        Me.rtxResult.TabIndex = 3
        Me.rtxResult.Text = "///"
        '
        'btnStop
        '
        Me.btnStop.Location = New System.Drawing.Point(405, 13)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(75, 23)
        Me.btnStop.TabIndex = 4
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'rtbPure
        '
        Me.rtbPure.Location = New System.Drawing.Point(12, 275)
        Me.rtbPure.Name = "rtbPure"
        Me.rtbPure.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.rtbPure.Size = New System.Drawing.Size(757, 115)
        Me.rtbPure.TabIndex = 5
        Me.rtbPure.Text = "///"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Baud:"
        '
        'cmbBaud
        '
        Me.cmbBaud.FormattingEnabled = True
        Me.cmbBaud.Items.AddRange(New Object() {"2400", "9600", "115200"})
        Me.cmbBaud.Location = New System.Drawing.Point(80, 40)
        Me.cmbBaud.Name = "cmbBaud"
        Me.cmbBaud.Size = New System.Drawing.Size(237, 21)
        Me.cmbBaud.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Data:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 259)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Buffer:"
        '
        'frReadSerial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 402)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbBaud)
        Me.Controls.Add(Me.rtbPure)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.rtxResult)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbPortList)
        Me.Controls.Add(Me.btnRead)
        Me.Name = "frReadSerial"
        Me.RightToLeftLayout = True
        Me.Text = "Read Data from Serial"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnRead As Button
    Friend WithEvents cmbPortList As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents rtxResult As RichTextBox
    Friend WithEvents btnStop As Button
    Friend WithEvents rtbPure As RichTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbBaud As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
