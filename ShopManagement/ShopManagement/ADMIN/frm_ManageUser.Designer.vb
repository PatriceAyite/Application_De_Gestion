<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_ManageUser
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
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges13 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges14 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges15 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges16 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Label5 = New Label()
        txt_name = New Guna.UI2.WinForms.Guna2TextBox()
        txt_UserName = New Guna.UI2.WinForms.Guna2TextBox()
        txt_password = New Guna.UI2.WinForms.Guna2TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        cbo_role = New Guna.UI2.WinForms.Guna2ComboBox()
        btn1 = New Guna.UI2.WinForms.Guna2Button()
        btn2 = New Guna.UI2.WinForms.Guna2Button()
        Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Guna2Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Guna2Panel1
        ' 
        Guna2Panel1.BackColor = SystemColors.ActiveCaptionText
        Guna2Panel1.Controls.Add(Guna2ControlBox1)
        Guna2Panel1.Controls.Add(Label5)
        Guna2Panel1.CustomizableEdges = CustomizableEdges3
        Guna2Panel1.Dock = DockStyle.Top
        Guna2Panel1.Location = New Point(0, 0)
        Guna2Panel1.Name = "Guna2Panel1"
        Guna2Panel1.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Guna2Panel1.Size = New Size(742, 46)
        Guna2Panel1.TabIndex = 0
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 10.0173912F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = SystemColors.ButtonHighlight
        Label5.Location = New Point(12, 9)
        Label5.Name = "Label5"
        Label5.Size = New Size(97, 21)
        Label5.TabIndex = 0
        Label5.Text = "Utilisateurs"
        ' 
        ' txt_name
        ' 
        txt_name.CustomizableEdges = CustomizableEdges5
        txt_name.DefaultText = ""
        txt_name.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txt_name.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txt_name.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txt_name.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txt_name.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txt_name.Font = New Font("Segoe UI", 9F)
        txt_name.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txt_name.Location = New Point(184, 113)
        txt_name.Margin = New Padding(3, 4, 3, 4)
        txt_name.Name = "txt_name"
        txt_name.PasswordChar = ChrW(0)
        txt_name.PlaceholderText = ""
        txt_name.SelectedText = ""
        txt_name.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        txt_name.Size = New Size(444, 43)
        txt_name.TabIndex = 1
        ' 
        ' txt_UserName
        ' 
        txt_UserName.CustomizableEdges = CustomizableEdges7
        txt_UserName.DefaultText = ""
        txt_UserName.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txt_UserName.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txt_UserName.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txt_UserName.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txt_UserName.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txt_UserName.Font = New Font("Segoe UI", 9F)
        txt_UserName.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txt_UserName.Location = New Point(184, 190)
        txt_UserName.Margin = New Padding(3, 4, 3, 4)
        txt_UserName.Name = "txt_UserName"
        txt_UserName.PasswordChar = ChrW(0)
        txt_UserName.PlaceholderText = ""
        txt_UserName.SelectedText = ""
        txt_UserName.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        txt_UserName.Size = New Size(444, 43)
        txt_UserName.TabIndex = 2
        ' 
        ' txt_password
        ' 
        txt_password.CustomizableEdges = CustomizableEdges9
        txt_password.DefaultText = ""
        txt_password.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txt_password.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txt_password.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txt_password.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txt_password.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txt_password.Font = New Font("Segoe UI", 9F)
        txt_password.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txt_password.Location = New Point(184, 268)
        txt_password.Margin = New Padding(3, 4, 3, 4)
        txt_password.Name = "txt_password"
        txt_password.PasswordChar = ChrW(0)
        txt_password.PlaceholderText = ""
        txt_password.SelectedText = ""
        txt_password.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        txt_password.Size = New Size(444, 43)
        txt_password.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(80, 124)
        Label1.Name = "Label1"
        Label1.Size = New Size(42, 20)
        Label1.TabIndex = 5
        Label1.Text = "Nom"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(80, 204)
        Label2.Name = "Label2"
        Label2.Size = New Size(57, 20)
        Label2.TabIndex = 6
        Label2.Text = "Pseudo"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(80, 282)
        Label3.Name = "Label3"
        Label3.Size = New Size(98, 20)
        Label3.TabIndex = 7
        Label3.Text = "Mot de passe"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(83, 350)
        Label4.Name = "Label4"
        Label4.Size = New Size(39, 20)
        Label4.TabIndex = 8
        Label4.Text = "Rôle"
        ' 
        ' cbo_role
        ' 
        cbo_role.BackColor = Color.Transparent
        cbo_role.CustomizableEdges = CustomizableEdges11
        cbo_role.DrawMode = DrawMode.OwnerDrawFixed
        cbo_role.DropDownStyle = ComboBoxStyle.DropDownList
        cbo_role.FocusedColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        cbo_role.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        cbo_role.Font = New Font("Segoe UI", 10F)
        cbo_role.ForeColor = Color.FromArgb(CByte(68), CByte(88), CByte(112))
        cbo_role.ItemHeight = 30
        cbo_role.Items.AddRange(New Object() {"ADMIN", "UTILISATEUR"})
        cbo_role.Location = New Point(184, 334)
        cbo_role.Name = "cbo_role"
        cbo_role.ShadowDecoration.CustomizableEdges = CustomizableEdges12
        cbo_role.Size = New Size(444, 36)
        cbo_role.TabIndex = 9
        ' 
        ' btn1
        ' 
        btn1.CustomizableEdges = CustomizableEdges13
        btn1.DisabledState.BorderColor = Color.DarkGray
        btn1.DisabledState.CustomBorderColor = Color.DarkGray
        btn1.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btn1.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btn1.Font = New Font("Segoe UI", 9F)
        btn1.ForeColor = Color.White
        btn1.Location = New Point(184, 398)
        btn1.Name = "btn1"
        btn1.ShadowDecoration.CustomizableEdges = CustomizableEdges14
        btn1.Size = New Size(189, 37)
        btn1.TabIndex = 10
        btn1.Text = "Ajouter"
        ' 
        ' btn2
        ' 
        btn2.CustomizableEdges = CustomizableEdges15
        btn2.DisabledState.BorderColor = Color.DarkGray
        btn2.DisabledState.CustomBorderColor = Color.DarkGray
        btn2.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btn2.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btn2.FillColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        btn2.Font = New Font("Segoe UI", 9F)
        btn2.ForeColor = Color.White
        btn2.Location = New Point(455, 398)
        btn2.Name = "btn2"
        btn2.ShadowDecoration.CustomizableEdges = CustomizableEdges16
        btn2.Size = New Size(173, 37)
        btn2.TabIndex = 11
        btn2.Text = "Annuler"
        ' 
        ' Guna2ControlBox1
        ' 
        Guna2ControlBox1.CustomizableEdges = CustomizableEdges1
        Guna2ControlBox1.Dock = DockStyle.Right
        Guna2ControlBox1.FillColor = Color.FromArgb(CByte(139), CByte(152), CByte(166))
        Guna2ControlBox1.IconColor = Color.White
        Guna2ControlBox1.Location = New Point(688, 0)
        Guna2ControlBox1.Name = "Guna2ControlBox1"
        Guna2ControlBox1.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2ControlBox1.Size = New Size(54, 46)
        Guna2ControlBox1.TabIndex = 1
        ' 
        ' frm_ManageUser
        ' 
        AutoScaleDimensions = New SizeF(8F, 19F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonHighlight
        ClientSize = New Size(742, 471)
        Controls.Add(btn2)
        Controls.Add(btn1)
        Controls.Add(cbo_role)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txt_password)
        Controls.Add(txt_UserName)
        Controls.Add(txt_name)
        Controls.Add(Guna2Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "frm_ManageUser"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        Guna2Panel1.ResumeLayout(False)
        Guna2Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents txt_name As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_UserName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_password As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cbo_role As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents btn1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox

End Class
