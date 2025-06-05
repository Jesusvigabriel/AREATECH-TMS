using System.IO;
using System.Net;
using Microsoft.VisualBasic.CompilerServices;

namespace Hermes;

[StandardModule]
internal sealed class Mod_Pruebaws
{
	public static object dirrget(string valremito)
	{
		string requestUriString = string.Empty;
		if (Operators.CompareString(Mod_Sentencias.baseDD, "hermes", TextCompare: true) == 0)
		{
			requestUriString = $"http://www.etrans.com.ar/api/getdirr/?usu=hermes&pass=hermetica&id={valremito}";
		}
		else if (Operators.CompareString(Mod_Sentencias.baseDD, "hermesDev", TextCompare: true) == 0)
		{
			requestUriString = $"http://h8000127.ferozo.com/api/getdirr/?usu=hermes&pass=hermetica&id={valremito}";
		}
		HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(requestUriString);
		httpWebRequest.Credentials = CredentialCache.DefaultCredentials;
		HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
		Stream responseStream = httpWebResponse.GetResponseStream();
		StreamReader streamReader = new StreamReader(responseStream);
		return streamReader.ReadToEnd();
	}

	public static object direget(string valremito)
	{
		string requestUriString = string.Empty;
		if (Operators.CompareString(Mod_Sentencias.baseDD, "hermes", TextCompare: true) == 0)
		{
			requestUriString = $"http://www.etrans.com.ar/api/getdire/?usu=hermes&pass=hermetica&id={valremito}";
		}
		else if (Operators.CompareString(Mod_Sentencias.baseDD, "hermesDev", TextCompare: true) == 0)
		{
			requestUriString = $"http://h8000127.ferozo.com/api/getdire/?usu=hermes&pass=hermetica&id={valremito}";
		}
		HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(requestUriString);
		httpWebRequest.Credentials = CredentialCache.DefaultCredentials;
		HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
		Stream responseStream = httpWebResponse.GetResponseStream();
		StreamReader streamReader = new StreamReader(responseStream);
		string text = streamReader.ReadToEnd();
		string text2 = text;
		string[] array = text2.Split('|');
		return array[0] + " " + array[1];
	}

	public static object updatews(string valremito, string fecha, string observaciones)
	{
		string requestUriString = $"http://api-interna.area54sa.com.ar/set_entregado1.php?remito={valremito}&fecha={fecha}&observaciones={observaciones}";
		HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(requestUriString);
		httpWebRequest.Credentials = CredentialCache.DefaultCredentials;
		HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
		Stream responseStream = httpWebResponse.GetResponseStream();
		StreamReader streamReader = new StreamReader(responseStream);
		return streamReader.ReadToEnd();
	}

	public static object update_2ws(string valremito, string fecha, string observaciones)
	{
		string requestUriString = $"http://api-interna.area54sa.com.ar/set_noentregado1.php?remito={valremito}&fecha={fecha}&observaciones={observaciones}";
		HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(requestUriString);
		httpWebRequest.Credentials = CredentialCache.DefaultCredentials;
		HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
		Stream responseStream = httpWebResponse.GetResponseStream();
		StreamReader streamReader = new StreamReader(responseStream);
		return streamReader.ReadToEnd();
	}
}
