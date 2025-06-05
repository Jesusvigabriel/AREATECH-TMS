using System;
using System.Collections.Generic;
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
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace Hermes;

[DesignerGenerated]
public class Etiquetas_Form : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ComboBox1")]
	private ComboBox _ComboBox1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("BtnImprimir")]
	private Button _BtnImprimir;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ListView1")]
	private ListView _ListView1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("BtnBuscar")]
	private Button _BtnBuscar;

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
	[AccessedThroughProperty("BtnBarras")]
	private Button _BtnBarras;

	private string id_producto;

	private string barrCode_producto;

	private string codeEmpresa_producto;

	private string descripcion_producto;

	private string alto_producto;

	private string ancho_producto;

	private string largo_producto;

	private string peso_producto;

	private string precio_producto;

	private string empresa_producto;

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
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
			EventHandler value2 = ComboBox1_SelectionChangeCommitted;
			ComboBox comboBox = _ComboBox1;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value2;
			}
			_ComboBox1 = value;
			comboBox = _ComboBox1;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value2;
			}
		}
	}

	[field: AccessedThroughProperty("LblCliente")]
	internal virtual Label LblCliente
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

	[field: AccessedThroughProperty("TextBox1")]
	internal virtual TextBox TextBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button BtnImprimir
	{
		[CompilerGenerated]
		get
		{
			return _BtnImprimir;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = BtnImprimir_Click;
			Button btnImprimir = _BtnImprimir;
			if (btnImprimir != null)
			{
				btnImprimir.Click -= value2;
			}
			_BtnImprimir = value;
			btnImprimir = _BtnImprimir;
			if (btnImprimir != null)
			{
				btnImprimir.Click += value2;
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

	[field: AccessedThroughProperty("LblCount")]
	internal virtual Label LblCount
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

	[field: AccessedThroughProperty("BarrCode")]
	internal virtual ColumnHeader BarrCode
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CodeEmpresa")]
	internal virtual ColumnHeader CodeEmpresa
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

	[field: AccessedThroughProperty("Alto")]
	internal virtual ColumnHeader Alto
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Ancho")]
	internal virtual ColumnHeader Ancho
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Largo")]
	internal virtual ColumnHeader Largo
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

	[field: AccessedThroughProperty("Precio")]
	internal virtual ColumnHeader Precio
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button BtnBuscar
	{
		[CompilerGenerated]
		get
		{
			return _BtnBuscar;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = BtnBuscar_Click;
			Button btnBuscar = _BtnBuscar;
			if (btnBuscar != null)
			{
				btnBuscar.Click -= value2;
			}
			_BtnBuscar = value;
			btnBuscar = _BtnBuscar;
			if (btnBuscar != null)
			{
				btnBuscar.Click += value2;
			}
		}
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

	internal virtual Button BtnBarras
	{
		[CompilerGenerated]
		get
		{
			return _BtnBarras;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = BtnBarras_Click;
			Button btnBarras = _BtnBarras;
			if (btnBarras != null)
			{
				btnBarras.Click -= value2;
			}
			_BtnBarras = value;
			btnBarras = _BtnBarras;
			if (btnBarras != null)
			{
				btnBarras.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Empresa")]
	internal virtual ColumnHeader Empresa
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public Etiquetas_Form()
	{
		base.Load += Etiquetas_Form_Load;
		id_producto = string.Empty;
		barrCode_producto = string.Empty;
		codeEmpresa_producto = string.Empty;
		descripcion_producto = string.Empty;
		alto_producto = string.Empty;
		ancho_producto = string.Empty;
		largo_producto = string.Empty;
		peso_producto = string.Empty;
		precio_producto = string.Empty;
		empresa_producto = string.Empty;
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
		this.Label1 = new System.Windows.Forms.Label();
		this.ComboBox1 = new System.Windows.Forms.ComboBox();
		this.LblCliente = new System.Windows.Forms.Label();
		this.Label3 = new System.Windows.Forms.Label();
		this.TextBox1 = new System.Windows.Forms.TextBox();
		this.BtnImprimir = new System.Windows.Forms.Button();
		this.ListView1 = new System.Windows.Forms.ListView();
		this.Producto = new System.Windows.Forms.ColumnHeader();
		this.BarrCode = new System.Windows.Forms.ColumnHeader();
		this.CodeEmpresa = new System.Windows.Forms.ColumnHeader();
		this.Descripcion = new System.Windows.Forms.ColumnHeader();
		this.Alto = new System.Windows.Forms.ColumnHeader();
		this.Ancho = new System.Windows.Forms.ColumnHeader();
		this.Largo = new System.Windows.Forms.ColumnHeader();
		this.Peso = new System.Windows.Forms.ColumnHeader();
		this.Precio = new System.Windows.Forms.ColumnHeader();
		this.LblCount = new System.Windows.Forms.Label();
		this.BtnBuscar = new System.Windows.Forms.Button();
		this.PrintDocument1 = new System.Drawing.Printing.PrintDocument();
		this.PrintDialog1 = new System.Windows.Forms.PrintDialog();
		this.PrintDocument2 = new System.Drawing.Printing.PrintDocument();
		this.BtnBarras = new System.Windows.Forms.Button();
		this.Empresa = new System.Windows.Forms.ColumnHeader();
		base.SuspendLayout();
		this.Label1.AutoSize = true;
		this.Label1.Location = new System.Drawing.Point(23, 34);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(42, 13);
		this.Label1.TabIndex = 0;
		this.Label1.Text = "Cliente:";
		this.ComboBox1.FormattingEnabled = true;
		this.ComboBox1.Location = new System.Drawing.Point(71, 31);
		this.ComboBox1.Name = "ComboBox1";
		this.ComboBox1.Size = new System.Drawing.Size(222, 21);
		this.ComboBox1.TabIndex = 1;
		this.LblCliente.AutoSize = true;
		this.LblCliente.Location = new System.Drawing.Point(304, 34);
		this.LblCliente.Name = "LblCliente";
		this.LblCliente.Size = new System.Drawing.Size(52, 13);
		this.LblCliente.TabIndex = 2;
		this.LblCliente.Text = "id_cliente";
		this.Label3.AutoSize = true;
		this.Label3.Location = new System.Drawing.Point(379, 34);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(89, 13);
		this.Label3.TabIndex = 6;
		this.Label3.Text = "Buscar Producto:";
		this.TextBox1.Location = new System.Drawing.Point(471, 31);
		this.TextBox1.Name = "TextBox1";
		this.TextBox1.Size = new System.Drawing.Size(186, 20);
		this.TextBox1.TabIndex = 7;
		this.BtnImprimir.Location = new System.Drawing.Point(13, 323);
		this.BtnImprimir.Name = "BtnImprimir";
		this.BtnImprimir.Size = new System.Drawing.Size(112, 41);
		this.BtnImprimir.TabIndex = 8;
		this.BtnImprimir.Text = "Informacion";
		this.BtnImprimir.UseVisualStyleBackColor = true;
		this.ListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[10] { this.Empresa, this.Producto, this.BarrCode, this.CodeEmpresa, this.Descripcion, this.Alto, this.Ancho, this.Largo, this.Peso, this.Precio });
		this.ListView1.FullRowSelect = true;
		this.ListView1.GridLines = true;
		this.ListView1.Location = new System.Drawing.Point(12, 60);
		this.ListView1.Name = "ListView1";
		this.ListView1.Size = new System.Drawing.Size(776, 257);
		this.ListView1.TabIndex = 9;
		this.ListView1.UseCompatibleStateImageBehavior = false;
		this.ListView1.View = System.Windows.Forms.View.Details;
		this.Producto.Text = "Producto";
		this.BarrCode.Text = "BarrCode";
		this.CodeEmpresa.Text = "CodeEmpresa";
		this.CodeEmpresa.Width = 110;
		this.Descripcion.Text = "Descripcion";
		this.Descripcion.Width = 181;
		this.Alto.Text = "Alto";
		this.Ancho.Text = "Ancho";
		this.Largo.Text = "Largo";
		this.Peso.Text = "Peso";
		this.Precio.Text = "Precio";
		this.LblCount.AutoSize = true;
		this.LblCount.Location = new System.Drawing.Point(717, 337);
		this.LblCount.Name = "LblCount";
		this.LblCount.Size = new System.Drawing.Size(35, 13);
		this.LblCount.TabIndex = 10;
		this.LblCount.Text = "Count";
		this.BtnBuscar.Location = new System.Drawing.Point(663, 27);
		this.BtnBuscar.Name = "BtnBuscar";
		this.BtnBuscar.Size = new System.Drawing.Size(75, 27);
		this.BtnBuscar.TabIndex = 11;
		this.BtnBuscar.Text = "Buscar";
		this.BtnBuscar.UseVisualStyleBackColor = true;
		this.PrintDialog1.UseEXDialog = true;
		this.BtnBarras.Location = new System.Drawing.Point(141, 323);
		this.BtnBarras.Name = "BtnBarras";
		this.BtnBarras.Size = new System.Drawing.Size(112, 41);
		this.BtnBarras.TabIndex = 12;
		this.BtnBarras.Text = "Codigo Barras";
		this.BtnBarras.UseVisualStyleBackColor = true;
		this.Empresa.Text = "Empresa";
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(800, 374);
		base.Controls.Add(this.BtnBarras);
		base.Controls.Add(this.BtnBuscar);
		base.Controls.Add(this.LblCount);
		base.Controls.Add(this.ListView1);
		base.Controls.Add(this.BtnImprimir);
		base.Controls.Add(this.TextBox1);
		base.Controls.Add(this.Label3);
		base.Controls.Add(this.LblCliente);
		base.Controls.Add(this.ComboBox1);
		base.Controls.Add(this.Label1);
		base.Name = "Etiquetas_Form";
		this.Text = "Etiquetas_Form";
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private void BtnImprimir_Click(object sender, EventArgs e)
	{
		if (ListView1.SelectedItems.Count <= 0)
		{
			return;
		}
		foreach (ListViewItem selectedItem in ListView1.SelectedItems)
		{
			empresa_producto = selectedItem.Text;
			id_producto = selectedItem.SubItems[1].Text;
			barrCode_producto = selectedItem.SubItems[2].Text;
			codeEmpresa_producto = selectedItem.SubItems[3].Text;
			descripcion_producto = selectedItem.SubItems[4].Text;
			alto_producto = selectedItem.SubItems[5].Text;
			ancho_producto = selectedItem.SubItems[6].Text;
			largo_producto = selectedItem.SubItems[7].Text;
			peso_producto = selectedItem.SubItems[8].Text;
			precio_producto = selectedItem.SubItems[9].Text;
			PrintDialog1.Document = PrintDocument1;
			PrintDialog1.PrinterSettings = PrintDocument1.PrinterSettings;
			PrintDialog1.AllowSomePages = true;
			if (PrintDialog1.ShowDialog() == DialogResult.OK)
			{
				PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings;
				PrintDocument2.PrinterSettings = PrintDialog1.PrinterSettings;
				PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
				PrintDocument1.DefaultPageSettings.Landscape = false;
				PrintDocument2.DefaultPageSettings.Landscape = false;
				printPreviewDialog.WindowState = FormWindowState.Maximized;
				printPreviewDialog.Document = PrintDocument1;
				PrintDocument1.Print();
			}
		}
	}

	private void Etiquetas_Form_Load(object sender, EventArgs e)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		string text = "SELECT  Nombre, id FROM empresas WHERE estado = 1 AND tipo = 1 ORDER BY id ASC";
		try
		{
			DataTable dataTable = new DataTable("x");
			MySqlDataAdapter val = new MySqlDataAdapter(text, Mod_Sentencias.cnn);
			((DbDataAdapter)(object)val).Fill(dataTable);
			if (dataTable.Rows.Count > 0)
			{
				ComboBox1.SelectedIndex = -1;
				Dictionary<string, string> dictionary = new Dictionary<string, string>();
				foreach (DataRow row in dataTable.Rows)
				{
					dictionary.Add(row[1].ToString(), Conversions.ToString(row[0]));
				}
				ComboBox1.DataSource = new BindingSource(dictionary, null);
				ComboBox1.DisplayMember = "Value";
				ComboBox1.ValueMember = "Key";
				ComboBox1.SelectedIndex = -1;
			}
			else
			{
				ComboBox1.DataSource = null;
				ComboBox1.Items.Clear();
				ComboBox1.SelectedIndex = -1;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox("Ocurrio un error al recuperar datos. " + ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void ComboBox1_SelectionChangeCommitted(object sender, EventArgs e)
	{
		LblCliente.Text = Conversions.ToString(ComboBox1.SelectedValue);
		get_products_by_empresa(Conversions.ToInteger(LblCliente.Text));
	}

	private void ListView1_ColumnClick(object sender, ColumnClickEventArgs e)
	{
		Mod_Ordenaclumnas.ordenar_columnas(ListView1, RuntimeHelpers.GetObjectValue(sender), e);
	}

	private void get_products_by_empresa(int empresa)
	{
		string sql = "SELECT s.empresa, s.producto, p.barrCode, p.codeEmpresa, p.descripcion, p.alto, p.ancho, p.largo, p.peso, p.precio FROM stock s \r\nLEFT JOIN\r\nproductos p\r\nON p.id = s.producto\r\nWHERE s.empresa=" + Conversions.ToString(empresa) + " and s.unidades > 0";
		DataTable dataTable = (DataTable)Mod_Sentencias.data(sql);
		ListView1.Columns.Clear();
		Mod_Sentencias.cargar_datos_lv_completa(ListView1, sql, LblCount);
	}

	private void BtnBuscar_Click(object sender, EventArgs e)
	{
		string text = TextBox1.Text;
		string sql = "SELECT p.empresa, p.id, p.barrCode, p.codeEmpresa, p.descripcion, p.alto, p.ancho, p.largo, p.peso, p.precio FROM \r\nproductos p\r\nWHERE p.barrCode LIKE '%" + text + "%' or p.codeEmpresa LIKE '%" + text + "%'";
		DataTable dataTable = (DataTable)Mod_Sentencias.data(sql);
		ListView1.Columns.Clear();
		Mod_Sentencias.cargar_datos_lv_completa(ListView1, sql, LblCount);
	}

	private void PrintDocument1_PrintPage(object sender, PrintPageEventArgs e)
	{
		int pHvalor = MySettingsProperty.Settings.pHvalor;
		int pVvalor = MySettingsProperty.Settings.pVvalor;
		Font font = new Font("Arial", 6.75f, FontStyle.Italic, GraphicsUnit.Point, 0);
		Font font2 = new Font("Arial", 11.75f, FontStyle.Italic, GraphicsUnit.Point, 0);
		Font font3 = new Font("Arial", 14.75f, FontStyle.Italic, GraphicsUnit.Point, 0);
		Font font4 = new Font("Arial", 22f, FontStyle.Bold, GraphicsUnit.Point, 0);
		Font font5 = new Font("Arial", 22f, FontStyle.Underline, GraphicsUnit.Point, 0);
		Rectangle empty = Rectangle.Empty;
		checked
		{
			empty.X = pHvalor + 2;
			empty.Y = pVvalor;
			empty.Width = 300;
			empty.Height = 150;
			e.Graphics.DrawRectangle(Pens.Black, empty);
			decimal value = ((descripcion_producto.Length <= 14) ? 20m : new decimal(280.0 / (double)descripcion_producto.Length));
			if (Operators.CompareString(empresa_producto, "70", TextCompare: true) == 0)
			{
				Font font6 = new Font("Arial", Convert.ToSingle(value), FontStyle.Bold);
				e.Graphics.DrawString(descripcion_producto, font6, Brushes.Black, empty.X + 10, empty.Y + 5);
				e.Graphics.DrawString(codeEmpresa_producto, font4, Brushes.Black, empty.X + 10, empty.Y + 30);
				e.Graphics.DrawString("Metros: " + largo_producto, font2, Brushes.Black, empty.X + 10, empty.Y + 65);
				e.Graphics.DrawString("Peso: " + peso_producto, font2, Brushes.Black, empty.X + 10, empty.Y + 80);
				e.Graphics.DrawString("Ancho: " + ancho_producto, font2, Brushes.Black, empty.X + 10, empty.Y + 95);
				e.Graphics.DrawString("Tono: " + alto_producto, font2, Brushes.Black, empty.X + 10, empty.Y + 110);
				e.Graphics.DrawString("Calidad: " + precio_producto, font2, Brushes.Black, empty.X + 10, empty.Y + 125);
			}
			else
			{
				Font font7 = new Font("Arial", Convert.ToSingle(value), FontStyle.Bold);
				e.Graphics.DrawString(descripcion_producto, font7, Brushes.Black, empty.X + 10, empty.Y + 5);
				e.Graphics.DrawString(codeEmpresa_producto, font4, Brushes.Black, empty.X + 10, empty.Y + 30);
				e.Graphics.DrawString("Largo: " + largo_producto, font2, Brushes.Black, empty.X + 10, empty.Y + 65);
				e.Graphics.DrawString("Ancho: " + ancho_producto, font2, Brushes.Black, empty.X + 10, empty.Y + 80);
				e.Graphics.DrawString("Alto: " + alto_producto, font2, Brushes.Black, empty.X + 10, empty.Y + 95);
				e.Graphics.DrawString("Peso: " + peso_producto, font2, Brushes.Black, empty.X + 10, empty.Y + 110);
			}
		}
	}

	private void PrintDocument2_PrintPage(object sender, PrintPageEventArgs e)
	{
		int pHvalor = MySettingsProperty.Settings.pHvalor;
		int pVvalor = MySettingsProperty.Settings.pVvalor;
		PrivateFontCollection privateFontCollection = new PrivateFontCollection();
		privateFontCollection.AddFontFile(AppDomain.CurrentDomain.BaseDirectory + "\\Resources\\Code39.ttf");
		Font font = new Font("Arial", 14.75f, FontStyle.Italic, GraphicsUnit.Point, 0);
		FontFamily family = privateFontCollection.Families[0];
		checked
		{
			if (Operators.CompareString(empresa_producto, "70", TextCompare: true) == 0)
			{
				Font font2 = new Font(family, 24f, FontStyle.Regular);
				Rectangle empty = Rectangle.Empty;
				empty.X = pHvalor + 2;
				empty.Y = pVvalor;
				empty.Width = 300;
				empty.Height = 150;
				e.Graphics.DrawRectangle(Pens.Black, empty);
				e.Graphics.DrawString("*" + barrCode_producto + "1*", font2, Brushes.Black, empty.X + 20, empty.Y + 30);
				e.Graphics.DrawString(barrCode_producto, font, Brushes.Black, empty.X + 30, empty.Y + 115);
			}
			else
			{
				Font font2 = new Font(family, 27f, FontStyle.Regular);
				Rectangle empty2 = Rectangle.Empty;
				empty2.X = pHvalor + 2;
				empty2.Y = pVvalor;
				empty2.Width = 300;
				empty2.Height = 150;
				e.Graphics.DrawRectangle(Pens.Black, empty2);
				e.Graphics.DrawString("*" + barrCode_producto + "*", font2, Brushes.Black, empty2.X + 10, empty2.Y + 30);
				e.Graphics.DrawString(barrCode_producto, font, Brushes.Black, empty2.X + 30, empty2.Y + 115);
			}
		}
	}

	private void BtnBarras_Click(object sender, EventArgs e)
	{
		if (ListView1.SelectedItems.Count <= 0)
		{
			return;
		}
		foreach (ListViewItem selectedItem in ListView1.SelectedItems)
		{
			empresa_producto = selectedItem.Text;
			id_producto = selectedItem.SubItems[1].Text;
			barrCode_producto = selectedItem.SubItems[2].Text;
			codeEmpresa_producto = selectedItem.SubItems[3].Text;
			descripcion_producto = selectedItem.SubItems[4].Text;
			alto_producto = selectedItem.SubItems[5].Text;
			ancho_producto = selectedItem.SubItems[6].Text;
			largo_producto = selectedItem.SubItems[7].Text;
			peso_producto = selectedItem.SubItems[8].Text;
			precio_producto = selectedItem.SubItems[9].Text;
			PrintDialog1.Document = PrintDocument1;
			PrintDialog1.PrinterSettings = PrintDocument1.PrinterSettings;
			PrintDialog1.AllowSomePages = true;
			if (PrintDialog1.ShowDialog() == DialogResult.OK)
			{
				PrintDocument2.PrinterSettings = PrintDialog1.PrinterSettings;
				PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
				PrintDocument2.DefaultPageSettings.Landscape = false;
				printPreviewDialog.WindowState = FormWindowState.Maximized;
				printPreviewDialog.Document = PrintDocument2;
				PrintDocument2.Print();
			}
		}
	}
}
