using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Hermes.My;
using Hermes.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace Hermes;

[DesignerGenerated]
public class Entregas : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button4")]
	private Button _Button4;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button5")]
	private Button _Button5;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button6")]
	private Button _Button6;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button7")]
	private Button _Button7;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button8")]
	private Button _Button8;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("PrintDocument1")]
	private PrintDocument _PrintDocument1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button9")]
	private Button _Button9;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("PrintDocument2")]
	private PrintDocument _PrintDocument2;

	private string fecha1;

	private string comprobante;

	private string cliente;

	private string destino;

	private string direccion;

	private string bultos;

	private string remitos;

	private string observaciones;

	private string cp;

	private string localidad;

	private string zona;

	private string qrCode;

	private int subCuenta;

	private int ventana;

	private string fecha;

	[field: AccessedThroughProperty("Panel1")]
	internal virtual Panel Panel1
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

	[field: AccessedThroughProperty("TabControl1")]
	internal virtual TabControl TabControl1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Entrega")]
	internal virtual TabPage Entrega
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Eventual")]
	internal virtual TabPage Eventual
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DateTimePicker1")]
	internal virtual DateTimePicker DateTimePicker1
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

	[field: AccessedThroughProperty("ListView1")]
	internal virtual ListView ListView1
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

	[field: AccessedThroughProperty("Label16")]
	internal virtual Label Label16
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

	[field: AccessedThroughProperty("Label14")]
	internal virtual Label Label14
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

	[field: AccessedThroughProperty("Label12")]
	internal virtual Label Label12
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

	[field: AccessedThroughProperty("GroupBox1")]
	internal virtual GroupBox GroupBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ListView2")]
	internal virtual ListView ListView2
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

	[field: AccessedThroughProperty("Label9")]
	internal virtual Label Label9
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

	[field: AccessedThroughProperty("Button2")]
	internal virtual Button Button2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Button3")]
	internal virtual Button Button3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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

	internal virtual Button Button6
	{
		[CompilerGenerated]
		get
		{
			return _Button6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button6_Click;
			Button button = _Button6;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button6 = value;
			button = _Button6;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button7
	{
		[CompilerGenerated]
		get
		{
			return _Button7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button7_Click;
			Button button = _Button7;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button7 = value;
			button = _Button7;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label22")]
	internal virtual Label Label22
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label21")]
	internal virtual Label Label21
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label20")]
	internal virtual Label Label20
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label19")]
	internal virtual Label Label19
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label18")]
	internal virtual Label Label18
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label17")]
	internal virtual Label Label17
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label23")]
	internal virtual Label Label23
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label25")]
	internal virtual Label Label25
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label24")]
	internal virtual Label Label24
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Edición")]
	internal virtual TabPage Edición
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Button8
	{
		[CompilerGenerated]
		get
		{
			return _Button8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button8_Click;
			Button button = _Button8;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button8 = value;
			button = _Button8;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual PrintDocument PrintDocument1
	{
		[CompilerGenerated]
		get
		{
			return _PrintDocument1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			PrintPageEventHandler value2 = PrintDocument1_PrintPage;
			PrintDocument printDocument = _PrintDocument1;
			if (printDocument != null)
			{
				printDocument.PrintPage -= value2;
			}
			_PrintDocument1 = value;
			printDocument = _PrintDocument1;
			if (printDocument != null)
			{
				printDocument.PrintPage += value2;
			}
		}
	}

	[field: AccessedThroughProperty("PrintDialog1")]
	internal virtual PrintDialog PrintDialog1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label26")]
	internal virtual Label Label26
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Button9
	{
		[CompilerGenerated]
		get
		{
			return _Button9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button9_Click;
			Button button = _Button9;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button9 = value;
			button = _Button9;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual PrintDocument PrintDocument2
	{
		[CompilerGenerated]
		get
		{
			return _PrintDocument2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			PrintPageEventHandler value2 = PrintDocument2_PrintPage_1;
			PrintDocument printDocument = _PrintDocument2;
			if (printDocument != null)
			{
				printDocument.PrintPage -= value2;
			}
			_PrintDocument2 = value;
			printDocument = _PrintDocument2;
			if (printDocument != null)
			{
				printDocument.PrintPage += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label27")]
	internal virtual Label Label27
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

	[field: AccessedThroughProperty("Label34")]
	internal virtual Label Label34
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox6")]
	internal virtual TextBox TextBox6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label33")]
	internal virtual Label Label33
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox5")]
	internal virtual TextBox TextBox5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label32")]
	internal virtual Label Label32
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

	[field: AccessedThroughProperty("Label31")]
	internal virtual Label Label31
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

	[field: AccessedThroughProperty("Label30")]
	internal virtual Label Label30
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

	[field: AccessedThroughProperty("Label29")]
	internal virtual Label Label29
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

	[field: AccessedThroughProperty("Label28")]
	internal virtual Label Label28
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public Entregas()
	{
		base.Load += Entregas_Load;
		fecha1 = Strings.Format(MyProject.Forms.Form1_Inicio.DateTimePicker1.Value, "yyyyMMdd");
		comprobante = Conversions.ToString(0);
		cliente = string.Empty;
		destino = string.Empty;
		direccion = string.Empty;
		bultos = Conversions.ToString(0);
		remitos = Conversions.ToString(0);
		observaciones = string.Empty;
		cp = string.Empty;
		localidad = string.Empty;
		zona = string.Empty;
		qrCode = string.Empty;
		subCuenta = 0;
		ventana = 0;
		fecha = string.Empty;
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
		this.Panel1 = new System.Windows.Forms.Panel();
		this.Label2 = new System.Windows.Forms.Label();
		this.Label1 = new System.Windows.Forms.Label();
		this.TabControl1 = new System.Windows.Forms.TabControl();
		this.Entrega = new System.Windows.Forms.TabPage();
		this.Label27 = new System.Windows.Forms.Label();
		this.Label23 = new System.Windows.Forms.Label();
		this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
		this.Label8 = new System.Windows.Forms.Label();
		this.Label7 = new System.Windows.Forms.Label();
		this.ListView1 = new System.Windows.Forms.ListView();
		this.Label6 = new System.Windows.Forms.Label();
		this.Label5 = new System.Windows.Forms.Label();
		this.Label4 = new System.Windows.Forms.Label();
		this.Label3 = new System.Windows.Forms.Label();
		this.Eventual = new System.Windows.Forms.TabPage();
		this.Label25 = new System.Windows.Forms.Label();
		this.Label24 = new System.Windows.Forms.Label();
		this.Label22 = new System.Windows.Forms.Label();
		this.Label21 = new System.Windows.Forms.Label();
		this.Label20 = new System.Windows.Forms.Label();
		this.Label19 = new System.Windows.Forms.Label();
		this.Label18 = new System.Windows.Forms.Label();
		this.Label17 = new System.Windows.Forms.Label();
		this.Label16 = new System.Windows.Forms.Label();
		this.Label15 = new System.Windows.Forms.Label();
		this.Label14 = new System.Windows.Forms.Label();
		this.Label13 = new System.Windows.Forms.Label();
		this.Label12 = new System.Windows.Forms.Label();
		this.Label11 = new System.Windows.Forms.Label();
		this.GroupBox1 = new System.Windows.Forms.GroupBox();
		this.ListView2 = new System.Windows.Forms.ListView();
		this.Label10 = new System.Windows.Forms.Label();
		this.Label9 = new System.Windows.Forms.Label();
		this.Edición = new System.Windows.Forms.TabPage();
		this.TextBox7 = new System.Windows.Forms.TextBox();
		this.Label34 = new System.Windows.Forms.Label();
		this.TextBox6 = new System.Windows.Forms.TextBox();
		this.Label33 = new System.Windows.Forms.Label();
		this.TextBox5 = new System.Windows.Forms.TextBox();
		this.Label32 = new System.Windows.Forms.Label();
		this.TextBox4 = new System.Windows.Forms.TextBox();
		this.Label31 = new System.Windows.Forms.Label();
		this.TextBox3 = new System.Windows.Forms.TextBox();
		this.Label30 = new System.Windows.Forms.Label();
		this.TextBox2 = new System.Windows.Forms.TextBox();
		this.Label29 = new System.Windows.Forms.Label();
		this.TextBox1 = new System.Windows.Forms.TextBox();
		this.Label28 = new System.Windows.Forms.Label();
		this.Label26 = new System.Windows.Forms.Label();
		this.Button1 = new System.Windows.Forms.Button();
		this.Button2 = new System.Windows.Forms.Button();
		this.Button3 = new System.Windows.Forms.Button();
		this.Button4 = new System.Windows.Forms.Button();
		this.Button5 = new System.Windows.Forms.Button();
		this.Button6 = new System.Windows.Forms.Button();
		this.Button7 = new System.Windows.Forms.Button();
		this.Button8 = new System.Windows.Forms.Button();
		this.PrintDocument1 = new System.Drawing.Printing.PrintDocument();
		this.PrintDialog1 = new System.Windows.Forms.PrintDialog();
		this.Button9 = new System.Windows.Forms.Button();
		this.PrintDocument2 = new System.Drawing.Printing.PrintDocument();
		this.Panel1.SuspendLayout();
		this.TabControl1.SuspendLayout();
		this.Entrega.SuspendLayout();
		this.Eventual.SuspendLayout();
		this.GroupBox1.SuspendLayout();
		this.Edición.SuspendLayout();
		base.SuspendLayout();
		this.Panel1.BackColor = System.Drawing.Color.LimeGreen;
		this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.Panel1.Controls.Add(this.Label2);
		this.Panel1.Controls.Add(this.Label1);
		this.Panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Panel1.ForeColor = System.Drawing.SystemColors.Window;
		this.Panel1.Location = new System.Drawing.Point(61, 12);
		this.Panel1.Name = "Panel1";
		this.Panel1.Size = new System.Drawing.Size(499, 38);
		this.Panel1.TabIndex = 0;
		this.Label2.AutoSize = true;
		this.Label2.Location = new System.Drawing.Point(164, 7);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(63, 20);
		this.Label2.TabIndex = 1;
		this.Label2.Text = "Label2";
		this.Label1.AutoSize = true;
		this.Label1.Location = new System.Drawing.Point(21, 7);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(122, 20);
		this.Label1.TabIndex = 0;
		this.Label1.Text = "Comprobante:";
		this.TabControl1.Controls.Add(this.Entrega);
		this.TabControl1.Controls.Add(this.Eventual);
		this.TabControl1.Controls.Add(this.Edición);
		this.TabControl1.Location = new System.Drawing.Point(12, 56);
		this.TabControl1.Name = "TabControl1";
		this.TabControl1.SelectedIndex = 0;
		this.TabControl1.Size = new System.Drawing.Size(597, 280);
		this.TabControl1.TabIndex = 1;
		this.TabControl1.Tag = "";
		this.Entrega.Controls.Add(this.Label27);
		this.Entrega.Controls.Add(this.Label23);
		this.Entrega.Controls.Add(this.DateTimePicker1);
		this.Entrega.Controls.Add(this.Label8);
		this.Entrega.Controls.Add(this.Label7);
		this.Entrega.Controls.Add(this.ListView1);
		this.Entrega.Controls.Add(this.Label6);
		this.Entrega.Controls.Add(this.Label5);
		this.Entrega.Controls.Add(this.Label4);
		this.Entrega.Controls.Add(this.Label3);
		this.Entrega.Location = new System.Drawing.Point(4, 22);
		this.Entrega.Name = "Entrega";
		this.Entrega.Padding = new System.Windows.Forms.Padding(3);
		this.Entrega.Size = new System.Drawing.Size(589, 254);
		this.Entrega.TabIndex = 0;
		this.Entrega.Text = "Entrega";
		this.Entrega.UseVisualStyleBackColor = true;
		this.Label27.AutoSize = true;
		this.Label27.Location = new System.Drawing.Point(349, 84);
		this.Label27.Name = "Label27";
		this.Label27.Size = new System.Drawing.Size(45, 13);
		this.Label27.TabIndex = 11;
		this.Label27.Text = "Label27";
		this.Label23.AutoSize = true;
		this.Label23.Location = new System.Drawing.Point(370, 26);
		this.Label23.Name = "Label23";
		this.Label23.Size = new System.Drawing.Size(45, 13);
		this.Label23.TabIndex = 10;
		this.Label23.Text = "Label23";
		this.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
		this.DateTimePicker1.Location = new System.Drawing.Point(370, 51);
		this.DateTimePicker1.Name = "DateTimePicker1";
		this.DateTimePicker1.Size = new System.Drawing.Size(121, 20);
		this.DateTimePicker1.TabIndex = 9;
		this.Label8.AutoSize = true;
		this.Label8.Location = new System.Drawing.Point(321, 57);
		this.Label8.Name = "Label8";
		this.Label8.Size = new System.Drawing.Size(37, 13);
		this.Label8.TabIndex = 8;
		this.Label8.Text = "Diferir:";
		this.Label7.AutoSize = true;
		this.Label7.Location = new System.Drawing.Point(321, 26);
		this.Label7.Name = "Label7";
		this.Label7.Size = new System.Drawing.Size(43, 13);
		this.Label7.TabIndex = 6;
		this.Label7.Text = "Estado:";
		this.ListView1.Location = new System.Drawing.Point(6, 109);
		this.ListView1.Name = "ListView1";
		this.ListView1.Size = new System.Drawing.Size(577, 139);
		this.ListView1.TabIndex = 5;
		this.ListView1.UseCompatibleStateImageBehavior = false;
		this.ListView1.View = System.Windows.Forms.View.Details;
		this.Label6.AutoSize = true;
		this.Label6.Location = new System.Drawing.Point(123, 57);
		this.Label6.Name = "Label6";
		this.Label6.Size = new System.Drawing.Size(39, 13);
		this.Label6.TabIndex = 3;
		this.Label6.Text = "Label6";
		this.Label5.AutoSize = true;
		this.Label5.Location = new System.Drawing.Point(14, 57);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(41, 13);
		this.Label5.TabIndex = 2;
		this.Label5.Text = "Chofer:";
		this.Label4.AutoSize = true;
		this.Label4.Location = new System.Drawing.Point(123, 26);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(39, 13);
		this.Label4.TabIndex = 1;
		this.Label4.Text = "Label4";
		this.Label3.AutoSize = true;
		this.Label3.Location = new System.Drawing.Point(14, 26);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(103, 13);
		this.Label3.TabIndex = 0;
		this.Label3.Text = "Intentos de Entrega:";
		this.Eventual.Controls.Add(this.Label25);
		this.Eventual.Controls.Add(this.Label24);
		this.Eventual.Controls.Add(this.Label22);
		this.Eventual.Controls.Add(this.Label21);
		this.Eventual.Controls.Add(this.Label20);
		this.Eventual.Controls.Add(this.Label19);
		this.Eventual.Controls.Add(this.Label18);
		this.Eventual.Controls.Add(this.Label17);
		this.Eventual.Controls.Add(this.Label16);
		this.Eventual.Controls.Add(this.Label15);
		this.Eventual.Controls.Add(this.Label14);
		this.Eventual.Controls.Add(this.Label13);
		this.Eventual.Controls.Add(this.Label12);
		this.Eventual.Controls.Add(this.Label11);
		this.Eventual.Controls.Add(this.GroupBox1);
		this.Eventual.Controls.Add(this.Label10);
		this.Eventual.Controls.Add(this.Label9);
		this.Eventual.Location = new System.Drawing.Point(4, 22);
		this.Eventual.Name = "Eventual";
		this.Eventual.Padding = new System.Windows.Forms.Padding(3);
		this.Eventual.Size = new System.Drawing.Size(589, 254);
		this.Eventual.TabIndex = 1;
		this.Eventual.Text = "Eventual";
		this.Eventual.UseVisualStyleBackColor = true;
		this.Label25.AutoSize = true;
		this.Label25.Location = new System.Drawing.Point(521, 19);
		this.Label25.Name = "Label25";
		this.Label25.Size = new System.Drawing.Size(45, 13);
		this.Label25.TabIndex = 17;
		this.Label25.Text = "Label25";
		this.Label24.AutoSize = true;
		this.Label24.Location = new System.Drawing.Point(521, 45);
		this.Label24.Name = "Label24";
		this.Label24.Size = new System.Drawing.Size(45, 13);
		this.Label24.TabIndex = 16;
		this.Label24.Text = "Label24";
		this.Label22.AutoSize = true;
		this.Label22.Location = new System.Drawing.Point(333, 78);
		this.Label22.Name = "Label22";
		this.Label22.Size = new System.Drawing.Size(45, 13);
		this.Label22.TabIndex = 15;
		this.Label22.Text = "Label22";
		this.Label21.AutoSize = true;
		this.Label21.Location = new System.Drawing.Point(333, 45);
		this.Label21.Name = "Label21";
		this.Label21.Size = new System.Drawing.Size(45, 13);
		this.Label21.TabIndex = 14;
		this.Label21.Text = "Label21";
		this.Label20.AutoSize = true;
		this.Label20.Location = new System.Drawing.Point(333, 19);
		this.Label20.Name = "Label20";
		this.Label20.Size = new System.Drawing.Size(45, 13);
		this.Label20.TabIndex = 13;
		this.Label20.Text = "Label20";
		this.Label19.AutoSize = true;
		this.Label19.Location = new System.Drawing.Point(74, 78);
		this.Label19.Name = "Label19";
		this.Label19.Size = new System.Drawing.Size(45, 13);
		this.Label19.TabIndex = 12;
		this.Label19.Text = "Label19";
		this.Label18.AutoSize = true;
		this.Label18.Location = new System.Drawing.Point(74, 45);
		this.Label18.Name = "Label18";
		this.Label18.Size = new System.Drawing.Size(45, 13);
		this.Label18.TabIndex = 11;
		this.Label18.Text = "Label18";
		this.Label17.AutoSize = true;
		this.Label17.Location = new System.Drawing.Point(74, 19);
		this.Label17.Name = "Label17";
		this.Label17.Size = new System.Drawing.Size(45, 13);
		this.Label17.TabIndex = 10;
		this.Label17.Text = "Label17";
		this.Label16.AutoSize = true;
		this.Label16.Location = new System.Drawing.Point(439, 19);
		this.Label16.Name = "Label16";
		this.Label16.Size = new System.Drawing.Size(50, 13);
		this.Label16.TabIndex = 9;
		this.Label16.Text = "Ventana:";
		this.Label15.AutoSize = true;
		this.Label15.Location = new System.Drawing.Point(439, 45);
		this.Label15.Name = "Label15";
		this.Label15.Size = new System.Drawing.Size(53, 13);
		this.Label15.TabIndex = 8;
		this.Label15.Text = "Adicional:";
		this.Label14.AutoSize = true;
		this.Label14.Location = new System.Drawing.Point(251, 78);
		this.Label14.Name = "Label14";
		this.Label14.Size = new System.Drawing.Size(35, 13);
		this.Label14.TabIndex = 7;
		this.Label14.Text = "Zona:";
		this.Label13.AutoSize = true;
		this.Label13.Location = new System.Drawing.Point(251, 45);
		this.Label13.Name = "Label13";
		this.Label13.Size = new System.Drawing.Size(75, 13);
		this.Label13.TabIndex = 6;
		this.Label13.Text = "Codigo Postal:";
		this.Label12.AutoSize = true;
		this.Label12.Location = new System.Drawing.Point(251, 19);
		this.Label12.Name = "Label12";
		this.Label12.Size = new System.Drawing.Size(56, 13);
		this.Label12.TabIndex = 5;
		this.Label12.Text = "Localidad:";
		this.Label11.AutoSize = true;
		this.Label11.Location = new System.Drawing.Point(19, 78);
		this.Label11.Name = "Label11";
		this.Label11.Size = new System.Drawing.Size(55, 13);
		this.Label11.TabIndex = 4;
		this.Label11.Text = "Direccion:";
		this.GroupBox1.Controls.Add(this.ListView2);
		this.GroupBox1.Location = new System.Drawing.Point(0, 134);
		this.GroupBox1.Name = "GroupBox1";
		this.GroupBox1.Size = new System.Drawing.Size(589, 120);
		this.GroupBox1.TabIndex = 3;
		this.GroupBox1.TabStop = false;
		this.GroupBox1.Text = "Coincidencias:";
		this.ListView2.FullRowSelect = true;
		this.ListView2.GridLines = true;
		this.ListView2.Location = new System.Drawing.Point(6, 26);
		this.ListView2.Name = "ListView2";
		this.ListView2.Size = new System.Drawing.Size(577, 88);
		this.ListView2.TabIndex = 2;
		this.ListView2.UseCompatibleStateImageBehavior = false;
		this.Label10.AutoSize = true;
		this.Label10.Location = new System.Drawing.Point(19, 45);
		this.Label10.Name = "Label10";
		this.Label10.Size = new System.Drawing.Size(47, 13);
		this.Label10.TabIndex = 1;
		this.Label10.Text = "Numero:";
		this.Label9.AutoSize = true;
		this.Label9.Location = new System.Drawing.Point(17, 19);
		this.Label9.Name = "Label9";
		this.Label9.Size = new System.Drawing.Size(47, 13);
		this.Label9.TabIndex = 0;
		this.Label9.Text = "Nombre:";
		this.Edición.Controls.Add(this.TextBox7);
		this.Edición.Controls.Add(this.Label34);
		this.Edición.Controls.Add(this.TextBox6);
		this.Edición.Controls.Add(this.Label33);
		this.Edición.Controls.Add(this.TextBox5);
		this.Edición.Controls.Add(this.Label32);
		this.Edición.Controls.Add(this.TextBox4);
		this.Edición.Controls.Add(this.Label31);
		this.Edición.Controls.Add(this.TextBox3);
		this.Edición.Controls.Add(this.Label30);
		this.Edición.Controls.Add(this.TextBox2);
		this.Edición.Controls.Add(this.Label29);
		this.Edición.Controls.Add(this.TextBox1);
		this.Edición.Controls.Add(this.Label28);
		this.Edición.Controls.Add(this.Label26);
		this.Edición.Location = new System.Drawing.Point(4, 22);
		this.Edición.Name = "Edición";
		this.Edición.Padding = new System.Windows.Forms.Padding(3);
		this.Edición.Size = new System.Drawing.Size(589, 254);
		this.Edición.TabIndex = 2;
		this.Edición.Text = "Edición";
		this.Edición.UseVisualStyleBackColor = true;
		this.TextBox7.Location = new System.Drawing.Point(415, 62);
		this.TextBox7.Name = "TextBox7";
		this.TextBox7.Size = new System.Drawing.Size(100, 20);
		this.TextBox7.TabIndex = 16;
		this.Label34.AutoSize = true;
		this.Label34.Location = new System.Drawing.Point(356, 65);
		this.Label34.Name = "Label34";
		this.Label34.Size = new System.Drawing.Size(33, 13);
		this.Label34.TabIndex = 15;
		this.Label34.Text = "Flete:";
		this.TextBox6.Location = new System.Drawing.Point(136, 203);
		this.TextBox6.Name = "TextBox6";
		this.TextBox6.Size = new System.Drawing.Size(380, 20);
		this.TextBox6.TabIndex = 14;
		this.Label33.AutoSize = true;
		this.Label33.Location = new System.Drawing.Point(49, 206);
		this.Label33.Name = "Label33";
		this.Label33.Size = new System.Drawing.Size(81, 13);
		this.Label33.TabIndex = 13;
		this.Label33.Text = "Observaciones:";
		this.TextBox5.Location = new System.Drawing.Point(111, 140);
		this.TextBox5.Name = "TextBox5";
		this.TextBox5.Size = new System.Drawing.Size(218, 20);
		this.TextBox5.TabIndex = 12;
		this.Label32.AutoSize = true;
		this.Label32.Location = new System.Drawing.Point(52, 143);
		this.Label32.Name = "Label32";
		this.Label32.Size = new System.Drawing.Size(39, 13);
		this.Label32.TabIndex = 11;
		this.Label32.Text = "Bultos:";
		this.TextBox4.Location = new System.Drawing.Point(415, 88);
		this.TextBox4.Name = "TextBox4";
		this.TextBox4.Size = new System.Drawing.Size(100, 20);
		this.TextBox4.TabIndex = 10;
		this.Label31.AutoSize = true;
		this.Label31.Location = new System.Drawing.Point(356, 91);
		this.Label31.Name = "Label31";
		this.Label31.Size = new System.Drawing.Size(59, 13);
		this.Label31.TabIndex = 9;
		this.Label31.Text = "Declarado:";
		this.TextBox3.Location = new System.Drawing.Point(111, 114);
		this.TextBox3.Name = "TextBox3";
		this.TextBox3.Size = new System.Drawing.Size(218, 20);
		this.TextBox3.TabIndex = 8;
		this.Label30.AutoSize = true;
		this.Label30.Location = new System.Drawing.Point(52, 117);
		this.Label30.Name = "Label30";
		this.Label30.Size = new System.Drawing.Size(56, 13);
		this.Label30.TabIndex = 7;
		this.Label30.Text = "Localidad:";
		this.TextBox2.Location = new System.Drawing.Point(111, 88);
		this.TextBox2.Name = "TextBox2";
		this.TextBox2.Size = new System.Drawing.Size(218, 20);
		this.TextBox2.TabIndex = 6;
		this.Label29.AutoSize = true;
		this.Label29.Location = new System.Drawing.Point(52, 91);
		this.Label29.Name = "Label29";
		this.Label29.Size = new System.Drawing.Size(24, 13);
		this.Label29.TabIndex = 5;
		this.Label29.Text = "CP:";
		this.TextBox1.Location = new System.Drawing.Point(111, 62);
		this.TextBox1.Name = "TextBox1";
		this.TextBox1.Size = new System.Drawing.Size(218, 20);
		this.TextBox1.TabIndex = 4;
		this.Label28.AutoSize = true;
		this.Label28.Location = new System.Drawing.Point(51, 65);
		this.Label28.Name = "Label28";
		this.Label28.Size = new System.Drawing.Size(52, 13);
		this.Label28.TabIndex = 3;
		this.Label28.Text = "Domicilio:";
		this.Label26.AutoSize = true;
		this.Label26.Location = new System.Drawing.Point(538, 238);
		this.Label26.Name = "Label26";
		this.Label26.Size = new System.Drawing.Size(45, 13);
		this.Label26.TabIndex = 2;
		this.Label26.Text = "Label26";
		this.Button1.Location = new System.Drawing.Point(12, 351);
		this.Button1.Name = "Button1";
		this.Button1.Size = new System.Drawing.Size(75, 23);
		this.Button1.TabIndex = 2;
		this.Button1.Text = "Guardar";
		this.Button1.UseVisualStyleBackColor = true;
		this.Button2.Location = new System.Drawing.Point(93, 351);
		this.Button2.Name = "Button2";
		this.Button2.Size = new System.Drawing.Size(75, 23);
		this.Button2.TabIndex = 3;
		this.Button2.Text = "Posicionar";
		this.Button2.UseVisualStyleBackColor = true;
		this.Button3.Location = new System.Drawing.Point(174, 351);
		this.Button3.Name = "Button3";
		this.Button3.Size = new System.Drawing.Size(75, 23);
		this.Button3.TabIndex = 4;
		this.Button3.Text = "Editar";
		this.Button3.UseVisualStyleBackColor = true;
		this.Button3.Visible = false;
		this.Button4.Enabled = false;
		this.Button4.Location = new System.Drawing.Point(255, 351);
		this.Button4.Name = "Button4";
		this.Button4.Size = new System.Drawing.Size(75, 23);
		this.Button4.TabIndex = 5;
		this.Button4.Text = "Borrar";
		this.Button4.UseVisualStyleBackColor = true;
		this.Button5.Location = new System.Drawing.Point(530, 351);
		this.Button5.Name = "Button5";
		this.Button5.Size = new System.Drawing.Size(75, 23);
		this.Button5.TabIndex = 6;
		this.Button5.Text = "Salir";
		this.Button5.UseVisualStyleBackColor = true;
		this.Button6.Location = new System.Drawing.Point(12, 12);
		this.Button6.Name = "Button6";
		this.Button6.Size = new System.Drawing.Size(43, 38);
		this.Button6.TabIndex = 2;
		this.Button6.Text = "<<";
		this.Button6.UseVisualStyleBackColor = true;
		this.Button7.Location = new System.Drawing.Point(566, 12);
		this.Button7.Name = "Button7";
		this.Button7.Size = new System.Drawing.Size(43, 38);
		this.Button7.TabIndex = 7;
		this.Button7.Text = ">>";
		this.Button7.UseVisualStyleBackColor = true;
		this.Button8.Location = new System.Drawing.Point(336, 351);
		this.Button8.Name = "Button8";
		this.Button8.Size = new System.Drawing.Size(75, 23);
		this.Button8.TabIndex = 8;
		this.Button8.Text = "etiqueta";
		this.Button8.UseVisualStyleBackColor = true;
		this.Button8.Visible = false;
		this.PrintDialog1.UseEXDialog = true;
		this.Button9.Location = new System.Drawing.Point(432, 351);
		this.Button9.Name = "Button9";
		this.Button9.Size = new System.Drawing.Size(75, 23);
		this.Button9.TabIndex = 9;
		this.Button9.Text = "Button9";
		this.Button9.UseVisualStyleBackColor = true;
		this.Button9.Visible = false;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.SystemColors.Control;
		base.ClientSize = new System.Drawing.Size(621, 386);
		base.Controls.Add(this.Button9);
		base.Controls.Add(this.Button8);
		base.Controls.Add(this.Button7);
		base.Controls.Add(this.Button6);
		base.Controls.Add(this.Button5);
		base.Controls.Add(this.Button4);
		base.Controls.Add(this.Button3);
		base.Controls.Add(this.Button2);
		base.Controls.Add(this.Button1);
		base.Controls.Add(this.TabControl1);
		base.Controls.Add(this.Panel1);
		base.Name = "Entregas";
		this.Text = "Entregas";
		this.Panel1.ResumeLayout(false);
		this.Panel1.PerformLayout();
		this.TabControl1.ResumeLayout(false);
		this.Entrega.ResumeLayout(false);
		this.Entrega.PerformLayout();
		this.Eventual.ResumeLayout(false);
		this.Eventual.PerformLayout();
		this.GroupBox1.ResumeLayout(false);
		this.Edición.ResumeLayout(false);
		this.Edición.PerformLayout();
		base.ResumeLayout(false);
	}

	private void Entregas_Load(object sender, EventArgs e)
	{
		if (Conversions.ToDouble(MySettingsProperty.Settings.Permiso) >= 8.0)
		{
			Button4.Enabled = true;
		}
		string sql = "SELECT * FROM Eventuales WHERE Cliente LIKE '" + Label17.Text + "%'";
		Mod_Sentencias.cargar_datos_lv_completa(ListView2, sql, Label6);
		string sql2 = ("SELECT * FROM Planchada WHERE Comprobante = " + Label2.Text) ?? "";
		Mod_Sentencias.cargar_datos_lv_completa(ListView1, sql2, Label4);
	}

	private void Button7_Click(object sender, EventArgs e)
	{
		try
		{
			int num = Conversions.ToInteger(Label2.Text);
			num = checked(num + 1);
			Label2.Text = num.ToString();
			string sql = ("SELECT * FROM Planchada WHERE Comprobante = " + Label2.Text) ?? "";
			Mod_Sentencias.cargar_datos_lv_completa(ListView1, sql, Label4);
			if (ListView1.Items.Count > 0)
			{
				Label18.Text = ListView1.Items[0].Text;
				Label2.Text = ListView1.Items[0].SubItems[1].Text;
				Label17.Text = ListView1.Items[0].SubItems[4].Text;
				Label19.Text = ListView1.Items[0].SubItems[5].Text;
				Label21.Text = ListView1.Items[0].SubItems[6].Text;
				Label20.Text = ListView1.Items[0].SubItems[7].Text;
				Label22.Text = ListView1.Items[0].SubItems[17].Text;
				Label6.Text = ListView1.Items[0].SubItems[20].Text;
				Label23.Text = ListView1.Items[0].SubItems[23].Text;
				Label27.Text = ListView1.Items[0].SubItems[28].Text;
				string sql2 = "SELECT * FROM Eventuales WHERE Cliente LIKE '" + Label17.Text + "%'";
				Mod_Sentencias.cargar_datos_lv_completa(ListView2, sql2, Label6);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objExcepcion = ex;
			Logger.e("Error con excepción y traza", objExcepcion, new StackFrame(fNeedFileInfo: true));
			ProjectData.ClearProjectError();
		}
	}

	private void Button5_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void Button4_Click(object sender, EventArgs e)
	{
		DialogResult dialogResult = MessageBox.Show("ATENCION, los datos borrados no se podran recuperar.", "Borrar Datos", MessageBoxButtons.YesNo);
		if (dialogResult == DialogResult.Yes)
		{
			string text = Strings.Format(DateTimePicker1.Value, "yyyyMMdd");
			string sQL = "DELETE FROM Planchada WHERE guia='" + Label27.Text + "'";
			Mod_ConeccionBD.BD_Sentencia(sQL);
		}
		if (dialogResult != DialogResult.No)
		{
		}
	}

	private void Button6_Click(object sender, EventArgs e)
	{
		try
		{
			int num = Conversions.ToInteger(Label2.Text);
			num = checked(num - 1);
			Label2.Text = num.ToString();
			string sql = ("SELECT * FROM Planchada WHERE Comprobante = " + Label2.Text) ?? "";
			Mod_Sentencias.cargar_datos_lv_completa(ListView1, sql, Label4);
			if (ListView1.Items.Count > 0)
			{
				Label18.Text = ListView1.Items[0].Text;
				Label2.Text = ListView1.Items[0].SubItems[1].Text;
				Label17.Text = ListView1.Items[0].SubItems[4].Text;
				Label19.Text = ListView1.Items[0].SubItems[5].Text;
				Label21.Text = ListView1.Items[0].SubItems[6].Text;
				Label20.Text = ListView1.Items[0].SubItems[7].Text;
				Label22.Text = ListView1.Items[0].SubItems[17].Text;
				Label6.Text = ListView1.Items[0].SubItems[20].Text;
				Label23.Text = ListView1.Items[0].SubItems[23].Text;
				Label27.Text = ListView1.Items[0].SubItems[28].Text;
				string sql2 = "SELECT * FROM Eventuales WHERE Cliente LIKE '" + Label17.Text + "%'";
				Mod_Sentencias.cargar_datos_lv_completa(ListView2, sql2, Label6);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objExcepcion = ex;
			Logger.e("Error con excepción y traza", objExcepcion, new StackFrame(fNeedFileInfo: true));
			ProjectData.ClearProjectError();
		}
	}

	private void Button8_Click(object sender, EventArgs e)
	{
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		DataTable dataTable = new DataTable("X1");
		string text = "SELECT Comprobante,Observaciones, Remitos,Cliente, Destino, Domicilio, Sub, Bultos, Localidad, CP, (SELECT Descripcion FROM Zonas WHERE zona=planchada.zona) as zona FROM Planchada WHERE  comprobante=" + Label2.Text + " and Fecha='" + fecha1 + "'";
		MySqlDataAdapter val = new MySqlDataAdapter(text, Mod_Sentencias.cnn);
		((DbDataAdapter)(object)val).Fill(dataTable);
		comprobante = Conversions.ToString(dataTable.Rows[0]["Comprobante"]);
		cliente = Conversions.ToString(dataTable.Rows[0]["Cliente"]);
		destino = Conversions.ToString(dataTable.Rows[0]["Destino"]);
		direccion = Conversions.ToString(dataTable.Rows[0]["Domicilio"]);
		remitos = Conversions.ToString(Operators.ConcatenateObject("N° Trans: ", dataTable.Rows[0]["Remitos"]));
		observaciones = Conversions.ToString(dataTable.Rows[0]["Observaciones"]);
		cp = Conversions.ToString(Operators.ConcatenateObject("Cp: ", dataTable.Rows[0]["Cp"]));
		localidad = Conversions.ToString(Operators.ConcatenateObject("Loc: ", dataTable.Rows[0]["Localidad"]));
		zona = Conversions.ToString(Operators.ConcatenateObject("Zona: ", dataTable.Rows[0]["zona"]));
		PrintDialog1.Document = PrintDocument1;
		PrintDialog1.PrinterSettings = PrintDocument1.PrinterSettings;
		PrintDialog1.AllowSomePages = true;
		if (PrintDialog1.ShowDialog() == DialogResult.OK)
		{
			int num = Conversions.ToInteger(dataTable.Rows[0]["Bultos"]);
			for (int i = 1; i <= num; i = checked(i + 1))
			{
				bultos = Conversions.ToString(Operators.ConcatenateObject("Bulto: " + Conversions.ToString(i) + "/", dataTable.Rows[0]["Bultos"]));
				qrCode = dataTable.Rows[0]["Remitos"].ToString() + Conversions.ToString(i);
				PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings;
				PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
				PrintDocument1.DefaultPageSettings.Landscape = false;
				printPreviewDialog.WindowState = FormWindowState.Maximized;
				printPreviewDialog.Document = PrintDocument1;
				PrintDocument1.Print();
			}
		}
	}

	private void PrintDocument1_PrintPage(object sender, PrintPageEventArgs e)
	{
		Font font = new Font("Arial", 6.75f, FontStyle.Italic, GraphicsUnit.Point, 0);
		Font font2 = new Font("Arial", 8.75f, FontStyle.Italic, GraphicsUnit.Point, 0);
		Font font3 = new Font("Arial", 10.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		int num = 0;
		checked
		{
			int num2 = 0 + MySettingsProperty.Settings.pHvalor;
			int num3 = 0 + MySettingsProperty.Settings.pVvalor;
			string text = MyProject.Forms.Form1_Inicio.nombreusuario.Text;
			e.Graphics.DrawLine(Pens.Brown, num2 + 2, num3 + 5, num2 + 300, num3 + 5);
			e.Graphics.DrawLine(Pens.Brown, num2 + 2, num3 + 5, num2 + 2, num3 + 185);
			e.Graphics.DrawLine(Pens.Brown, num2 + 300, num3 + 5, num2 + 300, num3 + 185);
			e.Graphics.DrawLine(Pens.Brown, num2 + 2, num3 + 185, num2 + 300, num3 + 185);
			Image image = (Image)Mod_QR.qrcodegen(qrCode);
			Image etrans = Resources.etrans2;
			e.Graphics.DrawImage(image, num2 + 10, num3 + 70);
			e.Graphics.DrawImage(etrans, num2 + 10, num3 + 10);
			int num4 = default(int);
			e.Graphics.DrawString(remitos, font3, Brushes.Black, num2 + 150, num3 + num4 + 10);
			e.Graphics.DrawString(bultos, font3, Brushes.Black, num2 + 110, num3 + num4 + 70);
			e.Graphics.DrawString(localidad, font3, Brushes.Black, num2 + 110, num3 + num4 + 90);
			e.Graphics.DrawString(cp, font3, Brushes.Black, num2 + 110, num3 + num4 + 110);
			e.Graphics.DrawString(zona, font3, Brushes.Black, num2 + 110, num3 + num4 + 130);
		}
	}

	private void Button9_Click(object sender, EventArgs e)
	{
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		DataTable dataTable = new DataTable("X1");
		string text = "SELECT Comprobante,Observaciones, fecha, ventana, Remitos,Cliente,sub, Destino, Domicilio, Bultos, Localidad, CP, (SELECT Descripcion FROM Zonas WHERE zona=planchada.zona) as zona FROM Planchada WHERE  comprobante=" + Label2.Text + " and Fecha='" + fecha1 + "'";
		MySqlDataAdapter val = new MySqlDataAdapter(text, Mod_Sentencias.cnn);
		((DbDataAdapter)(object)val).Fill(dataTable);
		comprobante = Conversions.ToString(dataTable.Rows[0]["Comprobante"]);
		cliente = Conversions.ToString(dataTable.Rows[0]["Cliente"]);
		destino = Conversions.ToString(dataTable.Rows[0]["Destino"]);
		direccion = Conversions.ToString(dataTable.Rows[0]["Domicilio"]);
		ventana = Conversions.ToInteger(dataTable.Rows[0]["Ventana"]);
		fecha = Conversions.ToString(dataTable.Rows[0]["fecha"]);
		remitos = Conversions.ToString(dataTable.Rows[0]["Remitos"]);
		observaciones = Conversions.ToString(dataTable.Rows[0]["Observaciones"]);
		cp = Conversions.ToString(dataTable.Rows[0]["Cp"]);
		localidad = Conversions.ToString(dataTable.Rows[0]["Localidad"]);
		zona = Conversions.ToString(dataTable.Rows[0]["zona"]);
		subCuenta = Conversions.ToInteger(dataTable.Rows[0]["sub"]);
		PrintDialog1.Document = PrintDocument2;
		PrintDialog1.PrinterSettings = PrintDocument2.PrinterSettings;
		PrintDialog1.AllowSomePages = true;
		if (PrintDialog1.ShowDialog() == DialogResult.OK)
		{
			bultos = Conversions.ToString(Operators.ConcatenateObject("Bulto: ", dataTable.Rows[0]["Bultos"]));
			qrCode = dataTable.Rows[0]["Remitos"].ToString() + Conversions.ToString(1);
			PrintDocument2.PrinterSettings = PrintDialog1.PrinterSettings;
			PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
			PrintDocument2.DefaultPageSettings.Landscape = false;
			printPreviewDialog.WindowState = FormWindowState.Maximized;
			printPreviewDialog.Document = PrintDocument2;
			printPreviewDialog.Show();
		}
	}

	private void PrintDocument2_PrintPage_1(object sender, PrintPageEventArgs e)
	{
		Font font = new Font("Arial", 6.75f, FontStyle.Italic, GraphicsUnit.Point, 0);
		Font font2 = new Font("Arial", 16.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		Font font3 = new Font("Arial", 14.75f, FontStyle.Italic, GraphicsUnit.Point, 0);
		int num = 0;
		checked
		{
			int num2 = 0 + MySettingsProperty.Settings.pHvalor;
			int num3 = 0 + MySettingsProperty.Settings.pVvalor;
			string text = MyProject.Forms.Form1_Inicio.nombreusuario.Text;
			e.Graphics.DrawLine(Pens.Brown, 2, 5, 750, 5);
			e.Graphics.DrawLine(Pens.Brown, 2, 5, 2, 1100);
			e.Graphics.DrawLine(Pens.Brown, 750, 5, 750, 1100);
			e.Graphics.DrawLine(Pens.Brown, 2, 1100, 750, 1100);
			e.Graphics.DrawLine(Pens.Brown, 2, 130, 750, 130);
			int num4 = default(int);
			if (subCuenta == 11)
			{
				e.Graphics.DrawString("ORDEN DE RECOLECCION", font2, Brushes.Black, 250f, 135f);
				e.Graphics.DrawString("Retirar de:", font2, Brushes.Black, 110f, num4 + 360);
				e.Graphics.DrawString(destino, font3, Brushes.Black, 310f, num4 + 360);
			}
			else
			{
				e.Graphics.DrawString("ORDEN DE ENTREGA", font2, Brushes.Black, 250f, 135f);
				e.Graphics.DrawString("Entregar a:", font2, Brushes.Black, 110f, num4 + 360);
				e.Graphics.DrawString(destino, font3, Brushes.Black, 310f, num4 + 360);
			}
			e.Graphics.DrawLine(Pens.Brown, 2, 162, 750, 162);
			e.Graphics.DrawString("Fecha:", font2, Brushes.Black, 110f, num4 + 180);
			e.Graphics.DrawString("Chofer:", font2, Brushes.Black, 110f, num4 + 220);
			Image image = (Image)Mod_QR.qrcodegen(qrCode);
			Image logo_etrans = Resources.logo_etrans;
			e.Graphics.DrawImage(image, 650, 30);
			e.Graphics.DrawImage(logo_etrans, 30, 30);
			e.Graphics.DrawString("Comprobante:", font2, Brushes.Black, 110f, num4 + 280);
			e.Graphics.DrawString(comprobante, font3, Brushes.Black, 310f, num4 + 280);
			e.Graphics.DrawString("Cliente:", font2, Brushes.Black, 110f, num4 + 320);
			e.Graphics.DrawString(cliente, font3, Brushes.Black, 310f, num4 + 320);
			e.Graphics.DrawString("Numero Trans:", font2, Brushes.Black, 110f, num4 + 400);
			e.Graphics.DrawString(remitos, font3, Brushes.Black, 310f, num4 + 400);
			e.Graphics.DrawString("Direccion:", font2, Brushes.Black, 110f, num4 + 440);
			e.Graphics.DrawString(direccion, font3, Brushes.Black, 310f, num4 + 440);
			e.Graphics.DrawString("Bultos:", font2, Brushes.Black, num2 + 110, num3 + num4 + 480);
			e.Graphics.DrawString(bultos, font3, Brushes.Black, num2 + 310, num3 + num4 + 480);
			e.Graphics.DrawString("Localidad:", font2, Brushes.Black, num2 + 110, num3 + num4 + 520);
			e.Graphics.DrawString(localidad, font3, Brushes.Black, num2 + 310, num3 + num4 + 520);
			e.Graphics.DrawString("Codigo Postal:", font2, Brushes.Black, num2 + 110, num3 + num4 + 560);
			e.Graphics.DrawString(cp, font3, Brushes.Black, num2 + 310, num3 + num4 + 560);
			e.Graphics.DrawString("Zona:", font2, Brushes.Black, num2 + 110, num3 + num4 + 600);
			e.Graphics.DrawString(zona, font3, Brushes.Black, num2 + 310, num3 + num4 + 600);
			e.Graphics.DrawString("Observaciones:", font2, Brushes.Black, 110f, num4 + 640);
			e.Graphics.DrawString(observaciones, font3, Brushes.Black, 310f, num4 + 640);
			e.Graphics.DrawString("Firma:", font2, Brushes.Black, 110f, num4 + 680);
			e.Graphics.DrawString("____________________", font2, Brushes.Black, 310f, num4 + 680);
			e.Graphics.DrawString("Aclaracion:", font2, Brushes.Black, 110f, num4 + 720);
			e.Graphics.DrawString("____________________", font2, Brushes.Black, 310f, num4 + 720);
			e.Graphics.DrawString("D.N.I.:", font2, Brushes.Black, 110f, num4 + 760);
			e.Graphics.DrawString("____________________", font2, Brushes.Black, 310f, num4 + 760);
		}
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		try
		{
			int.TryParse(Label27.Text, out var result);
			string text = TextBox1.Text;
			string text2 = TextBox2.Text;
			string text3 = TextBox3.Text;
			int.TryParse(TextBox5.Text, out var result2);
			string text4 = TextBox6.Text;
			string expression = TextBox7.Text.ToString();
			string expression2 = TextBox4.Text.ToString();
			expression = Strings.Replace(expression, ",", ".", 1, -1, CompareMethod.Text);
			expression2 = Strings.Replace(expression2, ",", ".", 1, -1, CompareMethod.Text);
			string sQL = "UPDATE planchada SET domicilio = '" + text + "', cp = '" + text2 + "', \r\n                                        localidad = '" + text3 + "', bultos = " + Conversions.ToString(result2) + ", \r\n                                        observaciones = '" + text4 + "', flete = '" + expression + "',\r\n                                        declarado = '" + expression2 + "' WHERE guia = " + Conversions.ToString(result);
			int num = Conversions.ToInteger(Mod_ConeccionBD.BD_Sentencia(sQL));
			if (num == 1)
			{
				Interaction.MsgBox("Registro Editado");
			}
			else
			{
				Interaction.MsgBox("Ocurrio un Error al editar. Revise los datos ingresados.");
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox(ex2.Message);
			ProjectData.ClearProjectError();
		}
	}
}
