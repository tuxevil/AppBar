Public Class frmIngresoFormaPago
    Dim dataTableInfoFormaPago As New DataTable
    Private Sub frmIngresoFormaPago_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.loadGridFormaPago()
    End Sub
    Public Sub loadGridFormaPago()
        Dim objFormaPago As New clsFormaPago
        dataTableInfoFormaPago = objFormaPago.consFormaPago
        dataTableInfoFormaPago.Columns(0).ColumnMapping = MappingType.Hidden
        Me.dgv_formasPago.DataSource = dataTableInfoFormaPago
        Me.dgv_formasPago.Columns(0).Width = 120
        Me.dgv_formasPago.Columns(0).HeaderText = "Descripcion"
        Me.dgv_formasPago.Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
        Me.clickGridFormaPago()
    End Sub
    Public Sub clickGridFormaPago()
        Dim indexGridFormaPago As Integer = Me.dgv_formasPago.CurrentRow.Index
        Me.txtNombre.Text = dataTableInfoFormaPago.Rows(indexGridFormaPago)(1)
    End Sub

    Private Sub dgv_formasPago_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_formasPago.CellClick
        Me.clickGridFormaPago()
    End Sub
    Public Sub CancelarFormaPago()
        Me.btnGuardar.Enabled = False
        Me.dgv_formasPago.Enabled = True
        Me.btnSalir.Text = "&Salir"
        Me.btnModificar.Text = "&Modificar"
        Me.btnEliminar.Text = "&Eliminar"
        Me.btnEliminar.Enabled = True
        Me.btnModificar.Enabled = True
        Me.btnNuevo.Enabled = True
        Me.txtNombre.ReadOnly = True
        Me.loadGridFormaPago()
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Me.btnNuevo.Enabled = False
        Me.btnGuardar.Enabled = True
        Me.btnModificar.Enabled = False
        Me.btnEliminar.Enabled = False
        Me.dgv_formasPago.Enabled = False
        Me.btnSalir.Text = "&Cancelar"
        Me.txtNombre.ReadOnly = False
        Me.txtNombre.Text = String.Empty
        Me.txtNombre.Focus()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        If Me.btnSalir.Text = "&Salir" Then
            Me.Close()
        Else
            Me.CancelarFormaPago()
            Me.loadGridFormaPago()
        End If
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        If Me.btnModificar.Text = "&Modificar" Then
            Me.btnModificar.Text = "&Aceptar"
            Me.txtNombre.ReadOnly = False
            Me.txtNombre.Focus()
            Me.btnSalir.Text = "&Cancelar"
            Me.btnEliminar.Enabled = False
            Me.btnGuardar.Enabled = False
            Me.btnNuevo.Enabled = False
        Else
            Dim objFormaPago As New clsFormaPago
            Dim codFormaPago As Integer = Me.dataTableInfoFormaPago.Rows(Me.dgv_formasPago.CurrentRow.Index)(0)
            If objFormaPago.modificarFormaPago(codFormaPago, Me.txtNombre.Text) Then
                MsgBox("Modificado con éxito", MsgBoxStyle.Information, "Mensaje del Sistema")
                CancelarFormaPago()
            Else
                MsgBox("Ocurrió un error al modificar el registro", MsgBoxStyle.Critical, "Mensaje del Sistema")
            End If
        End If
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        If MsgBox("¿Confirma que desea eliminar el registro?", MsgBoxStyle.YesNo, "Mensaje del Sistema") = MsgBoxResult.Yes Then
            Dim objFormaPago As New clsFormaPago
            Dim codFormaPago As Integer = Me.dataTableInfoFormaPago.Rows(Me.dgv_formasPago.CurrentRow.Index)(0)
            If objFormaPago.eliminarFormaPago(codFormaPago) Then
                MsgBox("El registro se eliminó con éxito", MsgBoxStyle.Information, "Mensaje del Sistema")
                CancelarFormaPago()
            Else
                MsgBox("Ocurrió un error al eliminar el registro", MsgBoxStyle.Critical, "Mensaje del Sistema")
            End If
        End If
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim objFormaPago As New clsFormaPago
        If objFormaPago.grabarFormaPago(Me.txtNombre.Text) Then
            MsgBox("Registro guardado satisfactoriamente", MsgBoxStyle.Information, "Mensaje del Sistema")
            CancelarFormaPago()
        Else
            MsgBox("Ocurrió un error al grabar el registro", MsgBoxStyle.Critical, "Mensaje del Sistema ??")
        End If
    End Sub
End Class