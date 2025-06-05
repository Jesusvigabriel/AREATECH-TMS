using System;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace Hermes;

[StandardModule]
internal sealed class Mod_Funciones
{
	public static void agregar_campo()
	{
		try
		{
			string sQL = "ALTER TABLE planchada ADD guia INT UNSIGNED NOT NULL AUTO_INCREMENT,ADD INDEX (guia)";
			Mod_ConeccionBD.BD_Sentencia(sQL);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox(ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	public static object contar_(string sql)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		int num = 0;
		try
		{
			DataTable dataTable = new DataTable("x");
			MySqlDataAdapter val = new MySqlDataAdapter(sql, Mod_Sentencias.cnn);
			((DbDataAdapter)(object)val).Fill(dataTable);
			int num2 = Conversions.ToInteger(dataTable.Rows[0]["total"]);
			num = num2;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Logger.e("Error con excepción y traza", ex2, new StackFrame(fNeedFileInfo: true));
			Interaction.MsgBox(ex2.Message);
			ProjectData.ClearProjectError();
		}
		return num;
	}

	public static ListViewItem FindItem(ListView.ListViewItemCollection ItemList, int ColumnIndex, string SearchString)
	{
		foreach (ListViewItem Item in ItemList)
		{
			if (Operators.CompareString(Item.SubItems[ColumnIndex].Text, SearchString, TextCompare: true) == 0)
			{
				return Item;
			}
		}
		return null;
	}
}
