Imports System.Data.SqlClient
Public Class clsventa
    Public Sub New()

    End Sub

    Public Function grabarSubTipo(ByVal tipo As Integer, ByVal descripcion As String, ByVal abreviatura As String, _
   ByVal costo As Double, ByVal pvp As Double) As Boolean
        Try
            Dim objConexion As New Conexion
            Dim objComando As New SqlCommand
            objConexion.conectar(True)
            With objComando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "sp_insert_venta"
                '.Parameters.AddWithValue("@tarjeta", tarjeta)
                '.Parameters.AddWithValue("@subTotal", subTotal)
                '.Parameters.AddWithValue("@impuestos", impuestos)
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
End Class
