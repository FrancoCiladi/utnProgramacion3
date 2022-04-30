<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEjercicio2
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
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.cmbMarca = New System.Windows.Forms.ComboBox()
        Me.chkABS = New System.Windows.Forms.CheckBox()
        Me.chkCierreCentralizado = New System.Windows.Forms.CheckBox()
        Me.chkGPS = New System.Windows.Forms.CheckBox()
        Me.rbSedan = New System.Windows.Forms.RadioButton()
        Me.rbHatchBack = New System.Windows.Forms.RadioButton()
        Me.rbSUV = New System.Windows.Forms.RadioButton()
        Me.lblSeleccion = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(155, 283)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 0
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'cmbMarca
        '
        Me.cmbMarca.FormattingEnabled = True
        Me.cmbMarca.Location = New System.Drawing.Point(12, 50)
        Me.cmbMarca.Name = "cmbMarca"
        Me.cmbMarca.Size = New System.Drawing.Size(355, 21)
        Me.cmbMarca.TabIndex = 1
        '
        'chkABS
        '
        Me.chkABS.AutoSize = True
        Me.chkABS.Location = New System.Drawing.Point(31, 138)
        Me.chkABS.Name = "chkABS"
        Me.chkABS.Size = New System.Drawing.Size(47, 17)
        Me.chkABS.TabIndex = 2
        Me.chkABS.Text = "ABS"
        Me.chkABS.UseVisualStyleBackColor = True
        '
        'chkCierreCentralizado
        '
        Me.chkCierreCentralizado.AutoSize = True
        Me.chkCierreCentralizado.Location = New System.Drawing.Point(132, 138)
        Me.chkCierreCentralizado.Name = "chkCierreCentralizado"
        Me.chkCierreCentralizado.Size = New System.Drawing.Size(114, 17)
        Me.chkCierreCentralizado.TabIndex = 3
        Me.chkCierreCentralizado.Text = "Cierre Centralizado"
        Me.chkCierreCentralizado.UseVisualStyleBackColor = True
        '
        'chkGPS
        '
        Me.chkGPS.AutoSize = True
        Me.chkGPS.Location = New System.Drawing.Point(307, 138)
        Me.chkGPS.Name = "chkGPS"
        Me.chkGPS.Size = New System.Drawing.Size(48, 17)
        Me.chkGPS.TabIndex = 4
        Me.chkGPS.Text = "GPS"
        Me.chkGPS.UseVisualStyleBackColor = True
        '
        'rbSedan
        '
        Me.rbSedan.AutoSize = True
        Me.rbSedan.Location = New System.Drawing.Point(31, 206)
        Me.rbSedan.Name = "rbSedan"
        Me.rbSedan.Size = New System.Drawing.Size(56, 17)
        Me.rbSedan.TabIndex = 5
        Me.rbSedan.TabStop = True
        Me.rbSedan.Text = "Sedan"
        Me.rbSedan.UseVisualStyleBackColor = True
        '
        'rbHatchBack
        '
        Me.rbHatchBack.AutoSize = True
        Me.rbHatchBack.Location = New System.Drawing.Point(141, 206)
        Me.rbHatchBack.Name = "rbHatchBack"
        Me.rbHatchBack.Size = New System.Drawing.Size(79, 17)
        Me.rbHatchBack.TabIndex = 6
        Me.rbHatchBack.TabStop = True
        Me.rbHatchBack.Text = "HatchBack"
        Me.rbHatchBack.UseVisualStyleBackColor = True
        '
        'rbSUV
        '
        Me.rbSUV.AutoSize = True
        Me.rbSUV.Location = New System.Drawing.Point(307, 206)
        Me.rbSUV.Name = "rbSUV"
        Me.rbSUV.Size = New System.Drawing.Size(47, 17)
        Me.rbSUV.TabIndex = 7
        Me.rbSUV.TabStop = True
        Me.rbSUV.Text = "SUV"
        Me.rbSUV.UseVisualStyleBackColor = True
        '
        'lblSeleccion
        '
        Me.lblSeleccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSeleccion.Location = New System.Drawing.Point(12, 350)
        Me.lblSeleccion.Name = "lblSeleccion"
        Me.lblSeleccion.Size = New System.Drawing.Size(355, 23)
        Me.lblSeleccion.TabIndex = 8
        '
        'frmEjercicio2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(379, 410)
        Me.Controls.Add(Me.lblSeleccion)
        Me.Controls.Add(Me.rbSUV)
        Me.Controls.Add(Me.rbHatchBack)
        Me.Controls.Add(Me.rbSedan)
        Me.Controls.Add(Me.chkGPS)
        Me.Controls.Add(Me.chkCierreCentralizado)
        Me.Controls.Add(Me.chkABS)
        Me.Controls.Add(Me.cmbMarca)
        Me.Controls.Add(Me.btnAceptar)
        Me.Name = "frmEjercicio2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ejercicio2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAceptar As Button
    Friend WithEvents cmbMarca As ComboBox
    Friend WithEvents chkABS As CheckBox
    Friend WithEvents chkCierreCentralizado As CheckBox
    Friend WithEvents chkGPS As CheckBox
    Friend WithEvents rbSedan As RadioButton
    Friend WithEvents rbHatchBack As RadioButton
    Friend WithEvents rbSUV As RadioButton
    Friend WithEvents lblSeleccion As Label
End Class
