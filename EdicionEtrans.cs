using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Hermes.My;
using Hermes.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace Hermes;

[DesignerGenerated]
public class EdicionEtrans : Form
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
	[AccessedThroughProperty("TextBox5")]
	private TextBox _TextBox5;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("TextBox9")]
	private TextBox _TextBox9;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button4")]
	private Button _Button4;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button3")]
	private Button _Button3;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("print_etiqueta")]
	private PrintDocument _print_etiqueta;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("print_orden")]
	private PrintDocument _print_orden;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("CheckBox2")]
	private CheckBox _CheckBox2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("CheckBox1")]
	private CheckBox _CheckBox1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("print_entrega")]
	private PrintDocument _print_entrega;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("print_recoleccion")]
	private PrintDocument _print_recoleccion;

	private int valE_cp;

	private string valE_localidad;

	private string fecha1;

	private string Et_bultos;

	private string Et_remitos;

	private string Et_cp;

	private string Et_localidad;

	private string Et_zona;

	private string Et_des;

	private string Et_qrCode;

	private string print_comprobante;

	private string print_cliente;

	private string print_destino;

	private string print_direccion;

	private string print_piso;

	private string print_ofi;

	private string print_bloq;

	private string print_bultos;

	private string print_remitos;

	private string print_observaciones;

	private string print_cp;

	private string print_localidad;

	private string print_zona;

	private string print_qrcode;

	private int print_subCuenta;

	private int print_ventana;

	private string print_chofer;

	private string print_fecha;

	private int compro_retiro;

	private string print_numerochofer;

	private int print_guia;

	private string print_cel;

	private string print_tel;

	private string print_voucher;

	private int dato;

	private int pagina;

	private int dato_r;

	private int bultosTotales;

	[field: AccessedThroughProperty("SplitContainer1")]
	internal virtual SplitContainer SplitContainer1
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

	[field: AccessedThroughProperty("TextBox1")]
	internal virtual TextBox TextBox1
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

	[field: AccessedThroughProperty("Envio")]
	internal virtual TabPage Envio
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

	[field: AccessedThroughProperty("ComboBox2")]
	internal virtual ComboBox ComboBox2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DateTimePicker2")]
	internal virtual DateTimePicker DateTimePicker2
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

	[field: AccessedThroughProperty("DateTimePicker1")]
	internal virtual DateTimePicker DateTimePicker1
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

	[field: AccessedThroughProperty("Remitente")]
	internal virtual TabPage Remitente
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual TextBox TextBox5
	{
		[CompilerGenerated]
		get
		{
			return _TextBox5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = TextBox5_TextChanged;
			TextBox textBox = _TextBox5;
			if (textBox != null)
			{
				textBox.TextChanged -= value2;
			}
			_TextBox5 = value;
			textBox = _TextBox5;
			if (textBox != null)
			{
				textBox.TextChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("TextBox4")]
	internal virtual TextBox TextBox4
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

	[field: AccessedThroughProperty("TextBox2")]
	internal virtual TextBox TextBox2
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

	[field: AccessedThroughProperty("Label10")]
	internal virtual Label Label10
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Destinatario")]
	internal virtual TabPage Destinatario
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

	[field: AccessedThroughProperty("Label27")]
	internal virtual Label Label27
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

	[field: AccessedThroughProperty("Label31")]
	internal virtual Label Label31
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

	[field: AccessedThroughProperty("Label29")]
	internal virtual Label Label29
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

	[field: AccessedThroughProperty("Label32")]
	internal virtual Label Label32
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox10")]
	internal virtual TextBox TextBox10
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual TextBox TextBox9
	{
		[CompilerGenerated]
		get
		{
			return _TextBox9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = TextBox9_TextChanged;
			TextBox textBox = _TextBox9;
			if (textBox != null)
			{
				textBox.TextChanged -= value2;
			}
			_TextBox9 = value;
			textBox = _TextBox9;
			if (textBox != null)
			{
				textBox.TextChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("TextBox8")]
	internal virtual TextBox TextBox8
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

	[field: AccessedThroughProperty("TextBox6")]
	internal virtual TextBox TextBox6
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

	[field: AccessedThroughProperty("Label23")]
	internal virtual Label Label23
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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

	[field: AccessedThroughProperty("Label39")]
	internal virtual Label Label39
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label38")]
	internal virtual Label Label38
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label37")]
	internal virtual Label Label37
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label36")]
	internal virtual Label Label36
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label35")]
	internal virtual Label Label35
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox13")]
	internal virtual TextBox TextBox13
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox12")]
	internal virtual TextBox TextBox12
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox11")]
	internal virtual TextBox TextBox11
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label44")]
	internal virtual Label Label44
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label42")]
	internal virtual Label Label42
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label40")]
	internal virtual Label Label40
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox16")]
	internal virtual TextBox TextBox16
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox15")]
	internal virtual TextBox TextBox15
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox14")]
	internal virtual TextBox TextBox14
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label45")]
	internal virtual Label Label45
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label43")]
	internal virtual Label Label43
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label41")]
	internal virtual Label Label41
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

	[field: AccessedThroughProperty("ComboBox3")]
	internal virtual ComboBox ComboBox3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual PrintDocument print_etiqueta
	{
		[CompilerGenerated]
		get
		{
			return _print_etiqueta;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			PrintPageEventHandler value2 = print_etiqueta_PrintPage;
			PrintDocument printDocument = _print_etiqueta;
			if (printDocument != null)
			{
				printDocument.PrintPage -= value2;
			}
			_print_etiqueta = value;
			printDocument = _print_etiqueta;
			if (printDocument != null)
			{
				printDocument.PrintPage += value2;
			}
		}
	}

	internal virtual PrintDocument print_orden
	{
		[CompilerGenerated]
		get
		{
			return _print_orden;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			PrintPageEventHandler value2 = print_orden_PrintPage;
			PrintDocument printDocument = _print_orden;
			if (printDocument != null)
			{
				printDocument.PrintPage -= value2;
			}
			_print_orden = value;
			printDocument = _print_orden;
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

	[field: AccessedThroughProperty("TextBox17")]
	internal virtual TextBox TextBox17
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox18")]
	internal virtual TextBox TextBox18
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

	[field: AccessedThroughProperty("TextBox19")]
	internal virtual TextBox TextBox19
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

	internal virtual CheckBox CheckBox2
	{
		[CompilerGenerated]
		get
		{
			return _CheckBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = CheckBox2_CheckStateChanged;
			CheckBox checkBox = _CheckBox2;
			if (checkBox != null)
			{
				checkBox.CheckStateChanged -= value2;
			}
			_CheckBox2 = value;
			checkBox = _CheckBox2;
			if (checkBox != null)
			{
				checkBox.CheckStateChanged += value2;
			}
		}
	}

	internal virtual CheckBox CheckBox1
	{
		[CompilerGenerated]
		get
		{
			return _CheckBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = CheckBox1_CheckStateChanged;
			CheckBox checkBox = _CheckBox1;
			if (checkBox != null)
			{
				checkBox.CheckStateChanged -= value2;
			}
			_CheckBox1 = value;
			checkBox = _CheckBox1;
			if (checkBox != null)
			{
				checkBox.CheckStateChanged += value2;
			}
		}
	}

	internal virtual PrintDocument print_entrega
	{
		[CompilerGenerated]
		get
		{
			return _print_entrega;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			PrintPageEventHandler value2 = print_entrega_PrintPage;
			PrintDocument printDocument = _print_entrega;
			if (printDocument != null)
			{
				printDocument.PrintPage -= value2;
			}
			_print_entrega = value;
			printDocument = _print_entrega;
			if (printDocument != null)
			{
				printDocument.PrintPage += value2;
			}
		}
	}

	internal virtual PrintDocument print_recoleccion
	{
		[CompilerGenerated]
		get
		{
			return _print_recoleccion;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			PrintPageEventHandler value2 = print_recoleccion_PrintPage;
			PrintDocument printDocument = _print_recoleccion;
			if (printDocument != null)
			{
				printDocument.PrintPage -= value2;
			}
			_print_recoleccion = value;
			printDocument = _print_recoleccion;
			if (printDocument != null)
			{
				printDocument.PrintPage += value2;
			}
		}
	}

	public EdicionEtrans()
	{
		base.Load += EdicionEtrans_Load;
		valE_cp = 0;
		valE_localidad = string.Empty;
		fecha1 = Strings.Format(MyProject.Forms.Form1_Inicio.DateTimePicker1.Value, "yyyyMMdd");
		Et_bultos = Conversions.ToString(0);
		Et_remitos = Conversions.ToString(0);
		Et_cp = string.Empty;
		Et_localidad = string.Empty;
		Et_zona = string.Empty;
		Et_des = string.Empty;
		Et_qrCode = string.Empty;
		print_comprobante = Conversions.ToString(0);
		print_cliente = string.Empty;
		print_destino = string.Empty;
		print_direccion = string.Empty;
		print_piso = string.Empty;
		print_ofi = string.Empty;
		print_bloq = string.Empty;
		print_bultos = Conversions.ToString(0);
		print_remitos = Conversions.ToString(0);
		print_observaciones = string.Empty;
		print_cp = string.Empty;
		print_localidad = string.Empty;
		print_zona = string.Empty;
		print_qrcode = string.Empty;
		print_subCuenta = 0;
		print_ventana = 0;
		print_chofer = string.Empty;
		print_fecha = string.Empty;
		compro_retiro = 0;
		print_numerochofer = string.Empty;
		print_guia = 0;
		print_cel = string.Empty;
		print_tel = string.Empty;
		print_voucher = string.Empty;
		dato = 0;
		pagina = 0;
		dato_r = 0;
		bultosTotales = 0;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hermes.EdicionEtrans));
		this.SplitContainer1 = new System.Windows.Forms.SplitContainer();
		this.CheckBox2 = new System.Windows.Forms.CheckBox();
		this.CheckBox1 = new System.Windows.Forms.CheckBox();
		this.Button4 = new System.Windows.Forms.Button();
		this.Button3 = new System.Windows.Forms.Button();
		this.Button1 = new System.Windows.Forms.Button();
		this.Label1 = new System.Windows.Forms.Label();
		this.TextBox1 = new System.Windows.Forms.TextBox();
		this.Button2 = new System.Windows.Forms.Button();
		this.TabControl1 = new System.Windows.Forms.TabControl();
		this.Envio = new System.Windows.Forms.TabPage();
		this.ComboBox3 = new System.Windows.Forms.ComboBox();
		this.Label39 = new System.Windows.Forms.Label();
		this.Label38 = new System.Windows.Forms.Label();
		this.Label37 = new System.Windows.Forms.Label();
		this.Label36 = new System.Windows.Forms.Label();
		this.Label35 = new System.Windows.Forms.Label();
		this.Label28 = new System.Windows.Forms.Label();
		this.Label27 = new System.Windows.Forms.Label();
		this.Label26 = new System.Windows.Forms.Label();
		this.Label9 = new System.Windows.Forms.Label();
		this.Label8 = new System.Windows.Forms.Label();
		this.Label7 = new System.Windows.Forms.Label();
		this.ComboBox2 = new System.Windows.Forms.ComboBox();
		this.DateTimePicker2 = new System.Windows.Forms.DateTimePicker();
		this.ComboBox1 = new System.Windows.Forms.ComboBox();
		this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
		this.Label6 = new System.Windows.Forms.Label();
		this.Label5 = new System.Windows.Forms.Label();
		this.Label4 = new System.Windows.Forms.Label();
		this.Label3 = new System.Windows.Forms.Label();
		this.Label2 = new System.Windows.Forms.Label();
		this.Remitente = new System.Windows.Forms.TabPage();
		this.TextBox18 = new System.Windows.Forms.TextBox();
		this.Label25 = new System.Windows.Forms.Label();
		this.TextBox13 = new System.Windows.Forms.TextBox();
		this.TextBox12 = new System.Windows.Forms.TextBox();
		this.TextBox11 = new System.Windows.Forms.TextBox();
		this.Label44 = new System.Windows.Forms.Label();
		this.Label42 = new System.Windows.Forms.Label();
		this.Label40 = new System.Windows.Forms.Label();
		this.Label31 = new System.Windows.Forms.Label();
		this.Label30 = new System.Windows.Forms.Label();
		this.Label29 = new System.Windows.Forms.Label();
		this.TextBox5 = new System.Windows.Forms.TextBox();
		this.TextBox4 = new System.Windows.Forms.TextBox();
		this.TextBox3 = new System.Windows.Forms.TextBox();
		this.TextBox2 = new System.Windows.Forms.TextBox();
		this.Label16 = new System.Windows.Forms.Label();
		this.Label15 = new System.Windows.Forms.Label();
		this.Label14 = new System.Windows.Forms.Label();
		this.Label13 = new System.Windows.Forms.Label();
		this.Label12 = new System.Windows.Forms.Label();
		this.Label11 = new System.Windows.Forms.Label();
		this.Label10 = new System.Windows.Forms.Label();
		this.Destinatario = new System.Windows.Forms.TabPage();
		this.TextBox19 = new System.Windows.Forms.TextBox();
		this.Label34 = new System.Windows.Forms.Label();
		this.TextBox17 = new System.Windows.Forms.TextBox();
		this.TextBox16 = new System.Windows.Forms.TextBox();
		this.TextBox15 = new System.Windows.Forms.TextBox();
		this.TextBox14 = new System.Windows.Forms.TextBox();
		this.Label45 = new System.Windows.Forms.Label();
		this.Label43 = new System.Windows.Forms.Label();
		this.Label41 = new System.Windows.Forms.Label();
		this.Label33 = new System.Windows.Forms.Label();
		this.Label32 = new System.Windows.Forms.Label();
		this.TextBox10 = new System.Windows.Forms.TextBox();
		this.TextBox9 = new System.Windows.Forms.TextBox();
		this.TextBox8 = new System.Windows.Forms.TextBox();
		this.TextBox7 = new System.Windows.Forms.TextBox();
		this.TextBox6 = new System.Windows.Forms.TextBox();
		this.Label24 = new System.Windows.Forms.Label();
		this.Label23 = new System.Windows.Forms.Label();
		this.Label22 = new System.Windows.Forms.Label();
		this.Label21 = new System.Windows.Forms.Label();
		this.Label20 = new System.Windows.Forms.Label();
		this.Label19 = new System.Windows.Forms.Label();
		this.Label18 = new System.Windows.Forms.Label();
		this.Label17 = new System.Windows.Forms.Label();
		this.print_etiqueta = new System.Drawing.Printing.PrintDocument();
		this.print_orden = new System.Drawing.Printing.PrintDocument();
		this.PrintDialog1 = new System.Windows.Forms.PrintDialog();
		this.print_entrega = new System.Drawing.Printing.PrintDocument();
		this.print_recoleccion = new System.Drawing.Printing.PrintDocument();
		this.SplitContainer1.Panel1.SuspendLayout();
		this.SplitContainer1.Panel2.SuspendLayout();
		this.SplitContainer1.SuspendLayout();
		this.TabControl1.SuspendLayout();
		this.Envio.SuspendLayout();
		this.Remitente.SuspendLayout();
		this.Destinatario.SuspendLayout();
		base.SuspendLayout();
		this.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.SplitContainer1.Location = new System.Drawing.Point(0, 0);
		this.SplitContainer1.Name = "SplitContainer1";
		this.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
		this.SplitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
		this.SplitContainer1.Panel1.Controls.Add(this.CheckBox2);
		this.SplitContainer1.Panel1.Controls.Add(this.CheckBox1);
		this.SplitContainer1.Panel1.Controls.Add(this.Button4);
		this.SplitContainer1.Panel1.Controls.Add(this.Button3);
		this.SplitContainer1.Panel1.Controls.Add(this.Button1);
		this.SplitContainer1.Panel1.Controls.Add(this.Label1);
		this.SplitContainer1.Panel1.Controls.Add(this.TextBox1);
		this.SplitContainer1.Panel1.Controls.Add(this.Button2);
		this.SplitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
		this.SplitContainer1.Panel2.Controls.Add(this.TabControl1);
		this.SplitContainer1.Size = new System.Drawing.Size(928, 437);
		this.SplitContainer1.SplitterDistance = 77;
		this.SplitContainer1.TabIndex = 0;
		this.CheckBox2.AutoSize = true;
		this.CheckBox2.Location = new System.Drawing.Point(581, 45);
		this.CheckBox2.Name = "CheckBox2";
		this.CheckBox2.Size = new System.Drawing.Size(63, 17);
		this.CheckBox2.TabIndex = 13;
		this.CheckBox2.Text = "Entrega";
		this.CheckBox2.UseVisualStyleBackColor = true;
		this.CheckBox1.AutoSize = true;
		this.CheckBox1.Location = new System.Drawing.Point(497, 45);
		this.CheckBox1.Name = "CheckBox1";
		this.CheckBox1.Size = new System.Drawing.Size(86, 17);
		this.CheckBox1.TabIndex = 12;
		this.CheckBox1.Text = "Recoleccion";
		this.CheckBox1.UseVisualStyleBackColor = true;
		this.Button4.Location = new System.Drawing.Point(416, 41);
		this.Button4.Name = "Button4";
		this.Button4.Size = new System.Drawing.Size(75, 23);
		this.Button4.TabIndex = 11;
		this.Button4.Text = "Orden";
		this.Button4.UseVisualStyleBackColor = true;
		this.Button3.Location = new System.Drawing.Point(416, 12);
		this.Button3.Name = "Button3";
		this.Button3.Size = new System.Drawing.Size(75, 23);
		this.Button3.TabIndex = 10;
		this.Button3.Text = "Etiqueta";
		this.Button3.UseVisualStyleBackColor = true;
		this.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
		this.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
		this.Button1.Image = (System.Drawing.Image)resources.GetObject("Button1.Image");
		this.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.Button1.Location = new System.Drawing.Point(12, 37);
		this.Button1.Name = "Button1";
		this.Button1.Size = new System.Drawing.Size(283, 31);
		this.Button1.TabIndex = 2;
		this.Button1.Text = "Consultar";
		this.Button1.UseVisualStyleBackColor = true;
		this.Label1.AutoSize = true;
		this.Label1.Location = new System.Drawing.Point(13, 15);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(92, 13);
		this.Label1.TabIndex = 1;
		this.Label1.Text = "Número de Envio:";
		this.TextBox1.Location = new System.Drawing.Point(111, 12);
		this.TextBox1.Name = "TextBox1";
		this.TextBox1.Size = new System.Drawing.Size(184, 20);
		this.TextBox1.TabIndex = 0;
		this.Button2.Image = (System.Drawing.Image)resources.GetObject("Button2.Image");
		this.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
		this.Button2.Location = new System.Drawing.Point(837, 12);
		this.Button2.Name = "Button2";
		this.Button2.Size = new System.Drawing.Size(75, 57);
		this.Button2.TabIndex = 9;
		this.Button2.Text = "Guardar";
		this.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
		this.Button2.UseVisualStyleBackColor = true;
		this.TabControl1.Controls.Add(this.Envio);
		this.TabControl1.Controls.Add(this.Remitente);
		this.TabControl1.Controls.Add(this.Destinatario);
		this.TabControl1.Location = new System.Drawing.Point(12, 3);
		this.TabControl1.Name = "TabControl1";
		this.TabControl1.SelectedIndex = 0;
		this.TabControl1.Size = new System.Drawing.Size(904, 341);
		this.TabControl1.TabIndex = 0;
		this.Envio.BackColor = System.Drawing.SystemColors.Control;
		this.Envio.Controls.Add(this.ComboBox3);
		this.Envio.Controls.Add(this.Label39);
		this.Envio.Controls.Add(this.Label38);
		this.Envio.Controls.Add(this.Label37);
		this.Envio.Controls.Add(this.Label36);
		this.Envio.Controls.Add(this.Label35);
		this.Envio.Controls.Add(this.Label28);
		this.Envio.Controls.Add(this.Label27);
		this.Envio.Controls.Add(this.Label26);
		this.Envio.Controls.Add(this.Label9);
		this.Envio.Controls.Add(this.Label8);
		this.Envio.Controls.Add(this.Label7);
		this.Envio.Controls.Add(this.ComboBox2);
		this.Envio.Controls.Add(this.DateTimePicker2);
		this.Envio.Controls.Add(this.ComboBox1);
		this.Envio.Controls.Add(this.DateTimePicker1);
		this.Envio.Controls.Add(this.Label6);
		this.Envio.Controls.Add(this.Label5);
		this.Envio.Controls.Add(this.Label4);
		this.Envio.Controls.Add(this.Label3);
		this.Envio.Controls.Add(this.Label2);
		this.Envio.Location = new System.Drawing.Point(4, 22);
		this.Envio.Name = "Envio";
		this.Envio.Padding = new System.Windows.Forms.Padding(3);
		this.Envio.Size = new System.Drawing.Size(896, 315);
		this.Envio.TabIndex = 0;
		this.Envio.Text = "Envio";
		this.ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.ComboBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.ComboBox3.FormattingEnabled = true;
		this.ComboBox3.Location = new System.Drawing.Point(331, 56);
		this.ComboBox3.Name = "ComboBox3";
		this.ComboBox3.Size = new System.Drawing.Size(209, 24);
		this.ComboBox3.TabIndex = 21;
		this.Label39.AutoSize = true;
		this.Label39.Location = new System.Drawing.Point(562, 190);
		this.Label39.Name = "Label39";
		this.Label39.Size = new System.Drawing.Size(45, 13);
		this.Label39.TabIndex = 20;
		this.Label39.Text = "Label39";
		this.Label38.AutoSize = true;
		this.Label38.Location = new System.Drawing.Point(430, 190);
		this.Label38.Name = "Label38";
		this.Label38.Size = new System.Drawing.Size(86, 13);
		this.Label38.TabIndex = 19;
		this.Label38.Text = "Número Externo:";
		this.Label37.AutoSize = true;
		this.Label37.Location = new System.Drawing.Point(818, 16);
		this.Label37.Name = "Label37";
		this.Label37.Size = new System.Drawing.Size(45, 13);
		this.Label37.TabIndex = 18;
		this.Label37.Text = "Label37";
		this.Label36.AutoSize = true;
		this.Label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label36.Location = new System.Drawing.Point(370, 16);
		this.Label36.Name = "Label36";
		this.Label36.Size = new System.Drawing.Size(45, 13);
		this.Label36.TabIndex = 17;
		this.Label36.Text = "Label36";
		this.Label35.AutoSize = true;
		this.Label35.Location = new System.Drawing.Point(272, 16);
		this.Label35.Name = "Label35";
		this.Label35.Size = new System.Drawing.Size(92, 13);
		this.Label35.TabIndex = 16;
		this.Label35.Text = "Número de Envio:";
		this.Label28.AutoSize = true;
		this.Label28.Location = new System.Drawing.Point(182, 259);
		this.Label28.Name = "Label28";
		this.Label28.Size = new System.Drawing.Size(45, 13);
		this.Label28.TabIndex = 15;
		this.Label28.Text = "Label28";
		this.Label27.AutoSize = true;
		this.Label27.Location = new System.Drawing.Point(182, 224);
		this.Label27.Name = "Label27";
		this.Label27.Size = new System.Drawing.Size(45, 13);
		this.Label27.TabIndex = 14;
		this.Label27.Text = "Label27";
		this.Label26.AutoSize = true;
		this.Label26.Location = new System.Drawing.Point(182, 190);
		this.Label26.Name = "Label26";
		this.Label26.Size = new System.Drawing.Size(45, 13);
		this.Label26.TabIndex = 13;
		this.Label26.Text = "Label26";
		this.Label9.AutoSize = true;
		this.Label9.Location = new System.Drawing.Point(39, 259);
		this.Label9.Name = "Label9";
		this.Label9.Size = new System.Drawing.Size(39, 13);
		this.Label9.TabIndex = 11;
		this.Label9.Text = "Bultos:";
		this.Label8.AutoSize = true;
		this.Label8.Location = new System.Drawing.Point(39, 224);
		this.Label8.Name = "Label8";
		this.Label8.Size = new System.Drawing.Size(51, 13);
		this.Label8.TabIndex = 10;
		this.Label8.Text = "Volumen:";
		this.Label7.AutoSize = true;
		this.Label7.Location = new System.Drawing.Point(39, 190);
		this.Label7.Name = "Label7";
		this.Label7.Size = new System.Drawing.Size(34, 13);
		this.Label7.TabIndex = 0;
		this.Label7.Text = "Peso:";
		this.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.ComboBox2.Enabled = false;
		this.ComboBox2.FormattingEnabled = true;
		this.ComboBox2.Items.AddRange(new object[3] { "1", "2", "3" });
		this.ComboBox2.Location = new System.Drawing.Point(565, 149);
		this.ComboBox2.Name = "ComboBox2";
		this.ComboBox2.Size = new System.Drawing.Size(104, 21);
		this.ComboBox2.TabIndex = 8;
		this.DateTimePicker2.Enabled = false;
		this.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
		this.DateTimePicker2.Location = new System.Drawing.Point(565, 108);
		this.DateTimePicker2.Name = "DateTimePicker2";
		this.DateTimePicker2.Size = new System.Drawing.Size(104, 20);
		this.DateTimePicker2.TabIndex = 7;
		this.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.ComboBox1.Enabled = false;
		this.ComboBox1.FormattingEnabled = true;
		this.ComboBox1.Items.AddRange(new object[2] { "1", "2" });
		this.ComboBox1.Location = new System.Drawing.Point(185, 149);
		this.ComboBox1.Name = "ComboBox1";
		this.ComboBox1.Size = new System.Drawing.Size(140, 21);
		this.ComboBox1.TabIndex = 6;
		this.DateTimePicker1.Enabled = false;
		this.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
		this.DateTimePicker1.Location = new System.Drawing.Point(185, 108);
		this.DateTimePicker1.Name = "DateTimePicker1";
		this.DateTimePicker1.Size = new System.Drawing.Size(104, 20);
		this.DateTimePicker1.TabIndex = 5;
		this.Label6.AutoSize = true;
		this.Label6.Location = new System.Drawing.Point(430, 152);
		this.Label6.Name = "Label6";
		this.Label6.Size = new System.Drawing.Size(90, 13);
		this.Label6.TabIndex = 4;
		this.Label6.Text = "Ventana Entrega:";
		this.Label5.AutoSize = true;
		this.Label5.Location = new System.Drawing.Point(430, 114);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(80, 13);
		this.Label5.TabIndex = 3;
		this.Label5.Text = "Fecha Entrega:";
		this.Label4.AutoSize = true;
		this.Label4.Location = new System.Drawing.Point(39, 152);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(81, 13);
		this.Label4.TabIndex = 2;
		this.Label4.Text = "Ventana Retiro:";
		this.Label3.AutoSize = true;
		this.Label3.Location = new System.Drawing.Point(39, 114);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(71, 13);
		this.Label3.TabIndex = 1;
		this.Label3.Text = "Fecha Retiro:";
		this.Label2.AutoSize = true;
		this.Label2.Location = new System.Drawing.Point(282, 61);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(43, 13);
		this.Label2.TabIndex = 0;
		this.Label2.Text = "Estado:";
		this.Remitente.BackColor = System.Drawing.SystemColors.Control;
		this.Remitente.Controls.Add(this.TextBox18);
		this.Remitente.Controls.Add(this.Label25);
		this.Remitente.Controls.Add(this.TextBox13);
		this.Remitente.Controls.Add(this.TextBox12);
		this.Remitente.Controls.Add(this.TextBox11);
		this.Remitente.Controls.Add(this.Label44);
		this.Remitente.Controls.Add(this.Label42);
		this.Remitente.Controls.Add(this.Label40);
		this.Remitente.Controls.Add(this.Label31);
		this.Remitente.Controls.Add(this.Label30);
		this.Remitente.Controls.Add(this.Label29);
		this.Remitente.Controls.Add(this.TextBox5);
		this.Remitente.Controls.Add(this.TextBox4);
		this.Remitente.Controls.Add(this.TextBox3);
		this.Remitente.Controls.Add(this.TextBox2);
		this.Remitente.Controls.Add(this.Label16);
		this.Remitente.Controls.Add(this.Label15);
		this.Remitente.Controls.Add(this.Label14);
		this.Remitente.Controls.Add(this.Label13);
		this.Remitente.Controls.Add(this.Label12);
		this.Remitente.Controls.Add(this.Label11);
		this.Remitente.Controls.Add(this.Label10);
		this.Remitente.Location = new System.Drawing.Point(4, 22);
		this.Remitente.Name = "Remitente";
		this.Remitente.Padding = new System.Windows.Forms.Padding(3);
		this.Remitente.Size = new System.Drawing.Size(896, 315);
		this.Remitente.TabIndex = 1;
		this.Remitente.Text = "Remitente";
		this.TextBox18.Location = new System.Drawing.Point(687, 146);
		this.TextBox18.Name = "TextBox18";
		this.TextBox18.Size = new System.Drawing.Size(100, 20);
		this.TextBox18.TabIndex = 24;
		this.Label25.AutoSize = true;
		this.Label25.Location = new System.Drawing.Point(644, 149);
		this.Label25.Name = "Label25";
		this.Label25.Size = new System.Drawing.Size(37, 13);
		this.Label25.TabIndex = 23;
		this.Label25.Text = "Altura:";
		this.TextBox13.Location = new System.Drawing.Point(687, 185);
		this.TextBox13.Name = "TextBox13";
		this.TextBox13.Size = new System.Drawing.Size(100, 20);
		this.TextBox13.TabIndex = 22;
		this.TextBox13.Text = "0";
		this.TextBox12.Location = new System.Drawing.Point(415, 185);
		this.TextBox12.Name = "TextBox12";
		this.TextBox12.Size = new System.Drawing.Size(100, 20);
		this.TextBox12.TabIndex = 21;
		this.TextBox12.Text = "0";
		this.TextBox11.Location = new System.Drawing.Point(167, 185);
		this.TextBox11.Name = "TextBox11";
		this.TextBox11.Size = new System.Drawing.Size(100, 20);
		this.TextBox11.TabIndex = 20;
		this.TextBox11.Text = "0";
		this.Label44.AutoSize = true;
		this.Label44.Location = new System.Drawing.Point(595, 188);
		this.Label44.Name = "Label44";
		this.Label44.Size = new System.Drawing.Size(73, 13);
		this.Label44.TabIndex = 19;
		this.Label44.Text = "Bloque/Torre:";
		this.Label42.AutoSize = true;
		this.Label42.Location = new System.Drawing.Point(329, 188);
		this.Label42.Name = "Label42";
		this.Label42.Size = new System.Drawing.Size(71, 13);
		this.Label42.TabIndex = 17;
		this.Label42.Text = "Dpto/Oficina:";
		this.Label40.AutoSize = true;
		this.Label40.Location = new System.Drawing.Point(110, 188);
		this.Label40.Name = "Label40";
		this.Label40.Size = new System.Drawing.Size(30, 13);
		this.Label40.TabIndex = 15;
		this.Label40.Text = "Piso:";
		this.Label31.AutoSize = true;
		this.Label31.Location = new System.Drawing.Point(526, 235);
		this.Label31.Name = "Label31";
		this.Label31.Size = new System.Drawing.Size(45, 13);
		this.Label31.TabIndex = 14;
		this.Label31.Text = "Label31";
		this.Label30.AutoSize = true;
		this.Label30.Location = new System.Drawing.Point(507, 32);
		this.Label30.Name = "Label30";
		this.Label30.Size = new System.Drawing.Size(45, 13);
		this.Label30.TabIndex = 13;
		this.Label30.Text = "Label30";
		this.Label29.AutoSize = true;
		this.Label29.Location = new System.Drawing.Point(92, 32);
		this.Label29.Name = "Label29";
		this.Label29.Size = new System.Drawing.Size(45, 13);
		this.Label29.TabIndex = 11;
		this.Label29.Text = "Label29";
		this.TextBox5.Location = new System.Drawing.Point(337, 232);
		this.TextBox5.Name = "TextBox5";
		this.TextBox5.Size = new System.Drawing.Size(88, 20);
		this.TextBox5.TabIndex = 10;
		this.TextBox4.Location = new System.Drawing.Point(95, 146);
		this.TextBox4.Name = "TextBox4";
		this.TextBox4.Size = new System.Drawing.Size(495, 20);
		this.TextBox4.TabIndex = 9;
		this.TextBox3.Location = new System.Drawing.Point(510, 104);
		this.TextBox3.Name = "TextBox3";
		this.TextBox3.Size = new System.Drawing.Size(325, 20);
		this.TextBox3.TabIndex = 8;
		this.TextBox2.Location = new System.Drawing.Point(95, 104);
		this.TextBox2.Name = "TextBox2";
		this.TextBox2.Size = new System.Drawing.Size(296, 20);
		this.TextBox2.TabIndex = 7;
		this.Label16.AutoSize = true;
		this.Label16.Location = new System.Drawing.Point(447, 235);
		this.Label16.Name = "Label16";
		this.Label16.Size = new System.Drawing.Size(56, 13);
		this.Label16.TabIndex = 6;
		this.Label16.Text = "Localidad:";
		this.Label15.AutoSize = true;
		this.Label15.Location = new System.Drawing.Point(307, 235);
		this.Label15.Name = "Label15";
		this.Label15.Size = new System.Drawing.Size(24, 13);
		this.Label15.TabIndex = 5;
		this.Label15.Text = "CP:";
		this.Label14.AutoSize = true;
		this.Label14.Location = new System.Drawing.Point(32, 149);
		this.Label14.Name = "Label14";
		this.Label14.Size = new System.Drawing.Size(55, 13);
		this.Label14.TabIndex = 4;
		this.Label14.Text = "Dirección:";
		this.Label13.AutoSize = true;
		this.Label13.Location = new System.Drawing.Point(447, 107);
		this.Label13.Name = "Label13";
		this.Label13.Size = new System.Drawing.Size(42, 13);
		this.Label13.TabIndex = 3;
		this.Label13.Text = "Celular:";
		this.Label12.AutoSize = true;
		this.Label12.Location = new System.Drawing.Point(32, 107);
		this.Label12.Name = "Label12";
		this.Label12.Size = new System.Drawing.Size(52, 13);
		this.Label12.TabIndex = 2;
		this.Label12.Text = "Telefono:";
		this.Label11.AutoSize = true;
		this.Label11.Location = new System.Drawing.Point(447, 32);
		this.Label11.Name = "Label11";
		this.Label11.Size = new System.Drawing.Size(35, 13);
		this.Label11.TabIndex = 1;
		this.Label11.Text = "Email:";
		this.Label10.AutoSize = true;
		this.Label10.Location = new System.Drawing.Point(32, 32);
		this.Label10.Name = "Label10";
		this.Label10.Size = new System.Drawing.Size(42, 13);
		this.Label10.TabIndex = 0;
		this.Label10.Text = "Cliente:";
		this.Destinatario.BackColor = System.Drawing.SystemColors.Control;
		this.Destinatario.Controls.Add(this.TextBox19);
		this.Destinatario.Controls.Add(this.Label34);
		this.Destinatario.Controls.Add(this.TextBox17);
		this.Destinatario.Controls.Add(this.TextBox16);
		this.Destinatario.Controls.Add(this.TextBox15);
		this.Destinatario.Controls.Add(this.TextBox14);
		this.Destinatario.Controls.Add(this.Label45);
		this.Destinatario.Controls.Add(this.Label43);
		this.Destinatario.Controls.Add(this.Label41);
		this.Destinatario.Controls.Add(this.Label33);
		this.Destinatario.Controls.Add(this.Label32);
		this.Destinatario.Controls.Add(this.TextBox10);
		this.Destinatario.Controls.Add(this.TextBox9);
		this.Destinatario.Controls.Add(this.TextBox8);
		this.Destinatario.Controls.Add(this.TextBox7);
		this.Destinatario.Controls.Add(this.TextBox6);
		this.Destinatario.Controls.Add(this.Label24);
		this.Destinatario.Controls.Add(this.Label23);
		this.Destinatario.Controls.Add(this.Label22);
		this.Destinatario.Controls.Add(this.Label21);
		this.Destinatario.Controls.Add(this.Label20);
		this.Destinatario.Controls.Add(this.Label19);
		this.Destinatario.Controls.Add(this.Label18);
		this.Destinatario.Controls.Add(this.Label17);
		this.Destinatario.Location = new System.Drawing.Point(4, 22);
		this.Destinatario.Name = "Destinatario";
		this.Destinatario.Size = new System.Drawing.Size(896, 315);
		this.Destinatario.TabIndex = 2;
		this.Destinatario.Text = "Destinatario";
		this.TextBox19.Location = new System.Drawing.Point(657, 149);
		this.TextBox19.Name = "TextBox19";
		this.TextBox19.Size = new System.Drawing.Size(100, 20);
		this.TextBox19.TabIndex = 26;
		this.Label34.AutoSize = true;
		this.Label34.Location = new System.Drawing.Point(614, 152);
		this.Label34.Name = "Label34";
		this.Label34.Size = new System.Drawing.Size(37, 13);
		this.Label34.TabIndex = 25;
		this.Label34.Text = "Altura:";
		this.TextBox17.Location = new System.Drawing.Point(564, 238);
		this.TextBox17.Name = "TextBox17";
		this.TextBox17.Size = new System.Drawing.Size(240, 20);
		this.TextBox17.TabIndex = 22;
		this.TextBox16.Location = new System.Drawing.Point(657, 186);
		this.TextBox16.Name = "TextBox16";
		this.TextBox16.Size = new System.Drawing.Size(100, 20);
		this.TextBox16.TabIndex = 21;
		this.TextBox16.Text = "0";
		this.TextBox15.Location = new System.Drawing.Point(450, 186);
		this.TextBox15.Name = "TextBox15";
		this.TextBox15.Size = new System.Drawing.Size(100, 20);
		this.TextBox15.TabIndex = 20;
		this.TextBox15.Text = "0";
		this.TextBox14.Location = new System.Drawing.Point(231, 186);
		this.TextBox14.Name = "TextBox14";
		this.TextBox14.Size = new System.Drawing.Size(100, 20);
		this.TextBox14.TabIndex = 19;
		this.TextBox14.Text = "0";
		this.Label45.AutoSize = true;
		this.Label45.Location = new System.Drawing.Point(578, 189);
		this.Label45.Name = "Label45";
		this.Label45.Size = new System.Drawing.Size(73, 13);
		this.Label45.TabIndex = 18;
		this.Label45.Text = "Bloque/Torre:";
		this.Label43.AutoSize = true;
		this.Label43.Location = new System.Drawing.Point(360, 189);
		this.Label43.Name = "Label43";
		this.Label43.Size = new System.Drawing.Size(77, 13);
		this.Label43.TabIndex = 17;
		this.Label43.Text = "Depto/Oficina:";
		this.Label41.AutoSize = true;
		this.Label41.Location = new System.Drawing.Point(195, 189);
		this.Label41.Name = "Label41";
		this.Label41.Size = new System.Drawing.Size(30, 13);
		this.Label41.TabIndex = 16;
		this.Label41.Text = "Piso:";
		this.Label33.AutoSize = true;
		this.Label33.Location = new System.Drawing.Point(588, 32);
		this.Label33.Name = "Label33";
		this.Label33.Size = new System.Drawing.Size(45, 13);
		this.Label33.TabIndex = 14;
		this.Label33.Text = "Label33";
		this.Label32.AutoSize = true;
		this.Label32.Location = new System.Drawing.Point(127, 32);
		this.Label32.Name = "Label32";
		this.Label32.Size = new System.Drawing.Size(45, 13);
		this.Label32.TabIndex = 13;
		this.Label32.Text = "Label32";
		this.TextBox10.Location = new System.Drawing.Point(130, 270);
		this.TextBox10.Name = "TextBox10";
		this.TextBox10.Size = new System.Drawing.Size(674, 20);
		this.TextBox10.TabIndex = 12;
		this.TextBox9.Location = new System.Drawing.Point(375, 238);
		this.TextBox9.Name = "TextBox9";
		this.TextBox9.Size = new System.Drawing.Size(100, 20);
		this.TextBox9.TabIndex = 11;
		this.TextBox8.Location = new System.Drawing.Point(130, 149);
		this.TextBox8.Name = "TextBox8";
		this.TextBox8.Size = new System.Drawing.Size(420, 20);
		this.TextBox8.TabIndex = 10;
		this.TextBox7.Location = new System.Drawing.Point(564, 109);
		this.TextBox7.Name = "TextBox7";
		this.TextBox7.Size = new System.Drawing.Size(299, 20);
		this.TextBox7.TabIndex = 9;
		this.TextBox6.Location = new System.Drawing.Point(130, 109);
		this.TextBox6.Name = "TextBox6";
		this.TextBox6.Size = new System.Drawing.Size(327, 20);
		this.TextBox6.TabIndex = 8;
		this.Label24.AutoSize = true;
		this.Label24.Location = new System.Drawing.Point(20, 273);
		this.Label24.Name = "Label24";
		this.Label24.Size = new System.Drawing.Size(81, 13);
		this.Label24.TabIndex = 7;
		this.Label24.Text = "Observaciones:";
		this.Label23.AutoSize = true;
		this.Label23.Location = new System.Drawing.Point(494, 241);
		this.Label23.Name = "Label23";
		this.Label23.Size = new System.Drawing.Size(56, 13);
		this.Label23.TabIndex = 6;
		this.Label23.Text = "Localidad:";
		this.Label22.AutoSize = true;
		this.Label22.Location = new System.Drawing.Point(267, 241);
		this.Label22.Name = "Label22";
		this.Label22.Size = new System.Drawing.Size(23, 13);
		this.Label22.TabIndex = 5;
		this.Label22.Text = "Cp:";
		this.Label21.AutoSize = true;
		this.Label21.Location = new System.Drawing.Point(20, 152);
		this.Label21.Name = "Label21";
		this.Label21.Size = new System.Drawing.Size(55, 13);
		this.Label21.TabIndex = 4;
		this.Label21.Text = "Direccion:";
		this.Label20.AutoSize = true;
		this.Label20.Location = new System.Drawing.Point(494, 112);
		this.Label20.Name = "Label20";
		this.Label20.Size = new System.Drawing.Size(42, 13);
		this.Label20.TabIndex = 3;
		this.Label20.Text = "Celular:";
		this.Label19.AutoSize = true;
		this.Label19.Location = new System.Drawing.Point(20, 112);
		this.Label19.Name = "Label19";
		this.Label19.Size = new System.Drawing.Size(52, 13);
		this.Label19.TabIndex = 2;
		this.Label19.Text = "Telefono:";
		this.Label18.AutoSize = true;
		this.Label18.Location = new System.Drawing.Point(481, 32);
		this.Label18.Name = "Label18";
		this.Label18.Size = new System.Drawing.Size(35, 13);
		this.Label18.TabIndex = 1;
		this.Label18.Text = "Email:";
		this.Label17.AutoSize = true;
		this.Label17.Location = new System.Drawing.Point(20, 32);
		this.Label17.Name = "Label17";
		this.Label17.Size = new System.Drawing.Size(47, 13);
		this.Label17.TabIndex = 0;
		this.Label17.Text = "Nombre:";
		this.PrintDialog1.UseEXDialog = true;
		base.AcceptButton = this.Button1;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(928, 437);
		base.Controls.Add(this.SplitContainer1);
		base.Name = "EdicionEtrans";
		this.Text = "Edicion de Envios";
		this.SplitContainer1.Panel1.ResumeLayout(false);
		this.SplitContainer1.Panel1.PerformLayout();
		this.SplitContainer1.Panel2.ResumeLayout(false);
		this.SplitContainer1.ResumeLayout(false);
		this.TabControl1.ResumeLayout(false);
		this.Envio.ResumeLayout(false);
		this.Envio.PerformLayout();
		this.Remitente.ResumeLayout(false);
		this.Remitente.PerformLayout();
		this.Destinatario.ResumeLayout(false);
		this.Destinatario.PerformLayout();
		base.ResumeLayout(false);
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected O, but got Unknown
		if (Operators.CompareString(TextBox1.Text, "", TextCompare: true) != 0)
		{
			Button2.Enabled = true;
			try
			{
				try
				{
					string value = TextBox1.Text;
					int estado = Conversions.ToInteger(Mod_Etrans.estado_web_etrans(Conversions.ToInteger(value)));
					string text = Conversions.ToString(Mod_Etrans.estado_int_string(estado));
					string sQL = "UPDATE etransEnvios SET estado='" + text + "' WHERE id_envio=" + TextBox1.Text;
					string text2 = Conversions.ToString(Mod_ConeccionBD.BD_Sentencia(sQL));
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					Interaction.MsgBox(ex2.Message);
					ProjectData.ClearProjectError();
				}
				string text3 = "SELECT id_hermes, id_envio, Bultos, Volumen, kilos, Cliente, U_mail ,U_telefono, U_cel, U_fecha, U_ventana, U_calle,U_numero_puerta, U_piso, U_dpto_oficina, U_bloque_torre, U_cp, U_localidad, U_provincia, Destinatario, D_mail, D_telefono, D_cel, D_fecha, D_ventana, D_calle, D_numero_puerta, D_piso, D_dpto_oficina, D_bloque_torre, D_cp, D_localidad, D_provincia, Observaciones, numero_interno, id_retiro, estado FROM etransEnvios WHERE id_envio = " + TextBox1.Text;
				DataTable dataTable = new DataTable("x");
				MySqlDataAdapter val = new MySqlDataAdapter(text3, Mod_Sentencias.cnn);
				((DbDataAdapter)(object)val).Fill(dataTable);
				Label37.Text = Conversions.ToString(dataTable.Rows[0]["id_hermes"]);
				Label36.Text = Conversions.ToString(dataTable.Rows[0]["id_envio"]);
				Label28.Text = Conversions.ToString(dataTable.Rows[0]["Bultos"]);
				Label27.Text = Conversions.ToString(dataTable.Rows[0]["Volumen"]);
				Label26.Text = Conversions.ToString(dataTable.Rows[0]["Kilos"]);
				Label29.Text = Conversions.ToString(dataTable.Rows[0]["Cliente"]);
				Label30.Text = Conversions.ToString(dataTable.Rows[0]["U_mail"]);
				TextBox2.Text = Conversions.ToString(dataTable.Rows[0]["U_telefono"]);
				TextBox3.Text = Conversions.ToString(dataTable.Rows[0]["U_cel"]);
				DateTimePicker1.Value = Conversions.ToDate(dataTable.Rows[0]["U_fecha"]);
				ComboBox1.Text = Conversions.ToString(dataTable.Rows[0]["U_ventana"]);
				TextBox4.Text = Conversions.ToString(dataTable.Rows[0]["U_calle"]);
				TextBox18.Text = Conversions.ToString(dataTable.Rows[0]["U_numero_puerta"]);
				TextBox5.Text = Conversions.ToString(dataTable.Rows[0]["U_cp"]);
				Label31.Text = Conversions.ToString(dataTable.Rows[0]["U_localidad"]);
				TextBox11.Text = Conversions.ToString(dataTable.Rows[0]["U_piso"]);
				TextBox12.Text = Conversions.ToString(dataTable.Rows[0]["U_dpto_oficina"]);
				TextBox13.Text = Conversions.ToString(dataTable.Rows[0]["U_bloque_torre"]);
				Label32.Text = Conversions.ToString(dataTable.Rows[0]["Destinatario"]);
				Label33.Text = Conversions.ToString(dataTable.Rows[0]["D_mail"]);
				TextBox6.Text = Conversions.ToString(dataTable.Rows[0]["D_telefono"]);
				TextBox7.Text = Conversions.ToString(dataTable.Rows[0]["D_cel"]);
				DateTimePicker2.Value = Conversions.ToDate(dataTable.Rows[0]["D_fecha"]);
				ComboBox2.Text = Conversions.ToString(dataTable.Rows[0]["D_ventana"]);
				TextBox8.Text = Conversions.ToString(dataTable.Rows[0]["D_calle"]);
				TextBox19.Text = Conversions.ToString(dataTable.Rows[0]["D_numero_puerta"]);
				TextBox9.Text = Conversions.ToString(dataTable.Rows[0]["D_cp"]);
				valE_cp = Conversions.ToInteger(dataTable.Rows[0]["D_cp"]);
				TextBox17.Text = Conversions.ToString(dataTable.Rows[0]["D_localidad"]);
				valE_localidad = Conversions.ToString(dataTable.Rows[0]["D_localidad"]);
				TextBox14.Text = Conversions.ToString(dataTable.Rows[0]["D_piso"]);
				TextBox15.Text = Conversions.ToString(dataTable.Rows[0]["D_dpto_oficina"]);
				TextBox16.Text = Conversions.ToString(dataTable.Rows[0]["D_bloque_torre"]);
				TextBox10.Text = Conversions.ToString(dataTable.Rows[0]["Observaciones"]);
				Label39.Text = Conversions.ToString(dataTable.Rows[0]["numero_interno"]);
				ComboBox3.Text = Conversions.ToString(dataTable.Rows[0]["estado"]);
				TextBox1.Text = "";
				TextBox1.Focus();
				return;
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				Label37.Text = "";
				Label36.Text = "";
				Label28.Text = "";
				Label27.Text = "";
				Label26.Text = "";
				Label29.Text = "";
				Label30.Text = "";
				TextBox2.Text = "";
				TextBox3.Text = "";
				DateTimePicker1.Value = DateAndTime.Today;
				ComboBox1.Text = "";
				TextBox4.Text = "";
				TextBox5.Text = "";
				TextBox18.Text = "";
				TextBox19.Text = "";
				Label31.Text = "";
				TextBox11.Text = "";
				TextBox12.Text = "";
				TextBox13.Text = "";
				Label32.Text = "";
				Label33.Text = "";
				TextBox6.Text = "";
				TextBox7.Text = "";
				DateTimePicker2.Value = DateAndTime.Today;
				ComboBox2.Text = "";
				TextBox8.Text = "";
				TextBox9.Text = "";
				TextBox17.Text = "";
				TextBox14.Text = "";
				TextBox15.Text = "";
				TextBox16.Text = "";
				valE_cp = 0;
				valE_localidad = "";
				TextBox10.Text = "";
				Label39.Text = "";
				ComboBox3.Text = "";
				string text4 = Conversions.ToString(Mod_Etrans.get_envio_etrans(Conversions.ToInteger(TextBox1.Text)));
				TextBox1.Focus();
				ProjectData.ClearProjectError();
				return;
			}
		}
		TextBox1.Text = "";
		Interaction.MsgBox("Debes introducir un numero de envio");
		TextBox1.Focus();
	}

	private void EdicionEtrans_Load(object sender, EventArgs e)
	{
		ComboBox3.Items.Add("PENDIENTE");
		ComboBox3.Items.Add("APROBADO");
		ComboBox3.Items.Add("EN RECOLECCION");
		ComboBox3.Items.Add("RECOLECTADO");
		ComboBox3.Items.Add("NO RECOLECTADO");
		ComboBox3.Items.Add("EN CD");
		ComboBox3.Items.Add("DESPACHADO");
		ComboBox3.Items.Add("ENTREGADO");
		ComboBox3.Items.Add("NO ENTREGADO");
		ComboBox3.Items.Add("CADUCADO");
		ComboBox3.Items.Add("CADUCADO WEB");
		ComboBox3.Items.Add("PENDIENTE WEB");
		ComboBox3.Items.Add("DESCARTADO");
		ComboBox3.Items.Add("A REPROGRAMAR");
		ComboBox3.Items.Add("DEVUELTO");
		CheckBox2.Checked = true;
		if (Conversions.ToDouble(MySettingsProperty.Settings.Permiso) >= 7.0)
		{
			DateTimePicker1.Enabled = true;
			DateTimePicker2.Enabled = true;
			ComboBox1.Enabled = true;
			ComboBox2.Enabled = true;
		}
		Button2.Enabled = false;
		Label37.Text = "";
		Label36.Text = "";
		Label28.Text = "";
		Label27.Text = "";
		Label26.Text = "";
		Label29.Text = "";
		Label30.Text = "";
		TextBox2.Text = "";
		TextBox3.Text = "";
		DateTimePicker1.Value = DateAndTime.Today;
		ComboBox1.Text = "";
		TextBox4.Text = "";
		TextBox5.Text = "";
		Label31.Text = "";
		TextBox11.Text = "";
		TextBox12.Text = "";
		TextBox13.Text = "";
		Label32.Text = "";
		Label33.Text = "";
		TextBox6.Text = "";
		TextBox7.Text = "";
		DateTimePicker2.Value = DateAndTime.Today;
		ComboBox2.Text = "";
		TextBox8.Text = "";
		TextBox9.Text = "";
		TextBox17.Text = "";
		TextBox14.Text = "";
		TextBox15.Text = "";
		TextBox16.Text = "";
		TextBox18.Text = "";
		TextBox19.Text = "";
		TextBox10.Text = "";
		Label39.Text = "";
		ComboBox3.Text = "";
		TextBox1.Text = "";
		TextBox1.Focus();
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		int num = Conversions.ToInteger(Label37.Text);
		int id_envio = Conversions.ToInteger(Label36.Text);
		int num2 = Conversions.ToInteger(Label28.Text);
		double num3 = Conversions.ToDouble(Label27.Text);
		double num4 = Conversions.ToDouble(Label26.Text);
		string text = Label29.Text;
		string text2 = Label30.Text;
		string text3 = TextBox2.Text;
		string text4 = TextBox3.Text;
		string text5 = Strings.Format(DateTimePicker1.Value, "yyyyMMdd");
		int num5 = Conversions.ToInteger(ComboBox1.Text);
		string text6 = TextBox4.Text;
		string text7 = TextBox18.Text;
		int num6 = Conversions.ToInteger(TextBox5.Text);
		string text8 = Label31.Text;
		string text9 = TextBox11.Text;
		string text10 = TextBox12.Text;
		string text11 = TextBox13.Text;
		string text12 = Label32.Text;
		string text13 = Label33.Text;
		string text14 = TextBox6.Text;
		string text15 = TextBox7.Text;
		string text16 = Strings.Format(DateTimePicker2.Value, "yyyyMMdd");
		int num7 = Conversions.ToInteger(ComboBox2.Text);
		string text17 = TextBox8.Text;
		string text18 = TextBox19.Text;
		int num8 = Conversions.ToInteger(TextBox9.Text);
		string text19 = TextBox17.Text;
		string text20 = TextBox14.Text;
		string text21 = TextBox15.Text;
		string text22 = TextBox16.Text;
		string text23 = TextBox10.Text;
		string text24 = ComboBox3.Text;
		try
		{
			string sQL = "UPDATE etransEnvios SET bultos=" + Conversions.ToString(num2) + ", U_fecha='" + text5 + "',U_ventana=" + Conversions.ToString(num5) + ", U_telefono='" + text3 + "', U_cel='" + text4 + "', U_calle='" + text6 + "', U_numero_puerta='" + text7 + "',U_bloque_torre='" + text11 + "', U_dpto_oficina='" + text10 + "',U_piso='" + text9 + "', U_cp=" + Conversions.ToString(num6) + ", U_localidad='" + text8 + "', D_fecha='" + text16 + "',D_ventana=" + Conversions.ToString(num7) + ", D_telefono='" + text14 + "', D_cel='" + text15 + "', D_calle='" + text17 + "',D_numero_puerta='" + text18 + "',D_bloque_torre='" + text22 + "', D_piso='" + text20 + "', D_dpto_oficina='" + text21 + "', D_cp=" + Conversions.ToString(num8) + ", D_localidad='" + text19 + "', estado='" + text24 + "', Observaciones='" + text23 + "' WHERE id_hermes=" + Conversions.ToString(num);
			string value = Conversions.ToString(Mod_ConeccionBD.BD_Sentencia(sQL));
			if (Conversions.ToDouble(value) == 1.0)
			{
				int estado = Conversions.ToInteger(Mod_Etrans.estado_web_int(text24));
				string text25 = Conversions.ToString(Mod_Etrans.actualizar_estado_web(id_envio, estado));
				if (Operators.CompareString(Mod_Sentencias.baseDD, "hermes", TextCompare: true) == 0)
				{
					Mod_Etrans.actualizar_estado_web(id_envio, estado);
				}
				Interaction.MsgBox("Se Edito Correctamente");
			}
			else
			{
				Interaction.MsgBox("Existe un error ");
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

	private void Button3_Click(object sender, EventArgs e)
	{
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected O, but got Unknown
		PrintDialog1.Document = print_etiqueta;
		PrintDialog1.PrinterSettings = print_etiqueta.PrinterSettings;
		PrintDialog1.AllowSomePages = true;
		if (PrintDialog1.ShowDialog() == DialogResult.OK)
		{
			string text = Label36.Text;
			DataTable dataTable = new DataTable("x1");
			string text2 = "Select D_cp, D_localidad, Bultos, (Select (SELECT z.Descripcion FROM Zonas z WHERE z.Zona=l.zona) AS Descripcion from localidades l where l.CP=e.D_cp) AS zonaD From etransEnvios e WHERE e.id_envio='" + text + "'";
			MySqlDataAdapter val = new MySqlDataAdapter(text2, Mod_Sentencias.cnn);
			DataSet dataSet = new DataSet();
			((DbDataAdapter)(object)val).Fill(dataTable);
			Et_remitos = text;
			Et_cp = Conversions.ToString(Operators.ConcatenateObject("Cp: ", dataTable.Rows[0]["D_cp"]));
			Et_localidad = Conversions.ToString(Operators.ConcatenateObject("Loc: ", dataTable.Rows[0]["D_localidad"]));
			Et_des = "N° Trans: ";
			Et_zona = Conversions.ToString(Operators.ConcatenateObject("Zona: ", dataTable.Rows[0]["zonaD"]));
			int num = Conversions.ToInteger(dataTable.Rows[0]["Bultos"]);
			for (int i = 1; i <= num; i = checked(i + 1))
			{
				Et_bultos = Conversions.ToString(Operators.ConcatenateObject("Bulto: " + Conversions.ToString(i) + "/", dataTable.Rows[0]["Bultos"]));
				Et_qrCode = text + Conversions.ToString(i);
				print_etiqueta.Print();
				print_etiqueta.Dispose();
			}
		}
	}

	private void print_etiqueta_PrintPage(object sender, PrintPageEventArgs e)
	{
		Font font = new Font("Arial", 6.75f, FontStyle.Italic, GraphicsUnit.Point, 0);
		Font font2 = new Font("Arial", 8.75f, FontStyle.Italic, GraphicsUnit.Point, 0);
		Font font3 = new Font("Arial", 10.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		Font font4 = new Font("Arial", 24.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
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
			Image image = (Image)Mod_QR.qrcodegen(Et_qrCode);
			Image etrans = Resources.etrans2;
			e.Graphics.DrawImage(image, num2 + 10, num3 + 70);
			e.Graphics.DrawImage(etrans, num2 + 10, num3 + 10);
			int num4 = default(int);
			e.Graphics.DrawString(Et_des, font3, Brushes.Black, num2 + 150, num3 + num4 + 10);
			e.Graphics.DrawString(Et_remitos, font4, Brushes.Black, num2 + 150, num3 + num4 + 30);
			e.Graphics.DrawString(Et_bultos, font3, Brushes.Black, num2 + 110, num3 + num4 + 70);
			e.Graphics.DrawString(Et_localidad, font3, Brushes.Black, num2 + 110, num3 + num4 + 90);
			e.Graphics.DrawString(Et_cp, font3, Brushes.Black, num2 + 110, num3 + num4 + 110);
			e.Graphics.DrawString(Et_zona, font3, Brushes.Black, num2 + 110, num3 + num4 + 130);
		}
	}

	private void print_orden_PrintPage(object sender, PrintPageEventArgs e)
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		//IL_021d: Expected O, but got Unknown
		string text = Strings.Format(MyProject.Forms.Form1_Inicio.DateTimePicker1.Value, "yyyyMMdd");
		DataTable dataTable = new DataTable("X1");
		string text2 = "SELECT Comprobante, Cliente, Bultos, Destino, Domicilio, Ventana, Localidad, CP, Remitos, Observaciones, sub, fecha, (SELECT Chofer FROM FLOTA Where Numero=planchada.Chofer) AS Chof FROM Planchada WHERE  Remitos=" + print_remitos + " AND Cliente='ETRANS'";
		MySqlDataAdapter val = new MySqlDataAdapter(text2, Mod_Sentencias.cnn);
		((DbDataAdapter)(object)val).Fill(dataTable);
		print_comprobante = Conversions.ToString(dataTable.Rows[0]["Comprobante"]);
		print_fecha = Conversions.ToString(dataTable.Rows[0]["fecha"]);
		print_cliente = Conversions.ToString(dataTable.Rows[0]["Cliente"]);
		print_destino = Conversions.ToString(dataTable.Rows[0]["Destino"]);
		print_direccion = Conversions.ToString(dataTable.Rows[0]["Domicilio"]);
		print_ventana = Conversions.ToInteger(dataTable.Rows[0]["Ventana"]);
		print_remitos = Conversions.ToString(dataTable.Rows[0]["Remitos"]);
		print_observaciones = Conversions.ToString(dataTable.Rows[0]["Observaciones"]);
		print_cp = Conversions.ToString(dataTable.Rows[0]["Cp"]);
		print_localidad = Conversions.ToString(dataTable.Rows[0]["Localidad"]);
		print_bultos = Conversions.ToString(dataTable.Rows[0]["Bultos"]);
		print_qrcode = dataTable.Rows[0]["Remitos"].ToString() + Conversions.ToString(1);
		DataTable dataTable2 = new DataTable("X2");
		string text3 = "SELECT id_envio,Cliente, Destinatario, D_calle, D_numero_puerta,D_piso, D_dpto_oficina, D_bloque_torre, D_cp, D_localidad, Bultos, numero_interno, D_ventana, Observaciones FROM etransenvios WHERE id_envio=" + print_remitos;
		MySqlDataAdapter val2 = new MySqlDataAdapter(text3, Mod_Sentencias.cnn);
		((DbDataAdapter)(object)val2).Fill(dataTable2);
		print_cliente = Conversions.ToString(dataTable2.Rows[0]["Cliente"]);
		print_destino = Conversions.ToString(dataTable2.Rows[0]["Destinatario"]);
		print_qrcode = dataTable2.Rows[0]["id_envio"].ToString() + Conversions.ToString(1);
		print_remitos = Conversions.ToString(dataTable2.Rows[0]["id_envio"]);
		print_direccion = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(dataTable2.Rows[0]["D_calle"], " "), dataTable2.Rows[0]["D_numero_puerta"]));
		print_piso = Conversions.ToString(dataTable2.Rows[0]["D_piso"]);
		print_ofi = Conversions.ToString(dataTable2.Rows[0]["D_dpto_oficina"]);
		print_bloq = Conversions.ToString(dataTable2.Rows[0]["D_bloque_torre"]);
		print_localidad = Conversions.ToString(dataTable2.Rows[0]["D_localidad"]);
		print_cp = Conversions.ToString(dataTable2.Rows[0]["D_cp"]);
		print_ventana = Conversions.ToInteger(dataTable2.Rows[0]["D_ventana"]);
		print_observaciones = Conversions.ToString(dataTable2.Rows[0]["Observaciones"]);
		print_bultos = Conversions.ToString(dataTable2.Rows[0]["Bultos"]);
		PrivateFontCollection privateFontCollection = new PrivateFontCollection();
		privateFontCollection.AddFontFile(AppDomain.CurrentDomain.BaseDirectory + "\\Code39.ttf");
		FontFamily family = privateFontCollection.Families[0];
		Font font = new Font(family, 20f);
		Font font2 = new Font("Arial", 6.75f, FontStyle.Italic, GraphicsUnit.Point, 0);
		Font font3 = new Font("Arial", 16.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		Font font4 = new Font("Arial", 14.75f, FontStyle.Italic, GraphicsUnit.Point, 0);
		Font font5 = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, 0);
		int num = 0;
		string text4 = MyProject.Forms.Form1_Inicio.nombreusuario.Text;
		e.Graphics.DrawLine(Pens.Brown, 2, 5, 750, 5);
		e.Graphics.DrawLine(Pens.Brown, 2, 5, 2, 1100);
		e.Graphics.DrawLine(Pens.Brown, 750, 5, 750, 1100);
		e.Graphics.DrawLine(Pens.Brown, 2, 1100, 750, 1100);
		e.Graphics.DrawLine(Pens.Brown, 2, 130, 750, 130);
		Image image = (Image)Mod_QR.qrcodegen(print_qrcode);
		Image logo_etrans = Resources.logo_etrans;
		e.Graphics.DrawImage(image, 650, 30);
		e.Graphics.DrawImage(logo_etrans, 30, 30);
		e.Graphics.DrawString("ORDEN DE ENTREGA", font3, Brushes.Black, 250f, 135f);
		e.Graphics.DrawLine(Pens.Brown, 2, 162, 750, 162);
		e.Graphics.DrawLine(Pens.Brown, 375, 162, 375, 236);
		e.Graphics.DrawString("Fecha: " + print_fecha, font5, Brushes.Black, 500f, 180f);
		e.Graphics.DrawString("Chofer: ", font5, Brushes.Black, 500f, 200f);
		e.Graphics.DrawString("Numero Trans:", font5, Brushes.Black, 55f, 180f);
		e.Graphics.DrawString(print_remitos, font5, Brushes.Black, 155f, 180f);
		e.Graphics.DrawString("Ventana:", font5, Brushes.Black, 55f, 200f);
		e.Graphics.DrawString(Conversions.ToString(print_ventana), font5, Brushes.Black, 155f, 200f);
		e.Graphics.DrawLine(Pens.Brown, 2, 236, 750, 236);
		e.Graphics.DrawString("Cliente:", font5, Brushes.Black, 55f, 244f);
		e.Graphics.DrawString(print_cliente, font5, Brushes.Black, 155f, 244f);
		e.Graphics.DrawString("Entregar a:", font5, Brushes.Black, 55f, 274f);
		e.Graphics.DrawString(print_destino, font5, Brushes.Black, 155f, 274f);
		e.Graphics.DrawLine(Pens.Brown, 2, 310, 750, 310);
		e.Graphics.DrawLine(Pens.Brown, 375, 310, 375, 466);
		e.Graphics.DrawLine(Pens.Brown, 2, 466, 750, 466);
		e.Graphics.DrawString("Direccion:", font5, Brushes.Black, 400f, 340f);
		e.Graphics.DrawString(print_direccion, font5, Brushes.Black, 480f, 340f);
		e.Graphics.DrawString("Piso:", font5, Brushes.Black, 400f, 370f);
		e.Graphics.DrawString(print_piso, font5, Brushes.Black, 480f, 370f);
		e.Graphics.DrawString("Ofi/Dpto:", font5, Brushes.Black, 400f, 400f);
		e.Graphics.DrawString(print_ofi, font5, Brushes.Black, 480f, 400f);
		e.Graphics.DrawString("Bloque:", font5, Brushes.Black, 400f, 430f);
		e.Graphics.DrawString(print_bloq, font5, Brushes.Black, 480f, 430f);
		e.Graphics.DrawString("Bultos:", font5, Brushes.Black, 55f, 340f);
		e.Graphics.DrawString(print_bultos, font5, Brushes.Black, 155f, 340f);
		e.Graphics.DrawString("Localidad:", font5, Brushes.Black, 55f, 370f);
		e.Graphics.DrawString(print_localidad, font5, Brushes.Black, 155f, 370f);
		e.Graphics.DrawString("Codigo Postal:", font5, Brushes.Black, 55f, 400f);
		e.Graphics.DrawString(print_cp, font5, Brushes.Black, 155f, 400f);
		e.Graphics.DrawString("Observaciones:", font5, Brushes.Black, 55f, 480f);
		if (print_observaciones.Length > 90)
		{
			string s = print_observaciones.Substring(0, 90);
			e.Graphics.DrawString(s, font5, Brushes.Black, 155f, 480f);
			string s2 = print_observaciones.Substring(90);
			e.Graphics.DrawString(s2, font5, Brushes.Black, 155f, 500f);
		}
		else
		{
			e.Graphics.DrawString(print_observaciones, font5, Brushes.Black, 155f, 480f);
		}
		e.Graphics.DrawString("Firma:", font3, Brushes.Black, 110f, 680f);
		e.Graphics.DrawString("____________________", font3, Brushes.Black, 310f, 680f);
		e.Graphics.DrawString("Aclaracion:", font3, Brushes.Black, 110f, 720f);
		e.Graphics.DrawString("____________________", font3, Brushes.Black, 310f, 720f);
		e.Graphics.DrawString("D.N.I.:", font3, Brushes.Black, 110f, 760f);
		e.Graphics.DrawString("____________________", font3, Brushes.Black, 310f, 760f);
		e.Graphics.DrawString("*2000200" + print_comprobante + "4*", font, Brushes.Black, 310f, 800f);
		e.Graphics.DrawString(print_comprobante, font4, Brushes.Black, 110f, 800f);
	}

	private void Button4_Click(object sender, EventArgs e)
	{
		if (CheckBox1.Checked)
		{
			print_remitos = Label36.Text;
			PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
			print_recoleccion.DefaultPageSettings.Landscape = false;
			printPreviewDialog.WindowState = FormWindowState.Maximized;
			printPreviewDialog.Document = print_recoleccion;
			printPreviewDialog.Show();
		}
		else if (CheckBox2.Checked)
		{
			print_remitos = Label36.Text;
			PrintPreviewDialog printPreviewDialog2 = new PrintPreviewDialog();
			print_entrega.DefaultPageSettings.Landscape = false;
			printPreviewDialog2.WindowState = FormWindowState.Maximized;
			printPreviewDialog2.Document = print_entrega;
			printPreviewDialog2.Show();
		}
		else
		{
			Interaction.MsgBox("Seleccione el tipo de Orden que desea imprimir.");
		}
	}

	private void TextBox9_TextChanged(object sender, EventArgs e)
	{
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		if (TextBox9.Text.Length >= 4)
		{
			try
			{
				string text = ("SELECT localidad FROM Localidades WHERE cp = " + TextBox9.Text) ?? "";
				DataTable dataTable = new DataTable("X2");
				MySqlDataAdapter val = new MySqlDataAdapter(text, Mod_Sentencias.cnn);
				((DbDataAdapter)(object)val).Fill(dataTable);
				TextBox17.Text = dataTable.Rows[0]["Localidad"].ToString();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				Interaction.MsgBox("El CP ingresado puede estar fuera del area de cobertura. O no estar ingresado en Hermes.");
				TextBox9.Text = Conversions.ToString(valE_cp);
				TextBox17.Text = valE_localidad;
				TextBox9.Focus();
				ProjectData.ClearProjectError();
			}
		}
	}

	private void TextBox5_TextChanged(object sender, EventArgs e)
	{
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		if (TextBox5.Text.Length >= 4)
		{
			try
			{
				string text = ("SELECT localidad FROM Localidades WHERE cp = " + TextBox5.Text) ?? "";
				DataTable dataTable = new DataTable("X2");
				MySqlDataAdapter val = new MySqlDataAdapter(text, Mod_Sentencias.cnn);
				((DbDataAdapter)(object)val).Fill(dataTable);
				Label31.Text = dataTable.Rows[0]["Localidad"].ToString();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				Interaction.MsgBox("El CP ingresado puede estar fuera del area de cobertura. O no estar ingresado en Hermes.");
				TextBox5.Text = Conversions.ToString(valE_cp);
				Label31.Text = valE_localidad;
				TextBox5.Focus();
				ProjectData.ClearProjectError();
			}
		}
	}

	private void print_entrega_PrintPage(object sender, PrintPageEventArgs e)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		DataTable dataTable = new DataTable("X2");
		string text = "SELECT id_envio,Cliente, Destinatario, D_calle, D_numero_puerta,D_piso, D_dpto_oficina, D_bloque_torre, D_cp, D_localidad, Bultos, numero_interno, D_ventana, D_Cel, D_telefono, Observaciones FROM etransenvios WHERE id_envio=" + print_remitos;
		MySqlDataAdapter val = new MySqlDataAdapter(text, Mod_Sentencias.cnn);
		((DbDataAdapter)(object)val).Fill(dataTable);
		print_cliente = Conversions.ToString(dataTable.Rows[0]["Cliente"]);
		print_destino = Conversions.ToString(dataTable.Rows[0]["Destinatario"]);
		print_qrcode = dataTable.Rows[0]["id_envio"].ToString() + Conversions.ToString(1);
		print_remitos = Conversions.ToString(dataTable.Rows[0]["id_envio"]);
		print_direccion = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(dataTable.Rows[0]["D_calle"], " "), dataTable.Rows[0]["D_numero_puerta"]));
		print_piso = Conversions.ToString(dataTable.Rows[0]["D_piso"]);
		print_ofi = Conversions.ToString(dataTable.Rows[0]["D_dpto_oficina"]);
		print_bloq = Conversions.ToString(dataTable.Rows[0]["D_bloque_torre"]);
		print_localidad = Conversions.ToString(dataTable.Rows[0]["D_localidad"]);
		print_cp = Conversions.ToString(dataTable.Rows[0]["D_cp"]);
		print_ventana = Conversions.ToInteger(dataTable.Rows[0]["D_ventana"]);
		print_observaciones = Conversions.ToString(dataTable.Rows[0]["Observaciones"]);
		print_bultos = Conversions.ToString(dataTable.Rows[0]["Bultos"]);
		print_cel = Conversions.ToString(dataTable.Rows[0]["D_Cel"]);
		print_tel = Conversions.ToString(dataTable.Rows[0]["D_telefono"]);
		PrivateFontCollection privateFontCollection = new PrivateFontCollection();
		privateFontCollection.AddFontFile(AppDomain.CurrentDomain.BaseDirectory + "\\Code39.ttf");
		FontFamily family = privateFontCollection.Families[0];
		Font font = new Font(family, 20f);
		Font font2 = new Font("Arial", 6.75f, FontStyle.Italic, GraphicsUnit.Point, 0);
		Font font3 = new Font("Arial", 16.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		Font font4 = new Font("Arial", 14.75f, FontStyle.Italic, GraphicsUnit.Point, 0);
		Font font5 = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, 0);
		int num = 0;
		string text2 = MyProject.Forms.Form1_Inicio.nombreusuario.Text;
		e.Graphics.DrawLine(Pens.Brown, 2, 5, 750, 5);
		e.Graphics.DrawLine(Pens.Brown, 2, 5, 2, 1040);
		e.Graphics.DrawLine(Pens.Brown, 750, 5, 750, 1040);
		e.Graphics.DrawLine(Pens.Brown, 2, 1040, 750, 1040);
		e.Graphics.DrawLine(Pens.Brown, 2, 130, 750, 130);
		Image image = (Image)Mod_QR.qrcodegen(print_qrcode);
		Image logo_etrans = Resources.logo_etrans;
		e.Graphics.DrawImage(image, 650, 30);
		e.Graphics.DrawImage(logo_etrans, 30, 30);
		e.Graphics.DrawString("ORDEN DE ENTREGA", font3, Brushes.Black, 55f, 135f);
		e.Graphics.DrawString("VENTANA: ", font3, Brushes.Black, 385f, 135f);
		switch (print_ventana)
		{
		case 1:
			e.Graphics.DrawString(Conversions.ToString(print_ventana) + " (8:00 a 13:00 hs)", font3, Brushes.Black, 525f, 135f);
			break;
		case 2:
			e.Graphics.DrawString(Conversions.ToString(print_ventana) + " (13:00 a 18:00 hs)", font3, Brushes.Black, 525f, 135f);
			break;
		case 3:
			e.Graphics.DrawString(Conversions.ToString(print_ventana) + " (18:00 a 21:00 hs)", font3, Brushes.Black, 525f, 135f);
			break;
		}
		e.Graphics.DrawLine(Pens.Brown, 2, 162, 750, 162);
		e.Graphics.DrawLine(Pens.Brown, 375, 162, 375, 236);
		e.Graphics.DrawString("Fecha: " + print_fecha, font5, Brushes.Black, 500f, 180f);
		e.Graphics.DrawString("Chofer: " + print_chofer, font5, Brushes.Black, 500f, 200f);
		e.Graphics.DrawString("Numero Trans:", font5, Brushes.Black, 55f, 180f);
		e.Graphics.DrawString(print_remitos, font5, Brushes.Black, 155f, 180f);
		e.Graphics.DrawString("Ventana:", font5, Brushes.Black, 55f, 200f);
		e.Graphics.DrawString(Conversions.ToString(print_ventana), font5, Brushes.Black, 155f, 200f);
		e.Graphics.DrawLine(Pens.Brown, 2, 236, 750, 236);
		e.Graphics.DrawString("Cliente:", font5, Brushes.Black, 55f, 244f);
		e.Graphics.DrawString(print_cliente, font5, Brushes.Black, 155f, 244f);
		e.Graphics.DrawString("Entregar a:", font5, Brushes.Black, 55f, 274f);
		e.Graphics.DrawString(print_destino, font5, Brushes.Black, 155f, 274f);
		e.Graphics.DrawLine(Pens.Brown, 2, 310, 750, 310);
		e.Graphics.DrawLine(Pens.Brown, 375, 310, 375, 490);
		e.Graphics.DrawLine(Pens.Brown, 2, 490, 750, 490);
		e.Graphics.DrawString("Direccion:", font5, Brushes.Black, 400f, 340f);
		e.Graphics.DrawString(print_direccion, font5, Brushes.Black, 480f, 340f);
		e.Graphics.DrawString("Piso:", font5, Brushes.Black, 400f, 370f);
		e.Graphics.DrawString(print_piso, font5, Brushes.Black, 480f, 370f);
		e.Graphics.DrawString("Ofi/Dpto:", font5, Brushes.Black, 400f, 400f);
		e.Graphics.DrawString(print_ofi, font5, Brushes.Black, 480f, 400f);
		e.Graphics.DrawString("Bloque:", font5, Brushes.Black, 400f, 430f);
		e.Graphics.DrawString(print_bloq, font5, Brushes.Black, 480f, 430f);
		e.Graphics.DrawString("Bultos:", font5, Brushes.Black, 55f, 340f);
		e.Graphics.DrawString(print_bultos, font5, Brushes.Black, 155f, 340f);
		e.Graphics.DrawString("Localidad:", font5, Brushes.Black, 55f, 370f);
		e.Graphics.DrawString(print_localidad, font5, Brushes.Black, 155f, 370f);
		e.Graphics.DrawString("Codigo Postal:", font5, Brushes.Black, 55f, 400f);
		e.Graphics.DrawString(print_cp, font5, Brushes.Black, 155f, 400f);
		e.Graphics.DrawString("Celular:", font5, Brushes.Black, 55f, 430f);
		e.Graphics.DrawString(print_cel, font5, Brushes.Black, 155f, 430f);
		e.Graphics.DrawString("Fijo:", font5, Brushes.Black, 55f, 460f);
		e.Graphics.DrawString(print_tel, font5, Brushes.Black, 155f, 460f);
		if (print_observaciones.Length > 0)
		{
			if (print_observaciones.Length > 90)
			{
				e.Graphics.DrawString("Observaciones:", font5, Brushes.Black, 55f, 540f);
				string s = print_observaciones.Substring(0, 90);
				e.Graphics.DrawString(s, font5, Brushes.Black, 155f, 540f);
				string s2 = print_observaciones.Substring(90);
				e.Graphics.DrawString(s2, font5, Brushes.Black, 155f, 540f);
			}
			else
			{
				e.Graphics.DrawString("Observaciones:", font5, Brushes.Black, 55f, 540f);
				e.Graphics.DrawString(print_observaciones, font5, Brushes.Black, 155f, 540f);
			}
		}
		e.Graphics.DrawString("Firma:", font5, Brushes.Black, 55f, 890f);
		e.Graphics.DrawString("____________________", font5, Brushes.Black, 200f, 890f);
		e.Graphics.DrawString("Aclaracion:", font5, Brushes.Black, 55f, 930f);
		e.Graphics.DrawString("____________________", font5, Brushes.Black, 200f, 930f);
		e.Graphics.DrawString("D.N.I.:", font5, Brushes.Black, 55f, 970f);
		e.Graphics.DrawString("____________________", font5, Brushes.Black, 200f, 970f);
		e.Graphics.DrawString("1 - Direccion Erronea/Fatan Datos.", font5, Brushes.Black, 400f, 890f);
		e.Graphics.DrawString("2 - Zona Peligrosa/Inaccesible.", font5, Brushes.Black, 400f, 920f);
		e.Graphics.DrawString("3 - No responden en domicilio.", font5, Brushes.Black, 400f, 950f);
		e.Graphics.DrawString("4 - No lo quiere / No firma", font5, Brushes.Black, 400f, 980f);
		e.Graphics.DrawString("5 - Otros:_________________________", font5, Brushes.Black, 400f, 1010f);
		num = checked(num + 1);
	}

	private void print_recoleccion_PrintPage(object sender, PrintPageEventArgs e)
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		DataTable dataTable = new DataTable("X12");
		string text = ("SELECT id_envio, Cliente, Destinatario, U_calle,U_ventana, U_numero_puerta, U_piso, U_dpto_oficina, U_bloque_torre, U_cp, U_localidad, D_cp, D_Localidad, Bultos, numero_interno, (SELECT Comprobante FROM Planchada WHERE remitos=etransEnvios.id_envio and fecha='" + fecha1 + "' And Ventana=" + MyProject.Forms.Form1_Inicio.ComboBox1.Text + " AND sub=11) AS Comprobante FROM etransenvios WHERE id_envio=" + print_remitos) ?? "";
		MySqlDataAdapter val = new MySqlDataAdapter(text, Mod_Sentencias.cnn);
		((DbDataAdapter)(object)val).Fill(dataTable);
		print_cliente = Conversions.ToString(dataTable.Rows[0]["Cliente"]);
		print_direccion = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(dataTable.Rows[0]["U_calle"], " "), dataTable.Rows[0]["U_numero_puerta"]));
		print_piso = Conversions.ToString(dataTable.Rows[0]["U_piso"]);
		print_ofi = Conversions.ToString(dataTable.Rows[0]["U_dpto_oficina"]);
		print_bloq = Conversions.ToString(dataTable.Rows[0]["U_bloque_torre"]);
		print_localidad = Conversions.ToString(dataTable.Rows[0]["U_localidad"]);
		print_cp = Conversions.ToString(dataTable.Rows[0]["U_cp"]);
		print_ventana = Conversions.ToInteger(dataTable.Rows[0]["U_ventana"]);
		Font font = new Font("Arial", 6.75f, FontStyle.Italic, GraphicsUnit.Point, 0);
		Font font2 = new Font("Arial", 16.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		Font font3 = new Font("Arial", 6.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		Font font4 = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, 0);
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		string text2 = MyProject.Forms.Form1_Inicio.nombreusuario.Text;
		e.Graphics.DrawLine(Pens.Brown, 2, 5, 750, 5);
		e.Graphics.DrawLine(Pens.Brown, 2, 5, 2, 1040);
		e.Graphics.DrawLine(Pens.Brown, 750, 5, 750, 1040);
		e.Graphics.DrawLine(Pens.Brown, 2, 1040, 750, 1040);
		e.Graphics.DrawLine(Pens.Brown, 2, 130, 750, 130);
		e.Graphics.DrawString("ORDEN DE RECOLECCION", font2, Brushes.Black, 55f, 135f);
		e.Graphics.DrawString("VENTANA: ", font2, Brushes.Black, 385f, 135f);
		switch (print_ventana)
		{
		case 1:
			e.Graphics.DrawString(Conversions.ToString(print_ventana) + " (8:00 a 13:00 hs)", font2, Brushes.Black, 525f, 135f);
			break;
		case 2:
			e.Graphics.DrawString(Conversions.ToString(print_ventana) + " (13:00 a 18:00 hs)", font2, Brushes.Black, 525f, 135f);
			break;
		case 3:
			e.Graphics.DrawString(Conversions.ToString(print_ventana) + " (18:00 a 21:00 hs)", font2, Brushes.Black, 525f, 135f);
			break;
		}
		e.Graphics.DrawLine(Pens.Brown, 2, 162, 750, 162);
		e.Graphics.DrawString("Fecha: " + print_fecha, font4, Brushes.Black, 55f, 180f);
		e.Graphics.DrawString("Chofer: " + print_chofer, font4, Brushes.Black, 500f, 180f);
		e.Graphics.DrawLine(Pens.Brown, 2, 244, 750, 244);
		Image logo_etrans = Resources.logo_etrans;
		e.Graphics.DrawImage(logo_etrans, 30, 30);
		e.Graphics.DrawString("Retirar de:", font4, Brushes.Black, 50f, 264f);
		e.Graphics.DrawString(print_cliente, font4, Brushes.Black, 155f, 264f);
		e.Graphics.DrawString("Direccion:", font4, Brushes.Black, 50f, 294f);
		e.Graphics.DrawString(print_direccion, font4, Brushes.Black, 155f, 294f);
		e.Graphics.DrawString("Piso:", font4, Brushes.Black, 50f, 324f);
		e.Graphics.DrawString(print_piso, font4, Brushes.Black, 155f, 324f);
		e.Graphics.DrawString("Ofi/Dpto:", font4, Brushes.Black, 300f, 324f);
		e.Graphics.DrawString(print_ofi, font4, Brushes.Black, 380f, 324f);
		e.Graphics.DrawString("Bloque:", font4, Brushes.Black, 500f, 324f);
		e.Graphics.DrawString(print_bloq, font4, Brushes.Black, 540f, 324f);
		e.Graphics.DrawString("Localidad:", font4, Brushes.Black, 250f, 354f);
		e.Graphics.DrawString(print_localidad, font4, Brushes.Black, 355f, 354f);
		e.Graphics.DrawString("Codigo Postal:", font4, Brushes.Black, 50f, 354f);
		e.Graphics.DrawString(print_cp, font4, Brushes.Black, 155f, 354f);
		e.Graphics.DrawLine(Pens.Brown, 2, 400, 750, 400);
		e.Graphics.DrawString("Numero Trans", font, Brushes.Black, 35f, 410f);
		e.Graphics.DrawString("Destinatario", font, Brushes.Black, 125f, 410f);
		e.Graphics.DrawString("Codigo Postal", font, Brushes.Black, 245f, 410f);
		e.Graphics.DrawString("Localidad", font, Brushes.Black, 310f, 410f);
		e.Graphics.DrawString("Bultos", font, Brushes.Black, 400f, 410f);
		e.Graphics.DrawString("Numero Interno", font, Brushes.Black, 560f, 410f);
		checked
		{
			while (dato_r < dataTable.Rows.Count)
			{
				num3 = ((dato_r != 0) ? (num * 40 + 450) : 450);
				string text3 = dataTable.Rows[dato_r]["Comprobante"].ToString();
				string s = dataTable.Rows[dato_r]["id_envio"].ToString();
				string text4 = dataTable.Rows[dato_r]["Destinatario"].ToString();
				string s2 = dataTable.Rows[dato_r]["D_cp"].ToString();
				string s3 = dataTable.Rows[dato_r]["D_Localidad"].ToString();
				string text5 = dataTable.Rows[dato_r]["Bultos"].ToString();
				bultosTotales = (int)Math.Round((double)bultosTotales + Conversions.ToDouble(text5));
				string s4 = dataTable.Rows[dato_r]["numero_interno"].ToString();
				e.Graphics.DrawString(s, font, Brushes.Black, 35f, num3);
				if (text4.Length > 20)
				{
					text4 = text4.Substring(0, 20);
				}
				e.Graphics.DrawString(text4, font, Brushes.Black, 100f, num3);
				e.Graphics.DrawString(s2, font, Brushes.Black, 245f, num3);
				e.Graphics.DrawString(s3, font, Brushes.Black, 280f, num3);
				e.Graphics.DrawString(text5, font3, Brushes.Black, 410f, num3);
				e.Graphics.DrawString(s4, font, Brushes.Black, 560f, num3);
				num++;
				dato_r++;
				pagina++;
				if (num3 > 1000)
				{
					num = 0;
					pagina = 0;
					e.HasMorePages = true;
					return;
				}
				e.HasMorePages = false;
			}
			e.Graphics.DrawString("Bultos totales a retirar: " + Conversions.ToString(bultosTotales), font2, Brushes.Black, 400f, 264f);
			dato++;
			pagina++;
			dato_r = 0;
		}
	}

	private void CheckBox2_CheckStateChanged(object sender, EventArgs e)
	{
		if (CheckBox2.Checked)
		{
			CheckBox1.Checked = false;
		}
	}

	private void CheckBox1_CheckStateChanged(object sender, EventArgs e)
	{
		if (CheckBox1.Checked)
		{
			CheckBox2.Checked = false;
		}
	}
}
