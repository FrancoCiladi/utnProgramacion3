Imports System.IO
Public Class frmListado
    Private Sub frmListado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()

        cbxCategoria.Items.Add("Verduras")
        cbxCategoria.Items.Add("Frutas")
        cbxCategoria.Items.Add("Lacteos")
        cbxCategoria.Items.Add("Carnes")
        cbxCategoria.Items.Add("Limpieza")
        cbxCategoria.SelectedIndex = 0
        cbxCategoria.DropDownStyle = ComboBoxStyle.DropDownList

        lsvProductos.View = View.Details

        lsvProductos.Columns.Add("Codigo", 70, HorizontalAlignment.Center)
        lsvProductos.Columns.Add("Descripcion", 150, HorizontalAlignment.Center)
        lsvProductos.Columns.Add("Categoria", 100, HorizontalAlignment.Center)
        lsvProductos.Columns.Add("Fecha de Vencimiento", 150, HorizontalAlignment.Center)
        lsvProductos.Columns.Add("Disponibilidad", 150, HorizontalAlignment.Center)
        lsvProductos.Columns.Add("Ubicacion", 100, HorizontalAlignment.Center)

        lsvProductos.FullRowSelect = True

        rbTodos.Checked = True


    End Sub

    Private Sub rbPorCategoria_CheckedChanged(sender As Object, e As EventArgs) Handles rbPorCategoria.CheckedChanged
        If rbPorCategoria.Checked Then
            rbTodos.Checked = False
        Else
            rbTodos.Checked = True
            cbxCategoria.Enabled = False
        End If
    End Sub

    Private Sub rbTodos_CheckedChanged(sender As Object, e As EventArgs) Handles rbTodos.CheckedChanged
        If rbTodos.Checked Then
            rbPorCategoria.Checked = False
            cbxCategoria.Enabled = False
        Else
            rbPorCategoria.Checked = True
            cbxCategoria.Enabled = True
        End If
    End Sub

    Private Sub btnFiltrar_Click(sender As Object, e As EventArgs) Handles btnFiltrar.Click
        Dim archivo As FileStream
        Dim lector As StreamReader
        Dim cadena As String
        Dim vector() As String
        Dim cargarfila As Boolean


        lsvProductos.Items.Clear()

        archivo = New FileStream("Productos.csv", FileMode.Open)
        lector = New StreamReader(archivo)

        While lector.EndOfStream = False
            cadena = lector.ReadLine
            vector = cadena.Split(";")
            cargarfila = False

            If rbPorCategoria.Checked Then
                If cbxCategoria.Text = vector(2) Then
                    If chkSoloDisp.Checked Then
                        If vector(4) = "Disponible" Then
                            cargarfila = True
                        End If
                    Else
                        cargarfila = True
                    End If
                End If
            Else
                If chkSoloDisp.Checked Then
                    If vector(4) = "Disponible" Then
                        cargarfila = True
                    End If
                Else
                    cargarfila = True
                End If
            End If

            If cargarfila = True Then
                lsvProductos.Items.Add(vector(0))
                lsvProductos.Items(lsvProductos.Items.Count - 1).SubItems.Add(vector(1))
                lsvProductos.Items(lsvProductos.Items.Count - 1).SubItems.Add(vector(2))
                lsvProductos.Items(lsvProductos.Items.Count - 1).SubItems.Add(vector(3))
                lsvProductos.Items(lsvProductos.Items.Count - 1).SubItems.Add(vector(4))
                lsvProductos.Items(lsvProductos.Items.Count - 1).SubItems.Add(vector(5))
            End If

        End While

        lblCantProd.Text = lsvProductos.Items.Count

        lector.Close()
        archivo.Close()

    End Sub


End Class