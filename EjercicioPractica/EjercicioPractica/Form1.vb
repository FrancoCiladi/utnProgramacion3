Public Class frmPrincipal
    Private Sub mnuCargarDatos_Click(sender As Object, e As EventArgs) Handles mnuCargarDatos.Click
        frmCargar.Show()
    End Sub

    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub
End Class
