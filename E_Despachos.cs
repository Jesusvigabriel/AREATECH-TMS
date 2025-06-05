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
public class E_Despachos : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("guias_txt")]
	private Label _guias_txt;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("chofer_cb")]
	private ComboBox _chofer_cb;

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
	[AccessedThroughProperty("ListView1")]
	private ListView _ListView1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("qr_check")]
	private CheckBox _qr_check;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("qr_txt")]
	private TextBox _qr_txt;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ListView2")]
	private ListView _ListView2;

	private string fechaActual;

	private int chofer;

	private int NumeroEnvio;

	private ListViewItem O_Item;

	private string direccion;

	private string destino;

	private int TiempoRestante;

	[field: AccessedThroughProperty("GroupBox1")]
	internal virtual GroupBox GroupBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("bultos_txt")]
	internal virtual Label bultos_txt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("bultos_lbl")]
	internal virtual Label bultos_lbl
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Label guias_txt
	{
		[CompilerGenerated]
		get
		{
			return _guias_txt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = guias_txt_TextChanged;
			Label label = _guias_txt;
			if (label != null)
			{
				label.TextChanged -= value2;
			}
			_guias_txt = value;
			label = _guias_txt;
			if (label != null)
			{
				label.TextChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("guias_lbl")]
	internal virtual Label guias_lbl
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("numero_txt")]
	internal virtual Label numero_txt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("numero_lbl")]
	internal virtual Label numero_lbl
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ComboBox chofer_cb
	{
		[CompilerGenerated]
		get
		{
			return _chofer_cb;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = chofer_cb_SelectedIndexChanged;
			ComboBox comboBox = _chofer_cb;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged -= value2;
			}
			_chofer_cb = value;
			comboBox = _chofer_cb;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("chofer_lbl")]
	internal virtual Label chofer_lbl
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

	[field: AccessedThroughProperty("Button1")]
	internal virtual Button Button1
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

	[field: AccessedThroughProperty("Button6")]
	internal virtual Button Button6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Button5")]
	internal virtual Button Button5
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

	[field: AccessedThroughProperty("Button2")]
	internal virtual Button Button2
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
			ListView listView = _ListView1;
			if (listView != null)
			{
				listView.ColumnClick -= value2;
				listView.SelectedIndexChanged -= value3;
			}
			_ListView1 = value;
			listView = _ListView1;
			if (listView != null)
			{
				listView.ColumnClick += value2;
				listView.SelectedIndexChanged += value3;
			}
		}
	}

	internal virtual CheckBox qr_check
	{
		[CompilerGenerated]
		get
		{
			return _qr_check;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = qr_check_CheckedChanged;
			CheckBox checkBox = _qr_check;
			if (checkBox != null)
			{
				checkBox.CheckedChanged -= value2;
			}
			_qr_check = value;
			checkBox = _qr_check;
			if (checkBox != null)
			{
				checkBox.CheckedChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("despachomanual_btn")]
	internal virtual Button despachomanual_btn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("manual_txt")]
	internal virtual TextBox manual_txt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("despacho_lbl")]
	internal virtual Label despacho_lbl
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("despacho_qr_lbl")]
	internal virtual Label despacho_qr_lbl
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual TextBox qr_txt
	{
		[CompilerGenerated]
		get
		{
			return _qr_txt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = qr_txt_LostFocus;
			EventHandler value3 = qr_txt_TextChanged;
			TextBox textBox = _qr_txt;
			if (textBox != null)
			{
				textBox.LostFocus -= value2;
				textBox.TextChanged -= value3;
			}
			_qr_txt = value;
			textBox = _qr_txt;
			if (textBox != null)
			{
				textBox.LostFocus += value2;
				textBox.TextChanged += value3;
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

	internal virtual ListView ListView2
	{
		[CompilerGenerated]
		get
		{
			return _ListView2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			ColumnClickEventHandler value2 = ListView2_ColumnClick;
			EventHandler value3 = ListView2_SelectedIndexChanged;
			ListView listView = _ListView2;
			if (listView != null)
			{
				listView.ColumnClick -= value2;
				listView.SelectedIndexChanged -= value3;
			}
			_ListView2 = value;
			listView = _ListView2;
			if (listView != null)
			{
				listView.ColumnClick += value2;
				listView.SelectedIndexChanged += value3;
			}
		}
	}

	[field: AccessedThroughProperty("id_envio")]
	internal virtual Label id_envio
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public E_Despachos()
	{
		base.Load += E_Despachos_Load;
		fechaActual = Strings.Format(MyProject.Forms.Form1_Inicio.DateTimePicker1.Value, "yyyyMMdd");
		chofer = 0;
		NumeroEnvio = 0;
		direccion = string.Empty;
		destino = string.Empty;
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
		this.GroupBox1 = new System.Windows.Forms.GroupBox();
		this.qr_check = new System.Windows.Forms.CheckBox();
		this.despachomanual_btn = new System.Windows.Forms.Button();
		this.manual_txt = new System.Windows.Forms.TextBox();
		this.despacho_lbl = new System.Windows.Forms.Label();
		this.despacho_qr_lbl = new System.Windows.Forms.Label();
		this.qr_txt = new System.Windows.Forms.TextBox();
		this.bultos_txt = new System.Windows.Forms.Label();
		this.bultos_lbl = new System.Windows.Forms.Label();
		this.guias_txt = new System.Windows.Forms.Label();
		this.guias_lbl = new System.Windows.Forms.Label();
		this.numero_txt = new System.Windows.Forms.Label();
		this.numero_lbl = new System.Windows.Forms.Label();
		this.chofer_cb = new System.Windows.Forms.ComboBox();
		this.chofer_lbl = new System.Windows.Forms.Label();
		this.GroupBox2 = new System.Windows.Forms.GroupBox();
		this.Button6 = new System.Windows.Forms.Button();
		this.Button5 = new System.Windows.Forms.Button();
		this.Button2 = new System.Windows.Forms.Button();
		this.Button1 = new System.Windows.Forms.Button();
		this.Button4 = new System.Windows.Forms.Button();
		this.Button3 = new System.Windows.Forms.Button();
		this.GroupBox3 = new System.Windows.Forms.GroupBox();
		this.id_envio = new System.Windows.Forms.Label();
		this.ListView2 = new System.Windows.Forms.ListView();
		this.ListView1 = new System.Windows.Forms.ListView();
		this.Timer1 = new System.Windows.Forms.Timer(this.components);
		this.GroupBox1.SuspendLayout();
		this.GroupBox2.SuspendLayout();
		this.GroupBox3.SuspendLayout();
		base.SuspendLayout();
		this.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.GroupBox1.Controls.Add(this.qr_check);
		this.GroupBox1.Controls.Add(this.despachomanual_btn);
		this.GroupBox1.Controls.Add(this.manual_txt);
		this.GroupBox1.Controls.Add(this.despacho_lbl);
		this.GroupBox1.Controls.Add(this.despacho_qr_lbl);
		this.GroupBox1.Controls.Add(this.qr_txt);
		this.GroupBox1.Controls.Add(this.bultos_txt);
		this.GroupBox1.Controls.Add(this.bultos_lbl);
		this.GroupBox1.Controls.Add(this.guias_txt);
		this.GroupBox1.Controls.Add(this.guias_lbl);
		this.GroupBox1.Controls.Add(this.numero_txt);
		this.GroupBox1.Controls.Add(this.numero_lbl);
		this.GroupBox1.Controls.Add(this.chofer_cb);
		this.GroupBox1.Controls.Add(this.chofer_lbl);
		this.GroupBox1.Location = new System.Drawing.Point(12, 14);
		this.GroupBox1.Name = "GroupBox1";
		this.GroupBox1.Size = new System.Drawing.Size(1019, 100);
		this.GroupBox1.TabIndex = 0;
		this.GroupBox1.TabStop = false;
		this.GroupBox1.Text = "Información";
		this.qr_check.AutoSize = true;
		this.qr_check.Location = new System.Drawing.Point(921, 24);
		this.qr_check.Name = "qr_check";
		this.qr_check.Size = new System.Drawing.Size(66, 17);
		this.qr_check.TabIndex = 11;
		this.qr_check.Text = "Leer QR";
		this.qr_check.UseVisualStyleBackColor = true;
		this.despachomanual_btn.Location = new System.Drawing.Point(921, 52);
		this.despachomanual_btn.Name = "despachomanual_btn";
		this.despachomanual_btn.Size = new System.Drawing.Size(75, 23);
		this.despachomanual_btn.TabIndex = 10;
		this.despachomanual_btn.Text = "Despachar";
		this.despachomanual_btn.UseVisualStyleBackColor = true;
		this.despachomanual_btn.Visible = false;
		this.manual_txt.Location = new System.Drawing.Point(754, 54);
		this.manual_txt.Name = "manual_txt";
		this.manual_txt.Size = new System.Drawing.Size(139, 20);
		this.manual_txt.TabIndex = 9;
		this.manual_txt.Visible = false;
		this.despacho_lbl.AutoSize = true;
		this.despacho_lbl.Location = new System.Drawing.Point(644, 57);
		this.despacho_lbl.Name = "despacho_lbl";
		this.despacho_lbl.Size = new System.Drawing.Size(97, 13);
		this.despacho_lbl.TabIndex = 8;
		this.despacho_lbl.Text = "Despacho Manual:";
		this.despacho_lbl.Visible = false;
		this.despacho_qr_lbl.AutoSize = true;
		this.despacho_qr_lbl.Location = new System.Drawing.Point(644, 25);
		this.despacho_qr_lbl.Name = "despacho_qr_lbl";
		this.despacho_qr_lbl.Size = new System.Drawing.Size(78, 13);
		this.despacho_qr_lbl.TabIndex = 6;
		this.despacho_qr_lbl.Text = "Despacho QR:";
		this.qr_txt.Location = new System.Drawing.Point(754, 22);
		this.qr_txt.Name = "qr_txt";
		this.qr_txt.Size = new System.Drawing.Size(139, 20);
		this.qr_txt.TabIndex = 7;
		this.bultos_txt.AutoSize = true;
		this.bultos_txt.Location = new System.Drawing.Point(483, 57);
		this.bultos_txt.Name = "bultos_txt";
		this.bultos_txt.Size = new System.Drawing.Size(13, 13);
		this.bultos_txt.TabIndex = 7;
		this.bultos_txt.Text = "0";
		this.bultos_txt.Visible = false;
		this.bultos_lbl.AutoSize = true;
		this.bultos_lbl.Location = new System.Drawing.Point(414, 57);
		this.bultos_lbl.Name = "bultos_lbl";
		this.bultos_lbl.Size = new System.Drawing.Size(39, 13);
		this.bultos_lbl.TabIndex = 6;
		this.bultos_lbl.Text = "Bultos:";
		this.bultos_lbl.Visible = false;
		this.guias_txt.AutoSize = true;
		this.guias_txt.Location = new System.Drawing.Point(483, 25);
		this.guias_txt.Name = "guias_txt";
		this.guias_txt.Size = new System.Drawing.Size(13, 13);
		this.guias_txt.TabIndex = 5;
		this.guias_txt.Text = "0";
		this.guias_lbl.AutoSize = true;
		this.guias_lbl.Location = new System.Drawing.Point(414, 25);
		this.guias_lbl.Name = "guias_lbl";
		this.guias_lbl.Size = new System.Drawing.Size(37, 13);
		this.guias_lbl.TabIndex = 4;
		this.guias_lbl.Text = "Guias:";
		this.numero_txt.AutoSize = true;
		this.numero_txt.Location = new System.Drawing.Point(81, 57);
		this.numero_txt.Name = "numero_txt";
		this.numero_txt.Size = new System.Drawing.Size(13, 13);
		this.numero_txt.TabIndex = 3;
		this.numero_txt.Text = "0";
		this.numero_lbl.AutoSize = true;
		this.numero_lbl.Location = new System.Drawing.Point(28, 57);
		this.numero_lbl.Name = "numero_lbl";
		this.numero_lbl.Size = new System.Drawing.Size(47, 13);
		this.numero_lbl.TabIndex = 2;
		this.numero_lbl.Text = "Numero:";
		this.chofer_cb.FormattingEnabled = true;
		this.chofer_cb.Location = new System.Drawing.Point(81, 22);
		this.chofer_cb.Name = "chofer_cb";
		this.chofer_cb.Size = new System.Drawing.Size(270, 21);
		this.chofer_cb.TabIndex = 1;
		this.chofer_lbl.AutoSize = true;
		this.chofer_lbl.Location = new System.Drawing.Point(28, 25);
		this.chofer_lbl.Name = "chofer_lbl";
		this.chofer_lbl.Size = new System.Drawing.Size(41, 13);
		this.chofer_lbl.TabIndex = 0;
		this.chofer_lbl.Text = "Chofer:";
		this.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.GroupBox2.Controls.Add(this.Button6);
		this.GroupBox2.Controls.Add(this.Button5);
		this.GroupBox2.Controls.Add(this.Button2);
		this.GroupBox2.Controls.Add(this.Button1);
		this.GroupBox2.Location = new System.Drawing.Point(12, 120);
		this.GroupBox2.Name = "GroupBox2";
		this.GroupBox2.Size = new System.Drawing.Size(1020, 50);
		this.GroupBox2.TabIndex = 1;
		this.GroupBox2.TabStop = false;
		this.GroupBox2.Text = "Opciones";
		this.Button6.Location = new System.Drawing.Point(436, 19);
		this.Button6.Name = "Button6";
		this.Button6.Size = new System.Drawing.Size(75, 23);
		this.Button6.TabIndex = 5;
		this.Button6.Text = "Button6";
		this.Button6.UseVisualStyleBackColor = true;
		this.Button6.Visible = false;
		this.Button5.Location = new System.Drawing.Point(355, 19);
		this.Button5.Name = "Button5";
		this.Button5.Size = new System.Drawing.Size(75, 23);
		this.Button5.TabIndex = 4;
		this.Button5.Text = "Button5";
		this.Button5.UseVisualStyleBackColor = true;
		this.Button5.Visible = false;
		this.Button2.Location = new System.Drawing.Point(112, 19);
		this.Button2.Name = "Button2";
		this.Button2.Size = new System.Drawing.Size(75, 23);
		this.Button2.TabIndex = 1;
		this.Button2.Text = "Button2";
		this.Button2.UseVisualStyleBackColor = true;
		this.Button2.Visible = false;
		this.Button1.Location = new System.Drawing.Point(31, 19);
		this.Button1.Name = "Button1";
		this.Button1.Size = new System.Drawing.Size(75, 23);
		this.Button1.TabIndex = 0;
		this.Button1.Text = "Button1";
		this.Button1.UseVisualStyleBackColor = true;
		this.Button1.Visible = false;
		this.Button4.Location = new System.Drawing.Point(477, 54);
		this.Button4.Name = "Button4";
		this.Button4.Size = new System.Drawing.Size(65, 23);
		this.Button4.TabIndex = 3;
		this.Button4.Text = "<<";
		this.Button4.UseVisualStyleBackColor = true;
		this.Button3.Location = new System.Drawing.Point(477, 25);
		this.Button3.Name = "Button3";
		this.Button3.Size = new System.Drawing.Size(65, 23);
		this.Button3.TabIndex = 2;
		this.Button3.Text = ">>";
		this.Button3.UseVisualStyleBackColor = true;
		this.GroupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.GroupBox3.Controls.Add(this.id_envio);
		this.GroupBox3.Controls.Add(this.ListView2);
		this.GroupBox3.Controls.Add(this.ListView1);
		this.GroupBox3.Controls.Add(this.Button4);
		this.GroupBox3.Controls.Add(this.Button3);
		this.GroupBox3.Location = new System.Drawing.Point(12, 185);
		this.GroupBox3.Name = "GroupBox3";
		this.GroupBox3.Size = new System.Drawing.Size(1019, 294);
		this.GroupBox3.TabIndex = 2;
		this.GroupBox3.TabStop = false;
		this.GroupBox3.Text = "Ruta Despachada";
		this.id_envio.AutoSize = true;
		this.id_envio.Location = new System.Drawing.Point(483, 89);
		this.id_envio.Name = "id_envio";
		this.id_envio.Size = new System.Drawing.Size(13, 13);
		this.id_envio.TabIndex = 4;
		this.id_envio.Text = "0";
		this.id_envio.Visible = false;
		this.ListView2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		this.ListView2.Location = new System.Drawing.Point(548, 25);
		this.ListView2.Name = "ListView2";
		this.ListView2.Size = new System.Drawing.Size(465, 263);
		this.ListView2.TabIndex = 1;
		this.ListView2.UseCompatibleStateImageBehavior = false;
		this.ListView1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.ListView1.Location = new System.Drawing.Point(6, 25);
		this.ListView1.Name = "ListView1";
		this.ListView1.Size = new System.Drawing.Size(465, 263);
		this.ListView1.TabIndex = 0;
		this.ListView1.UseCompatibleStateImageBehavior = false;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(1043, 491);
		base.Controls.Add(this.GroupBox3);
		base.Controls.Add(this.GroupBox2);
		base.Controls.Add(this.GroupBox1);
		base.Name = "E_Despachos";
		this.Text = "Despacho Etrans";
		this.GroupBox1.ResumeLayout(false);
		this.GroupBox1.PerformLayout();
		this.GroupBox2.ResumeLayout(false);
		this.GroupBox3.ResumeLayout(false);
		this.GroupBox3.PerformLayout();
		base.ResumeLayout(false);
	}

	private void E_Despachos_Load(object sender, EventArgs e)
	{
		Interaction.MsgBox("Seleccione un chofer y marque la casilla Leer QR para utilizar el escaner");
		if (!Operators.ConditionalCompareObjectEqual(Mod_Tareas_comunes.choferes_a_combo(chofer_cb), true, TextCompare: true))
		{
		}
	}

	private void chofer_cb_SelectedIndexChanged(object sender, EventArgs e)
	{
		string sql = "SELECT numero FROM flota where chofer='" + chofer_cb.Text + "'";
		DataTable dataTable = (DataTable)Mod_Sentencias.data(sql);
		chofer = Conversions.ToInteger(dataTable.Rows[0]["numero"]);
		if (dataTable.Rows.Count > 0)
		{
			numero_txt.Text = dataTable.Rows[0]["numero"].ToString();
			cargar_ruta_despachada(chofer);
			cargar_ruta_lv(chofer);
		}
	}

	private void qr_check_CheckedChanged(object sender, EventArgs e)
	{
		if (qr_check.Checked)
		{
			qr_txt.Focus();
		}
	}

	private void qr_txt_LostFocus(object sender, EventArgs e)
	{
		if (qr_check.Checked)
		{
			qr_txt.Focus();
		}
	}

	private void ListView1_ColumnClick(object sender, ColumnClickEventArgs e)
	{
		Mod_Ordenaclumnas.ordenar_columnas(ListView1, RuntimeHelpers.GetObjectValue(sender), e);
	}

	private void ListView2_ColumnClick(object sender, ColumnClickEventArgs e)
	{
		Mod_Ordenaclumnas.ordenar_columnas(ListView2, RuntimeHelpers.GetObjectValue(sender), e);
	}

	private void qr_txt_TextChanged(object sender, EventArgs e)
	{
		if (Operators.CompareString(qr_txt.Text, "", TextCompare: true) != 0)
		{
			TiempoEjecutar(1);
		}
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
				TiempoRestante--;
				return;
			}
			Timer1.Enabled = false;
			try
			{
				NumeroEnvio = Conversions.ToInteger(Strings.Mid(qr_txt.Text, 1, Strings.Len(qr_txt.Text) - 1));
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Interaction.MsgBox("El valor ingresado no es un numero");
				qr_txt.Text = "";
				ProjectData.ClearProjectError();
				return;
			}
			leerNumero(NumeroEnvio);
		}
	}

	private void leerNumero(int id_envio)
	{
		if (O_Item == null)
		{
			try
			{
				string text = Strings.Format(MyProject.Forms.Form1_Inicio.DateTimePicker1.Value, "yyyyMMdd");
				string sql = "SELECT chofer, sub, estado, Destino, Domicilio, CP, ventana  FROM planchada WHERE cliente='ETRANS' AND comprobante=" + Conversions.ToString(id_envio) + " AND fecha='" + fechaActual + "'";
				DataTable dataTable = (DataTable)Mod_Sentencias.data(sql);
				string left = dataTable.Rows[0]["estado"].ToString();
				int num = Conversions.ToInteger(dataTable.Rows[0]["ventana"]);
				string text2 = MyProject.Forms.Form1_Inicio.nombreusuario.Text;
				if (Operators.CompareString(dataTable.Rows[0]["chofer"].ToString(), numero_txt.Text, TextCompare: true) == 0)
				{
					if (Operators.CompareString(left, "Ruteado", TextCompare: true) == 0)
					{
						if (Conversions.ToDouble(dataTable.Rows[0]["sub"].ToString()) == 11.0)
						{
							despachar_retiros(id_envio);
							Mod_Etrans.actualizar_estados(id_envio, "EN RECOLECCION");
							cargar_ruta_despachada(chofer);
							cargar_ruta_lv(chofer);
						}
						else
						{
							string sQL = "UPDATE planchada SET estado='DESPACHADO', chofer=" + Conversions.ToString(chofer) + " WHERE cliente='ETRANS' AND comprobante=" + Conversions.ToString(id_envio) + " AND fecha ='" + fechaActual + "'";
							Mod_ConeccionBD.BD_Sentencia(sQL);
							Mod_Etrans.actualizar_estados(id_envio, "DESPACHADO");
							cargar_ruta_despachada(chofer);
							cargar_ruta_lv(chofer);
						}
					}
					else if (Operators.CompareString(left, "EN RECOLECCION", TextCompare: true) == 0)
					{
						cancelar_retiros(id_envio);
						Mod_Etrans.actualizar_estados(id_envio, "Ruteado");
						cargar_ruta_despachada(chofer);
						cargar_ruta_lv(chofer);
					}
					else if (Operators.CompareString(left, "DESPACHADO", TextCompare: true) == 0)
					{
						string sQL2 = "UPDATE planchada SET estado='Ruteado', chofer=" + Conversions.ToString(chofer) + ", viaje=0 WHERE cliente='ETRANS' AND comprobante=" + Conversions.ToString(id_envio) + " AND fecha ='" + fechaActual + "'";
						Mod_ConeccionBD.BD_Sentencia(sQL2);
						Mod_Etrans.actualizar_estados(id_envio, "Ruteado");
						cargar_ruta_despachada(chofer);
						cargar_ruta_lv(chofer);
					}
				}
				else
				{
					Interaction.MsgBox("El chofer no coincide");
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Interaction.MsgBox("Existe un error con el dato ingresado");
				qr_txt.Text = "";
				ProjectData.ClearProjectError();
			}
		}
		else
		{
			string text3 = O_Item.ToString();
			string text4 = text3.Substring(15, checked(qr_txt.TextLength - 1));
			if (Conversions.ToDouble(text4) == (double)id_envio)
			{
				Interaction.MsgBox("ya fue escaneado " + text4 + " - " + Conversions.ToString(id_envio));
			}
		}
		qr_txt.Text = "";
	}

	private void guias_txt_TextChanged(object sender, EventArgs e)
	{
		if (Conversions.ToDouble(guias_txt.Text) > 0.0)
		{
			bultos_lbl.Visible = true;
			bultos_txt.Visible = true;
		}
		else
		{
			bultos_lbl.Visible = false;
			bultos_txt.Visible = false;
		}
	}

	private void cargar_ruta_lv(int chofer)
	{
		string sql = "SELECT comprobante, destino, domicilio, bultos, CP, localidad, chofer, estado FROM planchada WHERE cliente='ETRANS' AND estado='Ruteado' AND chofer=" + Conversions.ToString(chofer) + " AND fecha='" + fechaActual + "'";
		ListView listView = ListView1;
		listView.Items.Clear();
		listView.Columns.Clear();
		listView = null;
		Mod_Sentencias.cargar_datos_lv_completa(ListView1, sql, guias_txt);
	}

	private void cargar_ruta_despachada(int chofer)
	{
		string sql = "SELECT comprobante, destino, domicilio, bultos, CP, localidad, chofer, estado FROM planchada WHERE cliente='ETRANS' AND estado='DESPACHADO' AND chofer=" + Conversions.ToString(chofer) + " AND fecha='" + fechaActual + "' OR cliente='ETRANS' AND estado='EN RECOLECCION' AND chofer=" + Conversions.ToString(chofer) + " AND fecha='" + fechaActual + "'";
		ListView listView = ListView2;
		listView.Items.Clear();
		listView.Columns.Clear();
		listView = null;
		Mod_Sentencias.cargar_datos_lv_completa(ListView2, sql, guias_txt);
	}

	private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (ListView1.SelectedItems.Count > 0)
		{
			int index = ListView1.SelectedIndices[0];
			destino = ListView1.Items[index].SubItems[1].Text;
			direccion = ListView1.Items[index].SubItems[2].Text;
			id_envio.Text = ListView1.Items[index].Text;
			O_Item = ListView1.FindItemWithText(id_envio.ToString());
		}
		ListView1.Refresh();
	}

	private void ListView2_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (ListView2.SelectedItems.Count > 0)
		{
			int index = ListView2.SelectedIndices[0];
			destino = ListView2.Items[index].SubItems[1].Text;
			direccion = ListView2.Items[index].SubItems[2].Text;
			id_envio.Text = ListView2.Items[index].Text;
			O_Item = ListView2.FindItemWithText(id_envio.ToString());
		}
		ListView2.Refresh();
	}

	private void Button3_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(id_envio.Text, "0", TextCompare: true) == 0)
		{
			Interaction.MsgBox("Seleccione un envio");
			return;
		}
		NumeroEnvio = Conversions.ToInteger(id_envio.Text);
		leerNumero(NumeroEnvio);
		id_envio.Text = "0";
	}

	private void Button4_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(id_envio.Text, "0", TextCompare: true) == 0)
		{
			Interaction.MsgBox("Seleccione un envio");
			return;
		}
		NumeroEnvio = Conversions.ToInteger(id_envio.Text);
		leerNumero(NumeroEnvio);
		id_envio.Text = "0";
	}

	private void despachar_retiros(int id_envio)
	{
		string sql = "SELECT comprobante FROM planchada WHERE domicilio ='" + direccion + "' AND destino='" + destino + "' AND fecha ='" + fechaActual + "'";
		DataTable dataTable = (DataTable)Mod_Sentencias.data(sql);
		checked
		{
			int num = dataTable.Rows.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				string sQL = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("UPDATE planchada Set estado='EN RECOLECCION', chofer=" + Conversions.ToString(chofer) + " WHERE cliente='ETRANS' AND comprobante=", dataTable.Rows[i]["comprobante"]), " AND fecha ='"), fechaActual), "'"));
				Mod_ConeccionBD.BD_Sentencia(sQL);
				Mod_Etrans.actualizar_estados(Conversions.ToInteger(dataTable.Rows[i]["comprobante"]), "EN RECOLECCION");
			}
		}
	}

	private void cancelar_retiros(int id_envio)
	{
		string sql = "SELECT comprobante FROM planchada WHERE domicilio ='" + direccion + "' AND destino='" + destino + "' AND fecha ='" + fechaActual + "'";
		DataTable dataTable = (DataTable)Mod_Sentencias.data(sql);
		checked
		{
			int num = dataTable.Rows.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				string sQL = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("UPDATE planchada Set estado='Ruteado', chofer=" + Conversions.ToString(chofer) + ", viaje=0  WHERE cliente='ETRANS' AND comprobante=", dataTable.Rows[i]["comprobante"]), " AND fecha ='"), fechaActual), "'"));
				Mod_ConeccionBD.BD_Sentencia(sQL);
				Mod_Etrans.actualizar_estados(Conversions.ToInteger(dataTable.Rows[i]["comprobante"]), "Ruteado");
			}
		}
	}
}
