using System;
using System.Data;
using System.Data.Common;
using System.Runtime.CompilerServices;
using Hermes.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace Hermes;

[StandardModule]
internal sealed class Mod_Informes
{
	public static object guardar_planificado(string fecha, int chofera, int ventana)
	{
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected O, but got Unknown
		object result;
		try
		{
			string text = ("SELECT (SELECT Categoria FROM Flota WHERE Numero=" + Conversions.ToString(chofera) + ") AS CAT, Count(DISTINCT Destino) AS Puntos, sum(Bultos) AS Bultos, sum(ROUND(Declarado,2)) AS VD, sum(ROUND(Kilos,2)) AS Peso, sum(ROUND(Volumen,3)) AS Volumen, sum(ROUND(Flete,2)) AS Flete, (SELECT tarifa FROM Flota WHERE Numero=" + Conversions.ToString(chofera) + ") AS Tarifa FROM Planchada WHERE fecha ='" + fecha + "' And Chofer = " + Conversions.ToString(chofera) + " And ventana = " + Conversions.ToString(ventana)) ?? "";
			DataTable dataTable = new DataTable("x");
			MySqlDataAdapter val = new MySqlDataAdapter(text, Mod_Sentencias.cnn);
			((DbDataAdapter)(object)val).Fill(dataTable);
			int num = Conversions.ToInteger(dataTable.Rows[0]["CAT"]);
			int num2 = Conversions.ToInteger(dataTable.Rows[0]["Puntos"]);
			int num3 = Conversions.ToInteger(dataTable.Rows[0]["Bultos"]);
			double num4 = Conversions.ToDouble(dataTable.Rows[0]["VD"]);
			double num5 = Conversions.ToDouble(dataTable.Rows[0]["Peso"]);
			double num6 = Conversions.ToDouble(dataTable.Rows[0]["Volumen"]);
			double num7 = Conversions.ToDouble(dataTable.Rows[0]["Flete"]);
			double num8 = Conversions.ToDouble(dataTable.Rows[0]["Tarifa"]);
			double num9 = Conversions.ToDouble(Mod_Costos.costo_unidad(num, num3, num2, ventana, num8));
			string sQL = "INSERT INTO Planificado(Cat, Puntos, Bultos, VD, Peso, Volumen, Flete, Tarifa, Costo, Fecha, Chofer, Ventana, Despachado) VALUES(" + Conversions.ToString(num) + ", " + Conversions.ToString(num2) + ", " + Conversions.ToString(num3) + ", '" + Strings.Replace(Conversions.ToString(num4), ",", ".", 1, -1, CompareMethod.Text) + "', '" + Strings.Replace(Conversions.ToString(num5), ",", ".", 1, -1, CompareMethod.Text) + "', '" + Strings.Replace(Conversions.ToString(num6), ",", ".", 1, -1, CompareMethod.Text) + "', '" + Strings.Replace(Conversions.ToString(num7), ",", ".", 1, -1, CompareMethod.Text) + "', '" + Strings.Replace(Conversions.ToString(num8), ",", ".", 1, -1, CompareMethod.Text) + "','" + Strings.Replace(Conversions.ToString(num9), ",", ".", 1, -1, CompareMethod.Text) + "','" + fecha + "'," + Conversions.ToString(chofera) + "," + Conversions.ToString(ventana) + ", 1)";
			Mod_ConeccionBD.BD_Sentencia(sQL);
			result = 1;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox("2 " + ex2.Message, MsgBoxStyle.Exclamation);
			result = 2;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static object informeDiario()
	{
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		string text = Strings.Format(MyProject.Forms.Informes.DateTimePicker1.Value, "yyyyMMdd");
		string text2 = Strings.Format(MyProject.Forms.Informes.DateTimePicker2.Value, "yyyyMMdd");
		DataTable dataTable = new DataTable("x");
		string text3 = "SELECT f.chofer As chofer, f.Categoria as CAT, count(DISTINCT p.Destino) AS Puntos,\tsum(p.Bultos) AS Bultos, sum(ROUND(p.Declarado,2)) AS VD, sum(ROUND(p.Kilos,2)) AS Peso, sum(ROUND(p.Volumen,3)) AS Volumen, sum(ROUND(p.Flete,2)) AS Flete, Round((f.Tarifa),2) AS adicionalModelo, (c.tarifa_fija) AS Costo, (max(p.adicional)) AS adicionalzona,\t p.fecha as fecha, p.Ventana as ventana FROM Planchada p LEFT JOIN flota f ON f.numero=p.chofer LEFT JOIN categorias c ON c.categoria=f.categoria WHERE p.fecha BETWEEN '" + text + "' AND '" + text2 + "' and p.Chofer>0 GROUP BY f.Chofer, p.Fecha, p.ventana";
		MySqlDataAdapter val = new MySqlDataAdapter(text3, Mod_Sentencias.cnn);
		((DbDataAdapter)(object)val).Fill(dataTable);
		DataTable dataTable2 = new DataTable("informesD");
		dataTable2.Columns.Add("Chofer", Type.GetType("System.String"));
		dataTable2.Columns.Add("Categoria", Type.GetType("System.Int32"));
		dataTable2.Columns.Add("Ventana", Type.GetType("System.Int32"));
		dataTable2.Columns.Add("Puntos", Type.GetType("System.Int32"));
		dataTable2.Columns.Add("Bultos", Type.GetType("System.Double"));
		dataTable2.Columns.Add("Peso", Type.GetType("System.Double"));
		dataTable2.Columns.Add("Declarado", Type.GetType("System.Double"));
		dataTable2.Columns.Add("Flete", Type.GetType("System.Double"));
		dataTable2.Columns.Add("Costo", Type.GetType("System.Double"));
		dataTable2.Columns.Add("Fecha", Type.GetType("System.String"));
		dataTable2.Columns.Add("Adicional", Type.GetType("System.String"));
		checked
		{
			int num = dataTable.Rows.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				DataRow dataRow = dataTable2.NewRow();
				double num2 = Conversions.ToDouble(dataTable.Rows[i]["Costo"]);
				double num3 = Conversions.ToDouble(dataTable.Rows[i]["adicionalModelo"]);
				double num4 = Conversions.ToDouble(selectAdicional(Conversions.ToInteger(dataTable.Rows[i]["CAT"]), Conversions.ToInteger(dataTable.Rows[i]["adicionalZona"])));
				int num5 = Conversions.ToInteger(dataTable.Rows[i]["ventana"]);
				dataRow["Chofer"] = RuntimeHelpers.GetObjectValue(dataTable.Rows[i]["Chofer"]);
				dataRow["Categoria"] = RuntimeHelpers.GetObjectValue(dataTable.Rows[i]["CAT"]);
				dataRow["Ventana"] = RuntimeHelpers.GetObjectValue(dataTable.Rows[i]["Ventana"]);
				dataRow["Puntos"] = RuntimeHelpers.GetObjectValue(dataTable.Rows[i]["Puntos"]);
				dataRow["Bultos"] = RuntimeHelpers.GetObjectValue(dataTable.Rows[i]["Bultos"]);
				dataRow["Peso"] = RuntimeHelpers.GetObjectValue(dataTable.Rows[i]["Peso"]);
				dataRow["Declarado"] = RuntimeHelpers.GetObjectValue(dataTable.Rows[i]["VD"]);
				dataRow["Flete"] = RuntimeHelpers.GetObjectValue(dataTable.Rows[i]["Flete"]);
				if (num5 > 1)
				{
					dataRow["Costo"] = Math.Round((num2 + num3) * 0.7 * num4, 2);
				}
				else
				{
					dataRow["Costo"] = Math.Round((num2 + num3) * num4, 2);
				}
				dataRow["Fecha"] = RuntimeHelpers.GetObjectValue(dataTable.Rows[i]["Fecha"]);
				dataRow["Adicional"] = RuntimeHelpers.GetObjectValue(dataTable.Rows[i]["adicionalZona"]);
				dataTable2.Rows.Add(dataRow);
			}
			return dataTable2;
		}
	}

