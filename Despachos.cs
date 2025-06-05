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
public class Despachos : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button3")]
	private Button _Button3;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("CheckBox1")]
	private CheckBox _CheckBox1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button4")]
	private Button _Button4;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button5")]
	private Button _Button5;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("BackgroundWorker1")]
	private BackgroundWorker _BackgroundWorker1;

	[field: AccessedThroughProperty("ListView1")]
	internal virtual ListView ListView1
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

	[field: AccessedThroughProperty("DateTimePicker1")]
	internal virtual DateTimePicker DateTimePicker1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DateTimePicker2")]
	internal virtual DateTimePicker DateTimePicker2
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

	internal virtual Button Button5
	{
		[CompilerGenerated]
		get
		{
			return _Button5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button5_Click;
			Button button = _Button5;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button5 = value;
			button = _Button5;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("StatusStrip1")]
	internal virtual StatusStrip StatusStrip1
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

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
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

	[field: AccessedThroughProperty("Label4")]
	internal virtual Label Label4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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
			BackgroundWorker backgroundWorker = _BackgroundWorker1;
			if (backgroundWorker != null)
			{
				backgroundWorker.DoWork -= value2;
			}
			_BackgroundWorker1 = value;
			backgroundWorker = _BackgroundWorker1;
			if (backgroundWorker != null)
			{
				backgroundWorker.DoWork += value2;
			}
		}
	}

	[field: AccessedThroughProperty("CheckBox2")]
	internal virtual CheckBox CheckBox2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public Despachos()
	{
		base.Load += Despachos_Load;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hermes.Despachos));
		this.ListView1 = new System.Windows.Forms.ListView();
		this.Button1 = new System.Windows.Forms.Button();
		this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
		this.DateTimePicker2 = new System.Windows.Forms.DateTimePicker();
		this.Button3 = new System.Windows.Forms.Button();
		this.CheckBox1 = new System.Windows.Forms.CheckBox();
		this.Button4 = new System.Windows.Forms.Button();
		this.Button5 = new System.Windows.Forms.Button();
		this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
		this.Label1 = new System.Windows.Forms.Label();
		this.Label2 = new System.Windows.Forms.Label();
		this.Label3 = new System.Windows.Forms.Label();
		this.Label4 = new System.Windows.Forms.Label();
		this.BackgroundWorker1 = new System.ComponentModel.BackgroundWorker();
		this.CheckBox2 = new System.Windows.Forms.CheckBox();
		base.SuspendLayout();
		this.ListView1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.ListView1.CheckBoxes = true;
		this.ListView1.Location = new System.Drawing.Point(12, 61);
		this.ListView1.Name = "ListView1";
		this.ListView1.Size = new System.Drawing.Size(853, 328);
		this.ListView1.TabIndex = 0;
		this.ListView1.UseCompatibleStateImageBehavior = false;
		this.Button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.Button1.Image = (System.Drawing.Image)resources.GetObject("Button1.Image");
		this.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
		this.Button1.Location = new System.Drawing.Point(12, 395);
		this.Button1.Name = "Button1";
		this.Button1.Size = new System.Drawing.Size(92, 62);
		this.Button1.TabIndex = 1;
		this.Button1.Text = "Cargar";
		this.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
		this.Button1.UseVisualStyleBackColor = true;
		this.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
		this.DateTimePicker1.Location = new System.Drawing.Point(12, 12);
		this.DateTimePicker1.Name = "DateTimePicker1";
		this.DateTimePicker1.Size = new System.Drawing.Size(99, 20);
		this.DateTimePicker1.TabIndex = 2;
		this.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
		this.DateTimePicker2.Location = new System.Drawing.Point(117, 12);
		this.DateTimePicker2.Name = "DateTimePicker2";
		this.DateTimePicker2.Size = new System.Drawing.Size(99, 20);
		this.DateTimePicker2.TabIndex = 3;
		this.Button3.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.Button3.Image = (System.Drawing.Image)resources.GetObject("Button3.Image");
		this.Button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
		this.Button3.Location = new System.Drawing.Point(110, 395);
		this.Button3.Name = "Button3";
		this.Button3.Size = new System.Drawing.Size(92, 62);
		this.Button3.TabIndex = 5;
		this.Button3.Text = "Despachar";
		this.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
		this.Button3.UseVisualStyleBackColor = true;
		this.CheckBox1.AutoSize = true;
		this.CheckBox1.Location = new System.Drawing.Point(12, 38);
		this.CheckBox1.Name = "CheckBox1";
		this.CheckBox1.Size = new System.Drawing.Size(115, 17);
		this.CheckBox1.TabIndex = 6;
		this.CheckBox1.Text = "Seleccionar Todas";
		this.CheckBox1.UseVisualStyleBackColor = true;
		this.Button4.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.Button4.Image = (System.Drawing.Image)resources.GetObject("Button4.Image");
		this.Button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
		this.Button4.Location = new System.Drawing.Point(208, 395);
		this.Button4.Name = "Button4";
		this.Button4.Size = new System.Drawing.Size(92, 62);
		this.Button4.TabIndex = 7;
		this.Button4.Text = "Subir Ruta/s";
		this.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
		this.Button4.UseVisualStyleBackColor = true;
		this.Button5.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		this.Button5.Image = (System.Drawing.Image)resources.GetObject("Button5.Image");
		this.Button5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
		this.Button5.Location = new System.Drawing.Point(773, 395);
		this.Button5.Name = "Button5";
		this.Button5.Size = new System.Drawing.Size(92, 62);
		this.Button5.TabIndex = 8;
		this.Button5.Text = "Salir";
		this.Button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
		this.Button5.UseVisualStyleBackColor = true;
		this.StatusStrip1.Location = new System.Drawing.Point(0, 461);
		this.StatusStrip1.Name = "StatusStrip1";
		this.StatusStrip1.Size = new System.Drawing.Size(877, 22);
		this.StatusStrip1.TabIndex = 9;
		this.StatusStrip1.Text = "StatusStrip1";
		this.Label1.AutoSize = true;
		this.Label1.Location = new System.Drawing.Point(460, 38);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(76, 13);
		this.Label1.TabIndex = 10;
		this.Label1.Text = "Rutas Totales:";
		this.Label2.AutoSize = true;
		this.Label2.Location = new System.Drawing.Point(542, 38);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(13, 13);
		this.Label2.TabIndex = 11;
		this.Label2.Text = "0";
		this.Label3.AutoSize = true;
		this.Label3.Location = new System.Drawing.Point(632, 38);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(107, 13);
		this.Label3.TabIndex = 12;
		this.Label3.Text = "Rutas Despachadas:";
		this.Label4.AutoSize = true;
		this.Label4.Location = new System.Drawing.Point(745, 38);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(13, 13);
		this.Label4.TabIndex = 13;
		this.Label4.Text = "0";
		this.CheckBox2.AutoSize = true;
		this.CheckBox2.Enabled = false;
		this.CheckBox2.Location = new System.Drawing.Point(319, 439);
		this.CheckBox2.Name = "CheckBox2";
		this.CheckBox2.Size = new System.Drawing.Size(92, 17);
		this.CheckBox2.TabIndex = 14;
		this.CheckBox2.Text = "ReDespachar";
		this.CheckBox2.UseVisualStyleBackColor = true;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(877, 483);
		base.Controls.Add(this.CheckBox2);
		base.Controls.Add(this.Label4);
		base.Controls.Add(this.Label3);
		base.Controls.Add(this.Label2);
		base.Controls.Add(this.Label1);
		base.Controls.Add(this.StatusStrip1);
		base.Controls.Add(this.Button5);
		base.Controls.Add(this.Button4);
		base.Controls.Add(this.CheckBox1);
		base.Controls.Add(this.Button3);
		base.Controls.Add(this.DateTimePicker2);
		base.Controls.Add(this.DateTimePicker1);
		base.Controls.Add(this.Button1);
		base.Controls.Add(this.ListView1);
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.Name = "Despachos";
		this.Text = "Despachos";
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected O, but got Unknown
		checked
		{
			try
			{
				string text = Strings.Format(MyProject.Forms.Form1_Inicio.DateTimePicker1.Value, "yyyyMMdd");
				string commandText = "SELECT (SELECT Chofer FROM Flota WHERE Numero=Planchada.Chofer) AS Chofer,(SELECT Categoria FROM Flota WHERE Numero=Planchada.Chofer) AS CAT, count(DISTINCT Destino) AS Puntos, sum(Bultos) AS Bultos,sum(ROUND(Declarado,2)) AS VD, sum(ROUND(Kilos,2)) AS Peso, sum(ROUND(Volumen,3)) AS Volumen,sum(ROUND(Flete,2)) AS Flete,(SELECT Tarifa FROM Flota WHERE Numero=Planchada.Chofer) AS Tarifa, (ROUND(((SELECT count(DISTINCT Destino) AS Puntos)*(SELECT Valorpe FROM Categorias WHERE Categoria=CAT))+((SELECT sum(Bultos) AS Bultos)*(SELECT Valorbulto FROM Categorias WHERE Categoria=CAT))+(SELECT Tarifa FROM Flota WHERE Numero=Planchada.Chofer),2)) AS Costo FROM Planchada WHERE fecha = '" + text + "' AND Chofer>0 AND Ventana=" + MyProject.Forms.Form1_Inicio.ComboBox1.Text + " GROUP BY Chofer";
				Interaction.MsgBox(("Se mostraran los datos para " + MyProject.Forms.Form1_Inicio.DateTimePicker1.Text) ?? "");
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
				listView.Columns.Clear();
				listView.View = View.Details;
				listView.GridLines = true;
				listView.FullRowSelect = true;
				int num = dataSet.Tables["tabla"].Columns.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					listView.Columns.Add(dataSet.Tables["tabla"].Columns[i].Caption);
				}
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
					num4 += Conversions.ToDouble(ListView1.Items[l].SubItems[9].Text);
					num5 += Conversions.ToDouble(ListView1.Items[l].SubItems[7].Text);
				}
				CheckBox1.Checked = false;
				Label2.Text = Conversions.ToString(ListView1.Items.Count);
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

	private void despachar_viejo()
	{
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected O, but got Unknown
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Expected O, but got Unknown
		DateTime dateTime = Conversions.ToDate(Strings.Format(DateTimePicker1.Value, "yyyyMMdd"));
		if (ListView1.SelectedItems.Count <= 0)
		{
			return;
		}
		int index = ListView1.SelectedIndices[0];
		string text = "SELECT Numero FROM Flota WHERE Chofer='" + ListView1.Items[index].Text + "'";
		DataTable dataTable = new DataTable("x");
		MySqlDataAdapter val = new MySqlDataAdapter(text, Mod_Sentencias.cnn);
		((DbDataAdapter)(object)val).Fill(dataTable);
		string text2 = dataTable.Rows[0]["Numero"].ToString();
		string text3 = ("SELECT * FROM planchada WHERE Chofer=" + text2 + " and ventana =" + MyProject.Forms.Form1_Inicio.ComboBox1.Text + " and Fecha=" + Conversions.ToString(dateTime)) ?? "";
		DataTable dataTable2 = new DataTable("x");
		MySqlDataAdapter val2 = new MySqlDataAdapter(text3, Mod_Sentencias.cnn);
		((DbDataAdapter)(object)val2).Fill(dataTable2);
		checked
		{
			int num = dataTable2.Rows.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				if (!Operators.ConditionalCompareObjectEqual(dataTable2.Rows[i]["ESTADO"], "Ruteado", TextCompare: true))
				{
					continue;
				}
				if (Operators.ConditionalCompareObjectEqual(dataTable2.Rows[i]["Cliente"], "ETRANS", TextCompare: true))
				{
					if (Operators.ConditionalCompareObjectEqual(dataTable2.Rows[i]["SUB"], 11, TextCompare: true))
					{
						string sQL = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("UPDATE Planchada SET Estado='EN RECOLECCION' WHERE Comprobante= '", dataTable2.Rows[i]["Comprobante"]), "' AND Fecha='"), dateTime), "'"));
						Mod_ConeccionBD.BD_Sentencia(sQL);
						int num2 = Conversions.ToInteger(Mod_logger.historialenter(Conversions.ToString(dataTable2.Rows[i]["Comprobante"]), " ", "'EN RECOLECCION'", " "));
					}
					else
					{
						string sQL2 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("UPDATE Planchada SET Estado='DESPACHADO' WHERE Comprobante= '", dataTable2.Rows[i]["Comprobante"]), "' AND Fecha='"), dateTime), "'"));
						Mod_ConeccionBD.BD_Sentencia(sQL2);
						int num3 = Conversions.ToInteger(Mod_logger.historialenter(Conversions.ToString(dataTable2.Rows[i]["Comprobante"]), " ", "'DESPACHADO'", " "));
					}
				}
				else
				{
					string sQL3 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("UPDATE Planchada SET Estado='DESPACHADO' WHERE Comprobante= '", dataTable2.Rows[i]["Comprobante"]), "' AND Fecha='"), dateTime), "'"));
					Mod_ConeccionBD.BD_Sentencia(sQL3);
					int num4 = Conversions.ToInteger(Mod_logger.historialenter(Conversions.ToString(dataTable2.Rows[i]["Comprobante"]), " ", "'DESPACHADO'", " "));
				}
			}
			Interaction.MsgBox("Ruta " + ListView1.Items[index].Text + " Despachado.");
		}
	}

	private void Button3_Click(object sender, EventArgs e)
	{
		checked
		{
			if (ListView1.CheckedItems.Count > 0)
			{
				int num = 0;
				int num2 = ListView1.CheckedItems.Count - 1;
				for (int i = 0; i <= num2; i++)
				{
					num = ((!CheckBox2.Checked) ? Conversions.ToInteger(Operators.AddObject(num, despachar_ruta(ListView1.CheckedItems[i].Text, i))) : Conversions.ToInteger(Operators.AddObject(num, redespachar_ruta(ListView1.CheckedItems[i].Text, i))));
					Label4.Text = Conversions.ToString(num);
				}
				Interaction.MsgBox("Se despacharon " + Conversions.ToString(num) + " rutas");
				CheckBox1.Checked = true;
				CheckBox1.Checked = false;
			}
			else
			{
				Interaction.MsgBox("Selecciona la/s rutas a despachar", MsgBoxStyle.Exclamation);
			}
		}
	}

	private object despachar_ruta(string chofer_d, int i)
	{
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected O, but got Unknown
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected O, but got Unknown
		checked
		{
			object result3;
			try
			{
				string text = Strings.Format(MyProject.Forms.Form1_Inicio.DateTimePicker1.Value, "yyyyMMdd");
				int num = Conversions.ToInteger(MyProject.Forms.Form1_Inicio.ComboBox1.Text);
				string text2 = MyProject.Forms.Form1_Inicio.nombreusuario.Text;
				string text3 = "SELECT Numero FROM Flota WHERE Chofer='" + chofer_d + "'";
				DataTable dataTable = new DataTable("x");
				MySqlDataAdapter val = new MySqlDataAdapter(text3, Mod_Sentencias.cnn);
				((DbDataAdapter)(object)val).Fill(dataTable);
				string text4 = dataTable.Rows[0]["Numero"].ToString();
				string text5 = ("SELECT comprobante, estado, cliente, sub, remitos, guia FROM planchada WHERE Chofer=" + text4 + " and ventana =" + Conversions.ToString(num) + " and Fecha=" + text) ?? "";
				DataTable dataTable2 = new DataTable("x");
				MySqlDataAdapter val2 = new MySqlDataAdapter(text5, Mod_Sentencias.cnn);
				((DbDataAdapter)(object)val2).Fill(dataTable2);
				int num2 = dataTable2.Rows.Count - 1;
				for (int j = 0; j <= num2; j++)
				{
					if (!Operators.ConditionalCompareObjectEqual(dataTable2.Rows[j]["ESTADO"], "Ruteado", TextCompare: true))
					{
						continue;
					}
					object left = dataTable2.Rows[j]["Cliente"];
					if (Operators.ConditionalCompareObjectEqual(left, "ETRANS", TextCompare: true))
					{
						if (Operators.ConditionalCompareObjectEqual(dataTable2.Rows[j]["SUB"], 11, TextCompare: true))
						{
							string sQL = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("UPDATE Planchada SET Estado='EN RECOLECCION', Usuario='" + text2 + "' WHERE Comprobante= '", dataTable2.Rows[j]["Comprobante"]), "' AND Fecha='"), text), "'"));
							Mod_ConeccionBD.BD_Sentencia(sQL);
							string sQL2 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("UPDATE etransEnvios SET Estado='EN RECOLECCION' WHERE id_envio=", dataTable2.Rows[j]["Remitos"]), ""));
							Mod_ConeccionBD.BD_Sentencia(sQL2);
						}
						else
						{
							string sQL3 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("UPDATE Planchada SET Estado='DESPACHADO', Usuario='" + text2 + "' WHERE Comprobante= '", dataTable2.Rows[j]["Comprobante"]), "' AND Fecha='"), text), "'"));
							Mod_ConeccionBD.BD_Sentencia(sQL3);
							string sQL4 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("UPDATE etransEnvios SET Estado='DESPACHADO' WHERE id_envio=", dataTable2.Rows[j]["Remitos"]), ""));
							Mod_ConeccionBD.BD_Sentencia(sQL4);
						}
					}
					else if (Operators.ConditionalCompareObjectEqual(left, "DABRA SOCIEDAD ANONIMA", TextCompare: true))
					{
						if (Operators.ConditionalCompareObjectEqual(dataTable2.Rows[j]["SUB"], "01", TextCompare: true))
						{
							string sQL5 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("UPDATE Planchada SET Estado='EN RECOLECCION', Usuario='" + text2 + "' WHERE Comprobante= '", dataTable2.Rows[j]["Comprobante"]), "' AND Fecha='"), text), "'"));
							Mod_ConeccionBD.BD_Sentencia(sQL5);
							if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(dataTable2.Rows[j]["SUB"], "10", TextCompare: true), int.TryParse(Conversions.ToString(dataTable2.Rows[j]["remitos"]), out var _))))
							{
								Mod_ecommerce.CambiarEstados(Conversions.ToInteger(dataTable2.Rows[j]["remitos"]), 4);
							}
						}
						else
						{
							string sQL6 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("UPDATE Planchada SET Estado='DESPACHADO', Usuario='" + text2 + "' WHERE Comprobante= '", dataTable2.Rows[j]["Comprobante"]), "' AND Fecha='"), text), "'"));
							Mod_ConeccionBD.BD_Sentencia(sQL6);
							if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(dataTable2.Rows[j]["SUB"], "10", TextCompare: true), int.TryParse(Conversions.ToString(dataTable2.Rows[j]["remitos"]), out var _))))
							{
								Mod_ecommerce.CambiarEstados(Conversions.ToInteger(dataTable2.Rows[j]["remitos"]), 4);
							}
						}
					}
					else if (Operators.ConditionalCompareObjectEqual(left, "LAS BLONDAS S.A", TextCompare: true))
					{
						if (Operators.ConditionalCompareObjectEqual(dataTable2.Rows[j]["SUB"], "01", TextCompare: true))
						{
							string sQL7 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("UPDATE Planchada SET Estado='EN RECOLECCION', Usuario='" + text2 + "' WHERE Comprobante= '", dataTable2.Rows[j]["Comprobante"]), "' AND Fecha='"), text), "'"));
							Mod_ConeccionBD.BD_Sentencia(sQL7);
						}
						else
						{
							string sQL8 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("UPDATE Planchada SET Estado='DESPACHADO', Usuario='" + text2 + "' WHERE Comprobante= '", dataTable2.Rows[j]["Comprobante"]), "' AND Fecha='"), text), "'"));
							Mod_ConeccionBD.BD_Sentencia(sQL8);
						}
					}
					else if (Operators.ConditionalCompareObjectEqual(left, "TISCH S.R.L. (MISHKA)", TextCompare: true))
					{
						if (Operators.ConditionalCompareObjectEqual(dataTable2.Rows[j]["SUB"], "01", TextCompare: true))
						{
							string sQL9 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("UPDATE Planchada SET Estado='EN RECOLECCION', Usuario='" + text2 + "' WHERE Comprobante= '", dataTable2.Rows[j]["Comprobante"]), "' AND Fecha='"), text), "'"));
							Mod_ConeccionBD.BD_Sentencia(sQL9);
						}
						else
						{
							string sQL10 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("UPDATE Planchada SET Estado='DESPACHADO', Usuario='" + text2 + "' WHERE Comprobante= '", dataTable2.Rows[j]["Comprobante"]), "' AND Fecha='"), text), "'"));
							Mod_ConeccionBD.BD_Sentencia(sQL10);
						}
					}
					else if (Operators.ConditionalCompareObjectEqual(left, "GAX S.A. (PRUNE)", TextCompare: true))
					{
						if (Operators.ConditionalCompareObjectEqual(dataTable2.Rows[j]["SUB"], "01", TextCompare: true))
						{
							string sQL11 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("UPDATE Planchada SET Estado='EN RECOLECCION', Usuario='" + text2 + "' WHERE Comprobante= '", dataTable2.Rows[j]["Comprobante"]), "' AND Fecha='"), text), "'"));
							Mod_ConeccionBD.BD_Sentencia(sQL11);
						}
						else
						{
							string sQL12 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("UPDATE Planchada SET Estado='DESPACHADO', Usuario='" + text2 + "' WHERE Comprobante= '", dataTable2.Rows[j]["Comprobante"]), "' AND Fecha='"), text), "'"));
							Mod_ConeccionBD.BD_Sentencia(sQL12);
						}
					}
					else if (Operators.ConditionalCompareObjectEqual(left, "ENVIOS DIGITALES S.A", TextCompare: true))
					{
						if (Operators.ConditionalCompareObjectEqual(dataTable2.Rows[j]["SUB"], "01", TextCompare: true))
						{
							string sQL13 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("UPDATE Planchada SET Estado='EN RECOLECCION', Usuario='" + text2 + "' WHERE Comprobante= '", dataTable2.Rows[j]["Comprobante"]), "' AND Fecha='"), text), "'"));
							Mod_ConeccionBD.BD_Sentencia(sQL13);
						}
						else
						{
							string sQL14 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("UPDATE Planchada SET Estado='DESPACHADO', Usuario='" + text2 + "' WHERE Comprobante= '", dataTable2.Rows[j]["Comprobante"]), "' AND Fecha='"), text), "'"));
							Mod_ConeccionBD.BD_Sentencia(sQL14);
						}
					}
					else if (Operators.ConditionalCompareObjectEqual(left, "TRANS GON S.R.L.", TextCompare: true))
					{
						if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(dataTable2.Rows[j]["SUB"], "01", TextCompare: true), Operators.CompareObjectEqual(dataTable2.Rows[j]["SUB"], "02", TextCompare: true))))
						{
							string sQL15 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("UPDATE Planchada SET Estado='EN RECOLECCION', Usuario='" + text2 + "' WHERE Comprobante= '", dataTable2.Rows[j]["Comprobante"]), "' AND Fecha='"), text), "'"));
							Mod_ConeccionBD.BD_Sentencia(sQL15);
						}
						else
						{
							string sQL16 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("UPDATE Planchada SET Estado='DESPACHADO', Usuario='" + text2 + "' WHERE Comprobante= '", dataTable2.Rows[j]["Comprobante"]), "' AND Fecha='"), text), "'"));
							Mod_ConeccionBD.BD_Sentencia(sQL16);
						}
					}
					else if (Operators.ConditionalCompareObjectEqual(left, "LANNOT S.A", TextCompare: true))
					{
						if (Operators.ConditionalCompareObjectEqual(dataTable2.Rows[j]["SUB"], "01", TextCompare: true))
						{
							string sQL17 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("UPDATE Planchada SET Estado='EN RECOLECCION', Usuario='" + text2 + "' WHERE Comprobante= '", dataTable2.Rows[j]["Comprobante"]), "' AND Fecha='"), text), "'"));
							Mod_ConeccionBD.BD_Sentencia(sQL17);
						}
						else
						{
							string sQL18 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("UPDATE Planchada SET Estado='DESPACHADO', Usuario='" + text2 + "' WHERE Comprobante= '", dataTable2.Rows[j]["Comprobante"]), "' AND Fecha='"), text), "'"));
							Mod_ConeccionBD.BD_Sentencia(sQL18);
						}
					}
					else
					{
						string sQL19 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("UPDATE Planchada SET Estado='DESPACHADO', Usuario='" + text2 + "' WHERE guia=", dataTable2.Rows[j]["guia"]), ""));
						Mod_ConeccionBD.BD_Sentencia(sQL19);
						int num3 = Conversions.ToInteger(Mod_logger.historialenter(Conversions.ToString(dataTable2.Rows[j]["Comprobante"]), " ", "DESPACHADO", Conversions.ToString(dataTable2.Rows[j]["Remitos"])));
					}
				}
				ListView1.CheckedItems[i].BackColor = Color.LimeGreen;
				result3 = 1;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception objExcepcion = ex;
				Logger.e("Error con excepción y traza", objExcepcion, new StackFrame(fNeedFileInfo: true));
				result3 = 0;
				ProjectData.ClearProjectError();
			}
			return result3;
		}
	}

	private void CheckBox1_CheckedChanged(object sender, EventArgs e)
	{
		checked
		{
			if (CheckBox1.Checked)
			{
				int num = ListView1.Items.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					ListView1.Items[i].Checked = true;
				}
			}
			else
			{
				int num2 = ListView1.Items.Count - 1;
				for (int j = 0; j <= num2; j++)
				{
					ListView1.Items[j].Checked = false;
				}
			}
		}
	}

	private void Button4_Click(object sender, EventArgs e)
	{
		if (Conversions.ToDouble(MySettingsProperty.Settings.Permiso) == 10.0)
		{
			create_excel_();
			Mod_Subir_FTP.subir_ftp();
		}
		else
		{
			Interaction.MsgBox("Proximamente");
		}
	}

	private void Button5_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void create_excel_()
	{
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Expected O, but got Unknown
		checked
		{
			try
			{
				string text = Strings.Format(MyProject.Forms.Form1_Inicio.DateTimePicker1.Value, "yyyyMMdd");
				string text2 = MyProject.Forms.Form1_Inicio.ComboBox1.Text;
				string destino = "Exportacion";
				if (ListView1.CheckedItems.Count > 0)
				{
					string text3 = ListView1.CheckedItems[0].Text;
					string text4 = "SELECT Numero FROM Flota WHERE Chofer='" + text3 + "'";
					DataTable dataTable = new DataTable("x");
					MySqlDataAdapter val = new MySqlDataAdapter(text4, Mod_Sentencias.cnn);
					((DbDataAdapter)(object)val).Fill(dataTable);
					string text5 = dataTable.Rows[0]["Numero"].ToString();
					string text6 = ("Select Eventual, Comprobante, cliente, remitos, destino, domicilio, cp, localidad, declarado, bultos, kilos, sub, observaciones, volumen, atraso, fecha, flete, zona, adicional, prioridad, chofer, latitud, longitud FROM planchada where fecha='" + text + "' AND Chofer=" + text5 + " AND Ventana=" + text2) ?? "";
					int num = ListView1.CheckedItems.Count - 1;
					for (int i = 1; i <= num; i++)
					{
						string text7 = ListView1.CheckedItems[i].Text;
						string text8 = "SELECT Numero FROM Flota WHERE Chofer='" + text7 + "'";
						DataTable dataTable2 = new DataTable("x");
						MySqlDataAdapter val2 = new MySqlDataAdapter(text8, Mod_Sentencias.cnn);
						((DbDataAdapter)(object)val2).Fill(dataTable2);
						string text9 = dataTable2.Rows[0]["Numero"].ToString();
						string text10 = ("UNION ALL Select Eventual, Comprobante, cliente, remitos, destino, domicilio, cp, localidad, declarado, bultos, kilos, sub, observaciones, volumen, atraso, fecha, flete, zona, adicional, prioridad, chofer, latitud, longitud FROM planchada where fecha='" + text + "' AND Chofer=" + text9 + " AND Ventana=" + text2) ?? "";
						text6 = text6 + " " + text10;
					}
					Mod_Exportar.exportar_excel(text6, destino);
				}
				else
				{
					Interaction.MsgBox("Seleccione una ruta");
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception objExcepcion = ex;
				Logger.e("Error con excepción y traza", objExcepcion, new StackFrame(fNeedFileInfo: true));
				ProjectData.ClearProjectError();
			}
		}
	}

	private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
	{
	}

	private object redespachar_ruta(string chofer_d, int i)
	{
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected O, but got Unknown
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected O, but got Unknown
		checked
		{
			object result3;
			try
			{
				string text = MyProject.Forms.Form1_Inicio.nombreusuario.Text;
				int num = Conversions.ToInteger(MyProject.Forms.Form1_Inicio.ComboBox1.Text);
				string text2 = Strings.Format(MyProject.Forms.Form1_Inicio.DateTimePicker1.Value, "yyyyMMdd");
				string text3 = "SELECT Numero FROM Flota WHERE Chofer='" + chofer_d + "'";
				DataTable dataTable = new DataTable("x");
				MySqlDataAdapter val = new MySqlDataAdapter(text3, Mod_Sentencias.cnn);
				((DbDataAdapter)(object)val).Fill(dataTable);
				string text4 = dataTable.Rows[0]["Numero"].ToString();
				string text5 = ("SELECT comprobante, estado, cliente, sub, remitos, guia FROM planchada WHERE Chofer=" + text4 + " and ventana =" + Conversions.ToString(num) + " and Fecha=" + text2) ?? "";
				DataTable dataTable2 = new DataTable("x");
				MySqlDataAdapter val2 = new MySqlDataAdapter(text5, Mod_Sentencias.cnn);
				((DbDataAdapter)(object)val2).Fill(dataTable2);
				int num2 = dataTable2.Rows.Count - 1;
				for (int j = 0; j <= num2; j++)
				{
					object left = dataTable2.Rows[j]["Cliente"];
					if (Operators.ConditionalCompareObjectEqual(left, "ETRANS", TextCompare: true))
					{
						if (Operators.ConditionalCompareObjectEqual(dataTable2.Rows[j]["SUB"], 11, TextCompare: true))
						{
							string sQL = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("UPDATE Planchada SET Estado='EN RECOLECCION', Usuario='" + text + "' WHERE Comprobante= '", dataTable2.Rows[j]["Comprobante"]), "' AND Fecha='"), text2), "'"));
							Mod_ConeccionBD.BD_Sentencia(sQL);
							string sQL2 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("UPDATE etransEnvios SET Estado='EN RECOLECCION' WHERE id_envio=", dataTable2.Rows[j]["Remitos"]), ""));
							Mod_ConeccionBD.BD_Sentencia(sQL2);
						}
						else
						{
							string sQL3 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("UPDATE Planchada SET Estado='DESPACHADO', Usuario='" + text + "' WHERE Comprobante= '", dataTable2.Rows[j]["Comprobante"]), "' AND Fecha='"), text2), "'"));
							Mod_ConeccionBD.BD_Sentencia(sQL3);
							string sQL4 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("UPDATE etransEnvios SET Estado='DESPACHADO' WHERE id_envio=", dataTable2.Rows[j]["Remitos"]), ""));
							Mod_ConeccionBD.BD_Sentencia(sQL4);
						}
					}
					else if (Operators.ConditionalCompareObjectEqual(left, "DABRA SOCIEDAD ANONIMA", TextCompare: true))
					{
						if (Operators.ConditionalCompareObjectEqual(dataTable2.Rows[j]["SUB"], "01", TextCompare: true))
						{
							string sQL5 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("UPDATE Planchada SET Estado='EN RECOLECCION', Usuario='" + text + "' WHERE Comprobante= '", dataTable2.Rows[j]["Comprobante"]), "' AND Fecha='"), text2), "'"));
							Mod_ConeccionBD.BD_Sentencia(sQL5);
							if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(dataTable2.Rows[j]["SUB"], "10", TextCompare: true), int.TryParse(Conversions.ToString(dataTable2.Rows[j]["remitos"]), out var _))))
							{
								Mod_ecommerce.CambiarEstados(Conversions.ToInteger(dataTable2.Rows[j]["remitos"]), 4);
							}
						}
						else
						{
							string sQL6 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("UPDATE Planchada SET Estado='DESPACHADO', Usuario='" + text + "' WHERE Comprobante= '", dataTable2.Rows[j]["Comprobante"]), "' AND Fecha='"), text2), "'"));
							Mod_ConeccionBD.BD_Sentencia(sQL6);
							if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(dataTable2.Rows[j]["SUB"], "10", TextCompare: true), int.TryParse(Conversions.ToString(dataTable2.Rows[j]["remitos"]), out var _))))
							{
								Mod_ecommerce.CambiarEstados(Conversions.ToInteger(dataTable2.Rows[j]["remitos"]), 4);
							}
						}
					}
					else if (Operators.ConditionalCompareObjectEqual(left, "LAS BLONDAS S.A", TextCompare: true))
					{
						if (Operators.ConditionalCompareObjectEqual(dataTable2.Rows[j]["SUB"], "01", TextCompare: true))
						{
							string sQL7 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("UPDATE Planchada SET Estado='EN RECOLECCION', Usuario='" + text + "' WHERE Comprobante= '", dataTable2.Rows[j]["Comprobante"]), "' AND Fecha='"), text2), "'"));
							Mod_ConeccionBD.BD_Sentencia(sQL7);
						}
						else
						{
							string sQL8 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("UPDATE Planchada SET Estado='DESPACHADO', Usuario='" + text + "' WHERE Comprobante= '", dataTable2.Rows[j]["Comprobante"]), "' AND Fecha='"), text2), "'"));
							Mod_ConeccionBD.BD_Sentencia(sQL8);
						}
					}
					else if (Operators.ConditionalCompareObjectEqual(left, "TISCH S.R.L. (MISHKA)", TextCompare: true))
					{
						if (Operators.ConditionalCompareObjectEqual(dataTable2.Rows[j]["SUB"], "01", TextCompare: true))
						{
							string sQL9 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("UPDATE Planchada SET Estado='EN RECOLECCION', Usuario='" + text + "' WHERE Comprobante= '", dataTable2.Rows[j]["Comprobante"]), "' AND Fecha='"), text2), "'"));
							Mod_ConeccionBD.BD_Sentencia(sQL9);
						}
						else
						{
							string sQL10 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("UPDATE Planchada SET Estado='DESPACHADO', Usuario='" + text + "' WHERE Comprobante= '", dataTable2.Rows[j]["Comprobante"]), "' AND Fecha='"), text2), "'"));
							Mod_ConeccionBD.BD_Sentencia(sQL10);
						}
					}
					else if (Operators.ConditionalCompareObjectEqual(left, "GAX S.A. (PRUNE)", TextCompare: true))
					{
						if (Operators.ConditionalCompareObjectEqual(dataTable2.Rows[j]["SUB"], "01", TextCompare: true))
						{
							string sQL11 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("UPDATE Planchada SET Estado='EN RECOLECCION', Usuario='" + text + "' WHERE Comprobante= '", dataTable2.Rows[j]["Comprobante"]), "' AND Fecha='"), text2), "'"));
							Mod_ConeccionBD.BD_Sentencia(sQL11);
						}
						else
						{
							string sQL12 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("UPDATE Planchada SET Estado='DESPACHADO', Usuario='" + text + "' WHERE Comprobante= '", dataTable2.Rows[j]["Comprobante"]), "' AND Fecha='"), text2), "'"));
							Mod_ConeccionBD.BD_Sentencia(sQL12);
						}
					}
					else if (Operators.ConditionalCompareObjectEqual(left, "ENVIOS DIGITALES S.A", TextCompare: true))
					{
						if (Operators.ConditionalCompareObjectEqual(dataTable2.Rows[j]["SUB"], "01", TextCompare: true))
						{
							string sQL13 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("UPDATE Planchada SET Estado='EN RECOLECCION', Usuario='" + text + "' WHERE Comprobante= '", dataTable2.Rows[j]["Comprobante"]), "' AND Fecha='"), text2), "'"));
							Mod_ConeccionBD.BD_Sentencia(sQL13);
						}
						else
						{
							string sQL14 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("UPDATE Planchada SET Estado='DESPACHADO', Usuario='" + text + "' WHERE Comprobante= '", dataTable2.Rows[j]["Comprobante"]), "' AND Fecha='"), text2), "'"));
							Mod_ConeccionBD.BD_Sentencia(sQL14);
						}
					}
					else if (Operators.ConditionalCompareObjectEqual(left, "TRANS GON S.R.L.", TextCompare: true))
					{
						if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(dataTable2.Rows[j]["SUB"], "01", TextCompare: true), Operators.CompareObjectEqual(dataTable2.Rows[j]["SUB"], "02", TextCompare: true))))
						{
							string sQL15 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("UPDATE Planchada SET Estado='EN RECOLECCION', Usuario='" + text + "' WHERE Comprobante= '", dataTable2.Rows[j]["Comprobante"]), "' AND Fecha='"), text2), "'"));
							Mod_ConeccionBD.BD_Sentencia(sQL15);
						}
						else
						{
							string sQL16 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("UPDATE Planchada SET Estado='DESPACHADO', Usuario='" + text + "' WHERE Comprobante= '", dataTable2.Rows[j]["Comprobante"]), "' AND Fecha='"), text2), "'"));
							Mod_ConeccionBD.BD_Sentencia(sQL16);
						}
					}
					else if (Operators.ConditionalCompareObjectEqual(left, "LANNOT S.A", TextCompare: true))
					{
						if (Operators.ConditionalCompareObjectEqual(dataTable2.Rows[j]["SUB"], "01", TextCompare: true))
						{
							string sQL17 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("UPDATE Planchada SET Estado='EN RECOLECCION', Usuario='" + text + "' WHERE Comprobante= '", dataTable2.Rows[j]["Comprobante"]), "' AND Fecha='"), text2), "'"));
							Mod_ConeccionBD.BD_Sentencia(sQL17);
						}
						else
						{
							string sQL18 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("UPDATE Planchada SET Estado='DESPACHADO', Usuario='" + text + "' WHERE Comprobante= '", dataTable2.Rows[j]["Comprobante"]), "' AND Fecha='"), text2), "'"));
							Mod_ConeccionBD.BD_Sentencia(sQL18);
						}
					}
					else
					{
						string sQL19 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("UPDATE Planchada SET Estado='DESPACHADO', Usuario='" + text + "' WHERE guia=", dataTable2.Rows[j]["guia"]), ""));
						Mod_ConeccionBD.BD_Sentencia(sQL19);
						int num3 = Conversions.ToInteger(Mod_logger.historialenter(Conversions.ToString(dataTable2.Rows[j]["Comprobante"]), " ", "DESPACHADO", Conversions.ToString(dataTable2.Rows[j]["Remitos"])));
					}
				}
				ListView1.CheckedItems[i].BackColor = Color.LimeGreen;
				result3 = 1;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception objExcepcion = ex;
				Logger.e("Error con excepción y traza", objExcepcion, new StackFrame(fNeedFileInfo: true));
				result3 = 0;
				ProjectData.ClearProjectError();
			}
			return result3;
		}
	}

	private void Despachos_Load(object sender, EventArgs e)
	{
		if (Conversions.ToDouble(MySettingsProperty.Settings.Permiso) > 7.0)
		{
			CheckBox2.Enabled = true;
		}
	}
}
