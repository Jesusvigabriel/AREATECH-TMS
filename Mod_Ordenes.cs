using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;
using Newtonsoft.Json.Linq;

namespace Hermes;

[StandardModule]
internal sealed class Mod_Ordenes
{
	public struct ordendesalida
	{
		public int id;

		public int empresa;

		public int tipo;

		public string numero;

		public int destinatario;

		public decimal valor;

		public decimal valorCtr;

		public int prioridad;

		public int estado;

		public string observacion;

		public DateTime fecha;
	}

	public struct ordenDetalleItem
	{
		public int ordenId;

		public int productId;

		public int varId;

		public int unidades;

		public decimal precio;
	}

	public struct orderDetallePrint
	{
		public int id;

		public int unidades;

		public string producto;

		public string codigo;

		public string codigoempresa;

		public int variacion;

		public string alto;

		public string ancho;

		public string largo;

		public string peso;

		public string precio;

		public string posicion;
	}

	public struct Destino
	{
		public int id;

		public string nombre;

		public string direccion;

		public string localidad;

		public string postal;
	}

	public struct envioArea
	{
		public string estado;

		public string guia;

		public string comprobante;

		public string cliente;

		public string destino;

		public string remito;

		public string bultos;

		public string atraso;

		public string observaciones;

		public string fecha;

		public string comentario;
	}

	public struct NuevaOrdenCompleta
	{
		public string action;

		public int user;

		public string token;

		public OrdenCompleta order;
	}

	public struct OrdenCompleta
	{
		public string doc;

		public string number;

		public Addressee addressee;

		public string ctr;

		public string note;

		public string value;

		public OrderItems items;
	}

	public struct Addressee
	{
		public string name;

		public string address;

		public string postal;

		public string loc;
	}

	public struct OrderItems
	{
		public int totalitems;

		public List<OrderItem> list;
	}

	public struct OrderItem
	{
		public string barrcode;

		public string unidades;
	}

	public struct OrdenAIngresar
	{
		public int empresa;

		public int tipo;

		public string numero;

		public EventualDestino eventual;

		public decimal valor;

		public string observaciones;

		public int prioridad;

		public decimal contraReembolso;

		public ListaProductosSolicitados productos;
	}

	public struct EventualDestino
	{
		public string nombre;

		public string direccion;

		public string codigoPostal;

		public string localidada;
	}

	public struct ProductoSolicitado
	{
		public int insertId;

		public int idProducto;

		public int empresa;

		public string codigoBarras;

		public string descripcion;

		public int unidadesDisponibles;

		public int unidadesSolicitadas;

		public int variacionSolicitada;

		public decimal precio;

		public int unidadesPorBulto;
	}

	public struct ListaProductosSolicitados
	{
		public int totalProductos;

		public List<ProductoSolicitado> listaProductos;
	}

	public static int status;

	public static string mensaje;

	public static string eMensaje;

	private static int ordenid;

	private static int eventualId;

