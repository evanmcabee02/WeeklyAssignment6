Public Class Form1
    Private Sub btnSpeed_Click(sender As Object, e As EventArgs) Handles btnSpeed.Click
        Dim strSpeed As String
        Dim decSpeed As Decimal
        Dim decSumOfSpeeds As Decimal
        Dim decAverage As Decimal = 0D

        Dim strIBoxMsg As String = "Enter the number of Mbps of your home Internet speed user #"
        Dim strIBoxTitle As String = "Internet Speed"
        Dim strNotNumericErrMsg As String = "Error - Enter the speed of your home Internet computer"
        Dim strNegErrMsg As String = "Error - Enter a valid speed"

        Dim intMaxEntries As Integer = 10
        Dim intEntries As Integer = 1

        strSpeed = InputBox(strIBoxMsg & intEntries, strIBoxTitle)

        Do Until intEntries > intMaxEntries Or strSpeed = ""
            If IsNumeric(strSpeed) Then
                decSpeed = Convert.ToDecimal(strSpeed)
                If decSpeed > 0 Then
                    lstSpeed.Items.Add(decSpeed)
                    decSumOfSpeeds += decSpeed
                    intEntries += 1
                    strIBoxMsg = strIBoxMsg
                Else
                    strIBoxMsg = strNotNumericErrMsg
                End If
                If intEntries <= intMaxEntries Then
                    strSpeed = InputBox(strIBoxMsg & intEntries, strIBoxTitle)
                End If
            End If
        Loop

        lblAverageSpeed.Visible = True

        If intEntries > 1 Then
            decAverage = decSumOfSpeeds / (intEntries - 1)
            lblAverageSpeed.Text = "Average Internet Speed: " & decAverage.ToString("F2") & " Mbps "
        Else
            lblAverageSpeed.Text = "No Speed Values Entered"
        End If

        btnSpeed.Enabled = False
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lstSpeed.Items.Clear()
        lblAverageSpeed.Text = ""
        btnSpeed.Enabled = True
    End Sub
End Class
