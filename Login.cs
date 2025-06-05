using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Hermes.My;
using Hermes.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace Hermes;

[DesignerGenerated]
public class Login : Form
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("OK")]
	private Button _OK;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Cancel")]
	private Button _Cancel;

	private IContainer components;

	[field: AccessedThroughProperty("LogoPictureBox")]
	internal virtual PictureBox LogoPictureBox
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("UsernameLabel")]
	internal virtual Label UsernameLabel
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PasswordLabel")]
	internal virtual Label PasswordLabel
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("UsernameTextBox")]
	internal virtual TextBox UsernameTextBox
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PasswordTextBox")]
	internal virtual TextBox PasswordTextBox
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button OK
	{
		[CompilerGenerated]
		get
		{
			return _OK;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = OK_Click;
			Button oK = _OK;
			if (oK != null)
			{
				oK.Click -= value2;
			}
			_OK = value;
			oK = _OK;
			if (oK != null)
			{
				oK.Click += value2;
			}
		}
	}

	internal virtual Button Cancel
	{
		[CompilerGenerated]
		get
		{
			return _Cancel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Cancel_Click;
			Button cancel = _Cancel;
			if (cancel != null)
			{
				cancel.Click -= value2;
			}
			_Cancel = value;
			cancel = _Cancel;
			if (cancel != null)
			{
				cancel.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public Login()
	{
		base.Load += Login_Load;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hermes.Login));
		this.LogoPictureBox = new System.Windows.Forms.PictureBox();
		this.UsernameLabel = new System.Windows.Forms.Label();
		this.PasswordLabel = new System.Windows.Forms.Label();
		this.UsernameTextBox = new System.Windows.Forms.TextBox();
		this.PasswordTextBox = new System.Windows.Forms.TextBox();
		this.OK = new System.Windows.Forms.Button();
		this.Cancel = new System.Windows.Forms.Button();
		this.Label1 = new System.Windows.Forms.Label();
		((System.ComponentModel.ISupportInitialize)this.LogoPictureBox).BeginInit();
		base.SuspendLayout();
		this.LogoPictureBox.Image = Hermes.My.Resources.Resources.Logo_hermes_31;
		this.LogoPictureBox.Location = new System.Drawing.Point(1, 0);
		this.LogoPictureBox.Name = "LogoPictureBox";
		this.LogoPictureBox.Size = new System.Drawing.Size(247, 124);
		this.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.LogoPictureBox.TabIndex = 0;
		this.LogoPictureBox.TabStop = false;
		this.UsernameLabel.BackColor = System.Drawing.Color.Transparent;
		this.UsernameLabel.Location = new System.Drawing.Point(12, 104);
		this.UsernameLabel.Name = "UsernameLabel";
		this.UsernameLabel.Size = new System.Drawing.Size(199, 23);
		this.UsernameLabel.TabIndex = 0;
		this.UsernameLabel.Text = "Usuario";
		this.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.PasswordLabel.BackColor = System.Drawing.Color.Transparent;
		this.PasswordLabel.Location = new System.Drawing.Point(11, 153);
		this.PasswordLabel.Name = "PasswordLabel";
		this.PasswordLabel.Size = new System.Drawing.Size(188, 23);
		this.PasswordLabel.TabIndex = 2;
		this.PasswordLabel.Text = "Contraseña";
		this.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.UsernameTextBox.Location = new System.Drawing.Point(14, 130);
		this.UsernameTextBox.Name = "UsernameTextBox";
		this.UsernameTextBox.Size = new System.Drawing.Size(220, 20);
		this.UsernameTextBox.TabIndex = 1;
		this.PasswordTextBox.Location = new System.Drawing.Point(14, 179);
		this.PasswordTextBox.Name = "PasswordTextBox";
		this.PasswordTextBox.PasswordChar = '*';
		this.PasswordTextBox.Size = new System.Drawing.Size(220, 20);
		this.PasswordTextBox.TabIndex = 3;
		this.OK.Location = new System.Drawing.Point(14, 215);
		this.OK.Name = "OK";
		this.OK.Size = new System.Drawing.Size(94, 23);
		this.OK.TabIndex = 4;
		this.OK.Text = "&OK";
		this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
		this.Cancel.Location = new System.Drawing.Point(140, 215);
		this.Cancel.Name = "Cancel";
		this.Cancel.Size = new System.Drawing.Size(94, 23);
		this.Cancel.TabIndex = 5;
		this.Cancel.Text = "&Cancel";
		this.Label1.AutoSize = true;
		this.Label1.Location = new System.Drawing.Point(88, 24);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(39, 13);
		this.Label1.TabIndex = 6;
		this.Label1.Text = "Label1";
		base.AcceptButton = this.OK;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.CancelButton = this.Cancel;
		base.ClientSize = new System.Drawing.Size(248, 250);
		base.ControlBox = false;
		base.Controls.Add(this.Label1);
		base.Controls.Add(this.Cancel);
		base.Controls.Add(this.OK);
		base.Controls.Add(this.PasswordTextBox);
		base.Controls.Add(this.UsernameTextBox);
		base.Controls.Add(this.PasswordLabel);
		base.Controls.Add(this.UsernameLabel);
		base.Controls.Add(this.LogoPictureBox);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "Login";
		base.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = " Bienvenido";
		((System.ComponentModel.ISupportInitialize)this.LogoPictureBox).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private void OK_Click(object sender, EventArgs e)
	{
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected O, but got Unknown
		Cursor = Cursors.WaitCursor;
		DateTime now = DateAndTime.Now;
		if ((Operators.CompareString(UsernameTextBox.Text, MySettingsProperty.Settings.Admin, TextCompare: true) == 0) & (Operators.CompareString(PasswordTextBox.Text, MySettingsProperty.Settings.Password, TextCompare: true) == 0))
		{
			MyProject.Forms.Form1_Inicio.nombreusuario.Text = "Admin";
			MySettingsProperty.Settings.Permiso = Conversions.ToString(99);
			MyProject.Forms.Form1_Inicio.WindowState = FormWindowState.Maximized;
			Close();
		}
		else
		{
			try
			{
				string text = "SELECT Usuario,Password,Permiso FROM Usuarios WHERE Usuario='" + UsernameTextBox.Text + "' and Password= '" + PasswordTextBox.Text + "'";
				DataTable dataTable = new DataTable("x");
				MySqlDataAdapter val = new MySqlDataAdapter(text, Mod_Sentencias.cnn);
				DataSet dataSet = new DataSet();
				((DbDataAdapter)(object)val).Fill(dataTable);
				if (dataTable.Rows.Count > 0)
				{
					MySettingsProperty.Settings.Usuario = Conversions.ToString(dataTable.Rows[0]["usuario"]);
					MySettingsProperty.Settings.Permiso = Conversions.ToString(dataTable.Rows[0]["permiso"]);
					MyProject.Forms.Form1_Inicio.nombreusuario.Text = MySettingsProperty.Settings.Usuario;
					MyProject.Forms.Form1_Inicio.WindowState = FormWindowState.Maximized;
					Close();
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Interaction.MsgBox("Error: Usuario incorrecto o Problema en la conexion.");
				Logger.e("Error: " + ex2.Message);
				ProjectData.ClearProjectError();
			}
		}
		Cursor = Cursors.Default;
		Logger.i("Ingreso: " + Conversions.ToString(now) + " Usuario: " + MySettingsProperty.Settings.Usuario);
	}

	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	private void Cancel_Click(object sender, EventArgs e)
	{
		ProjectData.EndApp();
	}

	private void Login_Load(object sender, EventArgs e)
	{
		Mod_Update.UpdateHermes();
		if (Operators.CompareString(Mod_Sentencias.baseDD, "hermesDev", TextCompare: true) == 0)
		{
			Label1.Visible = true;
			Label1.Text = "DESARROLLO";
		}
		else
		{
			Label1.Visible = false;
		}
	}
}
