Imports System.Data.SqlClient
Public Class clsConsumo
    Public Sub New()

    End Sub

    Public Function consConsumo(ByVal tarjeta As Integer) As DataTable
        Dim dataSetRetorna As New DataTable
        Try
            Dim objConexion As New Conexion
            Dim strSQL As String
            strSQL = "sp_cons_consumo_BySel"
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

    Public Function grabarConsumo(ByVal tarjeta As Integer, ByVal clase As Integer, _
    ByVal tipo As Integer, ByVal subTipo As Integer, ByVal cantidad As Integer) As Boolean
        Try
            Dim objConexion As New Conexion
            Dim objComando As New SqlCommand
            objConexion.conectar(True)
            With objComando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "sp_insert_consumo"
                .Parameters.AddWithValue("@tarjeta", tarjeta)
                .Parameters.AddWithValue("@clase", clase)
                .Parameters.AddWithValue("@tipo", tipo)
                .Parameters.AddWithValue("@subTipo", subTipo)
                .Parameters.AddWithValue("@cantidad", cantidad)
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
