using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Hermes.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace Hermes;

[DesignerGenerated]
public class Movimientos_A : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ComboBox1")]
	private ComboBox _ComboBox1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button3")]
	private Button _Button3;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ComboBox2")]
	private ComboBox _ComboBox2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("TextBox4")]
	private TextBox _TextBox4;

	public int identificacionempresa;

	private List<Mod_Productos.datos_producto> productosCompleto;

	private List<Mod_Ordenes.Destino> allDestinos;

	private string tipoComprobante;

	[field: AccessedThroughProperty("GroupBox1")]
	internal virtual GroupBox GroupBox1
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

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
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

	internal virtual ComboBox ComboBox1
	{
		[CompilerGenerated]
		get
		{
			return _ComboBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ComboBox1_SelectionChangeCommitted;
			ComboBox comboBox = _ComboBox1;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value2;
			}
			_ComboBox1 = value;
			comboBox = _ComboBox1;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value2;
			}
		}
	}

	[field: AccessedThroughProperty("GroupBox2")]
	internal virtual GroupBox GroupBox2
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

	[field: AccessedThroughProperty("RadioButton1")]
	internal virtual RadioButton RadioButton1
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

	[field: AccessedThroughProperty("GroupBox3")]
	internal virtual GroupBox GroupBox3
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

	[field: AccessedThroughProperty("Label5")]
	internal virtual Label Label5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("GroupBox5")]
	internal virtual GroupBox GroupBox5
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

	[field: AccessedThroughProperty("Label7")]
	internal virtual Label Label7
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

	[field: AccessedThroughProperty("Label11")]
	internal virtual Label Label11
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label12")]
	internal virtual Label Label12
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label13")]
	internal virtual Label Label13
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

	[field: AccessedThroughProperty("GroupBox4")]
	internal virtual GroupBox GroupBox4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ListView1")]
	internal virtual ListView ListView1
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

	[field: AccessedThroughProperty("ColumnHeader3")]
	internal virtual ColumnHeader ColumnHeader3
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

	[field: AccessedThroughProperty("ColumnHeader5")]
	internal virtual ColumnHeader ColumnHeader5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ColumnHeader6")]
	internal virtual ColumnHeader ColumnHeader6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ColumnHeader7")]
	internal virtual ColumnHeader ColumnHeader7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("GroupBox6")]
	internal virtual GroupBox GroupBox6
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

	internal virtual ComboBox ComboBox2
	{
		[CompilerGenerated]
		get
		{
			return _ComboBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ComboBox2_SelectedIndexChanged;
			ComboBox comboBox = _ComboBox2;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged -= value2;
			}
			_ComboBox2 = value;
			comboBox = _ComboBox2;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("TextBox6")]
	internal virtual TextBox TextBox6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("unidadeslbl")]
	internal virtual Label unidadeslbl
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("descripcionlbl")]
	internal virtual Label descripcionlbl
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual TextBox TextBox4
	{
		[CompilerGenerated]
		get
		{
			return _TextBox4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = TextBox4_TextChanged;
			KeyPressEventHandler value3 = TextBox4_KeyPress;
			TextBox textBox = _TextBox4;
			if (textBox != null)
			{
				textBox.TextChanged -= value2;
				textBox.KeyPress -= value3;
			}
			_TextBox4 = value;
			textBox = _TextBox4;
			if (textBox != null)
			{
				textBox.TextChanged += value2;
				textBox.KeyPress += value3;
			}
		}
	}

	[field: AccessedThroughProperty("codigolbl")]
	internal virtual Label codigolbl
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label14")]
	internal virtual Label Label14
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("dtpMovimiento")]
	internal virtual DateTimePicker dtpMovimiento
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label15")]
	internal virtual Label Label15
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public Movimientos_A()
	{
		base.Load += Movimientos_A_Load;
		allDestinos = new List<Mod_Ordenes.Destino>();
		tipoComprobante = string.Empty;
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
		this.GroupBox1 = new System.Windows.Forms.GroupBox();
		this.Label3 = new System.Windows.Forms.Label();
		this.Label2 = new System.Windows.Forms.Label();
		this.Label1 = new System.Windows.Forms.Label();
		this.ComboBox1 = new System.Windows.Forms.ComboBox();
		this.GroupBox2 = new System.Windows.Forms.GroupBox();
		this.RadioButton2 = new System.Windows.Forms.RadioButton();
		this.RadioButton1 = new System.Windows.Forms.RadioButton();
		this.Label4 = new System.Windows.Forms.Label();
		this.GroupBox3 = new System.Windows.Forms.GroupBox();
		this.Label14 = new System.Windows.Forms.Label();
		this.dtpMovimiento = new System.Windows.Forms.DateTimePicker();
		this.TextBox1 = new System.Windows.Forms.TextBox();
		this.Label5 = new System.Windows.Forms.Label();
		this.GroupBox5 = new System.Windows.Forms.GroupBox();
		this.Label8 = new System.Windows.Forms.Label();
		this.Label7 = new System.Windows.Forms.Label();
		this.Label6 = new System.Windows.Forms.Label();
		this.Label9 = new System.Windows.Forms.Label();
		this.Label10 = new System.Windows.Forms.Label();
		this.Label11 = new System.Windows.Forms.Label();
		this.Label12 = new System.Windows.Forms.Label();
		this.Label13 = new System.Windows.Forms.Label();
		this.Button2 = new System.Windows.Forms.Button();
		this.Button1 = new System.Windows.Forms.Button();
		this.GroupBox4 = new System.Windows.Forms.GroupBox();
		this.ListView1 = new System.Windows.Forms.ListView();
		this.ColumnHeader2 = new System.Windows.Forms.ColumnHeader();
		this.ColumnHeader3 = new System.Windows.Forms.ColumnHeader();
		this.ColumnHeader4 = new System.Windows.Forms.ColumnHeader();
		this.ColumnHeader5 = new System.Windows.Forms.ColumnHeader();
		this.ColumnHeader6 = new System.Windows.Forms.ColumnHeader();
		this.ColumnHeader7 = new System.Windows.Forms.ColumnHeader();
		this.GroupBox6 = new System.Windows.Forms.GroupBox();
		this.Button3 = new System.Windows.Forms.Button();
		this.ComboBox2 = new System.Windows.Forms.ComboBox();
		this.TextBox6 = new System.Windows.Forms.TextBox();
		this.unidadeslbl = new System.Windows.Forms.Label();
		this.descripcionlbl = new System.Windows.Forms.Label();
		this.TextBox4 = new System.Windows.Forms.TextBox();
		this.codigolbl = new System.Windows.Forms.Label();
		this.Label15 = new System.Windows.Forms.Label();
		this.GroupBox1.SuspendLayout();
		this.GroupBox2.SuspendLayout();
		this.GroupBox3.SuspendLayout();
		this.GroupBox5.SuspendLayout();
		this.GroupBox4.SuspendLayout();
		this.GroupBox6.SuspendLayout();
		base.SuspendLayout();
		this.GroupBox1.Controls.Add(this.Label3);
		this.GroupBox1.Controls.Add(this.Label2);
		this.GroupBox1.Controls.Add(this.Label1);
		this.GroupBox1.Controls.Add(this.ComboBox1);
		this.GroupBox1.Location = new System.Drawing.Point(12, 12);
		this.GroupBox1.Name = "GroupBox1";
		this.GroupBox1.Size = new System.Drawing.Size(480, 86);
		this.GroupBox1.TabIndex = 0;
		this.GroupBox1.TabStop = false;
		this.Label3.AutoSize = true;
		this.Label3.Location = new System.Drawing.Point(112, 22);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(39, 13);
		this.Label3.TabIndex = 3;
		this.Label3.Text = "Label3";
		this.Label2.AutoSize = true;
		this.Label2.Location = new System.Drawing.Point(15, 54);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(51, 13);
		this.Label2.TabIndex = 2;
		this.Label2.Text = "Empresa:";
		this.Label1.AutoSize = true;
		this.Label1.Location = new System.Drawing.Point(15, 22);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(91, 13);
		this.Label1.TabIndex = 1;
		this.Label1.Text = "Número Empresa:";
		this.ComboBox1.FormattingEnabled = true;
		this.ComboBox1.Location = new System.Drawing.Point(72, 51);
		this.ComboBox1.Name = "ComboBox1";
		this.ComboBox1.Size = new System.Drawing.Size(402, 21);
		this.ComboBox1.TabIndex = 0;
		this.GroupBox2.Controls.Add(this.RadioButton2);
		this.GroupBox2.Controls.Add(this.RadioButton1);
		this.GroupBox2.Controls.Add(this.Label4);
		this.GroupBox2.Location = new System.Drawing.Point(498, 12);
		this.GroupBox2.Name = "GroupBox2";
		this.GroupBox2.Size = new System.Drawing.Size(85, 86);
		this.GroupBox2.TabIndex = 1;
		this.GroupBox2.TabStop = false;
		this.RadioButton2.AutoSize = true;
		this.RadioButton2.Location = new System.Drawing.Point(16, 55);
		this.RadioButton2.Name = "RadioButton2";
		this.RadioButton2.Size = new System.Drawing.Size(54, 17);
		this.RadioButton2.TabIndex = 2;
		this.RadioButton2.TabStop = true;
		this.RadioButton2.Text = "Salida";
		this.RadioButton2.UseVisualStyleBackColor = true;
		this.RadioButton1.AutoSize = true;
		this.RadioButton1.Location = new System.Drawing.Point(16, 32);
		this.RadioButton1.Name = "RadioButton1";
		this.RadioButton1.Size = new System.Drawing.Size(62, 17);
		this.RadioButton1.TabIndex = 1;
		this.RadioButton1.TabStop = true;
		this.RadioButton1.Text = "Entrada";
		this.RadioButton1.UseVisualStyleBackColor = true;
		this.Label4.AutoSize = true;
		this.Label4.Location = new System.Drawing.Point(13, 16);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(64, 13);
		this.Label4.TabIndex = 0;
		this.Label4.Text = "Movimiento:";
		this.GroupBox3.Controls.Add(this.Label14);
		this.GroupBox3.Controls.Add(this.dtpMovimiento);
		this.GroupBox3.Controls.Add(this.TextBox1);
		this.GroupBox3.Controls.Add(this.Label5);
		this.GroupBox3.Location = new System.Drawing.Point(589, 12);
		this.GroupBox3.Name = "GroupBox3";
		this.GroupBox3.Size = new System.Drawing.Size(277, 86);
		this.GroupBox3.TabIndex = 2;
		this.GroupBox3.TabStop = false;
		this.Label14.AutoSize = true;
		this.Label14.Location = new System.Drawing.Point(20, 25);
		this.Label14.Name = "Label14";
		this.Label14.Size = new System.Drawing.Size(37, 13);
		this.Label14.TabIndex = 3;
		this.Label14.Text = "Fecha";
		this.dtpMovimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
		this.dtpMovimiento.Location = new System.Drawing.Point(99, 25);
		this.dtpMovimiento.Name = "dtpMovimiento";
		this.dtpMovimiento.Size = new System.Drawing.Size(99, 20);
		this.dtpMovimiento.TabIndex = 2;
		this.TextBox1.Location = new System.Drawing.Point(99, 51);
		this.TextBox1.Name = "TextBox1";
		this.TextBox1.Size = new System.Drawing.Size(168, 20);
		this.TextBox1.TabIndex = 1;
		this.Label5.AutoSize = true;
		this.Label5.Location = new System.Drawing.Point(20, 57);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(73, 13);
		this.Label5.TabIndex = 0;
		this.Label5.Text = "Comprobante:";
		this.GroupBox5.Controls.Add(this.Label8);
		this.GroupBox5.Controls.Add(this.Label7);
		this.GroupBox5.Controls.Add(this.Label6);
		this.GroupBox5.Controls.Add(this.Label9);
		this.GroupBox5.Controls.Add(this.Label10);
		this.GroupBox5.Controls.Add(this.Label11);
		this.GroupBox5.Controls.Add(this.Label12);
		this.GroupBox5.Controls.Add(this.Label13);
		this.GroupBox5.Controls.Add(this.Button2);
		this.GroupBox5.Controls.Add(this.Button1);
		this.GroupBox5.Location = new System.Drawing.Point(652, 178);
		this.GroupBox5.Name = "GroupBox5";
		this.GroupBox5.Size = new System.Drawing.Size(214, 235);
		this.GroupBox5.TabIndex = 13;
		this.GroupBox5.TabStop = false;
		this.Label8.AutoSize = true;
		this.Label8.Location = new System.Drawing.Point(130, 94);
		this.Label8.Name = "Label8";
		this.Label8.Size = new System.Drawing.Size(13, 13);
		this.Label8.TabIndex = 9;
		this.Label8.Text = "0";
		this.Label7.AutoSize = true;
		this.Label7.Location = new System.Drawing.Point(10, 94);
		this.Label7.Name = "Label7";
		this.Label7.Size = new System.Drawing.Size(55, 13);
		this.Label7.TabIndex = 8;
		this.Label7.Text = "Unidades:";
		this.Label6.AutoSize = true;
		this.Label6.Location = new System.Drawing.Point(130, 68);
		this.Label6.Name = "Label6";
		this.Label6.Size = new System.Drawing.Size(13, 13);
		this.Label6.TabIndex = 7;
		this.Label6.Text = "0";
		this.Label9.AutoSize = true;
		this.Label9.Location = new System.Drawing.Point(10, 68);
		this.Label9.Name = "Label9";
		this.Label9.Size = new System.Drawing.Size(35, 13);
		this.Label9.TabIndex = 6;
		this.Label9.Text = "Items:";
		this.Label10.AutoSize = true;
		this.Label10.Location = new System.Drawing.Point(130, 42);
		this.Label10.Name = "Label10";
		this.Label10.Size = new System.Drawing.Size(13, 13);
		this.Label10.TabIndex = 5;
		this.Label10.Text = "0";
		this.Label11.AutoSize = true;
		this.Label11.Location = new System.Drawing.Point(10, 42);
		this.Label11.Name = "Label11";
		this.Label11.Size = new System.Drawing.Size(26, 13);
		this.Label11.TabIndex = 4;
		this.Label11.Text = "Var:";
		this.Label12.AutoSize = true;
		this.Label12.Location = new System.Drawing.Point(130, 19);
		this.Label12.Name = "Label12";
		this.Label12.Size = new System.Drawing.Size(13, 13);
		this.Label12.TabIndex = 3;
		this.Label12.Text = "0";
		this.Label13.AutoSize = true;
		this.Label13.Location = new System.Drawing.Point(10, 19);
		this.Label13.Name = "Label13";
		this.Label13.Size = new System.Drawing.Size(90, 13);
		this.Label13.TabIndex = 2;
		this.Label13.Text = "Stock Disponible:";
		this.Button2.Location = new System.Drawing.Point(133, 206);
		this.Button2.Name = "Button2";
		this.Button2.Size = new System.Drawing.Size(75, 23);
		this.Button2.TabIndex = 1;
		this.Button2.Text = "Button2";
		this.Button2.UseVisualStyleBackColor = true;
		this.Button1.Location = new System.Drawing.Point(6, 206);
		this.Button1.Name = "Button1";
		this.Button1.Size = new System.Drawing.Size(75, 23);
		this.Button1.TabIndex = 0;
		this.Button1.Text = "Button1";
		this.Button1.UseVisualStyleBackColor = true;
		this.GroupBox4.Controls.Add(this.ListView1);
		this.GroupBox4.Location = new System.Drawing.Point(12, 178);
		this.GroupBox4.Name = "GroupBox4";
		this.GroupBox4.Size = new System.Drawing.Size(634, 236);
		this.GroupBox4.TabIndex = 12;
		this.GroupBox4.TabStop = false;
		this.GroupBox4.Text = "Orden :";
		this.ListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[6] { this.ColumnHeader2, this.ColumnHeader3, this.ColumnHeader4, this.ColumnHeader5, this.ColumnHeader6, this.ColumnHeader7 });
		this.ListView1.FullRowSelect = true;
		this.ListView1.GridLines = true;
		this.ListView1.Location = new System.Drawing.Point(6, 19);
		this.ListView1.Name = "ListView1";
		this.ListView1.Size = new System.Drawing.Size(623, 211);
		this.ListView1.TabIndex = 0;
		this.ListView1.UseCompatibleStateImageBehavior = false;
		this.ListView1.View = System.Windows.Forms.View.Details;
		this.ColumnHeader2.Text = "Unidades";
		this.ColumnHeader3.Text = "Producto";
		this.ColumnHeader4.Text = "Descripcion";
		this.ColumnHeader4.Width = 281;
		this.ColumnHeader5.Text = "Codigo";
		this.ColumnHeader6.Text = "Variacion";
		this.ColumnHeader7.Text = "Valor";
		this.GroupBox6.Controls.Add(this.Label15);
		this.GroupBox6.Controls.Add(this.Button3);
		this.GroupBox6.Controls.Add(this.ComboBox2);
		this.GroupBox6.Controls.Add(this.TextBox6);
		this.GroupBox6.Controls.Add(this.unidadeslbl);
		this.GroupBox6.Controls.Add(this.descripcionlbl);
		this.GroupBox6.Controls.Add(this.TextBox4);
		this.GroupBox6.Controls.Add(this.codigolbl);
		this.GroupBox6.Location = new System.Drawing.Point(12, 104);
		this.GroupBox6.Name = "GroupBox6";
		this.GroupBox6.Size = new System.Drawing.Size(854, 68);
		this.GroupBox6.TabIndex = 11;
		this.GroupBox6.TabStop = false;
		this.GroupBox6.Text = "Producto :";
		this.Button3.Location = new System.Drawing.Point(754, 21);
		this.Button3.Name = "Button3";
		this.Button3.Size = new System.Drawing.Size(75, 23);
		this.Button3.TabIndex = 8;
		this.Button3.Text = "Button3";
		this.Button3.UseVisualStyleBackColor = true;
		this.ComboBox2.FormattingEnabled = true;
		this.ComboBox2.Location = new System.Drawing.Point(287, 23);
		this.ComboBox2.Name = "ComboBox2";
		this.ComboBox2.Size = new System.Drawing.Size(322, 21);
		this.ComboBox2.TabIndex = 6;
		this.TextBox6.Location = new System.Drawing.Point(680, 23);
		this.TextBox6.Name = "TextBox6";
		this.TextBox6.Size = new System.Drawing.Size(53, 20);
		this.TextBox6.TabIndex = 7;
		this.TextBox6.Text = "0";
		this.TextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		this.unidadeslbl.AutoSize = true;
		this.unidadeslbl.Location = new System.Drawing.Point(615, 26);
		this.unidadeslbl.Name = "unidadeslbl";
		this.unidadeslbl.Size = new System.Drawing.Size(55, 13);
		this.unidadeslbl.TabIndex = 4;
		this.unidadeslbl.Text = "Unidades:";
		this.descripcionlbl.AutoSize = true;
		this.descripcionlbl.Location = new System.Drawing.Point(212, 26);
		this.descripcionlbl.Name = "descripcionlbl";
		this.descripcionlbl.Size = new System.Drawing.Size(69, 13);
		this.descripcionlbl.TabIndex = 2;
		this.descripcionlbl.Text = "Descripción: ";
		this.TextBox4.Location = new System.Drawing.Point(72, 23);
		this.TextBox4.Name = "TextBox4";
		this.TextBox4.Size = new System.Drawing.Size(134, 20);
		this.TextBox4.TabIndex = 1;
		this.codigolbl.AutoSize = true;
		this.codigolbl.Location = new System.Drawing.Point(23, 26);
		this.codigolbl.Name = "codigolbl";
		this.codigolbl.Size = new System.Drawing.Size(43, 13);
		this.codigolbl.TabIndex = 0;
		this.codigolbl.Text = "Código:";
		this.Label15.AutoSize = true;
		this.Label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label15.Location = new System.Drawing.Point(78, 46);
		this.Label15.Name = "Label15";
		this.Label15.Size = new System.Drawing.Size(128, 12);
		this.Label15.TabIndex = 9;
		this.Label15.Text = "*Presione ENTER para buscar";
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(879, 425);
		base.Controls.Add(this.GroupBox5);
		base.Controls.Add(this.GroupBox4);
		base.Controls.Add(this.GroupBox6);
		base.Controls.Add(this.GroupBox3);
		base.Controls.Add(this.GroupBox2);
		base.Controls.Add(this.GroupBox1);
		base.Name = "Movimientos_A";
		this.Text = "Movimientos_A";
		this.GroupBox1.ResumeLayout(false);
		this.GroupBox1.PerformLayout();
		this.GroupBox2.ResumeLayout(false);
		this.GroupBox2.PerformLayout();
		this.GroupBox3.ResumeLayout(false);
		this.GroupBox3.PerformLayout();
		this.GroupBox5.ResumeLayout(false);
		this.GroupBox5.PerformLayout();
		this.GroupBox4.ResumeLayout(false);
		this.GroupBox6.ResumeLayout(false);
		this.GroupBox6.PerformLayout();
		base.ResumeLayout(false);
	}

	private void Movimientos_A_Load(object sender, EventArgs e)
	{
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		Text = "Nuevo Movimiento";
		Button1.Text = "Crear";
		Button2.Text = "Cancelar";
		Button3.Text = "Asignar";
		RadioButton1.Checked = true;
		string text = "SELECT  Nombre, id FROM empresas WHERE estado = 1 AND tipo = 1 ORDER BY id ASC";
		try
		{
			DataTable dataTable = new DataTable("x");
			MySqlDataAdapter val = new MySqlDataAdapter(text, Mod_Sentencias.cnn);
			((DbDataAdapter)(object)val).Fill(dataTable);
			if (dataTable.Rows.Count > 0)
			{
				ComboBox1.SelectedIndex = -1;
				Dictionary<string, string> dictionary = new Dictionary<string, string>();
				foreach (DataRow row in dataTable.Rows)
				{
					dictionary.Add(row[1].ToString(), Conversions.ToString(row[0]));
				}
				ComboBox1.DataSource = new BindingSource(dictionary, null);
				ComboBox1.DisplayMember = "Value";
				ComboBox1.ValueMember = "Key";
				ComboBox1.SelectedIndex = -1;
			}
			else
			{
				ComboBox1.DataSource = null;
				ComboBox1.Items.Clear();
				ComboBox1.SelectedIndex = -1;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox("Ocurrio un error al recuperar datos. " + ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void ComboBox1_SelectionChangeCommitted(object sender, EventArgs e)
	{
		if (ComboBox1.SelectedIndex > -1)
		{
			identificacionempresa = Conversions.ToInteger(ComboBox1.SelectedValue);
			Label3.Text = Conversions.ToString(identificacionempresa);
			load_productos();
		}
	}

	private void load_productos()
	{
		ComboBox2.Items.Clear();
		productosCompleto = (List<Mod_Productos.datos_producto>)Mod_Productos.listaProductos(identificacionempresa);
		checked
		{
			int num = productosCompleto.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				ComboBox2.Items.Add(productosCompleto[i].productDescripcion);
			}
			ComboBox2.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			ComboBox2.AutoCompleteSource = AutoCompleteSource.ListItems;
		}
	}

	private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (ComboBox2.SelectedIndex > -1)
		{
			Mod_Productos.datos_producto datos_producto = default(Mod_Productos.datos_producto);
			try
			{
				int num = 0;
				object obj = Mod_Productos.buscarProdPorNombre(ComboBox2.Text, productosCompleto);
				datos_producto = ((obj != null) ? ((Mod_Productos.datos_producto)obj) : default(Mod_Productos.datos_producto));
				TextBox4.Text = datos_producto.productCodigo;
				num = Conversions.ToInteger(Mod_Productos.unidadesDisponibles(datos_producto.productId, datos_producto.productVariaciones, identificacionempresa));
				Label10.Text = Conversions.ToString(datos_producto.productVariaciones);
				ListViewItem listViewItem = null;
				if (ListView1.Items.Count > 0)
				{
					listViewItem = ListView1.FindItemWithText(ComboBox2.Text, includeSubItemsInSearch: true, 0, isPrefixSearch: false);
				}
				if (listViewItem != null)
				{
					num = checked(num - int.Parse(listViewItem.Text));
				}
				Label12.Text = Conversions.ToString(num);
				return;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				Interaction.MsgBox("No se encontraron resultados para la busqueda");
				ProjectData.ClearProjectError();
				return;
			}
		}
		Interaction.MsgBox("Seleccione una producto");
	}

	private void Button3_Click(object sender, EventArgs e)
	{
		string left = TextBox1.Text;
		if (Operators.CompareString(left, "", TextCompare: true) == 0)
		{
			Interaction.MsgBox("Debe indicar un identificador para la orden.");
			TextBox1.Focus();
			return;
		}
		int selectedIndex = ComboBox2.SelectedIndex;
		checked
		{
			if (Conversions.ToDouble(TextBox6.Text) != 0.0)
			{
				if (Conversions.ToDouble(Label10.Text) == 1.0)
				{
					Selector selector = MyProject.Forms.Selector;
					selector.Label1.Text = Conversions.ToString(1);
					selector.Label2.Text = Conversions.ToString(productosCompleto[selectedIndex].productId);
					selector.Label3.Text = productosCompleto[selectedIndex].productBarrcode;
					selector.ListView1.Items.Clear();
					selector = null;
					MyProject.Forms.Selector.ShowDialog();
				}
				else if (Conversions.ToDouble(Label10.Text) == 0.0)
				{
					ListViewItem listViewItem = null;
					ListViewItem listViewItem2 = null;
					int num = int.Parse(TextBox6.Text);
					int num2 = 0;
					if (ListView1.Items.Count > 0)
					{
						listViewItem = ListView1.FindItemWithText(Conversions.ToString(productosCompleto[selectedIndex].productId), includeSubItemsInSearch: true, 0);
					}
					if (listViewItem != null)
					{
						num = int.Parse(Conversions.ToString(num)) + int.Parse(listViewItem.Text);
						string text = listViewItem.SubItems[2].Text;
						string text2 = listViewItem.SubItems[1].Text;
						if (!RadioButton1.Checked && RadioButton2.Checked && num > int.Parse(Label12.Text))
						{
							Interaction.MsgBox("Se exedio la cantidad solicitada. Recuerde restar las unidades ya asignadas, al stock disponible.");
							return;
						}
						listViewItem.Remove();
						listViewItem2 = new ListViewItem(num.ToString());
						listViewItem2.SubItems.Add(text2);
						listViewItem2.SubItems.Add(text);
						listViewItem2.SubItems.Add(productosCompleto[selectedIndex].productBarrcode);
						listViewItem2.SubItems.Add(Conversions.ToString(0));
						listViewItem2.SubItems.Add(Conversions.ToString(productosCompleto[selectedIndex].productPrecio));
						ListView1.Items.Add(listViewItem2);
						listViewItem2.EnsureVisible();
						foreach (object item in ListView1.Items)
						{
							object objectValue = RuntimeHelpers.GetObjectValue(item);
							num2 += int.Parse(Conversions.ToString(NewLateBinding.LateGet(objectValue, null, "Text", new object[0], null, null, null)));
						}
					}
					else
					{
						if (!RadioButton1.Checked && RadioButton2.Checked && num > int.Parse(Label12.Text))
						{
							Interaction.MsgBox("Se exedio la cantidad solicitada. Recuerde restar las unidades ya asignadas, al stock disponible.");
							return;
						}
						string text3 = ComboBox2.Text;
						listViewItem2 = new ListViewItem(Conversions.ToString(num));
						listViewItem2.SubItems.Add(Conversions.ToString(productosCompleto[selectedIndex].productId));
						listViewItem2.SubItems.Add(productosCompleto[selectedIndex].productDescripcion);
						listViewItem2.SubItems.Add(productosCompleto[selectedIndex].productBarrcode);
						listViewItem2.SubItems.Add(Conversions.ToString(0));
						listViewItem2.SubItems.Add(Conversions.ToString(productosCompleto[selectedIndex].productPrecio));
						ListView1.Items.Add(listViewItem2);
						listViewItem2.EnsureVisible();
						foreach (ListViewItem item2 in ListView1.Items)
						{
							num2 += int.Parse(item2.Text);
						}
					}
					Label6.Text = Conversions.ToString(ListView1.Items.Count);
					Label8.Text = Conversions.ToString(num2);
					TextBox4.Clear();
					Label12.Text = Conversions.ToString(0);
					ComboBox2.Text = "";
					TextBox6.Text = Conversions.ToString(0);
				}
				ComboBox2.Focus();
			}
			else
			{
				Interaction.MsgBox("Las unidades no pueden ser 0");
			}
		}
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
		switch (num)
		{
		case 0:
			try
			{
				int num8 = 0;
				int num9 = 0;
				int num10 = 0;
				int num11 = 0;
				int empresa2 = int.Parse(Label3.Text);
				List<Mod_ActualizacionStock.abmStock> list2 = new List<Mod_ActualizacionStock.abmStock>();
				foreach (ListViewItem item3 in ListView1.Items)
				{
					num8 = int.Parse(item3.SubItems[1].Text);
					num9 = int.Parse(item3.Text);
					num10 = int.Parse(item3.SubItems[4].Text);
					Mod_ActualizacionStock.abmStock item2 = default(Mod_ActualizacionStock.abmStock);
					item2.id = num8;
					item2.unidades = num9;
					item2.variacion = num10;
					list2.Add(item2);
				}
				int num12 = Conversions.ToInteger(Mod_ActualizacionStock.ingresoStock2(list2, empresa2));
				if (num12 == 1)
				{
					Interaction.MsgBox("actualizacion correcta");
					string sQL2 = Conversions.ToString(ingresoDeProductos());
					int num13 = Conversions.ToInteger(Mod_ConeccionBD.BD_Sentencia(sQL2));
					if (num13 == 1)
					{
						TextBox1.Clear();
						ListView1.Items.Clear();
						Interaction.MsgBox("Se guardo el movimiento.");
					}
					else
					{
						Interaction.MsgBox("Error al guardar el movimiento.");
					}
				}
				else
				{
					Interaction.MsgBox("algo fallo");
				}
				break;
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				Logger.e(ex4.Message);
				ProjectData.ClearProjectError();
				break;
			}
		case 1:
			try
			{
				int num2 = 0;
				int num3 = 0;
				int num4 = 0;
				int num5 = 0;
				int empresa = int.Parse(Label3.Text);
				List<Mod_ActualizacionStock.abmStock> list = new List<Mod_ActualizacionStock.abmStock>();
				foreach (ListViewItem item4 in ListView1.Items)
				{
					num2 = int.Parse(item4.SubItems[1].Text);
					num3 = int.Parse(item4.Text);
					num4 = int.Parse(item4.SubItems[4].Text);
					Mod_ActualizacionStock.abmStock item = default(Mod_ActualizacionStock.abmStock);
					item.id = num2;
					item.unidades = num3;
					item.variacion = num4;
					list.Add(item);
				}
				int num6 = Conversions.ToInteger(Mod_ActualizacionStock.egresoStock2(list, empresa));
				if (num6 == 1)
				{
					Interaction.MsgBox("actualizacion correcta");
					Logger.i("actualizacion correcta");
					string sQL = Conversions.ToString(egresoDeProductos());
					int num7 = Conversions.ToInteger(Mod_ConeccionBD.BD_Sentencia(sQL));
					if (num7 == 1)
					{
						TextBox1.Clear();
						ListView1.Items.Clear();
						Interaction.MsgBox("Se guardo el movimiento.");
					}
					else
					{
						Interaction.MsgBox("Error al guardar el movimiento.");
					}
				}
				else
				{
					Interaction.MsgBox("algo fallo");
				}
				break;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Logger.e(ex2.Message);
				ProjectData.ClearProjectError();
				break;
			}
		}
	}

	private object ingresoDeProductos()
	{
		int num = Conversions.ToInteger(Label3.Text);
		string usuario = MySettingsProperty.Settings.Usuario;
		string text = TextBox1.Text;
		string text2 = Strings.Format(dtpMovimiento.Value, "yyyyMMdd");
		string text3 = "INSERT INTO movimientos (orden, codprod, variacion, unidades, tipo, id_empresa, estado, fecha, usuario)\r\nVALUES";
		checked
		{
			int num2 = ListView1.Items.Count - 1;
			for (int i = 0; i <= num2; i++)
			{
				string text4 = ListView1.Items[i].Text;
				string text5 = ListView1.Items[i].SubItems[3].Text;
				int num3 = int.Parse(ListView1.Items[i].SubItems[4].Text);
				text3 = ((i != 0) ? (text3 + ", ('" + text + "', '" + text5 + "', '" + Conversions.ToString(num3) + "', '" + text4 + "', '4', '" + Conversions.ToString(num) + "', '0', '" + text2 + "', '" + usuario + "')") : (text3 + "('" + text + "', '" + text5 + "', '" + Conversions.ToString(num3) + "', '" + text4 + "', '4', '" + Conversions.ToString(num) + "', '0', '" + text2 + "', '" + usuario + "')"));
			}
			return text3;
		}
	}

	private object egresoDeProductos()
	{
		int num = Conversions.ToInteger(Label3.Text);
		string usuario = MySettingsProperty.Settings.Usuario;
		string text = TextBox1.Text;
		string text2 = Strings.Format(dtpMovimiento.Value, "yyyyMMdd");
		string text3 = "INSERT INTO movimientos (orden, codprod, variacion, unidades, tipo, id_empresa, estado, fecha, usuario)\r\nVALUES";
		checked
		{
			int num2 = ListView1.Items.Count - 1;
			for (int i = 0; i <= num2; i++)
			{
				string text4 = ListView1.Items[i].Text;
				string text5 = ListView1.Items[i].SubItems[3].Text;
				int num3 = int.Parse(ListView1.Items[i].SubItems[4].Text);
				text3 = ((i != 0) ? (text3 + ", ('" + text + "', '" + text5 + "', '" + Conversions.ToString(num3) + "', '" + text4 + "', '3', '" + Conversions.ToString(num) + "', '0', '" + text2 + "', '" + usuario + "')") : (text3 + "('" + text + "', '" + text5 + "', '" + Conversions.ToString(num3) + "', '" + text4 + "', '3', '" + Conversions.ToString(num) + "', '0', '" + text2 + "', '" + usuario + "')"));
			}
			return text3;
		}
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void TextBox4_TextChanged(object sender, EventArgs e)
	{
	}

	private void TextBox4_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (e.KeyChar == '\r')
		{
			string value = TextBox4.Text;
			object obj = Mod_Productos.buscarProdPorCodigo(value, productosCompleto);
			Mod_Productos.datos_producto datos_producto = ((obj != null) ? ((Mod_Productos.datos_producto)obj) : default(Mod_Productos.datos_producto));
			ComboBox2.Text = datos_producto.productDescripcion;
		}
	}
}
