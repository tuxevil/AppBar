Public Class frmPrincipal
    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        For Each ChildForm As Form In Me.MdiChildren
            If ChildForm.Name = "frmRegClase" Then
                Exit Sub
            End If
        Next
        Dim objFrmRegClase As New frmRegClase
        objFrmRegClase.MdiParent = Me
        objFrmRegClase.Show()
        GC.ReRegisterForFinalize(objFrmRegClase)
        GC.Collect()
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        For Each ChildForm As Form In Me.MdiChildren
            If ChildForm.Name = "frmIngresoFormaPago" Then
                Exit Sub
            End If
        Next
        Dim objFrmFormaPago As New frmIngresoFormaPago
        objFrmFormaPago.MdiParent = Me
        objFrmFormaPago.Show()
        GC.ReRegisterForFinalize(objFrmFormaPago)
        GC.Collect()
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        For Each ChildForm As Form In Me.MdiChildren
            If ChildForm.Name = "frmIngresoCliente" Then
                Exit Sub
            End If
        Next
        Dim objFrmIngresoCliente As New frmIngresoCliente
        objFrmIngresoCliente.MdiParent = Me
        objFrmIngresoCliente.Show()
        GC.ReRegisterForFinalize(objFrmIngresoCliente)
        GC.Collect()
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        For Each ChildForm As Form In Me.MdiChildren
            If ChildForm.Name = "frmRegConsumo" Then
                Exit Sub
            End If
        Next
        Dim objFrmRegConsumo As New frmRegConsumo
        objFrmRegConsumo.MdiParent = Me
        objFrmRegConsumo.Show()
        GC.ReRegisterForFinalize(objFrmRegConsumo)
        GC.Collect()
    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click
        For Each ChildForm As Form In Me.MdiChildren
            If ChildForm.Name = "frmReceta" Then
                Exit Sub
            End If
        Next
        Dim objFrmReceta As New frmReceta
        objFrmReceta.MdiParent = Me
        objFrmReceta.Show()
        GC.ReRegisterForFinalize(objFrmReceta)
        GC.Collect()
    End Sub

    Private Sub ToolStripButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton6.Click
        For Each ChildForm As Form In Me.MdiChildren
            If ChildForm.Name = "frmIngresoInventario" Then
                Exit Sub
            End If
        Next
        Dim objfrmIngresoInventario As New frmIngresoInventario
        objfrmIngresoInventario.MdiParent = Me
        objfrmIngresoInventario.Show()
        GC.ReRegisterForFinalize(objfrmIngresoInventario)
        GC.Collect()
    End Sub

    Private Sub ToolStripButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton7.Click
        For Each ChildForm As Form In Me.MdiChildren
            If ChildForm.Name = "frmFormaPago" Then
                Exit Sub
            End If
        Next
        Dim objfrmCancelartarjeta As New frmFormaPago
        objfrmCancelartarjeta.MdiParent = Me
        objfrmCancelartarjeta.Show()
        GC.ReRegisterForFinalize(objfrmCancelartarjeta)
        GC.Collect()
    End Sub
End Class