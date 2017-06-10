Imports System.Data.SqlClient
Public Class clsSubtipo
    Public Sub New()

    End Sub

    Public Function consSubTipo(ByVal clase As Integer) As DataTable
        Dim dataSetRetorna As New DataTable
        Try
            Dim objConexion As New Conexion
            Dim strSQL As String
            strSQL = "select codigo,descripcion,abreviatura,costo,pvp from [SUB-TIPO] where cod_tipo = " & clase & " and status ='A'"
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

    Public Function consSubTipoByAb(ByVal tipo As Integer, ByVal abreviatura As String) As String()
        Dim valorRetorna(2) As String
        Try
            Dim objConexion As New Conexion
            Dim objComando As New SqlCommand
            Dim dataReaderRecibe As SqlDataReader
            Dim strSQL As String = "sp_cons_SubTipoByAb"
            objConexion.conectar(True)
            With objComando
                .CommandType = CommandType.StoredProcedure
                .CommandText = strSQL
                .Parameters.AddWithValue("@tipo", tipo)
                .Parameters.AddWithValue("@abreviatura", abreviatura)
                .Connection = objConexion.conexion1
                dataReaderRecibe = .ExecuteReader
            End With
            If dataReaderRecibe.Read Then
                valorRetorna(0) = dataReaderRecibe.Item(0).ToString
                valorRetorna(1) = dataReaderRecibe.Item(1).ToString
                valorRetorna(2) = dataReaderRecibe.Item(2).ToString
            End If
            dataReaderRecibe.Close()
            objConexion.conectar(False)
            GC.ReRegisterForFinalize(objConexion)
            GC.ReRegisterForFinalize(objComando)
            GC.ReRegisterForFinalize(dataReaderRecibe)
            GC.Collect()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
        Return valorRetorna
    End Function

    Public Function grabarSubTipo(ByVal tipo As Integer, ByVal descripcion As String, ByVal abreviatura As String, _
    ByVal costo As Double, ByVal pvp As Double) As Boolean
        Try
            Dim objConexion As New Conexion
            Dim objComando As New SqlCommand
            objConexion.conectar(True)
            With objComando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "sp_insert_subtipo"
                .Parameters.AddWithValue("@codTipo", tipo)
                .Parameters.AddWithValue("@descripcion", descripcion)
                .Parameters.AddWithValue("@abreviatura", abreviatura)
                .Parameters.AddWithValue("@costo", costo)
                .Parameters.AddWithValue("@pvp", pvp)
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
    Public Function modificarSubTipo(ByVal codigo As Integer, ByVal descripcion As String, ByVal abreviatura As String, _
    ByVal costo As Double, ByVal pvp As Double) As Boolean
        Try
            Dim objConexion As New Conexion
            Dim objComando As New SqlCommand
            objConexion.conectar(True)
            With objComando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "sp_update_subtipo"
                .Parameters.AddWithValue("@codigo", codigo)
                .Parameters.AddWithValue("@descripcion", descripcion)
                .Parameters.AddWithValue("@abreviatura", abreviatura)
                .Parameters.AddWithValue("@costo", costo)
                .Parameters.AddWithValue("@pvp", pvp)
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
    Public Function eliminarSubTipo(ByVal codigo As Integer)
        Try
            Dim objConexion As New Conexion
            Dim objComando As New SqlCommand
            objConexion.conectar(True)
            With objComando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "sp_delete_subtipo"
                .Parameters.AddWithValue("@codigo", codigo)
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
