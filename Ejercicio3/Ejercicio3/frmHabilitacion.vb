Public Class frmHabilitacion
    Private Sub btnHabilitaryDeshabilitar_Click(sender As Object, e As EventArgs) Handles btnHabilitaryDeshabilitar.Click
        If lblTexto.Enabled = True Then
            btnHabilitaryDeshabilitar.Text = "Habilitar"
            lblTexto.Enabled = False
        Else
            btnHabilitaryDeshabilitar.Text = "Deshabilitar"
            lblTexto.Enabled = True
        End If
    End Sub

    Private Sub frmHabilitacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub
End Class