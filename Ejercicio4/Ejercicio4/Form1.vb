Public Class frmEjercicio4
    Private Sub frmEjercicio4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lsvLista.View = View.Details

        dtpFechaNacimiento.MaxDate = DateTime.Today     'Establece como fecha maxima el dia hoy

        cbxEstadoCivil.Items.Add("Soltero/a")
        cbxEstadoCivil.Items.Add("Casado/a")
        cbxEstadoCivil.Items.Add("Divorciado/a")
        cbxEstadoCivil.Items.Add("Viudo/a")
        cbxEstadoCivil.SelectedIndex = 0                 'muestra por default la opcion 0 en este caso soltero/a
        cbxEstadoCivil.DropDownStyle = ComboBoxStyle.DropDownList


        lsvLista.Columns.Add("DNI", 100, HorizontalAlignment.Right)
        lsvLista.Columns.Add("Apellido", 150, HorizontalAlignment.Left)
        lsvLista.Columns.Add("Nombre", 150, HorizontalAlignment.Left)
        lsvLista.Columns.Add("Est. Civil", 150, HorizontalAlignment.Center)
        lsvLista.Columns.Add("Fecha. Nac.", 100, HorizontalAlignment.Center)
        lsvLista.Columns.Add("Cant. Hijos", 100, HorizontalAlignment.Center)
        lsvLista.Columns.Add("Salarios", 100, HorizontalAlignment.Center)

        lsvLista.Items.Add("10.000")
        lsvLista.Items(0).SubItems.Add("Perez")
        lsvLista.Items(0).SubItems.Add("Lucas")
        lsvLista.Items(0).SubItems.Add("Soltero")
        lsvLista.Items(0).SubItems.Add("10/5/2001")
        lsvLista.Items(0).SubItems.Add("2")
        lsvLista.Items(0).SubItems.Add("5000")

        lsvLista.Items.Add("41.134.538")
        lsvLista.Items(1).SubItems.Add("Ciladi")
        lsvLista.Items(1).SubItems.Add("Franco")
        lsvLista.Items(1).SubItems.Add("Soltero")
        lsvLista.Items(1).SubItems.Add("27/5/1998")
        lsvLista.Items(1).SubItems.Add("0")
        lsvLista.Items(1).SubItems.Add("10000")

        lsvLista.Items.Add("25.687.319")
        lsvLista.Items(2).SubItems.Add("Gonzales")
        lsvLista.Items(2).SubItems.Add("Renzo")
        lsvLista.Items(2).SubItems.Add("Casado")
        lsvLista.Items(2).SubItems.Add("8/7/1986")
        lsvLista.Items(2).SubItems.Add("1")
        lsvLista.Items(2).SubItems.Add("15000")
    End Sub

    Private Sub btnCalcularHijo_Click(sender As Object, e As EventArgs) Handles btnCalcularHijo.Click
        Dim cant As Integer
        Dim i As Integer

        cant = 0
        For i = 0 To lsvLista.Items.Count - 1
            cant = cant + Integer.Parse(lsvLista.Items(i).SubItems(5).Text)         'subitems(5) haria referencia a la columna 5 donde esta ubicada la cantidad de hijos
        Next

        lblCalcular.Text = cant.ToString()

    End Sub

    Private Sub btnCalcularSalario_Click(sender As Object, e As EventArgs) Handles btnCalcularSalario.Click
        Dim cant As Integer
        Dim i As Integer

        cant = 0
        For i = 0 To lsvLista.Items.Count - 1
            cant = cant + Integer.Parse(lsvLista.Items(i).SubItems(6).Text)
        Next

        MessageBox.Show("El salario total es: " & cant.ToString(), "Salario Total", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click

        If Verificar() = True Then
            lsvLista.Items.Add(txtDNI.Text)
            lsvLista.Items(lsvLista.Items.Count - 1).SubItems.Add(txtApellido.Text)
            lsvLista.Items(lsvLista.Items.Count - 1).SubItems.Add(txtNombre.Text)
            lsvLista.Items(lsvLista.Items.Count - 1).SubItems.Add(cbxEstadoCivil.SelectedItem)
            lsvLista.Items(lsvLista.Items.Count - 1).SubItems.Add(dtpFechaNacimiento.Value.ToShortDateString())
            lsvLista.Items(lsvLista.Items.Count - 1).SubItems.Add(txtCantHijos.Text)
            lsvLista.Items(lsvLista.Items.Count - 1).SubItems.Add(txtSalario.Text)
        End If


    End Sub
    Private Function Verificar() As Boolean
        Dim ok As Boolean = False

        Dim dni As Integer
        Dim canthijos As Integer
        Dim salario As Integer

        If Integer.TryParse(txtDNI.Text, dni) Then
            If dni > 0 Then
                If txtApellido.Text <> String.Empty Then
                    If txtNombre.Text <> String.Empty Then
                        If Integer.TryParse(txtCantHijos.Text, canthijos) Then
                            If canthijos >= 0 Then
                                If Integer.TryParse(txtSalario.Text, salario) Then
                                    If salario >= 0 Then
                                        ok = True
                                    Else
                                        MessageBox.Show("Debe ingresar una salario valido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                        txtSalario.Focus()
                                    End If
                                Else
                                    MessageBox.Show("Debe ingresar una salario valido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                    txtSalario.Focus()
                                End If
                            Else
                                MessageBox.Show("Debe ingresar una cant de hijos valido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                txtCantHijos.Focus()
                            End If
                        Else
                            MessageBox.Show("Debe ingresar una cant de hijos valido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            txtCantHijos.Focus()
                        End If
                    Else
                        MessageBox.Show("Debe ingresar un nombre valido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        txtNombre.Focus()
                    End If
                Else
                    MessageBox.Show("Debe ingresar un apellido valido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtApellido.Focus()
                End If
            Else
                MessageBox.Show("Debe ingresar un DNI valido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtDNI.Focus()
            End If
        Else
            MessageBox.Show("Debe ingresar un DNI valido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtDNI.Focus()
        End If
        Return ok
    End Function
End Class
