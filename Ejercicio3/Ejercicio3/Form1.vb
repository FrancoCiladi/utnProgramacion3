Public Class frmEjercicio3
    Private Sub mnuHabilitacion_Click(sender As Object, e As EventArgs) Handles mnuHabilitacion.Click
        frmHabilitacion.MdiParent = Me
        frmHabilitacion.Show()
        'frmHabilitacion.ShowDialog()' ' el showdialog no deja ver el formulario principal hasta cerrar el popup'
    End Sub

    Private Sub mnuVisualizacion_Click(sender As Object, e As EventArgs) Handles mnuVisualizacion.Click
        frmVisualizacion.MdiParent = Me
        frmVisualizacion.Show()
        'frmVisualizacion.ShowDialog()' 
    End Sub

    Private Sub frmEjercicio3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub
End Class
