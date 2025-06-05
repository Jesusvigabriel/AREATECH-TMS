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
public class Inf_seguimiento : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ComboBox1")]
	private ComboBox _ComboBox1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	private string fecha1;

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

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ComboBox2")]
	internal virtual ComboBox ComboBox2
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

	[field: AccessedThroughProperty("lblEmpresa")]
	internal virtual Label lblEmpresa
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblSubCuenta")]
	internal virtual Label lblSubCuenta
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblMonto")]
	internal virtual Label lblMonto
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label4")]
	internal virtual Label Label4
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

	[field: AccessedThroughProperty("ListView1")]
	internal virtual ListView ListView1
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

	[field: AccessedThroughProperty("Button3")]
	internal virtual Button Button3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public Inf_seguimiento()
	{
		base.Load += Inf_seguimiento_Load;
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
		this.Label1 = new System.Windows.Forms.Label();
		this.ComboBox1 = new System.Windows.Forms.ComboBox();
		this.Label2 = new System.Windows.Forms.Label();
		this.ComboBox2 = new System.Windows.Forms.ComboBox();
		this.Label3 = new System.Windows.Forms.Label();
		this.TextBox1 = new System.Windows.Forms.TextBox();
		this.lblEmpresa = new System.Windows.Forms.Label();
		this.lblSubCuenta = new System.Windows.Forms.Label();
		this.lblMonto = new System.Windows.Forms.Label();
		this.Label4 = new System.Windows.Forms.Label();
		this.Label5 = new System.Windows.Forms.Label();
		this.ListView1 = new System.Windows.Forms.ListView();
		this.Button1 = new System.Windows.Forms.Button();
		this.Button2 = new System.Windows.Forms.Button();
		this.Button3 = new System.Windows.Forms.Button();
		base.SuspendLayout();
		this.Label1.AutoSize = true;
		this.Label1.Location = new System.Drawing.Point(12, 9);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(51, 13);
		this.Label1.TabIndex = 0;
		this.Label1.Text = "Empresa:";
		this.ComboBox1.FormattingEnabled = true;
		this.ComboBox1.Location = new System.Drawing.Point(69, 6);
		this.ComboBox1.Name = "ComboBox1";
		this.ComboBox1.Size = new System.Drawing.Size(341, 21);
		this.ComboBox1.TabIndex = 1;
		this.Label2.AutoSize = true;
		this.Label2.Location = new System.Drawing.Point(12, 51);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(63, 13);
		this.Label2.TabIndex = 2;
		this.Label2.Text = "SubCuenta:";
		this.ComboBox2.FormattingEnabled = true;
		this.ComboBox2.Location = new System.Drawing.Point(81, 48);
		this.ComboBox2.Name = "ComboBox2";
		this.ComboBox2.Size = new System.Drawing.Size(121, 21);
		this.ComboBox2.TabIndex = 3;
		this.Label3.AutoSize = true;
		this.Label3.Location = new System.Drawing.Point(225, 51);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(40, 13);
		this.Label3.TabIndex = 4;
		this.Label3.Text = "Monto:";
		this.TextBox1.Location = new System.Drawing.Point(271, 48);
		this.TextBox1.Name = "TextBox1";
		this.TextBox1.Size = new System.Drawing.Size(139, 20);
		this.TextBox1.TabIndex = 5;
		this.lblEmpresa.AutoSize = true;
		this.lblEmpresa.Location = new System.Drawing.Point(450, 23);
		this.lblEmpresa.Name = "lblEmpresa";
		this.lblEmpresa.Size = new System.Drawing.Size(57, 13);
		this.lblEmpresa.TabIndex = 6;
		this.lblEmpresa.Text = "lblempresa";
		this.lblSubCuenta.AutoSize = true;
		this.lblSubCuenta.Location = new System.Drawing.Point(450, 46);
		this.lblSubCuenta.Name = "lblSubCuenta";
		this.lblSubCuenta.Size = new System.Drawing.Size(70, 13);
		this.lblSubCuenta.TabIndex = 7;
		this.lblSubCuenta.Text = "lblSubCuenta";
		this.lblMonto.AutoSize = true;
		this.lblMonto.Location = new System.Drawing.Point(450, 65);
		this.lblMonto.Name = "lblMonto";
		this.lblMonto.Size = new System.Drawing.Size(47, 13);
		this.lblMonto.TabIndex = 8;
		this.lblMonto.Text = "lblMonto";
		this.Label4.AutoSize = true;
		this.Label4.Location = new System.Drawing.Point(146, 86);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(138, 13);
		this.Label4.TabIndex = 9;
		this.Label4.Text = "Vehiculos para Seguimiento";
		this.Label5.AutoSize = true;
		this.Label5.Location = new System.Drawing.Point(78, 110);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(68, 13);
		this.Label5.TabIndex = 10;
		this.Label5.Text = "En Deposito:";
		this.ListView1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.ListView1.GridLines = true;
		this.ListView1.Location = new System.Drawing.Point(15, 126);
		this.ListView1.Name = "ListView1";
		this.ListView1.Size = new System.Drawing.Size(395, 123);
		this.ListView1.TabIndex = 12;
		this.ListView1.UseCompatibleStateImageBehavior = false;
		this.ListView1.View = System.Windows.Forms.View.Details;
		this.Button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		this.Button1.Location = new System.Drawing.Point(425, 126);
		this.Button1.Name = "Button1";
		this.Button1.Size = new System.Drawing.Size(107, 33);
		this.Button1.TabIndex = 14;
		this.Button1.Text = "Guardar Confg";
		this.Button1.UseVisualStyleBackColor = true;
		this.Button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		this.Button2.Location = new System.Drawing.Point(425, 165);
		this.Button2.Name = "Button2";
		this.Button2.Size = new System.Drawing.Size(107, 23);
		this.Button2.TabIndex = 15;
		this.Button2.Text = "Generar Inf.";
		this.Button2.UseVisualStyleBackColor = true;
		this.Button3.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		this.Button3.Location = new System.Drawing.Point(425, 194);
		this.Button3.Name = "Button3";
		this.Button3.Size = new System.Drawing.Size(107, 23);
		this.Button3.TabIndex = 16;
		this.Button3.Text = "Exportar";
		this.Button3.UseVisualStyleBackColor = true;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(544, 261);
		base.Controls.Add(this.Button3);
		base.Controls.Add(this.Button2);
		base.Controls.Add(this.Button1);
		base.Controls.Add(this.ListView1);
		base.Controls.Add(this.Label5);
		base.Controls.Add(this.Label4);
		base.Controls.Add(this.lblMonto);
		base.Controls.Add(this.lblSubCuenta);
		base.Controls.Add(this.lblEmpresa);
		base.Controls.Add(this.TextBox1);
		base.Controls.Add(this.Label3);
		base.Controls.Add(this.ComboBox2);
		base.Controls.Add(this.Label2);
		base.Controls.Add(this.ComboBox1);
		base.Controls.Add(this.Label1);
		base.Name = "Inf_seguimiento";
		this.Text = "Informe para Seguimiento";
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private void Inf_seguimiento_Load(object sender, EventArgs e)
	{
		string sql = "SELECT nombre, id FROM empresas WHERE estado = 1 ORDER BY nombre ASC";
		Mod_Sentencias.fillcbb(ComboBox1, sql);
		if (Conversions.ToBoolean(MySettingsProperty.Settings.MontoInf))
		{
			TextBox1.Text = MySettingsProperty.Settings.MontoInf;
			lblMonto.Text = TextBox1.Text;
		}
	}

	private void ComboBox1_SelectionChangeCommitted(object sender, EventArgs e)
	{
		lblEmpresa.Text = Conversions.ToString(ComboBox1.SelectedValue);
		string sql = "SELECT DISTINCT p.sub, p.sub FROM planchada p LEFT JOIN empresas e ON e.razonsocial = p.cliente WHERE e.id = '" + lblEmpresa.Text + "' AND p.fecha='" + fecha1 + "'";
		Mod_Sentencias.fillcbb(ComboBox2, sql);
	}

	private void DatosRuta()
	{
		string sql = "Select p.comprobante, p.Sub, p.ventana, sum(p.declarado), p.chofer FROM planchada p LEFT JOIN empresas e On e.razonsocial = p.cliente WHERE e.id = '" + lblEmpresa.Text + "' AND p.fecha='" + fecha1 + "' AND chofer > 0  group by p.sub, p.ventana, p.chofer order by p.ventana, p.chofer asc";
		Mod_Sentencias.cargar_datos_lv_completa(ListView1, sql, lblSubCuenta);
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		loadData();
	}

	private void loadData()
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		string commandText = "Select p.Sub, p.ventana, sum(p.declarado) as declarado, p.chofer FROM planchada p LEFT JOIN empresas e On e.razonsocial = p.cliente WHERE e.id = '" + lblEmpresa.Text + "' AND p.fecha='" + fecha1 + "' AND chofer > 0 group by p.sub, p.ventana, p.chofer order by p.ventana, p.chofer asc";
		checked
		{
			try
			{
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
				listView.MultiSelect = false;
				listView.LabelEdit = false;
				listView.HideSelection = false;
				int num = dataSet.Tables["tabla"].Columns.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					listView.Columns.Add(dataSet.Tables["tabla"].Columns[i].Caption);
				}
				listView.Columns.Add("Seguimiento");
				listView = null;
				DataTable dataTable = dataSet.Tables["tabla"];
				int num2 = dataTable.Rows.Count - 1;
				for (int j = 0; j <= num2; j++)
				{
					ListViewItem listViewItem = new ListViewItem(dataTable.Rows[j][0].ToString());
					int num3 = dataTable.Columns.Count - 1;
					for (int k = 1; k <= num3; k++)
					{
						listViewItem.SubItems.Add(dataTable.Rows[j][k].ToString());
					}
					string s = dataTable.Rows[j]["declarado"].ToString();
					double num4 = double.Parse(s);
					double num5 = double.Parse(TextBox1.Text);
					if (num4 > num5)
					{
						listViewItem.SubItems.Add("SEGUIMIENTO");
					}
					else
					{
						listViewItem.SubItems.Add("N/A");
					}
					ListView1.Items.Add(listViewItem);
					if (j == 0)
					{
					}
				}
				dataTable = null;
				Mod_Sentencias.cnn.Close();
				ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Mod_Sentencias.cnn.Close();
				Interaction.MsgBox(ex2.Message);
				ProjectData.ClearProjectError();
			}
		}
	}
}
