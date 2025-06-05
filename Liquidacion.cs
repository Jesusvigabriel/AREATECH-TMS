using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Hermes.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Hermes;

[DesignerGenerated]
public class Liquidacion : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("BtnConsultar")]
	private Button _BtnConsultar;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("BtnGuardar")]
	private Button _BtnGuardar;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ComboCategoria")]
	private ComboBox _ComboCategoria;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("TxtPuntos")]
	private TextBox _TxtPuntos;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("TxtTarifa")]
	private TextBox _TxtTarifa;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("TxtOtros")]
	private TextBox _TxtOtros;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("TxtAdicional")]
	private TextBox _TxtAdicional;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ListView1")]
	private ListView _ListView1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("RBArea")]
	private RadioButton _RBArea;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("RBEtrans")]
	private RadioButton _RBEtrans;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("RBTelas")]
	private RadioButton _RBTelas;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("RBHilo")]
	private RadioButton _RBHilo;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("BtnRecalcular")]
	private Button _BtnRecalcular;

	private int chofer;

	private int viaje;

	private int categoria;

	private int ventana;

	private double tarifa_fija;

	private double tarifa_final;

	private int puntos;

	private double adicional;

	private double adicionalModelo;

	private double kilos;

	private int bultos;

	private double declarado;

	private double flete;

	private int AP1;

	private int AP2;

	private double VAP1;

	private double VAP2;

	[field: AccessedThroughProperty("GroupBox1")]
	internal virtual GroupBox GroupBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button BtnConsultar
	{
		[CompilerGenerated]
		get
		{
			return _BtnConsultar;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = BtnConsultar_Click;
			Button btnConsultar = _BtnConsultar;
			if (btnConsultar != null)
			{
				btnConsultar.Click -= value2;
			}
			_BtnConsultar = value;
			btnConsultar = _BtnConsultar;
			if (btnConsultar != null)
			{
				btnConsultar.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("LblFecha")]
	internal virtual Label LblFecha
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DTPLiquidacion")]
	internal virtual DateTimePicker DTPLiquidacion
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("LblChofer")]
	internal virtual Label LblChofer
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

	internal virtual Button BtnGuardar
	{
		[CompilerGenerated]
		get
		{
			return _BtnGuardar;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = BtnGuardar_Click;
			Button btnGuardar = _BtnGuardar;
			if (btnGuardar != null)
			{
				btnGuardar.Click -= value2;
			}
			_BtnGuardar = value;
			btnGuardar = _BtnGuardar;
			if (btnGuardar != null)
			{
				btnGuardar.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("BtnSalir")]
	internal virtual Button BtnSalir
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("LblTarifa")]
	internal virtual Label LblTarifa
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ComboBox ComboCategoria
	{
		[CompilerGenerated]
		get
		{
			return _ComboCategoria;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ComboCategoria_SelectedIndexChanged;
			ComboBox comboCategoria = _ComboCategoria;
			if (comboCategoria != null)
			{
				comboCategoria.SelectedIndexChanged -= value2;
			}
			_ComboCategoria = value;
			comboCategoria = _ComboCategoria;
			if (comboCategoria != null)
			{
				comboCategoria.SelectedIndexChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("LblCategoria")]
	internal virtual Label LblCategoria
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TxtNumero")]
	internal virtual TextBox TxtNumero
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("LblNumero")]
	internal virtual Label LblNumero
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual TextBox TxtPuntos
	{
		[CompilerGenerated]
		get
		{
			return _TxtPuntos;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = TxtPuntos_TextChanged;
			TextBox txtPuntos = _TxtPuntos;
			if (txtPuntos != null)
			{
				txtPuntos.TextChanged -= value2;
			}
			_TxtPuntos = value;
			txtPuntos = _TxtPuntos;
			if (txtPuntos != null)
			{
				txtPuntos.TextChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("LblPuntos")]
	internal virtual Label LblPuntos
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual TextBox TxtTarifa
	{
		[CompilerGenerated]
		get
		{
			return _TxtTarifa;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = TxtTarifa_TextChanged;
			TextBox txtTarifa = _TxtTarifa;
			if (txtTarifa != null)
			{
				txtTarifa.TextChanged -= value2;
			}
			_TxtTarifa = value;
			txtTarifa = _TxtTarifa;
			if (txtTarifa != null)
			{
				txtTarifa.TextChanged += value2;
			}
		}
	}

	internal virtual TextBox TxtOtros
	{
		[CompilerGenerated]
		get
		{
			return _TxtOtros;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = TxtOtros_TextChanged;
			TextBox txtOtros = _TxtOtros;
			if (txtOtros != null)
			{
				txtOtros.TextChanged -= value2;
			}
			_TxtOtros = value;
			txtOtros = _TxtOtros;
			if (txtOtros != null)
			{
				txtOtros.TextChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("LblOtro")]
	internal virtual Label LblOtro
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TxtFinal")]
	internal virtual TextBox TxtFinal
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("LblTotal")]
	internal virtual Label LblTotal
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual TextBox TxtAdicional
	{
		[CompilerGenerated]
		get
		{
			return _TxtAdicional;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = TxtAdicional_TextChanged;
			TextBox txtAdicional = _TxtAdicional;
			if (txtAdicional != null)
			{
				txtAdicional.TextChanged -= value2;
			}
			_TxtAdicional = value;
			txtAdicional = _TxtAdicional;
			if (txtAdicional != null)
			{
				txtAdicional.TextChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("LblAdicional")]
	internal virtual Label LblAdicional
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
			EventHandler value3 = ListView1_SelectedIndexChanged;
			EventHandler value4 = ListView1_DoubleClick;
			ListView listView = _ListView1;
			if (listView != null)
			{
				listView.ColumnClick -= value2;
				listView.SelectedIndexChanged -= value3;
				listView.DoubleClick -= value4;
			}
			_ListView1 = value;
			listView = _ListView1;
			if (listView != null)
			{
				listView.ColumnClick += value2;
				listView.SelectedIndexChanged += value3;
				listView.DoubleClick += value4;
			}
		}
	}

	[field: AccessedThroughProperty("LblItems")]
	internal virtual Label LblItems
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual RadioButton RBArea
	{
		[CompilerGenerated]
		get
		{
			return _RBArea;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = RBArea_CheckedChanged;
			RadioButton rBArea = _RBArea;
			if (rBArea != null)
			{
				rBArea.CheckedChanged -= value2;
			}
			_RBArea = value;
			rBArea = _RBArea;
			if (rBArea != null)
			{
				rBArea.CheckedChanged += value2;
			}
		}
	}

	internal virtual RadioButton RBEtrans
	{
		[CompilerGenerated]
		get
		{
			return _RBEtrans;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = RBEtrans_CheckedChanged;
			RadioButton rBEtrans = _RBEtrans;
			if (rBEtrans != null)
			{
				rBEtrans.CheckedChanged -= value2;
			}
			_RBEtrans = value;
			rBEtrans = _RBEtrans;
			if (rBEtrans != null)
			{
				rBEtrans.CheckedChanged += value2;
			}
		}
	}

	internal virtual RadioButton RBTelas
	{
		[CompilerGenerated]
		get
		{
			return _RBTelas;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = RBTelas_CheckedChanged;
			RadioButton rBTelas = _RBTelas;
			if (rBTelas != null)
			{
				rBTelas.CheckedChanged -= value2;
			}
			_RBTelas = value;
			rBTelas = _RBTelas;
			if (rBTelas != null)
			{
				rBTelas.CheckedChanged += value2;
			}
		}
	}

	internal virtual RadioButton RBHilo
	{
		[CompilerGenerated]
		get
		{
			return _RBHilo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = RBHilo_CheckedChanged;
			RadioButton rBHilo = _RBHilo;
			if (rBHilo != null)
			{
				rBHilo.CheckedChanged -= value2;
			}
			_RBHilo = value;
			rBHilo = _RBHilo;
			if (rBHilo != null)
			{
				rBHilo.CheckedChanged += value2;
			}
		}
	}

	internal virtual Button BtnRecalcular
	{
		[CompilerGenerated]
		get
		{
			return _BtnRecalcular;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = BtnRecalcular_Click;
			Button btnRecalcular = _BtnRecalcular;
			if (btnRecalcular != null)
			{
				btnRecalcular.Click -= value2;
			}
			_BtnRecalcular = value;
			btnRecalcular = _BtnRecalcular;
			if (btnRecalcular != null)
			{
				btnRecalcular.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public Liquidacion()
	{
		base.Load += Liquidacion_Load;
		chofer = 0;
		viaje = 0;
		categoria = 0;
		ventana = 0;
		tarifa_fija = 0.0;
		tarifa_final = 0.0;
		puntos = 0;
		adicional = 0.0;
		adicionalModelo = 0.0;
		kilos = 0.0;
		bultos = 0;
		declarado = 0.0;
		flete = 0.0;
		AP1 = 0;
		AP2 = 0;
		VAP1 = 0.0;
		VAP2 = 0.0;
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
		this.BtnConsultar = new System.Windows.Forms.Button();
		this.LblFecha = new System.Windows.Forms.Label();
		this.DTPLiquidacion = new System.Windows.Forms.DateTimePicker();
		this.LblItems = new System.Windows.Forms.Label();
		this.LblChofer = new System.Windows.Forms.Label();
		this.GroupBox2 = new System.Windows.Forms.GroupBox();
		this.BtnRecalcular = new System.Windows.Forms.Button();
		this.RBHilo = new System.Windows.Forms.RadioButton();
		this.RBArea = new System.Windows.Forms.RadioButton();
		this.RBEtrans = new System.Windows.Forms.RadioButton();
		this.RBTelas = new System.Windows.Forms.RadioButton();
		this.TxtOtros = new System.Windows.Forms.TextBox();
		this.LblOtro = new System.Windows.Forms.Label();
		this.TxtFinal = new System.Windows.Forms.TextBox();
		this.LblTotal = new System.Windows.Forms.Label();
		this.TxtAdicional = new System.Windows.Forms.TextBox();
		this.LblAdicional = new System.Windows.Forms.Label();
		this.TxtPuntos = new System.Windows.Forms.TextBox();
		this.LblPuntos = new System.Windows.Forms.Label();
		this.TxtTarifa = new System.Windows.Forms.TextBox();
		this.LblTarifa = new System.Windows.Forms.Label();
		this.ComboCategoria = new System.Windows.Forms.ComboBox();
		this.LblCategoria = new System.Windows.Forms.Label();
		this.TxtNumero = new System.Windows.Forms.TextBox();
		this.LblNumero = new System.Windows.Forms.Label();
		this.BtnGuardar = new System.Windows.Forms.Button();
		this.BtnSalir = new System.Windows.Forms.Button();
		this.GroupBox3 = new System.Windows.Forms.GroupBox();
		this.ListView1 = new System.Windows.Forms.ListView();
		this.Label1 = new System.Windows.Forms.Label();
		this.GroupBox1.SuspendLayout();
		this.GroupBox2.SuspendLayout();
		this.GroupBox3.SuspendLayout();
		base.SuspendLayout();
		this.GroupBox1.Controls.Add(this.Label1);
		this.GroupBox1.Controls.Add(this.BtnConsultar);
		this.GroupBox1.Controls.Add(this.LblFecha);
		this.GroupBox1.Controls.Add(this.DTPLiquidacion);
		this.GroupBox1.Controls.Add(this.LblItems);
		this.GroupBox1.Controls.Add(this.LblChofer);
		this.GroupBox1.Location = new System.Drawing.Point(12, 12);
		this.GroupBox1.Name = "GroupBox1";
		this.GroupBox1.Size = new System.Drawing.Size(754, 61);
		this.GroupBox1.TabIndex = 0;
		this.GroupBox1.TabStop = false;
		this.BtnConsultar.Location = new System.Drawing.Point(673, 20);
		this.BtnConsultar.Name = "BtnConsultar";
		this.BtnConsultar.Size = new System.Drawing.Size(75, 23);
		this.BtnConsultar.TabIndex = 4;
		this.BtnConsultar.Text = "Consultar";
		this.BtnConsultar.UseVisualStyleBackColor = true;
		this.LblFecha.AutoSize = true;
		this.LblFecha.Location = new System.Drawing.Point(335, 25);
		this.LblFecha.Name = "LblFecha";
		this.LblFecha.Size = new System.Drawing.Size(40, 13);
		this.LblFecha.TabIndex = 3;
		this.LblFecha.Text = "Fecha:";
		this.DTPLiquidacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
		this.DTPLiquidacion.Location = new System.Drawing.Point(381, 23);
		this.DTPLiquidacion.Name = "DTPLiquidacion";
		this.DTPLiquidacion.Size = new System.Drawing.Size(100, 20);
		this.DTPLiquidacion.TabIndex = 2;
		this.LblItems.AutoSize = true;
		this.LblItems.Location = new System.Drawing.Point(510, 26);
		this.LblItems.Name = "LblItems";
		this.LblItems.Size = new System.Drawing.Size(39, 13);
		this.LblItems.TabIndex = 16;
		this.LblItems.Text = "Label1";
		this.LblChofer.AutoSize = true;
		this.LblChofer.Location = new System.Drawing.Point(13, 25);
		this.LblChofer.Name = "LblChofer";
		this.LblChofer.Size = new System.Drawing.Size(41, 13);
		this.LblChofer.TabIndex = 1;
		this.LblChofer.Text = "Chofer:";
		this.GroupBox2.Controls.Add(this.BtnRecalcular);
		this.GroupBox2.Controls.Add(this.RBHilo);
		this.GroupBox2.Controls.Add(this.RBArea);
		this.GroupBox2.Controls.Add(this.RBEtrans);
		this.GroupBox2.Controls.Add(this.RBTelas);
		this.GroupBox2.Controls.Add(this.TxtOtros);
		this.GroupBox2.Controls.Add(this.LblOtro);
		this.GroupBox2.Controls.Add(this.TxtFinal);
		this.GroupBox2.Controls.Add(this.LblTotal);
		this.GroupBox2.Controls.Add(this.TxtAdicional);
		this.GroupBox2.Controls.Add(this.LblAdicional);
		this.GroupBox2.Controls.Add(this.TxtPuntos);
		this.GroupBox2.Controls.Add(this.LblPuntos);
		this.GroupBox2.Controls.Add(this.TxtTarifa);
		this.GroupBox2.Controls.Add(this.LblTarifa);
		this.GroupBox2.Controls.Add(this.ComboCategoria);
		this.GroupBox2.Controls.Add(this.LblCategoria);
		this.GroupBox2.Controls.Add(this.TxtNumero);
		this.GroupBox2.Controls.Add(this.LblNumero);
		this.GroupBox2.Controls.Add(this.BtnGuardar);
		this.GroupBox2.Controls.Add(this.BtnSalir);
		this.GroupBox2.Location = new System.Drawing.Point(772, 12);
		this.GroupBox2.Name = "GroupBox2";
		this.GroupBox2.Size = new System.Drawing.Size(167, 476);
		this.GroupBox2.TabIndex = 1;
		this.GroupBox2.TabStop = false;
		this.BtnRecalcular.Location = new System.Drawing.Point(6, 348);
		this.BtnRecalcular.Name = "BtnRecalcular";
		this.BtnRecalcular.Size = new System.Drawing.Size(151, 23);
		this.BtnRecalcular.TabIndex = 21;
		this.BtnRecalcular.Text = "Recalcular";
		this.BtnRecalcular.UseVisualStyleBackColor = true;
		this.BtnRecalcular.Visible = false;
		this.RBHilo.AutoSize = true;
		this.RBHilo.Location = new System.Drawing.Point(10, 307);
		this.RBHilo.Name = "RBHilo";
		this.RBHilo.Size = new System.Drawing.Size(43, 17);
		this.RBHilo.TabIndex = 20;
		this.RBHilo.TabStop = true;
		this.RBHilo.Text = "Hilo";
		this.RBHilo.UseVisualStyleBackColor = true;
		this.RBArea.AutoSize = true;
		this.RBArea.Location = new System.Drawing.Point(87, 284);
		this.RBArea.Name = "RBArea";
		this.RBArea.Size = new System.Drawing.Size(47, 17);
		this.RBArea.TabIndex = 19;
		this.RBArea.TabStop = true;
		this.RBArea.Text = "Area";
		this.RBArea.UseVisualStyleBackColor = true;
		this.RBEtrans.AutoSize = true;
		this.RBEtrans.Location = new System.Drawing.Point(87, 307);
		this.RBEtrans.Name = "RBEtrans";
		this.RBEtrans.Size = new System.Drawing.Size(55, 17);
		this.RBEtrans.TabIndex = 18;
		this.RBEtrans.TabStop = true;
		this.RBEtrans.Text = "Etrans";
		this.RBEtrans.UseVisualStyleBackColor = true;
		this.RBTelas.AutoSize = true;
		this.RBTelas.Location = new System.Drawing.Point(10, 284);
		this.RBTelas.Name = "RBTelas";
		this.RBTelas.Size = new System.Drawing.Size(51, 17);
		this.RBTelas.TabIndex = 17;
		this.RBTelas.TabStop = true;
		this.RBTelas.Text = "Telas";
		this.RBTelas.UseVisualStyleBackColor = true;
		this.TxtOtros.Location = new System.Drawing.Point(61, 232);
		this.TxtOtros.Name = "TxtOtros";
		this.TxtOtros.Size = new System.Drawing.Size(100, 20);
		this.TxtOtros.TabIndex = 15;
		this.TxtOtros.Text = "0";
		this.TxtOtros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		this.LblOtro.AutoSize = true;
		this.LblOtro.Location = new System.Drawing.Point(6, 235);
		this.LblOtro.Name = "LblOtro";
		this.LblOtro.Size = new System.Drawing.Size(35, 13);
		this.LblOtro.TabIndex = 14;
		this.LblOtro.Text = "Otros:";
		this.TxtFinal.Location = new System.Drawing.Point(61, 388);
		this.TxtFinal.Name = "TxtFinal";
		this.TxtFinal.Size = new System.Drawing.Size(100, 20);
		this.TxtFinal.TabIndex = 13;
		this.TxtFinal.Text = "0";
		this.LblTotal.AutoSize = true;
		this.LblTotal.Location = new System.Drawing.Point(6, 391);
		this.LblTotal.Name = "LblTotal";
		this.LblTotal.Size = new System.Drawing.Size(34, 13);
		this.LblTotal.TabIndex = 12;
		this.LblTotal.Text = "Total:";
		this.TxtAdicional.Location = new System.Drawing.Point(61, 191);
		this.TxtAdicional.Name = "TxtAdicional";
		this.TxtAdicional.Size = new System.Drawing.Size(100, 20);
		this.TxtAdicional.TabIndex = 11;
		this.TxtAdicional.Text = "1";
		this.TxtAdicional.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		this.LblAdicional.AutoSize = true;
		this.LblAdicional.Location = new System.Drawing.Point(6, 194);
		this.LblAdicional.Name = "LblAdicional";
		this.LblAdicional.Size = new System.Drawing.Size(53, 13);
		this.LblAdicional.TabIndex = 10;
		this.LblAdicional.Text = "Adicional:";
		this.TxtPuntos.Location = new System.Drawing.Point(61, 148);
		this.TxtPuntos.Name = "TxtPuntos";
		this.TxtPuntos.Size = new System.Drawing.Size(100, 20);
		this.TxtPuntos.TabIndex = 9;
		this.TxtPuntos.Text = "0";
		this.TxtPuntos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		this.LblPuntos.AutoSize = true;
		this.LblPuntos.Location = new System.Drawing.Point(6, 151);
		this.LblPuntos.Name = "LblPuntos";
		this.LblPuntos.Size = new System.Drawing.Size(43, 13);
		this.LblPuntos.TabIndex = 8;
		this.LblPuntos.Text = "Puntos:";
		this.TxtTarifa.Location = new System.Drawing.Point(61, 104);
		this.TxtTarifa.Name = "TxtTarifa";
		this.TxtTarifa.Size = new System.Drawing.Size(100, 20);
		this.TxtTarifa.TabIndex = 7;
		this.TxtTarifa.Text = "0";
		this.TxtTarifa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		this.LblTarifa.AutoSize = true;
		this.LblTarifa.Location = new System.Drawing.Point(6, 107);
		this.LblTarifa.Name = "LblTarifa";
		this.LblTarifa.Size = new System.Drawing.Size(37, 13);
		this.LblTarifa.TabIndex = 6;
		this.LblTarifa.Text = "Tarifa:";
		this.ComboCategoria.FormattingEnabled = true;
		this.ComboCategoria.Location = new System.Drawing.Point(61, 64);
		this.ComboCategoria.Name = "ComboCategoria";
		this.ComboCategoria.Size = new System.Drawing.Size(100, 21);
		this.ComboCategoria.TabIndex = 5;
		this.ComboCategoria.Text = "0";
		this.LblCategoria.AutoSize = true;
		this.LblCategoria.Location = new System.Drawing.Point(6, 67);
		this.LblCategoria.Name = "LblCategoria";
		this.LblCategoria.Size = new System.Drawing.Size(55, 13);
		this.LblCategoria.TabIndex = 4;
		this.LblCategoria.Text = "Categoria:";
		this.TxtNumero.Location = new System.Drawing.Point(61, 23);
		this.TxtNumero.Name = "TxtNumero";
		this.TxtNumero.Size = new System.Drawing.Size(100, 20);
		this.TxtNumero.TabIndex = 3;
		this.TxtNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		this.LblNumero.AutoSize = true;
		this.LblNumero.Location = new System.Drawing.Point(6, 25);
		this.LblNumero.Name = "LblNumero";
		this.LblNumero.Size = new System.Drawing.Size(47, 13);
		this.LblNumero.TabIndex = 2;
		this.LblNumero.Text = "Numero:";
		this.BtnGuardar.Location = new System.Drawing.Point(6, 442);
		this.BtnGuardar.Name = "BtnGuardar";
		this.BtnGuardar.Size = new System.Drawing.Size(75, 23);
		this.BtnGuardar.TabIndex = 1;
		this.BtnGuardar.Text = "Guardar";
		this.BtnGuardar.UseVisualStyleBackColor = true;
		this.BtnSalir.Location = new System.Drawing.Point(87, 442);
		this.BtnSalir.Name = "BtnSalir";
		this.BtnSalir.Size = new System.Drawing.Size(75, 23);
		this.BtnSalir.TabIndex = 0;
		this.BtnSalir.Text = "Salir";
		this.BtnSalir.UseVisualStyleBackColor = true;
		this.GroupBox3.Controls.Add(this.ListView1);
		this.GroupBox3.Location = new System.Drawing.Point(12, 79);
		this.GroupBox3.Name = "GroupBox3";
		this.GroupBox3.Size = new System.Drawing.Size(754, 409);
		this.GroupBox3.TabIndex = 2;
		this.GroupBox3.TabStop = false;
		this.ListView1.Location = new System.Drawing.Point(6, 21);
		this.ListView1.Name = "ListView1";
		this.ListView1.Size = new System.Drawing.Size(742, 377);
		this.ListView1.TabIndex = 0;
		this.ListView1.UseCompatibleStateImageBehavior = false;
		this.Label1.AutoSize = true;
		this.Label1.Location = new System.Drawing.Point(60, 25);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(0, 13);
		this.Label1.TabIndex = 17;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(949, 500);
		base.Controls.Add(this.GroupBox3);
		base.Controls.Add(this.GroupBox2);
		base.Controls.Add(this.GroupBox1);
		base.Name = "Liquidacion";
		this.Text = "Liquidacion Diaria";
		this.GroupBox1.ResumeLayout(false);
		this.GroupBox1.PerformLayout();
		this.GroupBox2.ResumeLayout(false);
		this.GroupBox2.PerformLayout();
		this.GroupBox3.ResumeLayout(false);
		base.ResumeLayout(false);
	}

	private void Liquidacion_Load(object sender, EventArgs e)
	{
		RBArea.Checked = true;
	}

	private void BtnConsultar_Click(object sender, EventArgs e)
	{
		informe_Viaje();
	}

	private void ListView1_ColumnClick(object sender, ColumnClickEventArgs e)
	{
		Mod_Ordenaclumnas.ordenar_columnas(ListView1, RuntimeHelpers.GetObjectValue(sender), e);
	}

	private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
	{
		string fecha = Strings.Format(DTPLiquidacion.Value, "yyyyMMdd");
		if (ListView1.SelectedItems.Count > 0)
		{
			int index = ListView1.SelectedIndices[0];
			Label1.Text = ListView1.Items[index].Text;
			ventana = Conversions.ToInteger(ListView1.Items[index].SubItems[2].Text);
			categoria = Conversions.ToInteger(ListView1.Items[index].SubItems[1].Text);
			tarifa_fija = Conversions.ToDouble(ListView1.Items[index].SubItems[8].Text);
			puntos = Conversions.ToInteger(ListView1.Items[index].SubItems[3].Text);
			adicional = Conversions.ToDouble(ListView1.Items[index].SubItems[10].Text);
			adicionalModelo = Conversions.ToDouble(ListView1.Items[index].SubItems[11].Text);
			kilos = Conversions.ToDouble(ListView1.Items[index].SubItems[5].Text);
			bultos = Conversions.ToInteger(ListView1.Items[index].SubItems[4].Text);
			declarado = Conversions.ToDouble(ListView1.Items[index].SubItems[6].Text);
			flete = Conversions.ToDouble(ListView1.Items[index].SubItems[7].Text);
			ComboCategoria.Text = Conversions.ToString(categoria);
			TxtTarifa.Text = Conversions.ToString(tarifa_fija);
			TxtPuntos.Text = Conversions.ToString(puntos);
			TxtAdicional.Text = Conversions.ToString(adicional);
			string sql = "SELECT numero FROM flota where chofer='" + ListView1.Items[index].Text + "'";
			DataTable dataTable = (DataTable)Mod_Sentencias.data(sql);
			chofer = Conversions.ToInteger(dataTable.Rows[0]["numero"]);
			viaje = Conversions.ToInteger(Mod_Despacho.numeroViaje(chofer, ventana, fecha));
			TxtNumero.Text = Conversions.ToString(viaje);
			RBArea.Checked = true;
			calcularFinal();
			BtnRecalcular.Visible = false;
		}
	}

	private void informe_Viaje()
	{
		checked
		{
			try
			{
				string fecha = Strings.Format(DTPLiquidacion.Value, "yyyyMMdd");
				DataTable dataTable = (DataTable)Mod_Informes.informeViaje(fecha);
				ListView listView = ListView1;
				listView.Items.Clear();
				listView.Columns.Clear();
				listView.View = View.Details;
				listView.GridLines = true;
				listView.FullRowSelect = true;
				int num = dataTable.Columns.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					listView.Columns.Add(dataTable.Columns[i].Caption);
				}
				listView.Columns[4].TextAlign = HorizontalAlignment.Right;
				listView.Columns[5].TextAlign = HorizontalAlignment.Right;
				listView.Columns[6].TextAlign = HorizontalAlignment.Right;
				listView.Columns[7].TextAlign = HorizontalAlignment.Right;
				listView.Columns[8].TextAlign = HorizontalAlignment.Right;
				listView = null;
				DataTable dataTable2 = dataTable;
				int num2 = dataTable2.Rows.Count - 1;
				for (int j = 0; j <= num2; j++)
				{
					ListViewItem listViewItem = new ListViewItem(dataTable2.Rows[j][0].ToString());
					int num3 = dataTable2.Columns.Count - 1;
					for (int k = 1; k <= num3; k++)
					{
						listViewItem.SubItems.Add(dataTable2.Rows[j][k].ToString());
					}
					ListView1.Items.Add(listViewItem);
				}
				dataTable2 = null;
				int num4 = ListView1.Items.Count - 1;
				for (int l = 0; l <= num4; l++)
				{
					string left = ListView1.Items[l].SubItems[13].Text;
					try
					{
						if (Operators.CompareString(left, "Cerrado", TextCompare: true) == 0)
						{
							ListView1.Items[l].BackColor = Color.Green;
						}
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ListView1.Items[l].BackColor = Color.White;
						ProjectData.ClearProjectError();
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	private void calcularFinal()
	{
		checked
		{
			if (RBEtrans.Checked)
			{
				if (ventana > 1)
				{
					AP1 = (int)Math.Round(Conversions.ToDouble(TxtPuntos.Text) - 30.0);
					AP2 = AP1 - 30;
					if (AP1 > 0)
					{
						VAP1 = AP1 * 20;
					}
					if (AP2 > 0)
					{
						VAP2 = AP2 * 30;
					}
					TxtFinal.Text = Conversions.ToString(Math.Round((Conversions.ToDouble(TxtTarifa.Text) + adicionalModelo) * 0.7 * Conversions.ToDouble(TxtAdicional.Text) + Conversions.ToDouble(TxtOtros.Text) + VAP1 + VAP2, 2));
				}
				else
				{
					AP1 = (int)Math.Round(Conversions.ToDouble(TxtPuntos.Text) - 30.0);
					AP2 = AP1 - 30;
					if (AP1 > 0)
					{
						VAP1 = AP1 * 20;
					}
					if (AP2 > 0)
					{
						VAP2 = AP2 * 30;
					}
					TxtFinal.Text = Conversions.ToString(Math.Round((Conversions.ToDouble(TxtTarifa.Text) + adicionalModelo) * Conversions.ToDouble(TxtAdicional.Text) + Conversions.ToDouble(TxtOtros.Text) + VAP1 + VAP2, 2));
				}
			}
			if (RBArea.Checked)
			{
				if (ventana > 1)
				{
					TxtFinal.Text = Conversions.ToString(Math.Round((Conversions.ToDouble(TxtTarifa.Text) + adicionalModelo) * 0.7 * Conversions.ToDouble(TxtAdicional.Text) + Conversions.ToDouble(TxtOtros.Text), 2));
				}
				else
				{
					TxtFinal.Text = Conversions.ToString(Math.Round((Conversions.ToDouble(TxtTarifa.Text) + adicionalModelo) * Conversions.ToDouble(TxtAdicional.Text) + Conversions.ToDouble(TxtOtros.Text), 2));
				}
			}
			if (RBTelas.Checked)
			{
				if (kilos > 7000.0)
				{
					double num = kilos * 0.36;
					TxtFinal.Text = Conversions.ToString(Math.Round(num + Conversions.ToDouble(TxtOtros.Text), 2));
				}
				else
				{
					double num2 = 2520.0;
					TxtFinal.Text = Conversions.ToString(Math.Round(num2 + Conversions.ToDouble(TxtOtros.Text), 2));
				}
			}
			if (RBHilo.Checked)
			{
				if (kilos > 7000.0)
				{
					double num3 = kilos * 0.38;
					TxtFinal.Text = Conversions.ToString(Math.Round(num3 + Conversions.ToDouble(TxtOtros.Text), 2));
				}
				else
				{
					double num4 = 2660.0;
					TxtFinal.Text = Conversions.ToString(Math.Round(num4 + Conversions.ToDouble(TxtOtros.Text), 2));
				}
			}
		}
	}

	private void ComboCategoria_SelectedIndexChanged(object sender, EventArgs e)
	{
		BtnRecalcular.Visible = true;
	}

	private void TxtTarifa_TextChanged(object sender, EventArgs e)
	{
		BtnRecalcular.Visible = true;
	}

	private void TxtPuntos_TextChanged(object sender, EventArgs e)
	{
		BtnRecalcular.Visible = true;
	}

	private void TxtAdicional_TextChanged(object sender, EventArgs e)
	{
		BtnRecalcular.Visible = true;
	}

	private void TxtOtros_TextChanged(object sender, EventArgs e)
	{
		BtnRecalcular.Visible = true;
	}

	private void BtnRecalcular_Click(object sender, EventArgs e)
	{
		calcularFinal();
	}

	private void ListView1_DoubleClick(object sender, EventArgs e)
	{
		string text = Strings.Format(DTPLiquidacion.Value, "yyyyMMdd");
		string sql = ("SELECT Comprobante, ESTADO, Observaciones, Comentario, (Select Novedad From Novedades where comprobante=planchada.comprobante and fecha='" + text + "') as novedad FROM Planchada WHERE viaje=" + Conversions.ToString(viaje)) ?? "";
		ListadoRuta listadoRuta = MyProject.Forms.ListadoRuta;
		Mod_Sentencias.cargar_datos_lv_completa(listadoRuta.ListView1, sql, listadoRuta.Label1);
		listadoRuta = null;
		MyProject.Forms.ListadoRuta.Show();
	}

	private void RBTelas_CheckedChanged(object sender, EventArgs e)
	{
		if (RBTelas.Checked)
		{
			BtnRecalcular.Visible = true;
		}
	}

	private void RBArea_CheckedChanged(object sender, EventArgs e)
	{
		if (RBArea.Checked)
		{
			BtnRecalcular.Visible = true;
		}
	}

	private void RBHilo_CheckedChanged(object sender, EventArgs e)
	{
		if (RBHilo.Checked)
		{
			BtnRecalcular.Visible = true;
		}
	}

	private void RBEtrans_CheckedChanged(object sender, EventArgs e)
	{
		if (RBEtrans.Checked)
		{
			BtnRecalcular.Visible = true;
		}
	}

	private void BtnGuardar_Click(object sender, EventArgs e)
	{
		if (Conversions.ToDouble(TxtNumero.Text) > 0.0)
		{
			string sQL = ("UPDATE Viajes SET Puntos=" + Conversions.ToString(puntos) + ", Bultos=" + Conversions.ToString(bultos) + ", Peso=" + Strings.Replace(Conversions.ToString(kilos), ",", ".", 1, -1, CompareMethod.Text) + "\t, Declarado=" + Strings.Replace(Conversions.ToString(declarado), ",", ".", 1, -1, CompareMethod.Text) + ", Flete=" + Strings.Replace(Conversions.ToString(flete), ",", ".", 1, -1, CompareMethod.Text) + ", Costo=" + Strings.Replace(TxtFinal.Text, ",", ".", 1, -1, CompareMethod.Text) + ", usuario='" + MyProject.Forms.Form1_Inicio.nombreusuario.Text + "', Estado=1 WHERE id=" + Conversions.ToString(viaje)) ?? "";
			int num = Conversions.ToInteger(Mod_ConeccionBD.BD_Sentencia(sQL));
			if (num == 1)
			{
				Interaction.MsgBox("Se Guardaron los datos");
				ListView1.Clear();
				informe_Viaje();
			}
			else
			{
				Interaction.MsgBox("Existe un error");
				ListView1.Clear();
				informe_Viaje();
			}
		}
	}
}
