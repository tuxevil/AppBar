Public Class frmReceta
    Dim comaPress As Boolean = False
    Dim objReceta As New clsReceta
    Dim dataTableInfoClase As New DataTable
    Dim dataTableInfoTipo As New DataTable
    Dim dataTableInfoSubTipo As New DataTable
    Dim dataTableInfoInventario As New DataTable
    Dim dataTableInfoReceta As New DataTable
    Private Sub frmReceta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadGridClase()
        Me.loadGridIngrediende()
        Me.loadGridReceta()
    End Sub
    Public Sub loadGridClase()
        Try
            Dim objClase As New clsClase
            dataTableInfoClase = objClase.consClase
            dataTableInfoClase.Columns(0).ColumnMapping = MappingType.Hidden
            dataTableInfoClase.Columns(1).ColumnMapping = MappingType.Hidden
            dataTableInfoClase.Columns(3).ColumnMapping = MappingType.Hidden
            Me.dgv_clase.DataSource = dataTableInfoClase
            Me.dgv_clase.Columns(0).Width = 160
            Me.dgv_clase.Columns(0).HeaderText = "Descripción de Clase"
            Me.dgv_clase.Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
            GC.ReRegisterForFinalize(objClase)
            GC.Collect()
            ClickGridClase()
        Catch ex As Exception
            MsgBox("Error:" & Chr(10) & ex.Message, MsgBoxStyle.Critical, "Mensaje del Sistema ???")
        End Try
    End Sub
    Public Sub ClickGridClase()
        Dim indexGrid As Integer = Me.dgv_clase.CurrentRow.Index
        Dim objTipo As New clsTipo
        dataTableInfoTipo = objTipo.consTipo(dataTableInfoClase.Rows(indexGrid)(0))
        dataTableInfoTipo.Columns(0).ColumnMapping = MappingType.Hidden
        dataTableInfoTipo.Columns(2).ColumnMapping = MappingType.Hidden
        Me.dgv_tipo.DataSource = dataTableInfoTipo
        Me.dgv_tipo.Columns(0).Width = 160
        Me.dgv_tipo.Columns(0).HeaderText = "Descripción de Tipo"
        Me.dgv_tipo.Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
        GC.ReRegisterForFinalize(objTipo)
        GC.Collect()
        clickGridTipo()
    End Sub
    Public Sub clickGridTipo()
        If Me.dgv_tipo.RowCount = 0 Then
            dataTableInfoSubTipo.Rows.Clear()
        Else
            Dim indexGrid As Integer = Me.dgv_tipo.CurrentRow.Index
            Dim objSubTipo As New clsSubtipo
            dataTableInfoSubTipo = objSubTipo.consSubTipo(dataTableInfoTipo.Rows(indexGrid)(0))
            dataTableInfoSubTipo.Columns(0).ColumnMapping = MappingType.Hidden
            dataTableInfoSubTipo.Columns(2).ColumnMapping = MappingType.Hidden
            dataTableInfoSubTipo.Columns(3).ColumnMapping = MappingType.Hidden
            dataTableInfoSubTipo.Columns(4).ColumnMapping = MappingType.Hidden
            Me.dgv_subTipo.DataSource = dataTableInfoSubTipo
            Me.dgv_subTipo.Columns(0).Width = 160
            Me.dgv_subTipo.Columns(0).HeaderText = "Descripción SubTipo"
            Me.dgv_subTipo.Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
            GC.ReRegisterForFinalize(objSubTipo)
            GC.Collect()
        End If
    End Sub

    Public Sub loadGridIngrediende()
        Dim objInventario As New clsInventario
        Me.dataTableInfoInventario = objInventario.consInventario
        Me.dataTableInfoInventario.Columns(0).ColumnMapping = MappingType.Hidden
        Me.dataTableInfoInventario.Columns(2).ColumnMapping = MappingType.Hidden
        Me.dgv_ingrediente.DataSource = Me.dataTableInfoInventario
        Me.dgv_ingrediente.Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
    End Sub
    Public Sub loadGridReceta()
        Dim clase As Integer
        Dim tipo As Integer
        Dim subTipo As Integer
        Dim inventario As Integer
        If Me.dgv_clase.RowCount = 0 Then
            Me.txtIngrediente.Text = String.Empty
            Me.txtCantidad.Text = String.Empty
            Me.dataTableInfoReceta.Clear()
            Exit Sub
        Else
            clase = Me.dataTableInfoClase.Rows(Me.dgv_clase.CurrentRow.Index)(0)
        End If
        If Me.dgv_tipo.RowCount = 0 Then
            Me.txtIngrediente.Text = String.Empty
            Me.txtCantidad.Text = String.Empty
            Me.dataTableInfoReceta.Clear()
            Exit Sub
        Else
            tipo = Me.dataTableInfoTipo.Rows(Me.dgv_tipo.CurrentRow.Index)(0)
        End If
        If Me.dgv_subTipo.RowCount = 0 Then
            Me.txtIngrediente.Text = String.Empty
            Me.txtCantidad.Text = String.Empty
            Me.dataTableInfoReceta.Clear()
            Exit Sub
        Else
            subTipo = Me.dataTableInfoSubTipo.Rows(Me.dgv_subTipo.CurrentRow.Index)(0)
        End If
        If Me.dgv_ingrediente.RowCount = 0 Then
            Me.txtIngrediente.Text = String.Empty
            Me.txtCantidad.Text = String.Empty
            Me.dataTableInfoReceta.Clear()
            Exit Sub
        Else
            inventario = Me.dataTableInfoInventario.Rows(Me.dgv_ingrediente.CurrentRow.Index)(0)
        End If

        Me.dataTableInfoReceta = objReceta.consReceta(clase, tipo, subTipo)
        Me.dataTableInfoReceta.Columns(0).ColumnMapping = MappingType.Hidden
        Me.dgv_receta.DataSource = Me.dataTableInfoReceta
        Me.dgv_receta.Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
        Me.dgv_receta.Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable
        Me.clickReceta()
    End Sub

    Private Sub dgv_clase_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_clase.CellClick
        Me.ClickGridClase()
        Me.loadGridReceta()
    End Sub

    Private Sub dgv_tipo_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_tipo.CellClick
        Me.clickGridTipo()
        Me.loadGridReceta()
    End Sub

    Private Sub dgv_subTipo_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_subTipo.CellClick
        Me.loadGridReceta()
    End Sub

    Private Sub dgv_ingrediente_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_ingrediente.CellClick
        clickIngrediente()
    End Sub
    Public Sub clickIngrediente()
        If Me.btnNuevo.Enabled = False And Me.btnModificar.Text <> "&Aceptar" Then
            Me.txtIngrediente.Text = Me.dataTableInfoInventario.Rows(Me.dgv_ingrediente.CurrentRow.Index)(1)
            Me.txtCantidad.Focus()
        End If
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Try
            If Me.dgv_clase.RowCount = 0 Then
                Throw New Exception("Error:" & Chr(10) & "Debe tener ingresado por lo menos una Clase.")
            End If
            If Me.dgv_subTipo.RowCount = 0 Then
                Throw New Exception("Error:" & Chr(10) & "Debe tener ingresado por lo menos un Tipo.")
            End If
            If Me.dgv_subTipo.RowCount = 0 Then
                Throw New Exception("Error:" & Chr(10) & "Debe tener ingresado por lo menos un subTipo.")
            End If
            Me.dgv_receta.Enabled = False
            Me.btnModificar.Enabled = False
            Me.btnGrabar.Enabled = True
            Me.btnNuevo.Enabled = False
            Me.txtCantidad.ReadOnly = False
            Me.txtIngrediente.Text = String.Empty
            Me.txtCantidad.Text = String.Empty
            Me.btnSalir.Text = "&Cancelar"
            Me.clickIngrediente()
            Me.txtCantidad.Focus()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Mensaje del Sistema ???")
        End Try
    End Sub

    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        If Me.btnSalir.Text = "&Eliminar" Then
            If MsgBox("¿Confirma que desea eliminar el registro?", MsgBoxStyle.YesNo, "Mensaje del Sistema") = MsgBoxResult.Yes Then
                Dim objReceta As New clsReceta
                Dim codReceta As Integer = Me.dataTableInfoReceta.Rows(Me.dgv_receta.CurrentRow.Index)(0)
                If objReceta.eliminarReceta(codReceta) Then
                    MsgBox("El registro se eliminó con éxito", MsgBoxStyle.Information, "Mensaje del Sistema")
                    cancelarReceta()
                Else
                    MsgBox("Ocurrió un error al eliminar el registro", MsgBoxStyle.Critical, "Mensaje del Sistema")
                End If
            End If
        Else
            cancelarReceta()
        End If
    End Sub
    Public Sub cancelarReceta()
        comaPress = False
        Me.dgv_clase.Enabled = True
        Me.dgv_tipo.Enabled = True
        Me.dgv_subTipo.Enabled = True
        Me.dgv_receta.Enabled = True
        Me.btnModificar.Enabled = True
        Me.btnGrabar.Enabled = False
        Me.btnNuevo.Enabled = True
        Me.txtCantidad.ReadOnly = True
        Me.txtIngrediente.Text = String.Empty
        Me.txtCantidad.Text = String.Empty
        Me.btnModificar.Text = "&Modificar"
        Me.btnSalir.Text = "&Eliminar"
        loadGridClase()
        Me.loadGridIngrediende()
        Me.loadGridReceta()
    End Sub

    Private Sub dgv_receta_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_receta.CellClick
        clickReceta()
    End Sub
    Public Sub clickReceta()
        If Me.dgv_receta.RowCount <> 0 Then
            Me.txtIngrediente.Text = Me.dataTableInfoReceta.Rows(Me.dgv_receta.CurrentRow.Index)(1)
            Me.txtCantidad.Text = Me.dataTableInfoReceta.Rows(Me.dgv_receta.CurrentRow.Index)(2)
        End If
    End Sub

    Private Sub txtCantidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidad.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf (e.KeyChar = "." Or e.KeyChar = ",") And (comaPress = False) Then
            If e.KeyChar = "." Then
                e.KeyChar = ","
            End If
            comaPress = True
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtCantidad_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCantidad.KeyUp
        Dim i As Int16 = Me.txtCantidad.Text.IndexOf(",")
        If Me.txtCantidad.Text = String.Empty Or i = -1 Then
            comaPress = False
        End If
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Try
            If Me.btnModificar.Text = "&Modificar" Then
                Me.btnModificar.Text = "&Aceptar"
                Me.btnSalir.Text = "&Cancelar"
                Me.txtCantidad.ReadOnly = False
                Me.btnNuevo.Enabled = False
                Me.dgv_clase.Enabled = False
                Me.dgv_tipo.Enabled = False
                Me.dgv_subTipo.Enabled = False
                Me.txtCantidad.Focus()
            Else
                Dim objReceta As New clsReceta
                If objReceta.modificarReceta(Me.dataTableInfoReceta.Rows(Me.dgv_receta.CurrentRow.Index)(0), Me.txtCantidad.Text) Then
                    MsgBox("Modificado con éxito", MsgBoxStyle.Information, "Mensaje del Sistema")
                    cancelarReceta()
                Else
                    MsgBox("Ocurrió un error al modificar el registro", MsgBoxStyle.Critical, "Mensaje del Sistema")
                End If
                GC.ReRegisterForFinalize(objReceta)
                GC.Collect()
            End If
        Catch ex As Exception
            MsgBox("Error:" & Chr(10) & "" & ex.Message & "", MsgBoxStyle.Critical, "Mensaje del Sistema ???")
        End Try
    End Sub

    Private Sub btnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabar.Click
        Try
            Dim objReceta As New clsReceta
            If objReceta.grabarReceta(Me.dataTableInfoClase.Rows(Me.dgv_clase.CurrentRow.Index)(0), _
            Me.dataTableInfoTipo.Rows(Me.dgv_tipo.CurrentRow.Index)(0), Me.dataTableInfoSubTipo.Rows _
            (Me.dgv_subTipo.CurrentRow.Index)(0), Me.dataTableInfoInventario.Rows(Me.dgv_ingrediente.CurrentRow.Index)(0) _
            , Me.txtCantidad.Text) Then
                MsgBox("El registro se guardó satisfactoriamente", MsgBoxStyle.Information, "Mensaje del Sistema ??")
                Me.cancelarReceta()
            Else
                MsgBox("Error:" & Chr(10) & "Ocurrió un problema al grabar el registro.", MsgBoxStyle.Critical, "Mensaje del Sistema ??")
            End If
        Catch ex As Exception
            MsgBox("Error:" & Chr(10) & "" & ex.Message & "", MsgBoxStyle.Critical, "MEnsaje del Sistema ???")
        End Try
    End Sub
End Class