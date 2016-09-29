'Joshua Pickenpaugh
'September 29th, 2016
'Water calculatorS

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

        'Sets cursor back to text box:
        txtCurrent.Focus()

    End Sub

    Private Sub txtCurrent_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCurrent.KeyPress

        'Allows only numbers, ".", and the backspace key in the text boxes:
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
                e.KeyChar <> "." AndAlso
                e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtCurrent_TextChanged(sender As Object, e As EventArgs) Handles txtCurrent.TextChanged

        'Clears the label:
        lblTotal.Text = String.Empty
        lblGallonsUsed.Text = String.Empty

    End Sub

    Private Sub txtPrevious_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrevious.KeyPress

        'Allows only numbers, ".", and the backspace key in the text boxes:
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
                e.KeyChar <> "." AndAlso
                e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtPrevious_TextChanged(sender As Object, e As EventArgs) Handles txtPrevious.TextChanged

        'Clears the label:
        lblTotal.Text = String.Empty
        lblGallonsUsed.Text = String.Empty

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Sets the focus when the form opens:
        txtCurrent.Select()

    End Sub
End Class
