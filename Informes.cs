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
public class Informes : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ListView1")]
	private ListView _ListView1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("CheckBox1")]
	private CheckBox _CheckBox1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button2")]
	private Button _Button2;

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

	internal virtual CheckBox CheckBox1
	{
		[CompilerGenerated]
		get
		{
			return _CheckBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = CheckBox1_CheckedChanged;
			CheckBox checkBox = _CheckBox1;
			if (checkBox != null)
			{
				checkBox.CheckedChanged -= value2;
			}
			_CheckBox1 = value;
			checkBox = _CheckBox1;
			if (checkBox != null)
			{
				checkBox.CheckedChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("DateTimePicker2")]
	internal virtual DateTimePicker DateTimePicker2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DateTimePicker1")]
	internal virtual DateTimePicker DateTimePicker1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox3")]
	internal virtual TextBox TextBox3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox2")]
	internal virtual TextBox TextBox2
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

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
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

	[field: AccessedThroughProperty("GroupBox1")]
	internal virtual GroupBox GroupBox1
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

	public Informes()
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hermes.Informes));
		this.DateTimePicker2 = new System.Windows.Forms.DateTimePicker();
		this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
		this.CheckBox1 = new System.Windows.Forms.CheckBox();
		this.Button1 = new System.Windows.Forms.Button();
		this.Button2 = new System.Windows.Forms.Button();
		this.Label3 = new System.Windows.Forms.Label();
		this.Label2 = new System.Windows.Forms.Label();
		this.Label1 = new System.Windows.Forms.Label();
		this.TextBox3 = new System.Windows.Forms.TextBox();
		this.TextBox2 = new System.Windows.Forms.TextBox();
		this.TextBox1 = new System.Windows.Forms.TextBox();
		this.ListView1 = new System.Windows.Forms.ListView();
		this.GroupBox1 = new System.Windows.Forms.GroupBox();
		this.GroupBox2 = new System.Windows.Forms.GroupBox();
		this.GroupBox1.SuspendLayout();
		this.GroupBox2.SuspendLayout();
		base.SuspendLayout();
		this.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
		this.DateTimePicker2.Location = new System.Drawing.Point(32, 66);
		this.DateTimePicker2.Name = "DateTimePicker2";
		this.DateTimePicker2.Size = new System.Drawing.Size(102, 20);
		this.DateTimePicker2.TabIndex = 3;
		this.DateTimePicker2.Visible = false;
		this.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
		this.DateTimePicker1.Location = new System.Drawing.Point(32, 26);
		this.DateTimePicker1.Name = "DateTimePicker1";
		this.DateTimePicker1.Size = new System.Drawing.Size(102, 20);
		this.DateTimePicker1.TabIndex = 2;
		this.CheckBox1.AutoSize = true;
		this.CheckBox1.Location = new System.Drawing.Point(141, 28);
		this.CheckBox1.Name = "CheckBox1";
		this.CheckBox1.Size = new System.Drawing.Size(89, 17);
		this.CheckBox1.TabIndex = 1;
		this.CheckBox1.Text = "Entre Fechas";
		this.CheckBox1.UseVisualStyleBackColor = true;
		this.Button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.Button1.Image = (System.Drawing.Image)resources.GetObject("Button1.Image");
		this.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
		this.Button1.Location = new System.Drawing.Point(12, 286);
		this.Button1.Name = "Button1";
		this.Button1.Size = new System.Drawing.Size(75, 57);
		this.Button1.TabIndex = 0;
		this.Button1.Text = "Consulta";
		this.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
		this.Button1.UseVisualStyleBackColor = true;
		this.Button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.Button2.Image = (System.Drawing.Image)resources.GetObject("Button2.Image");
		this.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
		this.Button2.Location = new System.Drawing.Point(105, 286);
		this.Button2.Name = "Button2";
		this.Button2.Size = new System.Drawing.Size(75, 57);
		this.Button2.TabIndex = 7;
		this.Button2.Text = "Exportar";
		this.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
		this.Button2.UseVisualStyleBackColor = true;
		this.Label3.AutoSize = true;
		this.Label3.Location = new System.Drawing.Point(14, 88);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(58, 13);
		this.Label3.TabIndex = 6;
		this.Label3.Text = "Diferencia:";
		this.Label2.AutoSize = true;
		this.Label2.Location = new System.Drawing.Point(35, 55);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(37, 13);
		this.Label2.TabIndex = 5;
		this.Label2.Text = "Costo:";
		this.Label1.AutoSize = true;
		this.Label1.Location = new System.Drawing.Point(39, 22);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(33, 13);
		this.Label1.TabIndex = 4;
		this.Label1.Text = "Flete:";
		this.TextBox3.Location = new System.Drawing.Point(78, 85);
		this.TextBox3.Name = "TextBox3";
		this.TextBox3.Size = new System.Drawing.Size(173, 20);
		this.TextBox3.TabIndex = 3;
		this.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		this.TextBox2.Location = new System.Drawing.Point(77, 52);
		this.TextBox2.Name = "TextBox2";
		this.TextBox2.Size = new System.Drawing.Size(173, 20);
		this.TextBox2.TabIndex = 2;
		this.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		this.TextBox1.Location = new System.Drawing.Point(78, 19);
		this.TextBox1.Name = "TextBox1";
		this.TextBox1.Size = new System.Drawing.Size(173, 20);
		this.TextBox1.TabIndex = 1;
		this.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		this.ListView1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.ListView1.Location = new System.Drawing.Point(286, 12);
		this.ListView1.Name = "ListView1";
		this.ListView1.Size = new System.Drawing.Size(584, 327);
		this.ListView1.TabIndex = 0;
		this.ListView1.UseCompatibleStateImageBehavior = false;
		this.GroupBox1.Controls.Add(this.DateTimePicker1);
		this.GroupBox1.Controls.Add(this.CheckBox1);
		this.GroupBox1.Controls.Add(this.DateTimePicker2);
		this.GroupBox1.Location = new System.Drawing.Point(12, 12);
		this.GroupBox1.Name = "GroupBox1";
		this.GroupBox1.Size = new System.Drawing.Size(268, 100);
		this.GroupBox1.TabIndex = 8;
		this.GroupBox1.TabStop = false;
		this.GroupBox1.Text = "Fecha:";
		this.GroupBox2.Controls.Add(this.TextBox1);
		this.GroupBox2.Controls.Add(this.Label1);
		this.GroupBox2.Controls.Add(this.TextBox2);
		this.GroupBox2.Controls.Add(this.Label3);
		this.GroupBox2.Controls.Add(this.Label2);
		this.GroupBox2.Controls.Add(this.TextBox3);
		this.GroupBox2.Location = new System.Drawing.Point(12, 118);
		this.GroupBox2.Name = "GroupBox2";
		this.GroupBox2.Size = new System.Drawing.Size(268, 116);
		this.GroupBox2.TabIndex = 9;
		this.GroupBox2.TabStop = false;
		this.GroupBox2.Text = "Totales:";
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(882, 355);
		base.Controls.Add(this.GroupBox2);
		base.Controls.Add(this.GroupBox1);
		base.Controls.Add(this.Button2);
		base.Controls.Add(this.Button1);
		base.Controls.Add(this.ListView1);
		base.Name = "Informes";
		this.Text = "Informes";
		this.GroupBox1.ResumeLayout(false);
		this.GroupBox1.PerformLayout();
		this.GroupBox2.ResumeLayout(false);
		this.GroupBox2.PerformLayout();
		base.ResumeLayout(false);
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		string text = Strings.Format(DateTimePicker1.Value, "yyyyMMdd");
		string text2 = Strings.Format(DateTimePicker2.Value, "yyyyMMdd");
		DataTable dataTable = (DataTable)Mod_Informes.informeDiario();
		ListView listView = ListView1;
		listView.Items.Clear();
		listView.Columns.Clear();
		listView.View = View.Details;
		listView.GridLines = true;
		listView.FullRowSelect = true;
		checked
		{
			int num = dataTable.Columns.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				listView.Columns.Add(dataTable.Columns[i].Caption);
			}
			listView.Columns[4].TextAlign = HorizontalAlignment.Right;
			listView.Columns[5].TextAlign = HorizontalAlignment.Right;
			listView.Columns[6].TextAlign = HorizontalAlignment.Right;
			listView.Columns[7].TextAlign = HorizontalAlignment.Right;
			listView.Columns[8].TextAlign = HorizontalAlignment.Right;
			listView.Columns[9].TextAlign = HorizontalAlignment.Right;
			listView.Columns[10].TextAlign = HorizontalAlignment.Right;
			listView = null;
			DataTable dataTable2 = dataTable;
			int num2 = dataTable2.Rows.Count - 1;
			for (int j = 0; j <= num2; j++)
			{
				ListViewItem listViewItem = new ListViewItem(dataTable2.Rows[j][0].ToString());
				int num3 = dataTable2.Columns.Count - 1;
				for (int k = 1; k <= num3; k++)
				{
					listViewItem.SubItems.Add(dataTable2.Rows[j][k].ToString());
				}
				ListView1.Items.Add(listViewItem);
			}
			dataTable2 = null;
			ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
			double num4 = 0.0;
			double num5 = 0.0;
			double num6 = 0.0;
			int num7 = ListView1.Items.Count - 1;
			for (int l = 0; l <= num7; l++)
			{
				double costo = Conversions.ToDouble(ListView1.Items[l].SubItems[8].Text);
				double flete = Conversions.ToDouble(ListView1.Items[l].SubItems[7].Text);
				try
				{
					object obj = Mod_Rentabilidad.rentabilidad(flete, costo);
					Color foreColor = ((obj != null) ? ((Color)obj) : default(Color));
					ListView1.Items[l].ForeColor = foreColor;
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ListView1.Items[l].ForeColor = Color.Black;
					ProjectData.ClearProjectError();
				}
				num4 += Conversions.ToDouble(ListView1.Items[l].SubItems[8].Text);
				num5 += Conversions.ToDouble(ListView1.Items[l].SubItems[7].Text);
			}
			TextBox1.Text = Conversions.ToString(num5);
			TextBox1.Refresh();
			TextBox2.Text = Conversions.ToString(num4);
			TextBox2.Refresh();
			num6 = num5 - num4;
			TextBox3.Text = Conversions.ToString(Math.Round(num6, 2));
			TextBox3.Refresh();
		}
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		SaveFileDialog saveFileDialog = new SaveFileDialog();
		saveFileDialog.Filter = "Excel files(*.xlsx)|*xlsx";
		saveFileDialog.Title = "Guardar Archivo";
		saveFileDialog.ShowDialog();
		string fileName = saveFileDialog.FileName;
		if (Operators.CompareString(fileName, "", TextCompare: true) != 0)
		{
			DataTable data = (DataTable)Mod_Exportar.ListviewToDatatable(ListView1);
			Mod_Exportar.DatatableToExcelDir(data, fileName);
		}
	}

	private void CheckBox1_CheckedChanged(object sender, EventArgs e)
	{
		if (CheckBox1.Checked)
		{
			DateTimePicker2.Visible = true;
		}
		else
		{
			DateTimePicker2.Visible = false;
		}
	}

	private void ListView1_ColumnClick(object sender, ColumnClickEventArgs e)
	{
		Mod_Ordenaclumnas.ordenar_columnas(ListView1, RuntimeHelpers.GetObjectValue(sender), e);
	}

	private void infviejo()
	{
		//IL_0b26: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b2d: Expected O, but got Unknown
		//IL_0b56: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b5d: Expected O, but got Unknown
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Expected O, but got Unknown
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Expected O, but got Unknown
		//IL_1003: Unknown result type (might be due to invalid IL or missing references)
		//IL_100a: Expected O, but got Unknown
		//IL_1033: Unknown result type (might be due to invalid IL or missing references)
		//IL_103a: Expected O, but got Unknown
		//IL_061d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0624: Expected O, but got Unknown
		//IL_064d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0654: Expected O, but got Unknown
		checked
		{
			if (CheckBox1.Checked)
			{
				if (Operators.CompareString(MyProject.Forms.Form1_Inicio.ComboBox1.Text, "1", TextCompare: true) == 0)
				{
					try
					{
						string text = Strings.Format(DateTimePicker1.Value, "yyyyMMdd");
						string text2 = Strings.Format(DateTimePicker2.Value, "yyyyMMdd");
						string text3 = "SELECT (SELECT Chofer FROM Flota WHERE Numero=Planchada.Chofer) AS Chofer, (SELECT Categoria FROM Flota WHERE Numero=Planchada.Chofer) AS CAT, count(DISTINCT Destino) AS Puntos,sum(Bultos) As Bultos, sum(ROUND(Declarado,2)) AS VD, sum(Round(Kilos, 2)) As Peso,sum(ROUND(Volumen,3)) AS Volumen,sum(Round(Flete, 2)) As Flete,Round((SELECT Tarifa FROM Flota WHERE Numero=Planchada.Chofer),2) AS AdicionalModelo,Adicional,(ROUND((SELECT Tarifa_fija FROM Categorias WHERE Categoria=CAT),2)) AS TarifaFija,(ROUND((SELECT Tarifa FROM Flota WHERE Numero=Planchada.Chofer)+(SELECT Tarifa_fija FROM Categorias WHERE Categoria=CAT),2)) AS Costo,fecha,Ventana FROM Planchada WHERE fecha BETWEEN '" + text + "' AND '" + text2 + "' AND Chofer>0 AND Ventana=1 GROUP BY Chofer,Fecha UNION ALL SELECT (SELECT Chofer FROM Flota WHERE Numero=Planchada.Chofer) AS Chofer,(SELECT Categoria FROM Flota WHERE Numero=Planchada.Chofer) AS CAT,count(DISTINCT Destino) AS Puntos,sum(Bultos) AS Bultos,sum(ROUND(Declarado,2)) AS VD,sum(ROUND(Kilos,2)) AS Peso,sum(ROUND(Volumen,3)) AS Volumen,sum(ROUND(Flete,2)) AS Flete,(ROUND(((SELECT Tarifa FROM Flota WHERE Numero=Planchada.Chofer)*(0.7)),2)) AS Tarifa,Adicional,(ROUND((SELECT Tarifa_fija FROM Categorias WHERE Categoria=CAT),2)) AS TarifaFija,(ROUND((SELECT Tarifa FROM Flota WHERE Numero=Planchada.Chofer) + (SELECT Tarifa FROM Flota WHERE Numero=Planchada.Chofer),2)) AS Costo,fecha,Ventana FROM Planchada WHERE fecha BETWEEN '" + text + "' AND '" + text2 + "' AND Chofer>0 AND Ventana>1 GROUP BY Chofer";
						Interaction.MsgBox(("Se mostraran los datos entre " + DateTimePicker1.Text + " y " + DateTimePicker2.Text) ?? "");
						MySettingsProperty.Settings.Sqlinforme = text3;
						Mod_Sentencias.cnn.Open();
						MySqlCommand val = new MySqlCommand();
						MySqlCommand val2 = val;
						val2.CommandType = CommandType.Text;
						val2.CommandText = text3;
						val2.Connection = Mod_Sentencias.cnn;
						val2 = null;
						MySqlDataAdapter val3 = new MySqlDataAdapter();
						DataSet dataSet = new DataSet();
						val3.SelectCommand = val;
						((DbDataAdapter)(object)val3).Fill(dataSet, "Tabla");
						ListView listView = ListView1;
						listView.Items.Clear();
						listView.Columns.Clear();
						listView.View = View.Details;
						listView.GridLines = true;
						listView.FullRowSelect = true;
						int num = dataSet.Tables["tabla"].Columns.Count - 1;
						for (int i = 0; i <= num; i++)
						{
							listView.Columns.Add(dataSet.Tables["tabla"].Columns[i].Caption);
						}
						listView.Columns[4].TextAlign = HorizontalAlignment.Right;
						listView.Columns[5].TextAlign = HorizontalAlignment.Right;
						listView.Columns[6].TextAlign = HorizontalAlignment.Right;
						listView.Columns[7].TextAlign = HorizontalAlignment.Right;
						listView.Columns[8].TextAlign = HorizontalAlignment.Right;
						listView.Columns[9].TextAlign = HorizontalAlignment.Right;
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
							ListView1.Items.Add(listViewItem);
						}
						dataTable = null;
						Mod_Sentencias.cnn.Close();
						ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
						double num4 = 0.0;
						double num5 = 0.0;
						double num6 = 0.0;
						int num7 = ListView1.Items.Count - 1;
						for (int l = 0; l <= num7; l++)
						{
							double costo = Conversions.ToDouble(ListView1.Items[l].SubItems[11].Text);
							double flete = Conversions.ToDouble(ListView1.Items[l].SubItems[7].Text);
							try
							{
								object obj = Mod_Rentabilidad.rentabilidad(flete, costo);
								Color backColor = ((obj != null) ? ((Color)obj) : default(Color));
								ListView1.Items[l].BackColor = backColor;
							}
							catch (Exception projectError)
							{
								ProjectData.SetProjectError(projectError);
								ListView1.Items[l].BackColor = Color.White;
								ProjectData.ClearProjectError();
							}
							num4 += Conversions.ToDouble(ListView1.Items[l].SubItems[11].Text);
							num5 += Conversions.ToDouble(ListView1.Items[l].SubItems[7].Text);
						}
						TextBox1.Text = Conversions.ToString(num5);
						TextBox1.Refresh();
						TextBox2.Text = Conversions.ToString(num4);
						TextBox2.Refresh();
						num6 = num5 - num4;
						TextBox3.Text = Conversions.ToString(Math.Round(num6, 2));
						TextBox3.Refresh();
						return;
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						Mod_Sentencias.cnn.Close();
						Interaction.MsgBox(ex2.Message);
						ProjectData.ClearProjectError();
						return;
					}
				}
				try
				{
					string text4 = Strings.Format(DateTimePicker1.Value, "yyyyMMdd");
					string text5 = Strings.Format(DateTimePicker2.Value, "yyyyMMdd");
					string text6 = "SELECT (SELECT Chofer FROM Flota WHERE Numero=Planchada.Chofer) AS Chofer,(SELECT Categoria FROM Flota WHERE Numero=Planchada.Chofer) AS CAT, count(DISTINCT Destino) AS Puntos, sum(Bultos) AS Bultos,sum(ROUND(Declarado,2)) AS VD, sum(ROUND(Kilos,2)) AS Peso, sum(ROUND(Volumen,3)) AS Volumen,sum(ROUND(Flete,2)) AS Flete,((SELECT Tarifa FROM Flota WHERE Numero=Planchada.Chofer)*(0.7)) AS Tarifa, (ROUND(((SELECT count(DISTINCT Destino) AS Puntos)*(SELECT Valorpe FROM Categorias WHERE Categoria=CAT))+((SELECT sum(Bultos) AS Bultos)*(SELECT Valorbulto FROM Categorias WHERE Categoria=CAT))+(SELECT Tarifa FROM Flota WHERE Numero=Planchada.Chofer),2)) AS Costo, fecha FROM Planchada WHERE fecha BETWEEN '" + text4 + "' AND '" + text5 + "' AND Chofer>0 AND Ventana=" + MyProject.Forms.Form1_Inicio.ComboBox1.Text + " GROUP BY Chofer";
					Interaction.MsgBox(("Se mostraran los datos entre " + DateTimePicker1.Text + " y " + DateTimePicker2.Text) ?? "");
					MySettingsProperty.Settings.Sqlinforme = text6;
					Mod_Sentencias.cnn.Open();
					MySqlCommand val4 = new MySqlCommand();
					MySqlCommand val5 = val4;
					val5.CommandType = CommandType.Text;
					val5.CommandText = text6;
					val5.Connection = Mod_Sentencias.cnn;
					val5 = null;
					MySqlDataAdapter val6 = new MySqlDataAdapter();
					DataSet dataSet2 = new DataSet();
					val6.SelectCommand = val4;
					((DbDataAdapter)(object)val6).Fill(dataSet2, "Tabla");
					ListView listView2 = ListView1;
					listView2.Items.Clear();
					listView2.Columns.Clear();
					listView2.View = View.Details;
					listView2.GridLines = true;
					listView2.FullRowSelect = true;
					int num8 = dataSet2.Tables["tabla"].Columns.Count - 1;
					for (int m = 0; m <= num8; m++)
					{
						listView2.Columns.Add(dataSet2.Tables["tabla"].Columns[m].Caption);
					}
					listView2.Columns[4].TextAlign = HorizontalAlignment.Right;
					listView2.Columns[5].TextAlign = HorizontalAlignment.Right;
					listView2.Columns[6].TextAlign = HorizontalAlignment.Right;
					listView2.Columns[7].TextAlign = HorizontalAlignment.Right;
					listView2.Columns[8].TextAlign = HorizontalAlignment.Right;
					listView2.Columns[9].TextAlign = HorizontalAlignment.Right;
					listView2 = null;
					DataTable dataTable2 = dataSet2.Tables["tabla"];
					int num9 = dataTable2.Rows.Count - 1;
					for (int n = 0; n <= num9; n++)
					{
						ListViewItem listViewItem2 = new ListViewItem(dataTable2.Rows[n][0].ToString());
						int num10 = dataTable2.Columns.Count - 1;
						for (int num11 = 1; num11 <= num10; num11++)
						{
							listViewItem2.SubItems.Add(dataTable2.Rows[n][num11].ToString());
						}
						ListView1.Items.Add(listViewItem2);
					}
					dataTable2 = null;
					Mod_Sentencias.cnn.Close();
					ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
					double num12 = 0.0;
					double num13 = 0.0;
					double num14 = 0.0;
					int num15 = ListView1.Items.Count - 1;
					for (int num16 = 0; num16 <= num15; num16++)
					{
						double costo2 = Conversions.ToDouble(ListView1.Items[num16].SubItems[9].Text);
						double flete2 = Conversions.ToDouble(ListView1.Items[num16].SubItems[7].Text);
						try
						{
							object obj2 = Mod_Rentabilidad.rentabilidad(flete2, costo2);
							Color backColor2 = ((obj2 != null) ? ((Color)obj2) : default(Color));
							ListView1.Items[num16].BackColor = backColor2;
						}
						catch (Exception projectError2)
						{
							ProjectData.SetProjectError(projectError2);
							ListView1.Items[num16].BackColor = Color.White;
							ProjectData.ClearProjectError();
						}
						num12 += Conversions.ToDouble(ListView1.Items[num16].SubItems[9].Text);
						num13 += Conversions.ToDouble(ListView1.Items[num16].SubItems[7].Text);
					}
					TextBox1.Text = Conversions.ToString(num13);
					TextBox1.Refresh();
					TextBox2.Text = Conversions.ToString(num12);
					TextBox2.Refresh();
					num14 = num13 - num12;
					TextBox3.Text = Conversions.ToString(Math.Round(num14, 2));
					TextBox3.Refresh();
					return;
				}
				catch (Exception ex3)
				{
					ProjectData.SetProjectError(ex3);
					Exception ex4 = ex3;
					Mod_Sentencias.cnn.Close();
					Interaction.MsgBox(ex4.Message);
					ProjectData.ClearProjectError();
					return;
				}
			}
			if (Operators.CompareString(MyProject.Forms.Form1_Inicio.ComboBox1.Text, "1", TextCompare: true) == 0)
			{
				try
				{
					string text7 = Strings.Format(DateTimePicker1.Value, "yyyyMMdd");
					string text8 = "SELECT (SELECT Chofer FROM Flota WHERE Numero=Planchada.Chofer) AS Chofer,(SELECT Categoria FROM Flota WHERE Numero=Planchada.Chofer) AS CAT, count(DISTINCT Destino) AS Puntos, sum(Bultos) AS Bultos,sum(ROUND(Declarado,2)) AS VD, sum(ROUND(Kilos,2)) AS Peso, sum(ROUND(Volumen,3)) AS Volumen,sum(ROUND(Flete,2)) AS Flete,(SELECT Tarifa FROM Flota WHERE Numero=Planchada.Chofer) AS Tarifa, (ROUND(((SELECT count(DISTINCT Destino) AS Puntos)*(SELECT Valorpe FROM Categorias WHERE Categoria=CAT))+((SELECT sum(Bultos) AS Bultos)*(SELECT Valorbulto FROM Categorias WHERE Categoria=CAT))+(SELECT Tarifa FROM Flota WHERE Numero=Planchada.Chofer),2)) AS Costo, fecha FROM Planchada WHERE fecha = '" + text7 + "' AND Chofer>0 AND Ventana=" + MyProject.Forms.Form1_Inicio.ComboBox1.Text + " GROUP BY Chofer";
					Interaction.MsgBox(("Se mostraran los datos para la fecha " + DateTimePicker1.Text) ?? "");
					MySettingsProperty.Settings.Sqlinforme = text8;
					Mod_Sentencias.cnn.Open();
					MySqlCommand val7 = new MySqlCommand();
					MySqlCommand val8 = val7;
					val8.CommandType = CommandType.Text;
					val8.CommandText = text8;
					val8.Connection = Mod_Sentencias.cnn;
					val8 = null;
					MySqlDataAdapter val9 = new MySqlDataAdapter();
					DataSet dataSet3 = new DataSet();
					val9.SelectCommand = val7;
					((DbDataAdapter)(object)val9).Fill(dataSet3, "Tabla");
					ListView listView3 = ListView1;
					listView3.Items.Clear();
					listView3.Columns.Clear();
					listView3.View = View.Details;
					listView3.GridLines = true;
					listView3.FullRowSelect = true;
					int num17 = dataSet3.Tables["tabla"].Columns.Count - 1;
					for (int num18 = 0; num18 <= num17; num18++)
					{
						listView3.Columns.Add(dataSet3.Tables["tabla"].Columns[num18].Caption);
					}
					listView3.Columns[4].TextAlign = HorizontalAlignment.Right;
					listView3.Columns[5].TextAlign = HorizontalAlignment.Right;
					listView3.Columns[6].TextAlign = HorizontalAlignment.Right;
					listView3.Columns[7].TextAlign = HorizontalAlignment.Right;
					listView3.Columns[8].TextAlign = HorizontalAlignment.Right;
					listView3.Columns[9].TextAlign = HorizontalAlignment.Right;
					listView3 = null;
					DataTable dataTable3 = dataSet3.Tables["tabla"];
					int num19 = dataTable3.Rows.Count - 1;
					for (int num20 = 0; num20 <= num19; num20++)
					{
						ListViewItem listViewItem3 = new ListViewItem(dataTable3.Rows[num20][0].ToString());
						int num21 = dataTable3.Columns.Count - 1;
						for (int num22 = 1; num22 <= num21; num22++)
						{
							listViewItem3.SubItems.Add(dataTable3.Rows[num20][num22].ToString());
						}
						ListView1.Items.Add(listViewItem3);
					}
					dataTable3 = null;
					Mod_Sentencias.cnn.Close();
					ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
					double num23 = 0.0;
					double num24 = 0.0;
					double num25 = 0.0;
					int num26 = ListView1.Items.Count - 1;
					for (int num27 = 0; num27 <= num26; num27++)
					{
						double costo3 = Conversions.ToDouble(ListView1.Items[num27].SubItems[9].Text);
						double flete3 = Conversions.ToDouble(ListView1.Items[num27].SubItems[7].Text);
						try
						{
							object obj3 = Mod_Rentabilidad.rentabilidad(flete3, costo3);
							Color backColor3 = ((obj3 != null) ? ((Color)obj3) : default(Color));
							ListView1.Items[num27].BackColor = backColor3;
						}
						catch (Exception projectError3)
						{
							ProjectData.SetProjectError(projectError3);
							ListView1.Items[num27].BackColor = Color.White;
							ProjectData.ClearProjectError();
						}
						num23 += Conversions.ToDouble(ListView1.Items[num27].SubItems[9].Text);
						num24 += Conversions.ToDouble(ListView1.Items[num27].SubItems[7].Text);
					}
					TextBox1.Text = Conversions.ToString(num24);
					TextBox1.Refresh();
					TextBox2.Text = Conversions.ToString(num23);
					TextBox2.Refresh();
					num25 = num24 - num23;
					TextBox3.Text = Conversions.ToString(Math.Round(num25, 2));
					TextBox3.Refresh();
					return;
				}
				catch (Exception ex5)
				{
					ProjectData.SetProjectError(ex5);
					Exception ex6 = ex5;
					Mod_Sentencias.cnn.Close();
					Interaction.MsgBox(ex6.Message);
					ProjectData.ClearProjectError();
					return;
				}
			}
			try
			{
				string text9 = Strings.Format(DateTimePicker1.Value, "yyyyMMdd");
				string text10 = "SELECT (SELECT Chofer FROM Flota WHERE Numero=Planchada.Chofer) AS Chofer,(SELECT Categoria FROM Flota WHERE Numero=Planchada.Chofer) AS CAT, count(DISTINCT Destino) AS Puntos, sum(Bultos) AS Bultos,sum(ROUND(Declarado,2)) AS VD, sum(ROUND(Kilos,2)) AS Peso, sum(ROUND(Volumen,3)) AS Volumen,sum(ROUND(Flete,2)) AS Flete,((SELECT Tarifa FROM Flota WHERE Numero=Planchada.Chofer)*(0.7)) AS Tarifa, (ROUND(((SELECT count(DISTINCT Destino) AS Puntos)*(SELECT Valorpe FROM Categorias WHERE Categoria=CAT))+((SELECT sum(Bultos) AS Bultos)*(SELECT Valorbulto FROM Categorias WHERE Categoria=CAT))+(SELECT Tarifa FROM Flota WHERE Numero=Planchada.Chofer),2)) AS Costo, fecha FROM Planchada WHERE fecha = '" + text9 + "'  AND Chofer>0 AND Ventana=" + MyProject.Forms.Form1_Inicio.ComboBox1.Text + " GROUP BY Chofer";
				Interaction.MsgBox(("Se mostraran los datos para la fecha " + DateTimePicker1.Text) ?? "");
				MySettingsProperty.Settings.Sqlinforme = text10;
				Mod_Sentencias.cnn.Open();
				MySqlCommand val10 = new MySqlCommand();
				MySqlCommand val11 = val10;
				val11.CommandType = CommandType.Text;
				val11.CommandText = text10;
				val11.Connection = Mod_Sentencias.cnn;
				val11 = null;
				MySqlDataAdapter val12 = new MySqlDataAdapter();
				DataSet dataSet4 = new DataSet();
				val12.SelectCommand = val10;
				((DbDataAdapter)(object)val12).Fill(dataSet4, "Tabla");
				ListView listView4 = ListView1;
				listView4.Items.Clear();
				listView4.Columns.Clear();
				listView4.View = View.Details;
				listView4.GridLines = true;
				listView4.FullRowSelect = true;
				int num28 = dataSet4.Tables["tabla"].Columns.Count - 1;
				for (int num29 = 0; num29 <= num28; num29++)
				{
					listView4.Columns.Add(dataSet4.Tables["tabla"].Columns[num29].Caption);
				}
				listView4.Columns[4].TextAlign = HorizontalAlignment.Right;
				listView4.Columns[5].TextAlign = HorizontalAlignment.Right;
				listView4.Columns[6].TextAlign = HorizontalAlignment.Right;
				listView4.Columns[7].TextAlign = HorizontalAlignment.Right;
				listView4.Columns[8].TextAlign = HorizontalAlignment.Right;
				listView4.Columns[9].TextAlign = HorizontalAlignment.Right;
				listView4 = null;
				DataTable dataTable4 = dataSet4.Tables["tabla"];
				int num30 = dataTable4.Rows.Count - 1;
				for (int num31 = 0; num31 <= num30; num31++)
				{
					ListViewItem listViewItem4 = new ListViewItem(dataTable4.Rows[num31][0].ToString());
					int num32 = dataTable4.Columns.Count - 1;
					for (int num33 = 1; num33 <= num32; num33++)
					{
						listViewItem4.SubItems.Add(dataTable4.Rows[num31][num33].ToString());
					}
					ListView1.Items.Add(listViewItem4);
				}
				dataTable4 = null;
				Mod_Sentencias.cnn.Close();
				ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
				double num34 = 0.0;
				double num35 = 0.0;
				double num36 = 0.0;
				int num37 = ListView1.Items.Count - 1;
				for (int num38 = 0; num38 <= num37; num38++)
				{
					double costo4 = Conversions.ToDouble(ListView1.Items[num38].SubItems[9].Text);
					double flete4 = Conversions.ToDouble(ListView1.Items[num38].SubItems[7].Text);
					try
					{
						object obj4 = Mod_Rentabilidad.rentabilidad(flete4, costo4);
						Color backColor4 = ((obj4 != null) ? ((Color)obj4) : default(Color));
						ListView1.Items[num38].BackColor = backColor4;
					}
					catch (Exception projectError4)
					{
						ProjectData.SetProjectError(projectError4);
						ListView1.Items[num38].BackColor = Color.White;
						ProjectData.ClearProjectError();
					}
					num34 += Conversions.ToDouble(ListView1.Items[num38].SubItems[9].Text);
					num35 += Conversions.ToDouble(ListView1.Items[num38].SubItems[7].Text);
				}
				TextBox1.Text = Conversions.ToString(num35);
				TextBox1.Refresh();
				TextBox2.Text = Conversions.ToString(num34);
				TextBox2.Refresh();
				num36 = num35 - num34;
				TextBox3.Text = Conversions.ToString(Math.Round(num36, 2));
				TextBox3.Refresh();
			}
			catch (Exception ex7)
			{
				ProjectData.SetProjectError(ex7);
				Exception ex8 = ex7;
				Mod_Sentencias.cnn.Close();
				Interaction.MsgBox(ex8.Message);
				ProjectData.ClearProjectError();
			}
		}
	}
}
