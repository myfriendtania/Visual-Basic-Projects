Public Class Form1
    Dim mpg As Double

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblTankSize.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles lblModelAndYear.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblMilesDriven.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles lblMake.Click

    End Sub

    Private Sub txtTankSize_TextChanged(sender As Object, e As EventArgs) Handles txtTankSize.TextChanged

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        mpg = CDbl(txtMilesDriven.Text) / CDbl(txtTankSize.Text)
        lblResult.Text = ("Your " & txtMake.Text & " " & txtModelAndYear.Text & " gets" & mpg.ToString("n") & " miles/gallon.")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblResult.Text = ""
    End Sub
End Class
