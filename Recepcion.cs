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
public class Recepcion : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("TextBox1")]
	private TextBox _TextBox1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ListView1")]
	private ListView _ListView1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button3")]
	private Button _Button3;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("PrintDocument1")]
	private PrintDocument _PrintDocument1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("PrintDocument2")]
	private PrintDocument _PrintDocument2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

	private string fecha1;

	private int guia;

	private int TiempoRestante;

	private int dato;

	private int pagina;

	private string Et_bultos;

	private string Et_remitos;

	private string Et_cp;

	private string Et_localidad;

	private string Et_zona;

	private string Et_qrCode;

	internal virtual TextBox TextBox1
	{
		[CompilerGenerated]
		get
		{
			return _TextBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = TextBox1_TextChanged;
			EventHandler value3 = TextBox1_LostFocus;
			EventHandler value4 = TextBox1_Validated;
			TextBox textBox = _TextBox1;
			if (textBox != null)
			{
				textBox.TextChanged -= value2;
				textBox.LostFocus -= value3;
				textBox.Validated -= value4;
			}
			_TextBox1 = value;
			textBox = _TextBox1;
			if (textBox != null)
			{
				textBox.TextChanged += value2;
				textBox.LostFocus += value3;
				textBox.Validated += value4;
			}
		}
	}

	[field: AccessedThroughProperty("Button1")]
	internal virtual Button Button1
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
			ColumnClickEventHandler value2 = ListView1_ColumnClick;
			ListView listView = _ListView1;
			if (listView != null)
			{
				listView.ColumnClick -= value2;
			}
			_ListView1 = value;
			listView = _ListView1;
			if (listView != null)
			{
				listView.ColumnClick += value2;
			}
		}
	}

	[field: AccessedThroughProperty("ListView2")]
	internal virtual ListView ListView2
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

	[field: AccessedThroughProperty("Button4")]
	internal virtual Button Button4
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

	[field: AccessedThroughProperty("Label14")]
	internal virtual Label Label14
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

	[field: AccessedThroughProperty("Label16")]
	internal virtual Label Label16
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ListView3")]
	internal virtual ListView ListView3
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

	[field: AccessedThroughProperty("Label18")]
	internal virtual Label Label18
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
			PrintPageEventHandler value2 = PrintDocument2_PrintPage;
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

	internal virtual Timer Timer1
	{
		[CompilerGenerated]
		get
		{
			return _Timer1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Timer1_Tick;
			Timer timer = _Timer1;
			if (timer != null)
			{
				timer.Tick -= value2;
			}
			_Timer1 = value;
			timer = _Timer1;
			if (timer != null)
			{
				timer.Tick += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label20")]
	internal virtual Label Label20
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public Recepcion()
	{
		base.Load += Recepcion_Load;
		fecha1 = Strings.Format(MyProject.Forms.Form1_Inicio.DateTimePicker1.Value, "yyyyMMdd");
		guia = 0;
		dato = 0;
		pagina = 0;
		Et_bultos = Conversions.ToString(0);
		Et_remitos = Conversions.ToString(0);
		Et_cp = string.Empty;
		Et_localidad = string.Empty;
		Et_zona = string.Empty;
		Et_qrCode = string.Empty;
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
		this.components = new System.ComponentModel.Container();
		this.TextBox1 = new System.Windows.Forms.TextBox();
		this.Button1 = new System.Windows.Forms.Button();
		this.ListView1 = new System.Windows.Forms.ListView();
		this.ListView2 = new System.Windows.Forms.ListView();
		this.Button2 = new System.Windows.Forms.Button();
		this.Button3 = new System.Windows.Forms.Button();
		this.Button4 = new System.Windows.Forms.Button();
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
		this.Label11 = new System.Windows.Forms.Label();
		this.Label12 = new System.Windows.Forms.Label();
		this.Label13 = new System.Windows.Forms.Label();
		this.Label14 = new System.Windows.Forms.Label();
		this.Label15 = new System.Windows.Forms.Label();
		this.Label16 = new System.Windows.Forms.Label();
		this.ListView3 = new System.Windows.Forms.ListView();
		this.Label17 = new System.Windows.Forms.Label();
		this.Label18 = new System.Windows.Forms.Label();
		this.Label19 = new System.Windows.Forms.Label();
		this.PrintDocument1 = new System.Drawing.Printing.PrintDocument();
		this.PrintDialog1 = new System.Windows.Forms.PrintDialog();
		this.PrintDocument2 = new System.Drawing.Printing.PrintDocument();
		this.Timer1 = new System.Windows.Forms.Timer(this.components);
		this.Label20 = new System.Windows.Forms.Label();
		base.SuspendLayout();
		this.TextBox1.Location = new System.Drawing.Point(12, 12);
		this.TextBox1.Name = "TextBox1";
		this.TextBox1.Size = new System.Drawing.Size(313, 20);
		this.TextBox1.TabIndex = 0;
		this.Button1.Location = new System.Drawing.Point(331, 10);
		this.Button1.Name = "Button1";
		this.Button1.Size = new System.Drawing.Size(75, 23);
		this.Button1.TabIndex = 1;
		this.Button1.Text = "Ingresar";
		this.Button1.UseVisualStyleBackColor = true;
		this.ListView1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.ListView1.Location = new System.Drawing.Point(12, 60);
		this.ListView1.Name = "ListView1";
		this.ListView1.Size = new System.Drawing.Size(456, 451);
		this.ListView1.TabIndex = 2;
		this.ListView1.UseCompatibleStateImageBehavior = false;
		this.ListView2.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		this.ListView2.Location = new System.Drawing.Point(507, 343);
		this.ListView2.Name = "ListView2";
		this.ListView2.Size = new System.Drawing.Size(223, 168);
		this.ListView2.TabIndex = 3;
		this.ListView2.UseCompatibleStateImageBehavior = false;
		this.Button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.Button2.Location = new System.Drawing.Point(12, 539);
		this.Button2.Name = "Button2";
		this.Button2.Size = new System.Drawing.Size(75, 23);
		this.Button2.TabIndex = 4;
		this.Button2.Text = "Imprimir";
		this.Button2.UseVisualStyleBackColor = true;
		this.Button3.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.Button3.Location = new System.Drawing.Point(93, 539);
		this.Button3.Name = "Button3";
		this.Button3.Size = new System.Drawing.Size(75, 23);
		this.Button3.TabIndex = 5;
		this.Button3.Text = "Etiqueta";
		this.Button3.UseVisualStyleBackColor = true;
		this.Button4.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.Button4.Location = new System.Drawing.Point(174, 539);
		this.Button4.Name = "Button4";
		this.Button4.Size = new System.Drawing.Size(75, 23);
		this.Button4.TabIndex = 6;
		this.Button4.Text = "Buscar";
		this.Button4.UseVisualStyleBackColor = true;
		this.Label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		this.Label1.AutoSize = true;
		this.Label1.Location = new System.Drawing.Point(507, 327);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(43, 13);
		this.Label1.TabIndex = 7;
		this.Label1.Text = "Retiros:";
		this.Label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		this.Label2.AutoSize = true;
		this.Label2.Location = new System.Drawing.Point(565, 327);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(39, 13);
		this.Label2.TabIndex = 8;
		this.Label2.Text = "Label2";
		this.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.Label3.AutoSize = true;
		this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label3.Location = new System.Drawing.Point(514, 51);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(45, 16);
		this.Label3.TabIndex = 9;
		this.Label3.Text = "Envio:";
		this.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.Label4.AutoSize = true;
		this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 36f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label4.Location = new System.Drawing.Point(573, 26);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(175, 55);
		this.Label4.TabIndex = 10;
		this.Label4.Text = "Label4";
		this.Label5.AutoSize = true;
		this.Label5.Location = new System.Drawing.Point(177, 44);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(39, 13);
		this.Label5.TabIndex = 11;
		this.Label5.Text = "Bultos:";
		this.Label6.AutoSize = true;
		this.Label6.Location = new System.Drawing.Point(222, 44);
		this.Label6.Name = "Label6";
		this.Label6.Size = new System.Drawing.Size(39, 13);
		this.Label6.TabIndex = 12;
		this.Label6.Text = "Label6";
		this.Label7.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.Label7.AutoSize = true;
		this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label7.Location = new System.Drawing.Point(516, 266);
		this.Label7.Name = "Label7";
		this.Label7.Size = new System.Drawing.Size(50, 16);
		this.Label7.TabIndex = 13;
		this.Label7.Text = "Chofer:";
		this.Label8.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.Label8.AutoSize = true;
		this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label8.Location = new System.Drawing.Point(603, 266);
		this.Label8.Name = "Label8";
		this.Label8.Size = new System.Drawing.Size(49, 16);
		this.Label8.TabIndex = 14;
		this.Label8.Text = "Label8";
		this.Label9.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.Label9.AutoSize = true;
		this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label9.Location = new System.Drawing.Point(514, 202);
		this.Label9.Name = "Label9";
		this.Label9.Size = new System.Drawing.Size(54, 16);
		this.Label9.TabIndex = 15;
		this.Label9.Text = "Estado:";
		this.Label10.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.Label10.AutoSize = true;
		this.Label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 36f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label10.Location = new System.Drawing.Point(573, 187);
		this.Label10.Name = "Label10";
		this.Label10.Size = new System.Drawing.Size(203, 55);
		this.Label10.TabIndex = 16;
		this.Label10.Text = "Label10";
		this.Label11.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.Label11.AutoSize = true;
		this.Label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label11.Location = new System.Drawing.Point(516, 291);
		this.Label11.Name = "Label11";
		this.Label11.Size = new System.Drawing.Size(48, 16);
		this.Label11.TabIndex = 17;
		this.Label11.Text = "Bultos:";
		this.Label12.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.Label12.AutoSize = true;
		this.Label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label12.Location = new System.Drawing.Point(603, 291);
		this.Label12.Name = "Label12";
		this.Label12.Size = new System.Drawing.Size(56, 16);
		this.Label12.TabIndex = 18;
		this.Label12.Text = "Label12";
		this.Label13.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.Label13.AutoSize = true;
		this.Label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label13.Location = new System.Drawing.Point(753, 266);
		this.Label13.Name = "Label13";
		this.Label13.Size = new System.Drawing.Size(103, 16);
		this.Label13.TabIndex = 19;
		this.Label13.Text = "Observaciones:";
		this.Label14.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.Label14.AutoSize = true;
		this.Label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label14.Location = new System.Drawing.Point(753, 291);
		this.Label14.Name = "Label14";
		this.Label14.Size = new System.Drawing.Size(56, 16);
		this.Label14.TabIndex = 20;
		this.Label14.Text = "Label14";
		this.Label15.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.Label15.AutoSize = true;
		this.Label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label15.Location = new System.Drawing.Point(514, 129);
		this.Label15.Name = "Label15";
		this.Label15.Size = new System.Drawing.Size(42, 16);
		this.Label15.TabIndex = 21;
		this.Label15.Text = "Zona:";
		this.Label16.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.Label16.AutoSize = true;
		this.Label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 36f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label16.Location = new System.Drawing.Point(573, 105);
		this.Label16.Name = "Label16";
		this.Label16.Size = new System.Drawing.Size(203, 55);
		this.Label16.TabIndex = 22;
		this.Label16.Text = "Label16";
		this.ListView3.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		this.ListView3.Location = new System.Drawing.Point(756, 343);
		this.ListView3.Name = "ListView3";
		this.ListView3.Size = new System.Drawing.Size(225, 168);
		this.ListView3.TabIndex = 23;
		this.ListView3.UseCompatibleStateImageBehavior = false;
		this.Label17.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		this.Label17.AutoSize = true;
		this.Label17.Location = new System.Drawing.Point(832, 327);
		this.Label17.Name = "Label17";
		this.Label17.Size = new System.Drawing.Size(45, 13);
		this.Label17.TabIndex = 24;
		this.Label17.Text = "Label17";
		this.Label18.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		this.Label18.AutoSize = true;
		this.Label18.Location = new System.Drawing.Point(753, 327);
		this.Label18.Name = "Label18";
		this.Label18.Size = new System.Drawing.Size(73, 13);
		this.Label18.TabIndex = 25;
		this.Label18.Text = "Vuelve a ruta:";
		this.Label19.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.Label19.AutoSize = true;
		this.Label19.Location = new System.Drawing.Point(12, 514);
		this.Label19.Name = "Label19";
		this.Label19.Size = new System.Drawing.Size(45, 13);
		this.Label19.TabIndex = 26;
		this.Label19.Text = "Label19";
		this.PrintDialog1.UseEXDialog = true;
		this.Label20.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.Label20.AutoSize = true;
		this.Label20.Location = new System.Drawing.Point(504, 15);
		this.Label20.Name = "Label20";
		this.Label20.Size = new System.Drawing.Size(45, 13);
		this.Label20.TabIndex = 27;
		this.Label20.Text = "Label20";
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(1103, 574);
		base.Controls.Add(this.Label20);
		base.Controls.Add(this.Label19);
		base.Controls.Add(this.Label18);
		base.Controls.Add(this.Label17);
		base.Controls.Add(this.ListView3);
		base.Controls.Add(this.Label16);
		base.Controls.Add(this.Label15);
		base.Controls.Add(this.Label14);
		base.Controls.Add(this.Label13);
		base.Controls.Add(this.Label12);
		base.Controls.Add(this.Label11);
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
		base.Controls.Add(this.Button4);
		base.Controls.Add(this.Button3);
		base.Controls.Add(this.Button2);
		base.Controls.Add(this.ListView2);
		base.Controls.Add(this.ListView1);
		base.Controls.Add(this.Button1);
		base.Controls.Add(this.TextBox1);
		base.Name = "Recepcion";
		this.Text = "Recepcion";
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private void Recepcion_Load(object sender, EventArgs e)
	{
		actualizar_listview();
		Label8.Text = "";
		Label10.Text = "";
		Label12.Text = Conversions.ToString(0);
		Label14.Text = "";
		Label2.Text = Conversions.ToString(0);
		Label17.Text = Conversions.ToString(0);
		Label16.Text = "";
		Label4.Text = Conversions.ToString(0);
		Label6.Text = Conversions.ToString(0);
		Label19.Text = Conversions.ToString(0);
	}

	private void TextBox1_TextChanged(object sender, EventArgs e)
	{
		TiempoEjecutar(1);
	}

	public object TiempoEjecutar(int Tiempo)
	{
		object result = "";
		TiempoRestante = Tiempo;
		Timer1.Interval = 1;
		short Interval = 1;
		TimerOn(ref Interval);
		return result;
	}

	public void TimerOn(ref short Interval)
	{
		if (Interval > 0)
		{
			Timer1.Enabled = true;
		}
		else
		{
			Timer1.Enabled = false;
		}
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		checked
		{
			if (TiempoRestante >= 0)
			{
				Label20.Text = Conversions.ToString(TiempoRestante);
				TiempoRestante--;
			}
			else
			{
				Timer1.Enabled = false;
				leerNumero();
			}
		}
	}

	private void leerNumero()
	{
		string empty = string.Empty;
		string comentario = string.Empty;
		int num = 0;
		if (Operators.CompareString(TextBox1.Text, "", TextCompare: true) == 0)
		{
			return;
		}
		Label2.Text = Conversions.ToString(0);
		Label6.Text = Conversions.ToString(0);
		Label8.Text = "";
		Label10.Text = "";
		Label12.Text = Conversions.ToString(0);
		Label14.Text = "";
		Label16.Text = "";
		Label17.Text = Conversions.ToString(0);
		Label19.Text = Conversions.ToString(0);
		Label4.Text = Strings.Mid(TextBox1.Text, 1, checked(Strings.Len(TextBox1.Text) - 1));
		num = Conversions.ToInteger(Label4.Text);
		int num2 = Conversions.ToInteger(Mod_Recepcion.vecesEnCD(num));
		try
		{
			try
			{
				guia = Conversions.ToInteger(buscar_guia(Conversions.ToString(num)));
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				guia = 0;
				ProjectData.ClearProjectError();
			}
			if (guia > 0)
			{
				int num3 = Conversions.ToInteger(buscar_envio(num));
				int num4 = Conversions.ToInteger(Operators.AddObject(Mod_Recepcion.bultosActuales2(num, fecha1), 1));
				if (num4 <= num3)
				{
					if (num4 == num3)
					{
						empty = Conversions.ToString(Mod_Recepcion.estadoAnterior(num));
						if (Operators.CompareString(empty, "A REPROGRAMAR", TextCompare: true) == 0)
						{
							return;
						}
						DateTime t = Conversions.ToDate(Strings.Format(DateAndTime.Today, "dd/MM/yyyy"));
						DateTime t2 = Conversions.ToDate(Mod_Recepcion.fechaEntrega(num));
						if (DateTime.Compare(t, t2) == 0)
						{
							int num5 = Conversions.ToInteger(Mod_fechas.cambiarFechaEntrega(num));
							comentario = ((num5 != 1) ? "No se pudo actualizar fecha de entrega" : "Se cambio la fecha de entrega");
						}
						if (DateTime.Compare(t, t2) > 0)
						{
							int num6 = Conversions.ToInteger(Mod_fechas.cambiarFechaEntrega(num));
							comentario = ((num6 != 1) ? "No se pudo actualizar fecha de entrega" : "Se cambio la fecha de entrega");
						}
						if (num2 > 1)
						{
							recepcion_guia(num, num3, num4, "EN CD", Label8.Text, MySettingsProperty.Settings.Usuario);
							string sQL = ("UPDATE etransEnvios SET Estado='A REPROGRAMAR' WHERE id_envio=" + Conversions.ToString(num)) ?? "";
							Mod_ConeccionBD.BD_Sentencia(sQL);
							update_guia(guia, num, "A REPROGRAMAR");
							string text = Conversions.ToString(Mod_Etrans.actualizar_estado_web(num, 10));
							int num7 = Conversions.ToInteger(Mod_logger.historialenter(Conversions.ToString(num), "", "A REPROGRAMAR", "Se vencieron los intentos de entrega"));
							Label10.Text = "A REPROGRAMAR";
						}
						else
						{
							recepcion_guia(num, num3, num4, "EN CD", Label8.Text, MySettingsProperty.Settings.Usuario);
							string sQL2 = ("UPDATE etransEnvios SET Estado='EN CD' WHERE id_envio=" + Conversions.ToString(num)) ?? "";
							Mod_ConeccionBD.BD_Sentencia(sQL2);
							update_guia(guia, num, "EN CD");
							string text2 = Conversions.ToString(Mod_Etrans.actualizar_estado_web(num, 5));
							int num8 = Conversions.ToInteger(Mod_logger.historialenter(Conversions.ToString(num), "", "EN CD", comentario));
							Label10.Text = "EN CD";
						}
					}
					else
					{
						recepcion_guia(num, num3, num4, "RECOLECTADO", Label8.Text, MySettingsProperty.Settings.Usuario);
						int num9 = Conversions.ToInteger(Mod_logger.historialenter(Conversions.ToString(num), "", "RECOLECTADO", comentario));
					}
				}
			}
			else
			{
				int num10 = Conversions.ToInteger(buscar_envio(num));
				int num11 = Conversions.ToInteger(Operators.AddObject(Mod_Recepcion.bultosActuales2(num, fecha1), 1));
				if (num11 <= num10)
				{
					if (num11 == num10)
					{
						empty = Conversions.ToString(Mod_Recepcion.estadoAnterior(num));
						if (Operators.CompareString(empty, "A REPROGRAMAR", TextCompare: true) == 0)
						{
							return;
						}
						DateTime t3 = Conversions.ToDate(Strings.Format(DateAndTime.Today, "dd/MM/yyyy"));
						DateTime t4 = Conversions.ToDate(Mod_Recepcion.fechaEntrega(num));
						if (DateTime.Compare(t3, t4) == 0)
						{
							int num12 = Conversions.ToInteger(Mod_fechas.cambiarFechaEntrega(num));
							comentario = ((num12 != 1) ? "No se pudo actualizar fecha de entrega" : "Se cambio la fecha de entrega");
						}
						if (DateTime.Compare(t3, t4) > 0)
						{
							int num13 = Conversions.ToInteger(Mod_fechas.cambiarFechaEntrega(num));
							comentario = ((num13 != 1) ? "No se pudo actualizar fecha de entrega" : "Se cambio la fecha de entrega");
						}
						if (num2 > 1)
						{
							recepcion_guia(num, num10, num11, "EN CD", Label8.Text, MySettingsProperty.Settings.Usuario);
							string sQL3 = ("UPDATE etransEnvios SET Estado='A REPROGRAMAR' WHERE id_envio=" + Conversions.ToString(num)) ?? "";
							Mod_ConeccionBD.BD_Sentencia(sQL3);
							update_guia(guia, num, "A REPROGRAMAR");
							string text3 = Conversions.ToString(Mod_Etrans.actualizar_estado_web(num, 10));
							int num14 = Conversions.ToInteger(Mod_logger.historialenter(Conversions.ToString(num), "", "A REPROGRAMAR", "Se vencieron los intentos de entrega"));
							Label10.Text = "A REPROGRAMAR";
						}
						else
						{
							recepcion_guia(num, num10, num11, "EN CD", Label8.Text, MySettingsProperty.Settings.Usuario);
							string sQL4 = ("UPDATE etransEnvios SET Estado='EN CD' WHERE id_envio=" + Conversions.ToString(num)) ?? "";
							Mod_ConeccionBD.BD_Sentencia(sQL4);
							update_guia(guia, num, "EN CD");
							string text4 = Conversions.ToString(Mod_Etrans.actualizar_estado_web(num, 5));
							int num15 = Conversions.ToInteger(Mod_logger.historialenter(Conversions.ToString(num), "", "EN CD", comentario));
							Label10.Text = "EN CD";
						}
					}
					else
					{
						recepcion_guia(num, num10, num11, "RECOLECTADO", Label8.Text, MySettingsProperty.Settings.Usuario);
						int num16 = Conversions.ToInteger(Mod_logger.historialenter(Conversions.ToString(num), "", "RECOLECTADO", comentario));
					}
				}
			}
			actualizar_listview();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox(ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	private object buscar_guia(string envio)
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Expected O, but got Unknown
		string text = "0";
		try
		{
			if (Operators.CompareString(Label4.Text, "", TextCompare: true) != 0)
			{
				DataTable dataTable = new DataTable("x1");
				string text2 = "Select D_cp From etransEnvios WHERE id_envio='" + envio + "'";
				MySqlDataAdapter val = new MySqlDataAdapter(text2, Mod_Sentencias.cnn);
				DataSet dataSet = new DataSet();
				((DbDataAdapter)(object)val).Fill(dataTable);
				text = dataTable.Rows[0]["D_cp"].ToString();
				DataTable dataTable2 = new DataTable("x2");
				string text3 = "SELECT (Select Chofer from Flota where numero=planchada.chofer) as Chofer,Estado,Bultos,Observaciones, guia FROM Planchada WHERE Cliente='ETRANS' AND Remitos = " + envio + " AND Fecha='" + fecha1 + "'";
				MySqlDataAdapter val2 = new MySqlDataAdapter(text3, Mod_Sentencias.cnn);
				DataSet dataSet2 = new DataSet();
				((DbDataAdapter)(object)val2).Fill(dataTable2);
				guia = Conversions.ToInteger(dataTable2.Rows[0]["guia"]);
				try
				{
					DataTable dataTable3 = new DataTable("x3");
					string text4 = ("Select zona,(SELECT Descripcion FROM Zonas WHERE Zona=localidades.zona) AS Descripcion from localidades where CP=" + text) ?? "";
					MySqlDataAdapter val3 = new MySqlDataAdapter(text4, Mod_Sentencias.cnn);
					DataSet dataSet3 = new DataSet();
					((DbDataAdapter)(object)val3).Fill(dataTable3);
					Label16.Text = dataTable3.Rows[0]["Descripcion"].ToString();
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					Label16.Text = "Cap";
					ProjectData.ClearProjectError();
				}
				Label8.Text = dataTable2.Rows[0]["Chofer"].ToString();
				Label10.Text = dataTable2.Rows[0]["Estado"].ToString();
				if (Operators.CompareString(Label10.Text, "A REPROGRAMAR", TextCompare: true) == 0)
				{
					Label10.ForeColor = Color.Red;
				}
				else
				{
					Label10.ForeColor = Color.Black;
				}
				Label12.Text = dataTable2.Rows[0]["Bultos"].ToString();
				Label14.Text = dataTable2.Rows[0]["Observaciones"].ToString();
				TextBox1.Text = "";
				TextBox1.Focus();
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			TextBox1.Text = "";
			TextBox1.Focus();
			guia = 0;
			ProjectData.ClearProjectError();
		}
		return guia;
	}

	private void TextBox1_LostFocus(object sender, EventArgs e)
	{
		TextBox1.Text = "";
		TextBox1.Focus();
	}

	private void update_guia(int guia, int id_envio, string estado)
	{
		try
		{
			if (guia > 0)
			{
				try
				{
					string sQL = "UPDATE Planchada SET Estado='" + estado + "', Usuario='" + MySettingsProperty.Settings.Usuario + "', fecha='" + fecha1 + "' WHERE guia=" + Conversions.ToString(guia) + " ";
					Mod_ConeccionBD.BD_Sentencia(sQL);
					return;
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
					return;
				}
			}
			try
			{
				string sQL2 = "UPDATE Planchada SET Estado='" + estado + "', Usuario='" + MySettingsProperty.Settings.Usuario + "' WHERE fecha='" + fecha1 + "' and comprobante=" + Conversions.ToString(guia);
				Mod_ConeccionBD.BD_Sentencia(sQL2);
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void actualizar_listview()
	{
		try
		{
			ListView2.Clear();
			string sql = "SELECT COUNT(Remitos) As Remitos, (SELECT Chofer FROM Flota WHERE Numero=planchada.Chofer) as Nombre, Chofer FROM Planchada WHERE cliente='ETRANS' And Fecha='" + fecha1 + "' AND Estado='RECOLECTADO' group by Chofer";
			Mod_Sentencias.cargar_datos_lv_completa(ListView2, sql, Label2);
			ListView3.Clear();
			string sql2 = "SELECT COUNT(Remitos) As Remitos, (SELECT Chofer FROM Flota WHERE Numero=planchada.Chofer) as Nombre, Chofer FROM Planchada WHERE cliente='ETRANS' And Fecha='" + fecha1 + "' AND Estado='NO ENTREGADO' group by Chofer";
			Mod_Sentencias.cargar_datos_lv_completa(ListView3, sql2, Label17);
			ListView1.Clear();
			string sql3 = "SELECT id_envio,BultosRecep,BultosTotal,Estado,(Observaciones) As Chofer FROM Recepcion WHERE fecha='" + fecha1 + "' ORDER BY id_envio desc";
			Mod_Sentencias.cargar_datos_lv_completa(ListView1, sql3, Label19);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox(ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void recepcion_guia(int id_envio, int BultosTotal, int BultosRecep, string Estado, string Observaciones, string Usuario)
	{
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected O, but got Unknown
		try
		{
			string text = "INSERT INTO Recepcion ( id_envio, BultosTotal,BultosRecep,Estado,Observaciones,Fecha,Usuario) VALUES(" + Conversions.ToString(id_envio) + ", " + Conversions.ToString(BultosTotal) + "," + Conversions.ToString(BultosRecep) + ",'" + Estado + "','" + Observaciones + "','" + fecha1 + "','" + Usuario + "') ON DUPLICATE KEY UPDATE  BultosRecep=" + Conversions.ToString(BultosRecep) + ", Estado='" + Estado + "',fecha='" + fecha1 + "'";
			Mod_ConeccionBD.BD_Sentencia(text);
			MySqlCommand val = new MySqlCommand(text, Mod_Sentencias.cnn);
			Mod_Sentencias.cnn.Open();
			val.ExecuteNonQuery();
			Mod_Sentencias.cnn.Close();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox(ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	private object buscar_envio(int envio)
	{
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected O, but got Unknown
		string text = "0";
		int num = 0;
		try
		{
			if (Operators.CompareString(Label4.Text, "", TextCompare: true) != 0)
			{
				DataTable dataTable = new DataTable("x1");
				string text2 = "Select D_cp, estado, bultos, observaciones From etransEnvios WHERE id_envio='" + Conversions.ToString(envio) + "'";
				MySqlDataAdapter val = new MySqlDataAdapter(text2, Mod_Sentencias.cnn);
				DataSet dataSet = new DataSet();
				((DbDataAdapter)(object)val).Fill(dataTable);
				text = dataTable.Rows[0]["D_cp"].ToString();
				Label10.Text = dataTable.Rows[0]["Estado"].ToString();
				Label12.Text = dataTable.Rows[0]["Bultos"].ToString();
				Label14.Text = dataTable.Rows[0]["Observaciones"].ToString();
				num = Conversions.ToInteger(dataTable.Rows[0]["Bultos"]);
				try
				{
					DataTable dataTable2 = new DataTable("x3");
					string text3 = ("Select zona,(SELECT Descripcion FROM Zonas WHERE Zona=localidades.zona) AS Descripcion from localidades where CP=" + text) ?? "";
					MySqlDataAdapter val2 = new MySqlDataAdapter(text3, Mod_Sentencias.cnn);
					DataSet dataSet2 = new DataSet();
					((DbDataAdapter)(object)val2).Fill(dataTable2);
					Label16.Text = dataTable2.Rows[0]["Descripcion"].ToString();
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					Label16.Text = "Cap";
					ProjectData.ClearProjectError();
				}
				TextBox1.Text = "";
				TextBox1.Focus();
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			TextBox1.Text = "";
			TextBox1.Focus();
			ProjectData.ClearProjectError();
		}
		return num;
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
			Image image = (Image)Mod_QR.qrcodegen(Et_qrCode);
			Image etrans = Resources.etrans2;
			e.Graphics.DrawImage(image, num2 + 10, num3 + 70);
			e.Graphics.DrawImage(etrans, num2 + 10, num3 + 10);
			int num4 = default(int);
			e.Graphics.DrawString(Et_remitos, font3, Brushes.Black, num2 + 150, num3 + num4 + 10);
			e.Graphics.DrawString(Et_bultos, font3, Brushes.Black, num2 + 110, num3 + num4 + 70);
			e.Graphics.DrawString(Et_localidad, font3, Brushes.Black, num2 + 110, num3 + num4 + 90);
			e.Graphics.DrawString(Et_cp, font3, Brushes.Black, num2 + 110, num3 + num4 + 110);
			e.Graphics.DrawString(Et_zona, font3, Brushes.Black, num2 + 110, num3 + num4 + 130);
		}
	}

	private void Button3_Click(object sender, EventArgs e)
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		try
		{
			string text = Interaction.InputBox("Transaccion", "Transaccion");
			if (Operators.CompareString(text, "", TextCompare: true) == 0)
			{
				Interaction.MsgBox("Ingrese un numero de Transaccion");
				return;
			}
			DataTable dataTable = new DataTable("x1");
			string text2 = "Select D_cp,D_localidad,Bultos From etransEnvios WHERE id_envio='" + text + "'";
			MySqlDataAdapter val = new MySqlDataAdapter(text2, Mod_Sentencias.cnn);
			DataSet dataSet = new DataSet();
			((DbDataAdapter)(object)val).Fill(dataTable);
			Et_remitos = "N° Trans: " + text;
			Et_cp = Conversions.ToString(Operators.ConcatenateObject("Cp: ", dataTable.Rows[0]["D_cp"]));
			Et_localidad = Conversions.ToString(Operators.ConcatenateObject("Loc: ", dataTable.Rows[0]["D_localidad"]));
			PrintDialog1.Document = PrintDocument1;
			PrintDialog1.PrinterSettings = PrintDocument1.PrinterSettings;
			PrintDialog1.AllowSomePages = true;
			if (PrintDialog1.ShowDialog() == DialogResult.OK)
			{
				int num = Conversions.ToInteger(dataTable.Rows[0]["Bultos"]);
				for (int i = 1; i <= num; i = checked(i + 1))
				{
					Et_bultos = Conversions.ToString(Operators.ConcatenateObject("Bulto: " + Conversions.ToString(i) + "/", dataTable.Rows[0]["Bultos"]));
					Et_qrCode = text + Conversions.ToString(i);
					PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings;
					PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
					PrintDocument1.DefaultPageSettings.Landscape = false;
					printPreviewDialog.WindowState = FormWindowState.Maximized;
					printPreviewDialog.Document = PrintDocument1;
					PrintDocument1.Print();
					PrintDocument1.Dispose();
				}
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

	private void PrintDocument2_PrintPage(object sender, PrintPageEventArgs e)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		DataTable dataTable = new DataTable("X1");
		string text = "SELECT guia, id_envio, BultosTotal,BultosRecep,Estado,Observaciones,Fecha,Usuario FROM recepcion WHERE Fecha='" + fecha1 + "'";
		MySqlDataAdapter val = new MySqlDataAdapter(text, Mod_Sentencias.cnn);
		((DbDataAdapter)(object)val).Fill(dataTable);
		Font font = new Font("Arial", 6.75f, FontStyle.Italic, GraphicsUnit.Point, 0);
		Font font2 = new Font("Arial", 8.75f, FontStyle.Italic, GraphicsUnit.Point, 0);
		Font font3 = new Font("Arial", 10.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		int num = 0;
		string s = MyProject.Forms.Form1_Inicio.nombreusuario.Text;
		string s2 = dataTable.Rows[0]["Fecha"].ToString();
		checked
		{
			int num2 = default(int);
			e.Graphics.DrawString(s2, font2, Brushes.Blue, 700f, num2 + 30);
			e.Graphics.DrawString("HOJA DE RECEPCION", font2, Brushes.Blue, 30f, num2 + 30);
			e.Graphics.DrawString(s, font2, Brushes.Blue, 700f, num2 + 50);
			e.Graphics.DrawLine(Pens.Brown, 20, 79, 700, 79);
			e.Graphics.DrawLine(Pens.Brown, 20, 79, 20, 95);
			e.Graphics.DrawLine(Pens.Brown, 20, 95, 700, 95);
			e.Graphics.DrawLine(Pens.Brown, 700, 79, 700, 95);
			e.Graphics.DrawString("ENVIO", font2, Brushes.Blue, 30f, num2 + 80);
			e.Graphics.DrawString("BULTOS RECEPCIONADOS", font2, Brushes.Blue, 100f, num2 + 80);
			e.Graphics.DrawString("BULTOS TOTALES", font2, Brushes.Blue, 300f, num2 + 80);
			e.Graphics.DrawString("ESTADO", font2, Brushes.Blue, 500f, num2 + 80);
			while (dato < dataTable.Rows.Count)
			{
				string s3 = dataTable.Rows[dato]["id_envio"].ToString();
				string s4 = dataTable.Rows[dato]["BultosRecep"].ToString();
				string s5 = dataTable.Rows[dato]["BultosTotal"].ToString();
				string s6 = dataTable.Rows[dato]["Estado"].ToString();
				num2 = ((pagina != 0) ? (num * 20 + 100) : 100);
				e.Graphics.DrawString(s3, font, Brushes.Black, 30f, num2);
				e.Graphics.DrawString(s4, font, Brushes.Black, 100f, num2);
				e.Graphics.DrawString(s5, font, Brushes.Black, 300f, num2);
				e.Graphics.DrawString(s6, font, Brushes.Black, 500f, num2);
				num++;
				dato++;
				pagina++;
				if (num2 > 1000)
				{
					pagina = 0;
					e.HasMorePages = true;
					return;
				}
				e.HasMorePages = false;
			}
			e.Graphics.DrawLine(Pens.Brown, 20, num2 + 19, 700, num2 + 19);
			e.Graphics.DrawLine(Pens.Brown, 20, num2 + 19, 20, num2 + 38);
			e.Graphics.DrawLine(Pens.Brown, 20, num2 + 38, 700, num2 + 38);
			e.Graphics.DrawLine(Pens.Brown, 700, num2 + 19, 700, num2 + 38);
		}
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
		PrintDocument2.DefaultPageSettings.Landscape = false;
		printPreviewDialog.WindowState = FormWindowState.Maximized;
		printPreviewDialog.Document = PrintDocument2;
		PrintDocument2.Print();
		PrintDocument2.Dispose();
	}

	private void ListView1_ColumnClick(object sender, ColumnClickEventArgs e)
	{
		Mod_Ordenaclumnas.ordenar_columnas(ListView1, RuntimeHelpers.GetObjectValue(sender), e);
	}

	private void TextBox1_Validated(object sender, EventArgs e)
	{
		if (TextBox1.Text.Length == 2)
		{
			Interaction.MsgBox("2");
		}
		if (TextBox1.Text.Length == 3)
		{
			Interaction.MsgBox("3");
		}
	}
}
