<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCargar
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
        Me.lsvDatos = New System.Windows.Forms.ListView()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.lblMercaderia = New System.Windows.Forms.Label()
        Me.txtMercaderia = New System.Windows.Forms.TextBox()
        Me.cbxPaisDestino = New System.Windows.Forms.ComboBox()
        Me.lblPaisDestino = New System.Windows.Forms.Label()
        Me.rbTecnologia = New System.Windows.Forms.RadioButton()
        Me.lblTipoMercaderia = New System.Windows.Forms.Label()
        Me.rbVehiculos = New System.Windows.Forms.RadioButton()
        Me.rbVestimenta = New System.Windows.Forms.RadioButton()
        Me.rbVarios = New System.Windows.Forms.RadioButton()
        Me.txtPeso = New System.Windows.Forms.TextBox()
        Me.lblPeso = New System.Windows.Forms.Label()
        Me.dtpFechaEmbarque = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaEmbarque = New System.Windows.Forms.Label()
        Me.chkLucas = New System.Windows.Forms.CheckBox()
        Me.lblResponsables = New System.Windows.Forms.Label()
        Me.chkLucia = New System.Windows.Forms.CheckBox()
        Me.chkRamon = New System.Windows.Forms.CheckBox()
        Me.btnCargar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lsvDatos
        '
        Me.lsvDatos.HideSelection = False
        Me.lsvDatos.Location = New System.Drawing.Point(11, 185)
        Me.lsvDatos.Name = "lsvDatos"
        Me.lsvDatos.Size = New System.Drawing.Size(1025, 409)
        Me.lsvDatos.TabIndex = 0
        Me.lsvDatos.UseCompatibleStateImageBehavior = False
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(113, 9)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(148, 20)
        Me.txtCodigo.TabIndex = 1
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigo.Location = New System.Drawing.Point(29, 12)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(46, 13)
        Me.lblCodigo.TabIndex = 2
        Me.lblCodigo.Text = "Codigo"
        '
        'lblMercaderia
        '
        Me.lblMercaderia.AutoSize = True
        Me.lblMercaderia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMercaderia.Location = New System.Drawing.Point(16, 40)
        Me.lblMercaderia.Name = "lblMercaderia"
        Me.lblMercaderia.Size = New System.Drawing.Size(70, 13)
        Me.lblMercaderia.TabIndex = 3
        Me.lblMercaderia.Text = "Mercaderia"
        '
        'txtMercaderia
        '
        Me.txtMercaderia.Location = New System.Drawing.Point(113, 37)
        Me.txtMercaderia.Name = "txtMercaderia"
        Me.txtMercaderia.Size = New System.Drawing.Size(247, 20)
        Me.txtMercaderia.TabIndex = 4
        '
        'cbxPaisDestino
        '
        Me.cbxPaisDestino.FormattingEnabled = True
        Me.cbxPaisDestino.Location = New System.Drawing.Point(113, 63)
        Me.cbxPaisDestino.Name = "cbxPaisDestino"
        Me.cbxPaisDestino.Size = New System.Drawing.Size(148, 21)
        Me.cbxPaisDestino.TabIndex = 5
        '
        'lblPaisDestino
        '
        Me.lblPaisDestino.AutoSize = True
        Me.lblPaisDestino.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaisDestino.Location = New System.Drawing.Point(16, 71)
        Me.lblPaisDestino.Name = "lblPaisDestino"
        Me.lblPaisDestino.Size = New System.Drawing.Size(78, 13)
        Me.lblPaisDestino.TabIndex = 6
        Me.lblPaisDestino.Text = "Pais Destino"
        '
        'rbTecnologia
        '
        Me.rbTecnologia.AutoSize = True
        Me.rbTecnologia.Location = New System.Drawing.Point(113, 103)
        Me.rbTecnologia.Name = "rbTecnologia"
        Me.rbTecnologia.Size = New System.Drawing.Size(78, 17)
        Me.rbTecnologia.TabIndex = 7
        Me.rbTecnologia.TabStop = True
        Me.rbTecnologia.Text = "Tecnologia"
        Me.rbTecnologia.UseVisualStyleBackColor = True
        '
        'lblTipoMercaderia
        '
        Me.lblTipoMercaderia.AutoSize = True
        Me.lblTipoMercaderia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoMercaderia.Location = New System.Drawing.Point(8, 103)
        Me.lblTipoMercaderia.Name = "lblTipoMercaderia"
        Me.lblTipoMercaderia.Size = New System.Drawing.Size(99, 13)
        Me.lblTipoMercaderia.TabIndex = 8
        Me.lblTipoMercaderia.Text = "Tipo Mercaderia"
        '
        'rbVehiculos
        '
        Me.rbVehiculos.AutoSize = True
        Me.rbVehiculos.Location = New System.Drawing.Point(191, 103)
        Me.rbVehiculos.Name = "rbVehiculos"
        Me.rbVehiculos.Size = New System.Drawing.Size(71, 17)
        Me.rbVehiculos.TabIndex = 9
        Me.rbVehiculos.TabStop = True
        Me.rbVehiculos.Text = "Vehiculos"
        Me.rbVehiculos.UseVisualStyleBackColor = True
        '
        'rbVestimenta
        '
        Me.rbVestimenta.AutoSize = True
        Me.rbVestimenta.Location = New System.Drawing.Point(268, 103)
        Me.rbVestimenta.Name = "rbVestimenta"
        Me.rbVestimenta.Size = New System.Drawing.Size(77, 17)
        Me.rbVestimenta.TabIndex = 10
        Me.rbVestimenta.TabStop = True
        Me.rbVestimenta.Text = "Vestimenta"
        Me.rbVestimenta.UseVisualStyleBackColor = True
        '
        'rbVarios
        '
        Me.rbVarios.AutoSize = True
        Me.rbVarios.Location = New System.Drawing.Point(351, 103)
        Me.rbVarios.Name = "rbVarios"
        Me.rbVarios.Size = New System.Drawing.Size(54, 17)
        Me.rbVarios.TabIndex = 11
        Me.rbVarios.TabStop = True
        Me.rbVarios.Text = "Varios"
        Me.rbVarios.UseVisualStyleBackColor = True
        '
        'txtPeso
        '
        Me.txtPeso.Location = New System.Drawing.Point(519, 12)
        Me.txtPeso.Name = "txtPeso"
        Me.txtPeso.Size = New System.Drawing.Size(148, 20)
        Me.txtPeso.TabIndex = 12
        '
        'lblPeso
        '
        Me.lblPeso.AutoSize = True
        Me.lblPeso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPeso.Location = New System.Drawing.Point(477, 16)
        Me.lblPeso.Name = "lblPeso"
        Me.lblPeso.Size = New System.Drawing.Size(35, 13)
        Me.lblPeso.TabIndex = 13
        Me.lblPeso.Text = "Peso"
        '
        'dtpFechaEmbarque
        '
        Me.dtpFechaEmbarque.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaEmbarque.Location = New System.Drawing.Point(519, 38)
        Me.dtpFechaEmbarque.MinDate = New Date(2020, 1, 1, 0, 0, 0, 0)
        Me.dtpFechaEmbarque.Name = "dtpFechaEmbarque"
        Me.dtpFechaEmbarque.Size = New System.Drawing.Size(149, 20)
        Me.dtpFechaEmbarque.TabIndex = 14
        '
        'lblFechaEmbarque
        '
        Me.lblFechaEmbarque.AutoSize = True
        Me.lblFechaEmbarque.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaEmbarque.Location = New System.Drawing.Point(410, 40)
        Me.lblFechaEmbarque.Name = "lblFechaEmbarque"
        Me.lblFechaEmbarque.Size = New System.Drawing.Size(102, 13)
        Me.lblFechaEmbarque.TabIndex = 15
        Me.lblFechaEmbarque.Text = "Fecha Embarque"
        '
        'chkLucas
        '
        Me.chkLucas.AutoSize = True
        Me.chkLucas.Location = New System.Drawing.Point(519, 71)
        Me.chkLucas.Name = "chkLucas"
        Me.chkLucas.Size = New System.Drawing.Size(55, 17)
        Me.chkLucas.TabIndex = 16
        Me.chkLucas.Text = "Lucas"
        Me.chkLucas.UseVisualStyleBackColor = True
        '
        'lblResponsables
        '
        Me.lblResponsables.AutoSize = True
        Me.lblResponsables.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResponsables.Location = New System.Drawing.Point(410, 71)
        Me.lblResponsables.Name = "lblResponsables"
        Me.lblResponsables.Size = New System.Drawing.Size(86, 13)
        Me.lblResponsables.TabIndex = 17
        Me.lblResponsables.Text = "Responsables"
        '
        'chkLucia
        '
        Me.chkLucia.AutoSize = True
        Me.chkLucia.Location = New System.Drawing.Point(580, 71)
        Me.chkLucia.Name = "chkLucia"
        Me.chkLucia.Size = New System.Drawing.Size(52, 17)
        Me.chkLucia.TabIndex = 18
        Me.chkLucia.Text = "Lucia"
        Me.chkLucia.UseVisualStyleBackColor = True
        '
        'chkRamon
        '
        Me.chkRamon.AutoSize = True
        Me.chkRamon.Location = New System.Drawing.Point(638, 71)
        Me.chkRamon.Name = "chkRamon"
        Me.chkRamon.Size = New System.Drawing.Size(60, 17)
        Me.chkRamon.TabIndex = 19
        Me.chkRamon.Text = "Ramon"
        Me.chkRamon.UseVisualStyleBackColor = True
        '
        'btnCargar
        '
        Me.btnCargar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCargar.Location = New System.Drawing.Point(759, 12)
        Me.btnCargar.Name = "btnCargar"
        Me.btnCargar.Size = New System.Drawing.Size(268, 155)
        Me.btnCargar.TabIndex = 20
        Me.btnCargar.Text = "Cargar"
        Me.btnCargar.UseVisualStyleBackColor = True
        '
        'frmCargar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1039, 606)
        Me.Controls.Add(Me.btnCargar)
        Me.Controls.Add(Me.chkRamon)
        Me.Controls.Add(Me.chkLucia)
        Me.Controls.Add(Me.lblResponsables)
        Me.Controls.Add(Me.chkLucas)
        Me.Controls.Add(Me.lblFechaEmbarque)
        Me.Controls.Add(Me.dtpFechaEmbarque)
        Me.Controls.Add(Me.lblPeso)
        Me.Controls.Add(Me.txtPeso)
        Me.Controls.Add(Me.rbVarios)
        Me.Controls.Add(Me.rbVestimenta)
        Me.Controls.Add(Me.rbVehiculos)
        Me.Controls.Add(Me.lblTipoMercaderia)
        Me.Controls.Add(Me.rbTecnologia)
        Me.Controls.Add(Me.lblPaisDestino)
        Me.Controls.Add(Me.cbxPaisDestino)
        Me.Controls.Add(Me.txtMercaderia)
        Me.Controls.Add(Me.lblMercaderia)
        Me.Controls.Add(Me.lblCodigo)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.lsvDatos)
        Me.Name = "frmCargar"
        Me.Text = "Ejercicio de Practica"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lsvDatos As ListView
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents lblCodigo As Label
    Friend WithEvents lblMercaderia As Label
    Friend WithEvents txtMercaderia As TextBox
    Friend WithEvents cbxPaisDestino As ComboBox
    Friend WithEvents lblPaisDestino As Label
    Friend WithEvents rbTecnologia As RadioButton
    Friend WithEvents lblTipoMercaderia As Label
    Friend WithEvents rbVehiculos As RadioButton
    Friend WithEvents rbVestimenta As RadioButton
    Friend WithEvents rbVarios As RadioButton
    Friend WithEvents txtPeso As TextBox
    Friend WithEvents lblPeso As Label
    Friend WithEvents dtpFechaEmbarque As DateTimePicker
    Friend WithEvents lblFechaEmbarque As Label
    Friend WithEvents chkLucas As CheckBox
    Friend WithEvents lblResponsables As Label
    Friend WithEvents chkLucia As CheckBox
    Friend WithEvents chkRamon As CheckBox
    Friend WithEvents btnCargar As Button
End Class
