<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormUsuarios
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormUsuarios))
        PanelMenu = New Panel()
        BtnInicio = New Button()
        BtnSalir = New Button()
        BtnReporte = New Button()
        BtnPagos = New Button()
        BtnProgramacion = New Button()
        BtnCita = New Button()
        BtnProductos = New Button()
        BtnServicios = New Button()
        BtnRoles = New Button()
        BtnUsuarios = New Button()
        PictureBox2 = New PictureBox()
        PictureBox1 = New PictureBox()
        PanelSuperior = New Panel()
        lblTitulo = New Label()
        PanelContenido = New Panel()
        PictureBox4 = New PictureBox()
        DataGridView1 = New DataGridView()
        txtBusqueda = New TextBox()
        BtnRegistrar = New Button()
        PanelMenu.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        PanelContenido.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PanelMenu
        ' 
        PanelMenu.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(255))
        PanelMenu.Controls.Add(BtnInicio)
        PanelMenu.Controls.Add(BtnSalir)
        PanelMenu.Controls.Add(BtnReporte)
        PanelMenu.Controls.Add(BtnPagos)
        PanelMenu.Controls.Add(BtnProgramacion)
        PanelMenu.Controls.Add(BtnCita)
        PanelMenu.Controls.Add(BtnProductos)
        PanelMenu.Controls.Add(BtnServicios)
        PanelMenu.Controls.Add(BtnRoles)
        PanelMenu.Controls.Add(BtnUsuarios)
        PanelMenu.Controls.Add(PictureBox2)
        PanelMenu.Controls.Add(PictureBox1)
        PanelMenu.Dock = DockStyle.Left
        PanelMenu.Location = New Point(0, 0)
        PanelMenu.Name = "PanelMenu"
        PanelMenu.Size = New Size(156, 749)
        PanelMenu.TabIndex = 0
        ' 
        ' BtnInicio
        ' 
        BtnInicio.BackColor = Color.Transparent
        BtnInicio.BackgroundImageLayout = ImageLayout.Zoom
        BtnInicio.Cursor = Cursors.Hand
        BtnInicio.FlatAppearance.MouseDownBackColor = Color.White
        BtnInicio.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        BtnInicio.FlatStyle = FlatStyle.Flat
        BtnInicio.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnInicio.ForeColor = Color.Purple
        BtnInicio.Image = My.Resources.Resources.casa
        BtnInicio.ImageAlign = ContentAlignment.MiddleLeft
        BtnInicio.Location = New Point(0, 176)
        BtnInicio.Name = "BtnInicio"
        BtnInicio.Size = New Size(156, 36)
        BtnInicio.TabIndex = 13
        BtnInicio.Text = "INICIO"
        BtnInicio.TextAlign = ContentAlignment.MiddleRight
        BtnInicio.UseVisualStyleBackColor = False
        ' 
        ' BtnSalir
        ' 
        BtnSalir.BackColor = Color.Transparent
        BtnSalir.BackgroundImageLayout = ImageLayout.Zoom
        BtnSalir.Cursor = Cursors.Hand
        BtnSalir.FlatAppearance.MouseDownBackColor = Color.White
        BtnSalir.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        BtnSalir.FlatStyle = FlatStyle.Flat
        BtnSalir.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnSalir.ForeColor = Color.Purple
        BtnSalir.Image = CType(resources.GetObject("BtnSalir.Image"), Image)
        BtnSalir.ImageAlign = ContentAlignment.MiddleLeft
        BtnSalir.Location = New Point(0, 701)
        BtnSalir.Name = "BtnSalir"
        BtnSalir.Size = New Size(156, 36)
        BtnSalir.TabIndex = 12
        BtnSalir.Text = "Salir"
        BtnSalir.TextAlign = ContentAlignment.MiddleRight
        BtnSalir.UseVisualStyleBackColor = False
        ' 
        ' BtnReporte
        ' 
        BtnReporte.BackColor = Color.Transparent
        BtnReporte.BackgroundImageLayout = ImageLayout.Zoom
        BtnReporte.Cursor = Cursors.Hand
        BtnReporte.FlatAppearance.MouseDownBackColor = Color.White
        BtnReporte.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        BtnReporte.FlatStyle = FlatStyle.Flat
        BtnReporte.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnReporte.ForeColor = Color.Purple
        BtnReporte.Image = CType(resources.GetObject("BtnReporte.Image"), Image)
        BtnReporte.ImageAlign = ContentAlignment.MiddleLeft
        BtnReporte.Location = New Point(0, 530)
        BtnReporte.Name = "BtnReporte"
        BtnReporte.Size = New Size(156, 36)
        BtnReporte.TabIndex = 11
        BtnReporte.Text = "Reportes"
        BtnReporte.TextAlign = ContentAlignment.MiddleRight
        BtnReporte.UseVisualStyleBackColor = False
        ' 
        ' BtnPagos
        ' 
        BtnPagos.BackColor = Color.Transparent
        BtnPagos.BackgroundImageLayout = ImageLayout.Zoom
        BtnPagos.Cursor = Cursors.Hand
        BtnPagos.FlatAppearance.MouseDownBackColor = Color.White
        BtnPagos.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        BtnPagos.FlatStyle = FlatStyle.Flat
        BtnPagos.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnPagos.ForeColor = Color.Purple
        BtnPagos.Image = CType(resources.GetObject("BtnPagos.Image"), Image)
        BtnPagos.ImageAlign = ContentAlignment.MiddleLeft
        BtnPagos.Location = New Point(0, 488)
        BtnPagos.Name = "BtnPagos"
        BtnPagos.Size = New Size(156, 36)
        BtnPagos.TabIndex = 10
        BtnPagos.Text = "Pagos"
        BtnPagos.TextAlign = ContentAlignment.MiddleRight
        BtnPagos.UseVisualStyleBackColor = False
        ' 
        ' BtnProgramacion
        ' 
        BtnProgramacion.BackColor = Color.Transparent
        BtnProgramacion.BackgroundImageLayout = ImageLayout.Zoom
        BtnProgramacion.Cursor = Cursors.Hand
        BtnProgramacion.FlatAppearance.MouseDownBackColor = Color.White
        BtnProgramacion.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        BtnProgramacion.FlatStyle = FlatStyle.Flat
        BtnProgramacion.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnProgramacion.ForeColor = Color.Purple
        BtnProgramacion.Image = CType(resources.GetObject("BtnProgramacion.Image"), Image)
        BtnProgramacion.ImageAlign = ContentAlignment.MiddleLeft
        BtnProgramacion.Location = New Point(0, 446)
        BtnProgramacion.Name = "BtnProgramacion"
        BtnProgramacion.Size = New Size(156, 36)
        BtnProgramacion.TabIndex = 9
        BtnProgramacion.Text = "Programacion"
        BtnProgramacion.TextAlign = ContentAlignment.MiddleRight
        BtnProgramacion.UseVisualStyleBackColor = False
        ' 
        ' BtnCita
        ' 
        BtnCita.BackColor = Color.Transparent
        BtnCita.BackgroundImageLayout = ImageLayout.Zoom
        BtnCita.Cursor = Cursors.Hand
        BtnCita.FlatAppearance.MouseDownBackColor = Color.White
        BtnCita.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        BtnCita.FlatStyle = FlatStyle.Flat
        BtnCita.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnCita.ForeColor = Color.Purple
        BtnCita.Image = CType(resources.GetObject("BtnCita.Image"), Image)
        BtnCita.ImageAlign = ContentAlignment.MiddleLeft
        BtnCita.Location = New Point(0, 404)
        BtnCita.Name = "BtnCita"
        BtnCita.Size = New Size(156, 36)
        BtnCita.TabIndex = 8
        BtnCita.Text = "Cita"
        BtnCita.TextAlign = ContentAlignment.MiddleRight
        BtnCita.UseVisualStyleBackColor = False
        ' 
        ' BtnProductos
        ' 
        BtnProductos.BackColor = Color.Transparent
        BtnProductos.BackgroundImageLayout = ImageLayout.Zoom
        BtnProductos.Cursor = Cursors.Hand
        BtnProductos.FlatAppearance.MouseDownBackColor = Color.White
        BtnProductos.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        BtnProductos.FlatStyle = FlatStyle.Flat
        BtnProductos.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnProductos.ForeColor = Color.Purple
        BtnProductos.Image = CType(resources.GetObject("BtnProductos.Image"), Image)
        BtnProductos.ImageAlign = ContentAlignment.MiddleLeft
        BtnProductos.Location = New Point(0, 362)
        BtnProductos.Name = "BtnProductos"
        BtnProductos.Size = New Size(156, 36)
        BtnProductos.TabIndex = 7
        BtnProductos.Text = "Productos"
        BtnProductos.TextAlign = ContentAlignment.MiddleRight
        BtnProductos.UseVisualStyleBackColor = False
        ' 
        ' BtnServicios
        ' 
        BtnServicios.BackColor = Color.Transparent
        BtnServicios.BackgroundImageLayout = ImageLayout.Zoom
        BtnServicios.Cursor = Cursors.Hand
        BtnServicios.FlatAppearance.MouseDownBackColor = Color.White
        BtnServicios.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        BtnServicios.FlatStyle = FlatStyle.Flat
        BtnServicios.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnServicios.ForeColor = Color.Purple
        BtnServicios.Image = CType(resources.GetObject("BtnServicios.Image"), Image)
        BtnServicios.ImageAlign = ContentAlignment.MiddleLeft
        BtnServicios.Location = New Point(0, 315)
        BtnServicios.Name = "BtnServicios"
        BtnServicios.Size = New Size(156, 36)
        BtnServicios.TabIndex = 6
        BtnServicios.Text = "Servicios"
        BtnServicios.TextAlign = ContentAlignment.MiddleRight
        BtnServicios.UseVisualStyleBackColor = False
        ' 
        ' BtnRoles
        ' 
        BtnRoles.BackColor = Color.Transparent
        BtnRoles.BackgroundImageLayout = ImageLayout.Zoom
        BtnRoles.Cursor = Cursors.Hand
        BtnRoles.FlatAppearance.MouseDownBackColor = Color.White
        BtnRoles.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        BtnRoles.FlatStyle = FlatStyle.Flat
        BtnRoles.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnRoles.ForeColor = Color.Purple
        BtnRoles.Image = CType(resources.GetObject("BtnRoles.Image"), Image)
        BtnRoles.ImageAlign = ContentAlignment.MiddleLeft
        BtnRoles.Location = New Point(0, 273)
        BtnRoles.Name = "BtnRoles"
        BtnRoles.Size = New Size(156, 36)
        BtnRoles.TabIndex = 5
        BtnRoles.Text = "Roles"
        BtnRoles.TextAlign = ContentAlignment.MiddleRight
        BtnRoles.UseVisualStyleBackColor = False
        ' 
        ' BtnUsuarios
        ' 
        BtnUsuarios.BackColor = Color.Transparent
        BtnUsuarios.BackgroundImageLayout = ImageLayout.Zoom
        BtnUsuarios.Cursor = Cursors.Hand
        BtnUsuarios.FlatAppearance.MouseDownBackColor = Color.White
        BtnUsuarios.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        BtnUsuarios.FlatStyle = FlatStyle.Flat
        BtnUsuarios.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnUsuarios.ForeColor = Color.Purple
        BtnUsuarios.Image = My.Resources.Resources.agregar_usuario1
        BtnUsuarios.ImageAlign = ContentAlignment.MiddleLeft
        BtnUsuarios.Location = New Point(0, 231)
        BtnUsuarios.Name = "BtnUsuarios"
        BtnUsuarios.Size = New Size(156, 36)
        BtnUsuarios.TabIndex = 4
        BtnUsuarios.Text = "Usuarios"
        BtnUsuarios.TextAlign = ContentAlignment.MiddleRight
        BtnUsuarios.UseVisualStyleBackColor = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.menu
        PictureBox2.Location = New Point(126, 12)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(27, 26)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = My.Resources.Resources.loguito
        PictureBox1.Location = New Point(3, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(121, 132)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' PanelSuperior
        ' 
        PanelSuperior.Dock = DockStyle.Top
        PanelSuperior.Location = New Point(156, 0)
        PanelSuperior.Name = "PanelSuperior"
        PanelSuperior.Size = New Size(1214, 65)
        PanelSuperior.TabIndex = 1
        ' 
        ' lblTitulo
        ' 
        lblTitulo.AutoSize = True
        lblTitulo.Font = New Font("Arial", 24.0F, FontStyle.Bold)
        lblTitulo.Location = New Point(300, 20)
        lblTitulo.Name = "lblTitulo"
        lblTitulo.Size = New Size(154, 37)
        lblTitulo.TabIndex = 1
        lblTitulo.Text = "Usuarios"
        ' 
        ' PanelContenido
        ' 
        PanelContenido.BackColor = SystemColors.ScrollBar
        PanelContenido.BackgroundImage = My.Resources.Resources.fondo_spa
        PanelContenido.Controls.Add(PictureBox4)
        PanelContenido.Controls.Add(DataGridView1)
        PanelContenido.Controls.Add(txtBusqueda)
        PanelContenido.Controls.Add(BtnRegistrar)
        PanelContenido.Dock = DockStyle.Fill
        PanelContenido.Location = New Point(156, 65)
        PanelContenido.Name = "PanelContenido"
        PanelContenido.Size = New Size(1214, 684)
        PanelContenido.TabIndex = 2
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(780, 68)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(28, 29)
        PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox4.TabIndex = 4
        PictureBox4.TabStop = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(19, 191)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(1321, 340)
        DataGridView1.TabIndex = 3
        ' 
        ' txtBusqueda
        ' 
        txtBusqueda.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtBusqueda.Location = New Point(814, 72)
        txtBusqueda.Name = "txtBusqueda"
        txtBusqueda.Size = New Size(240, 25)
        txtBusqueda.TabIndex = 2
        ' 
        ' BtnRegistrar
        ' 
        BtnRegistrar.BackColor = Color.FromArgb(CByte(91), CByte(30), CByte(80))
        BtnRegistrar.Cursor = Cursors.Hand
        BtnRegistrar.Font = New Font("Sitka Subheading", 11.249999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnRegistrar.ForeColor = SystemColors.Control
        BtnRegistrar.Location = New Point(1059, 65)
        BtnRegistrar.Name = "BtnRegistrar"
        BtnRegistrar.Size = New Size(143, 35)
        BtnRegistrar.TabIndex = 1
        BtnRegistrar.Text = "Agregar Usuario"
        BtnRegistrar.UseVisualStyleBackColor = False
        ' 
        ' FormUsuarios
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1370, 749)
        Controls.Add(lblTitulo)
        Controls.Add(PanelContenido)
        Controls.Add(PanelSuperior)
        Controls.Add(PanelMenu)
        ForeColor = SystemColors.MenuText
        Name = "FormUsuarios"
        Text = "..::BELLEZA TOTAL ::."
        PanelMenu.ResumeLayout(False)
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        PanelContenido.ResumeLayout(False)
        PanelContenido.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PanelMenu As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PanelSuperior As Panel
    Friend WithEvents PanelContenido As Panel
    Friend WithEvents BtnUsuarios As Button
    Friend WithEvents BtnRoles As Button
    Friend WithEvents BtnProductos As Button
    Friend WithEvents BtnServicios As Button
    Friend WithEvents BtnProgramacion As Button
    Friend WithEvents BtnCita As Button
    Friend WithEvents BtnReporte As Button
    Friend WithEvents BtnPagos As Button
    Friend WithEvents BtnSalir As Button
    Friend WithEvents txtBusqueda As TextBox
    Friend WithEvents BtnRegistrar As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents BtnInicio As Button
    Friend WithEvents lblTitulo As Label
End Class