	public static object selectAdicional(int categoria, int adicional)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		double num = 1.0;
		DataTable dataTable = new DataTable("x");
		string text = ("SELECT Adicional_1,Adicional_2,Adicional_3,Adicional_4,Adicional_5 FROM Categorias where Categoria= " + Conversions.ToString(categoria)) ?? "";
		MySqlDataAdapter val = new MySqlDataAdapter(text, Mod_Sentencias.cnn);
		((DbDataAdapter)(object)val).Fill(dataTable);
		double num2 = Conversions.ToDouble(dataTable.Rows[0]["Adicional_1"]);
		double num3 = Conversions.ToDouble(dataTable.Rows[0]["Adicional_2"]);
		double num4 = Conversions.ToDouble(dataTable.Rows[0]["Adicional_3"]);
		double num5 = Conversions.ToDouble(dataTable.Rows[0]["Adicional_4"]);
		double num6 = Conversions.ToDouble(dataTable.Rows[0]["Adicional_5"]);
		if (adicional == 0)
		{
			num = num;
		}
		if (adicional == 1)
		{
			num = num2;
		}
		if (adicional == 2)
		{
			num = num3;
		}
		if (adicional == 3)
		{
			num = num4;
		}
		if (adicional == 4)
		{
			num = num5;
		}
		if (adicional == 5)
		{
			num = num6;
		}
		return num;
	}

