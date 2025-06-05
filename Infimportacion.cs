using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Hermes.My;
using Hermes.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace Hermes;

[DesignerGenerated]
public class Infimportacion : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("posicionarbtn")]
	private Button _posicionarbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("cndbtn")]
	private Button _cndbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("cerrarbtn")]
	private Button _cerrarbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("eventosbtn")]
	private Button _eventosbtn;

	private string fecha1;

	[field: AccessedThroughProperty("GroupBox1")]
	internal virtual GroupBox GroupBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("localidadtxt")]
	internal virtual Label localidadtxt
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

	[field: AccessedThroughProperty("importadastxt")]
	internal virtual Label importadastxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("importadaslbl")]
	internal virtual Label importadaslbl
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

	internal virtual Button cndbtn
	{
		[CompilerGenerated]
		get
		{
			return _cndbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = cndbtn_Click;
			Button button = _cndbtn;
			if (button != null)
			{
				button.Click -= value2;
			}
			_cndbtn = value;
			button = _cndbtn;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("excedenbtn")]
	internal virtual Button excedenbtn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button cerrarbtn
	{
		[CompilerGenerated]
		get
		{
			return _cerrarbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = cerrarbtn_Click;
			Button button = _cerrarbtn;
			if (button != null)
			{
				button.Click -= value2;
			}
			_cerrarbtn = value;
			button = _cerrarbtn;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("PictureBox1")]
	internal virtual PictureBox PictureBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button eventosbtn
	{
		[CompilerGenerated]
		get
		{
			return _eventosbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = eventosbtn_Click;
			Button button = _eventosbtn;
			if (button != null)
			{
				button.Click -= value2;
			}
			_eventosbtn = value;
			button = _eventosbtn;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	public Infimportacion()
	{
		base.Load += Infimportacion_Load;
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
		this.GroupBox1 = new System.Windows.Forms.GroupBox();
		this.localidadtxt = new System.Windows.Forms.Label();
		this.Label3 = new System.Windows.Forms.Label();
		this.importadastxt = new System.Windows.Forms.Label();
		this.importadaslbl = new System.Windows.Forms.Label();
		this.posicionarbtn = new System.Windows.Forms.Button();
		this.cndbtn = new System.Windows.Forms.Button();
		this.excedenbtn = new System.Windows.Forms.Button();
		this.cerrarbtn = new System.Windows.Forms.Button();
		this.PictureBox1 = new System.Windows.Forms.PictureBox();
		this.eventosbtn = new System.Windows.Forms.Button();
		this.GroupBox1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
		base.SuspendLayout();
		this.GroupBox1.Controls.Add(this.localidadtxt);
		this.GroupBox1.Controls.Add(this.Label3);
		this.GroupBox1.Controls.Add(this.importadastxt);
		this.GroupBox1.Controls.Add(this.importadaslbl);
		this.GroupBox1.Location = new System.Drawing.Point(269, 105);
		this.GroupBox1.Name = "GroupBox1";
		this.GroupBox1.Size = new System.Drawing.Size(144, 110);
		this.GroupBox1.TabIndex = 0;
		this.GroupBox1.TabStop = false;
		this.GroupBox1.Text = "Importacion";
		this.localidadtxt.AutoSize = true;
		this.localidadtxt.Location = new System.Drawing.Point(110, 63);
		this.localidadtxt.Name = "localidadtxt";
		this.localidadtxt.Size = new System.Drawing.Size(13, 13);
		this.localidadtxt.TabIndex = 7;
		this.localidadtxt.Text = "0";
		this.localidadtxt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.Label3.AutoSize = true;
		this.Label3.Location = new System.Drawing.Point(6, 63);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(91, 13);
		this.Label3.TabIndex = 6;
		this.Label3.Text = "Nueva Localidad:";
		this.importadastxt.AutoSize = true;
		this.importadastxt.Location = new System.Drawing.Point(110, 34);
		this.importadastxt.Name = "importadastxt";
		this.importadastxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
		this.importadastxt.Size = new System.Drawing.Size(13, 13);
		this.importadastxt.TabIndex = 1;
		this.importadastxt.Text = "0";
		this.importadastxt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.importadaslbl.AutoSize = true;
		this.importadaslbl.Location = new System.Drawing.Point(6, 34);
		this.importadaslbl.Name = "importadaslbl";
		this.importadaslbl.Size = new System.Drawing.Size(79, 13);
		this.importadaslbl.TabIndex = 0;
		this.importadaslbl.Text = "CP Importadas:";
		this.posicionarbtn.Location = new System.Drawing.Point(12, 106);
		this.posicionarbtn.Name = "posicionarbtn";
		this.posicionarbtn.Size = new System.Drawing.Size(251, 23);
		this.posicionarbtn.TabIndex = 1;
		this.posicionarbtn.Text = "Posicionar";
		this.posicionarbtn.UseVisualStyleBackColor = true;
		this.cndbtn.Location = new System.Drawing.Point(12, 134);
		this.cndbtn.Name = "cndbtn";
		this.cndbtn.Size = new System.Drawing.Size(251, 23);
		this.cndbtn.TabIndex = 2;
		this.cndbtn.Text = "CND";
		this.cndbtn.UseVisualStyleBackColor = true;
		this.excedenbtn.Location = new System.Drawing.Point(12, 163);
		this.excedenbtn.Name = "excedenbtn";
		this.excedenbtn.Size = new System.Drawing.Size(251, 23);
		this.excedenbtn.TabIndex = 3;
		this.excedenbtn.Text = "Exceden";
		this.excedenbtn.UseVisualStyleBackColor = true;
		this.cerrarbtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
		this.cerrarbtn.Location = new System.Drawing.Point(338, 221);
		this.cerrarbtn.Name = "cerrarbtn";
		this.cerrarbtn.Size = new System.Drawing.Size(75, 23);
		this.cerrarbtn.TabIndex = 4;
		this.cerrarbtn.Text = "Cerrar";
		this.cerrarbtn.UseVisualStyleBackColor = true;
		this.PictureBox1.Image = Hermes.My.Resources.Resources.Logo_hermes_3;
		this.PictureBox1.Location = new System.Drawing.Point(12, 12);
		this.PictureBox1.Name = "PictureBox1";
		this.PictureBox1.Size = new System.Drawing.Size(401, 87);
		this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.PictureBox1.TabIndex = 6;
		this.PictureBox1.TabStop = false;
		this.eventosbtn.Location = new System.Drawing.Point(12, 192);
		this.eventosbtn.Name = "eventosbtn";
		this.eventosbtn.Size = new System.Drawing.Size(251, 23);
		this.eventosbtn.TabIndex = 7;
		this.eventosbtn.Text = "Eventos";
		this.eventosbtn.UseVisualStyleBackColor = true;
		base.AcceptButton = this.posicionarbtn;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.CancelButton = this.cerrarbtn;
		base.ClientSize = new System.Drawing.Size(419, 242);
		base.ControlBox = false;
		base.Controls.Add(this.eventosbtn);
		base.Controls.Add(this.PictureBox1);
		base.Controls.Add(this.cerrarbtn);
		base.Controls.Add(this.excedenbtn);
		base.Controls.Add(this.cndbtn);
		base.Controls.Add(this.posicionarbtn);
		base.Controls.Add(this.GroupBox1);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
		base.Name = "Infimportacion";
		base.ShowIcon = false;
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Informe de Importacion";
		this.GroupBox1.ResumeLayout(false);
		this.GroupBox1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
		base.ResumeLayout(false);
	}

	private void cerrarbtn_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void cndbtn_Click(object sender, EventArgs e)
	{
		MyProject.Forms.CND.MdiParent = MyProject.Forms.Form1_Inicio;
		MyProject.Forms.CND.Show();
		Close();
	}

	private void Infimportacion_Load(object sender, EventArgs e)
	{
		total_importados();
		no_posicionados();
		CND_load();
		Nueva_localidad();
		Exceden_seguro();
		capturar_Eventos();
	}

	public void CND_load()
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		DataTable dataTable = new DataTable("xx");
		string text = "SELECT DISTINCT Eventual FROM Planchada where Sub='30'AND Fecha='" + fecha1 + "' AND Ventana=0 UNION ALL SELECT DISTINCT Eventual FROM Planchada where Sub='31'AND Fecha='" + fecha1 + "' AND Ventana=0";
		MySqlDataAdapter val = new MySqlDataAdapter(text, Mod_Sentencias.cnn);
		((DbDataAdapter)(object)val).Fill(dataTable);
		cndbtn.Text = "CND (" + Conversions.ToString(dataTable.Rows.Count) + ")";
	}

	public void Nueva_localidad()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		DataTable dataTable = new DataTable("xx");
		string text = "SELECT * FROM Localidades where Zona=0";
		MySqlDataAdapter val = new MySqlDataAdapter(text, Mod_Sentencias.cnn);
		((DbDataAdapter)(object)val).Fill(dataTable);
		localidadtxt.Text = Conversions.ToString(dataTable.Rows.Count);
	}

	public void total_importados()
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		DataTable dataTable = new DataTable("xx");
		string text = "SELECT * FROM Planchada Where Fecha='" + fecha1 + "'";
		MySqlDataAdapter val = new MySqlDataAdapter(text, Mod_Sentencias.cnn);
		((DbDataAdapter)(object)val).Fill(dataTable);
		importadastxt.Text = Conversions.ToString(dataTable.Rows.Count);
	}

	public void Exceden_seguro()
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		DataTable dataTable = new DataTable("xx");
		string text = "SELECT * FROM Planchada where Declarado>=" + MySettingsProperty.Settings.custodia + " AND Fecha='" + fecha1 + "'";
		MySqlDataAdapter val = new MySqlDataAdapter(text, Mod_Sentencias.cnn);
		((DbDataAdapter)(object)val).Fill(dataTable);
		excedenbtn.Text = "Exceden (" + Conversions.ToString(dataTable.Rows.Count) + ")";
	}

	public void no_posicionados()
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		DataTable dataTable = new DataTable("xx");
		string text = "SELECT DISTINCT Destino FROM Planchada where Eventual=0 AND Fecha='" + fecha1 + "'";
		MySqlDataAdapter val = new MySqlDataAdapter(text, Mod_Sentencias.cnn);
		((DbDataAdapter)(object)val).Fill(dataTable);
		posicionarbtn.Text = "Posicionar (" + Conversions.ToString(dataTable.Rows.Count) + ")";
	}

	public void capturar_Eventos()
	{
		if ((Mod_Rutearmodulo.dir_error.Count > 0) | (Mod_Rutearmodulo.nom_error.Count > 0))
		{
			int num = checked(Mod_Rutearmodulo.dir_error.Count + Mod_Rutearmodulo.nom_error.Count);
			eventosbtn.Text = "Eventos (" + Conversions.ToString(num) + ")";
		}
	}

	private void eventosbtn_Click(object sender, EventArgs e)
	{
		MyProject.Forms.Eventos.MdiParent = MyProject.Forms.Form1_Inicio;
		MyProject.Forms.Eventos.Show();
		Close();
	}

	private void posicionarbtn_Click(object sender, EventArgs e)
	{
		MyProject.Forms.Posicionar.MdiParent = MyProject.Forms.Form1_Inicio;
		MyProject.Forms.Posicionar.Show();
		Close();
	}
}
