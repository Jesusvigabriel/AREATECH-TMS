using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Hermes.My;
using Hermes.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Hermes;

[DesignerGenerated]
public class Productos_Form : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("NuevoToolStripButton")]
	private ToolStripButton _NuevoToolStripButton;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("EditarToolStripButton")]
	private ToolStripButton _EditarToolStripButton;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ImprimirToolStripButton")]
	private ToolStripButton _ImprimirToolStripButton;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ListView1")]
	private ListView _ListView1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("TextBox1")]
	private TextBox _TextBox1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("PrintDocument1")]
	private PrintDocument _PrintDocument1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStripButton1")]
	private ToolStripButton _ToolStripButton1;

	private string sqlProductos;

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

	[field: AccessedThroughProperty("StatusStrip1")]
	internal virtual StatusStrip StatusStrip1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ToolStrip1")]
	internal virtual ToolStrip ToolStrip1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripButton NuevoToolStripButton
	{
		[CompilerGenerated]
		get
		{
			return _NuevoToolStripButton;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = NuevoToolStripButton_Click;
			ToolStripButton nuevoToolStripButton = _NuevoToolStripButton;
			if (nuevoToolStripButton != null)
			{
				nuevoToolStripButton.Click -= value2;
			}
			_NuevoToolStripButton = value;
			nuevoToolStripButton = _NuevoToolStripButton;
			if (nuevoToolStripButton != null)
			{
				nuevoToolStripButton.Click += value2;
			}
		}
	}

	internal virtual ToolStripButton EditarToolStripButton
	{
		[CompilerGenerated]
		get
		{
			return _EditarToolStripButton;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = EditarToolStripButton_Click;
			ToolStripButton editarToolStripButton = _EditarToolStripButton;
			if (editarToolStripButton != null)
			{
				editarToolStripButton.Click -= value2;
			}
			_EditarToolStripButton = value;
			editarToolStripButton = _EditarToolStripButton;
			if (editarToolStripButton != null)
			{
				editarToolStripButton.Click += value2;
			}
		}
	}

	internal virtual ToolStripButton ImprimirToolStripButton
	{
		[CompilerGenerated]
		get
		{
			return _ImprimirToolStripButton;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ImprimirToolStripButton_Click;
			ToolStripButton imprimirToolStripButton = _ImprimirToolStripButton;
			if (imprimirToolStripButton != null)
			{
				imprimirToolStripButton.Click -= value2;
			}
			_ImprimirToolStripButton = value;
			imprimirToolStripButton = _ImprimirToolStripButton;
			if (imprimirToolStripButton != null)
			{
				imprimirToolStripButton.Click += value2;
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
			EventHandler value2 = ListView1_DoubleClick;
			ColumnClickEventHandler value3 = ListView1_ColumnClick;
			ListView listView = _ListView1;
			if (listView != null)
			{
				listView.DoubleClick -= value2;
				listView.ColumnClick -= value3;
			}
			_ListView1 = value;
			listView = _ListView1;
			if (listView != null)
			{
				listView.DoubleClick += value2;
				listView.ColumnClick += value3;
			}
		}
	}

	[field: AccessedThroughProperty("ComboBox1")]
	internal virtual ComboBox ComboBox1
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

	[field: AccessedThroughProperty("ToolStripStatusLabel1")]
	internal virtual ToolStripStatusLabel ToolStripStatusLabel1
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
			KeyPressEventHandler value2 = TextBox1_KeyPress;
			TextBox textBox = _TextBox1;
			if (textBox != null)
			{
				textBox.KeyPress -= value2;
			}
			_TextBox1 = value;
			textBox = _TextBox1;
			if (textBox != null)
			{
				textBox.KeyPress += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
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

	[field: AccessedThroughProperty("SaveFileDialog1")]
	internal virtual SaveFileDialog SaveFileDialog1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public Productos_Form()
	{
		base.Load += Productos_Form_Load;
		sqlProductos = string.Empty;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hermes.Productos_Form));
		this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
		this.ToolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
		this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
		this.NuevoToolStripButton = new System.Windows.Forms.ToolStripButton();
		this.EditarToolStripButton = new System.Windows.Forms.ToolStripButton();
		this.ImprimirToolStripButton = new System.Windows.Forms.ToolStripButton();
		this.ToolStripButton1 = new System.Windows.Forms.ToolStripButton();
		this.ListView1 = new System.Windows.Forms.ListView();
		this.ComboBox1 = new System.Windows.Forms.ComboBox();
		this.Label1 = new System.Windows.Forms.Label();
		this.Button1 = new System.Windows.Forms.Button();
		this.Label2 = new System.Windows.Forms.Label();
		this.TextBox1 = new System.Windows.Forms.TextBox();
		this.Label3 = new System.Windows.Forms.Label();
		this.PrintDocument1 = new System.Drawing.Printing.PrintDocument();
		this.SaveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
		this.StatusStrip1.SuspendLayout();
		this.ToolStrip1.SuspendLayout();
		base.SuspendLayout();
		this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[1] { this.ToolStripStatusLabel1 });
		this.StatusStrip1.Location = new System.Drawing.Point(0, 396);
		this.StatusStrip1.Name = "StatusStrip1";
		this.StatusStrip1.Size = new System.Drawing.Size(880, 22);
		this.StatusStrip1.TabIndex = 0;
		this.StatusStrip1.Text = "StatusStrip1";
		this.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
		this.ToolStripStatusLabel1.Size = new System.Drawing.Size(93, 17);
		this.ToolStripStatusLabel1.Text = "Total Productos:";
		this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[4] { this.NuevoToolStripButton, this.EditarToolStripButton, this.ImprimirToolStripButton, this.ToolStripButton1 });
		this.ToolStrip1.Location = new System.Drawing.Point(0, 0);
		this.ToolStrip1.Name = "ToolStrip1";
		this.ToolStrip1.Size = new System.Drawing.Size(880, 25);
		this.ToolStrip1.TabIndex = 1;
		this.ToolStrip1.Text = "ToolStrip1";
		this.NuevoToolStripButton.Image = (System.Drawing.Image)resources.GetObject("NuevoToolStripButton.Image");
		this.NuevoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.NuevoToolStripButton.Name = "NuevoToolStripButton";
		this.NuevoToolStripButton.Size = new System.Drawing.Size(62, 22);
		this.NuevoToolStripButton.Text = "&Nuevo";
		this.EditarToolStripButton.Image = Hermes.My.Resources.Resources.document_edit;
		this.EditarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.EditarToolStripButton.Name = "EditarToolStripButton";
		this.EditarToolStripButton.Size = new System.Drawing.Size(57, 22);
		this.EditarToolStripButton.Text = "&Editar";
		this.ImprimirToolStripButton.Image = (System.Drawing.Image)resources.GetObject("ImprimirToolStripButton.Image");
		this.ImprimirToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.ImprimirToolStripButton.Name = "ImprimirToolStripButton";
		this.ImprimirToolStripButton.Size = new System.Drawing.Size(73, 22);
		this.ImprimirToolStripButton.Text = "&Imprimir";
		this.ToolStripButton1.Image = Hermes.My.Resources.Resources.page_table_32;
		this.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.ToolStripButton1.Name = "ToolStripButton1";
		this.ToolStripButton1.Size = new System.Drawing.Size(70, 22);
		this.ToolStripButton1.Text = "Exportar";
		this.ListView1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.ListView1.Location = new System.Drawing.Point(0, 28);
		this.ListView1.Name = "ListView1";
		this.ListView1.Size = new System.Drawing.Size(880, 365);
		this.ListView1.TabIndex = 2;
		this.ListView1.UseCompatibleStateImageBehavior = false;
		this.ComboBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.ComboBox1.FormattingEnabled = true;
		this.ComboBox1.Location = new System.Drawing.Point(534, 4);
		this.ComboBox1.Name = "ComboBox1";
		this.ComboBox1.Size = new System.Drawing.Size(253, 21);
		this.ComboBox1.TabIndex = 3;
		this.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.Label1.AutoSize = true;
		this.Label1.Location = new System.Drawing.Point(477, 7);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(51, 13);
		this.Label1.TabIndex = 4;
		this.Label1.Text = "Empresa:";
		this.Button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.Button1.Location = new System.Drawing.Point(793, 3);
		this.Button1.Name = "Button1";
		this.Button1.Size = new System.Drawing.Size(75, 21);
		this.Button1.TabIndex = 5;
		this.Button1.Text = "Buscar";
		this.Button1.UseVisualStyleBackColor = true;
		this.Label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.Label2.AutoSize = true;
		this.Label2.Location = new System.Drawing.Point(98, 401);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(13, 13);
		this.Label2.TabIndex = 6;
		this.Label2.Text = "0";
		this.TextBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.TextBox1.Location = new System.Drawing.Point(371, 4);
		this.TextBox1.Name = "TextBox1";
		this.TextBox1.Size = new System.Drawing.Size(100, 20);
		this.TextBox1.TabIndex = 7;
		this.TextBox1.Visible = false;
		this.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.Label3.AutoSize = true;
		this.Label3.Location = new System.Drawing.Point(322, 7);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(43, 13);
		this.Label3.TabIndex = 8;
		this.Label3.Text = "Codigo:";
		this.Label3.Visible = false;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(880, 418);
		base.Controls.Add(this.Label3);
		base.Controls.Add(this.TextBox1);
		base.Controls.Add(this.Label2);
		base.Controls.Add(this.Button1);
		base.Controls.Add(this.Label1);
		base.Controls.Add(this.ComboBox1);
		base.Controls.Add(this.ListView1);
		base.Controls.Add(this.ToolStrip1);
		base.Controls.Add(this.StatusStrip1);
		base.Name = "Productos_Form";
		this.Text = "Productos";
		this.StatusStrip1.ResumeLayout(false);
		this.StatusStrip1.PerformLayout();
		this.ToolStrip1.ResumeLayout(false);
		this.ToolStrip1.PerformLayout();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private void Productos_Form_Load(object sender, EventArgs e)
	{
		string sql = "SELECT Nombre, id FROM empresas WHERE estado = 1 AND tipo = 1 ORDER BY Nombre ASC";
		int num = Conversions.ToInteger(Mod_Tareas_comunes.FillMyCombo(sql, ComboBox1));
		if (num == 1)
		{
			Interaction.MsgBox("No se pudieron cargar las empresas.");
		}
	}

	public void BuscarProducto(int buscar)
	{
		int num = 0;
		if (Operators.ConditionalCompareObjectGreater(ComboBox1.SelectedValue, 0, TextCompare: true))
		{
			num = Conversions.ToInteger(ComboBox1.SelectedValue);
		}
		else
		{
			buscar = 0;
		}
		switch (buscar)
		{
		case 0:
			sqlProductos = "select p.id as id,  p.barrcode as barrcode, p.codeempresa as codeempresa, p.descripcion as descripcion, s.unidades as unidades, p.unXcaja, p.unXinner, p.alto as alto, p.ancho as ancho, p.largo as largo, p.peso as peso, p.precio as precio, p.variaciones as variaciones, p.estado as estado from productos p left join stock s on s.producto = p.id where p.variaciones=0\r\n                                union all\r\n                                Select p.id As id,  p.barrcode As barrcode, p.codeempresa As codeempresa, v.descripcion As descripcion, v.unidades As unidades, p.unXcaja, p.unXinner, p.alto As alto, p.ancho As ancho, p.largo As largo, p.peso As peso, p.precio As precio, v.id As variaciones, p.estado as estado from productos p left join variaciones v On p.id=v.producto_id where p.variaciones <> 0";
			ListView1.Clear();
			Mod_Sentencias.cargar_datos_lv_completa(ListView1, sqlProductos, Label2);
			break;
		case 2:
			sqlProductos = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("select p.id as id,  p.barrcode as barrcode, p.codeempresa as codeempresa, p.descripcion as descripcion, s.unidades as unidades, p.unXcaja, p.unXinner, p.alto as alto, p.ancho as ancho, p.largo as largo, p.peso as peso, p.precio as precio, p.variaciones as variaciones, p.estado as estado from productos p left join stock s on s.producto = p.id where p.empresa=", ComboBox1.SelectedValue), " and p.variaciones=0\r\n                                        union all\r\n                                        select p.id as id,  p.barrcode as barrcode, p.codeempresa as codeempresa, v.descripcion as descripcion, v.unidades as unidades, p.unXcaja, p.unXinner, p.alto as alto, p.ancho as ancho, p.largo as largo, p.peso as peso, p.precio as precio, v.id as variaciones, p.estado as estado from productos p left join variaciones v on p.id=v.producto_id where p.empresa="), ComboBox1.SelectedValue), " and p.variaciones <> 0"));
			ListView1.Clear();
			Mod_Sentencias.cargar_datos_lv_completa(ListView1, sqlProductos, Label2);
			break;
		}
		if (ListView1.Items.Count == 0)
		{
			Interaction.MsgBox("La busqueda no obtuvo resultados.");
		}
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		BuscarProducto(2);
	}

	private void ListView1_DoubleClick(object sender, EventArgs e)
	{
		if (Conversions.ToDouble(MySettingsProperty.Settings.Permiso) >= 7.0)
		{
			if (ListView1.SelectedItems.Count <= 0)
			{
				return;
			}
			if (int.Parse(ListView1.SelectedItems[0].SubItems[12].Text) == 0)
			{
				Editar editar = MyProject.Forms.Editar;
				editar.controladorLbl.Text = Conversions.ToString(1);
				editar.idlbl.Text = ListView1.SelectedItems[0].Text;
				editar.barrCodeTxt.Text = ListView1.SelectedItems[0].SubItems[1].Text;
				editar.codeEmpresaTxt.Text = ListView1.SelectedItems[0].SubItems[2].Text;
				editar.descripcionTxt.Text = ListView1.SelectedItems[0].SubItems[3].Text;
				editar.TextBox1.Text = ListView1.SelectedItems[0].SubItems[5].Text;
				editar.TextBox2.Text = ListView1.SelectedItems[0].SubItems[6].Text;
				editar.altoTxt.Text = ListView1.SelectedItems[0].SubItems[7].Text;
				editar.anchoTxt.Text = ListView1.SelectedItems[0].SubItems[8].Text;
				editar.largoTxt.Text = ListView1.SelectedItems[0].SubItems[9].Text;
				editar.pesotxt.Text = ListView1.SelectedItems[0].SubItems[10].Text;
				editar.precioTxt.Text = ListView1.SelectedItems[0].SubItems[11].Text;
				editar.estadoCombo.Text = ListView1.SelectedItems[0].SubItems[13].Text;
				if (Conversions.ToDouble(ListView1.SelectedItems[0].SubItems[4].Text) == 1.0)
				{
					editar.CheckBox1.Checked = true;
				}
				editar = null;
				MyProject.Forms.Editar.Show();
			}
			else
			{
				Interaction.MsgBox("La edicion de variaciones de productos esta desactivada.");
			}
		}
		else
		{
			Interaction.MsgBox("No posee los permisos requeridos.");
		}
	}

	private void NuevoToolStripButton_Click(object sender, EventArgs e)
	{
		if (Conversions.ToDouble(MySettingsProperty.Settings.Permiso) >= 7.0)
		{
			if (ComboBox1.SelectedIndex == -1)
			{
				Interaction.MsgBox("Seleccione la empresa correspondiente.");
			}
			else
			{
				MyProject.Forms.NuevoProducto_Form.Show();
			}
		}
		else
		{
			Interaction.MsgBox("No posee los permisos requeridos.");
		}
	}

	private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
	{
		if ((e.KeyChar == '\r') & (ListView1.Items.Count > 0) & (Operators.CompareString(TextBox1.Text, "", TextCompare: true) != 0))
		{
			string searchString = TextBox1.Text;
			ListViewItem listViewItem = null;
			ListView.ListViewItemCollection itemList = new ListView.ListViewItemCollection(ListView1);
			listViewItem = Mod_Funciones.FindItem(itemList, 2, searchString);
			if (listViewItem != null)
			{
				listViewItem.Selected = true;
				listViewItem.EnsureVisible();
			}
			else
			{
				Interaction.MsgBox("El item no exite");
			}
		}
	}

	private void ListView1_ColumnClick(object sender, ColumnClickEventArgs e)
	{
		Mod_Ordenaclumnas.ordenar_columnas(ListView1, RuntimeHelpers.GetObjectValue(sender), e);
	}

	private void ImprimirToolStripButton_Click(object sender, EventArgs e)
	{
		PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
		printPreviewDialog.Document = PrintDocument1;
		printPreviewDialog.ShowDialog();
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
			PrintDetails(ref e);
		}
	}

	private void PrintDetails(ref PrintPageEventArgs e)
	{
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
			int num = (int)Math.Round(graphics.DpiX);
			int num2 = (int)Math.Round(graphics.DpiY);
			graphics.Dispose();
			Rectangle empty = Rectangle.Empty;
			float num3 = (float)(-4.0 * ((double)num / 96.0));
			float num4 = (float)((double)ListView1.Font.Height + 10.0 * ((double)num / 96.0));
			StringFormat stringFormat = new StringFormat();
			float num5 = e.Graphics.MeasureString(Conversions.ToString(_0024STATIC_0024PrintDetails_0024201110128195_0024CurrentPage), ListView1.Font).Width;
			stringFormat.FormatFlags = StringFormatFlags.NoWrap;
			stringFormat.Trimming = StringTrimming.EllipsisCharacter;
			stringFormat.LineAlignment = StringAlignment.Center;
			_0024STATIC_0024PrintDetails_0024201110128195_0024CurrentPage++;
			int num6 = e.MarginBounds.X;
			int num7 = e.MarginBounds.Y;
			int num8 = ListView1.Columns.Count - 1;
			for (int i = 0; i <= num8; i++)
			{
				empty.X = num6;
				empty.Y = num7;
				empty.Width = ListView1.Columns[i].Width;
				empty.Height = (int)Math.Round(num4);
				e.Graphics.FillRectangle(Brushes.LightGray, empty);
				e.Graphics.DrawRectangle(Pens.DarkGray, empty);
				empty.X = (int)Math.Round((float)empty.X + num3);
				empty.Width = (int)Math.Round((float)empty.Width - num3);
				e.Graphics.DrawString(ListView1.Columns[i].Text, ListView1.Font, Brushes.Black, empty, stringFormat);
				num6 = (int)Math.Round((float)num6 + ((float)empty.Width + num3));
			}
			num7 = (int)Math.Round((float)num7 + num4);
			int num9 = _0024STATIC_0024PrintDetails_0024201110128195_0024LastIndex;
			int num10 = ListView1.Items.Count - 1;
			for (int j = num9; j <= num10; j++)
			{
				ListViewItem listViewItem = ListView1.Items[j];
				num6 = e.MarginBounds.X;
				if (num7 + listViewItem.Bounds.Height > e.MarginBounds.Bottom)
				{
					_0024STATIC_0024PrintDetails_0024201110128195_0024LastIndex = j - 1;
					e.HasMorePages = true;
					stringFormat.Dispose();
					e.Graphics.DrawString(Conversions.ToString(_0024STATIC_0024PrintDetails_0024201110128195_0024CurrentPage), ListView1.Font, Brushes.Black, ((float)e.PageBounds.Width - num5) / 2f, e.PageBounds.Bottom - ListView1.Font.Height * 2);
					return;
				}
				int num11 = 0;
				if (ListView1.SmallImageList != null)
				{
					if (!string.IsNullOrEmpty(listViewItem.ImageKey))
					{
						e.Graphics.DrawImage(ListView1.SmallImageList.Images[listViewItem.ImageKey], num6, num7);
					}
					else if (listViewItem.ImageIndex >= 0)
					{
						e.Graphics.DrawImage(ListView1.SmallImageList.Images[listViewItem.ImageIndex], num6, num7);
					}
					num11 = ListView1.SmallImageList.ImageSize.Width;
				}
				int num12 = ListView1.Columns.Count - 1;
				for (int k = 0; k <= num12; k++)
				{
					empty.X = num6;
					empty.Y = num7;
					empty.Width = ListView1.Columns[k].Width;
					empty.Height = listViewItem.Bounds.Height;
					if (ListView1.GridLines)
					{
						e.Graphics.DrawRectangle(Pens.DarkGray, empty);
					}
					if (k == 0)
					{
						empty.X += num11;
					}
					empty.X = (int)Math.Round((float)empty.X + num3);
					empty.Width = (int)Math.Round((float)empty.Width - num3);
					if (k < listViewItem.SubItems.Count)
					{
						e.Graphics.DrawString(listViewItem.SubItems[k].Text, ListView1.Font, Brushes.Black, empty, stringFormat);
					}
					num6 = (int)Math.Round((float)num6 + ((float)empty.Width + num3));
				}
				num7 += listViewItem.Bounds.Height;
				listViewItem = null;
			}
			e.Graphics.DrawString(Conversions.ToString(_0024STATIC_0024PrintDetails_0024201110128195_0024CurrentPage), ListView1.Font, Brushes.Black, ((float)e.PageBounds.Width - num5) / 2f, e.PageBounds.Bottom - ListView1.Font.Height * 2);
			stringFormat.Dispose();
			_0024STATIC_0024PrintDetails_0024201110128195_0024LastIndex = 0;
			_0024STATIC_0024PrintDetails_0024201110128195_0024CurrentPage = 0;
		}
	}

	private void EditarToolStripButton_Click(object sender, EventArgs e)
	{
		if (Conversions.ToDouble(MySettingsProperty.Settings.Permiso) >= 7.0)
		{
			if (ListView1.SelectedItems.Count > 0)
			{
				Editar editar = MyProject.Forms.Editar;
				editar.controladorLbl.Text = Conversions.ToString(1);
				editar.idlbl.Text = ListView1.SelectedItems[0].Text;
				editar.barrCodeTxt.Text = ListView1.SelectedItems[0].SubItems[1].Text;
				editar.codeEmpresaTxt.Text = ListView1.SelectedItems[0].SubItems[2].Text;
				editar.descripcionTxt.Text = ListView1.SelectedItems[0].SubItems[3].Text;
				editar.TextBox1.Text = ListView1.SelectedItems[0].SubItems[5].Text;
				editar.TextBox2.Text = ListView1.SelectedItems[0].SubItems[6].Text;
				editar.altoTxt.Text = ListView1.SelectedItems[0].SubItems[7].Text;
				editar.anchoTxt.Text = ListView1.SelectedItems[0].SubItems[8].Text;
				editar.largoTxt.Text = ListView1.SelectedItems[0].SubItems[9].Text;
				editar.pesotxt.Text = ListView1.SelectedItems[0].SubItems[10].Text;
				editar.precioTxt.Text = ListView1.SelectedItems[0].SubItems[11].Text;
				editar.estadoCombo.Text = ListView1.SelectedItems[0].SubItems[13].Text;
				if (Conversions.ToDouble(ListView1.SelectedItems[0].SubItems[4].Text) == 1.0)
				{
					editar.CheckBox1.Checked = true;
				}
				editar = null;
				MyProject.Forms.Editar.Show();
			}
		}
		else
		{
			Interaction.MsgBox("No posee los permisos requeridos.");
		}
	}

	private void ToolStripButton1_Click(object sender, EventArgs e)
	{
		SaveFileDialog saveFileDialog = new SaveFileDialog();
		saveFileDialog.Filter = "Excel files(*.xlsx)|*xlsx";
		saveFileDialog.Title = "Guardar Archivo";
		saveFileDialog.ShowDialog();
		string fileName = saveFileDialog.FileName;
		if (Operators.CompareString(fileName, "", TextCompare: true) != 0)
		{
			Mod_Exportar.exp_excel_dir(sqlProductos, fileName);
		}
	}
}
