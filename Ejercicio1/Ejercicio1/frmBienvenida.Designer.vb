<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBienvenida
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBienvenida))
        Me.pcbLogo = New System.Windows.Forms.PictureBox()
        Me.lblAplicacion = New System.Windows.Forms.Label()
        CType(Me.pcbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pcbLogo
        '
        Me.pcbLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pcbLogo.Image = CType(resources.GetObject("pcbLogo.Image"), System.Drawing.Image)
        Me.pcbLogo.Location = New System.Drawing.Point(12, 12)
        Me.pcbLogo.Name = "pcbLogo"
        Me.pcbLogo.Size = New System.Drawing.Size(607, 313)
        Me.pcbLogo.TabIndex = 0
        Me.pcbLogo.TabStop = False
        '
        'lblAplicacion
        '
        Me.lblAplicacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAplicacion.Font = New System.Drawing.Font("Impact", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAplicacion.Location = New System.Drawing.Point(12, 343)
        Me.lblAplicacion.Name = "lblAplicacion"
        Me.lblAplicacion.Size = New System.Drawing.Size(607, 85)
        Me.lblAplicacion.TabIndex = 1
        Me.lblAplicacion.Text = "Ejercicio 1"
        Me.lblAplicacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmBienvenida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(631, 437)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblAplicacion)
        Me.Controls.Add(Me.pcbLogo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmBienvenida"
        CType(Me.pcbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pcbLogo As PictureBox
    Friend WithEvents lblAplicacion As Label
End Class
