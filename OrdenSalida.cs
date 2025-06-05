using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Hermes.My;
using Hermes.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Hermes;

[DesignerGenerated]
public class OrdenSalida : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("empresasCbo")]
	private ComboBox _empresasCbo;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ComboBox1")]
	private ComboBox _ComboBox1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("TextBox2")]
	private TextBox _TextBox2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("asignarBtn")]
	private Button _asignarBtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ListView1")]
	private ListView _ListView1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("crearBtn")]
	private Button _crearBtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("cancelarBtn")]
	private Button _cancelarBtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("PrintDocument1")]
	private PrintDocument _PrintDocument1;

	private List<Mod_Productos.datos_producto> productosCompleto;

	private List<Mod_eventuales.datos_eventuales> eventualesCompleto;

	private int print_order;

	private Mod_Ordenes.ordendesalida selectedOrder;

	private List<Mod_Ordenes.orderDetallePrint> selectedOrderItems;

	private Mod_Ordenes.Destino selectedDestinatario;

	[SpecialName]
	private int _0024STATIC_0024PrintDocument1_PrintPage_002420211C128195_0024CurrentYPosition;

	[SpecialName]
	private StaticLocalInitFlag _0024STATIC_0024PrintDocument1_PrintPage_002420211C128195_0024CurrentYPosition_0024Init;

	[SpecialName]
	private int _0024STATIC_0024PrintDetails_0024201110128195_0024LastIndex;

	[SpecialName]
	private StaticLocalInitFlag _0024STATIC_0024PrintDetails_0024201110128195_0024LastIndex_0024Init;

	[SpecialName]
	private int _0024STATIC_0024PrintDetails_0024201110128195_0024CurrentPage;

	[SpecialName]
	private StaticLocalInitFlag _0024STATIC_0024PrintDetails_0024201110128195_0024CurrentPage_0024Init;

	[SpecialName]
	private int _0024STATIC_0024newPrintDetail_0024201110128195_0024LastIndex;

	[SpecialName]
	private StaticLocalInitFlag _0024STATIC_0024newPrintDetail_0024201110128195_0024LastIndex_0024Init;

	[SpecialName]
	private int _0024STATIC_0024newPrintDetail_0024201110128195_0024CurrentPage;

	[SpecialName]
	private StaticLocalInitFlag _0024STATIC_0024newPrintDetail_0024201110128195_0024CurrentPage_0024Init;

	[field: AccessedThroughProperty("GroupBox1")]
	internal virtual GroupBox GroupBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("idEmpresaLbl")]
	internal virtual Label idEmpresaLbl
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ComboBox empresasCbo
	{
		[CompilerGenerated]
		get
		{
			return _empresasCbo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = empresasCbo_SelectedIndexChanged;
			ComboBox comboBox = _empresasCbo;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged -= value2;
			}
			_empresasCbo = value;
			comboBox = _empresasCbo;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged += value2;
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

	[field: AccessedThroughProperty("codeLbl")]
	internal virtual Label codeLbl
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual TextBox TextBox2
	{
		[CompilerGenerated]
		get
		{
			return _TextBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			KeyPressEventHandler value2 = TextBox2_KeyPress;
			TextBox textBox = _TextBox2;
			if (textBox != null)
			{
				textBox.KeyPress -= value2;
			}
			_TextBox2 = value;
			textBox = _TextBox2;
			if (textBox != null)
			{
				textBox.KeyPress += value2;
			}
		}
	}

	[field: AccessedThroughProperty("buscarDescripcionLbl")]
	internal virtual Label buscarDescripcionLbl
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("StatusStrip1")]
	internal virtual StatusStrip StatusStrip1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("GroupBox4")]
	internal virtual GroupBox GroupBox4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button asignarBtn
	{
		[CompilerGenerated]
		get
		{
			return _asignarBtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = asignarBtn_Click;
			Button button = _asignarBtn;
			if (button != null)
			{
				button.Click -= value2;
			}
			_asignarBtn = value;
			button = _asignarBtn;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("TextBox3")]
	internal virtual TextBox TextBox3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("unidadesLbl")]
	internal virtual Label unidadesLbl
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

	[field: AccessedThroughProperty("GroupBox6")]
	internal virtual GroupBox GroupBox6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("imprimirBtn")]
	internal virtual Button imprimirBtn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button crearBtn
	{
		[CompilerGenerated]
		get
		{
			return _crearBtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = crearBtn_Click;
			Button button = _crearBtn;
			if (button != null)
			{
				button.Click -= value2;
			}
			_crearBtn = value;
			button = _crearBtn;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button cancelarBtn
	{
		[CompilerGenerated]
		get
		{
			return _cancelarBtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = cancelarBtn_Click;
			Button button = _cancelarBtn;
			if (button != null)
			{
				button.Click -= value2;
			}
			_cancelarBtn = value;
			button = _cancelarBtn;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Item")]
	internal virtual ColumnHeader Item
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Unidades")]
	internal virtual ColumnHeader Unidades
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Producto")]
	internal virtual ColumnHeader Producto
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Descripcion")]
	internal virtual ColumnHeader Descripcion
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Codigo")]
	internal virtual ColumnHeader Codigo
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

	[field: AccessedThroughProperty("RadioButton3")]
	internal virtual RadioButton RadioButton3
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

	[field: AccessedThroughProperty("TextBox7")]
	internal virtual TextBox TextBox7
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

	[field: AccessedThroughProperty("Label8")]
	internal virtual Label Label8
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

	[field: AccessedThroughProperty("valor")]
	internal virtual ColumnHeader valor
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

	[field: AccessedThroughProperty("TextBox6")]
	internal virtual TextBox TextBox6
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

	[field: AccessedThroughProperty("TextBox4")]
	internal virtual TextBox TextBox4
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

	[field: AccessedThroughProperty("Button1")]
	internal virtual Button Button1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ComboBox2")]
	internal virtual ComboBox ComboBox2
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

	[field: AccessedThroughProperty("Label14")]
	internal virtual Label Label14
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

	[field: AccessedThroughProperty("GroupBox3")]
	internal virtual GroupBox GroupBox3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("variacionColumn")]
	internal virtual ColumnHeader variacionColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public OrdenSalida()
	{
		base.Load += OrdenSalida_Load;
		print_order = 0;
		selectedOrder = default(Mod_Ordenes.ordendesalida);
		selectedOrderItems = new List<Mod_Ordenes.orderDetallePrint>();
		selectedDestinatario = default(Mod_Ordenes.Destino);
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hermes.OrdenSalida));
		this.GroupBox1 = new System.Windows.Forms.GroupBox();
		this.RadioButton3 = new System.Windows.Forms.RadioButton();
		this.RadioButton2 = new System.Windows.Forms.RadioButton();
		this.RadioButton1 = new System.Windows.Forms.RadioButton();
		this.Label1 = new System.Windows.Forms.Label();
		this.TextBox1 = new System.Windows.Forms.TextBox();
		this.empresasCbo = new System.Windows.Forms.ComboBox();
		this.idEmpresaLbl = new System.Windows.Forms.Label();
		this.Label2 = new System.Windows.Forms.Label();
		this.ComboBox1 = new System.Windows.Forms.ComboBox();
		this.codeLbl = new System.Windows.Forms.Label();
		this.TextBox2 = new System.Windows.Forms.TextBox();
		this.buscarDescripcionLbl = new System.Windows.Forms.Label();
		this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
		this.GroupBox4 = new System.Windows.Forms.GroupBox();
		this.Label14 = new System.Windows.Forms.Label();
		this.TextBox7 = new System.Windows.Forms.TextBox();
		this.Label10 = new System.Windows.Forms.Label();
		this.Label9 = new System.Windows.Forms.Label();
		this.Label8 = new System.Windows.Forms.Label();
		this.asignarBtn = new System.Windows.Forms.Button();
		this.TextBox3 = new System.Windows.Forms.TextBox();
		this.unidadesLbl = new System.Windows.Forms.Label();
		this.GroupBox5 = new System.Windows.Forms.GroupBox();
		this.ListView1 = new System.Windows.Forms.ListView();
		this.Item = new System.Windows.Forms.ColumnHeader();
		this.Unidades = new System.Windows.Forms.ColumnHeader();
		this.Producto = new System.Windows.Forms.ColumnHeader();
		this.Descripcion = new System.Windows.Forms.ColumnHeader();
		this.Codigo = new System.Windows.Forms.ColumnHeader();
		this.variacionColumn = new System.Windows.Forms.ColumnHeader();
		this.valor = new System.Windows.Forms.ColumnHeader();
		this.Label13 = new System.Windows.Forms.Label();
		this.Label12 = new System.Windows.Forms.Label();
		this.GroupBox6 = new System.Windows.Forms.GroupBox();
		this.cancelarBtn = new System.Windows.Forms.Button();
		this.imprimirBtn = new System.Windows.Forms.Button();
		this.crearBtn = new System.Windows.Forms.Button();
		this.PrintDocument1 = new System.Drawing.Printing.PrintDocument();
		this.GroupBox2 = new System.Windows.Forms.GroupBox();
		this.TextBox6 = new System.Windows.Forms.TextBox();
		this.TextBox5 = new System.Windows.Forms.TextBox();
		this.TextBox4 = new System.Windows.Forms.TextBox();
		this.Label7 = new System.Windows.Forms.Label();
		this.Label6 = new System.Windows.Forms.Label();
		this.Label5 = new System.Windows.Forms.Label();
		this.Button1 = new System.Windows.Forms.Button();
		this.ComboBox2 = new System.Windows.Forms.ComboBox();
		this.Label4 = new System.Windows.Forms.Label();
		this.Label3 = new System.Windows.Forms.Label();
		this.Label11 = new System.Windows.Forms.Label();
		this.Label15 = new System.Windows.Forms.Label();
		this.Label16 = new System.Windows.Forms.Label();
		this.GroupBox3 = new System.Windows.Forms.GroupBox();
		this.GroupBox1.SuspendLayout();
		this.GroupBox4.SuspendLayout();
		this.GroupBox5.SuspendLayout();
		this.GroupBox6.SuspendLayout();
		this.GroupBox2.SuspendLayout();
		this.GroupBox3.SuspendLayout();
		base.SuspendLayout();
		this.GroupBox1.Controls.Add(this.RadioButton3);
		this.GroupBox1.Controls.Add(this.RadioButton2);
		this.GroupBox1.Controls.Add(this.RadioButton1);
		this.GroupBox1.Controls.Add(this.Label1);
		this.GroupBox1.Controls.Add(this.TextBox1);
		this.GroupBox1.Controls.Add(this.empresasCbo);
		this.GroupBox1.Location = new System.Drawing.Point(12, 12);
		this.GroupBox1.Name = "GroupBox1";
		this.GroupBox1.Size = new System.Drawing.Size(879, 56);
		this.GroupBox1.TabIndex = 0;
		this.GroupBox1.TabStop = false;
		this.GroupBox1.Text = "Empresa:";
		this.RadioButton3.AutoSize = true;
		this.RadioButton3.Location = new System.Drawing.Point(823, 20);
		this.RadioButton3.Name = "RadioButton3";
		this.RadioButton3.Size = new System.Drawing.Size(45, 17);
		this.RadioButton3.TabIndex = 4;
		this.RadioButton3.Text = "Otro";
		this.RadioButton3.UseVisualStyleBackColor = true;
		this.RadioButton2.AutoSize = true;
		this.RadioButton2.Location = new System.Drawing.Point(740, 20);
		this.RadioButton2.Name = "RadioButton2";
		this.RadioButton2.Size = new System.Drawing.Size(77, 17);
		this.RadioButton2.TabIndex = 3;
		this.RadioButton2.Text = "Asignacion";
		this.RadioButton2.UseVisualStyleBackColor = true;
		this.RadioButton1.AutoSize = true;
		this.RadioButton1.Checked = true;
		this.RadioButton1.Location = new System.Drawing.Point(676, 20);
		this.RadioButton1.Name = "RadioButton1";
		this.RadioButton1.Size = new System.Drawing.Size(58, 17);
		this.RadioButton1.TabIndex = 2;
		this.RadioButton1.TabStop = true;
		this.RadioButton1.Text = "Remito";
		this.RadioButton1.UseVisualStyleBackColor = true;
		this.Label1.AutoSize = true;
		this.Label1.Location = new System.Drawing.Point(378, 22);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(98, 13);
		this.Label1.TabIndex = 3;
		this.Label1.Text = "N. Remito/Factura:";
		this.TextBox1.Location = new System.Drawing.Point(482, 19);
		this.TextBox1.Name = "TextBox1";
		this.TextBox1.Size = new System.Drawing.Size(185, 20);
		this.TextBox1.TabIndex = 1;
		this.empresasCbo.FormattingEnabled = true;
		this.empresasCbo.Location = new System.Drawing.Point(6, 19);
		this.empresasCbo.Name = "empresasCbo";
		this.empresasCbo.Size = new System.Drawing.Size(291, 21);
		this.empresasCbo.TabIndex = 0;
		this.idEmpresaLbl.AutoSize = true;
		this.idEmpresaLbl.Location = new System.Drawing.Point(181, 102);
		this.idEmpresaLbl.Name = "idEmpresaLbl";
		this.idEmpresaLbl.Size = new System.Drawing.Size(60, 13);
		this.idEmpresaLbl.TabIndex = 1;
		this.idEmpresaLbl.Text = "Id Empresa";
		this.Label2.AutoSize = true;
		this.Label2.Location = new System.Drawing.Point(118, 52);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(13, 13);
		this.Label2.TabIndex = 0;
		this.Label2.Text = "0";
		this.ComboBox1.FormattingEnabled = true;
		this.ComboBox1.Location = new System.Drawing.Point(322, 18);
		this.ComboBox1.Name = "ComboBox1";
		this.ComboBox1.Size = new System.Drawing.Size(269, 21);
		this.ComboBox1.TabIndex = 11;
		this.codeLbl.AutoSize = true;
		this.codeLbl.Location = new System.Drawing.Point(24, 23);
		this.codeLbl.Name = "codeLbl";
		this.codeLbl.Size = new System.Drawing.Size(43, 13);
		this.codeLbl.TabIndex = 1;
		this.codeLbl.Text = "Codigo:";
		this.TextBox2.Location = new System.Drawing.Point(73, 20);
		this.TextBox2.Name = "TextBox2";
		this.TextBox2.Size = new System.Drawing.Size(163, 20);
		this.TextBox2.TabIndex = 10;
		this.buscarDescripcionLbl.AutoSize = true;
		this.buscarDescripcionLbl.Location = new System.Drawing.Point(250, 23);
		this.buscarDescripcionLbl.Name = "buscarDescripcionLbl";
		this.buscarDescripcionLbl.Size = new System.Drawing.Size(66, 13);
		this.buscarDescripcionLbl.TabIndex = 3;
		this.buscarDescripcionLbl.Text = "Descripción:";
		this.StatusStrip1.Location = new System.Drawing.Point(0, 526);
		this.StatusStrip1.Name = "StatusStrip1";
		this.StatusStrip1.Size = new System.Drawing.Size(905, 22);
		this.StatusStrip1.TabIndex = 4;
		this.StatusStrip1.Text = "StatusStrip1";
		this.GroupBox4.Controls.Add(this.Label14);
		this.GroupBox4.Controls.Add(this.TextBox7);
		this.GroupBox4.Controls.Add(this.Label10);
		this.GroupBox4.Controls.Add(this.Label9);
		this.GroupBox4.Controls.Add(this.Label8);
		this.GroupBox4.Controls.Add(this.asignarBtn);
		this.GroupBox4.Controls.Add(this.TextBox3);
		this.GroupBox4.Controls.Add(this.unidadesLbl);
		this.GroupBox4.Controls.Add(this.TextBox2);
		this.GroupBox4.Controls.Add(this.buscarDescripcionLbl);
		this.GroupBox4.Controls.Add(this.ComboBox1);
		this.GroupBox4.Controls.Add(this.codeLbl);
		this.GroupBox4.Location = new System.Drawing.Point(12, 174);
		this.GroupBox4.Name = "GroupBox4";
		this.GroupBox4.Size = new System.Drawing.Size(879, 94);
		this.GroupBox4.TabIndex = 4;
		this.GroupBox4.TabStop = false;
		this.GroupBox4.Text = "Producto:";
		this.Label14.AutoSize = true;
		this.Label14.Location = new System.Drawing.Point(254, 66);
		this.Label14.Name = "Label14";
		this.Label14.Size = new System.Drawing.Size(45, 13);
		this.Label14.TabIndex = 11;
		this.Label14.Text = "Label14";
		this.TextBox7.Location = new System.Drawing.Point(597, 60);
		this.TextBox7.Name = "TextBox7";
		this.TextBox7.Size = new System.Drawing.Size(137, 20);
		this.TextBox7.TabIndex = 13;
		this.TextBox7.Text = "0";
		this.Label10.AutoSize = true;
		this.Label10.Location = new System.Drawing.Point(505, 63);
		this.Label10.Name = "Label10";
		this.Label10.Size = new System.Drawing.Size(86, 13);
		this.Label10.TabIndex = 9;
		this.Label10.Text = "Valor Declarado:";
		this.Label9.AutoSize = true;
		this.Label9.Location = new System.Drawing.Point(160, 63);
		this.Label9.Name = "Label9";
		this.Label9.Size = new System.Drawing.Size(39, 13);
		this.Label9.TabIndex = 8;
		this.Label9.Text = "Label9";
		this.Label8.AutoSize = true;
		this.Label8.Location = new System.Drawing.Point(105, 63);
		this.Label8.Name = "Label8";
		this.Label8.Size = new System.Drawing.Size(38, 13);
		this.Label8.TabIndex = 7;
		this.Label8.Text = "Stock:";
		this.asignarBtn.Location = new System.Drawing.Point(787, 18);
		this.asignarBtn.Name = "asignarBtn";
		this.asignarBtn.Size = new System.Drawing.Size(75, 23);
		this.asignarBtn.TabIndex = 14;
		this.asignarBtn.Text = "Agregar";
		this.asignarBtn.UseVisualStyleBackColor = true;
		this.TextBox3.Location = new System.Drawing.Point(673, 20);
		this.TextBox3.Name = "TextBox3";
		this.TextBox3.Size = new System.Drawing.Size(100, 20);
		this.TextBox3.TabIndex = 12;
		this.TextBox3.Text = "0";
		this.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		this.unidadesLbl.AutoSize = true;
		this.unidadesLbl.Location = new System.Drawing.Point(612, 23);
		this.unidadesLbl.Name = "unidadesLbl";
		this.unidadesLbl.Size = new System.Drawing.Size(55, 13);
		this.unidadesLbl.TabIndex = 4;
		this.unidadesLbl.Text = "Unidades:";
		this.GroupBox5.Controls.Add(this.ListView1);
		this.GroupBox5.Location = new System.Drawing.Point(12, 274);
		this.GroupBox5.Name = "GroupBox5";
		this.GroupBox5.Size = new System.Drawing.Size(605, 237);
		this.GroupBox5.TabIndex = 5;
		this.GroupBox5.TabStop = false;
		this.GroupBox5.Text = "Orden:";
		this.ListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[7] { this.Item, this.Unidades, this.Producto, this.Descripcion, this.Codigo, this.variacionColumn, this.valor });
		this.ListView1.FullRowSelect = true;
		this.ListView1.GridLines = true;
		this.ListView1.Location = new System.Drawing.Point(6, 19);
		this.ListView1.Name = "ListView1";
		this.ListView1.Size = new System.Drawing.Size(593, 206);
		this.ListView1.TabIndex = 18;
		this.ListView1.UseCompatibleStateImageBehavior = false;
		this.ListView1.View = System.Windows.Forms.View.Details;
		this.Item.Text = "Item";
		this.Item.Width = 32;
		this.Unidades.Text = "Unidades";
		this.Unidades.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		this.Unidades.Width = 59;
		this.Producto.Text = "Producto";
		this.Producto.Width = 55;
		this.Descripcion.Text = "Descripción";
		this.Descripcion.Width = 246;
		this.Codigo.Text = "Código";
		this.Codigo.Width = 101;
		this.variacionColumn.DisplayIndex = 6;
		this.variacionColumn.Text = "Variacion";
		this.variacionColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		this.valor.DisplayIndex = 5;
		this.valor.Text = "Valor Declarado";
		this.valor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		this.valor.Width = 93;
		this.Label13.AutoSize = true;
		this.Label13.Location = new System.Drawing.Point(117, 102);
		this.Label13.Name = "Label13";
		this.Label13.Size = new System.Drawing.Size(13, 13);
		this.Label13.TabIndex = 3;
		this.Label13.Text = "0";
		this.Label12.AutoSize = true;
		this.Label12.Location = new System.Drawing.Point(117, 77);
		this.Label12.Name = "Label12";
		this.Label12.Size = new System.Drawing.Size(13, 13);
		this.Label12.TabIndex = 2;
		this.Label12.Text = "0";
		this.GroupBox6.Controls.Add(this.cancelarBtn);
		this.GroupBox6.Controls.Add(this.imprimirBtn);
		this.GroupBox6.Controls.Add(this.crearBtn);
		this.GroupBox6.Location = new System.Drawing.Point(623, 457);
		this.GroupBox6.Name = "GroupBox6";
		this.GroupBox6.Size = new System.Drawing.Size(270, 54);
		this.GroupBox6.TabIndex = 6;
		this.GroupBox6.TabStop = false;
		this.GroupBox6.Text = "Opciones:";
		this.cancelarBtn.Location = new System.Drawing.Point(178, 19);
		this.cancelarBtn.Name = "cancelarBtn";
		this.cancelarBtn.Size = new System.Drawing.Size(75, 23);
		this.cancelarBtn.TabIndex = 17;
		this.cancelarBtn.Text = "Cancelar";
		this.cancelarBtn.UseVisualStyleBackColor = true;
		this.imprimirBtn.Location = new System.Drawing.Point(97, 19);
		this.imprimirBtn.Name = "imprimirBtn";
		this.imprimirBtn.Size = new System.Drawing.Size(75, 23);
		this.imprimirBtn.TabIndex = 16;
		this.imprimirBtn.Text = "Imprimir";
		this.imprimirBtn.UseVisualStyleBackColor = true;
		this.imprimirBtn.Visible = false;
		this.crearBtn.Location = new System.Drawing.Point(16, 19);
		this.crearBtn.Name = "crearBtn";
		this.crearBtn.Size = new System.Drawing.Size(75, 23);
		this.crearBtn.TabIndex = 15;
		this.crearBtn.Text = "Crear";
		this.crearBtn.UseVisualStyleBackColor = true;
		this.GroupBox2.Controls.Add(this.TextBox6);
		this.GroupBox2.Controls.Add(this.TextBox5);
		this.GroupBox2.Controls.Add(this.TextBox4);
		this.GroupBox2.Controls.Add(this.Label7);
		this.GroupBox2.Controls.Add(this.Label6);
		this.GroupBox2.Controls.Add(this.Label5);
		this.GroupBox2.Controls.Add(this.Button1);
		this.GroupBox2.Controls.Add(this.ComboBox2);
		this.GroupBox2.Controls.Add(this.Label4);
		this.GroupBox2.Controls.Add(this.Label3);
		this.GroupBox2.Location = new System.Drawing.Point(12, 74);
		this.GroupBox2.Name = "GroupBox2";
		this.GroupBox2.Size = new System.Drawing.Size(879, 94);
		this.GroupBox2.TabIndex = 7;
		this.GroupBox2.TabStop = false;
		this.GroupBox2.Text = "Destino:";
		this.TextBox6.Location = new System.Drawing.Point(663, 57);
		this.TextBox6.Name = "TextBox6";
		this.TextBox6.Size = new System.Drawing.Size(100, 20);
		this.TextBox6.TabIndex = 8;
		this.TextBox5.Location = new System.Drawing.Point(663, 20);
		this.TextBox5.Name = "TextBox5";
		this.TextBox5.Size = new System.Drawing.Size(100, 20);
		this.TextBox5.TabIndex = 7;
		this.TextBox4.Location = new System.Drawing.Point(98, 57);
		this.TextBox4.Name = "TextBox4";
		this.TextBox4.Size = new System.Drawing.Size(478, 20);
		this.TextBox4.TabIndex = 6;
		this.Label7.AutoSize = true;
		this.Label7.Location = new System.Drawing.Point(582, 60);
		this.Label7.Name = "Label7";
		this.Label7.Size = new System.Drawing.Size(56, 13);
		this.Label7.TabIndex = 6;
		this.Label7.Text = "Localidad:";
		this.Label6.AutoSize = true;
		this.Label6.Location = new System.Drawing.Point(582, 23);
		this.Label6.Name = "Label6";
		this.Label6.Size = new System.Drawing.Size(75, 13);
		this.Label6.TabIndex = 5;
		this.Label6.Text = "Código Postal:";
		this.Label5.AutoSize = true;
		this.Label5.Location = new System.Drawing.Point(26, 60);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(55, 13);
		this.Label5.TabIndex = 4;
		this.Label5.Text = "Direccion:";
		this.Button1.Location = new System.Drawing.Point(789, 55);
		this.Button1.Name = "Button1";
		this.Button1.Size = new System.Drawing.Size(75, 23);
		this.Button1.TabIndex = 9;
		this.Button1.Text = "Nuevo";
		this.Button1.UseVisualStyleBackColor = true;
		this.ComboBox2.FormattingEnabled = true;
		this.ComboBox2.Location = new System.Drawing.Point(98, 20);
		this.ComboBox2.Name = "ComboBox2";
		this.ComboBox2.Size = new System.Drawing.Size(478, 21);
		this.ComboBox2.TabIndex = 5;
		this.Label4.AutoSize = true;
		this.Label4.Location = new System.Drawing.Point(26, 23);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(66, 13);
		this.Label4.TabIndex = 1;
		this.Label4.Text = "Destinatario:";
		this.Label3.AutoSize = true;
		this.Label3.Location = new System.Drawing.Point(801, 23);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(52, 13);
		this.Label3.TabIndex = 0;
		this.Label3.Text = "Eventual:";
		this.Label11.AutoSize = true;
		this.Label11.Location = new System.Drawing.Point(25, 52);
		this.Label11.Name = "Label11";
		this.Label11.Size = new System.Drawing.Size(58, 13);
		this.Label11.TabIndex = 8;
		this.Label11.Text = "Productos:";
		this.Label15.AutoSize = true;
		this.Label15.Location = new System.Drawing.Point(25, 77);
		this.Label15.Name = "Label15";
		this.Label15.Size = new System.Drawing.Size(55, 13);
		this.Label15.TabIndex = 9;
		this.Label15.Text = "Unidades:";
		this.Label16.AutoSize = true;
		this.Label16.Location = new System.Drawing.Point(25, 102);
		this.Label16.Name = "Label16";
		this.Label16.Size = new System.Drawing.Size(86, 13);
		this.Label16.TabIndex = 10;
		this.Label16.Text = "Valor Declarado:";
		this.GroupBox3.Controls.Add(this.Label13);
		this.GroupBox3.Controls.Add(this.Label16);
		this.GroupBox3.Controls.Add(this.idEmpresaLbl);
		this.GroupBox3.Controls.Add(this.Label15);
		this.GroupBox3.Controls.Add(this.Label11);
		this.GroupBox3.Controls.Add(this.Label12);
		this.GroupBox3.Controls.Add(this.Label2);
		this.GroupBox3.Location = new System.Drawing.Point(623, 281);
		this.GroupBox3.Name = "GroupBox3";
		this.GroupBox3.Size = new System.Drawing.Size(268, 170);
		this.GroupBox3.TabIndex = 11;
		this.GroupBox3.TabStop = false;
		this.GroupBox3.Text = "Totales:";
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(905, 548);
		base.Controls.Add(this.GroupBox2);
		base.Controls.Add(this.GroupBox6);
		base.Controls.Add(this.GroupBox5);
		base.Controls.Add(this.GroupBox4);
		base.Controls.Add(this.StatusStrip1);
		base.Controls.Add(this.GroupBox1);
		base.Controls.Add(this.GroupBox3);
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.Name = "OrdenSalida";
		this.Text = "Nueva Orden Salida";
		this.GroupBox1.ResumeLayout(false);
		this.GroupBox1.PerformLayout();
		this.GroupBox4.ResumeLayout(false);
		this.GroupBox4.PerformLayout();
		this.GroupBox5.ResumeLayout(false);
		this.GroupBox6.ResumeLayout(false);
		this.GroupBox2.ResumeLayout(false);
		this.GroupBox2.PerformLayout();
		this.GroupBox3.ResumeLayout(false);
		this.GroupBox3.PerformLayout();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private void OrdenSalida_Load(object sender, EventArgs e)
	{
		string sql = "SELECT Nombre FROM empresas ORDER BY id ASC";
		try
		{
			Mod_Sentencias.cargar_cbb(empresasCbo, sql);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox("Ocurrio un error al recuperar datos. " + ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void empresasCbo_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (empresasCbo.SelectedIndex <= -1)
		{
			return;
		}
		ComboBox1.Items.Clear();
		Interaction.MsgBox(empresasCbo.SelectedIndex);
		checked
		{
			idEmpresaLbl.Text = Conversions.ToString(empresasCbo.SelectedIndex + 2);
			try
			{
				productosCompleto = (List<Mod_Productos.datos_producto>)Mod_Productos.listaProductos(Conversions.ToInteger(idEmpresaLbl.Text));
				int num = productosCompleto.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					ComboBox1.Items.Add(productosCompleto[i].productDescripcion);
				}
				ComboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
				ComboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;
				TextBox1.Focus();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				Interaction.MsgBox("El cliente no tiene productos cargados");
				ProjectData.ClearProjectError();
			}
		}
	}

	private void asignarBtn_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(TextBox1.Text, "", TextCompare: true) == 0)
		{
			Interaction.MsgBox("Debe indicar un identificador para la orden.");
			TextBox1.Focus();
			return;
		}
		int selectedIndex = ComboBox1.SelectedIndex;
		checked
		{
			if (Conversions.ToDouble(TextBox3.Text) != 0.0)
			{
				if (Conversions.ToDouble(Label14.Text) == 1.0)
				{
					Selector selector = MyProject.Forms.Selector;
					selector.Label1.Text = Conversions.ToString(1);
					selector.Label2.Text = Conversions.ToString(productosCompleto[selectedIndex].productId);
					selector.Label3.Text = productosCompleto[selectedIndex].productBarrcode;
					selector.ListView1.Items.Clear();
					selector = null;
					MyProject.Forms.Selector.ShowDialog();
				}
				else if (Conversions.ToDouble(Label14.Text) == 0.0)
				{
					ListViewItem listViewItem = null;
					int num = Conversions.ToInteger(TextBox3.Text);
					if (num > int.Parse(Label9.Text))
					{
						Interaction.MsgBox("La cantidad solicitada es mayor a la existencia en stock");
						return;
					}
					string text = ComboBox1.Text;
					int num2 = (int)Math.Round(Conversions.ToDouble(Label2.Text) + 1.0);
					string text2 = Strings.Replace(TextBox7.Text, ".", ",", 1, -1, CompareMethod.Text);
					listViewItem = new ListViewItem(num2.ToString());
					listViewItem.SubItems.Add(Conversions.ToString(num));
					listViewItem.SubItems.Add(Conversions.ToString(productosCompleto[selectedIndex].productId));
					listViewItem.SubItems.Add(productosCompleto[selectedIndex].productDescripcion);
					listViewItem.SubItems.Add(productosCompleto[selectedIndex].productBarrcode);
					listViewItem.SubItems.Add(Conversions.ToString(0));
					listViewItem.SubItems.Add(text2);
					ListView1.Items.Add(listViewItem);
					Label2.Text = Conversions.ToString(num2);
					int num3 = 0;
					decimal num4 = default(decimal);
					foreach (ListViewItem item in ListView1.Items)
					{
						num3 = (int)Math.Round((double)num3 + Conversions.ToDouble(item.SubItems[1].Text));
						num4 = decimal.Add(num4, new decimal(Conversions.ToDouble(item.SubItems[6].Text) * Conversions.ToDouble(item.SubItems[1].Text)));
					}
					Label13.Text = Conversions.ToString(num4);
					Label12.Text = Conversions.ToString(num3);
					TextBox2.Text = "";
					ComboBox1.Text = "";
					Label9.Text = Conversions.ToString(0);
					Label14.Text = Conversions.ToString(0);
					TextBox3.Text = Conversions.ToString(0);
					TextBox7.Text = Conversions.ToString(0);
				}
				TextBox2.Focus();
			}
			else
			{
				Interaction.MsgBox("Las unidades no pueden ser 0");
			}
		}
	}

	private void PrintDocument1_PrintPage(object sender, PrintPageEventArgs e)
	{
		if (_0024STATIC_0024PrintDocument1_PrintPage_002420211C128195_0024CurrentYPosition_0024Init == null)
		{
			Interlocked.CompareExchange(ref _0024STATIC_0024PrintDocument1_PrintPage_002420211C128195_0024CurrentYPosition_0024Init, new StaticLocalInitFlag(), null);
		}
		bool lockTaken = false;
		try
		{
			Monitor.Enter(_0024STATIC_0024PrintDocument1_PrintPage_002420211C128195_0024CurrentYPosition_0024Init, ref lockTaken);
			if (_0024STATIC_0024PrintDocument1_PrintPage_002420211C128195_0024CurrentYPosition_0024Init.State == 0)
			{
				_0024STATIC_0024PrintDocument1_PrintPage_002420211C128195_0024CurrentYPosition_0024Init.State = 2;
				_0024STATIC_0024PrintDocument1_PrintPage_002420211C128195_0024CurrentYPosition = 0;
			}
			else if (_0024STATIC_0024PrintDocument1_PrintPage_002420211C128195_0024CurrentYPosition_0024Init.State == 2)
			{
				throw new IncompleteInitialization();
			}
		}
		finally
		{
			_0024STATIC_0024PrintDocument1_PrintPage_002420211C128195_0024CurrentYPosition_0024Init.State = 1;
			if (lockTaken)
			{
				Monitor.Exit(_0024STATIC_0024PrintDocument1_PrintPage_002420211C128195_0024CurrentYPosition_0024Init);
			}
		}
		if (ListView1.View == View.Details)
		{
			newPrintDetail(ref e);
		}
	}

	private void PrintDetails(ref PrintPageEventArgs e)
	{
		string text = Strings.Format(MyProject.Forms.Form1_Inicio.DateTimePicker1.Value, "dd-MM-yyyy");
		string text2 = TextBox1.Text;
		string text3 = empresasCbo.Text;
		string empty = string.Empty;
		string empty2 = string.Empty;
		string empty3 = string.Empty;
		string empty4 = string.Empty;
		string text4 = ComboBox2.Text;
		string text5 = TextBox4.Text;
		string text6 = TextBox6.Text;
		string text7 = TextBox5.Text;
		PrivateFontCollection privateFontCollection = new PrivateFontCollection();
		privateFontCollection.AddFontFile(AppDomain.CurrentDomain.BaseDirectory + "\\Code39.ttf");
		FontFamily family = privateFontCollection.Families[0];
		Font font = new Font(family, 30f);
		Font font2 = new Font("Arial", 6.75f, FontStyle.Italic, GraphicsUnit.Point, 0);
		Font font3 = new Font("Arial", 16.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		Font font4 = new Font("Arial", 14.75f, FontStyle.Italic, GraphicsUnit.Point, 0);
		Font font5 = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, 0);
		int num = 0;
		string text8 = MyProject.Forms.Form1_Inicio.nombreusuario.Text;
		e.Graphics.DrawLine(Pens.Brown, 2, 5, 750, 5);
		e.Graphics.DrawLine(Pens.Brown, 2, 5, 2, 1100);
		e.Graphics.DrawLine(Pens.Brown, 750, 5, 750, 1100);
		e.Graphics.DrawLine(Pens.Brown, 2, 1100, 750, 1100);
		e.Graphics.DrawLine(Pens.Brown, 2, 130, 750, 130);
		Image logoArea = Resources.logoArea1;
		e.Graphics.DrawImage(logoArea, 170, 30);
		e.Graphics.DrawString(text2, font, Brushes.Black, 30f, 30f);
		e.Graphics.DrawString(text2, font5, Brushes.Black, 50f, 85f);
		e.Graphics.DrawString("ORDEN DE PICKING", font3, Brushes.Black, 250f, 135f);
		e.Graphics.DrawLine(Pens.Brown, 2, 162, 750, 162);
		e.Graphics.DrawString("Empresa: " + text3, font5, Brushes.Black, 55f, 180f);
		e.Graphics.DrawString("Remito número: " + text2, font5, Brushes.Black, 55f, 200f);
		e.Graphics.DrawString("Fecha: " + text, font5, Brushes.Black, 55f, 220f);
		e.Graphics.DrawString("Bultos:", font5, Brushes.Black, 55f, 240f);
		if (RadioButton1.Checked)
		{
			e.Graphics.DrawString("Tipo de orden: REMITO", font5, Brushes.Black, 55f, 270f);
		}
		if (RadioButton2.Checked)
		{
			e.Graphics.DrawString("Tipo de orden: ASIGNACION", font5, Brushes.Black, 55f, 270f);
		}
		if (RadioButton3.Checked)
		{
			e.Graphics.DrawString("Tipo de orden: OTRO", font5, Brushes.Black, 55f, 270f);
		}
		e.Graphics.DrawString("Destinatario: " + text4, font5, Brushes.Black, 400f, 180f);
		e.Graphics.DrawString("Direccion: " + text5, font5, Brushes.Black, 400f, 200f);
		e.Graphics.DrawString("Localidad: " + text6, font5, Brushes.Black, 400f, 220f);
		e.Graphics.DrawString("Codigo Postal: " + text7, font5, Brushes.Black, 400f, 240f);
		e.Graphics.DrawLine(Pens.Brown, 2, 310, 750, 310);
		if (_0024STATIC_0024PrintDetails_0024201110128195_0024LastIndex_0024Init == null)
		{
			Interlocked.CompareExchange(ref _0024STATIC_0024PrintDetails_0024201110128195_0024LastIndex_0024Init, new StaticLocalInitFlag(), null);
		}
		bool lockTaken = false;
		try
		{
			Monitor.Enter(_0024STATIC_0024PrintDetails_0024201110128195_0024LastIndex_0024Init, ref lockTaken);
			if (_0024STATIC_0024PrintDetails_0024201110128195_0024LastIndex_0024Init.State == 0)
			{
				_0024STATIC_0024PrintDetails_0024201110128195_0024LastIndex_0024Init.State = 2;
				_0024STATIC_0024PrintDetails_0024201110128195_0024LastIndex = 0;
			}
			else if (_0024STATIC_0024PrintDetails_0024201110128195_0024LastIndex_0024Init.State == 2)
			{
				throw new IncompleteInitialization();
			}
		}
		finally
		{
			_0024STATIC_0024PrintDetails_0024201110128195_0024LastIndex_0024Init.State = 1;
			if (lockTaken)
			{
				Monitor.Exit(_0024STATIC_0024PrintDetails_0024201110128195_0024LastIndex_0024Init);
			}
		}
		if (_0024STATIC_0024PrintDetails_0024201110128195_0024CurrentPage_0024Init == null)
		{
			Interlocked.CompareExchange(ref _0024STATIC_0024PrintDetails_0024201110128195_0024CurrentPage_0024Init, new StaticLocalInitFlag(), null);
		}
		bool lockTaken2 = false;
		try
		{
			Monitor.Enter(_0024STATIC_0024PrintDetails_0024201110128195_0024CurrentPage_0024Init, ref lockTaken2);
			if (_0024STATIC_0024PrintDetails_0024201110128195_0024CurrentPage_0024Init.State == 0)
			{
				_0024STATIC_0024PrintDetails_0024201110128195_0024CurrentPage_0024Init.State = 2;
				_0024STATIC_0024PrintDetails_0024201110128195_0024CurrentPage = 0;
			}
			else if (_0024STATIC_0024PrintDetails_0024201110128195_0024CurrentPage_0024Init.State == 2)
			{
				throw new IncompleteInitialization();
			}
		}
		finally
		{
			_0024STATIC_0024PrintDetails_0024201110128195_0024CurrentPage_0024Init.State = 1;
			if (lockTaken2)
			{
				Monitor.Exit(_0024STATIC_0024PrintDetails_0024201110128195_0024CurrentPage_0024Init);
			}
		}
		Graphics graphics = CreateGraphics();
		checked
		{
			int num2 = (int)Math.Round(graphics.DpiX);
			int num3 = (int)Math.Round(graphics.DpiY);
			graphics.Dispose();
			Rectangle empty5 = Rectangle.Empty;
			float num4 = (float)(4.0 * ((double)num2 / 96.0));
			float num5 = (float)((double)ListView1.Font.Height + 10.0 * ((double)num2 / 96.0));
			StringFormat stringFormat = new StringFormat();
			float num6 = e.Graphics.MeasureString(Conversions.ToString(_0024STATIC_0024PrintDetails_0024201110128195_0024CurrentPage), ListView1.Font).Width;
			stringFormat.FormatFlags = StringFormatFlags.NoWrap;
			stringFormat.Trimming = StringTrimming.EllipsisCharacter;
			stringFormat.LineAlignment = StringAlignment.Center;
			_0024STATIC_0024PrintDetails_0024201110128195_0024CurrentPage++;
			int num7 = 15;
			int num8 = e.MarginBounds.Y + 260;
			int num9 = ListView1.Columns.Count - 1;
			for (int i = 0; i <= num9; i++)
			{
				empty5.X = num7;
				empty5.Y = num8;
				empty5.Width = ListView1.Columns[i].Width;
				empty5.Height = (int)Math.Round(num5);
				e.Graphics.FillRectangle(Brushes.LightGray, empty5);
				e.Graphics.DrawRectangle(Pens.DarkGray, empty5);
				empty5.X = (int)Math.Round((float)empty5.X + num4);
				empty5.Width = (int)Math.Round((float)empty5.Width - num4);
				e.Graphics.DrawString(ListView1.Columns[i].Text, ListView1.Font, Brushes.Black, empty5, stringFormat);
				num7 = (int)Math.Round((float)num7 + ((float)empty5.Width + num4));
			}
			num8 = (int)Math.Round((float)num8 + num5);
			int num10 = _0024STATIC_0024PrintDetails_0024201110128195_0024LastIndex;
			int num11 = ListView1.Items.Count - 1;
			for (int j = num10; j <= num11; j++)
			{
				ListViewItem listViewItem = ListView1.Items[j];
				num7 = 5;
				if (num8 + listViewItem.Bounds.Height > e.MarginBounds.Bottom)
				{
					_0024STATIC_0024PrintDetails_0024201110128195_0024LastIndex = j - 1;
					e.HasMorePages = true;
					stringFormat.Dispose();
					e.Graphics.DrawString(Conversions.ToString(_0024STATIC_0024PrintDetails_0024201110128195_0024CurrentPage), ListView1.Font, Brushes.Black, ((float)e.PageBounds.Width - num6) / 2f, e.PageBounds.Bottom - ListView1.Font.Height * 2);
					return;
				}
				int num12 = 0;
				if (ListView1.SmallImageList != null)
				{
					if (!string.IsNullOrEmpty(listViewItem.ImageKey))
					{
						e.Graphics.DrawImage(ListView1.SmallImageList.Images[listViewItem.ImageKey], num7, num8);
					}
					else if (listViewItem.ImageIndex >= 0)
					{
						e.Graphics.DrawImage(ListView1.SmallImageList.Images[listViewItem.ImageIndex], num7, num8);
					}
					num12 = ListView1.SmallImageList.ImageSize.Width;
				}
				int num13 = ListView1.Columns.Count - 1;
				for (int k = 0; k <= num13; k++)
				{
					empty5.X = num7;
					empty5.Y = num8;
					empty5.Width = ListView1.Columns[k].Width;
					empty5.Height = listViewItem.Bounds.Height;
					if (ListView1.GridLines)
					{
						e.Graphics.DrawRectangle(Pens.DarkGray, empty5);
					}
					if (k == 0)
					{
						empty5.X += num12;
					}
					empty5.X = (int)Math.Round((float)empty5.X + num4);
					empty5.Width = (int)Math.Round((float)empty5.Width - num4);
					if (k < listViewItem.SubItems.Count)
					{
						e.Graphics.DrawString(listViewItem.SubItems[k].Text, ListView1.Font, Brushes.Black, empty5, stringFormat);
					}
					num7 = (int)Math.Round((float)num7 + ((float)empty5.Width + num4));
				}
				num8 += listViewItem.Bounds.Height;
				listViewItem = null;
			}
			stringFormat.Dispose();
			_0024STATIC_0024PrintDetails_0024201110128195_0024LastIndex = 0;
			_0024STATIC_0024PrintDetails_0024201110128195_0024CurrentPage = 0;
			e.Graphics.DrawString("Preparo:", font5, Brushes.Black, 100f, 1000f);
			e.Graphics.DrawString("____________________", font5, Brushes.Black, 170f, 1000f);
			e.Graphics.DrawString("Controlo:", font5, Brushes.Black, 350f, 1000f);
			e.Graphics.DrawString("____________________", font5, Brushes.Black, 420f, 1000f);
		}
	}

	private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (empresasCbo.SelectedIndex > -1)
		{
			if (e.KeyChar == '\r')
			{
				Mod_Productos.datos_producto datos_producto = default(Mod_Productos.datos_producto);
				try
				{
					object obj = Mod_Productos.buscarProdPorCodigo(TextBox2.Text, productosCompleto);
					datos_producto = ((obj != null) ? ((Mod_Productos.datos_producto)obj) : default(Mod_Productos.datos_producto));
					ComboBox1.Text = datos_producto.productDescripcion;
					Label9.Text = Conversions.ToString(datos_producto.productUnidades);
					Label14.Text = Conversions.ToString(datos_producto.productVariaciones);
					TextBox7.Text = Conversions.ToString(datos_producto.productPrecio);
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					Interaction.MsgBox("No se encontraron resultados para la busqueda");
					ProjectData.ClearProjectError();
				}
			}
		}
		else
		{
			Interaction.MsgBox("Seleccione una empresa");
		}
	}

	private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (empresasCbo.SelectedIndex > -1)
		{
			Mod_Productos.datos_producto datos_producto = default(Mod_Productos.datos_producto);
			try
			{
				object obj = Mod_Productos.buscarProdPorNombre(ComboBox1.Text, productosCompleto);
				datos_producto = ((obj != null) ? ((Mod_Productos.datos_producto)obj) : default(Mod_Productos.datos_producto));
				TextBox2.Text = datos_producto.productCodigo;
				Label9.Text = Conversions.ToString(datos_producto.productUnidades);
				Label14.Text = Conversions.ToString(datos_producto.productVariaciones);
				TextBox7.Text = Conversions.ToString(datos_producto.productPrecio);
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
		Interaction.MsgBox("Seleccione una empresa");
	}

	private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (ListView1.SelectedItems.Count <= 0)
		{
			return;
		}
		double num = 0.0;
		int num2 = (int)MessageBox.Show("Desea Eliminar el item " + ListView1.SelectedItems[0].SubItems[3].Text, "Atencion", MessageBoxButtons.YesNoCancel);
		if (num2 == 2 || num2 == 7 || num2 != 6)
		{
			return;
		}
		ListView1.SelectedItems[0].Remove();
		Label2.Text = Conversions.ToString(ListView1.Items.Count);
		decimal num3 = default(decimal);
		foreach (ListViewItem item in ListView1.Items)
		{
			num += Conversions.ToDouble(item.SubItems[1].Text);
			num3 = decimal.Add(num3, Conversions.ToDecimal(item.SubItems[6].Text));
		}
		Label13.Text = Conversions.ToString(num3);
		Label12.Text = Conversions.ToString(num);
	}

	private void cancelarBtn_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void crearBtn_Click(object sender, EventArgs e)
	{
		int num = (int)MessageBox.Show("Se Creara la siguiente Orden " + TextBox1.Text, "Atencion", MessageBoxButtons.YesNoCancel);
		if (num == 2 || num == 7 || num != 6)
		{
			return;
		}
		if (ListView1.Items.Count > 0)
		{
			Mod_Ordenes.ordendesalida outOrder = default(Mod_Ordenes.ordendesalida);
			outOrder.empresa = int.Parse(idEmpresaLbl.Text);
			if (RadioButton1.Checked)
			{
				outOrder.tipo = 1;
			}
			if (RadioButton2.Checked)
			{
				outOrder.tipo = 2;
			}
			if (RadioButton3.Checked)
			{
				outOrder.tipo = 3;
			}
			outOrder.numero = TextBox1.Text;
			Mod_Destinatarios.Destinatario destino = default(Mod_Destinatarios.Destinatario);
			destino.DestinoNombre = ComboBox2.Text;
			destino.DestinoDireccion = TextBox4.Text;
			destino.DestinoLocalidad = TextBox5.Text;
			destino.DestinoPostal = TextBox6.Text;
			int num2 = Conversions.ToInteger(Mod_Destinatarios.nuevoDestinatario(destino));
			if (num2 > 0)
			{
				outOrder.destinatario = num2;
			}
			else
			{
				outOrder.destinatario = 0;
			}
			outOrder.valor = decimal.Parse(Label13.Text);
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
				print_order = num3;
				item.productId = int.Parse(item2.SubItems[2].Text);
				item.varId = int.Parse(item2.SubItems[5].Text);
				item.unidades = int.Parse(item2.SubItems[1].Text);
				item.precio = new decimal(double.Parse(item2.SubItems[6].Text));
				list.Add(item);
			}
			switch (Conversions.ToInteger(Mod_Ordenes.guardarDetalleOrden(list)))
			{
			case 1:
				if (Operators.ConditionalCompareObjectEqual(Mod_Ordenes.updateOrderStatus(num3, 1), 1, TextCompare: true))
				{
					Interaction.MsgBox("La orden se genero correctamente");
					int num4 = (int)MessageBox.Show("Desea imprimir la orden de picking ", "Atencion", MessageBoxButtons.YesNoCancel);
					if (num4 != 2 && num4 != 7 && num4 == 6)
					{
						PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
						printPreviewDialog.Document = PrintDocument1;
						printPreviewDialog.ShowDialog();
					}
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

	public void limpiarCampos()
	{
		TextBox1.Text = "";
		RadioButton1.Checked = true;
		ComboBox2.Text = "";
		TextBox4.Text = "";
		TextBox5.Text = "";
		TextBox6.Text = "";
		TextBox2.Text = "";
		ComboBox1.Text = "";
		TextBox3.Text = Conversions.ToString(0);
		Label9.Text = Conversions.ToString(0);
		TextBox7.Text = Conversions.ToString(0);
		ListView1.Items.Clear();
		Label2.Text = Conversions.ToString(0);
		Label12.Text = Conversions.ToString(0);
		Label13.Text = Conversions.ToString(0);
	}

	public void newPrintDetail(ref PrintPageEventArgs e)
	{
		object orderById = Mod_Ordenes.getOrderById(print_order);
		selectedOrder = ((orderById != null) ? ((Mod_Ordenes.ordendesalida)orderById) : default(Mod_Ordenes.ordendesalida));
		checked
		{
			if (selectedOrder.numero != null)
			{
				selectedOrderItems = (List<Mod_Ordenes.orderDetallePrint>)Mod_Ordenes.getOrderItemsByOrder(selectedOrder.id);
				object destinatario = Mod_Ordenes.getDestinatario(selectedOrder.destinatario);
				selectedDestinatario = ((destinatario != null) ? ((Mod_Ordenes.Destino)destinatario) : default(Mod_Ordenes.Destino));
				Font font = new Font("Arial", 6.75f, FontStyle.Italic, GraphicsUnit.Point, 0);
				Font font2 = new Font("Arial", 16.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
				Font font3 = new Font("Arial", 14.75f, FontStyle.Italic, GraphicsUnit.Point, 0);
				Font font4 = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, 0);
				int num = 0;
				e.Graphics.DrawLine(Pens.Brown, 2, 5, 750, 5);
				e.Graphics.DrawLine(Pens.Brown, 2, 5, 2, 1100);
				e.Graphics.DrawLine(Pens.Brown, 750, 5, 750, 1100);
				e.Graphics.DrawLine(Pens.Brown, 2, 1100, 750, 1100);
				e.Graphics.DrawLine(Pens.Brown, 2, 130, 750, 130);
				e.Graphics.DrawString("ORDEN DE PICKING", font2, Brushes.Black, 250f, 135f);
				e.Graphics.DrawLine(Pens.Brown, 2, 162, 750, 162);
				e.Graphics.DrawString("Empresa: " + empresasCbo.Text, font4, Brushes.Black, 55f, 180f);
				e.Graphics.DrawString("Remito número: " + selectedOrder.numero, font4, Brushes.Black, 55f, 200f);
				e.Graphics.DrawString("Fecha: " + Conversions.ToString(selectedOrder.fecha), font4, Brushes.Black, 55f, 220f);
				e.Graphics.DrawString("Bultos:", font4, Brushes.Black, 55f, 240f);
				switch (selectedOrder.tipo)
				{
				case 1:
					e.Graphics.DrawString("Tipo de orden: REMITO", font4, Brushes.Black, 55f, 270f);
					break;
				case 2:
					e.Graphics.DrawString("Tipo de orden: ASIGNACION", font4, Brushes.Black, 55f, 270f);
					break;
				case 3:
					e.Graphics.DrawString("Tipo de orden: OTRO", font4, Brushes.Black, 55f, 270f);
					break;
				}
				e.Graphics.DrawString("Destinatario: " + selectedDestinatario.nombre, font4, Brushes.Black, 400f, 180f);
				e.Graphics.DrawString("Direccion: " + selectedDestinatario.direccion, font4, Brushes.Black, 400f, 200f);
				e.Graphics.DrawString("Localidad: " + selectedDestinatario.localidad, font4, Brushes.Black, 400f, 220f);
				e.Graphics.DrawString("Codigo Postal: " + selectedDestinatario.postal, font4, Brushes.Black, 400f, 240f);
				e.Graphics.DrawLine(Pens.Brown, 2, 310, 750, 310);
				if (_0024STATIC_0024newPrintDetail_0024201110128195_0024LastIndex_0024Init == null)
				{
					Interlocked.CompareExchange(ref _0024STATIC_0024newPrintDetail_0024201110128195_0024LastIndex_0024Init, new StaticLocalInitFlag(), null);
				}
				bool lockTaken = false;
				try
				{
					Monitor.Enter(_0024STATIC_0024newPrintDetail_0024201110128195_0024LastIndex_0024Init, ref lockTaken);
					if (_0024STATIC_0024newPrintDetail_0024201110128195_0024LastIndex_0024Init.State == 0)
					{
						_0024STATIC_0024newPrintDetail_0024201110128195_0024LastIndex_0024Init.State = 2;
						_0024STATIC_0024newPrintDetail_0024201110128195_0024LastIndex = 0;
					}
					else if (_0024STATIC_0024newPrintDetail_0024201110128195_0024LastIndex_0024Init.State == 2)
					{
						throw new IncompleteInitialization();
					}
				}
				finally
				{
					_0024STATIC_0024newPrintDetail_0024201110128195_0024LastIndex_0024Init.State = 1;
					if (lockTaken)
					{
						Monitor.Exit(_0024STATIC_0024newPrintDetail_0024201110128195_0024LastIndex_0024Init);
					}
				}
				if (_0024STATIC_0024newPrintDetail_0024201110128195_0024CurrentPage_0024Init == null)
				{
					Interlocked.CompareExchange(ref _0024STATIC_0024newPrintDetail_0024201110128195_0024CurrentPage_0024Init, new StaticLocalInitFlag(), null);
				}
				bool lockTaken2 = false;
				try
				{
					Monitor.Enter(_0024STATIC_0024newPrintDetail_0024201110128195_0024CurrentPage_0024Init, ref lockTaken2);
					if (_0024STATIC_0024newPrintDetail_0024201110128195_0024CurrentPage_0024Init.State == 0)
					{
						_0024STATIC_0024newPrintDetail_0024201110128195_0024CurrentPage_0024Init.State = 2;
						_0024STATIC_0024newPrintDetail_0024201110128195_0024CurrentPage = 0;
					}
					else if (_0024STATIC_0024newPrintDetail_0024201110128195_0024CurrentPage_0024Init.State == 2)
					{
						throw new IncompleteInitialization();
					}
				}
				finally
				{
					_0024STATIC_0024newPrintDetail_0024201110128195_0024CurrentPage_0024Init.State = 1;
					if (lockTaken2)
					{
						Monitor.Exit(_0024STATIC_0024newPrintDetail_0024201110128195_0024CurrentPage_0024Init);
					}
				}
				Graphics graphics = CreateGraphics();
				int num2 = (int)Math.Round(graphics.DpiX);
				int num3 = (int)Math.Round(graphics.DpiY);
				graphics.Dispose();
				Rectangle empty = Rectangle.Empty;
				float num4 = (float)(4.0 * ((double)num2 / 96.0));
				float num5 = (float)((double)ListView1.Font.Height + 10.0 * ((double)num2 / 96.0));
				StringFormat stringFormat = new StringFormat();
				float num6 = e.Graphics.MeasureString(Conversions.ToString(_0024STATIC_0024newPrintDetail_0024201110128195_0024CurrentPage), ListView1.Font).Width;
				stringFormat.FormatFlags = StringFormatFlags.NoWrap;
				stringFormat.Trimming = StringTrimming.EllipsisCharacter;
				stringFormat.LineAlignment = StringAlignment.Center;
				_0024STATIC_0024newPrintDetail_0024201110128195_0024CurrentPage++;
				int num7 = 15;
				int num8 = e.MarginBounds.Y + 260;
				empty.X = num7;
				empty.Y = num8;
				empty.Width = 70;
				empty.Height = 20;
				int num9 = 0;
				do
				{
					switch (num9)
					{
					case 0:
						e.Graphics.FillRectangle(Brushes.LightGray, empty);
						e.Graphics.DrawRectangle(Pens.DarkGray, empty);
						empty.X = (int)Math.Round((float)empty.X + num4);
						empty.Width = (int)Math.Round((float)empty.Width - num4);
						e.Graphics.DrawString("UNIDADES", ListView1.Font, Brushes.Black, empty, stringFormat);
						break;
					case 1:
						empty.Width = (int)Math.Round((float)empty.Width - num4);
						empty.Width = 450;
						e.Graphics.FillRectangle(Brushes.LightGray, empty);
						e.Graphics.DrawRectangle(Pens.DarkGray, empty);
						e.Graphics.DrawString("PRODUCTO", ListView1.Font, Brushes.Black, empty, stringFormat);
						break;
					case 2:
						empty.Width = (int)Math.Round((float)empty.Width - num4);
						empty.Width = 150;
						e.Graphics.FillRectangle(Brushes.LightGray, empty);
						e.Graphics.DrawRectangle(Pens.DarkGray, empty);
						e.Graphics.DrawString("CODIGO", ListView1.Font, Brushes.Black, empty, stringFormat);
						break;
					case 3:
						empty.Width = (int)Math.Round((float)empty.Width - num4);
						empty.Width = 50;
						e.Graphics.FillRectangle(Brushes.LightGray, empty);
						e.Graphics.DrawRectangle(Pens.DarkGray, empty);
						e.Graphics.DrawString("VARIACION", ListView1.Font, Brushes.Black, empty, stringFormat);
						break;
					}
					empty.X += empty.Width;
					num9++;
				}
				while (num9 <= 3);
				num7 = 15;
				num8 += 20;
				empty.X = num7;
				empty.Y = num8;
				empty.Width = 70;
				empty.Height = 20;
				int num10 = 0;
				int num11 = _0024STATIC_0024newPrintDetail_0024201110128195_0024LastIndex;
				int num12 = selectedOrderItems.Count - 1;
				for (int i = num11; i <= num12; i++)
				{
					if (num10 > 25)
					{
						num10 = 0;
						_0024STATIC_0024newPrintDetail_0024201110128195_0024LastIndex = i;
						e.HasMorePages = true;
						stringFormat.Dispose();
						return;
					}
					num10++;
					e.Graphics.DrawRectangle(Pens.DarkGray, empty);
					empty.X = (int)Math.Round((float)empty.X + num4);
					empty.Width = (int)Math.Round((float)empty.Width - num4);
					e.Graphics.DrawString(Conversions.ToString(selectedOrderItems[i].unidades), ListView1.Font, Brushes.Black, empty, stringFormat);
					empty.X += empty.Width;
					empty.Width = 450;
					e.Graphics.DrawRectangle(Pens.DarkGray, empty);
					empty.X = (int)Math.Round((float)empty.X + num4);
					empty.Width = (int)Math.Round((float)empty.Width - num4);
					e.Graphics.DrawString(selectedOrderItems[i].producto, ListView1.Font, Brushes.Black, empty, stringFormat);
					empty.X += empty.Width;
					empty.Width = 150;
					e.Graphics.DrawRectangle(Pens.DarkGray, empty);
					empty.X = (int)Math.Round((float)empty.X + num4);
					empty.Width = (int)Math.Round((float)empty.Width - num4);
					e.Graphics.DrawString(selectedOrderItems[i].codigo, ListView1.Font, Brushes.Black, empty, stringFormat);
					empty.X += empty.Width;
					empty.Width = 50;
					e.Graphics.DrawRectangle(Pens.DarkGray, empty);
					empty.X = (int)Math.Round((float)empty.X + num4);
					empty.Width = (int)Math.Round((float)empty.Width - num4);
					e.Graphics.DrawString(Conversions.ToString(selectedOrderItems[i].variacion), ListView1.Font, Brushes.Black, empty, stringFormat);
					empty.X = 15;
					empty.Y += 20;
					empty.Width = 70;
				}
				stringFormat.Dispose();
				_0024STATIC_0024newPrintDetail_0024201110128195_0024LastIndex = 0;
				_0024STATIC_0024newPrintDetail_0024201110128195_0024CurrentPage = 0;
				e.Graphics.DrawString("Observación:", font4, Brushes.Black, 100f, 920f);
				if (selectedOrder.observacion.Length > 90)
				{
					string s = selectedOrder.observacion.Substring(0, 90);
					e.Graphics.DrawString(s, font, Brushes.Black, 100f, 940f);
					string s2 = selectedOrder.observacion.Substring(90);
					e.Graphics.DrawString(s2, font, Brushes.Black, 100f, 960f);
				}
				else
				{
					e.Graphics.DrawString(selectedOrder.observacion, font, Brushes.Black, 100f, 940f);
				}
				e.Graphics.DrawString("Preparo:", font4, Brushes.Black, 100f, 1000f);
				e.Graphics.DrawString("____________________", font4, Brushes.Black, 170f, 1000f);
				e.Graphics.DrawString("Controlo:", font4, Brushes.Black, 350f, 1000f);
				e.Graphics.DrawString("____________________", font4, Brushes.Black, 420f, 1000f);
				e.Graphics.DrawString("Valor CTR: $" + Conversions.ToString(selectedOrder.valorCtr), font4, Brushes.Black, 170f, 1110f);
				e.Graphics.DrawString("Valor Declarado: $" + Conversions.ToString(selectedOrder.valor), font4, Brushes.Black, 420f, 1110f);
			}
			else
			{
				Interaction.MsgBox("Error al recuperar la orden");
			}
		}
	}
}
