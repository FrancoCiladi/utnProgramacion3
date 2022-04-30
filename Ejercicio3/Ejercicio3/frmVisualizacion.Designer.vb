<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVisualizacion
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
        Me.lblTexto = New System.Windows.Forms.Label()
        Me.btnOcultaryVisualizar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTexto
        '
        Me.lblTexto.AutoSize = True
        Me.lblTexto.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTexto.Location = New System.Drawing.Point(59, 224)
        Me.lblTexto.Name = "lblTexto"
        Me.lblTexto.Size = New System.Drawing.Size(454, 55)
        Me.lblTexto.TabIndex = 0
        Me.lblTexto.Text = "Mensaje de prueba"
        '
        'btnOcultaryVisualizar
        '
        Me.btnOcultaryVisualizar.Location = New System.Drawing.Point(86, 45)
        Me.btnOcultaryVisualizar.Name = "btnOcultaryVisualizar"
        Me.btnOcultaryVisualizar.Size = New System.Drawing.Size(395, 114)
        Me.btnOcultaryVisualizar.TabIndex = 1
        Me.btnOcultaryVisualizar.Text = "Ocultar"
        Me.btnOcultaryVisualizar.UseVisualStyleBackColor = True
        '
        'frmVisualizacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(562, 325)
        Me.Controls.Add(Me.btnOcultaryVisualizar)
        Me.Controls.Add(Me.lblTexto)
        Me.Name = "frmVisualizacion"
        Me.Text = "frmVisualizacion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTexto As Label
    Friend WithEvents btnOcultaryVisualizar As Button
End Class
