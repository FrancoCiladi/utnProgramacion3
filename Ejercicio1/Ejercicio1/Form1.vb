Public Class frmEjercicio1
    Private Sub btnCopiar_Click(sender As Object, e As EventArgs) Handles btnCopiar.Click
        If txtIngreso.Text = String.Empty Then

            MessageBox.Show("Se debe ingresar texto para poder copiar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Else

            lblCopia.Text = txtIngreso.Text

        End If

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click

        If lblCopia.Text = String.Empty Then

            MessageBox.Show("No hay texto para limpiar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Else

            lblCopia.Text = String.Empty

        End If


    End Sub
End Class
