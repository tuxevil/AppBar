Imports System.Data.SqlClient
Public Class clsDetallePago
    Public Sub New()

    End Sub

    Public Function consDetallePago(ByVal tarjeta As Integer) As DataTable
        Dim dataSetRetorna As New DataTable
        Try
            Dim objConexion As New Conexion
            Dim strSQL As String
            strSQL = "sp_cons_detallePago_BySel"
            objConexion.conectar(True)
            Dim objDataAdapter As New SqlDataAdapter(strSQL, objConexion.conexion1)
            With objDataAdapter.SelectCommand
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@tarjeta", tarjeta)
            End With

            objDataAdapter.Fill(dataSetRetorna)
            objConexion.conectar(False)
            GC.ReRegisterForFinalize(objDataAdapter)
            GC.ReRegisterForFinalize(objConexion)
            GC.Collect()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
        Return dataSetRetorna
    End Function

    Public Function grabarDetallePago(ByVal tarjeta As Integer, ByVal formaPago As Integer, ByVal valor As Double) As Boolean
        Try
            Dim objConexion As New Conexion
            Dim objComando As New SqlCommand
            objConexion.conectar(True)
            With objComando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "sp_insert_Detalle_Pago"
                .Parameters.AddWithValue("@tarjeta", tarjeta)
                .Parameters.AddWithValue("@formaPago", formaPago)
                .Parameters.AddWithValue("@valor", valor)
                .Connection = objConexion.conexion1
                Return .ExecuteNonQuery
            End With
            objConexion.conectar(False)
            GC.ReRegisterForFinalize(objConexion)
            GC.ReRegisterForFinalize(objComando)
            GC.Collect()
        Catch ex As Exception
            Return False
        End Try
    End Function
End Class
