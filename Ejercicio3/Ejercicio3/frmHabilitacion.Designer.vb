<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHabilitacion
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
        Me.btnHabilitaryDeshabilitar = New System.Windows.Forms.Button()
        Me.lblTexto = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnHabilitaryDeshabilitar
        '
        Me.btnHabilitaryDeshabilitar.Location = New System.Drawing.Point(57, 74)
        Me.btnHabilitaryDeshabilitar.Name = "btnHabilitaryDeshabilitar"
        Me.btnHabilitaryDeshabilitar.Size = New System.Drawing.Size(446, 76)
        Me.btnHabilitaryDeshabilitar.TabIndex = 0
        Me.btnHabilitaryDeshabilitar.Text = "Deshabilitar"
        Me.btnHabilitaryDeshabilitar.UseVisualStyleBackColor = True
        '
        'lblTexto
        '
        Me.lblTexto.AutoSize = True
        Me.lblTexto.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTexto.Location = New System.Drawing.Point(49, 217)
        Me.lblTexto.Name = "lblTexto"
        Me.lblTexto.Size = New System.Drawing.Size(454, 55)
        Me.lblTexto.TabIndex = 1
        Me.lblTexto.Text = "Mensaje de prueba"
        '
        'frmHabilitacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(558, 331)
        Me.Controls.Add(Me.lblTexto)
        Me.Controls.Add(Me.btnHabilitaryDeshabilitar)
        Me.Name = "frmHabilitacion"
        Me.Text = "frmHabilitacion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnHabilitaryDeshabilitar As Button
    Friend WithEvents lblTexto As Label
End Class
