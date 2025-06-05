using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.VisualBasic.CompilerServices;

namespace Hermes;

[StandardModule]
internal sealed class OrdenesTable
{
	public struct OrdenTable
	{
		public int id;

		public int empresa;

		public int tipo;

		public string numero;

		public int eventual;

		public decimal valor;

		public int estado;

		public string observ;

		public decimal valor_ctr;

		public int prioridad;

		public string fechaCreacion;

		public string fechaPreparado;

		public string fecha;

		public string usuario;
	}

	public struct OrdenRespuesta
	{
		public bool Status;

		public string Mensaje;

		public OrdenTable Orden;
	}

	public struct ListOrdenRespuesta
	{
		public bool Status;

		public int TotalOrdenes;

		public string Mensaje;

		public List<OrdenTable> Ordenes;
	}

	public static object InsertarOrden(OrdenTable orden)
	{
		OrdenRespuesta ordenRespuesta = default(OrdenRespuesta);
		try
		{
			string sQL = string.Concat("INSERT INTO ordenes (empresa, tipo, numero, eventual, valor, estado, observ, valor_ctr, prioridad, fechaCreacion, fecha, usuario) VALUES (" + Conversions.ToString(orden.empresa) + ", " + Conversions.ToString(orden.tipo) + ", '" + orden.numero + "', " + Conversions.ToString(orden.eventual) + ", '" + Conversions.ToString(orden.valor) + "', " + Conversions.ToString(orden.estado) + ", '" + orden.observ + "', '" + Conversions.ToString(orden.valor_ctr) + "', ", Conversions.ToString(orden.prioridad), ", '", orden.fechaCreacion, "', '", orden.fecha, "', '", orden.usuario, "')");
			int num = Conversions.ToInteger(Mod_ConeccionBD.BD_insert_ID(sQL));
			if (num > 0)
			{
				ordenRespuesta.Status = true;
				ordenRespuesta.Mensaje = num.ToString();
			}
			else
			{
				ordenRespuesta.Status = false;
				ordenRespuesta.Mensaje = "Error al insertar.";
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ordenRespuesta.Status = false;
			ordenRespuesta.Mensaje = ex2.Message;
			ProjectData.ClearProjectError();
		}
		return ordenRespuesta;
	}

	public static object SelectOrdenWithNumero(string numero)
	{
		OrdenRespuesta ordenRespuesta = default(OrdenRespuesta);
		try
		{
			ordenRespuesta.Status = true;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ordenRespuesta.Status = false;
			ordenRespuesta.Mensaje = ex2.Message;
			ProjectData.ClearProjectError();
		}
		return ordenRespuesta;
	}

	public static object RowToOrden(DataTable data)
	{
		ListOrdenRespuesta listOrdenRespuesta = default(ListOrdenRespuesta);
		List<OrdenTable> list = new List<OrdenTable>();
		checked
		{
			try
			{
				int num = data.Rows.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					OrdenTable item = default(OrdenTable);
					item.id = int.Parse(Conversions.ToString(data.Rows[i]["id"]));
					item.empresa = int.Parse(Conversions.ToString(data.Rows[i]["empresa"]));
					item.tipo = int.Parse(Conversions.ToString(data.Rows[i]["tipo"]));
					item.numero = data.Rows[i]["numero"].ToString();
					item.eventual = int.Parse(Conversions.ToString(data.Rows[i]["eventual"]));
					item.valor = Conversions.ToDecimal(data.Rows[i]["valor"].ToString());
					item.estado = int.Parse(Conversions.ToString(data.Rows[i]["estado"]));
					item.observ = data.Rows[i]["observ"].ToString();
					item.valor_ctr = Conversions.ToDecimal(data.Rows[i]["valor_ctr"].ToString());
					item.prioridad = int.Parse(Conversions.ToString(data.Rows[i]["prioridad"]));
					item.fechaCreacion = data.Rows[i]["fechaCreacion"].ToString();
					item.fechaPreparado = data.Rows[i]["fechaPreparado"].ToString();
					item.fecha = data.Rows[i]["fecha"].ToString();
					item.usuario = data.Rows[i]["usuario"].ToString();
					list.Add(item);
				}
				listOrdenRespuesta.Status = true;
				listOrdenRespuesta.TotalOrdenes = data.Rows.Count;
				listOrdenRespuesta.Ordenes = list;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				listOrdenRespuesta.Status = false;
				listOrdenRespuesta.Mensaje = ex2.Message;
				ProjectData.ClearProjectError();
			}
			return listOrdenRespuesta;
		}
	}
}
