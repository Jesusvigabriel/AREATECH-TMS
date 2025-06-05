using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;
using Newtonsoft.Json.Linq;

namespace Hermes;

[StandardModule]
internal sealed class Mod_api_ordenes
{
	public struct SelectOrder
	{
		public int user;

		public string token;

		public string order;
	}

	public static object LoginApi(string usuario, string password)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		string result = string.Empty;
		try
		{
			string requestUriString = "https://api.area54sa.com.ar/";
			WebRequest webRequest = WebRequest.Create(requestUriString);
			webRequest.Method = "POST";
			JObject val = new JObject(new object[3]
			{
				(object)new JProperty("action", (object)"LOGIN"),
				(object)new JProperty("user", (object)usuario),
				(object)new JProperty("pass", (object)password)
			});
			byte[] bytes = Encoding.UTF8.GetBytes(((JToken)val).ToString());
			webRequest.ContentType = "application/json";
			webRequest.ContentLength = bytes.Length;
			Stream requestStream = webRequest.GetRequestStream();
			requestStream.Write(bytes, 0, bytes.Length);
			requestStream.Close();
			WebResponse response = webRequest.GetResponse();
			string statusDescription = ((HttpWebResponse)response).StatusDescription;
			requestStream = response.GetResponseStream();
			StreamReader streamReader = new StreamReader(requestStream);
			string text = streamReader.ReadToEnd();
			streamReader.Close();
			requestStream.Close();
			response.Close();
			JObject val2 = JObject.Parse(text);
			Console.WriteLine("STATUS :" + val2["status"].ToString());
			int num = (int)val2["status"];
			if (num == 200)
			{
				Console.WriteLine("Login correcto");
				result = (string)val2["msg"][(object)"token"];
			}
			else
			{
				Console.WriteLine("Error al obtener token");
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			int num = 0;
			Logger.e("Error: " + ex2.Message);
			Logger.e("Usuario: " + usuario + " Pass: " + password);
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static object CrearOrdenApi(JObject json)
	{
		string result = string.Empty;
		try
		{
			Console.WriteLine("InicioA: " + DateTime.Now.ToString());
			string requestUriString = "http://api-interna.area54sa.com.ar/";
			WebRequest webRequest = WebRequest.Create(requestUriString);
			webRequest.Timeout = 180000;
			webRequest.Proxy = null;
			webRequest.Method = "POST";
			byte[] bytes = Encoding.UTF8.GetBytes(((JToken)json).ToString());
			webRequest.ContentType = "application/json";
			webRequest.ContentLength = bytes.Length;
			Stream requestStream = webRequest.GetRequestStream();
			requestStream.Write(bytes, 0, bytes.Length);
			requestStream.Close();
			WebResponse response = webRequest.GetResponse();
			string statusDescription = ((HttpWebResponse)response).StatusDescription;
			requestStream = response.GetResponseStream();
			StreamReader streamReader = new StreamReader(requestStream);
			string text = streamReader.ReadToEnd();
			streamReader.Close();
			requestStream.Close();
			response.Close();
			JObject val = JObject.Parse(text);
			int num = (int)val["status"];
			if (num == 200)
			{
				result = (string)val["msg"];
			}
			else
			{
				result = (string)val["msg"];
				Logger.e((string)val["msg"]);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Logger.e(ex2.Message);
			Logger.e(ex2.StackTrace);
			int num = 0;
			ProjectData.ClearProjectError();
		}
		Console.WriteLine("Fin: " + DateTime.Now.ToString());
		return result;
	}

	public static object StructureToJson(Mod_Ordenes.NuevaOrdenCompleta estructura)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected O, but got Unknown
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected O, but got Unknown
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected O, but got Unknown
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected O, but got Unknown
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Expected O, but got Unknown
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Expected O, but got Unknown
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Expected O, but got Unknown
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Expected O, but got Unknown
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Expected O, but got Unknown
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Expected O, but got Unknown
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Expected O, but got Unknown
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f8: Expected O, but got Unknown
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Expected O, but got Unknown
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0203: Expected O, but got Unknown
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Expected O, but got Unknown
		//IL_0204: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Expected O, but got Unknown
		JObject result;
		try
		{
			result = new JObject(new object[4]
			{
				(object)new JProperty("action", (object)"new"),
				(object)new JProperty("user", (object)estructura.user),
				(object)new JProperty("token", (object)estructura.token),
				(object)new JProperty("order", (object)new JObject(new object[7]
				{
					(object)new JProperty("doc", (object)estructura.order.doc),
					(object)new JProperty("number", (object)estructura.order.number),
					(object)new JProperty("addressee", (object)new JObject(new object[4]
					{
						(object)new JProperty("name", (object)estructura.order.addressee.name),
						(object)new JProperty("address", (object)estructura.order.addressee.address),
						(object)new JProperty("postal", (object)estructura.order.addressee.postal),
						(object)new JProperty("loc", (object)estructura.order.addressee.loc)
					})),
					(object)new JProperty("ctr", (object)estructura.order.ctr.Replace(",", ".")),
					(object)new JProperty("note", (object)estructura.order.note),
					(object)new JProperty("value", (object)estructura.order.value.Replace(",", ".")),
					(object)new JProperty("items", (object)new JObject(new object[2]
					{
						(object)new JProperty("totalItems", (object)estructura.order.items.totalitems),
						(object)new JProperty("list", (object)new JArray((object)((IEnumerable<Mod_Ordenes.OrderItem>)estructura.order.items.list).Select((Func<Mod_Ordenes.OrderItem, JObject>)([SpecialName] (Mod_Ordenes.OrderItem p) => new JObject(new object[2]
						{
							(object)new JProperty("barrcode", (object)p.barrcode),
							(object)new JProperty("unidades", (object)p.unidades)
						})))))
					}))
				}))
			});
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Logger.e("Error: " + ex2.Message);
			Logger.i(ex2.StackTrace);
			result = null;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static object SelectOrdenJson(SelectOrder OrdenConsultada)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		JObject result = null;
		try
		{
			result = new JObject(new object[4]
			{
				(object)new JProperty("action", (object)"SELECT"),
				(object)new JProperty("user", (object)OrdenConsultada.user),
				(object)new JProperty("token", (object)OrdenConsultada.token),
				(object)new JProperty("order", (object)new JObject((object)new JProperty("orderId", (object)OrdenConsultada.order)))
			});
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Logger.e(ex2.Message);
			Logger.i(ex2.StackTrace);
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static object OrderDetalle(JObject POSTDATA)
	{
		string result = string.Empty;
		try
		{
			string requestUriString = "https://api.area54sa.com.ar/";
			WebRequest webRequest = WebRequest.Create(requestUriString);
			webRequest.Method = "POST";
			byte[] bytes = Encoding.UTF8.GetBytes(((JToken)POSTDATA).ToString());
			webRequest.ContentType = "application/json";
			webRequest.ContentLength = bytes.Length;
			Stream requestStream = webRequest.GetRequestStream();
			requestStream.Write(bytes, 0, bytes.Length);
			requestStream.Close();
			WebResponse response = webRequest.GetResponse();
			string statusDescription = ((HttpWebResponse)response).StatusDescription;
			requestStream = response.GetResponseStream();
			StreamReader streamReader = new StreamReader(requestStream);
			string text = streamReader.ReadToEnd();
			streamReader.Close();
			requestStream.Close();
			response.Close();
			JObject val = JObject.Parse(text);
			result = ((JToken)val).ToString();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Logger.e(ex2.Message);
			Logger.i(ex2.StackTrace);
			ProjectData.ClearProjectError();
		}
		return result;
	}
}
