<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormRegistrarProducto
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        TxtNombreProducto = New TextBox()
        TxtDescripcion = New TextBox()
        TxtStock = New TextBox()
        TxtPrecio = New TextBox()
        BtnGuardar = New Button()
        BtnCancelar = New Button()
        PictureFoto = New PictureBox()
        BtnSeleccionarFoto = New Button()
        Label6 = New Label()
        TxtIdProducto = New TextBox()
        CType(PictureFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("MV Boli", 24.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.Control
        Label1.Location = New Point(145, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(157, 41)
        Label1.TabIndex = 0
        Label1.Text = "Productos"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Sitka Text", 11.25F, FontStyle.Bold)
        Label2.ForeColor = SystemColors.Control
        Label2.Location = New Point(28, 162)
        Label2.Name = "Label2"
        Label2.Size = New Size(143, 21)
        Label2.TabIndex = 1
        Label2.Text = "Nombre Producto:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Sitka Text", 11.25F, FontStyle.Bold)
        Label3.ForeColor = SystemColors.Control
        Label3.Location = New Point(28, 236)
        Label3.Name = "Label3"
        Label3.Size = New Size(103, 21)
        Label3.TabIndex = 2
        Label3.Text = "Descripción:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Sitka Text", 11.25F, FontStyle.Bold)
        Label4.ForeColor = SystemColors.Control
        Label4.Location = New Point(28, 318)
        Label4.Name = "Label4"
        Label4.Size = New Size(55, 21)
        Label4.TabIndex = 3
        Label4.Text = "Stock:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Sitka Text", 11.25F, FontStyle.Bold)
        Label5.ForeColor = SystemColors.Control
        Label5.Location = New Point(28, 395)
        Label5.Name = "Label5"
        Label5.Size = New Size(58, 21)
        Label5.TabIndex = 4
        Label5.Text = "Precio:"
        ' 
        ' TxtNombreProducto
        ' 
        TxtNombreProducto.BackColor = Color.FromArgb(CByte(91), CByte(30), CByte(80))
        TxtNombreProducto.ForeColor = SystemColors.Control
        TxtNombreProducto.Location = New Point(28, 197)
        TxtNombreProducto.Name = "TxtNombreProducto"
        TxtNombreProducto.Size = New Size(380, 26)
        TxtNombreProducto.TabIndex = 10
        ' 
        ' TxtDescripcion
        ' 
        TxtDescripcion.BackColor = Color.FromArgb(CByte(91), CByte(30), CByte(80))
        TxtDescripcion.ForeColor = SystemColors.Control
        TxtDescripcion.Location = New Point(28, 276)
        TxtDescripcion.Name = "TxtDescripcion"
        TxtDescripcion.Size = New Size(380, 26)
        TxtDescripcion.TabIndex = 11
        ' 
        ' TxtStock
        ' 
        TxtStock.BackColor = Color.FromArgb(CByte(91), CByte(30), CByte(80))
        TxtStock.ForeColor = SystemColors.Control
        TxtStock.Location = New Point(28, 352)
        TxtStock.Name = "TxtStock"
        TxtStock.Size = New Size(230, 26)
        TxtStock.TabIndex = 13
        ' 
        ' TxtPrecio
        ' 
        TxtPrecio.BackColor = Color.FromArgb(CByte(91), CByte(30), CByte(80))
        TxtPrecio.ForeColor = SystemColors.Control
        TxtPrecio.Location = New Point(28, 432)
        TxtPrecio.Name = "TxtPrecio"
        TxtPrecio.Size = New Size(230, 26)
        TxtPrecio.TabIndex = 14
        ' 
        ' BtnGuardar
        ' 
        BtnGuardar.BackColor = Color.FromArgb(CByte(91), CByte(30), CByte(80))
        BtnGuardar.ForeColor = SystemColors.Control
        BtnGuardar.Location = New Point(236, 504)
        BtnGuardar.Name = "BtnGuardar"
        BtnGuardar.Size = New Size(140, 45)
        BtnGuardar.TabIndex = 19
        BtnGuardar.Text = "Guardar"
        BtnGuardar.UseVisualStyleBackColor = False
        ' 
        ' BtnCancelar
        ' 
        BtnCancelar.BackColor = Color.Black
        BtnCancelar.ForeColor = Color.White
        BtnCancelar.Location = New Point(61, 504)
        BtnCancelar.Name = "BtnCancelar"
        BtnCancelar.Size = New Size(140, 45)
        BtnCancelar.TabIndex = 20
        BtnCancelar.Text = "Cancelar"
        BtnCancelar.UseVisualStyleBackColor = False
        ' 
        ' PictureFoto
        ' 
        PictureFoto.BorderStyle = BorderStyle.FixedSingle
        PictureFoto.Location = New Point(157, 78)
        PictureFoto.Name = "PictureFoto"
        PictureFoto.Size = New Size(101, 91)
        PictureFoto.SizeMode = PictureBoxSizeMode.AutoSize
        PictureFoto.TabIndex = 25
        PictureFoto.TabStop = False
        ' 
        ' BtnSeleccionarFoto
        ' 
        BtnSeleccionarFoto.BackColor = Color.FromArgb(CByte(91), CByte(30), CByte(80))
        BtnSeleccionarFoto.ForeColor = SystemColors.Control
        BtnSeleccionarFoto.Location = New Point(288, 111)
        BtnSeleccionarFoto.Name = "BtnSeleccionarFoto"
        BtnSeleccionarFoto.Size = New Size(120, 33)
        BtnSeleccionarFoto.TabIndex = 27
        BtnSeleccionarFoto.Text = "Subir Imagen"
        BtnSeleccionarFoto.UseVisualStyleBackColor = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Sitka Text", 11.25F, FontStyle.Bold)
        Label6.ForeColor = SystemColors.Control
        Label6.Location = New Point(28, 78)
        Label6.Name = "Label6"
        Label6.Size = New Size(89, 21)
        Label6.TabIndex = 23
        Label6.Text = "IdProducto:"
        ' 
        ' TxtIdProducto
        ' 
        TxtIdProducto.BackColor = Color.FromArgb(CByte(91), CByte(30), CByte(80))
        TxtIdProducto.ForeColor = SystemColors.Control
        TxtIdProducto.Location = New Point(28, 118)
        TxtIdProducto.Name = "TxtIdProducto"
        TxtIdProducto.Size = New Size(74, 26)
        TxtIdProducto.TabIndex = 24
        ' 
        ' FormRegistrarProducto
        ' 
        AutoScaleDimensions = New SizeF(9.0F, 21.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        ClientSize = New Size(438, 600)
        Controls.Add(BtnSeleccionarFoto)
        Controls.Add(PictureFoto)
        Controls.Add(TxtIdProducto)
        Controls.Add(Label6)
        Controls.Add(BtnCancelar)
        Controls.Add(BtnGuardar)
        Controls.Add(TxtPrecio)
        Controls.Add(TxtStock)
        Controls.Add(TxtDescripcion)
        Controls.Add(TxtNombreProducto)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Font = New Font("Sitka Text", 11.25F, FontStyle.Bold)
        FormBorderStyle = FormBorderStyle.None
        Name = "FormRegistrarProducto"
        StartPosition = FormStartPosition.CenterParent
        Text = "FormRegistrarProducto"
        CType(PictureFoto, System.ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtNombreProducto As TextBox
    Friend WithEvents TxtDescripcion As TextBox
    Friend WithEvents TxtStock As TextBox
    Friend WithEvents TxtPrecio As TextBox
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents PictureFoto As PictureBox
    Friend WithEvents BtnSeleccionarFoto As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtIdProducto As TextBox
End Class
