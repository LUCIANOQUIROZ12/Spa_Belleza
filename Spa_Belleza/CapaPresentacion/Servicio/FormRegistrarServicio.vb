Imports System.Data.SqlClient

Public Class FormRegistrarServicio
    Private cadenaConexion As String = "Data Source=DESKTOP-ON05S9T;Initial Catalog=spabelleza;Integrated Security=True"
    Private servicioID As Integer
    Private modoEdicion As Boolean = False

    ' Constructor para registrar nuevos servicios
    Public Sub New()
        InitializeComponent()
    End Sub

    ' Constructor para editar servicios existentes
    Public Sub New(servicioID As Integer)
        InitializeComponent()
        Me.servicioID = servicioID
        modoEdicion = True
    End Sub

    Private Sub FormRegistrarServicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Si estás en modo edición, llena los campos con los datos del servicio seleccionado
        If modoEdicion Then
            CargarServicio(servicioID)
        End If

        ' Configura TxtIdServicio como solo lectura
        TxtIdServicio.ReadOnly = True
    End Sub

    Private Sub CargarServicio(servicioID As Integer)
        Dim servicio As Servicio = ObtenerServicioPorId(servicioID)

        ' Llena los campos con los datos del servicio
        If servicio IsNot Nothing Then
            TxtIdServicio.Text = servicio.ServicioID.ToString()
            TxtNombreServicio.Text = servicio.NombreServicio
            TxtCosto.Text = servicio.Costo.ToString()
        End If
    End Sub

    Private Function ObtenerServicioPorId(servicioID As Integer) As Servicio
        Dim consulta As String = "SELECT ServicioID, NombreServicio, Costo FROM Servicios WHERE ServicioID = @IdServicio"
        Dim servicio As Servicio = Nothing

        Using conexion As New SqlConnection(cadenaConexion)
            Using comando As New SqlCommand(consulta, conexion)
                comando.Parameters.AddWithValue("@IdServicio", servicioID)
                conexion.Open()
                Using lector As SqlDataReader = comando.ExecuteReader()
                    If lector.Read() Then
                        servicio = New Servicio With {
                            .ServicioID = CInt(lector("ServicioID")),
                            .NombreServicio = lector("NombreServicio").ToString(),
                            .Costo = Convert.ToDecimal(lector("Costo"))
                        }
                    End If
                End Using
            End Using
        End Using

        Return servicio
    End Function

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If ValidarCampos() Then
            Dim servicio As New Servicio With {
                .ServicioID = If(modoEdicion, CInt(TxtIdServicio.Text), 0),
                .NombreServicio = TxtNombreServicio.Text,
                .Costo = Convert.ToDecimal(TxtCosto.Text)
            }

            Try
                If modoEdicion Then
                    ' Actualizar servicio existente
                    ActualizarServicio(servicio)
                Else
                    ' Registrar nuevo servicio
                    InsertarServicio(servicio)
                End If

                MessageBox.Show("Servicio guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            Catch ex As Exception
                MessageBox.Show("Ocurrió un error al guardar el servicio: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub InsertarServicio(servicio As Servicio)
        Dim consulta As String = "INSERT INTO Servicios (NombreServicio, Costo) " &
                                 "VALUES (@NombreServicio, @Costo)"
        Using conexion As New SqlConnection(cadenaConexion)
            Using comando As New SqlCommand(consulta, conexion)
                comando.Parameters.AddWithValue("@NombreServicio", servicio.NombreServicio)
                comando.Parameters.AddWithValue("@Costo", servicio.Costo)

                conexion.Open()
                comando.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Private Sub ActualizarServicio(servicio As Servicio)
        Dim consulta As String = "UPDATE Servicios SET NombreServicio = @NombreServicio, Costo = @Costo WHERE ServicioID = @ServicioID"
        Using conexion As New SqlConnection(cadenaConexion)
            Using comando As New SqlCommand(consulta, conexion)
                comando.Parameters.AddWithValue("@NombreServicio", servicio.NombreServicio)
                comando.Parameters.AddWithValue("@Costo", servicio.Costo)
                comando.Parameters.AddWithValue("@ServicioID", servicio.ServicioID)

                conexion.Open()
                comando.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Private Function ValidarCampos() As Boolean
        ' Asegúrate de que todos los campos necesarios estén completos
        If String.IsNullOrWhiteSpace(TxtNombreServicio.Text) OrElse
           String.IsNullOrWhiteSpace(TxtCosto.Text) Then

            MessageBox.Show("Por favor complete todos los campos.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        ' Validar que el costo sea un valor numérico
        Dim costoValido As Decimal
        If Not Decimal.TryParse(TxtCosto.Text, costoValido) Then
            MessageBox.Show("Por favor ingrese un valor numérico válido para el costo.", "Campos inválidos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        Return True
    End Function

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub
End Class