	public static object guardarOrdenSalida(ordendesalida values)
	{
		object result;
		try
		{
			int empresa = values.empresa;
			int tipo = values.tipo;
			string numero = values.numero;
			int destinatario = values.destinatario;
			string text = Strings.Replace(values.valor.ToString(), ",", ".", 1, -1, CompareMethod.Text);
			int estado = values.estado;
			string sQL = "INSERT INTO ordenes (empresa, tipo, numero, eventual, valor, estado, fechacreacion) VALUES ('" + Conversions.ToString(empresa) + "', '" + Conversions.ToString(tipo) + "', '" + numero + "', '" + Conversions.ToString(destinatario) + "', '" + text + "', '" + Conversions.ToString(estado) + "', '" + Conversions.ToString(DateAndTime.Now) + "')";
			int num = Conversions.ToInteger(Mod_ConeccionBD.BD_insert_ID(sQL));
			result = num;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			result = 0;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static object guardarDetalleOrden(List<ordenDetalleItem> values)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected O, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected O, but got Unknown
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected O, but got Unknown
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Expected O, but got Unknown
		int num2;
		try
		{
			string requestUriString = "http://api-interna.area54sa.com.ar/MVC/app/controller/order.controller.php";
			WebRequest webRequest = WebRequest.Create(requestUriString);
			webRequest.Method = "POST";
			JObject val = new JObject();
			int num = 0;
			foreach (ordenDetalleItem value in values)
			{
				JObject val2 = new JObject();
				((JContainer)val2).Add((object)new JProperty("ordenId", (object)value.ordenId));
				((JContainer)val2).Add((object)new JProperty("productId", (object)value.productId));
				((JContainer)val2).Add((object)new JProperty("varId", (object)value.varId));
				((JContainer)val2).Add((object)new JProperty("unidades", (object)value.unidades));
				((JContainer)val2).Add((object)new JProperty("precio", (object)value.precio));
				((JContainer)val).Add((object)new JProperty(Conversions.ToString(num), (object)val2));
				num = checked(num + 1);
			}
			JObject val3 = new JObject((object)new JProperty("data", (object)val));
			byte[] bytes = Encoding.UTF8.GetBytes(((JToken)val3).ToString());
			webRequest.ContentType = "application/json";
			webRequest.ContentLength = bytes.Length;
			webRequest.Headers.Add("Token", "australopitecus");
			webRequest.Headers.Add("Action", "detalle");
			Stream requestStream = webRequest.GetRequestStream();
			requestStream.Write(bytes, 0, bytes.Length);
			requestStream.Close();
			WebResponse response = webRequest.GetResponse();
			string statusDescription = ((HttpWebResponse)response).StatusDescription;
			requestStream = response.GetResponseStream();
			StreamReader streamReader = new StreamReader(requestStream);
			string s = streamReader.ReadToEnd();
			streamReader.Close();
			requestStream.Close();
			response.Close();
			num2 = ((int.Parse(s) != 0) ? int.Parse(s) : 0);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			num2 = 0;
			ProjectData.ClearProjectError();
		}
		return num2;
	}

	public static object setOutOrder(ordendesalida values)
	{
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected O, but got Unknown
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected O, but got Unknown
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Expected O, but got Unknown
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected O, but got Unknown
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected O, but got Unknown
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Expected O, but got Unknown
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Expected O, but got Unknown
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected O, but got Unknown
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Expected O, but got Unknown
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Expected O, but got Unknown
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Expected O, but got Unknown
		string text = values.empresa.ToString();
		string text2 = values.tipo.ToString();
		string text3 = values.numero.ToString();
		string text4 = values.destinatario.ToString();
		string text5 = Strings.Replace(values.valor.ToString(), ",", ".", 1, -1, CompareMethod.Text);
		string text6 = Strings.Replace(values.valorCtr.ToString(), ",", ".", 1, -1, CompareMethod.Text);
		string text7 = values.estado.ToString();
		string text8 = values.prioridad.ToString();
		string text9 = values.observacion.ToString();
		int num;
		try
		{
			string requestUriString = "http://api-interna.area54sa.com.ar/MVC/app/controller/order.controller.php";
			WebRequest webRequest = WebRequest.Create(requestUriString);
			webRequest.Method = "POST";
			JObject val = new JObject((object)new JProperty("data", (object)new JObject(new object[9]
			{
				(object)new JProperty("empresa", (object)text),
				(object)new JProperty("tipo", (object)text2),
				(object)new JProperty("numero", (object)text3),
				(object)new JProperty("eventual", (object)text4),
				(object)new JProperty("valor", (object)text5),
				(object)new JProperty("valor_ctr", (object)text6),
				(object)new JProperty("estado", (object)text7),
				(object)new JProperty("observ", (object)text9),
				(object)new JProperty("prioridad", (object)text8)
			})));
			byte[] bytes = Encoding.UTF8.GetBytes(((JToken)val).ToString());
			webRequest.ContentType = "application/json";
			webRequest.ContentLength = bytes.Length;
			webRequest.Headers.Add("Token", "australopitecus");
			webRequest.Headers.Add("Action", "nueva");
			Stream requestStream = webRequest.GetRequestStream();
			requestStream.Write(bytes, 0, bytes.Length);
			requestStream.Close();
			WebResponse response = webRequest.GetResponse();
			string statusDescription = ((HttpWebResponse)response).StatusDescription;
			requestStream = response.GetResponseStream();
			StreamReader streamReader = new StreamReader(requestStream);
			string s = streamReader.ReadToEnd();
			streamReader.Close();
			requestStream.Close();
			response.Close();
			num = ((int.Parse(s) != 0) ? int.Parse(s) : 0);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			num = 0;
			Logger.e("Error: " + ex2.Message);
			ProjectData.ClearProjectError();
		}
		return num;
	}

