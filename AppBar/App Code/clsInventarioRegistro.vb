Imports System.Data.SqlClient
Public Class clsInventarioRegistro
    Public Sub New()

    End Sub

    Public Function consInventarioRegistro(ByVal inventario As Integer) As DataTable
        Dim dataSetRetorna As New DataTable
        Try
            Dim objConexion As New Conexion
            Dim strSQL As String
            strSQL = "sp_cons_inventarioIngreso_BySel"
            objConexion.conectar(True)
            Dim objDataAdapter As New SqlDataAdapter(strSQL, objConexion.conexion1)
            With objDataAdapter.SelectCommand
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@inventario", inventario)
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

    Public Function grabarRegistroInventario(ByVal inventario As Integer, _
    ByVal cantidad As String, ByVal fecha As DateTime) As Int16
        Dim valRetorna As Int16 = 0
        Try
            Dim objConexion As New Conexion
            Dim objComando As New SqlCommand
            objConexion.conectar(True)
            With objComando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "sp_insert_RegInventario"
                .Parameters.AddWithValue("@inventario", inventario)
                .Parameters.AddWithValue("@cantidad", cantidad)
                .Parameters.AddWithValue("@fecha", fecha)
                .Connection = objConexion.conexion1
                valRetorna = .ExecuteNonQuery
            End With
            objConexion.conectar(False)
            GC.ReRegisterForFinalize(objConexion)
            GC.ReRegisterForFinalize(objComando)
            GC.Collect()
        Catch ex As Exception
            Return valRetorna
        End Try
        Return valRetorna
    End Function
End Class
