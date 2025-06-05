using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;
using System.Xml;
using Hermes.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Hermes;

[StandardModule]
internal sealed class Mod_leerXML
{
	public static void leoxml(string archivo)
	{
		string right = Strings.Format(DateAndTime.Today, "dd/MM/yyyy");
		string requestUriString = "ftp://ftp.officecore.com/";
		string userName = "Area54_OTExportFiles";
		string password = "s4102w5pfertl123q";
		FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(requestUriString);
		ftpWebRequest.KeepAlive = false;
		ftpWebRequest.Proxy = null;
		NetworkCredential credentials = new NetworkCredential(userName, password);
		ftpWebRequest.Credentials = credentials;
		string url = "ftp://Area54_OTExportFiles:s4102w5pfertl123q@ftp.officecore.com/" + archivo;
		XmlTextReader xmlTextReader = new XmlTextReader(url);
		XmlLectura xmlLectura = MyProject.Forms.XmlLectura;
		string left = string.Empty;
		string valremito = string.Empty;
		string text = string.Empty;
		string observaciones = string.Empty;
		try
		{
			while (xmlTextReader.Read())
			{
				switch (xmlTextReader.NodeType)
				{
				case XmlNodeType.Element:
					if (Operators.CompareString(xmlTextReader.Name, "Status", TextCompare: true) == 0)
					{
						left = ((Operators.CompareString(xmlTextReader.ReadElementContentAsString(), "32", TextCompare: true) != 0) ? "No Entregado" : "Entregado");
					}
					if (Operators.CompareString(xmlTextReader.Name, "Value", TextCompare: true) == 0)
					{
						observaciones = xmlTextReader.ReadElementContentAsString();
					}
					if (Operators.CompareString(xmlTextReader.Name, "FirstName", TextCompare: true) == 0)
					{
					}
					if (Operators.CompareString(xmlTextReader.Name, "Data2", TextCompare: true) == 0)
					{
						valremito = xmlTextReader.ReadElementContentAsString();
					}
					if (Operators.CompareString(xmlTextReader.Name, "Data16", TextCompare: true) == 0)
					{
						text = xmlTextReader.ReadElementContentAsString();
					}
					break;
				}
			}
			try
			{
				if (Operators.CompareString(text, right, TextCompare: true) == 0)
				{
					if (Operators.CompareString(left, "Entregado", TextCompare: true) == 0)
					{
						string text2 = Conversions.ToString(Mod_Pruebaws.updatews(valremito, text, observaciones));
					}
					if (Operators.CompareString(left, "No Entregado", TextCompare: true) == 0)
					{
						string text3 = Conversions.ToString(Mod_Pruebaws.update_2ws(valremito, text, observaciones));
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception objExcepcion = ex;
				Logger.e("Error con excepción", objExcepcion);
				Logger.d("Debug con traza", new StackFrame(fNeedFileInfo: true));
				Logger.i("Info sin traza", new StackFrame(fNeedFileInfo: true));
				Logger.e("Error con excepción y traza", objExcepcion, new StackFrame(fNeedFileInfo: true));
				ProjectData.ClearProjectError();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception objExcepcion2 = ex2;
			xmlTextReader.Close();
			Logger.e("Error con excepción", objExcepcion2);
			Logger.d("Debug con traza", new StackFrame(fNeedFileInfo: true));
			Logger.i("Info sin traza", new StackFrame(fNeedFileInfo: true));
			Logger.e("Error con excepción y traza", objExcepcion2, new StackFrame(fNeedFileInfo: true));
			ProjectData.ClearProjectError();
		}
		xmlLectura = null;
	}

	public static void listarFTP()
	{
		string requestUriString = "ftp://ftp.officecore.com/";
		string userName = "Area54_OTExportFiles";
		string password = "s4102w5pfertl123q";
		FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(requestUriString);
		ftpWebRequest.KeepAlive = false;
		ftpWebRequest.Proxy = null;
		NetworkCredential credentials = new NetworkCredential(userName, password);
		ftpWebRequest.Credentials = credentials;
		ftpWebRequest.Method = "LIST";
		ftpWebRequest.Method = "NLST";
		StreamReader streamReader = new StreamReader(ftpWebRequest.GetResponse().GetResponseStream());
		while (!streamReader.EndOfStream)
		{
			string archivo = streamReader.ReadLine();
			leoxml(archivo);
		}
		streamReader.Close();
		ftpWebRequest.Abort();
	}

	public static void descargarFic()
	{
		try
		{
			string requestUriString = "ftp://ftp.officecore.com/";
			string userName = "Area54_OTExportFiles";
			string password = "s4102w5pfertl123q";
			string path = "C:\\FTP";
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(requestUriString);
			ftpWebRequest.KeepAlive = false;
			ftpWebRequest.Proxy = null;
			NetworkCredential credentials = new NetworkCredential(userName, password);
			ftpWebRequest.Credentials = credentials;
			ftpWebRequest.Method = "LIST";
			ftpWebRequest.Method = "NLST";
			StreamReader streamReader = new StreamReader(ftpWebRequest.GetResponse().GetResponseStream());
			string text = streamReader.ReadToEnd();
			ArrayList arrayList = new ArrayList(Strings.Split(text, ".xml", -1, CompareMethod.Text));
			ftpWebRequest.Method = "RETR";
			foreach (object item in arrayList)
			{
				string path2 = Conversions.ToString(item);
				StreamReader streamReader2 = new StreamReader(ftpWebRequest.GetResponse().GetResponseStream());
				string text2 = streamReader2.ReadToEnd();
				string path3 = Path.Combine(path, Path.GetFileName(path2) + ".txt");
				StreamWriter streamWriter = new StreamWriter(path3, append: false, Encoding.Default);
				streamWriter.Write(text);
				streamWriter.Close();
				streamReader2.Close();
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objExcepcion = ex;
			Logger.e("Error con excepción", objExcepcion);
			Logger.d("Debug con traza", new StackFrame(fNeedFileInfo: true));
			Logger.i("Info sin traza", new StackFrame(fNeedFileInfo: true));
			Logger.e("Error con excepción y traza", objExcepcion, new StackFrame(fNeedFileInfo: true));
			ProjectData.ClearProjectError();
		}
	}

	public static void ftpextrae(string RutaArchivo, string NombreArchivo)
	{
		string requestUriString = "ftp://ftp.officecore.com/" + NombreArchivo;
		FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(requestUriString);
		ftpWebRequest.Credentials = new NetworkCredential("Area54_OTExportFiles", "s4102w5pfertl123q");
		ftpWebRequest.KeepAlive = true;
		ftpWebRequest.UseBinary = true;
		ftpWebRequest.Method = "RETR";
		try
		{
			using FtpWebResponse ftpWebResponse = (FtpWebResponse)ftpWebRequest.GetResponse();
			using (Stream stream = ftpWebResponse.GetResponseStream())
			{
				using (FileStream fileStream = new FileStream(RutaArchivo, FileMode.Create))
				{
					byte[] array = new byte[2048];
					int num = 0;
					do
					{
						num = stream.Read(array, 0, array.Length);
						fileStream.Write(array, 0, num);
					}
					while (num != 0);
					stream.Close();
					fileStream.Flush();
					fileStream.Close();
				}
				stream.Close();
			}
			ftpWebResponse.Close();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objExcepcion = ex;
			Logger.e("Error con excepción", objExcepcion);
			Logger.d("Debug con traza", new StackFrame(fNeedFileInfo: true));
			Logger.i("Info sin traza", new StackFrame(fNeedFileInfo: true));
			Logger.e("Error con excepción y traza", objExcepcion, new StackFrame(fNeedFileInfo: true));
			ProjectData.ClearProjectError();
		}
	}
}
