Public Class frmRegClase
    Dim comaPress As Boolean = False
    Dim comaPress1 As Boolean = False
    Dim dataTableInfoClase As New DataTable
    Dim dataTableInfoTipo As New DataTable
    Dim dataTableInfoSubTipo As New DataTable
    Dim DataTableInfoGrupos As New DataTable

    Private Sub frmRegClase_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cargarComboGrupo()
        loadGridClase()
    End Sub
    Private Sub DGV_CLASE_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_clase.CellClick
        ClickGridClase()
    End Sub

    Private Sub dgv_tipo_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_tipo.CellClick
        clickGridTipo()
    End Sub

    Private Sub dgv_subtipo_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_subtipo.CellClick
        clickGridSubTipo()
    End Sub

    Public Sub cargarComboGrupo()
        Dim objGrupos As New clsGrupo
        DataTableInfoGrupos = objGrupos.consGrupo
        Me.cmbGrupo.DataSource = DataTableInfoGrupos
        Me.cmbGrupo.DisplayMember = "descripcion"
        Me.cmbGrupo.ValueMember = "codigo"
        GC.ReRegisterForFinalize(objGrupos)
        GC.Collect()
    End Sub
    Public Sub loadGridClase()
        Dim objClase As New clsClase
        dataTableInfoClase = objClase.consClase
        dataTableInfoClase.Columns(0).ColumnMapping = MappingType.Hidden
        Me.dgv_clase.DataSource = dataTableInfoClase
        Me.dgv_clase.Columns(0).HeaderText = "Grupos"
        Me.dgv_clase.Columns(1).Width = 160
        Me.dgv_clase.Columns(1).HeaderText = "Descripcion del Producto"
        Me.dgv_clase.Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
        Me.dgv_clase.Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable
        Me.dgv_clase.Columns(2).SortMode = DataGridViewColumnSortMode.NotSortable
        GC.ReRegisterForFinalize(objClase)
        GC.Collect()
        ClickGridClase()
    End Sub
    Public Sub ClickGridClase()
        Dim indexGrid As Integer = Me.dgv_clase.CurrentRow.Index
        Me.txtDescripcionClase.Text = dataTableInfoClase.Rows(indexGrid)(2)
        Me.txtAbreviaturaClase.Text = dataTableInfoClase.Rows(indexGrid)(3)
        Me.cmbGrupo.Text = Me.dataTableInfoClase.Rows(indexGrid)(1)
        Dim objTipo As New clsTipo
        dataTableInfoTipo = objTipo.consTipo(dataTableInfoClase.Rows(indexGrid)(0))
        dataTableInfoTipo.Columns(0).ColumnMapping = MappingType.Hidden
        Me.dgv_tipo.DataSource = dataTableInfoTipo
        Me.dgv_tipo.Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
        Me.dgv_tipo.Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable
        Me.btnGrabaClase.Enabled = False
        GC.ReRegisterForFinalize(objTipo)
        GC.Collect()
        clickGridTipo()
    End Sub
    Public Sub clickGridTipo()
        If Me.dgv_tipo.RowCount = 0 Then
            dataTableInfoSubTipo.Rows.Clear()
        Else
            Dim indexGrid As Integer = Me.dgv_tipo.CurrentRow.Index
            Me.txtDescripcionTipo.Text = dataTableInfoTipo.Rows(indexGrid)(1)
            Me.txtAbreviaturaTipo.Text = dataTableInfoTipo.Rows(indexGrid)(2)
            Dim objSubTipo As New clsSubtipo
            dataTableInfoSubTipo = objSubTipo.consSubTipo(dataTableInfoTipo.Rows(indexGrid)(0))
            dataTableInfoSubTipo.Columns(0).ColumnMapping = MappingType.Hidden
            Me.dgv_subtipo.DataSource = dataTableInfoSubTipo
            Me.dgv_subtipo.Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
            Me.dgv_subtipo.Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable
            Me.dgv_subtipo.Columns(2).SortMode = DataGridViewColumnSortMode.NotSortable
            Me.dgv_subtipo.Columns(3).SortMode = DataGridViewColumnSortMode.NotSortable
            Me.btnGrabarTipo.Enabled = False
            GC.ReRegisterForFinalize(objSubTipo)
            GC.Collect()
        End If
        clickGridSubTipo()
    End Sub
    Public Sub clickGridSubTipo()
        If Me.dgv_subtipo.RowCount = 0 Then
        Else
            Dim indexGrid As Integer = Me.dgv_subtipo.CurrentRow.Index
            Me.txtDescripcionSubtipo.Text = dataTableInfoSubTipo.Rows(indexGrid)(1)
            Me.txtAbreviaturaSubtipo.Text = dataTableInfoSubTipo.Rows(indexGrid)(2)
            Me.txtCostoSubTipo.Text = dataTableInfoSubTipo.Rows(indexGrid)(3)
            Me.txtPvpSubTipo.Text = dataTableInfoSubTipo.Rows(indexGrid)(4)
            Me.btnGrabaSubTipo.Enabled = False
        End If
    End Sub

    Private Sub btnNuevoClase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevoClase.Click
        Me.btnCallFrmGrupo.Enabled = False
        Me.gb_Tipo.Enabled = False
        Me.gb_SubTipo.Enabled = False
        Me.dgv_clase.Enabled = False
        Me.btnGrabaClase.Enabled = True
        Me.btnModificaClase.Enabled = False
        Me.btnEliminaClase.Text = "&Cancelar"
        Me.txtDescripcionClase.Text = String.Empty
        Me.txtAbreviaturaClase.Text = String.Empty
        Me.txtDescripcionClase.ReadOnly = False
        Me.txtAbreviaturaClase.ReadOnly = False
        Me.cmbGrupo.Enabled = True
        Me.txtDescripcionClase.Focus()
    End Sub

    Private Sub btnEliminaClase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminaClase.Click
        If Me.btnEliminaClase.Text = "&Cancelar" Then
            CancelarClase()
        Else
            If MsgBox("¿Confirma que desea eliminar el registro?", MsgBoxStyle.YesNo, "Mensaje del Sistema") = MsgBoxResult.Yes Then
                Dim objClase As New clsClase
                Dim codClase As Integer = Me.dataTableInfoClase.Rows(Me.dgv_clase.CurrentRow.Index)(0)
                If objClase.eliminarClase(codClase) Then
                    MsgBox("El registro se eliminó con éxito", MsgBoxStyle.Information, "Mensaje del Sistema")
                    CancelarClase()
                Else
                    MsgBox("Ocurrió un error al eliminar el registro", MsgBoxStyle.Critical, "Mensaje del Sistema")
                End If
            End If
        End If
    End Sub
    Public Sub CancelarClase()
        Me.btnCallFrmGrupo.Enabled = True
        Me.btnEliminaClase.Text = "&Eliminar"
        Me.btnModificaClase.Text = "&Modificar"
        Me.txtDescripcionClase.ReadOnly = True
        Me.txtAbreviaturaClase.ReadOnly = True
        Me.btnGrabaClase.Enabled = False
        Me.btnModificaClase.Enabled = True
        Me.btnNuevoClase.Enabled = True
        Me.dgv_clase.Enabled = True
        Me.gb_Tipo.Enabled = True
        Me.gb_SubTipo.Enabled = True
        Me.cmbGrupo.Enabled = False
        Me.cargarComboGrupo()
        loadGridClase()
    End Sub

    Private Sub btnModificaClase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificaClase.Click
        Try
            If Me.btnModificaClase.Text = "&Modificar" Then
                Me.btnModificaClase.Text = "&Aceptar"
                Me.gb_Tipo.Enabled = False
                Me.gb_SubTipo.Enabled = False
                Me.btnNuevoClase.Enabled = False
                Me.btnEliminaClase.Text = "&Cancelar"
                Me.txtDescripcionClase.ReadOnly = False
                Me.txtAbreviaturaClase.ReadOnly = False
                Me.btnCallFrmGrupo.Enabled = False
                Me.txtDescripcionClase.Focus()
            Else
                If Trim(Me.txtDescripcionClase.Text) = String.Empty Then
                    Me.txtDescripcionClase.Focus()
                    Throw New Exception("Debe ingresar una descripción para la clase.")
                ElseIf Trim(Me.txtAbreviaturaClase.Text) = String.Empty Then
                    Me.txtAbreviaturaClase.Focus()
                    Throw New Exception("Debe ingresar una abreviatura para la clase.")
                End If
                Dim objClase As New clsClase
                Dim codClase As Integer = Me.dataTableInfoClase.Rows(Me.dgv_clase.CurrentRow.Index)(0)
                If objClase.modificarClase(codClase, Me.txtDescripcionClase.Text, Me.txtAbreviaturaClase.Text) Then
                    MsgBox("Modificado con éxito", MsgBoxStyle.Information, "Mensaje del Sistema")
                    CancelarClase()
                Else
                    MsgBox("Ocurrió un error al modificar el registro", MsgBoxStyle.Critical, "Mensaje del Sistema")
                End If
            End If
        Catch ex As Exception
            MsgBox("Error:" & Chr(10) & "" & ex.Message & "", MsgBoxStyle.Critical, "Mensaje del Sistema ???")
        End Try
    End Sub

    Private Sub btnNuevoTipo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevoTipo.Click
        Me.btnCallFrmGrupo.Enabled = False
        Me.gb_Clase.Enabled = False
        Me.gb_SubTipo.Enabled = False
        Me.dgv_tipo.Enabled = False
        Me.btnGrabarTipo.Enabled = True
        Me.btnModificaTipo.Enabled = False
        Me.btnEliminaTipo.Text = "C&ancelar"
        Me.txtDescripcionTipo.Text = String.Empty
        Me.txtAbreviaturaTipo.Text = String.Empty
        Me.txtDescripcionTipo.ReadOnly = False
        Me.txtAbreviaturaTipo.ReadOnly = False
        Me.txtDescripcionTipo.Focus()
    End Sub

    Private Sub btnEliminaTipo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminaTipo.Click
        Try
            If Me.dgv_tipo.RowCount = 0 Then
                Throw New Exception("No existen registros para eliminar.")
            End If
            If Me.btnEliminaTipo.Text = "C&ancelar" Then
                cancelarTipo()
            Else
                If MsgBox("¿Confirma que desea eliminar el registro?", MsgBoxStyle.YesNo, "Mensaje del Sistema") = MsgBoxResult.Yes Then
                    Dim objTipo As New clsTipo
                    Dim codTipo As Integer = Me.dataTableInfoTipo.Rows(Me.dgv_tipo.CurrentRow.Index)(0)
                    If objTipo.eliminarTipo(codTipo) Then
                        MsgBox("El registro se eliminó con éxito", MsgBoxStyle.Information, "Mensaje del Sistema")
                        cancelarTipo()
                    Else
                        MsgBox("Ocurrió un error al eliminar el registro", MsgBoxStyle.Critical, "Mensaje del Sistema")
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("Error:" & Chr(10) & "" & ex.Message & "", MsgBoxStyle.Critical, "Mensaje del Sistema ???")
        End Try
    End Sub
    Public Sub cancelarTipo()
        Me.btnCallFrmGrupo.Enabled = True
        Me.btnEliminaTipo.Text = "E&liminar"
        Me.btnModificaTipo.Text = "M&odificar"
        Me.txtDescripcionTipo.ReadOnly = True
        Me.txtAbreviaturaTipo.ReadOnly = True
        Me.btnGrabarTipo.Enabled = False
        Me.btnModificaTipo.Enabled = True
        Me.btnNuevoTipo.Enabled = True
        Me.dgv_tipo.Enabled = True
        Me.gb_Clase.Enabled = True
        Me.gb_SubTipo.Enabled = True
        loadGridClase()
    End Sub

    Private Sub btnModificaTipo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificaTipo.Click
        Try
            If Me.dgv_tipo.RowCount = 0 Then
                Throw New Exception("No existen registros para modificar.")
            End If
            If Me.btnModificaTipo.Text = "M&odificar" Then
                Me.btnModificaTipo.Text = "A&ceptar"
                Me.gb_Clase.Enabled = False
                Me.gb_SubTipo.Enabled = False
                Me.btnNuevoTipo.Enabled = False
                Me.btnEliminaTipo.Text = "C&ancelar"
                Me.txtDescripcionTipo.ReadOnly = False
                Me.txtAbreviaturaTipo.ReadOnly = False
                Me.btnCallFrmGrupo.Enabled = False
                Me.txtDescripcionTipo.Focus()
            Else
                If Trim(Me.txtDescripcionTipo.Text) = String.Empty Then
                    Me.txtDescripcionTipo.Focus()
                    Throw New Exception("Debe ingresar una descripción para el Tipo.")
                ElseIf Trim(Me.txtAbreviaturaTipo.Text) = String.Empty Then
                    Me.txtAbreviaturaTipo.Focus()
                    Throw New Exception("Debe ingresar una abreviatura para el Tipo.")
                End If
                Dim objTipo As New clsTipo
                Dim codTipo As Integer = Me.dataTableInfoTipo.Rows(Me.dgv_tipo.CurrentRow.Index)(0)
                If objTipo.modificarTipo(codTipo, Me.txtDescripcionTipo.Text, Me.txtAbreviaturaTipo.Text) Then
                    MsgBox("Modificado con éxito", MsgBoxStyle.Information, "Mensaje del Sistema")
                    cancelarTipo()
                Else
                    MsgBox("Ocurrió un error al modificar el registro", MsgBoxStyle.Critical, "Mensaje del Sistema")
                End If
            End If
        Catch ex As Exception
            MsgBox("Error:" & Chr(10) & "" & ex.Message & "", MsgBoxStyle.Critical, "Mensaje del Sistema ???")
        End Try
    End Sub

    Private Sub btnNuevoSubTipo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevoSubTipo.Click
        Me.btnCallFrmGrupo.Enabled = False
        Me.gb_Clase.Enabled = False
        Me.gb_Tipo.Enabled = False
        Me.dgv_subtipo.Enabled = False
        Me.btnGrabaSubTipo.Enabled = True
        Me.btnModificaSubTipo.Enabled = False
        Me.btnEliminaSubTipo.Text = "Ca&ncelar"
        Me.txtDescripcionSubtipo.Text = String.Empty
        Me.txtAbreviaturaSubtipo.Text = String.Empty
        Me.txtCostoSubTipo.Text = String.Empty
        Me.txtPvpSubTipo.Text = String.Empty
        Me.txtDescripcionSubtipo.ReadOnly = False
        Me.txtAbreviaturaSubtipo.ReadOnly = False
        Me.txtPvpSubTipo.ReadOnly = False
        Me.txtCostoSubTipo.ReadOnly = False
        Me.txtDescripcionSubtipo.Focus()
    End Sub

    Private Sub btnEliminaSubTipo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminaSubTipo.Click
        Try
            If Me.dgv_subtipo.RowCount = 0 Then
                Throw New Exception("No existen registros para eliminar.")
            End If
            If Me.btnEliminaSubTipo.Text = "Ca&ncelar" Then
                cancelarSubTipo()
            Else
                If MsgBox("¿Confirma que desea eliminar el registro?", MsgBoxStyle.YesNo, "Mensaje del Sistema") = MsgBoxResult.Yes Then
                    Dim objSubTipo As New clsSubtipo
                    Dim codSubTipo As Integer = Me.dataTableInfoSubTipo.Rows(Me.dgv_subtipo.CurrentRow.Index)(0)
                    If objSubTipo.eliminarSubTipo(codSubTipo) Then
                        MsgBox("El registro se eliminó con éxito", MsgBoxStyle.Information, "Mensaje del Sistema")
                        cancelarSubTipo()
                    Else
                        MsgBox("Ocurrió un error al eliminar el registro", MsgBoxStyle.Critical, "Mensaje del Sistema")
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("Error:" & Chr(10) & "" & ex.Message & "", MsgBoxStyle.Critical, "Mensaje del Sistema ???")
        End Try
    End Sub
    Public Sub cancelarSubTipo()
        Me.comaPress = False
        Me.comaPress1 = False
        Me.btnCallFrmGrupo.Enabled = True
        Me.btnEliminaSubTipo.Text = "El&iminar"
        Me.btnModificaSubTipo.Text = "Mo&dificar"
        Me.txtDescripcionSubtipo.ReadOnly = True
        Me.txtAbreviaturaSubtipo.ReadOnly = True
        Me.txtPvpSubTipo.ReadOnly = True
        Me.txtCostoSubTipo.ReadOnly = True
        Me.btnGrabaSubTipo.Enabled = False
        Me.btnModificaSubTipo.Enabled = True
        Me.btnNuevoSubTipo.Enabled = True
        Me.dgv_subtipo.Enabled = True
        Me.gb_Clase.Enabled = True
        Me.gb_Tipo.Enabled = True
        loadGridClase()
    End Sub

    Private Sub btnModificaSubTipo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificaSubTipo.Click
        Try
            If Me.dgv_subtipo.RowCount = 0 Then
                Throw New Exception("No existen registros para modificar.")
            End If
            If Me.btnModificaSubTipo.Text = "Mo&dificar" Then
                Me.btnModificaSubTipo.Text = "A&ceptar"
                Me.gb_Clase.Enabled = False
                Me.gb_Tipo.Enabled = False
                Me.btnNuevoSubTipo.Enabled = False
                Me.btnEliminaSubTipo.Text = "Ca&ncelar"
                Me.txtDescripcionSubtipo.ReadOnly = False
                Me.txtAbreviaturaSubtipo.ReadOnly = False
                Me.txtPvpSubTipo.ReadOnly = False
                Me.txtCostoSubTipo.ReadOnly = False
                Me.btnCallFrmGrupo.Enabled = False
                Me.txtDescripcionSubtipo.Focus()
            Else
                Dim objSubTipo As New clsSubtipo
                Dim codSubTipo As Integer = Me.dataTableInfoSubTipo.Rows(Me.dgv_subtipo.CurrentRow.Index)(0)
                If objSubTipo.modificarSubTipo(codSubTipo, Me.txtDescripcionSubtipo.Text, Me.txtAbreviaturaSubtipo.Text, Me.txtCostoSubTipo.Text, Me.txtPvpSubTipo.Text) Then
                    MsgBox("Modificado con éxito", MsgBoxStyle.Information, "Mensaje del Sistema")
                    cancelarSubTipo()
                Else
                    MsgBox("Ocurrió un error al modificar el registro", MsgBoxStyle.Critical, "Mensaje del Sistema")
                End If
            End If
        Catch ex As Exception
            MsgBox("Error:" & Chr(10) & "" & ex.Message & "", MsgBoxStyle.Critical, "Mensaje del Sistema ???")
        End Try
    End Sub

    Private Sub btnGrabaClase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabaClase.Click
        Try
            If Trim(Me.txtDescripcionClase.Text) = String.Empty Then
                Me.txtDescripcionClase.Focus()
                Throw New Exception("Debe ingresar una descripción para la Clase.")
            ElseIf Trim(Me.txtAbreviaturaClase.Text) = String.Empty Then
                Me.txtAbreviaturaClase.Focus()
                Throw New Exception("Debe ingresar una abreviatura para la Clase.")
            End If
            Dim objClase As New clsClase
            If objClase.grabarClase(Me.txtDescripcionClase.Text, Me.txtAbreviaturaClase.Text, _
            Me.cmbGrupo.SelectedValue) Then
                MsgBox("Registro guardado satisfactoriamente", MsgBoxStyle.Information, "Mensaje del Sistema ??")
                CancelarClase()
            Else
                MsgBox("Ocurrió un error al grabar el registro", MsgBoxStyle.Critical, "Mensaje del Sistema ??")
            End If
        Catch ex As Exception
            MsgBox("Error:" & Chr(10) & "" & ex.Message & "", MsgBoxStyle.Critical, "Mensaje de lSistema ???")
        End Try
    End Sub

    Private Sub btnGrabarTipo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabarTipo.Click
        Try
            If Trim(Me.txtDescripcionTipo.Text) = String.Empty Then
                Me.txtDescripcionTipo.Focus()
                Throw New Exception("Debe ingresar una descripción para el Tipo.")
            ElseIf Trim(Me.txtAbreviaturaTipo.Text) = String.Empty Then
                Me.txtAbreviaturaTipo.Focus()
                Throw New Exception("Debe ingresar una abreviatura para el Tipo.")
            End If
            Dim objTipo As New clsTipo
            Dim codClase As Integer = Me.dataTableInfoClase.Rows(Me.dgv_clase.CurrentRow.Index)(0)
            If objTipo.grabartipo(codClase, Me.txtDescripcionTipo.Text, Me.txtAbreviaturaTipo.Text) Then
                MsgBox("Registro guardado satisfactoriamente", MsgBoxStyle.Information, "Mensaje del Sistema")
                cancelarTipo()
            Else
                MsgBox("Ocurrió un error al grabar el registro", MsgBoxStyle.Critical, "Mensaje del Sistema ??")
            End If
        Catch ex As Exception
            MsgBox("Error:" & Chr(10) & "" & ex.Message & "", MsgBoxStyle.Critical, "Mensaje del Sistema ???")
        End Try
    End Sub

    Private Sub btnGrabaSubTipo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabaSubTipo.Click
        Try
            If Trim(Me.txtDescripcionSubtipo.Text) = String.Empty Then
                Me.txtDescripcionSubtipo.Focus()
                Throw New Exception("Debe ingresar una descripción correcta.")
            ElseIf Trim(Me.txtAbreviaturaSubtipo.Text) = String.Empty Then
                Me.txtAbreviaturaSubtipo.Focus()
                Throw New Exception("Debe ingresar una abreviatura correcta.")
            ElseIf Trim(Me.txtCostoSubTipo.Text) = String.Empty Then
                Me.txtCostoSubTipo.Focus()
                Throw New Exception("Debe ingresar un costo correcto.")
            ElseIf Trim(Me.txtPvpSubTipo.Text) = String.Empty Then
                Me.txtPvpSubTipo.Focus()
                Throw New Exception("Debe ingresar un precio correcto.")
            End If
            Dim objSubTipo As New clsSubtipo
            Dim codTipo As Integer = Me.dataTableInfoTipo.Rows(Me.dgv_tipo.CurrentRow.Index)(0)
            If objSubTipo.grabarSubTipo(codTipo, Me.txtDescripcionSubtipo.Text, Me.txtAbreviaturaSubtipo.Text, Me.txtCostoSubTipo.Text, Me.txtPvpSubTipo.Text) Then
                MsgBox("Registro guardado satisfactoriamente", MsgBoxStyle.Information, "Mensaje del Sistema")
                cancelarSubTipo()
            Else
                MsgBox("Ocurrió un error al grabar el registro", MsgBoxStyle.Critical, "Mensaje del Sistema ??")
            End If
        Catch ex As Exception
            MsgBox("Error:" & Chr(10) & "" & ex.Message & "", MsgBoxStyle.Critical, "Mensaje del Sistema ???")
        End Try
    End Sub

    Private Sub btnCallFrmGrupo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCallFrmGrupo.Click
        '        For Each ChildForm As Form In Me.MdiParent.MdiChildren
        '        If ChildForm.Name = "frmGrupos" Then
        '        Exit Sub
        '        End If
        '        Next
        Dim objFrmGrupos As New frmGrupos
        'objFrmGrupos.MdiParent = Me.MdiParent
        objFrmGrupos.ShowDialog()
        GC.ReRegisterForFinalize(objFrmGrupos)
        GC.Collect()
    End Sub

    Private Sub txtCostoSubTipo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCostoSubTipo.KeyPress
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

    Private Sub txtCostoSubTipo_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCostoSubTipo.KeyUp
        Dim i As Int16 = Me.txtCostoSubTipo.Text.IndexOf(",")
        If Me.txtCostoSubTipo.Text = String.Empty Or i = -1 Then
            comaPress = False
        End If
    End Sub

    Private Sub txtPvpSubTipo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPvpSubTipo.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf (e.KeyChar = "." Or e.KeyChar = ",") And (comaPress1 = False) Then
            If e.KeyChar = "." Then
                e.KeyChar = ","
            End If
            comaPress1 = True
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtPvpSubTipo_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPvpSubTipo.KeyUp
        Dim i As Int16 = Me.txtPvpSubTipo.Text.IndexOf(",")
        If Me.txtPvpSubTipo.Text = String.Empty Or i = -1 Then
            comaPress1 = False
        End If
    End Sub
End Class