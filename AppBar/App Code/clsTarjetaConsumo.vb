Imports System.Data.SqlClient
Public Class clsTarjetaConsumo
    Public Sub New()

    End Sub
    Public Function consClientePorTarjeta(ByVal numeroTarjeta As Integer) As String
        Dim valorRetorna As String = String.Empty
        Try
            Dim objConexion As New Conexion
            Dim objComando As New SqlCommand
            Dim dataReaderCliente As SqlDataReader
            objConexion.conectar(True)
            With objComando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "sp_cons_nombreCliente"
                .Parameters.AddWithValue("@codigo", numeroTarjeta)
                .Connection = objConexion.conexion1
                dataReaderCliente = .ExecuteReader
            End With
            If dataReaderCliente.Read Then
                valorRetorna = dataReaderCliente.Item(0).ToString
            End If
            dataReaderCliente.Close()
            objConexion.conectar(False)
            GC.ReRegisterForFinalize(objConexion)
            GC.ReRegisterForFinalize(objComando)
            GC.ReRegisterForFinalize(dataReaderCliente)
            GC.Collect()
        Catch ex As Exception
            Return valorRetorna
        End Try
        Return valorRetorna
    End Function

    Public Function grabaInfoCliente(ByVal nombre As String, ByVal fecha As DateTime, _
    ByVal hombres As Integer, ByVal mujeres As Integer, ByVal idFormaPago As Integer, _
    ByVal valor As Double) As Int16
        Dim valorRetorna As Int16 = 0
        Try
            Dim objConexion As New Conexion
            Dim objComando As New SqlCommand
            objConexion.conectar(True)
            With objComando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "sp_insert_infoCliente"
                .Parameters.AddWithValue("@nombre", nombre)
                .Parameters.AddWithValue("@fecha", fecha)
                .Parameters.AddWithValue("@hombres", hombres)
                .Parameters.AddWithValue("@mujeres", mujeres)
                .Parameters.AddWithValue("@idFormaPago", idFormaPago)
                .Parameters.AddWithValue("@valor", valor)
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
    Public Function obtenerNumTarjeta()
        Dim NumeroTarjeta As Integer = 0
        Try
            Dim objConexion As New Conexion
            Dim objComando As New SqlCommand
            objConexion.conectar(True)
            With objComando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "sp_obtener_numTarjeta"
                .Parameters.AddWithValue("@numeroRetorna", NumeroTarjeta).Direction = ParameterDirection.Output
                .Connection = objConexion.conexion1
                .ExecuteNonQuery()
                NumeroTarjeta = .Parameters.Item(0).Value
            End With
            objConexion.conectar(False)
            GC.ReRegisterForFinalize(objConexion)
            GC.ReRegisterForFinalize(objComando)
            GC.Collect()
        Catch ex As Exception
            Return NumeroTarjeta
        End Try
        Return NumeroTarjeta
    End Function
End Class
