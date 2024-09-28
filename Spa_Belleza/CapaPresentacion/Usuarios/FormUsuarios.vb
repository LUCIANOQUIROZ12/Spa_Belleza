Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms

Public Class FormUsuarios
    Private ReadOnly idUsuario As Integer = 1 ' ID de ejemplo
    Private usuarioNegocio As New UsuarioNegocio()
    Private PanelExpandido As Boolean = True
    Private Const AnchoOriginal As Integer = 160
    Private Const AnchoReducido As Integer = 32


    Private Sub FormUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Inicializa la altura de las filas antes de cargar los datos
        DataGridView1.RowTemplate.Height = 150
        DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None



        ' Cargar los datos de la tabla Usuarios en el DataGridView
        CargarUsuariosEnDataGridView()
    End Sub

    Private Sub MostrarNombreUsuario()
        Dim nombreUsuario As String = usuarioNegocio.ObtenerNombreUsuario(idUsuario)

        ' Definir la fuente en negrita, tamaño 24, Arial
        Dim font As New Font("Arial", 24, FontStyle.Bold)

        ' Actualizar el texto del Label y su estilo
        If Not String.IsNullOrEmpty(nombreUsuario) Then
            lblTitulo.Text = " " & nombreUsuario
        Else
            lblTitulo.Text = "Usuario no encontrado"
        End If

        ' Aplicar la fuente al Label
        lblTitulo.Font = font
    End Sub

    Private Sub CargarUsuariosEnDataGridView()
        Dim usuariosData As DataTable = usuarioNegocio.ObtenerUsuarios()

        ' Limpiar columnas existentes antes de agregar nuevas
        DataGridView1.Columns.Clear()

        ' Asignar el DataTable al DataSource del DataGridView
        DataGridView1.DataSource = usuariosData

        ' Establecer AllowUserToAddRows en False para evitar el espacio en blanco al final
        DataGridView1.AllowUserToAddRows = False

        ' Crear y agregar columna de imagen al final del DataGridView si no existe
        If Not DataGridView1.Columns.Contains("Foto") Then
            Dim columnaImagen As New DataGridViewImageColumn()
            columnaImagen.Name = "Foto"
            columnaImagen.HeaderText = "Foto"
            columnaImagen.ImageLayout = DataGridViewImageCellLayout.Zoom
            columnaImagen.Width = 100 ' Ajustar el ancho a 100 píxeles
            columnaImagen.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
            DataGridView1.Columns.Add(columnaImagen)
        End If

        ' Redimensionar imágenes para ajustar a la altura de la fila desde el inicio
        For Each fila As DataGridViewRow In DataGridView1.Rows
            If fila.Cells("Foto").Value IsNot Nothing AndAlso TypeOf fila.Cells("Foto").Value Is Byte() Then
                Dim imagenOriginal As Image = ConvertirBytesAImagen(DirectCast(fila.Cells("Foto").Value, Byte()))
                fila.Cells("Foto").Value = RedimensionarImagen(imagenOriginal, 100, 150)
            End If
        Next

        ' Crear y agregar columna de botones de Editar si no existe
        If Not DataGridView1.Columns.Contains("Editar") Then
            Dim columnaEditar As New DataGridViewButtonColumn()
            columnaEditar.Name = "Editar"
            columnaEditar.HeaderText = "Editar"
            columnaEditar.Text = "Editar"
            columnaEditar.UseColumnTextForButtonValue = True
            DataGridView1.Columns.Add(columnaEditar)
        End If

        ' Crear y agregar columna de botones de Eliminar si no existe
        If Not DataGridView1.Columns.Contains("Eliminar") Then
            Dim columnaEliminar As New DataGridViewButtonColumn()
            columnaEliminar.Name = "Eliminar"
            columnaEliminar.HeaderText = "Eliminar"
            columnaEliminar.Text = "Eliminar"
            columnaEliminar.UseColumnTextForButtonValue = True
            DataGridView1.Columns.Add(columnaEliminar)
        End If

        ' Colorear los botones de Editar (verde) y Eliminar (rojo) completamente
        For Each fila As DataGridViewRow In DataGridView1.Rows
            If fila.Cells("Editar") IsNot Nothing Then
                fila.Cells("Editar").Style.BackColor = Color.LightGreen ' Color verde para Editar
                fila.Cells("Editar").Style.ForeColor = Color.Black
            End If

            If fila.Cells("Eliminar") IsNot Nothing Then
                fila.Cells("Eliminar").Style.BackColor = Color.LightCoral ' Color rojo para Eliminar
                fila.Cells("Eliminar").Style.ForeColor = Color.Black
            End If
        Next

        ' Establecer todas las celdas como solo lectura
        For Each columna As DataGridViewColumn In DataGridView1.Columns
            columna.ReadOnly = True
        Next
    End Sub



    ' Función para redimensionar la imagen
    Private Function RedimensionarImagen(imagenOriginal As Image, ancho As Integer, alto As Integer) As Image
        Dim imagenRedimensionada As New Bitmap(ancho, alto)
        Using grafico As Graphics = Graphics.FromImage(imagenRedimensionada)
            grafico.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
            grafico.DrawImage(imagenOriginal, 0, 0, ancho, alto)
        End Using
        Return imagenRedimensionada
    End Function

    ' Función para convertir un arreglo de bytes a una imagen
    Private Function ConvertirBytesAImagen(byteArray As Byte()) As Image
        Using memoria As New IO.MemoryStream(byteArray)
            Return Image.FromStream(memoria)
        End Using
    End Function







    ' Evento para manejar la expansión y contracción del panel lateral
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If PanelExpandido Then
            PanelMenu.Width = AnchoReducido
            PictureBox2.Location = New Point(5, PictureBox2.Location.Y)
        Else
            PanelMenu.Width = AnchoOriginal
            PictureBox2.Location = New Point(AnchoOriginal - PictureBox2.Width - 5, PictureBox2.Location.Y)
        End If
        PanelExpandido = Not PanelExpandido
    End Sub

    ' Botón para salir de la aplicación
    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Application.Exit()
    End Sub

    ' Método para dibujar el texto en el PanelSuperior


    Private Sub BtnRegistrar_Click(sender As Object, e As EventArgs) Handles BtnRegistrar.Click
        ' Crear y mostrar el formulario de registro de nuevo usuario
        Dim formRegistrar As New FormRegistrarUsuario()
        formRegistrar.ShowDialog()

        ' Recargar los datos en el DataGridView después de registrar un nuevo usuario
        CargarUsuariosEnDataGridView()
    End Sub

    ' Evento para manejar el texto de búsqueda en el TextBox
    Private Sub txtBusqueda_Enter(sender As Object, e As EventArgs) Handles txtBusqueda.Enter
        If txtBusqueda.Text = "Nombres" Then
            txtBusqueda.Text = ""
            txtBusqueda.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtBusqueda_Leave(sender As Object, e As EventArgs) Handles txtBusqueda.Leave
        If String.IsNullOrWhiteSpace(txtBusqueda.Text) Then
            txtBusqueda.Text = "Nombres"
            txtBusqueda.ForeColor = Color.Gray
        End If

        ' Actualizar el DataGridView cuando se pierde el foco en el TextBox de búsqueda
        FiltrarUsuarios(txtBusqueda.Text)
    End Sub

    ' Evento para filtrar los datos en el DataGridView según el texto de búsqueda
    Private Sub txtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtBusqueda.TextChanged
        ' Actualizar el DataGridView mientras se escribe en el TextBox de búsqueda
        FiltrarUsuarios(txtBusqueda.Text)
    End Sub

    ' Método para filtrar los usuarios según la letra con la que empieza el nombre
    Private Sub FiltrarUsuarios(busqueda As String)
        Dim usuariosData As DataTable = CType(DataGridView1.DataSource, DataTable)
        If usuariosData IsNot Nothing Then
            If Not String.IsNullOrWhiteSpace(busqueda) AndAlso busqueda <> "Nombres" Then
                ' Aplicar el filtro para que muestre solo los nombres que empiezan con la letra ingresada
                Dim filtro As String = $"Nombres LIKE '{busqueda}%'"
                usuariosData.DefaultView.RowFilter = filtro
            Else
                ' Limpiar el filtro si no hay texto en el cuadro de búsqueda
                usuariosData.DefaultView.RowFilter = String.Empty
            End If
        End If
    End Sub

    ' Evento para manejar clics en las celdas de botón de Editar y Eliminar
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        ' Verifica que el índice de la fila sea válido
        If e.RowIndex >= 0 Then
            ' Verifica que el índice de la columna sea válido
            If e.ColumnIndex >= 0 AndAlso e.ColumnIndex < DataGridView1.Columns.Count Then
                Dim columna As String = DataGridView1.Columns(e.ColumnIndex).Name

                ' Verifica que la celda no sea Nothing y que tenga un valor válido
                Dim usuarioID As Integer
                If DataGridView1.Rows(e.RowIndex).Cells("UsuarioID") IsNot Nothing AndAlso
                   DataGridView1.Rows(e.RowIndex).Cells("UsuarioID").Value IsNot Nothing AndAlso
                   Integer.TryParse(DataGridView1.Rows(e.RowIndex).Cells("UsuarioID").Value.ToString(), usuarioID) Then

                    Select Case columna
                        Case "Editar"
                            ' Llamar al formulario de registro con el ID del usuario
                            Dim formRegistrar As New FormRegistrarUsuario(usuarioID)
                            formRegistrar.ShowDialog()

                            ' Recargar los datos en el DataGridView después de editar un usuario
                            CargarUsuariosEnDataGridView()

                        Case "Eliminar"
                            ' Confirmar eliminación
                            Dim resultado As DialogResult = MessageBox.Show("¿Está seguro de que desea eliminar este usuario?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                            If resultado = DialogResult.Yes Then
                                ' Eliminar el usuario
                                usuarioNegocio.EliminarUsuario(usuarioID)

                                ' Recargar los datos en el DataGridView después de eliminar un usuario
                                CargarUsuariosEnDataGridView()
                            End If
                    End Select
                Else
                    MessageBox.Show("El ID del usuario no está disponible o es inválido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("La columna seleccionada es inválida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("La fila seleccionada es inválida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub BtnProductos_Click(sender As Object, e As EventArgs) Handles BtnProductos.Click
        ' Limpiar controles previos en el PanelContenido
        PanelContenido.Controls.Clear()

        ' Actualizar el título del formulario
        lblTitulo.Text = "PRODUCTOS"

        ' Crear una nueva instancia del formulario de Productos
        Dim formProducto As New FormProducto()
        formProducto.TopLevel = False ' Establecer como control hijo
        formProducto.FormBorderStyle = FormBorderStyle.None
        formProducto.Dock = DockStyle.Fill ' Ajustar para que llene el panel

        ' Agregar el formulario al PanelContenido
        PanelContenido.Controls.Add(formProducto)
        PanelContenido.Tag = formProducto
        formProducto.Show()
    End Sub

    Private Sub BtnServicios_Click(sender As Object, e As EventArgs) Handles BtnServicios.Click
        ' Limpiar controles previos en el PanelContenido
        PanelContenido.Controls.Clear()

        ' Actualizar el título del formulario
        lblTitulo.Text = "SERVICIOS"

        ' Crear una nueva instancia del formulario de Servicios
        Dim formServicio As New FormServicio()
        formServicio.TopLevel = False ' Establecer como control hijo
        formServicio.FormBorderStyle = FormBorderStyle.None
        formServicio.Dock = DockStyle.Fill ' Ajustar para que llene el panel

        ' Agregar el formulario al PanelContenido
        PanelContenido.Controls.Add(formServicio)
        PanelContenido.Tag = formServicio
        formServicio.Show()
    End Sub

    Private Sub BtnUsuarios_Click(sender As Object, e As EventArgs) Handles BtnUsuarios.Click
        PanelContenido.Controls.Clear()

        ' Actualizar el título del formulario
        lblTitulo.Text = "USUARIOS"

        ' Este código está incorrecto porque estás tratando de agregar una nueva instancia del mismo formulario
        ' Dim formUsuarios As New FormUsuarios() ' No es correcto crear otra instancia de FormUsuarios

        ' En lugar de eso, simplemente reorganiza los controles dentro de PanelContenido
        PanelContenido.Controls.Add(DataGridView1)
        PanelContenido.Controls.Add(txtBusqueda)
        PanelContenido.Controls.Add(BtnRegistrar)

        ' Si es necesario, recarga los datos de usuarios
        CargarUsuariosEnDataGridView()
    End Sub

    Private Sub BtnInicio_Click(sender As Object, e As EventArgs) Handles BtnInicio.Click

    End Sub
End Class