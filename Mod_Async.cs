using System;
using System.IO;
using System.Net;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;
using Newtonsoft.Json.Linq;

namespace Hermes;

[StandardModule]
internal sealed class Mod_Async
{
	public static void MyBackgroundThread(JObject json)
	{
		string empty = string.Empty;
		try
		{
			Console.WriteLine("Inicio: " + DateTime.Now.ToString());
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
				empty = (string)val["msg"];
			}
			else
			{
				empty = (string)val["msg"];
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
	}
}
