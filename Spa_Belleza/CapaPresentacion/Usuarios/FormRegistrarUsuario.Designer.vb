<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRegistrarUsuario
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        TxtNombres = New TextBox()
        TxtApellidoPaterno = New TextBox()
        TxtApellidoMaterno = New TextBox()
        TxtGmail = New TextBox()
        TxtDNI = New TextBox()
        TxtTelefono = New TextBox()
        TxtUsuario = New TextBox()
        TxtEstado = New ComboBox()
        CboRol = New ComboBox()
        BtnGuardar = New Button()
        BtnCancelar = New Button()
        TxtPassword = New TextBox()
        Label11 = New Label()
        TxtIdUsuario = New TextBox()
        Label12 = New Label()
        PictureFoto = New PictureBox()
        BtnSeleccionarFoto = New Button()
        Label13 = New Label()
        CType(PictureFoto, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("MV Boli", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.Control
        Label1.Location = New Point(145, 9)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(148, 41)
        Label1.TabIndex = 0
        Label1.Text = "Usuarios"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Sitka Text", 11.249999F, FontStyle.Bold)
        Label2.ForeColor = SystemColors.Control
        Label2.Location = New Point(28, 162)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(83, 21)
        Label2.TabIndex = 1
        Label2.Text = "Nombres:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Sitka Text", 11.249999F, FontStyle.Bold)
        Label3.ForeColor = SystemColors.Control
        Label3.Location = New Point(28, 236)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(138, 21)
        Label3.TabIndex = 2
        Label3.Text = "Apellido Paterno:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Sitka Text", 11.249999F, FontStyle.Bold)
        Label4.ForeColor = SystemColors.Control
        Label4.Location = New Point(209, 236)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(143, 21)
        Label4.TabIndex = 3
        Label4.Text = "Apellido Materno:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Sitka Text", 11.249999F, FontStyle.Bold)
        Label5.ForeColor = SystemColors.Control
        Label5.Location = New Point(28, 318)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(60, 21)
        Label5.TabIndex = 4
        Label5.Text = "Gmail:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Sitka Text", 11.249999F, FontStyle.Bold)
        Label6.ForeColor = SystemColors.Control
        Label6.Location = New Point(272, 318)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(45, 21)
        Label6.TabIndex = 5
        Label6.Text = "DNI:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Sitka Text", 11.249999F, FontStyle.Bold)
        Label7.ForeColor = SystemColors.Control
        Label7.Location = New Point(28, 574)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(41, 21)
        Label7.TabIndex = 9
        Label7.Text = "Rol:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Sitka Text", 11.249999F, FontStyle.Bold)
        Label8.ForeColor = SystemColors.Control
        Label8.Location = New Point(28, 484)
        Label8.Margin = New Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(75, 21)
        Label8.TabIndex = 8
        Label8.Text = "Usuario:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Sitka Text", 11.249999F, FontStyle.Bold)
        Label9.ForeColor = SystemColors.Control
        Label9.Location = New Point(272, 395)
        Label9.Margin = New Padding(4, 0, 4, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(67, 21)
        Label9.TabIndex = 7
        Label9.Text = "Estado:"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Sitka Text", 11.249999F, FontStyle.Bold)
        Label10.ForeColor = SystemColors.Control
        Label10.Location = New Point(28, 395)
        Label10.Margin = New Padding(4, 0, 4, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(80, 21)
        Label10.TabIndex = 6
        Label10.Text = "Telefono:"
        ' 
        ' TxtNombres
        ' 
        TxtNombres.BackColor = Color.FromArgb(CByte(91), CByte(30), CByte(80))
        TxtNombres.ForeColor = SystemColors.Control
        TxtNombres.Location = New Point(28, 197)
        TxtNombres.Margin = New Padding(4)
        TxtNombres.Name = "TxtNombres"
        TxtNombres.Size = New Size(380, 26)
        TxtNombres.TabIndex = 10
        ' 
        ' TxtApellidoPaterno
        ' 
        TxtApellidoPaterno.BackColor = Color.FromArgb(CByte(91), CByte(30), CByte(80))
        TxtApellidoPaterno.ForeColor = SystemColors.Control
        TxtApellidoPaterno.Location = New Point(28, 276)
        TxtApellidoPaterno.Margin = New Padding(4)
        TxtApellidoPaterno.Name = "TxtApellidoPaterno"
        TxtApellidoPaterno.Size = New Size(173, 26)
        TxtApellidoPaterno.TabIndex = 11
        ' 
        ' TxtApellidoMaterno
        ' 
        TxtApellidoMaterno.BackColor = Color.FromArgb(CByte(91), CByte(30), CByte(80))
        TxtApellidoMaterno.ForeColor = SystemColors.Control
        TxtApellidoMaterno.Location = New Point(209, 276)
        TxtApellidoMaterno.Margin = New Padding(4)
        TxtApellidoMaterno.Name = "TxtApellidoMaterno"
        TxtApellidoMaterno.Size = New Size(199, 26)
        TxtApellidoMaterno.TabIndex = 12
        ' 
        ' TxtGmail
        ' 
        TxtGmail.BackColor = Color.FromArgb(CByte(91), CByte(30), CByte(80))
        TxtGmail.ForeColor = SystemColors.Control
        TxtGmail.Location = New Point(28, 352)
        TxtGmail.Margin = New Padding(4)
        TxtGmail.Name = "TxtGmail"
        TxtGmail.Size = New Size(230, 26)
        TxtGmail.TabIndex = 13
        ' 
        ' TxtDNI
        ' 
        TxtDNI.BackColor = Color.FromArgb(CByte(91), CByte(30), CByte(80))
        TxtDNI.ForeColor = SystemColors.Control
        TxtDNI.Location = New Point(272, 352)
        TxtDNI.Margin = New Padding(4)
        TxtDNI.Name = "TxtDNI"
        TxtDNI.Size = New Size(136, 26)
        TxtDNI.TabIndex = 14
        ' 
        ' TxtTelefono
        ' 
        TxtTelefono.BackColor = Color.FromArgb(CByte(91), CByte(30), CByte(80))
        TxtTelefono.ForeColor = SystemColors.Control
        TxtTelefono.Location = New Point(28, 435)
        TxtTelefono.Margin = New Padding(4)
        TxtTelefono.Name = "TxtTelefono"
        TxtTelefono.Size = New Size(230, 26)
        TxtTelefono.TabIndex = 15
        ' 
        ' TxtUsuario
        ' 
        TxtUsuario.BackColor = Color.FromArgb(CByte(91), CByte(30), CByte(80))
        TxtUsuario.ForeColor = SystemColors.Control
        TxtUsuario.Location = New Point(28, 519)
        TxtUsuario.Margin = New Padding(4)
        TxtUsuario.Name = "TxtUsuario"
        TxtUsuario.Size = New Size(173, 26)
        TxtUsuario.TabIndex = 16
        ' 
        ' TxtEstado
        ' 
        TxtEstado.BackColor = Color.FromArgb(CByte(91), CByte(30), CByte(80))
        TxtEstado.ForeColor = SystemColors.Control
        TxtEstado.FormattingEnabled = True
        TxtEstado.Items.AddRange(New Object() {"Activo", "No Activo"})
        TxtEstado.Location = New Point(272, 432)
        TxtEstado.Margin = New Padding(4)
        TxtEstado.Name = "TxtEstado"
        TxtEstado.Size = New Size(136, 29)
        TxtEstado.TabIndex = 17
        ' 
        ' CboRol
        ' 
        CboRol.BackColor = Color.FromArgb(CByte(91), CByte(30), CByte(80))
        CboRol.ForeColor = SystemColors.Control
        CboRol.FormattingEnabled = True
        CboRol.Location = New Point(28, 611)
        CboRol.Margin = New Padding(4)
        CboRol.Name = "CboRol"
        CboRol.Size = New Size(380, 29)
        CboRol.TabIndex = 18
        ' 
        ' BtnGuardar
        ' 
        BtnGuardar.BackColor = Color.FromArgb(CByte(91), CByte(30), CByte(80))
        BtnGuardar.ForeColor = SystemColors.Control
        BtnGuardar.Location = New Point(236, 672)
        BtnGuardar.Margin = New Padding(4)
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
        BtnCancelar.Location = New Point(61, 672)
        BtnCancelar.Margin = New Padding(4)
        BtnCancelar.Name = "BtnCancelar"
        BtnCancelar.Size = New Size(140, 45)
        BtnCancelar.TabIndex = 20
        BtnCancelar.Text = "Cancelar"
        BtnCancelar.UseVisualStyleBackColor = False
        ' 
        ' TxtPassword
        ' 
        TxtPassword.BackColor = Color.FromArgb(CByte(91), CByte(30), CByte(80))
        TxtPassword.ForeColor = SystemColors.Control
        TxtPassword.Location = New Point(217, 519)
        TxtPassword.Margin = New Padding(4)
        TxtPassword.Name = "TxtPassword"
        TxtPassword.Size = New Size(191, 26)
        TxtPassword.TabIndex = 22
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Sitka Text", 11.249999F, FontStyle.Bold)
        Label11.ForeColor = SystemColors.Control
        Label11.Location = New Point(217, 484)
        Label11.Margin = New Padding(4, 0, 4, 0)
        Label11.Name = "Label11"
        Label11.Size = New Size(82, 21)
        Label11.TabIndex = 21
        Label11.Text = "Password"
        ' 
        ' TxtIdUsuario
        ' 
        TxtIdUsuario.BackColor = Color.FromArgb(CByte(91), CByte(30), CByte(80))
        TxtIdUsuario.ForeColor = SystemColors.Control
        TxtIdUsuario.Location = New Point(28, 118)
        TxtIdUsuario.Margin = New Padding(4)
        TxtIdUsuario.Name = "TxtIdUsuario"
        TxtIdUsuario.Size = New Size(74, 26)
        TxtIdUsuario.TabIndex = 24
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Sitka Text", 11.249999F, FontStyle.Bold)
        Label12.ForeColor = SystemColors.Control
        Label12.Location = New Point(28, 78)
        Label12.Margin = New Padding(4, 0, 4, 0)
        Label12.Name = "Label12"
        Label12.Size = New Size(90, 21)
        Label12.TabIndex = 23
        Label12.Text = "IdUsuario:"
        ' 
        ' PictureFoto
        ' 
        PictureFoto.BorderStyle = BorderStyle.FixedSingle
        PictureFoto.Location = New Point(157, 78)
        PictureFoto.Margin = New Padding(4)
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
        BtnSeleccionarFoto.Margin = New Padding(4)
        BtnSeleccionarFoto.Name = "BtnSeleccionarFoto"
        BtnSeleccionarFoto.Size = New Size(120, 33)
        BtnSeleccionarFoto.TabIndex = 27
        BtnSeleccionarFoto.Text = "Subir Imagen"
        BtnSeleccionarFoto.UseVisualStyleBackColor = False
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.BackColor = Color.Transparent
        Label13.ForeColor = SystemColors.ControlLight
        Label13.Location = New Point(26, 50)
        Label13.Name = "Label13"
        Label13.Size = New Size(382, 21)
        Label13.TabIndex = 28
        Label13.Text = "--------------------------------------------------------------"
        ' 
        ' FormRegistrarUsuario
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        ClientSize = New Size(438, 755)
        Controls.Add(Label13)
        Controls.Add(BtnSeleccionarFoto)
        Controls.Add(PictureFoto)
        Controls.Add(TxtIdUsuario)
        Controls.Add(Label12)
        Controls.Add(TxtPassword)
        Controls.Add(Label11)
        Controls.Add(BtnCancelar)
        Controls.Add(BtnGuardar)
        Controls.Add(CboRol)
        Controls.Add(TxtEstado)
        Controls.Add(TxtUsuario)
        Controls.Add(TxtTelefono)
        Controls.Add(TxtDNI)
        Controls.Add(TxtGmail)
        Controls.Add(TxtApellidoMaterno)
        Controls.Add(TxtApellidoPaterno)
        Controls.Add(TxtNombres)
        Controls.Add(Label7)
        Controls.Add(Label8)
        Controls.Add(Label9)
        Controls.Add(Label10)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Font = New Font("Sitka Text", 11.249999F, FontStyle.Bold)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4)
        Name = "FormRegistrarUsuario"
        Opacity = 0.95R
        StartPosition = FormStartPosition.CenterParent
        Text = "FormRegistrarUsuario"
        CType(PictureFoto, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtNombres As TextBox
    Friend WithEvents TxtApellidoPaterno As TextBox
    Friend WithEvents TxtApellidoMaterno As TextBox
    Friend WithEvents TxtGmail As TextBox
    Friend WithEvents TxtDNI As TextBox
    Friend WithEvents TxtTelefono As TextBox
    Friend WithEvents TxtUsuario As TextBox
    Friend WithEvents TxtEstado As ComboBox
    Friend WithEvents CboRol As ComboBox
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TxtIdUsuario As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents PictureFoto As PictureBox
    Friend WithEvents BtnSeleccionarFoto As Button
    Friend WithEvents Label13 As Label
End Class
