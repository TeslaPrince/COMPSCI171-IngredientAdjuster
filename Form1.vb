Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Const sugarC As Double = 1.5
        Const butterC As Double = 1
        Const flourC As Double = 2.75
        Const batch As Double = 50
        Dim batchPt As Double
        Dim number As Integer
        Dim sugar As Double
        Dim butter As Double
        Dim flour As Double
        number = CInt(txtNumber.Text)
        batchPt = number / batch
        sugar = sugarC * batchPt
        butter = butterC * batchPt
        flour = flourC * batchPt
        txtSugar.Text = String.Format("{0:N}", sugar)
        txtButter.Text = String.Format("{0:N}", butter)
        txtFlour.Text = String.Format("{0:N}", flour)
    End Sub
    Private Sub btnReset_click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtSugar.Text = ""
        txtButter.Text = ""
        txtFlour.Text = ""
        txtNumber.Text = ""
    End Sub
End Class
