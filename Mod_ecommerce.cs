using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace Hermes;

[StandardModule]
internal sealed class Mod_ecommerce
{
	public static object ObtenerRetiros(int empresa)
	{
		string sql = "Select e.id, r.numero, r.bultos, d.nombre FROM envios e LEFT JOIN remitos_envios r ON r.envio = e.id LEFT JOIN destinos_eventuales d ON d.id = e.eventual WHERE e.estado = 1 AND e.empresa = " + Conversions.ToString(empresa);
		return (DataTable)Mod_Sentencias.data(sql);
	}

	public static object ObtenerEmpresasRetiro()
	{
		List<Mod_empresas.EmpresasStructure> list = new List<Mod_empresas.EmpresasStructure>();
		string sql = "SELECT DISTINCT e.empresa FROM envios e WHERE e.estado = 1";
		DataTable dataTable = (DataTable)Mod_Sentencias.data(sql);
		checked
		{
			if (dataTable.Rows.Count > 0)
			{
				int num = dataTable.Rows.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					Mod_empresas.EmpresasStructure item = default(Mod_empresas.EmpresasStructure);
					item.idempresa = Conversions.ToInteger(dataTable.Rows[i]["empresa"]);
					list.Add(item);
				}
			}
			return list;
		}
	}

	public static object GenerarRetiroEnvios(int empresa)
	{
		string sql = "SELECT \r\n\t\t\t\te.id,\r\n\t\t\t\te.empresa,  \r\n\t\t\t\te.id as REMITO,\r\n\t\t\t\te.fecha as FECHA,\r\n\t\t\t\td.nombre as RS1_DEST,\r\n\t\t\t\td.direccion as DOM_DEST,\r\n\t\t\t\td.postal as LOC_DEST,\r\n\t\t\t\tr.kilos as KILOS, \r\n\t\t\t\tr.bultos as BULTOS, \r\n\t\t\t\tr.volumen as MT3, \r\n\t\t\t\tr.valor as VALOR_DECL, \r\n\t\t\t\tr.numero as OBSERV  \r\n\t\t\tFROM \r\n\t\t\t\tenvios e  \r\n\t\t\tLEFT JOIN \r\n\t\t\t\tremitos_envios r \r\n\t\t\tON \r\n\t\t\t\tr.envio = e.id \r\n\t\t\tLEFT JOIN\r\n\t\t\t\tdestinos_eventuales d\r\n\t\t\tON\r\n\t\t\t\td.id = e.eventual\r\n\t\t\tWHERE \r\n\t\t\t\te.estado = 1 AND e.empresa = " + Conversions.ToString(empresa);
		DataTable dataTable = (DataTable)Mod_Sentencias.data(sql);
		if (dataTable.Rows.Count > 0)
		{
		}
		return dataTable;
	}

	public static object ContarRetiroEnvios(int empresa)
	{
		string sql = "Select e.id FROM envios e WHERE e.estado=1 And e.empresa =" + Conversions.ToString(empresa);
		DataTable dataTable = (DataTable)Mod_Sentencias.data(sql);
		if (dataTable.Rows.Count > 0)
		{
		}
		return dataTable.Rows.Count;
	}

	public static object ObtenerEnvios()
	{
		return true;
	}

	public static object CambiarEstados(int id, int estado)
	{
		bool flag = false;
		try
		{
			string sQL = "UPDATE envios Set estado=" + Conversions.ToString(estado) + " WHERE id =" + Conversions.ToString(id);
			int num = Conversions.ToInteger(Mod_ConeccionBD.BD_Sentencia(sQL));
			if (num == 1)
			{
				flag = true;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		return flag;
	}

	public static object ObtenerIdWithRemito(string remito)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		string text = "Select envio FROM remitos_envios WHERE numero = '" + remito + "'";
		int num = 0;
		try
		{
			DataTable dataTable = new DataTable("x");
			MySqlDataAdapter val = new MySqlDataAdapter(text, Mod_Sentencias.cnn);
			DataSet dataSet = new DataSet();
			((DbDataAdapter)(object)val).Fill(dataTable);
			num = Conversions.ToInteger(NewLateBinding.LateGet(dataTable.Rows[0][0], null, "text", new object[0], null, null, null));
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		return num;
	}
}
