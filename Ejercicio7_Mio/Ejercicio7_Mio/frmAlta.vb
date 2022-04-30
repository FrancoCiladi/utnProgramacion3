Imports System.IO
Public Class frmAlta
    Private Sub frmAlta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()

        cbxCategoria.Items.Add("Verduras")
        cbxCategoria.Items.Add("Frutas")
        cbxCategoria.Items.Add("Lacteos")
        cbxCategoria.Items.Add("Carnes")
        cbxCategoria.Items.Add("Limpieza")
        cbxCategoria.SelectedIndex = 0
        cbxCategoria.DropDownStyle = ComboBoxStyle.DropDownList

        dtpFechavencimiento.MinDate = Today

        rbGondola.Checked = True

    End Sub

    Private Function Verificar()
        Dim ok As Boolean
        ok = False

        If mskCodigo.MaskCompleted = True Then
            If txtDescripcion.Text.Trim() <> String.Empty Then
                If VerificarCodigo() = False Then
                    ok = True
                Else
                    MessageBox.Show("El codigo ingresado ya existe.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    mskCodigo.Focus()
                End If
            Else
                MessageBox.Show("Debe completar la descripcion.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtDescripcion.Focus()
            End If
        Else
            MessageBox.Show("Debe completar el codigo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            mskCodigo.Focus()
        End If

        Return ok
    End Function
    Private Function VerificarCodigo()
        Dim archivo As FileStream
        Dim lector As StreamReader
        Dim cadena As String
        Dim vector() As String
        Dim codigoexiste As Boolean

        codigoexiste = False

        archivo = New FileStream("Productos.csv", FileMode.Open)
        lector = New StreamReader(archivo)

        While lector.EndOfStream = False
            cadena = lector.ReadLine
            vector = cadena.Split(";")

            If vector(0).ToUpper = mskCodigo.Text.ToUpper Then
                codigoexiste = True
            End If

        End While

        lector.Close()
        archivo.Close()


        Return codigoexiste
    End Function
    Private Sub limpiar()
        mskCodigo.Clear()
        txtDescripcion.Clear()
        cbxCategoria.SelectedIndex = 0
        dtpFechavencimiento.Checked = True
        dtpFechavencimiento.MinDate = Today
        chkDisponibilidad.Checked = False
        rbGondola.Checked = True
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Dim archivo As FileStream
        Dim grabador As StreamWriter
        Dim cadena As String

        If Verificar() = True Then

            archivo = New FileStream("Productos.csv", FileMode.Append)
            grabador = New StreamWriter(archivo)

            cadena = mskCodigo.Text
            cadena = cadena & ";" & txtDescripcion.Text
            cadena = cadena & ";" & cbxCategoria.SelectedItem

            If dtpFechavencimiento.Checked Then
                cadena = cadena & ";" & dtpFechavencimiento.Value.ToShortDateString()
            Else
                cadena = cadena & ";Sin fecha de Vencimiento"
            End If

            If chkDisponibilidad.Checked Then
                cadena = cadena & ";Disponible"
            Else
                cadena = cadena & ";No Disponible"
            End If

            If rbGondola.Checked Then
                cadena = cadena & ";Gondola"
            Else
                If rbRefrigerador.Checked Then
                    cadena = cadena & ";Refrigerador"
                Else
                    cadena = cadena & ";Deposito"
                End If
            End If

            grabador.WriteLine(cadena)

            grabador.Close()
            archivo.Close()

            limpiar()
            MessageBox.Show("El producto fue registrado con exito.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub
End Class