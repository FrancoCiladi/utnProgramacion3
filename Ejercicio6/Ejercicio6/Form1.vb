Imports System.IO
Public Class frmEjercicio6
    Private Sub frmEjercicio6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Dim Archivo As FileStream
        Dim Grabador As StreamWriter

        If txtRegistar.Text.Trim() <> String.Empty Then
            SFD.AddExtension = True     'que agrege extension por default si no lo hace el usuario
            SFD.Filter = "Archivo de Texto|*.txt"       'archivo de texto seria para descripcion, el *.txt seria lo que realmente te filtra
            SFD.InitialDirectory = Application.StartupPath  'directorio inicial sera la carpeta donde se ejecuta
            SFD.OverwritePrompt = True   'en caso de elegir un archivo ya existente le pide confirmacion de sobreescribir
            SFD.DefaultExt = "*.txt"    'la extension default a crearse

            If SFD.ShowDialog = DialogResult.OK Then            ' si el usuario elige cancelar o no OK no se ejecuta el codigo
                Archivo = New FileStream(SFD.FileName, FileMode.Append)         ' el filename seria el archivo seleccionado por el usuario
                Grabador = New StreamWriter(Archivo)

                Grabador.WriteLine(txtRegistar.Text.Trim())

                Grabador.Close()                   'SIEMPRE CERRAR AMBOS
                Archivo.Close()                     'SIEMPRE CERRAR AMBOS
                txtRegistar.Clear()
            End If
        Else
            MessageBox.Show("Debe ingresar un texto a registrar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtRegistar.Focus()
        End If
    End Sub

    Private Sub btnLeer_Click(sender As Object, e As EventArgs) Handles btnLeer.Click
        Dim Archivo As FileStream
        Dim Lector As StreamReader
        Dim cadena As String
        Dim cantlinea As Integer

        OFD.AddExtension = True
        OFD.Filter = "Archivo de Texto|*.txt"
        OFD.InitialDirectory = Application.StartupPath
        OFD.DefaultExt = "*.txt"
        OFD.FileName = String.Empty

        txtLeer.Clear()  'o txt.Leer = String.Empty

        If OFD.ShowDialog = DialogResult.OK Then
            txtLeer.Clear()
            cantlinea = 0
            Archivo = New FileStream(OFD.FileName, FileMode.Open)
            Lector = New StreamReader(Archivo)

            While Lector.EndOfStream = False
                cadena = Lector.ReadLine()
                txtLeer.Text = txtLeer.Text & cadena & vbCrLf   'el vbCrLf actuaria como un enter para que salte a la prox linea y no salga todo junto
                cantlinea = cantlinea + 1
            End While

            lblCantLineas.Text = cantlinea.ToString()

            Lector.Close()
            Archivo.Close()
        End If

    End Sub
End Class
