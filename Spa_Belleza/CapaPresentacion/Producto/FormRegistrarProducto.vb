Imports System.Data.SqlClient
Imports System.IO

Public Class FormRegistrarProducto
    Private cadenaConexion As String = "Data Source=DESKTOP-ON05S9T;Initial Catalog=spabelleza;Integrated Security=True"
    Private productoID As Integer
    Private modoEdicion As Boolean = False

    ' Constructor para registrar nuevos productos
    Public Sub New()
        InitializeComponent()
    End Sub

    ' Constructor para editar productos existentes
    Public Sub New(productoID As Integer)
        InitializeComponent()
        Me.productoID = productoID
        modoEdicion = True
    End Sub

    Private Sub FormRegistrarProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Configura el PictureBox para ajustar la imagen al tamaño del control
        PictureFoto.SizeMode = PictureBoxSizeMode.StretchImage

        ' Si estás en modo edición, llena los campos con los datos del producto seleccionado
        If modoEdicion Then
            CargarProducto(productoID)
        End If

        ' Configura TxtIdProducto como solo lectura
        TxtIdProducto.ReadOnly = True
    End Sub

    Private Sub CargarProducto(productoID As Integer)
        Dim producto As Producto = ObtenerProductoPorId(productoID)

        ' Llena los campos con los datos del producto
        If producto IsNot Nothing Then
            TxtIdProducto.Text = producto.ProductoID.ToString()
            TxtNombreProducto.Text = producto.NombreProducto
            TxtDescripcion.Text = producto.Descripcion
            TxtStock.Text = producto.Stock.ToString()
            TxtPrecio.Text = producto.Precio.ToString()

            ' Cargar la foto si existe
            If producto.Foto IsNot Nothing Then
                Using ms As New MemoryStream(producto.Foto)

                End Using
            End If
        End If
    End Sub

    Private Function ObtenerProductoPorId(productoID As Integer) As Producto
        Dim consulta As String = "SELECT ProductoID, NombreProducto, Descripcion, Stock, Precio, Foto FROM Productos WHERE ProductoID = @IdProducto"
        Dim producto As Producto = Nothing

        Using conexion As New SqlConnection(cadenaConexion)
            Using comando As New SqlCommand(consulta, conexion)
                comando.Parameters.AddWithValue("@IdProducto", productoID)
                conexion.Open()
                Using lector As SqlDataReader = comando.ExecuteReader()
                    If lector.Read() Then
                        producto = New Producto With {
                            .ProductoID = CInt(lector("ProductoID")),
                            .NombreProducto = lector("NombreProducto").ToString(),
                            .Descripcion = lector("Descripcion").ToString(),
                            .Stock = CInt(lector("Stock")),
                            .Precio = Convert.ToDecimal(lector("Precio")),
                            .Foto = If(lector("Foto") IsNot DBNull.Value, CType(lector("Foto"), Byte()), Nothing)
                        }
                    End If
                End Using
            End Using
        End Using

        Return producto
    End Function

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If ValidarCampos() Then
            Dim producto As New Producto With {
                .ProductoID = If(modoEdicion, CInt(TxtIdProducto.Text), 0),
                .NombreProducto = TxtNombreProducto.Text,
                .Descripcion = TxtDescripcion.Text,
                .Stock = CInt(TxtStock.Text),
                .Precio = Convert.ToDecimal(TxtPrecio.Text),
                .Foto = If(PictureFoto.Image IsNot Nothing, ConvertImageToByteArray(PictureFoto.Image), Nothing)
            }

            Try
                If modoEdicion Then
                    ' Actualizar producto existente
                    ActualizarProducto(producto)
                Else
                    ' Registrar nuevo producto
                    InsertarProducto(producto)
                End If

                MessageBox.Show("Producto guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            Catch ex As Exception
                MessageBox.Show("Ocurrió un error al guardar el producto: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub InsertarProducto(producto As Producto)
        Dim consulta As String = "INSERT INTO Productos (NombreProducto, Descripcion, Stock, Precio, Foto) " &
                                 "VALUES (@NombreProducto, @Descripcion, @Stock, @Precio, @Foto)"
        Using conexion As New SqlConnection(cadenaConexion)
            Using comando As New SqlCommand(consulta, conexion)
                comando.Parameters.AddWithValue("@NombreProducto", producto.NombreProducto)
                comando.Parameters.AddWithValue("@Descripcion", producto.Descripcion)
                comando.Parameters.AddWithValue("@Stock", producto.Stock)
                comando.Parameters.AddWithValue("@Precio", producto.Precio)
                comando.Parameters.AddWithValue("@Foto", If(producto.Foto IsNot Nothing, CType(producto.Foto, Object), DBNull.Value))

                conexion.Open()
                comando.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Private Sub ActualizarProducto(producto As Producto)
        Dim consulta As String = "UPDATE Productos SET NombreProducto = @NombreProducto, Descripcion = @Descripcion, " &
                                 "Stock = @Stock, Precio = @Precio, Foto = @Foto WHERE ProductoID = @ProductoID"
        Using conexion As New SqlConnection(cadenaConexion)
            Using comando As New SqlCommand(consulta, conexion)
                comando.Parameters.AddWithValue("@NombreProducto", producto.NombreProducto)
                comando.Parameters.AddWithValue("@Descripcion", producto.Descripcion)
                comando.Parameters.AddWithValue("@Stock", producto.Stock)
                comando.Parameters.AddWithValue("@Precio", producto.Precio)
                comando.Parameters.AddWithValue("@Foto", If(producto.Foto IsNot Nothing, CType(producto.Foto, Object), DBNull.Value))
                comando.Parameters.AddWithValue("@ProductoID", producto.ProductoID)

                conexion.Open()
                comando.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Private Function ValidarCampos() As Boolean
        ' Asegúrate de que todos los campos necesarios estén completos
        If String.IsNullOrWhiteSpace(TxtNombreProducto.Text) OrElse
           String.IsNullOrWhiteSpace(TxtDescripcion.Text) OrElse
           String.IsNullOrWhiteSpace(TxtStock.Text) OrElse
           String.IsNullOrWhiteSpace(TxtPrecio.Text) Then

            MessageBox.Show("Por favor complete todos los campos.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        ' Validar que Stock y Precio sean valores numéricos
        Dim stockValido As Integer
        Dim precioValido As Decimal
        If Not Integer.TryParse(TxtStock.Text, stockValido) OrElse Not Decimal.TryParse(TxtPrecio.Text, precioValido) Then
            MessageBox.Show("Por favor ingrese valores numéricos válidos para Stock y Precio.", "Campos inválidos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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

End Class
