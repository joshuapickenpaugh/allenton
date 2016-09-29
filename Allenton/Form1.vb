Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        'Closes the app:
        Me.Close()

    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click

        'Declares procedure-level object:
        Dim wtrCalc As New WaterCalculator()

        'Assigns the properties to the text boxes:
        Decimal.TryParse(txtCurrent.Text, wtrCalc.CurrentReading)
        Decimal.TryParse(txtPrevious.Text, wtrCalc.PreviousReading)

        'Prints results:
        lblGallonsUsed.Text = wtrCalc.GetGallonsUsed.ToString("N1")
        lblTotal.Text = wtrCalc.GetTotalCharge.ToString("C2")

    End Sub
End Class
