using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Hermes;

[DesignerGenerated]
public class EstadosConfig : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ListView1")]
	private ListView _ListView1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button2")]
	private Button _Button2;

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

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
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

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
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

	[field: AccessedThroughProperty("Label4")]
	internal virtual Label Label4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ColumnHeader2")]
	internal virtual ColumnHeader ColumnHeader2
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

	[field: AccessedThroughProperty("ColumnHeader3")]
	internal virtual ColumnHeader ColumnHeader3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("RadioButton1")]
	internal virtual RadioButton RadioButton1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("RadioButton2")]
	internal virtual RadioButton RadioButton2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ColumnHeader4")]
	internal virtual ColumnHeader ColumnHeader4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("RadioButton3")]
	internal virtual RadioButton RadioButton3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public EstadosConfig()
	{
		base.Load += EstadosConfig_Load;
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
		this.ColumnHeader3 = new System.Windows.Forms.ColumnHeader();
		this.ColumnHeader2 = new System.Windows.Forms.ColumnHeader();
		this.ColumnHeader4 = new System.Windows.Forms.ColumnHeader();
		this.Label1 = new System.Windows.Forms.Label();
		this.Button1 = new System.Windows.Forms.Button();
		this.Button2 = new System.Windows.Forms.Button();
		this.Label3 = new System.Windows.Forms.Label();
		this.TextBox2 = new System.Windows.Forms.TextBox();
		this.Label4 = new System.Windows.Forms.Label();
		this.Label5 = new System.Windows.Forms.Label();
		this.RadioButton1 = new System.Windows.Forms.RadioButton();
		this.RadioButton2 = new System.Windows.Forms.RadioButton();
		this.RadioButton3 = new System.Windows.Forms.RadioButton();
		base.SuspendLayout();
		this.ListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[3] { this.ColumnHeader3, this.ColumnHeader2, this.ColumnHeader4 });
		this.ListView1.FullRowSelect = true;
		this.ListView1.GridLines = true;
		this.ListView1.Location = new System.Drawing.Point(12, 120);
		this.ListView1.Name = "ListView1";
		this.ListView1.Size = new System.Drawing.Size(258, 193);
		this.ListView1.TabIndex = 0;
		this.ListView1.UseCompatibleStateImageBehavior = false;
		this.ListView1.View = System.Windows.Forms.View.Details;
		this.ColumnHeader3.Text = "ID";
		this.ColumnHeader3.Width = 40;
		this.ColumnHeader2.Text = "Comentario";
		this.ColumnHeader2.Width = 154;
		this.ColumnHeader4.Text = "Motivo";
		this.Label1.AutoSize = true;
		this.Label1.Location = new System.Drawing.Point(12, 104);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(90, 13);
		this.Label1.TabIndex = 1;
		this.Label1.Text = "Estados Creados:";
		this.Button1.Location = new System.Drawing.Point(12, 319);
		this.Button1.Name = "Button1";
		this.Button1.Size = new System.Drawing.Size(75, 23);
		this.Button1.TabIndex = 2;
		this.Button1.Text = "Crear";
		this.Button1.UseVisualStyleBackColor = true;
		this.Button2.Location = new System.Drawing.Point(195, 319);
		this.Button2.Name = "Button2";
		this.Button2.Size = new System.Drawing.Size(75, 23);
		this.Button2.TabIndex = 3;
		this.Button2.Text = "Borrar";
		this.Button2.UseVisualStyleBackColor = true;
		this.Label3.AutoSize = true;
		this.Label3.Location = new System.Drawing.Point(12, 51);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(63, 13);
		this.Label3.TabIndex = 6;
		this.Label3.Text = "Comentario:";
		this.TextBox2.Location = new System.Drawing.Point(12, 67);
		this.TextBox2.Name = "TextBox2";
		this.TextBox2.Size = new System.Drawing.Size(258, 20);
		this.TextBox2.TabIndex = 7;
		this.Label4.AutoSize = true;
		this.Label4.Location = new System.Drawing.Point(108, 104);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(13, 13);
		this.Label4.TabIndex = 8;
		this.Label4.Text = "0";
		this.Label5.AutoSize = true;
		this.Label5.Location = new System.Drawing.Point(231, 51);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(39, 13);
		this.Label5.TabIndex = 9;
		this.Label5.Text = "Label5";
		this.Label5.Visible = false;
		this.RadioButton1.AutoSize = true;
		this.RadioButton1.Checked = true;
		this.RadioButton1.Location = new System.Drawing.Point(12, 21);
		this.RadioButton1.Name = "RadioButton1";
		this.RadioButton1.Size = new System.Drawing.Size(62, 17);
		this.RadioButton1.TabIndex = 10;
		this.RadioButton1.TabStop = true;
		this.RadioButton1.Text = "Entrega";
		this.RadioButton1.UseVisualStyleBackColor = true;
		this.RadioButton2.AutoSize = true;
		this.RadioButton2.Location = new System.Drawing.Point(191, 21);
		this.RadioButton2.Name = "RadioButton2";
		this.RadioButton2.Size = new System.Drawing.Size(79, 17);
		this.RadioButton2.TabIndex = 11;
		this.RadioButton2.TabStop = true;
		this.RadioButton2.Text = "No Entrega";
		this.RadioButton2.UseVisualStyleBackColor = true;
		this.RadioButton3.AutoSize = true;
		this.RadioButton3.Location = new System.Drawing.Point(111, 21);
		this.RadioButton3.Name = "RadioButton3";
		this.RadioButton3.Size = new System.Drawing.Size(57, 17);
		this.RadioButton3.TabIndex = 12;
		this.RadioButton3.TabStop = true;
		this.RadioButton3.Text = "Parcial";
		this.RadioButton3.UseVisualStyleBackColor = true;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(281, 354);
		base.Controls.Add(this.RadioButton3);
		base.Controls.Add(this.RadioButton2);
		base.Controls.Add(this.RadioButton1);
		base.Controls.Add(this.Label5);
		base.Controls.Add(this.Label4);
		base.Controls.Add(this.TextBox2);
		base.Controls.Add(this.Label3);
		base.Controls.Add(this.Button2);
		base.Controls.Add(this.Button1);
		base.Controls.Add(this.Label1);
		base.Controls.Add(this.ListView1);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
		base.Name = "EstadosConfig";
		this.Text = "Estados";
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private void EstadosConfig_Load(object sender, EventArgs e)
	{
		string sql = "Select Id,Comentario,motivo From Estados";
		Mod_Sentencias.cargar_datos_lv(ListView1, sql, Label4);
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		int num = 0;
		if (RadioButton1.Checked)
		{
			num = 0;
		}
		if (RadioButton2.Checked)
		{
			num = 1;
		}
		if (RadioButton3.Checked)
		{
			num = 2;
		}
		string sQL = "INSERT INTO Estados (Comentario,Motivo) Values ('" + TextBox2.Text + "'," + Conversions.ToString(num) + ")";
		Mod_ConeccionBD.BD_Sentencia(sQL);
		ListView1.Items.Clear();
		string sql = "Select Id,Comentario,motivo From Estados";
		Mod_Sentencias.cargar_datos_lv(ListView1, sql, Label4);
		TextBox2.Text = "";
		RadioButton1.Checked = true;
	}

	private void Selected_item()
	{
		if (ListView1.SelectedItems.Count > 0)
		{
			int index = ListView1.SelectedIndices[0];
			Label5.Text = ListView1.Items[index].Text;
		}
		ListView1.Refresh();
	}

	private void ListView1_ColumnClick(object sender, ColumnClickEventArgs e)
	{
		Mod_Ordenaclumnas.ordenar_columnas(ListView1, RuntimeHelpers.GetObjectValue(sender), e);
	}

	private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
	{
		Selected_item();
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		string sQL = ("Delete From Estados Where id= " + Label5.Text) ?? "";
		Mod_ConeccionBD.BD_Sentencia(sQL);
		ListView1.Items.Clear();
		string sql = "Select Id,Comentario,motivo From Estados";
		Mod_Sentencias.cargar_datos_lv(ListView1, sql, Label4);
		Label5.Text = "";
	}
}
