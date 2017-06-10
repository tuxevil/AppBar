Imports System.Data.SqlClient
Public Class clsReceta
    Public Sub New()
    End Sub

    Public Function consReceta(ByVal clase As Integer, ByVal tipo As Integer, ByVal subTipo As Integer) As DataTable
        Dim dataSetRetorna As New DataTable
        Try
            Dim objConexion As New Conexion
            Dim strSQL As String
            strSQL = "sp_cons_receta_BySel"
            objConexion.conectar(True)
            Dim objDataAdapter As New SqlDataAdapter(strSQL, objConexion.conexion1)
            With objDataAdapter.SelectCommand
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@clase", clase)
                .Parameters.AddWithValue("@tipo", tipo)
                .Parameters.AddWithValue("@subTipo", subTipo)
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

    Public Function grabarReceta(ByVal clase As Integer, ByVal tipo As Integer, ByVal subTipo As Integer, _
    ByVal inventario As Integer, ByVal cantidad As Double) As Boolean
        Try
            Dim objConexion As New Conexion
            Dim objComando As New SqlCommand
            objConexion.conectar(True)
            With objComando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "sp_insert_receta"
                .Parameters.AddWithValue("@clase", clase)
                .Parameters.AddWithValue("@tipo", tipo)
                .Parameters.AddWithValue("@subTipo", subTipo)
                .Parameters.AddWithValue("@inventario", inventario)
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

    Public Function modificarReceta(ByVal codigo As Integer, ByVal cantidad As Double) As Boolean
        Try
            Dim objConexion As New Conexion
            Dim objComando As New SqlCommand
            objConexion.conectar(True)
            With objComando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "sp_update_receta"
                .Parameters.AddWithValue("@codigo", codigo)
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

    Public Function eliminarReceta(ByVal codigo As Integer)
        Try
            Dim objConexion As New Conexion
            Dim objComando As New SqlCommand
            objConexion.conectar(True)
            With objComando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "sp_delete_receta"
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