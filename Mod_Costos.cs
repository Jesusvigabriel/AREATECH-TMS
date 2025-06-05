using System;
using System.Data;
using System.Data.Common;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace Hermes;

[StandardModule]
internal sealed class Mod_Costos
{
	public static object costo_unidad(int Categoria, int TotalBultos, int TotalPuntosEntrega, int Ventana, double Tarifa)
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		DataTable dataTable = new DataTable("x");
		string text = ("SELECT Valorbulto,ValorPE FROM Categorias where Categoria=" + Conversions.ToString(Categoria)) ?? "";
		MySqlDataAdapter val = new MySqlDataAdapter(text, Mod_Sentencias.cnn);
		((DbDataAdapter)(object)val).Fill(dataTable);
		double num = Conversions.ToDouble(dataTable.Rows[0]["Valorbulto"]);
		double num2 = Conversions.ToDouble(dataTable.Rows[0]["ValorPE"]);
		if (Ventana > 1)
		{
			Tarifa *= 0.7;
		}
		double value = Tarifa + (double)TotalBultos * num + (double)TotalPuntosEntrega * num2;
		double num3 = Math.Round(value, 2);
		return num3;
	}
}
