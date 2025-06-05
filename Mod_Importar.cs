using System;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Windows.Forms;
using Hermes.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace Hermes;

[StandardModule]
internal sealed class Mod_Importar
{
	public static void importar_datos_mysql()
	{
		checked
		{
			try
			{
				MyProject.Forms.Form1_Inicio.DateTimePicker1.Format = DateTimePickerFormat.Short;
				DateTime dateTime = Conversions.ToDate(MyProject.Forms.Form1_Inicio.DateTimePicker1.Text);
				OleDbConnection oleDbConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source='Temp.xls'; Extended Properties=Excel 8.0;");
				OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("select * from [Planchada$]", oleDbConnection);
				oleDbDataAdapter.TableMappings.Add("Table", "Test");
				DataSet dataSet = new DataSet();
				oleDbDataAdapter.Fill(dataSet);
				oleDbConnection.Close();
				MyProject.Forms.Loading.Show();
				MyProject.Forms.Loading.Refresh();
				MyProject.Forms.Loading.ProgressBar1.Maximum = dataSet.Tables[0].Rows.Count;
				Interaction.MsgBox("este es");
				try
				{
					int num = dataSet.Tables[0].Rows.Count - 1;
					for (int i = 0; i <= num; i++)
					{
						string sQL = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("INSERT INTO Planchada(Eventual, Comprobante, Cliente, Remitos, Destino, Domicilio, CP, Localidad, Declarado, Bultos, Kilos, Sub, Observaciones, Volumen, Atraso, Diferida, Flete, Zona, Adicional, Prioridad, Chofer, Latitud, Longitud, Estado, Fecha, Ventana, Usuario) VALUES (", dataSet.Tables[0].Rows[i][MySettingsProperty.Settings.Eventual]), ", "), dataSet.Tables[0].Rows[i][MySettingsProperty.Settings.Comprobante]), ",'"), dataSet.Tables[0].Rows[i][MySettingsProperty.Settings.Cliente]), "','"), dataSet.Tables[0].Rows[i][MySettingsProperty.Settings.Remitos]), "','"), Strings.Replace(Conversions.ToString(dataSet.Tables[0].Rows[i][MySettingsProperty.Settings.Destino]), "'", " ", 1, -1, CompareMethod.Text)), "','"), Strings.Replace(Conversions.ToString(dataSet.Tables[0].Rows[i][MySettingsProperty.Settings.Domicilio]), "'", " ", 1, -1, CompareMethod.Text)), "','"), dataSet.Tables[0].Rows[i][MySettingsProperty.Settings.CP]), "','"), dataSet.Tables[0].Rows[i][MySettingsProperty.Settings.Localidad]), "',"), Strings.Replace(Conversions.ToString(dataSet.Tables[0].Rows[i][MySettingsProperty.Settings.Declarado]), ",", ".", 1, -1, CompareMethod.Text)), ","), dataSet.Tables[0].Rows[i][MySettingsProperty.Settings.Bultos]), ","), Strings.Replace(Conversions.ToString(dataSet.Tables[0].Rows[i][MySettingsProperty.Settings.Kilos]), ",", ".", 1, -1, CompareMethod.Text)), ",'"), dataSet.Tables[0].Rows[i][MySettingsProperty.Settings.Subc]), "','"), dataSet.Tables[0].Rows[i][MySettingsProperty.Settings.Observaciones]), "',"), Strings.Replace(Conversions.ToString(dataSet.Tables[0].Rows[i][MySettingsProperty.Settings.Volumen]), ",", ".", 1, -1, CompareMethod.Text)), ","), dataSet.Tables[0].Rows[i][MySettingsProperty.Settings.Atraso]), ",'"), dataSet.Tables[0].Rows[i][MySettingsProperty.Settings.Diferida]), "',"), Strings.Replace(Conversions.ToString(dataSet.Tables[0].Rows[i][MySettingsProperty.Settings.Flete]), ",", ".", 1, -1, CompareMethod.Text)), ",0,0,0,0,0,0,'En Planchada','"), Strings.Format(MyProject.Forms.Form1_Inicio.DateTimePicker1.Value, "yyyy/MM/dd")), "', 0,'"), MyProject.Forms.Form1_Inicio.nombreusuario.Text), "')"));
						Mod_ConeccionBD.BD_Sentencia(sQL);
						MyProject.Forms.Loading.ProgressBar1.Value = MyProject.Forms.Loading.ProgressBar1.Value + 1;
					}
					Mod_Sentencias.cnn.Close();
					MyProject.Forms.Loading.Close();
					DialogResult dialogResult = MessageBox.Show("Desea iniciar el ruteo?", "Importado Correctamente", MessageBoxButtons.YesNo);
					if (dialogResult == DialogResult.Yes)
					{
						MyProject.Forms.Procesos.Show();
						Mod_Rutearmodulo.busca_eve();
						Mod_Rutearmodulo.eventuales_gba();
						Mod_Rutearmodulo.eventuales_caba();
						Mod_Rutearmodulo.etrans_pos();
						Mod_Rutearmodulo.localidades_s();
						MyProject.Forms.Infimportacion.Show();
					}
					if (dialogResult != DialogResult.No)
					{
					}
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
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				Interaction.MsgBox(ex4.Message);
				ProjectData.ClearProjectError();
			}
		}
	}

	public static void importar_mysql_sin_duplicados()
	{
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected O, but got Unknown
		checked
		{
			try
			{
				MyProject.Forms.Form1_Inicio.DateTimePicker1.Format = DateTimePickerFormat.Short;
				DateTime dateTime = Conversions.ToDate(MyProject.Forms.Form1_Inicio.DateTimePicker1.Text);
				OleDbConnection oleDbConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source='Temp.xls'; Extended Properties=Excel 8.0;");
				OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("select * from [Planchada$]", oleDbConnection);
				oleDbDataAdapter.TableMappings.Add("Table", "Test");
				DataSet dataSet = new DataSet();
				oleDbDataAdapter.Fill(dataSet);
				oleDbConnection.Close();
				MyProject.Forms.Loading.Show();
				MyProject.Forms.Loading.Refresh();
				MyProject.Forms.Loading.ProgressBar1.Maximum = dataSet.Tables[0].Rows.Count;
				try
				{
					int num = dataSet.Tables[0].Rows.Count - 1;
					for (int i = 0; i <= num; i++)
					{
						string text = dataSet.Tables[0].Rows[i][MySettingsProperty.Settings.Comprobante].ToString();
						if (text.Length > 8)
						{
							text = text.Substring(5, 8);
						}
						string text2 = "SELECT * FROM PLANCHADA WHERE COMPROBANTE=" + text + " AND FECHA='" + Strings.Format(MyProject.Forms.Form1_Inicio.DateTimePicker1.Value, "yyyy/MM/dd") + "'";
						DataTable dataTable = new DataTable("x");
						MySqlDataAdapter val = new MySqlDataAdapter(text2, Mod_Sentencias.cnn);
						((DbDataAdapter)(object)val).Fill(dataTable);
						if (dataTable.Rows.Count != 1)
						{
							if (Operators.ConditionalCompareObjectEqual(dataSet.Tables[0].Rows[i][MySettingsProperty.Settings.Cliente], "MURESCO SA", TextCompare: true))
							{
								if (Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Operators.CompareObjectEqual(dataSet.Tables[0].Rows[i][MySettingsProperty.Settings.Subc], 11, TextCompare: true), Operators.CompareObjectEqual(dataSet.Tables[0].Rows[i][MySettingsProperty.Settings.Subc], 21, TextCompare: true)), Operators.CompareObjectEqual(dataSet.Tables[0].Rows[i][MySettingsProperty.Settings.Subc], 31, TextCompare: true))))
								{
									string sQL = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("INSERT INTO Planchada(Eventual, Comprobante, Cliente, Remitos, Destino, Domicilio, CP, Localidad, Declarado, Bultos, Kilos, Sub, Observaciones, Volumen, Atraso, Diferida, Flete, Zona, Adicional, Prioridad, Chofer, Latitud, Longitud, Estado, Fecha, Ventana, Usuario) VALUES (", dataSet.Tables[0].Rows[i][MySettingsProperty.Settings.Eventual]), ", "), dataSet.Tables[0].Rows[i][MySettingsProperty.Settings.Comprobante]), ",'REVESTIMIENTO','"), dataSet.Tables[0].Rows[i][MySettingsProperty.Settings.Remitos]), "','"), Strings.Replace(Conversions.ToString(dataSet.Tables[0].Rows[i][MySettingsProperty.Settings.Destino]), "'", " ", 1, -1, CompareMethod.Text)), "','"), Strings.Replace(Conversions.ToString(dataSet.Tables[0].Rows[i][MySettingsProperty.Settings.Domicilio]), "'", " ", 1, -1, CompareMethod.Text)), "','"), dataSet.Tables[0].Rows[i][MySettingsProperty.Settings.CP]), "','"), dataSet.Tables[0].Rows[i][MySettingsProperty.Settings.Localidad]), "',"), Strings.Replace(Conversions.ToString(dataSet.Tables[0].Rows[i][MySettingsProperty.Settings.Declarado]), ",", ".", 1, -1, CompareMethod.Text)), ","), dataSet.Tables[0].Rows[i][MySettingsProperty.Settings.Bultos]), ","), Strings.Replace(Conversions.ToString(dataSet.Tables[0].Rows[i][MySettingsProperty.Settings.Kilos]), ",", ".", 1, -1, CompareMethod.Text)), ",'"), dataSet.Tables[0].Rows[i][MySettingsProperty.Settings.Subc]), "','"), dataSet.Tables[0].Rows[i][MySettingsProperty.Settings.Observaciones]), "',"), Strings.Replace(Conversions.ToString(dataSet.Tables[0].Rows[i][MySettingsProperty.Settings.Volumen]), ",", ".", 1, -1, CompareMethod.Text)), ","), dataSet.Tables[0].Rows[i][MySettingsProperty.Settings.Atraso]), ",'"), dataSet.Tables[0].Rows[i][MySettingsProperty.Settings.Diferida]), "',"), Strings.Replace(Conversions.ToString(dataSet.Tables[0].Rows[i][MySettingsProperty.Settings.Flete]), ",", ".", 1, -1, CompareMethod.Text)), ",0,0,0,0,0,0,'En Planchada','"), Strings.Format(MyProject.Forms.Form1_Inicio.DateTimePicker1.Value, "yyyy/MM/dd")), "', 0,'"), MyProject.Forms.Form1_Inicio.nombreusuario.Text), "')"));
									Mod_ConeccionBD.BD_Sentencia(sQL);
								}
								else
								{
									string sQL2 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("INSERT INTO Planchada(Eventual, Comprobante, Cliente, Remitos, Destino, Domicilio, CP, Localidad, Declarado, Bultos, Kilos, Sub, Observaciones, Volumen, Atraso, Diferida, Flete, Zona, Adicional, Prioridad, Chofer, Latitud, Longitud, Estado, Fecha, Ventana, Usuario) VALUES (", dataSet.Tables[0].Rows[i][MySettingsProperty.Settings.Eventual]), ", "), dataSet.Tables[0].Rows[i][MySettingsProperty.Settings.Comprobante]), ",'"), dataSet.Tables[0].Rows[i][MySettingsProperty.Settings.Cliente]), "','"), dataSet.Tables[0].Rows[i][MySettingsProperty.Settings.Remitos]), "','"), Strings.Replace(Conversions.ToString(dataSet.Tables[0].Rows[i][MySettingsProperty.Settings.Destino]), "'", " ", 1, -1, CompareMethod.Text)), "','"), Strings.Replace(Conversions.ToString(dataSet.Tables[0].Rows[i][MySettingsProperty.Settings.Domicilio]), "'", " ", 1, -1, CompareMethod.Text)), "','"), dataSet.Tables[0].Rows[i][MySettingsProperty.Settings.CP]), "','"), dataSet.Tables[0].Rows[i][MySettingsProperty.Settings.Localidad]), "',"), Strings.Replace(Conversions.ToString(dataSet.Tables[0].Rows[i][MySettingsProperty.Settings.Declarado]), ",", ".", 1, -1, CompareMethod.Text)), ","), dataSet.Tables[0].Rows[i][MySettingsProperty.Settings.Bultos]), ","), Strings.Replace(Conversions.ToString(dataSet.Tables[0].Rows[i][MySettingsProperty.Settings.Kilos]), ",", ".", 1, -1, CompareMethod.Text)), ",'"), dataSet.Tables[0].Rows[i][MySettingsProperty.Settings.Subc]), "','"), dataSet.Tables[0].Rows[i][MySettingsProperty.Settings.Observaciones]), "',"), Strings.Replace(Conversions.ToString(dataSet.Tables[0].Rows[i][MySettingsProperty.Settings.Volumen]), ",", ".", 1, -1, CompareMethod.Text)), ","), dataSet.Tables[0].Rows[i][MySettingsProperty.Settings.Atraso]), ",'"), dataSet.Tables[0].Rows[i][MySettingsProperty.Settings.Diferida]), "',"), Strings.Replace(Conversions.ToString(dataSet.Tables[0].Rows[i][MySettingsProperty.Settings.Flete]), ",", ".", 1, -1, CompareMethod.Text)), ",0,0,0,0,0,0,'En Planchada','"), Strings.Format(MyProject.Forms.Form1_Inicio.DateTimePicker1.Value, "yyyy/MM/dd")), "', 0,'"), MyProject.Forms.Form1_Inicio.nombreusuario.Text), "')"));
									Mod_ConeccionBD.BD_Sentencia(sQL2);
								}
							}
							else
							{
								if (text.Length > 8)
								{
									text = text.Substring(5, 8);
								}
								Console.WriteLine(text);
								string text3 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("INSERT INTO Planchada(Eventual, Comprobante, Cliente, Remitos, Destino, Domicilio, CP, Localidad, Declarado, Bultos, Kilos, Sub, Observaciones, Volumen, Atraso, Diferida, Flete, Zona, Adicional, Prioridad, Chofer, Latitud, Longitud, Estado, Fecha, Ventana, Usuario) VALUES (", dataSet.Tables[0].Rows[i][MySettingsProperty.Settings.Eventual]), ", "), text), ",'"), dataSet.Tables[0].Rows[i][MySettingsProperty.Settings.Cliente]), "','"), dataSet.Tables[0].Rows[i][MySettingsProperty.Settings.Remitos]), "','"), Strings.Replace(Conversions.ToString(dataSet.Tables[0].Rows[i][MySettingsProperty.Settings.Destino]), "'", " ", 1, -1, CompareMethod.Text)), "','"), Strings.Replace(Conversions.ToString(dataSet.Tables[0].Rows[i][MySettingsProperty.Settings.Domicilio]), "'", " ", 1, -1, CompareMethod.Text)), "','"), dataSet.Tables[0].Rows[i][MySettingsProperty.Settings.CP]), "','"), dataSet.Tables[0].Rows[i][MySettingsProperty.Settings.Localidad]), "',"), Strings.Replace(Conversions.ToString(dataSet.Tables[0].Rows[i][MySettingsProperty.Settings.Declarado]), ",", ".", 1, -1, CompareMethod.Text)), ","), dataSet.Tables[0].Rows[i][MySettingsProperty.Settings.Bultos]), ","), Strings.Replace(Conversions.ToString(dataSet.Tables[0].Rows[i][MySettingsProperty.Settings.Kilos]), ",", ".", 1, -1, CompareMethod.Text)), ",'"), dataSet.Tables[0].Rows[i][MySettingsProperty.Settings.Subc]), "','"), dataSet.Tables[0].Rows[i][MySettingsProperty.Settings.Observaciones]), "',"), Strings.Replace(Conversions.ToString(dataSet.Tables[0].Rows[i][MySettingsProperty.Settings.Volumen]), ",", ".", 1, -1, CompareMethod.Text)), ","), dataSet.Tables[0].Rows[i][MySettingsProperty.Settings.Atraso]), ",'"), dataSet.Tables[0].Rows[i][MySettingsProperty.Settings.Diferida]), "',"), Strings.Replace(Conversions.ToString(dataSet.Tables[0].Rows[i][MySettingsProperty.Settings.Flete]), ",", ".", 1, -1, CompareMethod.Text)), ",0,0,0,0,0,0,'En Planchada','"), Strings.Format(MyProject.Forms.Form1_Inicio.DateTimePicker1.Value, "yyyy/MM/dd")), "', 0,'"), MyProject.Forms.Form1_Inicio.nombreusuario.Text), "')"));
								Logger.i(text3);
								Mod_ConeccionBD.BD_Sentencia(text3);
							}
						}
						MyProject.Forms.Loading.ProgressBar1.Value = MyProject.Forms.Loading.ProgressBar1.Value + 1;
					}
					Mod_Sentencias.cnn.Close();
					MyProject.Forms.Loading.Close();
					DialogResult dialogResult = MessageBox.Show("Desea iniciar el ruteo?", "Importado Correctamente", MessageBoxButtons.YesNo);
					if (dialogResult == DialogResult.Yes)
					{
						MyProject.Forms.Procesos.Show();
						Mod_Rutearmodulo.busca_eve();
						Mod_Rutearmodulo.eventuales_gba();
						Mod_Rutearmodulo.eventuales_caba();
						Mod_Rutearmodulo.etrans_pos();
						Mod_Rutearmodulo.localidades_s();
						MyProject.Forms.Infimportacion.Show();
					}
					if (dialogResult != DialogResult.No)
					{
					}
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
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				Interaction.MsgBox(ex4.Message);
				ProjectData.ClearProjectError();
			}
		}
	}
}
