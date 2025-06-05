using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;
using Newtonsoft.Json.Linq;

namespace Hermes;

[StandardModule]
internal sealed class Mod_Productos
{
	public struct datos_producto
	{
		public int productId;

		public int productUnidades;

		public string productEmpresa;

		public string productCodigo;

		public decimal productPrecio;

		public string productDescripcion;

		public int productVariaciones;

		public string productBarrcode;
	}

	public struct variaciones_producto
	{
		public int variacion_id;

		public int variacion_producto;

		public string variacion_descripcion;

		public int variacion_unidades;

		public decimal variacion_precio;
	}

	public struct Respuesta
	{
		public bool status;

		public string mensaje;

		public Mod_Ordenes.ProductoSolicitado producto;
	}

	public static object productosOrden(int orderid)
	{
		DataTable result = new DataTable();
		try
		{
			string sql = "SELECT productid, varid, unidades, precio FROM orderdetalle WHERE ordenId=" + Conversions.ToString(orderid);
			result = (DataTable)Mod_Sentencias.data(sql);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Logger.e(ex2.Message + " - FUNCION: productosOrden");
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static object listaProductos(int empresa)
	{
		string empty = string.Empty;
		string empty2 = string.Empty;
		string empty3 = string.Empty;
		List<datos_producto> list = new List<datos_producto>();
		checked
		{
			datos_producto datos_producto = default(datos_producto);
			object result;
			try
			{
				empty = $"http://api-interna.area54sa.com.ar/services/get_productos.php?token=R4sp33ry5423yXw&empresa={empresa}";
				HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(empty);
				httpWebRequest.Credentials = CredentialCache.DefaultCredentials;
				HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
				Stream responseStream = httpWebResponse.GetResponseStream();
				StreamReader streamReader = new StreamReader(responseStream);
				empty2 = streamReader.ReadToEnd();
				JObject val = JObject.Parse(empty2);
				int num = ((IEnumerable<JToken>)val["data"]).Count();
				int num2 = num - 1;
				for (int i = 0; i <= num2; i++)
				{
					datos_producto.productId = int.Parse((string)val["data"][(object)i][(object)"producto"]);
					datos_producto.productUnidades = int.Parse((string)val["data"][(object)i][(object)"unidades"]);
					datos_producto.productEmpresa = (string)val["data"][(object)i][(object)"empresa"];
					datos_producto.productCodigo = (string)val["data"][(object)i][(object)"codigo"];
					datos_producto.productPrecio = decimal.Parse(Strings.Replace((string)val["data"][(object)i][(object)"precio"], ".", ",", 1, -1, CompareMethod.Text));
					datos_producto.productDescripcion = (string)val["data"][(object)i][(object)"descripcion"];
					datos_producto.productVariaciones = int.Parse((string)val["data"][(object)i][(object)"variaciones"]);
					datos_producto.productBarrcode = (string)val["data"][(object)i][(object)"barrCode"];
					list.Add(datos_producto);
				}
				result = list;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Interaction.MsgBox(ex2.Message);
				datos_producto.productId = 0;
				datos_producto.productUnidades = 0;
				datos_producto.productEmpresa = Conversions.ToString(0);
				datos_producto.productCodigo = Conversions.ToString(0);
				datos_producto.productPrecio = default(decimal);
				datos_producto.productDescripcion = Conversions.ToString(0);
				datos_producto.productVariaciones = 0;
				datos_producto.productBarrcode = Conversions.ToString(0);
				result = datos_producto;
				ProjectData.ClearProjectError();
			}
			return result;
		}
	}

	public static object buscarProdPorCodigo(string value, List<datos_producto> lista)
	{
		datos_producto datos_producto = default(datos_producto);
		checked
		{
			int num = lista.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				if (Operators.CompareString(value, lista[i].productCodigo, TextCompare: true) == 0)
				{
					datos_producto.productBarrcode = lista[i].productBarrcode;
					datos_producto.productCodigo = lista[i].productCodigo;
					datos_producto.productDescripcion = lista[i].productDescripcion;
					datos_producto.productEmpresa = lista[i].productEmpresa;
					datos_producto.productId = lista[i].productId;
					datos_producto.productPrecio = lista[i].productPrecio;
					datos_producto.productUnidades = lista[i].productUnidades;
					datos_producto.productVariaciones = lista[i].productVariaciones;
					break;
				}
				if (Operators.CompareString(value, lista[i].productBarrcode, TextCompare: true) == 0)
				{
					datos_producto.productBarrcode = lista[i].productBarrcode;
					datos_producto.productCodigo = lista[i].productCodigo;
					datos_producto.productDescripcion = lista[i].productDescripcion;
					datos_producto.productEmpresa = lista[i].productEmpresa;
					datos_producto.productId = lista[i].productId;
					datos_producto.productPrecio = lista[i].productPrecio;
					datos_producto.productUnidades = lista[i].productUnidades;
					datos_producto.productVariaciones = lista[i].productVariaciones;
					break;
				}
			}
			return datos_producto;
		}
	}

