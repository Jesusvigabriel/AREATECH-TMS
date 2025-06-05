using System;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using Hermes.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace Hermes;

[StandardModule]
internal sealed class Mod_Etrans_Retiros
{
	public static object agrupar_retiros()
	{
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Expected O, but got Unknown
		checked
		{
			object result;
			try
			{
				int num = 0;
				string empty = string.Empty;
				string text = Strings.Format(MyProject.Forms.Form1_Inicio.DateTimePicker1.Value, "yyyyMMdd");
				string text2 = ("SELECT id_envio FROM etransEnvios WHERE U_fecha=" + text) ?? "";
				DataTable dataTable = new DataTable("x");
				MySqlDataAdapter val = new MySqlDataAdapter(text2, Mod_Sentencias.cnn);
				((DbDataAdapter)(object)val).Fill(dataTable);
				int num2 = dataTable.Rows.Count - 1;
				for (int i = 0; i <= num2; i++)
				{
					num = Conversions.ToInteger(dataTable.Rows[i]["id_envio"]);
					int estado = Conversions.ToInteger(Mod_Etrans.estado_web_etrans(num));
					string text3 = Conversions.ToString(Mod_Etrans.estado_int_string(estado));
					string sQL = "UPDATE etransEnvios SET Estado='" + text3 + "', id_retiro=0 WHERE id_envio=" + Conversions.ToString(num);
					int num3 = Conversions.ToInteger(Mod_ConeccionBD.BD_Sentencia(sQL));
				}
				string text4 = "SELECT id_hermes, Cliente, U_calle, U_numero_puerta, U_cp, U_localidad, sum(Declarado) as Declarado, sum(Bultos) as Bultos, sum(Kilos) as Kilos, numero_interno, sum(Volumen) as Volumen, U_fecha, sum(flete) as flete, U_ventana FROM etransenvios WHERE U_fecha=" + text + "  AND Estado='APROBADO' GROUP BY Cliente, U_calle";
				DataTable dataTable2 = new DataTable("x");
				MySqlDataAdapter val2 = new MySqlDataAdapter(text4, Mod_Sentencias.cnn);
				((DbDataAdapter)(object)val2).Fill(dataTable2);
				int num4 = dataTable2.Rows.Count - 1;
				for (int j = 0; j <= num4; j++)
				{
					string sQL2 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("UPDATE etransEnvios SET id_retiro=", dataTable2.Rows[j]["id_hermes"]), " WHERE U_calle = '"), dataTable2.Rows[j]["U_calle"]), "' AND Cliente ='"), dataTable2.Rows[j]["Cliente"]), "' AND U_fecha='"), text), "'"));
					Mod_ConeccionBD.BD_Sentencia(sQL2);
				}
				result = "OK";
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				result = "Error";
				ProjectData.ClearProjectError();
			}
			return result;
		}
	}

	public static object armar_retiro(int id_envio)
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		string empty = string.Empty;
		string text = ("SELECT id_hermes, Cliente, U_calle, U_numero_puerta, U_cp, U_localidad, Declarado, Bultos, Kilos, numero_interno, Volumen, U_fecha, flete, U_ventana,id_retiro FROM etransenvios WHERE id_envio=" + Conversions.ToString(id_envio)) ?? "";
		DataTable dataTable = new DataTable("x");
		MySqlDataAdapter val = new MySqlDataAdapter(text, Mod_Sentencias.cnn);
		((DbDataAdapter)(object)val).Fill(dataTable);
		string empty2 = string.Empty;
		string text2 = Conversions.ToString(dataTable.Rows[0]["U_calle"]);
		string text3 = Conversions.ToString(dataTable.Rows[0]["U_numero_puerta"]);
		empty2 = ((Operators.CompareString(text2, text3, TextCompare: true) == 0) ? text2 : ((!text2.Contains(text3)) ? (text2 + " " + text3) : text2));
		empty = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("INSERT INTO Planchada(Eventual, Comprobante, Cliente, Remitos, Destino, Domicilio, CP, Localidad, Declarado, Bultos, Kilos, Sub, Observaciones, Volumen, Atraso, Diferida, Flete, Zona, Adicional, Prioridad, Chofer, Latitud, Longitud, Estado, Fecha, Ventana, Usuario) VALUES (0, " + Conversions.ToString(id_envio) + ",'ETRANS','" + Conversions.ToString(id_envio) + "','" + Strings.Replace(Conversions.ToString(dataTable.Rows[0]["Cliente"]), "'", " ", 1, -1, CompareMethod.Text) + "','" + Strings.Replace(empty2, "'", " ", 1, -1, CompareMethod.Text) + "','", dataTable.Rows[0]["U_cp"]), "','"), dataTable.Rows[0]["U_localidad"]), "',"), Strings.Replace(Conversions.ToString(dataTable.Rows[0]["Declarado"]), ",", ".", 1, -1, CompareMethod.Text)), ","), dataTable.Rows[0]["Bultos"]), ","), Strings.Replace(Conversions.ToString(dataTable.Rows[0]["Kilos"]), ",", ".", 1, -1, CompareMethod.Text)), ",11,'"), dataTable.Rows[0]["id_retiro"]), "',"), Strings.Replace(Conversions.ToString(dataTable.Rows[0]["Volumen"]), ",", ".", 1, -1, CompareMethod.Text)), ",0,'"), Strings.Format(RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["U_fecha"]), "yyyy/MM/dd")), "',0,0,0,0,0,0,0,'En Planchada','"), Strings.Format(RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["U_fecha"]), "yyyy/MM/dd")), "',"), dataTable.Rows[0]["U_ventana"]), ",'Hermes')"));
		int num = Conversions.ToInteger(Mod_logger.historialenter(Conversions.ToString(id_envio), Strings.Format(RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["U_fecha"]), "yyyy/MM/dd"), "EN PLANCHADA", ""));
		return empty;
	}

	public static object armar_entrega(int id_envio)
	{
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		double num = 0.0;
		string empty = string.Empty;
		string text = ("SELECT id_hermes, Destinatario, D_calle, D_numero_puerta, D_cp, D_localidad, Declarado, Bultos, Kilos, numero_interno, Volumen, D_fecha, round(flete/1.21,2)as flete, D_ventana,id_retiro FROM etransenvios WHERE id_envio=" + Conversions.ToString(id_envio)) ?? "";
		DataTable dataTable = new DataTable("x");
		MySqlDataAdapter val = new MySqlDataAdapter(text, Mod_Sentencias.cnn);
		((DbDataAdapter)(object)val).Fill(dataTable);
		string empty2 = string.Empty;
		string text2 = Conversions.ToString(dataTable.Rows[0]["D_calle"]);
		string text3 = Conversions.ToString(dataTable.Rows[0]["D_numero_puerta"]);
		empty2 = ((Operators.CompareString(text2, text3, TextCompare: true) == 0) ? text2 : ((!text2.Contains(text3)) ? (text2 + " " + text3) : text2));
		num = Conversions.ToDouble(dataTable.Rows[0]["Volumen"]);
		num /= 1000000.0;
		num = Math.Round(num, 3);
		num = Conversions.ToDouble(Strings.Replace(Conversions.ToString(num), ",", ".", 1, -1, CompareMethod.Text));
		string right = Strings.Replace(Conversions.ToDouble(dataTable.Rows[0]["flete"]).ToString(), ",", ".", 1, -1, CompareMethod.Text);
		empty = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("INSERT INTO Planchada(Eventual, Comprobante, Cliente, Remitos, Destino, Domicilio, CP, Localidad, Declarado, Bultos, Kilos, Sub, Observaciones, Volumen, Atraso, Diferida, Flete, Zona, Adicional, Prioridad, Chofer, Latitud, Longitud, Estado, Fecha, Ventana, Usuario) VALUES (0, " + Conversions.ToString(id_envio) + ",'ETRANS','" + Conversions.ToString(id_envio) + "','" + Strings.Replace(Conversions.ToString(dataTable.Rows[0]["Destinatario"]), "'", " ", 1, -1, CompareMethod.Text) + "','" + Strings.Replace(empty2, "'", " ", 1, -1, CompareMethod.Text) + "','", dataTable.Rows[0]["D_cp"]), "','"), dataTable.Rows[0]["D_localidad"]), "',"), Strings.Replace(Conversions.ToString(dataTable.Rows[0]["Declarado"]), ",", ".", 1, -1, CompareMethod.Text)), ","), dataTable.Rows[0]["Bultos"]), ","), Strings.Replace(Conversions.ToString(dataTable.Rows[0]["Kilos"]), ",", ".", 1, -1, CompareMethod.Text)), ", "), dataTable.Rows[0]["D_ventana"]), ",'"), dataTable.Rows[0]["id_retiro"]), "',"), num), ",0,'"), Strings.Format(RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["D_fecha"]), "yyyy/MM/dd")), "',"), right), ",0,0,0,0,0,0,'En Planchada','"), Strings.Format(RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["D_fecha"]), "yyyy/MM/dd")), "',"), dataTable.Rows[0]["D_ventana"]), ",'Hermes')"));
		int num2 = Conversions.ToInteger(Mod_logger.historialenter(Conversions.ToString(id_envio), Strings.Format(RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["D_fecha"]), "yyyy/MM/dd"), "EN PLANCHADA", ""));
		return empty;
	}

	public static void llenar_tabla_etrans()
	{
		string sQL = "INSERT INTO etransenvios(id_envio,Bultos,Volumen,Kilos,Flete,Declarado,Cliente,U_mail,U_telefono,U_fecha,U_ventana,U_calle,U_numero_puerta,U_piso,U_dpto_oficina,U_bloque_torre,U_cp,U_localidad,U_provincia,Destinatario,D_mail,D_telefono,D_fecha,D_ventana,D_calle,D_numero_puerta, D_piso,D_dpto_oficina,D_bloque_torre,D_cp,D_localidad,D_provincia,Observaciones,numero_interno,estado)values('2540','1','0.33','2','150.25', '1580.12','FACUNDO','mail@mail.com','02224521125','2015/08/13','2','Sarmiento','365','','','','1870','Avellaneda','Buenos Aires','Juan Manuel Gorostiaga','jm@mail.com','452325','2015/08/14','1','Tomas Guido','2585','2','sistemas','','1852','burzaco','buenos aires','preguntar por pepe','1','APROBADO')";
		Mod_ConeccionBD.BD_Sentencia(sQL);
	}

	public static void retiros_v1()
	{
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		deleteCSV_table();
		createCSV_table();
		string text = Strings.Format(MyProject.Forms.Form1_Inicio.DateTimePicker1.Value, "yyyyMMdd");
		string text2 = Strings.Format(MyProject.Forms.Form1_Inicio.DateTimePicker1.Value, "ddMMyyyy");
		string text3 = "SELECT id_envio, Cliente, U_calle, U_numero_puerta, U_cp, U_localidad, Declarado, Bultos, Kilos, numero_interno, Volumen, U_fecha, flete, U_ventana FROM etransenvios WHERE U_fecha=" + text + " AND Estado='APROBADO'  AND U_ventana = 1";
		DataTable dataTable = new DataTable("x");
		MySqlDataAdapter val = new MySqlDataAdapter(text3, Mod_Sentencias.cnn);
		((DbDataAdapter)(object)val).Fill(dataTable);
		checked
		{
			int num = dataTable.Rows.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				int num2 = Conversions.ToInteger(Mod_Etrans.estado_web_etrans(Conversions.ToInteger(dataTable.Rows[i]["id_envio"])));
				if (Conversions.ToBoolean(Operators.AndObject(num2 == 2, Operators.CompareObjectNotEqual(dataTable.Rows[i]["Cliente"], "Facundo", TextCompare: true))))
				{
					string text4 = Conversions.ToString(dataTable.Rows[i]["id_envio"]);
					string text5 = Conversions.ToString(dataTable.Rows[i]["U_fecha"]);
					string text6 = Conversions.ToString(dataTable.Rows[i]["Cliente"]);
					string text7 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(dataTable.Rows[i]["U_calle"], " "), dataTable.Rows[i]["U_numero_puerta"]));
					string text8 = Conversions.ToString(dataTable.Rows[i]["U_cp"]);
					string text9 = "BULTOS";
					string text10 = Conversions.ToString(dataTable.Rows[i]["kilos"]);
					string text11 = Conversions.ToString(dataTable.Rows[i]["bultos"]);
					string text12 = "1";
					string text13 = Conversions.ToString(dataTable.Rows[i]["Declarado"]);
					if (text4.Length > 12)
					{
						text4 = text4.Substring(0, 12);
					}
					if (text6.Length > 25)
					{
						text6 = text6.Substring(0, 25);
					}
					if (text7.Length > 25)
					{
						text7 = text7.Substring(0, 25);
					}
					if (text8.Length > 4)
					{
						text8 = text8.Substring(0, 4);
					}
					if (text9.Length > 20)
					{
						text9 = text9.Substring(0, 20);
					}
					if (text10.Length > 9)
					{
						text10 = Strings.Replace(text10.Substring(0, 9), ",", ".", 1, -1, CompareMethod.Text);
					}
					if (text11.Length > 5)
					{
						text11 = text11.Substring(0, 5);
					}
					if (text13.Length > 10)
					{
						text13 = Strings.Replace(text13.Substring(0, 10), ",", ".", 1, -1, CompareMethod.Text);
					}
					text10 = Strings.Replace(text10, ",", ".", 1, -1, CompareMethod.Text);
					text13 = Strings.Replace(text13, ",", ".", 1, -1, CompareMethod.Text);
					if (Conversions.ToDouble(text8) < 1599.0)
					{
						text8 = Conversions.ToString(1000);
					}
					string sQL = "INSERT INTO CSV (REMITO,FECHA,RS1_DEST,DOM_DEST,LOC_DEST,DESCRIP,KILOS,BULTOS,MT3,VALOR_DECL) VALUES('" + text4 + "','" + text2 + "','" + text6 + "','" + text7 + "','" + text8 + "','" + text9 + "','" + text10 + "','" + text11 + "','" + text12 + "','" + text13 + "')";
					Mod_ConeccionBD.BD_Sentencia(sQL);
				}
				else
				{
					string sQL2 = Conversions.ToString(Operators.ConcatenateObject("UPDATE etransEnvios SET Estado='CADUCADO' WHERE id_envio=", dataTable.Rows[i]["id_envio"]));
					Mod_ConeccionBD.BD_Sentencia(sQL2);
				}
			}
			DBF_retiro_v1();
		}
	}

	public static void retiros_v2()
	{
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		deleteCSV_table();
		createCSV_table();
		string text = Strings.Format(MyProject.Forms.Form1_Inicio.DateTimePicker1.Value, "yyyyMMdd");
		string text2 = Strings.Format(MyProject.Forms.Form1_Inicio.DateTimePicker1.Value, "ddMMyyyy");
		string text3 = "SELECT id_envio, Cliente, U_calle, U_numero_puerta, U_cp, U_localidad, Declarado, Bultos, Kilos, numero_interno, Volumen, U_fecha, flete, U_ventana FROM etransenvios WHERE U_fecha=" + text + " AND Estado='APROBADO' AND U_ventana = 2 ";
		DataTable dataTable = new DataTable("x");
		MySqlDataAdapter val = new MySqlDataAdapter(text3, Mod_Sentencias.cnn);
		((DbDataAdapter)(object)val).Fill(dataTable);
		checked
		{
			int num = dataTable.Rows.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				int num2 = Conversions.ToInteger(Mod_Etrans.estado_web_etrans(Conversions.ToInteger(dataTable.Rows[i]["id_envio"])));
				if (Conversions.ToBoolean(Operators.AndObject(num2 == 2, Operators.CompareObjectNotEqual(dataTable.Rows[i]["Cliente"], "Facundo", TextCompare: true))))
				{
					string text4 = Conversions.ToString(dataTable.Rows[i]["id_envio"]);
					string text5 = Conversions.ToString(dataTable.Rows[i]["U_fecha"]);
					string text6 = Conversions.ToString(dataTable.Rows[i]["Cliente"]);
					string text7 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(dataTable.Rows[i]["U_calle"], " "), dataTable.Rows[i]["U_numero_puerta"]));
					string text8 = Conversions.ToString(dataTable.Rows[i]["U_cp"]);
					string text9 = "BULTOS";
					string text10 = Conversions.ToString(dataTable.Rows[i]["kilos"]);
					string text11 = Conversions.ToString(dataTable.Rows[i]["bultos"]);
					string text12 = "1";
					string text13 = Conversions.ToString(dataTable.Rows[i]["Declarado"]);
					if (text4.Length > 12)
					{
						text4 = text4.Substring(0, 12);
					}
					if (text6.Length > 25)
					{
						text6 = text6.Substring(0, 25);
					}
					if (text7.Length > 25)
					{
						text7 = text7.Substring(0, 25);
					}
					if (text8.Length > 4)
					{
						text8 = text8.Substring(0, 4);
					}
					if (text9.Length > 20)
					{
						text9 = text9.Substring(0, 20);
					}
					if (text10.Length > 9)
					{
						text10 = Strings.Replace(text10.Substring(0, 9), ",", ".", 1, -1, CompareMethod.Text);
					}
					if (text11.Length > 5)
					{
						text11 = text11.Substring(0, 5);
					}
					if (text13.Length > 10)
					{
						text13 = Strings.Replace(text13.Substring(0, 10), ",", ".", 1, -1, CompareMethod.Text);
					}
					text10 = Strings.Replace(text10, ",", ".", 1, -1, CompareMethod.Text);
					text13 = Strings.Replace(text13, ",", ".", 1, -1, CompareMethod.Text);
					if (Conversions.ToDouble(text8) < 1599.0)
					{
						text8 = Conversions.ToString(1000);
					}
					string sQL = "INSERT INTO CSV (REMITO,FECHA,RS1_DEST,DOM_DEST,LOC_DEST,DESCRIP,KILOS,BULTOS,MT3,VALOR_DECL) VALUES('" + text4 + "','" + text2 + "','" + text6 + "','" + text7 + "','" + text8 + "','" + text9 + "','" + text10 + "','" + text11 + "','" + text12 + "','" + text13 + "')";
					Mod_ConeccionBD.BD_Sentencia(sQL);
				}
				else
				{
					string sQL2 = Conversions.ToString(Operators.ConcatenateObject("UPDATE etransEnvios SET Estado='CADUCADO' WHERE id_envio=", dataTable.Rows[i]["id_envio"]));
					Mod_ConeccionBD.BD_Sentencia(sQL2);
				}
			}
			DBF_retiro_v2();
		}
	}

	public static void entregas_v1()
	{
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		deleteCSV_table();
		createCSV_table();
		string text = Strings.Format(MyProject.Forms.Form1_Inicio.DateTimePicker1.Value, "yyyyMMdd");
		string text2 = Strings.Format(MyProject.Forms.Form1_Inicio.DateTimePicker1.Value, "ddMMyyyy");
		string text3 = "SELECT id_envio, Destinatario, D_calle, D_numero_puerta, D_cp, D_localidad, Declarado, Bultos, Kilos, numero_interno, Volumen, D_fecha, flete, D_ventana FROM etransenvios WHERE D_fecha=" + text + " AND Estado='EN CD' AND D_ventana = 1";
		DataTable dataTable = new DataTable("x");
		MySqlDataAdapter val = new MySqlDataAdapter(text3, Mod_Sentencias.cnn);
		((DbDataAdapter)(object)val).Fill(dataTable);
		checked
		{
			int num = dataTable.Rows.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				int num2 = Conversions.ToInteger(Mod_Etrans.estado_web_etrans(Conversions.ToInteger(dataTable.Rows[i]["id_envio"])));
				if (num2 == 5)
				{
					string text4 = Conversions.ToString(dataTable.Rows[i]["id_envio"]);
					string text5 = Conversions.ToString(dataTable.Rows[i]["D_fecha"]);
					string text6 = Conversions.ToString(dataTable.Rows[i]["Destinatario"]);
					string text7 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(dataTable.Rows[i]["D_calle"], " "), dataTable.Rows[i]["D_numero_puerta"]));
					string text8 = Conversions.ToString(dataTable.Rows[i]["D_cp"]);
					string text9 = "BULTOS";
					string text10 = Conversions.ToString(dataTable.Rows[i]["kilos"]);
					string text11 = Conversions.ToString(dataTable.Rows[i]["bultos"]);
					string text12 = "1";
					string text13 = Conversions.ToString(dataTable.Rows[i]["Declarado"]);
					if (text4.Length > 12)
					{
						text4 = text4.Substring(0, 12);
					}
					if (text6.Length > 25)
					{
						text6 = text6.Substring(0, 25);
					}
					if (text7.Length > 25)
					{
						text7 = text7.Substring(0, 25);
					}
					if (text8.Length > 4)
					{
						text8 = text8.Substring(0, 4);
					}
					if (text9.Length > 20)
					{
						text9 = text9.Substring(0, 20);
					}
					if (text10.Length > 9)
					{
						text10 = Strings.Replace(text10.Substring(0, 9), ",", ".", 1, -1, CompareMethod.Text);
					}
					if (text11.Length > 5)
					{
						text11 = text11.Substring(0, 5);
					}
					if (text13.Length > 10)
					{
						text13 = Strings.Replace(text13.Substring(0, 10), ",", ".", 1, -1, CompareMethod.Text);
					}
					text10 = Strings.Replace(text10, ",", ".", 1, -1, CompareMethod.Text);
					text13 = Strings.Replace(text13, ",", ".", 1, -1, CompareMethod.Text);
					if (Conversions.ToDouble(text8) < 1599.0)
					{
						text8 = Conversions.ToString(1000);
					}
					string sQL = "INSERT INTO CSV (REMITO,FECHA,RS1_DEST,DOM_DEST,LOC_DEST,DESCRIP,KILOS,BULTOS,MT3,VALOR_DECL) VALUES('" + text4 + "','" + text2 + "','" + text6 + "','" + text7 + "','" + text8 + "','" + text9 + "','" + text10 + "','" + text11 + "','" + text12 + "','" + text13 + "')";
					Mod_ConeccionBD.BD_Sentencia(sQL);
				}
			}
			DBF_entregas_v1();
		}
	}

	public static void entregas_v2()
	{
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		deleteCSV_table();
		createCSV_table();
		string text = Strings.Format(MyProject.Forms.Form1_Inicio.DateTimePicker1.Value, "yyyyMMdd");
		string text2 = Strings.Format(MyProject.Forms.Form1_Inicio.DateTimePicker1.Value, "ddMMyyyy");
		string text3 = "SELECT id_envio, Destinatario, D_calle, D_numero_puerta, D_cp, D_localidad, Declarado, Bultos, Kilos, numero_interno, Volumen, D_fecha, flete, D_ventana FROM etransenvios WHERE D_fecha=" + text + " AND Estado='EN CD' AND D_ventana = 2";
		DataTable dataTable = new DataTable("x");
		MySqlDataAdapter val = new MySqlDataAdapter(text3, Mod_Sentencias.cnn);
		((DbDataAdapter)(object)val).Fill(dataTable);
		checked
		{
			int num = dataTable.Rows.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				int num2 = Conversions.ToInteger(Mod_Etrans.estado_web_etrans(Conversions.ToInteger(dataTable.Rows[i]["id_envio"])));
				if (num2 == 5)
				{
					string text4 = Conversions.ToString(dataTable.Rows[i]["id_envio"]);
					string text5 = Conversions.ToString(dataTable.Rows[i]["D_fecha"]);
					string text6 = Conversions.ToString(dataTable.Rows[i]["Destinatario"]);
					string text7 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(dataTable.Rows[i]["D_calle"], " "), dataTable.Rows[i]["D_numero_puerta"]));
					string text8 = Conversions.ToString(dataTable.Rows[i]["D_cp"]);
					string text9 = "BULTOS";
					string text10 = Conversions.ToString(dataTable.Rows[i]["kilos"]);
					string text11 = Conversions.ToString(dataTable.Rows[i]["bultos"]);
					string text12 = "1";
					string text13 = Conversions.ToString(dataTable.Rows[i]["Declarado"]);
					if (text4.Length > 12)
					{
						text4 = text4.Substring(0, 12);
					}
					if (text6.Length > 25)
					{
						text6 = text6.Substring(0, 25);
					}
					if (text7.Length > 25)
					{
						text7 = text7.Substring(0, 25);
					}
					if (text8.Length > 4)
					{
						text8 = text8.Substring(0, 4);
					}
					if (text9.Length > 20)
					{
						text9 = text9.Substring(0, 20);
					}
					if (text10.Length > 9)
					{
						text10 = Strings.Replace(text10.Substring(0, 9), ",", ".", 1, -1, CompareMethod.Text);
					}
					if (text11.Length > 5)
					{
						text11 = text11.Substring(0, 5);
					}
					if (text13.Length > 10)
					{
						text13 = Strings.Replace(text13.Substring(0, 10), ",", ".", 1, -1, CompareMethod.Text);
					}
					text10 = Strings.Replace(text10, ",", ".", 1, -1, CompareMethod.Text);
					text13 = Strings.Replace(text13, ",", ".", 1, -1, CompareMethod.Text);
					if (Conversions.ToDouble(text8) < 1599.0)
					{
						text8 = Conversions.ToString(1000);
					}
					string sQL = "INSERT INTO CSV (REMITO,FECHA,RS1_DEST,DOM_DEST,LOC_DEST,DESCRIP,KILOS,BULTOS,MT3,VALOR_DECL) VALUES('" + text4 + "','" + text2 + "','" + text6 + "','" + text7 + "','" + text8 + "','" + text9 + "','" + text10 + "','" + text11 + "','" + text12 + "','" + text13 + "')";
					Mod_ConeccionBD.BD_Sentencia(sQL);
				}
			}
			DBF_entregas_v2();
		}
	}

	public static void entregas_v3()
	{
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		deleteCSV_table();
		createCSV_table();
		string text = Strings.Format(MyProject.Forms.Form1_Inicio.DateTimePicker1.Value, "yyyyMMdd");
		string text2 = Strings.Format(MyProject.Forms.Form1_Inicio.DateTimePicker1.Value, "ddMMyyyy");
		string text3 = "SELECT id_envio, Destinatario, D_calle, D_numero_puerta, D_cp, D_localidad, Declarado, Bultos, Kilos, numero_interno, Volumen, D_fecha, flete, D_ventana FROM etransenvios WHERE D_fecha=" + text + " AND Estado='EN CD' AND D_ventana = 3";
		DataTable dataTable = new DataTable("x");
		MySqlDataAdapter val = new MySqlDataAdapter(text3, Mod_Sentencias.cnn);
		((DbDataAdapter)(object)val).Fill(dataTable);
		checked
		{
			int num = dataTable.Rows.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				int num2 = Conversions.ToInteger(Mod_Etrans.estado_web_etrans(Conversions.ToInteger(dataTable.Rows[i]["id_envio"])));
				if (num2 == 5)
				{
					string text4 = Conversions.ToString(dataTable.Rows[i]["id_envio"]);
					string text5 = Conversions.ToString(dataTable.Rows[i]["D_fecha"]);
					string text6 = Conversions.ToString(dataTable.Rows[i]["Destinatario"]);
					string text7 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(dataTable.Rows[i]["D_calle"], " "), dataTable.Rows[i]["D_numero_puerta"]));
					string text8 = Conversions.ToString(dataTable.Rows[i]["D_cp"]);
					string text9 = "BULTOS";
					string text10 = Conversions.ToString(dataTable.Rows[i]["kilos"]);
					string text11 = Conversions.ToString(dataTable.Rows[i]["bultos"]);
					string text12 = "1";
					string text13 = Conversions.ToString(dataTable.Rows[i]["Declarado"]);
					if (text4.Length > 12)
					{
						text4 = text4.Substring(0, 12);
					}
					if (text6.Length > 25)
					{
						text6 = text6.Substring(0, 25);
					}
					if (text7.Length > 25)
					{
						text7 = text7.Substring(0, 25);
					}
					if (text8.Length > 4)
					{
						text8 = text8.Substring(0, 4);
					}
					if (text9.Length > 20)
					{
						text9 = text9.Substring(0, 20);
					}
					if (text10.Length > 9)
					{
						text10 = Strings.Replace(text10.Substring(0, 9), ",", ".", 1, -1, CompareMethod.Text);
					}
					if (text11.Length > 5)
					{
						text11 = text11.Substring(0, 5);
					}
					if (text13.Length > 10)
					{
						text13 = Strings.Replace(text13.Substring(0, 10), ",", ".", 1, -1, CompareMethod.Text);
					}
					text10 = Strings.Replace(text10, ",", ".", 1, -1, CompareMethod.Text);
					text13 = Strings.Replace(text13, ",", ".", 1, -1, CompareMethod.Text);
					if (Conversions.ToDouble(text8) < 1599.0)
					{
						text8 = Conversions.ToString(1000);
					}
					string sQL = "INSERT INTO CSV (REMITO,FECHA,RS1_DEST,DOM_DEST,LOC_DEST,DESCRIP,KILOS,BULTOS,MT3,VALOR_DECL) VALUES('" + text4 + "','" + text2 + "','" + text6 + "','" + text7 + "','" + text8 + "','" + text9 + "','" + text10 + "','" + text11 + "','" + text12 + "','" + text13 + "')";
					Mod_ConeccionBD.BD_Sentencia(sQL);
				}
			}
			DBF_entregas_v3();
		}
	}

	private static void DBF_entregas_v1()
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		string text = Strings.Format(MyProject.Forms.Form1_Inicio.DateTimePicker1.Value, "ddMMyyyy");
		string text2 = ("SELECT REMITO,FECHA,RS1_DEST,DOM_DEST,LOC_DEST,DESCRIP,KILOS,BULTOS,MT3,VALOR_DECL FROM CSV WHERE FECHA=" + text) ?? "";
		DataTable dataTable = new DataTable("EV1");
		MySqlDataAdapter val = new MySqlDataAdapter(text2, Mod_Sentencias.cnn);
		((DbDataAdapter)(object)val).Fill(dataTable);
		ExportaDT_DBF(dataTable);
	}

	private static void DBF_entregas_v2()
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		string text = Strings.Format(MyProject.Forms.Form1_Inicio.DateTimePicker1.Value, "ddMMyyyy");
		string text2 = ("SELECT REMITO,FECHA,RS1_DEST,DOM_DEST,LOC_DEST,DESCRIP,KILOS,BULTOS,MT3,VALOR_DECL FROM CSV WHERE FECHA=" + text) ?? "";
		DataTable dataTable = new DataTable("EV2");
		MySqlDataAdapter val = new MySqlDataAdapter(text2, Mod_Sentencias.cnn);
		((DbDataAdapter)(object)val).Fill(dataTable);
		ExportaDT_DBF(dataTable);
	}

	private static void DBF_entregas_v3()
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		string text = Strings.Format(MyProject.Forms.Form1_Inicio.DateTimePicker1.Value, "ddMMyyyy");
		string text2 = ("SELECT REMITO,FECHA,RS1_DEST,DOM_DEST,LOC_DEST,DESCRIP,KILOS,BULTOS,MT3,VALOR_DECL FROM CSV WHERE FECHA=" + text) ?? "";
		DataTable dataTable = new DataTable("EV3");
		MySqlDataAdapter val = new MySqlDataAdapter(text2, Mod_Sentencias.cnn);
		((DbDataAdapter)(object)val).Fill(dataTable);
		ExportaDT_DBF(dataTable);
	}

	private static void DBF_retiro_v1()
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		string text = Strings.Format(MyProject.Forms.Form1_Inicio.DateTimePicker1.Value, "ddMMyyyy");
		string text2 = ("SELECT REMITO,FECHA,RS1_DEST,DOM_DEST,LOC_DEST,DESCRIP,KILOS,BULTOS,MT3,VALOR_DECL FROM CSV WHERE FECHA=" + text) ?? "";
		DataTable dataTable = new DataTable("RV1");
		MySqlDataAdapter val = new MySqlDataAdapter(text2, Mod_Sentencias.cnn);
		((DbDataAdapter)(object)val).Fill(dataTable);
		ExportaDT_DBF(dataTable);
	}

	private static void DBF_retiro_v2()
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		string text = Strings.Format(MyProject.Forms.Form1_Inicio.DateTimePicker1.Value, "ddMMyyyy");
		string text2 = ("SELECT REMITO,FECHA,RS1_DEST,DOM_DEST,LOC_DEST,DESCRIP,KILOS,BULTOS,MT3,VALOR_DECL FROM CSV WHERE FECHA=" + text) ?? "";
		DataTable dataTable = new DataTable("RV2");
		MySqlDataAdapter val = new MySqlDataAdapter(text2, Mod_Sentencias.cnn);
		((DbDataAdapter)(object)val).Fill(dataTable);
		ExportaDT_DBF(dataTable);
	}

	private static int CreateDbf(DataTable dt, string tableName, OleDbConnection cnn)
	{
		if (dt == null)
		{
			throw new ArgumentNullException("dt", "El objeto no es válido");
		}
		if (string.IsNullOrEmpty(tableName))
		{
			throw new ArgumentNullException("tableName", "No se ha especificado el nombre de la tabla.");
		}
		if (cnn == null)
		{
			throw new ArgumentNullException("cnn", "El objeto Connection no es válido.");
		}
		string path = (AppDomain.CurrentDomain.BaseDirectory ?? "") + tableName + ".DBF";
		if (File.Exists(path))
		{
			File.Delete(path);
		}
		StringBuilder stringBuilder = new StringBuilder(256);
		try
		{
			stringBuilder.Append("CREATE TABLE " + tableName + "(");
			foreach (DataColumn column in dt.Columns)
			{
				stringBuilder.Append(GetDataTypeSql(column));
			}
			stringBuilder.Replace(',', ')', checked(stringBuilder.Length - 1), 1);
			using (cnn)
			{
				OleDbCommand oleDbCommand = cnn.CreateCommand();
				oleDbCommand.CommandText = stringBuilder.ToString();
				cnn.Open();
				oleDbCommand.ExecuteNonQuery();
				oleDbCommand.CommandText = $"SELECT * FROM [{tableName}]";
				OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(oleDbCommand);
				OleDbCommandBuilder oleDbCommandBuilder = new OleDbCommandBuilder(oleDbDataAdapter);
				oleDbCommandBuilder.QuotePrefix = "[";
				oleDbCommandBuilder.QuoteSuffix = "]";
				oleDbDataAdapter.InsertCommand = oleDbCommandBuilder.GetInsertCommand();
				return oleDbDataAdapter.Update(dt);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			throw;
		}
		finally
		{
			stringBuilder = null;
		}
	}

	private static string GetDataTypeSql(DataColumn dc)
	{
		string columnName = dc.ColumnName;
		string name = dc.DataType.Name;
		string arg;
		int maxLength = default(int);
		if (Operators.CompareString(name, "Boolean", TextCompare: true) == 0)
		{
			arg = "bit";
		}
		else if (Operators.CompareString(name, "Byte", TextCompare: true) == 0 || Operators.CompareString(name, "SByte", TextCompare: true) == 0)
		{
			arg = "tinyint";
		}
		else if (Operators.CompareString(name, "Char", TextCompare: true) == 0)
		{
			arg = "nchar";
			maxLength = dc.MaxLength;
		}
		else if (Operators.CompareString(name, "DateTime", TextCompare: true) == 0)
		{
			arg = "datetime";
		}
		else if (Operators.CompareString(name, "Decimal", TextCompare: true) == 0)
		{
			arg = "decimal (18, 2)";
		}
		else if (Operators.CompareString(name, "Double", TextCompare: true) == 0)
		{
			arg = "real";
		}
		else if (Operators.CompareString(name, "Int16", TextCompare: true) == 0 || Operators.CompareString(name, "UInt16", TextCompare: true) == 0)
		{
			arg = "smallint";
		}
		else if (Operators.CompareString(name, "Int32", TextCompare: true) == 0 || Operators.CompareString(name, "UInt32", TextCompare: true) == 0)
		{
			arg = "int";
		}
		else if (Operators.CompareString(name, "Int64", TextCompare: true) == 0 || Operators.CompareString(name, "UInt64", TextCompare: true) == 0)
		{
			arg = "bigint";
		}
		else if (Operators.CompareString(name, "Object", TextCompare: true) == 0 || Operators.CompareString(name, "Byte[]", TextCompare: true) == 0)
		{
			arg = "image";
		}
		else if (Operators.CompareString(name, "Single", TextCompare: true) == 0)
		{
			arg = "float";
		}
		else if (dc.MaxLength == 536870910)
		{
			arg = "memo";
		}
		else
		{
			arg = "nvarchar";
			maxLength = dc.MaxLength;
		}
		if (maxLength > 0)
		{
			return $"[{columnName}] {arg} ({maxLength}),";
		}
		return $"[{columnName}] {arg},";
	}

	public static int ExportaDT_DBF(DataTable ldt)
	{
		if (ldt == null)
		{
			throw new ArgumentNullException();
		}
		foreach (DataRow row in ldt.Rows)
		{
			row.SetAdded();
		}
		try
		{
			OleDbConnection cnn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + AppDomain.CurrentDomain.BaseDirectory + ";Extended Properties='dBASE III;'");
			return CreateDbf(ldt, ldt.TableName, cnn);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show(ex2.Message);
			ProjectData.ClearProjectError();
		}
		return Conversions.ToInteger("Ok");
	}

	private static void createCSV_table()
	{
		try
		{
			string sQL = "CREATE TABLE CSV (guia int UNSIGNED ZEROFILL NOT NULL AUTO_INCREMENT, REMITO char(12), FECHA char(8), RS1_DEST char(25), DOM_DEST char(25), LOC_DEST char(4), DESCRIP char(20), KILOS decimal(9,3), BULTOS char(5), MT3 decimal(7,3), VALOR_DECL decimal(10,2), VALOR_CR decimal(10,2), PRIMARY KEY (guia)) ";
			Mod_ConeccionBD.BD_Sentencia(sQL);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox(ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	private static void deleteCSV_table()
	{
		try
		{
			string sQL = "DROP TABLE CSV";
			Mod_ConeccionBD.BD_Sentencia(sQL);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox(ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	public static object fleteRealFinal(int id_envio)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		double num = 0.0;
		int num2 = 0;
		try
		{
			string text = "Select round(flete/1.21,2)as flete from etransenvios where id_envio='" + Conversions.ToString(id_envio) + "' LIMIT 1";
			DataTable dataTable = new DataTable("x");
			MySqlDataAdapter val = new MySqlDataAdapter(text, Mod_Sentencias.cnn);
			((DbDataAdapter)(object)val).Fill(dataTable);
			string text2 = Strings.Replace(Conversions.ToDouble(dataTable.Rows[0]["flete"]).ToString(), ",", ".", 1, -1, CompareMethod.Text);
			string sQL = "UPDATE planchada SET flete='" + text2 + "' Where comprobante='" + Conversions.ToString(id_envio) + "' and fecha='2016-05-19'";
			num2 = Conversions.ToInteger(Mod_ConeccionBD.BD_Sentencia(sQL));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		return num2;
	}

	public static void recolecciones()
	{
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected O, but got Unknown
		string empty = string.Empty;
		string text = Strings.Format(MyProject.Forms.Form1_Inicio.DateTimePicker1.Value, "yyyyMMdd");
		string text2 = "Select id_hermes, count(id_envio) as envios, count(bultos) as bultos, cliente, U_calle FROM etransEnvios WHERE U_fecha='" + text + "' AND estado = 'APROBADO' group by cliente, U_calle, U_numero_puerta, U_cp asc";
		DataTable dataTable = new DataTable("x");
		MySqlDataAdapter val = new MySqlDataAdapter(text2, Mod_Sentencias.cnn);
		((DbDataAdapter)(object)val).Fill(dataTable);
		string empty2 = string.Empty;
		string empty3 = string.Empty;
		checked
		{
			int num = dataTable.Rows.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				empty2 = Conversions.ToString(dataTable.Rows[i]["cliente"]);
				empty3 = Conversions.ToString(dataTable.Rows[i]["U_calle"]);
				string text3 = "SELECT id_hermes, id_envio, U_calle, U_numero_puerta, U_cp, U_localidad, U_fecha, U_ventana, bultos, volumen, kilos, declarado FROM etransEnvios WHERE U_fecha='" + text + "' AND cliente='" + empty2 + "' AND U_calle='" + empty3 + "' AND estado='APROBADO'";
				DataTable dataTable2 = new DataTable("x");
				MySqlDataAdapter val2 = new MySqlDataAdapter(text3, Mod_Sentencias.cnn);
				((DbDataAdapter)(object)val2).Fill(dataTable2);
				string empty4 = string.Empty;
				string text4 = Conversions.ToString(dataTable2.Rows[0]["U_calle"]);
				string text5 = Conversions.ToString(dataTable2.Rows[0]["U_numero_puerta"]);
				string text6 = Conversions.ToString(dataTable2.Rows[0]["id_envio"]);
				int num2 = 0;
				decimal num3 = default(decimal);
				decimal num4 = default(decimal);
				decimal num5 = default(decimal);
				int num6 = dataTable2.Rows.Count - 1;
				for (int j = 0; j <= num6; j++)
				{
					int num7 = Conversions.ToInteger(Mod_Etrans.estado_web_etrans(Conversions.ToInteger(dataTable2.Rows[j]["id_envio"])));
					if (num7 == 2)
					{
						if (Operators.ConditionalCompareObjectEqual(duplicadosEtrans(Conversions.ToInteger(dataTable2.Rows[j]["id_envio"])), 0, TextCompare: true))
						{
							num2 = Conversions.ToInteger(Operators.AddObject(num2, dataTable2.Rows[j]["bultos"]));
							num3 = Conversions.ToDecimal(Operators.AddObject(num3, dataTable2.Rows[j]["volumen"]));
							num4 = Conversions.ToDecimal(Operators.AddObject(num4, dataTable2.Rows[j]["kilos"]));
							num5 = Conversions.ToDecimal(Operators.AddObject(num5, dataTable2.Rows[j]["declarado"]));
							string sQL = Conversions.ToString(Operators.ConcatenateObject("UPDATE etransEnvios SET id_retiro=" + text6 + " WHERE id_envio=", dataTable2.Rows[j]["id_envio"]));
							Mod_ConeccionBD.BD_Sentencia(sQL);
						}
						else
						{
							Logger.i(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("remito ya cargardo - ", dataTable2.Rows[j]["id_envio"]), " - "), MySettingsProperty.Settings.Usuario)));
						}
					}
					else if (Versioned.IsNumeric(num7))
					{
						string text7 = Conversions.ToString(Mod_Etrans.estado_int_string(num7));
						string text8 = Conversions.ToString(Mod_Etrans.actualizar_estados(Conversions.ToInteger(dataTable2.Rows[j]["id_envio"]), text7));
						Logger.i(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Se actualiza estado x estado web - ", dataTable2.Rows[j]["id_envio"]), " - "), text7), " - "), MySettingsProperty.Settings.Usuario)));
					}
					else
					{
						Logger.i(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("No se obtuvo estado web - ", dataTable2.Rows[j]["id_envio"]), " - "), MySettingsProperty.Settings.Usuario)));
					}
				}
				empty4 = ((Operators.CompareString(text4, text5, TextCompare: true) == 0) ? text4 : ((!text4.Contains(text5)) ? (text4 + " " + text5) : text4));
				num3 = new decimal(Convert.ToDouble(num3) * 1E-06);
				num3 = Math.Round(num3, 3);
				num3 = Conversions.ToDecimal(Strings.Replace(Conversions.ToString(num3), ",", ".", 1, -1, CompareMethod.Text));
				if (num2 > 0 && Operators.ConditionalCompareObjectEqual(duplicadosEtrans(Conversions.ToInteger(text6)), 0, TextCompare: true))
				{
					empty = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("INSERT INTO Planchada(Eventual, Comprobante, Cliente, Remitos, Destino, Domicilio, CP, Localidad, Declarado, Bultos, Kilos, Sub, Observaciones, Volumen, Atraso, Diferida, Flete, Zona, Adicional, Prioridad, Chofer, Latitud, Longitud, Estado, Fecha, Ventana, Usuario) VALUES (0, '" + text6 + "','ETRANS','" + text6 + "','" + Strings.Replace(empty2, "'", " ", 1, -1, CompareMethod.Text) + "','" + Strings.Replace(empty4, "'", " ", 1, -1, CompareMethod.Text) + "','", dataTable2.Rows[0]["U_cp"]), "','"), dataTable2.Rows[0]["U_localidad"]), "',"), Strings.Replace(Conversions.ToString(num5), ",", ".", 1, -1, CompareMethod.Text)), ",1,"), Strings.Replace(Conversions.ToString(num4), ",", ".", 1, -1, CompareMethod.Text)), ",11,'Recoleccion: "), num2), " Bultos',"), num3), ",0,'"), Strings.Format(RuntimeHelpers.GetObjectValue(dataTable2.Rows[0]["U_fecha"]), "yyyy/MM/dd")), "',0,0,0,0,0,0,0,'En Planchada','"), Strings.Format(RuntimeHelpers.GetObjectValue(dataTable2.Rows[0]["U_fecha"]), "yyyy/MM/dd")), "',"), dataTable2.Rows[0]["U_ventana"]), ",'Hermes')"));
					Mod_ConeccionBD.BD_Sentencia(empty);
				}
			}
		}
	}

	public static object duplicadosEtrans(int id_envio)
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		string text = Strings.Format(MyProject.Forms.Form1_Inicio.DateTimePicker1.Value, "yyyyMMdd");
		string text2 = "SELECT guia FROM planchada WHERE fecha='" + text + "' AND remitos=" + Conversions.ToString(id_envio) + " AND cliente = 'ETRANS'";
		DataTable dataTable = new DataTable("x");
		MySqlDataAdapter val = new MySqlDataAdapter(text2, Mod_Sentencias.cnn);
		((DbDataAdapter)(object)val).Fill(dataTable);
		int num = ((dataTable.Rows.Count > 0) ? 1 : 0);
		return num;
	}

	public static void etrans_entregas()
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		string text = Strings.Format(MyProject.Forms.Form1_Inicio.DateTimePicker1.Value, "yyyyMMdd");
		string text2 = "SELECT id_hermes, id_envio FROM etransEnvios WHERE D_fecha='" + text + "' AND estado = 'EN CD'";
		DataTable dataTable = new DataTable("x");
		MySqlDataAdapter val = new MySqlDataAdapter(text2, Mod_Sentencias.cnn);
		((DbDataAdapter)(object)val).Fill(dataTable);
		string empty = string.Empty;
		checked
		{
			int num = dataTable.Rows.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				int num2 = Conversions.ToInteger(Mod_Etrans.estado_web_etrans(Conversions.ToInteger(dataTable.Rows[i]["id_envio"])));
				if (num2 == 5)
				{
					if (Operators.ConditionalCompareObjectEqual(duplicadosEtrans(Conversions.ToInteger(dataTable.Rows[i]["id_envio"])), 0, TextCompare: true))
					{
						empty = Conversions.ToString(armar_entrega(Conversions.ToInteger(dataTable.Rows[i]["id_envio"])));
						Mod_ConeccionBD.BD_Sentencia(empty);
					}
					else
					{
						Logger.i(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("remito ya cargardo - ", dataTable.Rows[i]["id_envio"]), " - "), MySettingsProperty.Settings.Usuario)));
					}
				}
				else if (Versioned.IsNumeric(num2))
				{
					string text3 = Conversions.ToString(Mod_Etrans.estado_int_string(num2));
					string text4 = Conversions.ToString(Mod_Etrans.actualizar_estados(Conversions.ToInteger(dataTable.Rows[i]["id_envio"]), text3));
					Logger.i(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Se actualiza estado x estado web - ", dataTable.Rows[i]["id_envio"]), " - "), text3), " - "), MySettingsProperty.Settings.Usuario)));
				}
				else
				{
					Logger.i(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("No se obtuvo estado web - ", dataTable.Rows[i]["id_envio"]), " - "), MySettingsProperty.Settings.Usuario)));
				}
			}
		}
	}
}
