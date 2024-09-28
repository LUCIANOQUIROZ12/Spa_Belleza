<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormServicio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormServicio))
        PanelSuperior = New Panel()
        PanelContenido = New Panel()
        PictureBox4 = New PictureBox()
        DataGridView1 = New DataGridView()
        txtBusqueda = New TextBox()
        BtnRegistrar = New Button()
        PanelContenido.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PanelSuperior
        ' 
        PanelSuperior.Dock = DockStyle.Top
        PanelSuperior.Location = New Point(0, 0)
        PanelSuperior.Name = "PanelSuperior"
        PanelSuperior.Size = New Size(1370, 43)
        PanelSuperior.TabIndex = 1
        ' 
        ' PanelContenido
        ' 
        PanelContenido.BackColor = SystemColors.ScrollBar
        PanelContenido.BackgroundImage = My.Resources.Resources.fondo_spa
        PanelContenido.BackgroundImageLayout = ImageLayout.Stretch
        PanelContenido.Controls.Add(PictureBox4)
        PanelContenido.Controls.Add(DataGridView1)
        PanelContenido.Controls.Add(txtBusqueda)
        PanelContenido.Controls.Add(BtnRegistrar)
        PanelContenido.Dock = DockStyle.Fill
        PanelContenido.Location = New Point(0, 43)
        PanelContenido.Name = "PanelContenido"
        PanelContenido.Size = New Size(1370, 706)
        PanelContenido.TabIndex = 2
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(652, 141)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(28, 29)
        PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox4.TabIndex = 4
        PictureBox4.TabStop = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(271, 176)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(585, 340)
        DataGridView1.TabIndex = 3
        ' 
        ' txtBusqueda
        ' 
        txtBusqueda.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtBusqueda.Location = New Point(677, 141)
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
        BtnRegistrar.Location = New Point(923, 135)
        BtnRegistrar.Name = "BtnRegistrar"
        BtnRegistrar.Size = New Size(143, 35)
        BtnRegistrar.TabIndex = 1
        BtnRegistrar.Text = "Agregar Servicio"
        BtnRegistrar.UseVisualStyleBackColor = False
        ' 
        ' FormServicio
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1370, 749)
        Controls.Add(PanelContenido)
        Controls.Add(PanelSuperior)
        Name = "FormServicio"
        Text = "FormServicio"
        PanelContenido.ResumeLayout(False)
        PanelContenido.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)

    End Sub

    Friend WithEvents PanelSuperior As Panel
    Friend WithEvents PanelContenido As Panel
    Friend WithEvents txtBusqueda As TextBox
    Friend WithEvents BtnRegistrar As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PictureBox4 As PictureBox
End Class
