<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEjercicio4
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lsvLista = New System.Windows.Forms.ListView()
        Me.btnCalcularHijo = New System.Windows.Forms.Button()
        Me.lblCalcular = New System.Windows.Forms.Label()
        Me.btnCalcularSalario = New System.Windows.Forms.Button()
        Me.cbxEstadoCivil = New System.Windows.Forms.ComboBox()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.lblEstadoCivil = New System.Windows.Forms.Label()
        Me.lblDNI = New System.Windows.Forms.Label()
        Me.txtDNI = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblFechaNacimiento = New System.Windows.Forms.Label()
        Me.txtCantHijos = New System.Windows.Forms.TextBox()
        Me.txtSalario = New System.Windows.Forms.TextBox()
        Me.lblCantHijos = New System.Windows.Forms.Label()
        Me.lblSalario = New System.Windows.Forms.Label()
        Me.dtpFechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'lsvLista
        '
        Me.lsvLista.HideSelection = False
        Me.lsvLista.Location = New System.Drawing.Point(13, 119)
        Me.lsvLista.Name = "lsvLista"
        Me.lsvLista.Size = New System.Drawing.Size(1154, 353)
        Me.lsvLista.TabIndex = 0
        Me.lsvLista.UseCompatibleStateImageBehavior = False
        '
        'btnCalcularHijo
        '
        Me.btnCalcularHijo.Location = New System.Drawing.Point(919, 490)
        Me.btnCalcularHijo.Name = "btnCalcularHijo"
        Me.btnCalcularHijo.Size = New System.Drawing.Size(122, 47)
        Me.btnCalcularHijo.TabIndex = 1
        Me.btnCalcularHijo.Text = "Calcular Hijos"
        Me.btnCalcularHijo.UseVisualStyleBackColor = True
        '
        'lblCalcular
        '
        Me.lblCalcular.AutoSize = True
        Me.lblCalcular.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCalcular.Location = New System.Drawing.Point(1067, 503)
        Me.lblCalcular.Name = "lblCalcular"
        Me.lblCalcular.Size = New System.Drawing.Size(17, 18)
        Me.lblCalcular.TabIndex = 2
        Me.lblCalcular.Text = "0"
        '
        'btnCalcularSalario
        '
        Me.btnCalcularSalario.Location = New System.Drawing.Point(779, 491)
        Me.btnCalcularSalario.Name = "btnCalcularSalario"
        Me.btnCalcularSalario.Size = New System.Drawing.Size(124, 46)
        Me.btnCalcularSalario.TabIndex = 3
        Me.btnCalcularSalario.Text = "Calcular Salarios"
        Me.btnCalcularSalario.UseVisualStyleBackColor = True
        '
        'cbxEstadoCivil
        '
        Me.cbxEstadoCivil.FormattingEnabled = True
        Me.cbxEstadoCivil.Location = New System.Drawing.Point(89, 91)
        Me.cbxEstadoCivil.Name = "cbxEstadoCivil"
        Me.cbxEstadoCivil.Size = New System.Drawing.Size(228, 21)
        Me.cbxEstadoCivil.TabIndex = 4
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Location = New System.Drawing.Point(1054, 12)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(113, 92)
        Me.btnRegistrar.TabIndex = 5
        Me.btnRegistrar.Text = "Registrar"
        Me.btnRegistrar.UseVisualStyleBackColor = True
        '
        'lblEstadoCivil
        '
        Me.lblEstadoCivil.AutoSize = True
        Me.lblEstadoCivil.Location = New System.Drawing.Point(24, 94)
        Me.lblEstadoCivil.Name = "lblEstadoCivil"
        Me.lblEstadoCivil.Size = New System.Drawing.Size(62, 13)
        Me.lblEstadoCivil.TabIndex = 6
        Me.lblEstadoCivil.Text = "Estado Civil"
        '
        'lblDNI
        '
        Me.lblDNI.AutoSize = True
        Me.lblDNI.Location = New System.Drawing.Point(57, 13)
        Me.lblDNI.Name = "lblDNI"
        Me.lblDNI.Size = New System.Drawing.Size(26, 13)
        Me.lblDNI.TabIndex = 7
        Me.lblDNI.Text = "DNI"
        '
        'txtDNI
        '
        Me.txtDNI.Location = New System.Drawing.Point(89, 13)
        Me.txtDNI.MaxLength = 8
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.Size = New System.Drawing.Size(109, 20)
        Me.txtDNI.TabIndex = 8
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(89, 40)
        Me.txtApellido.MaxLength = 30
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(228, 20)
        Me.txtApellido.TabIndex = 9
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Location = New System.Drawing.Point(39, 43)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(44, 13)
        Me.lblApellido.TabIndex = 10
        Me.lblApellido.Text = "Apellido"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(89, 65)
        Me.txtNombre.MaxLength = 30
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(228, 20)
        Me.txtNombre.TabIndex = 11
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(42, 71)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(44, 13)
        Me.lblNombre.TabIndex = 12
        Me.lblNombre.Text = "Nombre"
        '
        'lblFechaNacimiento
        '
        Me.lblFechaNacimiento.AutoSize = True
        Me.lblFechaNacimiento.Location = New System.Drawing.Point(390, 15)
        Me.lblFechaNacimiento.Name = "lblFechaNacimiento"
        Me.lblFechaNacimiento.Size = New System.Drawing.Size(93, 13)
        Me.lblFechaNacimiento.TabIndex = 13
        Me.lblFechaNacimiento.Text = "Fecha Nacimiento"
        '
        'txtCantHijos
        '
        Me.txtCantHijos.Location = New System.Drawing.Point(509, 38)
        Me.txtCantHijos.MaxLength = 2
        Me.txtCantHijos.Name = "txtCantHijos"
        Me.txtCantHijos.Size = New System.Drawing.Size(39, 20)
        Me.txtCantHijos.TabIndex = 15
        '
        'txtSalario
        '
        Me.txtSalario.Location = New System.Drawing.Point(509, 64)
        Me.txtSalario.Name = "txtSalario"
        Me.txtSalario.Size = New System.Drawing.Size(228, 20)
        Me.txtSalario.TabIndex = 16
        '
        'lblCantHijos
        '
        Me.lblCantHijos.AutoSize = True
        Me.lblCantHijos.Location = New System.Drawing.Point(425, 41)
        Me.lblCantHijos.Name = "lblCantHijos"
        Me.lblCantHijos.Size = New System.Drawing.Size(58, 13)
        Me.lblCantHijos.TabIndex = 18
        Me.lblCantHijos.Text = "Cant. Hijos"
        '
        'lblSalario
        '
        Me.lblSalario.AutoSize = True
        Me.lblSalario.Location = New System.Drawing.Point(444, 65)
        Me.lblSalario.Name = "lblSalario"
        Me.lblSalario.Size = New System.Drawing.Size(39, 13)
        Me.lblSalario.TabIndex = 19
        Me.lblSalario.Text = "Salario"
        '
        'dtpFechaNacimiento
        '
        Me.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaNacimiento.Location = New System.Drawing.Point(509, 13)
        Me.dtpFechaNacimiento.Name = "dtpFechaNacimiento"
        Me.dtpFechaNacimiento.Size = New System.Drawing.Size(105, 20)
        Me.dtpFechaNacimiento.TabIndex = 20
        '
        'frmEjercicio4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1179, 549)
        Me.Controls.Add(Me.dtpFechaNacimiento)
        Me.Controls.Add(Me.lblSalario)
        Me.Controls.Add(Me.lblCantHijos)
        Me.Controls.Add(Me.txtSalario)
        Me.Controls.Add(Me.txtCantHijos)
        Me.Controls.Add(Me.lblFechaNacimiento)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lblApellido)
        Me.Controls.Add(Me.txtApellido)
        Me.Controls.Add(Me.txtDNI)
        Me.Controls.Add(Me.lblDNI)
        Me.Controls.Add(Me.lblEstadoCivil)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.cbxEstadoCivil)
        Me.Controls.Add(Me.btnCalcularSalario)
        Me.Controls.Add(Me.lblCalcular)
        Me.Controls.Add(Me.btnCalcularHijo)
        Me.Controls.Add(Me.lsvLista)
        Me.Name = "frmEjercicio4"
        Me.Text = "Ejercicio 4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lsvLista As ListView
    Friend WithEvents btnCalcularHijo As Button
    Friend WithEvents lblCalcular As Label
    Friend WithEvents btnCalcularSalario As Button
    Friend WithEvents cbxEstadoCivil As ComboBox
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents lblEstadoCivil As Label
    Friend WithEvents lblDNI As Label
    Friend WithEvents txtDNI As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents lblApellido As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblFechaNacimiento As Label
    Friend WithEvents txtCantHijos As TextBox
    Friend WithEvents txtSalario As TextBox
    Friend WithEvents lblCantHijos As Label
    Friend WithEvents lblSalario As Label
    Friend WithEvents dtpFechaNacimiento As DateTimePicker
End Class
