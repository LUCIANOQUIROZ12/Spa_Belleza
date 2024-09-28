Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms

Public Class FormServicio
    Private ReadOnly idServicio As Integer = 1 ' ID de ejemplo
    Private servicioNegocio As New ServicioNegocio()
    Private PanelExpandido As Boolean = True
    Private Const AnchoOriginal As Integer = 160
    Private Const AnchoReducido As Integer = 32

    Private Sub FormServicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Inicializa la altura de las filas antes de cargar los datos
        DataGridView1.RowTemplate.Height = 150
        DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None



        ' Cargar los datos de la tabla Servicios en el DataGridView
        CargarServiciosEnDataGridView()
    End Sub


    Private Sub CargarServiciosEnDataGridView()
        Dim serviciosData As DataTable = servicioNegocio.ObtenerServicios()

        ' Limpiar columnas existentes antes de agregar nuevas
        DataGridView1.Columns.Clear()

        ' Asignar el DataTable al DataSource del DataGridView
        DataGridView1.DataSource = serviciosData

        ' Establecer AllowUserToAddRows en False para evitar el espacio en blanco al final
        DataGridView1.AllowUserToAddRows = False

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

    ' Evento para manejar clics en las celdas de botón de Editar y Eliminar
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        ' Verifica que el índice de la fila sea válido
        If e.RowIndex >= 0 Then
            ' Verifica que el índice de la columna sea válido
            If e.ColumnIndex >= 0 AndAlso e.ColumnIndex < DataGridView1.Columns.Count Then
                Dim columna As String = DataGridView1.Columns(e.ColumnIndex).Name

                ' Verifica que la celda no sea Nothing y que tenga un valor válido
                Dim servicioID As Integer
                If DataGridView1.Rows(e.RowIndex).Cells("ServicioID") IsNot Nothing AndAlso
                   DataGridView1.Rows(e.RowIndex).Cells("ServicioID").Value IsNot Nothing AndAlso
                   Integer.TryParse(DataGridView1.Rows(e.RowIndex).Cells("ServicioID").Value.ToString(), servicioID) Then

                    Select Case columna
                        Case "Editar"
                            ' Llamar al formulario de registro con el ID del servicio
                            Dim formRegistrar As New FormRegistrarServicio(servicioID)
                            formRegistrar.ShowDialog()

                            ' Recargar los datos en el DataGridView después de editar un servicio
                            CargarServiciosEnDataGridView()

                        Case "Eliminar"
                            ' Confirmar eliminación
                            Dim resultado As DialogResult = MessageBox.Show("¿Está seguro de que desea eliminar este servicio?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                            If resultado = DialogResult.Yes Then
                                ' Eliminar el servicio
                                servicioNegocio.EliminarServicio(servicioID)

                                ' Recargar los datos en el DataGridView después de eliminar un servicio
                                CargarServiciosEnDataGridView()
                            End If
                    End Select
                Else
                    MessageBox.Show("El ID del servicio no está disponible o es inválido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("La columna seleccionada es inválida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("La fila seleccionada es inválida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    ' Función para retroceder

End Class
