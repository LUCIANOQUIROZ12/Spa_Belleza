<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormRegistrarServicio
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
        TxtNombreServicio = New TextBox()
        TxtCosto = New TextBox()
        BtnGuardar = New Button()
        BtnCancelar = New Button()
        Label6 = New Label()
        TxtIdServicio = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("MV Boli", 24.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.Control
        Label1.Location = New Point(145, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(155, 41)
        Label1.TabIndex = 0
        Label1.Text = "Servicios"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Sitka Text", 11.25F, FontStyle.Bold)
        Label2.ForeColor = SystemColors.Control
        Label2.Location = New Point(28, 162)
        Label2.Name = "Label2"
        Label2.Size = New Size(141, 21)
        Label2.TabIndex = 1
        Label2.Text = "Nombre Servicio:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Sitka Text", 11.25F, FontStyle.Bold)
        Label3.ForeColor = SystemColors.Control
        Label3.Location = New Point(28, 236)
        Label3.Name = "Label3"
        Label3.Size = New Size(55, 21)
        Label3.TabIndex = 2
        Label3.Text = "Costo:"
        ' 
        ' TxtNombreServicio
        ' 
        TxtNombreServicio.BackColor = Color.FromArgb(CByte(91), CByte(30), CByte(80))
        TxtNombreServicio.ForeColor = SystemColors.Control
        TxtNombreServicio.Location = New Point(28, 197)
        TxtNombreServicio.Name = "TxtNombreServicio"
        TxtNombreServicio.Size = New Size(380, 26)
        TxtNombreServicio.TabIndex = 10
        ' 
        ' TxtCosto
        ' 
        TxtCosto.BackColor = Color.FromArgb(CByte(91), CByte(30), CByte(80))
        TxtCosto.ForeColor = SystemColors.Control
        TxtCosto.Location = New Point(28, 276)
        TxtCosto.Name = "TxtCosto"
        TxtCosto.Size = New Size(230, 26)
        TxtCosto.TabIndex = 13
        ' 
        ' BtnGuardar
        ' 
        BtnGuardar.BackColor = Color.FromArgb(CByte(91), CByte(30), CByte(80))
        BtnGuardar.ForeColor = SystemColors.Control
        BtnGuardar.Location = New Point(236, 350)
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
        BtnCancelar.Location = New Point(61, 350)
        BtnCancelar.Name = "BtnCancelar"
        BtnCancelar.Size = New Size(140, 45)
        BtnCancelar.TabIndex = 20
        BtnCancelar.Text = "Cancelar"
        BtnCancelar.UseVisualStyleBackColor = False
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
        Label6.Text = "IdServicio:"
        ' 
        ' TxtIdServicio
        ' 
        TxtIdServicio.BackColor = Color.FromArgb(CByte(91), CByte(30), CByte(80))
        TxtIdServicio.ForeColor = SystemColors.Control
        TxtIdServicio.Location = New Point(28, 118)
        TxtIdServicio.Name = "TxtIdServicio"
        TxtIdServicio.ReadOnly = True
        TxtIdServicio.Size = New Size(74, 26)
        TxtIdServicio.TabIndex = 24
        ' 
        ' FormRegistrarServicio
        ' 
        AutoScaleDimensions = New SizeF(9.0F, 21.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        ClientSize = New Size(438, 450)
        Controls.Add(TxtIdServicio)
        Controls.Add(Label6)
        Controls.Add(BtnCancelar)
        Controls.Add(BtnGuardar)
        Controls.Add(TxtCosto)
        Controls.Add(TxtNombreServicio)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Font = New Font("Sitka Text", 11.25F, FontStyle.Bold)
        FormBorderStyle = FormBorderStyle.None
        Name = "FormRegistrarServicio"
        StartPosition = FormStartPosition.CenterParent
        Text = "FormRegistrarServicio"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtNombreServicio As TextBox
    Friend WithEvents TxtCosto As TextBox
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtIdServicio As TextBox
End Class
