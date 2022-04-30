<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAlta
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
        Me.mskCodigo = New System.Windows.Forms.MaskedTextBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.cbxCategoria = New System.Windows.Forms.ComboBox()
        Me.rbGondola = New System.Windows.Forms.RadioButton()
        Me.rbRefrigerador = New System.Windows.Forms.RadioButton()
        Me.rbDeposito = New System.Windows.Forms.RadioButton()
        Me.grpbUbicacion = New System.Windows.Forms.GroupBox()
        Me.chkDisponibilidad = New System.Windows.Forms.CheckBox()
        Me.dtpFechavencimiento = New System.Windows.Forms.DateTimePicker()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblCategoria = New System.Windows.Forms.Label()
        Me.lblFechaVenc = New System.Windows.Forms.Label()
        Me.grpbUbicacion.SuspendLayout()
        Me.SuspendLayout()
        '
        'mskCodigo
        '
        Me.mskCodigo.Location = New System.Drawing.Point(310, 50)
        Me.mskCodigo.Mask = "L000"
        Me.mskCodigo.Name = "mskCodigo"
        Me.mskCodigo.Size = New System.Drawing.Size(46, 20)
        Me.mskCodigo.TabIndex = 0
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(310, 89)
        Me.txtDescripcion.MaxLength = 30
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(171, 20)
        Me.txtDescripcion.TabIndex = 1
        '
        'cbxCategoria
        '
        Me.cbxCategoria.FormattingEnabled = True
        Me.cbxCategoria.Location = New System.Drawing.Point(310, 125)
        Me.cbxCategoria.Name = "cbxCategoria"
        Me.cbxCategoria.Size = New System.Drawing.Size(171, 21)
        Me.cbxCategoria.TabIndex = 2
        '
        'rbGondola
        '
        Me.rbGondola.AutoSize = True
        Me.rbGondola.Location = New System.Drawing.Point(6, 46)
        Me.rbGondola.Name = "rbGondola"
        Me.rbGondola.Size = New System.Drawing.Size(65, 17)
        Me.rbGondola.TabIndex = 3
        Me.rbGondola.TabStop = True
        Me.rbGondola.Text = "Gondola"
        Me.rbGondola.UseVisualStyleBackColor = True
        '
        'rbRefrigerador
        '
        Me.rbRefrigerador.AutoSize = True
        Me.rbRefrigerador.Location = New System.Drawing.Point(94, 46)
        Me.rbRefrigerador.Name = "rbRefrigerador"
        Me.rbRefrigerador.Size = New System.Drawing.Size(83, 17)
        Me.rbRefrigerador.TabIndex = 4
        Me.rbRefrigerador.TabStop = True
        Me.rbRefrigerador.Text = "Refrigerador"
        Me.rbRefrigerador.UseVisualStyleBackColor = True
        '
        'rbDeposito
        '
        Me.rbDeposito.AutoSize = True
        Me.rbDeposito.Location = New System.Drawing.Point(207, 46)
        Me.rbDeposito.Name = "rbDeposito"
        Me.rbDeposito.Size = New System.Drawing.Size(67, 17)
        Me.rbDeposito.TabIndex = 5
        Me.rbDeposito.TabStop = True
        Me.rbDeposito.Text = "Deposito"
        Me.rbDeposito.UseVisualStyleBackColor = True
        '
        'grpbUbicacion
        '
        Me.grpbUbicacion.Controls.Add(Me.rbGondola)
        Me.grpbUbicacion.Controls.Add(Me.rbDeposito)
        Me.grpbUbicacion.Controls.Add(Me.rbRefrigerador)
        Me.grpbUbicacion.Location = New System.Drawing.Point(244, 232)
        Me.grpbUbicacion.Name = "grpbUbicacion"
        Me.grpbUbicacion.Size = New System.Drawing.Size(280, 100)
        Me.grpbUbicacion.TabIndex = 6
        Me.grpbUbicacion.TabStop = False
        Me.grpbUbicacion.Text = "Ubicacion"
        '
        'chkDisponibilidad
        '
        Me.chkDisponibilidad.AutoSize = True
        Me.chkDisponibilidad.Location = New System.Drawing.Point(353, 199)
        Me.chkDisponibilidad.Name = "chkDisponibilidad"
        Me.chkDisponibilidad.Size = New System.Drawing.Size(91, 17)
        Me.chkDisponibilidad.TabIndex = 7
        Me.chkDisponibilidad.Text = "Disponibilidad"
        Me.chkDisponibilidad.UseVisualStyleBackColor = True
        '
        'dtpFechavencimiento
        '
        Me.dtpFechavencimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechavencimiento.Location = New System.Drawing.Point(310, 163)
        Me.dtpFechavencimiento.Name = "dtpFechavencimiento"
        Me.dtpFechavencimiento.ShowCheckBox = True
        Me.dtpFechavencimiento.Size = New System.Drawing.Size(171, 20)
        Me.dtpFechavencimiento.TabIndex = 8
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Location = New System.Drawing.Point(338, 356)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(106, 42)
        Me.btnRegistrar.TabIndex = 9
        Me.btnRegistrar.Text = "Registrar"
        Me.btnRegistrar.UseVisualStyleBackColor = True
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(261, 53)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(43, 13)
        Me.lblCodigo.TabIndex = 10
        Me.lblCodigo.Text = "Codigo:"
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Location = New System.Drawing.Point(241, 92)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(66, 13)
        Me.lblDescripcion.TabIndex = 11
        Me.lblDescripcion.Text = "Descripcion:"
        '
        'lblCategoria
        '
        Me.lblCategoria.AutoSize = True
        Me.lblCategoria.Location = New System.Drawing.Point(249, 128)
        Me.lblCategoria.Name = "lblCategoria"
        Me.lblCategoria.Size = New System.Drawing.Size(55, 13)
        Me.lblCategoria.TabIndex = 12
        Me.lblCategoria.Text = "Categoria:"
        '
        'lblFechaVenc
        '
        Me.lblFechaVenc.AutoSize = True
        Me.lblFechaVenc.Location = New System.Drawing.Point(194, 169)
        Me.lblFechaVenc.Name = "lblFechaVenc"
        Me.lblFechaVenc.Size = New System.Drawing.Size(116, 13)
        Me.lblFechaVenc.TabIndex = 13
        Me.lblFechaVenc.Text = "Fecha de Vencimiento:"
        '
        'frmAlta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblFechaVenc)
        Me.Controls.Add(Me.lblCategoria)
        Me.Controls.Add(Me.lblDescripcion)
        Me.Controls.Add(Me.lblCodigo)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.dtpFechavencimiento)
        Me.Controls.Add(Me.chkDisponibilidad)
        Me.Controls.Add(Me.grpbUbicacion)
        Me.Controls.Add(Me.cbxCategoria)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.mskCodigo)
        Me.Name = "frmAlta"
        Me.Text = "Alta de Productos"
        Me.grpbUbicacion.ResumeLayout(False)
        Me.grpbUbicacion.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mskCodigo As MaskedTextBox
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents cbxCategoria As ComboBox
    Friend WithEvents rbGondola As RadioButton
    Friend WithEvents rbRefrigerador As RadioButton
    Friend WithEvents rbDeposito As RadioButton
    Friend WithEvents grpbUbicacion As GroupBox
    Friend WithEvents chkDisponibilidad As CheckBox
    Friend WithEvents dtpFechavencimiento As DateTimePicker
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents lblCodigo As Label
    Friend WithEvents lblDescripcion As Label
    Friend WithEvents lblCategoria As Label
    Friend WithEvents lblFechaVenc As Label
End Class
