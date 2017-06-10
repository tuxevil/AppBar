Public Class frmGrupos
    Dim DataTableInfoGrupos As New DataTable
    Private Sub frmGrupos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadGridGrupo()
        Me.btnGrabar.Enabled = False
        Me.txtNombre.Focus()
    End Sub
    Public Sub loadGridGrupo()
        Dim objGrupos As New clsGrupo
        DataTableInfoGrupos = objGrupos.consGrupo
        DataTableInfoGrupos.Columns(0).ColumnMapping = MappingType.Hidden
        DataTableInfoGrupos.Columns(2).ColumnMapping = MappingType.Hidden
        Me.dgv_grupo.DataSource = DataTableInfoGrupos
        Me.dgv_grupo.Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
        GC.ReRegisterForFinalize(objGrupos)
        GC.Collect()
        clickGridGrupo()
    End Sub
    Public Sub cancelarGrupo()
        Me.txtNombre.ReadOnly = True
        Me.btnModificar.Text = "&Modificar"
        Me.btnSalir.Text = "&Salir"
        Me.btnGrabar.Enabled = False
        Me.btnModificar.Enabled = True
        Me.dgv_grupo.Enabled = True
        Me.btnNuevo.Enabled = True
        Me.btnAbajo.Enabled = True
        Me.btnArriba.Enabled = True
        Me.loadGridGrupo()
    End Sub
    Public Sub clickGridGrupo()
        Dim indexGrupo As Integer = Me.dgv_grupo.CurrentRow.Index
        If indexGrupo = 0 Then
            Me.btnArriba.Enabled = False
            Me.btnAbajo.Enabled = True
        ElseIf indexGrupo = Me.dgv_grupo.RowCount - 1 Then
            Me.btnAbajo.Enabled = False
            Me.btnArriba.Enabled = True
        Else
            Me.btnAbajo.Enabled = True
            Me.btnArriba.Enabled = True
        End If
        Me.txtNombre.Text = DataTableInfoGrupos.Rows(indexGrupo)(1)
    End Sub
    Private Sub dgv_grupo_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_grupo.CellClick
        clickGridGrupo()
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Me.dgv_grupo.Enabled = False
        Me.btnSalir.Text = "&Cancelar"
        Me.btnGrabar.Enabled = True
        Me.btnModificar.Enabled = False
        Me.txtNombre.Text = String.Empty
        Me.txtNombre.ReadOnly = False
        Me.btnAbajo.Enabled = False
        Me.btnArriba.Enabled = False
        Me.txtNombre.Focus()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        If Me.btnSalir.Text = "&Salir" Then
            Me.Close()
        Else
            cancelarGrupo()
        End If
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        If Me.btnModificar.Text = "&Modificar" Then
            Me.btnModificar.Text = "&Aceptar"
            Me.btnSalir.Text = "&Cancelar"
            Me.btnNuevo.Enabled = False
            Me.txtNombre.ReadOnly = False
            Me.btnAbajo.Enabled = False
            Me.btnArriba.Enabled = False
            Me.txtNombre.Focus()
        Else
            Dim objGrupo As New clsGrupo
            Dim codGrupo As Integer = Me.DataTableInfoGrupos.Rows(Me.dgv_grupo.CurrentRow.Index)(0)
            If objGrupo.modificarGrupo(codGrupo, Me.txtNombre.Text) Then
                MsgBox("Modificado con éxito", MsgBoxStyle.Information, "Mensaje del Sistema")
                cancelarGrupo()
            Else
                MsgBox("Ocurrió un error al modificar el registro", MsgBoxStyle.Critical, "Mensaje del Sistema")
            End If
            GC.ReRegisterForFinalize(objGrupo)
            GC.Collect()
        End If
    End Sub

    Private Sub btnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabar.Click
        Dim objGrupo As New clsGrupo
        If objGrupo.grabarGrupo(Me.txtNombre.Text) Then
            MsgBox("Registro guardado satisfactoriamente", MsgBoxStyle.Information, "Mensaje del Sistema ??")
            cancelarGrupo()
        Else
            MsgBox("Ocurrió un error al grabar el registro", MsgBoxStyle.Critical, "Mensaje del Sistema ??")
        End If
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        If MsgBox("¿Confirma que desea eliminar el registro?", MsgBoxStyle.YesNo, "Mensaje del Sistema") = MsgBoxResult.Yes Then
            Dim objGrupos As New clsGrupo
            Dim codgrupo As Integer = Me.DataTableInfoGrupos.Rows(Me.dgv_grupo.CurrentRow.Index)(0)
            If objGrupos.eliminargrupo(codgrupo) Then
                MsgBox("El registro se eliminó con éxito", MsgBoxStyle.Information, "Mensaje del Sistema")
                cancelarGrupo()
            Else
                MsgBox("Ocurrió un error al eliminar el registro", MsgBoxStyle.Critical, "Mensaje del Sistema")
            End If
        End If
    End Sub

    Private Sub btnArriba_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnArriba.Click
        Try
            Dim indexGrid As Integer = Me.dgv_grupo.CurrentRow.Index
            Dim codigo1 As Integer = Me.DataTableInfoGrupos.Rows(indexGrid)(0)
            Dim codigo2 As Integer = Me.DataTableInfoGrupos.Rows(indexGrid - 1)(0)
            Dim varTemp1 As Integer = Me.DataTableInfoGrupos.Rows(indexGrid)(2)
            Dim varTemp2 As Integer = Me.DataTableInfoGrupos.Rows(indexGrid - 1)(2)
            Dim objGrupo As New clsGrupo
            objGrupo.upGrupo(codigo1, codigo2, varTemp1, varTemp2)
            Me.dgv_grupo.DataSource = Nothing
            loadGridGrupo()
            Me.dgv_grupo.CurrentCell = Me.dgv_grupo.Rows(indexGrid - 1).Cells(0)
            validaIndex(indexGrid, True)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnAbajo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbajo.Click
        Try
            Dim indexGrid As Integer = Me.dgv_grupo.CurrentRow.Index
            Dim codigo1 As Integer = Me.DataTableInfoGrupos.Rows(indexGrid)(0)
            Dim codigo2 As Integer = Me.DataTableInfoGrupos.Rows(indexGrid + 1)(0)
            Dim varTemp1 As Integer = Me.DataTableInfoGrupos.Rows(indexGrid)(2)
            Dim varTemp2 As Integer = Me.DataTableInfoGrupos.Rows(indexGrid + 1)(2)
            Dim objGrupo As New clsGrupo
            objGrupo.upGrupo(codigo1, codigo2, varTemp1, varTemp2)
            Me.dgv_grupo.DataSource = Nothing
            loadGridGrupo()
            Me.dgv_grupo.CurrentCell = Me.dgv_grupo.Rows(indexGrid + 1).Cells(0)
            validaIndex(indexGrid, False)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub validaIndex(ByVal indexGrid As Integer, ByVal valor As Boolean)
        If valor Then
            If ((indexGrid - 1) = 0) Or (indexGrid = 0) Then
                Me.btnArriba.Enabled = False
                Me.btnAbajo.Enabled = True
            Else
                Me.btnArriba.Enabled = True
                Me.btnAbajo.Enabled = True
            End If
        Else
            If (indexGrid + 1) = (Me.dgv_grupo.RowCount - 1) Then
                Me.btnAbajo.Enabled = False
                Me.btnArriba.Enabled = True
            Else
                Me.btnArriba.Enabled = True
                Me.btnAbajo.Enabled = True
            End If
        End If
    End Sub
End Class