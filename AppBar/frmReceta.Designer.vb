<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReceta
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.dgv_clase = New System.Windows.Forms.DataGridView
        Me.dgv_tipo = New System.Windows.Forms.DataGridView
        Me.dgv_subTipo = New System.Windows.Forms.DataGridView
        Me.Label2 = New System.Windows.Forms.Label
        Me.dgv_ingrediente = New System.Windows.Forms.DataGridView
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtIngrediente = New System.Windows.Forms.TextBox
        Me.txtCantidad = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.dgv_receta = New System.Windows.Forms.DataGridView
        Me.btnNuevo = New System.Windows.Forms.Button
        Me.btnSalir = New System.Windows.Forms.Button
        Me.Label9 = New System.Windows.Forms.Label
        Me.btnGrabar = New System.Windows.Forms.Button
        Me.btnModificar = New System.Windows.Forms.Button
        CType(Me.dgv_clase, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_tipo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_subTipo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_ingrediente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_receta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(204, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "RECETAS"
        '
        'dgv_clase
        '
        Me.dgv_clase.AllowUserToAddRows = False
        Me.dgv_clase.AllowUserToDeleteRows = False
        Me.dgv_clase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_clase.Location = New System.Drawing.Point(12, 84)
        Me.dgv_clase.Name = "dgv_clase"
        Me.dgv_clase.ReadOnly = True
        Me.dgv_clase.Size = New System.Drawing.Size(176, 156)
        Me.dgv_clase.TabIndex = 4
        '
        'dgv_tipo
        '
        Me.dgv_tipo.AllowUserToAddRows = False
        Me.dgv_tipo.AllowUserToDeleteRows = False
        Me.dgv_tipo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_tipo.Location = New System.Drawing.Point(194, 84)
        Me.dgv_tipo.Name = "dgv_tipo"
        Me.dgv_tipo.ReadOnly = True
        Me.dgv_tipo.Size = New System.Drawing.Size(176, 156)
        Me.dgv_tipo.TabIndex = 4
        '
        'dgv_subTipo
        '
        Me.dgv_subTipo.AllowUserToAddRows = False
        Me.dgv_subTipo.AllowUserToDeleteRows = False
        Me.dgv_subTipo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_subTipo.Location = New System.Drawing.Point(376, 84)
        Me.dgv_subTipo.Name = "dgv_subTipo"
        Me.dgv_subTipo.ReadOnly = True
        Me.dgv_subTipo.Size = New System.Drawing.Size(176, 156)
        Me.dgv_subTipo.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "ELIJA EL PRODUCTO"
        '
        'dgv_ingrediente
        '
        Me.dgv_ingrediente.AllowUserToAddRows = False
        Me.dgv_ingrediente.AllowUserToDeleteRows = False
        Me.dgv_ingrediente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_ingrediente.Location = New System.Drawing.Point(12, 294)
        Me.dgv_ingrediente.Name = "dgv_ingrediente"
        Me.dgv_ingrediente.ReadOnly = True
        Me.dgv_ingrediente.Size = New System.Drawing.Size(154, 211)
        Me.dgv_ingrediente.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 278)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(148, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "ELIJA EL INGREDIENTE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(192, 260)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "INGREDIENTE"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(192, 286)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "CANTIDAD"
        '
        'txtIngrediente
        '
        Me.txtIngrediente.Location = New System.Drawing.Point(279, 257)
        Me.txtIngrediente.Name = "txtIngrediente"
        Me.txtIngrediente.ReadOnly = True
        Me.txtIngrediente.Size = New System.Drawing.Size(100, 20)
        Me.txtIngrediente.TabIndex = 10
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(279, 283)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.ReadOnly = True
        Me.txtCantidad.Size = New System.Drawing.Size(100, 20)
        Me.txtCantidad.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(10, 72)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 9)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "CLASE"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(193, 72)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(23, 9)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "TIPO"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(374, 72)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 9)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "SUBTIPO"
        '
        'dgv_receta
        '
        Me.dgv_receta.AllowUserToAddRows = False
        Me.dgv_receta.AllowUserToDeleteRows = False
        Me.dgv_receta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_receta.Location = New System.Drawing.Point(195, 359)
        Me.dgv_receta.Name = "dgv_receta"
        Me.dgv_receta.ReadOnly = True
        Me.dgv_receta.Size = New System.Drawing.Size(281, 146)
        Me.dgv_receta.TabIndex = 13
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(195, 312)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(66, 23)
        Me.btnNuevo.TabIndex = 14
        Me.btnNuevo.Text = "&Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(452, 312)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(66, 23)
        Me.btnSalir.TabIndex = 14
        Me.btnSalir.Text = "&Eliminar"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(193, 347)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 9)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "RECETA"
        '
        'btnGrabar
        '
        Me.btnGrabar.Enabled = False
        Me.btnGrabar.Location = New System.Drawing.Point(279, 312)
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(66, 23)
        Me.btnGrabar.TabIndex = 15
        Me.btnGrabar.Text = "&Grabar"
        Me.btnGrabar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(366, 312)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(66, 23)
        Me.btnModificar.TabIndex = 16
        Me.btnModificar.Text = "&Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'frmReceta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(555, 517)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnGrabar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.dgv_receta)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.txtIngrediente)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgv_ingrediente)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgv_subTipo)
        Me.Controls.Add(Me.dgv_tipo)
        Me.Controls.Add(Me.dgv_clase)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmReceta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Recetas"
        CType(Me.dgv_clase, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_tipo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_subTipo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_ingrediente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_receta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgv_clase As System.Windows.Forms.DataGridView
    Friend WithEvents dgv_tipo As System.Windows.Forms.DataGridView
    Friend WithEvents dgv_subTipo As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgv_ingrediente As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtIngrediente As System.Windows.Forms.TextBox
    Friend WithEvents txtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dgv_receta As System.Windows.Forms.DataGridView
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnGrabar As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
End Class
