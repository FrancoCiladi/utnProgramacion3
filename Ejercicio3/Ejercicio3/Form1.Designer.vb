<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEjercicio3
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuOpciones = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHabilitacion = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuVisualizacion = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuOpciones})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(554, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuOpciones
        '
        Me.mnuOpciones.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuHabilitacion, Me.mnuVisualizacion})
        Me.mnuOpciones.Name = "mnuOpciones"
        Me.mnuOpciones.Size = New System.Drawing.Size(69, 20)
        Me.mnuOpciones.Text = "Opciones"
        '
        'mnuHabilitacion
        '
        Me.mnuHabilitacion.Name = "mnuHabilitacion"
        Me.mnuHabilitacion.Size = New System.Drawing.Size(180, 22)
        Me.mnuHabilitacion.Text = "Habilitacion"
        '
        'mnuVisualizacion
        '
        Me.mnuVisualizacion.Name = "mnuVisualizacion"
        Me.mnuVisualizacion.Size = New System.Drawing.Size(180, 22)
        Me.mnuVisualizacion.Text = "Visualizacion"
        '
        'frmEjercicio3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(554, 354)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmEjercicio3"
        Me.Text = "Formulario Principal"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuOpciones As ToolStripMenuItem
    Friend WithEvents mnuHabilitacion As ToolStripMenuItem
    Friend WithEvents mnuVisualizacion As ToolStripMenuItem
End Class
