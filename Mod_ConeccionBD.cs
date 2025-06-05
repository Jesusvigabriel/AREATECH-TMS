using System;
using System.Data;
using System.Diagnostics;
using Hermes.My;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace Hermes;

[StandardModule]
internal sealed class Mod_ConeccionBD
{
	public static object BD_Sentencia(string SQL)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		MySqlCommand val = new MySqlCommand(SQL, Mod_Sentencias.cnn);
		object result;
		try
		{
			Mod_Sentencias.cnn.Open();
			val.ExecuteNonQuery();
			Mod_Sentencias.cnn.Close();
			result = 1;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objExcepcion = ex;
			Logger.e(SQL + " - " + MySettingsProperty.Settings.Usuario, objExcepcion, new StackFrame(fNeedFileInfo: true));
			result = 2;
			ProjectData.ClearProjectError();
		}
		finally
		{
			if (Mod_Sentencias.cnn.State == ConnectionState.Open)
			{
				Mod_Sentencias.cnn.Close();
				Mod_Sentencias.cnn.Dispose();
			}
		}
		return result;
	}

	public static object BD_insert_ID(string SQL)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		MySqlCommand val = new MySqlCommand(SQL, Mod_Sentencias.cnn);
		object result;
		try
		{
			Mod_Sentencias.cnn.Open();
			val.ExecuteNonQuery();
			int num = checked((int)val.LastInsertedId);
			Mod_Sentencias.cnn.Close();
			result = num;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objExcepcion = ex;
			Logger.e(SQL + " - " + MySettingsProperty.Settings.Usuario, objExcepcion, new StackFrame(fNeedFileInfo: true));
			result = 0;
			ProjectData.ClearProjectError();
		}
		finally
		{
			if (Mod_Sentencias.cnn.State == ConnectionState.Open)
			{
				Mod_Sentencias.cnn.Close();
				Mod_Sentencias.cnn.Dispose();
			}
		}
		return result;
	}
}
