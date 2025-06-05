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
public class Ingreso_manual : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Guardar_btn")]
	private Button _Guardar_btn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("salir_btn")]
	private Button _salir_btn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("comprobante_txt")]
	private TextBox _comprobante_txt;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("destino_combo")]
	private ComboBox _destino_combo;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("domicilio_combo")]
	private ComboBox _domicilio_combo;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	internal virtual Button Guardar_btn
	{
		[CompilerGenerated]
		get
		{
			return _Guardar_btn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Guardar_btn_Click;
			Button guardar_btn = _Guardar_btn;
			if (guardar_btn != null)
			{
				guardar_btn.Click -= value2;
			}
			_Guardar_btn = value;
			guardar_btn = _Guardar_btn;
			if (guardar_btn != null)
			{
				guardar_btn.Click += value2;
			}
		}
	}

	internal virtual Button salir_btn
	{
		[CompilerGenerated]
		get
		{
			return _salir_btn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = salir_btn_Click;
			Button button = _salir_btn;
			if (button != null)
			{
				button.Click -= value2;
			}
			_salir_btn = value;
			button = _salir_btn;
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

	[field: AccessedThroughProperty("Label20")]
	internal virtual Label Label20
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual TextBox comprobante_txt
	{
		[CompilerGenerated]
		get
		{
			return _comprobante_txt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			KeyPressEventHandler value2 = comprobante_txt_KeyPress;
			TextBox textBox = _comprobante_txt;
			if (textBox != null)
			{
				textBox.KeyPress -= value2;
			}
			_comprobante_txt = value;
			textBox = _comprobante_txt;
			if (textBox != null)
			{
				textBox.KeyPress += value2;
			}
		}
	}

	[field: AccessedThroughProperty("cliente_combo")]
	internal virtual ComboBox cliente_combo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("remito_txt")]
	internal virtual TextBox remito_txt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ComboBox destino_combo
	{
		[CompilerGenerated]
		get
		{
			return _destino_combo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = destino_combo_SelectedIndexChanged;
			ComboBox comboBox = _destino_combo;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged -= value2;
			}
			_destino_combo = value;
			comboBox = _destino_combo;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("cp_txt")]
	internal virtual TextBox cp_txt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("localidad_combo")]
	internal virtual ComboBox localidad_combo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("declarado_txt")]
	internal virtual TextBox declarado_txt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("bultos_txt")]
	internal virtual TextBox bultos_txt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("kilos_txt")]
	internal virtual TextBox kilos_txt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("volumen_txt")]
	internal virtual TextBox volumen_txt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("zona_txt")]
	internal virtual TextBox zona_txt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("adicional_txt")]
	internal virtual TextBox adicional_txt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("prioridad_txt")]
	internal virtual TextBox prioridad_txt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ventana_txt")]
	internal virtual ComboBox ventana_txt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("observaciones_txt")]
	internal virtual TextBox observaciones_txt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("sub_txt")]
	internal virtual TextBox sub_txt
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

	[field: AccessedThroughProperty("DateTimePicker2")]
	internal virtual DateTimePicker DateTimePicker2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel1")]
	internal virtual Panel Panel1
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

	[field: AccessedThroughProperty("Label21")]
	internal virtual Label Label21
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

	[field: AccessedThroughProperty("GroupBox2")]
	internal virtual GroupBox GroupBox2
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

	[field: AccessedThroughProperty("TextBox2")]
	internal virtual TextBox TextBox2
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

	[field: AccessedThroughProperty("Panel3")]
	internal virtual Panel Panel3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ComboBox domicilio_combo
	{
		[CompilerGenerated]
		get
		{
			return _domicilio_combo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = domicilio_combo_SelectedIndexChanged;
			ComboBox comboBox = _domicilio_combo;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged -= value2;
			}
			_domicilio_combo = value;
			comboBox = _domicilio_combo;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label22")]
	internal virtual Label Label22
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

	public Ingreso_manual()
	{
		base.Load += Ingreso_manual_Load;
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
		this.Guardar_btn = new System.Windows.Forms.Button();
		this.salir_btn = new System.Windows.Forms.Button();
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
		this.Label17 = new System.Windows.Forms.Label();
		this.Label18 = new System.Windows.Forms.Label();
		this.Label19 = new System.Windows.Forms.Label();
		this.Label20 = new System.Windows.Forms.Label();
		this.comprobante_txt = new System.Windows.Forms.TextBox();
		this.cliente_combo = new System.Windows.Forms.ComboBox();
		this.remito_txt = new System.Windows.Forms.TextBox();
		this.destino_combo = new System.Windows.Forms.ComboBox();
		this.cp_txt = new System.Windows.Forms.TextBox();
		this.localidad_combo = new System.Windows.Forms.ComboBox();
		this.declarado_txt = new System.Windows.Forms.TextBox();
		this.bultos_txt = new System.Windows.Forms.TextBox();
		this.kilos_txt = new System.Windows.Forms.TextBox();
		this.volumen_txt = new System.Windows.Forms.TextBox();
		this.zona_txt = new System.Windows.Forms.TextBox();
		this.adicional_txt = new System.Windows.Forms.TextBox();
		this.prioridad_txt = new System.Windows.Forms.TextBox();
		this.ventana_txt = new System.Windows.Forms.ComboBox();
		this.observaciones_txt = new System.Windows.Forms.TextBox();
		this.sub_txt = new System.Windows.Forms.TextBox();
		this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
		this.DateTimePicker2 = new System.Windows.Forms.DateTimePicker();
		this.Panel1 = new System.Windows.Forms.Panel();
		this.TextBox1 = new System.Windows.Forms.TextBox();
		this.Label21 = new System.Windows.Forms.Label();
		this.GroupBox1 = new System.Windows.Forms.GroupBox();
		this.GroupBox2 = new System.Windows.Forms.GroupBox();
		this.Panel2 = new System.Windows.Forms.Panel();
		this.domicilio_combo = new System.Windows.Forms.ComboBox();
		this.TextBox2 = new System.Windows.Forms.TextBox();
		this.GroupBox3 = new System.Windows.Forms.GroupBox();
		this.Panel3 = new System.Windows.Forms.Panel();
		this.Label22 = new System.Windows.Forms.Label();
		this.Button1 = new System.Windows.Forms.Button();
		this.Panel1.SuspendLayout();
		this.GroupBox1.SuspendLayout();
		this.GroupBox2.SuspendLayout();
		this.Panel2.SuspendLayout();
		this.GroupBox3.SuspendLayout();
		this.Panel3.SuspendLayout();
		base.SuspendLayout();
		this.Guardar_btn.Location = new System.Drawing.Point(18, 352);
		this.Guardar_btn.Name = "Guardar_btn";
		this.Guardar_btn.Size = new System.Drawing.Size(75, 23);
		this.Guardar_btn.TabIndex = 0;
		this.Guardar_btn.Text = "Guardar";
		this.Guardar_btn.UseVisualStyleBackColor = true;
		this.salir_btn.Location = new System.Drawing.Point(747, 352);
		this.salir_btn.Name = "salir_btn";
		this.salir_btn.Size = new System.Drawing.Size(75, 23);
		this.salir_btn.TabIndex = 1;
		this.salir_btn.Text = "Salir";
		this.salir_btn.UseVisualStyleBackColor = true;
		this.Label1.AutoSize = true;
		this.Label1.BackColor = System.Drawing.SystemColors.Control;
		this.Label1.Location = new System.Drawing.Point(165, 30);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(73, 13);
		this.Label1.TabIndex = 2;
		this.Label1.Text = "Comprobante:";
		this.Label2.AutoSize = true;
		this.Label2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
		this.Label2.Location = new System.Drawing.Point(6, 41);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(42, 13);
		this.Label2.TabIndex = 3;
		this.Label2.Text = "Cliente:";
		this.Label3.AutoSize = true;
		this.Label3.Location = new System.Drawing.Point(8, 18);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(47, 13);
		this.Label3.TabIndex = 4;
		this.Label3.Text = "Número:";
		this.Label4.AutoSize = true;
		this.Label4.Location = new System.Drawing.Point(21, 15);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(46, 13);
		this.Label4.TabIndex = 5;
		this.Label4.Text = "Destino:";
		this.Label5.AutoSize = true;
		this.Label5.Location = new System.Drawing.Point(21, 45);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(52, 13);
		this.Label5.TabIndex = 6;
		this.Label5.Text = "Domicilio:";
		this.Label6.AutoSize = true;
		this.Label6.Location = new System.Drawing.Point(21, 75);
		this.Label6.Name = "Label6";
		this.Label6.Size = new System.Drawing.Size(30, 13);
		this.Label6.TabIndex = 7;
		this.Label6.Text = "C.P.:";
		this.Label7.AutoSize = true;
		this.Label7.Location = new System.Drawing.Point(225, 75);
		this.Label7.Name = "Label7";
		this.Label7.Size = new System.Drawing.Size(56, 13);
		this.Label7.TabIndex = 8;
		this.Label7.Text = "Localidad:";
		this.Label8.AutoSize = true;
		this.Label8.Location = new System.Drawing.Point(619, 18);
		this.Label8.Name = "Label8";
		this.Label8.Size = new System.Drawing.Size(59, 13);
		this.Label8.TabIndex = 9;
		this.Label8.Text = "Declarado:";
		this.Label9.AutoSize = true;
		this.Label9.Location = new System.Drawing.Point(176, 18);
		this.Label9.Name = "Label9";
		this.Label9.Size = new System.Drawing.Size(39, 13);
		this.Label9.TabIndex = 10;
		this.Label9.Text = "Bultos:";
		this.Label10.AutoSize = true;
		this.Label10.Location = new System.Drawing.Point(308, 18);
		this.Label10.Name = "Label10";
		this.Label10.Size = new System.Drawing.Size(32, 13);
		this.Label10.TabIndex = 11;
		this.Label10.Text = "Kilos:";
		this.Label11.AutoSize = true;
		this.Label11.BackColor = System.Drawing.SystemColors.ControlDarkDark;
		this.Label11.Location = new System.Drawing.Point(274, 15);
		this.Label11.Name = "Label11";
		this.Label11.Size = new System.Drawing.Size(29, 13);
		this.Label11.TabIndex = 12;
		this.Label11.Text = "Sub:";
		this.Label12.AutoSize = true;
		this.Label12.Location = new System.Drawing.Point(25, 282);
		this.Label12.Name = "Label12";
		this.Label12.Size = new System.Drawing.Size(81, 13);
		this.Label12.TabIndex = 13;
		this.Label12.Text = "Observaciones:";
		this.Label13.AutoSize = true;
		this.Label13.Location = new System.Drawing.Point(452, 18);
		this.Label13.Name = "Label13";
		this.Label13.Size = new System.Drawing.Size(51, 13);
		this.Label13.TabIndex = 14;
		this.Label13.Text = "Volumen:";
		this.Label14.AutoSize = true;
		this.Label14.Location = new System.Drawing.Point(197, 162);
		this.Label14.Name = "Label14";
		this.Label14.Size = new System.Drawing.Size(77, 13);
		this.Label14.TabIndex = 15;
		this.Label14.Text = "Diferir Entrega:";
		this.Label15.AutoSize = true;
		this.Label15.Location = new System.Drawing.Point(27, 162);
		this.Label15.Name = "Label15";
		this.Label15.Size = new System.Drawing.Size(40, 13);
		this.Label15.TabIndex = 16;
		this.Label15.Text = "Fecha:";
		this.Label16.AutoSize = true;
		this.Label16.Location = new System.Drawing.Point(636, 162);
		this.Label16.Name = "Label16";
		this.Label16.Size = new System.Drawing.Size(33, 13);
		this.Label16.TabIndex = 17;
		this.Label16.Text = "Flete:";
		this.Label17.AutoSize = true;
		this.Label17.Location = new System.Drawing.Point(299, 308);
		this.Label17.Name = "Label17";
		this.Label17.Size = new System.Drawing.Size(35, 13);
		this.Label17.TabIndex = 18;
		this.Label17.Text = "Zona:";
		this.Label18.AutoSize = true;
		this.Label18.Location = new System.Drawing.Point(409, 308);
		this.Label18.Name = "Label18";
		this.Label18.Size = new System.Drawing.Size(53, 13);
		this.Label18.TabIndex = 19;
		this.Label18.Text = "Adicional:";
		this.Label19.AutoSize = true;
		this.Label19.Location = new System.Drawing.Point(539, 308);
		this.Label19.Name = "Label19";
		this.Label19.Size = new System.Drawing.Size(51, 13);
		this.Label19.TabIndex = 20;
		this.Label19.Text = "Prioridad:";
		this.Label20.AutoSize = true;
		this.Label20.Location = new System.Drawing.Point(691, 308);
		this.Label20.Name = "Label20";
		this.Label20.Size = new System.Drawing.Size(50, 13);
		this.Label20.TabIndex = 21;
		this.Label20.Text = "Ventana:";
		this.comprobante_txt.Location = new System.Drawing.Point(244, 27);
		this.comprobante_txt.Name = "comprobante_txt";
		this.comprobante_txt.Size = new System.Drawing.Size(134, 20);
		this.comprobante_txt.TabIndex = 22;
		this.comprobante_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		this.cliente_combo.FormattingEnabled = true;
		this.cliente_combo.Location = new System.Drawing.Point(54, 38);
		this.cliente_combo.Name = "cliente_combo";
		this.cliente_combo.Size = new System.Drawing.Size(297, 21);
		this.cliente_combo.TabIndex = 23;
		this.remito_txt.Location = new System.Drawing.Point(55, 15);
		this.remito_txt.Name = "remito_txt";
		this.remito_txt.Size = new System.Drawing.Size(108, 20);
		this.remito_txt.TabIndex = 24;
		this.remito_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		this.destino_combo.FormattingEnabled = true;
		this.destino_combo.Location = new System.Drawing.Point(83, 12);
		this.destino_combo.Name = "destino_combo";
		this.destino_combo.Size = new System.Drawing.Size(326, 21);
		this.destino_combo.TabIndex = 25;
		this.cp_txt.Location = new System.Drawing.Point(83, 72);
		this.cp_txt.Name = "cp_txt";
		this.cp_txt.Size = new System.Drawing.Size(100, 20);
		this.cp_txt.TabIndex = 27;
		this.localidad_combo.FormattingEnabled = true;
		this.localidad_combo.Location = new System.Drawing.Point(288, 72);
		this.localidad_combo.Name = "localidad_combo";
		this.localidad_combo.Size = new System.Drawing.Size(121, 21);
		this.localidad_combo.TabIndex = 28;
		this.declarado_txt.Location = new System.Drawing.Point(684, 15);
		this.declarado_txt.Name = "declarado_txt";
		this.declarado_txt.Size = new System.Drawing.Size(103, 20);
		this.declarado_txt.TabIndex = 29;
		this.declarado_txt.Text = "0";
		this.declarado_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		this.bultos_txt.Location = new System.Drawing.Point(224, 15);
		this.bultos_txt.Name = "bultos_txt";
		this.bultos_txt.Size = new System.Drawing.Size(67, 20);
		this.bultos_txt.TabIndex = 30;
		this.bultos_txt.Text = "0";
		this.bultos_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		this.kilos_txt.Location = new System.Drawing.Point(346, 15);
		this.kilos_txt.Name = "kilos_txt";
		this.kilos_txt.Size = new System.Drawing.Size(100, 20);
		this.kilos_txt.TabIndex = 31;
		this.kilos_txt.Text = "0";
		this.kilos_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		this.volumen_txt.Location = new System.Drawing.Point(509, 15);
		this.volumen_txt.Name = "volumen_txt";
		this.volumen_txt.Size = new System.Drawing.Size(100, 20);
		this.volumen_txt.TabIndex = 32;
		this.volumen_txt.Text = "0";
		this.volumen_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		this.zona_txt.Location = new System.Drawing.Point(347, 305);
		this.zona_txt.Name = "zona_txt";
		this.zona_txt.Size = new System.Drawing.Size(56, 20);
		this.zona_txt.TabIndex = 33;
		this.adicional_txt.Location = new System.Drawing.Point(468, 305);
		this.adicional_txt.Name = "adicional_txt";
		this.adicional_txt.Size = new System.Drawing.Size(56, 20);
		this.adicional_txt.TabIndex = 34;
		this.prioridad_txt.Location = new System.Drawing.Point(596, 305);
		this.prioridad_txt.Name = "prioridad_txt";
		this.prioridad_txt.Size = new System.Drawing.Size(82, 20);
		this.prioridad_txt.TabIndex = 35;
		this.ventana_txt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.ventana_txt.FormattingEnabled = true;
		this.ventana_txt.Items.AddRange(new object[3] { "1", "2", "3" });
		this.ventana_txt.Location = new System.Drawing.Point(747, 305);
		this.ventana_txt.Name = "ventana_txt";
		this.ventana_txt.Size = new System.Drawing.Size(58, 21);
		this.ventana_txt.TabIndex = 36;
		this.observaciones_txt.Location = new System.Drawing.Point(112, 279);
		this.observaciones_txt.Name = "observaciones_txt";
		this.observaciones_txt.Size = new System.Drawing.Size(693, 20);
		this.observaciones_txt.TabIndex = 37;
		this.sub_txt.Location = new System.Drawing.Point(309, 12);
		this.sub_txt.Name = "sub_txt";
		this.sub_txt.Size = new System.Drawing.Size(42, 20);
		this.sub_txt.TabIndex = 38;
		this.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
		this.DateTimePicker1.Location = new System.Drawing.Point(73, 156);
		this.DateTimePicker1.Name = "DateTimePicker1";
		this.DateTimePicker1.Size = new System.Drawing.Size(90, 20);
		this.DateTimePicker1.TabIndex = 39;
		this.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
		this.DateTimePicker2.Location = new System.Drawing.Point(280, 156);
		this.DateTimePicker2.Name = "DateTimePicker2";
		this.DateTimePicker2.Size = new System.Drawing.Size(90, 20);
		this.DateTimePicker2.TabIndex = 40;
		this.Panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
		this.Panel1.Controls.Add(this.TextBox1);
		this.Panel1.Controls.Add(this.Label21);
		this.Panel1.Controls.Add(this.sub_txt);
		this.Panel1.Controls.Add(this.Label11);
		this.Panel1.Controls.Add(this.Label2);
		this.Panel1.Controls.Add(this.cliente_combo);
		this.Panel1.Location = new System.Drawing.Point(7, 19);
		this.Panel1.Name = "Panel1";
		this.Panel1.Size = new System.Drawing.Size(359, 67);
		this.Panel1.TabIndex = 42;
		this.TextBox1.Location = new System.Drawing.Point(168, 12);
		this.TextBox1.Name = "TextBox1";
		this.TextBox1.Size = new System.Drawing.Size(100, 20);
		this.TextBox1.TabIndex = 40;
		this.Label21.AutoSize = true;
		this.Label21.Location = new System.Drawing.Point(143, 15);
		this.Label21.Name = "Label21";
		this.Label21.Size = new System.Drawing.Size(19, 13);
		this.Label21.TabIndex = 39;
		this.Label21.Text = "Id:";
		this.GroupBox1.Controls.Add(this.Panel1);
		this.GroupBox1.Location = new System.Drawing.Point(12, 53);
		this.GroupBox1.Name = "GroupBox1";
		this.GroupBox1.Size = new System.Drawing.Size(372, 94);
		this.GroupBox1.TabIndex = 43;
		this.GroupBox1.TabStop = false;
		this.GroupBox1.Text = "Remitente:";
		this.GroupBox2.Controls.Add(this.Panel2);
		this.GroupBox2.Location = new System.Drawing.Point(390, 12);
		this.GroupBox2.Name = "GroupBox2";
		this.GroupBox2.Size = new System.Drawing.Size(439, 135);
		this.GroupBox2.TabIndex = 44;
		this.GroupBox2.TabStop = false;
		this.GroupBox2.Text = "Destinatario:";
		this.Panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
		this.Panel2.Controls.Add(this.domicilio_combo);
		this.Panel2.Controls.Add(this.Label4);
		this.Panel2.Controls.Add(this.Label5);
		this.Panel2.Controls.Add(this.Label6);
		this.Panel2.Controls.Add(this.destino_combo);
		this.Panel2.Controls.Add(this.cp_txt);
		this.Panel2.Controls.Add(this.localidad_combo);
		this.Panel2.Controls.Add(this.Label7);
		this.Panel2.Location = new System.Drawing.Point(6, 19);
		this.Panel2.Name = "Panel2";
		this.Panel2.Size = new System.Drawing.Size(426, 110);
		this.Panel2.TabIndex = 0;
		this.domicilio_combo.FormattingEnabled = true;
		this.domicilio_combo.Location = new System.Drawing.Point(83, 42);
		this.domicilio_combo.Name = "domicilio_combo";
		this.domicilio_combo.Size = new System.Drawing.Size(326, 21);
		this.domicilio_combo.TabIndex = 29;
		this.TextBox2.Location = new System.Drawing.Point(684, 155);
		this.TextBox2.Name = "TextBox2";
		this.TextBox2.Size = new System.Drawing.Size(100, 20);
		this.TextBox2.TabIndex = 45;
		this.TextBox2.Text = "0";
		this.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		this.GroupBox3.Controls.Add(this.Panel3);
		this.GroupBox3.Location = new System.Drawing.Point(12, 197);
		this.GroupBox3.Name = "GroupBox3";
		this.GroupBox3.Size = new System.Drawing.Size(817, 67);
		this.GroupBox3.TabIndex = 46;
		this.GroupBox3.TabStop = false;
		this.GroupBox3.Text = "Remitos:";
		this.Panel3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
		this.Panel3.Controls.Add(this.remito_txt);
		this.Panel3.Controls.Add(this.volumen_txt);
		this.Panel3.Controls.Add(this.Label3);
		this.Panel3.Controls.Add(this.declarado_txt);
		this.Panel3.Controls.Add(this.Label9);
		this.Panel3.Controls.Add(this.Label8);
		this.Panel3.Controls.Add(this.bultos_txt);
		this.Panel3.Controls.Add(this.Label13);
		this.Panel3.Controls.Add(this.Label10);
		this.Panel3.Controls.Add(this.kilos_txt);
		this.Panel3.Location = new System.Drawing.Point(6, 13);
		this.Panel3.Name = "Panel3";
		this.Panel3.Size = new System.Drawing.Size(804, 48);
		this.Panel3.TabIndex = 47;
		this.Label22.AutoSize = true;
		this.Label22.Location = new System.Drawing.Point(229, 308);
		this.Label22.Name = "Label22";
		this.Label22.Size = new System.Drawing.Size(13, 13);
		this.Label22.TabIndex = 47;
		this.Label22.Text = "0";
		this.Label22.Visible = false;
		this.Button1.Enabled = false;
		this.Button1.Location = new System.Drawing.Point(106, 352);
		this.Button1.Name = "Button1";
		this.Button1.Size = new System.Drawing.Size(75, 23);
		this.Button1.TabIndex = 48;
		this.Button1.Text = "Borrar";
		this.Button1.UseVisualStyleBackColor = true;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(841, 383);
		base.Controls.Add(this.Button1);
		base.Controls.Add(this.Label22);
		base.Controls.Add(this.GroupBox3);
		base.Controls.Add(this.TextBox2);
		base.Controls.Add(this.GroupBox2);
		base.Controls.Add(this.DateTimePicker2);
		base.Controls.Add(this.DateTimePicker1);
		base.Controls.Add(this.observaciones_txt);
		base.Controls.Add(this.ventana_txt);
		base.Controls.Add(this.prioridad_txt);
		base.Controls.Add(this.adicional_txt);
		base.Controls.Add(this.zona_txt);
		base.Controls.Add(this.comprobante_txt);
		base.Controls.Add(this.Label20);
		base.Controls.Add(this.Label19);
		base.Controls.Add(this.Label18);
		base.Controls.Add(this.Label17);
		base.Controls.Add(this.Label16);
		base.Controls.Add(this.Label15);
		base.Controls.Add(this.Label14);
		base.Controls.Add(this.Label12);
		base.Controls.Add(this.Label1);
		base.Controls.Add(this.salir_btn);
		base.Controls.Add(this.Guardar_btn);
		base.Controls.Add(this.GroupBox1);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
		base.Name = "Ingreso_manual";
		this.Text = "Ingreos Manual de Guias";
		this.Panel1.ResumeLayout(false);
		this.Panel1.PerformLayout();
		this.GroupBox1.ResumeLayout(false);
		this.GroupBox2.ResumeLayout(false);
		this.Panel2.ResumeLayout(false);
		this.Panel2.PerformLayout();
		this.GroupBox3.ResumeLayout(false);
		this.Panel3.ResumeLayout(false);
		this.Panel3.PerformLayout();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private void Guardar_btn_Click(object sender, EventArgs e)
	{
		try
		{
			string text = Strings.Format(DateTimePicker1.Value, "yyyyMMdd");
			string sQL = "insert into planchada(eventual, comprobante, cliente, remitos, destino, domicilio, cp, localidad, declarado, bultos, kilos, sub, observaciones, volumen, atraso, diferida, flete, zona, adicional, prioridad, chofer, latitud, longitud, estado, fecha, ventana, usuario) values (" + Label22.Text + ", " + comprobante_txt.Text + ",'" + cliente_combo.Text + "','" + remito_txt.Text + "','" + destino_combo.Text + "','" + Strings.Replace(domicilio_combo.Text, "'", " ", 1, -1, CompareMethod.Text) + "','" + cp_txt.Text + "','" + localidad_combo.Text + "'," + Strings.Replace(declarado_txt.Text, ",", ".", 1, -1, CompareMethod.Text) + "," + bultos_txt.Text + "," + Strings.Replace(kilos_txt.Text, ",", ".", 1, -1, CompareMethod.Text) + ",'" + sub_txt.Text + "','" + observaciones_txt.Text + "'," + Strings.Replace(volumen_txt.Text, ",", ".", 1, -1, CompareMethod.Text) + ",0,'" + Conversions.ToString(DateTimePicker2.Value) + "'," + Strings.Replace(TextBox2.Text, ",", ".", 1, -1, CompareMethod.Text) + "," + zona_txt.Text + "," + adicional_txt.Text + "," + prioridad_txt.Text + ",0,0,0,'en planchada','" + text + "', 0,'" + MyProject.Forms.Form1_Inicio.nombreusuario.Text + "')";
			Mod_ConeccionBD.BD_Sentencia(sQL);
			limpiar_campos();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox(ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void Ingreso_manual_Load(object sender, EventArgs e)
	{
		Clientes_load();
		string sql = "SELECT DISTINCT Cliente FROM EVENTUALES";
		Mod_Sentencias.cargar_cbb(destino_combo, sql);
		ventana_txt.SelectedIndex = 0;
		if (Conversions.ToDouble(MySettingsProperty.Settings.Permiso) >= 8.0)
		{
			Button1.Enabled = true;
		}
	}

	private void Clientes_load()
	{
		try
		{
			string sql = "SELECT Nombre FROM Clientes";
			Mod_Sentencias.cargar_cbb(cliente_combo, sql);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			Interaction.MsgBox("Error al cargar los clientes");
			ProjectData.ClearProjectError();
		}
	}

	private void salir_btn_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void destino_combo_SelectedIndexChanged(object sender, EventArgs e)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		checked
		{
			try
			{
				if (Operators.CompareString(destino_combo.Text, "", TextCompare: true) == 0)
				{
					return;
				}
				DataTable dataTable = new DataTable("x");
				string text = "SELECT * FROM EVENTUALES WHERE CLIENTE = '" + destino_combo.Text + "'";
				MySqlDataAdapter val = new MySqlDataAdapter(text, Mod_Sentencias.cnn);
				DataSet dataSet = new DataSet();
				((DbDataAdapter)(object)val).Fill(dataTable);
				domicilio_combo.Items.Clear();
				cp_txt.Text = "";
				localidad_combo.Text = "";
				domicilio_combo.Text = "";
				Label22.Text = "0";
				int num = dataTable.Rows.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					if (dataTable.Rows.Count > 1)
					{
						domicilio_combo.Items.Add(dataTable.Rows[i]["Domicilio"].ToString());
						continue;
					}
					domicilio_combo.Text = dataTable.Rows[i]["Domicilio"].ToString();
					cp_txt.Text = dataTable.Rows[0]["CP"].ToString();
					localidad_combo.Text = dataTable.Rows[0]["Localidad"].ToString();
					Label22.Text = dataTable.Rows[0]["Eventual"].ToString();
					zona_txt.Text = dataTable.Rows[0]["Zona"].ToString();
					adicional_txt.Text = dataTable.Rows[0]["Adicional"].ToString();
					prioridad_txt.Text = dataTable.Rows[0]["Prioridad"].ToString();
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

	private void domicilio_combo_SelectedIndexChanged(object sender, EventArgs e)
	{
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		try
		{
			if (Operators.CompareString(destino_combo.Text, "", TextCompare: true) != 0 && Operators.CompareString(domicilio_combo.Text, "", TextCompare: true) != 0)
			{
				DataTable dataTable = new DataTable("x");
				string text = "SELECT * FROM EVENTUALES WHERE CLIENTE = '" + destino_combo.Text + "' AND DOMICILIO='" + domicilio_combo.Text + "'";
				MySqlDataAdapter val = new MySqlDataAdapter(text, Mod_Sentencias.cnn);
				DataSet dataSet = new DataSet();
				((DbDataAdapter)(object)val).Fill(dataTable);
				cp_txt.Text = dataTable.Rows[0]["CP"].ToString();
				localidad_combo.Text = dataTable.Rows[0]["Localidad"].ToString();
				Label22.Text = dataTable.Rows[0]["Eventual"].ToString();
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

	private void limpiar_campos()
	{
		Label22.Text = "";
		comprobante_txt.Text = "";
		cliente_combo.Text = "";
		remito_txt.Text = "";
		destino_combo.Text = "";
		domicilio_combo.Text = "";
		cp_txt.Text = "";
		localidad_combo.Text = "";
		declarado_txt.Text = "";
		bultos_txt.Text = "";
		kilos_txt.Text = "";
		observaciones_txt.Text = "";
		volumen_txt.Text = "";
		TextBox2.Text = "";
		zona_txt.Text = "";
		adicional_txt.Text = "";
		prioridad_txt.Text = "";
	}

	private void comprobante_txt_KeyPress(object sender, EventArgs e)
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		if (Operators.CompareString(comprobante_txt.Text, "", TextCompare: true) != 0)
		{
			KeyPressEventArgs keyPressEventArgs = (KeyPressEventArgs)e;
			if (keyPressEventArgs.KeyChar == '\r')
			{
				DataTable dataTable = new DataTable("x");
				string text = "SELECT * FROM PLANCHADA WHERE COMPROBANTE = '" + comprobante_txt.Text + "' order by fecha desc limit 1";
				MySqlDataAdapter val = new MySqlDataAdapter(text, Mod_Sentencias.cnn);
				DataSet dataSet = new DataSet();
				((DbDataAdapter)(object)val).Fill(dataTable);
				cliente_combo.Text = dataTable.Rows[0]["Cliente"].ToString();
				sub_txt.Text = dataTable.Rows[0]["Sub"].ToString();
				destino_combo.Text = dataTable.Rows[0]["Destino"].ToString();
				domicilio_combo.Text = dataTable.Rows[0]["Domicilio"].ToString();
				cp_txt.Text = dataTable.Rows[0]["CP"].ToString();
				localidad_combo.Text = dataTable.Rows[0]["Localidad"].ToString();
				Label22.Text = dataTable.Rows[0]["Eventual"].ToString();
				remito_txt.Text = dataTable.Rows[0]["Remitos"].ToString();
				bultos_txt.Text = dataTable.Rows[0]["Bultos"].ToString();
				declarado_txt.Text = dataTable.Rows[0]["Declarado"].ToString();
				kilos_txt.Text = dataTable.Rows[0]["Kilos"].ToString();
				volumen_txt.Text = dataTable.Rows[0]["Volumen"].ToString();
				zona_txt.Text = dataTable.Rows[0]["Zona"].ToString();
				adicional_txt.Text = dataTable.Rows[0]["Adicional"].ToString();
				prioridad_txt.Text = dataTable.Rows[0]["Prioridad"].ToString();
				observaciones_txt.Text = dataTable.Rows[0]["Observaciones"].ToString();
				TextBox2.Text = dataTable.Rows[0]["Flete"].ToString();
			}
		}
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		string text = Strings.Format(DateTimePicker1.Value, "yyyyMMdd");
		string sQL = ("DELETE FROM PLANCHADA WHERE Comprobante=" + comprobante_txt.Text + " and Fecha =" + text) ?? "";
		int num = Conversions.ToInteger(Mod_ConeccionBD.BD_Sentencia(sQL));
		Interaction.MsgBox(num);
	}
}
