using System;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace Hermes;

[StandardModule]
internal sealed class Mod_calendario
{
	public static object saberDia(DateTime fecha)
	{
		int num = DateAndTime.Weekday(fecha);
		return num;
	}

	public static object proximoDia(DateTime fecha)
	{
		switch (Conversions.ToInteger(saberDia(fecha)))
		{
		case 1:
			fecha = fecha.AddDays(1.0);
			break;
		case 2:
			fecha = fecha.AddDays(1.0);
			break;
		case 3:
			fecha = fecha.AddDays(1.0);
			break;
		case 4:
			fecha = fecha.AddDays(1.0);
			break;
		case 5:
			fecha = fecha.AddDays(1.0);
			break;
		case 6:
			fecha = fecha.AddDays(3.0);
			break;
		case 7:
			fecha = fecha.AddDays(2.0);
			break;
		}
		return fecha;
	}

	public static object comprobarFeriado(DateTime fecha)
	{
		string text = Strings.Format(fecha, "yyyyMMdd");
		string sql = "SELECT fecha FROM feriados WHERE fecha='" + text + "'";
		int num = Conversions.ToInteger(contar_rows(sql));
		return num;
	}

	public static object contar_rows(string sql)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		int num = 0;
		try
		{
			DataTable dataTable = new DataTable("x");
			MySqlDataAdapter val = new MySqlDataAdapter(sql, Mod_Sentencias.cnn);
			((DbDataAdapter)(object)val).Fill(dataTable);
			num = dataTable.Rows.Count;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		return num;
	}

	public static object proxima_fecha(DateTime fecha)
	{
		DateTime dateTime = Conversions.ToDate(proximoDia(fecha));
		while (Operators.ConditionalCompareObjectGreater(comprobarFeriado(dateTime), 0, TextCompare: true))
		{
			dateTime = Conversions.ToDate(proximoDia(dateTime));
		}
		return dateTime;
	}

	public static object cambios_fecha(int id_envio)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		int num = 0;
		object result;
		try
		{
			string text = "SELECT U_fecha, D_fecha, estado FROM etransEnvios WHERE id_envio=" + Conversions.ToString(id_envio);
			DataTable dataTable = new DataTable("X");
			MySqlDataAdapter val = new MySqlDataAdapter(text, Mod_Sentencias.cnn);
			((DbDataAdapter)(object)val).Fill(dataTable);
			if (dataTable.Rows.Count > 0)
			{
				DateTime today = DateAndTime.Today;
				int num2 = Conversions.ToInteger(saberDia(today));
				int num3 = Conversions.ToInteger(saberDia(Conversions.ToDate(dataTable.Rows[0]["U_fecha"])));
				int num4 = Conversions.ToInteger(saberDia(Conversions.ToDate(dataTable.Rows[0]["D_fecha"])));
				string text2 = Conversions.ToString(dataTable.Rows[0]["estado"]);
				DateTime dateTime = Conversions.ToDate(proximoDia(today));
				int num5 = Conversions.ToInteger(saberDia(dateTime));
				DateTime dateTime2 = Conversions.ToDate(proximoDia(dateTime));
				int num6 = Conversions.ToInteger(saberDia(dateTime2));
				string empty = string.Empty;
				int num7 = Conversions.ToInteger(Mod_Etrans.estado_web_etrans(id_envio));
				string empty2 = string.Empty;
				string empty3 = string.Empty;
				if ((Operators.CompareString(text2, "NO RECOLECTADO", TextCompare: true) == 0) | (Operators.CompareString(text2, "EN RECOLECCION", TextCompare: true) == 0) | (Operators.CompareString(text2, "RECOLECTADO", TextCompare: true) == 0))
				{
					int num9;
					if (num3 == num2)
					{
						num3 = num5;
						if (num7 != 1 && num7 != 11 && num7 != 12 && num7 != 23)
						{
							string text3 = "APROBADO";
							empty2 = Strings.Format(dateTime, "yyyyMMdd");
							empty = ("UPDATE etransEnvios SET Estado='" + text3 + "', U_fecha = " + empty2) ?? "";
							int num8 = Conversions.ToInteger(Mod_Etrans.estado_web_int(text3));
							string comentario = Conversions.ToString(Mod_Etrans.actualizar_estado_web(id_envio, num7));
							num9 = Conversions.ToInteger(Mod_logger.historialenter(Conversions.ToString(id_envio), "", Conversions.ToString(num8), comentario));
							num9 = Conversions.ToInteger(Mod_logger.historialenter(Conversions.ToString(id_envio), "", text3, "Cambio Fecha Retiro"));
							if (num4 == num5)
							{
								empty3 = Strings.Format(dateTime2, "yyyyMMdd");
								empty = (empty + ", D_fecha=" + empty3) ?? "";
								num9 = Conversions.ToInteger(Mod_logger.historialenter(Conversions.ToString(id_envio), "", text3, "Cambio Fecha Entrega"));
							}
							empty = (empty + " WHERE id_envio=" + Conversions.ToString(id_envio)) ?? "";
							Mod_ConeccionBD.BD_Sentencia(empty);
						}
						else
						{
							string text4 = Conversions.ToString(Mod_Etrans.estado_int_string(num7));
							string empty4 = string.Empty;
							num9 = Conversions.ToInteger(Mod_logger.historialenter(Conversions.ToString(id_envio), "", text4, ""));
							empty4 = ("UPDATE etransEnvios SET Estado='" + text4 + "' WHERE id_envio=" + Conversions.ToString(id_envio)) ?? "";
							Mod_ConeccionBD.BD_Sentencia(empty4);
							Interaction.MsgBox("El estado web actual no permite edicion local: " + text4);
						}
					}
					int num10 = Conversions.ToInteger(Mod_Etrans.estado_web_int(text2));
					string comentario2 = Conversions.ToString(Mod_Etrans.actualizar_estado_web(id_envio, num7));
					num9 = Conversions.ToInteger(Mod_logger.historialenter(Conversions.ToString(id_envio), "", Conversions.ToString(num10), comentario2));
				}
			}
			result = num;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox(ex2.Message);
			Logger.e("Error con excepción y traza", ex2, new StackFrame(fNeedFileInfo: true));
			result = num;
			ProjectData.ClearProjectError();
		}
		return result;
	}
}
