using System;
using System.Data;
using System.Data.Common;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace Hermes;

[StandardModule]
internal sealed class Mod_Recepcion
{
	public struct data_envio
	{
		public string e_codigo_postal;

		public string e_estado;

		public int e_bultos;

		public string e_observation;

		public string e_zona;
	}

	public static object bultosActuales(int guia)
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		int num = 0;
		try
		{
			DataTable dataTable = new DataTable("x1");
			string text = "Select BultosRecep From Recepcion WHERE guia='" + Conversions.ToString(guia) + "'";
			MySqlDataAdapter val = new MySqlDataAdapter(text, Mod_Sentencias.cnn);
			DataSet dataSet = new DataSet();
			((DbDataAdapter)(object)val).Fill(dataTable);
			num = Conversions.ToInteger(dataTable.Rows[0]["BultosRecep"]);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		return num;
	}

	public static object bultosActuales2(int id_envio, string fechaRecepcion)
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		int num = 0;
		try
		{
			DataTable dataTable = new DataTable("x1");
			string text = "Select BultosRecep From Recepcion WHERE id_envio='" + Conversions.ToString(id_envio) + "' and fecha='" + fechaRecepcion + "'";
			MySqlDataAdapter val = new MySqlDataAdapter(text, Mod_Sentencias.cnn);
			DataSet dataSet = new DataSet();
			((DbDataAdapter)(object)val).Fill(dataTable);
			num = Conversions.ToInteger(dataTable.Rows[0]["BultosRecep"]);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		return num;
	}

	public static object bultosTotal(int guia)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		int num = 0;
		DataTable dataTable = new DataTable("x1");
		string text = "Select Bultos From planchada WHERE guia='" + Conversions.ToString(guia) + "'";
		MySqlDataAdapter val = new MySqlDataAdapter(text, Mod_Sentencias.cnn);
		DataSet dataSet = new DataSet();
		((DbDataAdapter)(object)val).Fill(dataTable);
		num = Conversions.ToInteger(dataTable.Rows[0]["Bultos"]);
		return num;
	}

	public static object estadoAnterior(int id_envio)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		string text = "SELECT estado FROM etransEnvios WHERE id_envio=" + Conversions.ToString(id_envio);
		DataTable dataTable = new DataTable("x");
		MySqlDataAdapter val = new MySqlDataAdapter(text, Mod_Sentencias.cnn);
		((DbDataAdapter)(object)val).Fill(dataTable);
		return Conversions.ToString(dataTable.Rows[0]["estado"]);
	}

	public static object fechaEntrega(int id_envio)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		string text = "SELECT D_fecha FROM etransEnvios WHERE id_envio=" + Conversions.ToString(id_envio);
		DataTable dataTable = new DataTable("x");
		MySqlDataAdapter val = new MySqlDataAdapter(text, Mod_Sentencias.cnn);
		((DbDataAdapter)(object)val).Fill(dataTable);
		return Conversions.ToString(dataTable.Rows[0]["D_fecha"]);
	}

	public static object vecesEnCD(int id_envio)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		int num = 0;
		string text = "select count(comprobante) as veces from planchada where estado='EN CD' and chofer>0 and sub<11 and comprobante='" + Conversions.ToString(id_envio) + "' group by domicilio order by fecha desc";
		DataTable dataTable = new DataTable("x");
		MySqlDataAdapter val = new MySqlDataAdapter(text, Mod_Sentencias.cnn);
		((DbDataAdapter)(object)val).Fill(dataTable);
		try
		{
			num = Conversions.ToInteger(dataTable.Rows[0]["veces"]);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			num = 0;
			ProjectData.ClearProjectError();
		}
		return num;
	}

	private static object buscar_datos_envio(int envio)
	{
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected O, but got Unknown
		data_envio data_envio = default(data_envio);
		DataTable dataTable = new DataTable("dt1");
		DataTable dataTable2 = new DataTable("dt2");
		string text = "Select D_cp, estado, bultos, observaciones From etransEnvios WHERE id_envio='" + Conversions.ToString(envio) + "' LIMIT 1";
		MySqlDataAdapter val = new MySqlDataAdapter(text, Mod_Sentencias.cnn);
		((DbDataAdapter)(object)val).Fill(dataTable);
		if (dataTable.Rows.Count > 0)
		{
			data_envio.e_codigo_postal = dataTable.Rows[0]["D_cp"].ToString();
			data_envio.e_estado = dataTable.Rows[0]["Estado"].ToString();
			data_envio.e_bultos = Conversions.ToInteger(dataTable.Rows[0]["Bultos"].ToString());
			data_envio.e_observation = dataTable.Rows[0]["Observaciones"].ToString();
			string text2 = "Select zona,(SELECT Descripcion FROM Zonas WHERE Zona=localidades.zona) AS Descripcion from localidades where CP=" + data_envio.e_codigo_postal + " LIMIT 1";
			MySqlDataAdapter val2 = new MySqlDataAdapter(text2, Mod_Sentencias.cnn);
			((DbDataAdapter)(object)val2).Fill(dataTable2);
			if (dataTable2.Rows.Count > 0)
			{
				data_envio.e_zona = dataTable2.Rows[0]["Descripcion"].ToString();
			}
			else
			{
				data_envio.e_zona = "Cap";
			}
		}
		return data_envio;
	}
}
