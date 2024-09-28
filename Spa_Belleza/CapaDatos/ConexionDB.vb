Imports System.Data.SqlClient

Public Class ConexionDB
    ' Cadena de conexión
    Private ReadOnly cadenaConexion As String = "Data Source=DESKTOP-ON05S9T;Initial Catalog=spabelleza;Integrated Security=True"

    ' Función para obtener la conexión
    Public Function ObtenerConexion() As SqlConnection
        Return New SqlConnection(cadenaConexion)
    End Function
End Class




'ESTE ES EL NUEVO PROYECTO'