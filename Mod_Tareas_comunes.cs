using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace Hermes;

[StandardModule]
internal sealed class Mod_Tareas_comunes
{
	public static void selected_items_2(ListView listv, Label idtxt, Label sitem1txt, Label sitem2txt, Label sitem3txt, Label sitem4txt, Label sitem5txt, Label sitem6txt, Label sitem7txt, Label sitem8txt, Label sitem9txt)
	{
		if (listv.SelectedItems.Count > 0)
		{
			int index = listv.SelectedIndices[0];
			idtxt.Text = listv.Items[index].Text;
			sitem1txt.Text = listv.Items[index].SubItems[1].Text;
			sitem2txt.Text = listv.Items[index].SubItems[2].Text;
			sitem3txt.Text = listv.Items[index].SubItems[3].Text;
			sitem4txt.Text = listv.Items[index].SubItems[4].Text;
			sitem5txt.Text = listv.Items[index].SubItems[5].Text;
			sitem6txt.Text = listv.Items[index].SubItems[6].Text;
			sitem7txt.Text = listv.Items[index].SubItems[7].Text;
			sitem8txt.Text = listv.Items[index].SubItems[8].Text;
			sitem9txt.Text = listv.Items[index].SubItems[9].Text;
		}
		listv.Refresh();
	}

	public static void lista_de_tablas(ComboBox combo)
	{
		combo.Items.Clear();
		combo.Items.Add("Adicionales");
		combo.Items.Add("Categorias");
		combo.Items.Add("Choferes");
		combo.Items.Add("Contactos");
		combo.Items.Add("Clientes");
		combo.Items.Add("Chat");
		combo.Items.Add("CSV");
		combo.Items.Add("Equipos");
		combo.Items.Add("Dibujos");
		combo.Items.Add("Direccion");
		combo.Items.Add("Eventuales");
		combo.Items.Add("Estados");
		combo.Items.Add("Empresas");
		combo.Items.Add("estadoEnvio");
		combo.Items.Add("etransEnvios");
		combo.Items.Add("feriados");
		combo.Items.Add("Flota");
		combo.Items.Add("Historial");
		combo.Items.Add("IVA");
		combo.Items.Add("Localidades");
		combo.Items.Add("Logg");
		combo.Items.Add("Novedades");
		combo.Items.Add("Planchada");
		combo.Items.Add("Planificado");
		combo.Items.Add("Recepcion");
		combo.Items.Add("Retiros");
		combo.Items.Add("Seguro");
		combo.Items.Add("Tarifas");
		combo.Items.Add("Viajes");
		combo.Items.Add("Vehiculos");
		combo.Items.Add("Usuarios");
		combo.Items.Add("Zonas");
	}

	public static void lv_de_tablas(ListView combo)
	{
		combo.Items.Clear();
		combo.Items.Add("Adicionales");
		combo.Items.Add("Categorias");
		combo.Items.Add("Choferes");
		combo.Items.Add("Contactos");
		combo.Items.Add("Clientes");
		combo.Items.Add("Chat");
		combo.Items.Add("CSV");
		combo.Items.Add("Equipos");
		combo.Items.Add("Dibujos");
		combo.Items.Add("Direccion");
		combo.Items.Add("Eventuales");
		combo.Items.Add("Estados");
		combo.Items.Add("Empresas");
		combo.Items.Add("estadoEnvio");
		combo.Items.Add("etransEnvios");
		combo.Items.Add("feriados");
		combo.Items.Add("Flota");
		combo.Items.Add("Historial");
		combo.Items.Add("IVA");
		combo.Items.Add("Localidades");
		combo.Items.Add("Logg");
		combo.Items.Add("Novedades");
		combo.Items.Add("Planchada");
		combo.Items.Add("Planificado");
		combo.Items.Add("Recepcion");
		combo.Items.Add("Retiros");
		combo.Items.Add("Seguro");
		combo.Items.Add("Tarifas");
		combo.Items.Add("Viajes");
		combo.Items.Add("Vehiculos");
		combo.Items.Add("Usuarios");
		combo.Items.Add("Zonas");
	}

	public static object choferes_a_combo(ComboBox Combo)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected O, but got Unknown
		bool flag = false;
		try
		{
			DataTable dataTable = new DataTable("x");
			string text = "SELECT Chofer FROM Flota where Disponible='Si' and Estado='Activo' ORDER BY Chofer";
			MySqlDataAdapter val = new MySqlDataAdapter(text, Mod_Sentencias.cnn);
			DataSet dataSet = new DataSet();
			((DbDataAdapter)(object)val).Fill(dataSet, "tabla");
			Combo.Items.Clear();
			DataTable dataTable2 = dataSet.Tables["tabla"];
			foreach (DataRow row in dataTable2.Rows)
			{
				Combo.Items.Add(RuntimeHelpers.GetObjectValue(row["Chofer"]));
			}
			Combo.DropDownStyle = ComboBoxStyle.DropDownList;
			flag = true;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox(ex2.Message);
			ProjectData.ClearProjectError();
		}
		return flag;
	}

	public static object flota_a_combo(ComboBox Combo)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected O, but got Unknown
		bool flag = false;
		try
		{
			DataTable dataTable = new DataTable("x");
			string text = "SELECT Chofer FROM Flota where Estado='Activo' ORDER BY Chofer";
			MySqlDataAdapter val = new MySqlDataAdapter(text, Mod_Sentencias.cnn);
			DataSet dataSet = new DataSet();
			((DbDataAdapter)(object)val).Fill(dataSet, "tabla");
			Combo.Items.Clear();
			DataTable dataTable2 = dataSet.Tables["tabla"];
			foreach (DataRow row in dataTable2.Rows)
			{
				Combo.Items.Add(RuntimeHelpers.GetObjectValue(row["Chofer"]));
			}
			Combo.DropDownStyle = ComboBoxStyle.DropDownList;
			flag = true;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox(ex2.Message);
			ProjectData.ClearProjectError();
		}
		return flag;
	}

	public static object FillMyCombo(string sql, ComboBox combobox)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		int num = 0;
		try
		{
			DataTable dataTable = new DataTable("x");
			MySqlDataAdapter val = new MySqlDataAdapter(sql, Mod_Sentencias.cnn);
			((DbDataAdapter)(object)val).Fill(dataTable);
			if (dataTable.Rows.Count > 0)
			{
				combobox.SelectedIndex = -1;
				Dictionary<string, string> dictionary = new Dictionary<string, string>();
				foreach (DataRow row in dataTable.Rows)
				{
					dictionary.Add(row[1].ToString(), Conversions.ToString(row[0]));
				}
				combobox.DataSource = new BindingSource(dictionary, null);
				combobox.DisplayMember = "Value";
				combobox.ValueMember = "Key";
				combobox.SelectedIndex = -1;
			}
			else
			{
				combobox.DataSource = null;
				combobox.Items.Clear();
				combobox.SelectedIndex = -1;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			num = 1;
			Interaction.MsgBox("Ocurrio un error al recuperar datos. " + ex2.Message);
			ProjectData.ClearProjectError();
		}
		return num;
	}
}
