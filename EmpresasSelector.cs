using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace Hermes;

[DesignerGenerated]
public class EmpresasSelector : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnExportar")]
	private Button _btnExportar;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnCancelar")]
	private Button _btnCancelar;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("BackgroundWorker1")]
	private BackgroundWorker _BackgroundWorker1;

	private int empresaid;

	[field: AccessedThroughProperty("ComboBox1")]
	internal virtual ComboBox ComboBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button btnExportar
	{
		[CompilerGenerated]
		get
		{
			return _btnExportar;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = btnExportar_Click;
			Button button = _btnExportar;
			if (button != null)
			{
				button.Click -= value2;
			}
			_btnExportar = value;
			button = _btnExportar;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button btnCancelar
	{
		[CompilerGenerated]
		get
		{
			return _btnCancelar;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = btnCancelar_Click;
			Button button = _btnCancelar;
			if (button != null)
			{
				button.Click -= value2;
			}
			_btnCancelar = value;
			button = _btnCancelar;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual BackgroundWorker BackgroundWorker1
	{
		[CompilerGenerated]
		get
		{
			return _BackgroundWorker1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			DoWorkEventHandler value2 = BackgroundWorker1_DoWork;
			RunWorkerCompletedEventHandler value3 = BackgroundWorker1_RunWorkerCompleted;
			BackgroundWorker backgroundWorker = _BackgroundWorker1;
			if (backgroundWorker != null)
			{
				backgroundWorker.DoWork -= value2;
				backgroundWorker.RunWorkerCompleted -= value3;
			}
			_BackgroundWorker1 = value;
			backgroundWorker = _BackgroundWorker1;
			if (backgroundWorker != null)
			{
				backgroundWorker.DoWork += value2;
				backgroundWorker.RunWorkerCompleted += value3;
			}
		}
	}

	[field: AccessedThroughProperty("CheckBox1")]
	internal virtual CheckBox CheckBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public EmpresasSelector()
	{
		base.Load += EmpresasSelector_Load;
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
		this.ComboBox1 = new System.Windows.Forms.ComboBox();
		this.btnExportar = new System.Windows.Forms.Button();
		this.btnCancelar = new System.Windows.Forms.Button();
		this.BackgroundWorker1 = new System.ComponentModel.BackgroundWorker();
		this.CheckBox1 = new System.Windows.Forms.CheckBox();
		base.SuspendLayout();
		this.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.ComboBox1.FormattingEnabled = true;
		this.ComboBox1.Location = new System.Drawing.Point(12, 28);
		this.ComboBox1.Name = "ComboBox1";
		this.ComboBox1.Size = new System.Drawing.Size(332, 21);
		this.ComboBox1.TabIndex = 0;
		this.btnExportar.BackColor = System.Drawing.Color.Lime;
		this.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
		this.btnExportar.Location = new System.Drawing.Point(12, 69);
		this.btnExportar.Name = "btnExportar";
		this.btnExportar.Size = new System.Drawing.Size(75, 23);
		this.btnExportar.TabIndex = 1;
		this.btnExportar.Text = "Exportar";
		this.btnExportar.UseVisualStyleBackColor = false;
		this.btnCancelar.BackColor = System.Drawing.Color.Red;
		this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
		this.btnCancelar.Location = new System.Drawing.Point(269, 69);
		this.btnCancelar.Name = "btnCancelar";
		this.btnCancelar.Size = new System.Drawing.Size(75, 23);
		this.btnCancelar.TabIndex = 2;
		this.btnCancelar.Text = "Cancelar";
		this.btnCancelar.UseVisualStyleBackColor = false;
		this.BackgroundWorker1.WorkerReportsProgress = true;
		this.BackgroundWorker1.WorkerSupportsCancellation = true;
		this.CheckBox1.AutoSize = true;
		this.CheckBox1.Location = new System.Drawing.Point(131, 73);
		this.CheckBox1.Name = "CheckBox1";
		this.CheckBox1.Size = new System.Drawing.Size(93, 17);
		this.CheckBox1.TabIndex = 3;
		this.CheckBox1.Text = "A Distribuicion";
		this.CheckBox1.UseVisualStyleBackColor = true;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(356, 104);
		base.Controls.Add(this.CheckBox1);
		base.Controls.Add(this.btnCancelar);
		base.Controls.Add(this.btnExportar);
		base.Controls.Add(this.ComboBox1);
		base.Name = "EmpresasSelector";
		this.Text = "Seleccione Empresa";
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private void EmpresasSelector_Load(object sender, EventArgs e)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		string text = "SELECT  Nombre, id FROM empresas WHERE estado = 1 ORDER BY id ASC";
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

	private void btnExportar_Click(object sender, EventArgs e)
	{
		if (ComboBox1.SelectedIndex > -1)
		{
			empresaid = Conversions.ToInteger(ComboBox1.SelectedValue);
			BackgroundWorker1.RunWorkerAsync();
		}
		else
		{
			Interaction.MsgBox("Selecciones una empresa");
		}
	}

	private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
	{
		if (CheckBox1.Checked)
		{
			Mod_interfas.distribucionOrdenes(empresaid);
		}
		else
		{
			Mod_interfas.hdrOrdenes(empresaid);
		}
	}

	private void BackgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
	{
		Close();
	}

	private void btnCancelar_Click(object sender, EventArgs e)
	{
		Close();
	}
}
