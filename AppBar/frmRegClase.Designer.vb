<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegClase
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
        Me.gb_Clase = New System.Windows.Forms.GroupBox
        Me.cmbGrupo = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.btnCallFrmGrupo = New System.Windows.Forms.Button
        Me.btnModificaClase = New System.Windows.Forms.Button
        Me.btnEliminaClase = New System.Windows.Forms.Button
        Me.btnGrabaClase = New System.Windows.Forms.Button
        Me.btnNuevoClase = New System.Windows.Forms.Button
        Me.dgv_clase = New System.Windows.Forms.DataGridView
        Me.txtAbreviaturaClase = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtDescripcionClase = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.gb_Tipo = New System.Windows.Forms.GroupBox
        Me.btnNuevoTipo = New System.Windows.Forms.Button
        Me.btnGrabarTipo = New System.Windows.Forms.Button
        Me.btnEliminaTipo = New System.Windows.Forms.Button
        Me.btnModificaTipo = New System.Windows.Forms.Button
        Me.dgv_tipo = New System.Windows.Forms.DataGridView
        Me.txtAbreviaturaTipo = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtDescripcionTipo = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.gb_SubTipo = New System.Windows.Forms.GroupBox
        Me.txtPvpSubTipo = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtCostoSubTipo = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.btnNuevoSubTipo = New System.Windows.Forms.Button
        Me.btnGrabaSubTipo = New System.Windows.Forms.Button
        Me.btnEliminaSubTipo = New System.Windows.Forms.Button
        Me.btnModificaSubTipo = New System.Windows.Forms.Button
        Me.dgv_subtipo = New System.Windows.Forms.DataGridView
        Me.txtAbreviaturaSubtipo = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtDescripcionSubtipo = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.gb_Clase.SuspendLayout()
        CType(Me.dgv_clase, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_Tipo.SuspendLayout()
        CType(Me.dgv_tipo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_SubTipo.SuspendLayout()
        CType(Me.dgv_subtipo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gb_Clase
        '
        Me.gb_Clase.Controls.Add(Me.cmbGrupo)
        Me.gb_Clase.Controls.Add(Me.Label9)
        Me.gb_Clase.Controls.Add(Me.btnCallFrmGrupo)
        Me.gb_Clase.Controls.Add(Me.btnModificaClase)
        Me.gb_Clase.Controls.Add(Me.btnEliminaClase)
        Me.gb_Clase.Controls.Add(Me.btnGrabaClase)
        Me.gb_Clase.Controls.Add(Me.btnNuevoClase)
        Me.gb_Clase.Controls.Add(Me.dgv_clase)
        Me.gb_Clase.Controls.Add(Me.txtAbreviaturaClase)
        Me.gb_Clase.Controls.Add(Me.Label3)
        Me.gb_Clase.Controls.Add(Me.txtDescripcionClase)
        Me.gb_Clase.Controls.Add(Me.Label2)
        Me.gb_Clase.Location = New System.Drawing.Point(12, 12)
        Me.gb_Clase.Name = "gb_Clase"
        Me.gb_Clase.Size = New System.Drawing.Size(788, 200)
        Me.gb_Clase.TabIndex = 7
        Me.gb_Clase.TabStop = False
        Me.gb_Clase.Text = "CLASE:"
        '
        'cmbGrupo
        '
        Me.cmbGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGrupo.Enabled = False
        Me.cmbGrupo.FormattingEnabled = True
        Me.cmbGrupo.Location = New System.Drawing.Point(558, 67)
        Me.cmbGrupo.MaxDropDownItems = 30
        Me.cmbGrupo.Name = "cmbGrupo"
        Me.cmbGrupo.Size = New System.Drawing.Size(130, 21)
        Me.cmbGrupo.TabIndex = 21
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(441, 70)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 13)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "GRUPO:"
        '
        'btnCallFrmGrupo
        '
        Me.btnCallFrmGrupo.Location = New System.Drawing.Point(636, 19)
        Me.btnCallFrmGrupo.Name = "btnCallFrmGrupo"
        Me.btnCallFrmGrupo.Size = New System.Drawing.Size(133, 23)
        Me.btnCallFrmGrupo.TabIndex = 19
        Me.btnCallFrmGrupo.Text = "&Agregar Grupo"
        Me.btnCallFrmGrupo.UseVisualStyleBackColor = True
        '
        'btnModificaClase
        '
        Me.btnModificaClase.Location = New System.Drawing.Point(613, 171)
        Me.btnModificaClase.Name = "btnModificaClase"
        Me.btnModificaClase.Size = New System.Drawing.Size(75, 23)
        Me.btnModificaClase.TabIndex = 18
        Me.btnModificaClase.Text = "&Modificar"
        Me.btnModificaClase.UseVisualStyleBackColor = True
        '
        'btnEliminaClase
        '
        Me.btnEliminaClase.Location = New System.Drawing.Point(694, 171)
        Me.btnEliminaClase.Name = "btnEliminaClase"
        Me.btnEliminaClase.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminaClase.TabIndex = 17
        Me.btnEliminaClase.Text = "&Eliminar"
        Me.btnEliminaClase.UseVisualStyleBackColor = True
        '
        'btnGrabaClase
        '
        Me.btnGrabaClase.Location = New System.Drawing.Point(530, 171)
        Me.btnGrabaClase.Name = "btnGrabaClase"
        Me.btnGrabaClase.Size = New System.Drawing.Size(75, 23)
        Me.btnGrabaClase.TabIndex = 16
        Me.btnGrabaClase.Text = "&Grabar"
        Me.btnGrabaClase.UseVisualStyleBackColor = True
        '
        'btnNuevoClase
        '
        Me.btnNuevoClase.Location = New System.Drawing.Point(449, 171)
        Me.btnNuevoClase.Name = "btnNuevoClase"
        Me.btnNuevoClase.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevoClase.TabIndex = 15
        Me.btnNuevoClase.Text = "&Nuevo"
        Me.btnNuevoClase.UseVisualStyleBackColor = True
        '
        'dgv_clase
        '
        Me.dgv_clase.AllowUserToAddRows = False
        Me.dgv_clase.AllowUserToDeleteRows = False
        Me.dgv_clase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_clase.Location = New System.Drawing.Point(6, 19)
        Me.dgv_clase.Name = "dgv_clase"
        Me.dgv_clase.ReadOnly = True
        Me.dgv_clase.Size = New System.Drawing.Size(417, 175)
        Me.dgv_clase.TabIndex = 13
        '
        'txtAbreviaturaClase
        '
        Me.txtAbreviaturaClase.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAbreviaturaClase.Location = New System.Drawing.Point(558, 123)
        Me.txtAbreviaturaClase.MaxLength = 1
        Me.txtAbreviaturaClase.Name = "txtAbreviaturaClase"
        Me.txtAbreviaturaClase.ReadOnly = True
        Me.txtAbreviaturaClase.Size = New System.Drawing.Size(44, 20)
        Me.txtAbreviaturaClase.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(441, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "ABREVIATURA:"
        '
        'txtDescripcionClase
        '
        Me.txtDescripcionClase.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcionClase.Location = New System.Drawing.Point(558, 97)
        Me.txtDescripcionClase.Name = "txtDescripcionClase"
        Me.txtDescripcionClase.ReadOnly = True
        Me.txtDescripcionClase.Size = New System.Drawing.Size(215, 20)
        Me.txtDescripcionClase.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(441, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "DESCRIPCIÓN:"
        '
        'gb_Tipo
        '
        Me.gb_Tipo.Controls.Add(Me.btnNuevoTipo)
        Me.gb_Tipo.Controls.Add(Me.btnGrabarTipo)
        Me.gb_Tipo.Controls.Add(Me.btnEliminaTipo)
        Me.gb_Tipo.Controls.Add(Me.btnModificaTipo)
        Me.gb_Tipo.Controls.Add(Me.dgv_tipo)
        Me.gb_Tipo.Controls.Add(Me.txtAbreviaturaTipo)
        Me.gb_Tipo.Controls.Add(Me.Label4)
        Me.gb_Tipo.Controls.Add(Me.txtDescripcionTipo)
        Me.gb_Tipo.Controls.Add(Me.Label5)
        Me.gb_Tipo.Location = New System.Drawing.Point(6, 218)
        Me.gb_Tipo.Name = "gb_Tipo"
        Me.gb_Tipo.Size = New System.Drawing.Size(788, 200)
        Me.gb_Tipo.TabIndex = 8
        Me.gb_Tipo.TabStop = False
        Me.gb_Tipo.Text = "TIPO:"
        '
        'btnNuevoTipo
        '
        Me.btnNuevoTipo.Location = New System.Drawing.Point(455, 171)
        Me.btnNuevoTipo.Name = "btnNuevoTipo"
        Me.btnNuevoTipo.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevoTipo.TabIndex = 18
        Me.btnNuevoTipo.Text = "N&uevo"
        Me.btnNuevoTipo.UseVisualStyleBackColor = True
        '
        'btnGrabarTipo
        '
        Me.btnGrabarTipo.Location = New System.Drawing.Point(536, 171)
        Me.btnGrabarTipo.Name = "btnGrabarTipo"
        Me.btnGrabarTipo.Size = New System.Drawing.Size(75, 23)
        Me.btnGrabarTipo.TabIndex = 17
        Me.btnGrabarTipo.Text = "G&rabar"
        Me.btnGrabarTipo.UseVisualStyleBackColor = True
        '
        'btnEliminaTipo
        '
        Me.btnEliminaTipo.Location = New System.Drawing.Point(700, 171)
        Me.btnEliminaTipo.Name = "btnEliminaTipo"
        Me.btnEliminaTipo.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminaTipo.TabIndex = 16
        Me.btnEliminaTipo.Text = "E&liminar"
        Me.btnEliminaTipo.UseVisualStyleBackColor = True
        '
        'btnModificaTipo
        '
        Me.btnModificaTipo.Location = New System.Drawing.Point(619, 171)
        Me.btnModificaTipo.Name = "btnModificaTipo"
        Me.btnModificaTipo.Size = New System.Drawing.Size(75, 23)
        Me.btnModificaTipo.TabIndex = 15
        Me.btnModificaTipo.Text = "M&odificar"
        Me.btnModificaTipo.UseVisualStyleBackColor = True
        '
        'dgv_tipo
        '
        Me.dgv_tipo.AllowUserToAddRows = False
        Me.dgv_tipo.AllowUserToDeleteRows = False
        Me.dgv_tipo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_tipo.Location = New System.Drawing.Point(6, 19)
        Me.dgv_tipo.Name = "dgv_tipo"
        Me.dgv_tipo.ReadOnly = True
        Me.dgv_tipo.Size = New System.Drawing.Size(423, 175)
        Me.dgv_tipo.TabIndex = 13
        '
        'txtAbreviaturaTipo
        '
        Me.txtAbreviaturaTipo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAbreviaturaTipo.Location = New System.Drawing.Point(563, 127)
        Me.txtAbreviaturaTipo.MaxLength = 1
        Me.txtAbreviaturaTipo.Name = "txtAbreviaturaTipo"
        Me.txtAbreviaturaTipo.ReadOnly = True
        Me.txtAbreviaturaTipo.Size = New System.Drawing.Size(44, 20)
        Me.txtAbreviaturaTipo.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(455, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "ABREVIATURA:"
        '
        'txtDescripcionTipo
        '
        Me.txtDescripcionTipo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcionTipo.Location = New System.Drawing.Point(563, 101)
        Me.txtDescripcionTipo.Name = "txtDescripcionTipo"
        Me.txtDescripcionTipo.ReadOnly = True
        Me.txtDescripcionTipo.Size = New System.Drawing.Size(215, 20)
        Me.txtDescripcionTipo.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(452, 109)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "DESCRIPCIÓN:"
        '
        'gb_SubTipo
        '
        Me.gb_SubTipo.Controls.Add(Me.txtPvpSubTipo)
        Me.gb_SubTipo.Controls.Add(Me.Label8)
        Me.gb_SubTipo.Controls.Add(Me.txtCostoSubTipo)
        Me.gb_SubTipo.Controls.Add(Me.Label7)
        Me.gb_SubTipo.Controls.Add(Me.btnNuevoSubTipo)
        Me.gb_SubTipo.Controls.Add(Me.btnGrabaSubTipo)
        Me.gb_SubTipo.Controls.Add(Me.btnEliminaSubTipo)
        Me.gb_SubTipo.Controls.Add(Me.btnModificaSubTipo)
        Me.gb_SubTipo.Controls.Add(Me.dgv_subtipo)
        Me.gb_SubTipo.Controls.Add(Me.txtAbreviaturaSubtipo)
        Me.gb_SubTipo.Controls.Add(Me.Label1)
        Me.gb_SubTipo.Controls.Add(Me.txtDescripcionSubtipo)
        Me.gb_SubTipo.Controls.Add(Me.Label6)
        Me.gb_SubTipo.Location = New System.Drawing.Point(6, 424)
        Me.gb_SubTipo.Name = "gb_SubTipo"
        Me.gb_SubTipo.Size = New System.Drawing.Size(788, 200)
        Me.gb_SubTipo.TabIndex = 9
        Me.gb_SubTipo.TabStop = False
        Me.gb_SubTipo.Text = "SUBTIPO:"
        '
        'txtPvpSubTipo
        '
        Me.txtPvpSubTipo.Location = New System.Drawing.Point(676, 124)
        Me.txtPvpSubTipo.Name = "txtPvpSubTipo"
        Me.txtPvpSubTipo.ReadOnly = True
        Me.txtPvpSubTipo.Size = New System.Drawing.Size(99, 20)
        Me.txtPvpSubTipo.TabIndex = 22
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(639, 127)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 13)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "PVP:"
        '
        'txtCostoSubTipo
        '
        Me.txtCostoSubTipo.Location = New System.Drawing.Point(505, 124)
        Me.txtCostoSubTipo.Name = "txtCostoSubTipo"
        Me.txtCostoSubTipo.ReadOnly = True
        Me.txtCostoSubTipo.Size = New System.Drawing.Size(99, 20)
        Me.txtCostoSubTipo.TabIndex = 20
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(452, 127)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "COSTO:"
        '
        'btnNuevoSubTipo
        '
        Me.btnNuevoSubTipo.Location = New System.Drawing.Point(455, 171)
        Me.btnNuevoSubTipo.Name = "btnNuevoSubTipo"
        Me.btnNuevoSubTipo.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevoSubTipo.TabIndex = 18
        Me.btnNuevoSubTipo.Text = "Nu&evo"
        Me.btnNuevoSubTipo.UseVisualStyleBackColor = True
        '
        'btnGrabaSubTipo
        '
        Me.btnGrabaSubTipo.Location = New System.Drawing.Point(536, 171)
        Me.btnGrabaSubTipo.Name = "btnGrabaSubTipo"
        Me.btnGrabaSubTipo.Size = New System.Drawing.Size(75, 23)
        Me.btnGrabaSubTipo.TabIndex = 17
        Me.btnGrabaSubTipo.Text = "Gra&bar"
        Me.btnGrabaSubTipo.UseVisualStyleBackColor = True
        '
        'btnEliminaSubTipo
        '
        Me.btnEliminaSubTipo.Location = New System.Drawing.Point(700, 171)
        Me.btnEliminaSubTipo.Name = "btnEliminaSubTipo"
        Me.btnEliminaSubTipo.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminaSubTipo.TabIndex = 16
        Me.btnEliminaSubTipo.Text = "El&iminar"
        Me.btnEliminaSubTipo.UseVisualStyleBackColor = True
        '
        'btnModificaSubTipo
        '
        Me.btnModificaSubTipo.Location = New System.Drawing.Point(619, 171)
        Me.btnModificaSubTipo.Name = "btnModificaSubTipo"
        Me.btnModificaSubTipo.Size = New System.Drawing.Size(75, 23)
        Me.btnModificaSubTipo.TabIndex = 15
        Me.btnModificaSubTipo.Text = "Mo&dificar"
        Me.btnModificaSubTipo.UseVisualStyleBackColor = True
        '
        'dgv_subtipo
        '
        Me.dgv_subtipo.AllowUserToAddRows = False
        Me.dgv_subtipo.AllowUserToDeleteRows = False
        Me.dgv_subtipo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_subtipo.Location = New System.Drawing.Point(6, 19)
        Me.dgv_subtipo.Name = "dgv_subtipo"
        Me.dgv_subtipo.ReadOnly = True
        Me.dgv_subtipo.Size = New System.Drawing.Size(423, 175)
        Me.dgv_subtipo.TabIndex = 13
        '
        'txtAbreviaturaSubtipo
        '
        Me.txtAbreviaturaSubtipo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAbreviaturaSubtipo.Location = New System.Drawing.Point(560, 98)
        Me.txtAbreviaturaSubtipo.MaxLength = 1
        Me.txtAbreviaturaSubtipo.Name = "txtAbreviaturaSubtipo"
        Me.txtAbreviaturaSubtipo.ReadOnly = True
        Me.txtAbreviaturaSubtipo.Size = New System.Drawing.Size(44, 20)
        Me.txtAbreviaturaSubtipo.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(452, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "ABREVIATURA:"
        '
        'txtDescripcionSubtipo
        '
        Me.txtDescripcionSubtipo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcionSubtipo.Location = New System.Drawing.Point(560, 72)
        Me.txtDescripcionSubtipo.Name = "txtDescripcionSubtipo"
        Me.txtDescripcionSubtipo.ReadOnly = True
        Me.txtDescripcionSubtipo.Size = New System.Drawing.Size(215, 20)
        Me.txtDescripcionSubtipo.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(450, 75)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "DESCRIPCIÓN:"
        '
        'frmRegClase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(812, 631)
        Me.Controls.Add(Me.gb_SubTipo)
        Me.Controls.Add(Me.gb_Tipo)
        Me.Controls.Add(Me.gb_Clase)
        Me.Name = "frmRegClase"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.gb_Clase.ResumeLayout(False)
        Me.gb_Clase.PerformLayout()
        CType(Me.dgv_clase, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_Tipo.ResumeLayout(False)
        Me.gb_Tipo.PerformLayout()
        CType(Me.dgv_tipo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_SubTipo.ResumeLayout(False)
        Me.gb_SubTipo.PerformLayout()
        CType(Me.dgv_subtipo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gb_Clase As System.Windows.Forms.GroupBox
    Friend WithEvents btnModificaClase As System.Windows.Forms.Button
    Friend WithEvents btnEliminaClase As System.Windows.Forms.Button
    Friend WithEvents btnGrabaClase As System.Windows.Forms.Button
    Friend WithEvents btnNuevoClase As System.Windows.Forms.Button
    Friend WithEvents dgv_clase As System.Windows.Forms.DataGridView
    Friend WithEvents txtAbreviaturaClase As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDescripcionClase As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents gb_Tipo As System.Windows.Forms.GroupBox
    Friend WithEvents btnNuevoTipo As System.Windows.Forms.Button
    Friend WithEvents btnGrabarTipo As System.Windows.Forms.Button
    Friend WithEvents btnEliminaTipo As System.Windows.Forms.Button
    Friend WithEvents btnModificaTipo As System.Windows.Forms.Button
    Friend WithEvents dgv_tipo As System.Windows.Forms.DataGridView
    Friend WithEvents txtAbreviaturaTipo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDescripcionTipo As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents gb_SubTipo As System.Windows.Forms.GroupBox
    Friend WithEvents btnNuevoSubTipo As System.Windows.Forms.Button
    Friend WithEvents btnGrabaSubTipo As System.Windows.Forms.Button
    Friend WithEvents btnEliminaSubTipo As System.Windows.Forms.Button
    Friend WithEvents btnModificaSubTipo As System.Windows.Forms.Button
    Friend WithEvents dgv_subtipo As System.Windows.Forms.DataGridView
    Friend WithEvents txtAbreviaturaSubtipo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDescripcionSubtipo As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtPvpSubTipo As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtCostoSubTipo As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnCallFrmGrupo As System.Windows.Forms.Button
    Friend WithEvents cmbGrupo As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label

End Class
