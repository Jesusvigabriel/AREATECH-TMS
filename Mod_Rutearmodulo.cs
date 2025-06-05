using System;
using System.Collections;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Api.Maps.Service.Geocoding;
using Hermes.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace Hermes;

[StandardModule]
internal sealed class Mod_Rutearmodulo
{
	private enum ServiceResponse
	{
		Unknown,
		Ok,
		InvalidRequest,
		ZeroResults,
		OverQueryLimit,
		RequestDenied
	}

	public struct datos_ruta
	{
		public int Guias;

		public int Puntos;

		public double Volumen;

		public double Flete;

		public double Kilos;

		public double Declarado;

		public int Bultos;
	}

	internal static ArrayList dir_error = new ArrayList();

	internal static ArrayList nom_error = new ArrayList();

	public static void rutear_todos()
	{
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Expected O, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected O, but got Unknown
		//IL_0420: Unknown result type (might be due to invalid IL or missing references)
		//IL_0427: Expected O, but got Unknown
		//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Expected O, but got Unknown
		checked
		{
			try
			{
				Mod_Sentencias.cnn.Open();
				string text = Strings.Format(MyProject.Forms.Form1_Inicio.DateTimePicker1.Value, "yyyyMMdd");
				DataTable dataTable = new DataTable("x");
				DataTable dataTable2 = new DataTable("xx");
				DataSet dataSet = new DataSet();
				long num = 0L;
				int num2 = 0;
				int num3 = 0;
				string text2 = "SELECT * FROM Planchada WHERE Ventana=0 AND Chofer= 0 AND Fecha='" + text + "'";
				MySqlDataAdapter val = new MySqlDataAdapter(text2, Mod_Sentencias.cnn);
				((DbDataAdapter)(object)val).Fill(dataTable);
				int count = dataTable.Rows.Count;
				for (int i = 0; i <= count; i++)
				{
					try
					{
						string text3 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("INSERT INTO Eventuales(Cliente, Eventual, Zona, Domicilio, Localidad, CP, Adicional, Prioridad, Sub, Normalizada, Latitud, Longitud, Franja, Fecha, Usuario)values('", dataTable.Rows[i]["Destino"]), "',"), dataTable.Rows[i]["Eventual"].ToString()), ",0,'"), dataTable.Rows[i]["Domicilio"].ToString()), "','"), dataTable.Rows[i]["Localidad"].ToString()), "','"), dataTable.Rows[i]["CP"].ToString()), "',0,0,'"), dataTable.Rows[i]["Sub"].ToString()), "',0,-34.603561,-58.277087,"), MyProject.Forms.Form1_Inicio.ComboBox1.Text), ",'"), text), "','"), MyProject.Forms.Form1_Inicio.nombreusuario.Text), "')"));
						MySqlCommand val2 = new MySqlCommand(text3, Mod_Sentencias.cnn);
						val2.ExecuteNonQuery();
						num++;
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						string text4 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("SELECT * FROM Eventuales where Eventual= ", dataTable.Rows[i]["Eventual"]), ""));
						MySqlDataAdapter val3 = new MySqlDataAdapter(text4, Mod_Sentencias.cnn);
						((DbDataAdapter)(object)val3).Fill(dataTable2);
						string left = Conversions.ToString(dataTable.Rows[i]["Destino"]);
						string left2 = Conversions.ToString(dataTable.Rows[i]["Domicilio"]);
						string right = Conversions.ToString(dataTable2.Rows[0]["Cliente"]);
						string right2 = Conversions.ToString(dataTable2.Rows[0]["Domicilio"]);
						string text5;
						if (Operators.CompareString(left, right, TextCompare: true) == 0)
						{
							if (Operators.CompareString(left2, right2, TextCompare: true) == 0)
							{
								text5 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("UPDATE Planchada SET Zona=", dataTable2.Rows[0]["Zona"]), ",Eventual="), dataTable2.Rows[0]["Eventual"]), ", Adicional="), dataTable2.Rows[0]["Adicional"]), ",Prioridad="), dataTable2.Rows[0]["Prioridad"]), ",Latitud= '"), dataTable2.Rows[0]["Latitud"]), "',Longitud= '"), dataTable2.Rows[0]["Longitud"]), "' WHERE Comprobante= '"), dataTable.Rows[i]["Comprobante"]), "'"));
								MySqlCommand val2 = new MySqlCommand(text5, Mod_Sentencias.cnn);
								val2.ExecuteNonQuery();
							}
							else
							{
								num2++;
							}
						}
						else
						{
							num3++;
						}
						val3 = null;
						dataTable2.Clear();
						text4 = null;
						text5 = null;
						ProjectData.ClearProjectError();
					}
				}
				Mod_Sentencias.cnn.Close();
				Interaction.MsgBox("errores de eventuales " + Conversions.ToString(num3) + ", errores de direccion " + Conversions.ToString(num2));
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Mod_Sentencias.cnn.Close();
				MyProject.Forms.Procesos.Close();
				Interaction.MsgBox(ex2.Message);
				ProjectData.ClearProjectError();
			}
		}
	}

	public static void localidades_s()
	{
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected O, but got Unknown
		//IL_0231: Unknown result type (might be due to invalid IL or missing references)
		//IL_0238: Expected O, but got Unknown
		//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02db: Expected O, but got Unknown
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Expected O, but got Unknown
		checked
		{
			try
			{
				MyProject.Forms.Procesos.Refresh();
				Mod_Sentencias.cnn.Open();
				string text = Strings.Format(MyProject.Forms.Form1_Inicio.DateTimePicker1.Value, "yyyyMMdd");
				DataTable dataTable = new DataTable("x");
				DataTable dataTable2 = new DataTable("xx");
				DataSet dataSet = new DataSet();
				long num = 0L;
				string text2 = "SELECT DISTINCT CP, Localidad FROM Planchada WHERE CP>'1000' AND Ventana=0 AND zona=0 and Chofer=0 AND Fecha='" + text + "'";
				MySqlDataAdapter val = new MySqlDataAdapter(text2, Mod_Sentencias.cnn);
				((DbDataAdapter)(object)val).Fill(dataTable);
				MyProject.Forms.Procesos.ProgressBar5.Maximum = dataTable.Rows.Count + 1;
				MyProject.Forms.Procesos.ProgressBar5.Value = 0;
				MyProject.Forms.Procesos.Label5.Text = Conversions.ToString(dataTable.Rows.Count);
				int count = dataTable.Rows.Count;
				MyProject.Forms.Procesos.Refresh();
				int num2 = dataTable.Rows.Count - 1;
				for (int i = 0; i <= num2; i++)
				{
					MyProject.Forms.Procesos.ProgressBar5.Value = MyProject.Forms.Procesos.ProgressBar5.Value + 1;
					try
					{
						string text3 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("INSERT INTO Localidades (Localidad, CP, zona, Adicional)values('", dataTable.Rows[i]["Localidad"]), "','"), dataTable.Rows[i]["CP"].ToString()), "' ,0,0)"));
						MySqlCommand val2 = new MySqlCommand(text3, Mod_Sentencias.cnn);
						val2.ExecuteNonQuery();
						num++;
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						int num3 = Conversions.ToInteger(dataTable.Rows[i]["CP"]);
						if (num3 > 0)
						{
							string text4 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("SELECT Zona, Adicional FROM Localidades where CP= ", dataTable.Rows[i]["CP"]), ""));
							MySqlDataAdapter val3 = new MySqlDataAdapter(text4, Mod_Sentencias.cnn);
							((DbDataAdapter)(object)val3).Fill(dataTable2);
							string text5 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("UPDATE Planchada SET Zona=", dataTable2.Rows[0]["Zona"]), ", Adicional="), dataTable2.Rows[0]["Adicional"]), " WHERE CP= '"), dataTable.Rows[i]["CP"]), "' AND Fecha='"), text), "'"));
							MySqlCommand val2 = new MySqlCommand(text5, Mod_Sentencias.cnn);
							val2.ExecuteNonQuery();
							val3 = null;
							dataTable2.Clear();
							text4 = null;
							text5 = null;
						}
						ProjectData.ClearProjectError();
					}
				}
				MyProject.Forms.Procesos.ProgressBar5.Maximum = 10;
				MyProject.Forms.Procesos.ProgressBar5.Value = 10;
				MyProject.Forms.Procesos.Refresh();
				MyProject.Forms.Infimportacion.localidadtxt.Text = Conversions.ToString(num);
				MyProject.Forms.Infimportacion.importadastxt.Text = Conversions.ToString(count);
				Mod_Sentencias.cnn.Close();
				MyProject.Forms.Procesos.Close();
				MyProject.Forms.Infimportacion.Show();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				MyProject.Forms.Procesos.Close();
				Mod_Sentencias.cnn.Close();
				Interaction.MsgBox(ex2.Message);
				ProjectData.ClearProjectError();
			}
		}
	}

	public static void eventuales_gba()
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected O, but got Unknown
		//IL_0316: Unknown result type (might be due to invalid IL or missing references)
		//IL_031d: Expected O, but got Unknown
		//IL_0456: Unknown result type (might be due to invalid IL or missing references)
		//IL_045d: Expected O, but got Unknown
		//IL_0290: Unknown result type (might be due to invalid IL or missing references)
		//IL_0297: Expected O, but got Unknown
		checked
		{
			try
			{
				Mod_Sentencias.cnn.Open();
				string text = Strings.Format(MyProject.Forms.Form1_Inicio.DateTimePicker1.Value, "yyyyMMdd");
				DataTable dataTable = new DataTable("x");
				DataTable dataTable2 = new DataTable("xx");
				DataSet dataSet = new DataSet();
				long num = 0L;
				string text2 = "SELECT Destino, Eventual, Domicilio, Localidad, CP, Sub FROM Planchada WHERE cp>'1599' AND Eventual>0 AND Chofer = 0 AND zona=0 AND Ventana=0 AND Fecha='" + text + "'";
				MySqlDataAdapter val = new MySqlDataAdapter(text2, Mod_Sentencias.cnn);
				((DbDataAdapter)(object)val).Fill(dataTable);
				MyProject.Forms.Procesos.ProgressBar2.Maximum = dataTable.Rows.Count + 1;
				MyProject.Forms.Procesos.ProgressBar2.Value = 0;
				MyProject.Forms.Procesos.Label2.Text = Conversions.ToString(dataTable.Rows.Count);
				MyProject.Forms.Procesos.Refresh();
				int num2 = dataTable.Rows.Count - 1;
				for (int i = 0; i <= num2; i++)
				{
					MyProject.Forms.Procesos.ProgressBar2.Value = MyProject.Forms.Procesos.ProgressBar2.Value + 1;
					try
					{
						string text3 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("INSERT INTO Eventuales(Cliente, Eventual, Zona, Domicilio, Localidad, CP, Adicional, Prioridad, Sub, Normalizada, Latitud, Longitud, Franja, Fecha, Usuario)values('", dataTable.Rows[i]["Destino"]), "',"), dataTable.Rows[i]["Eventual"].ToString()), ",0,'"), dataTable.Rows[i]["Domicilio"].ToString()), "','"), dataTable.Rows[i]["Localidad"].ToString()), "','"), dataTable.Rows[i]["CP"].ToString()), "',0,0,'"), dataTable.Rows[i]["Sub"].ToString()), "',0,-34.603561,-58.277087,"), MyProject.Forms.Form1_Inicio.ComboBox1.Text), ",'"), text), "','"), MyProject.Forms.Form1_Inicio.nombreusuario.Text), "')"));
						MySqlCommand val2 = new MySqlCommand(text3, Mod_Sentencias.cnn);
						val2.ExecuteNonQuery();
						num++;
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						int num3 = Conversions.ToInteger(dataTable.Rows[i]["Eventual"]);
						if (num3 > 0)
						{
							string text4 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("SELECT Zona, Adicional, Prioridad, Latitud, Longitud FROM Eventuales where Eventual= ", dataTable.Rows[i]["Eventual"]), ""));
							MySqlDataAdapter val3 = new MySqlDataAdapter(text4, Mod_Sentencias.cnn);
							((DbDataAdapter)(object)val3).Fill(dataTable2);
							string text5 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("UPDATE Planchada SET Zona=", dataTable2.Rows[0]["Zona"]), ",Adicional="), dataTable2.Rows[0]["Adicional"]), ",Prioridad="), dataTable2.Rows[0]["Prioridad"]), ",Latitud="), Strings.Replace(Conversions.ToString(dataTable2.Rows[0]["Latitud"]), ",", ".", 1, -1, CompareMethod.Text)), ",Longitud="), Strings.Replace(Conversions.ToString(dataTable2.Rows[0]["Longitud"]), ",", ".", 1, -1, CompareMethod.Text)), " WHERE Eventual= '"), dataTable.Rows[i]["Eventual"]), "' AND Fecha='"), text), "'"));
							MySqlCommand val2 = new MySqlCommand(text5, Mod_Sentencias.cnn);
							val2.ExecuteNonQuery();
							val3 = null;
							dataTable2.Clear();
							text4 = null;
							text5 = null;
						}
						ProjectData.ClearProjectError();
					}
				}
				Mod_Sentencias.cnn.Close();
				MyProject.Forms.Procesos.ProgressBar2.Maximum = 10;
				MyProject.Forms.Procesos.ProgressBar2.Value = 10;
				MyProject.Forms.Procesos.Refresh();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				MyProject.Forms.Procesos.Close();
				Mod_Sentencias.cnn.Close();
				ProjectData.ClearProjectError();
			}
		}
	}

	public static void eventuales_caba()
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected O, but got Unknown
		//IL_0316: Unknown result type (might be due to invalid IL or missing references)
		//IL_031d: Expected O, but got Unknown
		//IL_0456: Unknown result type (might be due to invalid IL or missing references)
		//IL_045d: Expected O, but got Unknown
		//IL_0290: Unknown result type (might be due to invalid IL or missing references)
		//IL_0297: Expected O, but got Unknown
		checked
		{
			try
			{
				Mod_Sentencias.cnn.Open();
				string text = Strings.Format(MyProject.Forms.Form1_Inicio.DateTimePicker1.Value, "yyyyMMdd");
				DataTable dataTable = new DataTable("x");
				DataTable dataTable2 = new DataTable("xx");
				DataSet dataSet = new DataSet();
				long num = 0L;
				string text2 = "SELECT Destino, Eventual, Domicilio, Localidad, CP, Sub FROM Planchada WHERE Eventual>0 AND Cp <'1600' AND Chofer=0 AND zona=0 AND Ventana=0 AND Fecha='" + text + "'";
				MySqlDataAdapter val = new MySqlDataAdapter(text2, Mod_Sentencias.cnn);
				((DbDataAdapter)(object)val).Fill(dataTable);
				MyProject.Forms.Procesos.ProgressBar3.Maximum = dataTable.Rows.Count + 1;
				MyProject.Forms.Procesos.ProgressBar3.Value = 0;
				MyProject.Forms.Procesos.Label3.Text = Conversions.ToString(dataTable.Rows.Count);
				MyProject.Forms.Procesos.Refresh();
				int num2 = dataTable.Rows.Count - 1;
				for (int i = 0; i <= num2; i++)
				{
					MyProject.Forms.Procesos.ProgressBar3.Value = MyProject.Forms.Procesos.ProgressBar3.Value + 1;
					try
					{
						string text3 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("INSERT INTO Eventuales(Cliente, Eventual, Zona, Domicilio, Localidad, CP, Adicional, Prioridad, Sub, Normalizada, Latitud, Longitud, Franja, Fecha, Usuario)values('", dataTable.Rows[i]["Destino"]), "',"), dataTable.Rows[i]["Eventual"].ToString()), ",0,'"), dataTable.Rows[i]["Domicilio"].ToString()), "','"), dataTable.Rows[i]["Localidad"].ToString()), "','"), dataTable.Rows[i]["CP"].ToString()), "',0,0,'"), dataTable.Rows[i]["Sub"].ToString()), "',0,-34.603561,-58.277087,"), MyProject.Forms.Form1_Inicio.ComboBox1.Text), ",'"), text), "','"), MyProject.Forms.Form1_Inicio.nombreusuario.Text), "')"));
						MySqlCommand val2 = new MySqlCommand(text3, Mod_Sentencias.cnn);
						val2.ExecuteNonQuery();
						num++;
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						int num3 = Conversions.ToInteger(dataTable.Rows[i]["Eventual"]);
						if (num3 > 0)
						{
							string text4 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("SELECT Zona, Adicional, Prioridad, Latitud, Longitud FROM Eventuales where Eventual= ", dataTable.Rows[i]["Eventual"]), ""));
							MySqlDataAdapter val3 = new MySqlDataAdapter(text4, Mod_Sentencias.cnn);
							((DbDataAdapter)(object)val3).Fill(dataTable2);
							string text5 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("UPDATE Planchada SET Zona=", dataTable2.Rows[0]["Zona"]), ",Adicional="), dataTable2.Rows[0]["Adicional"]), ",Prioridad="), dataTable2.Rows[0]["Prioridad"]), ",Latitud="), Strings.Replace(Conversions.ToString(dataTable2.Rows[0]["Latitud"]), ",", ".", 1, -1, CompareMethod.Text)), ",Longitud="), Strings.Replace(Conversions.ToString(dataTable2.Rows[0]["Longitud"]), ",", ".", 1, -1, CompareMethod.Text)), " WHERE Eventual= '"), dataTable.Rows[i]["Eventual"]), "' AND Chofer= 0 AND Fecha='"), text), "'"));
							MySqlCommand val2 = new MySqlCommand(text5, Mod_Sentencias.cnn);
							val2.ExecuteNonQuery();
							val3 = null;
							dataTable2.Clear();
							text4 = null;
							text5 = null;
						}
						ProjectData.ClearProjectError();
					}
				}
				Mod_Sentencias.cnn.Close();
				MyProject.Forms.Procesos.ProgressBar3.Maximum = 10;
				MyProject.Forms.Procesos.ProgressBar3.Value = 10;
				MyProject.Forms.Procesos.Refresh();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception objExcepcion = ex;
				Mod_Sentencias.cnn.Close();
				MyProject.Forms.Procesos.Close();
				Logger.e("Error con excepción y traza", objExcepcion, new StackFrame(fNeedFileInfo: true));
				ProjectData.ClearProjectError();
			}
		}
	}

	public static void busca_eve()
	{
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected O, but got Unknown
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Expected O, but got Unknown
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Expected O, but got Unknown
		string text = Strings.Format(MyProject.Forms.Form1_Inicio.DateTimePicker1.Value, "yyyyMMdd");
		checked
		{
			try
			{
				Mod_Sentencias.cnn.Open();
				DataTable dataTable = new DataTable("x");
				DataTable dataTable2 = new DataTable("xx");
				DataSet dataSet = new DataSet();
				string text2 = "SELECT Guia, Destino, Domicilio FROM Planchada WHERE Eventual=0 AND zona=0 and Chofer=0 AND Ventana=0 AND Fecha='" + text + "'";
				MySqlDataAdapter val = new MySqlDataAdapter(text2, Mod_Sentencias.cnn);
				((DbDataAdapter)(object)val).Fill(dataTable);
				MyProject.Forms.Procesos.ProgressBar1.Maximum = dataTable.Rows.Count + 1;
				MyProject.Forms.Procesos.ProgressBar1.Value = 0;
				MyProject.Forms.Procesos.Label1.Text = Conversions.ToString(dataTable.Rows.Count);
				MyProject.Forms.Procesos.Refresh();
				int num = dataTable.Rows.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					MyProject.Forms.Procesos.ProgressBar1.Value = MyProject.Forms.Procesos.ProgressBar1.Value + 1;
					try
					{
						string text3 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("SELECT Eventual, Cliente, Domicilio FROM Eventuales WHERE Cliente='", dataTable.Rows[i]["Destino"]), "'"));
						MySqlDataAdapter val2 = new MySqlDataAdapter(text3, Mod_Sentencias.cnn);
						((DbDataAdapter)(object)val2).Fill(dataTable2);
						string text4 = Conversions.ToString(dataTable.Rows[i]["Destino"]);
						string left = Conversions.ToString(dataTable.Rows[i]["Domicilio"]);
						string text5 = Conversions.ToString(dataTable2.Rows[0]["Cliente"]);
						string right = Conversions.ToString(dataTable2.Rows[0]["Domicilio"]);
						string text6;
						if (Operators.CompareString(left, right, TextCompare: true) == 0)
						{
							text6 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("UPDATE Planchada SET Eventual=", dataTable2.Rows[0]["Eventual"]), " WHERE Guia= '"), dataTable.Rows[i]["Guia"]), "'"));
							MySqlCommand val3 = new MySqlCommand(text6, Mod_Sentencias.cnn);
							val3.ExecuteNonQuery();
						}
						else
						{
							dir_error.Add(RuntimeHelpers.GetObjectValue(dataTable.Rows[i]["Comprobante"]));
						}
						val2 = null;
						dataTable2.Clear();
						text3 = null;
						text6 = null;
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						nom_error.Add(RuntimeHelpers.GetObjectValue(dataTable.Rows[i]["Guia"]));
						ProjectData.ClearProjectError();
					}
				}
				Mod_Sentencias.cnn.Close();
				MyProject.Forms.Procesos.ProgressBar1.Value = MyProject.Forms.Procesos.ProgressBar1.Maximum;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception objExcepcion = ex;
				Mod_Sentencias.cnn.Close();
				Logger.e("Error con excepción y traza", objExcepcion, new StackFrame(fNeedFileInfo: true));
				ProjectData.ClearProjectError();
			}
		}
	}

	public static void etrans_pos()
	{
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected O, but got Unknown
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Expected O, but got Unknown
		//IL_031a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0321: Expected O, but got Unknown
		//IL_0273: Unknown result type (might be due to invalid IL or missing references)
		//IL_027a: Expected O, but got Unknown
		//IL_03bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c4: Expected O, but got Unknown
		checked
		{
			try
			{
				Mod_Sentencias.cnn.Open();
				string text = Strings.Format(MyProject.Forms.Form1_Inicio.DateTimePicker1.Value, "yyyyMMdd");
				DataTable dataTable = new DataTable("x");
				DataTable dataTable2 = new DataTable("xx");
				DataSet dataSet = new DataSet();
				string text2 = "SELECT sub, remitos, comprobante, guia FROM planchada WHERE cliente='ETRANS' AND chofer=0 AND zona=0 AND Fecha='" + text + "'";
				MySqlDataAdapter val = new MySqlDataAdapter(text2, Mod_Sentencias.cnn);
				((DbDataAdapter)(object)val).Fill(dataTable);
				MyProject.Forms.Procesos.ProgressBar4.Maximum = dataTable.Rows.Count + 1;
				MyProject.Forms.Procesos.ProgressBar4.Value = 0;
				MyProject.Forms.Procesos.Label4.Text = Conversions.ToString(dataTable.Rows.Count);
				MyProject.Forms.Procesos.Refresh();
				int num = dataTable.Rows.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					MyProject.Forms.Procesos.ProgressBar4.Value = MyProject.Forms.Procesos.ProgressBar4.Value + 1;
					if (Operators.ConditionalCompareObjectEqual(dataTable.Rows[i]["Sub"], 11, TextCompare: true))
					{
						try
						{
							int id_envio = Conversions.ToInteger(dataTable.Rows[i]["remitos"]);
							object obj = Mod_Etrans.updatedirR(id_envio);
							Mod_Etrans.envionuevoEtrans envionuevoEtrans = ((obj != null) ? ((Mod_Etrans.envionuevoEtrans)obj) : default(Mod_Etrans.envionuevoEtrans));
							string direccionE = envionuevoEtrans.direccionE;
							string cpE = envionuevoEtrans.cpE;
							string localidadE = envionuevoEtrans.localidadE;
							string text3 = "SELECT zona FROM localidades WHERE cp='" + cpE + "'";
							DataTable dataTable3 = new DataTable("x");
							MySqlDataAdapter val2 = new MySqlDataAdapter(text3, Mod_Sentencias.cnn);
							int num2 = 0;
							((DbDataAdapter)(object)val2).Fill(dataTable3);
							if (dataTable3.Rows.Count > 0)
							{
								num2 = Conversions.ToInteger(dataTable3.Rows[0]["zona"]);
							}
							string text4 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("UPDATE Planchada Set Zona=" + Conversions.ToString(num2) + " WHERE Guia= '", dataTable.Rows[i]["Guia"]), "' AND Fecha='"), text), "'"));
							MySqlCommand val3 = new MySqlCommand(text4, Mod_Sentencias.cnn);
							val3.ExecuteNonQuery();
						}
						catch (Exception ex)
						{
							ProjectData.SetProjectError(ex);
							Exception ex2 = ex;
							ProjectData.ClearProjectError();
						}
						continue;
					}
					try
					{
						int id_envio2 = Conversions.ToInteger(dataTable.Rows[i]["remitos"]);
						object obj2 = Mod_Etrans.updatedirE(id_envio2);
						Mod_Etrans.envionuevoEtrans envionuevoEtrans2 = ((obj2 != null) ? ((Mod_Etrans.envionuevoEtrans)obj2) : default(Mod_Etrans.envionuevoEtrans));
						string direccionE2 = envionuevoEtrans2.direccionE;
						string cpE2 = envionuevoEtrans2.cpE;
						string localidadE2 = envionuevoEtrans2.localidadE;
						string text5 = "SELECT zona FROM localidades WHERE cp='" + cpE2 + "'";
						DataTable dataTable4 = new DataTable("x");
						MySqlDataAdapter val4 = new MySqlDataAdapter(text5, Mod_Sentencias.cnn);
						int num3 = 0;
						((DbDataAdapter)(object)val4).Fill(dataTable4);
						if (dataTable4.Rows.Count > 0)
						{
							num3 = Conversions.ToInteger(dataTable4.Rows[0]["zona"]);
						}
						string text6 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("UPDATE Planchada SET  Zona=" + Conversions.ToString(num3) + " WHERE Guia= '", dataTable.Rows[i]["Guia"]), "' AND Fecha='"), text), "'"));
						MySqlCommand val5 = new MySqlCommand(text6, Mod_Sentencias.cnn);
						val5.ExecuteNonQuery();
					}
					catch (Exception ex3)
					{
						ProjectData.SetProjectError(ex3);
						Exception ex4 = ex3;
						Interaction.MsgBox(ex4.Message + " 2");
						ProjectData.ClearProjectError();
					}
				}
				Mod_Sentencias.cnn.Close();
				MyProject.Forms.Procesos.ProgressBar4.Maximum = 10;
				MyProject.Forms.Procesos.ProgressBar4.Value = 10;
				MyProject.Forms.Procesos.Refresh();
			}
			catch (Exception ex5)
			{
				ProjectData.SetProjectError(ex5);
				Exception ex6 = ex5;
				Mod_Sentencias.cnn.Close();
				Interaction.MsgBox(ex6.Message);
				ProjectData.ClearProjectError();
			}
		}
	}

	public static void algoritmo_facu()
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Expected O, but got Unknown
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Invalid comparison between Unknown and I4
		//IL_02f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0300: Expected O, but got Unknown
		//IL_039c: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a3: Expected O, but got Unknown
		try
		{
			Mod_Sentencias.cnn.Open();
			string text = Strings.Format(MyProject.Forms.Form1_Inicio.DateTimePicker1.Value, "yyyyMMdd");
			DataTable dataTable = new DataTable("x");
			DataTable dataTable2 = new DataTable("xx");
			DataSet dataSet = new DataSet();
			int num = 0;
			int num2 = 0;
			string text2 = "SELECT Guia, Localidad, Domicilio, CP FROM Planchada WHERE Ventana=0 AND Chofer= 0 AND Fecha='" + text + "'";
			MySqlDataAdapter val = new MySqlDataAdapter(text2, Mod_Sentencias.cnn);
			((DbDataAdapter)(object)val).Fill(dataTable);
			int num3 = checked(dataTable.Rows.Count - 1);
			for (int i = 0; i <= num3; i = checked(i + 1))
			{
				int guia = Conversions.ToInteger(dataTable.Rows[i]["Guia"]);
				try
				{
					string empty = string.Empty;
					string empty2 = string.Empty;
					if (Operators.ConditionalCompareObjectEqual(dataTable.Rows[i]["Localidad"], "C.A.B.A.", TextCompare: true))
					{
						empty = ",buenos aires";
					}
					else
					{
						empty = Conversions.ToString(dataTable.Rows[i]["Localidad"]);
					}
					empty2 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Right: (!Operators.ConditionalCompareObjectEqual(dataTable.Rows[i]["Localidad"], "CIUDAD AUTONOMA DE BS.AS", TextCompare: true)) ? Conversions.ToString(dataTable.Rows[i]["Localidad"]) : ",buenos aires", Left: Operators.ConcatenateObject(Operators.ConcatenateObject("", dataTable.Rows[i]["Domicilio"]), ",")), ""));
					empty2 = empty2.Replace(" ", "+");
					empty2 = empty2.Replace("  ", "+");
					GeocodingRequest val2 = new GeocodingRequest();
					val2.Address = empty2;
					val2.Sensor = "false";
					GeocodingResponse response = GeocodingService.GetResponse(val2);
					if ((int)response.Status == 1)
					{
						string text3 = response.Results[0].FormattedAddress.ToString();
						double ax = Convert.ToDouble(response.Results[0].Geometry.Location.Latitude);
						double ay = Convert.ToDouble(response.Results[0].Geometry.Location.Longitude);
						try
						{
							localizar_punto(ax, ay, guia);
						}
						catch (Exception ex)
						{
							ProjectData.SetProjectError(ex);
							Exception objExcepcion = ex;
							Logger.e("Error con excepción y traza", objExcepcion, new StackFrame(fNeedFileInfo: true));
							ProjectData.ClearProjectError();
						}
					}
					else
					{
						int num4 = Conversions.ToInteger(dataTable.Rows[i]["CP"]);
						if (num4 > 0)
						{
							string text4 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("SELECT Zona, Adicional FROM Localidades where CP= ", dataTable.Rows[i]["CP"]), ""));
							MySqlDataAdapter val3 = new MySqlDataAdapter(text4, Mod_Sentencias.cnn);
							((DbDataAdapter)(object)val3).Fill(dataTable2);
							string text5 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("UPDATE Planchada SET Zona=", dataTable2.Rows[0]["Zona"]), ",Adicional="), dataTable2.Rows[0]["Adicional"]), " WHERE CP= '"), dataTable.Rows[i]["CP"]), "' AND Fecha='"), text), "'"));
							MySqlCommand val4 = new MySqlCommand(text5, Mod_Sentencias.cnn);
							val4.ExecuteNonQuery();
						}
					}
				}
				catch (Exception ex2)
				{
					ProjectData.SetProjectError(ex2);
					Exception objExcepcion2 = ex2;
					Logger.e("Error con excepción y traza", objExcepcion2, new StackFrame(fNeedFileInfo: true));
					ProjectData.ClearProjectError();
				}
			}
			Mod_Sentencias.cnn.Close();
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception objExcepcion3 = ex3;
			Mod_Sentencias.cnn.Close();
			Logger.e("Error con excepción y traza", objExcepcion3, new StackFrame(fNeedFileInfo: true));
			ProjectData.ClearProjectError();
		}
	}

	public static void localizar_punto(double Ax0, double Ay0, int guia)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		checked
		{
			try
			{
				string text = "SELECT DISTINCT zona FROM Dibujos ORDER BY zona";
				DataTable dataTable = new DataTable("x");
				MySqlDataAdapter val = new MySqlDataAdapter(text, Mod_Sentencias.cnn);
				((DbDataAdapter)(object)val).Fill(dataTable);
				int num = dataTable.Rows.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					int valorzona = Conversions.ToInteger(dataTable.Rows[i]["Zona"]);
					if (Conversions.ToBoolean(Mod_Calculos.puntoenpoligono3(valorzona, Ax0, Ay0)))
					{
						int zona = Conversions.ToInteger(dataTable.Rows[i]["zona"]);
						update_zona(zona, guia, Ax0, Ay0);
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception objExcepcion = ex;
				Logger.e("Error con excepción y traza", objExcepcion, new StackFrame(fNeedFileInfo: true));
				ProjectData.ClearProjectError();
			}
		}
	}

	public static void update_zona(int zona, int Guia, double Ax0, double Ay0)
	{
		try
		{
			string text = Strings.Format(MyProject.Forms.Form1_Inicio.DateTimePicker1.Value, "yyyyMMdd");
			string sQL = ("UPDATE Planchada SET Zona=" + Conversions.ToString(zona) + ", Latitud='" + Strings.Replace(Conversions.ToString(Ax0), ",", ".", 1, -1, CompareMethod.Text) + "', Longitud='" + Strings.Replace(Conversions.ToString(Ay0), ",", ".", 1, -1, CompareMethod.Text) + "' WHERE Guia= " + Conversions.ToString(Guia)) ?? "";
			int num = Conversions.ToInteger(Mod_ConeccionBD.BD_Sentencia(sQL));
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objExcepcion = ex;
			Logger.e("Error con excepción y traza", objExcepcion, new StackFrame(fNeedFileInfo: true));
			ProjectData.ClearProjectError();
		}
	}

	public static object calculos_ruta(string Chofer)
	{
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected O, but got Unknown
		int num = Conversions.ToInteger(MyProject.Forms.Form1_Inicio.ComboBox1.Text);
		string text = Strings.Format(MyProject.Forms.Form1_Inicio.DateTimePicker1.Value, "yyyyMMdd");
		string text2 = ("SELECT COUNT(Destino) As Guias, COUNT(DISTINCT Destino) As Destino, sum(Volumen) AS Volumen,sum(Flete) As Flete,sum(Kilos) AS Kilos,sum(Declarado) AS Declarado,sum(Bultos) AS Bultos FROM Planchada WHERE Chofer=" + Chofer + " AND Fecha='" + text + "' AND Ventana =" + Conversions.ToString(num)) ?? "";
		DataTable dataTable = new DataTable("x");
		MySqlDataAdapter val = new MySqlDataAdapter(text2, Mod_Sentencias.cnn);
		((DbDataAdapter)(object)val).Fill(dataTable);
		datos_ruta datos_ruta = default(datos_ruta);
		datos_ruta.Guias = Conversions.ToInteger(dataTable.Rows[0]["Guias"]);
		datos_ruta.Puntos = Conversions.ToInteger(dataTable.Rows[0]["Destino"]);
		object[] array;
		DataRow dataRow;
		bool[] array2;
		object value = NewLateBinding.LateGet(null, typeof(Math), "Round", array = new object[2]
		{
			(dataRow = dataTable.Rows[0])["Volumen"],
			3
		}, null, null, array2 = new bool[2] { true, false });
		if (array2[0])
		{
			dataRow["Volumen"] = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
		datos_ruta.Volumen = Conversions.ToDouble(value);
		object value2 = NewLateBinding.LateGet(null, typeof(Math), "Round", array = new object[2]
		{
			(dataRow = dataTable.Rows[0])["Flete"],
			2
		}, null, null, array2 = new bool[2] { true, false });
		if (array2[0])
		{
			dataRow["Flete"] = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
		datos_ruta.Flete = Conversions.ToDouble(value2);
		object value3 = NewLateBinding.LateGet(null, typeof(Math), "Round", array = new object[2]
		{
			(dataRow = dataTable.Rows[0])["Kilos"],
			2
		}, null, null, array2 = new bool[2] { true, false });
		if (array2[0])
		{
			dataRow["Kilos"] = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
		datos_ruta.Kilos = Conversions.ToDouble(value3);
		object value4 = NewLateBinding.LateGet(null, typeof(Math), "Round", array = new object[2]
		{
			(dataRow = dataTable.Rows[0])["Declarado"],
			2
		}, null, null, array2 = new bool[2] { true, false });
		if (array2[0])
		{
			dataRow["Declarado"] = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
		datos_ruta.Declarado = Conversions.ToDouble(value4);
		datos_ruta.Bultos = Conversions.ToInteger(dataTable.Rows[0]["Bultos"]);
		return datos_ruta;
	}

	public static object calculos_zona(int Zona)
	{
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected O, but got Unknown
		int num = Conversions.ToInteger(MyProject.Forms.Form1_Inicio.ComboBox1.Text);
		string text = Strings.Format(MyProject.Forms.Form1_Inicio.DateTimePicker1.Value, "yyyyMMdd");
		string text2 = "SELECT COUNT(Destino) As Guias, COUNT(DISTINCT Destino) As Destino, sum(Volumen) AS Volumen,sum(Flete) As Flete,sum(Kilos) AS Kilos,sum(Declarado) AS Declarado,sum(Bultos) AS Bultos FROM Planchada WHERE Zona=" + Conversions.ToString(Zona) + " AND Chofer=0 AND Fecha='" + text + "'";
		DataTable dataTable = new DataTable("x");
		MySqlDataAdapter val = new MySqlDataAdapter(text2, Mod_Sentencias.cnn);
		((DbDataAdapter)(object)val).Fill(dataTable);
		datos_ruta datos_ruta = default(datos_ruta);
		datos_ruta.Guias = Conversions.ToInteger(dataTable.Rows[0]["Guias"]);
		datos_ruta.Puntos = Conversions.ToInteger(dataTable.Rows[0]["Destino"]);
		Type typeFromHandle = typeof(Math);
		DataRow dataRow;
		object[] obj = new object[2]
		{
			(dataRow = dataTable.Rows[0])["Volumen"],
			3
		};
		object[] array = obj;
		bool[] obj2 = new bool[2] { true, false };
		bool[] array2 = obj2;
		object value = NewLateBinding.LateGet(null, typeFromHandle, "Round", obj, null, null, obj2);
		if (array2[0])
		{
			dataRow["Volumen"] = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
		datos_ruta.Volumen = Conversions.ToDouble(value);
		object value2 = NewLateBinding.LateGet(null, typeof(Math), "Round", array = new object[2]
		{
			(dataRow = dataTable.Rows[0])["Flete"],
			2
		}, null, null, array2 = new bool[2] { true, false });
		if (array2[0])
		{
			dataRow["Flete"] = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
		datos_ruta.Flete = Conversions.ToDouble(value2);
		object value3 = NewLateBinding.LateGet(null, typeof(Math), "Round", array = new object[2]
		{
			(dataRow = dataTable.Rows[0])["Kilos"],
			2
		}, null, null, array2 = new bool[2] { true, false });
		if (array2[0])
		{
			dataRow["Kilos"] = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
		datos_ruta.Kilos = Conversions.ToDouble(value3);
		object value4 = NewLateBinding.LateGet(null, typeof(Math), "Round", array = new object[2]
		{
			(dataRow = dataTable.Rows[0])["Declarado"],
			2
		}, null, null, array2 = new bool[2] { true, false });
		if (array2[0])
		{
			dataRow["Declarado"] = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
		datos_ruta.Declarado = Conversions.ToDouble(value4);
		datos_ruta.Bultos = Conversions.ToInteger(dataTable.Rows[0]["Bultos"]);
		return datos_ruta;
	}

	public static object d_vehiculo(string Chofer)
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		int num = Conversions.ToInteger(MyProject.Forms.Form1_Inicio.ComboBox1.Text);
		string text = Strings.Format(MyProject.Forms.Form1_Inicio.DateTimePicker1.Value, "yyyymmdd");
		string text2 = ("select chofer,categoria,peso,volumen,tarifa, (select otro from categorias where categoria=flota.categoria) as otro from flota where numero=" + Chofer) ?? "";
		DataTable dataTable = new DataTable("x");
		MySqlDataAdapter val = new MySqlDataAdapter(text2, Mod_Sentencias.cnn);
		((DbDataAdapter)(object)val).Fill(dataTable);
		Mod_Json.datos_vehiculo datos_vehiculo = default(Mod_Json.datos_vehiculo);
		datos_vehiculo.V_Chofer = Conversions.ToString(dataTable.Rows[0]["chofer"]);
		datos_vehiculo.V_Categoria = Conversions.ToInteger(dataTable.Rows[0]["categoria"]);
		object[] array;
		DataRow dataRow;
		bool[] array2;
		object obj = NewLateBinding.LateGet(null, typeof(Math), "Round", array = new object[2]
		{
			(dataRow = dataTable.Rows[0])["peso"],
			2
		}, null, null, array2 = new bool[2] { true, false });
		if (array2[0])
		{
			dataRow["peso"] = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
		datos_vehiculo.V_Peso = Conversions.ToString(obj);
		object obj2 = NewLateBinding.LateGet(null, typeof(Math), "Round", array = new object[2]
		{
			(dataRow = dataTable.Rows[0])["volumen"],
			3
		}, null, null, array2 = new bool[2] { true, false });
		if (array2[0])
		{
			dataRow["volumen"] = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
		datos_vehiculo.V_Volumen = Conversions.ToString(obj2);
		object obj3 = NewLateBinding.LateGet(null, typeof(Math), "Round", array = new object[2]
		{
			(dataRow = dataTable.Rows[0])["tarifa"],
			2
		}, null, null, array2 = new bool[2] { true, false });
		if (array2[0])
		{
			dataRow["tarifa"] = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
		datos_vehiculo.V_Tarifa = Conversions.ToString(obj3);
		object obj4 = NewLateBinding.LateGet(null, typeof(Math), "Round", array = new object[2]
		{
			(dataRow = dataTable.Rows[0])["otro"],
			2
		}, null, null, array2 = new bool[2] { true, false });
		if (array2[0])
		{
			dataRow["otro"] = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
		datos_vehiculo.V_Otro = Conversions.ToString(obj4);
		return datos_vehiculo;
	}
}
