Imports System.Net.Http
Imports System.Reflection.Metadata

Public Class Form1
    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        rtxResult.Lines.Append("request to " & txURL.Text)
        MsgBox(txURL.Text)

        ' Create an instance of HttpClient
        Using client As New HttpClient()
            ' Specify the URL you want to send the request to
            Dim url As String = txURL.Text

            ' Send the GET request
            Dim response As HttpResponseMessage = client.GetAsync(url).Result

            ' Check if the request was successful (status code 200)
            If response.IsSuccessStatusCode Then
                ' Read and display the response content
                Dim content As String = response.Content.ReadAsStringAsync().Result
                Console.WriteLine("Response: " & content)
                rtxResult.AppendText(content)

                'MsgBox(content)
            Else
                ' Display the error status code
                Console.WriteLine("Error: " & response.StatusCode)
                rtxResult.AppendText("no result")
            End If
        End Using

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rtxResult.Enabled = False
    End Sub
End Class
