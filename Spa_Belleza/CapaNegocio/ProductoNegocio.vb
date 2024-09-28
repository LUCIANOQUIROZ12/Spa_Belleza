Imports System.Data
Imports System.Data.SqlClient

Public Class ProductoNegocio
    Private ReadOnly conexionDB As New ConexionDB()

    ' Función para obtener el nombre del producto
    Public Function ObtenerNombreProducto(ByVal idProducto As Integer) As String
        Dim nombre As String = String.Empty
        Dim consulta As String = "SELECT NombreProducto FROM Productos WHERE ProductoID = @IdProducto"

        Using conexion As SqlConnection = conexionDB.ObtenerConexion()
            Using comando As New SqlCommand(consulta, conexion)
                comando.Parameters.AddWithValue("@IdProducto", idProducto)

                conexion.Open()
                Dim resultado = comando.ExecuteScalar()
                If resultado IsNot Nothing Then
                    nombre = resultado.ToString()
                End If
            End Using
        End Using

        Return nombre
    End Function

    ' Función para obtener los productos
    Public Function ObtenerProductos() As DataTable
        Dim dtProductos As New DataTable()
        Dim consulta As String = "SELECT ProductoID, NombreProducto, Descripcion, Stock, Precio, Foto FROM Productos"

        Using conexion As SqlConnection = conexionDB.ObtenerConexion()
            Using comando As New SqlCommand(consulta, conexion)
                Using adaptador As New SqlDataAdapter(comando)
                    adaptador.Fill(dtProductos)
                End Using
            End Using
        End Using

        Return dtProductos
    End Function

    ' Método para insertar un producto
    Public Sub InsertarProducto(producto As Producto)
        Dim consulta As String = "INSERT INTO Productos (NombreProducto, Descripcion, Stock, Precio, Foto) " &
                                 "VALUES (@NombreProducto, @Descripcion, @Stock, @Precio, @Foto)"
        Using conexion As SqlConnection = conexionDB.ObtenerConexion()
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

    ' Método para actualizar un producto
    Public Sub ActualizarProducto(producto As Producto)
        Dim consulta As String = "UPDATE Productos SET NombreProducto = @NombreProducto, Descripcion = @Descripcion, " &
                                 "Stock = @Stock, Precio = @Precio, Foto = @Foto WHERE ProductoID = @ProductoID"
        Using conexion As SqlConnection = conexionDB.ObtenerConexion()
            Using comando As New SqlCommand(consulta, conexion)
                comando.Parameters.AddWithValue("@ProductoID", producto.ProductoID)
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

    ' Método para eliminar un producto
    Public Sub EliminarProducto(idProducto As Integer)
        Dim consulta As String = "DELETE FROM Productos WHERE ProductoID = @IdProducto"

        Using conexion As SqlConnection = conexionDB.ObtenerConexion()
            Using comando As New SqlCommand(consulta, conexion)
                comando.Parameters.AddWithValue("@IdProducto", idProducto)

                Try
                    conexion.Open()
                    comando.ExecuteNonQuery()
                Catch ex As Exception
                    ' Manejar excepciones si ocurren errores
                    MessageBox.Show("Ocurrió un error al eliminar el producto: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub
End Class
