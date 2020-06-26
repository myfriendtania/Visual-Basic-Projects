Public Class WorkshopSelector

    Dim registrationFee As Double = 0
    Dim lodgingPerDay As Double = 0
    Dim lodgingDays As Integer = 0

    Private Sub lstworkshop_SelectedItem(sender As Object, e As EventArgs) Handles lstWorkshop.SelectedIndexChanged

        Select Case lstWorkshop.SelectedItem.ToString
            Case "Handling Stress"
                registrationFee = 595
                lodgingDays = 3
            Case "Time Management"
                registrationFee = 695
                lodgingDays = 3
            Case "Supervision Skills"
                registrationFee = 995
                lodgingDays = 3
            Case "Negotiation"
                registrationFee = 1095
                lodgingDays = 3
            Case "How to Interview"
                registrationFee = 395
                lodgingDays = 3
        End Select
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstLocation.SelectedIndexChanged

        Select Case lstLocation.SelectedItem.ToString
            Case "Austin"
                lodgingPerDay = 95
            Case "Chicago"
                lodgingPerDay = 125
            Case "Dallas"
                lodgingPerDay = 100
            Case "Orlando"
                lodgingPerDay = 100
            Case "Phoenix"
                lodgingPerDay = 92
            Case "Raleigh"
                lodgingPerDay = 90
        End Select
    End Sub

    Private Sub btnAddWorkshop_Click(sender As Object, e As EventArgs) Handles btnAddWorkshop.Click
        If (registrationFee > 0) And (lodgingDays > 0) And (lodgingPerDay > 0) Then
            lstCosts.Items.Add(registrationFee + lodgingDays + lodgingPerDay)
        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim totalCost As Double = 0
        Dim itemCount As Integer = lstCosts.Items.Count
        Dim itemIndex As Integer = 0
        Do While (itemIndex < itemCount)
            totalCost += CDbl(lstCosts.Items(itemIndex))
            itemIndex += 1
        Loop
        txtTotalCost.Text = totalCost.ToString
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        lstCosts.Items.Clear()
        registrationFee = 0
        lodgingDays = 0
        lodgingPerDay = 0
        txtTotalCost.Text = String.Empty
    End Sub

    Private Sub lstCosts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstCosts.SelectedIndexChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblPickaWorkshopHere.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblPickALocationHere.Click

    End Sub
End Class
