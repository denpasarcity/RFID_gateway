Imports System.IO.Ports


Public Class frReadSerial

    Dim WithEvents serialPort As SerialPort
    Dim isRead, isStop As Boolean

    Private Function IsPortsChanged(ByVal ports() As String) As Boolean
        Dim items As ComboBox.ObjectCollection = cmbPortList.Items
        If items.Count <> ports.Length Then
            Return True
        End If

        For i As Integer = 0 To ports.Length - 1
            If String.Compare(items(i).ToString(), ports(i), StringComparison.OrdinalIgnoreCase) <> 0 Then
                Return True
            End If
        Next i
        Return False
    End Function

    Private Sub frReadSerial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        isRead = True
        isStop = False
        btnStop.Enabled = True
        Try
            Dim ports() As String = SerialPort.GetPortNames()
            Array.Sort(ports)
            If IsPortsChanged(ports) Then
                cmbPortList.Items.Clear()
                cmbPortList.Items.AddRange(ports)
            End If

        Catch ex As Exception
            MessageBox.Show(Me, ex.Message, Me.Text)
        End Try

        cmbBaud.SelectedIndex = 1

        'rtbPure.AppendText(StringToHex("a"))
    End Sub

    Function StringToHex(ByVal text As String) As String
        Dim hex As String = "-"
        For i As Integer = 0 To text.Length - 1
            hex &= Asc(text.Substring(i, 1)).ToString("x").ToUpper
        Next
        Return hex
    End Function

    Private Sub btnRead_Click(sender As Object, e As EventArgs) Handles btnRead.Click
        Dim incomingText As String = ""
        Dim incomingByte As Char = ""
        Dim arrayBuffer As Byte() = New Byte(32) {}
        Dim i As Integer

        ' Create an instance of the SerialPort class
        serialPort = New SerialPort()

        ' Set the serial port properties (adjust these based on your requirements)
        serialPort.PortName = cmbPortList.SelectedItem
        serialPort.BaudRate = cmbBaud.SelectedItem
        serialPort.Parity = Parity.None
        serialPort.DataBits = 8
        serialPort.StopBits = StopBits.One

        'rtxResult.Clear()
        rtxResult.AppendText("Reading card")
        rtxResult.AppendText(Environment.NewLine)
        rtxResult.ScrollToCaret()

        Try
            ' Open the serial port
            serialPort.Open()
            isRead = True
            isStop = False

            Do
                If isRead = True Then
                    btnRead.Enabled = False

                    incomingText = serialPort.ReadLine
                    rtxResult.AppendText("length: " + Len(incomingText))
                    'rtxResult.AppendText(Environment.NewLine + incomingText)
                    rtxResult.ScrollToCaret()
                    'rtxResult.AppendText(StringToHex(incomingText))

                    For i = 1 To arrayBuffer.Length() - 1
                        arrayBuffer(i) = serialPort.ReadByte
                        rtbPure.AppendText(serialPort.ReadChar)
                    Next

                    ' Start reading data asynchronously
                    'rtbPure.Clear()
                    For i = 0 To incomingText.Length - 1
                        incomingByte = incomingText(i)
                        rtbPure.AppendText(Environment.NewLine + incomingByte)
                        rtbPure.ScrollToCaret()
                    Next

                    Console.WriteLine("Reading from serial port. Press Enter to exit.")
                    Console.ReadLine()
                ElseIf isRead = False Then
                    btnRead.Enabled = True
                    btnStop.Enabled = False
                    Exit Do
                End If

                For i = 1 To 30
                    Threading.Thread.Sleep(100)
                    Application.DoEvents()
                Next
            Loop

        Catch ex As Exception
            Console.WriteLine("Error: " & ex.Message)
            'rtxResult.AppendText("Error opening port.")
        Finally
            ' Close the serial port when done
            rtxResult.AppendText("Closing port")
            If serialPort.IsOpen Then
                serialPort.Close()
            End If
        End Try
    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        isRead = False
        isStop = True
        btnRead.Enabled = True
        btnStop.Enabled = False
    End Sub
End Class
