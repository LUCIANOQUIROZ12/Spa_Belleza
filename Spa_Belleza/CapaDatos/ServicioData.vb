Imports System.Data
Imports System.Data.SqlClient

Public Class ServicioData
    Private db As New ConexionDB()

    ' Obtener todos los servicios
    Public Function ObtenerServicios() As DataTable
        Dim dataTable As New DataTable()

        Using conexion As SqlConnection = db.ObtenerConexion()
            Using comando As New SqlCommand("ListarServicios", conexion)
                comando.CommandType = CommandType.StoredProcedure

                Using adapter As New SqlDataAdapter(comando)
                    conexion.Open()
                    adapter.Fill(dataTable)
                End Using
            End Using
        End Using

        Return dataTable
    End Function

    ' Insertar un nuevo servicio
    Public Sub InsertarServicio(servicio As Servicio)
        Using conexion As SqlConnection = db.ObtenerConexion()
            Using comando As New SqlCommand("InsertarServicio", conexion)
                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.AddWithValue("@NombreServicio", servicio.NombreServicio)
                comando.Parameters.AddWithValue("@Costo", servicio.Costo)

                conexion.Open()
                comando.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    ' Actualizar un servicio existente
    Public Sub ActualizarServicio(servicio As Servicio)
        Using conexion As SqlConnection = db.ObtenerConexion()
            Using comando As New SqlCommand("ActualizarServicio", conexion)
                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.AddWithValue("@ServicioID", servicio.ServicioID)
                comando.Parameters.AddWithValue("@NombreServicio", servicio.NombreServicio)
                comando.Parameters.AddWithValue("@Costo", servicio.Costo)

                conexion.Open()
                comando.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    ' Eliminar un servicio
    Public Sub EliminarServicio(servicioID As Integer)
        Using conexion As SqlConnection = db.ObtenerConexion()
            Using comando As New SqlCommand("EliminarServicio", conexion)
                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.AddWithValue("@ServicioID", servicioID)

                conexion.Open()
                comando.ExecuteNonQuery()
            End Using
        End Using
    End Sub
End Class
