<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        PanelLogo = New Panel()
        PanelLogin = New Panel()
        LinkLabel1 = New LinkLabel()
        txtPassword = New TextBox()
        IngresarLogin = New Button()
        Label4 = New Label()
        txtUsuario = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        PanelLogin.SuspendLayout()
        SuspendLayout()
        ' 
        ' PanelLogo
        ' 
        PanelLogo.BackColor = Color.Transparent
        PanelLogo.BackgroundImage = My.Resources.Resources.loguito
        PanelLogo.Location = New Point(1098, 12)
        PanelLogo.Name = "PanelLogo"
        PanelLogo.Size = New Size(154, 136)
        PanelLogo.TabIndex = 0
        ' 
        ' PanelLogin
        ' 
        PanelLogin.BackColor = SystemColors.Desktop
        PanelLogin.Controls.Add(LinkLabel1)
        PanelLogin.Controls.Add(txtPassword)
        PanelLogin.Controls.Add(IngresarLogin)
        PanelLogin.Controls.Add(Label4)
        PanelLogin.Controls.Add(txtUsuario)
        PanelLogin.Controls.Add(Label3)
        PanelLogin.Controls.Add(Label2)
        PanelLogin.Controls.Add(Label1)
        PanelLogin.Location = New Point(458, 200)
        PanelLogin.Name = "PanelLogin"
        PanelLogin.Size = New Size(388, 493)
        PanelLogin.TabIndex = 1
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.ActiveLinkColor = Color.DarkMagenta
        LinkLabel1.AutoSize = True
        LinkLabel1.BackColor = Color.Transparent
        LinkLabel1.LinkColor = Color.White
        LinkLabel1.Location = New Point(137, 401)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(127, 15)
        LinkLabel1.TabIndex = 7
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Forgot your Password?"
        ' 
        ' txtPassword
        ' 
        txtPassword.BackColor = Color.FromArgb(CByte(54), CByte(18), CByte(48))
        txtPassword.ForeColor = SystemColors.Window
        txtPassword.Location = New Point(32, 285)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(310, 23)
        txtPassword.TabIndex = 6
        ' 
        ' IngresarLogin
        ' 
        IngresarLogin.BackColor = Color.FromArgb(CByte(227), CByte(118), CByte(208))
        IngresarLogin.Font = New Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        IngresarLogin.ForeColor = SystemColors.Control
        IngresarLogin.Location = New Point(137, 345)
        IngresarLogin.Name = "IngresarLogin"
        IngresarLogin.Size = New Size(122, 31)
        IngresarLogin.TabIndex = 5
        IngresarLogin.Text = "Ingresar"
        IngresarLogin.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Sitka Text", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.Control
        Label4.Location = New Point(32, 225)
        Label4.Name = "Label4"
        Label4.Size = New Size(110, 28)
        Label4.TabIndex = 4
        Label4.Text = "Password:"
        ' 
        ' txtUsuario
        ' 
        txtUsuario.BackColor = Color.FromArgb(CByte(54), CByte(18), CByte(48))
        txtUsuario.ForeColor = SystemColors.Window
        txtUsuario.Location = New Point(32, 177)
        txtUsuario.Name = "txtUsuario"
        txtUsuario.Size = New Size(310, 23)
        txtUsuario.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Sitka Text", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.Control
        Label3.Location = New Point(32, 125)
        Label3.Name = "Label3"
        Label3.Size = New Size(98, 28)
        Label3.TabIndex = 2
        Label3.Text = "Usuario: "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ControlLightLight
        Label2.Location = New Point(32, 71)
        Label2.Name = "Label2"
        Label2.Size = New Size(323, 17)
        Label2.TabIndex = 1
        Label2.Text = "---------------------------------------------------------------"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Transparent
        Label1.Location = New Point(116, 30)
        Label1.Name = "Label1"
        Label1.Size = New Size(170, 29)
        Label1.TabIndex = 0
        Label1.Text = "BIENVENIDO"
        ' 
        ' FrmLogin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.HighlightText
        BackgroundImage = My.Resources.Resources.fondo_spa
        ClientSize = New Size(1264, 761)
        Controls.Add(PanelLogin)
        Controls.Add(PanelLogo)
        MaximizeBox = False
        Name = "FrmLogin"
        StartPosition = FormStartPosition.CenterParent
        Text = "Login"
        PanelLogin.ResumeLayout(False)
        PanelLogin.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PanelLogo As Panel
    Friend WithEvents PanelLogin As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents IngresarLogin As Button
    Friend WithEvents LinkLabel1 As LinkLabel

End Class
