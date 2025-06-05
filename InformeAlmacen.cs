using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Hermes;

[DesignerGenerated]
public class InformeAlmacen : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnConsultar")]
	private Button _btnConsultar;

	private string fechaInicial;

	private string fechaFinal;

	[field: AccessedThroughProperty("ListView1")]
	internal virtual ListView ListView1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("dtpInforme1")]
	internal virtual DateTimePicker dtpInforme1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("dtpInforme2")]
	internal virtual DateTimePicker dtpInforme2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button btnConsultar
	{
		[CompilerGenerated]
		get
		{
			return _btnConsultar;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = btnConsultar_Click;
			Button button = _btnConsultar;
			if (button != null)
			{
				button.Click -= value2;
			}
			_btnConsultar = value;
			button = _btnConsultar;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Empresa")]
	internal virtual ColumnHeader Empresa
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Ordenes")]
	internal virtual ColumnHeader Ordenes
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ValorDeclarado")]
	internal virtual ColumnHeader ValorDeclarado
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

	[field: AccessedThroughProperty("GroupBox1")]
	internal virtual GroupBox GroupBox1
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

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
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

	[field: AccessedThroughProperty("promOrdenes")]
	internal virtual ColumnHeader promOrdenes
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("promValor")]
	internal virtual ColumnHeader promValor
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("promBultos")]
	internal virtual ColumnHeader promBultos
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("diasPrep")]
	internal virtual ColumnHeader diasPrep
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public InformeAlmacen()
	{
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hermes.InformeAlmacen));
		this.ListView1 = new System.Windows.Forms.ListView();
		this.dtpInforme1 = new System.Windows.Forms.DateTimePicker();
		this.dtpInforme2 = new System.Windows.Forms.DateTimePicker();
		this.btnConsultar = new System.Windows.Forms.Button();
		this.Empresa = new System.Windows.Forms.ColumnHeader();
		this.Ordenes = new System.Windows.Forms.ColumnHeader();
		this.ValorDeclarado = new System.Windows.Forms.ColumnHeader();
		this.Bultos = new System.Windows.Forms.ColumnHeader();
		this.GroupBox1 = new System.Windows.Forms.GroupBox();
		this.Label1 = new System.Windows.Forms.Label();
		this.Label2 = new System.Windows.Forms.Label();
		this.GroupBox2 = new System.Windows.Forms.GroupBox();
		this.promOrdenes = new System.Windows.Forms.ColumnHeader();
		this.promValor = new System.Windows.Forms.ColumnHeader();
		this.promBultos = new System.Windows.Forms.ColumnHeader();
		this.diasPrep = new System.Windows.Forms.ColumnHeader();
		this.GroupBox1.SuspendLayout();
		base.SuspendLayout();
		this.ListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[8] { this.Empresa, this.Ordenes, this.ValorDeclarado, this.Bultos, this.promOrdenes, this.promValor, this.promBultos, this.diasPrep });
		this.ListView1.FullRowSelect = true;
		this.ListView1.GridLines = true;
		this.ListView1.Location = new System.Drawing.Point(12, 78);
		this.ListView1.Name = "ListView1";
		this.ListView1.Size = new System.Drawing.Size(709, 312);
		this.ListView1.TabIndex = 0;
		this.ListView1.UseCompatibleStateImageBehavior = false;
		this.ListView1.View = System.Windows.Forms.View.Details;
		this.dtpInforme1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
		this.dtpInforme1.Location = new System.Drawing.Point(149, 22);
		this.dtpInforme1.Name = "dtpInforme1";
		this.dtpInforme1.Size = new System.Drawing.Size(101, 20);
		this.dtpInforme1.TabIndex = 1;
		this.dtpInforme2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
		this.dtpInforme2.Location = new System.Drawing.Point(314, 22);
		this.dtpInforme2.Name = "dtpInforme2";
		this.dtpInforme2.Size = new System.Drawing.Size(99, 20);
		this.dtpInforme2.TabIndex = 2;
		this.btnConsultar.Location = new System.Drawing.Point(500, 19);
		this.btnConsultar.Name = "btnConsultar";
		this.btnConsultar.Size = new System.Drawing.Size(75, 23);
		this.btnConsultar.TabIndex = 3;
		this.btnConsultar.Text = "Consultar";
		this.btnConsultar.UseVisualStyleBackColor = true;
		this.Empresa.Text = "Empresa";
		this.Empresa.Width = 272;
		this.Ordenes.Text = "Ordenes";
		this.Ordenes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		this.Ordenes.Width = 61;
		this.ValorDeclarado.Text = "Valor Declarado";
		this.ValorDeclarado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		this.ValorDeclarado.Width = 103;
		this.Bultos.Text = "Bultos";
		this.Bultos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		this.Bultos.Width = 48;
		this.GroupBox1.Controls.Add(this.Label2);
		this.GroupBox1.Controls.Add(this.btnConsultar);
		this.GroupBox1.Controls.Add(this.Label1);
		this.GroupBox1.Controls.Add(this.dtpInforme2);
		this.GroupBox1.Controls.Add(this.dtpInforme1);
		this.GroupBox1.Location = new System.Drawing.Point(12, 12);
		this.GroupBox1.Name = "GroupBox1";
		this.GroupBox1.Size = new System.Drawing.Size(709, 60);
		this.GroupBox1.TabIndex = 4;
		this.GroupBox1.TabStop = false;
		this.GroupBox1.Text = "Consulta";
		this.Label1.AutoSize = true;
		this.Label1.Location = new System.Drawing.Point(102, 24);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(41, 13);
		this.Label1.TabIndex = 0;
		this.Label1.Text = "Desde:";
		this.Label2.AutoSize = true;
		this.Label2.Location = new System.Drawing.Point(270, 24);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(38, 13);
		this.Label2.TabIndex = 1;
		this.Label2.Text = "Hasta:";
		this.GroupBox2.Location = new System.Drawing.Point(12, 396);
		this.GroupBox2.Name = "GroupBox2";
		this.GroupBox2.Size = new System.Drawing.Size(709, 62);
		this.GroupBox2.TabIndex = 5;
		this.GroupBox2.TabStop = false;
		this.GroupBox2.Text = "Opciones";
		this.promOrdenes.Text = "Ordenes Prom";
		this.promOrdenes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		this.promOrdenes.Width = 85;
		this.promValor.Text = "VD Prom";
		this.promValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		this.promValor.Width = 61;
		this.promBultos.Text = "Bultos Prom";
		this.promBultos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		this.promBultos.Width = 76;
		this.diasPrep.Text = "Dias De Prep";
		this.diasPrep.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(733, 470);
		base.Controls.Add(this.GroupBox2);
		base.Controls.Add(this.GroupBox1);
		base.Controls.Add(this.ListView1);
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.Name = "InformeAlmacen";
		this.Text = "Informe Almacen";
		this.GroupBox1.ResumeLayout(false);
		this.GroupBox1.PerformLayout();
		base.ResumeLayout(false);
	}

	private void btnConsultar_Click(object sender, EventArgs e)
	{
		fechaInicial = Strings.Format(dtpInforme1.Value, "yyyy-MM-dd");
		fechaFinal = Strings.Format(dtpInforme2.Value, "yyyy-MM-dd");
		ListView1.Items.Clear();
		listaDeEmpresas();
	}

	private void listaDeEmpresas()
	{
		string sql = "Select id FROM empresas WHERE estado = 1";
		DataTable dataTable = (DataTable)Mod_Sentencias.data(sql);
		checked
		{
			int num = dataTable.Rows.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				datosEmpresa(dataTable.Rows[i]["id"].ToString());
			}
		}
	}

	private void datosEmpresa(string empresas)
	{
		string sql = "Select o.id, e.nombre, o.numero, o.valor, d.bultos, o.fechapreparado from ordenes o LEFT JOIN bultosorden d On d.ordenid = o.numero And d.empresa=o.empresa LEFT JOIN empresas e ON e.id = o.empresa where o.empresa In (" + empresas + ") And o.estado Not In (1,4) AND o.fechapreparado > '" + fechaInicial + " 00:00:00' AND o.fechapreparado < '" + fechaFinal + " 23:59:59' order by o.fechapreparado desc;";
		DataTable dataTable = (DataTable)Mod_Sentencias.data(sql);
		if (dataTable.Rows.Count <= 0)
		{
			return;
		}
		ListViewItem listViewItem = new ListViewItem();
		string empty = string.Empty;
		string empty2 = string.Empty;
		int num = 0;
		int num2 = 1;
		decimal num3 = default(decimal);
		int num4 = 0;
		empty = dataTable.Rows[0]["nombre"].ToString();
		empty2 = Strings.Format(RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["fechapreparado"]), "yyyy-MM-dd");
		checked
		{
			int num5 = dataTable.Rows.Count - 1;
			for (int i = 0; i <= num5; i++)
			{
				if (Operators.CompareString(empty2, Strings.Format(RuntimeHelpers.GetObjectValue(dataTable.Rows[i]["fechapreparado"]), "yyyy-MM-dd"), TextCompare: true) != 0)
				{
					empty2 = Strings.Format(RuntimeHelpers.GetObjectValue(dataTable.Rows[i]["fechapreparado"]), "yyyy-MM-dd");
					num2++;
				}
				num++;
				num3 = Conversions.ToDecimal(Operators.AddObject(num3, dataTable.Rows[i]["valor"]));
				if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataTable.Rows[i]["bultos"])))
				{
					num4 += int.Parse(Conversions.ToString(dataTable.Rows[i]["Bultos"]));
				}
			}
			listViewItem.Text = empty;
			listViewItem.SubItems.Add(num.ToString());
			listViewItem.SubItems.Add(decimal.Round(num3, 2).ToString());
			listViewItem.SubItems.Add(num4.ToString());
			decimal d = new decimal((double)num / (double)num2);
			decimal d2 = new decimal((double)num4 / (double)num2);
			listViewItem.SubItems.Add(decimal.Round(d, 2).ToString());
			listViewItem.SubItems.Add(decimal.Round(decimal.Divide(num3, new decimal(num2)), 2).ToString());
			listViewItem.SubItems.Add(decimal.Round(d2, 2).ToString());
			listViewItem.SubItems.Add(num2.ToString());
			ListView1.Items.Add(listViewItem);
		}
	}
}
