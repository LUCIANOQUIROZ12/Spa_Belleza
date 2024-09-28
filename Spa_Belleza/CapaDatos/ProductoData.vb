Imports System.Data
Imports System.Data.SqlClient

Public Class ProductoData
    Private db As New ConexionDB()

    ' Obtener todos los productos
    Public Function ObtenerProductos() As DataTable
        Dim dataTable As New DataTable()

        Using conexion As SqlConnection = db.ObtenerConexion()
            Using comando As New SqlCommand("ListarProductos", conexion)
                comando.CommandType = CommandType.StoredProcedure

                Using adapter As New SqlDataAdapter(comando)
                    conexion.Open()
                    adapter.Fill(dataTable)
                End Using
            End Using
        End Using

        Return dataTable
    End Function

    ' Insertar un nuevo producto
    Public Sub InsertarProducto(producto As Producto)
        Using conexion As SqlConnection = db.ObtenerConexion()
            Using comando As New SqlCommand("InsertarProducto", conexion)
                comando.CommandType = CommandType.StoredProcedure
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

    ' Actualizar un producto existente
    Public Sub ActualizarProducto(producto As Producto)
        Using conexion As SqlConnection = db.ObtenerConexion()
            Using comando As New SqlCommand("ActualizarProducto", conexion)
                comando.CommandType = CommandType.StoredProcedure
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

    ' Eliminar un producto
    Public Sub EliminarProducto(productoID As Integer)
        Using conexion As SqlConnection = db.ObtenerConexion()
            Using comando As New SqlCommand("EliminarProducto", conexion)
                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.AddWithValue("@ProductoID", productoID)

                conexion.Open()
                comando.ExecuteNonQuery()
            End Using
        End Using
    End Sub
End Class
