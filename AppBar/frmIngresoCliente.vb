Public Class frmIngresoCliente
    Dim comaPress As Boolean = False
    Dim datatableInfoFormaPago As New DataTable
    Private Sub frmIngresoCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargarCombo()
    End Sub
    Public Sub cargarCombo()
        Dim objFormaPago As New clsFormaPago
        Me.datatableInfoFormaPago = objFormaPago.consFormaPago()
        Me.cmbFormaPago.DataSource = datatableInfoFormaPago
        Me.cmbFormaPago.ValueMember = "codigo"
        Me.cmbFormaPago.DisplayMember = "descripcion"
        Me.obtenerCodtarjeta()
        GC.ReRegisterForFinalize(objFormaPago)
        GC.Collect()
    End Sub
    Public Sub obtenerCodtarjeta()
        Dim objTarjeta As New clsTarjetaConsumo
        Me.lblCodtarjeta.Text = objTarjeta.obtenerNumTarjeta
        GC.ReRegisterForFinalize(objTarjeta)
        GC.Collect()
    End Sub
    Public Sub cancelarTarjeta()
        comaPress = False
        Me.txtnombreCliente.Text = String.Empty
        Me.dtpFecha.Value = Now
        Me.txtHombres.Text = String.Empty
        Me.txtMujeres.Text = String.Empty
        Me.cargarCombo()
        Me.txtnombreCliente.Focus()
    End Sub

    Private Sub txtHombres_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtHombres.KeyPress
        validaIngreso(e)
    End Sub

    Private Sub txtMujeres_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMujeres.KeyPress
        validaIngreso(e)
    End Sub
    Public Sub validaIngreso(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabar.Click
        Try
            If Trim(Me.txtnombreCliente.Text) = String.Empty Then
                Me.txtnombreCliente.Focus()
                Throw New Exception("Error:" & Chr(10) & "Debe ingresar un nombre.")
            ElseIf Me.txtHombres.Text = String.Empty Then
                Me.txtHombres.Focus()
                Throw New Exception("Error:" & Chr(10) & "Debe ingresar por lo menos una persona.")
            ElseIf Me.txtMujeres.Text = String.Empty Then
                Me.txtMujeres.Focus()
                Throw New Exception("Error:" & Chr(10) & "Debe ingresar por lo menos una persona.")
            ElseIf Me.txtHombres.Text = 0 And Me.txtMujeres.Text = 0 Then
                Me.txtHombres.Focus()
                Throw New Exception("Error:" & Chr(10) & "Debe ingresar por lo menos una persona.")
            ElseIf Me.txtMujeres.Text = 0 And Me.txtHombres.Text = 0 Then
                Me.txtMujeres.Focus()
                Throw New Exception("Error:" & Chr(10) & "Debe ingresar por lo menos una persona.")
            ElseIf Me.txtValor.Text = String.Empty Or Me.txtValor.Text = "," Then
                Me.txtValor.Focus()
                Throw New Exception("Error:" & Chr(10) & "Debe ingresar un valor correcto.")
            End If
            Dim objTarjetaConsumo As New clsTarjetaConsumo
            If objTarjetaConsumo.grabaInfoCliente(Me.txtnombreCliente.Text, Me.dtpFecha.Value, Me.txtHombres.Text, _
            Me.txtMujeres.Text, Me.cmbFormaPago.SelectedValue, Me.txtValor.Text) = 2 Then
                MsgBox("Registro guardado satisfactoriamente", MsgBoxStyle.Information, "Mensaje del Sistema ??")
                cancelarTarjeta()
            Else
                MsgBox("Ocurrió un error al grabar el registro", MsgBoxStyle.Critical, "Mensaje del Sistema ??")
            End If
            GC.ReRegisterForFinalize(objTarjetaConsumo)
            GC.Collect()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Mensaje del Sistema ???")
        End Try
    End Sub

    Private Sub txtValor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtValor.KeyPress
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

    Private Sub txtValor_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtValor.KeyUp
        Dim i As Int16 = Me.txtValor.Text.IndexOf(",")
        If Me.txtValor.Text = String.Empty Or i = -1 Then
            comaPress = False
        End If
    End Sub
End Class