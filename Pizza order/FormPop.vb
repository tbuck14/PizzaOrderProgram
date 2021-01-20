Public Class FrmPop
    Dim row As Integer
    Dim column As Integer
    Dim drinks(2, 2) As Double

    Private Sub FrmPop_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'reference for drink cost
        drinks(0, 0) = 1.25
        drinks(0, 1) = 0.99
        drinks(0, 2) = 2.9
        drinks(1, 0) = 1.29
        drinks(1, 1) = 0.99
        drinks(1, 2) = 2.99
        drinks(2, 0) = 1.9
        drinks(2, 1) = 0.9
        drinks(2, 2) = 2.75

        radPepsi.Checked = True
        rad2Liter.Checked = True
    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        'displays the main form, and hides the drink form
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub radGeneric_CheckedChanged(sender As Object, e As EventArgs) Handles radGeneric.CheckedChanged
        'Picked Generic
        row = 2
        lblPopCost.Text = drinks(row, column).ToString("c")

    End Sub

    Private Sub radPepsi_CheckedChanged(sender As Object, e As EventArgs) Handles radPepsi.CheckedChanged
        'Picked Pepsi
        row = 0
        lblPopCost.Text = drinks(row, column).ToString("c")
    End Sub

    Private Sub radCoke_CheckedChanged(sender As Object, e As EventArgs) Handles radCoke.CheckedChanged
        'Picked Coke
        row = 1
        lblPopCost.Text = drinks(row, column).ToString("c")
    End Sub

    Private Sub rad1Liter_CheckedChanged(sender As Object, e As EventArgs) Handles rad1Liter.CheckedChanged
        'Picked 1 Liter
        column = 0
        lblPopCost.Text = drinks(row, column).ToString("c")
    End Sub

    Private Sub rad2Liter_CheckedChanged(sender As Object, e As EventArgs) Handles rad2Liter.CheckedChanged
        'Picked 2 Liter
        column = 1
        lblPopCost.Text = drinks(row, column).ToString("c")
    End Sub

    Private Sub rad3Liter_CheckedChanged(sender As Object, e As EventArgs) Handles rad3Liter.CheckedChanged
        'Picked 3 Liter
        column = 2
        lblPopCost.Text = drinks(row, column).ToString("c")
    End Sub

    Private Sub lblPopCost_Click(sender As Object, e As EventArgs) Handles lblPopCost.TextChanged
        'price of pop sent to the pizza form
        Form1.PopCost = drinks(row, column)
    End Sub
End Class