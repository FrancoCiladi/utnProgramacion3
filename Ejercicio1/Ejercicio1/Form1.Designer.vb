<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEjercicio1
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
        Me.txtIngreso = New System.Windows.Forms.TextBox()
        Me.btnCopiar = New System.Windows.Forms.Button()
        Me.lblCopia = New System.Windows.Forms.Label()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtIngreso
        '
        Me.txtIngreso.Location = New System.Drawing.Point(36, 60)
        Me.txtIngreso.Name = "txtIngreso"
        Me.txtIngreso.Size = New System.Drawing.Size(324, 20)
        Me.txtIngreso.TabIndex = 0
        '
        'btnCopiar
        '
        Me.btnCopiar.Location = New System.Drawing.Point(36, 154)
        Me.btnCopiar.Name = "btnCopiar"
        Me.btnCopiar.Size = New System.Drawing.Size(144, 23)
        Me.btnCopiar.TabIndex = 1
        Me.btnCopiar.Text = "Copiar"
        Me.btnCopiar.UseVisualStyleBackColor = True
        '
        'lblCopia
        '
        Me.lblCopia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCopia.Location = New System.Drawing.Point(36, 256)
        Me.lblCopia.Name = "lblCopia"
        Me.lblCopia.Size = New System.Drawing.Size(324, 23)
        Me.lblCopia.TabIndex = 2
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(216, 154)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(144, 23)
        Me.btnLimpiar.TabIndex = 3
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'frmEjercicio1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(402, 320)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.lblCopia)
        Me.Controls.Add(Me.btnCopiar)
        Me.Controls.Add(Me.txtIngreso)
        Me.Name = "frmEjercicio1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ejercicio 1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtIngreso As TextBox
    Friend WithEvents btnCopiar As Button
    Friend WithEvents lblCopia As Label
    Friend WithEvents btnLimpiar As Button
End Class
