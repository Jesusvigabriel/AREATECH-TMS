using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Hermes.My;
using Hermes.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Hermes;

[DesignerGenerated]
public class Almacen : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ListView1")]
	private ListView _ListView1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStripButton1")]
	private ToolStripButton _ToolStripButton1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStripButton2")]
	private ToolStripButton _ToolStripButton2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("PosicionarPalletToolStripMenuItem")]
	private ToolStripMenuItem _PosicionarPalletToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("PosicionesToolStripMenuItem")]
	private ToolStripMenuItem _PosicionesToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("MudarPalletToolStripMenuItem")]
	private ToolStripMenuItem _MudarPalletToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("NuevaPosicionToolStripMenuItem")]
	private ToolStripMenuItem _NuevaPosicionToolStripMenuItem;

	public int mode;

	[field: AccessedThroughProperty("ToolStrip1")]
	internal virtual ToolStrip ToolStrip1
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

	internal virtual ToolStripButton ToolStripButton2
	{
		[CompilerGenerated]
		get
		{
			return _ToolStripButton2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ToolStripButton2_Click;
			ToolStripButton toolStripButton = _ToolStripButton2;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value2;
			}
			_ToolStripButton2 = value;
			toolStripButton = _ToolStripButton2;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ToolStripDropDownButton1")]
	internal virtual ToolStripDropDownButton ToolStripDropDownButton1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripMenuItem PosicionarPalletToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _PosicionarPalletToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = PosicionarPalletToolStripMenuItem_Click;
			ToolStripMenuItem posicionarPalletToolStripMenuItem = _PosicionarPalletToolStripMenuItem;
			if (posicionarPalletToolStripMenuItem != null)
			{
				posicionarPalletToolStripMenuItem.Click -= value2;
			}
			_PosicionarPalletToolStripMenuItem = value;
			posicionarPalletToolStripMenuItem = _PosicionarPalletToolStripMenuItem;
			if (posicionarPalletToolStripMenuItem != null)
			{
				posicionarPalletToolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem PosicionesToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _PosicionesToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = PosicionesToolStripMenuItem_Click;
			ToolStripMenuItem posicionesToolStripMenuItem = _PosicionesToolStripMenuItem;
			if (posicionesToolStripMenuItem != null)
			{
				posicionesToolStripMenuItem.Click -= value2;
			}
			_PosicionesToolStripMenuItem = value;
			posicionesToolStripMenuItem = _PosicionesToolStripMenuItem;
			if (posicionesToolStripMenuItem != null)
			{
				posicionesToolStripMenuItem.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("ToolStripSeparator2")]
	internal virtual ToolStripSeparator ToolStripSeparator2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ToolStripSeparator1")]
	internal virtual ToolStripSeparator ToolStripSeparator1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("MudarRolloToolStripMenuItem")]
	internal virtual ToolStripMenuItem MudarRolloToolStripMenuItem
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripMenuItem MudarPalletToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _MudarPalletToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = MudarPalletToolStripMenuItem_Click;
			ToolStripMenuItem mudarPalletToolStripMenuItem = _MudarPalletToolStripMenuItem;
			if (mudarPalletToolStripMenuItem != null)
			{
				mudarPalletToolStripMenuItem.Click -= value2;
			}
			_MudarPalletToolStripMenuItem = value;
			mudarPalletToolStripMenuItem = _MudarPalletToolStripMenuItem;
			if (mudarPalletToolStripMenuItem != null)
			{
				mudarPalletToolStripMenuItem.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("VerToolStripMenuItem")]
	internal virtual ToolStripMenuItem VerToolStripMenuItem
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripMenuItem NuevaPosicionToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _NuevaPosicionToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = NuevaPosicionToolStripMenuItem_Click;
			ToolStripMenuItem nuevaPosicionToolStripMenuItem = _NuevaPosicionToolStripMenuItem;
			if (nuevaPosicionToolStripMenuItem != null)
			{
				nuevaPosicionToolStripMenuItem.Click -= value2;
			}
			_NuevaPosicionToolStripMenuItem = value;
			nuevaPosicionToolStripMenuItem = _NuevaPosicionToolStripMenuItem;
			if (nuevaPosicionToolStripMenuItem != null)
			{
				nuevaPosicionToolStripMenuItem.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("DateTimePicker1")]
	internal virtual DateTimePicker DateTimePicker1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("StatusStrip1")]
	internal virtual StatusStrip StatusStrip1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ToolStripStatusLabel1")]
	internal virtual ToolStripStatusLabel ToolStripStatusLabel1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ToolStripStatusLabel2")]
	internal virtual ToolStripStatusLabel ToolStripStatusLabel2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ToolStripStatusLabel3")]
	internal virtual ToolStripStatusLabel ToolStripStatusLabel3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ToolStripStatusLabel4")]
	internal virtual ToolStripStatusLabel ToolStripStatusLabel4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ToolStripStatusLabel5")]
	internal virtual ToolStripStatusLabel ToolStripStatusLabel5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ToolStripStatusLabel6")]
	internal virtual ToolStripStatusLabel ToolStripStatusLabel6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public Almacen()
	{
		base.Load += Almacen_Load;
		mode = 0;
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
		this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
		this.ToolStripButton1 = new System.Windows.Forms.ToolStripButton();
		this.ToolStripButton2 = new System.Windows.Forms.ToolStripButton();
		this.ToolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
		this.PosicionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.VerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.NuevaPosicionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.ToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
		this.PosicionarPalletToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
		this.MudarRolloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.MudarPalletToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.ListView1 = new System.Windows.Forms.ListView();
		this.Label1 = new System.Windows.Forms.Label();
		this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
		this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
		this.ToolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
		this.ToolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
		this.ToolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
		this.ToolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
		this.ToolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
		this.ToolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
		this.ToolStrip1.SuspendLayout();
		this.StatusStrip1.SuspendLayout();
		base.SuspendLayout();
		this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[3] { this.ToolStripButton1, this.ToolStripButton2, this.ToolStripDropDownButton1 });
		this.ToolStrip1.Location = new System.Drawing.Point(0, 0);
		this.ToolStrip1.Name = "ToolStrip1";
		this.ToolStrip1.Size = new System.Drawing.Size(628, 25);
		this.ToolStrip1.TabIndex = 0;
		this.ToolStrip1.Text = "ToolStrip1";
		this.ToolStripButton1.Image = Hermes.My.Resources.Resources.document_preview_archive;
		this.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.ToolStripButton1.Name = "ToolStripButton1";
		this.ToolStripButton1.Size = new System.Drawing.Size(62, 22);
		this.ToolStripButton1.Text = "Buscar";
		this.ToolStripButton2.Image = Hermes.My.Resources.Resources.Button_White_Load;
		this.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.ToolStripButton2.Name = "ToolStripButton2";
		this.ToolStripButton2.Size = new System.Drawing.Size(85, 22);
		this.ToolStripButton2.Text = "Sincronizar";
		this.ToolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[6] { this.PosicionesToolStripMenuItem, this.ToolStripSeparator2, this.PosicionarPalletToolStripMenuItem, this.ToolStripSeparator1, this.MudarRolloToolStripMenuItem, this.MudarPalletToolStripMenuItem });
		this.ToolStripDropDownButton1.Image = Hermes.My.Resources.Resources.Antrepo_Container_2_Cargo_1;
		this.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1";
		this.ToolStripDropDownButton1.Size = new System.Drawing.Size(92, 22);
		this.ToolStripDropDownButton1.Text = "Posiciones";
		this.ToolStripDropDownButton1.ToolTipText = "Posiciones";
		this.PosicionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[2] { this.VerToolStripMenuItem, this.NuevaPosicionToolStripMenuItem });
		this.PosicionesToolStripMenuItem.Name = "PosicionesToolStripMenuItem";
		this.PosicionesToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
		this.PosicionesToolStripMenuItem.Text = "Posiciones";
		this.VerToolStripMenuItem.Name = "VerToolStripMenuItem";
		this.VerToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
		this.VerToolStripMenuItem.Text = "Ver";
		this.NuevaPosicionToolStripMenuItem.Name = "NuevaPosicionToolStripMenuItem";
		this.NuevaPosicionToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
		this.NuevaPosicionToolStripMenuItem.Text = "Nueva Posicion";
		this.ToolStripSeparator2.Name = "ToolStripSeparator2";
		this.ToolStripSeparator2.Size = new System.Drawing.Size(158, 6);
		this.PosicionarPalletToolStripMenuItem.Name = "PosicionarPalletToolStripMenuItem";
		this.PosicionarPalletToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
		this.PosicionarPalletToolStripMenuItem.Text = "Posicionar Pallet";
		this.ToolStripSeparator1.Name = "ToolStripSeparator1";
		this.ToolStripSeparator1.Size = new System.Drawing.Size(158, 6);
		this.MudarRolloToolStripMenuItem.Name = "MudarRolloToolStripMenuItem";
		this.MudarRolloToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
		this.MudarRolloToolStripMenuItem.Text = "Mudar Rollo";
		this.MudarPalletToolStripMenuItem.Name = "MudarPalletToolStripMenuItem";
		this.MudarPalletToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
		this.MudarPalletToolStripMenuItem.Text = "Mudar Pallet";
		this.ListView1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.ListView1.Location = new System.Drawing.Point(0, 25);
		this.ListView1.Name = "ListView1";
		this.ListView1.Size = new System.Drawing.Size(628, 284);
		this.ListView1.TabIndex = 1;
		this.ListView1.UseCompatibleStateImageBehavior = false;
		this.ListView1.View = System.Windows.Forms.View.Details;
		this.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.Label1.AutoSize = true;
		this.Label1.Location = new System.Drawing.Point(568, 9);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(39, 13);
		this.Label1.TabIndex = 2;
		this.Label1.Text = "Label1";
		this.DateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
		this.DateTimePicker1.Location = new System.Drawing.Point(466, 3);
		this.DateTimePicker1.Name = "DateTimePicker1";
		this.DateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.No;
		this.DateTimePicker1.Size = new System.Drawing.Size(96, 20);
		this.DateTimePicker1.TabIndex = 3;
		this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[6] { this.ToolStripStatusLabel1, this.ToolStripStatusLabel2, this.ToolStripStatusLabel3, this.ToolStripStatusLabel4, this.ToolStripStatusLabel5, this.ToolStripStatusLabel6 });
		this.StatusStrip1.Location = new System.Drawing.Point(0, 312);
		this.StatusStrip1.Name = "StatusStrip1";
		this.StatusStrip1.Size = new System.Drawing.Size(628, 22);
		this.StatusStrip1.TabIndex = 4;
		this.StatusStrip1.Text = "StatusStrip1";
		this.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
		this.ToolStripStatusLabel1.Size = new System.Drawing.Size(37, 17);
		this.ToolStripStatusLabel1.Text = "Total:";
		this.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2";
		this.ToolStripStatusLabel2.Size = new System.Drawing.Size(13, 17);
		this.ToolStripStatusLabel2.Text = "0";
		this.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3";
		this.ToolStripStatusLabel3.Size = new System.Drawing.Size(68, 17);
		this.ToolStripStatusLabel3.Text = "Excedentes:";
		this.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4";
		this.ToolStripStatusLabel4.Size = new System.Drawing.Size(13, 17);
		this.ToolStripStatusLabel4.Text = "0";
		this.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5";
		this.ToolStripStatusLabel5.Size = new System.Drawing.Size(57, 17);
		this.ToolStripStatusLabel5.Text = "Faltantes:";
		this.ToolStripStatusLabel6.Name = "ToolStripStatusLabel6";
		this.ToolStripStatusLabel6.Size = new System.Drawing.Size(13, 17);
		this.ToolStripStatusLabel6.Text = "0";
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(628, 334);
		base.Controls.Add(this.StatusStrip1);
		base.Controls.Add(this.DateTimePicker1);
		base.Controls.Add(this.Label1);
		base.Controls.Add(this.ListView1);
		base.Controls.Add(this.ToolStrip1);
		base.Name = "Almacen";
		this.Text = "Almacen";
		this.ToolStrip1.ResumeLayout(false);
		this.ToolStrip1.PerformLayout();
		this.StatusStrip1.ResumeLayout(false);
		this.StatusStrip1.PerformLayout();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private void Almacen_Load(object sender, EventArgs e)
	{
		ListView1.Columns.Clear();
		int num = 0;
		int num2 = 0;
		string sql = "select \np.id, p.barrcode, p.codeempresa, p.descripcion, d.descripcion as Actual, g.descripcion as Anterior \nFROM productos p \nLEFT JOIN ubicacion u ON p.id = u.codprod \nLEFT JOIN posicion d ON d.id = u.posActual \nLEFT JOIN posicion g ON g.id = u.posAnterior \nWHERE p.empresa=8";
		Mod_Sentencias.cargar_datos_lv_completa(ListView1, sql, Label1);
		ToolStripStatusLabel2.Text = Conversions.ToString(ListView1.Items.Count);
		checked
		{
			int num3 = ListView1.Items.Count - 1;
			for (int i = 0; i <= num3; i++)
			{
				if (Operators.CompareString(ListView1.Items[i].SubItems[2].Text, string.Empty, TextCompare: true) == 0)
				{
					num++;
				}
				if (Operators.CompareString(ListView1.Items[i].SubItems[4].Text, string.Empty, TextCompare: true) == 0)
				{
					num2++;
				}
			}
			ToolStripStatusLabel4.Text = num.ToString();
			ToolStripStatusLabel6.Text = num2.ToString();
		}
	}

	private void ListView1_ColumnClick(object sender, ColumnClickEventArgs e)
	{
		Mod_Ordenaclumnas.ordenar_columnas(ListView1, RuntimeHelpers.GetObjectValue(sender), e);
	}

	private void ToolStripButton2_Click(object sender, EventArgs e)
	{
		mode = 0;
		int num = 0;
		int num2 = 0;
		ListView1.Clear();
		string sql = "select \n                                p.id, p.barrcode, p.codeempresa, p.descripcion, d.descripcion as Actual, g.descripcion as Anterior \n                            FROM productos p \n                            LEFT JOIN ubicacion u ON p.id = u.codprod \n                            LEFT JOIN posicion d ON d.id = u.posActual \n                            LEFT JOIN posicion g ON g.id = u.posAnterior \n                            WHERE p.empresa=8";
		Mod_Sentencias.cargar_datos_lv_completa(ListView1, sql, Label1);
		ToolStripStatusLabel2.Text = Conversions.ToString(ListView1.Items.Count);
		checked
		{
			int num3 = ListView1.Items.Count - 1;
			for (int i = 0; i <= num3; i++)
			{
				if (Operators.CompareString(ListView1.Items[i].SubItems[2].Text, string.Empty, TextCompare: true) == 0)
				{
					num++;
				}
				if (Operators.CompareString(ListView1.Items[i].SubItems[4].Text, string.Empty, TextCompare: true) == 0)
				{
					num2++;
				}
			}
			ToolStripStatusLabel4.Text = num.ToString();
			ToolStripStatusLabel6.Text = num2.ToString();
		}
	}

	private void PosicionesToolStripMenuItem_Click(object sender, EventArgs e)
	{
		mode = 1;
		ListView1.Clear();
		string sql = "select id, descripcion FROM posicion";
		Mod_Sentencias.cargar_datos_lv_completa(ListView1, sql, Label1);
	}

	private void PosicionarPalletToolStripMenuItem_Click(object sender, EventArgs e)
	{
		mode = 2;
		string text = Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd");
		ListView1.Clear();
		string sql = "select d.id, d.rollo, d.pallet, d.observaciones, d.fecha, d.usuario FROM descarga d WHERE d.fecha like '%" + text + "%'";
		Mod_Sentencias.cargar_datos_lv_completa(ListView1, sql, Label1);
	}

	private void NuevaPosicionToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (Conversions.ToDouble(MySettingsProperty.Settings.Permiso) == 10.0)
		{
			PosicionModal posicionModal = MyProject.Forms.PosicionModal;
			posicionModal.mode = 1;
			posicionModal = null;
			MyProject.Forms.PosicionModal.ShowDialog();
		}
		else
		{
			Interaction.MsgBox("No posee los permisos para esta accion");
		}
	}

	private void ListView1_DoubleClick(object sender, EventArgs e)
	{
		if (ListView1.SelectedItems.Count <= 0)
		{
			return;
		}
		checked
		{
			switch (mode)
			{
			case 0:
			{
				Interaction.MsgBox("MODE: " + Conversions.ToString(mode));
				string text = ListView1.SelectedItems[0].SubItems[1].Text;
				PosicionModal posicionModal2 = MyProject.Forms.PosicionModal;
				posicionModal2.mode = 0;
				posicionModal2.Label1.Text = "Rollo";
				posicionModal2.ComboBox1.Text = text;
				posicionModal2.Label2.Text = "Nueva Posicion";
				string sql2 = "SELECT descripcion from posicion order by descripcion asc";
				DataTable dataTable2 = (DataTable)Mod_Sentencias.data(sql2);
				posicionModal2.ComboBox2.Items.Clear();
				int num3 = dataTable2.Rows.Count - 1;
				for (int j = 0; j <= num3; j++)
				{
					posicionModal2.ComboBox2.Items.Add(RuntimeHelpers.GetObjectValue(dataTable2.Rows[j]["descripcion"]));
				}
				posicionModal2.Label3.Visible = false;
				posicionModal2.ComboBox3.Visible = false;
				posicionModal2.Button1.Text = "Asignar";
				posicionModal2 = null;
				MyProject.Forms.PosicionModal.Show();
				break;
			}
			case 1:
				Interaction.MsgBox("MODE: " + Conversions.ToString(mode));
				break;
			case 2:
				try
				{
					int num = Conversions.ToInteger(ListView1.SelectedItems[0].SubItems[2].Text);
					PosicionModal posicionModal = MyProject.Forms.PosicionModal;
					posicionModal.mode = 2;
					posicionModal.Label1.Text = "Pallet";
					posicionModal.ComboBox1.Text = Conversions.ToString(num);
					posicionModal.Label2.Text = "Posicion";
					string sql = "SELECT descripcion from posicion order by descripcion asc";
					DataTable dataTable = (DataTable)Mod_Sentencias.data(sql);
					posicionModal.ComboBox2.Items.Clear();
					int num2 = dataTable.Rows.Count - 1;
					for (int i = 0; i <= num2; i++)
					{
						posicionModal.ComboBox2.Items.Add(RuntimeHelpers.GetObjectValue(dataTable.Rows[i]["descripcion"]));
					}
					posicionModal.Label3.Visible = false;
					posicionModal.ComboBox3.Visible = false;
					posicionModal.Button1.Text = "Asignar";
					posicionModal = null;
					MyProject.Forms.PosicionModal.Show();
					break;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					Logger.e(ex2.Message);
					ProjectData.ClearProjectError();
					break;
				}
			case 3:
				Interaction.MsgBox("MODE: " + Conversions.ToString(mode));
				break;
			}
		}
	}

	private void MudarPalletToolStripMenuItem_Click(object sender, EventArgs e)
	{
		checked
		{
			if (Conversions.ToDouble(MySettingsProperty.Settings.Permiso) == 10.0)
			{
				PosicionModal posicionModal = MyProject.Forms.PosicionModal;
				posicionModal.mode = 3;
				posicionModal.Label1.Text = "Posicion Origen:";
				posicionModal.Label2.Text = "Posicion Destino:";
				string sql = "SELECT descripcion from posicion order by descripcion asc";
				DataTable dataTable = (DataTable)Mod_Sentencias.data(sql);
				posicionModal.ComboBox1.Items.Clear();
				posicionModal.ComboBox2.Items.Clear();
				int num = dataTable.Rows.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					posicionModal.ComboBox1.Items.Add(RuntimeHelpers.GetObjectValue(dataTable.Rows[i]["descripcion"]));
					posicionModal.ComboBox2.Items.Add(RuntimeHelpers.GetObjectValue(dataTable.Rows[i]["descripcion"]));
				}
				posicionModal.Label3.Visible = false;
				posicionModal.ComboBox3.Visible = false;
				posicionModal.Button1.Text = "Mudar";
				posicionModal = null;
				MyProject.Forms.PosicionModal.Show();
			}
			else
			{
				Interaction.MsgBox("No posee los permisos para esta accion");
			}
		}
	}

	private void ToolStripButton1_Click(object sender, EventArgs e)
	{
		object obj = Interaction.InputBox("Buscar: ", "Buscar", Conversions.ToString(1), 100, 100);
		if (obj == "")
		{
			obj = 1;
			return;
		}
		ListViewItem listViewItem = ListView1.FindItemWithText(Conversions.ToString(obj), includeSubItemsInSearch: true, 0);
		if (listViewItem != null)
		{
			ListView1.Items[listViewItem.Index].Selected = true;
			ListView1.SelectedItems[0].EnsureVisible();
		}
	}
}