	public static object buscarProdPorNombre(string value, List<datos_producto> lista)
	{
		datos_producto datos_producto = default(datos_producto);
		checked
		{
			int num = lista.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				if (Operators.CompareString(value, lista[i].productDescripcion, TextCompare: true) == 0)
				{
					datos_producto.productBarrcode = lista[i].productBarrcode;
					datos_producto.productCodigo = lista[i].productCodigo;
					datos_producto.productDescripcion = lista[i].productDescripcion;
					datos_producto.productEmpresa = lista[i].productEmpresa;
					datos_producto.productId = lista[i].productId;
					datos_producto.productPrecio = lista[i].productPrecio;
					datos_producto.productUnidades = lista[i].productUnidades;
					datos_producto.productVariaciones = lista[i].productVariaciones;
					break;
				}
			}
			return datos_producto;
		}
	}

	public static object variableSelection(int productid)
	{
		string empty = string.Empty;
		string empty2 = string.Empty;
		string empty3 = string.Empty;
		List<variaciones_producto> list = new List<variaciones_producto>();
		checked
		{
			variaciones_producto item = default(variaciones_producto);
			object result;
			try
			{
				empty = $"http://api-interna.area54sa.com.ar/services/get_variation.php?token=R4sp33ry5423yXw&prod={productid}";
				HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(empty);
				httpWebRequest.Credentials = CredentialCache.DefaultCredentials;
				HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
				Stream responseStream = httpWebResponse.GetResponseStream();
				StreamReader streamReader = new StreamReader(responseStream);
				empty2 = streamReader.ReadToEnd();
				JObject val = JObject.Parse(empty2);
				int num = ((IEnumerable<JToken>)val["data"]).Count();
				int num2 = num - 1;
				for (int i = 0; i <= num2; i++)
				{
					item.variacion_id = int.Parse((string)val["data"][(object)i][(object)"id"]);
					item.variacion_unidades = int.Parse((string)val["data"][(object)i][(object)"unidades"]);
					item.variacion_producto = int.Parse((string)val["data"][(object)i][(object)"producto"]);
					item.variacion_descripcion = (string)val["data"][(object)i][(object)"descripcion"];
					item.variacion_precio = decimal.Parse((string)val["data"][(object)i][(object)"precio"]);
					list.Add(item);
				}
				result = list;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Interaction.MsgBox(ex2.Message);
				item.variacion_id = 0;
				item.variacion_unidades = 0;
				item.variacion_producto = 0;
				item.variacion_descripcion = Conversions.ToString(0);
				result = list;
				ProjectData.ClearProjectError();
			}
			return result;
		}
	}

