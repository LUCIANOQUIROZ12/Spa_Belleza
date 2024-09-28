Imports System.Data.SqlClient

Public Class FrmLogin

    Private conexion As SqlConnection

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Conexión a la base de datos
        conexion = New SqlConnection("server=DESKTOP-ON05S9T; database=spabelleza; integrated security=true")

        ' Configura el panel para que tenga un color negro transparente
        PanelLogin.BackColor = Color.FromArgb(128, 0, 0, 0) ' Negro transparente con 50% de opacidad
    End Sub

    Private Sub IngresarLogin_Click(sender As Object, e As EventArgs) Handles IngresarLogin.Click
        ' Validar que los campos de usuario y contraseña no estén vacíos
        If String.IsNullOrWhiteSpace(txtUsuario.Text) OrElse String.IsNullOrWhiteSpace(txtPassword.Text) Then
            MessageBox.Show("Por favor, ingresa el usuario y la contraseña.")
            Exit Sub
        End If

        ' Comprobar las credenciales
        Dim usuario As String = txtUsuario.Text
        Dim password As String = txtPassword.Text

        ' Conexión y consulta en bloque Using para liberar recursos automáticamente
        Using conexion As New SqlConnection("server=DESKTOP-ON05S9T; database=spabelleza; integrated security=true")
            Try
                ' Abrir la conexión
                conexion.Open()

                ' Consulta SQL adaptada para verificar usuario, contraseña y estado, y obtener el rol del usuario
                Dim query As String = "SELECT u.Usuario, r.NombreRol, u.Estado " &
                                      "FROM Usuarios u " &
                                      "INNER JOIN Roles r ON u.RolAsignado = r.RolID " &
                                      "WHERE u.Usuario=@usuario AND u.Password=@password AND u.Estado='Activo'"
                Using command As New SqlCommand(query, conexion)
                    ' Parametrizar los valores
                    command.Parameters.AddWithValue("@usuario", usuario)
                    command.Parameters.AddWithValue("@password", password)

                    ' Ejecutar la consulta
                    Using reader As SqlDataReader = command.ExecuteReader()
                        If reader.Read() Then
                            ' Usuario autenticado correctamente
                            Dim nombre_rol As String = reader("NombreRol").ToString()
                            MessageBox.Show("Bienvenido, " & usuario & ". Tu rol es: " & nombre_rol)

                            ' Abrir formulario principal
                            Dim formUsuarios As New FormUsuarios()
                            formUsuarios.Show()

                            ' Ocultar el formulario de login
                            Me.Hide()
                        Else
                            ' Credenciales incorrectas o usuario inactivo
                            MessageBox.Show("Usuario o contraseña incorrectos, o el usuario está inactivo.")
                        End If
                    End Using
                End Using

            Catch ex As Exception
                MessageBox.Show("Error al intentar conectarse a la base de datos: " & ex.Message)
            End Try
        End Using
    End Sub


    ' Este método detecta la tecla Enter
    Private Sub txtUsuario_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUsuario.KeyDown, txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' Si se presiona Enter, llama al método para iniciar sesión
            IngresarLogin.PerformClick()
        End If
    End Sub
    Private Sub PanelLogin_Paint(sender As Object, e As PaintEventArgs) Handles PanelLogin.Paint
        ' Crear las esquinas redondeadas para el panel
        Dim graphics As Graphics = e.Graphics
        Dim rect As New Rectangle(0, 0, PanelLogin.Width, PanelLogin.Height)
        Dim radius As Integer = 20 ' Radio de las esquinas redondeadas

        ' Crear la ruta gráfica para las esquinas redondeadas
        Dim path As New Drawing2D.GraphicsPath()
        path.AddArc(rect.X, rect.Y, radius, radius, 180, 90)
        path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90)
        path.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90)
        path.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90)
        path.CloseFigure()

        ' Aplicar el borde redondeado al panel
        PanelLogin.Region = New Region(path)
    End Sub
End Class
