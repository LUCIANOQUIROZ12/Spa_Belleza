Imports System.Data
Imports System.Data.SqlClient

Public Class ServicioNegocio
    Private ReadOnly conexionDB As New ConexionDB()

    ' Función para obtener el nombre del servicio por ID
    Public Function ObtenerNombreServicio(ByVal idServicio As Integer) As String
        Dim nombre As String = String.Empty
        Dim consulta As String = "SELECT NombreServicio FROM Servicios WHERE ServicioID = @IdServicio"

        Using conexion As SqlConnection = conexionDB.ObtenerConexion()
            Using comando As New SqlCommand(consulta, conexion)
                comando.Parameters.AddWithValue("@IdServicio", idServicio)

                conexion.Open()
                Dim resultado = comando.ExecuteScalar()
                If resultado IsNot Nothing Then
                    nombre = resultado.ToString()
                End If
            End Using
        End Using

        Return nombre
    End Function

    ' Función para obtener todos los servicios
    Public Function ObtenerServicios() As DataTable
        Dim dtServicios As New DataTable()
        Dim consulta As String = "SELECT ServicioID, NombreServicio, Costo FROM Servicios"

        Using conexion As SqlConnection = conexionDB.ObtenerConexion()
            Using comando As New SqlCommand(consulta, conexion)
                Using adaptador As New SqlDataAdapter(comando)
                    adaptador.Fill(dtServicios)
                End Using
            End Using
        End Using

        Return dtServicios
    End Function

    ' Método para insertar un servicio
    Public Sub InsertarServicio(servicio As Servicio)
        Dim consulta As String = "INSERT INTO Servicios (NombreServicio, Costo) " &
                                 "VALUES (@NombreServicio, @Costo)"
        Using conexion As SqlConnection = conexionDB.ObtenerConexion()
            Using comando As New SqlCommand(consulta, conexion)
                comando.Parameters.AddWithValue("@NombreServicio", servicio.NombreServicio)
                comando.Parameters.AddWithValue("@Costo", servicio.Costo)

                conexion.Open()
                comando.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    ' Método para actualizar un servicio existente
    Public Sub ActualizarServicio(servicio As Servicio)
        Dim consulta As String = "UPDATE Servicios SET NombreServicio = @NombreServicio, Costo = @Costo " &
                                 "WHERE ServicioID = @ServicioID"
        Using conexion As SqlConnection = conexionDB.ObtenerConexion()
            Using comando As New SqlCommand(consulta, conexion)
                comando.Parameters.AddWithValue("@ServicioID", servicio.ServicioID)
                comando.Parameters.AddWithValue("@NombreServicio", servicio.NombreServicio)
                comando.Parameters.AddWithValue("@Costo", servicio.Costo)

                conexion.Open()
                comando.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    ' Método para eliminar un servicio
    Public Sub EliminarServicio(idServicio As Integer)
        Dim consulta As String = "DELETE FROM Servicios WHERE ServicioID = @IdServicio"

        Using conexion As SqlConnection = conexionDB.ObtenerConexion()
            Using comando As New SqlCommand(consulta, conexion)
                comando.Parameters.AddWithValue("@IdServicio", idServicio)

                Try
                    conexion.Open()
                    comando.ExecuteNonQuery()
                Catch ex As Exception
                    ' Manejar excepciones si ocurren errores
                    MessageBox.Show("Ocurrió un error al eliminar el servicio: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub
End Class
