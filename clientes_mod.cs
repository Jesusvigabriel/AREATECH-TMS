using System;
using System.Data;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace Hermes;

[StandardModule]
internal sealed class clientes_mod
{
	public static object nuevo_cliente(string sql)
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

	public static object editar_cliente(string sql)
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

	public static object borrar_cliente(int id_cliente)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		string text = ("DELETE FROM Clientes WHERE id=" + Conversions.ToString(id_cliente)) ?? "";
		MySqlCommand val = new MySqlCommand(text, Mod_Sentencias.cnn);
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
			Interaction.MsgBox(ex2.Message);
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
