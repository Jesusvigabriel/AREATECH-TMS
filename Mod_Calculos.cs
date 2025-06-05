using System;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace Hermes;

[StandardModule]
internal sealed class Mod_Calculos
{
	public static object getDistance(double lat1, double long1, double lat2, double long2)
	{
		double num = 6371.0;
		double num2 = (lat2 - lat1) * (Math.PI / 180.0);
		double num3 = (long2 - long1) * (Math.PI / 180.0);
		double num4 = Math.Sin(num2 / 2.0);
		double num5 = Math.Sin(num3 / 2.0);
		double d = num4 * num4 + Math.Cos(lat1 * (Math.PI / 180.0)) * Math.Cos(lat2 * (Math.PI / 180.0)) * num5 * num5;
		double num6 = 2.0 * Math.Asin(Math.Sqrt(d));
		double num7 = Math.Round(num * num6, 2);
		return num7;
	}

	public static object getAngulo(double Ax0, double Ay0, double Bx1, double By1, double Cx2, double Cy2)
	{
		double num = Bx1 - Ax0;
		double num2 = By1 - Ay0;
		double num3 = Cx2 - Ax0;
		double num4 = Cy2 - Ay0;
		double x = num * num3 + num2 * num4;
		double y = num * num4 - num2 * num3;
		double num5 = Math.Atan2(y, x);
		return num5 * (180.0 / Math.PI);
	}

