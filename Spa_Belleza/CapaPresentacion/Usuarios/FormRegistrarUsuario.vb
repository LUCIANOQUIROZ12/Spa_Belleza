Imports System.Data.SqlClient
Imports System.IO

Public Class FormRegistrarUsuario
    Private cadenaConexion As String = "Data Source=DESKTOP-ON05S9T;Initial Catalog=spabelleza;Integrated Security=True"
    Private usuarioID As Integer
    Private modoEdicion As Boolean = False

    ' Constructor para registrar nuevos usuarios
    Public Sub New()
        InitializeComponent()
    End Sub

    ' Constructor para editar usuarios existentes
    Public Sub New(usuarioID As Integer)
        InitializeComponent()
        Me.usuarioID = usuarioID
        modoEdicion = True
    End Sub

    Private Sub FormRegistrarUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Configura el PictureBox para ajustar la imagen al tamaño del control
        PictureFoto.SizeMode = PictureBoxSizeMode.StretchImage

        CargarRoles()

        ' Si estás en modo edición, llena los campos con los datos del usuario seleccionado
        If modoEdicion Then
            CargarUsuario(usuarioID)
        End If

        ' Configura TxtIdUsuario como solo lectura
        TxtIdUsuario.ReadOnly = True
    End Sub

    Private Sub CargarRoles()
        ' Limpia los elementos del ComboBox antes de añadir nuevos
        CboRol.Items.Clear()

        Dim consulta As String = "SELECT RolID, NombreRol FROM Roles"

        Using conexion As New SqlConnection(cadenaConexion)
            Using comando As New SqlCommand(consulta, conexion)
                conexion.Open()
                Using lector As SqlDataReader = comando.ExecuteReader()
                    While lector.Read()
                        ' Crear un nuevo objeto KeyValuePair para agregar al ComboBox
                        Dim rolID As Integer = CInt(lector("RolID"))
                        Dim nombreRol As String = lector("NombreRol").ToString()
                        CboRol.Items.Add(New KeyValuePair(Of Integer, String)(rolID, nombreRol))
                    End While
                End Using
            End Using
        End Using

        ' Configura el ComboBox para mostrar el nombre del rol
        CboRol.DisplayMember = "Value"
        CboRol.ValueMember = "Key"
    End Sub

    Private Sub CargarUsuario(usuarioID As Integer)
        Dim usuario As Usuario = ObtenerUsuarioPorId(usuarioID)

        ' Llena los campos con los datos del usuario
        If usuario IsNot Nothing Then
            TxtIdUsuario.Text = usuario.UsuarioID.ToString()
            TxtNombres.Text = usuario.Nombres
            TxtApellidoPaterno.Text = usuario.ApellidoPaterno
            TxtApellidoMaterno.Text = usuario.ApellidoMaterno
            TxtGmail.Text = usuario.Gmail
            TxtDNI.Text = usuario.DNI
            TxtTelefono.Text = usuario.Telefono
            TxtEstado.Text = usuario.Estado
            TxtUsuario.Text = usuario.Usuario
            TxtPassword.Text = usuario.Password

            ' Selecciona el rol correspondiente en el ComboBox
            For i As Integer = 0 To CboRol.Items.Count - 1
                Dim item = DirectCast(CboRol.Items(i), KeyValuePair(Of Integer, String))
                If item.Key = usuario.RolAsignado Then
                    CboRol.SelectedIndex = i
                    Exit For
                End If
            Next

            ' Cargar la foto si existe
            If usuario.Foto IsNot Nothing Then
                Using ms As New MemoryStream(usuario.Foto)
                    PictureFoto.Image = Image.FromStream(ms)
                End Using
            End If
        End If
    End Sub

    Private Function ObtenerUsuarioPorId(usuarioID As Integer) As Usuario
        Dim consulta As String = "SELECT UsuarioID, Nombres, ApellidoPaterno, ApellidoMaterno, Gmail, DNI, Telefono, Estado, Usuario, Password, RolAsignado, Foto FROM Usuarios WHERE UsuarioID = @IdUsuario"
        Dim usuario As Usuario = Nothing

        Using conexion As New SqlConnection(cadenaConexion)
            Using comando As New SqlCommand(consulta, conexion)
                comando.Parameters.AddWithValue("@IdUsuario", usuarioID)
                conexion.Open()
                Using lector As SqlDataReader = comando.ExecuteReader()
                    If lector.Read() Then
                        usuario = New Usuario With {
                            .UsuarioID = CInt(lector("UsuarioID")),
                            .Nombres = lector("Nombres").ToString(),
                            .ApellidoPaterno = lector("ApellidoPaterno").ToString(),
                            .ApellidoMaterno = lector("ApellidoMaterno").ToString(),
                            .Gmail = lector("Gmail").ToString(),
                            .DNI = lector("DNI").ToString(),
                            .Telefono = lector("Telefono").ToString(),
                            .Estado = lector("Estado").ToString(),
                            .Usuario = lector("Usuario").ToString(),
                            .Password = lector("Password").ToString(),
                            .RolAsignado = CInt(lector("RolAsignado")),
                            .Foto = If(lector("Foto") IsNot DBNull.Value, CType(lector("Foto"), Byte()), Nothing)
                        }
                    End If
                End Using
            End Using
        End Using

        Return usuario
    End Function

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If ValidarCampos() Then
            Dim usuario As New Usuario With {
                .UsuarioID = If(modoEdicion, CInt(TxtIdUsuario.Text), 0),
                .Nombres = TxtNombres.Text,
                .ApellidoPaterno = TxtApellidoPaterno.Text,
                .ApellidoMaterno = TxtApellidoMaterno.Text,
                .Gmail = TxtGmail.Text,
                .DNI = TxtDNI.Text,
                .Telefono = TxtTelefono.Text,
                .Estado = TxtEstado.Text,
                .Usuario = TxtUsuario.Text,
                .Password = TxtPassword.Text,
                .RolAsignado = CType(CboRol.SelectedItem, KeyValuePair(Of Integer, String)).Key,
                .Foto = If(PictureFoto.Image IsNot Nothing, ConvertImageToByteArray(PictureFoto.Image), Nothing)
            }

            Try
                If modoEdicion Then
                    ' Actualizar usuario existente
                    ActualizarUsuario(usuario)
                Else
                    ' Registrar nuevo usuario
                    InsertarUsuario(usuario)
                End If

                MessageBox.Show("Usuario guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            Catch ex As Exception
                MessageBox.Show("Ocurrió un error al guardar el usuario: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub InsertarUsuario(usuario As Usuario)
        Dim consulta As String = "INSERT INTO Usuarios (Nombres, ApellidoPaterno, ApellidoMaterno, Gmail, DNI, Telefono, Estado, Usuario, Password, RolAsignado, Foto) " &
                                 "VALUES (@Nombres, @ApellidoPaterno, @ApellidoMaterno, @Gmail, @DNI, @Telefono, @Estado, @Usuario, @Password, @RolAsignado, @Foto)"
        Using conexion As New SqlConnection(cadenaConexion)
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
                comando.Parameters.AddWithValue("@RolAsignado", usuario.RolAsignado)
                comando.Parameters.AddWithValue("@Foto", If(usuario.Foto IsNot Nothing, CType(usuario.Foto, Object), DBNull.Value))

                conexion.Open()
                comando.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Private Sub ActualizarUsuario(usuario As Usuario)
        Dim consulta As String = "UPDATE Usuarios SET Nombres = @Nombres, ApellidoPaterno = @ApellidoPaterno, ApellidoMaterno = @ApellidoMaterno, " &
                                 "Gmail = @Gmail, DNI = @DNI, Telefono = @Telefono, Estado = @Estado, Usuario = @Usuario, Password = @Password, " &
                                 "RolAsignado = @RolAsignado, Foto = @Foto WHERE UsuarioID = @UsuarioID"
        Using conexion As New SqlConnection(cadenaConexion)
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
                comando.Parameters.AddWithValue("@RolAsignado", usuario.RolAsignado)
                comando.Parameters.AddWithValue("@Foto", If(usuario.Foto IsNot Nothing, CType(usuario.Foto, Object), DBNull.Value))
                comando.Parameters.AddWithValue("@UsuarioID", usuario.UsuarioID)

                conexion.Open()
                comando.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Private Function ValidarCampos() As Boolean
        ' Asegúrate de que todos los campos necesarios estén completos
        If String.IsNullOrWhiteSpace(TxtNombres.Text) OrElse
           String.IsNullOrWhiteSpace(TxtApellidoPaterno.Text) OrElse
           String.IsNullOrWhiteSpace(TxtApellidoMaterno.Text) OrElse
           String.IsNullOrWhiteSpace(TxtGmail.Text) OrElse
           String.IsNullOrWhiteSpace(TxtDNI.Text) OrElse
           String.IsNullOrWhiteSpace(TxtTelefono.Text) OrElse
           String.IsNullOrWhiteSpace(TxtEstado.Text) OrElse
           String.IsNullOrWhiteSpace(TxtUsuario.Text) OrElse
           String.IsNullOrWhiteSpace(TxtPassword.Text) Then

            MessageBox.Show("Por favor complete todos los campos.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        Return True
    End Function

    Private Function ConvertImageToByteArray(image As Image) As Byte()
        Using ms As New MemoryStream()
            image.Save(ms, image.RawFormat)
            Return ms.ToArray()
        End Using
    End Function

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub

    Private Sub BtnSeleccionarFoto_Click(sender As Object, e As EventArgs) Handles BtnSeleccionarFoto.Click
        Using openFileDialog As New OpenFileDialog()
            openFileDialog.Filter = "Imagenes|*.jpg;*.jpeg;*.png"
            If openFileDialog.ShowDialog() = DialogResult.OK Then
                PictureFoto.Image = Image.FromFile(openFileDialog.FileName)
            End If
        End Using
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub
End Class