	public static void listViewProductos(ListView listview1, string sql, Label contador)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		checked
		{
			try
			{
				Mod_Sentencias.cnn.Open();
				MySqlCommand val = new MySqlCommand();
				MySqlCommand val2 = val;
				val2.CommandType = CommandType.Text;
				val2.CommandText = sql;
				val2.Connection = Mod_Sentencias.cnn;
				val2 = null;
				MySqlDataAdapter val3 = new MySqlDataAdapter();
				DataSet dataSet = new DataSet();
				val3.SelectCommand = val;
				((DbDataAdapter)(object)val3).Fill(dataSet, "Tabla");
				ListView listView = listview1;
				listView.Items.Clear();
				listView.View = View.Details;
				listView.GridLines = true;
				listView.FullRowSelect = true;
				listView.MultiSelect = false;
				listView.LabelEdit = false;
				listView.HideSelection = false;
				int num = dataSet.Tables["tabla"].Columns.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					listView.Columns.Add(dataSet.Tables["tabla"].Columns[i].Caption);
				}
				listView = null;
				DataTable dataTable = dataSet.Tables["tabla"];
				int num2 = dataTable.Rows.Count - 1;
				for (int j = 0; j <= num2; j++)
				{
					ListViewItem listViewItem = new ListViewItem(dataTable.Rows[j][0].ToString());
					int num3 = dataTable.Columns.Count - 1;
					for (int k = 1; k <= num3; k++)
					{
						listViewItem.SubItems.Add(dataTable.Rows[j][k].ToString());
					}
					listview1.Items.Add(listViewItem);
					if (j == 0)
					{
					}
				}
				dataTable = null;
				Mod_Sentencias.cnn.Close();
				contador.Text = Conversions.ToString(listview1.Items.Count);
				listview1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Mod_Sentencias.cnn.Close();
				Interaction.MsgBox(ex2.Message);
				ProjectData.ClearProjectError();
			}
		}
	}

	public static object getDestinos()
	{
		object result;
		try
		{
			List<Mod_Ordenes.Destino> list = new List<Mod_Ordenes.Destino>();
			string sql = "SELECT id, nombre, direccion, localidad, postal FROM destinos";
			DataTable dataTable = (DataTable)Mod_Sentencias.data(sql);
			foreach (object row in dataTable.Rows)
			{
				object objectValue = RuntimeHelpers.GetObjectValue(row);
				Mod_Ordenes.Destino item = default(Mod_Ordenes.Destino);
				item.id = Conversions.ToInteger(NewLateBinding.LateGet(objectValue, null, "item", new object[1] { "id" }, null, null, null));
				item.nombre = Conversions.ToString(NewLateBinding.LateGet(objectValue, null, "item", new object[1] { "nombre" }, null, null, null));
				item.direccion = Conversions.ToString(NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { "direccion" }, null, null, null));
				item.localidad = Conversions.ToString(NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { "localidad" }, null, null, null));
				item.postal = Conversions.ToString(NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { "postal" }, null, null, null));
				list.Add(item);
			}
			result = list;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Logger.e("Error: " + ex2.Message);
			result = VariantType.Null;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static object buscarDestinoPorNombre(string value, List<Mod_Ordenes.Destino> lista)
	{
		Mod_Ordenes.Destino destino = default(Mod_Ordenes.Destino);
		checked
		{
			int num = lista.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				if (Operators.CompareString(value, lista[i].nombre, TextCompare: true) == 0)
				{
					destino.id = lista[i].id;
					destino.nombre = lista[i].nombre;
					destino.direccion = lista[i].direccion;
					destino.postal = lista[i].postal;
					destino.localidad = lista[i].localidad;
					break;
				}
			}
			return destino;
		}
	}

	public static object setDestino(Mod_Ordenes.Destino newDestino)
	{
		int num = 0;
		object result;
		try
		{
			string sQL = "INSERT INTO destinos SET nombre='" + newDestino.nombre + "', direccion = '" + newDestino.direccion + "', postal = '" + newDestino.postal + "', localidad = '" + newDestino.localidad + "'";
			try
			{
				num = Conversions.ToInteger(Mod_ConeccionBD.BD_insert_ID(sQL));
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Logger.e("Error: " + ex2.Message);
				ProjectData.ClearProjectError();
			}
			result = num;
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception ex4 = ex3;
			result = num;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static object unidadesDisponibles(int producto, int variation, int empresa)
	{
		int num = 0;
		checked
		{
			try
			{
				string text = string.Empty;
				string empty = string.Empty;
				empty = ((variation != 0) ? ("select unidades from variaciones where id=" + Conversions.ToString(variation)) : ("Select unidades from stock where producto =" + Conversions.ToString(producto)));
				int num2 = int.Parse(Conversions.ToString(Mod_Sentencias.dataValue(empty, "unidades")));
				num = num2;
				string sql = "SELECT id from ordenes where empresa=" + Conversions.ToString(empresa) + " and estado=1";
				DataTable dataTable = (DataTable)Mod_Sentencias.data(sql);
				int num3 = 0;
				if (dataTable.Rows.Count > 0)
				{
					int num4 = dataTable.Rows.Count - 1;
					for (int i = 0; i <= num4; i++)
					{
						text = ((i != 0) ? Conversions.ToString(Operators.ConcatenateObject(text + ", ", dataTable.Rows[i][0])) : Conversions.ToString(dataTable.Rows[i][0]));
					}
				}
				string sql2 = "select sum(unidades) as sum from orderdetalle where ordenid in (" + text + ") and productid = " + Conversions.ToString(producto) + " and  varid=" + Conversions.ToString(variation);
				num3 = Conversions.ToInteger(Mod_Sentencias.dataValue(sql2, "sum"));
				num = num2 - num3;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			return num;
		}
	}

	public static object GetBarrCodewithCodeEmpresa(string codeEmpresa, int empresa)
	{
		string result = string.Empty;
		try
		{
			string sql = "SELECT barrcode from productos where codeEmpresa= '" + codeEmpresa + "' AND empresa=" + Conversions.ToString(empresa) + " LIMIT 1";
			DataTable dataTable = (DataTable)Mod_Sentencias.data(sql);
			if (dataTable.Rows.Count == 1)
			{
				result = Conversions.ToString(dataTable.Rows[0]["barrcode"]);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Logger.e(ex2.Message);
			result = string.Empty;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static object GetProductWithCodeEmpresa(string codeEmpresa, int empresa)
	{
		Respuesta respuesta = default(Respuesta);
		respuesta.status = false;
		try
		{
			string sql = "SELECT id, empresa, barrCode, descripcion, unXcaja, precio FROM productos WHERE codeEmpresa = '" + codeEmpresa + "' AND empresa = " + Conversions.ToString(empresa) + " LIMIT 1";
			DataTable dataTable = (DataTable)Mod_Sentencias.data(sql);
			if (dataTable.Rows.Count > 0)
			{
				Mod_Ordenes.ProductoSolicitado producto = default(Mod_Ordenes.ProductoSolicitado);
				producto.idProducto = Conversions.ToInteger(dataTable.Rows[0]["id"]);
				producto.empresa = Conversions.ToInteger(dataTable.Rows[0]["empresa"]);
				producto.codigoBarras = Conversions.ToString(dataTable.Rows[0]["barrCode"]);
				producto.descripcion = Conversions.ToString(dataTable.Rows[0]["descripcion"]);
				producto.unidadesPorBulto = Conversions.ToInteger(dataTable.Rows[0]["unXcaja"]);
				producto.precio = Conversions.ToDecimal(dataTable.Rows[0]["precio"]);
				producto.unidadesDisponibles = Conversions.ToInteger(unidadesDisponibles(producto.idProducto, 0, empresa));
				respuesta.status = true;
				respuesta.producto = producto;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			respuesta.status = false;
			respuesta.mensaje = ex2.Message;
			ProjectData.ClearProjectError();
		}
		return respuesta;
	}
}
