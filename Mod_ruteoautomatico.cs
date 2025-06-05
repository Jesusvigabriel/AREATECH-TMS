using System.Data;
using Hermes.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Hermes;

[StandardModule]
internal sealed class Mod_ruteoautomatico
{
	public static object vehiculosRuteoAutomatico()
	{
		string sql = "SELECT numero FROM Flota WHERE Categoria=1 AND estado='Activo' AND disponible='Si'";
		return (DataTable)Mod_Sentencias.data(sql);
	}

	public static object clientesRuteoAutomatico()
	{
		string sql = "SELECT Nombre FROM Clientes WHERE Nombre='ETRANS'";
		return (DataTable)Mod_Sentencias.data(sql);
	}

	public static object zonasRuteoAutomatico(DataTable clientesRA)
	{
		string text = string.Empty;
		checked
		{
			int num = clientesRA.Rows.Count - 1;
			if (num > 0)
			{
				int num2 = num;
				for (int i = 0; i <= num2; i++)
				{
					text = Conversions.ToString(Operators.AddObject(text, clientesRA.Rows[i]["Nombre"]));
					if (i > num)
					{
						text += ", ";
					}
				}
			}
			else
			{
				text = Conversions.ToString(clientesRA.Rows[0]["Nombre"]);
			}
			string text2 = Strings.Format(MyProject.Forms.Form1_Inicio.DateTimePicker1.Value, "yyyyMMdd");
			string sql = "SELECT DISTINCT zona FROM Planchada where cliente in('" + text + "') AND fecha='" + text2 + "' AND Chofer=0";
			return (DataTable)Mod_Sentencias.data(sql);
		}
	}

	public static object guiasRuteoAutomatico(int zonaRA)
	{
		string sql = "SELECT guia FROM Planchada WHERE cliente='ETRANS' AND chofer=0 AND estado='En Planchada' AND zona=" + Conversions.ToString(zonaRA);
		return (DataTable)Mod_Sentencias.data(sql);
	}

	public static void ruteoAutomatico()
	{
		DataTable clientesRA = (DataTable)clientesRuteoAutomatico();
		DataTable dataTable = (DataTable)zonasRuteoAutomatico(clientesRA);
		checked
		{
			int num = dataTable.Rows.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				DataTable dataTable2 = (DataTable)guiasRuteoAutomatico(Conversions.ToInteger(dataTable.Rows[i]["zonas"]));
				DataTable dataTable3 = (DataTable)vehiculosRuteoAutomatico();
				int num2 = dataTable2.Rows.Count - 1;
				for (int j = 0; j <= num2; j++)
				{
					if (!Operators.ConditionalCompareObjectLess(capacidadVehiculo(Conversions.ToInteger(dataTable3.Rows[0]["numero"])), capacidadOcupadaVehiculo(Conversions.ToInteger(dataTable3.Rows[0]["numero"])), TextCompare: true) || Operators.ConditionalCompareObjectLess(cantidadDeEntregas(Conversions.ToInteger(dataTable3.Rows[0]["numero"])), cantidadEntregasActuales(Conversions.ToInteger(dataTable3.Rows[0]["numero"])), TextCompare: true))
					{
					}
				}
			}
		}
	}

	public static object capacidadVehiculo(int chofer)
	{
		double num = default(double);
		return num;
	}

	public static object capacidadOcupadaVehiculo(int chofer)
	{
		double num = default(double);
		return num;
	}

	public static object cantidadDeEntregas(int chofer)
	{
		double num = default(double);
		return num;
	}

	public static object cantidadEntregasActuales(int chofer)
	{
		double num = default(double);
		return num;
	}

	public static object nodoPrincipal()
	{
		return VariantType.Null;
	}

	public static object puntoInicial()
	{
		return VariantType.Null;
	}

	public static object puntoFinal()
	{
		return VariantType.Null;
	}

	public static object siguientePunto()
	{
		return VariantType.Null;
	}

	public static object GuiasParaRutear(string DiaDeDespacho, int CapacidadEntregaTotal)
	{
		DataSet result = null;
		string text = "SELECT id_envio FROM etransenvios WHERE D_fecha='" + DiaDeDespacho + "' ORDER BY id_envio asc LIMIT " + Conversions.ToString(CapacidadEntregaTotal);
		return result;
	}
}
