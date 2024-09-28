Imports System.Data
Imports System.Data.SqlClient

Public Class UsuarioNegocio
    Private ReadOnly conexionDB As New ConexionDB()

    ' Función para obtener el nombre completo del usuario
    Public Function ObtenerNombreUsuario(ByVal idUsuario As Integer) As String
        Dim nombre As String = String.Empty
        Dim consulta As String = "SELECT Nombres + ' ' + ApellidoPaterno + ' ' + ApellidoMaterno AS NombreCompleto FROM Usuarios WHERE UsuarioID = @IdUsuario"

        Using conexion As SqlConnection = conexionDB.ObtenerConexion()
            Using comando As New SqlCommand(consulta, conexion)
                comando.Parameters.AddWithValue("@IdUsuario", idUsuario)

                conexion.Open()
                Dim resultado = comando.ExecuteScalar()
                If resultado IsNot Nothing Then
                    nombre = resultado.ToString()
                End If
            End Using
        End Using

        Return nombre
    End Function

    ' Función para obtener los nombres de roles
    Public Function ObtenerNombresRoles() As Dictionary(Of Integer, String)
        Dim rolNombres As New Dictionary(Of Integer, String)()
        Dim consulta As String = "SELECT RolID, NombreRol FROM Roles"

        Using conexion As SqlConnection = conexionDB.ObtenerConexion()
            Using comando As New SqlCommand(consulta, conexion)
                conexion.Open()
                Using lector As SqlDataReader = comando.ExecuteReader()
                    While lector.Read()
                        Dim rolID As Integer = Convert.ToInt32(lector("RolID"))
                        Dim rolNombre As String = lector("NombreRol").ToString()
                        rolNombres.Add(rolID, rolNombre)
                    End While
                End Using
            End Using
        End Using

        Return rolNombres
    End Function

    ' Función para obtener los usuarios con nombres de rol
    Public Function ObtenerUsuarios() As DataTable
        Dim dtUsuarios As New DataTable()
        Dim consulta As String = "SELECT UsuarioID, Nombres, ApellidoPaterno, ApellidoMaterno, Gmail, DNI, Telefono, Estado, Usuario, RolAsignado, Foto FROM Usuarios"

        Using conexion As SqlConnection = conexionDB.ObtenerConexion()
            Using comando As New SqlCommand(consulta, conexion)
                Using adaptador As New SqlDataAdapter(comando)
                    adaptador.Fill(dtUsuarios)
                End Using
            End Using
        End Using

        ' Crear un diccionario para los nombres de roles
        Dim rolNombres As Dictionary(Of Integer, String) = ObtenerNombresRoles()

        ' Crear una nueva columna para el nombre del rol
        dtUsuarios.Columns.Add("NombreRol", GetType(String))

        ' Rellenar la columna NombreRol con los nombres de los roles
        For Each fila As DataRow In dtUsuarios.Rows
            If fila("RolAsignado") IsNot DBNull.Value AndAlso IsNumeric(fila("RolAsignado")) Then
                Dim rolID As Integer = Convert.ToInt32(fila("RolAsignado"))
                If rolNombres.ContainsKey(rolID) Then
                    fila("NombreRol") = rolNombres(rolID)
                Else
                    fila("NombreRol") = "Desconocido"
                End If
            Else
                fila("NombreRol") = "No Asignado"
            End If
        Next

        ' Verificar si la columna RolAsignado existe antes de intentar eliminarla
        If dtUsuarios.Columns.Contains("RolAsignado") Then
            dtUsuarios.Columns.Remove("RolAsignado")
        End If

        Return dtUsuarios
    End Function

    ' Método para insertar un usuario
    Public Sub InsertarUsuario(usuario As Usuario)
        Dim consulta As String = "INSERT INTO Usuarios (Nombres, ApellidoPaterno, ApellidoMaterno, Gmail, DNI, Telefono, Estado, Usuario, Password, RolAsignado, Foto) " &
                                 "VALUES (@Nombres, @ApellidoPaterno, @ApellidoMaterno, @Gmail, @DNI, @Telefono, @Estado, @Usuario, @Password, @RolAsignado, @Foto)"
        Using conexion As SqlConnection = conexionDB.ObtenerConexion()
            Using comando As New SqlCommand(consulta, conexion)
                comando.Parameters.AddWithValue("@Nombres", usuario.Nombres)
                comando.Parameters.AddWithValue("@ApellidoPaterno", usuario.ApellidoPaterno)
                comando.Parameters.AddWithValue("@ApellidoMaterno", usuario.ApellidoMaterno)
                comando.Parameters.AddWithValue("@Gmail", usuario.Gmail)
                comando.Parameters.AddWithValue("@DNI", usuario.DNI)
                comando.Parameters.AddWithValue("@Telefono", usuario.Telefono)
                comando.Parameters.AddWithValue("@Estado", usuario.Estado)
                comando.Parameters.AddWithValue("@Usuario", usuario.Usuario)
                comando.Parameters.AddWithValue("@Password", usuario.Password)
                comando.Parameters.AddWithValue("@RolAsignado", usuario.RolAsignado) ' Esto debe ser un ID de rol (Integer)
                comando.Parameters.AddWithValue("@Foto", If(usuario.Foto IsNot Nothing, CType(usuario.Foto, Object), DBNull.Value))

                conexion.Open()
                comando.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    ' Método para actualizar un usuario
    Public Sub ActualizarUsuario(usuario As Usuario)
        Dim consulta As String = "UPDATE Usuarios SET Nombres = @Nombres, ApellidoPaterno = @ApellidoPaterno, ApellidoMaterno = @ApellidoMaterno, " &
                                 "Gmail = @Gmail, DNI = @DNI, Telefono = @Telefono, Estado = @Estado, Usuario = @Usuario, Password = @Password, " &
                                 "RolAsignado = @RolAsignado, Foto = @Foto WHERE UsuarioID = @UsuarioID"
        Using conexion As SqlConnection = conexionDB.ObtenerConexion()
            Using comando As New SqlCommand(consulta, conexion)
                comando.Parameters.AddWithValue("@UsuarioID", usuario.UsuarioID)
                comando.Parameters.AddWithValue("@Nombres", usuario.Nombres)
                comando.Parameters.AddWithValue("@ApellidoPaterno", usuario.ApellidoPaterno)
                comando.Parameters.AddWithValue("@ApellidoMaterno", usuario.ApellidoMaterno)
                comando.Parameters.AddWithValue("@Gmail", usuario.Gmail)
                comando.Parameters.AddWithValue("@DNI", usuario.DNI)
                comando.Parameters.AddWithValue("@Telefono", usuario.Telefono)
                comando.Parameters.AddWithValue("@Estado", usuario.Estado)
                comando.Parameters.AddWithValue("@Usuario", usuario.Usuario)
                comando.Parameters.AddWithValue("@Password", usuario.Password)
                comando.Parameters.AddWithValue("@RolAsignado", usuario.RolAsignado) ' Esto debe ser un ID de rol (Integer)
                comando.Parameters.AddWithValue("@Foto", If(usuario.Foto IsNot Nothing, CType(usuario.Foto, Object), DBNull.Value))

                conexion.Open()
                comando.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    ' Método para eliminar un usuario
    Public Sub EliminarUsuario(idUsuario As Integer)
        Dim consulta As String = "DELETE FROM Usuarios WHERE UsuarioID = @IdUsuario"

        Using conexion As SqlConnection = conexionDB.ObtenerConexion()
            Using comando As New SqlCommand(consulta, conexion)
                comando.Parameters.AddWithValue("@IdUsuario", idUsuario)

                Try
                    conexion.Open()
                    comando.ExecuteNonQuery()
                Catch ex As Exception
                    ' Manejar excepciones si ocurren errores
                    MessageBox.Show("Ocurrió un error al eliminar el usuario: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub
End Class
