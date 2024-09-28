Imports System.Data
Imports System.Data.SqlClient

Public Class UsuarioData
    Private db As New ConexionDB()

    ' Función para obtener el nombre completo del usuario desde la base de datos
    Public Function ObtenerNombreUsuario(ByVal idUsuario As Integer) As String
        Dim consulta As String = "SELECT Nombres + ' ' + ApellidoPaterno + ' ' + ApellidoMaterno AS NombreCompleto " &
                                 "FROM Usuarios WHERE UsuarioID = @IdUsuario"

        Using conexion As SqlConnection = db.ObtenerConexion()
            Using comando As New SqlCommand(consulta, conexion)
                comando.Parameters.AddWithValue("@IdUsuario", idUsuario)
                conexion.Open()
                Dim nombreUsuario As Object = comando.ExecuteScalar()
                If nombreUsuario IsNot Nothing Then
                    Return nombreUsuario.ToString()
                End If
            End Using
        End Using
        Return String.Empty
    End Function

    ' Función para obtener los usuarios con su foto y rol para mostrarlos en el DataGridView
    Public Function ObtenerUsuarios() As DataTable
        Dim consulta As String = "SELECT U.UsuarioID, U.Nombres, U.ApellidoPaterno, U.ApellidoMaterno, U.Gmail, " &
                                 "U.DNI, U.Telefono, U.Estado, U.Usuario, U.Password, R.NombreRol AS Rol, U.Foto " &
                                 "FROM Usuarios U " &
                                 "INNER JOIN Roles R ON U.RolAsignado = R.RolID" ' Asegúrate de que RolAsignado está correctamente referenciado

        Dim dataTable As New DataTable()

        Using conexion As SqlConnection = db.ObtenerConexion()
            Using adapter As New SqlDataAdapter(consulta, conexion)
                conexion.Open()
                adapter.Fill(dataTable)
            End Using
        End Using

        Return dataTable
    End Function

End Class
