using System;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using Hermes.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace Hermes;

[StandardModule]
internal sealed class Mod_Canalizador
{
	private static string fecha1 = Strings.Format(MyProject.Forms.Form1_Inicio.DateTimePicker1.Value, "yyyyMMdd");

	public static void buscar_eventual_bd()
	{
		//IL_050c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0513: Expected O, but got Unknown
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Expected O, but got Unknown
		//IL_035f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0366: Expected O, but got Unknown
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected O, but got Unknown
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Expected O, but got Unknown
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		int num5 = 0;
		checked
		{
			try
			{
				Mod_Sentencias.cnn.Open();
				DataTable dataTable = new DataTable("x");
				string text = "SELECT * FROM Planchada WHERE Ventana=0 AND Fecha='" + fecha1 + "'";
				MySqlDataAdapter val = new MySqlDataAdapter(text, Mod_Sentencias.cnn);
				((DbDataAdapter)(object)val).Fill(dataTable);
				int count = dataTable.Rows.Count;
				DataTable dataTable2 = new DataTable("xx");
				int num6 = dataTable.Rows.Count - 1;
				for (int i = 0; i <= num6; i++)
				{
					try
					{
						string text2 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("SELECT * FROM Eventuales where Eventual= ", dataTable.Rows[i]["Eventual"]), ""));
						MySqlDataAdapter val2 = new MySqlDataAdapter(text2, Mod_Sentencias.cnn);
						((DbDataAdapter)(object)val2).Fill(dataTable2);
						int count2 = dataTable2.Rows.Count;
						string left = Conversions.ToString(dataTable.Rows[i]["Destino"]);
						string left2 = Conversions.ToString(dataTable.Rows[i]["Domicilio"]);
						string right = Conversions.ToString(dataTable2.Rows[0]["Cliente"]);
						string right2 = Conversions.ToString(dataTable2.Rows[0]["Domicilio"]);
						if (Operators.CompareString(left, right, TextCompare: true) == 0)
						{
							if (Operators.CompareString(left2, right2, TextCompare: true) == 0)
							{
								string text3 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("UPDATE Planchada SET Zona=", dataTable2.Rows[0]["Zona"]), ", Chofer=0 WHERE Comprobante= '"), dataTable.Rows[i]["Comprobante"]), "'"));
								MySqlCommand val3 = new MySqlCommand(text3, Mod_Sentencias.cnn);
								val3.ExecuteNonQuery();
								num++;
							}
							else
							{
								num3++;
							}
						}
						else
						{
							num2++;
						}
						dataTable2.Clear();
						left = null;
						left2 = null;
						right = null;
						right2 = null;
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						try
						{
							string text4 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("SELECT * FROM Eventuales WHERE Cliente='", dataTable.Rows[i]["Destino"]), "'"));
							MySqlDataAdapter val4 = new MySqlDataAdapter(text4, Mod_Sentencias.cnn);
							((DbDataAdapter)(object)val4).Fill(dataTable2);
							string text5 = Conversions.ToString(dataTable.Rows[i]["Destino"]);
							string left3 = Conversions.ToString(dataTable.Rows[i]["Domicilio"]);
							string text6 = Conversions.ToString(dataTable2.Rows[0]["Cliente"]);
							string right3 = Conversions.ToString(dataTable2.Rows[0]["Domicilio"]);
							if (Operators.CompareString(left3, right3, TextCompare: true) == 0)
							{
								string text7 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("UPDATE Planchada SET Eventual=", dataTable2.Rows[0]["Eventual"]), " WHERE Comprobante= '"), dataTable.Rows[i]["Comprobante"]), "'"));
								MySqlCommand val3 = new MySqlCommand(text7, Mod_Sentencias.cnn);
								val3.ExecuteNonQuery();
								num5++;
							}
							else
							{
								num3++;
							}
							dataTable2.Clear();
							text5 = null;
							left3 = null;
							text6 = null;
							right3 = null;
						}
						catch (Exception projectError2)
						{
							ProjectData.SetProjectError(projectError2);
							string text8 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("INSERT INTO Eventuales(Cliente, Eventual, Zona, Domicilio, Localidad, CP, Adicional, Prioridad, Sub, Normalizada, Latitud, Longitud, Franja, Fecha, Usuario)values('", dataTable.Rows[i]["Destino"]), "',"), dataTable.Rows[i]["Eventual"].ToString()), ",0,'"), dataTable.Rows[i]["Domicilio"].ToString()), "','"), dataTable.Rows[i]["Localidad"].ToString()), "','"), dataTable.Rows[i]["CP"].ToString()), "',0,0,'"), dataTable.Rows[i]["Sub"].ToString()), "',0,-34.603561,-58.277087,"), MyProject.Forms.Form1_Inicio.ComboBox1.Text), ",'"), fecha1), "','"), MyProject.Forms.Form1_Inicio.nombreusuario.Text), "')"));
							MySqlCommand val3 = new MySqlCommand(text8, Mod_Sentencias.cnn);
							num4++;
							ProjectData.ClearProjectError();
						}
						ProjectData.ClearProjectError();
					}
				}
				Interaction.MsgBox("Eventuales OK: " + Conversions.ToString(num));
				Interaction.MsgBox("Eventual 0 OK: " + Conversions.ToString(num5));
				Interaction.MsgBox("Eventuales Nuevos: " + Conversions.ToString(num4));
				Interaction.MsgBox("Cambio de Nombre: " + Conversions.ToString(num2));
				Interaction.MsgBox("Cambio de direccion: " + Conversions.ToString(num3));
				Mod_Sentencias.cnn.Close();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Interaction.MsgBox(ex2.Message);
				Mod_Sentencias.cnn.Close();
				Logger.e("Error con excepción", ex2);
				Logger.d("Debug con traza", new StackFrame(fNeedFileInfo: true));
				Logger.i("Info sin traza", new StackFrame(fNeedFileInfo: true));
				Logger.e("Error con excepción y traza", ex2, new StackFrame(fNeedFileInfo: true));
				ProjectData.ClearProjectError();
			}
		}
	}
}
