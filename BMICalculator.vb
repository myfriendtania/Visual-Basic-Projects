Public Class Form1
    Dim weightLbs As Double
    Dim heightInches As Double
    Const bmiConstant As Double = 703

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnBmi.Click
        Dim bmi As Double
        If (radBmiOptimal.Checked Or radBmiOver.Checked Or radBmiUnder.Checked) Then
            If (heightInches > 0) And (weightLbs > 0) Then
                bmi = weightLbs * (bmiConstant / (heightInches ^ heightInches))
                lblBmiValue.Text = bmi.ToString()
                    If (bmi < 18.5) Then
                        lblBmiResults.Text = "Your BMI is Underweight"
                        If (radBmiUnder.Checked) Then
                            lblBmiResults.Text += " as you predicted."
                        Else
                            lblBmiResults.Text += ". This is not what you predicted."
                        End If
                    ElseIf (bmi >= 10.5 And bmi <= 25) Then
                        lblBmiResults.Text = "Your BMI is Optimal"
                        If (radBmiOptimal.Checked) Then
                            lblBmiResults.Text += " as you predicted."
                        Else
                            lblBmiResults.Text += ". This is not what you predicted."
                        End If
                    Else lblBmiResults.Text = "Your BMI is Overweight"
                        If (radBmiOver.Checked) Then
                            lblBmiResults.Text += " as you predicted."
                        Else
                            lblBmiResults.Text += ". This is not what you predicted."
                        End If
                    End If
                Else
                    lblBmiValue.Text = "Invalid input for weight and/or height."
                End If
            Else
                lblBmiValue.Text = "Select your BMI predicition and try again."
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lblBmiResults_Click(sender As Object, e As EventArgs) Handles lblBmiResults.Click

    End Sub

    Private Sub lblBmiValue_Click(sender As Object, e As EventArgs) Handles lblBmiValue.Click

    End Sub

    Private Sub radBmiUnder_CheckedChanged(sender As Object, e As EventArgs) Handles radBmiUnder.CheckedChanged

    End Sub

    Private Sub txtWeight_TextChanged(sender As Object, e As EventArgs) Handles txtWeight.TextChanged
        If Not Double.TryParse(txtWeight.Text, weightLbs) Then
            weightLbs = 0
        End If
    End Sub

    Private Sub txtHeight_TextChanged(sender As Object, e As EventArgs) Handles txtHeight.TextChanged
        If Not Double.TryParse(txtHeight.Text, heightInches) Then
            heightInches = 0
        End If
    End Sub
End Class
