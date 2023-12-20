Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms

Namespace WindowsFormsApp1
	Friend Module Program
		''' <summary>
		''' 应用程序的主入口点。
		''' </summary>
		<STAThread>
		Sub Main()
			Application.EnableVisualStyles()
			Application.SetCompatibleTextRenderingDefault(False)
			Application.Run(New Form1())
		End Sub
	End Module
End Namespace
