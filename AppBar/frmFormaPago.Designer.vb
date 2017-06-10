<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFormaPago
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
        Me.cmbFormaPago = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtMonto = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnGrabar = New System.Windows.Forms.Button
        Me.dgv_detallePago = New System.Windows.Forms.DataGridView
        Me.btnTerminar = New System.Windows.Forms.Button
        Me.lblTarjeta = New System.Windows.Forms.Label
        Me.txtImpuestos = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtNumtarjeta = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtCliente = New System.Windows.Forms.TextBox
        Me.btnSalir = New System.Windows.Forms.Button
        Me.lblDatos = New System.Windows.Forms.Label
        Me.ckbImpuestos = New System.Windows.Forms.CheckBox
        Me.lblCol1 = New System.Windows.Forms.Label
        Me.lblCol2 = New System.Windows.Forms.Label
        Me.lblCol3 = New System.Windows.Forms.Label
        Me.lblCol4 = New System.Windows.Forms.Label
        Me.lblSubtotal = New System.Windows.Forms.Label
        Me.lblTotal = New System.Windows.Forms.Label
        CType(Me.dgv_detallePago, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(270, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CANCELAR TARJETA"
        '
        'cmbFormaPago
        '
        Me.cmbFormaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFormaPago.FormattingEnabled = True
        Me.cmbFormaPago.Location = New System.Drawing.Point(104, 130)
        Me.cmbFormaPago.Name = "cmbFormaPago"
        Me.cmbFormaPago.Size = New System.Drawing.Size(150, 21)
        Me.cmbFormaPago.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "TIPO:"
        '
        'txtMonto
        '
        Me.txtMonto.Location = New System.Drawing.Point(104, 202)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(69, 20)
        Me.txtMonto.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 202)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "MONTO:"
        '
        'btnGrabar
        '
        Me.btnGrabar.Location = New System.Drawing.Point(179, 202)
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(75, 23)
        Me.btnGrabar.TabIndex = 11
        Me.btnGrabar.Text = "&Grabar"
        Me.btnGrabar.UseVisualStyleBackColor = True
        '
        'dgv_detallePago
        '
        Me.dgv_detallePago.AllowUserToAddRows = False
        Me.dgv_detallePago.AllowUserToDeleteRows = False
        Me.dgv_detallePago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_detallePago.Location = New System.Drawing.Point(31, 247)
        Me.dgv_detallePago.Name = "dgv_detallePago"
        Me.dgv_detallePago.ReadOnly = True
        Me.dgv_detallePago.Size = New System.Drawing.Size(252, 168)
        Me.dgv_detallePago.TabIndex = 12
        '
        'btnTerminar
        '
        Me.btnTerminar.Location = New System.Drawing.Point(61, 460)
        Me.btnTerminar.Name = "btnTerminar"
        Me.btnTerminar.Size = New System.Drawing.Size(78, 23)
        Me.btnTerminar.TabIndex = 13
        Me.btnTerminar.Text = "Terminar"
        Me.btnTerminar.UseVisualStyleBackColor = True
        '
        'lblTarjeta
        '
        Me.lblTarjeta.AutoSize = True
        Me.lblTarjeta.Location = New System.Drawing.Point(12, 57)
        Me.lblTarjeta.Name = "lblTarjeta"
        Me.lblTarjeta.Size = New System.Drawing.Size(73, 13)
        Me.lblTarjeta.TabIndex = 1
        Me.lblTarjeta.Text = "Nº TARJETA:"
        '
        'txtImpuestos
        '
        Me.txtImpuestos.AcceptsReturn = True
        Me.txtImpuestos.Location = New System.Drawing.Point(104, 164)
        Me.txtImpuestos.Name = "txtImpuestos"
        Me.txtImpuestos.ReadOnly = True
        Me.txtImpuestos.Size = New System.Drawing.Size(69, 20)
        Me.txtImpuestos.TabIndex = 8
        Me.txtImpuestos.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 167)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "IMPUESTOS:"
        '
        'txtNumtarjeta
        '
        Me.txtNumtarjeta.Location = New System.Drawing.Point(104, 54)
        Me.txtNumtarjeta.Name = "txtNumtarjeta"
        Me.txtNumtarjeta.Size = New System.Drawing.Size(69, 20)
        Me.txtNumtarjeta.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "CLIENTE:"
        '
        'txtCliente
        '
        Me.txtCliente.Location = New System.Drawing.Point(104, 85)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(150, 20)
        Me.txtCliente.TabIndex = 4
        '
        'btnSalir
        '
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Location = New System.Drawing.Point(174, 460)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 14
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'lblDatos
        '
        Me.lblDatos.AutoSize = True
        Me.lblDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDatos.Location = New System.Drawing.Point(308, 73)
        Me.lblDatos.Name = "lblDatos"
        Me.lblDatos.Size = New System.Drawing.Size(62, 13)
        Me.lblDatos.TabIndex = 15
        Me.lblDatos.Text = "Consumo:"
        '
        'ckbImpuestos
        '
        Me.ckbImpuestos.AutoSize = True
        Me.ckbImpuestos.Enabled = False
        Me.ckbImpuestos.Location = New System.Drawing.Point(179, 166)
        Me.ckbImpuestos.Name = "ckbImpuestos"
        Me.ckbImpuestos.Size = New System.Drawing.Size(69, 17)
        Me.ckbImpuestos.TabIndex = 16
        Me.ckbImpuestos.Text = "Impuesto"
        Me.ckbImpuestos.UseVisualStyleBackColor = True
        '
        'lblCol1
        '
        Me.lblCol1.AutoSize = True
        Me.lblCol1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCol1.Location = New System.Drawing.Point(308, 92)
        Me.lblCol1.Name = "lblCol1"
        Me.lblCol1.Size = New System.Drawing.Size(150, 13)
        Me.lblCol1.TabIndex = 17
        Me.lblCol1.Text = "Descripción del Producto"
        Me.lblCol1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCol2
        '
        Me.lblCol2.AutoSize = True
        Me.lblCol2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCol2.Location = New System.Drawing.Point(479, 92)
        Me.lblCol2.Name = "lblCol2"
        Me.lblCol2.Size = New System.Drawing.Size(134, 13)
        Me.lblCol2.TabIndex = 18
        Me.lblCol2.Text = "Sub Tipo del Producto"
        Me.lblCol2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCol3
        '
        Me.lblCol3.AutoSize = True
        Me.lblCol3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCol3.Location = New System.Drawing.Point(631, 92)
        Me.lblCol3.Name = "lblCol3"
        Me.lblCol3.Size = New System.Drawing.Size(57, 13)
        Me.lblCol3.TabIndex = 19
        Me.lblCol3.Text = "Cantidad"
        Me.lblCol3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCol4
        '
        Me.lblCol4.AutoSize = True
        Me.lblCol4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCol4.Location = New System.Drawing.Point(706, 92)
        Me.lblCol4.Name = "lblCol4"
        Me.lblCol4.Size = New System.Drawing.Size(36, 13)
        Me.lblCol4.TabIndex = 20
        Me.lblCol4.Text = "Total"
        Me.lblCol4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSubtotal
        '
        Me.lblSubtotal.AutoSize = True
        Me.lblSubtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubtotal.Location = New System.Drawing.Point(631, 107)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(84, 13)
        Me.lblSubtotal.TabIndex = 21
        Me.lblSubtotal.Text = "SubTotal: $ 0"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(631, 130)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(62, 13)
        Me.lblTotal.TabIndex = 22
        Me.lblTotal.Text = "Total: $ 0"
        '
        'frmFormaPago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnSalir
        Me.ClientSize = New System.Drawing.Size(764, 495)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblSubtotal)
        Me.Controls.Add(Me.lblCol4)
        Me.Controls.Add(Me.lblCol3)
        Me.Controls.Add(Me.lblCol2)
        Me.Controls.Add(Me.lblCol1)
        Me.Controls.Add(Me.ckbImpuestos)
        Me.Controls.Add(Me.lblDatos)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.txtCliente)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtNumtarjeta)
        Me.Controls.Add(Me.txtImpuestos)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblTarjeta)
        Me.Controls.Add(Me.dgv_detallePago)
        Me.Controls.Add(Me.btnTerminar)
        Me.Controls.Add(Me.btnGrabar)
        Me.Controls.Add(Me.txtMonto)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbFormaPago)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmFormaPago"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cancelar Tarjeta"
        CType(Me.dgv_detallePago, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbFormaPago As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtMonto As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnGrabar As System.Windows.Forms.Button
    Friend WithEvents dgv_detallePago As System.Windows.Forms.DataGridView
    Friend WithEvents btnTerminar As System.Windows.Forms.Button
    Friend WithEvents lblTarjeta As System.Windows.Forms.Label
    Friend WithEvents txtImpuestos As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtNumtarjeta As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCliente As System.Windows.Forms.TextBox
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents lblDatos As System.Windows.Forms.Label
    Friend WithEvents ckbImpuestos As System.Windows.Forms.CheckBox
    Friend WithEvents lblCol1 As System.Windows.Forms.Label
    Friend WithEvents lblCol2 As System.Windows.Forms.Label
    Friend WithEvents lblCol3 As System.Windows.Forms.Label
    Friend WithEvents lblCol4 As System.Windows.Forms.Label
    Friend WithEvents lblSubtotal As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
End Class