	public static object updateOrderStatus(int orderId, int statusId)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected O, but got Unknown
		int num = 0;
		try
		{
			string requestUriString = "http://api-interna.area54sa.com.ar/MVC/app/controller/order.controller.php";
			WebRequest webRequest = WebRequest.Create(requestUriString);
			webRequest.Method = "POST";
			JObject val = new JObject((object)new JProperty("data", (object)new JObject(new object[2]
			{
				(object)new JProperty("id", (object)orderId),
				(object)new JProperty("estado", (object)statusId)
			})));
			byte[] bytes = Encoding.UTF8.GetBytes(((JToken)val).ToString());
			webRequest.ContentType = "application/json";
			webRequest.ContentLength = bytes.Length;
			webRequest.Headers.Add("Token", "australopitecus");
			webRequest.Headers.Add("Action", "estado");
			Stream requestStream = webRequest.GetRequestStream();
			requestStream.Write(bytes, 0, bytes.Length);
			requestStream.Close();
			WebResponse response = webRequest.GetResponse();
			string statusDescription = ((HttpWebResponse)response).StatusDescription;
			requestStream = response.GetResponseStream();
			StreamReader streamReader = new StreamReader(requestStream);
			string s = streamReader.ReadToEnd();
			streamReader.Close();
			requestStream.Close();
			response.Close();
			num = ((int.Parse(s) != 0) ? int.Parse(s) : 0);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			num = 0;
			Logger.e("Error: " + ex2.Message);
			ProjectData.ClearProjectError();
		}
		return num;
	}

	public static void listar_ordenes_lvl(ListView listview1, string sql)
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
				listView.Columns.Clear();
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

	public static object getOrderById(int orderId)
	{
		ordendesalida ordendesalida = default(ordendesalida);
		string sql = "SELECT * FROM ordenes where id=" + Conversions.ToString(orderId);
		DataTable dataTable = (DataTable)Mod_Sentencias.data(sql);
		if (dataTable.Rows.Count > 0)
		{
			ordendesalida.id = int.Parse(Conversions.ToString(dataTable.Rows[0]["id"]));
			ordendesalida.empresa = int.Parse(Conversions.ToString(dataTable.Rows[0]["empresa"]));
			ordendesalida.tipo = int.Parse(Conversions.ToString(dataTable.Rows[0]["tipo"]));
			ordendesalida.numero = Conversions.ToString(dataTable.Rows[0]["numero"]);
			ordendesalida.destinatario = int.Parse(Conversions.ToString(dataTable.Rows[0]["eventual"]));
			ordendesalida.valor = decimal.Parse(Conversions.ToString(dataTable.Rows[0]["valor"]));
			ordendesalida.estado = int.Parse(Conversions.ToString(dataTable.Rows[0]["estado"]));
			ordendesalida.observacion = dataTable.Rows[0]["observ"].ToString();
			ordendesalida.valorCtr = decimal.Parse(Conversions.ToString(dataTable.Rows[0]["valor_ctr"]));
			ordendesalida.prioridad = int.Parse(Conversions.ToString(dataTable.Rows[0]["prioridad"]));
			ordendesalida.fecha = DateTime.Parse(Conversions.ToString(dataTable.Rows[0]["fechaCreacion"]));
		}
		return ordendesalida;
	}

