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
public class Vehiculos : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("salirbtn")]
	private Button _salirbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button4")]
	private Button _Button4;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("eliminarbtn")]
	private Button _eliminarbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("guardarbtn")]
	private Button _guardarbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ListView1")]
	private ListView _ListView1;

	private string fecha1;

	[field: AccessedThroughProperty("Panel1")]
	internal virtual Panel Panel1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("buscarbtn")]
	internal virtual Button buscarbtn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("unidadestxt")]
	internal virtual Label unidadestxt
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

	[field: AccessedThroughProperty("GroupBox1")]
	internal virtual GroupBox GroupBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel2")]
	internal virtual Panel Panel2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button salirbtn
	{
		[CompilerGenerated]
		get
		{
			return _salirbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = salirbtn_Click;
			Button button = _salirbtn;
			if (button != null)
			{
				button.Click -= value2;
			}
			_salirbtn = value;
			button = _salirbtn;
			if (button != null)
			{
				button.Click += value2;
			}
		}
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

	internal virtual Button eliminarbtn
	{
		[CompilerGenerated]
		get
		{
			return _eliminarbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = eliminarbtn_Click;
			Button button = _eliminarbtn;
			if (button != null)
			{
				button.Click -= value2;
			}
			_eliminarbtn = value;
			button = _eliminarbtn;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button guardarbtn
	{
		[CompilerGenerated]
		get
		{
			return _guardarbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = guardarbtn_Click;
			Button button = _guardarbtn;
			if (button != null)
			{
				button.Click -= value2;
			}
			_guardarbtn = value;
			button = _guardarbtn;
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
			ColumnClickEventHandler value3 = ListView1_ColumnClick;
			ListView listView = _ListView1;
			if (listView != null)
			{
				listView.SelectedIndexChanged -= value2;
				listView.ColumnClick -= value3;
			}
			_ListView1 = value;
			listView = _ListView1;
			if (listView != null)
			{
				listView.SelectedIndexChanged += value2;
				listView.ColumnClick += value3;
			}
		}
	}

	[field: AccessedThroughProperty("gpstxt")]
	internal virtual TextBox gpstxt
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

	[field: AccessedThroughProperty("estadocombo")]
	internal virtual ComboBox estadocombo
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

	[field: AccessedThroughProperty("tarifatxt")]
	internal virtual TextBox tarifatxt
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

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
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

	[field: AccessedThroughProperty("pesolbl")]
	internal virtual Label pesolbl
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

	[field: AccessedThroughProperty("volumentxt")]
	internal virtual TextBox volumentxt
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

	[field: AccessedThroughProperty("categoriacombo")]
	internal virtual ComboBox categoriacombo
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

	[field: AccessedThroughProperty("disponiblecombo")]
	internal virtual ComboBox disponiblecombo
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

	[field: AccessedThroughProperty("chofertxt")]
	internal virtual TextBox chofertxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("choferlbl")]
	internal virtual Label choferlbl
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

	[field: AccessedThroughProperty("numerolbl")]
	internal virtual Label numerolbl
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

	[field: AccessedThroughProperty("idlbl")]
	internal virtual Label idlbl
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("id_")]
	internal virtual ColumnHeader id_
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Numero")]
	internal virtual ColumnHeader Numero
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Categoria")]
	internal virtual ColumnHeader Categoria
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

	[field: AccessedThroughProperty("Disponible")]
	internal virtual ColumnHeader Disponible
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Tarifa")]
	internal virtual ColumnHeader Tarifa
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Peso")]
	internal virtual ColumnHeader Peso
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Volumen")]
	internal virtual ColumnHeader Volumen
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

	[field: AccessedThroughProperty("GPS")]
	internal virtual ColumnHeader GPS
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

	[field: AccessedThroughProperty("TextBox1")]
	internal virtual TextBox TextBox1
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

	[field: AccessedThroughProperty("ColumnHeader1")]
	internal virtual ColumnHeader ColumnHeader1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public Vehiculos()
	{
		base.Load += Vehiculos_Load;
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
		this.Panel1 = new System.Windows.Forms.Panel();
		this.buscarbtn = new System.Windows.Forms.Button();
		this.unidadestxt = new System.Windows.Forms.Label();
		this.unidadeslbl = new System.Windows.Forms.Label();
		this.GroupBox1 = new System.Windows.Forms.GroupBox();
		this.TextBox1 = new System.Windows.Forms.TextBox();
		this.Label3 = new System.Windows.Forms.Label();
		this.ListView1 = new System.Windows.Forms.ListView();
		this.id_ = new System.Windows.Forms.ColumnHeader();
		this.Numero = new System.Windows.Forms.ColumnHeader();
		this.Categoria = new System.Windows.Forms.ColumnHeader();
		this.Chofer = new System.Windows.Forms.ColumnHeader();
		this.Disponible = new System.Windows.Forms.ColumnHeader();
		this.Tarifa = new System.Windows.Forms.ColumnHeader();
		this.Peso = new System.Windows.Forms.ColumnHeader();
		this.Volumen = new System.Windows.Forms.ColumnHeader();
		this.Estado = new System.Windows.Forms.ColumnHeader();
		this.GPS = new System.Windows.Forms.ColumnHeader();
		this.ColumnHeader1 = new System.Windows.Forms.ColumnHeader();
		this.gpstxt = new System.Windows.Forms.TextBox();
		this.gpslbl = new System.Windows.Forms.Label();
		this.estadocombo = new System.Windows.Forms.ComboBox();
		this.estadolbl = new System.Windows.Forms.Label();
		this.tarifatxt = new System.Windows.Forms.TextBox();
		this.tarifalbl = new System.Windows.Forms.Label();
		this.Label2 = new System.Windows.Forms.Label();
		this.pesotxt = new System.Windows.Forms.TextBox();
		this.pesolbl = new System.Windows.Forms.Label();
		this.Label1 = new System.Windows.Forms.Label();
		this.volumentxt = new System.Windows.Forms.TextBox();
		this.volumenlbl = new System.Windows.Forms.Label();
		this.categoriacombo = new System.Windows.Forms.ComboBox();
		this.categorialbl = new System.Windows.Forms.Label();
		this.disponiblecombo = new System.Windows.Forms.ComboBox();
		this.disponiblelbl = new System.Windows.Forms.Label();
		this.chofertxt = new System.Windows.Forms.TextBox();
		this.choferlbl = new System.Windows.Forms.Label();
		this.numerotxt = new System.Windows.Forms.TextBox();
		this.numerolbl = new System.Windows.Forms.Label();
		this.idtxt = new System.Windows.Forms.Label();
		this.idlbl = new System.Windows.Forms.Label();
		this.Panel2 = new System.Windows.Forms.Panel();
		this.CheckBox1 = new System.Windows.Forms.CheckBox();
		this.salirbtn = new System.Windows.Forms.Button();
		this.Button4 = new System.Windows.Forms.Button();
		this.eliminarbtn = new System.Windows.Forms.Button();
		this.guardarbtn = new System.Windows.Forms.Button();
		this.Panel1.SuspendLayout();
		this.GroupBox1.SuspendLayout();
		this.Panel2.SuspendLayout();
		base.SuspendLayout();
		this.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.Panel1.Controls.Add(this.buscarbtn);
		this.Panel1.Controls.Add(this.unidadestxt);
		this.Panel1.Controls.Add(this.unidadeslbl);
		this.Panel1.Location = new System.Drawing.Point(12, 12);
		this.Panel1.Name = "Panel1";
		this.Panel1.Size = new System.Drawing.Size(783, 31);
		this.Panel1.TabIndex = 0;
		this.buscarbtn.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.buscarbtn.Location = new System.Drawing.Point(699, 4);
		this.buscarbtn.Name = "buscarbtn";
		this.buscarbtn.Size = new System.Drawing.Size(75, 23);
		this.buscarbtn.TabIndex = 2;
		this.buscarbtn.Text = "Buscar";
		this.buscarbtn.UseVisualStyleBackColor = true;
		this.unidadestxt.AutoSize = true;
		this.unidadestxt.Location = new System.Drawing.Point(75, 9);
		this.unidadestxt.Name = "unidadestxt";
		this.unidadestxt.Size = new System.Drawing.Size(13, 13);
		this.unidadestxt.TabIndex = 1;
		this.unidadestxt.Text = "0";
		this.unidadeslbl.AutoSize = true;
		this.unidadeslbl.Location = new System.Drawing.Point(14, 9);
		this.unidadeslbl.Name = "unidadeslbl";
		this.unidadeslbl.Size = new System.Drawing.Size(55, 13);
		this.unidadeslbl.TabIndex = 0;
		this.unidadeslbl.Text = "Unidades:";
		this.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.GroupBox1.Controls.Add(this.TextBox1);
		this.GroupBox1.Controls.Add(this.Label3);
		this.GroupBox1.Controls.Add(this.ListView1);
		this.GroupBox1.Controls.Add(this.gpstxt);
		this.GroupBox1.Controls.Add(this.gpslbl);
		this.GroupBox1.Controls.Add(this.estadocombo);
		this.GroupBox1.Controls.Add(this.estadolbl);
		this.GroupBox1.Controls.Add(this.tarifatxt);
		this.GroupBox1.Controls.Add(this.tarifalbl);
		this.GroupBox1.Controls.Add(this.Label2);
		this.GroupBox1.Controls.Add(this.pesotxt);
		this.GroupBox1.Controls.Add(this.pesolbl);
		this.GroupBox1.Controls.Add(this.Label1);
		this.GroupBox1.Controls.Add(this.volumentxt);
		this.GroupBox1.Controls.Add(this.volumenlbl);
		this.GroupBox1.Controls.Add(this.categoriacombo);
		this.GroupBox1.Controls.Add(this.categorialbl);
		this.GroupBox1.Controls.Add(this.disponiblecombo);
		this.GroupBox1.Controls.Add(this.disponiblelbl);
		this.GroupBox1.Controls.Add(this.chofertxt);
		this.GroupBox1.Controls.Add(this.choferlbl);
		this.GroupBox1.Controls.Add(this.numerotxt);
		this.GroupBox1.Controls.Add(this.numerolbl);
		this.GroupBox1.Controls.Add(this.idtxt);
		this.GroupBox1.Controls.Add(this.idlbl);
		this.GroupBox1.Location = new System.Drawing.Point(12, 49);
		this.GroupBox1.Name = "GroupBox1";
		this.GroupBox1.Size = new System.Drawing.Size(764, 373);
		this.GroupBox1.TabIndex = 1;
		this.GroupBox1.TabStop = false;
		this.TextBox1.Location = new System.Drawing.Point(237, 44);
		this.TextBox1.Name = "TextBox1";
		this.TextBox1.Size = new System.Drawing.Size(138, 20);
		this.TextBox1.TabIndex = 23;
		this.Label3.AutoSize = true;
		this.Label3.Location = new System.Drawing.Point(184, 47);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(47, 13);
		this.Label3.TabIndex = 22;
		this.Label3.Text = "Patente:";
		this.ListView1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.ListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[11]
		{
			this.id_, this.Numero, this.Categoria, this.Chofer, this.Disponible, this.Tarifa, this.Peso, this.Volumen, this.Estado, this.GPS,
			this.ColumnHeader1
		});
		this.ListView1.FullRowSelect = true;
		this.ListView1.GridLines = true;
		this.ListView1.Location = new System.Drawing.Point(6, 180);
		this.ListView1.MultiSelect = false;
		this.ListView1.Name = "ListView1";
		this.ListView1.Size = new System.Drawing.Size(750, 187);
		this.ListView1.TabIndex = 3;
		this.ListView1.UseCompatibleStateImageBehavior = false;
		this.ListView1.View = System.Windows.Forms.View.Details;
		this.id_.Text = "Id";
		this.Numero.Text = "Numero";
		this.Categoria.Text = "Categoria";
		this.Chofer.Text = "Chofer";
		this.Chofer.Width = 160;
		this.Disponible.Text = "Disponible";
		this.Tarifa.Text = "Tarifa";
		this.Peso.Text = "Peso";
		this.Volumen.Text = "Volumen";
		this.Estado.Text = "Estado";
		this.GPS.Text = "GPS";
		this.ColumnHeader1.Text = "Patente";
		this.gpstxt.Location = new System.Drawing.Point(459, 137);
		this.gpstxt.Name = "gpstxt";
		this.gpstxt.Size = new System.Drawing.Size(297, 20);
		this.gpstxt.TabIndex = 21;
		this.gpslbl.AutoSize = true;
		this.gpslbl.Location = new System.Drawing.Point(387, 140);
		this.gpslbl.Name = "gpslbl";
		this.gpslbl.Size = new System.Drawing.Size(32, 13);
		this.gpslbl.TabIndex = 20;
		this.gpslbl.Text = "GPS:";
		this.estadocombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.estadocombo.FormattingEnabled = true;
		this.estadocombo.Items.AddRange(new object[2] { "Activo", "Inactivo" });
		this.estadocombo.Location = new System.Drawing.Point(459, 106);
		this.estadocombo.Name = "estadocombo";
		this.estadocombo.Size = new System.Drawing.Size(121, 21);
		this.estadocombo.TabIndex = 19;
		this.estadolbl.AutoSize = true;
		this.estadolbl.Location = new System.Drawing.Point(387, 109);
		this.estadolbl.Name = "estadolbl";
		this.estadolbl.Size = new System.Drawing.Size(43, 13);
		this.estadolbl.TabIndex = 18;
		this.estadolbl.Text = "Estado:";
		this.tarifatxt.Location = new System.Drawing.Point(459, 75);
		this.tarifatxt.Name = "tarifatxt";
		this.tarifatxt.Size = new System.Drawing.Size(100, 20);
		this.tarifatxt.TabIndex = 17;
		this.tarifalbl.AutoSize = true;
		this.tarifalbl.Location = new System.Drawing.Point(387, 78);
		this.tarifalbl.Name = "tarifalbl";
		this.tarifalbl.Size = new System.Drawing.Size(37, 13);
		this.tarifalbl.TabIndex = 16;
		this.tarifalbl.Text = "Tarifa:";
		this.Label2.AutoSize = true;
		this.Label2.Location = new System.Drawing.Point(565, 47);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(24, 13);
		this.Label2.TabIndex = 15;
		this.Label2.Text = "kgs";
		this.pesotxt.Location = new System.Drawing.Point(459, 44);
		this.pesotxt.Name = "pesotxt";
		this.pesotxt.Size = new System.Drawing.Size(100, 20);
		this.pesotxt.TabIndex = 14;
		this.pesolbl.AutoSize = true;
		this.pesolbl.Location = new System.Drawing.Point(387, 47);
		this.pesolbl.Name = "pesolbl";
		this.pesolbl.Size = new System.Drawing.Size(34, 13);
		this.pesolbl.TabIndex = 13;
		this.pesolbl.Text = "Peso:";
		this.Label1.AutoSize = true;
		this.Label1.Location = new System.Drawing.Point(565, 16);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(29, 13);
		this.Label1.TabIndex = 12;
		this.Label1.Text = "mts3";
		this.volumentxt.Location = new System.Drawing.Point(459, 13);
		this.volumentxt.Name = "volumentxt";
		this.volumentxt.Size = new System.Drawing.Size(100, 20);
		this.volumentxt.TabIndex = 11;
		this.volumenlbl.AutoSize = true;
		this.volumenlbl.Location = new System.Drawing.Point(387, 16);
		this.volumenlbl.Name = "volumenlbl";
		this.volumenlbl.Size = new System.Drawing.Size(51, 13);
		this.volumenlbl.TabIndex = 10;
		this.volumenlbl.Text = "Volumen:";
		this.categoriacombo.FormattingEnabled = true;
		this.categoriacombo.Location = new System.Drawing.Point(78, 137);
		this.categoriacombo.Name = "categoriacombo";
		this.categoriacombo.Size = new System.Drawing.Size(121, 21);
		this.categoriacombo.TabIndex = 9;
		this.categorialbl.AutoSize = true;
		this.categorialbl.Location = new System.Drawing.Point(6, 140);
		this.categorialbl.Name = "categorialbl";
		this.categorialbl.Size = new System.Drawing.Size(55, 13);
		this.categorialbl.TabIndex = 8;
		this.categorialbl.Text = "Categoria:";
		this.disponiblecombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.disponiblecombo.FormattingEnabled = true;
		this.disponiblecombo.Items.AddRange(new object[2] { "Si", "No" });
		this.disponiblecombo.Location = new System.Drawing.Point(78, 106);
		this.disponiblecombo.Name = "disponiblecombo";
		this.disponiblecombo.Size = new System.Drawing.Size(121, 21);
		this.disponiblecombo.TabIndex = 7;
		this.disponiblelbl.AutoSize = true;
		this.disponiblelbl.Location = new System.Drawing.Point(6, 109);
		this.disponiblelbl.Name = "disponiblelbl";
		this.disponiblelbl.Size = new System.Drawing.Size(59, 13);
		this.disponiblelbl.TabIndex = 6;
		this.disponiblelbl.Text = "Disponible:";
		this.chofertxt.Location = new System.Drawing.Point(78, 75);
		this.chofertxt.Name = "chofertxt";
		this.chofertxt.Size = new System.Drawing.Size(297, 20);
		this.chofertxt.TabIndex = 5;
		this.choferlbl.AutoSize = true;
		this.choferlbl.Location = new System.Drawing.Point(6, 78);
		this.choferlbl.Name = "choferlbl";
		this.choferlbl.Size = new System.Drawing.Size(41, 13);
		this.choferlbl.TabIndex = 4;
		this.choferlbl.Text = "Chofer:";
		this.numerotxt.Location = new System.Drawing.Point(78, 44);
		this.numerotxt.Name = "numerotxt";
		this.numerotxt.Size = new System.Drawing.Size(100, 20);
		this.numerotxt.TabIndex = 3;
		this.numerolbl.AutoSize = true;
		this.numerolbl.Location = new System.Drawing.Point(6, 47);
		this.numerolbl.Name = "numerolbl";
		this.numerolbl.Size = new System.Drawing.Size(47, 13);
		this.numerolbl.TabIndex = 2;
		this.numerolbl.Text = "Numero:";
		this.idtxt.AutoSize = true;
		this.idtxt.Location = new System.Drawing.Point(81, 16);
		this.idtxt.Name = "idtxt";
		this.idtxt.Size = new System.Drawing.Size(13, 13);
		this.idtxt.TabIndex = 1;
		this.idtxt.Text = "0";
		this.idlbl.AutoSize = true;
		this.idlbl.Location = new System.Drawing.Point(6, 16);
		this.idlbl.Name = "idlbl";
		this.idlbl.Size = new System.Drawing.Size(19, 13);
		this.idlbl.TabIndex = 0;
		this.idlbl.Text = "Id:";
		this.Panel2.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.Panel2.Controls.Add(this.CheckBox1);
		this.Panel2.Controls.Add(this.salirbtn);
		this.Panel2.Controls.Add(this.Button4);
		this.Panel2.Controls.Add(this.eliminarbtn);
		this.Panel2.Controls.Add(this.guardarbtn);
		this.Panel2.Location = new System.Drawing.Point(12, 428);
		this.Panel2.Name = "Panel2";
		this.Panel2.Size = new System.Drawing.Size(452, 30);
		this.Panel2.TabIndex = 2;
		this.CheckBox1.AutoSize = true;
		this.CheckBox1.Location = new System.Drawing.Point(84, 7);
		this.CheckBox1.Name = "CheckBox1";
		this.CheckBox1.Size = new System.Drawing.Size(53, 17);
		this.CheckBox1.TabIndex = 4;
		this.CheckBox1.Text = "Editar";
		this.CheckBox1.UseVisualStyleBackColor = true;
		this.CheckBox1.Visible = false;
		this.salirbtn.Location = new System.Drawing.Point(374, 3);
		this.salirbtn.Name = "salirbtn";
		this.salirbtn.Size = new System.Drawing.Size(75, 23);
		this.salirbtn.TabIndex = 0;
		this.salirbtn.Text = "Salir";
		this.salirbtn.UseVisualStyleBackColor = true;
		this.Button4.Location = new System.Drawing.Point(293, 3);
		this.Button4.Name = "Button4";
		this.Button4.Size = new System.Drawing.Size(75, 23);
		this.Button4.TabIndex = 3;
		this.Button4.Text = "Button4";
		this.Button4.UseVisualStyleBackColor = true;
		this.eliminarbtn.Location = new System.Drawing.Point(212, 3);
		this.eliminarbtn.Name = "eliminarbtn";
		this.eliminarbtn.Size = new System.Drawing.Size(75, 23);
		this.eliminarbtn.TabIndex = 0;
		this.eliminarbtn.Text = "Eliminar";
		this.eliminarbtn.UseVisualStyleBackColor = true;
		this.guardarbtn.Location = new System.Drawing.Point(3, 3);
		this.guardarbtn.Name = "guardarbtn";
		this.guardarbtn.Size = new System.Drawing.Size(75, 23);
		this.guardarbtn.TabIndex = 0;
		this.guardarbtn.Text = "Guardar";
		this.guardarbtn.UseVisualStyleBackColor = true;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(783, 460);
		base.ControlBox = false;
		base.Controls.Add(this.Panel2);
		base.Controls.Add(this.GroupBox1);
		base.Controls.Add(this.Panel1);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
		base.Name = "Vehiculos";
		base.ShowIcon = false;
		this.Text = "Vehiculos";
		this.Panel1.ResumeLayout(false);
		this.Panel1.PerformLayout();
		this.GroupBox1.ResumeLayout(false);
		this.GroupBox1.PerformLayout();
		this.Panel2.ResumeLayout(false);
		this.Panel2.PerformLayout();
		base.ResumeLayout(false);
	}

	private void Vehiculos_Load(object sender, EventArgs e)
	{
		llenar_choferes();
	}

	private void nuevobtn_Click(object sender, EventArgs e)
	{
		Nuevovb nuevovb = MyProject.Forms.Nuevovb;
		nuevovb.tablalbl.Text = "Flota_insert";
		nuevovb.classlbl.Text = "Vehiculos";
		nuevovb.GroupBox1.Text = "Nuevo Vehiculo";
		nuevovb.Label1.Text = "Numero: ";
		nuevovb.Label2.Text = "Categoria: ";
		nuevovb.Label3.Text = "Chofer: ";
		nuevovb.Label4.Text = "Disponible: ";
		nuevovb.Label5.Text = "Tarifa: ";
		nuevovb.Label6.Text = "Peso: ";
		nuevovb.Label7.Text = "Volumen: ";
		nuevovb.Label8.Text = "Estado: ";
		nuevovb.Label9.Text = "GPS: ";
		nuevovb = null;
		MyProject.Forms.Nuevovb.MdiParent = MyProject.Forms.Form1_Inicio;
		MyProject.Forms.Nuevovb.Show();
	}

	private void guardarbtn_Click(object sender, EventArgs e)
	{
		if (Conversions.ToDouble(idtxt.Text) == 0.0)
		{
			string sQL = "INSERT INTO Flota (Numero,Patente, Chofer,Disponible,Categoria,Volumen,Peso,Tarifa,Estado,GPS) VALUES (" + numerotxt.Text + ", '" + TextBox1.Text + "', '" + chofertxt.Text + "','" + disponiblecombo.Text + "'," + categoriacombo.Text + "," + Strings.Replace(volumentxt.Text, ",", ".", 1, -1, CompareMethod.Text) + "," + Strings.Replace(pesotxt.Text, ",", ".", 1, -1, CompareMethod.Text) + "," + Strings.Replace(tarifatxt.Text, ",", ".", 1, -1, CompareMethod.Text) + ",'" + estadocombo.Text + "'," + gpstxt.Text + ")";
			Mod_ConeccionBD.BD_Sentencia(sQL);
			Interaction.MsgBox("Vehiculo Creado");
			clear_campos();
			llenar_choferes();
		}
		else
		{
			string sQL2 = ("UPDATE Flota SET Numero=" + numerotxt.Text + ",Patente='" + TextBox1.Text + "',Chofer='" + chofertxt.Text + "',Disponible='" + disponiblecombo.Text + "',Categoria=" + categoriacombo.Text + ",Volumen=" + Strings.Replace(volumentxt.Text, ",", ".", 1, -1, CompareMethod.Text) + ",Peso=" + Strings.Replace(pesotxt.Text, ",", ".", 1, -1, CompareMethod.Text) + ",Tarifa=" + Strings.Replace(tarifatxt.Text, ",", ".", 1, -1, CompareMethod.Text) + ", Estado='" + estadocombo.Text + "', GPS=" + gpstxt.Text + " Where id=" + idtxt.Text) ?? "";
			Mod_ConeccionBD.BD_Sentencia(sQL2);
			Interaction.MsgBox("Vehiculo Editado");
			clear_campos();
			llenar_choferes();
		}
		idtxt.Text = "0";
	}

	private void eliminarbtn_Click(object sender, EventArgs e)
	{
		string sQL = ("DELETE FROM Flota WHERE id= " + idtxt.Text) ?? "";
		Mod_ConeccionBD.BD_Sentencia(sQL);
		ListView1.Items.Remove(ListView1.SelectedItems[0]);
		clear_campos();
		if (Conversions.ToDouble(unidadestxt.Text) > 0.0)
		{
			unidadestxt.Text = Conversions.ToString(Conversions.ToDouble(unidadestxt.Text) - 1.0);
		}
	}

	private void salirbtn_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
	{
		Selected_item();
	}

	private void Selected_item()
	{
		if (ListView1.SelectedItems.Count > 0)
		{
			int index = ListView1.SelectedIndices[0];
			idtxt.Text = ListView1.Items[index].Text;
			TextBox1.Text = ListView1.Items[index].SubItems[10].Text;
			numerotxt.Text = ListView1.Items[index].SubItems[1].Text;
			chofertxt.Text = ListView1.Items[index].SubItems[3].Text;
			disponiblecombo.Text = ListView1.Items[index].SubItems[4].Text;
			categoriacombo.Text = ListView1.Items[index].SubItems[2].Text;
			volumentxt.Text = ListView1.Items[index].SubItems[7].Text;
			pesotxt.Text = ListView1.Items[index].SubItems[6].Text;
			tarifatxt.Text = ListView1.Items[index].SubItems[5].Text;
			estadocombo.Text = ListView1.Items[index].SubItems[8].Text;
			gpstxt.Text = ListView1.Items[index].SubItems[9].Text;
		}
		ListView1.Refresh();
	}

	private void ListView1_ColumnClick(object sender, ColumnClickEventArgs e)
	{
		Mod_Ordenaclumnas.ordenar_columnas(ListView1, RuntimeHelpers.GetObjectValue(sender), e);
	}

	private void clear_campos()
	{
		idtxt.Text = "";
		TextBox1.Text = "";
		numerotxt.Text = "";
		chofertxt.Text = "";
		disponiblecombo.Text = "";
		categoriacombo.Text = "";
		volumentxt.Text = "";
		pesotxt.Text = "";
		tarifatxt.Text = "";
		estadocombo.Text = "";
		gpstxt.Text = "";
	}

	private void llenar_choferes()
	{
		string sql = "SELECT * FROM Flota";
		Mod_Sentencias.cargar_datos_lv(ListView1, sql, unidadestxt);
	}

	private void Button4_Click(object sender, EventArgs e)
	{
		if (!CheckBox1.Checked)
		{
		}
		idtxt.Text = "0";
	}
}
