Public Class frmVisualizacion
    Private Sub btnOcultaryVisualizar_Click(sender As Object, e As EventArgs) Handles btnOcultaryVisualizar.Click

        If lblTexto.Visible = True Then
            btnOcultaryVisualizar.Text = "Visualizar"
            lblTexto.Visible = False
        Else
            btnOcultaryVisualizar.Text = "Ocultar"
            lblTexto.Visible = True
        End If

    End Sub

    Private Sub frmVisualizacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub
End Class