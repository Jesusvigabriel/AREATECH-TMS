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
public class Novedades : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ComboBox2")]
	private ComboBox _ComboBox2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DateTimePicker2")]
	private DateTimePicker _DateTimePicker2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DateTimePicker1")]
	private DateTimePicker _DateTimePicker1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ListView1")]
	private ListView _ListView1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

	private int TiempoRestante;

	private int TiempoRestante1;

	[field: AccessedThroughProperty("SplitContainer1")]
	internal virtual SplitContainer SplitContainer1
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

	internal virtual ComboBox ComboBox2
	{
		[CompilerGenerated]
		get
		{
			return _ComboBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ComboBox2_SelectedIndexChanged;
			ComboBox comboBox = _ComboBox2;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged -= value2;
			}
			_ComboBox2 = value;
			comboBox = _ComboBox2;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label4")]
	internal virtual Label Label4
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

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DateTimePicker DateTimePicker2
	{
		[CompilerGenerated]
		get
		{
			return _DateTimePicker2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DateTimePicker2_ValueChanged;
			DateTimePicker dateTimePicker = _DateTimePicker2;
			if (dateTimePicker != null)
			{
				dateTimePicker.ValueChanged -= value2;
			}
			_DateTimePicker2 = value;
			dateTimePicker = _DateTimePicker2;
			if (dateTimePicker != null)
			{
				dateTimePicker.ValueChanged += value2;
			}
		}
	}

	internal virtual DateTimePicker DateTimePicker1
	{
		[CompilerGenerated]
		get
		{
			return _DateTimePicker1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DateTimePicker1_ValueChanged;
			DateTimePicker dateTimePicker = _DateTimePicker1;
			if (dateTimePicker != null)
			{
				dateTimePicker.ValueChanged -= value2;
			}
			_DateTimePicker1 = value;
			dateTimePicker = _DateTimePicker1;
			if (dateTimePicker != null)
			{
				dateTimePicker.ValueChanged += value2;
			}
		}
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
			EventHandler value3 = ListView1_DoubleClick;
			ListView listView = _ListView1;
			if (listView != null)
			{
				listView.ColumnClick -= value2;
				listView.DoubleClick -= value3;
			}
			_ListView1 = value;
			listView = _ListView1;
			if (listView != null)
			{
				listView.ColumnClick += value2;
				listView.DoubleClick += value3;
			}
		}
	}

	[field: AccessedThroughProperty("Label5")]
	internal virtual Label Label5
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
			EventHandler value3 = Timer2_Tick;
			Timer timer = _Timer1;
			if (timer != null)
			{
				timer.Tick -= value2;
				timer.Tick -= value3;
			}
			_Timer1 = value;
			timer = _Timer1;
			if (timer != null)
			{
				timer.Tick += value2;
				timer.Tick += value3;
			}
		}
	}

	[field: AccessedThroughProperty("Chofer")]
	internal virtual ColumnHeader Chofer
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Ventana")]
	internal virtual ColumnHeader Ventana
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Comprobante")]
	internal virtual ColumnHeader Comprobante
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Cliente")]
	internal virtual ColumnHeader Cliente
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Destino")]
	internal virtual ColumnHeader Destino
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Remitos")]
	internal virtual ColumnHeader Remitos
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Bultos")]
	internal virtual ColumnHeader Bultos
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

	[field: AccessedThroughProperty("Fecha")]
	internal virtual ColumnHeader Fecha
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

	[field: AccessedThroughProperty("Comentario")]
	internal virtual ColumnHeader Comentario
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Observaciones")]
	internal virtual ColumnHeader Observaciones
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("BackgroundWorker1")]
	internal virtual BackgroundWorker BackgroundWorker1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Timer2")]
	internal virtual Timer Timer2
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

	[field: AccessedThroughProperty("subcuenta")]
	internal virtual ColumnHeader subcuenta
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ComboBox3")]
	internal virtual ComboBox ComboBox3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("noved")]
	internal virtual ColumnHeader noved
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Usuario_")]
	internal virtual ColumnHeader Usuario_
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Atraso")]
	internal virtual ColumnHeader Atraso
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Diferido")]
	internal virtual ColumnHeader Diferido
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public Novedades()
	{
		base.Load += Novedades_Load;
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
		this.SplitContainer1 = new System.Windows.Forms.SplitContainer();
		this.ComboBox3 = new System.Windows.Forms.ComboBox();
		this.Label9 = new System.Windows.Forms.Label();
		this.Label8 = new System.Windows.Forms.Label();
		this.Label7 = new System.Windows.Forms.Label();
		this.Label6 = new System.Windows.Forms.Label();
		this.Label5 = new System.Windows.Forms.Label();
		this.Button2 = new System.Windows.Forms.Button();
		this.Button1 = new System.Windows.Forms.Button();
		this.ComboBox2 = new System.Windows.Forms.ComboBox();
		this.Label4 = new System.Windows.Forms.Label();
		this.ComboBox1 = new System.Windows.Forms.ComboBox();
		this.Label3 = new System.Windows.Forms.Label();
		this.DateTimePicker2 = new System.Windows.Forms.DateTimePicker();
		this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
		this.Label2 = new System.Windows.Forms.Label();
		this.Label1 = new System.Windows.Forms.Label();
		this.ListView1 = new System.Windows.Forms.ListView();
		this.Chofer = new System.Windows.Forms.ColumnHeader();
		this.Ventana = new System.Windows.Forms.ColumnHeader();
		this.Comprobante = new System.Windows.Forms.ColumnHeader();
		this.Cliente = new System.Windows.Forms.ColumnHeader();
		this.subcuenta = new System.Windows.Forms.ColumnHeader();
		this.Atraso = new System.Windows.Forms.ColumnHeader();
		this.Destino = new System.Windows.Forms.ColumnHeader();
		this.Remitos = new System.Windows.Forms.ColumnHeader();
		this.Bultos = new System.Windows.Forms.ColumnHeader();
		this.Estado = new System.Windows.Forms.ColumnHeader();
		this.Fecha = new System.Windows.Forms.ColumnHeader();
		this.Diferido = new System.Windows.Forms.ColumnHeader();
		this.Observaciones = new System.Windows.Forms.ColumnHeader();
		this.Comentario = new System.Windows.Forms.ColumnHeader();
		this.noved = new System.Windows.Forms.ColumnHeader();
		this.Usuario_ = new System.Windows.Forms.ColumnHeader();
		this.Timer1 = new System.Windows.Forms.Timer(this.components);
		this.BackgroundWorker1 = new System.ComponentModel.BackgroundWorker();
		this.Timer2 = new System.Windows.Forms.Timer(this.components);
		((System.ComponentModel.ISupportInitialize)this.SplitContainer1).BeginInit();
		this.SplitContainer1.Panel1.SuspendLayout();
		this.SplitContainer1.Panel2.SuspendLayout();
		this.SplitContainer1.SuspendLayout();
		base.SuspendLayout();
		this.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.SplitContainer1.Location = new System.Drawing.Point(0, 0);
		this.SplitContainer1.Name = "SplitContainer1";
		this.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
		this.SplitContainer1.Panel1.Controls.Add(this.ComboBox3);
		this.SplitContainer1.Panel1.Controls.Add(this.Label9);
		this.SplitContainer1.Panel1.Controls.Add(this.Label8);
		this.SplitContainer1.Panel1.Controls.Add(this.Label7);
		this.SplitContainer1.Panel1.Controls.Add(this.Label6);
		this.SplitContainer1.Panel1.Controls.Add(this.Label5);
		this.SplitContainer1.Panel1.Controls.Add(this.Button2);
		this.SplitContainer1.Panel1.Controls.Add(this.Button1);
		this.SplitContainer1.Panel1.Controls.Add(this.ComboBox2);
		this.SplitContainer1.Panel1.Controls.Add(this.Label4);
		this.SplitContainer1.Panel1.Controls.Add(this.ComboBox1);
		this.SplitContainer1.Panel1.Controls.Add(this.Label3);
		this.SplitContainer1.Panel1.Controls.Add(this.DateTimePicker2);
		this.SplitContainer1.Panel1.Controls.Add(this.DateTimePicker1);
		this.SplitContainer1.Panel1.Controls.Add(this.Label2);
		this.SplitContainer1.Panel1.Controls.Add(this.Label1);
		this.SplitContainer1.Panel2.Controls.Add(this.ListView1);
		this.SplitContainer1.Size = new System.Drawing.Size(899, 481);
		this.SplitContainer1.SplitterDistance = 79;
		this.SplitContainer1.TabIndex = 0;
		this.ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.ComboBox3.FormattingEnabled = true;
		this.ComboBox3.Items.AddRange(new object[2] { "Todos", "Mis Clientes" });
		this.ComboBox3.Location = new System.Drawing.Point(639, 45);
		this.ComboBox3.Name = "ComboBox3";
		this.ComboBox3.Size = new System.Drawing.Size(121, 21);
		this.ComboBox3.TabIndex = 15;
		this.Label9.AutoSize = true;
		this.Label9.Location = new System.Drawing.Point(324, 59);
		this.Label9.Name = "Label9";
		this.Label9.Size = new System.Drawing.Size(39, 13);
		this.Label9.TabIndex = 14;
		this.Label9.Text = "Label9";
		this.Label9.Visible = false;
		this.Label8.AutoSize = true;
		this.Label8.Location = new System.Drawing.Point(324, 37);
		this.Label8.Name = "Label8";
		this.Label8.Size = new System.Drawing.Size(39, 13);
		this.Label8.TabIndex = 13;
		this.Label8.Text = "Label8";
		this.Label7.AutoSize = true;
		this.Label7.Location = new System.Drawing.Point(278, 55);
		this.Label7.Name = "Label7";
		this.Label7.Size = new System.Drawing.Size(13, 13);
		this.Label7.TabIndex = 12;
		this.Label7.Text = "0";
		this.Label6.AutoSize = true;
		this.Label6.Location = new System.Drawing.Point(194, 54);
		this.Label6.Name = "Label6";
		this.Label6.Size = new System.Drawing.Size(78, 13);
		this.Label6.TabIndex = 11;
		this.Label6.Text = "Comprobantes:";
		this.Label5.AutoSize = true;
		this.Label5.Location = new System.Drawing.Point(557, 48);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(39, 13);
		this.Label5.TabIndex = 10;
		this.Label5.Text = "Label5";
		this.Button2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.Button2.Location = new System.Drawing.Point(812, 49);
		this.Button2.Name = "Button2";
		this.Button2.Size = new System.Drawing.Size(75, 23);
		this.Button2.TabIndex = 9;
		this.Button2.Text = "Exportar";
		this.Button2.UseVisualStyleBackColor = true;
		this.Button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.Button1.Location = new System.Drawing.Point(812, 11);
		this.Button1.Name = "Button1";
		this.Button1.Size = new System.Drawing.Size(75, 23);
		this.Button1.TabIndex = 8;
		this.Button1.Text = "Generar";
		this.Button1.UseVisualStyleBackColor = true;
		this.ComboBox2.FormattingEnabled = true;
		this.ComboBox2.Location = new System.Drawing.Point(560, 13);
		this.ComboBox2.Name = "ComboBox2";
		this.ComboBox2.Size = new System.Drawing.Size(200, 21);
		this.ComboBox2.TabIndex = 7;
		this.Label4.AutoSize = true;
		this.Label4.Location = new System.Drawing.Point(512, 16);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(41, 13);
		this.Label4.TabIndex = 6;
		this.Label4.Text = "Chofer:";
		this.ComboBox1.FormattingEnabled = true;
		this.ComboBox1.Location = new System.Drawing.Point(242, 13);
		this.ComboBox1.Name = "ComboBox1";
		this.ComboBox1.Size = new System.Drawing.Size(200, 21);
		this.ComboBox1.TabIndex = 5;
		this.Label3.AutoSize = true;
		this.Label3.Location = new System.Drawing.Point(194, 16);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(42, 13);
		this.Label3.TabIndex = 4;
		this.Label3.Text = "Cliente:";
		this.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
		this.DateTimePicker2.Location = new System.Drawing.Point(61, 48);
		this.DateTimePicker2.Name = "DateTimePicker2";
		this.DateTimePicker2.Size = new System.Drawing.Size(108, 20);
		this.DateTimePicker2.TabIndex = 3;
		this.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
		this.DateTimePicker1.Location = new System.Drawing.Point(61, 13);
		this.DateTimePicker1.Name = "DateTimePicker1";
		this.DateTimePicker1.Size = new System.Drawing.Size(108, 20);
		this.DateTimePicker1.TabIndex = 2;
		this.Label2.AutoSize = true;
		this.Label2.Location = new System.Drawing.Point(14, 53);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(38, 13);
		this.Label2.TabIndex = 1;
		this.Label2.Text = "Hasta:";
		this.Label1.AutoSize = true;
		this.Label1.Location = new System.Drawing.Point(14, 16);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(41, 13);
		this.Label1.TabIndex = 0;
		this.Label1.Text = "Desde:";
		this.ListView1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.ListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[16]
		{
			this.Chofer, this.Ventana, this.Comprobante, this.Cliente, this.subcuenta, this.Atraso, this.Destino, this.Remitos, this.Bultos, this.Estado,
			this.Fecha, this.Diferido, this.Observaciones, this.Comentario, this.noved, this.Usuario_
		});
		this.ListView1.FullRowSelect = true;
		this.ListView1.GridLines = true;
		this.ListView1.Location = new System.Drawing.Point(3, 3);
		this.ListView1.Name = "ListView1";
		this.ListView1.Size = new System.Drawing.Size(893, 392);
		this.ListView1.TabIndex = 0;
		this.ListView1.UseCompatibleStateImageBehavior = false;
		this.ListView1.View = System.Windows.Forms.View.Details;
		this.Chofer.Text = "Chofer";
		this.Chofer.Width = 100;
		this.Ventana.Text = "Ventana";
		this.Ventana.Width = 50;
		this.Comprobante.Text = "Comprobante";
		this.Comprobante.Width = 70;
		this.Cliente.Text = "Cliente";
		this.Cliente.Width = 77;
		this.subcuenta.Text = "Sub";
		this.Atraso.Text = "Atraso";
		this.Atraso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		this.Destino.Text = "Destino";
		this.Destino.Width = 91;
		this.Remitos.Text = "Remitos";
		this.Remitos.Width = 120;
		this.Bultos.Text = "Bultos";
		this.Bultos.Width = 35;
		this.Estado.Text = "Estado";
		this.Estado.Width = 80;
		this.Fecha.Text = "Fecha";
		this.Fecha.Width = 70;
		this.Diferido.Text = "Diferido";
		this.Observaciones.Text = "Observaciones";
		this.Comentario.Text = "Comentario";
		this.noved.Text = "Novedades";
		this.Usuario_.Text = "Usuario";
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(899, 481);
		base.Controls.Add(this.SplitContainer1);
		base.Name = "Novedades";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Novedades";
		base.WindowState = System.Windows.Forms.FormWindowState.Maximized;
		this.SplitContainer1.Panel1.ResumeLayout(false);
		this.SplitContainer1.Panel1.PerformLayout();
		this.SplitContainer1.Panel2.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.SplitContainer1).EndInit();
		this.SplitContainer1.ResumeLayout(false);
		base.ResumeLayout(false);
	}

	private void Novedades_Load(object sender, EventArgs e)
	{
		ComboBox3.SelectedIndex = 0;
		cargar_chof();
		cargar_cliente();
		TiempoEjecutar(300);
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		ejecutarconsulta();
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		string text = "Exp_Novedades_" + MySettingsProperty.Settings.Usuario;
		string sql = MySettingsProperty.Settings.sql;
		SaveFileDialog saveFileDialog = new SaveFileDialog();
		saveFileDialog.Filter = "Excel files(*.xlsx)|*xlsx";
		saveFileDialog.Title = "Guardar Archivo";
		saveFileDialog.ShowDialog();
		string fileName = saveFileDialog.FileName;
		if (Operators.CompareString(fileName, "", TextCompare: true) != 0)
		{
			Mod_Exportar.exp_excel_dir(sql, fileName);
		}
	}

	private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		DataTable dataTable = new DataTable("x");
		string text = "SELECT Numero FROM Flota where chofer= '" + ComboBox2.Text + "'";
		MySqlDataAdapter val = new MySqlDataAdapter(text, Mod_Sentencias.cnn);
		DataSet dataSet = new DataSet();
		((DbDataAdapter)(object)val).Fill(dataTable);
		Label5.Text = dataTable.Rows[0]["Numero"].ToString();
	}

	private void ListView1_ColumnClick(object sender, ColumnClickEventArgs e)
	{
		Mod_Ordenaclumnas.ordenar_columnas(ListView1, RuntimeHelpers.GetObjectValue(sender), e);
	}

	private void ListView1_DoubleClick(object sender, EventArgs e)
	{
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected O, but got Unknown
		if (ListView1.SelectedItems.Count > 0)
		{
			int index = ListView1.SelectedIndices[0];
			string text = Strings.Format(DateTimePicker1.Value, "yyyyMMdd");
			string text2 = "Select comprobante,cliente,remitos, sub, domicilio, localidad, cp, chofer, guia, bultos, atraso, diferida, observaciones from planchada where comprobante=" + ListView1.Items[index].SubItems[2].Text + " and fecha='" + text + "'";
			DataTable dataTable = new DataTable("x");
			MySqlDataAdapter val = new MySqlDataAdapter(text2, Mod_Sentencias.cnn);
			DataSet dataSet = new DataSet();
			((DbDataAdapter)(object)val).Fill(dataSet, "tabla");
			Estados estados = MyProject.Forms.Estados;
			estados.Label6.Text = ListView1.Items[index].SubItems[3].Text;
			estados.Label7.Text = ListView1.Items[index].SubItems[4].Text;
			estados.Label16.Text = ListView1.Items[index].SubItems[6].Text;
			estados.Label18.Text = ListView1.Items[index].SubItems[9].Text;
			estados.Label22.Text = dataSet.Tables["tabla"].Rows[0]["guia"].ToString();
			estados.Label23.Text = dataSet.Tables["tabla"].Rows[0]["bultos"].ToString();
			estados.Label24.Text = dataSet.Tables["tabla"].Rows[0]["atraso"].ToString();
			estados.Label25.Text = dataSet.Tables["tabla"].Rows[0]["observaciones"].ToString();
			if (Operators.CompareString(ListView1.Items[index].SubItems[9].Text, "ENTREGADO", TextCompare: true) == 0)
			{
				estados.RadioButton1.Checked = true;
			}
			else if (Operators.CompareString(ListView1.Items[index].SubItems[9].Text, "PARCIAL", TextCompare: true) == 0)
			{
				estados.RadioButton2.Checked = true;
			}
			else if (Operators.CompareString(ListView1.Items[index].SubItems[9].Text, "NO ENTREGADO", TextCompare: true) == 0)
			{
				estados.RadioButton3.Checked = true;
			}
			estados.ComboBox1.Text = ListView1.Items[index].SubItems[12].Text;
			estados.Label17.Text = dataSet.Tables["tabla"].Rows[0]["Remitos"].ToString();
			estados.Label11.Text = dataSet.Tables["tabla"].Rows[0]["domicilio"].ToString();
			estados.Label13.Text = dataSet.Tables["tabla"].Rows[0]["localidad"].ToString();
			estados.Label5.Text = dataSet.Tables["tabla"].Rows[0]["cp"].ToString();
			estados.Label19.Text = dataSet.Tables["tabla"].Rows[0]["Chofer"].ToString();
			estados.Label21.Text = dataSet.Tables["tabla"].Rows[0]["Comprobante"].ToString();
			estados.ComboBox2.Text = ListView1.Items[index].SubItems[13].Text;
			estados = null;
		}
		MyProject.Forms.Estados.Owner = this;
		MyProject.Forms.Estados.ShowDialog();
		ListView1.Items.Clear();
		actualizacion();
	}

	private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
	{
		cargar_cliente();
	}

	private void DateTimePicker2_ValueChanged(object sender, EventArgs e)
	{
		cargar_cliente();
	}

	private void cargar_chof()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		DataTable dataTable = new DataTable("x");
		string text = "SELECT Chofer FROM Flota where Disponible='Si' and Estado='Activo' ORDER BY Chofer";
		MySqlDataAdapter val = new MySqlDataAdapter(text, Mod_Sentencias.cnn);
		DataSet dataSet = new DataSet();
		((DbDataAdapter)(object)val).Fill(dataSet, "tabla");
		ComboBox2.Items.Clear();
		DataTable dataTable2 = dataSet.Tables["tabla"];
		foreach (DataRow row in dataTable2.Rows)
		{
			ComboBox2.Items.Add(RuntimeHelpers.GetObjectValue(row["Chofer"]));
		}
	}

	private void cargar_cliente()
	{
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		string text = Strings.Format(DateTimePicker1.Value, "yyyyMMdd");
		string text2 = Strings.Format(DateTimePicker2.Value, "yyyyMMdd");
		DataTable dataTable = new DataTable("x");
		string text3 = "SELECT DISTINCT Cliente FROM Planchada where fecha BETWEEN '" + text + "' AND '" + text2 + "' AND Ventana>0 order by Cliente";
		MySqlDataAdapter val = new MySqlDataAdapter(text3, Mod_Sentencias.cnn);
		DataSet dataSet = new DataSet();
		((DbDataAdapter)(object)val).Fill(dataSet, "tabla");
		ComboBox1.Items.Clear();
		DataTable dataTable2 = dataSet.Tables["tabla"];
		foreach (DataRow row in dataTable2.Rows)
		{
			ComboBox1.Items.Add(RuntimeHelpers.GetObjectValue(row["Cliente"]));
		}
	}

	public object TiempoEjecutar(int Tiempo)
	{
		object result = "";
		TiempoRestante = Tiempo;
		Timer1.Interval = 300;
		short Interval = 300;
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
				Label8.Text = "Ejecutar en: " + Conversions.ToString(TiempoRestante);
				TiempoRestante--;
			}
			else
			{
				Timer1.Enabled = false;
				actualizacion();
				TiempoEjecutar(300);
			}
		}
	}

	private void ejecutarconsulta()
	{
		//IL_0ac9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad0: Expected O, but got Unknown
		//IL_0af8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aff: Expected O, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected O, but got Unknown
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Expected O, but got Unknown
		//IL_0fcc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fd3: Expected O, but got Unknown
		//IL_0ffb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1002: Expected O, but got Unknown
		//IL_05ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c1: Expected O, but got Unknown
		//IL_05e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f0: Expected O, but got Unknown
		string text = "";
		checked
		{
			if (Operators.CompareString(ComboBox1.Text, "", TextCompare: true) == 0)
			{
				if (Operators.CompareString(ComboBox2.Text, "", TextCompare: true) == 0)
				{
					try
					{
						string text2 = Strings.Format(DateTimePicker1.Value, "yyyyMMdd");
						string text3 = Strings.Format(DateTimePicker2.Value, "yyyyMMdd");
						text = "SELECT \r\n(SELECT Chofer FROM FLota Where Numero=Planchada.Chofer) AS Chofer,\r\nVentana,\r\nComprobante,\r\nCliente,\r\nSub,\r\nAtraso,\r\nDestino,\r\nRemitos,\r\nBultos,\r\nEstado,\r\nFecha,\r\nDiferida,\r\nObservaciones,\r\nComentario,\r\n(SELECT novedad from novedades where comprobante=planchada.comprobante and fecha=planchada.fecha) as novedad,\r\nUsuario \r\nFROM Planchada WHERE fecha >= '" + text2 + "' and fecha <='" + text3 + "' AND Ventana>0 AND chofer>0 ORDER BY Chofer";
						MySettingsProperty.Settings.sql = text;
						MySettingsProperty.Settings.Save();
						Mod_Sentencias.cnn.Open();
						MySqlCommand val = new MySqlCommand();
						MySqlCommand val2 = val;
						val2.CommandType = CommandType.Text;
						val2.CommandText = text;
						val2.Connection = Mod_Sentencias.cnn;
						val2 = null;
						MySqlDataAdapter val3 = new MySqlDataAdapter();
						DataSet dataSet = new DataSet();
						val3.SelectCommand = val;
						((DbDataAdapter)(object)val3).Fill(dataSet, "Tabla");
						ListView listView = ListView1;
						listView.Items.Clear();
						listView.View = View.Details;
						listView.GridLines = true;
						listView.FullRowSelect = true;
						listView = null;
						DataTable dataTable = dataSet.Tables["tabla"];
						int num = dataTable.Rows.Count - 1;
						for (int i = 0; i <= num; i++)
						{
							ListViewItem listViewItem = new ListViewItem(dataTable.Rows[i][0].ToString());
							int num2 = dataTable.Columns.Count - 1;
							for (int j = 1; j <= num2; j++)
							{
								listViewItem.SubItems.Add(dataTable.Rows[i][j].ToString());
							}
							ListView1.Items.Add(listViewItem);
						}
						int num3 = ListView1.Items.Count - 1;
						for (int k = 0; k <= num3; k++)
						{
							if (Operators.CompareString(ListView1.Items[k].SubItems[9].Text, "NO ENTREGADO", TextCompare: true) == 0)
							{
								ListView1.Items[k].ForeColor = Color.Red;
							}
							if (Operators.CompareString(ListView1.Items[k].SubItems[9].Text, "NO RECOLECTADO", TextCompare: true) == 0)
							{
								ListView1.Items[k].ForeColor = Color.Red;
							}
							if (Operators.CompareString(ListView1.Items[k].SubItems[9].Text, "A REPROGRAMAR", TextCompare: true) == 0)
							{
								ListView1.Items[k].ForeColor = Color.Red;
							}
							if (Operators.CompareString(ListView1.Items[k].SubItems[9].Text, "ENTREGADO", TextCompare: true) == 0)
							{
								ListView1.Items[k].ForeColor = Color.Green;
							}
							if (Operators.CompareString(ListView1.Items[k].SubItems[9].Text, "RECOLECTADO", TextCompare: true) == 0)
							{
								ListView1.Items[k].ForeColor = Color.Green;
							}
							if (Operators.CompareString(ListView1.Items[k].SubItems[9].Text, "EN CD", TextCompare: true) == 0)
							{
								ListView1.Items[k].ForeColor = Color.Green;
							}
							if (Operators.CompareString(ListView1.Items[k].SubItems[9].Text, "PARCIAL", TextCompare: true) == 0)
							{
								ListView1.Items[k].ForeColor = Color.Orange;
							}
						}
						dataTable = null;
						Mod_Sentencias.cnn.Close();
						Label5.Text = "";
						ComboBox1.Text = "";
						ComboBox2.Text = "";
						ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception objExcepcion = ex;
						Mod_Sentencias.cnn.Close();
						Logger.e("Error con excepción y traza", objExcepcion, new StackFrame(fNeedFileInfo: true));
						ProjectData.ClearProjectError();
					}
				}
				else
				{
					try
					{
						string text4 = Strings.Format(DateTimePicker1.Value, "yyyyMMdd");
						string text5 = Strings.Format(DateTimePicker2.Value, "yyyyMMdd");
						text = "SELECT \r\n(SELECT Chofer FROM FLota Where Numero=Planchada.Chofer) AS Chofer,\r\nVentana,\r\nComprobante,\r\nCliente,\r\nSub,\r\nAtraso,\r\nDestino,\r\nRemitos,\r\nBultos,\r\nEstado,\r\nFecha,\r\nDiferida,\r\nObservaciones,\r\nComentario,\r\n(SELECT novedad from novedades where comprobante=planchada.comprobante and fecha=planchada.fecha) as novedad,\r\nUsuario \r\nFROM Planchada WHERE fecha >= '" + text4 + "' and fecha <='" + text5 + "' AND Ventana>0 AND Chofer = " + Label5.Text + " ORDER BY Chofer";
						MySettingsProperty.Settings.sql = text;
						MySettingsProperty.Settings.Save();
						Mod_Sentencias.cnn.Open();
						MySqlCommand val4 = new MySqlCommand();
						MySqlCommand val5 = val4;
						val5.CommandType = CommandType.Text;
						val5.CommandText = text;
						val5.Connection = Mod_Sentencias.cnn;
						val5 = null;
						MySqlDataAdapter val6 = new MySqlDataAdapter();
						DataSet dataSet2 = new DataSet();
						val6.SelectCommand = val4;
						((DbDataAdapter)(object)val6).Fill(dataSet2, "Tabla");
						ListView listView2 = ListView1;
						listView2.Items.Clear();
						listView2.View = View.Details;
						listView2.GridLines = true;
						listView2.FullRowSelect = true;
						listView2 = null;
						DataTable dataTable2 = dataSet2.Tables["tabla"];
						int num4 = dataTable2.Rows.Count - 1;
						for (int l = 0; l <= num4; l++)
						{
							ListViewItem listViewItem2 = new ListViewItem(dataTable2.Rows[l][0].ToString());
							int num5 = dataTable2.Columns.Count - 1;
							for (int m = 1; m <= num5; m++)
							{
								listViewItem2.SubItems.Add(dataTable2.Rows[l][m].ToString());
							}
							ListView1.Items.Add(listViewItem2);
						}
						int num6 = ListView1.Items.Count - 1;
						for (int n = 0; n <= num6; n++)
						{
							if (Operators.CompareString(ListView1.Items[n].SubItems[9].Text, "NO ENTREGADO", TextCompare: true) == 0)
							{
								ListView1.Items[n].ForeColor = Color.Red;
							}
							if (Operators.CompareString(ListView1.Items[n].SubItems[9].Text, "NO RECOLECTADO", TextCompare: true) == 0)
							{
								ListView1.Items[n].ForeColor = Color.Red;
							}
							if (Operators.CompareString(ListView1.Items[n].SubItems[9].Text, "A REPROGRAMAR", TextCompare: true) == 0)
							{
								ListView1.Items[n].ForeColor = Color.Red;
							}
							if (Operators.CompareString(ListView1.Items[n].SubItems[9].Text, "ENTREGADO", TextCompare: true) == 0)
							{
								ListView1.Items[n].ForeColor = Color.Green;
							}
							if (Operators.CompareString(ListView1.Items[n].SubItems[9].Text, "RECOLECTADO", TextCompare: true) == 0)
							{
								ListView1.Items[n].ForeColor = Color.Green;
							}
							if (Operators.CompareString(ListView1.Items[n].SubItems[9].Text, "EN CD", TextCompare: true) == 0)
							{
								ListView1.Items[n].ForeColor = Color.Green;
							}
							if (Operators.CompareString(ListView1.Items[n].SubItems[9].Text, "PARCIAL", TextCompare: true) == 0)
							{
								ListView1.Items[n].ForeColor = Color.Orange;
							}
						}
						dataTable2 = null;
						Mod_Sentencias.cnn.Close();
						Label5.Text = "";
						ComboBox1.Text = "";
						ComboBox2.Text = "";
						ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
					}
					catch (Exception ex2)
					{
						ProjectData.SetProjectError(ex2);
						Exception objExcepcion2 = ex2;
						Mod_Sentencias.cnn.Close();
						Logger.e("Error con excepción y traza", objExcepcion2, new StackFrame(fNeedFileInfo: true));
						ProjectData.ClearProjectError();
					}
				}
			}
			else if (Operators.CompareString(ComboBox2.Text, "", TextCompare: true) == 0)
			{
				try
				{
					string text6 = Strings.Format(DateTimePicker1.Value, "yyyyMMdd");
					string text7 = Strings.Format(DateTimePicker2.Value, "yyyyMMdd");
					text = "SELECT \r\n(SELECT Chofer FROM FLota Where Numero=Planchada.Chofer) AS Chofer,\r\nVentana,\r\nComprobante,\r\nCliente,\r\nSub,\r\nAtraso,\r\nDestino,\r\nRemitos,\r\nBultos,\r\nEstado,\r\nFecha,\r\nDiferida,\r\nObservaciones,\r\nComentario,\r\n(SELECT novedad from novedades where comprobante=planchada.comprobante and fecha=planchada.fecha) as novedad,\r\nUsuario \r\nFROM Planchada WHERE fecha >= '" + text6 + "' and fecha <='" + text7 + "' AND Ventana>0 AND Cliente= '" + ComboBox1.Text + "' AND chofer>0  ORDER BY Chofer";
					MySettingsProperty.Settings.sql = text;
					MySettingsProperty.Settings.Save();
					Mod_Sentencias.cnn.Open();
					MySqlCommand val7 = new MySqlCommand();
					MySqlCommand val8 = val7;
					val8.CommandType = CommandType.Text;
					val8.CommandText = text;
					val8.Connection = Mod_Sentencias.cnn;
					val8 = null;
					MySqlDataAdapter val9 = new MySqlDataAdapter();
					DataSet dataSet3 = new DataSet();
					val9.SelectCommand = val7;
					((DbDataAdapter)(object)val9).Fill(dataSet3, "Tabla");
					ListView listView3 = ListView1;
					listView3.Items.Clear();
					listView3.View = View.Details;
					listView3.GridLines = true;
					listView3.FullRowSelect = true;
					listView3 = null;
					DataTable dataTable3 = dataSet3.Tables["tabla"];
					int num7 = dataTable3.Rows.Count - 1;
					for (int num8 = 0; num8 <= num7; num8++)
					{
						ListViewItem listViewItem3 = new ListViewItem(dataTable3.Rows[num8][0].ToString());
						int num9 = dataTable3.Columns.Count - 1;
						for (int num10 = 1; num10 <= num9; num10++)
						{
							listViewItem3.SubItems.Add(dataTable3.Rows[num8][num10].ToString());
						}
						ListView1.Items.Add(listViewItem3);
					}
					int num11 = ListView1.Items.Count - 1;
					for (int num12 = 0; num12 <= num11; num12++)
					{
						if (Operators.CompareString(ListView1.Items[num12].SubItems[9].Text, "NO ENTREGADO", TextCompare: true) == 0)
						{
							ListView1.Items[num12].ForeColor = Color.Red;
						}
						if (Operators.CompareString(ListView1.Items[num12].SubItems[9].Text, "NO RECOLECTADO", TextCompare: true) == 0)
						{
							ListView1.Items[num12].ForeColor = Color.Red;
						}
						if (Operators.CompareString(ListView1.Items[num12].SubItems[9].Text, "A REPROGRAMAR", TextCompare: true) == 0)
						{
							ListView1.Items[num12].ForeColor = Color.Red;
						}
						if (Operators.CompareString(ListView1.Items[num12].SubItems[9].Text, "ENTREGADO", TextCompare: true) == 0)
						{
							ListView1.Items[num12].ForeColor = Color.Green;
						}
						if (Operators.CompareString(ListView1.Items[num12].SubItems[9].Text, "RECOLECTADO", TextCompare: true) == 0)
						{
							ListView1.Items[num12].ForeColor = Color.Green;
						}
						if (Operators.CompareString(ListView1.Items[num12].SubItems[9].Text, "EN CD", TextCompare: true) == 0)
						{
							ListView1.Items[num12].ForeColor = Color.Green;
						}
						if (Operators.CompareString(ListView1.Items[num12].SubItems[9].Text, "PARCIAL", TextCompare: true) == 0)
						{
							ListView1.Items[num12].ForeColor = Color.Orange;
						}
					}
					dataTable3 = null;
					Mod_Sentencias.cnn.Close();
					Label5.Text = "";
					ComboBox1.Text = "";
					ComboBox2.Text = "";
					ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
				}
				catch (Exception ex3)
				{
					ProjectData.SetProjectError(ex3);
					Exception objExcepcion3 = ex3;
					Mod_Sentencias.cnn.Close();
					Logger.e("Error con excepción y traza", objExcepcion3, new StackFrame(fNeedFileInfo: true));
					ProjectData.ClearProjectError();
				}
			}
			else
			{
				try
				{
					string text8 = Strings.Format(DateTimePicker1.Value, "yyyyMMdd");
					string text9 = Strings.Format(DateTimePicker2.Value, "yyyyMMdd");
					text = "SELECT \r\n(SELECT Chofer FROM FLota Where Numero=Planchada.Chofer) AS Chofer,\r\nVentana,\r\nComprobante,\r\nCliente,\r\nSub,\r\nAtraso,\r\nDestino,\r\nRemitos,\r\nBultos,\r\nEstado,\r\nFecha,\r\nDiferida,\r\nObservaciones,\r\nComentario,\r\n(SELECT novedad from novedades where comprobante=planchada.comprobante and fecha=planchada.fecha) as novedad,\r\nUsuario \r\nFROM Planchada WHERE fecha >= '" + text8 + "' and fecha <='" + text9 + "' AND Ventana>0 AND Cliente= '" + ComboBox1.Text + "' AND Chofer = " + Label5.Text + " ORDER BY Chofer";
					MySettingsProperty.Settings.sql = text;
					MySettingsProperty.Settings.Save();
					Mod_Sentencias.cnn.Open();
					MySqlCommand val10 = new MySqlCommand();
					MySqlCommand val11 = val10;
					val11.CommandType = CommandType.Text;
					val11.CommandText = text;
					val11.Connection = Mod_Sentencias.cnn;
					val11 = null;
					MySqlDataAdapter val12 = new MySqlDataAdapter();
					DataSet dataSet4 = new DataSet();
					val12.SelectCommand = val10;
					((DbDataAdapter)(object)val12).Fill(dataSet4, "Tabla");
					ListView listView4 = ListView1;
					listView4.Items.Clear();
					listView4.View = View.Details;
					listView4.GridLines = true;
					listView4.FullRowSelect = true;
					listView4 = null;
					DataTable dataTable4 = dataSet4.Tables["tabla"];
					int num13 = dataTable4.Rows.Count - 1;
					for (int num14 = 0; num14 <= num13; num14++)
					{
						ListViewItem listViewItem4 = new ListViewItem(dataTable4.Rows[num14][0].ToString());
						int num15 = dataTable4.Columns.Count - 1;
						for (int num16 = 1; num16 <= num15; num16++)
						{
							listViewItem4.SubItems.Add(dataTable4.Rows[num14][num16].ToString());
						}
						ListView1.Items.Add(listViewItem4);
					}
					int num17 = ListView1.Items.Count - 1;
					for (int num18 = 0; num18 <= num17; num18++)
					{
						if (Operators.CompareString(ListView1.Items[num18].SubItems[9].Text, "NO ENTREGADO", TextCompare: true) == 0)
						{
							ListView1.Items[num18].ForeColor = Color.Red;
						}
						if (Operators.CompareString(ListView1.Items[num18].SubItems[9].Text, "NO RECOLECTADO", TextCompare: true) == 0)
						{
							ListView1.Items[num18].ForeColor = Color.Red;
						}
						if (Operators.CompareString(ListView1.Items[num18].SubItems[9].Text, "A REPROGRAMAR", TextCompare: true) == 0)
						{
							ListView1.Items[num18].ForeColor = Color.Red;
						}
						if (Operators.CompareString(ListView1.Items[num18].SubItems[9].Text, "ENTREGADO", TextCompare: true) == 0)
						{
							ListView1.Items[num18].ForeColor = Color.Green;
						}
						if (Operators.CompareString(ListView1.Items[num18].SubItems[9].Text, "RECOLECTADO", TextCompare: true) == 0)
						{
							ListView1.Items[num18].ForeColor = Color.Green;
						}
						if (Operators.CompareString(ListView1.Items[num18].SubItems[9].Text, "EN CD", TextCompare: true) == 0)
						{
							ListView1.Items[num18].ForeColor = Color.Green;
						}
						if (Operators.CompareString(ListView1.Items[num18].SubItems[9].Text, "PARCIAL", TextCompare: true) == 0)
						{
							ListView1.Items[num18].ForeColor = Color.Orange;
						}
					}
					dataTable4 = null;
					Label5.Text = "";
					ComboBox1.Text = "";
					ComboBox2.Text = "";
					Mod_Sentencias.cnn.Close();
					ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
				}
				catch (Exception ex4)
				{
					ProjectData.SetProjectError(ex4);
					Exception objExcepcion4 = ex4;
					Mod_Sentencias.cnn.Close();
					Logger.e("Error con excepción y traza", objExcepcion4, new StackFrame(fNeedFileInfo: true));
					ProjectData.ClearProjectError();
				}
			}
			Label7.Text = Conversions.ToString(ListView1.Items.Count);
		}
	}

	private void actualizacion()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		string commandText = MySettingsProperty.Settings.sql.ToString();
		Mod_Sentencias.cnn.Open();
		MySqlCommand val = new MySqlCommand();
		MySqlCommand val2 = val;
		val2.CommandType = CommandType.Text;
		val2.CommandText = commandText;
		val2.Connection = Mod_Sentencias.cnn;
		val2 = null;
		MySqlDataAdapter val3 = new MySqlDataAdapter();
		DataSet dataSet = new DataSet();
		val3.SelectCommand = val;
		((DbDataAdapter)(object)val3).Fill(dataSet, "Tabla");
		ListView listView = ListView1;
		listView.Items.Clear();
		listView.View = View.Details;
		listView.GridLines = true;
		listView.FullRowSelect = true;
		listView = null;
		DataTable dataTable = dataSet.Tables["tabla"];
		checked
		{
			int num = dataTable.Rows.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				ListViewItem listViewItem = new ListViewItem(dataTable.Rows[i][0].ToString());
				int num2 = dataTable.Columns.Count - 1;
				for (int j = 1; j <= num2; j++)
				{
					listViewItem.SubItems.Add(dataTable.Rows[i][j].ToString());
				}
				ListView1.Items.Add(listViewItem);
			}
			int num3 = ListView1.Items.Count - 1;
			for (int k = 0; k <= num3; k++)
			{
				if (Operators.CompareString(ListView1.Items[k].SubItems[9].Text, "NO ENTREGADO", TextCompare: true) == 0)
				{
					ListView1.Items[k].ForeColor = Color.Red;
				}
				if (Operators.CompareString(ListView1.Items[k].SubItems[9].Text, "NO RECOLECTADO", TextCompare: true) == 0)
				{
					ListView1.Items[k].ForeColor = Color.Red;
				}
				if (Operators.CompareString(ListView1.Items[k].SubItems[9].Text, "A REPROGRAMAR", TextCompare: true) == 0)
				{
					ListView1.Items[k].ForeColor = Color.Red;
				}
				if (Operators.CompareString(ListView1.Items[k].SubItems[9].Text, "ENTREGADO", TextCompare: true) == 0)
				{
					ListView1.Items[k].ForeColor = Color.Green;
				}
				if (Operators.CompareString(ListView1.Items[k].SubItems[9].Text, "RECOLECTADO", TextCompare: true) == 0)
				{
					ListView1.Items[k].ForeColor = Color.Green;
				}
				if (Operators.CompareString(ListView1.Items[k].SubItems[9].Text, "EN CD", TextCompare: true) == 0)
				{
					ListView1.Items[k].ForeColor = Color.Green;
				}
				if (Operators.CompareString(ListView1.Items[k].SubItems[9].Text, "PARCIAL", TextCompare: true) == 0)
				{
					ListView1.Items[k].ForeColor = Color.Orange;
				}
			}
			dataTable = null;
			Mod_Sentencias.cnn.Close();
		}
	}

	public object TiempoEjecutar1(int Tiempo1)
	{
		object result = "";
		TiempoRestante1 = Tiempo1;
		Timer2.Interval = 4000;
		short Interval = 4000;
		TimerOn1(ref Interval);
		return result;
	}

	public void TimerOn1(ref short Interval)
	{
		if (Interval > 0)
		{
			Timer2.Enabled = true;
		}
		else
		{
			Timer2.Enabled = false;
		}
	}

	private void Timer2_Tick(object sender, EventArgs e)
	{
		checked
		{
			if (TiempoRestante1 >= 0)
			{
				Label9.Text = "Ejecutar en: " + Conversions.ToString(TiempoRestante1);
				TiempoRestante1--;
			}
			else
			{
				Timer2.Enabled = false;
				BackgroundWorker1.RunWorkerAsync();
				TiempoEjecutar1(4000);
			}
		}
	}
}
