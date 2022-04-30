<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEjercicio6
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
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.btnLeer = New System.Windows.Forms.Button()
        Me.txtRegistar = New System.Windows.Forms.TextBox()
        Me.txtLeer = New System.Windows.Forms.TextBox()
        Me.lblRegistar = New System.Windows.Forms.Label()
        Me.lblLeer = New System.Windows.Forms.Label()
        Me.SFD = New System.Windows.Forms.SaveFileDialog()
        Me.OFD = New System.Windows.Forms.OpenFileDialog()
        Me.lblCantLineas = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Location = New System.Drawing.Point(288, 211)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(75, 23)
        Me.btnRegistrar.TabIndex = 0
        Me.btnRegistrar.Text = "Registrar"
        Me.btnRegistrar.UseVisualStyleBackColor = True
        '
        'btnLeer
        '
        Me.btnLeer.Location = New System.Drawing.Point(288, 434)
        Me.btnLeer.Name = "btnLeer"
        Me.btnLeer.Size = New System.Drawing.Size(75, 23)
        Me.btnLeer.TabIndex = 1
        Me.btnLeer.Text = "Leer"
        Me.btnLeer.UseVisualStyleBackColor = True
        '
        'txtRegistar
        '
        Me.txtRegistar.Location = New System.Drawing.Point(95, 12)
        Me.txtRegistar.Multiline = True
        Me.txtRegistar.Name = "txtRegistar"
        Me.txtRegistar.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtRegistar.Size = New System.Drawing.Size(481, 183)
        Me.txtRegistar.TabIndex = 2
        '
        'txtLeer
        '
        Me.txtLeer.Location = New System.Drawing.Point(95, 249)
        Me.txtLeer.Multiline = True
        Me.txtLeer.Name = "txtLeer"
        Me.txtLeer.ReadOnly = True
        Me.txtLeer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtLeer.Size = New System.Drawing.Size(481, 175)
        Me.txtLeer.TabIndex = 3
        '
        'lblRegistar
        '
        Me.lblRegistar.AutoSize = True
        Me.lblRegistar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegistar.Location = New System.Drawing.Point(12, 74)
        Me.lblRegistar.Name = "lblRegistar"
        Me.lblRegistar.Size = New System.Drawing.Size(77, 20)
        Me.lblRegistar.TabIndex = 4
        Me.lblRegistar.Text = "Registar"
        '
        'lblLeer
        '
        Me.lblLeer.AutoSize = True
        Me.lblLeer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLeer.Location = New System.Drawing.Point(27, 339)
        Me.lblLeer.Name = "lblLeer"
        Me.lblLeer.Size = New System.Drawing.Size(45, 20)
        Me.lblLeer.TabIndex = 5
        Me.lblLeer.Text = "Leer"
        '
        'OFD
        '
        Me.OFD.FileName = "OFD"
        '
        'lblCantLineas
        '
        Me.lblCantLineas.AutoSize = True
        Me.lblCantLineas.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantLineas.Location = New System.Drawing.Point(439, 439)
        Me.lblCantLineas.Name = "lblCantLineas"
        Me.lblCantLineas.Size = New System.Drawing.Size(17, 18)
        Me.lblCantLineas.TabIndex = 6
        Me.lblCantLineas.Text = "0"
        '
        'frmEjercicio6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(588, 469)
        Me.Controls.Add(Me.lblCantLineas)
        Me.Controls.Add(Me.lblLeer)
        Me.Controls.Add(Me.lblRegistar)
        Me.Controls.Add(Me.txtLeer)
        Me.Controls.Add(Me.txtRegistar)
        Me.Controls.Add(Me.btnLeer)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Name = "frmEjercicio6"
        Me.Text = "Ejercicio 6"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnRegistrar As Button
    Friend WithEvents btnLeer As Button
    Friend WithEvents txtRegistar As TextBox
    Friend WithEvents txtLeer As TextBox
    Friend WithEvents lblRegistar As Label
    Friend WithEvents lblLeer As Label
    Friend WithEvents SFD As SaveFileDialog
    Friend WithEvents OFD As OpenFileDialog
    Friend WithEvents lblCantLineas As Label
End Class
