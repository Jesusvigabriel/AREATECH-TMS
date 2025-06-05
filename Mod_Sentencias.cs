using System;
using System.Collections.Generic;
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

[StandardModule]
internal sealed class Mod_Sentencias
{
	private static string ip = "datos.area54sa.com.ar";

	public static string baseDD = "hermes";

	public static string pass = "A54MySQL";

	public static string user = "logiciel";

	public static bool etransActiva = false;

	private static string ruta = "Data Source=" + ip + ";Database=" + baseDD + ";Uid=" + user + ";Password=" + pass;

	public static int versionActual = 2;

	public static MySqlConnection cnn { get; set; } = new MySqlConnection(ruta);


	public static void cargar_datos_lv(ListView listview1, string sql, Label contador)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		checked
		{
			try
			{
				cnn.Open();
				MySqlCommand val = new MySqlCommand();
				MySqlCommand val2 = val;
				val2.CommandType = CommandType.Text;
				val2.CommandText = sql;
				val2.Connection = cnn;
				val2 = null;
				MySqlDataAdapter val3 = new MySqlDataAdapter();
				DataSet dataSet = new DataSet();
				val3.SelectCommand = val;
				((DbDataAdapter)(object)val3).Fill(dataSet, "Tabla");
				ListView listView = listview1;
				listView.Items.Clear();
				listView.View = View.Details;
				listView.GridLines = true;
				listView.FullRowSelect = true;
				listView.MultiSelect = false;
				listView.LabelEdit = false;
				listView.HideSelection = false;
				listView = null;
				DataTable dataTable = dataSet.Tables["tabla"];
				int num = dataTable.Rows.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					ListViewItem listViewItem = new ListViewItem(dataTable.Rows[i][0].ToString());
					int num2 = dataTable.Columns.Count - 1;
					for (int j = 1; j <= num2; j++)
					{
						listViewItem.SubItems.Add(dataTable.Rows[i][j].ToString());
					}
					listview1.Items.Add(listViewItem);
					if (i == 0)
					{
					}
				}
				dataTable = null;
				cnn.Close();
				contador.Text = Conversions.ToString(dataSet.Tables["tabla"].Rows.Count);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				cnn.Close();
				Interaction.MsgBox(ex2.Message);
				ProjectData.ClearProjectError();
			}
		}
	}

	public static void cargar_datos_lv_completa(ListView listview1, string sql, Label contador)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		checked
		{
			try
			{
				cnn.Open();
				MySqlCommand val = new MySqlCommand();
				MySqlCommand val2 = val;
				val2.CommandType = CommandType.Text;
				val2.CommandText = sql;
				val2.Connection = cnn;
				val2 = null;
				MySqlDataAdapter val3 = new MySqlDataAdapter();
				DataSet dataSet = new DataSet();
				val3.SelectCommand = val;
				((DbDataAdapter)(object)val3).Fill(dataSet, "Tabla");
				ListView listView = listview1;
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
					listview1.Items.Add(listViewItem);
					if (j == 0)
					{
					}
				}
				dataTable = null;
				cnn.Close();
				contador.Text = Conversions.ToString(listview1.Items.Count);
				listview1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				cnn.Close();
				Interaction.MsgBox(ex2.Message);
				ProjectData.ClearProjectError();
			}
		}
	}

	public static void cargar_zonas_combo(ComboBox cbb)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		try
		{
			DataTable dataTable = new DataTable("x");
			string text = "SELECT * FROM Zonas order by Zona";
			MySqlDataAdapter val = new MySqlDataAdapter(text, cnn);
			DataSet dataSet = new DataSet();
			((DbDataAdapter)(object)val).Fill(dataSet, "tabla");
			cbb.Items.Clear();
			DataTable dataTable2 = dataSet.Tables["tabla"];
			foreach (DataRow row in dataTable2.Rows)
			{
				cbb.Items.Add(RuntimeHelpers.GetObjectValue(row["Descripcion"]));
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

	public static void contar_items(string sql, Label contador)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		try
		{
			DataTable dataTable = new DataTable("x");
			MySqlDataAdapter val = new MySqlDataAdapter(sql, cnn);
			((DbDataAdapter)(object)val).Fill(dataTable);
			contador.Text = Conversions.ToString(dataTable.Rows.Count);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Logger.e("Error con excepción y traza", ex2, new StackFrame(fNeedFileInfo: true));
			Interaction.MsgBox(ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	public static void cargar_datos_combo(string sql, ComboBox combobox1)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		checked
		{
			try
			{
				cnn.Open();
				MySqlCommand val = new MySqlCommand();
				MySqlCommand val2 = val;
				val2.CommandType = CommandType.Text;
				val2.CommandText = sql;
				val2.Connection = cnn;
				val2 = null;
				MySqlDataAdapter val3 = new MySqlDataAdapter();
				DataSet dataSet = new DataSet();
				val3.SelectCommand = val;
				((DbDataAdapter)(object)val3).Fill(dataSet, "Tabla");
				ComboBox comboBox = combobox1;
				int num = dataSet.Tables["tabla"].Columns.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					comboBox.Items.Add(dataSet.Tables["tabla"].Columns[i].Caption);
				}
				comboBox = null;
				cnn.Close();
				if (combobox1.Items.Count > 1)
				{
					combobox1.SelectedIndex = 1;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Logger.e(ex2.Message + " - FUNCION: cargar_datos_combo");
				Interaction.MsgBox(ex2.Message);
				ProjectData.ClearProjectError();
			}
		}
	}

	public static void cargar_eventuales_combo(string sql, ComboBox cbb, Label contador)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		try
		{
			DataTable dataTable = new DataTable("x");
			MySqlDataAdapter val = new MySqlDataAdapter(sql, cnn);
			DataSet dataSet = new DataSet();
			((DbDataAdapter)(object)val).Fill(dataSet, "tabla");
			cbb.Items.Clear();
			DataTable dataTable2 = dataSet.Tables["tabla"];
			foreach (DataRow row in dataTable2.Rows)
			{
				cbb.Items.Add(RuntimeHelpers.GetObjectValue(row["Eventual"]));
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Logger.e(ex2.Message + " - FUNCION: cargar_eventuales_combo");
			Interaction.MsgBox(ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	public static void cargar_cbb(ComboBox cbb, string sql)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		DataTable dataTable = new DataTable("x");
		MySqlDataAdapter val = new MySqlDataAdapter(sql, cnn);
		DataSet dataSet = new DataSet();
		((DbDataAdapter)(object)val).Fill(dataSet, "tabla");
		cbb.Items.Clear();
		DataTable dataTable2 = dataSet.Tables["tabla"];
		foreach (DataRow row in dataTable2.Rows)
		{
			cbb.Items.Add(RuntimeHelpers.GetObjectValue(row[0]));
		}
	}

	public static void sentecia_mysql_completa(ListView listview1, Label contador, string Campo, string Tabla)
	{
		string sql = ("SELECT " + Campo + " FROM " + Tabla) ?? "";
		cargar_datos_lv(listview1, sql, contador);
	}

	public static void cargar_lv_etrans(ListView listview1, string sql, Label contador)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		checked
		{
			try
			{
				cnn.Open();
				MySqlCommand val = new MySqlCommand();
				MySqlCommand val2 = val;
				val2.CommandType = CommandType.Text;
				val2.CommandText = sql;
				val2.Connection = cnn;
				val2 = null;
				MySqlDataAdapter val3 = new MySqlDataAdapter();
				DataSet dataSet = new DataSet();
				val3.SelectCommand = val;
				((DbDataAdapter)(object)val3).Fill(dataSet, "Tabla");
				ListView listView = listview1;
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
					listview1.Items.Add(listViewItem);
					int num4 = listview1.Items.Count - 1;
					for (int l = 0; l <= num4; l++)
					{
						if (Operators.CompareString(listview1.Items[l].SubItems[1].Text, "NO ENTREGADO", TextCompare: true) == 0)
						{
							listview1.Items[l].ForeColor = Color.Red;
						}
						if (Operators.CompareString(listview1.Items[l].SubItems[1].Text, "NO RECOLECTADO", TextCompare: true) == 0)
						{
							listview1.Items[l].ForeColor = Color.Red;
						}
						if (Operators.CompareString(listview1.Items[l].SubItems[1].Text, "A REPROGRAMAR", TextCompare: true) == 0)
						{
							listview1.Items[l].ForeColor = Color.Red;
						}
						if (Operators.CompareString(listview1.Items[l].SubItems[1].Text, "ENTREGADO", TextCompare: true) == 0)
						{
							listview1.Items[l].ForeColor = Color.Green;
						}
						if (Operators.CompareString(listview1.Items[l].SubItems[1].Text, "RECOLECTADO", TextCompare: true) == 0)
						{
							listview1.Items[l].ForeColor = Color.Green;
						}
						if (Operators.CompareString(listview1.Items[l].SubItems[1].Text, "EN CD", TextCompare: true) == 0)
						{
							listview1.Items[l].ForeColor = Color.Green;
						}
						if (Operators.CompareString(listview1.Items[l].SubItems[1].Text, "PARCIAL", TextCompare: true) == 0)
						{
							listview1.Items[l].ForeColor = Color.Orange;
						}
						if (Operators.CompareString(listview1.Items[l].SubItems[1].Text, "CADUCADO", TextCompare: true) == 0)
						{
							listview1.Items[l].ForeColor = Color.OrangeRed;
						}
						if (Operators.CompareString(listview1.Items[l].SubItems[1].Text, "CADUCADO", TextCompare: true) == 0)
						{
							listview1.Items[l].ForeColor = Color.OrangeRed;
						}
						if (Operators.CompareString(listview1.Items[l].SubItems[1].Text, "DESCARTADO", TextCompare: true) == 0)
						{
							listview1.Items[l].ForeColor = Color.OrangeRed;
						}
					}
				}
				dataTable = null;
				cnn.Close();
				contador.Text = Conversions.ToString(listview1.Items.Count);
				listview1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Logger.e(ex2.Message + " - FUNCION: cargar_lv_etrans");
				cnn.Close();
				Interaction.MsgBox(ex2.Message);
				ProjectData.ClearProjectError();
			}
		}
	}

	public static object data(string sql)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		DataTable dataTable = new DataTable("x");
		object result;
		try
		{
			MySqlDataAdapter val = new MySqlDataAdapter(sql, cnn);
			DataSet dataSet = new DataSet();
			((DbDataAdapter)(object)val).Fill(dataTable);
			result = dataTable;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Logger.e(ex2.Message + " - FUNCION: data");
			result = dataTable;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static object dataValue(string sql, string campo)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		object result;
		try
		{
			DataTable dataTable = new DataTable("x");
			MySqlDataAdapter val = new MySqlDataAdapter(sql, cnn);
			DataSet dataSet = new DataSet();
			((DbDataAdapter)(object)val).Fill(dataTable);
			result = dataTable.Rows[0][campo];
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Logger.e(ex2.Message + " - FUNCION: dataValue");
			result = 0;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static object update_sql(string tabla, List<KeyValuePair<string, string>> variables, List<KeyValuePair<string, string>> where)
	{
		string text = "UPDATE '" + tabla + "' SET ";
		string text2 = "";
		string text3 = "";
		foreach (KeyValuePair<string, string> variable in variables)
		{
			if (Operators.CompareString(variable.Value, "", TextCompare: true) != 0)
			{
				text2 = "'" + variable.Key + "' = '" + variable.Value + "',";
			}
		}
		text2 = Strings.Mid(text2, 1, checked(Strings.Len(text2) - 1));
		foreach (KeyValuePair<string, string> item in where)
		{
			if (Operators.CompareString(item.Value, "", TextCompare: true) != 0)
			{
				text3 = "'" + item.Key + "' = '" + item.Value + "',";
			}
		}
		return text + " " + text2 + " WHERE " + text3;
	}

	public static object fillcbb(ComboBox Combobox3, string sql)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		try
		{
			DataTable dataTable = new DataTable("x");
			MySqlDataAdapter val = new MySqlDataAdapter(sql, cnn);
			((DbDataAdapter)(object)val).Fill(dataTable);
			if (dataTable.Rows.Count > 0)
			{
				Combobox3.SelectedIndex = -1;
				Dictionary<string, string> dictionary = new Dictionary<string, string>();
				foreach (DataRow row in dataTable.Rows)
				{
					dictionary.Add(row[1].ToString(), Conversions.ToString(row[0]));
				}
				Combobox3.DataSource = new BindingSource(dictionary, null);
				Combobox3.DisplayMember = "Value";
				Combobox3.ValueMember = "Key";
				Combobox3.SelectedIndex = -1;
			}
			else
			{
				Combobox3.DataSource = null;
				Combobox3.Items.Clear();
				Combobox3.SelectedIndex = -1;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox("Ocurrio un error al recuperar datos. " + ex2.Message);
			ProjectData.ClearProjectError();
		}
		return null;
	}
}
