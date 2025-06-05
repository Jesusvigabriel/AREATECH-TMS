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
public class Feriados : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ListView1")]
	private ListView _ListView1;

	private string sql;

	[field: AccessedThroughProperty("DateTimePicker1")]
	internal virtual DateTimePicker DateTimePicker1
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
			EventHandler value2 = ListView1_SelectedIndexChanged;
			ListView listView = _ListView1;
			if (listView != null)
			{
				listView.SelectedIndexChanged -= value2;
			}
			_ListView1 = value;
			listView = _ListView1;
			if (listView != null)
			{
				listView.SelectedIndexChanged += value2;
			}
		}
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

	[field: AccessedThroughProperty("Label8")]
	internal virtual Label Label8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label9")]
	internal virtual Label Label9
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label10")]
	internal virtual Label Label10
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public Feriados()
	{
		base.Load += Feriados_Load;
		sql = "Select id, fecha, descripcion , usuario FROM feriados";
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
		this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
		this.TextBox1 = new System.Windows.Forms.TextBox();
		this.Button1 = new System.Windows.Forms.Button();
		this.Button2 = new System.Windows.Forms.Button();
		this.ListView1 = new System.Windows.Forms.ListView();
		this.Label1 = new System.Windows.Forms.Label();
		this.Label2 = new System.Windows.Forms.Label();
		this.Label3 = new System.Windows.Forms.Label();
		this.Label4 = new System.Windows.Forms.Label();
		this.Label5 = new System.Windows.Forms.Label();
		this.Label6 = new System.Windows.Forms.Label();
		this.Label7 = new System.Windows.Forms.Label();
		this.Label8 = new System.Windows.Forms.Label();
		this.Label9 = new System.Windows.Forms.Label();
		this.Label10 = new System.Windows.Forms.Label();
		base.SuspendLayout();
		this.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
		this.DateTimePicker1.Location = new System.Drawing.Point(26, 41);
		this.DateTimePicker1.Name = "DateTimePicker1";
		this.DateTimePicker1.Size = new System.Drawing.Size(97, 20);
		this.DateTimePicker1.TabIndex = 0;
		this.TextBox1.Location = new System.Drawing.Point(26, 67);
		this.TextBox1.Name = "TextBox1";
		this.TextBox1.Size = new System.Drawing.Size(262, 20);
		this.TextBox1.TabIndex = 1;
		this.Button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.Button1.Location = new System.Drawing.Point(26, 371);
		this.Button1.Name = "Button1";
		this.Button1.Size = new System.Drawing.Size(75, 23);
		this.Button1.TabIndex = 2;
		this.Button1.Text = "Guardar";
		this.Button1.UseVisualStyleBackColor = true;
		this.Button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.Button2.Location = new System.Drawing.Point(213, 371);
		this.Button2.Name = "Button2";
		this.Button2.Size = new System.Drawing.Size(75, 23);
		this.Button2.TabIndex = 3;
		this.Button2.Text = "Borrar";
		this.Button2.UseVisualStyleBackColor = true;
		this.ListView1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.ListView1.Location = new System.Drawing.Point(315, 12);
		this.ListView1.Name = "ListView1";
		this.ListView1.Size = new System.Drawing.Size(349, 361);
		this.ListView1.TabIndex = 4;
		this.ListView1.UseCompatibleStateImageBehavior = false;
		this.Label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		this.Label1.AutoSize = true;
		this.Label1.Location = new System.Drawing.Point(625, 384);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(13, 13);
		this.Label1.TabIndex = 5;
		this.Label1.Text = "0";
		this.Label2.AutoSize = true;
		this.Label2.Location = new System.Drawing.Point(23, 115);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(19, 13);
		this.Label2.TabIndex = 6;
		this.Label2.Text = "Id:";
		this.Label3.AutoSize = true;
		this.Label3.Location = new System.Drawing.Point(105, 115);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(39, 13);
		this.Label3.TabIndex = 7;
		this.Label3.Text = "Label3";
		this.Label4.AutoSize = true;
		this.Label4.Location = new System.Drawing.Point(23, 149);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(40, 13);
		this.Label4.TabIndex = 8;
		this.Label4.Text = "Fecha:";
		this.Label5.AutoSize = true;
		this.Label5.Location = new System.Drawing.Point(105, 149);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(39, 13);
		this.Label5.TabIndex = 9;
		this.Label5.Text = "Label5";
		this.Label6.AutoSize = true;
		this.Label6.Location = new System.Drawing.Point(23, 182);
		this.Label6.Name = "Label6";
		this.Label6.Size = new System.Drawing.Size(46, 13);
		this.Label6.TabIndex = 10;
		this.Label6.Text = "Usuario:";
		this.Label7.AutoSize = true;
		this.Label7.Location = new System.Drawing.Point(105, 182);
		this.Label7.Name = "Label7";
		this.Label7.Size = new System.Drawing.Size(39, 13);
		this.Label7.TabIndex = 11;
		this.Label7.Text = "Label7";
		this.Label8.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		this.Label8.AutoSize = true;
		this.Label8.Location = new System.Drawing.Point(524, 384);
		this.Label8.Name = "Label8";
		this.Label8.Size = new System.Drawing.Size(54, 13);
		this.Label8.TabIndex = 12;
		this.Label8.Text = "Registros:";
		this.Label9.AutoSize = true;
		this.Label9.Location = new System.Drawing.Point(23, 218);
		this.Label9.Name = "Label9";
		this.Label9.Size = new System.Drawing.Size(66, 13);
		this.Label9.TabIndex = 13;
		this.Label9.Text = "Descripcion:";
		this.Label10.AutoSize = true;
		this.Label10.Location = new System.Drawing.Point(105, 218);
		this.Label10.Name = "Label10";
		this.Label10.Size = new System.Drawing.Size(45, 13);
		this.Label10.TabIndex = 14;
		this.Label10.Text = "Label10";
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(676, 406);
		base.Controls.Add(this.Label10);
		base.Controls.Add(this.Label9);
		base.Controls.Add(this.Label8);
		base.Controls.Add(this.Label7);
		base.Controls.Add(this.Label6);
		base.Controls.Add(this.Label5);
		base.Controls.Add(this.Label4);
		base.Controls.Add(this.Label3);
		base.Controls.Add(this.Label2);
		base.Controls.Add(this.Label1);
		base.Controls.Add(this.ListView1);
		base.Controls.Add(this.Button2);
		base.Controls.Add(this.Button1);
		base.Controls.Add(this.TextBox1);
		base.Controls.Add(this.DateTimePicker1);
		base.Name = "Feriados";
		this.Text = "Feriados";
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private void Feriados_Load(object sender, EventArgs e)
	{
		Mod_Sentencias.cargar_datos_lv_completa(ListView1, sql, Label1);
		Label3.Text = "";
		Label5.Text = "";
		Label7.Text = "";
		Label10.Text = "";
		DateTimePicker1.Value = DateAndTime.Today;
		TextBox1.Text = "";
	}

	private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (ListView1.SelectedItems.Count > 0)
		{
			int index = ListView1.SelectedIndices[0];
			Label3.Text = ListView1.Items[index].Text;
			Label5.Text = ListView1.Items[index].SubItems[1].Text;
			Label10.Text = ListView1.Items[index].SubItems[3].Text;
			Label7.Text = ListView1.Items[index].SubItems[2].Text;
		}
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(Label3.Text, "", TextCompare: true) != 0)
		{
			string sQL = ("DELETE FROM feriados WHERE id=" + Label3.Text) ?? "";
			Mod_ConeccionBD.BD_Sentencia(sQL);
			ListView1.Clear();
			Mod_Sentencias.cargar_datos_lv_completa(ListView1, sql, Label1);
			Label3.Text = "";
			Label5.Text = "";
			Label7.Text = "";
			Label10.Text = "";
			DateTimePicker1.Value = DateAndTime.Today;
			TextBox1.Text = "";
		}
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		string text = Strings.Format(DateTimePicker1.Value, "yyyyMMdd");
		string sQL = "INSERT INTO feriados (fecha, descripcion, usuario) VALUES('" + text + "', '" + TextBox1.Text + "' , '" + MySettingsProperty.Settings.Usuario + "')";
		Mod_ConeccionBD.BD_Sentencia(sQL);
		ListView1.Clear();
		Mod_Sentencias.cargar_datos_lv_completa(ListView1, sql, Label1);
		Label3.Text = "";
		Label5.Text = "";
		Label7.Text = "";
		Label10.Text = "";
		DateTimePicker1.Value = DateAndTime.Today;
		TextBox1.Text = "";
	}
}
