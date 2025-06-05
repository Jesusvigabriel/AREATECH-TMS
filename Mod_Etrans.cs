using System;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.IO;
using System.Net;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace Hermes;

[StandardModule]
internal sealed class Mod_Etrans
{
	public struct envionuevoEtrans
	{
		public string direccionE;

		public string cpE;

		public string localidadE;
	}

	public static object actualizar_estado_web(int id_envio, int estado)
	{
		string text = string.Empty;
		if (Mod_Sentencias.etransActiva)
		{
			try
			{
				string requestUriString = string.Empty;
				if (Operators.CompareString(Mod_Sentencias.baseDD, "hermes", TextCompare: true) == 0)
				{
					requestUriString = $"http://www.etrans.com.ar/api/setEstado/?usu=hermes&pass=hermetica&id={id_envio}&estado={estado}";
				}
				else if (Operators.CompareString(Mod_Sentencias.baseDD, "hermesDev", TextCompare: true) == 0)
				{
					requestUriString = $"http://h8000127.ferozo.com/api/setEstado/?usu=hermes&pass=hermetica&id={id_envio}&estado={estado}";
				}
				HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(requestUriString);
				httpWebRequest.Credentials = CredentialCache.DefaultCredentials;
				HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
				Stream responseStream = httpWebResponse.GetResponseStream();
				StreamReader streamReader = new StreamReader(responseStream);
				string text2 = streamReader.ReadToEnd();
				text = text2;
				Logger.i("Proceso =>" + text);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception objExcepcion = ex;
				text = "error";
				Logger.e("Error con excepción y traza =>" + text, objExcepcion, new StackFrame(fNeedFileInfo: true));
				ProjectData.ClearProjectError();
			}
		}
		return text;
	}

	public static object estado_web_int(string estado)
	{
		int num = 2;
		if (Operators.CompareString(estado, "PENDIENTE", TextCompare: true) == 0)
		{
			num = 1;
		}
		if (Operators.CompareString(estado, "APROBADO", TextCompare: true) == 0)
		{
			num = 2;
		}
		if (Operators.CompareString(estado, "EN RECOLECCION", TextCompare: true) == 0)
		{
			num = 3;
		}
		if (Operators.CompareString(estado, "RECOLECTADO", TextCompare: true) == 0)
		{
			num = 4;
		}
		if (Operators.CompareString(estado, "EN CD", TextCompare: true) == 0)
		{
			num = 5;
		}
		if (Operators.CompareString(estado, "DESPACHADO", TextCompare: true) == 0)
		{
			num = 6;
		}
		if (Operators.CompareString(estado, "PROXIMO A ENTREGAR", TextCompare: true) == 0)
		{
			num = 7;
		}
		if (Operators.CompareString(estado, "ENTREGADO", TextCompare: true) == 0)
		{
			num = 8;
		}
		if (Operators.CompareString(estado, "NO ENTREGADO", TextCompare: true) == 0)
		{
			num = 9;
		}
		if (Operators.CompareString(estado, "A REPROGRAMAR", TextCompare: true) == 0)
		{
			num = 10;
		}
		if (Operators.CompareString(estado, "CADUCADO", TextCompare: true) == 0)
		{
			num = 11;
		}
		if (Operators.CompareString(estado, "DESCARTADO", TextCompare: true) == 0)
		{
			num = 12;
		}
		if (Operators.CompareString(estado, "EN DEVOLUCION", TextCompare: true) == 0)
		{
			num = 13;
		}
		if (Operators.CompareString(estado, "DEVUELTO", TextCompare: true) == 0)
		{
			num = 14;
		}
		if (Operators.CompareString(estado, "PENDIENTE WEB", TextCompare: true) == 0)
		{
			num = 22;
		}
		if (Operators.CompareString(estado, "CADUCADO WEB", TextCompare: true) == 0)
		{
			num = 23;
		}
		if (Operators.CompareString(estado, "NO RECOLECTADO", TextCompare: true) == 0)
		{
			num = 24;
		}
		return num;
	}

	public static object actualizar_estados(int id_envio, string estado)
	{
		string empty = string.Empty;
		string sQL = ("UPDATE etransEnvios SET Estado='" + estado + "' WHERE id_envio=" + Conversions.ToString(id_envio)) ?? "";
		if (Operators.CompareString(Mod_Sentencias.baseDD, "hermes", TextCompare: true) == 0)
		{
			int estado2 = Conversions.ToInteger(estado_web_int(estado));
			actualizar_estado_web(id_envio, estado2);
		}
		Mod_ConeccionBD.BD_Sentencia(sQL);
		int num = Conversions.ToInteger(Mod_logger.historialenter(Conversions.ToString(id_envio), "actualizar_estados", estado, ""));
		return empty;
	}

	public static object estado_web_etrans(int id_envio)
	{
		int num = 0;
		if (Mod_Sentencias.etransActiva)
		{
			try
			{
				string requestUriString = string.Empty;
				if (Operators.CompareString(Mod_Sentencias.baseDD, "hermes", TextCompare: true) == 0)
				{
					requestUriString = $"http://www.etrans.com.ar/api/getestado/?usu=hermes&pass=hermetica&id={id_envio}";
				}
				else if (Operators.CompareString(Mod_Sentencias.baseDD, "hermesDev", TextCompare: true) == 0)
				{
					requestUriString = $"http://h8000127.ferozo.com/api/getestado/?usu=hermes&pass=hermetica&id={id_envio}";
				}
				HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(requestUriString);
				httpWebRequest.Credentials = CredentialCache.DefaultCredentials;
				HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
				Stream responseStream = httpWebResponse.GetResponseStream();
				StreamReader streamReader = new StreamReader(responseStream);
				string value = streamReader.ReadToEnd();
				num = Conversions.ToInteger(value);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Interaction.MsgBox(ex2.Message);
				ProjectData.ClearProjectError();
			}
		}
		return num;
	}

