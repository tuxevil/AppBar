Imports System.Data.SqlClient
Public Class clsTipo
    Public Sub New()

    End Sub

    Public Function consTipo(ByVal clase As Integer) As DataTable
        Dim dataSetRetorna As New DataTable
        Try
            Dim objConexion As New Conexion
            Dim strSQL As String
            strSQL = "select codigo, descripcion,abreviatura from TIPO where cod_clase = " & clase & " and status ='A'"
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

    Public Function consTipoByAb(ByVal clase As Integer, ByVal abreviatura As String) As String()
        Dim valorRetorna(1) As String
        Try
            Dim objConexion As New Conexion
            Dim objComando As New SqlCommand
            Dim dataReaderRecibe As SqlDataReader
            Dim strSQL As String = "sp_cons_TipoByAb"
            objConexion.conectar(True)
            With objComando
                .CommandType = CommandType.StoredProcedure
                .CommandText = strSQL
                .Parameters.AddWithValue("@clase", clase)
                .Parameters.AddWithValue("@abreviatura", abreviatura)
                .Connection = objConexion.conexion1
                dataReaderRecibe = .ExecuteReader
            End With
            If dataReaderRecibe.Read Then
                valorRetorna(0) = dataReaderRecibe.Item(0).ToString
                valorRetorna(1) = dataReaderRecibe.Item(1).ToString
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

    Public Function grabartipo(ByVal clase As Integer, ByVal descripcion As String, ByVal abreviatura As String) As Boolean
        Try
            Dim objConexion As New Conexion
            Dim objComando As New SqlCommand
            objConexion.conectar(True)
            With objComando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "sp_insert_tipo"
                .Parameters.AddWithValue("@codClase", clase)
                .Parameters.AddWithValue("@descripcion", descripcion)
                .Parameters.AddWithValue("@abreviatura", abreviatura)
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
    Public Function modificarTipo(ByVal codigo As Integer, ByVal descripcion As String, ByVal abreviatura As String) As Boolean
        Try
            Dim objConexion As New Conexion
            Dim objComando As New SqlCommand
            objConexion.conectar(True)
            With objComando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "sp_update_tipo"
                .Parameters.AddWithValue("@codigo", codigo)
                .Parameters.AddWithValue("@descripcion", descripcion)
                .Parameters.AddWithValue("@abreviatura", abreviatura)
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
    Public Function eliminarTipo(ByVal codigo As Integer)
        Try
            Dim objConexion As New Conexion
            Dim objComando As New SqlCommand
            objConexion.conectar(True)
            With objComando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "sp_delete_tipo"
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