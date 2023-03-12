Public Class Form1
    Private Sub btnEnterSpeeds_Click(sender As Object, e As EventArgs) Handles btnEnterSpeeds.Click
        Dim strSpeed As String
        Dim decSpeed As Decimal
        Dim decSumOfSpeeds As Decimal
        Dim decAverage As Decimal = 0D

        Dim intMaxEntries As Integer = 10
        Dim intEntries As Integer = 1

        Dim strIBoxMsg As String = "Enter the number of Mbps of your home internet speed user "
        Dim strIBoxTitle As String = "Internet Speed"
        Dim strErrMsg As String = "Error - Speed value must be a non negative number. Please try again."

        strSpeed = InputBox(strIBoxMsg & intEntries, strIBoxTitle)

        Do Until intEntries > intMaxEntries Or strSpeed = ""
            If IsNumeric(strSpeed) Then
                decSpeed = Convert.ToDecimal(strSpeed)
                If decSpeed > 0 Then
                    lstSpeeds.Items.Add(decSpeed)
                    decSumOfSpeeds += decSpeed
                    intEntries += 1
                    strIBoxMsg = strIBoxMsg
                Else
                    strIBoxMsg = strErrMsg
                End If
            Else
                strIBoxMsg = strErrMsg
            End If
            If intEntries <= intMaxEntries Then
                strSpeed = InputBox(strIBoxMsg & intEntries, strIBoxTitle)
            End If
        Loop

        lblAverageSpeed.Visible = True
        If intEntries > 1 Then
            decAverage = decSumOfSpeeds / (intEntries - 1)
            lblAverageSpeed.Text = "Average Internet Speed: " & decAverage.ToString("F2") & " Mbps"
        Else
            lblAverageSpeed.Text = "No Speed Values Entered"
        End If

        btnEnterSpeeds.Enabled = False
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lstSpeeds.Items.Clear()
        lblAverageSpeed.Text = ""
        btnClear.Enabled = True
        btnEnterSpeeds.Enabled = True
    End Sub
End Class
