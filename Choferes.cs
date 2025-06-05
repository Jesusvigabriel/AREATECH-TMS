using System;
using System.ComponentModel;
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
public class Choferes : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("NewToolStripButton")]
	private ToolStripButton _NewToolStripButton;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("SaveToolStripButton")]
	private ToolStripButton _SaveToolStripButton;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ListView1")]
	private ListView _ListView1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStripButton1")]
	private ToolStripButton _ToolStripButton1;

	private string fecha1;

	[field: AccessedThroughProperty("ToolStrip1")]
	internal virtual ToolStrip ToolStrip1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripButton NewToolStripButton
	{
		[CompilerGenerated]
		get
		{
			return _NewToolStripButton;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = NewToolStripButton_Click;
			ToolStripButton newToolStripButton = _NewToolStripButton;
			if (newToolStripButton != null)
			{
				newToolStripButton.Click -= value2;
			}
			_NewToolStripButton = value;
			newToolStripButton = _NewToolStripButton;
			if (newToolStripButton != null)
			{
				newToolStripButton.Click += value2;
			}
		}
	}

	internal virtual ToolStripButton SaveToolStripButton
	{
		[CompilerGenerated]
		get
		{
			return _SaveToolStripButton;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = SaveToolStripButton_Click;
			ToolStripButton saveToolStripButton = _SaveToolStripButton;
			if (saveToolStripButton != null)
			{
				saveToolStripButton.Click -= value2;
			}
			_SaveToolStripButton = value;
			saveToolStripButton = _SaveToolStripButton;
			if (saveToolStripButton != null)
			{
				saveToolStripButton.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("PrintToolStripButton")]
	internal virtual ToolStripButton PrintToolStripButton
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("toolStripSeparator")]
	internal virtual ToolStripSeparator toolStripSeparator
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CutToolStripButton")]
	internal virtual ToolStripButton CutToolStripButton
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CopyToolStripButton")]
	internal virtual ToolStripButton CopyToolStripButton
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PasteToolStripButton")]
	internal virtual ToolStripButton PasteToolStripButton
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("toolStripSeparator1")]
	internal virtual ToolStripSeparator toolStripSeparator1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("HelpToolStripButton")]
	internal virtual ToolStripButton HelpToolStripButton
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

	[field: AccessedThroughProperty("patentecombo")]
	internal virtual ComboBox patentecombo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("nombretxt")]
	internal virtual TextBox nombretxt
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

	[field: AccessedThroughProperty("usuariolbl")]
	internal virtual Label usuariolbl
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("bajalbl")]
	internal virtual Label bajalbl
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("modificadolbl")]
	internal virtual Label modificadolbl
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("altalbl")]
	internal virtual Label altalbl
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("patentenlbl")]
	internal virtual Label patentenlbl
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("nombrelbl")]
	internal virtual Label nombrelbl
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
			ListView listView = _ListView1;
			if (listView != null)
			{
				listView.SelectedIndexChanged -= value2;
			}
			_ListView1 = value;
			listView = _ListView1;
			if (listView != null)
			{
				listView.SelectedIndexChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Numero")]
	internal virtual ColumnHeader Numero
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Nombre")]
	internal virtual ColumnHeader Nombre
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Patente")]
	internal virtual ColumnHeader Patente
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

	[field: AccessedThroughProperty("modificadotxt")]
	internal virtual Label modificadotxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("bajatxt")]
	internal virtual Label bajatxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("altatxt")]
	internal virtual Label altatxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("choferestxt")]
	internal virtual Label choferestxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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

	public Choferes()
	{
		base.Load += Choferes_Load;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hermes.Choferes));
		this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
		this.NewToolStripButton = new System.Windows.Forms.ToolStripButton();
		this.SaveToolStripButton = new System.Windows.Forms.ToolStripButton();
		this.ToolStripButton1 = new System.Windows.Forms.ToolStripButton();
		this.PrintToolStripButton = new System.Windows.Forms.ToolStripButton();
		this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
		this.CutToolStripButton = new System.Windows.Forms.ToolStripButton();
		this.CopyToolStripButton = new System.Windows.Forms.ToolStripButton();
		this.PasteToolStripButton = new System.Windows.Forms.ToolStripButton();
		this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
		this.HelpToolStripButton = new System.Windows.Forms.ToolStripButton();
		this.GroupBox1 = new System.Windows.Forms.GroupBox();
		this.choferestxt = new System.Windows.Forms.Label();
		this.usuariotxt = new System.Windows.Forms.Label();
		this.modificadotxt = new System.Windows.Forms.Label();
		this.bajatxt = new System.Windows.Forms.Label();
		this.altatxt = new System.Windows.Forms.Label();
		this.patentecombo = new System.Windows.Forms.ComboBox();
		this.nombretxt = new System.Windows.Forms.TextBox();
		this.numerotxt = new System.Windows.Forms.TextBox();
		this.usuariolbl = new System.Windows.Forms.Label();
		this.bajalbl = new System.Windows.Forms.Label();
		this.modificadolbl = new System.Windows.Forms.Label();
		this.altalbl = new System.Windows.Forms.Label();
		this.patentenlbl = new System.Windows.Forms.Label();
		this.nombrelbl = new System.Windows.Forms.Label();
		this.numerolbl = new System.Windows.Forms.Label();
		this.idtxt = new System.Windows.Forms.Label();
		this.idlbl = new System.Windows.Forms.Label();
		this.ListView1 = new System.Windows.Forms.ListView();
		this.Numero = new System.Windows.Forms.ColumnHeader();
		this.Nombre = new System.Windows.Forms.ColumnHeader();
		this.Patente = new System.Windows.Forms.ColumnHeader();
		this.ToolStrip1.SuspendLayout();
		this.GroupBox1.SuspendLayout();
		base.SuspendLayout();
		this.ToolStrip1.BackColor = System.Drawing.Color.Transparent;
		this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[10] { this.NewToolStripButton, this.SaveToolStripButton, this.ToolStripButton1, this.PrintToolStripButton, this.toolStripSeparator, this.CutToolStripButton, this.CopyToolStripButton, this.PasteToolStripButton, this.toolStripSeparator1, this.HelpToolStripButton });
		this.ToolStrip1.Location = new System.Drawing.Point(0, 0);
		this.ToolStrip1.Name = "ToolStrip1";
		this.ToolStrip1.Size = new System.Drawing.Size(655, 25);
		this.ToolStrip1.TabIndex = 0;
		this.ToolStrip1.Text = "ToolStrip1";
		this.NewToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
		this.NewToolStripButton.Image = (System.Drawing.Image)resources.GetObject("NewToolStripButton.Image");
		this.NewToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.NewToolStripButton.Name = "NewToolStripButton";
		this.NewToolStripButton.Size = new System.Drawing.Size(23, 22);
		this.NewToolStripButton.Text = "&Nuevo Chofer";
		this.SaveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
		this.SaveToolStripButton.Image = (System.Drawing.Image)resources.GetObject("SaveToolStripButton.Image");
		this.SaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.SaveToolStripButton.Name = "SaveToolStripButton";
		this.SaveToolStripButton.Size = new System.Drawing.Size(23, 22);
		this.SaveToolStripButton.Text = "&Guardar ";
		this.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
		this.ToolStripButton1.Image = Hermes.My.Resources.Resources.close_32;
		this.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.ToolStripButton1.Name = "ToolStripButton1";
		this.ToolStripButton1.Size = new System.Drawing.Size(23, 22);
		this.ToolStripButton1.Text = "&Quitar Vehiculo";
		this.PrintToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
		this.PrintToolStripButton.Image = (System.Drawing.Image)resources.GetObject("PrintToolStripButton.Image");
		this.PrintToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.PrintToolStripButton.Name = "PrintToolStripButton";
		this.PrintToolStripButton.Size = new System.Drawing.Size(23, 22);
		this.PrintToolStripButton.Text = "&Imprimir";
		this.toolStripSeparator.Name = "toolStripSeparator";
		this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
		this.CutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
		this.CutToolStripButton.Image = (System.Drawing.Image)resources.GetObject("CutToolStripButton.Image");
		this.CutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.CutToolStripButton.Name = "CutToolStripButton";
		this.CutToolStripButton.Size = new System.Drawing.Size(23, 22);
		this.CutToolStripButton.Text = "C&ut";
		this.CopyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
		this.CopyToolStripButton.Image = (System.Drawing.Image)resources.GetObject("CopyToolStripButton.Image");
		this.CopyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.CopyToolStripButton.Name = "CopyToolStripButton";
		this.CopyToolStripButton.Size = new System.Drawing.Size(23, 22);
		this.CopyToolStripButton.Text = "&Copy";
		this.PasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
		this.PasteToolStripButton.Image = (System.Drawing.Image)resources.GetObject("PasteToolStripButton.Image");
		this.PasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.PasteToolStripButton.Name = "PasteToolStripButton";
		this.PasteToolStripButton.Size = new System.Drawing.Size(23, 22);
		this.PasteToolStripButton.Text = "&Paste";
		this.toolStripSeparator1.Name = "toolStripSeparator1";
		this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
		this.HelpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
		this.HelpToolStripButton.Image = (System.Drawing.Image)resources.GetObject("HelpToolStripButton.Image");
		this.HelpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.HelpToolStripButton.Name = "HelpToolStripButton";
		this.HelpToolStripButton.Size = new System.Drawing.Size(23, 22);
		this.HelpToolStripButton.Text = "He&lp";
		this.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.GroupBox1.Controls.Add(this.choferestxt);
		this.GroupBox1.Controls.Add(this.usuariotxt);
		this.GroupBox1.Controls.Add(this.modificadotxt);
		this.GroupBox1.Controls.Add(this.bajatxt);
		this.GroupBox1.Controls.Add(this.altatxt);
		this.GroupBox1.Controls.Add(this.patentecombo);
		this.GroupBox1.Controls.Add(this.nombretxt);
		this.GroupBox1.Controls.Add(this.numerotxt);
		this.GroupBox1.Controls.Add(this.usuariolbl);
		this.GroupBox1.Controls.Add(this.bajalbl);
		this.GroupBox1.Controls.Add(this.modificadolbl);
		this.GroupBox1.Controls.Add(this.altalbl);
		this.GroupBox1.Controls.Add(this.patentenlbl);
		this.GroupBox1.Controls.Add(this.nombrelbl);
		this.GroupBox1.Controls.Add(this.numerolbl);
		this.GroupBox1.Controls.Add(this.idtxt);
		this.GroupBox1.Controls.Add(this.idlbl);
		this.GroupBox1.Location = new System.Drawing.Point(12, 28);
		this.GroupBox1.Name = "GroupBox1";
		this.GroupBox1.Size = new System.Drawing.Size(629, 148);
		this.GroupBox1.TabIndex = 1;
		this.GroupBox1.TabStop = false;
		this.choferestxt.AutoSize = true;
		this.choferestxt.Location = new System.Drawing.Point(572, 114);
		this.choferestxt.Name = "choferestxt";
		this.choferestxt.Size = new System.Drawing.Size(39, 13);
		this.choferestxt.TabIndex = 17;
		this.choferestxt.Text = "Label1";
		this.choferestxt.Visible = false;
		this.usuariotxt.AutoSize = true;
		this.usuariotxt.Location = new System.Drawing.Point(384, 114);
		this.usuariotxt.Name = "usuariotxt";
		this.usuariotxt.Size = new System.Drawing.Size(43, 13);
		this.usuariotxt.TabIndex = 16;
		this.usuariotxt.Text = "Usuario";
		this.modificadotxt.AutoSize = true;
		this.modificadotxt.Location = new System.Drawing.Point(384, 82);
		this.modificadotxt.Name = "modificadotxt";
		this.modificadotxt.Size = new System.Drawing.Size(133, 13);
		this.modificadotxt.TabIndex = 15;
		this.modificadotxt.Text = "01/01/1999 00:00:00 a.m.";
		this.bajatxt.AutoSize = true;
		this.bajatxt.Location = new System.Drawing.Point(384, 46);
		this.bajatxt.Name = "bajatxt";
		this.bajatxt.Size = new System.Drawing.Size(133, 13);
		this.bajatxt.TabIndex = 14;
		this.bajatxt.Text = "01/01/1999 00:00:00 a.m.";
		this.altatxt.AutoSize = true;
		this.altatxt.Location = new System.Drawing.Point(384, 16);
		this.altatxt.Name = "altatxt";
		this.altatxt.Size = new System.Drawing.Size(133, 13);
		this.altatxt.TabIndex = 13;
		this.altatxt.Text = "01/01/1999 00:00:00 a.m.";
		this.patentecombo.FormattingEnabled = true;
		this.patentecombo.Location = new System.Drawing.Point(67, 111);
		this.patentecombo.Name = "patentecombo";
		this.patentecombo.Size = new System.Drawing.Size(240, 21);
		this.patentecombo.TabIndex = 12;
		this.nombretxt.Location = new System.Drawing.Point(67, 79);
		this.nombretxt.Name = "nombretxt";
		this.nombretxt.Size = new System.Drawing.Size(240, 20);
		this.nombretxt.TabIndex = 11;
		this.numerotxt.Location = new System.Drawing.Point(67, 43);
		this.numerotxt.Name = "numerotxt";
		this.numerotxt.Size = new System.Drawing.Size(240, 20);
		this.numerotxt.TabIndex = 10;
		this.usuariolbl.AutoSize = true;
		this.usuariolbl.Location = new System.Drawing.Point(313, 114);
		this.usuariolbl.Name = "usuariolbl";
		this.usuariolbl.Size = new System.Drawing.Size(46, 13);
		this.usuariolbl.TabIndex = 8;
		this.usuariolbl.Text = "Usuario:";
		this.bajalbl.AutoSize = true;
		this.bajalbl.Location = new System.Drawing.Point(313, 46);
		this.bajalbl.Name = "bajalbl";
		this.bajalbl.Size = new System.Drawing.Size(31, 13);
		this.bajalbl.TabIndex = 7;
		this.bajalbl.Text = "Baja:";
		this.modificadolbl.AutoSize = true;
		this.modificadolbl.Location = new System.Drawing.Point(313, 82);
		this.modificadolbl.Name = "modificadolbl";
		this.modificadolbl.Size = new System.Drawing.Size(62, 13);
		this.modificadolbl.TabIndex = 9;
		this.modificadolbl.Text = "Modificado:";
		this.altalbl.AutoSize = true;
		this.altalbl.Location = new System.Drawing.Point(313, 16);
		this.altalbl.Name = "altalbl";
		this.altalbl.Size = new System.Drawing.Size(28, 13);
		this.altalbl.TabIndex = 6;
		this.altalbl.Text = "Alta:";
		this.patentenlbl.AutoSize = true;
		this.patentenlbl.Location = new System.Drawing.Point(6, 114);
		this.patentenlbl.Name = "patentenlbl";
		this.patentenlbl.Size = new System.Drawing.Size(47, 13);
		this.patentenlbl.TabIndex = 5;
		this.patentenlbl.Text = "Patente:";
		this.nombrelbl.AutoSize = true;
		this.nombrelbl.Location = new System.Drawing.Point(6, 82);
		this.nombrelbl.Name = "nombrelbl";
		this.nombrelbl.Size = new System.Drawing.Size(47, 13);
		this.nombrelbl.TabIndex = 4;
		this.nombrelbl.Text = "Nombre:";
		this.numerolbl.AutoSize = true;
		this.numerolbl.Location = new System.Drawing.Point(6, 46);
		this.numerolbl.Name = "numerolbl";
		this.numerolbl.Size = new System.Drawing.Size(47, 13);
		this.numerolbl.TabIndex = 3;
		this.numerolbl.Text = "Numero:";
		this.idtxt.AutoSize = true;
		this.idtxt.Location = new System.Drawing.Point(64, 16);
		this.idtxt.Name = "idtxt";
		this.idtxt.Size = new System.Drawing.Size(13, 13);
		this.idtxt.TabIndex = 2;
		this.idtxt.Text = "0";
		this.idlbl.AutoSize = true;
		this.idlbl.Location = new System.Drawing.Point(6, 16);
		this.idlbl.Name = "idlbl";
		this.idlbl.Size = new System.Drawing.Size(19, 13);
		this.idlbl.TabIndex = 2;
		this.idlbl.Text = "Id:";
		this.ListView1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.ListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[3] { this.Numero, this.Nombre, this.Patente });
		this.ListView1.FullRowSelect = true;
		this.ListView1.GridLines = true;
		this.ListView1.Location = new System.Drawing.Point(12, 182);
		this.ListView1.Name = "ListView1";
		this.ListView1.Size = new System.Drawing.Size(629, 224);
		this.ListView1.TabIndex = 2;
		this.ListView1.UseCompatibleStateImageBehavior = false;
		this.ListView1.View = System.Windows.Forms.View.Details;
		this.Numero.Text = "Numero";
		this.Numero.Width = 75;
		this.Nombre.Text = "Nombre";
		this.Nombre.Width = 464;
		this.Patente.Text = "Patente";
		this.Patente.Width = 86;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.Gray;
		base.ClientSize = new System.Drawing.Size(655, 418);
		base.Controls.Add(this.ListView1);
		base.Controls.Add(this.GroupBox1);
		base.Controls.Add(this.ToolStrip1);
		this.ForeColor = System.Drawing.Color.White;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.Name = "Choferes";
		this.Text = "Choferes";
		this.ToolStrip1.ResumeLayout(false);
		this.ToolStrip1.PerformLayout();
		this.GroupBox1.ResumeLayout(false);
		this.GroupBox1.PerformLayout();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private void Choferes_Load(object sender, EventArgs e)
	{
		choferes();
		vehiculos();
	}

	private void NewToolStripButton_Click(object sender, EventArgs e)
	{
		limpiar_campos();
		nombretxt.BackColor = Color.Khaki;
		numerotxt.Focus();
		idtxt.Text = "0";
	}

	private void SaveToolStripButton_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(idtxt.Text, "0", TextCompare: true) == 0)
		{
			if (Operators.CompareString(numerotxt.Text, "", TextCompare: true) == 0)
			{
				numerotxt.Text = Conversions.ToString(0);
			}
			if (Operators.CompareString(nombretxt.Text, "", TextCompare: true) == 0)
			{
				nombretxt.BackColor = Color.Khaki;
				nombretxt.Focus();
				return;
			}
			if (Operators.CompareString(patentecombo.Text, "", TextCompare: true) == 0)
			{
				patentecombo.Text = "Sin Vehiculo Asignado";
			}
			string sQL = "INSERT INTO Choferes (Numero,Nombre, Patente,Alta,Modificado,Usuario) VALUES (" + numerotxt.Text + ",'" + nombretxt.Text + "','" + patentecombo.Text + "'," + fecha1 + "," + fecha1 + ",'" + MyProject.Forms.Form1_Inicio.nombreusuario.Text + "')";
			Mod_ConeccionBD.BD_Sentencia(sQL);
			if (Operators.CompareString(patentecombo.Text, "Sin Vehiculo Asignado", TextCompare: true) != 0)
			{
				string sQL2 = "UPDATE Vehiculos SET Numero=" + numerotxt.Text + ", Chofer='" + nombretxt.Text + "' WHERE Patente='" + patentecombo.Text + "'";
				Mod_ConeccionBD.BD_Sentencia(sQL2);
				vehiculos();
			}
			limpiar_campos();
			numerotxt.BackColor = Color.White;
			nombretxt.BackColor = Color.White;
			choferes();
			return;
		}
		if (Operators.CompareString(numerotxt.Text, "", TextCompare: true) == 0)
		{
			numerotxt.Text = Conversions.ToString(0);
		}
		if (Operators.CompareString(nombretxt.Text, "", TextCompare: true) == 0)
		{
			nombretxt.BackColor = Color.Khaki;
			nombretxt.Focus();
			return;
		}
		if (Operators.CompareString(patentecombo.Text, "", TextCompare: true) == 0)
		{
			patentecombo.Text = "Sin Vehiculo Asignado";
		}
		string sQL3 = ("UPDATE Choferes SET Numero=" + numerotxt.Text + ", Nombre='" + nombretxt.Text + "',Patente='" + patentecombo.Text + "',Modificado=" + fecha1 + ",Usuario='" + MyProject.Forms.Form1_Inicio.nombreusuario.Text + "' Where id=" + idtxt.Text) ?? "";
		Mod_ConeccionBD.BD_Sentencia(sQL3);
		if (Operators.CompareString(patentecombo.Text, "Sin Vehiculo Asignado", TextCompare: true) != 0)
		{
			string sQL4 = "UPDATE Vehiculos SET Numero=" + numerotxt.Text + ", Chofer='" + nombretxt.Text + "' WHERE Patente='" + patentecombo.Text + "'";
			Mod_ConeccionBD.BD_Sentencia(sQL4);
			vehiculos();
		}
		limpiar_campos();
		numerotxt.BackColor = Color.White;
		nombretxt.BackColor = Color.White;
		choferes();
	}

	private void ToolStripButton1_Click(object sender, EventArgs e)
	{
		if (Conversions.ToDouble(idtxt.Text) == 0.0)
		{
			return;
		}
		if (Operators.CompareString(numerotxt.Text, "", TextCompare: true) == 0)
		{
			numerotxt.Text = Conversions.ToString(0);
		}
		if (Operators.CompareString(nombretxt.Text, "", TextCompare: true) == 0)
		{
			nombretxt.BackColor = Color.Khaki;
			nombretxt.Focus();
			return;
		}
		string sQL = "UPDATE Vehiculos SET Numero=0, Chofer='Sin Chofer Asignado',Estado='Inactivo',Disponible='No' WHERE Patente='" + patentecombo.Text + "'";
		Mod_ConeccionBD.BD_Sentencia(sQL);
		vehiculos();
		if (Operators.CompareString(patentecombo.Text, "", TextCompare: true) != 0)
		{
			patentecombo.Text = "Sin Vehiculo Asignado";
		}
		string sQL2 = ("UPDATE Choferes SET Numero=" + numerotxt.Text + ", Nombre='" + nombretxt.Text + "',Patente='" + patentecombo.Text + "',Baja=" + fecha1 + ",Modificado=" + fecha1 + ",Usuario='" + MyProject.Forms.Form1_Inicio.nombreusuario.Text + "' Where id=" + idtxt.Text) ?? "";
		Mod_ConeccionBD.BD_Sentencia(sQL2);
		limpiar_campos();
		numerotxt.BackColor = Color.White;
		nombretxt.BackColor = Color.White;
		choferes();
	}

	private void choferes()
	{
		string sql = "SELECT numero,nombre,patente,id,alta,baja,modificado,usuario FROM Choferes";
		Mod_Sentencias.cargar_datos_lv(ListView1, sql, choferestxt);
	}

	private void limpiar_campos()
	{
		idtxt.Text = Conversions.ToString(0);
		numerotxt.Text = "";
		nombretxt.Text = "";
		patentecombo.Text = "";
	}

	private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
	{
		Selected_item();
		nombretxt.BackColor = Color.White;
		numerotxt.BackColor = Color.White;
	}

	private void Selected_item()
	{
		if (ListView1.SelectedItems.Count > 0)
		{
			int index = ListView1.SelectedIndices[0];
			idtxt.Text = ListView1.Items[index].SubItems[3].Text;
			numerotxt.Text = ListView1.Items[index].Text;
			nombretxt.Text = ListView1.Items[index].SubItems[1].Text;
			patentecombo.Text = ListView1.Items[index].SubItems[2].Text;
			altatxt.Text = ListView1.Items[index].SubItems[4].Text;
			bajatxt.Text = ListView1.Items[index].SubItems[5].Text;
			usuariotxt.Text = ListView1.Items[index].SubItems[7].Text;
			modificadotxt.Text = ListView1.Items[index].SubItems[6].Text;
		}
		ListView1.Refresh();
	}

	private void vehiculos()
	{
		try
		{
			string sql = "SELECT Patente FROM Vehiculos WHERE numero=0";
			Mod_Sentencias.cargar_cbb(patentecombo, sql);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			Interaction.MsgBox("No existen Vehiculos disponibles");
			ProjectData.ClearProjectError();
		}
	}
}
