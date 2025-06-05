using System;
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
public class Eventuales_form : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ListView1")]
	private ListView _ListView1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("borrarbtn")]
	private Button _borrarbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("posicionarbtn")]
	private Button _posicionarbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("nuevobtn")]
	private Button _nuevobtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("salirbtn")]
	private Button _salirbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("TextBox1")]
	private TextBox _TextBox1;

	private DataSet dt;

	[field: AccessedThroughProperty("GroupBox1")]
	internal virtual GroupBox GroupBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("adicionaltxt")]
	internal virtual Label adicionaltxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("adicionalcombo")]
	internal virtual ComboBox adicionalcombo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("codigopostaltxt")]
	internal virtual TextBox codigopostaltxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("localidadtxt")]
	internal virtual TextBox localidadtxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("domiciliotxt")]
	internal virtual TextBox domiciliotxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("zonatxt")]
	internal virtual Label zonatxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("zonacombo")]
	internal virtual ComboBox zonacombo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("evetxt")]
	internal virtual Label evetxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("clientetxt")]
	internal virtual TextBox clientetxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("longitudlbl")]
	internal virtual Label longitudlbl
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("latitudlbl")]
	internal virtual Label latitudlbl
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("normalizadalbl")]
	internal virtual Label normalizadalbl
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("sublbl")]
	internal virtual Label sublbl
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("prioridadlbl")]
	internal virtual Label prioridadlbl
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

	[field: AccessedThroughProperty("codigopostallbl")]
	internal virtual Label codigopostallbl
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

	[field: AccessedThroughProperty("domiciliolbl")]
	internal virtual Label domiciliolbl
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("zonalbl")]
	internal virtual Label zonalbl
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("eventuallbl")]
	internal virtual Label eventuallbl
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

	[field: AccessedThroughProperty("usuariotxt")]
	internal virtual Label usuariotxt
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

	[field: AccessedThroughProperty("fechatxt")]
	internal virtual Label fechatxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ultimalbl")]
	internal virtual Label ultimalbl
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("longitudtxt")]
	internal virtual TextBox longitudtxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("latitudtxt")]
	internal virtual TextBox latitudtxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("normalizadatxt")]
	internal virtual TextBox normalizadatxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("subcuentatxt")]
	internal virtual TextBox subcuentatxt
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

	[field: AccessedThroughProperty("prioridadcombo")]
	internal virtual ComboBox prioridadcombo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("guardarbtn")]
	internal virtual Button guardarbtn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button borrarbtn
	{
		[CompilerGenerated]
		get
		{
			return _borrarbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = borrarbtn_Click;
			Button button = _borrarbtn;
			if (button != null)
			{
				button.Click -= value2;
			}
			_borrarbtn = value;
			button = _borrarbtn;
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

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button posicionarbtn
	{
		[CompilerGenerated]
		get
		{
			return _posicionarbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = posicionarbtn_Click;
			Button button = _posicionarbtn;
			if (button != null)
			{
				button.Click -= value2;
			}
			_posicionarbtn = value;
			button = _posicionarbtn;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button nuevobtn
	{
		[CompilerGenerated]
		get
		{
			return _nuevobtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = nuevobtn_Click;
			Button button = _nuevobtn;
			if (button != null)
			{
				button.Click -= value2;
			}
			_nuevobtn = value;
			button = _nuevobtn;
			if (button != null)
			{
				button.Click += value2;
			}
		}
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
			TextBox textBox = _TextBox1;
			if (textBox != null)
			{
				textBox.TextChanged -= value2;
			}
			_TextBox1 = value;
			textBox = _TextBox1;
			if (textBox != null)
			{
				textBox.TextChanged += value2;
			}
		}
	}

	public Eventuales_form()
	{
		base.Load += Eventuales_Load;
		dt = new DataSet();
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
		this.prioridadcombo = new System.Windows.Forms.ComboBox();
		this.usuariotxt = new System.Windows.Forms.Label();
		this.usuariolbl = new System.Windows.Forms.Label();
		this.fechatxt = new System.Windows.Forms.Label();
		this.ultimalbl = new System.Windows.Forms.Label();
		this.longitudtxt = new System.Windows.Forms.TextBox();
		this.latitudtxt = new System.Windows.Forms.TextBox();
		this.normalizadatxt = new System.Windows.Forms.TextBox();
		this.subcuentatxt = new System.Windows.Forms.TextBox();
		this.adicionaltxt = new System.Windows.Forms.Label();
		this.adicionalcombo = new System.Windows.Forms.ComboBox();
		this.codigopostaltxt = new System.Windows.Forms.TextBox();
		this.localidadtxt = new System.Windows.Forms.TextBox();
		this.domiciliotxt = new System.Windows.Forms.TextBox();
		this.zonatxt = new System.Windows.Forms.Label();
		this.zonacombo = new System.Windows.Forms.ComboBox();
		this.evetxt = new System.Windows.Forms.Label();
		this.clientetxt = new System.Windows.Forms.TextBox();
		this.longitudlbl = new System.Windows.Forms.Label();
		this.latitudlbl = new System.Windows.Forms.Label();
		this.normalizadalbl = new System.Windows.Forms.Label();
		this.sublbl = new System.Windows.Forms.Label();
		this.prioridadlbl = new System.Windows.Forms.Label();
		this.adicionallbl = new System.Windows.Forms.Label();
		this.codigopostallbl = new System.Windows.Forms.Label();
		this.localidadlbl = new System.Windows.Forms.Label();
		this.domiciliolbl = new System.Windows.Forms.Label();
		this.zonalbl = new System.Windows.Forms.Label();
		this.eventuallbl = new System.Windows.Forms.Label();
		this.clientelbl = new System.Windows.Forms.Label();
		this.ListView1 = new System.Windows.Forms.ListView();
		this.guardarbtn = new System.Windows.Forms.Button();
		this.borrarbtn = new System.Windows.Forms.Button();
		this.Label2 = new System.Windows.Forms.Label();
		this.Label3 = new System.Windows.Forms.Label();
		this.posicionarbtn = new System.Windows.Forms.Button();
		this.nuevobtn = new System.Windows.Forms.Button();
		this.salirbtn = new System.Windows.Forms.Button();
		this.TextBox1 = new System.Windows.Forms.TextBox();
		this.GroupBox1.SuspendLayout();
		base.SuspendLayout();
		this.GroupBox1.Controls.Add(this.prioridadcombo);
		this.GroupBox1.Controls.Add(this.usuariotxt);
		this.GroupBox1.Controls.Add(this.usuariolbl);
		this.GroupBox1.Controls.Add(this.fechatxt);
		this.GroupBox1.Controls.Add(this.ultimalbl);
		this.GroupBox1.Controls.Add(this.longitudtxt);
		this.GroupBox1.Controls.Add(this.latitudtxt);
		this.GroupBox1.Controls.Add(this.normalizadatxt);
		this.GroupBox1.Controls.Add(this.subcuentatxt);
		this.GroupBox1.Controls.Add(this.adicionaltxt);
		this.GroupBox1.Controls.Add(this.adicionalcombo);
		this.GroupBox1.Controls.Add(this.codigopostaltxt);
		this.GroupBox1.Controls.Add(this.localidadtxt);
		this.GroupBox1.Controls.Add(this.domiciliotxt);
		this.GroupBox1.Controls.Add(this.zonatxt);
		this.GroupBox1.Controls.Add(this.zonacombo);
		this.GroupBox1.Controls.Add(this.evetxt);
		this.GroupBox1.Controls.Add(this.clientetxt);
		this.GroupBox1.Controls.Add(this.longitudlbl);
		this.GroupBox1.Controls.Add(this.latitudlbl);
		this.GroupBox1.Controls.Add(this.normalizadalbl);
		this.GroupBox1.Controls.Add(this.sublbl);
		this.GroupBox1.Controls.Add(this.prioridadlbl);
		this.GroupBox1.Controls.Add(this.adicionallbl);
		this.GroupBox1.Controls.Add(this.codigopostallbl);
		this.GroupBox1.Controls.Add(this.localidadlbl);
		this.GroupBox1.Controls.Add(this.domiciliolbl);
		this.GroupBox1.Controls.Add(this.zonalbl);
		this.GroupBox1.Controls.Add(this.eventuallbl);
		this.GroupBox1.Controls.Add(this.clientelbl);
		this.GroupBox1.Location = new System.Drawing.Point(12, 12);
		this.GroupBox1.Name = "GroupBox1";
		this.GroupBox1.Size = new System.Drawing.Size(446, 511);
		this.GroupBox1.TabIndex = 0;
		this.GroupBox1.TabStop = false;
		this.GroupBox1.Text = "Seleccion:";
		this.prioridadcombo.AutoCompleteCustomSource.AddRange(new string[11]
		{
			"0", "1", "2", "3", "4", "5", "6", "7", "8", "9",
			"10"
		});
		this.prioridadcombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.prioridadcombo.FormattingEnabled = true;
		this.prioridadcombo.Items.AddRange(new object[12]
		{
			"0", "1", "2", "3", "4", "5", "6", "7", "8", "9",
			"10", ""
		});
		this.prioridadcombo.Location = new System.Drawing.Point(86, 268);
		this.prioridadcombo.Name = "prioridadcombo";
		this.prioridadcombo.Size = new System.Drawing.Size(62, 21);
		this.prioridadcombo.TabIndex = 30;
		this.usuariotxt.AutoSize = true;
		this.usuariotxt.Location = new System.Drawing.Point(61, 475);
		this.usuariotxt.Name = "usuariotxt";
		this.usuariotxt.Size = new System.Drawing.Size(36, 13);
		this.usuariotxt.TabIndex = 29;
		this.usuariotxt.Text = "Admin";
		this.usuariolbl.AutoSize = true;
		this.usuariolbl.Location = new System.Drawing.Point(6, 475);
		this.usuariolbl.Name = "usuariolbl";
		this.usuariolbl.Size = new System.Drawing.Size(46, 13);
		this.usuariolbl.TabIndex = 28;
		this.usuariolbl.Text = "Usuario:";
		this.fechatxt.AutoSize = true;
		this.fechatxt.Location = new System.Drawing.Point(122, 446);
		this.fechatxt.Name = "fechatxt";
		this.fechatxt.Size = new System.Drawing.Size(65, 13);
		this.fechatxt.TabIndex = 27;
		this.fechatxt.Text = "19/09/2014";
		this.ultimalbl.AutoSize = true;
		this.ultimalbl.Location = new System.Drawing.Point(6, 446);
		this.ultimalbl.Name = "ultimalbl";
		this.ultimalbl.Size = new System.Drawing.Size(102, 13);
		this.ultimalbl.TabIndex = 26;
		this.ultimalbl.Text = "Ultima Modificacion:";
		this.longitudtxt.Location = new System.Drawing.Point(86, 408);
		this.longitudtxt.Name = "longitudtxt";
		this.longitudtxt.Size = new System.Drawing.Size(180, 20);
		this.longitudtxt.TabIndex = 25;
		this.latitudtxt.Location = new System.Drawing.Point(86, 373);
		this.latitudtxt.Name = "latitudtxt";
		this.latitudtxt.Size = new System.Drawing.Size(180, 20);
		this.latitudtxt.TabIndex = 24;
		this.normalizadatxt.Location = new System.Drawing.Point(86, 338);
		this.normalizadatxt.Name = "normalizadatxt";
		this.normalizadatxt.Size = new System.Drawing.Size(344, 20);
		this.normalizadatxt.TabIndex = 23;
		this.subcuentatxt.Location = new System.Drawing.Point(86, 303);
		this.subcuentatxt.Name = "subcuentatxt";
		this.subcuentatxt.Size = new System.Drawing.Size(100, 20);
		this.subcuentatxt.TabIndex = 22;
		this.adicionaltxt.AutoSize = true;
		this.adicionaltxt.Location = new System.Drawing.Point(245, 236);
		this.adicionaltxt.Name = "adicionaltxt";
		this.adicionaltxt.Size = new System.Drawing.Size(54, 13);
		this.adicionaltxt.TabIndex = 20;
		this.adicionaltxt.Text = "No Posee";
		this.adicionalcombo.FormattingEnabled = true;
		this.adicionalcombo.Location = new System.Drawing.Point(86, 233);
		this.adicionalcombo.Name = "adicionalcombo";
		this.adicionalcombo.Size = new System.Drawing.Size(121, 21);
		this.adicionalcombo.TabIndex = 19;
		this.codigopostaltxt.Location = new System.Drawing.Point(87, 198);
		this.codigopostaltxt.Name = "codigopostaltxt";
		this.codigopostaltxt.Size = new System.Drawing.Size(100, 20);
		this.codigopostaltxt.TabIndex = 18;
		this.localidadtxt.Location = new System.Drawing.Point(87, 163);
		this.localidadtxt.Name = "localidadtxt";
		this.localidadtxt.Size = new System.Drawing.Size(344, 20);
		this.localidadtxt.TabIndex = 17;
		this.domiciliotxt.Location = new System.Drawing.Point(86, 128);
		this.domiciliotxt.Name = "domiciliotxt";
		this.domiciliotxt.Size = new System.Drawing.Size(344, 20);
		this.domiciliotxt.TabIndex = 16;
		this.zonatxt.AutoSize = true;
		this.zonatxt.Location = new System.Drawing.Point(84, 96);
		this.zonatxt.Name = "zonatxt";
		this.zonatxt.Size = new System.Drawing.Size(50, 13);
		this.zonatxt.TabIndex = 15;
		this.zonatxt.Text = "Sin Zona";
		this.zonacombo.FormattingEnabled = true;
		this.zonacombo.Location = new System.Drawing.Point(345, 93);
		this.zonacombo.Name = "zonacombo";
		this.zonacombo.Size = new System.Drawing.Size(86, 21);
		this.zonacombo.TabIndex = 14;
		this.evetxt.AutoSize = true;
		this.evetxt.Location = new System.Drawing.Point(84, 61);
		this.evetxt.Name = "evetxt";
		this.evetxt.Size = new System.Drawing.Size(13, 13);
		this.evetxt.TabIndex = 13;
		this.evetxt.Text = "0";
		this.clientetxt.Location = new System.Drawing.Point(86, 23);
		this.clientetxt.Name = "clientetxt";
		this.clientetxt.Size = new System.Drawing.Size(344, 20);
		this.clientetxt.TabIndex = 12;
		this.longitudlbl.AutoSize = true;
		this.longitudlbl.Location = new System.Drawing.Point(6, 411);
		this.longitudlbl.Name = "longitudlbl";
		this.longitudlbl.Size = new System.Drawing.Size(51, 13);
		this.longitudlbl.TabIndex = 11;
		this.longitudlbl.Text = "Longitud:";
		this.latitudlbl.AutoSize = true;
		this.latitudlbl.Location = new System.Drawing.Point(6, 376);
		this.latitudlbl.Name = "latitudlbl";
		this.latitudlbl.Size = new System.Drawing.Size(42, 13);
		this.latitudlbl.TabIndex = 10;
		this.latitudlbl.Text = "Latitud:";
		this.normalizadalbl.AutoSize = true;
		this.normalizadalbl.Location = new System.Drawing.Point(6, 341);
		this.normalizadalbl.Name = "normalizadalbl";
		this.normalizadalbl.Size = new System.Drawing.Size(68, 13);
		this.normalizadalbl.TabIndex = 9;
		this.normalizadalbl.Text = "Normalizada:";
		this.sublbl.AutoSize = true;
		this.sublbl.Location = new System.Drawing.Point(6, 306);
		this.sublbl.Name = "sublbl";
		this.sublbl.Size = new System.Drawing.Size(63, 13);
		this.sublbl.TabIndex = 8;
		this.sublbl.Text = "SubCuenta:";
		this.prioridadlbl.AutoSize = true;
		this.prioridadlbl.Location = new System.Drawing.Point(6, 271);
		this.prioridadlbl.Name = "prioridadlbl";
		this.prioridadlbl.Size = new System.Drawing.Size(51, 13);
		this.prioridadlbl.TabIndex = 7;
		this.prioridadlbl.Text = "Prioridad:";
		this.adicionallbl.AutoSize = true;
		this.adicionallbl.Location = new System.Drawing.Point(6, 236);
		this.adicionallbl.Name = "adicionallbl";
		this.adicionallbl.Size = new System.Drawing.Size(53, 13);
		this.adicionallbl.TabIndex = 6;
		this.adicionallbl.Text = "Adicional:";
		this.codigopostallbl.AutoSize = true;
		this.codigopostallbl.Location = new System.Drawing.Point(6, 201);
		this.codigopostallbl.Name = "codigopostallbl";
		this.codigopostallbl.Size = new System.Drawing.Size(75, 13);
		this.codigopostallbl.TabIndex = 5;
		this.codigopostallbl.Text = "Codigo Postal:";
		this.localidadlbl.AutoSize = true;
		this.localidadlbl.Location = new System.Drawing.Point(6, 166);
		this.localidadlbl.Name = "localidadlbl";
		this.localidadlbl.Size = new System.Drawing.Size(56, 13);
		this.localidadlbl.TabIndex = 4;
		this.localidadlbl.Text = "Localidad:";
		this.domiciliolbl.AutoSize = true;
		this.domiciliolbl.Location = new System.Drawing.Point(6, 131);
		this.domiciliolbl.Name = "domiciliolbl";
		this.domiciliolbl.Size = new System.Drawing.Size(52, 13);
		this.domiciliolbl.TabIndex = 3;
		this.domiciliolbl.Text = "Domicilio:";
		this.zonalbl.AutoSize = true;
		this.zonalbl.Location = new System.Drawing.Point(6, 96);
		this.zonalbl.Name = "zonalbl";
		this.zonalbl.Size = new System.Drawing.Size(35, 13);
		this.zonalbl.TabIndex = 2;
		this.zonalbl.Text = "Zona:";
		this.eventuallbl.AutoSize = true;
		this.eventuallbl.Location = new System.Drawing.Point(6, 61);
		this.eventuallbl.Name = "eventuallbl";
		this.eventuallbl.Size = new System.Drawing.Size(52, 13);
		this.eventuallbl.TabIndex = 1;
		this.eventuallbl.Text = "Eventual:";
		this.clientelbl.AutoSize = true;
		this.clientelbl.Location = new System.Drawing.Point(6, 26);
		this.clientelbl.Name = "clientelbl";
		this.clientelbl.Size = new System.Drawing.Size(42, 13);
		this.clientelbl.TabIndex = 0;
		this.clientelbl.Text = "Cliente:";
		this.ListView1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.ListView1.Location = new System.Drawing.Point(464, 62);
		this.ListView1.Name = "ListView1";
		this.ListView1.Size = new System.Drawing.Size(399, 424);
		this.ListView1.TabIndex = 1;
		this.ListView1.UseCompatibleStateImageBehavior = false;
		this.guardarbtn.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.guardarbtn.Location = new System.Drawing.Point(707, 33);
		this.guardarbtn.Name = "guardarbtn";
		this.guardarbtn.Size = new System.Drawing.Size(75, 23);
		this.guardarbtn.TabIndex = 2;
		this.guardarbtn.Text = "Guardar";
		this.guardarbtn.UseVisualStyleBackColor = true;
		this.borrarbtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		this.borrarbtn.Location = new System.Drawing.Point(545, 500);
		this.borrarbtn.Name = "borrarbtn";
		this.borrarbtn.Size = new System.Drawing.Size(75, 23);
		this.borrarbtn.TabIndex = 3;
		this.borrarbtn.Text = "Borrar";
		this.borrarbtn.UseVisualStyleBackColor = true;
		this.Label2.AutoSize = true;
		this.Label2.Location = new System.Drawing.Point(461, 38);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(95, 13);
		this.Label2.TabIndex = 4;
		this.Label2.Text = "Cantidad de Items:";
		this.Label3.AutoSize = true;
		this.Label3.Location = new System.Drawing.Point(562, 38);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(13, 13);
		this.Label3.TabIndex = 5;
		this.Label3.Text = "0";
		this.posicionarbtn.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.posicionarbtn.Location = new System.Drawing.Point(788, 33);
		this.posicionarbtn.Name = "posicionarbtn";
		this.posicionarbtn.Size = new System.Drawing.Size(75, 23);
		this.posicionarbtn.TabIndex = 7;
		this.posicionarbtn.Text = "Posicionar";
		this.posicionarbtn.UseVisualStyleBackColor = true;
		this.nuevobtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		this.nuevobtn.Location = new System.Drawing.Point(464, 500);
		this.nuevobtn.Name = "nuevobtn";
		this.nuevobtn.Size = new System.Drawing.Size(75, 23);
		this.nuevobtn.TabIndex = 8;
		this.nuevobtn.Text = "Nuevo";
		this.nuevobtn.UseVisualStyleBackColor = true;
		this.salirbtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		this.salirbtn.Location = new System.Drawing.Point(777, 500);
		this.salirbtn.Name = "salirbtn";
		this.salirbtn.Size = new System.Drawing.Size(75, 23);
		this.salirbtn.TabIndex = 9;
		this.salirbtn.Text = "Salir";
		this.salirbtn.UseVisualStyleBackColor = true;
		this.TextBox1.Location = new System.Drawing.Point(464, 12);
		this.TextBox1.Name = "TextBox1";
		this.TextBox1.Size = new System.Drawing.Size(399, 20);
		this.TextBox1.TabIndex = 10;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(865, 527);
		base.ControlBox = false;
		base.Controls.Add(this.TextBox1);
		base.Controls.Add(this.salirbtn);
		base.Controls.Add(this.nuevobtn);
		base.Controls.Add(this.posicionarbtn);
		base.Controls.Add(this.Label3);
		base.Controls.Add(this.Label2);
		base.Controls.Add(this.borrarbtn);
		base.Controls.Add(this.guardarbtn);
		base.Controls.Add(this.ListView1);
		base.Controls.Add(this.GroupBox1);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
		base.Name = "Eventuales_form";
		base.ShowIcon = false;
		base.ShowInTaskbar = false;
		this.Text = "Eventuales";
		this.GroupBox1.ResumeLayout(false);
		this.GroupBox1.PerformLayout();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private void Eventuales_Load(object sender, EventArgs e)
	{
		prioridadcombo.SelectedIndex = 0;
		string sql = "SELECT * FROM Eventuales";
		Eventuales_Load(sql);
	}

	public void Eventuales_Load(string sql)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		checked
		{
			try
			{
				Mod_Sentencias.cnn.Open();
				MySqlCommand val = new MySqlCommand();
				MySqlCommand val2 = val;
				val2.CommandType = CommandType.Text;
				val2.CommandText = sql;
				val2.Connection = Mod_Sentencias.cnn;
				val2 = null;
				MySqlDataAdapter val3 = new MySqlDataAdapter();
				val3.SelectCommand = val;
				((DbDataAdapter)(object)val3).Fill(dt, "Tabla");
				ListView listView = ListView1;
				listView.Items.Clear();
				listView.Columns.Clear();
				listView.View = View.Details;
				listView.GridLines = true;
				listView.FullRowSelect = true;
				int num = dt.Tables["tabla"].Columns.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					listView.Columns.Add(dt.Tables["tabla"].Columns[i].Caption);
				}
				listView = null;
				DataTable dataTable = dt.Tables["tabla"];
				int num2 = dataTable.Rows.Count - 1;
				for (int j = 0; j <= num2; j++)
				{
					ListViewItem listViewItem = new ListViewItem(dataTable.Rows[j][0].ToString());
					int num3 = dataTable.Columns.Count - 1;
					for (int k = 1; k <= num3; k++)
					{
						listViewItem.SubItems.Add(dataTable.Rows[j][k].ToString());
					}
					ListView1.Items.Add(listViewItem);
				}
				dataTable = null;
				ListView listView2 = ListView1;
				int num4 = dt.Tables["tabla"].Columns.Count - 1;
				for (int l = 0; l <= num4; l++)
				{
					listView2.AutoResizeColumn(l, ColumnHeaderAutoResizeStyle.ColumnContent);
				}
				listView2 = null;
				Label3.Text = Conversions.ToString(ListView1.Items.Count);
				Mod_Sentencias.cnn.Close();
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

	private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
	{
		Selected_item();
	}

	private void Selected_item()
	{
		if (ListView1.SelectedItems.Count > 0)
		{
			int index = ListView1.SelectedIndices[0];
			clientetxt.Text = ListView1.Items[index].Text;
			evetxt.Text = ListView1.Items[index].SubItems[1].Text;
			zonacombo.Text = ListView1.Items[index].SubItems[2].Text;
			domiciliotxt.Text = ListView1.Items[index].SubItems[3].Text;
			localidadtxt.Text = ListView1.Items[index].SubItems[4].Text;
			codigopostaltxt.Text = ListView1.Items[index].SubItems[5].Text;
			adicionaltxt.Text = ListView1.Items[index].SubItems[6].Text;
			prioridadcombo.Text = ListView1.Items[index].SubItems[7].Text;
			subcuentatxt.Text = ListView1.Items[index].SubItems[8].Text;
			normalizadatxt.Text = ListView1.Items[index].SubItems[9].Text;
			latitudtxt.Text = ListView1.Items[index].SubItems[10].Text;
			longitudtxt.Text = ListView1.Items[index].SubItems[11].Text;
			fechatxt.Text = ListView1.Items[index].SubItems[13].Text;
			usuariotxt.Text = ListView1.Items[index].SubItems[14].Text;
		}
		ListView1.Refresh();
	}

	private void ListView1_ColumnClick(object sender, ColumnClickEventArgs e)
	{
		Mod_Ordenaclumnas.ordenar_columnas(ListView1, RuntimeHelpers.GetObjectValue(sender), e);
	}

	private void borrarbtn_Click(object sender, EventArgs e)
	{
		int i = ListView1.SelectedIndices[0];
		borrar_dato(i);
	}

	private void borrar_dato(int i)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		try
		{
			string text = ("DELETE FROM Eventuales WHERE Eventual= " + evetxt.Text) ?? "";
			MySqlCommand val = new MySqlCommand(text, Mod_Sentencias.cnn);
			Mod_Sentencias.cnn.Open();
			val.ExecuteNonQuery();
			Mod_Sentencias.cnn.Close();
			limpiar_datos();
			ListView1.Items[i].Remove();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox(ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void limpiar_datos()
	{
		clientetxt.Text = "";
		evetxt.Text = Conversions.ToString(0);
		zonacombo.Text = "";
		domiciliotxt.Text = "";
		localidadtxt.Text = "";
		codigopostaltxt.Text = "";
		adicionaltxt.Text = Conversions.ToString(0);
		prioridadcombo.Text = Conversions.ToString(0);
		subcuentatxt.Text = "";
		normalizadatxt.Text = "";
		latitudtxt.Text = "";
		longitudtxt.Text = "";
		fechatxt.Text = "";
		usuariotxt.Text = "";
	}

	private void posicionarbtn_Click(object sender, EventArgs e)
	{
		Posicionar posicionar = MyProject.Forms.Posicionar;
		string sql = ("SELECT Cliente,Domicilio,Localidad,Eventual,Zona From Eventuales WHERE Eventual=" + evetxt.Text) ?? "";
		Mod_Sentencias.cargar_datos_lv(posicionar.ListView1, sql, posicionar.Label2);
		posicionar = null;
		MyProject.Forms.Posicionar.MdiParent = MyProject.Forms.Form1_Inicio;
		MyProject.Forms.Posicionar.Show();
	}

	private void nuevobtn_Click(object sender, EventArgs e)
	{
		Nuevovb nuevovb = MyProject.Forms.Nuevovb;
		nuevovb.tablalbl.Text = "Eventual_insert";
		nuevovb.classlbl.Text = "Eventuales";
		nuevovb.GroupBox1.Text = "Nuevo Eventual";
		nuevovb.Label1.Text = "Cliente: ";
		nuevovb.Label2.Text = "Eventual: ";
		nuevovb.Label3.Text = "Zona: ";
		nuevovb.Label4.Text = "Domicilio: ";
		nuevovb.Label5.Text = "Localidad: ";
		nuevovb.Label6.Text = "CP: ";
		nuevovb.Label7.Text = "Adicional: ";
		nuevovb.Label8.Text = "Prioridad: ";
		nuevovb.Label9.Text = "Franja: ";
		nuevovb = null;
		MyProject.Forms.Nuevovb.Show();
	}

	private void salirbtn_Click(object sender, EventArgs e)
	{
		try
		{
			Mod_Sentencias.cnn.Close();
			Close();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Close();
			ProjectData.ClearProjectError();
		}
	}

	private void TextBox1_TextChanged(object sender, EventArgs e)
	{
		if (Operators.CompareString(TextBox1.Text, "", TextCompare: true) == 0)
		{
			return;
		}
		DataRow[] array = dt.Tables["Tabla"].Select("Cliente  LIKE '" + TextBox1.Text + "%'");
		if (array.Length <= 0)
		{
			return;
		}
		ListView1.Items.Clear();
		DataRow[] array2 = array;
		checked
		{
			foreach (DataRow dataRow in array2)
			{
				ListViewItem listViewItem = new ListViewItem(dataRow[0].ToString());
				int num = dt.Tables["Tabla"].Columns.Count - 1;
				for (int j = 1; j <= num; j++)
				{
					listViewItem.SubItems.Add(dataRow[j].ToString());
				}
				ListView1.Items.Add(listViewItem);
			}
		}
	}
}
