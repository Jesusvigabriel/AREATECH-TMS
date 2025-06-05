using System;
using System.Data;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace Hermes;

[StandardModule]
internal sealed class Mod_novedades
{
	public static object guardar_novedades(string sql)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		MySqlCommand val = new MySqlCommand(sql, Mod_Sentencias.cnn);
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
			Exception ex2 = ex;
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
}
