using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Hermes;

[DesignerGenerated]
public class Form2_Usuario : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ListView1")]
	private ListView _ListView1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button3")]
	private Button _Button3;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button4")]
	private Button _Button4;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button5")]
	private Button _Button5;

	[field: AccessedThroughProperty("StatusStrip1")]
	internal virtual StatusStrip StatusStrip1
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

	[field: AccessedThroughProperty("TextBox1")]
	internal virtual TextBox TextBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox2")]
	internal virtual TextBox TextBox2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ComboBox1")]
	internal virtual ComboBox ComboBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Button2
	{
		[CompilerGenerated]
		get
		{
			return _Button2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button2_Click;
			Button button = _Button2;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button2 = value;
			button = _Button2;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual ListView ListView1
	{
		[CompilerGenerated]
		get
		{
			return _ListView1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			ColumnClickEventHandler value2 = ListView1_ColumnClick;
			EventHandler value3 = ListView1_SelectedIndexChanged;
			ListView listView = _ListView1;
			if (listView != null)
			{
				listView.ColumnClick -= value2;
				listView.SelectedIndexChanged -= value3;
			}
			_ListView1 = value;
			listView = _ListView1;
			if (listView != null)
			{
				listView.ColumnClick += value2;
				listView.SelectedIndexChanged += value3;
			}
		}
	}

	[field: AccessedThroughProperty("Label4")]
	internal virtual Label Label4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label5")]
	internal virtual Label Label5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label6")]
	internal virtual Label Label6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label7")]
	internal virtual Label Label7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Button3
	{
		[CompilerGenerated]
		get
		{
			return _Button3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button3_Click;
			Button button = _Button3;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button3 = value;
			button = _Button3;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button4
	{
		[CompilerGenerated]
		get
		{
			return _Button4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button4_Click;
			Button button = _Button4;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button4 = value;
			button = _Button4;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button5
	{
		[CompilerGenerated]
		get
		{
			return _Button5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button5_Click;
			Button button = _Button5;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button5 = value;
			button = _Button5;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label8")]
	internal virtual Label Label8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public Form2_Usuario()
	{
		base.Load += Form2_Usuario_Load;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hermes.Form2_Usuario));
		this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
		this.Label1 = new System.Windows.Forms.Label();
		this.Label2 = new System.Windows.Forms.Label();
		this.Label3 = new System.Windows.Forms.Label();
		this.TextBox1 = new System.Windows.Forms.TextBox();
		this.TextBox2 = new System.Windows.Forms.TextBox();
		this.ComboBox1 = new System.Windows.Forms.ComboBox();
		this.Button2 = new System.Windows.Forms.Button();
		this.ListView1 = new System.Windows.Forms.ListView();
		this.Label4 = new System.Windows.Forms.Label();
		this.Label5 = new System.Windows.Forms.Label();
		this.Label6 = new System.Windows.Forms.Label();
		this.Label7 = new System.Windows.Forms.Label();
		this.Button3 = new System.Windows.Forms.Button();
		this.Button4 = new System.Windows.Forms.Button();
		this.Button5 = new System.Windows.Forms.Button();
		this.Label8 = new System.Windows.Forms.Label();
		base.SuspendLayout();
		this.StatusStrip1.Location = new System.Drawing.Point(0, 245);
		this.StatusStrip1.Name = "StatusStrip1";
		this.StatusStrip1.Size = new System.Drawing.Size(695, 22);
		this.StatusStrip1.TabIndex = 0;
		this.StatusStrip1.Text = "StatusStrip1";
		this.Label1.AutoSize = true;
		this.Label1.Location = new System.Drawing.Point(12, 78);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(46, 13);
		this.Label1.TabIndex = 1;
		this.Label1.Text = "Usuario:";
		this.Label2.AutoSize = true;
		this.Label2.Location = new System.Drawing.Point(12, 112);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(61, 13);
		this.Label2.TabIndex = 2;
		this.Label2.Text = "Contraseña";
		this.Label3.AutoSize = true;
		this.Label3.Location = new System.Drawing.Point(12, 150);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(52, 13);
		this.Label3.TabIndex = 3;
		this.Label3.Text = "Permisos:";
		this.TextBox1.Location = new System.Drawing.Point(95, 75);
		this.TextBox1.Name = "TextBox1";
		this.TextBox1.Size = new System.Drawing.Size(164, 20);
		this.TextBox1.TabIndex = 4;
		this.TextBox2.Location = new System.Drawing.Point(95, 109);
		this.TextBox2.Name = "TextBox2";
		this.TextBox2.Size = new System.Drawing.Size(164, 20);
		this.TextBox2.TabIndex = 5;
		this.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.ComboBox1.FormattingEnabled = true;
		this.ComboBox1.Items.AddRange(new object[10] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
		this.ComboBox1.Location = new System.Drawing.Point(95, 147);
		this.ComboBox1.Name = "ComboBox1";
		this.ComboBox1.Size = new System.Drawing.Size(67, 21);
		this.ComboBox1.TabIndex = 6;
		this.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
		this.Button2.Image = (System.Drawing.Image)resources.GetObject("Button2.Image");
		this.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.Button2.Location = new System.Drawing.Point(608, 214);
		this.Button2.Name = "Button2";
		this.Button2.Size = new System.Drawing.Size(75, 23);
		this.Button2.TabIndex = 8;
		this.Button2.Text = "Salir";
		this.Button2.UseVisualStyleBackColor = true;
		this.ListView1.FullRowSelect = true;
		this.ListView1.Location = new System.Drawing.Point(281, 12);
		this.ListView1.Name = "ListView1";
		this.ListView1.Size = new System.Drawing.Size(402, 191);
		this.ListView1.TabIndex = 9;
		this.ListView1.UseCompatibleStateImageBehavior = false;
		this.Label4.AutoSize = true;
		this.Label4.Location = new System.Drawing.Point(394, 219);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(13, 13);
		this.Label4.TabIndex = 10;
		this.Label4.Text = "0";
		this.Label5.AutoSize = true;
		this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label5.Location = new System.Drawing.Point(80, 12);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(108, 20);
		this.Label5.TabIndex = 11;
		this.Label5.Text = "USUARIOS:";
		this.Label6.AutoSize = true;
		this.Label6.Location = new System.Drawing.Point(12, 47);
		this.Label6.Name = "Label6";
		this.Label6.Size = new System.Drawing.Size(18, 13);
		this.Label6.TabIndex = 12;
		this.Label6.Text = "id:";
		this.Label7.AutoSize = true;
		this.Label7.Location = new System.Drawing.Point(246, 47);
		this.Label7.Name = "Label7";
		this.Label7.Size = new System.Drawing.Size(13, 13);
		this.Label7.TabIndex = 13;
		this.Label7.Text = "0";
		this.Button3.Image = (System.Drawing.Image)resources.GetObject("Button3.Image");
		this.Button3.Location = new System.Drawing.Point(15, 180);
		this.Button3.Name = "Button3";
		this.Button3.Size = new System.Drawing.Size(75, 57);
		this.Button3.TabIndex = 14;
		this.Button3.UseVisualStyleBackColor = true;
		this.Button4.Image = (System.Drawing.Image)resources.GetObject("Button4.Image");
		this.Button4.Location = new System.Drawing.Point(177, 180);
		this.Button4.Name = "Button4";
		this.Button4.Size = new System.Drawing.Size(75, 57);
		this.Button4.TabIndex = 15;
		this.Button4.UseVisualStyleBackColor = true;
		this.Button5.Image = (System.Drawing.Image)resources.GetObject("Button5.Image");
		this.Button5.Location = new System.Drawing.Point(96, 180);
		this.Button5.Name = "Button5";
		this.Button5.Size = new System.Drawing.Size(75, 57);
		this.Button5.TabIndex = 16;
		this.Button5.UseVisualStyleBackColor = true;
		this.Label8.AutoSize = true;
		this.Label8.Location = new System.Drawing.Point(278, 219);
		this.Label8.Name = "Label8";
		this.Label8.Size = new System.Drawing.Size(110, 13);
		this.Label8.TabIndex = 17;
		this.Label8.Text = "Usuarios Registrados:";
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.CancelButton = this.Button2;
		base.ClientSize = new System.Drawing.Size(695, 267);
		base.Controls.Add(this.Label8);
		base.Controls.Add(this.Button5);
		base.Controls.Add(this.Button4);
		base.Controls.Add(this.Button3);
		base.Controls.Add(this.Label7);
		base.Controls.Add(this.Label6);
		base.Controls.Add(this.Label5);
		base.Controls.Add(this.Label4);
		base.Controls.Add(this.ListView1);
		base.Controls.Add(this.Button2);
		base.Controls.Add(this.ComboBox1);
		base.Controls.Add(this.TextBox2);
		base.Controls.Add(this.TextBox1);
		base.Controls.Add(this.Label3);
		base.Controls.Add(this.Label2);
		base.Controls.Add(this.Label1);
		base.Controls.Add(this.StatusStrip1);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "Form2_Usuario";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Usuarios";
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private void Form2_Usuario_Load(object sender, EventArgs e)
	{
		ComboBox1.SelectedIndex = 0;
		usuarios_();
		if (Operators.CompareString(Label7.Text, "0", TextCompare: true) == 0)
		{
			Button3.Enabled = true;
			Button4.Enabled = false;
			Button5.Enabled = false;
		}
	}

	private void Button3_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(Label7.Text, "0", TextCompare: true) == 0)
		{
			string text = TextBox1.Text;
			string text2 = TextBox2.Text;
			int permiso = Conversions.ToInteger(ComboBox1.Text);
			if (Operators.CompareString(text, "", TextCompare: true) == 0)
			{
				Interaction.MsgBox("Complete los campos");
				TextBox1.BackColor = Color.LimeGreen;
				TextBox1.Focus();
				return;
			}
			if (Operators.CompareString(text2, "", TextCompare: true) == 0)
			{
				Interaction.MsgBox("Complete los campos");
				TextBox2.BackColor = Color.White;
				TextBox2.BackColor = Color.LimeGreen;
				TextBox2.Focus();
				return;
			}
			string text3 = Conversions.ToString(Mod_Usuarios.nuevo_usuario(text, text2, permiso));
			if (Operators.CompareString(text3, "1", TextCompare: true) == 0)
			{
				Interaction.MsgBox("Usuario Creado");
				limpiar_campos();
				default_campos();
				ListView1.Clear();
				usuarios_();
			}
			else
			{
				Interaction.MsgBox(text3);
				limpiar_campos();
				default_campos();
			}
		}
		else
		{
			limpiar_campos();
			resaltar_campos();
			ListView1.Clear();
			usuarios_();
		}
	}

	private void Button5_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(Label7.Text, "0", TextCompare: true) == 0)
		{
			Interaction.MsgBox("No se selecciono registro para Editar");
			return;
		}
		int id_usuario = Conversions.ToInteger(Label7.Text);
		string text = TextBox1.Text;
		string text2 = TextBox2.Text;
		int permiso = Conversions.ToInteger(ComboBox1.Text);
		if (Operators.CompareString(text, "", TextCompare: true) == 0)
		{
			Interaction.MsgBox("Complete los campos");
			TextBox1.BackColor = Color.LimeGreen;
			TextBox1.Focus();
			return;
		}
		if (Operators.CompareString(text2, "", TextCompare: true) == 0)
		{
			Interaction.MsgBox("Complete los campos");
			TextBox2.BackColor = Color.White;
			TextBox2.BackColor = Color.LimeGreen;
			TextBox2.Focus();
			return;
		}
		switch (Conversions.ToInteger(Mod_Usuarios.editar_usuario(id_usuario, text, text2, permiso)))
		{
		case 1:
			Interaction.MsgBox("Usuario Editado");
			limpiar_campos();
			default_campos();
			ListView1.Clear();
			usuarios_();
			break;
		case 2:
			Interaction.MsgBox("Error al Editar Usuario");
			limpiar_campos();
			default_campos();
			break;
		}
	}

	private void Button4_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(Label7.Text, "0", TextCompare: true) == 0)
		{
			Interaction.MsgBox("No se selecciono registro para Borrar");
			return;
		}
		int id_usuario = Conversions.ToInteger(Label7.Text);
		switch (Conversions.ToInteger(Mod_Usuarios.borrar_usuario(id_usuario)))
		{
		case 1:
			Interaction.MsgBox("Usuario Eliminado");
			limpiar_campos();
			default_campos();
			ListView1.Clear();
			usuarios_();
			break;
		case 2:
			Interaction.MsgBox("Error al Eliminar Usuario");
			limpiar_campos();
			default_campos();
			break;
		}
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void limpiar_campos()
	{
		Label7.Text = "0";
		TextBox1.Text = "";
		TextBox2.Text = "";
		ComboBox1.SelectedIndex = 0;
		Button3.Enabled = true;
		Button4.Enabled = false;
		Button5.Enabled = false;
	}

	private void resaltar_campos()
	{
		TextBox1.BackColor = Color.LimeGreen;
		TextBox2.BackColor = Color.LimeGreen;
	}

	private void default_campos()
	{
		TextBox1.BackColor = Color.White;
		TextBox2.BackColor = Color.White;
	}

	private void usuarios_()
	{
		string sql = "select * from usuarios";
		Mod_Sentencias.cargar_datos_lv_completa(ListView1, sql, Label4);
	}

	private void ListView1_ColumnClick(object sender, ColumnClickEventArgs e)
	{
		Mod_Ordenaclumnas.ordenar_columnas(ListView1, RuntimeHelpers.GetObjectValue(sender), e);
	}

	private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
	{
		Selected_item();
	}

	private void Selected_item()
	{
		limpiar_campos();
		default_campos();
		if (ListView1.SelectedItems.Count > 0)
		{
			default_campos();
			int index = ListView1.SelectedIndices[0];
			Label7.Text = ListView1.Items[index].Text;
			TextBox1.Text = ListView1.Items[index].SubItems[1].Text;
			TextBox2.Text = ListView1.Items[index].SubItems[2].Text;
			ComboBox1.Text = ListView1.Items[index].SubItems[3].Text;
			Button3.Enabled = true;
			Button4.Enabled = true;
			Button5.Enabled = true;
		}
		ListView1.Refresh();
	}
}
