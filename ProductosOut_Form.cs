using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Hermes.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace Hermes;

[DesignerGenerated]
public class ProductosOut_Form : Form
{
	public struct orderItem
	{
		public int id;

		public string barrcode;

		public int variation;

		public int units;
	}

	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ComboBox1")]
	private ComboBox _ComboBox1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ComboBox2")]
	private ComboBox _ComboBox2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("TextBox1")]
	private TextBox _TextBox1;

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
	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button3")]
	private Button _Button3;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("PrintDocument1")]
	private PrintDocument _PrintDocument1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button4")]
	private Button _Button4;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("TextBox2")]
	private TextBox _TextBox2;

	private Mod_Ordenes.ordenDetalleItem detalleOrden;

	private string empresa;

	private string remito;

	private string destino;

	private string direccion;

	private string localidad;

	private string bultos;

	private int bultostotal;

	private string QRCode;

	private List<orderItem> ordenSeleccionada;

	[SpecialName]
	private int _0024STATIC_0024PrintDetails_0024201110128195_0024LastIndex;

	[SpecialName]
	private StaticLocalInitFlag _0024STATIC_0024PrintDetails_0024201110128195_0024LastIndex_0024Init;

	[SpecialName]
	private int _0024STATIC_0024PrintDetails_0024201110128195_0024CurrentPage;

	[SpecialName]
	private StaticLocalInitFlag _0024STATIC_0024PrintDetails_0024201110128195_0024CurrentPage_0024Init;

	[field: AccessedThroughProperty("GroupBox1")]
	internal virtual GroupBox GroupBox1
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

	[field: AccessedThroughProperty("GroupBox2")]
	internal virtual GroupBox GroupBox2
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
			EventHandler value3 = ComboBox2_TextUpdate;
			ComboBox comboBox = _ComboBox2;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged -= value2;
				comboBox.TextUpdate -= value3;
			}
			_ComboBox2 = value;
			comboBox = _ComboBox2;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged += value2;
				comboBox.TextUpdate += value3;
			}
		}
	}

	[field: AccessedThroughProperty("GroupBox3")]
	internal virtual GroupBox GroupBox3
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

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
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
			ListView listView = _ListView1;
			if (listView != null)
			{
				listView.DoubleClick -= value2;
			}
			_ListView1 = value;
			listView = _ListView1;
			if (listView != null)
			{
				listView.DoubleClick += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label4")]
	internal virtual Label Label4
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

	[field: AccessedThroughProperty("ColumnHeader1")]
	internal virtual ColumnHeader ColumnHeader1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ColumnHeader2")]
	internal virtual ColumnHeader ColumnHeader2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ColumnHeader3")]
	internal virtual ColumnHeader ColumnHeader3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ColumnHeader4")]
	internal virtual ColumnHeader ColumnHeader4
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

	[field: AccessedThroughProperty("PrintDialog1")]
	internal virtual PrintDialog PrintDialog1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ColumnHeader5")]
	internal virtual ColumnHeader ColumnHeader5
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

	[field: AccessedThroughProperty("Label9")]
	internal virtual Label Label9
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public ProductosOut_Form()
	{
		base.Load += ProductosOut_Form_Load;
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
		this.Label1 = new System.Windows.Forms.Label();
		this.ComboBox1 = new System.Windows.Forms.ComboBox();
		this.GroupBox2 = new System.Windows.Forms.GroupBox();
		this.Label9 = new System.Windows.Forms.Label();
		this.Label2 = new System.Windows.Forms.Label();
		this.ComboBox2 = new System.Windows.Forms.ComboBox();
		this.GroupBox3 = new System.Windows.Forms.GroupBox();
		this.ListView1 = new System.Windows.Forms.ListView();
		this.ColumnHeader1 = new System.Windows.Forms.ColumnHeader();
		this.ColumnHeader2 = new System.Windows.Forms.ColumnHeader();
		this.ColumnHeader3 = new System.Windows.Forms.ColumnHeader();
		this.ColumnHeader4 = new System.Windows.Forms.ColumnHeader();
		this.ColumnHeader5 = new System.Windows.Forms.ColumnHeader();
		this.GroupBox4 = new System.Windows.Forms.GroupBox();
		this.Label8 = new System.Windows.Forms.Label();
		this.TextBox2 = new System.Windows.Forms.TextBox();
		this.Button4 = new System.Windows.Forms.Button();
		this.Button3 = new System.Windows.Forms.Button();
		this.Label7 = new System.Windows.Forms.Label();
		this.Label6 = new System.Windows.Forms.Label();
		this.Label5 = new System.Windows.Forms.Label();
		this.Label4 = new System.Windows.Forms.Label();
		this.Label3 = new System.Windows.Forms.Label();
		this.TextBox1 = new System.Windows.Forms.TextBox();
		this.Button1 = new System.Windows.Forms.Button();
		this.Button2 = new System.Windows.Forms.Button();
		this.PrintDocument1 = new System.Drawing.Printing.PrintDocument();
		this.PrintDialog1 = new System.Windows.Forms.PrintDialog();
		this.GroupBox1.SuspendLayout();
		this.GroupBox2.SuspendLayout();
		this.GroupBox3.SuspendLayout();
		this.GroupBox4.SuspendLayout();
		base.SuspendLayout();
		this.GroupBox1.Controls.Add(this.Label1);
		this.GroupBox1.Controls.Add(this.ComboBox1);
		this.GroupBox1.Location = new System.Drawing.Point(18, 21);
		this.GroupBox1.Name = "GroupBox1";
		this.GroupBox1.Size = new System.Drawing.Size(257, 99);
		this.GroupBox1.TabIndex = 0;
		this.GroupBox1.TabStop = false;
		this.GroupBox1.Text = "Empresa";
		this.Label1.AutoSize = true;
		this.Label1.Location = new System.Drawing.Point(6, 43);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(39, 13);
		this.Label1.TabIndex = 1;
		this.Label1.Text = "Label1";
		this.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.ComboBox1.FormattingEnabled = true;
		this.ComboBox1.Location = new System.Drawing.Point(6, 19);
		this.ComboBox1.Name = "ComboBox1";
		this.ComboBox1.Size = new System.Drawing.Size(245, 21);
		this.ComboBox1.TabIndex = 0;
		this.GroupBox2.Controls.Add(this.Label9);
		this.GroupBox2.Controls.Add(this.Label2);
		this.GroupBox2.Controls.Add(this.ComboBox2);
		this.GroupBox2.Location = new System.Drawing.Point(281, 21);
		this.GroupBox2.Name = "GroupBox2";
		this.GroupBox2.Size = new System.Drawing.Size(336, 99);
		this.GroupBox2.TabIndex = 1;
		this.GroupBox2.TabStop = false;
		this.GroupBox2.Text = "Orden";
		this.Label9.AutoSize = true;
		this.Label9.Location = new System.Drawing.Point(6, 79);
		this.Label9.Name = "Label9";
		this.Label9.Size = new System.Drawing.Size(39, 13);
		this.Label9.TabIndex = 2;
		this.Label9.Text = "Label9";
		this.Label9.Visible = false;
		this.Label2.AutoSize = true;
		this.Label2.Location = new System.Drawing.Point(6, 46);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(39, 13);
		this.Label2.TabIndex = 1;
		this.Label2.Text = "Label2";
		this.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.ComboBox2.FormattingEnabled = true;
		this.ComboBox2.Location = new System.Drawing.Point(6, 19);
		this.ComboBox2.Name = "ComboBox2";
		this.ComboBox2.Size = new System.Drawing.Size(324, 21);
		this.ComboBox2.TabIndex = 0;
		this.GroupBox3.Controls.Add(this.ListView1);
		this.GroupBox3.Location = new System.Drawing.Point(18, 126);
		this.GroupBox3.Name = "GroupBox3";
		this.GroupBox3.Size = new System.Drawing.Size(599, 282);
		this.GroupBox3.TabIndex = 2;
		this.GroupBox3.TabStop = false;
		this.GroupBox3.Text = "Listado";
		this.ListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[5] { this.ColumnHeader1, this.ColumnHeader2, this.ColumnHeader3, this.ColumnHeader4, this.ColumnHeader5 });
		this.ListView1.FullRowSelect = true;
		this.ListView1.GridLines = true;
		this.ListView1.Location = new System.Drawing.Point(8, 21);
		this.ListView1.Name = "ListView1";
		this.ListView1.Size = new System.Drawing.Size(585, 248);
		this.ListView1.TabIndex = 0;
		this.ListView1.UseCompatibleStateImageBehavior = false;
		this.ListView1.View = System.Windows.Forms.View.Details;
		this.ColumnHeader1.Text = "Cantidad";
		this.ColumnHeader2.Text = "Codigo";
		this.ColumnHeader2.Width = 166;
		this.ColumnHeader3.Text = "Descripcion";
		this.ColumnHeader3.Width = 600;
		this.ColumnHeader4.Text = "id";
		this.ColumnHeader5.Text = "variacion";
		this.GroupBox4.Controls.Add(this.Label8);
		this.GroupBox4.Controls.Add(this.TextBox2);
		this.GroupBox4.Controls.Add(this.Button4);
		this.GroupBox4.Controls.Add(this.Button3);
		this.GroupBox4.Controls.Add(this.Label7);
		this.GroupBox4.Controls.Add(this.Label6);
		this.GroupBox4.Controls.Add(this.Label5);
		this.GroupBox4.Controls.Add(this.Label4);
		this.GroupBox4.Controls.Add(this.Label3);
		this.GroupBox4.Controls.Add(this.TextBox1);
		this.GroupBox4.Location = new System.Drawing.Point(623, 21);
		this.GroupBox4.Name = "GroupBox4";
		this.GroupBox4.Size = new System.Drawing.Size(242, 387);
		this.GroupBox4.TabIndex = 3;
		this.GroupBox4.TabStop = false;
		this.GroupBox4.Text = "Producto";
		this.Label8.AutoSize = true;
		this.Label8.Location = new System.Drawing.Point(17, 46);
		this.Label8.Name = "Label8";
		this.Label8.Size = new System.Drawing.Size(58, 13);
		this.Label8.TabIndex = 10;
		this.Label8.Text = "Unidades :";
		this.TextBox2.Location = new System.Drawing.Point(110, 43);
		this.TextBox2.Name = "TextBox2";
		this.TextBox2.Size = new System.Drawing.Size(81, 20);
		this.TextBox2.TabIndex = 9;
		this.TextBox2.Text = "1";
		this.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.Button4.Location = new System.Drawing.Point(87, 351);
		this.Button4.Name = "Button4";
		this.Button4.Size = new System.Drawing.Size(75, 23);
		this.Button4.TabIndex = 8;
		this.Button4.Text = "Etiqueta";
		this.Button4.UseVisualStyleBackColor = true;
		this.Button3.Location = new System.Drawing.Point(6, 351);
		this.Button3.Name = "Button3";
		this.Button3.Size = new System.Drawing.Size(75, 23);
		this.Button3.TabIndex = 7;
		this.Button3.Text = "Imprimir";
		this.Button3.UseVisualStyleBackColor = true;
		this.Button3.Visible = false;
		this.Label7.AutoSize = true;
		this.Label7.Location = new System.Drawing.Point(141, 148);
		this.Label7.Name = "Label7";
		this.Label7.Size = new System.Drawing.Size(13, 13);
		this.Label7.TabIndex = 6;
		this.Label7.Text = "0";
		this.Label6.AutoSize = true;
		this.Label6.Location = new System.Drawing.Point(141, 126);
		this.Label6.Name = "Label6";
		this.Label6.Size = new System.Drawing.Size(13, 13);
		this.Label6.TabIndex = 5;
		this.Label6.Text = "0";
		this.Label5.AutoSize = true;
		this.Label5.Location = new System.Drawing.Point(17, 148);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(99, 13);
		this.Label5.TabIndex = 4;
		this.Label5.Text = "Productos Totales :";
		this.Label4.AutoSize = true;
		this.Label4.Location = new System.Drawing.Point(17, 126);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(96, 13);
		this.Label4.TabIndex = 2;
		this.Label4.Text = "Unidades Totales :";
		this.Label3.AutoSize = true;
		this.Label3.Location = new System.Drawing.Point(17, 82);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(43, 13);
		this.Label3.TabIndex = 1;
		this.Label3.Text = "Codigo:";
		this.TextBox1.Location = new System.Drawing.Point(66, 79);
		this.TextBox1.Name = "TextBox1";
		this.TextBox1.Size = new System.Drawing.Size(170, 20);
		this.TextBox1.TabIndex = 0;
		this.Button1.BackColor = System.Drawing.Color.Lime;
		this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
		this.Button1.Location = new System.Drawing.Point(703, 421);
		this.Button1.Name = "Button1";
		this.Button1.Size = new System.Drawing.Size(75, 23);
		this.Button1.TabIndex = 4;
		this.Button1.Text = "Guardar";
		this.Button1.UseVisualStyleBackColor = false;
		this.Button2.BackColor = System.Drawing.Color.Red;
		this.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
		this.Button2.Location = new System.Drawing.Point(784, 421);
		this.Button2.Name = "Button2";
		this.Button2.Size = new System.Drawing.Size(75, 23);
		this.Button2.TabIndex = 5;
		this.Button2.Text = "Salir";
		this.Button2.UseVisualStyleBackColor = false;
		this.PrintDialog1.UseEXDialog = true;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(877, 456);
		base.Controls.Add(this.Button2);
		base.Controls.Add(this.Button1);
		base.Controls.Add(this.GroupBox4);
		base.Controls.Add(this.GroupBox3);
		base.Controls.Add(this.GroupBox2);
		base.Controls.Add(this.GroupBox1);
		base.Name = "ProductosOut_Form";
		this.Text = "ProductosOut_Form";
		this.GroupBox1.ResumeLayout(false);
		this.GroupBox1.PerformLayout();
		this.GroupBox2.ResumeLayout(false);
		this.GroupBox2.PerformLayout();
		this.GroupBox3.ResumeLayout(false);
		this.GroupBox4.ResumeLayout(false);
		this.GroupBox4.PerformLayout();
		base.ResumeLayout(false);
	}

	private void ProductosOut_Form_Load(object sender, EventArgs e)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		string text = "SELECT  Nombre, id FROM empresas WHERE estado = 1 AND tipo = 1 ORDER BY Nombre ASC";
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
		Label1.Text = Conversions.ToString(ComboBox1.SelectedValue);
		obtenerOrdenes(Conversions.ToInteger(ComboBox1.SelectedValue));
		Label2.Text = string.Empty;
		Label9.Text = string.Empty;
	}

	private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (ComboBox2.SelectedIndex >= 0)
		{
			Label2.Text = ComboBox2.SelectedValue.ToString();
			Label9.Text = ComboBox2.SelectedValue.ToString();
			LoadOrder(ComboBox2.SelectedValue.ToString());
			ListView1.Items.Clear();
		}
	}

	private void obtenerOrdenes(int empresa)
	{
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		if (Conversions.ToDouble(MySettingsProperty.Settings.Permiso) == 10.0)
		{
			ComboBox2.DropDownStyle = ComboBoxStyle.DropDown;
		}
		try
		{
			string text = "Select  numero, id, tipo FROM ordenes WHERE empresa=" + Conversions.ToString(empresa) + " AND estado = 1";
			DataTable dataTable = new DataTable("x");
			MySqlDataAdapter val = new MySqlDataAdapter(text, Mod_Sentencias.cnn);
			((DbDataAdapter)(object)val).Fill(dataTable);
			if (dataTable.Rows.Count > 0)
			{
				ComboBox2.SelectedIndex = -1;
				Dictionary<string, string> dictionary = new Dictionary<string, string>();
				foreach (DataRow row in dataTable.Rows)
				{
					dictionary.Add(row[1].ToString(), Conversions.ToString(row[0]));
				}
				ComboBox2.DataSource = new BindingSource(dictionary, null);
				ComboBox2.DisplayMember = "Value";
				ComboBox2.ValueMember = "Key";
				ComboBox2.SelectedIndex = -1;
			}
			else
			{
				ComboBox2.DataSource = null;
				ComboBox2.Items.Clear();
				ComboBox2.SelectedIndex = -1;
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

	private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (e.KeyChar != '\r')
		{
			return;
		}
		checked
		{
			if (Operators.CompareString(TextBox1.Text, "", TextCompare: true) != 0)
			{
				if (TextBox1.Text.Contains("'"))
				{
					TextBox1.Text = Strings.Replace(TextBox1.Text, "'", "-", 1, -1, CompareMethod.Text);
				}
				double num = 0.0;
				string empty = string.Empty;
				empty = ((Operators.CompareString(Label1.Text, "70", TextCompare: true) != 0) ? TextBox1.Text : TextBox1.Text.Remove(TextBox1.Text.Length - 1));
				int num2 = 0;
				string empty2 = string.Empty;
				ListViewItem listViewItem = null;
				ListViewItem listViewItem2 = null;
				int num3 = 0;
				string sql = "Select descripcion, id, variaciones from productos where empresa='" + Label1.Text + "' and barrCode='" + empty + "' Limit 1";
				empty2 = Conversions.ToString(Mod_Sentencias.dataValue(sql, "descripcion"));
				num3 = Conversions.ToInteger(Mod_Sentencias.dataValue(sql, "id"));
				int num4 = Conversions.ToInteger(Mod_Sentencias.dataValue(sql, "variaciones"));
				if (Conversions.ToInteger(validateProduct(num3)) == 0)
				{
					TextBox1.Clear();
					Interaction.MsgBox("El Producto no correspone a la orden seleccionada.");
					return;
				}
				switch (num4)
				{
				case 0:
					if (ListView1.Items.Count > 0)
					{
						listViewItem2 = ListView1.FindItemWithText(empty, includeSubItemsInSearch: true, 0, isPrefixSearch: false);
					}
					if (listViewItem2 != null)
					{
						num2 = Conversions.ToInteger(listViewItem2.Text);
						empty2 = listViewItem2.SubItems[2].Text;
						num3 = Conversions.ToInteger(listViewItem2.SubItems[3].Text);
						num2 = (int)Math.Round((double)num2 + Conversions.ToDouble(TextBox2.Text));
						if (Conversions.ToInteger(validateunits(num3, num4, num2)) == 0)
						{
							TextBox1.Clear();
							Interaction.MsgBox("Se exedio la cantidad solicitada.");
							return;
						}
						listViewItem2.Remove();
						listViewItem = new ListViewItem(num2.ToString());
						listViewItem.SubItems.Add(empty);
						listViewItem.SubItems.Add(empty2);
						listViewItem.SubItems.Add(Conversions.ToString(num3));
						listViewItem.SubItems.Add(Conversions.ToString(0));
						ListView1.Items.Add(listViewItem);
						listViewItem.EnsureVisible();
						Label7.Text = Conversions.ToString(ListView1.Items.Count);
						foreach (ListViewItem item in ListView1.Items)
						{
							num += (double)int.Parse(item.Text);
						}
						Label6.Text = Conversions.ToString(num);
					}
					else if (num3 > 0)
					{
						num2 = (int)Math.Round((double)num2 + Conversions.ToDouble(TextBox2.Text));
						if (Conversions.ToInteger(validateunits(num3, num4, num2)) == 0)
						{
							TextBox1.Clear();
							Interaction.MsgBox("Se exedio la cantidad solicitada.");
							return;
						}
						listViewItem = new ListViewItem(num2.ToString());
						listViewItem.SubItems.Add(empty);
						listViewItem.SubItems.Add(empty2);
						listViewItem.SubItems.Add(Conversions.ToString(num3));
						listViewItem.SubItems.Add(Conversions.ToString(0));
						ListView1.Items.Add(listViewItem);
						Label7.Text = Conversions.ToString(ListView1.Items.Count);
						foreach (ListViewItem item2 in ListView1.Items)
						{
							num += (double)int.Parse(item2.Text);
						}
						Label6.Text = Conversions.ToString(num);
					}
					else
					{
						Interaction.MsgBox("El Codigo ingresado no tiene un producto relacionado.");
					}
					break;
				case 1:
				{
					Selector selector = MyProject.Forms.Selector;
					selector.Label1.Text = Conversions.ToString(2);
					selector.Label2.Text = Conversions.ToString(num3);
					selector.Label3.Text = empty;
					selector.ListView1.Items.Clear();
					selector = null;
					MyProject.Forms.Selector.ShowDialog();
					break;
				}
				}
				TextBox1.Text = "";
				TextBox2.Text = Conversions.ToString(1);
			}
			else
			{
				Interaction.MsgBox("Debe ingresar un codigo de barras.");
			}
		}
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		Button1.Enabled = false;
		try
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			int num5 = Conversions.ToInteger(Label1.Text);
			List<Mod_ActualizacionStock.abmStock> list = new List<Mod_ActualizacionStock.abmStock>();
			if (ListView1.Items.Count != ordenSeleccionada.Count)
			{
				Interaction.MsgBox("Orden Incompleta");
				Interaction.MsgBox("Tienes: " + Conversions.ToString(ListView1.Items.Count) + " productos y la orden pide: " + Conversions.ToString(ordenSeleccionada.Count) + " productos.");
				return;
			}
			if (Conversions.ToBoolean(finalControl()))
			{
				foreach (ListViewItem item2 in ListView1.Items)
				{
					num = int.Parse(item2.SubItems[3].Text);
					num2 = int.Parse(item2.Text);
					num3 = int.Parse(item2.SubItems[4].Text);
					Mod_ActualizacionStock.abmStock item = default(Mod_ActualizacionStock.abmStock);
					item.id = num;
					item.unidades = num2;
					item.variacion = num3;
					list.Add(item);
				}
				int num6 = Conversions.ToInteger(Mod_ActualizacionStock.egresoStock2(list, num5));
				if (num6 != 1)
				{
					Interaction.MsgBox("ERROR GRAVE!");
					Logger.e("ERROR GRAVE! egresoStock2 fallo -> ORDEN: " + Label9.Text + " EMPRESA: " + Conversions.ToString(num5));
					return;
				}
				Logger.i("actualizacion correcta");
				string sQL = Conversions.ToString(egresoDeProductos());
				int num7 = Conversions.ToInteger(Mod_ConeccionBD.BD_Sentencia(sQL));
				if (num7 == 1)
				{
					string sql = "Select id from ordenes where empresa=" + Conversions.ToString(num5) + " and numero='" + ComboBox2.Text + "' and estado=1";
					DataTable dataTable = (DataTable)Mod_Sentencias.data(sql);
					Mod_Ordenes.updateOrderStatus(Conversions.ToInteger(dataTable.Rows[0]["id"]), 2);
					ListView1.Items.Clear();
					obtenerOrdenes(num5);
					Interaction.MsgBox("Se guardo el movimiento.");
				}
				else
				{
					Interaction.MsgBox("Error al guardar el movimiento.");
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Logger.e(ex2.Message);
			ProjectData.ClearProjectError();
		}
		Button1.Enabled = true;
	}

	private object egresoDeProductos()
	{
		int num = Conversions.ToInteger(Label1.Text);
		string usuario = MySettingsProperty.Settings.Usuario;
		string text = ComboBox2.Text;
		string text2 = Strings.Format(MyProject.Forms.Form1_Inicio.DateTimePicker1.Value, "yyyyMMdd");
		string text3 = "INSERT INTO movimientos (orden, codprod, variacion, unidades, tipo, id_empresa, estado, fecha, usuario)\r\nVALUES";
		checked
		{
			int num2 = ListView1.Items.Count - 1;
			for (int i = 0; i <= num2; i++)
			{
				string text4 = ListView1.Items[i].Text;
				string text5 = ListView1.Items[i].SubItems[1].Text;
				int num3 = int.Parse(ListView1.Items[i].SubItems[4].Text);
				text3 = ((i != 0) ? (text3 + ", ('" + text + "', '" + text5 + "', '" + Conversions.ToString(num3) + "', '" + text4 + "', '1', '" + Conversions.ToString(num) + "', '0', now(), '" + usuario + "')") : (text3 + "('" + text + "', '" + text5 + "', '" + Conversions.ToString(num3) + "', '" + text4 + "', '1', '" + Conversions.ToString(num) + "', '0', now(), '" + usuario + "')"));
			}
			return text3;
		}
	}

	private void ListView1_DoubleClick(object sender, EventArgs e)
	{
		if (ListView1.SelectedItems.Count <= 0)
		{
			return;
		}
		double num = 0.0;
		int num2 = (int)MessageBox.Show("Desea Eliminar el item " + ListView1.SelectedItems[0].SubItems[2].Text, "Atencion", MessageBoxButtons.YesNoCancel);
		if (num2 == 2 || num2 == 7 || num2 != 6)
		{
			return;
		}
		ListView1.SelectedItems[0].Remove();
		Label7.Text = Conversions.ToString(ListView1.Items.Count);
		foreach (object item in ListView1.Items)
		{
			object objectValue = RuntimeHelpers.GetObjectValue(item);
			num += Conversions.ToDouble(NewLateBinding.LateGet(objectValue, null, "Text", new object[0], null, null, null));
		}
		Label6.Text = Conversions.ToString(num);
	}

	private void Button3_Click(object sender, EventArgs e)
	{
		PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
		printPreviewDialog.Document = PrintDocument1;
		printPreviewDialog.ShowDialog();
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

	private void Button4_Click(object sender, EventArgs e)
	{
		string prompt = "Introdusca la cantidad de bultos final.";
		string title = "Imprecion de etiquetas";
		string defaultResponse = Label6.Text;
		object obj = Interaction.InputBox(prompt, title, defaultResponse);
		if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(obj, "0", TextCompare: true), Operators.CompareObjectEqual(obj, "", TextCompare: true))))
		{
			return;
		}
		if (int.TryParse(Conversions.ToString(obj), out var result))
		{
			string sQL = ("INSERT INTO bultosorden ( ordenId, bultos, empresa) values ('" + ComboBox2.Text + "'," + Conversions.ToString(result) + ", " + Label1.Text + ") ON DUPLICATE KEY UPDATE bultos = " + Conversions.ToString(result)) ?? "";
			Mod_ConeccionBD.BD_Sentencia(sQL);
		}
		string sql = "Select e.nombre As empresa, o.numero As remito, d.nombre, d.direccion, d.localidad  from ordenes o LEFT JOIN destinos d On d.id = o.eventual LEFT JOIN empresas e On e.id = o.empresa WHERE o.numero='" + ComboBox2.Text + "' AND o.empresa = " + Label1.Text + " LIMIT 1";
		DataTable dataTable = (DataTable)Mod_Sentencias.data(sql);
		empresa = dataTable.Rows[0]["empresa"].ToString();
		remito = "REMITO: " + dataTable.Rows[0]["remito"].ToString();
		destino = dataTable.Rows[0]["nombre"].ToString();
		direccion = dataTable.Rows[0]["direccion"].ToString();
		localidad = "Loc:" + dataTable.Rows[0]["localidad"].ToString();
		bultostotal = Conversions.ToInteger(obj);
		PrintDialog1.Document = PrintDocument1;
		PrintDialog1.PrinterSettings = PrintDocument1.PrinterSettings;
		PrintDialog1.AllowSomePages = true;
		if (PrintDialog1.ShowDialog() == DialogResult.OK)
		{
			int num = bultostotal;
			for (int i = 1; i <= num; i = checked(i + 1))
			{
				bultos = "Bulto: " + Conversions.ToString(i) + "/" + Conversions.ToString(bultostotal);
				PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings;
				PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
				PrintDocument1.DefaultPageSettings.Landscape = false;
				printPreviewDialog.WindowState = FormWindowState.Maximized;
				printPreviewDialog.Document = PrintDocument1;
				PrintDocument1.Print();
			}
		}
	}

	private void PrintDocument1_PrintPage(object sender, PrintPageEventArgs e)
	{
		int pHvalor = MySettingsProperty.Settings.pHvalor;
		int pVvalor = MySettingsProperty.Settings.pVvalor;
		Font font = new Font("Arial", 6.75f, FontStyle.Italic, GraphicsUnit.Point, 0);
		Font font2 = new Font("Arial", 16.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		Font font3 = new Font("Arial", 14.75f, FontStyle.Italic, GraphicsUnit.Point, 0);
		Font font4 = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, 0);
		Rectangle empty = Rectangle.Empty;
		checked
		{
			empty.X = pHvalor + 2;
			empty.Y = pVvalor;
			empty.Width = 300;
			empty.Height = 150;
			e.Graphics.DrawRectangle(Pens.Black, empty);
			e.Graphics.DrawString(empresa, font2, Brushes.Black, empty.X + 10, empty.Y + 5);
			e.Graphics.DrawString(remito, font2, Brushes.Black, empty.X + 10, empty.Y + 30);
			e.Graphics.DrawString(destino, font4, Brushes.Black, empty.X + 10, empty.Y + 65);
			e.Graphics.DrawString(localidad, font4, Brushes.Black, empty.X + 10, empty.Y + 85);
			e.Graphics.DrawString(bultos, font2, Brushes.Black, empty.X + 10, empty.Y + 105);
		}
	}

	private object validateProduct(int idproduct)
	{
		int num = 0;
		foreach (orderItem ordenSeleccionadum in ordenSeleccionada)
		{
			if (ordenSeleccionadum.id == idproduct)
			{
				num = 1;
				break;
			}
		}
		return num;
	}

	private object validateVariation(int idvariation)
	{
		int num = 0;
		foreach (orderItem ordenSeleccionadum in ordenSeleccionada)
		{
			if (ordenSeleccionadum.variation == idvariation)
			{
				num = 1;
				break;
			}
		}
		return num;
	}

	public object validateunits(int idproduct, int idvariation, int units)
	{
		int num = 0;
		foreach (orderItem ordenSeleccionadum in ordenSeleccionada)
		{
			if ((ordenSeleccionadum.id == idproduct) & (ordenSeleccionadum.variation == idvariation) & (ordenSeleccionadum.units >= units))
			{
				num = 1;
				break;
			}
		}
		return num;
	}

	private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (e.KeyChar == '\r')
		{
			TextBox1.Focus();
		}
	}

	private void LoadOrder(string orden)
	{
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		ordenSeleccionada = new List<orderItem>();
		int num = int.Parse(((KeyValuePair<string, string>)ComboBox2.SelectedItem).Key);
		string text = "Select d.ordenid As ORDEN, d.productid As PRODUCTO, p.barrcode As CODIGO, p.descripcion As DESCRIPCION, d.unidades As UNIDADES, d.varid as VARIACIONES from orderdetalle d LEFT JOIN productos p On d.productid=p.id where p.variaciones=0 And d.ordenid=" + Conversions.ToString(num) + " UNION ALL Select d.ordenid As ORDEN, d.productid As PRODUCTO, p.barrcode As CODIGO, v.descripcion As DESCRIPCION, d.unidades As UNIDADES, d.varid as VARIACIONES from ((orderdetalle d LEFT JOIN productos p On d.productid=p.id) LEFT JOIN variaciones v On v.id=d.varid) where p.variaciones<>0 And d.ordenid=" + Conversions.ToString(num);
		MySqlDataAdapter val = new MySqlDataAdapter(text, Mod_Sentencias.cnn);
		DataTable dataTable = new DataTable("orden");
		((DbDataAdapter)(object)val).Fill(dataTable);
		checked
		{
			int num2 = dataTable.Rows.Count - 1;
			for (int i = 0; i <= num2; i++)
			{
				orderItem item = default(orderItem);
				item.id = int.Parse(Conversions.ToString(dataTable.Rows[i]["PRODUCTO"]));
				item.barrcode = Conversions.ToString(dataTable.Rows[i]["CODIGO"]);
				item.units = int.Parse(Conversions.ToString(dataTable.Rows[i]["UNIDADES"]));
				item.variation = int.Parse(Conversions.ToString(dataTable.Rows[i]["VARIACIONES"]));
				Console.WriteLine(item.id);
				Console.WriteLine(item.barrcode);
				Console.WriteLine(item.units);
				ordenSeleccionada.Add(item);
			}
		}
	}

	private void ComboBox2_TextUpdate(object sender, EventArgs e)
	{
		Label2.Text = string.Empty;
		Label9.Text = string.Empty;
		ListView1.Items.Clear();
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		Close();
	}

	private object finalControl()
	{
		bool flag = false;
		if (Operators.CompareString(Label9.Text, string.Empty, TextCompare: true) == 0)
		{
			Interaction.MsgBox("No hay una orden seleccionada");
			return false;
		}
		if (ordenSeleccionada.Count != ListView1.Items.Count)
		{
			int num = checked(ordenSeleccionada.Count - ListView1.Items.Count);
			Interaction.MsgBox("Faltan " + Conversions.ToString(num) + " Productos en la orden");
			return false;
		}
		foreach (ListViewItem item in ListView1.Items)
		{
			if (Operators.ConditionalCompareObjectEqual(findProducto(item.SubItems[1].Text, Conversions.ToInteger(item.Text)), false, TextCompare: true))
			{
				return false;
			}
		}
		return true;
	}

	private object findProducto(string barrcode, int unidades)
	{
		bool flag = false;
		foreach (orderItem ordenSeleccionadum in ordenSeleccionada)
		{
			if (string.Compare(ordenSeleccionadum.barrcode, barrcode) == 0)
			{
				if (object.Equals(ordenSeleccionadum.units, unidades))
				{
					flag = true;
				}
				else if (unidades > ordenSeleccionadum.units)
				{
					Interaction.MsgBox("PRODUCTO: " + barrcode + " Se piden " + Conversions.ToString(ordenSeleccionadum.units) + " estas ingresando " + Conversions.ToString(unidades));
				}
				else
				{
					int num = checked(ordenSeleccionadum.units - unidades);
					Interaction.MsgBox("Faltan " + Conversions.ToString(num) + " del codigo " + ordenSeleccionadum.barrcode + " para completar el pedido.");
				}
			}
		}
		return flag;
	}
}