	public static object sincronizar_etrans()
	{
		int num = 1;
		if (Mod_Sentencias.etransActiva)
		{
			try
			{
				string requestUriString = string.Empty;
				if (Operators.CompareString(Mod_Sentencias.baseDD, "hermes", TextCompare: true) == 0)
				{
					requestUriString = "http://www.etrans.com.ar/admin/cronServiceEstados.php";
				}
				else if (Operators.CompareString(Mod_Sentencias.baseDD, "hermesDev", TextCompare: true) == 0)
				{
					requestUriString = "http://h8000127.ferozo.com/admin/cronServiceEstados.php";
				}
				HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(requestUriString);
				httpWebRequest.Credentials = CredentialCache.DefaultCredentials;
				HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
				Stream responseStream = httpWebResponse.GetResponseStream();
				StreamReader streamReader = new StreamReader(responseStream);
				string text = streamReader.ReadToEnd();
				string text2 = text;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				num = 2;
				ProjectData.ClearProjectError();
			}
		}
		return num;
	}

	public static object estado_int_string(int estado)
	{
		string result = string.Empty;
		if (estado == 1)
		{
			result = "PENDIENTE";
		}
		if (estado == 2)
		{
			result = "APROBADO";
		}
		if (estado == 3)
		{
			result = "EN RECOLECCION";
		}
		if (estado == 4)
		{
			result = "RECOLECTADO";
		}
		if (estado == 5)
		{
			result = "EN CD";
		}
		if (estado == 6)
		{
			result = "DESPACHADO";
		}
		if (estado == 7)
		{
			result = "PROXIMO A ENTREGAR";
		}
		if (estado == 8)
		{
			result = "ENTREGADO";
		}
		if (estado == 9)
		{
			result = "NO ENTREGADO";
		}
		if (estado == 10)
		{
			result = "A REPROGRAMAR";
		}
		if (estado == 11)
		{
			result = "CADUCADO";
		}
		if (estado == 12)
		{
			result = "DESCARTADO";
		}
		if (estado == 13)
		{
			result = "EN DEVOLUCION";
		}
		if (estado == 14)
		{
			result = "DEVUELTO";
		}
		if (estado == 22)
		{
			result = "PENDIENTE WEB";
		}
		if (estado == 23)
		{
			result = "CADUCADO WEB";
		}
		if (estado == 24)
		{
			result = "NO RECOLECTADO";
		}
		return result;
	}

	public static object updatedirR(int id_envio)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		string text = "SELECT U_calle, U_numero_puerta,  U_cp, U_localidad FROM etransEnvios WHERE id_envio=" + Conversions.ToString(id_envio);
		DataTable dataTable = new DataTable("x");
		MySqlDataAdapter val = new MySqlDataAdapter(text, Mod_Sentencias.cnn);
		((DbDataAdapter)(object)val).Fill(dataTable);
		envionuevoEtrans envionuevoEtrans = default(envionuevoEtrans);
		envionuevoEtrans.direccionE = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(dataTable.Rows[0]["U_calle"], " "), dataTable.Rows[0]["U_numero_puerta"]));
		envionuevoEtrans.cpE = Conversions.ToString(dataTable.Rows[0]["U_cp"]);
		envionuevoEtrans.localidadE = Conversions.ToString(dataTable.Rows[0]["U_localidad"]);
		return envionuevoEtrans;
	}

	public static object updatedirE(int id_envio)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		string text = "SELECT D_calle, D_numero_puerta,  D_cp, D_localidad FROM etransEnvios WHERE id_envio=" + Conversions.ToString(id_envio);
		DataTable dataTable = new DataTable("x");
		MySqlDataAdapter val = new MySqlDataAdapter(text, Mod_Sentencias.cnn);
		((DbDataAdapter)(object)val).Fill(dataTable);
		envionuevoEtrans envionuevoEtrans = default(envionuevoEtrans);
		envionuevoEtrans.direccionE = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(dataTable.Rows[0]["D_calle"], " "), dataTable.Rows[0]["D_numero_puerta"]));
		envionuevoEtrans.cpE = Conversions.ToString(dataTable.Rows[0]["D_cp"]);
		envionuevoEtrans.localidadE = Conversions.ToString(dataTable.Rows[0]["D_localidad"]);
		return envionuevoEtrans;
	}

	public static object get_envio_etrans(int id_envio)
	{
		string result = string.Empty;
		if (Mod_Sentencias.etransActiva)
		{
			string requestUriString = string.Empty;
			if (Operators.CompareString(Mod_Sentencias.baseDD, "hermes", TextCompare: true) == 0)
			{
				requestUriString = $"http://www.etrans.com.ar/api/hermes/ws_hermes.php?id_envio={id_envio}";
			}
			else if (Operators.CompareString(Mod_Sentencias.baseDD, "hermesDev", TextCompare: true) == 0)
			{
				requestUriString = $"http://h8000127.ferozo.com/api/hermes/ws_hermes.php?id_envio={id_envio}";
			}
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(requestUriString);
			httpWebRequest.Credentials = CredentialCache.DefaultCredentials;
			HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
			Stream responseStream = httpWebResponse.GetResponseStream();
			StreamReader streamReader = new StreamReader(responseStream);
			string text = streamReader.ReadToEnd();
			result = text;
		}
		return result;
	}
}
