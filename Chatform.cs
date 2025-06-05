using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Hermes.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Hermes;

[DesignerGenerated]
public class Chatform : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[field: AccessedThroughProperty("ListView1")]
	internal virtual ListView ListView1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("RichTextBox1")]
	internal virtual RichTextBox RichTextBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Button1
	{
		[CompilerGenerated]
		get
		{
			return _Button1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button1_Click;
			Button button = _Button1;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button1 = value;
			button = _Button1;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("comentario")]
	internal virtual ColumnHeader comentario
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("usuario")]
	internal virtual ColumnHeader usuario
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("fecha")]
	internal virtual ColumnHeader fecha
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public Chatform()
	{
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
		this.ListView1 = new System.Windows.Forms.ListView();
		this.RichTextBox1 = new System.Windows.Forms.RichTextBox();
		this.Button1 = new System.Windows.Forms.Button();
		this.Label1 = new System.Windows.Forms.Label();
		this.comentario = new System.Windows.Forms.ColumnHeader();
		this.usuario = new System.Windows.Forms.ColumnHeader();
		this.fecha = new System.Windows.Forms.ColumnHeader();
		base.SuspendLayout();
		this.ListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[3] { this.comentario, this.usuario, this.fecha });
		this.ListView1.Location = new System.Drawing.Point(12, 12);
		this.ListView1.Name = "ListView1";
		this.ListView1.Size = new System.Drawing.Size(351, 398);
		this.ListView1.TabIndex = 0;
		this.ListView1.UseCompatibleStateImageBehavior = false;
		this.RichTextBox1.Location = new System.Drawing.Point(12, 416);
		this.RichTextBox1.Name = "RichTextBox1";
		this.RichTextBox1.Size = new System.Drawing.Size(233, 27);
		this.RichTextBox1.TabIndex = 1;
		this.RichTextBox1.Text = "";
		this.Button1.Location = new System.Drawing.Point(261, 416);
		this.Button1.Name = "Button1";
		this.Button1.Size = new System.Drawing.Size(102, 27);
		this.Button1.TabIndex = 2;
		this.Button1.Text = "Enviar";
		this.Button1.UseVisualStyleBackColor = true;
		this.Label1.AutoSize = true;
		this.Label1.Location = new System.Drawing.Point(258, 456);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(39, 13);
		this.Label1.TabIndex = 3;
		this.Label1.Text = "Label1";
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(375, 478);
		base.Controls.Add(this.Label1);
		base.Controls.Add(this.Button1);
		base.Controls.Add(this.RichTextBox1);
		base.Controls.Add(this.ListView1);
		base.Name = "Chatform";
		this.Text = "Chat";
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		string text = Strings.Format(DateAndTime.Now, "yyyy-mm-dd HH:MM:ss");
		string sQL = "Insert into chat (comentario,usuario) values ('" + RichTextBox1.Text + "', '" + MySettingsProperty.Settings.Usuario + "')";
		Mod_ConeccionBD.BD_Sentencia(sQL);
		string sql = "Select * from chat";
		Mod_Sentencias.cargar_datos_lv(ListView1, sql, Label1);
	}
}
