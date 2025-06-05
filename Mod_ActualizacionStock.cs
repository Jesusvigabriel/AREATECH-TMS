using System;
using System.Collections.Generic;
using Hermes.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Hermes;

[StandardModule]
internal sealed class Mod_ActualizacionStock
{
	public struct abmStock
	{
		public int id;

		public int unidades;

		public int variacion;
	}

	public static object ingresoStock(List<Dictionary<string, int>> values, int empresa)
	{
		checked
		{
			object result;
			try
			{
				foreach (Dictionary<string, int> value in values)
				{
					int num = value["id"];
					int num2 = value["unidades"];
					string sql = "Select unidades from stock where empresa='" + Conversions.ToString(empresa) + "' and producto='" + Conversions.ToString(num) + "' Limit 1";
					int num3 = (int)Math.Round(Conversions.ToDouble(Mod_Sentencias.dataValue(sql, "unidades")));
					int num4 = num3 + num2;
					string sQL = "UPDATE stock SET  unidades='" + Conversions.ToString(num4) + "' WHERE producto='" + Conversions.ToString(num) + "' AND empresa='" + Conversions.ToString(empresa) + "'";
					int num5 = Conversions.ToInteger(Mod_ConeccionBD.BD_Sentencia(sQL));
				}
				result = 1;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				result = 0;
				ProjectData.ClearProjectError();
			}
			return result;
		}
	}

	public static object egresoStock(List<Dictionary<string, int>> values, int empresa)
	{
		checked
		{
			object result;
			try
			{
				foreach (Dictionary<string, int> value in values)
				{
					int num = value["id"];
					int num2 = value["unidades"];
					string sql = "Select unidades from stock where empresa='" + Conversions.ToString(empresa) + "' and producto='" + Conversions.ToString(num) + "' Limit 1";
					int num3 = (int)Math.Round(Conversions.ToDouble(Mod_Sentencias.dataValue(sql, "unidades")));
					int num4 = num3 - num2;
					string sQL = "UPDATE stock SET  unidades='" + Conversions.ToString(num4) + "' WHERE producto='" + Conversions.ToString(num) + "' AND empresa='" + Conversions.ToString(empresa) + "'";
					int num5 = Conversions.ToInteger(Mod_ConeccionBD.BD_Sentencia(sQL));
				}
				result = 1;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				result = 0;
				ProjectData.ClearProjectError();
			}
			return result;
		}
	}

	public static object egresoStock2(List<abmStock> descontarStock, int empresa)
	{
		string text = Strings.Format(MyProject.Forms.Form1_Inicio.DateTimePicker1.Value, "yyyyMMdd");
		checked
		{
			object result;
			try
			{
				foreach (abmStock item in descontarStock)
				{
					int id = item.id;
					int unidades = item.unidades;
					int variacion = item.variacion;
					if (variacion == 0)
					{
						string sql = "Select unidades from stock where empresa='" + Conversions.ToString(empresa) + "' and producto='" + Conversions.ToString(id) + "' Limit 1";
						int num = (int)Math.Round(Conversions.ToDouble(Mod_Sentencias.dataValue(sql, "unidades")));
						int num2 = num - unidades;
						string sQL = "UPDATE stock SET  unidades='" + Conversions.ToString(num2) + "' WHERE producto='" + Conversions.ToString(id) + "' AND empresa='" + Conversions.ToString(empresa) + "'";
						int num3 = Conversions.ToInteger(Mod_ConeccionBD.BD_Sentencia(sQL));
						string sQL2 = "UPDATE pos_prod SET unidades='" + Conversions.ToString(num2) + "', removed='" + text + "', existe='1' WHERE productId='" + Conversions.ToString(id) + "' AND empresaId='" + Conversions.ToString(empresa) + "'";
						Mod_ConeccionBD.BD_Sentencia(sQL2);
					}
					else
					{
						string sql2 = "Select unidades from variaciones where producto_id='" + Conversions.ToString(id) + "' and id='" + Conversions.ToString(variacion) + "' Limit 1";
						int num4 = (int)Math.Round(Conversions.ToDouble(Mod_Sentencias.dataValue(sql2, "unidades")));
						int num5 = num4 - unidades;
						string sQL3 = "UPDATE variaciones SET  unidades='" + Conversions.ToString(num5) + "' WHERE id='" + Conversions.ToString(variacion) + "' AND producto_id='" + Conversions.ToString(id) + "'";
						int num6 = Conversions.ToInteger(Mod_ConeccionBD.BD_Sentencia(sQL3));
						string sQL4 = "UPDATE pos_prod SET unidades='" + Conversions.ToString(num5) + "', removed='" + text + "', existe='1' WHERE productId='" + Conversions.ToString(id) + "' AND empresaId='" + Conversions.ToString(empresa) + "'";
						Mod_ConeccionBD.BD_Sentencia(sQL4);
					}
				}
				result = 1;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				result = 0;
				ProjectData.ClearProjectError();
			}
			return result;
		}
	}

	public static object ingresoStock2(List<abmStock> sumarStock, int empresa)
	{
		checked
		{
			object result;
			try
			{
				foreach (abmStock item in sumarStock)
				{
					int id = item.id;
					int unidades = item.unidades;
					int variacion = item.variacion;
					if (variacion == 0)
					{
						string sql = "Select unidades from stock where empresa='" + Conversions.ToString(empresa) + "' and producto='" + Conversions.ToString(id) + "' Limit 1";
						int num = int.Parse(Conversions.ToString(Mod_Sentencias.dataValue(sql, "unidades")));
						int num2 = num + unidades;
						string sQL = "UPDATE stock SET  unidades='" + Conversions.ToString(num2) + "' WHERE producto='" + Conversions.ToString(id) + "' AND empresa='" + Conversions.ToString(empresa) + "'";
						int num3 = Conversions.ToInteger(Mod_ConeccionBD.BD_Sentencia(sQL));
					}
					else
					{
						string sql2 = "Select unidades from variaciones where producto_id='" + Conversions.ToString(id) + "' and id='" + Conversions.ToString(variacion) + "' Limit 1";
						int num4 = int.Parse(Conversions.ToString(Mod_Sentencias.dataValue(sql2, "unidades")));
						int num5 = num4 + unidades;
						string sQL2 = "UPDATE variaciones SET  unidades='" + Conversions.ToString(num5) + "' WHERE id='" + Conversions.ToString(variacion) + "' AND producto_id='" + Conversions.ToString(id) + "'";
						int num6 = Conversions.ToInteger(Mod_ConeccionBD.BD_Sentencia(sQL2));
					}
				}
				result = 1;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				result = 0;
				ProjectData.ClearProjectError();
			}
			return result;
		}
	}
}