	public static object informeViaje(string fecha1)
	{
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		DataTable dataTable = new DataTable("x");
		string text = "SELECT (Chofer) as Numero, (SELECT Chofer FROM Flota WHERE Numero=Planchada.Chofer) AS Chofer,(SELECT Categoria FROM Flota WHERE Numero=Planchada.Chofer) AS CAT, count(DISTINCT Destino) AS Puntos, sum(Bultos) AS Bultos,sum(ROUND(Declarado,2)) AS VD, sum(ROUND(Kilos,2)) AS Peso, sum(ROUND(Volumen,3)) AS Volumen,sum(ROUND(Flete,2)) AS Flete,Round((SELECT Tarifa FROM Flota WHERE Numero=Planchada.Chofer),2) AS adicionalModelo, (SELECT tarifa_fija from categorias where categoria=CAT) AS Costo, (max(adicional)) AS adicionalzona, fecha,Ventana, (SELECT Viaje FROM Viajes WHERE chofer=planchada.Chofer AND ventana=1  AND Estado=0 AND fecha = '" + fecha1 + "') as Viaje FROM Planchada WHERE fecha = '" + fecha1 + "'  AND Chofer>0 AND Ventana=1 GROUP BY Chofer,Fecha UNION ALL SELECT  (Chofer) as Numero,(SELECT Chofer FROM Flota WHERE Numero=Planchada.Chofer) AS Chofer,(SELECT Categoria FROM Flota WHERE Numero=Planchada.Chofer) AS CAT, count(DISTINCT Destino) AS Puntos, sum(Bultos) AS Bultos,sum(ROUND(Declarado,2)) AS VD, sum(ROUND(Kilos,2)) AS Peso, sum(ROUND(Volumen,3)) AS Volumen,sum(ROUND(Flete,2)) AS Flete,Round((SELECT Tarifa FROM Flota WHERE Numero=Planchada.Chofer),2) AS adicionalModelo, (SELECT tarifa_fija from categorias where categoria=CAT) AS Costo, (max(adicional)) AS adicionalzona, fecha,Ventana, (SELECT Viaje FROM Viajes WHERE chofer=planchada.Chofer AND ventana>1 AND Estado=0 AND fecha = '" + fecha1 + "') as Viaje FROM Planchada WHERE fecha ='" + fecha1 + "' AND Chofer>0 AND Ventana>1 GROUP BY Chofer,fecha";
		MySqlDataAdapter val = new MySqlDataAdapter(text, Mod_Sentencias.cnn);
		((DbDataAdapter)(object)val).Fill(dataTable);
		DataTable dataTable2 = new DataTable("informesD");
		dataTable2.Columns.Add("Chofer", Type.GetType("System.String"));
		dataTable2.Columns.Add("Categoria", Type.GetType("System.Int32"));
		dataTable2.Columns.Add("Ventana", Type.GetType("System.Int32"));
		dataTable2.Columns.Add("Puntos", Type.GetType("System.Int32"));
		dataTable2.Columns.Add("Bultos", Type.GetType("System.Double"));
		dataTable2.Columns.Add("Peso", Type.GetType("System.Double"));
		dataTable2.Columns.Add("Declarado", Type.GetType("System.Double"));
		dataTable2.Columns.Add("Flete", Type.GetType("System.Double"));
		dataTable2.Columns.Add("Costo", Type.GetType("System.Double"));
		dataTable2.Columns.Add("Fecha", Type.GetType("System.String"));
		dataTable2.Columns.Add("Adicional", Type.GetType("System.Double"));
		dataTable2.Columns.Add("AModelo", Type.GetType("System.Double"));
		dataTable2.Columns.Add("Viaje", Type.GetType("System.Int32"));
		dataTable2.Columns.Add("Cerrado", Type.GetType("System.String"));
		checked
		{
			int num = dataTable.Rows.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				DataRow dataRow = dataTable2.NewRow();
				double value = Conversions.ToDouble(selectAdicional(Conversions.ToInteger(dataTable.Rows[i]["CAT"]), Conversions.ToInteger(dataTable.Rows[i]["adicionalZona"])));
				int ventana = Conversions.ToInteger(dataTable.Rows[i]["ventana"]);
				dataRow["Chofer"] = RuntimeHelpers.GetObjectValue(dataTable.Rows[i]["Chofer"]);
				dataRow["Categoria"] = RuntimeHelpers.GetObjectValue(dataTable.Rows[i]["CAT"]);
				dataRow["Ventana"] = RuntimeHelpers.GetObjectValue(dataTable.Rows[i]["Ventana"]);
				dataRow["Puntos"] = RuntimeHelpers.GetObjectValue(dataTable.Rows[i]["Puntos"]);
				dataRow["Bultos"] = RuntimeHelpers.GetObjectValue(dataTable.Rows[i]["Bultos"]);
				object[] array;
				DataRow dataRow2;
				bool[] array2;
				object obj = NewLateBinding.LateGet(null, typeof(Math), "Round", array = new object[2]
				{
					(dataRow2 = dataTable.Rows[i])["Peso"],
					2
				}, null, null, array2 = new bool[2] { true, false });
				if (array2[0])
				{
					dataRow2["Peso"] = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
				}
				dataRow["Peso"] = RuntimeHelpers.GetObjectValue(obj);
				object obj2 = NewLateBinding.LateGet(null, typeof(Math), "Round", array = new object[2]
				{
					(dataRow2 = dataTable.Rows[i])["VD"],
					2
				}, null, null, array2 = new bool[2] { true, false });
				if (array2[0])
				{
					dataRow2["VD"] = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
				}
				dataRow["Declarado"] = RuntimeHelpers.GetObjectValue(obj2);
				object obj3 = NewLateBinding.LateGet(null, typeof(Math), "Round", array = new object[2]
				{
					(dataRow2 = dataTable.Rows[i])["Flete"],
					2
				}, null, null, array2 = new bool[2] { true, false });
				if (array2[0])
				{
					dataRow2["Flete"] = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
				}
				dataRow["Flete"] = RuntimeHelpers.GetObjectValue(obj3);
				object obj4 = NewLateBinding.LateGet(null, typeof(Math), "Round", array = new object[2]
				{
					(dataRow2 = dataTable.Rows[i])["adicionalModelo"],
					2
				}, null, null, array2 = new bool[2] { true, false });
				if (array2[0])
				{
					dataRow2["adicionalModelo"] = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
				}
				dataRow["AModelo"] = RuntimeHelpers.GetObjectValue(obj4);
				object obj5 = NewLateBinding.LateGet(null, typeof(Math), "Round", array = new object[2]
				{
					(dataRow2 = dataTable.Rows[i])["Costo"],
					2
				}, null, null, array2 = new bool[2] { true, false });
				if (array2[0])
				{
					dataRow2["Costo"] = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
				}
				dataRow["Costo"] = RuntimeHelpers.GetObjectValue(obj5);
				dataRow["Fecha"] = RuntimeHelpers.GetObjectValue(dataTable.Rows[i]["Fecha"]);
				dataRow["Adicional"] = Math.Round(value, 2);
				int num2 = Conversions.ToInteger(Mod_Despacho.numeroViaje(Conversions.ToInteger(dataTable.Rows[i]["numero"]), ventana, fecha1));
				dataRow["Viaje"] = num2;
				if (num2 > 0)
				{
					string sql = ("Select Estado FROM viajes where id=" + Conversions.ToString(num2)) ?? "";
					DataTable dataTable3 = (DataTable)Mod_Sentencias.data(sql);
					int num3 = Conversions.ToInteger(dataTable3.Rows[0]["Estado"]);
					if (num3 == 1)
					{
						dataRow["Cerrado"] = "Cerrado";
					}
					if (num3 == 0)
					{
						dataRow["Cerrado"] = "Abierto";
					}
					dataTable2.Rows.Add(dataRow);
				}
			}
			return dataTable2;
		}
	}
}
