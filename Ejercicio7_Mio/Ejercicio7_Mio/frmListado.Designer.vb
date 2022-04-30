<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListado
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
        Me.lsvProductos = New System.Windows.Forms.ListView()
        Me.rbTodos = New System.Windows.Forms.RadioButton()
        Me.rbPorCategoria = New System.Windows.Forms.RadioButton()
        Me.grpbVerProductos = New System.Windows.Forms.GroupBox()
        Me.cbxCategoria = New System.Windows.Forms.ComboBox()
        Me.lblCategorias = New System.Windows.Forms.Label()
        Me.btnFiltrar = New System.Windows.Forms.Button()
        Me.lblCantProd = New System.Windows.Forms.Label()
        Me.chkSoloDisp = New System.Windows.Forms.CheckBox()
        Me.grpbVerProductos.SuspendLayout()
        Me.SuspendLayout()
        '
        'lsvProductos
        '
        Me.lsvProductos.HideSelection = False
        Me.lsvProductos.Location = New System.Drawing.Point(259, 12)
        Me.lsvProductos.Name = "lsvProductos"
        Me.lsvProductos.Size = New System.Drawing.Size(717, 534)
        Me.lsvProductos.TabIndex = 0
        Me.lsvProductos.UseCompatibleStateImageBehavior = False
        '
        'rbTodos
        '
        Me.rbTodos.AutoSize = True
        Me.rbTodos.Location = New System.Drawing.Point(16, 45)
        Me.rbTodos.Name = "rbTodos"
        Me.rbTodos.Size = New System.Drawing.Size(55, 17)
        Me.rbTodos.TabIndex = 1
        Me.rbTodos.TabStop = True
        Me.rbTodos.Text = "Todos"
        Me.rbTodos.UseVisualStyleBackColor = True
        '
        'rbPorCategoria
        '
        Me.rbPorCategoria.AutoSize = True
        Me.rbPorCategoria.Location = New System.Drawing.Point(92, 45)
        Me.rbPorCategoria.Name = "rbPorCategoria"
        Me.rbPorCategoria.Size = New System.Drawing.Size(89, 17)
        Me.rbPorCategoria.TabIndex = 2
        Me.rbPorCategoria.TabStop = True
        Me.rbPorCategoria.Text = "Por Categoria"
        Me.rbPorCategoria.UseVisualStyleBackColor = True
        '
        'grpbVerProductos
        '
        Me.grpbVerProductos.Controls.Add(Me.rbTodos)
        Me.grpbVerProductos.Controls.Add(Me.rbPorCategoria)
        Me.grpbVerProductos.Location = New System.Drawing.Point(20, 56)
        Me.grpbVerProductos.Name = "grpbVerProductos"
        Me.grpbVerProductos.Size = New System.Drawing.Size(200, 100)
        Me.grpbVerProductos.TabIndex = 3
        Me.grpbVerProductos.TabStop = False
        Me.grpbVerProductos.Text = "Ver Productos"
        '
        'cbxCategoria
        '
        Me.cbxCategoria.FormattingEnabled = True
        Me.cbxCategoria.Location = New System.Drawing.Point(83, 199)
        Me.cbxCategoria.Name = "cbxCategoria"
        Me.cbxCategoria.Size = New System.Drawing.Size(125, 21)
        Me.cbxCategoria.TabIndex = 4
        '
        'lblCategorias
        '
        Me.lblCategorias.AutoSize = True
        Me.lblCategorias.Location = New System.Drawing.Point(17, 202)
        Me.lblCategorias.Name = "lblCategorias"
        Me.lblCategorias.Size = New System.Drawing.Size(60, 13)
        Me.lblCategorias.TabIndex = 5
        Me.lblCategorias.Text = "Categorias:"
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Location = New System.Drawing.Point(63, 349)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(118, 58)
        Me.btnFiltrar.TabIndex = 6
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.UseVisualStyleBackColor = True
        '
        'lblCantProd
        '
        Me.lblCantProd.AutoSize = True
        Me.lblCantProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantProd.Location = New System.Drawing.Point(199, 479)
        Me.lblCantProd.Name = "lblCantProd"
        Me.lblCantProd.Size = New System.Drawing.Size(21, 24)
        Me.lblCantProd.TabIndex = 7
        Me.lblCantProd.Text = "0"
        '
        'chkSoloDisp
        '
        Me.chkSoloDisp.AutoSize = True
        Me.chkSoloDisp.Location = New System.Drawing.Point(83, 255)
        Me.chkSoloDisp.Name = "chkSoloDisp"
        Me.chkSoloDisp.Size = New System.Drawing.Size(104, 17)
        Me.chkSoloDisp.TabIndex = 8
        Me.chkSoloDisp.Text = "Solo Disponibles"
        Me.chkSoloDisp.UseVisualStyleBackColor = True
        '
        'frmListado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(988, 558)
        Me.Controls.Add(Me.chkSoloDisp)
        Me.Controls.Add(Me.lblCantProd)
        Me.Controls.Add(Me.btnFiltrar)
        Me.Controls.Add(Me.lblCategorias)
        Me.Controls.Add(Me.cbxCategoria)
        Me.Controls.Add(Me.grpbVerProductos)
        Me.Controls.Add(Me.lsvProductos)
        Me.Name = "frmListado"
        Me.Text = "Listado de Productos"
        Me.grpbVerProductos.ResumeLayout(False)
        Me.grpbVerProductos.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lsvProductos As ListView
    Friend WithEvents rbTodos As RadioButton
    Friend WithEvents rbPorCategoria As RadioButton
    Friend WithEvents grpbVerProductos As GroupBox
    Friend WithEvents cbxCategoria As ComboBox
    Friend WithEvents lblCategorias As Label
    Friend WithEvents btnFiltrar As Button
    Friend WithEvents lblCantProd As Label
    Friend WithEvents chkSoloDisp As CheckBox
End Class
