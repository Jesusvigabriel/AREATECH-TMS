using System;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using Hermes.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace Hermes;

[StandardModule]
internal sealed class Mod_Despacho
{
	public static object generaViaje(int chofer, int ventana, string usuario)
	{
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected O, but got Unknown
		int num = 0;
		string text = Strings.Format(MyProject.Forms.Form1_Inicio.DateTimePicker1.Value, "yyyyMMdd");
		try
		{
			string text2 = "SELECT (SELECT Categoria FROM Flota WHERE Numero=" + Conversions.ToString(chofer) + ") AS CAT, (ROUND((SELECT Tarifa FROM Flota WHERE Numero=" + Conversions.ToString(chofer) + ")+(SELECT Tarifa_fija FROM Categorias WHERE Categoria=CAT),2)) AS Costo FROM Flota LIMIT 1";
			DataTable dataTable = new DataTable("x");
			MySqlDataAdapter val = new MySqlDataAdapter(text2, Mod_Sentencias.cnn);
			((DbDataAdapter)(object)val).Fill(dataTable);
			int num2 = Conversions.ToInteger(dataTable.Rows[0]["CAT"]);
			double num3 = Conversions.ToDouble(dataTable.Rows[0]["Costo"]);
			string sQL = "INSERT INTO viajes (Chofer, Categoria, Ventana, Puntos, Bultos, Peso, Declarado, Flete, Costo, usuario, fecha)\nVALUES(" + Conversions.ToString(chofer) + ", " + Conversions.ToString(num2) + ", " + Conversions.ToString(ventana) + ", NULL, NULL, NULL, NULL, NULL, '" + Conversions.ToString(num3) + "', '" + usuario + "', '" + text + "')";
			num = Conversions.ToInteger(Mod_ConeccionBD.BD_Sentencia(sQL));
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objExcepcion = ex;
			Logger.e("[Error] creando Viaje", objExcepcion, new StackFrame(fNeedFileInfo: true));
			ProjectData.ClearProjectError();
		}
		return num;
	}

	public static object numeroViaje(int chofer, int ventana, string fecha)
	{
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		int num = 0;
		try
		{
			string text = "SELECT id FROM viajes WHERE Chofer=" + Conversions.ToString(chofer) + " AND Ventana = " + Conversions.ToString(ventana) + " AND fecha='" + fecha + "'";
			DataTable dataTable = new DataTable("x");
			MySqlDataAdapter val = new MySqlDataAdapter(text, Mod_Sentencias.cnn);
			((DbDataAdapter)(object)val).Fill(dataTable);
			num = Conversions.ToInteger(dataTable.Rows[0]["id"]);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objExcepcion = ex;
			Logger.e("[Error] obteniendo numero de Viaje", objExcepcion, new StackFrame(fNeedFileInfo: true));
			ProjectData.ClearProjectError();
		}
		return num;
	}
}
