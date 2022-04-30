Public Class frmEjercicio2
    Private Sub frmEjercicio2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.CenterToScreen()   'centraliza la aplicacion

        'mediante Load cuando inicia la aplicacion agrega al combobox items en este caso marcas, ya que el combobox es una coleccion de items
        cmbMarca.Items.Add("Ford")
        cmbMarca.Items.Add("VW")
        cmbMarca.Items.Add("Fiat")
        cmbMarca.Items.Add("Renault")
        cmbMarca.Items.Add("Peugeot")

        cmbMarca.DropDownStyle = ComboBoxStyle.DropDownList         'previene al usuario tipear dentro del combobox
        cmbMarca.SelectedIndex = 0          'selecciona al primer elemento o item para que sea mostrado por default en este caso "Ford"

        rbSedan.Checked = True  'hace que por default un radiobutton este seleccionado
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

        Dim cadena As String

        cadena = cmbMarca.Text
        'no va anidado porque descarta siempre alguna opcion ver min 48 en cambio de esta manera siempre agrega si se cumple el if
        If chkABS.Checked = True Then
            cadena = cadena & " - ABS "           ' el & CONCATENA
        End If
        If chkCierreCentralizado.Checked = True Then
            cadena = cadena & " - Cierre Centralizado "
        End If
        If chkGPS.Checked = True Then
            cadena = cadena & " - GPS "
        End If

        If rbHatchBack.Checked = True Then
            cadena = cadena & " - HatchBack "
        Else
            If rbSedan.Checked = True Then
                cadena = cadena & " - Sedan "
            Else
                cadena = cadena & " - SUV "
            End If
        End If

        lblSeleccion.Text = cadena
    End Sub
End Class
