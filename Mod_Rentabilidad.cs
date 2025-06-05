using System.Data;
using System.Data.Common;
using System.Drawing;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace Hermes;

[StandardModule]
internal sealed class Mod_Rentabilidad
{
	public static object rentabilidad(double flete, double costo)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		int num5 = 0;
		int num6 = 0;
		int num7 = 0;
		DataTable dataTable = new DataTable("C");
		string text = "SELECT * FROM configuracion LIMIT 1";
		MySqlDataAdapter val = new MySqlDataAdapter(text, Mod_Sentencias.cnn);
		((DbDataAdapter)(object)val).Fill(dataTable);
		num2 = Conversions.ToInteger(dataTable.Rows[0]["excelente"]);
		num3 = Conversions.ToInteger(dataTable.Rows[0]["muybuena"]);
		num4 = Conversions.ToInteger(dataTable.Rows[0]["buena"]);
		num5 = Conversions.ToInteger(dataTable.Rows[0]["razonable"]);
		num6 = Conversions.ToInteger(dataTable.Rows[0]["baja"]);
		num7 = Conversions.ToInteger(dataTable.Rows[0]["ninguna"]);
		num = Conversions.ToInteger(dataTable.Rows[0]["custodia"]);
		double num8 = flete - costo;
		double num9 = num8 / costo * 100.0;
		Color color = default(Color);
		if (Conversion.Val(num9) < (double)num7)
		{
			color = Color.Red;
		}
		else if ((Conversion.Val(num9) >= (double)num6) & (Conversion.Val(num9) < (double)num5))
		{
			color = Color.Orange;
		}
		else if ((Conversion.Val(num9) >= (double)num5) & (Conversion.Val(num9) < (double)num4))
		{
			color = Color.Blue;
		}
		else if ((Conversion.Val(num9) >= (double)num4) & (Conversion.Val(num9) < (double)num3))
		{
			color = Color.DarkBlue;
		}
		else if ((Conversion.Val(num9) >= (double)num3) & (Conversion.Val(num9) < (double)num2))
		{
			color = Color.Green;
		}
		else if (Conversion.Val(num9) >= (double)num2)
		{
			color = Color.DarkGreen;
		}
		return color;
	}
}
