Imports System.Data.SqlClient
Public Class clsGrupo
    Public Sub New()

    End Sub

    Public Function consGrupo() As DataTable
        Dim dataSetRetorna As New DataTable
        Try
            Dim objConexion As New Conexion
            Dim strSQL As String
            strSQL = "select codigo,descripcion,orden from GRUPOS where status ='A' order by orden"
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
    Public Function grabarGrupo(ByVal descripcion As String) As Boolean
        Try
            Dim objConexion As New Conexion
            Dim objComando As New SqlCommand
            objConexion.conectar(True)
            With objComando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "sp_insert_grupo"
                .Parameters.AddWithValue("@descripcion", descripcion)
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
    Public Function modificarGrupo(ByVal codigo As Integer, ByVal descripcion As String) As Boolean
        Try
            Dim objConexion As New Conexion
            Dim objComando As New SqlCommand
            objConexion.conectar(True)
            With objComando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "sp_update_grupo"
                .Parameters.AddWithValue("@codigo", codigo)
                .Parameters.AddWithValue("@descripcion", descripcion)
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
    Public Function eliminargrupo(ByVal codigo As Integer)
        Try
            Dim objConexion As New Conexion
            Dim objComando As New SqlCommand
            objConexion.conectar(True)
            With objComando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "sp_delete_grupo"
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
    Public Function upGrupo(ByVal codigo1 As Integer, ByVal codigo2 As Integer, _
    ByVal valor1 As Integer, ByVal valor2 As Integer) As Int16
        Dim valorretorna As Integer
        Try
            Dim objConexion As New Conexion
            Dim objComando As New SqlCommand
            objConexion.conectar(True)
            With objComando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "sp_update_ordenUp"
                .Parameters.AddWithValue("@codigo1", codigo1)
                .Parameters.AddWithValue("@codigo2", codigo2)
                .Parameters.AddWithValue("@valor1", valor1)
                .Parameters.AddWithValue("@valor2", valor2)
                .Connection = objConexion.conexion1
                valorretorna = .ExecuteNonQuery
                Return valorretorna
            End With
            objConexion.conectar(False)
            GC.ReRegisterForFinalize(objConexion)
            GC.ReRegisterForFinalize(objComando)
            GC.Collect()
        Catch ex As Exception
            Return 0
        End Try
    End Function
    Public Function countGrupo() As Integer
        Dim cantidad As Integer = 0
        Dim objcomando As New SqlCommand
        Dim drRecibe As SqlDataReader
        Try
            Dim objConexion As New Conexion
            Dim strSQL As String
            strSQL = "select count(*) from GRUPOS where status='A'"
            objConexion.conectar(True)
            With objcomando
                .CommandType = CommandType.Text
                .CommandText = strSQL
                .Connection = objConexion.conexion1
                drRecibe = .ExecuteReader
            End With
            If drRecibe.Read Then
                cantidad = drRecibe.Item(0)
            End If
            objConexion.conectar(False)
            GC.ReRegisterForFinalize(objConexion)
            GC.ReRegisterForFinalize(objcomando)
            GC.Collect()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
        Return cantidad
    End Function
    Public Function nombreGrupo(ByVal orden As Integer) As String
        Dim nombre As String = String.Empty
        Dim objcomando As New SqlCommand
        Dim drRecibe As SqlDataReader
        Try
            Dim objConexion As New Conexion
            Dim strSQL As String
            strSQL = "select descripcion from GRUPOS where status='A' and orden = " & orden & ""
            objConexion.conectar(True)
            With objcomando
                .CommandType = CommandType.Text
                .CommandText = strSQL
                .Connection = objConexion.conexion1
                drRecibe = .ExecuteReader
            End With
            If drRecibe.Read Then
                nombre = drRecibe.Item(0)
            Else
                nombre = "INACTIVO"
            End If
            objConexion.conectar(False)
            GC.ReRegisterForFinalize(objConexion)
            GC.ReRegisterForFinalize(objcomando)
            GC.Collect()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
        Return nombre
    End Function

End Class