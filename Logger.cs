using System;
using System.Diagnostics;
using System.IO;
using Hermes.My;
using Microsoft.VisualBasic.CompilerServices;

namespace Hermes;

public class Logger
{
	public enum TipoMensaje
	{
		DEBUG,
		INFO,
		WARNING,
		LERROR
	}

	private const int TAM_FICHERO = 52428800;

	private const string EXTENSION = ".log";

	private static TipoMensaje eNivel = TipoMensaje.DEBUG;

	public static TipoMensaje Nivel
	{
		get
		{
			return eNivel;
		}
		set
		{
			eNivel = value;
		}
	}

	private static void add(TipoMensaje eTipo, string sMensaje, StackFrame objTraza = null)
	{
		if (eTipo >= eNivel)
		{
			string fileFecha = getFileFecha();
			verificar(fileFecha);
			FileStream fileStream = new FileStream(fileFecha, FileMode.Append, FileAccess.Write);
			if (fileStream?.CanWrite ?? false)
			{
				string empty = string.Empty;
				empty = DateTime.Now.ToString() + " [" + eTipo.ToString() + "] ";
				empty = empty + getTraza(objTraza) + sMensaje;
				StreamWriter streamWriter = new StreamWriter(fileStream);
				streamWriter.WriteLine(empty);
				streamWriter.Close();
				fileStream.Close();
			}
		}
	}

	private static string getFileFecha()
	{
		DateTime now = DateTime.Now;
		string empty = string.Empty;
		empty += Conversions.ToString(now.Year);
		if (now.Month < 10)
		{
			empty += "0";
		}
		empty += Conversions.ToString(now.Month);
		if (now.Day < 10)
		{
			empty += "0";
		}
		empty += Conversions.ToString(now.Day);
		return empty + MySettingsProperty.Settings.Usuario + ".log";
	}

	private static void verificar(string sFichero)
	{
		try
		{
			if (MyProject.Computer.FileSystem.GetFileInfo(sFichero).Length >= 52428800)
			{
				MyProject.Computer.FileSystem.MoveFile(sFichero, sFichero + ".old");
			}
		}
		catch (IOException ex)
		{
			ProjectData.SetProjectError(ex);
			IOException ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	public static void e(string sMensaje, Exception objExcepcion, StackFrame objTraza = null)
	{
		add(TipoMensaje.LERROR, sMensaje + "\r\n\t" + objExcepcion.Message + "\r\n\t" + objExcepcion.ToString(), objTraza);
	}

	public static void e(string sMensaje, StackFrame objTraza = null)
	{
		add(TipoMensaje.LERROR, sMensaje, objTraza);
	}

	public static void w(string sMensaje, StackFrame objTraza = null)
	{
		add(TipoMensaje.WARNING, sMensaje, objTraza);
	}

	public static void i(string sMensaje, StackFrame objTraza = null)
	{
		add(TipoMensaje.INFO, sMensaje, objTraza);
	}

	public static void d(string sMensaje, StackFrame objTraza = null)
	{
		add(TipoMensaje.DEBUG, sMensaje, objTraza);
	}

	public static string getTraza(StackFrame objTraza)
	{
		string result = string.Empty;
		if (objTraza != null)
		{
			int num = objTraza.GetFileName().LastIndexOf("\\");
			result = ((num >= 0) ? objTraza.GetFileName().Substring(checked(num + 1)) : objTraza.GetFileName());
			result = result + "::" + Conversions.ToString(objTraza.GetFileLineNumber()) + " - ";
		}
		return result;
	}
}
