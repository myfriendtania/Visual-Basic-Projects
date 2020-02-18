Public Class Form1
    Private Sub txtboxInteger_TextChanged(sender As Object, e As EventArgs) Handles txtBoxInteger.TextChanged
        Dim int_arg As Integer
        If (txtBoxInteger.Text Is String.Empty) OrElse Integer.TryParse(txtBoxInteger.Text, int_arg) Then
            Select Case txtBoxInteger.Text
                Case ""
                    lblTextRomanNumeral.Text = ""
                Case "1"
                    lblTextRomanNumeral.Text = "I"
                Case "2"
                    lblTextRomanNumeral.Text = "II"
                Case "3"
                    lblTextRomanNumeral.Text = "III"
                Case "4"
                    lblTextRomanNumeral.Text = "IV"
                Case "5"
                    lblTextRomanNumeral.Text = "V"
                Case "6"
                    lblTextRomanNumeral.Text = "VI"
                Case "7"
                    lblTextRomanNumeral.Text = "VII"
                Case "8"
                    lblTextRomanNumeral.Text = "VIII"
                Case "9"
                    lblTextRomanNumeral.Text = "IX"
                Case "10"
                    lblTextRomanNumeral.Text = "X"
                Case "11"
                    lblTextRomanNumeral.Text = "XI"
                Case "12"
                    lblTextRomanNumeral.Text = "XII"
                Case "13"
                    lblTextRomanNumeral.Text = "XIII"
                Case "14"
                    lblTextRomanNumeral.Text = "XIV"
                Case "15"
                    lblTextRomanNumeral.Text = "XV"
                Case Else
                    lblTextRomanNumeral.Text = "Out of Range"
            End Select
        Else
            lblTextRomanNumeral.Text = "Invalid Input"
        End If

    End Sub

    Private Sub lblTextRomanNumeral_Click(sender As Object, e As EventArgs) Handles lblTextRomanNumeral.Click

    End Sub

    Private Sub lblEnterAnInteger_Click(sender As Object, e As EventArgs) Handles lblEnterAnInteger.Click

    End Sub
End Class