	public static object puntoenpoligono(ComboBox combobox1, Label label2, Label label4)
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		string text = ("SELECT Latitud,Longitud,zona FROM Dibujos where Zona=" + combobox1.Text) ?? "";
		DataTable dataTable = new DataTable("x");
		MySqlDataAdapter val = new MySqlDataAdapter(text, Mod_Sentencias.cnn);
		((DbDataAdapter)(object)val).Fill(dataTable);
		double ax = Conversions.ToDouble(label2.Text);
		double ay = Conversions.ToDouble(label4.Text);
		int count = dataTable.Rows.Count;
		double num = 0.0;
		checked
		{
			num = Conversions.ToDouble(getAngulo(ax, ay, Conversions.ToDouble(Strings.Replace(Conversions.ToString(dataTable.Rows[count - 1]["Latitud"]), ".", ",", 1, -1, CompareMethod.Text)), Conversions.ToDouble(Strings.Replace(Conversions.ToString(dataTable.Rows[count - 1]["Longitud"]), ".", ",", 1, -1, CompareMethod.Text)), Conversions.ToDouble(Strings.Replace(Conversions.ToString(dataTable.Rows[0]["Latitud"]), ".", ",", 1, -1, CompareMethod.Text)), Conversions.ToDouble(Strings.Replace(Conversions.ToString(dataTable.Rows[0]["Longitud"]), ".", ",", 1, -1, CompareMethod.Text))));
			int num2 = dataTable.Rows.Count - 2;
			for (int i = 0; i <= num2; i++)
			{
				double num3 = Conversions.ToDouble(getAngulo(ax, ay, Conversions.ToDouble(Strings.Replace(Conversions.ToString(dataTable.Rows[i]["Latitud"]), ".", ",", 1, -1, CompareMethod.Text)), Conversions.ToDouble(Strings.Replace(Conversions.ToString(dataTable.Rows[i]["Longitud"]), ".", ",", 1, -1, CompareMethod.Text)), Conversions.ToDouble(Strings.Replace(Conversions.ToString(dataTable.Rows[i + 1]["Latitud"]), ".", ",", 1, -1, CompareMethod.Text)), Conversions.ToDouble(Strings.Replace(Conversions.ToString(dataTable.Rows[i + 1]["Longitud"]), ".", ",", 1, -1, CompareMethod.Text))));
				num += num3;
			}
			if (!(Math.Abs(num) > 1E-06))
			{
				Interaction.MsgBox("no pertenece");
			}
			else
			{
				Interaction.MsgBox("pertenece a zona " + dataTable.Rows[1]["zona"].ToString());
			}
			return Math.Abs(num) > 1E-06;
		}
	}

	public static object puntoenpoligono2(int valorzona, Label label2, Label label4)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		string text = "SELECT Latitud,Longitud,zona FROM Dibujos where Zona='" + Conversions.ToString(valorzona) + "'";
		DataTable dataTable = new DataTable("x");
		MySqlDataAdapter val = new MySqlDataAdapter(text, Mod_Sentencias.cnn);
		((DbDataAdapter)(object)val).Fill(dataTable);
		double ax = Conversions.ToDouble(label2.Text);
		double ay = Conversions.ToDouble(label4.Text);
		int count = dataTable.Rows.Count;
		double num = 0.0;
		checked
		{
			num = Conversions.ToDouble(getAngulo(ax, ay, Conversions.ToDouble(Strings.Replace(Conversions.ToString(dataTable.Rows[count - 1]["Latitud"]), ".", ",", 1, -1, CompareMethod.Text)), Conversions.ToDouble(Strings.Replace(Conversions.ToString(dataTable.Rows[count - 1]["Longitud"]), ".", ",", 1, -1, CompareMethod.Text)), Conversions.ToDouble(Strings.Replace(Conversions.ToString(dataTable.Rows[0]["Latitud"]), ".", ",", 1, -1, CompareMethod.Text)), Conversions.ToDouble(Strings.Replace(Conversions.ToString(dataTable.Rows[0]["Longitud"]), ".", ",", 1, -1, CompareMethod.Text))));
			int num2 = dataTable.Rows.Count - 2;
			for (int i = 0; i <= num2; i++)
			{
				double num3 = Conversions.ToDouble(getAngulo(ax, ay, Conversions.ToDouble(Strings.Replace(Conversions.ToString(dataTable.Rows[i]["Latitud"]), ".", ",", 1, -1, CompareMethod.Text)), Conversions.ToDouble(Strings.Replace(Conversions.ToString(dataTable.Rows[i]["Longitud"]), ".", ",", 1, -1, CompareMethod.Text)), Conversions.ToDouble(Strings.Replace(Conversions.ToString(dataTable.Rows[i + 1]["Latitud"]), ".", ",", 1, -1, CompareMethod.Text)), Conversions.ToDouble(Strings.Replace(Conversions.ToString(dataTable.Rows[i + 1]["Longitud"]), ".", ",", 1, -1, CompareMethod.Text))));
				num += num3;
			}
			if (Math.Abs(num) > 1E-06)
			{
				Interaction.MsgBox("pertenece a zona " + dataTable.Rows[1]["zona"].ToString());
			}
			return Math.Abs(num) > 1E-06;
		}
	}

	public static object puntoenpoligono3(int valorzona, double Ax0, double Ay0)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		string text = "SELECT Latitud,Longitud,zona FROM Dibujos where Zona=" + Conversions.ToString(valorzona);
		DataTable dataTable = new DataTable("x");
		MySqlDataAdapter val = new MySqlDataAdapter(text, Mod_Sentencias.cnn);
		((DbDataAdapter)(object)val).Fill(dataTable);
		int count = dataTable.Rows.Count;
		double num = 0.0;
		checked
		{
			num = Conversions.ToDouble(getAngulo(Ax0, Ay0, Conversions.ToDouble(Strings.Replace(Conversions.ToString(dataTable.Rows[count - 1]["Latitud"]), ".", ",", 1, -1, CompareMethod.Text)), Conversions.ToDouble(Strings.Replace(Conversions.ToString(dataTable.Rows[count - 1]["Longitud"]), ".", ",", 1, -1, CompareMethod.Text)), Conversions.ToDouble(Strings.Replace(Conversions.ToString(dataTable.Rows[0]["Latitud"]), ".", ",", 1, -1, CompareMethod.Text)), Conversions.ToDouble(Strings.Replace(Conversions.ToString(dataTable.Rows[0]["Longitud"]), ".", ",", 1, -1, CompareMethod.Text))));
			int num2 = dataTable.Rows.Count - 2;
			for (int i = 0; i <= num2; i++)
			{
				double num3 = Conversions.ToDouble(getAngulo(Ax0, Ay0, Conversions.ToDouble(Strings.Replace(Conversions.ToString(dataTable.Rows[i]["Latitud"]), ".", ",", 1, -1, CompareMethod.Text)), Conversions.ToDouble(Strings.Replace(Conversions.ToString(dataTable.Rows[i]["Longitud"]), ".", ",", 1, -1, CompareMethod.Text)), Conversions.ToDouble(Strings.Replace(Conversions.ToString(dataTable.Rows[i + 1]["Latitud"]), ".", ",", 1, -1, CompareMethod.Text)), Conversions.ToDouble(Strings.Replace(Conversions.ToString(dataTable.Rows[i + 1]["Longitud"]), ".", ",", 1, -1, CompareMethod.Text))));
				num += num3;
			}
			return Math.Abs(num) > 1E-06;
		}
	}

	public static void detectar_zona(Label label2, Label label4)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		string text = "SELECT DISTINCT Zona FROM dibujos";
		DataTable dataTable = new DataTable("x");
		MySqlDataAdapter val = new MySqlDataAdapter(text, Mod_Sentencias.cnn);
		((DbDataAdapter)(object)val).Fill(dataTable);
		checked
		{
			int num = dataTable.Rows.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				puntoenpoligono2(Conversions.ToInteger(dataTable.Rows[i]["zona"].ToString()), label2, label4);
			}
		}
	}

	public static object verificarCuilCuit(string numero)
	{
		bool flag = false;
		checked
		{
			string value = Conversions.ToString(numero[numero.Length - 1]);
			numero = numero.Remove(numero.Length - 1);
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			string text = "5432765432";
			char[] array = text.ToCharArray();
			char[] array2 = numero.ToCharArray();
			int num4 = array2.Count() - 1;
			for (int i = 0; i <= num4; i++)
			{
				string value2 = Conversions.ToString(array2[i]);
				string value3 = Conversions.ToString(array[i]);
				value2 = Conversions.ToString(Conversions.ToDouble(value2) * Conversions.ToDouble(value3));
				num = (int)Math.Round((double)num + Conversions.ToDouble(value2));
			}
			num2 = unchecked(num % 11);
			num3 = num - num2 * 11;
			num3 = Math.Abs(num3);
			Interaction.MsgBox(num3);
			if (num3 > 9)
			{
				num3 = 11 - num3;
				num3 = Math.Abs(num3);
			}
			flag = (((double)num3 == Conversions.ToDouble(value)) ? true : false);
			return flag;
		}
	}

	public static object volumenProducto(int idproducto)
	{
		decimal num = 0.001m;
		try
		{
			string sql = "SELECT ROUND(alto * ancho * largo, 5) AS volumen FROM productos where id=" + Conversions.ToString(idproducto);
			num = Conversions.ToDecimal(Mod_Sentencias.dataValue(sql, "volumen"));
			if (decimal.Compare(num, 0m) == 0)
			{
				num = 0.001m;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Logger.e(ex2.Message + " - FUNCION: volumenProducto");
			ProjectData.ClearProjectError();
		}
		return num;
	}

	public static object volumenOrden(int ordenid)
	{
		decimal num = default(decimal);
		try
		{
			DataTable dataTable = (DataTable)Mod_Productos.productosOrden(ordenid);
			foreach (object row in dataTable.Rows)
			{
				object objectValue = RuntimeHelpers.GetObjectValue(row);
				decimal num2 = Conversions.ToDecimal(volumenProducto(Conversions.ToInteger(NewLateBinding.LateGet(objectValue, null, "item", new object[1] { "productid" }, null, null, null))));
				Logger.e(Conversions.ToString(num2) + " - FUNCION: volumenProducto");
				num2 = Conversions.ToDecimal(NewLateBinding.LateGet(null, typeof(Math), "Round", new object[2]
				{
					Operators.MultiplyObject(num2, NewLateBinding.LateGet(objectValue, null, "item", new object[1] { "unidades" }, null, null, null)),
					3
				}, null, null, null));
				Logger.e(Conversions.ToString(num2) + " - FUNCION: volumenProducto");
				num = Math.Round(decimal.Add(num, num2), 3);
				Logger.e(Conversions.ToString(num) + " - FUNCION: volumenProducto");
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Logger.e(ex2.Message + " - FUNCION: volumenOrden");
			ProjectData.ClearProjectError();
		}
		return num;
	}

	public static object CalculoDeCajas(int productId, int unidadesSolicitadas)
	{
		int num2 = default(int);
		try
		{
			string sql = "SELECT unXcaja FROM productos WHERE id=" + Conversions.ToString(productId) + " LIMIT 1";
			DataTable dataTable = (DataTable)Mod_Sentencias.data(sql);
			if (dataTable.Rows.Count != 1)
			{
				throw new Exception();
			}
			double num = 0.0;
			if (Operators.ConditionalCompareObjectGreater(dataTable.Rows[0]["unXcaja"], 1, TextCompare: true))
			{
				num = Conversions.ToDouble(Operators.DivideObject(unidadesSolicitadas, dataTable.Rows[0]["unXcaja"]));
			}
			num2 = ((num > 0.0) ? checked((int)num) : 0);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox("Exception capturada. " + ex2.Message);
			ProjectData.ClearProjectError();
		}
		return num2;
	}

	public static object CalculoDeInner(int productId, int unidadesSolicitadas)
	{
		int num2 = default(int);
		try
		{
			string sql = "SELECT unXinner FROM productos WHERE id=" + Conversions.ToString(productId) + " LIMIT 1";
			DataTable dataTable = (DataTable)Mod_Sentencias.data(sql);
			if (dataTable.Rows.Count != 1)
			{
				throw new Exception();
			}
			double num = 0.0;
			if (Operators.ConditionalCompareObjectGreater(dataTable.Rows[0]["unXinner"], 1, TextCompare: true))
			{
				num = Conversions.ToDouble(Operators.DivideObject(unidadesSolicitadas, dataTable.Rows[0]["unXinner"]));
			}
			num2 = ((num > 0.0) ? checked((int)num) : 0);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox("Exception capturada. " + ex2.Message);
			ProjectData.ClearProjectError();
		}
		return num2;
	}

	public static object UnidadesEnCajas(int productId, int cantidadCajas)
	{
		int num = default(int);
		try
		{
			string sql = "SELECT unXcaja FROM productos WHERE id=" + Conversions.ToString(productId) + " LIMIT 1";
			DataTable dataTable = (DataTable)Mod_Sentencias.data(sql);
			if (dataTable.Rows.Count != 1)
			{
				throw new Exception();
			}
			num = Conversions.ToInteger(Operators.MultiplyObject(cantidadCajas, dataTable.Rows[0]["unXcaja"]));
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox("Exception capturada. " + ex2.Message);
			ProjectData.ClearProjectError();
		}
		return num;
	}

	public static object UnidadesEnInner(int productId, int cantidadInners)
	{
		int num = default(int);
		try
		{
			string sql = "SELECT unXinner FROM productos WHERE id=" + Conversions.ToString(productId) + " LIMIT 1";
			DataTable dataTable = (DataTable)Mod_Sentencias.data(sql);
			if (dataTable.Rows.Count != 1)
			{
				throw new Exception();
			}
			num = Conversions.ToInteger(Operators.MultiplyObject(cantidadInners, dataTable.Rows[0]["unXinner"]));
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox("Exception capturada. " + ex2.Message);
			ProjectData.ClearProjectError();
		}
		return num;
	}
}
