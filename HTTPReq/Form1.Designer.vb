<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnGo = New Button()
        txURL = New TextBox()
        Label1 = New Label()
        rtxResult = New RichTextBox()
        SuspendLayout()
        ' 
        ' btnGo
        ' 
        btnGo.Location = New Point(349, 12)
        btnGo.Name = "btnGo"
        btnGo.Size = New Size(75, 23)
        btnGo.TabIndex = 0
        btnGo.Text = "Go..."
        btnGo.UseVisualStyleBackColor = True
        ' 
        ' txURL
        ' 
        txURL.Location = New Point(49, 12)
        txURL.Name = "txURL"
        txURL.Size = New Size(294, 23)
        txURL.TabIndex = 1
        txURL.Text = "http://localhost/"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 16)
        Label1.Name = "Label1"
        Label1.Size = New Size(31, 15)
        Label1.TabIndex = 2
        Label1.Text = "URL:"
        ' 
        ' rtxResult
        ' 
        rtxResult.Location = New Point(12, 41)
        rtxResult.Name = "rtxResult"
        rtxResult.Size = New Size(412, 234)
        rtxResult.TabIndex = 3
        rtxResult.Text = ""
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(448, 287)
        Controls.Add(rtxResult)
        Controls.Add(Label1)
        Controls.Add(txURL)
        Controls.Add(btnGo)
        Name = "Form1"
        Text = "HTTP Request"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnGo As Button
    Friend WithEvents txURL As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents rtxResult As RichTextBox

End Class
