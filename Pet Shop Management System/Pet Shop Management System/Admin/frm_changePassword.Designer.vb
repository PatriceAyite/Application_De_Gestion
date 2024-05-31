<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_changePassword
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_changePassword))
        Me.btn_ChangePassword = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_reenterpass = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_oldpass = New System.Windows.Forms.TextBox()
        Me.txt_newpass = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_close = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_ChangePassword
        '
        Me.btn_ChangePassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btn_ChangePassword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_ChangePassword.FlatAppearance.BorderSize = 0
        Me.btn_ChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ChangePassword.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btn_ChangePassword.ForeColor = System.Drawing.Color.White
        Me.btn_ChangePassword.Location = New System.Drawing.Point(440, 450)
        Me.btn_ChangePassword.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btn_ChangePassword.Name = "btn_ChangePassword"
        Me.btn_ChangePassword.Size = New System.Drawing.Size(245, 30)
        Me.btn_ChangePassword.TabIndex = 34
        Me.btn_ChangePassword.Text = "Changer le Mot De Passe"
        Me.btn_ChangePassword.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btn_ChangePassword.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(440, 374)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 20)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Confirmation"
        '
        'txt_reenterpass
        '
        Me.txt_reenterpass.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_reenterpass.Location = New System.Drawing.Point(440, 398)
        Me.txt_reenterpass.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txt_reenterpass.Name = "txt_reenterpass"
        Me.txt_reenterpass.Size = New System.Drawing.Size(433, 31)
        Me.txt_reenterpass.TabIndex = 32
        Me.txt_reenterpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_reenterpass.UseSystemPasswordChar = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(440, 308)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(168, 20)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Nouveau Mot De Passe" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(440, 241)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 20)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Ancien Mot De Passe"
        '
        'txt_oldpass
        '
        Me.txt_oldpass.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_oldpass.Location = New System.Drawing.Point(440, 264)
        Me.txt_oldpass.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txt_oldpass.Name = "txt_oldpass"
        Me.txt_oldpass.Size = New System.Drawing.Size(433, 31)
        Me.txt_oldpass.TabIndex = 28
        Me.txt_oldpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_oldpass.UseSystemPasswordChar = True
        '
        'txt_newpass
        '
        Me.txt_newpass.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_newpass.Location = New System.Drawing.Point(440, 332)
        Me.txt_newpass.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txt_newpass.Name = "txt_newpass"
        Me.txt_newpass.Size = New System.Drawing.Size(433, 31)
        Me.txt_newpass.TabIndex = 29
        Me.txt_newpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_newpass.UseSystemPasswordChar = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(51, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(198, 20)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "GESTION DE MOT DE PASSE"
        '
        'lbl_close
        '
        Me.lbl_close.AutoSize = True
        Me.lbl_close.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_close.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_close.Location = New System.Drawing.Point(1192, 16)
        Me.lbl_close.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_close.Name = "lbl_close"
        Me.lbl_close.Size = New System.Drawing.Size(36, 20)
        Me.lbl_close.TabIndex = 36
        Me.lbl_close.Text = "[ X ]"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-1, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(46, 35)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 37
        Me.PictureBox1.TabStop = False
        '
        'frm_changePassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1258, 779)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lbl_close)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btn_ChangePassword)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_reenterpass)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_oldpass)
        Me.Controls.Add(Me.txt_newpass)
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_changePassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_changePassword"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_ChangePassword As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_reenterpass As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_oldpass As System.Windows.Forms.TextBox
    Friend WithEvents txt_newpass As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lbl_close As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
