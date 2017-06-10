Imports System.Data.SqlClient
Public Class clsInventario
    Public Sub New()

    End Sub

    Public Function consInventario() As DataTable
        Dim dataSetRetorna As New DataTable
        Try
            Dim objConexion As New Conexion
            Dim strSQL As String
            strSQL = "select codigo,descripcion,cantidad from INVENTARIO"
            objConexion.conectar(True)
            Dim objDataAdapter As New SqlDataAdapter(strSQL, objConexion.conexion1)
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

    Public Function grabarInventario(ByVal descripcion As String, _
    ByVal cantidad As Integer, ByVal fecha As DateTime) As Int16
        Dim valorRetorna As Int16 = 0
        Try
            Dim objConexion As New Conexion
            Dim objComando As New SqlCommand
            objConexion.conectar(True)
            With objComando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "sp_insert_inventario"
                .Parameters.AddWithValue("@descripcion", descripcion)
                .Parameters.AddWithValue("@cantidad", cantidad)
                .Parameters.AddWithValue("@fecha", fecha)
                .Connection = objConexion.conexion1
                valorRetorna = .ExecuteNonQuery
            End With
            objConexion.conectar(False)
            GC.ReRegisterForFinalize(objConexion)
            GC.ReRegisterForFinalize(objComando)
            GC.Collect()
        Catch ex As Exception
            Return valorRetorna
        End Try
        Return valorRetorna
    End Function
End Class
