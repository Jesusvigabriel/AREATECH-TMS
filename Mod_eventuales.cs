using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Newtonsoft.Json.Linq;

namespace Hermes;

[StandardModule]
internal sealed class Mod_eventuales
{
	public struct datos_eventuales
	{
		public int eventualId;

		public string eventualCliente;

		public string eventualDomicilio;

		public string eventualLocalidad;

		public string eventualCP;
	}

	public static object listaEventuales()
	{
		string empty = string.Empty;
		string empty2 = string.Empty;
		string empty3 = string.Empty;
		List<datos_eventuales> list = new List<datos_eventuales>();
		checked
		{
			datos_eventuales datos_eventuales = default(datos_eventuales);
			object result;
			try
			{
				empty = $"http://api-interna.area54sa.com.ar/services/get_eventuales.php?token=R4sp33ry5423yXw";
				HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(empty);
				httpWebRequest.Credentials = CredentialCache.DefaultCredentials;
				HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
				Stream responseStream = httpWebResponse.GetResponseStream();
				StreamReader streamReader = new StreamReader(responseStream);
				empty2 = streamReader.ReadToEnd();
				JObject val = JObject.Parse(empty2);
				int num = ((IEnumerable<JToken>)val["data"]).Count();
				int num2 = num - 1;
				for (int i = 0; i <= num2; i++)
				{
					datos_eventuales.eventualId = int.Parse((string)val["data"][(object)i][(object)"eventual"]);
					datos_eventuales.eventualCliente = (string)val["data"][(object)i][(object)"cliente"];
					datos_eventuales.eventualDomicilio = (string)val["data"][(object)i][(object)"domicilio"];
					datos_eventuales.eventualLocalidad = (string)val["data"][(object)i][(object)"localidad"];
					datos_eventuales.eventualCP = (string)val["data"][(object)i][(object)"cp"];
					list.Add(datos_eventuales);
				}
				result = list;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Interaction.MsgBox(ex2.Message);
				datos_eventuales.eventualId = 0;
				datos_eventuales.eventualCliente = Conversions.ToString(0);
				datos_eventuales.eventualDomicilio = Conversions.ToString(0);
				datos_eventuales.eventualLocalidad = Conversions.ToString(0);
				datos_eventuales.eventualCP = Conversions.ToString(0);
				result = datos_eventuales;
				ProjectData.ClearProjectError();
			}
			return result;
		}
	}

	public static object buscarEvePorNombre(string value, List<Mod_Productos.datos_producto> lista)
	{
		datos_eventuales datos_eventuales = default(datos_eventuales);
		checked
		{
			int num = lista.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				if (Operators.CompareString(value, lista[i].productDescripcion, TextCompare: true) == 0)
				{
					datos_eventuales.eventualId = Conversions.ToInteger(lista[i].productBarrcode);
					datos_eventuales.eventualCliente = lista[i].productCodigo;
					datos_eventuales.eventualDomicilio = lista[i].productDescripcion;
					datos_eventuales.eventualDomicilio = lista[i].productEmpresa;
					datos_eventuales.eventualLocalidad = Conversions.ToString(lista[i].productId);
					datos_eventuales.eventualCP = Conversions.ToString(lista[i].productUnidades);
					break;
				}
			}
			return datos_eventuales;
		}
	}
}
