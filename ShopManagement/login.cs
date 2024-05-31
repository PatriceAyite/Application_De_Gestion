using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Enums;
using Guna.UI2.WinForms.Suite;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;
using ShopManagement.My;
using ShopManagement.My.Resources;

namespace ShopManagement;

[DesignerGenerated]
public class login : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Guna2Button1")]
	private Guna2Button _Guna2Button1;

	[field: AccessedThroughProperty("txtUsername")]
	internal virtual Guna2TextBox txtUsername
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtPassword")]
	internal virtual Guna2TextBox txtPassword
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Guna2Button Guna2Button1
	{
		[CompilerGenerated]
		get
		{
			return _Guna2Button1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Guna2Button1_Click;
			Guna2Button guna2Button = _Guna2Button1;
			if (guna2Button != null)
			{
				guna2Button.Click -= value2;
			}
			_Guna2Button1 = value;
			guna2Button = _Guna2Button1;
			if (guna2Button != null)
			{
				guna2Button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Guna2CirclePictureBox1")]
	internal virtual Guna2CirclePictureBox Guna2CirclePictureBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public login()
	{
		base.Load += login_Load;
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			base.Dispose(disposing);
		}
	}

	[System.Diagnostics.DebuggerStepThrough]
	private void InitializeComponent()
	{
		Guna.UI2.WinForms.Suite.CustomizableEdges CustomizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
		Guna.UI2.WinForms.Suite.CustomizableEdges CustomizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
		Guna.UI2.WinForms.Suite.CustomizableEdges CustomizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
		Guna.UI2.WinForms.Suite.CustomizableEdges CustomizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
		Guna.UI2.WinForms.Suite.CustomizableEdges CustomizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
		Guna.UI2.WinForms.Suite.CustomizableEdges CustomizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
		Guna.UI2.WinForms.Suite.CustomizableEdges CustomizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
		this.txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
		this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
		this.Guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
		this.Guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
		this.Label1 = new System.Windows.Forms.Label();
		this.Label2 = new System.Windows.Forms.Label();
		this.Label3 = new System.Windows.Forms.Label();
		((System.ComponentModel.ISupportInitialize)this.Guna2CirclePictureBox1).BeginInit();
		base.SuspendLayout();
		this.txtUsername.CustomizableEdges = CustomizableEdges1;
		this.txtUsername.DefaultText = "";
		this.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(208, 208, 208);
		this.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(226, 226, 226);
		this.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
		this.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
		this.txtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
		this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 9f);
		this.txtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
		this.txtUsername.Location = new System.Drawing.Point(697, 185);
		this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.txtUsername.Name = "txtUsername";
		this.txtUsername.PasswordChar = '\0';
		this.txtUsername.PlaceholderText = "";
		this.txtUsername.SelectedText = "";
		this.txtUsername.ShadowDecoration.CustomizableEdges = CustomizableEdges2;
		this.txtUsername.Size = new System.Drawing.Size(341, 45);
		this.txtUsername.TabIndex = 0;
		this.txtPassword.CustomizableEdges = CustomizableEdges3;
		this.txtPassword.DefaultText = "";
		this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(208, 208, 208);
		this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(226, 226, 226);
		this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
		this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
		this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
		this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9f);
		this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
		this.txtPassword.Location = new System.Drawing.Point(697, 269);
		this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.txtPassword.Name = "txtPassword";
		this.txtPassword.PasswordChar = '\0';
		this.txtPassword.PlaceholderText = "";
		this.txtPassword.SelectedText = "";
		this.txtPassword.ShadowDecoration.CustomizableEdges = CustomizableEdges4;
		this.txtPassword.Size = new System.Drawing.Size(341, 45);
		this.txtPassword.TabIndex = 1;
		this.Guna2Button1.CustomizableEdges = CustomizableEdges5;
		this.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
		this.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
		this.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
		this.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
		this.Guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9f);
		this.Guna2Button1.ForeColor = System.Drawing.Color.White;
		this.Guna2Button1.Location = new System.Drawing.Point(697, 343);
		this.Guna2Button1.Name = "Guna2Button1";
		this.Guna2Button1.ShadowDecoration.CustomizableEdges = CustomizableEdges6;
		this.Guna2Button1.Size = new System.Drawing.Size(341, 44);
		this.Guna2Button1.TabIndex = 2;
		this.Guna2Button1.Text = "&Se Connecter";
		this.Guna2CirclePictureBox1.Image = ShopManagement.My.Resources.Resources.livre5;
		this.Guna2CirclePictureBox1.ImageRotate = 0f;
		this.Guna2CirclePictureBox1.Location = new System.Drawing.Point(-155, -146);
		this.Guna2CirclePictureBox1.Name = "Guna2CirclePictureBox1";
		this.Guna2CirclePictureBox1.ShadowDecoration.CustomizableEdges = CustomizableEdges7;
		this.Guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
		this.Guna2CirclePictureBox1.Size = new System.Drawing.Size(717, 847);
		this.Guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
		this.Guna2CirclePictureBox1.TabIndex = 3;
		this.Guna2CirclePictureBox1.TabStop = false;
		this.Label1.AutoSize = true;
		this.Label1.Font = new System.Drawing.Font("Segoe UI", 18.1565228f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label1.ForeColor = System.Drawing.Color.FromArgb(94, 148, 255);
		this.Label1.Location = new System.Drawing.Point(777, 113);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(182, 40);
		this.Label1.TabIndex = 4;
		this.Label1.Text = "&Connexion !";
		this.Label2.AutoSize = true;
		this.Label2.Location = new System.Drawing.Point(697, 161);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(57, 20);
		this.Label2.TabIndex = 5;
		this.Label2.Text = "Pseudo";
		this.Label3.AutoSize = true;
		this.Label3.Location = new System.Drawing.Point(697, 245);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(98, 20);
		this.Label3.TabIndex = 6;
		this.Label3.Text = "Mot De Passe";
		base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 19f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
		base.ClientSize = new System.Drawing.Size(1182, 595);
		base.Controls.Add(this.Label3);
		base.Controls.Add(this.Label2);
		base.Controls.Add(this.Label1);
		base.Controls.Add(this.Guna2CirclePictureBox1);
		base.Controls.Add(this.Guna2Button1);
		base.Controls.Add(this.txtPassword);
		base.Controls.Add(this.txtUsername);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "login";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "login";
		((System.ComponentModel.ISupportInitialize)this.Guna2CirclePictureBox1).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private void login_Load(object sender, EventArgs e)
	{
		dbconnexion.dbconn();
	}

	private void Guna2Button1_Click(object sender, EventArgs e)
	{
		string connectionString = "server=localhost;user=root;password=;port=3306;database=book_db";
		string username = txtUsername.Text;
		string password = txtPassword.Text;
		using MySqlConnection conn = new MySqlConnection(connectionString);
		conn.Open();
		string query = "SELECT role FROM tbluser WHERE username = @username AND password = @password";
		MySqlCommand cmd = new MySqlCommand(query, conn);
		cmd.Parameters.AddWithValue("@username", username);
		cmd.Parameters.AddWithValue("@password", password);
		string role = Convert.ToString(RuntimeHelpers.GetObjectValue(cmd.ExecuteScalar()));
		if (!string.IsNullOrEmpty(role))
		{
			if (Operators.CompareString(role.ToUpper(), "ADMIN", TextCompare: false) == 0)
			{
				Hide();
				MyProject.Forms.frm_AdminMain.ShowDialog();
			}
			else if (Operators.CompareString(role.ToUpper(), "UTILISATEUR", TextCompare: false) == 0)
			{
				Hide();
				MyProject.Forms.frm_UserMain.ShowDialog();
				MyProject.Forms.frm_UserMain.lbl_userinfo.Text = "Login User : " + dbconnexion.dr["name"].ToString() + "Login Time : " + DateTime.Now.ToString("hh:mm:ss tt");
			}
			else
			{
				MessageBox.Show("Rôle d'utilisateur non reconnu.", "Erreur de connexion", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}
		else
		{
			MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect.", "Erreur de connexion", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}
	}
}
