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
public class New_Orden : Form
{
	private IContainer components;

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
	[AccessedThroughProperty("ListView1")]
	private ListView _ListView1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button3")]
	private Button _Button3;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ComboBox1")]
	private ComboBox _ComboBox1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ComboBox2")]
	private ComboBox _ComboBox2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("contrareembolsocheck")]
	private CheckBox _contrareembolsocheck;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ComboBox3")]
	private ComboBox _ComboBox3;

	public int identificacionempresa;

	private List<Mod_Productos.datos_producto> productosCompleto;

	private List<Mod_Ordenes.Destino> allDestinos;

	private string tipoComprobante;

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

	[field: AccessedThroughProperty("Label5")]
	internal virtual Label Label5
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
			EventHandler value2 = ListView1_DoubleClick;
			KeyEventHandler value3 = ListView1_KeyDown;
			ColumnClickEventHandler value4 = ListView1_ColumnClick;
			ListView listView = _ListView1;
			if (listView != null)
			{
				listView.DoubleClick -= value2;
				listView.KeyDown -= value3;
				listView.ColumnClick -= value4;
			}
			_ListView1 = value;
			listView = _ListView1;
			if (listView != null)
			{
				listView.DoubleClick += value2;
				listView.KeyDown += value3;
				listView.ColumnClick += value4;
			}
		}
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

	[field: AccessedThroughProperty("GroupBox3")]
	internal virtual GroupBox GroupBox3
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
			EventHandler value2 = ComboBox1_SelectedIndexChanged;
			ComboBox comboBox = _ComboBox1;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged -= value2;
			}
			_ComboBox1 = value;
			comboBox = _ComboBox1;
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

	[field: AccessedThroughProperty("TextBox4")]
	internal virtual TextBox TextBox4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("codigolbl")]
	internal virtual Label codigolbl
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("GroupBox2")]
	internal virtual GroupBox GroupBox2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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
			KeyEventHandler value3 = ComboBox2_KeyDown;
			ComboBox comboBox = _ComboBox2;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged -= value2;
				comboBox.KeyDown -= value3;
			}
			_ComboBox2 = value;
			comboBox = _ComboBox2;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged += value2;
				comboBox.KeyDown += value3;
			}
		}
	}

	[field: AccessedThroughProperty("eventualid")]
	internal virtual Label eventualid
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox7")]
	internal virtual TextBox TextBox7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("observaciontext")]
	internal virtual Label observaciontext
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("localidadtext")]
	internal virtual TextBox localidadtext
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("localidadlbl")]
	internal virtual Label localidadlbl
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox3")]
	internal virtual TextBox TextBox3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("postallbl")]
	internal virtual Label postallbl
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("direcciontext")]
	internal virtual TextBox direcciontext
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("direccionlbl")]
	internal virtual Label direccionlbl
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("clientelbl")]
	internal virtual Label clientelbl
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("GroupBox1")]
	internal virtual GroupBox GroupBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("labelid")]
	internal virtual Label labelid
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("importetext")]
	internal virtual TextBox importetext
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("valorlbl")]
	internal virtual Label valorlbl
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

	internal virtual CheckBox contrareembolsocheck
	{
		[CompilerGenerated]
		get
		{
			return _contrareembolsocheck;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = contrareembolsocheck_CheckedChanged;
			CheckBox checkBox = _contrareembolsocheck;
			if (checkBox != null)
			{
				checkBox.CheckedChanged -= value2;
			}
			_contrareembolsocheck = value;
			checkBox = _contrareembolsocheck;
			if (checkBox != null)
			{
				checkBox.CheckedChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("otrobtn")]
	internal virtual RadioButton otrobtn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("asignacionbtn")]
	internal virtual RadioButton asignacionbtn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("remitobtn")]
	internal virtual RadioButton remitobtn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CheckBox1")]
	internal virtual CheckBox CheckBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("remitotext")]
	internal virtual TextBox remitotext
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("comprobantelbl")]
	internal virtual Label comprobantelbl
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("modeLbl")]
	internal virtual Label modeLbl
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

	internal virtual ComboBox ComboBox3
	{
		[CompilerGenerated]
		get
		{
			return _ComboBox3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ComboBox3_SelectionChangeCommitted;
			ComboBox comboBox = _ComboBox3;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value2;
			}
			_ComboBox3 = value;
			comboBox = _ComboBox3;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label9")]
	internal virtual Label Label9
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public New_Orden()
	{
		base.Load += New_Orden_Load;
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
		this.GroupBox5 = new System.Windows.Forms.GroupBox();
		this.Label8 = new System.Windows.Forms.Label();
		this.Label7 = new System.Windows.Forms.Label();
		this.Label6 = new System.Windows.Forms.Label();
		this.Label5 = new System.Windows.Forms.Label();
		this.Label4 = new System.Windows.Forms.Label();
		this.Label3 = new System.Windows.Forms.Label();
		this.Label2 = new System.Windows.Forms.Label();
		this.Label1 = new System.Windows.Forms.Label();
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
		this.GroupBox3 = new System.Windows.Forms.GroupBox();
		this.Button3 = new System.Windows.Forms.Button();
		this.ComboBox1 = new System.Windows.Forms.ComboBox();
		this.TextBox6 = new System.Windows.Forms.TextBox();
		this.unidadeslbl = new System.Windows.Forms.Label();
		this.descripcionlbl = new System.Windows.Forms.Label();
		this.TextBox4 = new System.Windows.Forms.TextBox();
		this.codigolbl = new System.Windows.Forms.Label();
		this.GroupBox2 = new System.Windows.Forms.GroupBox();
		this.ComboBox2 = new System.Windows.Forms.ComboBox();
		this.eventualid = new System.Windows.Forms.Label();
		this.TextBox7 = new System.Windows.Forms.TextBox();
		this.observaciontext = new System.Windows.Forms.Label();
		this.localidadtext = new System.Windows.Forms.TextBox();
		this.localidadlbl = new System.Windows.Forms.Label();
		this.TextBox3 = new System.Windows.Forms.TextBox();
		this.postallbl = new System.Windows.Forms.Label();
		this.direcciontext = new System.Windows.Forms.TextBox();
		this.direccionlbl = new System.Windows.Forms.Label();
		this.clientelbl = new System.Windows.Forms.Label();
		this.GroupBox1 = new System.Windows.Forms.GroupBox();
		this.labelid = new System.Windows.Forms.Label();
		this.importetext = new System.Windows.Forms.TextBox();
		this.valorlbl = new System.Windows.Forms.Label();
		this.TextBox1 = new System.Windows.Forms.TextBox();
		this.contrareembolsocheck = new System.Windows.Forms.CheckBox();
		this.otrobtn = new System.Windows.Forms.RadioButton();
		this.asignacionbtn = new System.Windows.Forms.RadioButton();
		this.remitobtn = new System.Windows.Forms.RadioButton();
		this.CheckBox1 = new System.Windows.Forms.CheckBox();
		this.remitotext = new System.Windows.Forms.TextBox();
		this.comprobantelbl = new System.Windows.Forms.Label();
		this.modeLbl = new System.Windows.Forms.Label();
		this.GroupBox6 = new System.Windows.Forms.GroupBox();
		this.ComboBox3 = new System.Windows.Forms.ComboBox();
		this.Label9 = new System.Windows.Forms.Label();
		this.GroupBox5.SuspendLayout();
		this.GroupBox4.SuspendLayout();
		this.GroupBox3.SuspendLayout();
		this.GroupBox2.SuspendLayout();
		this.GroupBox1.SuspendLayout();
		this.GroupBox6.SuspendLayout();
		base.SuspendLayout();
		this.GroupBox5.Controls.Add(this.Label8);
		this.GroupBox5.Controls.Add(this.Label7);
		this.GroupBox5.Controls.Add(this.Label6);
		this.GroupBox5.Controls.Add(this.Label5);
		this.GroupBox5.Controls.Add(this.Label4);
		this.GroupBox5.Controls.Add(this.Label3);
		this.GroupBox5.Controls.Add(this.Label2);
		this.GroupBox5.Controls.Add(this.Label1);
		this.GroupBox5.Controls.Add(this.Button2);
		this.GroupBox5.Controls.Add(this.Button1);
		this.GroupBox5.Location = new System.Drawing.Point(652, 331);
		this.GroupBox5.Name = "GroupBox5";
		this.GroupBox5.Size = new System.Drawing.Size(214, 200);
		this.GroupBox5.TabIndex = 10;
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
		this.Label5.AutoSize = true;
		this.Label5.Location = new System.Drawing.Point(10, 68);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(35, 13);
		this.Label5.TabIndex = 6;
		this.Label5.Text = "Items:";
		this.Label4.AutoSize = true;
		this.Label4.Location = new System.Drawing.Point(130, 42);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(13, 13);
		this.Label4.TabIndex = 5;
		this.Label4.Text = "0";
		this.Label3.AutoSize = true;
		this.Label3.Location = new System.Drawing.Point(10, 42);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(26, 13);
		this.Label3.TabIndex = 4;
		this.Label3.Text = "Var:";
		this.Label2.AutoSize = true;
		this.Label2.Location = new System.Drawing.Point(130, 19);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(13, 13);
		this.Label2.TabIndex = 3;
		this.Label2.Text = "0";
		this.Label1.AutoSize = true;
		this.Label1.Location = new System.Drawing.Point(10, 19);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(90, 13);
		this.Label1.TabIndex = 2;
		this.Label1.Text = "Stock Disponible:";
		this.Button2.Location = new System.Drawing.Point(133, 171);
		this.Button2.Name = "Button2";
		this.Button2.Size = new System.Drawing.Size(75, 23);
		this.Button2.TabIndex = 1;
		this.Button2.Text = "Button2";
		this.Button2.UseVisualStyleBackColor = true;
		this.Button1.Location = new System.Drawing.Point(13, 171);
		this.Button1.Name = "Button1";
		this.Button1.Size = new System.Drawing.Size(75, 23);
		this.Button1.TabIndex = 0;
		this.Button1.Text = "Button1";
		this.Button1.UseVisualStyleBackColor = true;
		this.GroupBox4.Controls.Add(this.ListView1);
		this.GroupBox4.Location = new System.Drawing.Point(12, 331);
		this.GroupBox4.Name = "GroupBox4";
		this.GroupBox4.Size = new System.Drawing.Size(634, 200);
		this.GroupBox4.TabIndex = 9;
		this.GroupBox4.TabStop = false;
		this.GroupBox4.Text = "Orden :";
		this.ListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[6] { this.ColumnHeader2, this.ColumnHeader3, this.ColumnHeader4, this.ColumnHeader5, this.ColumnHeader6, this.ColumnHeader7 });
		this.ListView1.FullRowSelect = true;
		this.ListView1.GridLines = true;
		this.ListView1.Location = new System.Drawing.Point(6, 19);
		this.ListView1.Name = "ListView1";
		this.ListView1.Size = new System.Drawing.Size(623, 175);
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
		this.GroupBox3.Controls.Add(this.Button3);
		this.GroupBox3.Controls.Add(this.ComboBox1);
		this.GroupBox3.Controls.Add(this.TextBox6);
		this.GroupBox3.Controls.Add(this.unidadeslbl);
		this.GroupBox3.Controls.Add(this.descripcionlbl);
		this.GroupBox3.Controls.Add(this.TextBox4);
		this.GroupBox3.Controls.Add(this.codigolbl);
		this.GroupBox3.Location = new System.Drawing.Point(12, 270);
		this.GroupBox3.Name = "GroupBox3";
		this.GroupBox3.Size = new System.Drawing.Size(854, 55);
		this.GroupBox3.TabIndex = 8;
		this.GroupBox3.TabStop = false;
		this.GroupBox3.Text = "Producto :";
		this.Button3.Location = new System.Drawing.Point(754, 21);
		this.Button3.Name = "Button3";
		this.Button3.Size = new System.Drawing.Size(75, 23);
		this.Button3.TabIndex = 8;
		this.Button3.Text = "Button3";
		this.Button3.UseVisualStyleBackColor = true;
		this.ComboBox1.FormattingEnabled = true;
		this.ComboBox1.Location = new System.Drawing.Point(287, 23);
		this.ComboBox1.Name = "ComboBox1";
		this.ComboBox1.Size = new System.Drawing.Size(322, 21);
		this.ComboBox1.TabIndex = 6;
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
		this.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.GroupBox2.Controls.Add(this.ComboBox2);
		this.GroupBox2.Controls.Add(this.eventualid);
		this.GroupBox2.Controls.Add(this.TextBox7);
		this.GroupBox2.Controls.Add(this.observaciontext);
		this.GroupBox2.Controls.Add(this.localidadtext);
		this.GroupBox2.Controls.Add(this.localidadlbl);
		this.GroupBox2.Controls.Add(this.TextBox3);
		this.GroupBox2.Controls.Add(this.postallbl);
		this.GroupBox2.Controls.Add(this.direcciontext);
		this.GroupBox2.Controls.Add(this.direccionlbl);
		this.GroupBox2.Controls.Add(this.clientelbl);
		this.GroupBox2.Location = new System.Drawing.Point(12, 133);
		this.GroupBox2.Name = "GroupBox2";
		this.GroupBox2.Size = new System.Drawing.Size(854, 131);
		this.GroupBox2.TabIndex = 7;
		this.GroupBox2.TabStop = false;
		this.GroupBox2.Text = "Destino :";
		this.ComboBox2.FormattingEnabled = true;
		this.ComboBox2.Location = new System.Drawing.Point(84, 26);
		this.ComboBox2.Name = "ComboBox2";
		this.ComboBox2.Size = new System.Drawing.Size(444, 21);
		this.ComboBox2.TabIndex = 11;
		this.eventualid.AutoSize = true;
		this.eventualid.Location = new System.Drawing.Point(558, 104);
		this.eventualid.Name = "eventualid";
		this.eventualid.Size = new System.Drawing.Size(13, 13);
		this.eventualid.TabIndex = 10;
		this.eventualid.Text = "0";
		this.TextBox7.Location = new System.Drawing.Point(102, 101);
		this.TextBox7.Name = "TextBox7";
		this.TextBox7.Size = new System.Drawing.Size(422, 20);
		this.TextBox7.TabIndex = 9;
		this.observaciontext.AutoSize = true;
		this.observaciontext.Location = new System.Drawing.Point(23, 104);
		this.observaciontext.Name = "observaciontext";
		this.observaciontext.Size = new System.Drawing.Size(73, 13);
		this.observaciontext.TabIndex = 8;
		this.observaciontext.Text = "Observación :";
		this.localidadtext.Location = new System.Drawing.Point(633, 63);
		this.localidadtext.Name = "localidadtext";
		this.localidadtext.Size = new System.Drawing.Size(100, 20);
		this.localidadtext.TabIndex = 7;
		this.localidadlbl.AutoSize = true;
		this.localidadlbl.Location = new System.Drawing.Point(549, 66);
		this.localidadlbl.Name = "localidadlbl";
		this.localidadlbl.Size = new System.Drawing.Size(56, 13);
		this.localidadlbl.TabIndex = 6;
		this.localidadlbl.Text = "Localidad:";
		this.TextBox3.Location = new System.Drawing.Point(633, 26);
		this.TextBox3.Name = "TextBox3";
		this.TextBox3.Size = new System.Drawing.Size(100, 20);
		this.TextBox3.TabIndex = 5;
		this.postallbl.AutoSize = true;
		this.postallbl.Location = new System.Drawing.Point(549, 29);
		this.postallbl.Name = "postallbl";
		this.postallbl.Size = new System.Drawing.Size(75, 13);
		this.postallbl.TabIndex = 4;
		this.postallbl.Text = "Codigo Postal:";
		this.direcciontext.Location = new System.Drawing.Point(84, 63);
		this.direcciontext.MaxLength = 255;
		this.direcciontext.Name = "direcciontext";
		this.direcciontext.Size = new System.Drawing.Size(455, 20);
		this.direcciontext.TabIndex = 3;
		this.direccionlbl.AutoSize = true;
		this.direccionlbl.Location = new System.Drawing.Point(23, 66);
		this.direccionlbl.Name = "direccionlbl";
		this.direccionlbl.Size = new System.Drawing.Size(55, 13);
		this.direccionlbl.TabIndex = 2;
		this.direccionlbl.Text = "Direccion:";
		this.clientelbl.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.clientelbl.AutoSize = true;
		this.clientelbl.Location = new System.Drawing.Point(23, 29);
		this.clientelbl.Name = "clientelbl";
		this.clientelbl.Size = new System.Drawing.Size(42, 13);
		this.clientelbl.TabIndex = 0;
		this.clientelbl.Text = "Cliente:";
		this.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.GroupBox1.Controls.Add(this.labelid);
		this.GroupBox1.Controls.Add(this.importetext);
		this.GroupBox1.Controls.Add(this.valorlbl);
		this.GroupBox1.Controls.Add(this.TextBox1);
		this.GroupBox1.Controls.Add(this.contrareembolsocheck);
		this.GroupBox1.Controls.Add(this.otrobtn);
		this.GroupBox1.Controls.Add(this.asignacionbtn);
		this.GroupBox1.Controls.Add(this.remitobtn);
		this.GroupBox1.Controls.Add(this.CheckBox1);
		this.GroupBox1.Controls.Add(this.remitotext);
		this.GroupBox1.Controls.Add(this.comprobantelbl);
		this.GroupBox1.Controls.Add(this.modeLbl);
		this.GroupBox1.Location = new System.Drawing.Point(12, 48);
		this.GroupBox1.Name = "GroupBox1";
		this.GroupBox1.Size = new System.Drawing.Size(854, 79);
		this.GroupBox1.TabIndex = 6;
		this.GroupBox1.TabStop = false;
		this.labelid.AutoSize = true;
		this.labelid.Location = new System.Drawing.Point(526, 26);
		this.labelid.Name = "labelid";
		this.labelid.Size = new System.Drawing.Size(13, 13);
		this.labelid.TabIndex = 11;
		this.labelid.Text = "0";
		this.importetext.Location = new System.Drawing.Point(489, 48);
		this.importetext.Name = "importetext";
		this.importetext.Size = new System.Drawing.Size(190, 20);
		this.importetext.TabIndex = 10;
		this.importetext.Text = "0";
		this.importetext.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		this.valorlbl.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.valorlbl.AutoSize = true;
		this.valorlbl.Location = new System.Drawing.Point(433, 51);
		this.valorlbl.Name = "valorlbl";
		this.valorlbl.Size = new System.Drawing.Size(48, 13);
		this.valorlbl.TabIndex = 9;
		this.valorlbl.Text = "Importe :";
		this.TextBox1.Enabled = false;
		this.TextBox1.Location = new System.Drawing.Point(161, 48);
		this.TextBox1.Name = "TextBox1";
		this.TextBox1.Size = new System.Drawing.Size(226, 20);
		this.TextBox1.TabIndex = 5;
		this.TextBox1.Text = "0";
		this.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		this.contrareembolsocheck.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.contrareembolsocheck.AutoSize = true;
		this.contrareembolsocheck.Location = new System.Drawing.Point(50, 50);
		this.contrareembolsocheck.Name = "contrareembolsocheck";
		this.contrareembolsocheck.Size = new System.Drawing.Size(105, 17);
		this.contrareembolsocheck.TabIndex = 7;
		this.contrareembolsocheck.Text = "Contrareembolso";
		this.contrareembolsocheck.UseVisualStyleBackColor = true;
		this.otrobtn.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.otrobtn.AutoSize = true;
		this.otrobtn.Location = new System.Drawing.Point(385, 23);
		this.otrobtn.Name = "otrobtn";
		this.otrobtn.Size = new System.Drawing.Size(45, 17);
		this.otrobtn.TabIndex = 6;
		this.otrobtn.TabStop = true;
		this.otrobtn.Text = "Otro";
		this.otrobtn.UseVisualStyleBackColor = true;
		this.asignacionbtn.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.asignacionbtn.AutoSize = true;
		this.asignacionbtn.Location = new System.Drawing.Point(302, 23);
		this.asignacionbtn.Name = "asignacionbtn";
		this.asignacionbtn.Size = new System.Drawing.Size(77, 17);
		this.asignacionbtn.TabIndex = 5;
		this.asignacionbtn.TabStop = true;
		this.asignacionbtn.Text = "Asignación";
		this.asignacionbtn.UseVisualStyleBackColor = true;
		this.remitobtn.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.remitobtn.AutoSize = true;
		this.remitobtn.Location = new System.Drawing.Point(238, 23);
		this.remitobtn.Name = "remitobtn";
		this.remitobtn.Size = new System.Drawing.Size(58, 17);
		this.remitobtn.TabIndex = 4;
		this.remitobtn.TabStop = true;
		this.remitobtn.Text = "Remito";
		this.remitobtn.UseVisualStyleBackColor = true;
		this.CheckBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.CheckBox1.AutoSize = true;
		this.CheckBox1.Location = new System.Drawing.Point(633, 24);
		this.CheckBox1.Name = "CheckBox1";
		this.CheckBox1.Size = new System.Drawing.Size(88, 17);
		this.CheckBox1.TabIndex = 3;
		this.CheckBox1.Text = "Alta Prioridad";
		this.CheckBox1.UseVisualStyleBackColor = true;
		this.remitotext.Location = new System.Drawing.Point(105, 23);
		this.remitotext.Name = "remitotext";
		this.remitotext.Size = new System.Drawing.Size(127, 20);
		this.remitotext.TabIndex = 2;
		this.comprobantelbl.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.comprobantelbl.AutoSize = true;
		this.comprobantelbl.Location = new System.Drawing.Point(23, 26);
		this.comprobantelbl.Name = "comprobantelbl";
		this.comprobantelbl.Size = new System.Drawing.Size(76, 13);
		this.comprobantelbl.TabIndex = 1;
		this.comprobantelbl.Text = "Comprobante :";
		this.modeLbl.AutoSize = true;
		this.modeLbl.Location = new System.Drawing.Point(478, 26);
		this.modeLbl.Name = "modeLbl";
		this.modeLbl.Size = new System.Drawing.Size(13, 13);
		this.modeLbl.TabIndex = 0;
		this.modeLbl.Text = "0";
		this.modeLbl.Visible = false;
		this.GroupBox6.Controls.Add(this.ComboBox3);
		this.GroupBox6.Controls.Add(this.Label9);
		this.GroupBox6.Location = new System.Drawing.Point(12, 2);
		this.GroupBox6.Name = "GroupBox6";
		this.GroupBox6.Size = new System.Drawing.Size(854, 48);
		this.GroupBox6.TabIndex = 11;
		this.GroupBox6.TabStop = false;
		this.ComboBox3.FormattingEnabled = true;
		this.ComboBox3.Location = new System.Drawing.Point(224, 17);
		this.ComboBox3.Name = "ComboBox3";
		this.ComboBox3.Size = new System.Drawing.Size(452, 21);
		this.ComboBox3.TabIndex = 1;
		this.Label9.AutoSize = true;
		this.Label9.Location = new System.Drawing.Point(166, 20);
		this.Label9.Name = "Label9";
		this.Label9.Size = new System.Drawing.Size(51, 13);
		this.Label9.TabIndex = 0;
		this.Label9.Text = "Empresa:";
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(878, 544);
		base.Controls.Add(this.GroupBox6);
		base.Controls.Add(this.GroupBox5);
		base.Controls.Add(this.GroupBox4);
		base.Controls.Add(this.GroupBox3);
		base.Controls.Add(this.GroupBox2);
		base.Controls.Add(this.GroupBox1);
		base.Name = "New_Orden";
		this.Text = "New_Orden";
		this.GroupBox5.ResumeLayout(false);
		this.GroupBox5.PerformLayout();
		this.GroupBox4.ResumeLayout(false);
		this.GroupBox3.ResumeLayout(false);
		this.GroupBox3.PerformLayout();
		this.GroupBox2.ResumeLayout(false);
		this.GroupBox2.PerformLayout();
		this.GroupBox1.ResumeLayout(false);
		this.GroupBox1.PerformLayout();
		this.GroupBox6.ResumeLayout(false);
		this.GroupBox6.PerformLayout();
		base.ResumeLayout(false);
	}

	private void New_Orden_Load(object sender, EventArgs e)
	{
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		Text = "Nueva Orden";
		remitobtn.Checked = true;
		Button1.Text = "Crear";
		Button2.Text = "Cancelar";
		Button3.Text = "Asignar";
		string text = "SELECT  Nombre, id FROM empresas WHERE estado = 1 AND tipo = 1 ORDER BY nombre ASC";
		try
		{
			DataTable dataTable = new DataTable("x");
			MySqlDataAdapter val = new MySqlDataAdapter(text, Mod_Sentencias.cnn);
			((DbDataAdapter)(object)val).Fill(dataTable);
			if (dataTable.Rows.Count > 0)
			{
				ComboBox3.SelectedIndex = -1;
				Dictionary<string, string> dictionary = new Dictionary<string, string>();
				foreach (DataRow row in dataTable.Rows)
				{
					dictionary.Add(row[1].ToString(), Conversions.ToString(row[0]));
				}
				ComboBox3.DataSource = new BindingSource(dictionary, null);
				ComboBox3.DisplayMember = "Value";
				ComboBox3.ValueMember = "Key";
				ComboBox3.SelectedIndex = -1;
			}
			else
			{
				ComboBox3.DataSource = null;
				ComboBox3.Items.Clear();
				ComboBox3.SelectedIndex = -1;
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

	private void ComboBox3_SelectionChangeCommitted(object sender, EventArgs e)
	{
		if (ComboBox3.SelectedIndex > -1)
		{
			Cursor = Cursors.WaitCursor;
			identificacionempresa = Conversions.ToInteger(ComboBox3.SelectedValue);
			labelid.Text = Conversions.ToString(ComboBox3.SelectedValue);
			load_productos();
			load_destinos();
			Cursor = Cursors.Default;
		}
	}

	private void load_productos()
	{
		ComboBox1.Items.Clear();
		productosCompleto = (List<Mod_Productos.datos_producto>)Mod_Productos.listaProductos(identificacionempresa);
		checked
		{
			int num = productosCompleto.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				ComboBox1.Items.Add(productosCompleto[i].productDescripcion);
			}
			ComboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			ComboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;
		}
	}

	private void load_destinos()
	{
		ComboBox2.Items.Clear();
		allDestinos = (List<Mod_Ordenes.Destino>)Mod_Productos.getDestinos();
		checked
		{
			int num = allDestinos.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				ComboBox2.Items.Add(allDestinos[i].nombre);
			}
			ComboBox2.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			ComboBox2.AutoCompleteSource = AutoCompleteSource.ListItems;
		}
	}

	private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (ComboBox1.SelectedIndex > -1)
		{
			Mod_Productos.datos_producto datos_producto = default(Mod_Productos.datos_producto);
			try
			{
				int num = 0;
				object obj = Mod_Productos.buscarProdPorNombre(ComboBox1.Text, productosCompleto);
				datos_producto = ((obj != null) ? ((Mod_Productos.datos_producto)obj) : default(Mod_Productos.datos_producto));
				TextBox4.Text = datos_producto.productCodigo;
				num = Conversions.ToInteger(Mod_Productos.unidadesDisponibles(datos_producto.productId, datos_producto.productVariaciones, identificacionempresa));
				Label4.Text = Conversions.ToString(datos_producto.productVariaciones);
				Label2.Text = Conversions.ToString(num);
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

	private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (ComboBox2.SelectedIndex > -1)
		{
			Mod_Ordenes.Destino destino = default(Mod_Ordenes.Destino);
			try
			{
				object obj = Mod_Productos.buscarDestinoPorNombre(ComboBox2.Text, allDestinos);
				destino = ((obj != null) ? ((Mod_Ordenes.Destino)obj) : default(Mod_Ordenes.Destino));
				eventualid.Text = Conversions.ToString(destino.id);
				direcciontext.Text = destino.direccion;
				TextBox3.Text = destino.postal;
				localidadtext.Text = destino.localidad;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				Interaction.MsgBox("No se encontraron resultados para la busqueda");
				ProjectData.ClearProjectError();
			}
		}
	}

	private void contrareembolsocheck_CheckedChanged(object sender, EventArgs e)
	{
		if (contrareembolsocheck.Checked)
		{
			TextBox1.Enabled = true;
		}
		else
		{
			TextBox1.Enabled = false;
		}
	}

	private void Button3_Click(object sender, EventArgs e)
	{
		string left = remitotext.Text;
		if (Operators.CompareString(left, "", TextCompare: true) == 0)
		{
			Interaction.MsgBox("Debe indicar un identificador para la orden.");
			remitotext.Focus();
			return;
		}
		int selectedIndex = ComboBox1.SelectedIndex;
		checked
		{
			if (Conversions.ToDouble(TextBox6.Text) != 0.0)
			{
				if (Conversions.ToDouble(Label4.Text) == 1.0)
				{
					Selector selector = MyProject.Forms.Selector;
					selector.Label1.Text = Conversions.ToString(1);
					selector.Label2.Text = Conversions.ToString(productosCompleto[selectedIndex].productId);
					selector.Label3.Text = productosCompleto[selectedIndex].productBarrcode;
					selector.ListView1.Items.Clear();
					selector = null;
					MyProject.Forms.Selector.ShowDialog();
				}
				else if (Conversions.ToDouble(Label4.Text) == 0.0)
				{
					ListViewItem listViewItem = null;
					ListViewItem listViewItem2 = null;
					int num = int.Parse(TextBox6.Text);
					int num2 = 0;
					decimal num3 = Conversions.ToDecimal(importetext.Text);
					if (ListView1.Items.Count > 0)
					{
						listViewItem = ListView1.FindItemWithText(Conversions.ToString(productosCompleto[selectedIndex].productId), includeSubItemsInSearch: true, 0);
					}
					if (listViewItem != null)
					{
						num = int.Parse(Conversions.ToString(num)) + int.Parse(listViewItem.Text);
						string text = listViewItem.SubItems[2].Text;
						string text2 = listViewItem.SubItems[1].Text;
						if (num > int.Parse(Label2.Text))
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
						if (num > int.Parse(Label2.Text))
						{
							Interaction.MsgBox("La cantidad solicitada es mayor a la existencia en stock");
							return;
						}
						string text3 = ComboBox1.Text;
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
					Label2.Text = Conversions.ToString(0);
					ComboBox1.Text = "";
					TextBox6.Text = Conversions.ToString(0);
				}
				ComboBox1.Focus();
			}
			else
			{
				Interaction.MsgBox("Las unidades no pueden ser 0");
			}
		}
	}

	public void limpiarCampos()
	{
		remitotext.Clear();
		ComboBox2.Text = "";
		direcciontext.Clear();
		localidadtext.Clear();
		TextBox3.Clear();
		eventualid.Text = Conversions.ToString(0);
		importetext.Text = "0";
		TextBox1.Text = "0";
		TextBox7.Clear();
		Label2.Text = Conversions.ToString(0);
		Label4.Text = Conversions.ToString(0);
		Label6.Text = Conversions.ToString(0);
		Label8.Text = Conversions.ToString(0);
		TextBox4.Clear();
		ComboBox1.Text = "";
		TextBox6.Text = Conversions.ToString(0);
		ListView1.Items.Clear();
		CheckBox1.Checked = false;
		contrareembolsocheck.Checked = false;
	}

	private void ListView1_DoubleClick(object sender, EventArgs e)
	{
		if (ListView1.SelectedItems.Count <= 0)
		{
			return;
		}
		double num = 0.0;
		int num2 = (int)MessageBox.Show("Desea Eliminar el item " + ListView1.SelectedItems[0].SubItems[2].Text, "Atencion", MessageBoxButtons.YesNoCancel);
		if (num2 == 2 || num2 == 7 || num2 != 6)
		{
			return;
		}
		ListView1.SelectedItems[0].Remove();
		Label6.Text = Conversions.ToString(ListView1.Items.Count);
		foreach (ListViewItem item in ListView1.Items)
		{
			num += (double)int.Parse(item.Text);
		}
		Label8.Text = Conversions.ToString(num);
	}

	private void ListView1_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode != Keys.Delete || ListView1.SelectedItems.Count <= 0)
		{
			return;
		}
		double num = 0.0;
		int num2 = (int)MessageBox.Show("Desea Eliminar el item " + ListView1.SelectedItems[0].SubItems[2].Text, "Atencion", MessageBoxButtons.YesNoCancel);
		if (num2 == 2 || num2 == 7 || num2 != 6)
		{
			return;
		}
		ListView1.SelectedItems[0].Remove();
		Label6.Text = Conversions.ToString(ListView1.Items.Count);
		foreach (ListViewItem item in ListView1.Items)
		{
			num += (double)int.Parse(item.Text);
		}
		Label8.Text = Conversions.ToString(num);
	}

	private object buscarRemito(string remito, string tipo)
	{
		int num = 0;
		ListViewItem listViewItem = null;
		return num;
	}

	private void ComboBox2_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode != Keys.Return)
		{
			eventualid.Text = Conversions.ToString(0);
			direcciontext.Clear();
			TextBox3.Clear();
			localidadtext.Clear();
		}
	}

	private object nuevoEventual()
	{
		Mod_Ordenes.Destino destino = default(Mod_Ordenes.Destino);
		try
		{
			destino.nombre = ComboBox2.Text;
			destino.direccion = direcciontext.Text;
			destino.postal = TextBox3.Text;
			destino.localidad = localidadtext.Text;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Logger.e("Error: " + ex2.Message);
			ProjectData.ClearProjectError();
		}
		return destino;
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		string remito = remitotext.Text;
		int num = (int)MessageBox.Show("Se Creara la siguiente Orden " + remitotext.Text, "Atencion", MessageBoxButtons.YesNoCancel);
		if (num == 2 || num == 7 || num != 6)
		{
			return;
		}
		if (ListView1.Items.Count > 0)
		{
			Mod_Ordenes.ordendesalida outOrder = default(Mod_Ordenes.ordendesalida);
			outOrder.empresa = identificacionempresa;
			if (remitobtn.Checked)
			{
				outOrder.tipo = 1;
				if (Operators.ConditionalCompareObjectEqual(buscarRemito(remito, "REMITO"), 1, TextCompare: true))
				{
					Interaction.MsgBox("El Remito ya fue ingresado, utilise otro TIPO de comprobante distinto a " + tipoComprobante);
					return;
				}
			}
			if (asignacionbtn.Checked)
			{
				outOrder.tipo = 2;
				if (Operators.ConditionalCompareObjectEqual(buscarRemito(remito, "ASIGNACION"), 1, TextCompare: true))
				{
					Interaction.MsgBox("El Remito ya fue ingresado, utilise otro TIPO de comprobante distinto a " + tipoComprobante);
					return;
				}
			}
			if (otrobtn.Checked)
			{
				outOrder.tipo = 3;
				if (Operators.ConditionalCompareObjectEqual(buscarRemito(remito, "OTRO"), 1, TextCompare: true))
				{
					Interaction.MsgBox("El Remito ya fue ingresado, utilise otro TIPO de comprobante distinto a " + tipoComprobante);
					return;
				}
			}
			if (Operators.CompareString(TextBox7.Text, "", TextCompare: true) != 0)
			{
				outOrder.observacion = TextBox7.Text;
			}
			else
			{
				outOrder.observacion = "";
			}
			outOrder.numero = remitotext.Text;
			if (CheckBox1.Checked)
			{
				outOrder.prioridad = 1;
			}
			else
			{
				outOrder.prioridad = 0;
			}
			outOrder.valorCtr = decimal.Parse(Strings.Replace(TextBox1.Text, ".", ",", 1, -1, CompareMethod.Text));
			int num2 = int.Parse(eventualid.Text);
			if (num2 > 0)
			{
				outOrder.destinatario = num2;
			}
			else
			{
				int destinatario = 0;
				if (int.Parse(eventualid.Text) == 0)
				{
					object obj = nuevoEventual();
					destinatario = Conversions.ToInteger(Mod_Productos.setDestino((obj != null) ? ((Mod_Ordenes.Destino)obj) : default(Mod_Ordenes.Destino)));
				}
				outOrder.destinatario = destinatario;
			}
			outOrder.valor = decimal.Parse(Strings.Replace(importetext.Text, ".", ",", 1, -1, CompareMethod.Text));
			outOrder.estado = 0;
			int num3 = Conversions.ToInteger(Mod_Ordenes.setOutOrder(outOrder));
			if (num3 == 0)
			{
				Interaction.MsgBox("Error: La orden ya existe.");
				return;
			}
			List<Mod_Ordenes.ordenDetalleItem> list = new List<Mod_Ordenes.ordenDetalleItem>();
			foreach (ListViewItem item2 in ListView1.Items)
			{
				Mod_Ordenes.ordenDetalleItem item = default(Mod_Ordenes.ordenDetalleItem);
				item.ordenId = num3;
				item.productId = int.Parse(item2.SubItems[1].Text);
				item.varId = int.Parse(item2.SubItems[4].Text);
				item.unidades = int.Parse(item2.Text);
				item.precio = new decimal(double.Parse(item2.SubItems[5].Text));
				list.Add(item);
			}
			switch (Conversions.ToInteger(Mod_Ordenes.guardarDetalleOrden(list)))
			{
			case 1:
				if (Operators.ConditionalCompareObjectEqual(Mod_Ordenes.updateOrderStatus(num3, 1), 1, TextCompare: true))
				{
					Interaction.MsgBox("La orden se genero correctamente");
					limpiarCampos();
					Listado listado = MyProject.Forms.Listado;
					listado.loadData(1);
					listado = null;
				}
				break;
			case 0:
				Interaction.MsgBox("Ocurrio un error al guardar el detalle de la orden");
				break;
			}
		}
		else
		{
			Interaction.MsgBox("No puedes generar ordenes vacias.");
		}
	}

	private void ListView1_ColumnClick(object sender, ColumnClickEventArgs e)
	{
		Mod_Ordenaclumnas.ordenar_columnas(ListView1, RuntimeHelpers.GetObjectValue(sender), e);
	}
}
