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
internal sealed class Mod_fechas
{
	public static object cambiarFechaEntrega(int id_envio)
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		int num = 0;
		try
		{
			string text = ("SELECT D_fecha, Estado FROM etransEnvios WHERE id_envio=" + Conversions.ToString(id_envio)) ?? "";
			DataTable dataTable = new DataTable("x");
			MySqlDataAdapter val = new MySqlDataAdapter(text, Mod_Sentencias.cnn);
			((DbDataAdapter)(object)val).Fill(dataTable);
			string estado = Conversions.ToString(dataTable.Rows[0]["Estado"]);
			DateTime dateTime = Conversions.ToDate(dataTable.Rows[0]["D_fecha"]);
			DateTime value = MyProject.Forms.Form1_Inicio.DateTimePicker1.Value;
			DateTime dateTime2 = Conversions.ToDate(Mod_calendario.proxima_fecha(value));
			string text2 = Strings.Format(dateTime2, "yyyyMMdd");
			string sQL = ("UPDATE etransEnvios SET D_fecha='" + text2 + "' WHERE id_envio=" + Conversions.ToString(id_envio)) ?? "";
			Mod_ConeccionBD.BD_Sentencia(sQL);
			int num2 = Conversions.ToInteger(Mod_logger.historialenter(Conversions.ToString(id_envio), "Fecha Entrega: " + Conversions.ToString(dateTime), estado, "Nueva Fecha Entrega: " + Conversions.ToString(dateTime2)));
			num = 1;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objExcepcion = ex;
			Logger.e("Error con excepción y traza", objExcepcion, new StackFrame(fNeedFileInfo: true));
			ProjectData.ClearProjectError();
		}
		return num;
	}
}
