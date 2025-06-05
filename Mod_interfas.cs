using System.Collections.Generic;
using System.Data;
using System.Runtime.CompilerServices;
using Hermes.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Hermes;

[StandardModule]
internal sealed class Mod_interfas
{
	public struct lineaOrden
	{
		public string remitos;

		public string fecha;

		public string destino;

		public string domicilio;

		public string localidad;

		public string descripcion;

		public string kilos;

		public string bultos;

		public string mt3;

		public string valor;

		public string valorctr;

		public string observacion;
	}

	public struct CheckedOrdenes
	{
		public int id;
	}

	public static void distribucionOrdenes(int empresa)
	{
		string sql = "SELECT o.id, o.tipo, o.numero, d.nombre, d.direccion, sum(u.unidades) as bultos, d.postal , o.valor, o.valor_ctr, o.observ, o.fechaPreparado FROM ordenes o LEFT JOIN destinos d ON d.id = o.eventual LEFT JOIN orderdetalle u ON u.ordenId = o.id WHERE o.estado = 2 AND o.empresa = " + Conversions.ToString(empresa) + " GROUP BY o.id";
		DataTable dataTable = (DataTable)Mod_Sentencias.data(sql);
		DataTable dataTable2 = new DataTable();
		dataTable2.Columns.Add("id");
		dataTable2.Columns.Add("remitos");
		dataTable2.Columns.Add("fecha");
		dataTable2.Columns.Add("destino");
		dataTable2.Columns.Add("domicilio");
		dataTable2.Columns.Add("localidad");
		dataTable2.Columns.Add("descripcion");
		dataTable2.Columns.Add("kilos");
		dataTable2.Columns.Add("bultos");
		dataTable2.Columns.Add("mt3");
		dataTable2.Columns.Add("valor");
		dataTable2.Columns.Add("valorctr");
		dataTable2.Columns.Add("observacion");
		foreach (object row in dataTable.Rows)
		{
			object objectValue = RuntimeHelpers.GetObjectValue(row);
			DataRow dataRow = dataTable2.NewRow();
			string text = NewLateBinding.LateGet(objectValue, null, "item", new object[1] { "tipo" }, null, null, null).ToString();
			text = text.PadLeft(4, '0');
			string text2 = NewLateBinding.LateGet(objectValue, null, "item", new object[1] { "numero" }, null, null, null).ToString();
			string text3 = ((text2.Length <= 8) ? text2.PadLeft(8, '0') : text2.Substring(checked(text2.Length - 8), 8));
			dataRow["id"] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, null, "item", new object[1] { "id" }, null, null, null));
			dataRow["remitos"] = text + text3;
			dataRow["fecha"] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, null, "item", new object[1] { "fechaPreparado" }, null, null, null));
			dataRow["destino"] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, null, "item", new object[1] { "nombre" }, null, null, null));
			dataRow["domicilio"] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, null, "item", new object[1] { "direccion" }, null, null, null));
			dataRow["localidad"] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, null, "item", new object[1] { "postal" }, null, null, null));
			dataRow["descripcion"] = "";
			dataRow["kilos"] = 1;
			string sql2 = "SELECT bultos FROM bultosorden WHERE empresa = " + Conversions.ToString(empresa) + " AND ordenId = '" + text2 + "' LIMIT 1";
			DataTable dataTable3 = (DataTable)Mod_Sentencias.data(sql2);
			if (dataTable3.Rows.Count > 0)
			{
				dataRow["bultos"] = RuntimeHelpers.GetObjectValue(dataTable3.Rows[0]["bultos"]);
			}
			else
			{
				dataRow["bultos"] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, null, "item", new object[1] { "bultos" }, null, null, null));
			}
			dataRow["mt3"] = "'" + Mod_Calculos.volumenOrden(Conversions.ToInteger(NewLateBinding.LateGet(objectValue, null, "item", new object[1] { "id" }, null, null, null))).ToString();
			dataRow["valor"] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, null, "item", new object[1] { "valor" }, null, null, null));
			dataRow["valorctr"] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, null, "item", new object[1] { "valor_ctr" }, null, null, null));
			dataRow["observacion"] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, null, "item", new object[1] { "observ" }, null, null, null));
			dataTable2.Rows.Add(dataRow);
			string sQL = Conversions.ToString(Operators.ConcatenateObject("UPDATE ordenes SET estado=3, usuario='" + MySettingsProperty.Settings.Usuario + "' WHERE id=", dataRow["id"]));
			Mod_ConeccionBD.BD_Sentencia(sQL);
		}
		Mod_Exportar.DataToExcel(dataTable2);
	}

	public static void hdrOrdenes(int empresa)
	{
		string sql = "SELECT o.id, o.tipo, o.numero, d.nombre, d.direccion, sum(u.unidades) as bultos, d.postal , o.valor, o.valor_ctr, o.observ, o.fechaPreparado FROM ordenes o LEFT JOIN destinos d ON d.id = o.eventual LEFT JOIN orderdetalle u ON u.ordenId = o.id WHERE o.estado = 2 AND o.empresa = " + Conversions.ToString(empresa) + " GROUP BY o.id";
		DataTable dataTable = (DataTable)Mod_Sentencias.data(sql);
		DataTable dataTable2 = new DataTable();
		dataTable2.Columns.Add("id");
		dataTable2.Columns.Add("remitos");
		dataTable2.Columns.Add("fecha");
		dataTable2.Columns.Add("destino");
		dataTable2.Columns.Add("domicilio");
		dataTable2.Columns.Add("localidad");
		dataTable2.Columns.Add("descripcion");
		dataTable2.Columns.Add("kilos");
		dataTable2.Columns.Add("bultos");
		dataTable2.Columns.Add("mt3");
		dataTable2.Columns.Add("valor");
		dataTable2.Columns.Add("valorctr");
		dataTable2.Columns.Add("observacion");
		foreach (object row in dataTable.Rows)
		{
			object objectValue = RuntimeHelpers.GetObjectValue(row);
			DataRow dataRow = dataTable2.NewRow();
			string text = NewLateBinding.LateGet(objectValue, null, "item", new object[1] { "tipo" }, null, null, null).ToString();
			text = text.PadLeft(4, '0');
			string text2 = NewLateBinding.LateGet(objectValue, null, "item", new object[1] { "numero" }, null, null, null).ToString();
			string text3 = ((text2.Length <= 8) ? text2.PadLeft(8, '0') : text2.Substring(checked(text2.Length - 8), 8));
			dataRow["id"] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, null, "item", new object[1] { "id" }, null, null, null));
			dataRow["remitos"] = text + text3;
			dataRow["fecha"] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, null, "item", new object[1] { "fechaPreparado" }, null, null, null));
			dataRow["destino"] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, null, "item", new object[1] { "nombre" }, null, null, null));
			dataRow["domicilio"] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, null, "item", new object[1] { "direccion" }, null, null, null));
			dataRow["localidad"] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, null, "item", new object[1] { "postal" }, null, null, null));
			dataRow["descripcion"] = "";
			dataRow["kilos"] = 1;
			string sql2 = "SELECT bultos FROM bultosorden WHERE empresa = " + Conversions.ToString(empresa) + " AND ordenId = '" + text2 + "' LIMIT 1";
			DataTable dataTable3 = (DataTable)Mod_Sentencias.data(sql2);
			if (dataTable3.Rows.Count > 0)
			{
				dataRow["bultos"] = RuntimeHelpers.GetObjectValue(dataTable3.Rows[0]["bultos"]);
			}
			else
			{
				dataRow["bultos"] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, null, "item", new object[1] { "bultos" }, null, null, null));
			}
			dataRow["mt3"] = "'" + Mod_Calculos.volumenOrden(Conversions.ToInteger(NewLateBinding.LateGet(objectValue, null, "item", new object[1] { "id" }, null, null, null))).ToString();
			dataRow["valor"] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, null, "item", new object[1] { "valor" }, null, null, null));
			dataRow["valorctr"] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, null, "item", new object[1] { "valor_ctr" }, null, null, null));
			dataRow["observacion"] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, null, "item", new object[1] { "observ" }, null, null, null));
			dataTable2.Rows.Add(dataRow);
		}
		Mod_Exportar.DataToExcel(dataTable2);
	}

	public static void ExportarCheckedOrdenes(int empresa, List<CheckedOrdenes> listOrdenes)
	{
		string text = string.Empty;
		checked
		{
			int num = listOrdenes.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				text = ((i != 0) ? (text + ", " + listOrdenes[i].id) : (text + listOrdenes[i].id));
			}
			Interaction.MsgBox(text);
			string sql = "SELECT o.id, o.tipo, o.numero, d.nombre, d.direccion, sum(u.unidades) as bultos, d.postal , o.valor, o.valor_ctr, o.observ, o.fechaPreparado FROM ordenes o LEFT JOIN destinos d ON d.id = o.eventual LEFT JOIN orderdetalle u ON u.ordenId = o.id WHERE o.estado = 2 AND o.empresa = " + Conversions.ToString(empresa) + " AND o.id in (" + text + ") GROUP BY o.id";
			DataTable dataTable = (DataTable)Mod_Sentencias.data(sql);
			DataTable dataTable2 = new DataTable();
			dataTable2.Columns.Add("id");
			dataTable2.Columns.Add("remitos");
			dataTable2.Columns.Add("fecha");
			dataTable2.Columns.Add("destino");
			dataTable2.Columns.Add("domicilio");
			dataTable2.Columns.Add("localidad");
			dataTable2.Columns.Add("descripcion");
			dataTable2.Columns.Add("kilos");
			dataTable2.Columns.Add("bultos");
			dataTable2.Columns.Add("mt3");
			dataTable2.Columns.Add("valor");
			dataTable2.Columns.Add("valorctr");
			dataTable2.Columns.Add("observacion");
			foreach (object row in dataTable.Rows)
			{
				object objectValue = RuntimeHelpers.GetObjectValue(row);
				string sql2 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("SELECT sum(peso) as kilos FROM productos WHERE id In (SELECT productId FROM orderdetalle WHERE ordenId = ", NewLateBinding.LateGet(objectValue, null, "item", new object[1] { "id" }, null, null, null)), ")"));
				DataTable dataTable3 = (DataTable)Mod_Sentencias.data(sql2);
				DataRow dataRow = dataTable2.NewRow();
				string text2 = NewLateBinding.LateGet(objectValue, null, "item", new object[1] { "tipo" }, null, null, null).ToString();
				text2 = text2.PadLeft(4, '0');
				string text3 = NewLateBinding.LateGet(objectValue, null, "item", new object[1] { "numero" }, null, null, null).ToString();
				string text4 = ((text3.Length <= 8) ? text3.PadLeft(8, '0') : text3.Substring(text3.Length - 8, 8));
				dataRow["id"] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, null, "item", new object[1] { "id" }, null, null, null));
				dataRow["remitos"] = text2 + text4;
				dataRow["fecha"] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, null, "item", new object[1] { "fechaPreparado" }, null, null, null));
				dataRow["destino"] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, null, "item", new object[1] { "nombre" }, null, null, null));
				dataRow["domicilio"] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, null, "item", new object[1] { "direccion" }, null, null, null));
				dataRow["localidad"] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, null, "item", new object[1] { "postal" }, null, null, null));
				dataRow["descripcion"] = "";
				dataRow["kilos"] = RuntimeHelpers.GetObjectValue(dataTable3.Rows[0]["kilos"]);
				string sql3 = "SELECT bultos FROM bultosorden WHERE empresa = " + Conversions.ToString(empresa) + " AND ordenId = '" + text3 + "' LIMIT 1";
				DataTable dataTable4 = (DataTable)Mod_Sentencias.data(sql3);
				if (dataTable4.Rows.Count > 0)
				{
					dataRow["bultos"] = RuntimeHelpers.GetObjectValue(dataTable4.Rows[0]["bultos"]);
				}
				else
				{
					dataRow["bultos"] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, null, "item", new object[1] { "bultos" }, null, null, null));
				}
				dataRow["mt3"] = "'" + Mod_Calculos.volumenOrden(Conversions.ToInteger(NewLateBinding.LateGet(objectValue, null, "item", new object[1] { "id" }, null, null, null))).ToString();
				dataRow["valor"] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, null, "item", new object[1] { "valor" }, null, null, null));
				dataRow["valorctr"] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, null, "item", new object[1] { "valor_ctr" }, null, null, null));
				dataRow["observacion"] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, null, "item", new object[1] { "observ" }, null, null, null));
				dataTable2.Rows.Add(dataRow);
			}
			Mod_Exportar.DataToExcel(dataTable2);
		}
	}

	public static void ADistribucionOrdenes(int empresa, List<CheckedOrdenes> listOrdenes)
	{
		string text = string.Empty;
		checked
		{
			int num = listOrdenes.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				text = ((i != 0) ? (text + ", " + listOrdenes[i].id) : (text + listOrdenes[i].id));
			}
			string sql = "SELECT o.id, o.tipo, o.numero, d.nombre, d.direccion, sum(u.unidades) as bultos, d.postal , o.valor, o.valor_ctr, o.observ, o.fechaPreparado FROM ordenes o LEFT JOIN destinos d ON d.id = o.eventual LEFT JOIN orderdetalle u ON u.ordenId = o.id WHERE o.estado = 2 AND o.empresa = " + Conversions.ToString(empresa) + " AND o.id in (" + text + ") GROUP BY o.id";
			DataTable dataTable = (DataTable)Mod_Sentencias.data(sql);
			DataTable dataTable2 = new DataTable();
			dataTable2.Columns.Add("id");
			dataTable2.Columns.Add("remitos");
			dataTable2.Columns.Add("fecha");
			dataTable2.Columns.Add("destino");
			dataTable2.Columns.Add("domicilio");
			dataTable2.Columns.Add("localidad");
			dataTable2.Columns.Add("descripcion");
			dataTable2.Columns.Add("kilos");
			dataTable2.Columns.Add("bultos");
			dataTable2.Columns.Add("mt3");
			dataTable2.Columns.Add("valor");
			dataTable2.Columns.Add("valorctr");
			dataTable2.Columns.Add("observacion");
			foreach (object row in dataTable.Rows)
			{
				object objectValue = RuntimeHelpers.GetObjectValue(row);
				string sql2 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("SELECT sum(peso) as kilos FROM productos WHERE id In (SELECT productId FROM orderdetalle WHERE ordenId = ", NewLateBinding.LateGet(objectValue, null, "item", new object[1] { "id" }, null, null, null)), ")"));
				DataTable dataTable3 = (DataTable)Mod_Sentencias.data(sql2);
				DataRow dataRow = dataTable2.NewRow();
				string text2 = NewLateBinding.LateGet(objectValue, null, "item", new object[1] { "tipo" }, null, null, null).ToString();
				text2 = text2.PadLeft(4, '0');
				string text3 = NewLateBinding.LateGet(objectValue, null, "item", new object[1] { "numero" }, null, null, null).ToString();
				string text4 = ((text3.Length <= 8) ? text3.PadLeft(8, '0') : text3.Substring(text3.Length - 8, 8));
				dataRow["id"] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, null, "item", new object[1] { "id" }, null, null, null));
				dataRow["remitos"] = text2 + text4;
				dataRow["fecha"] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, null, "item", new object[1] { "fechaPreparado" }, null, null, null));
				dataRow["destino"] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, null, "item", new object[1] { "nombre" }, null, null, null));
				dataRow["domicilio"] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, null, "item", new object[1] { "direccion" }, null, null, null));
				dataRow["localidad"] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, null, "item", new object[1] { "postal" }, null, null, null));
				dataRow["descripcion"] = "";
				dataRow["kilos"] = RuntimeHelpers.GetObjectValue(dataTable3.Rows[0]["kilos"]);
				string sql3 = "SELECT bultos FROM bultosorden WHERE empresa = " + Conversions.ToString(empresa) + " AND ordenId = '" + text3 + "' LIMIT 1";
				DataTable dataTable4 = (DataTable)Mod_Sentencias.data(sql3);
				if (dataTable4.Rows.Count > 0)
				{
					dataRow["bultos"] = RuntimeHelpers.GetObjectValue(dataTable4.Rows[0]["bultos"]);
				}
				else
				{
					dataRow["bultos"] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, null, "item", new object[1] { "bultos" }, null, null, null));
				}
				dataRow["mt3"] = "'" + Mod_Calculos.volumenOrden(Conversions.ToInteger(NewLateBinding.LateGet(objectValue, null, "item", new object[1] { "id" }, null, null, null))).ToString();
				dataRow["valor"] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, null, "item", new object[1] { "valor" }, null, null, null));
				dataRow["valorctr"] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, null, "item", new object[1] { "valor_ctr" }, null, null, null));
				dataRow["observacion"] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, null, "item", new object[1] { "observ" }, null, null, null));
				dataTable2.Rows.Add(dataRow);
				string sQL = Conversions.ToString(Operators.ConcatenateObject("UPDATE ordenes SET estado=3, usuario='" + MySettingsProperty.Settings.Usuario + "' WHERE id=", dataRow["id"]));
				Mod_ConeccionBD.BD_Sentencia(sQL);
			}
			Mod_Exportar.DataToExcel(dataTable2);
		}
	}

	public static void ExportarOrdenesAExcel(int empresa, List<CheckedOrdenes> listOrdenes)
	{
		string text = string.Empty;
		checked
		{
			int num = listOrdenes.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				text = ((i != 0) ? (text + ", " + listOrdenes[i].id) : (text + listOrdenes[i].id));
			}
			string sql = "SELECT o.id, o.tipo, o.numero, d.nombre, d.direccion, sum(u.unidades) as bultos, d.postal , o.valor, o.valor_ctr, o.observ, o.fechaPreparado FROM ordenes o LEFT JOIN destinos d ON d.id = o.eventual LEFT JOIN orderdetalle u ON u.ordenId = o.id WHERE o.empresa = " + Conversions.ToString(empresa) + " AND o.id in (" + text + ") GROUP BY o.id";
			DataTable dataTable = (DataTable)Mod_Sentencias.data(sql);
			DataTable dataTable2 = new DataTable();
			dataTable2.Columns.Add("id");
			dataTable2.Columns.Add("remitos");
			dataTable2.Columns.Add("fecha");
			dataTable2.Columns.Add("destino");
			dataTable2.Columns.Add("domicilio");
			dataTable2.Columns.Add("localidad");
			dataTable2.Columns.Add("descripcion");
			dataTable2.Columns.Add("kilos");
			dataTable2.Columns.Add("bultos");
			dataTable2.Columns.Add("mt3");
			dataTable2.Columns.Add("valor");
			dataTable2.Columns.Add("valorctr");
			dataTable2.Columns.Add("observacion");
			foreach (object row in dataTable.Rows)
			{
				object objectValue = RuntimeHelpers.GetObjectValue(row);
				string sql2 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("SELECT sum(peso) as kilos FROM productos WHERE id In (SELECT productId FROM orderdetalle WHERE ordenId = ", NewLateBinding.LateGet(objectValue, null, "item", new object[1] { "id" }, null, null, null)), ")"));
				DataTable dataTable3 = (DataTable)Mod_Sentencias.data(sql2);
				DataRow dataRow = dataTable2.NewRow();
				string text2 = NewLateBinding.LateGet(objectValue, null, "item", new object[1] { "tipo" }, null, null, null).ToString();
				text2 = text2.PadLeft(4, '0');
				string text3 = NewLateBinding.LateGet(objectValue, null, "item", new object[1] { "numero" }, null, null, null).ToString();
				string text4 = ((text3.Length <= 8) ? text3.PadLeft(8, '0') : text3.Substring(text3.Length - 8, 8));
				dataRow["id"] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, null, "item", new object[1] { "id" }, null, null, null));
				dataRow["remitos"] = text2 + text4;
				dataRow["fecha"] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, null, "item", new object[1] { "fechaPreparado" }, null, null, null));
				dataRow["destino"] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, null, "item", new object[1] { "nombre" }, null, null, null));
				dataRow["domicilio"] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, null, "item", new object[1] { "direccion" }, null, null, null));
				dataRow["localidad"] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, null, "item", new object[1] { "postal" }, null, null, null));
				dataRow["descripcion"] = "";
				dataRow["kilos"] = RuntimeHelpers.GetObjectValue(dataTable3.Rows[0]["kilos"]);
				string sql3 = "SELECT bultos FROM bultosorden WHERE empresa = " + Conversions.ToString(empresa) + " AND ordenId = '" + text3 + "' LIMIT 1";
				DataTable dataTable4 = (DataTable)Mod_Sentencias.data(sql3);
				if (dataTable4.Rows.Count > 0)
				{
					dataRow["bultos"] = RuntimeHelpers.GetObjectValue(dataTable4.Rows[0]["bultos"]);
				}
				else
				{
					dataRow["bultos"] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, null, "item", new object[1] { "bultos" }, null, null, null));
				}
				dataRow["mt3"] = "'" + Mod_Calculos.volumenOrden(Conversions.ToInteger(NewLateBinding.LateGet(objectValue, null, "item", new object[1] { "id" }, null, null, null))).ToString();
				dataRow["valor"] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, null, "item", new object[1] { "valor" }, null, null, null));
				dataRow["valorctr"] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, null, "item", new object[1] { "valor_ctr" }, null, null, null));
				dataRow["observacion"] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, null, "item", new object[1] { "observ" }, null, null, null));
				dataTable2.Rows.Add(dataRow);
			}
			Mod_Exportar.DataToExcel(dataTable2);
		}
	}

	public static void ExportarInformeOrdenesAExcel(int empresa, List<CheckedOrdenes> listOrdenes)
	{
		string text = string.Empty;
		checked
		{
			int num = listOrdenes.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				text = ((i != 0) ? (text + ", " + listOrdenes[i].id) : (text + listOrdenes[i].id));
			}
			string sql = "SELECT o.id, o.tipo, o.numero, d.nombre, d.direccion, sum(u.unidades) as bultos, d.postal , o.valor, o.valor_ctr, o.observ, o.fechaPreparado FROM ordenes o LEFT JOIN destinos d ON d.id = o.eventual LEFT JOIN orderdetalle u ON u.ordenId = o.id WHERE o.empresa = " + Conversions.ToString(empresa) + " AND o.id in (" + text + ") GROUP BY o.id";
			DataTable dataTable = (DataTable)Mod_Sentencias.data(sql);
			DataTable dataTable2 = new DataTable();
			dataTable2.Columns.Add("id");
			dataTable2.Columns.Add("remitos");
			dataTable2.Columns.Add("fecha");
			dataTable2.Columns.Add("destino");
			dataTable2.Columns.Add("domicilio");
			dataTable2.Columns.Add("localidad");
			dataTable2.Columns.Add("descripcion");
			dataTable2.Columns.Add("kilos");
			dataTable2.Columns.Add("bultos");
			dataTable2.Columns.Add("Metros");
			dataTable2.Columns.Add("mt3");
			dataTable2.Columns.Add("valor");
			dataTable2.Columns.Add("valorctr");
			dataTable2.Columns.Add("observacion");
			foreach (object row in dataTable.Rows)
			{
				object objectValue = RuntimeHelpers.GetObjectValue(row);
				string sql2 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("SELECT sum(peso) as kilos FROM productos WHERE id In (SELECT productId FROM orderdetalle WHERE ordenId = ", NewLateBinding.LateGet(objectValue, null, "item", new object[1] { "id" }, null, null, null)), ")"));
				DataTable dataTable3 = (DataTable)Mod_Sentencias.data(sql2);
				string sql3 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("SELECT sum(ancho) as metros FROM productos WHERE id In (SELECT productId FROM orderdetalle WHERE ordenId = ", NewLateBinding.LateGet(objectValue, null, "item", new object[1] { "id" }, null, null, null)), ")"));
				DataTable dataTable4 = (DataTable)Mod_Sentencias.data(sql3);
				DataRow dataRow = dataTable2.NewRow();
				string text2 = NewLateBinding.LateGet(objectValue, null, "item", new object[1] { "tipo" }, null, null, null).ToString();
				text2 = text2.PadLeft(4, '0');
				string text3 = NewLateBinding.LateGet(objectValue, null, "item", new object[1] { "numero" }, null, null, null).ToString();
				string text4 = ((text3.Length <= 8) ? text3.PadLeft(8, '0') : text3.Substring(text3.Length - 8, 8));
				dataRow["id"] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, null, "item", new object[1] { "id" }, null, null, null));
				dataRow["remitos"] = text2 + text4;
				dataRow["fecha"] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, null, "item", new object[1] { "fechaPreparado" }, null, null, null));
				dataRow["destino"] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, null, "item", new object[1] { "nombre" }, null, null, null));
				dataRow["domicilio"] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, null, "item", new object[1] { "direccion" }, null, null, null));
				dataRow["localidad"] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, null, "item", new object[1] { "postal" }, null, null, null));
				dataRow["descripcion"] = "";
				dataRow["kilos"] = Operators.ConcatenateObject("'", dataTable3.Rows[0]["kilos"]);
				string sql4 = "SELECT bultos FROM bultosorden WHERE empresa = " + Conversions.ToString(empresa) + " AND ordenId = '" + text3 + "' LIMIT 1";
				DataTable dataTable5 = (DataTable)Mod_Sentencias.data(sql4);
				if (dataTable5.Rows.Count > 0)
				{
					dataRow["bultos"] = RuntimeHelpers.GetObjectValue(dataTable5.Rows[0]["bultos"]);
				}
				else
				{
					dataRow["bultos"] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, null, "item", new object[1] { "bultos" }, null, null, null));
				}
				dataRow["Metros"] = Operators.ConcatenateObject("'", dataTable4.Rows[0]["metros"]);
				dataRow["mt3"] = "'" + Mod_Calculos.volumenOrden(Conversions.ToInteger(NewLateBinding.LateGet(objectValue, null, "item", new object[1] { "id" }, null, null, null))).ToString();
				dataRow["valor"] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, null, "item", new object[1] { "valor" }, null, null, null));
				dataRow["valorctr"] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, null, "item", new object[1] { "valor_ctr" }, null, null, null));
				dataRow["observacion"] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, null, "item", new object[1] { "observ" }, null, null, null));
				dataTable2.Rows.Add(dataRow);
			}
			Mod_Exportar.DataToExcel(dataTable2);
		}
	}
}
