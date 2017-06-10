Public Class frmIngresoInventario
    Dim dataTableInfoProductos As New DataTable
    Dim dataTableInfoRegistroProductos As New DataTable
    Private Sub frmIngresoInventario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.lblFecha.Text = Now.ToLongDateString
        Me.loadgridProductos()
        Me.clickGridProductos()
        Me.txtIngreso.Focus()
    End Sub
    Public Sub loadgridProductos()
        Dim objInventario As New clsInventario
        Me.dataTableInfoProductos = objInventario.consInventario()
        Me.dataTableInfoProductos.Columns(0).ColumnMapping = MappingType.Hidden
        Me.dgv_Productos.DataSource = Me.dataTableInfoProductos
        Me.dgv_Productos.Columns(0).Width = 160
        Me.dgv_Productos.Columns(0).HeaderText = "Descripción del Producto"
        Me.dgv_Productos.Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
        Me.dgv_Productos.Columns(1).Width = 70
        Me.dgv_Productos.Columns(1).HeaderText = "Cantidad"
        Me.dgv_Productos.Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable
    End Sub

    Private Sub dgv_Productos_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_Productos.CellClick
        Me.clickGridProductos()
    End Sub
    Public Sub clickGridProductos()
        If Me.dgv_Productos.RowCount <> 0 Then
            Dim indexGridProductos As Integer = Me.dgv_Productos.CurrentRow.Index
            Me.txtProducto.Text = Me.dataTableInfoProductos.Rows(indexGridProductos)(1)
            Me.txtCantidad.Text = Me.dataTableInfoProductos.Rows(indexGridProductos)(2)
            Dim objInventarioRegistro As New clsInventarioRegistro
            dataTableInfoRegistroProductos = objInventarioRegistro.consInventarioRegistro _
            (Me.dataTableInfoProductos.Rows(Me.dgv_Productos.CurrentRow.Index)(0))
            dataTableInfoRegistroProductos.Columns(0).ColumnMapping = MappingType.Hidden
            Me.dgv_registroInventario.DataSource = dataTableInfoRegistroProductos
            Me.dgv_registroInventario.Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
            Me.dgv_registroInventario.Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable
        End If
    End Sub

    Private Sub txtIngreso_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtIngreso.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Public Sub cancelarRegistroInventario()
        Me.txtProducto.Text = String.Empty
        Me.txtProducto.ReadOnly = True
        Me.txtCantidad.Text = String.Empty
        Me.txtCantidad.ReadOnly = True
        Me.btnNuevo.Enabled = True
        Me.btnEliminar.Enabled = True
        Me.btnGrabar.Enabled = False
        Me.dgv_Productos.Enabled = True
        Me.btnAumentar.Enabled = True
        Me.btnAumentar.Text = "&Incrementar"
        Me.txtIngreso.Text = String.Empty
        Me.txtIngreso.ReadOnly = True
        Me.btnEliminar.Text = "&Eliminar"
        Me.btnSalir.Text = "&Salir"
        Me.lblFecha.Text = Now.ToLongDateString
        Me.loadgridProductos()
        Me.clickGridProductos()
        Me.txtIngreso.Focus()
    End Sub

    Private Sub btnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabar.Click
        Try
            If Me.txtProducto.Text = String.Empty Then
                Me.txtProducto.Focus()
                Throw New Exception("Debe de ingresar un producto correcto.")
            ElseIf Me.txtCantidad.Text = String.Empty Then
                Me.txtCantidad.Focus()
                Throw New Exception("Debe ingresar una cantidad correcta.")
            ElseIf Convert.ToInt32(Me.txtCantidad.Text) = 0 Then
                Me.txtCantidad.Focus()
                Throw New Exception("Debe ingresar una cantidad correcta.")
            End If
            Dim objInventario As New clsInventario
            If objInventario.grabarInventario(Me.txtProducto.Text, Me.txtCantidad.Text, Me.lblFecha.Text) = 2 Then
                MsgBox("El registro se guardó satisfactoriamente", MsgBoxStyle.Information, "Mensaje del Sistema ??")
                Me.cancelarRegistroInventario()
            Else
                MsgBox("Error:" & Chr(10) & "Ocurrió un problema al grabar el registro.", MsgBoxStyle.Critical, "Mensaje del Sistema ??")
            End If
        Catch ex As Exception
            MsgBox("Error:" & Chr(10) & "" & ex.Message & "", MsgBoxStyle.Critical, "Mensaje del Sistema ???")
        End Try
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Me.btnAumentar.Enabled = False
        Me.btnNuevo.Enabled = False
        Me.btnGrabar.Enabled = True
        Me.dgv_Productos.Enabled = False
        Me.txtProducto.ReadOnly = False
        Me.txtCantidad.ReadOnly = False
        Me.txtProducto.Text = String.Empty
        Me.txtCantidad.Text = String.Empty
        Me.btnEliminar.Text = "&Cancelar"
        Me.txtProducto.Focus()
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        If Me.btnEliminar.Text = "&Cancelar" Then
            cancelarRegistroInventario()
        Else

        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        If Me.btnSalir.Text = "&Salir" Then
            Me.Close()
        Else
            Me.cancelarRegistroInventario()
        End If
    End Sub

    Private Sub txtCantidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidad.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub btnAumentar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAumentar.Click
        Try
            If Me.btnAumentar.Text = "&Incrementar" Then
                Me.btnAumentar.Text = "&Aceptar"
                Me.btnSalir.Text = "&Cancelar"
                Me.btnNuevo.Enabled = False
                Me.btnEliminar.Enabled = False
                Me.txtIngreso.ReadOnly = False
                Me.txtIngreso.Focus()
            Else
                If Me.txtIngreso.Text = String.Empty Or Convert.ToInt32(Me.txtIngreso.Text) = 0 Then
                    Throw New Exception("Debe ingresar una cantidad correcta.")
                End If
                Dim objInventarioRegistro As New clsInventarioRegistro
                If objInventarioRegistro.grabarRegistroInventario(Me.dataTableInfoProductos.Rows(Me.dgv_Productos.CurrentRow.Index)(0), _
                Me.txtIngreso.Text, Me.lblFecha.Text) = 2 Then
                    MsgBox("El registro se incrementó satisfactoriamente", MsgBoxStyle.Information, "Mensaje del Sistema ??")
                    Me.cancelarRegistroInventario()
                Else
                    MsgBox("Error:" & Chr(10) & "Ocurrió un problema al grabar el registro.", MsgBoxStyle.Critical, "Mensaje del Sistema ??")
                End If
            End If
        Catch ex As Exception
            MsgBox("Error:" & Chr(10) & "" & ex.Message & "", MsgBoxStyle.Critical, "Mensaje del Sistema ???")
            Me.txtIngreso.Text = String.Empty
            Me.txtIngreso.Focus()
        End Try
    End Sub
End Class