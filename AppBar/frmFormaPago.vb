Public Class frmFormaPago
    Dim isEnter As Boolean = False
    Dim subTotal As Decimal = 0
    Dim Total As Decimal = 0
    Dim comapress As Boolean = False
    Dim datatableInfoFormaPago As New DataTable
    Dim datatableInfoDetallePago As New DataTable
    Dim dataTableInfoConsumo As New DataTable
    Private Sub frmFormaPago_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadComboTipo()
        Me.loadFormCancelar(False)
    End Sub
    Public Sub loadGridDetallePago()
        Dim objDetallePago As New clsDetallePago
        datatableInfoDetallePago = objDetallePago.consDetallePago(Me.txtNumtarjeta.Text)
        datatableInfoDetallePago.Columns(0).ColumnMapping = MappingType.Hidden
        Me.dgv_detallePago.DataSource = datatableInfoDetallePago
        Me.dgv_detallePago.Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
        Me.dgv_detallePago.Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable
        Me.dgv_detallePago.Columns(0).HeaderText = "Forma de Pago"
        Me.dgv_detallePago.Columns(1).HeaderText = "Valor"
    End Sub
    Public Sub loadDetalleConsumo()
        Me.Total = 0
        Me.subTotal = 0
        Me.lblSubtotal.Text = "SubTotal: $ 0"
        Me.lblTotal.Text = "Total: $ 0"
        Me.lblSubtotal.Location = New Drawing.Point(612, 107)
        Me.lblTotal.Location = New Drawing.Point(612, 130)
        Me.dataTableInfoConsumo.Rows.Clear()
        Me.lblCol1.Text = "Descripción del Producto"
        Me.lblCol2.Text = "Sub Tipo del Producto"
        Me.lblCol3.Text = "Cantidad"
        Me.lblCol4.Text = "Total"
        Dim objConsumo As New clsConsumo
        dataTableInfoConsumo = objConsumo.consConsumo(Me.txtNumtarjeta.Text)
        Dim i As Integer = 0
        Me.lblCol1.Text += Chr(10)
        Me.lblCol1.Text += Chr(10)
        Me.lblCol2.Text += Chr(10)
        Me.lblCol2.Text += Chr(10)
        Me.lblCol3.Text += Chr(10)
        Me.lblCol3.Text += Chr(10)
        Me.lblCol4.Text += Chr(10)
        Me.lblCol4.Text += Chr(10)
        While i < Me.dataTableInfoConsumo.Rows.Count
            Me.lblCol1.Text += Me.dataTableInfoConsumo.Rows(i)(0).ToString
            Me.lblCol1.Text += Chr(10)
            Me.lblCol2.Text += Me.dataTableInfoConsumo.Rows(i)(1).ToString
            Me.lblCol2.Text += Chr(10)
            Me.lblCol3.Text += Me.dataTableInfoConsumo.Rows(i)(2).ToString
            Me.lblCol3.Text += Chr(10)
            Me.lblCol4.Text += "$ " & Me.dataTableInfoConsumo.Rows(i)(3).ToString
            Me.lblCol4.Text += Chr(10)
            subTotal += Me.dataTableInfoConsumo.Rows(i)(3)
            i += 1
        End While
        Total = subTotal
        Me.lblSubtotal.Text = "SubTotal: $ " & Me.subTotal.ToString
        Me.lblTotal.Text = "Total: $ " & Me.Total.ToString
        Me.lblSubtotal.Location = New Drawing.Point(Me.lblSubtotal.Location.X, Me.lblSubtotal.Location.Y + Me.lblCol3.Height)
        Me.lblTotal.Location = New Drawing.Point(Me.lblTotal.Location.X, Me.lblTotal.Location.Y + Me.lblCol3.Height)
    End Sub
    Public Sub loadComboTipo()
        Dim objFormaPago As New clsFormaPago
        Me.datatableInfoFormaPago = objFormaPago.consFormaPago()
        Me.cmbFormaPago.DataSource = datatableInfoFormaPago
        Me.cmbFormaPago.ValueMember = "codigo"
        Me.cmbFormaPago.DisplayMember = "descripcion"
        GC.ReRegisterForFinalize(objFormaPago)
        GC.Collect()
    End Sub
    Public Sub loadFormCancelar(ByVal valor As Boolean)
        isEnter = valor
        Me.ckbImpuestos.Enabled = valor
        Me.txtNumtarjeta.ReadOnly = valor
        Me.txtCliente.ReadOnly = valor
        Me.txtCliente.Enabled = valor
        Me.cmbFormaPago.Enabled = valor
        Me.txtImpuestos.Enabled = valor
        Me.txtMonto.Enabled = valor
        Me.btnGrabar.Enabled = valor
        Me.dgv_detallePago.Enabled = valor
        Me.btnTerminar.Enabled = valor
        If Not valor Then
            isEnter = False
            Me.ckbImpuestos.Checked = False
            Me.subTotal = 0
            Me.Total = 0
            Me.lblSubtotal.Text = "SubTotal: $ 0"
            Me.lblTotal.Text = "Total: $ 0"
            Me.lblSubtotal.Location = New Drawing.Point(612, 107)
            Me.lblTotal.Location = New Drawing.Point(612, 130)
            Me.dataTableInfoConsumo.Rows.Clear()
            Me.lblCol1.Text = "Descripción del Producto"
            Me.lblCol2.Text = "Sub Tipo del Producto"
            Me.lblCol3.Text = "Cantidad"
            Me.lblCol4.Text = "Total"
            Me.comapress = False
            Me.txtMonto.Text = String.Empty
            Me.txtCliente.Text = String.Empty
            Me.txtNumtarjeta.Text = String.Empty
            Me.btnSalir.Text = "&Salir"
            Me.dgv_detallePago.DataSource = Nothing
        Else
            Me.btnSalir.Text = "&Cancelar"
        End If
        Me.txtNumtarjeta.Focus()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        If Me.btnSalir.Text = "&Cancelar" Then
            Me.loadFormCancelar(False)
        Else
            Me.Close()
        End If
    End Sub

    Private Sub txtNumtarjeta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumtarjeta.KeyPress
        Try
            If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
                e.Handled = False
                If e.KeyChar = Convert.ToChar(Keys.Return) Then
                    If Trim(Me.txtNumtarjeta.Text) = String.Empty Then
                        Throw New Exception("Error:" & Chr(10) & "Ingrese un número de tarjeta.")
                    End If
                    If isEnter = False Then
                        Dim objTarjeta As New clsTarjetaConsumo
                        Dim textRecibe As String = objTarjeta.consClientePorTarjeta(Me.txtNumtarjeta.Text)
                        If textRecibe <> DBNull.Value.ToString Then
                            Me.txtCliente.Text = textRecibe
                            Me.loadGridDetallePago()
                            Me.loadDetalleConsumo()
                            Me.loadFormCancelar(True)
                        Else
                            MsgBox("Error:" & Chr(10) & "El número de tarjeta no existe.", MsgBoxStyle.Exclamation, "Mensaje del Sistema ??")
                        End If
                        GC.ReRegisterForFinalize(objTarjeta)
                        GC.Collect()
                    End If
                End If
            Else
                e.Handled = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Mensaje del Sistema ???")
        End Try
    End Sub

    Private Sub btnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabar.Click
        Try
            If Me.txtMonto.Text = String.Empty Or Me.txtMonto.Text = "," Then
                Me.txtMonto.Focus()
                Throw New Exception("Ingrese un valor correcto.")
            End If
            Dim objDetallePago As New clsDetallePago
            If objDetallePago.grabarDetallePago(Me.txtNumtarjeta.Text, Me.cmbFormaPago.SelectedValue, Me.txtMonto.Text) Then
                MsgBox("El registro se guardó satisfactoriamente")
                loadComboTipo()
                loadGridDetallePago()
                Me.loadDetalleConsumo()
                Me.txtMonto.Text = String.Empty
            Else
                MsgBox("Ocurrió un error al grabar el registro.")
            End If
        Catch ex As Exception
            MsgBox("Error:" & Chr(10) & "" & ex.Message & "", MsgBoxStyle.Critical, "Mensaje del Sistema ???")
        End Try
    End Sub

    Private Sub txtMonto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMonto.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf (e.KeyChar = "." Or e.KeyChar = ",") And (comapress = False) Then
            If e.KeyChar = "." Then
                e.KeyChar = ","
            End If
            comapress = True
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtMonto_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtMonto.KeyUp
        Dim i As Int16 = Me.txtMonto.Text.IndexOf(",")
        If Me.txtMonto.Text = String.Empty Or i = -1 Then
            comapress = False
        End If
    End Sub

    Private Sub ckbImpuestos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckbImpuestos.CheckedChanged
        If Me.ckbImpuestos.Checked Then
            Total = FormatCurrency(Me.subTotal + (Me.subTotal * 0.22))
            Me.txtImpuestos.Text = FormatCurrency(Me.subTotal * 0.22)
            Me.lblTotal.Text = "Total: $ " & Total.ToString
        Else
            Total = subTotal
            Me.lblTotal.Text = "Total: $ " & Total.ToString
            Me.txtImpuestos.Text = 0
        End If
    End Sub

    Private Sub btnTerminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTerminar.Click
        Dim totGridDetalle As Integer = 0
        Dim i As Integer = 0

        While i < Me.dgv_detallePago.RowCount
            totGridDetalle += Me.datatableInfoDetallePago.Rows(i)(2)
            i += 1
        End While
        If totGridDetalle < Total Then
            MsgBox("Error:" & Chr(10) & "Falta cancelar una diferencia de " & (Total - totGridDetalle).ToString & "", MsgBoxStyle.Information, "Mensaje del Sistema ???")
            Me.txtNumtarjeta.Focus()
        Else

        End If
    End Sub
End Class