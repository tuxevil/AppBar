Public Class frmRegConsumo
    Dim dataTableinfoGrupos As New DataTable
    Dim objClase As New clsClase
    Dim objTipo As New clsTipo
    Dim objSubTipo As New clsSubtipo
    Dim strRecibeClase(1) As String
    Dim strRecibeTipo(1) As String
    Dim strRecibeSubTipo(2) As String
    Private Sub frmRegConsumo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargarCombo()
    End Sub
    Public Sub cargarCombo()
        Dim objGrupo As New clsGrupo
        Me.dataTableinfoGrupos = objGrupo.consGrupo()
        Me.cmbGrupos.DataSource = dataTableinfoGrupos
        Me.cmbGrupos.ValueMember = "codigo"
        Me.cmbGrupos.DisplayMember = "descripcion"
        GC.ReRegisterForFinalize(objGrupo)
        GC.Collect()
    End Sub

    Private Sub txtNumTarjeta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumTarjeta.KeyPress
        Try
            If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
                e.Handled = False
                If e.KeyChar = Convert.ToChar(Keys.Return) Then
                    If Trim(Me.txtNumTarjeta.Text) = String.Empty Then
                        Throw New Exception("Error:" & Chr(10) & "Ingrese un número de tarjeta.")
                    End If
                    Dim objTarjeta As New clsTarjetaConsumo
                    Dim textRecibe As String = objTarjeta.consClientePorTarjeta(Me.txtNumTarjeta.Text)
                    If textRecibe <> DBNull.Value.ToString Then
                        Me.lblCliente.Text = textRecibe
                        Me.cmbGrupos.Enabled = True
                        Me.txtNumTarjeta.ReadOnly = True
                        Me.btnGrabar.Enabled = True
                        Me.gbRegistro.Enabled = True
                        Me.btnSalir.Text = "&Cancelar"
                        Me.cmbGrupos.Focus()
                    Else
                        MsgBox("Error:" & Chr(10) & "El número de tarjeta no existe.", MsgBoxStyle.Exclamation, "Mensaje del Sistema ??")
                        cancelarRegistro()
                    End If
                End If
            Else
                e.Handled = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Mensaje del Sistema ???")
        End Try
    End Sub
    Public Sub cancelarRegistro()
        Me.txtClase.Text = String.Empty
        Me.txtTipo.Text = String.Empty
        Me.txtSubtipo.Text = String.Empty
        Me.txtSubtipo.Text = String.Empty
        Me.txtCantidad.Text = String.Empty
        Me.lblClase.Text = "Desconocido"
        Me.lblTipo.Text = "Desconocido"
        Me.lblSubTipo.Text = "Desconocido"
        Me.lblPvp.Text = "PVP: $"
        Me.lblTotal.Text = "TOTAL: $"
        Me.cmbGrupos.Enabled = False
        Me.txtNumTarjeta.Text = String.Empty
        Me.lblCliente.Text = String.Empty
        Me.txtNumTarjeta.ReadOnly = False
        Me.btnSalir.Text = "&Salir"
        Me.btnGrabar.Enabled = False
        Me.gbRegistro.Enabled = False
        Me.txtNumTarjeta.Focus()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        If Me.btnSalir.Text = "&Salir" Then
            Me.Close()
        Else
            cancelarRegistro()
        End If
    End Sub

    Private Sub txtClase_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtClase.KeyUp
        strRecibeClase = objClase.consClaseByAb(Me.cmbGrupos.SelectedValue, Me.txtClase.Text)
        If strRecibeClase(1) <> DBNull.Value.ToString Then
            Me.lblClase.Text = strRecibeClase(1)
            Me.lblTipo.Text = "Desconocido"
            Me.lblSubTipo.Text = "Desconocido"
            Me.txtTipo.Text = String.Empty
            Me.txtSubtipo.Text = String.Empty
            Me.txtCantidad.Text = String.Empty
            Me.lblPvp.Text = "PVP: $"
            Me.lblTotal.Text = "TOTAL: $"
            Me.txtTipo.Focus()
        Else
            Me.lblClase.Text = "Desconocido"
            Me.txtClase.Focus()
        End If
    End Sub

    Private Sub txtTipo_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTipo.KeyUp
        strRecibeTipo = objTipo.consTipoByAb(Me.strRecibeClase(0), Me.txtTipo.Text)
        If strRecibeTipo(1) <> DBNull.Value.ToString Then
            Me.lblTipo.Text = strRecibeTipo(1)
            Me.lblSubTipo.Text = "Desconocido"
            Me.txtSubtipo.Text = String.Empty
            Me.txtCantidad.Text = String.Empty
            Me.lblPvp.Text = "PVP: $"
            Me.lblTotal.Text = "TOTAL: $"
            Me.txtSubtipo.Focus()
        Else
            Me.lblTipo.Text = "Desconocido"
            Me.txtTipo.Focus()
        End If
    End Sub

    Private Sub txtSubtipo_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSubtipo.KeyUp
        strRecibeSubTipo = objSubTipo.consSubTipoByAb(Me.strRecibeTipo(0), Me.txtSubtipo.Text)
        If strRecibeSubTipo(1) <> DBNull.Value.ToString Then
            Me.lblSubTipo.Text = strRecibeSubTipo(1)
            Me.lblPvp.Text = "PVP: $" & Me.strRecibeSubTipo(2).ToString
            Me.txtCantidad.Focus()
        Else
            Me.lblSubTipo.Text = "Desconocido"
            Me.txtSubtipo.Focus()
        End If
    End Sub

    Private Sub cmbGrupos_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbGrupos.SelectionChangeCommitted
        Me.lblClase.Text = "Desconocido"
        Me.lblTipo.Text = "Desconocido"
        Me.lblSubTipo.Text = "Desconocido"
        Me.lblPvp.Text = "PVP: $"
        Me.txtClase.Text = String.Empty
        Me.txtTipo.Text = String.Empty
        Me.txtSubtipo.Text = String.Empty
    End Sub

    Private Sub txtCantidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidad.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtCantidad_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCantidad.KeyUp
        Dim tot As Double
        If Me.txtCantidad.Text = String.Empty Then
            tot = Me.strRecibeSubTipo(2) * 0
        Else
            tot = Me.strRecibeSubTipo(2) * Me.txtCantidad.Text
        End If
        Me.lblTotal.Text = "TOTAL: $" & tot.ToString
    End Sub

    Private Sub btnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabar.Click
        Try
            If Me.lblClase.Text = "Desconocido" Then
                Me.txtClase.Focus()
                Throw New Exception("La abreviatura no existe.")
            ElseIf Me.lblTipo.Text = "Desconocido" Then
                Me.txtTipo.Focus()
                Throw New Exception("La abreviatura no existe.")
            ElseIf Me.lblSubTipo.Text = "Desconocido" Then
                Me.txtSubtipo.Focus()
                Throw New Exception("La abreviatura no existe.")
            ElseIf Trim(Me.txtCantidad.Text) = String.Empty Then
                Me.txtCantidad.Focus()
                Throw New Exception("Ingrese una cantidad correcta.")
            ElseIf Me.txtCantidad.Text = 0 Then
                Me.txtCantidad.Focus()
                Throw New Exception("Ingrese una cantidad mayor a cero.")
            End If
            Dim objConsumo As New clsConsumo
            If objConsumo.grabarConsumo(Me.txtNumTarjeta.Text, Me.strRecibeClase(0), Me.strRecibeTipo(0), Me.strRecibeSubTipo(0), Me.txtCantidad.Text) Then
                MsgBox("Registro guardado satisfactoriamente", MsgBoxStyle.Information, "Mensaje del Sistema ??")
                Me.cancelarRegistro()
            Else
                MsgBox("Ocurrió un error al grabar el registro", MsgBoxStyle.Critical, "Mensaje del Sistema ??")
            End If
        Catch ex As Exception
            MsgBox("Error:" & Chr(10) & "" & ex.Message & "", MsgBoxStyle.Critical, "Mensaje del Sistema ???")
        End Try
    End Sub
End Class