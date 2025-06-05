using System;
using System.IO;
using System.Net;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Newtonsoft.Json.Linq;

namespace Hermes;

[StandardModule]
internal sealed class Mod_Json
{
	public struct datos_vehiculo
	{
		public string V_Chofer;

		public int V_Categoria;

		public string V_Peso;

		public string V_Volumen;

		public string V_Tarifa;

		public string V_Otro;
	}

	public static object datosVehiculoPHP(int chofer)
	{
		string empty = string.Empty;
		string empty2 = string.Empty;
		string empty3 = string.Empty;
		datos_vehiculo datos_vehiculo = default(datos_vehiculo);
		object result;
		try
		{
			empty = $"http://api-interna.area54sa.com.ar/hermes/ruteo/datosVehiculo.php?token=australopitecus158&chofer={chofer}";
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(empty);
			httpWebRequest.Credentials = CredentialCache.DefaultCredentials;
			HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
			Stream responseStream = httpWebResponse.GetResponseStream();
			StreamReader streamReader = new StreamReader(responseStream);
			empty2 = streamReader.ReadToEnd();
			JObject val = JObject.Parse(empty2);
			datos_vehiculo.V_Chofer = (string)val["transaccion"][(object)0][(object)"Chofer"];
			datos_vehiculo.V_Categoria = int.Parse((string)val["transaccion"][(object)0][(object)"Categoria"]);
			datos_vehiculo.V_Peso = Conversions.ToString(double.Parse(Strings.Replace((string)val["transaccion"][(object)0][(object)"Peso"], ".", ",", 1, -1, CompareMethod.Text)));
			datos_vehiculo.V_Volumen = Conversions.ToString(double.Parse(Strings.Replace((string)val["transaccion"][(object)0][(object)"Volumen"], ".", ",", 1, -1, CompareMethod.Text)));
			datos_vehiculo.V_Tarifa = Conversions.ToString(double.Parse(Strings.Replace((string)val["transaccion"][(object)0][(object)"Tarifa"], ".", ",", 1, -1, CompareMethod.Text)));
			datos_vehiculo.V_Otro = Conversions.ToString(double.Parse(Strings.Replace((string)val["transaccion"][(object)0][(object)"Otro"], ".", ",", 1, -1, CompareMethod.Text)));
			result = datos_vehiculo;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox(ex2.Message);
			datos_vehiculo.V_Chofer = "";
			datos_vehiculo.V_Categoria = 0;
			datos_vehiculo.V_Peso = Conversions.ToString(0);
			datos_vehiculo.V_Volumen = Conversions.ToString(0);
			datos_vehiculo.V_Tarifa = Conversions.ToString(0);
			datos_vehiculo.V_Otro = Conversions.ToString(0);
			result = datos_vehiculo;
			ProjectData.ClearProjectError();
		}
		return result;
	}
}
