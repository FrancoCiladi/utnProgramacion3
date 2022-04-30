Public Class frmCargar
    Private Sub frmCargar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()

        lsvDatos.View = View.Details    'sin esto no hay listview

        txtCodigo.MaxLength = 5
        txtMercaderia.MaxLength = 30
        txtPeso.MaxLength = 5

        cbxPaisDestino.Items.Add("EE.UU")
        cbxPaisDestino.Items.Add("Canada")
        cbxPaisDestino.Items.Add("Mexico")
        cbxPaisDestino.Items.Add("Francia")
        cbxPaisDestino.Items.Add("España")
        cbxPaisDestino.Items.Add("Alemania")
        cbxPaisDestino.SelectedIndex = 0
        cbxPaisDestino.DropDownStyle = ComboBoxStyle.DropDownList

        dtpFechaEmbarque.MaxDate = DateTime.Today
        dtpFechaEmbarque.MinDate = New DateTime(2020, 1, 1)  ' formato es año, mes, dia  'YYYY/MM/DD'

        lsvDatos.Columns.Add("Codigo", 100, HorizontalAlignment.Center)
        lsvDatos.Columns.Add("Mercaderia", 150, HorizontalAlignment.Center)
        lsvDatos.Columns.Add("Pais Destino", 150, HorizontalAlignment.Center)
        lsvDatos.Columns.Add("Tipo Mercaderia", 150, HorizontalAlignment.Center)
        lsvDatos.Columns.Add("Peso", 100, HorizontalAlignment.Center)
        lsvDatos.Columns.Add("Fecha Embarque", 150, HorizontalAlignment.Center)
        lsvDatos.Columns.Add("Responsables", 230, HorizontalAlignment.Center)

        rbTecnologia.Checked = True
        lsvDatos.FullRowSelect = True

    End Sub

    Private Sub btnCargar_Click(sender As Object, e As EventArgs) Handles btnCargar.Click
        Dim cadenachk As String
        cadenachk = String.Empty

        If Verificar() = True Then
            lsvDatos.Items.Add(txtCodigo.Text)
            lsvDatos.Items(lsvDatos.Items.Count - 1).SubItems.Add(txtMercaderia.Text)
            lsvDatos.Items(lsvDatos.Items.Count - 1).SubItems.Add(cbxPaisDestino.SelectedItem)
            If rbTecnologia.Checked = True Then
                lsvDatos.Items(lsvDatos.Items.Count - 1).SubItems.Add(rbTecnologia.Text)
            Else
                If rbVarios.Checked = True Then
                    lsvDatos.Items(lsvDatos.Items.Count - 1).SubItems.Add(rbVarios.Text)
                Else
                    If rbVehiculos.Checked = True Then
                        lsvDatos.Items(lsvDatos.Items.Count - 1).SubItems.Add(rbVehiculos.Text)
                    Else
                        If rbVestimenta.Checked = True Then
                            lsvDatos.Items(lsvDatos.Items.Count - 1).SubItems.Add(rbVestimenta.Text)
                        End If
                    End If
                End If
            End If
            lsvDatos.Items(lsvDatos.Items.Count - 1).SubItems.Add(txtPeso.Text)
            lsvDatos.Items(lsvDatos.Items.Count - 1).SubItems.Add(dtpFechaEmbarque.Value.ToShortDateString())
            If chkLucas.Checked = True Then
                cadenachk = "Lucas"
            End If
            If chkLucia.Checked = True Then
                If cadenachk = String.Empty Then
                    cadenachk = "Lucia"
                Else
                    cadenachk = cadenachk & ", " & "Lucia"
                End If
            End If
            If chkRamon.Checked = True Then
                If cadenachk = String.Empty Then
                    cadenachk = "Ramon"
                Else
                    cadenachk = cadenachk & ", " & "Ramon"
                End If
            End If
            lsvDatos.Items(lsvDatos.Items.Count - 1).SubItems.Add(cadenachk)
        End If
    End Sub

    Private Function Verificar() As Boolean
        Dim ok As Boolean = False
        Dim peso As Integer

        If txtCodigo.Text.Trim <> String.Empty Then
            If CodigoExiste(txtCodigo.Text.Trim) = False Then
                If txtMercaderia.Text.Trim <> String.Empty Then
                    If Integer.TryParse(txtPeso.Text, peso) Then
                        If peso > 0 Then
                            If chkLucas.Checked = True Or chkLucia.Checked = True Or chkRamon.Checked = True Then
                                ok = True
                            Else
                                MessageBox.Show("Debe elegir un responsable.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                chkLucas.Focus()
                            End If
                        Else
                            MessageBox.Show("Debe ingresar un peso valido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            txtPeso.Focus()
                        End If
                    Else
                        MessageBox.Show("Debe ingresar un peso.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        txtPeso.Focus()
                    End If
                Else
                    MessageBox.Show("Debe ingresar la mercaderia.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtMercaderia.Focus()
                End If
            Else
                MessageBox.Show("El codigo ingresado ya existe.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtCodigo.Focus()
            End If
        Else
            MessageBox.Show("Debe ingresar un codigo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCodigo.Focus()
        End If

        Return ok
    End Function

    Private Function CodigoExiste(ByVal codigobus As String) As Boolean
        Dim existe As Boolean = False
        Dim i As Integer

        For i = 0 To lsvDatos.Items.Count - 1
            If lsvDatos.Items(i).SubItems(0).Text = codigobus Then
                existe = True
            End If
        Next

        Return existe
    End Function
End Class