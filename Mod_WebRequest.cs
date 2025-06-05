using System;
using System.IO;
using System.Net;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Newtonsoft.Json.Linq;

namespace Hermes;

[StandardModule]
internal sealed class Mod_WebRequest
{
	public struct ResponseFromPost
	{
		public int status;

		public string mensaje;
	}

	public static object post_w()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected O, but got Unknown
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected O, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected O, but got Unknown
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected O, but got Unknown
		string result;
		try
		{
			string requestUriString = "http://api-interna.area54sa.com.ar/pruebapostnet.php";
			WebRequest webRequest = WebRequest.Create(requestUriString);
			webRequest.Method = "POST";
			JObject val = new JObject((object)new JProperty("data", (object)new JObject(new object[6]
			{
				(object)new JProperty("empresa", (object)"numeroEmpresa"),
				(object)new JProperty("tipo", (object)"nuevotipo"),
				(object)new JProperty("numero", (object)"numerouno"),
				(object)new JProperty("eventual", (object)"eventualnumero"),
				(object)new JProperty("valor", (object)"32.25"),
				(object)new JProperty("estado", (object)"estado1")
			})));
			byte[] bytes = Encoding.UTF8.GetBytes(((JToken)val).ToString());
			webRequest.ContentType = "application/json";
			webRequest.ContentLength = bytes.Length;
			webRequest.Headers.Add("Token", "australopitecus");
			Stream requestStream = webRequest.GetRequestStream();
			requestStream.Write(bytes, 0, bytes.Length);
			requestStream.Close();
			WebResponse response = webRequest.GetResponse();
			result = ((HttpWebResponse)response).StatusDescription;
			requestStream = response.GetResponseStream();
			StreamReader streamReader = new StreamReader(requestStream);
			string prompt = streamReader.ReadToEnd();
			streamReader.Close();
			requestStream.Close();
			response.Close();
			Interaction.MsgBox(prompt);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			result = "error al conectar";
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static object PostData(string url, JObject data)
	{
		ResponseFromPost responseFromPost = default(ResponseFromPost);
		try
		{
			WebRequest webRequest = WebRequest.Create(url);
			webRequest.Method = "POST";
			byte[] bytes = Encoding.UTF8.GetBytes(((JToken)data).ToString());
			webRequest.ContentType = "application/json";
			webRequest.ContentLength = bytes.Length;
			webRequest.Headers.Add("Token", "australopitecus");
			Stream requestStream = webRequest.GetRequestStream();
			requestStream.Write(bytes, 0, bytes.Length);
			requestStream.Close();
			WebResponse response = webRequest.GetResponse();
			responseFromPost.status = Conversions.ToInteger(((HttpWebResponse)response).StatusDescription);
			requestStream = response.GetResponseStream();
			StreamReader streamReader = new StreamReader(requestStream);
			responseFromPost.mensaje = streamReader.ReadToEnd();
			streamReader.Close();
			requestStream.Close();
			response.Close();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			responseFromPost.status = 404;
			responseFromPost.mensaje = "Error al Conectar";
			ProjectData.ClearProjectError();
		}
		return responseFromPost;
	}

	public static object GetData(string url)
	{
		ResponseFromPost responseFromPost = default(ResponseFromPost);
		try
		{
			WebRequest webRequest = WebRequest.Create(url);
			webRequest.Method = "GET";
			webRequest.ContentType = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8";
			WebResponse response = webRequest.GetResponse();
			if (Operators.CompareString(((HttpWebResponse)response).StatusDescription, "OK", TextCompare: true) == 0)
			{
				responseFromPost.status = 200;
			}
			Stream responseStream = response.GetResponseStream();
			StreamReader streamReader = new StreamReader(responseStream);
			responseFromPost.mensaje = streamReader.ReadToEnd();
			streamReader.Close();
			responseStream.Close();
			response.Close();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			responseFromPost.status = 404;
			responseFromPost.mensaje = "Error al Conectar " + ex2.Message;
			ProjectData.ClearProjectError();
		}
		return responseFromPost;
	}

	public static object DataToJson()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected O, but got Unknown
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected O, but got Unknown
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected O, but got Unknown
		return (object)new JObject((object)new JProperty("data", (object)new JObject(new object[6]
		{
			(object)new JProperty("empresa", (object)"numeroEmpresa"),
			(object)new JProperty("tipo", (object)"nuevotipo"),
			(object)new JProperty("numero", (object)"numerouno"),
			(object)new JProperty("eventual", (object)"eventualnumero"),
			(object)new JProperty("valor", (object)"32.25"),
			(object)new JProperty("estado", (object)"estado1")
		})));
	}
}
