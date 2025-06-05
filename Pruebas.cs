using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Hermes.My;
using Hermes.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace Hermes;

[DesignerGenerated]
public class Pruebas : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("catecombo")]
	private ComboBox _catecombo;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("NewToolStripButton")]
	private ToolStripButton _NewToolStripButton;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("SaveToolStripButton")]
	private ToolStripButton _SaveToolStripButton;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("PrintToolStripButton")]
	private ToolStripButton _PrintToolStripButton;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("CutToolStripButton")]
	private ToolStripButton _CutToolStripButton;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("CopyToolStripButton")]
	private ToolStripButton _CopyToolStripButton;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("PasteToolStripButton")]
	private ToolStripButton _PasteToolStripButton;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("HelpToolStripButton")]
	private ToolStripButton _HelpToolStripButton;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ListView1")]
	private ListView _ListView1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStripButton1")]
	private ToolStripButton _ToolStripButton1;

	private string fecha1;

	[field: AccessedThroughProperty("idlbl")]
	internal virtual Label idlbl
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("numerolbl")]
	internal virtual Label numerolbl
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("patentelbl")]
	internal virtual Label patentelbl
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("categorialbl")]
	internal virtual Label categorialbl
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("numchoferlbl")]
	internal virtual Label numchoferlbl
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("disponiblelbl")]
	internal virtual Label disponiblelbl
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tarifalbl")]
	internal virtual Label tarifalbl
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pesolbl")]
	internal virtual Label pesolbl
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("volumenlbl")]
	internal virtual Label volumenlbl
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("estadolbl")]
	internal virtual Label estadolbl
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("anolbl")]
	internal virtual Label anolbl
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("marcalbl")]
	internal virtual Label marcalbl
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("modelolbl")]
	internal virtual Label modelolbl
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("adicionallbl")]
	internal virtual Label adicionallbl
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("gpslbl")]
	internal virtual Label gpslbl
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("altalbl")]
	internal virtual Label altalbl
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("bajalbl")]
	internal virtual Label bajalbl
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("usuariolbl")]
	internal virtual Label usuariolbl
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

	[field: AccessedThroughProperty("gpstxt")]
	internal virtual TextBox gpstxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("volumentxt")]
	internal virtual TextBox volumentxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pesotxt")]
	internal virtual TextBox pesotxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("anotxt")]
	internal virtual TextBox anotxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("modelotxt")]
	internal virtual TextBox modelotxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("marcatxt")]
	internal virtual TextBox marcatxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("patentetxt")]
	internal virtual TextBox patentetxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("numerotxt")]
	internal virtual TextBox numerotxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("idtxt")]
	internal virtual Label idtxt
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

	[field: AccessedThroughProperty("GroupBox3")]
	internal virtual GroupBox GroupBox3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("dispocombo")]
	internal virtual ComboBox dispocombo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("estadocombo")]
	internal virtual ComboBox estadocombo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("nomchoferlbl")]
	internal virtual Label nomchoferlbl
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

	[field: AccessedThroughProperty("usuariotxt")]
	internal virtual Label usuariotxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("bajatxt")]
	internal virtual Label bajatxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("altatxt")]
	internal virtual Label altatxt
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

	[field: AccessedThroughProperty("adicionaltxt")]
	internal virtual TextBox adicionaltxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tarifatxt")]
	internal virtual TextBox tarifatxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ComboBox catecombo
	{
		[CompilerGenerated]
		get
		{
			return _catecombo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = catecombo_SelectedIndexChanged;
			ComboBox comboBox = _catecombo;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged -= value2;
			}
			_catecombo = value;
			comboBox = _catecombo;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("ToolStrip1")]
	internal virtual ToolStrip ToolStrip1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripButton NewToolStripButton
	{
		[CompilerGenerated]
		get
		{
			return _NewToolStripButton;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = NewToolStripButton_Click;
			ToolStripButton newToolStripButton = _NewToolStripButton;
			if (newToolStripButton != null)
			{
				newToolStripButton.Click -= value2;
			}
			_NewToolStripButton = value;
			newToolStripButton = _NewToolStripButton;
			if (newToolStripButton != null)
			{
				newToolStripButton.Click += value2;
			}
		}
	}

	internal virtual ToolStripButton SaveToolStripButton
	{
		[CompilerGenerated]
		get
		{
			return _SaveToolStripButton;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = SaveToolStripButton_Click;
			ToolStripButton saveToolStripButton = _SaveToolStripButton;
			if (saveToolStripButton != null)
			{
				saveToolStripButton.Click -= value2;
			}
			_SaveToolStripButton = value;
			saveToolStripButton = _SaveToolStripButton;
			if (saveToolStripButton != null)
			{
				saveToolStripButton.Click += value2;
			}
		}
	}

	internal virtual ToolStripButton PrintToolStripButton
	{
		[CompilerGenerated]
		get
		{
			return _PrintToolStripButton;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = PrintToolStripButton_Click;
			ToolStripButton printToolStripButton = _PrintToolStripButton;
			if (printToolStripButton != null)
			{
				printToolStripButton.Click -= value2;
			}
			_PrintToolStripButton = value;
			printToolStripButton = _PrintToolStripButton;
			if (printToolStripButton != null)
			{
				printToolStripButton.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("toolStripSeparator")]
	internal virtual ToolStripSeparator toolStripSeparator
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripButton CutToolStripButton
	{
		[CompilerGenerated]
		get
		{
			return _CutToolStripButton;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = CutToolStripButton_Click;
			ToolStripButton cutToolStripButton = _CutToolStripButton;
			if (cutToolStripButton != null)
			{
				cutToolStripButton.Click -= value2;
			}
			_CutToolStripButton = value;
			cutToolStripButton = _CutToolStripButton;
			if (cutToolStripButton != null)
			{
				cutToolStripButton.Click += value2;
			}
		}
	}

	internal virtual ToolStripButton CopyToolStripButton
	{
		[CompilerGenerated]
		get
		{
			return _CopyToolStripButton;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = CopyToolStripButton_Click;
			ToolStripButton copyToolStripButton = _CopyToolStripButton;
			if (copyToolStripButton != null)
			{
				copyToolStripButton.Click -= value2;
			}
			_CopyToolStripButton = value;
			copyToolStripButton = _CopyToolStripButton;
			if (copyToolStripButton != null)
			{
				copyToolStripButton.Click += value2;
			}
		}
	}

	internal virtual ToolStripButton PasteToolStripButton
	{
		[CompilerGenerated]
		get
		{
			return _PasteToolStripButton;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = PasteToolStripButton_Click;
			ToolStripButton pasteToolStripButton = _PasteToolStripButton;
			if (pasteToolStripButton != null)
			{
				pasteToolStripButton.Click -= value2;
			}
			_PasteToolStripButton = value;
			pasteToolStripButton = _PasteToolStripButton;
			if (pasteToolStripButton != null)
			{
				pasteToolStripButton.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("toolStripSeparator1")]
	internal virtual ToolStripSeparator toolStripSeparator1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripButton HelpToolStripButton
	{
		[CompilerGenerated]
		get
		{
			return _HelpToolStripButton;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = HelpToolStripButton_Click;
			ToolStripButton helpToolStripButton = _HelpToolStripButton;
			if (helpToolStripButton != null)
			{
				helpToolStripButton.Click -= value2;
			}
			_HelpToolStripButton = value;
			helpToolStripButton = _HelpToolStripButton;
			if (helpToolStripButton != null)
			{
				helpToolStripButton.Click += value2;
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

	[field: AccessedThroughProperty("Numero")]
	internal virtual ColumnHeader Numero
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Patente")]
	internal virtual ColumnHeader Patente
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Chofer")]
	internal virtual ColumnHeader Chofer
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Estado")]
	internal virtual ColumnHeader Estado
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Disponible")]
	internal virtual ColumnHeader Disponible
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripButton ToolStripButton1
	{
		[CompilerGenerated]
		get
		{
			return _ToolStripButton1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ToolStripButton1_Click;
			ToolStripButton toolStripButton = _ToolStripButton1;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value2;
			}
			_ToolStripButton1 = value;
			toolStripButton = _ToolStripButton1;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("vehiculostxt")]
	internal virtual Label vehiculostxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("vehiculoslbl")]
	internal virtual Label vehiculoslbl
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ultimatxt")]
	internal virtual Label ultimatxt
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

	[field: AccessedThroughProperty("nomchoftxt")]
	internal virtual Label nomchoftxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("numchoftxt")]
	internal virtual Label numchoftxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public Pruebas()
	{
		base.Load += Pruebas_Load;
		fecha1 = Strings.Format(MyProject.Forms.Form1_Inicio.DateTimePicker1.Value, "yyyyMMdd");
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hermes.Pruebas));
		this.idlbl = new System.Windows.Forms.Label();
		this.numerolbl = new System.Windows.Forms.Label();
		this.patentelbl = new System.Windows.Forms.Label();
		this.categorialbl = new System.Windows.Forms.Label();
		this.numchoferlbl = new System.Windows.Forms.Label();
		this.disponiblelbl = new System.Windows.Forms.Label();
		this.tarifalbl = new System.Windows.Forms.Label();
		this.pesolbl = new System.Windows.Forms.Label();
		this.volumenlbl = new System.Windows.Forms.Label();
		this.estadolbl = new System.Windows.Forms.Label();
		this.anolbl = new System.Windows.Forms.Label();
		this.marcalbl = new System.Windows.Forms.Label();
		this.modelolbl = new System.Windows.Forms.Label();
		this.adicionallbl = new System.Windows.Forms.Label();
		this.gpslbl = new System.Windows.Forms.Label();
		this.altalbl = new System.Windows.Forms.Label();
		this.bajalbl = new System.Windows.Forms.Label();
		this.usuariolbl = new System.Windows.Forms.Label();
		this.GroupBox1 = new System.Windows.Forms.GroupBox();
		this.gpstxt = new System.Windows.Forms.TextBox();
		this.volumentxt = new System.Windows.Forms.TextBox();
		this.pesotxt = new System.Windows.Forms.TextBox();
		this.anotxt = new System.Windows.Forms.TextBox();
		this.modelotxt = new System.Windows.Forms.TextBox();
		this.marcatxt = new System.Windows.Forms.TextBox();
		this.patentetxt = new System.Windows.Forms.TextBox();
		this.numerotxt = new System.Windows.Forms.TextBox();
		this.idtxt = new System.Windows.Forms.Label();
		this.GroupBox2 = new System.Windows.Forms.GroupBox();
		this.ultimatxt = new System.Windows.Forms.Label();
		this.Label1 = new System.Windows.Forms.Label();
		this.Label2 = new System.Windows.Forms.Label();
		this.adicionaltxt = new System.Windows.Forms.TextBox();
		this.tarifatxt = new System.Windows.Forms.TextBox();
		this.catecombo = new System.Windows.Forms.ComboBox();
		this.dispocombo = new System.Windows.Forms.ComboBox();
		this.estadocombo = new System.Windows.Forms.ComboBox();
		this.GroupBox3 = new System.Windows.Forms.GroupBox();
		this.nomchoferlbl = new System.Windows.Forms.Label();
		this.GroupBox4 = new System.Windows.Forms.GroupBox();
		this.vehiculostxt = new System.Windows.Forms.Label();
		this.vehiculoslbl = new System.Windows.Forms.Label();
		this.usuariotxt = new System.Windows.Forms.Label();
		this.bajatxt = new System.Windows.Forms.Label();
		this.altatxt = new System.Windows.Forms.Label();
		this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
		this.NewToolStripButton = new System.Windows.Forms.ToolStripButton();
		this.SaveToolStripButton = new System.Windows.Forms.ToolStripButton();
		this.ToolStripButton1 = new System.Windows.Forms.ToolStripButton();
		this.PrintToolStripButton = new System.Windows.Forms.ToolStripButton();
		this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
		this.CutToolStripButton = new System.Windows.Forms.ToolStripButton();
		this.CopyToolStripButton = new System.Windows.Forms.ToolStripButton();
		this.PasteToolStripButton = new System.Windows.Forms.ToolStripButton();
		this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
		this.HelpToolStripButton = new System.Windows.Forms.ToolStripButton();
		this.ListView1 = new System.Windows.Forms.ListView();
		this.Numero = new System.Windows.Forms.ColumnHeader();
		this.Patente = new System.Windows.Forms.ColumnHeader();
		this.Chofer = new System.Windows.Forms.ColumnHeader();
		this.Estado = new System.Windows.Forms.ColumnHeader();
		this.Disponible = new System.Windows.Forms.ColumnHeader();
		this.numchoftxt = new System.Windows.Forms.Label();
		this.nomchoftxt = new System.Windows.Forms.Label();
		this.GroupBox1.SuspendLayout();
		this.GroupBox2.SuspendLayout();
		this.GroupBox3.SuspendLayout();
		this.GroupBox4.SuspendLayout();
		this.ToolStrip1.SuspendLayout();
		base.SuspendLayout();
		this.idlbl.AutoSize = true;
		this.idlbl.Location = new System.Drawing.Point(8, 20);
		this.idlbl.Name = "idlbl";
		this.idlbl.Size = new System.Drawing.Size(19, 13);
		this.idlbl.TabIndex = 0;
		this.idlbl.Text = "Id:";
		this.numerolbl.AutoSize = true;
		this.numerolbl.Location = new System.Drawing.Point(8, 47);
		this.numerolbl.Name = "numerolbl";
		this.numerolbl.Size = new System.Drawing.Size(47, 13);
		this.numerolbl.TabIndex = 1;
		this.numerolbl.Text = "Numero:";
		this.numerolbl.Visible = false;
		this.patentelbl.AutoSize = true;
		this.patentelbl.Location = new System.Drawing.Point(8, 73);
		this.patentelbl.Name = "patentelbl";
		this.patentelbl.Size = new System.Drawing.Size(47, 13);
		this.patentelbl.TabIndex = 2;
		this.patentelbl.Text = "Patente:";
		this.categorialbl.AutoSize = true;
		this.categorialbl.Location = new System.Drawing.Point(6, 70);
		this.categorialbl.Name = "categorialbl";
		this.categorialbl.Size = new System.Drawing.Size(55, 13);
		this.categorialbl.TabIndex = 3;
		this.categorialbl.Text = "Categoria:";
		this.numchoferlbl.AutoSize = true;
		this.numchoferlbl.Location = new System.Drawing.Point(6, 27);
		this.numchoferlbl.Name = "numchoferlbl";
		this.numchoferlbl.Size = new System.Drawing.Size(81, 13);
		this.numchoferlbl.TabIndex = 4;
		this.numchoferlbl.Text = "Numero Chofer:";
		this.disponiblelbl.AutoSize = true;
		this.disponiblelbl.Location = new System.Drawing.Point(6, 44);
		this.disponiblelbl.Name = "disponiblelbl";
		this.disponiblelbl.Size = new System.Drawing.Size(59, 13);
		this.disponiblelbl.TabIndex = 5;
		this.disponiblelbl.Text = "Disponible:";
		this.tarifalbl.AutoSize = true;
		this.tarifalbl.Location = new System.Drawing.Point(162, 18);
		this.tarifalbl.Name = "tarifalbl";
		this.tarifalbl.Size = new System.Drawing.Size(37, 13);
		this.tarifalbl.TabIndex = 6;
		this.tarifalbl.Text = "Tarifa:";
		this.pesolbl.AutoSize = true;
		this.pesolbl.Location = new System.Drawing.Point(8, 177);
		this.pesolbl.Name = "pesolbl";
		this.pesolbl.Size = new System.Drawing.Size(34, 13);
		this.pesolbl.TabIndex = 7;
		this.pesolbl.Text = "Peso:";
		this.volumenlbl.AutoSize = true;
		this.volumenlbl.Location = new System.Drawing.Point(8, 203);
		this.volumenlbl.Name = "volumenlbl";
		this.volumenlbl.Size = new System.Drawing.Size(51, 13);
		this.volumenlbl.TabIndex = 8;
		this.volumenlbl.Text = "Volumen:";
		this.estadolbl.AutoSize = true;
		this.estadolbl.Location = new System.Drawing.Point(6, 18);
		this.estadolbl.Name = "estadolbl";
		this.estadolbl.Size = new System.Drawing.Size(43, 13);
		this.estadolbl.TabIndex = 9;
		this.estadolbl.Text = "Estado:";
		this.anolbl.AutoSize = true;
		this.anolbl.Location = new System.Drawing.Point(8, 153);
		this.anolbl.Name = "anolbl";
		this.anolbl.Size = new System.Drawing.Size(29, 13);
		this.anolbl.TabIndex = 10;
		this.anolbl.Text = "Año:";
		this.marcalbl.AutoSize = true;
		this.marcalbl.Location = new System.Drawing.Point(8, 100);
		this.marcalbl.Name = "marcalbl";
		this.marcalbl.Size = new System.Drawing.Size(40, 13);
		this.marcalbl.TabIndex = 11;
		this.marcalbl.Text = "Marca:";
		this.modelolbl.AutoSize = true;
		this.modelolbl.Location = new System.Drawing.Point(8, 127);
		this.modelolbl.Name = "modelolbl";
		this.modelolbl.Size = new System.Drawing.Size(45, 13);
		this.modelolbl.TabIndex = 12;
		this.modelolbl.Text = "Modelo:";
		this.adicionallbl.AutoSize = true;
		this.adicionallbl.Location = new System.Drawing.Point(162, 43);
		this.adicionallbl.Name = "adicionallbl";
		this.adicionallbl.Size = new System.Drawing.Size(53, 13);
		this.adicionallbl.TabIndex = 13;
		this.adicionallbl.Text = "Adicional:";
		this.gpslbl.AutoSize = true;
		this.gpslbl.Location = new System.Drawing.Point(8, 229);
		this.gpslbl.Name = "gpslbl";
		this.gpslbl.Size = new System.Drawing.Size(32, 13);
		this.gpslbl.TabIndex = 14;
		this.gpslbl.Text = "GPS:";
		this.altalbl.AutoSize = true;
		this.altalbl.Location = new System.Drawing.Point(8, 16);
		this.altalbl.Name = "altalbl";
		this.altalbl.Size = new System.Drawing.Size(28, 13);
		this.altalbl.TabIndex = 15;
		this.altalbl.Text = "Alta:";
		this.bajalbl.AutoSize = true;
		this.bajalbl.Location = new System.Drawing.Point(197, 16);
		this.bajalbl.Name = "bajalbl";
		this.bajalbl.Size = new System.Drawing.Size(31, 13);
		this.bajalbl.TabIndex = 16;
		this.bajalbl.Text = "Baja:";
		this.usuariolbl.AutoSize = true;
		this.usuariolbl.Location = new System.Drawing.Point(535, 16);
		this.usuariolbl.Name = "usuariolbl";
		this.usuariolbl.Size = new System.Drawing.Size(46, 13);
		this.usuariolbl.TabIndex = 17;
		this.usuariolbl.Text = "Usuario:";
		this.GroupBox1.Controls.Add(this.gpstxt);
		this.GroupBox1.Controls.Add(this.volumentxt);
		this.GroupBox1.Controls.Add(this.pesotxt);
		this.GroupBox1.Controls.Add(this.anotxt);
		this.GroupBox1.Controls.Add(this.modelotxt);
		this.GroupBox1.Controls.Add(this.marcatxt);
		this.GroupBox1.Controls.Add(this.gpslbl);
		this.GroupBox1.Controls.Add(this.patentetxt);
		this.GroupBox1.Controls.Add(this.numerotxt);
		this.GroupBox1.Controls.Add(this.idtxt);
		this.GroupBox1.Controls.Add(this.idlbl);
		this.GroupBox1.Controls.Add(this.numerolbl);
		this.GroupBox1.Controls.Add(this.patentelbl);
		this.GroupBox1.Controls.Add(this.modelolbl);
		this.GroupBox1.Controls.Add(this.marcalbl);
		this.GroupBox1.Controls.Add(this.anolbl);
		this.GroupBox1.Controls.Add(this.pesolbl);
		this.GroupBox1.Controls.Add(this.volumenlbl);
		this.GroupBox1.Location = new System.Drawing.Point(6, 28);
		this.GroupBox1.Name = "GroupBox1";
		this.GroupBox1.Size = new System.Drawing.Size(405, 261);
		this.GroupBox1.TabIndex = 18;
		this.GroupBox1.TabStop = false;
		this.gpstxt.Location = new System.Drawing.Point(94, 226);
		this.gpstxt.Name = "gpstxt";
		this.gpstxt.Size = new System.Drawing.Size(305, 20);
		this.gpstxt.TabIndex = 21;
		this.volumentxt.Location = new System.Drawing.Point(94, 200);
		this.volumentxt.Name = "volumentxt";
		this.volumentxt.Size = new System.Drawing.Size(305, 20);
		this.volumentxt.TabIndex = 20;
		this.pesotxt.Location = new System.Drawing.Point(94, 174);
		this.pesotxt.Name = "pesotxt";
		this.pesotxt.Size = new System.Drawing.Size(305, 20);
		this.pesotxt.TabIndex = 19;
		this.anotxt.Location = new System.Drawing.Point(94, 148);
		this.anotxt.Name = "anotxt";
		this.anotxt.Size = new System.Drawing.Size(305, 20);
		this.anotxt.TabIndex = 18;
		this.modelotxt.Location = new System.Drawing.Point(94, 122);
		this.modelotxt.Name = "modelotxt";
		this.modelotxt.Size = new System.Drawing.Size(305, 20);
		this.modelotxt.TabIndex = 17;
		this.marcatxt.Location = new System.Drawing.Point(94, 96);
		this.marcatxt.Name = "marcatxt";
		this.marcatxt.Size = new System.Drawing.Size(305, 20);
		this.marcatxt.TabIndex = 16;
		this.patentetxt.BackColor = System.Drawing.SystemColors.Window;
		this.patentetxt.Location = new System.Drawing.Point(94, 70);
		this.patentetxt.Name = "patentetxt";
		this.patentetxt.Size = new System.Drawing.Size(305, 20);
		this.patentetxt.TabIndex = 15;
		this.numerotxt.Location = new System.Drawing.Point(94, 44);
		this.numerotxt.Name = "numerotxt";
		this.numerotxt.Size = new System.Drawing.Size(305, 20);
		this.numerotxt.TabIndex = 14;
		this.numerotxt.Visible = false;
		this.idtxt.AutoSize = true;
		this.idtxt.Location = new System.Drawing.Point(91, 20);
		this.idtxt.Name = "idtxt";
		this.idtxt.Size = new System.Drawing.Size(13, 13);
		this.idtxt.TabIndex = 13;
		this.idtxt.Text = "0";
		this.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.GroupBox2.BackColor = System.Drawing.Color.Transparent;
		this.GroupBox2.Controls.Add(this.ultimatxt);
		this.GroupBox2.Controls.Add(this.Label1);
		this.GroupBox2.Controls.Add(this.Label2);
		this.GroupBox2.Controls.Add(this.adicionaltxt);
		this.GroupBox2.Controls.Add(this.tarifatxt);
		this.GroupBox2.Controls.Add(this.catecombo);
		this.GroupBox2.Controls.Add(this.dispocombo);
		this.GroupBox2.Controls.Add(this.estadocombo);
		this.GroupBox2.Controls.Add(this.estadolbl);
		this.GroupBox2.Controls.Add(this.disponiblelbl);
		this.GroupBox2.Controls.Add(this.tarifalbl);
		this.GroupBox2.Controls.Add(this.adicionallbl);
		this.GroupBox2.Controls.Add(this.categorialbl);
		this.GroupBox2.Location = new System.Drawing.Point(417, 295);
		this.GroupBox2.Name = "GroupBox2";
		this.GroupBox2.Size = new System.Drawing.Size(398, 100);
		this.GroupBox2.TabIndex = 19;
		this.GroupBox2.TabStop = false;
		this.ultimatxt.AutoSize = true;
		this.ultimatxt.Location = new System.Drawing.Point(231, 71);
		this.ultimatxt.Name = "ultimatxt";
		this.ultimatxt.Size = new System.Drawing.Size(133, 13);
		this.ultimatxt.TabIndex = 22;
		this.ultimatxt.Text = "19/05/2045 18:22:15 a.m.";
		this.Label1.AutoSize = true;
		this.Label1.Location = new System.Drawing.Point(358, 43);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(15, 13);
		this.Label1.TabIndex = 19;
		this.Label1.Text = "%";
		this.Label2.AutoSize = true;
		this.Label2.Location = new System.Drawing.Point(162, 71);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(63, 13);
		this.Label2.TabIndex = 21;
		this.Label2.Text = "Ultima Mod.";
		this.adicionaltxt.Location = new System.Drawing.Point(221, 41);
		this.adicionaltxt.Name = "adicionaltxt";
		this.adicionaltxt.Size = new System.Drawing.Size(131, 20);
		this.adicionaltxt.TabIndex = 18;
		this.tarifatxt.Location = new System.Drawing.Point(221, 14);
		this.tarifatxt.Name = "tarifatxt";
		this.tarifatxt.Size = new System.Drawing.Size(152, 20);
		this.tarifatxt.TabIndex = 17;
		this.catecombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.catecombo.FormattingEnabled = true;
		this.catecombo.Location = new System.Drawing.Point(74, 67);
		this.catecombo.Name = "catecombo";
		this.catecombo.Size = new System.Drawing.Size(81, 21);
		this.catecombo.TabIndex = 16;
		this.dispocombo.FormattingEnabled = true;
		this.dispocombo.Items.AddRange(new object[2] { "Si", "No" });
		this.dispocombo.Location = new System.Drawing.Point(74, 41);
		this.dispocombo.Name = "dispocombo";
		this.dispocombo.Size = new System.Drawing.Size(81, 21);
		this.dispocombo.TabIndex = 15;
		this.dispocombo.Text = "Si";
		this.estadocombo.FormattingEnabled = true;
		this.estadocombo.Items.AddRange(new object[2] { "Activo", "Inactivo" });
		this.estadocombo.Location = new System.Drawing.Point(74, 14);
		this.estadocombo.Name = "estadocombo";
		this.estadocombo.Size = new System.Drawing.Size(81, 21);
		this.estadocombo.TabIndex = 14;
		this.estadocombo.Text = "Activo";
		this.GroupBox3.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.GroupBox3.Controls.Add(this.nomchoftxt);
		this.GroupBox3.Controls.Add(this.numchoftxt);
		this.GroupBox3.Controls.Add(this.nomchoferlbl);
		this.GroupBox3.Controls.Add(this.numchoferlbl);
		this.GroupBox3.Location = new System.Drawing.Point(6, 295);
		this.GroupBox3.Name = "GroupBox3";
		this.GroupBox3.Size = new System.Drawing.Size(405, 100);
		this.GroupBox3.TabIndex = 20;
		this.GroupBox3.TabStop = false;
		this.nomchoferlbl.AutoSize = true;
		this.nomchoferlbl.Location = new System.Drawing.Point(6, 66);
		this.nomchoferlbl.Name = "nomchoferlbl";
		this.nomchoferlbl.Size = new System.Drawing.Size(81, 13);
		this.nomchoferlbl.TabIndex = 6;
		this.nomchoferlbl.Text = "Nombre Chofer:";
		this.GroupBox4.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.GroupBox4.Controls.Add(this.vehiculostxt);
		this.GroupBox4.Controls.Add(this.vehiculoslbl);
		this.GroupBox4.Controls.Add(this.usuariotxt);
		this.GroupBox4.Controls.Add(this.bajatxt);
		this.GroupBox4.Controls.Add(this.altatxt);
		this.GroupBox4.Controls.Add(this.usuariolbl);
		this.GroupBox4.Controls.Add(this.altalbl);
		this.GroupBox4.Controls.Add(this.bajalbl);
		this.GroupBox4.Location = new System.Drawing.Point(6, 401);
		this.GroupBox4.Name = "GroupBox4";
		this.GroupBox4.Size = new System.Drawing.Size(809, 37);
		this.GroupBox4.TabIndex = 21;
		this.GroupBox4.TabStop = false;
		this.vehiculostxt.AutoSize = true;
		this.vehiculostxt.Location = new System.Drawing.Point(713, 16);
		this.vehiculostxt.Name = "vehiculostxt";
		this.vehiculostxt.Size = new System.Drawing.Size(13, 13);
		this.vehiculostxt.TabIndex = 20;
		this.vehiculostxt.Text = "0";
		this.vehiculoslbl.AutoSize = true;
		this.vehiculoslbl.Location = new System.Drawing.Point(651, 16);
		this.vehiculoslbl.Name = "vehiculoslbl";
		this.vehiculoslbl.Size = new System.Drawing.Size(56, 13);
		this.vehiculoslbl.TabIndex = 19;
		this.vehiculoslbl.Text = "Vehiculos:";
		this.usuariotxt.AutoSize = true;
		this.usuariotxt.Location = new System.Drawing.Point(587, 16);
		this.usuariotxt.Name = "usuariotxt";
		this.usuariotxt.Size = new System.Drawing.Size(39, 13);
		this.usuariotxt.TabIndex = 18;
		this.usuariotxt.Text = "Label1";
		this.bajatxt.AutoSize = true;
		this.bajatxt.Location = new System.Drawing.Point(234, 16);
		this.bajatxt.Name = "bajatxt";
		this.bajatxt.Size = new System.Drawing.Size(133, 13);
		this.bajatxt.TabIndex = 17;
		this.bajatxt.Text = "01/01/1999 22:02:58 a.m.";
		this.altatxt.AutoSize = true;
		this.altatxt.Location = new System.Drawing.Point(42, 16);
		this.altatxt.Name = "altatxt";
		this.altatxt.Size = new System.Drawing.Size(133, 13);
		this.altatxt.TabIndex = 16;
		this.altatxt.Text = "01/01/1999 17:45:55 p.m.";
		this.ToolStrip1.BackColor = System.Drawing.Color.Transparent;
		this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[10] { this.NewToolStripButton, this.SaveToolStripButton, this.ToolStripButton1, this.PrintToolStripButton, this.toolStripSeparator, this.CutToolStripButton, this.CopyToolStripButton, this.PasteToolStripButton, this.toolStripSeparator1, this.HelpToolStripButton });
		this.ToolStrip1.Location = new System.Drawing.Point(0, 0);
		this.ToolStrip1.Name = "ToolStrip1";
		this.ToolStrip1.Size = new System.Drawing.Size(827, 25);
		this.ToolStrip1.TabIndex = 22;
		this.ToolStrip1.Text = "ToolStrip1";
		this.NewToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
		this.NewToolStripButton.Image = (System.Drawing.Image)resources.GetObject("NewToolStripButton.Image");
		this.NewToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.NewToolStripButton.Name = "NewToolStripButton";
		this.NewToolStripButton.Size = new System.Drawing.Size(23, 22);
		this.NewToolStripButton.Text = "Nuevo Vehiculo";
		this.SaveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
		this.SaveToolStripButton.Image = (System.Drawing.Image)resources.GetObject("SaveToolStripButton.Image");
		this.SaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.SaveToolStripButton.Name = "SaveToolStripButton";
		this.SaveToolStripButton.Size = new System.Drawing.Size(23, 22);
		this.SaveToolStripButton.Text = "Guardar";
		this.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
		this.ToolStripButton1.Image = Hermes.My.Resources.Resources.close_32;
		this.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.ToolStripButton1.Name = "ToolStripButton1";
		this.ToolStripButton1.Size = new System.Drawing.Size(23, 22);
		this.ToolStripButton1.Text = "Borrar Vehiculo";
		this.PrintToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
		this.PrintToolStripButton.Image = (System.Drawing.Image)resources.GetObject("PrintToolStripButton.Image");
		this.PrintToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.PrintToolStripButton.Name = "PrintToolStripButton";
		this.PrintToolStripButton.Size = new System.Drawing.Size(23, 22);
		this.PrintToolStripButton.Text = "Imprimir";
		this.toolStripSeparator.Name = "toolStripSeparator";
		this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
		this.CutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
		this.CutToolStripButton.Image = (System.Drawing.Image)resources.GetObject("CutToolStripButton.Image");
		this.CutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.CutToolStripButton.Name = "CutToolStripButton";
		this.CutToolStripButton.Size = new System.Drawing.Size(23, 22);
		this.CutToolStripButton.Text = "Cortar";
		this.CopyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
		this.CopyToolStripButton.Image = (System.Drawing.Image)resources.GetObject("CopyToolStripButton.Image");
		this.CopyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.CopyToolStripButton.Name = "CopyToolStripButton";
		this.CopyToolStripButton.Size = new System.Drawing.Size(23, 22);
		this.CopyToolStripButton.Text = "Copiar";
		this.PasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
		this.PasteToolStripButton.Image = (System.Drawing.Image)resources.GetObject("PasteToolStripButton.Image");
		this.PasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.PasteToolStripButton.Name = "PasteToolStripButton";
		this.PasteToolStripButton.Size = new System.Drawing.Size(23, 22);
		this.PasteToolStripButton.Text = "Pegar";
		this.toolStripSeparator1.Name = "toolStripSeparator1";
		this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
		this.HelpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
		this.HelpToolStripButton.Image = (System.Drawing.Image)resources.GetObject("HelpToolStripButton.Image");
		this.HelpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.HelpToolStripButton.Name = "HelpToolStripButton";
		this.HelpToolStripButton.Size = new System.Drawing.Size(23, 22);
		this.HelpToolStripButton.Text = "Ayuda";
		this.ListView1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.ListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[5] { this.Numero, this.Patente, this.Chofer, this.Estado, this.Disponible });
		this.ListView1.FullRowSelect = true;
		this.ListView1.GridLines = true;
		this.ListView1.Location = new System.Drawing.Point(417, 36);
		this.ListView1.MultiSelect = false;
		this.ListView1.Name = "ListView1";
		this.ListView1.Size = new System.Drawing.Size(398, 253);
		this.ListView1.TabIndex = 23;
		this.ListView1.UseCompatibleStateImageBehavior = false;
		this.ListView1.View = System.Windows.Forms.View.Details;
		this.Numero.Text = "Numero";
		this.Patente.Text = "Patente";
		this.Chofer.Text = "Chofer";
		this.Chofer.Width = 154;
		this.Estado.Text = "Estado";
		this.Disponible.Text = "Disponible";
		this.numchoftxt.AutoSize = true;
		this.numchoftxt.Location = new System.Drawing.Point(111, 27);
		this.numchoftxt.Name = "numchoftxt";
		this.numchoftxt.Size = new System.Drawing.Size(13, 13);
		this.numchoftxt.TabIndex = 7;
		this.numchoftxt.Text = "0";
		this.nomchoftxt.AutoSize = true;
		this.nomchoftxt.Location = new System.Drawing.Point(111, 66);
		this.nomchoftxt.Name = "nomchoftxt";
		this.nomchoftxt.Size = new System.Drawing.Size(103, 13);
		this.nomchoftxt.TabIndex = 8;
		this.nomchoftxt.Text = "Sin Chofer Asignado";
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.Gray;
		base.ClientSize = new System.Drawing.Size(827, 445);
		base.Controls.Add(this.ListView1);
		base.Controls.Add(this.ToolStrip1);
		base.Controls.Add(this.GroupBox4);
		base.Controls.Add(this.GroupBox3);
		base.Controls.Add(this.GroupBox2);
		base.Controls.Add(this.GroupBox1);
		this.ForeColor = System.Drawing.Color.White;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.Name = "Pruebas";
		this.Text = "Vehiculos:";
		this.GroupBox1.ResumeLayout(false);
		this.GroupBox1.PerformLayout();
		this.GroupBox2.ResumeLayout(false);
		this.GroupBox2.PerformLayout();
		this.GroupBox3.ResumeLayout(false);
		this.GroupBox3.PerformLayout();
		this.GroupBox4.ResumeLayout(false);
		this.GroupBox4.PerformLayout();
		this.ToolStrip1.ResumeLayout(false);
		this.ToolStrip1.PerformLayout();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private void Pruebas_Load(object sender, EventArgs e)
	{
		vehiculos();
		try
		{
			string sql = "SELECT Categoria FROM Categorias";
			Mod_Sentencias.cargar_cbb(catecombo, sql);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			Interaction.MsgBox("No existen Categorias");
			ProjectData.ClearProjectError();
		}
	}

	private void NewToolStripButton_Click(object sender, EventArgs e)
	{
		limpiar_campos();
		Interaction.MsgBox("ingrese los datos");
		patentetxt.BackColor = Color.Khaki;
		tarifatxt.BackColor = Color.Khaki;
		pesotxt.BackColor = Color.Khaki;
		volumentxt.BackColor = Color.Khaki;
		anotxt.BackColor = Color.Khaki;
		patentetxt.Focus();
		idtxt.Text = "0";
	}

	private void SaveToolStripButton_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(idtxt.Text, "0", TextCompare: true) == 0)
		{
			if (Operators.CompareString(patentetxt.Text, "", TextCompare: true) == 0)
			{
				patentetxt.BackColor = Color.Khaki;
				tarifatxt.BackColor = Color.Khaki;
				pesotxt.BackColor = Color.Khaki;
				volumentxt.BackColor = Color.Khaki;
				anotxt.BackColor = Color.Khaki;
				patentetxt.Focus();
				return;
			}
			if (Operators.CompareString(catecombo.Text, "", TextCompare: true) == 0)
			{
				catecombo.BackColor = Color.Khaki;
				catecombo.Focus();
				return;
			}
			if (Operators.CompareString(tarifatxt.Text, "", TextCompare: true) == 0)
			{
				tarifatxt.BackColor = Color.Khaki;
				tarifatxt.Focus();
				return;
			}
			if (Operators.CompareString(pesotxt.Text, "", TextCompare: true) == 0)
			{
				pesotxt.BackColor = Color.Khaki;
				pesotxt.Focus();
				return;
			}
			if (Operators.CompareString(volumentxt.Text, "", TextCompare: true) == 0)
			{
				volumentxt.BackColor = Color.Khaki;
				volumentxt.Focus();
				return;
			}
			if (Operators.CompareString(anotxt.Text, "", TextCompare: true) == 0)
			{
				anotxt.BackColor = Color.Khaki;
				anotxt.Focus();
				return;
			}
			if (Operators.CompareString(marcatxt.Text, "", TextCompare: true) == 0)
			{
				marcatxt.Text = "Marca";
			}
			if (Operators.CompareString(modelotxt.Text, "", TextCompare: true) == 0)
			{
				modelotxt.Text = "Modelo";
			}
			if (Operators.CompareString(adicionaltxt.Text, "", TextCompare: true) == 0)
			{
				adicionaltxt.Text = Conversions.ToString(0);
			}
			if (Operators.CompareString(gpstxt.Text, "", TextCompare: true) == 0)
			{
				gpstxt.Text = "Sin Especificar";
			}
			string sQL = "INSERT INTO Vehiculos (Patente,Numero, Chofer, Categoria,Disponible,Tarifa,Peso,Volumen,Estado,Ano,Marca,Modelo,Adicional,GPS,Alta,Modificacion,Usuario) VALUES ('" + patentetxt.Text + "'," + numchoftxt.Text + ",'" + nomchoftxt.Text + "'," + catecombo.Text + ",'No'," + Strings.Replace(tarifatxt.Text, ",", ".", 1, -1, CompareMethod.Text) + "," + Strings.Replace(pesotxt.Text, ",", ".", 1, -1, CompareMethod.Text) + "," + Strings.Replace(volumentxt.Text, ",", ".", 1, -1, CompareMethod.Text) + ",'Inactivo'," + anotxt.Text + ",'" + marcatxt.Text + "','" + modelotxt.Text + "'," + adicionaltxt.Text + ",'" + gpstxt.Text + "'," + fecha1 + "," + fecha1 + ",'" + MyProject.Forms.Form1_Inicio.nombreusuario.Text + "')";
			Mod_ConeccionBD.BD_Sentencia(sQL);
			limpiar_campos();
			patentetxt.BackColor = Color.White;
			tarifatxt.BackColor = Color.White;
			pesotxt.BackColor = Color.White;
			volumentxt.BackColor = Color.White;
			anotxt.BackColor = Color.White;
			vehiculos();
		}
		else
		{
			if (Conversions.ToDouble(numchoftxt.Text) == 0.0)
			{
				estadocombo.Text = "Inactivo";
				dispocombo.Text = "No";
			}
			if (Operators.CompareString(nomchoftxt.Text, "Sin Chofer Asignado", TextCompare: true) == 0)
			{
				estadocombo.Text = "Inactivo";
				dispocombo.Text = "No";
			}
			string sQL2 = ("UPDATE Vehiculos SET Numero=" + numchoftxt.Text + ", Patente='" + patentetxt.Text + "',Chofer='" + nomchoftxt.Text + "',Disponible='" + dispocombo.Text + "', Categoria=" + catecombo.Text + ",Volumen=" + Strings.Replace(volumentxt.Text, ",", ".", 1, -1, CompareMethod.Text) + ",Peso=" + Strings.Replace(pesotxt.Text, ",", ".", 1, -1, CompareMethod.Text) + ",Tarifa=" + Strings.Replace(tarifatxt.Text, ",", ".", 1, -1, CompareMethod.Text) + ",Estado='" + estadocombo.Text + "',Modificacion=" + fecha1 + ",GPS='" + gpstxt.Text + "' Where id=" + idtxt.Text) ?? "";
			Mod_ConeccionBD.BD_Sentencia(sQL2);
			Interaction.MsgBox("Vehiculo Editado");
			limpiar_campos();
			patentetxt.BackColor = Color.White;
			tarifatxt.BackColor = Color.White;
			pesotxt.BackColor = Color.White;
			volumentxt.BackColor = Color.White;
			anotxt.BackColor = Color.White;
			vehiculos();
		}
	}

	private void ToolStripButton1_Click(object sender, EventArgs e)
	{
		Interaction.MsgBox("Seguro desea eliminar el vehiculo");
		string sQL = ("UPDATE Vehiculos SET Estado='Inactivo',Baja=" + fecha1 + ",Disponible='No' WHERE id=" + idtxt.Text) ?? "";
		Mod_ConeccionBD.BD_Sentencia(sQL);
		idtxt.Text = Conversions.ToString(0);
		limpiar_campos();
		vehiculos();
	}

	private void PrintToolStripButton_Click(object sender, EventArgs e)
	{
		Interaction.MsgBox("Imprimir vehiculo");
	}

	private void CutToolStripButton_Click(object sender, EventArgs e)
	{
		Interaction.MsgBox("el contenido se corto");
	}

	private void CopyToolStripButton_Click(object sender, EventArgs e)
	{
		Interaction.MsgBox("se copio correctamente");
	}

	private void PasteToolStripButton_Click(object sender, EventArgs e)
	{
		Interaction.MsgBox("pegar contenido");
	}

	private void HelpToolStripButton_Click(object sender, EventArgs e)
	{
		Interaction.MsgBox("La ayuda no esta disponible en este momento");
	}

	private void vehiculos()
	{
		string sql = "SELECT Numero,Patente,Chofer,Estado,Disponible,Peso,Volumen,GPS,Ano,Marca,Modelo,Categoria,Alta,Baja,Usuario,Adicional,Tarifa,id,Modificacion FROM Vehiculos";
		Mod_Sentencias.cargar_datos_lv(ListView1, sql, vehiculostxt);
	}

	private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
	{
		Selected_item();
		patentetxt.BackColor = Color.White;
		tarifatxt.BackColor = Color.White;
		pesotxt.BackColor = Color.White;
		volumentxt.BackColor = Color.White;
		anotxt.BackColor = Color.White;
	}

	private void Selected_item()
	{
		if (ListView1.SelectedItems.Count > 0)
		{
			int index = ListView1.SelectedIndices[0];
			idtxt.Text = ListView1.Items[index].SubItems[17].Text;
			numchoftxt.Text = ListView1.Items[index].Text;
			patentetxt.Text = ListView1.Items[index].SubItems[1].Text;
			marcatxt.Text = ListView1.Items[index].SubItems[9].Text;
			modelotxt.Text = ListView1.Items[index].SubItems[10].Text;
			anotxt.Text = ListView1.Items[index].SubItems[8].Text;
			pesotxt.Text = ListView1.Items[index].SubItems[5].Text;
			volumentxt.Text = ListView1.Items[index].SubItems[6].Text;
			gpstxt.Text = ListView1.Items[index].SubItems[7].Text;
			nomchoftxt.Text = ListView1.Items[index].SubItems[2].Text;
			estadocombo.Text = ListView1.Items[index].SubItems[3].Text;
			dispocombo.Text = ListView1.Items[index].SubItems[4].Text;
			catecombo.Text = ListView1.Items[index].SubItems[11].Text;
			tarifatxt.Text = ListView1.Items[index].SubItems[16].Text;
			adicionaltxt.Text = ListView1.Items[index].SubItems[15].Text;
			altatxt.Text = ListView1.Items[index].SubItems[12].Text;
			bajatxt.Text = ListView1.Items[index].SubItems[13].Text;
			usuariotxt.Text = ListView1.Items[index].SubItems[14].Text;
			ultimatxt.Text = ListView1.Items[index].SubItems[18].Text;
		}
		ListView1.Refresh();
	}

	private void limpiar_campos()
	{
		idtxt.Text = Conversions.ToString(0);
		patentetxt.Text = "";
		catecombo.SelectedIndex = -1;
		tarifatxt.Text = "";
		pesotxt.Text = "";
		volumentxt.Text = "";
		anotxt.Text = "";
		marcatxt.Text = "";
		modelotxt.Text = "";
		adicionaltxt.Text = "";
		gpstxt.Text = "";
		nomchoftxt.Text = "Sin Chofer Asignado";
		numchoftxt.Text = Conversions.ToString(0);
		catecombo.Text = "";
		estadocombo.Text = "Inactivo";
		dispocombo.Text = "No";
	}

	private void catecombo_SelectedIndexChanged(object sender, EventArgs e)
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		if (Operators.CompareString(catecombo.Text, "", TextCompare: true) != 0)
		{
			try
			{
				string text = ("SELECT Tarifa_fija FROM Categorias WHERE Categoria =" + catecombo.Text) ?? "";
				DataTable dataTable = new DataTable("x");
				MySqlDataAdapter val = new MySqlDataAdapter(text, Mod_Sentencias.cnn);
				((DbDataAdapter)(object)val).Fill(dataTable);
				tarifatxt.Text = Conversions.ToString(dataTable.Rows[0]["Tarifa_fija"]);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Mod_Sentencias.cnn.Close();
				Interaction.MsgBox(ex2.Message);
				ProjectData.ClearProjectError();
			}
		}
	}
}
