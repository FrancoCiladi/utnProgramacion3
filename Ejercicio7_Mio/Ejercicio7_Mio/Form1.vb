Public Class frmMenu
    Private Sub frmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub mnuAlta_Click(sender As Object, e As EventArgs) Handles mnuAlta.Click
        frmAlta.Show()
    End Sub

    Private Sub mnuListado_Click(sender As Object, e As EventArgs) Handles mnuListado.Click
        frmListado.Show()
    End Sub
End Class
