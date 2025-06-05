using System;
using System.Data;
using System.IO;
using System.Net;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;
using Newtonsoft.Json.Linq;

namespace Hermes;

[StandardModule]
internal sealed class Mod_Destinatarios
{
	public struct Destinatario
	{
		public int DestinoId;

		public string DestinoNombre;

		public string DestinoDireccion;

		public string DestinoLocalidad;

		public string DestinoPostal;
	}

	public static object nuevoDestinatario(Destinatario destino)
	{
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected O, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected O, but got Unknown
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected O, but got Unknown
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected O, but got Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Expected O, but got Unknown
		string text = destino.DestinoNombre.ToString();
		string text2 = destino.DestinoDireccion.ToString();
		string text3 = destino.DestinoLocalidad.ToString();
		string text4 = destino.DestinoPostal.ToString();
		int num;
		try
		{
			string requestUriString = "http://api-interna.area54sa.com.ar/MVC/app/controller/destinos.controller.php";
			WebRequest webRequest = WebRequest.Create(requestUriString);
			webRequest.Method = "POST";
			JObject val = new JObject((object)new JProperty("data", (object)new JObject(new object[4]
			{
				(object)new JProperty("nombre", (object)text),
				(object)new JProperty("direccion", (object)text2),
				(object)new JProperty("localidad", (object)text3),
				(object)new JProperty("postal", (object)text4)
			})));
			byte[] bytes = Encoding.UTF8.GetBytes(((JToken)val).ToString());
			webRequest.ContentType = "application/json";
			webRequest.ContentLength = bytes.Length;
			webRequest.Headers.Add("Token", "australopitecus");
			webRequest.Headers.Add("Action", "nuevo");
			Stream requestStream = webRequest.GetRequestStream();
			requestStream.Write(bytes, 0, bytes.Length);
			requestStream.Close();
			WebResponse response = webRequest.GetResponse();
			string statusDescription = ((HttpWebResponse)response).StatusDescription;
			requestStream = response.GetResponseStream();
			StreamReader streamReader = new StreamReader(requestStream);
			string s = streamReader.ReadToEnd();
			streamReader.Close();
			requestStream.Close();
			response.Close();
			num = ((int.Parse(s) != 0) ? int.Parse(s) : 0);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			num = 0;
			ProjectData.ClearProjectError();
		}
		return num;
	}

	public static object selectDestinatario(string nombre)
	{
		Destinatario destinatario = default(Destinatario);
		string sql = "SELECT * FROM destinos WHERE nombre = '" + nombre + "'";
		DataTable dataTable = (DataTable)Mod_Sentencias.data(sql);
		if (dataTable.Rows.Count == 1)
		{
			destinatario.DestinoId = int.Parse(Conversions.ToString(NewLateBinding.LateGet(dataTable.Rows[0]["id"], null, "text", new object[0], null, null, null)));
			destinatario.DestinoNombre = Conversions.ToString(NewLateBinding.LateGet(dataTable.Rows[0]["nombre"], null, "text", new object[0], null, null, null));
			destinatario.DestinoDireccion = Conversions.ToString(NewLateBinding.LateGet(dataTable.Rows[0]["direccion"], null, "text", new object[0], null, null, null));
			destinatario.DestinoLocalidad = Conversions.ToString(NewLateBinding.LateGet(dataTable.Rows[0]["localidad"], null, "text", new object[0], null, null, null));
			destinatario.DestinoPostal = Conversions.ToString(NewLateBinding.LateGet(dataTable.Rows[0]["postal"], null, "text", new object[0], null, null, null));
		}
		else if (dataTable.Rows.Count <= 1)
		{
		}
		return destinatario;
	}
}