	public static object getOrderItemsByOrder(int orderId)
	{
		List<orderDetallePrint> list = new List<orderDetallePrint>();
		checked
		{
			try
			{
				string sql = "SELECT p.id, o.unidades as unidades, p.descripcion as producto, p.barrcode as codigo, p.codeEmpresa as codeempresa, r.descripcion as posicion, o.varid as variacion, p.alto, p.ancho, p.largo, p.peso, p.precio FROM orderdetalle o LEFT JOIN productos p ON o.productid = p.id LEFT JOIN pos_prod w ON w.productId = p.id AND w.existe = 0 LEFT JOIN posiciones r ON r.id = w.posicionId where o.ordenid=" + Conversions.ToString(orderId);
				DataTable dataTable = (DataTable)Mod_Sentencias.data(sql);
				if (dataTable.Rows.Count > 0)
				{
					int num = dataTable.Rows.Count - 1;
					for (int i = 0; i <= num; i++)
					{
						orderDetallePrint item = default(orderDetallePrint);
						item.id = int.Parse(Conversions.ToString(dataTable.Rows[i]["id"]));
						item.variacion = int.Parse(Conversions.ToString(dataTable.Rows[i]["variacion"]));
						if (item.variacion == 0)
						{
							item.producto = dataTable.Rows[i]["producto"].ToString();
						}
						else
						{
							string sql2 = "SELECT descripcion from variaciones where id=" + Conversions.ToString(item.variacion);
							DataTable dataTable2 = (DataTable)Mod_Sentencias.data(sql2);
							item.producto = dataTable2.Rows[0]["descripcion"].ToString();
						}
						item.unidades = int.Parse(Conversions.ToString(dataTable.Rows[i]["unidades"]));
						item.codigo = dataTable.Rows[i]["codigo"].ToString();
						item.codigoempresa = dataTable.Rows[i]["codeempresa"].ToString();
						item.alto = dataTable.Rows[i]["alto"].ToString();
						item.ancho = dataTable.Rows[i]["ancho"].ToString();
						item.largo = dataTable.Rows[i]["largo"].ToString();
						item.peso = dataTable.Rows[i]["peso"].ToString();
						item.precio = dataTable.Rows[i]["precio"].ToString();
						item.posicion = dataTable.Rows[i]["posicion"].ToString();
						list.Add(item);
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Interaction.MsgBox(ex2.Message);
				ProjectData.ClearProjectError();
			}
			return list;
		}
	}

	public static object getDestinatario(int eventual)
	{
		Destino destino = default(Destino);
		try
		{
			string sql = "SELECT * FROM destinos WHERE id=" + Conversions.ToString(eventual);
			DataTable dataTable = (DataTable)Mod_Sentencias.data(sql);
			if (dataTable.Rows.Count > 0)
			{
				destino.id = int.Parse(Conversions.ToString(dataTable.Rows[0]["id"]));
				destino.nombre = dataTable.Rows[0]["nombre"].ToString();
				destino.direccion = dataTable.Rows[0]["direccion"].ToString();
				destino.postal = dataTable.Rows[0]["postal"].ToString();
				destino.localidad = dataTable.Rows[0]["localidad"].ToString();
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		return destino;
	}

	public static object actualizarEnvioArea(envioArea envioA)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected O, but got Unknown
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected O, but got Unknown
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected O, but got Unknown
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected O, but got Unknown
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Expected O, but got Unknown
		int num = 0;
		try
		{
			string requestUriString = "http://www.area54sa.com.ar/tracker/actualizarEnvio.php";
			WebRequest webRequest = WebRequest.Create(requestUriString);
			webRequest.Method = "POST";
			JObject val = new JObject(new object[11]
			{
				(object)new JProperty("Estado", (object)envioA.estado),
				(object)new JProperty("guia", (object)envioA.guia),
				(object)new JProperty("Comprobante", (object)envioA.comprobante),
				(object)new JProperty("Cliente", (object)envioA.cliente),
				(object)new JProperty("Destino", (object)envioA.destino),
				(object)new JProperty("Remitos", (object)envioA.remito),
				(object)new JProperty("Bultos", (object)envioA.bultos),
				(object)new JProperty("Atraso", (object)envioA.atraso),
				(object)new JProperty("Observaciones", (object)envioA.observaciones),
				(object)new JProperty("fecha", (object)envioA.fecha),
				(object)new JProperty("Comentario", (object)envioA.comentario)
			});
			byte[] bytes = Encoding.UTF8.GetBytes(((JToken)val).ToString());
			webRequest.ContentType = "application/json";
			webRequest.ContentLength = bytes.Length;
			webRequest.Headers.Add("Token", "australopitecus");
			Stream requestStream = webRequest.GetRequestStream();
			requestStream.Write(bytes, 0, bytes.Length);
			requestStream.Close();
			WebResponse response = webRequest.GetResponse();
			string statusDescription = ((HttpWebResponse)response).StatusDescription;
			requestStream = response.GetResponseStream();
			StreamReader streamReader = new StreamReader(requestStream);
			string s = streamReader.ReadToEnd();
			streamReader.Close();
			requestStream.Close();
			response.Close();
			num = ((int.Parse(s) != 0) ? int.Parse(s) : 0);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		return num;
	}

	public static object CheckNumeroOrden(string orderNumber, int empresa)
	{
		int num = 0;
		try
		{
			string sql = "SELECT * FROM ordenes WHERE numero = '" + orderNumber + "' AND empresa = " + Conversions.ToString(empresa) + " LIMIT 1";
			DataTable dataTable = (DataTable)Mod_Sentencias.data(sql);
			num = ((dataTable.Rows.Count > 0) ? 1 : 2);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Logger.e(ex2.Message);
			num = 3;
			ProjectData.ClearProjectError();
		}
		return num;
	}

	private static void CrearOrdenLocal(OrdenAIngresar data)
	{
		status = 200;
		mensaje = "PROCESANDO";
		if (Conversions.ToBoolean(BuscarOrden(data.empresa, data.numero, data.tipo)))
		{
			status = 400;
			mensaje = "LA ORDEN YA FUE INGRESADA";
			return;
		}
		if (Operators.ConditionalCompareObjectEqual(BuscarEventual(), false, TextCompare: true) && Operators.ConditionalCompareObjectEqual(NuevoEventual(), false, TextCompare: true))
		{
			status = 402;
			mensaje = "ERROR AL CREAR NUEVO EVENTUAL";
			return;
		}
		if (Operators.ConditionalCompareObjectEqual(InsertarOrden(), false, TextCompare: true))
		{
			status = 401;
			mensaje = "ERROR AL INSERTAR LA ORDEN";
			return;
		}
		checked
		{
			int num = data.productos.totalProductos - 1;
			for (int i = 0; i <= num; i++)
			{
				if (Conversions.ToBoolean(ExisteProducto(data.productos.listaProductos[i])))
				{
					if (Conversions.ToBoolean(StockDisponible(data.productos.listaProductos[i])))
					{
						if (Operators.ConditionalCompareObjectEqual(InsertoSolicitudProducto(data.productos.listaProductos[i]), false, TextCompare: true))
						{
							status = 404;
							mensaje = "ERROR AL INSERTAR EL PRODUCTO";
						}
					}
					else
					{
						status = 403;
						mensaje = "NO HAY STOCK DISPONIBLE";
					}
					continue;
				}
				status = 402;
				mensaje = "EL PRODUCTO NO EXISTE";
				return;
			}
			mensaje = "ORDEN CREADA";
		}
	}

	private static object BuscarOrden(int empresa, string numero, int tipo)
	{
		try
		{
			string sql = "SELECT id FROM ordenes WHERE empresa = " + Conversions.ToString(empresa) + " AND numero = '" + numero + "' AND tipo = " + Conversions.ToString(tipo) + " LIMIT 1";
			DataTable dataTable = (DataTable)Mod_Sentencias.data(sql);
			if (dataTable.Rows.Count > 0)
			{
				return true;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			eMensaje = ex2.Message;
			ProjectData.ClearProjectError();
		}
		return false;
	}

	private static object InsertarOrden()
	{
		bool flag = false;
		try
		{
			string text = "INSERT INTO ordenes (empresa, tipo, numero, eventual, valor, estado, observ, valor_ctr, prioridad, fechaCreacion, fechaPreparado, fecha, usuario)  VALUES (";
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			eMensaje = ex2.Message;
			ProjectData.ClearProjectError();
		}
		return flag;
	}

	private static object BuscarEventual()
	{
		bool flag = false;
		try
		{
			eventualId = 0;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			eMensaje = ex2.Message;
			ProjectData.ClearProjectError();
		}
		return flag;
	}

	private static object NuevoEventual()
	{
		bool flag = false;
		try
		{
			eventualId = 0;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			eMensaje = ex2.Message;
			ProjectData.ClearProjectError();
		}
		return flag;
	}

	private static object ExisteProducto(ProductoSolicitado producto)
	{
		try
		{
			return true;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			eMensaje = ex2.Message;
			ProjectData.ClearProjectError();
		}
		return false;
	}

	private static object StockDisponible(ProductoSolicitado producto)
	{
		try
		{
			return true;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			eMensaje = ex2.Message;
			ProjectData.ClearProjectError();
		}
		return false;
	}

	private static object InsertoSolicitudProducto(ProductoSolicitado producto)
	{
		try
		{
			string sQL = "INSERT INTO orderdetalle (ordenId, productid, varid, unidades, precio) VALUES (" + Conversions.ToString(ordenid) + ", " + Conversions.ToString(producto.idProducto) + ", " + Conversions.ToString(producto.variacionSolicitada) + ", " + Conversions.ToString(producto.unidadesSolicitadas) + ", '" + Conversions.ToString(producto.precio) + "')";
			int num = Conversions.ToInteger(Mod_ConeccionBD.BD_insert_ID(sQL));
			if (num > 0)
			{
				producto.insertId = num;
				return true;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			eMensaje = ex2.Message;
			ProjectData.ClearProjectError();
		}
		return false;
	}
}
