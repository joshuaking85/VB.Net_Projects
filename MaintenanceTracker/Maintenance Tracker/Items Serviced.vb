Public Class Items_Serviced

    Dim todaysdate As String = String.Format("{0:MM/dd/yyyy}", DateTime.Now)

    Private Sub btnComplete_Click(sender As Object, e As EventArgs) Handles btnComplete.Click
        Dim oilPrice, tirePrice, transPrice, otherPrice, brakesPrice, sum As Double
        'Check which items are selected
        If cbOilServ.Checked = True Then
            oilPrice = 29.99
        Else : oilPrice = 0
        End If
        If cbTireServ.Checked = True Then
            tirePrice = 19.99
        Else : tirePrice = 0
        End If
        If cbTransServ.Checked = True Then
            transPrice = 25.0
        Else : transPrice = 0
        End If
        If cbBrakesServ.Checked = True Then
            brakesPrice = 69.99
        Else : brakesPrice = 0
        End If
        If cbOtherServ.Checked = True Then
            otherPrice = 50
        Else : otherPrice = 0
        End If
        ' Add Total Price
        sum = oilPrice + tirePrice + transPrice + otherPrice + brakesPrice
        lblCost.Text = "$" & sum
        lblDate.Text = todaysdate
    End Sub

    Private Sub lblDate_Click(sender As Object, e As EventArgs) Handles lblDate.Click

    End Sub
End Class