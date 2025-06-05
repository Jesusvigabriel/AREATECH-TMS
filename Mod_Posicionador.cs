using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.IO;
using System.Net;
using System.Xml;
using Google.Api.Maps.Service.Geocoding;
using Hermes.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace Hermes;

[StandardModule]
internal sealed class Mod_Posicionador
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

	public static void posicionar_facu()
	{
		//IL_02e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Expected O, but got Unknown
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected O, but got Unknown
		//IL_04bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c3: Expected O, but got Unknown
		//IL_0287: Unknown result type (might be due to invalid IL or missing references)
		//IL_028d: Expected O, but got Unknown
		//IL_0529: Unknown result type (might be due to invalid IL or missing references)
		//IL_0530: Expected O, but got Unknown
		//IL_071a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0720: Expected O, but got Unknown
		//IL_0802: Unknown result type (might be due to invalid IL or missing references)
		//IL_0809: Expected O, but got Unknown
		//IL_0833: Unknown result type (might be due to invalid IL or missing references)
		//IL_0839: Invalid comparison between Unknown and I4
		//IL_08a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ab: Expected O, but got Unknown
		//IL_0913: Unknown result type (might be due to invalid IL or missing references)
		//IL_0919: Expected O, but got Unknown
		checked
		{
			try
			{
				Mod_Sentencias.cnn.Open();
				string text = Strings.Format(MyProject.Forms.Form1_Inicio.DateTimePicker1.Value, "yyyyMMdd");
				MyProject.Forms.Loading.Show();
				MyProject.Forms.Loading.Refresh();
				MySqlCommand val = null;
				DataTable dataTable = new DataTable("x");
				string text2 = ("SELECT Destino,Domicilio,Localidad,Eventual,Zona,Comprobante FROM Planchada Where zona=0 AND Fecha=" + text) ?? "";
				MySqlDataAdapter val2 = new MySqlDataAdapter(text2, Mod_Sentencias.cnn);
				((DbDataAdapter)(object)val2).Fill(dataTable);
				MyProject.Forms.Loading.ProgressBar1.Maximum = dataTable.Rows.Count + 1;
				int num = dataTable.Rows.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					MyProject.Forms.Loading.ProgressBar1.Value = MyProject.Forms.Loading.ProgressBar1.Value + 1;
					if (Operators.ConditionalCompareObjectGreater(dataTable.Rows[i]["Eventual"], 0, TextCompare: true))
					{
						try
						{
							string empty = string.Empty;
							empty = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("INSERT INTO Eventuales(Cliente, Eventual, Zona, Domicilio, Localidad, CP, Adicional, Prioridad, Sub, Normalizada, Latitud, Longitud, Franja, Fecha, Usuario)values('", dataTable.Rows[i]["Destino"]), "',"), dataTable.Rows[i]["Eventual"].ToString()), ",0,'"), dataTable.Rows[i]["Domicilio"].ToString()), "','"), dataTable.Rows[i]["Localidad"].ToString()), "','"), dataTable.Rows[i]["CP"].ToString()), "',0,0,'"), dataTable.Rows[i]["Sub"].ToString()), "',0,-34.603561,-58.277087,"), MyProject.Forms.Form1_Inicio.ComboBox1.Text), ",'"), text), "','"), MyProject.Forms.Form1_Inicio.nombreusuario.Text), "')"));
							val = new MySqlCommand(empty, Mod_Sentencias.cnn);
							val.ExecuteNonQuery();
						}
						catch (Exception projectError)
						{
							ProjectData.SetProjectError(projectError);
							DataTable dataTable2 = new DataTable("A");
							string text3 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("Select * FROM Eventuales WHERE Eventual= ", dataTable.Rows[i]["Eventual"]), ""));
							MySqlDataAdapter val3 = new MySqlDataAdapter(text3, Mod_Sentencias.cnn);
							((DbDataAdapter)(object)val3).Fill(dataTable2);
							string left = Conversions.ToString(dataTable.Rows[i]["Destino"]);
							string left2 = Conversions.ToString(dataTable.Rows[i]["Domicilio"]);
							string right = Conversions.ToString(dataTable2.Rows[0]["Cliente"]);
							string right2 = Conversions.ToString(dataTable2.Rows[0]["Domicilio"]);
							if (Operators.CompareString(left, right, TextCompare: true) == 0 && Operators.CompareString(left2, right2, TextCompare: true) == 0)
							{
								string empty2 = string.Empty;
								empty2 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("UPDATE Planchada SET Zona=", dataTable2.Rows[0]["Zona"]), ",Eventual="), dataTable2.Rows[0]["Eventual"]), ", Adicional="), dataTable2.Rows[0]["Adicional"]), ",Prioridad="), dataTable2.Rows[0]["Prioridad"]), ",Latitud= '"), dataTable2.Rows[0]["Latitud"]), "',Longitud= '"), dataTable2.Rows[0]["Longitud"]), "', Chofer=0 WHERE Comprobante= '"), dataTable.Rows[i]["Comprobante"]), "'"));
								val = new MySqlCommand(empty2, Mod_Sentencias.cnn);
								val.ExecuteNonQuery();
							}
							ProjectData.ClearProjectError();
						}
						continue;
					}
					try
					{
						DataTable dataTable3 = new DataTable("C");
						string text4 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("SELECT * FROM eventuales WHERE Cliente='", dataTable.Rows[i]["Destino"]), "'"));
						MySqlDataAdapter val4 = new MySqlDataAdapter(text4, Mod_Sentencias.cnn);
						((DbDataAdapter)(object)val4).Fill(dataTable3);
						if (dataTable3.Rows.Count > 0)
						{
							string left3 = Conversions.ToString(dataTable.Rows[i]["Destino"]);
							string left4 = Conversions.ToString(dataTable.Rows[i]["Domicilio"]);
							string right3 = Conversions.ToString(dataTable3.Rows[0]["Cliente"]);
							string right4 = Conversions.ToString(dataTable3.Rows[0]["Domicilio"]);
							if (Operators.CompareString(left3, right3, TextCompare: true) == 0 && Operators.CompareString(left4, right4, TextCompare: true) == 0)
							{
								string empty3 = string.Empty;
								empty3 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("UPDATE Planchada SET Zona=", dataTable3.Rows[0]["Zona"]), ",Eventual="), dataTable3.Rows[0]["Eventual"]), ", Adicional="), dataTable3.Rows[0]["Adicional"]), ",Prioridad="), dataTable3.Rows[0]["Prioridad"]), ",Latitud= '"), dataTable3.Rows[0]["Latitud"]), "',Longitud= '"), dataTable3.Rows[0]["Longitud"]), "', Chofer=0 WHERE Comprobante= '"), dataTable.Rows[i]["Comprobante"]), "'"));
								val = new MySqlCommand(empty3, Mod_Sentencias.cnn);
								val.ExecuteNonQuery();
							}
							continue;
						}
						try
						{
							string empty4 = string.Empty;
							string empty5 = string.Empty;
							empty5 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Right: (!Operators.ConditionalCompareObjectEqual(dataTable.Rows[i]["Localidad"], "CIUDAD AUTONOMA DE BS.AS", TextCompare: true)) ? Conversions.ToString(dataTable.Rows[i]["Localidad"]) : ",buenos aires", Left: Operators.ConcatenateObject(Operators.ConcatenateObject("", dataTable.Rows[i]["Domicilio"]), ",")), ""));
							empty5 = empty5.Replace(" ", "+");
							empty5 = empty5.Replace("  ", "+");
							GeocodingRequest val5 = new GeocodingRequest();
							val5.Address = empty5;
							val5.Sensor = "false";
							GeocodingResponse response = GeocodingService.GetResponse(val5);
							Console.WriteLine(response);
							if (unchecked((int)response.Status) == 1)
							{
								string text5 = response.Results[0].FormattedAddress.ToString();
								double num2 = Convert.ToDouble(response.Results[0].Geometry.Location.Latitude);
								double num3 = Convert.ToDouble(response.Results[0].Geometry.Location.Longitude);
								try
								{
									string empty6 = string.Empty;
									MySqlConnection val6 = new MySqlConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=dbarea.mdb");
									empty6 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("UPDATE Planchada SET Latitud='" + Conversions.ToString(num2) + "',Longitud='" + Conversions.ToString(num3) + "' WHERE Comprobante= '", dataTable.Rows[i]["Comprobante"]), "'"));
									val = new MySqlCommand(empty6, val6);
									val.ExecuteNonQuery();
									text5 = string.Empty;
									num2 = 0.0;
									num3 = 0.0;
									val6 = null;
									empty6 = null;
								}
								catch (Exception ex)
								{
									ProjectData.SetProjectError(ex);
									Exception ex2 = ex;
									Interaction.MsgBox(ex2.Message, MsgBoxStyle.Critical, "Error");
									ProjectData.ClearProjectError();
								}
							}
							else
							{
								Interaction.MsgBox(response.Results);
							}
						}
						catch (Exception ex3)
						{
							ProjectData.SetProjectError(ex3);
							Exception ex4 = ex3;
							Interaction.MsgBox(ex4.Message, MsgBoxStyle.Critical, "Error");
							ProjectData.ClearProjectError();
						}
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
					}
				}
			}
			catch (Exception ex5)
			{
				ProjectData.SetProjectError(ex5);
				Exception ex6 = ex5;
				Interaction.MsgBox(ex6.Message + "3");
				ProjectData.ClearProjectError();
			}
		}
	}

	public static void ruting_all()
	{
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected O, but got Unknown
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Invalid comparison between Unknown and I4
		//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02da: Expected O, but got Unknown
		string text = Strings.Format(MyProject.Forms.Form1_Inicio.DateTimePicker1.Value, "yyyyMMdd");
		try
		{
			Mod_Sentencias.cnn.Open();
			MySqlCommand val = null;
			DataTable dataTable = new DataTable("x");
			string text2 = "SELECT * FROM Planchada WHERE Ventana=" + MyProject.Forms.Form1_Inicio.ComboBox1.Text + " AND Fecha='" + text + "'";
			MySqlDataAdapter val2 = new MySqlDataAdapter(text2, Mod_Sentencias.cnn);
			((DbDataAdapter)(object)val2).Fill(dataTable);
			int num = checked(dataTable.Rows.Count - 1);
			for (int i = 0; i <= num; i = checked(i + 1))
			{
				try
				{
					string empty = string.Empty;
					string empty2 = string.Empty;
					empty2 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Right: (!Operators.ConditionalCompareObjectEqual(dataTable.Rows[i]["Localidad"], "CIUDAD AUTONOMA DE BS.AS", TextCompare: true)) ? Conversions.ToString(dataTable.Rows[i]["Localidad"]) : ",buenos aires", Left: Operators.ConcatenateObject(Operators.ConcatenateObject("", dataTable.Rows[i]["Domicilio"]), ",")), ""));
					empty2 = empty2.Replace(" ", "+");
					empty2 = empty2.Replace("  ", "+");
					GeocodingRequest val3 = new GeocodingRequest
					{
						Address = empty2,
						Sensor = "false"
					};
					GeocodingResponse response = GeocodingService.GetResponse(val3);
					if ((int)response.Status == 1)
					{
						string text3 = response.Results[0].FormattedAddress.ToString();
						double num2 = Convert.ToDouble(response.Results[0].Geometry.Location.Latitude);
						double num3 = Convert.ToDouble(response.Results[0].Geometry.Location.Longitude);
						try
						{
							string empty3 = string.Empty;
							empty3 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("UPDATE Planchada SET Latitud=" + Strings.Replace(Conversions.ToString(num2), ",", ".", 1, -1, CompareMethod.Text) + ",Longitud=" + Strings.Replace(Conversions.ToString(num3), ",", ".", 1, -1, CompareMethod.Text) + " WHERE Comprobante=", dataTable.Rows[i]["Comprobante"]), " AND Ventana="), MyProject.Forms.Form1_Inicio.ComboBox1.Text), " AND Fecha='"), text), "'"));
							Interaction.MsgBox(empty3);
							val = new MySqlCommand(empty3, Mod_Sentencias.cnn);
							val.ExecuteNonQuery();
							text3 = string.Empty;
							num2 = 0.0;
							num3 = 0.0;
							empty3 = null;
						}
						catch (Exception ex)
						{
							ProjectData.SetProjectError(ex);
							Exception ex2 = ex;
							Interaction.MsgBox(ex2.Message, MsgBoxStyle.Critical, "Error1");
							ProjectData.ClearProjectError();
						}
					}
					else
					{
						Interaction.MsgBox(response.Results);
					}
				}
				catch (Exception ex3)
				{
					ProjectData.SetProjectError(ex3);
					Exception ex4 = ex3;
					Interaction.MsgBox(ex4.Message, MsgBoxStyle.Critical, "Error2");
					ProjectData.ClearProjectError();
				}
			}
			Mod_Sentencias.cnn.Close();
		}
		catch (Exception ex5)
		{
			ProjectData.SetProjectError(ex5);
			Exception ex6 = ex5;
			Mod_Sentencias.cnn.Close();
			Interaction.MsgBox(ex6.Message + "Error3");
			ProjectData.ClearProjectError();
		}
	}

	public static void posicionar_en_0()
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		checked
		{
			try
			{
				Mod_Sentencias.cnn.Open();
				MySqlCommand val = null;
				DataTable dataTable = new DataTable("x");
				string text = "SELECT * FROM Eventuales WHERE Latitud=0";
				MySqlDataAdapter val2 = new MySqlDataAdapter(text, Mod_Sentencias.cnn);
				((DbDataAdapter)(object)val2).Fill(dataTable);
				Interaction.MsgBox(dataTable.Rows.Count);
				int num = dataTable.Rows.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					string text2 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("UPDATE Eventuales SET Latitud=-34.603561, Longitud=-58.277087 WHERE Eventual=", dataTable.Rows[i]["Eventual"]), " "));
					val = new MySqlCommand(text2, Mod_Sentencias.cnn);
					val.ExecuteNonQuery();
				}
				Mod_Sentencias.cnn.Close();
				Interaction.MsgBox("FIN");
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

	public static void fuera_de_limites()
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		checked
		{
			try
			{
				Mod_Sentencias.cnn.Open();
				MySqlCommand val = null;
				DataTable dataTable = new DataTable("x");
				string text = "SELECT * FROM Eventuales WHERE Longitud=-58";
				MySqlDataAdapter val2 = new MySqlDataAdapter(text, Mod_Sentencias.cnn);
				((DbDataAdapter)(object)val2).Fill(dataTable);
				Interaction.MsgBox(dataTable.Rows.Count);
				int num = dataTable.Rows.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					string text2 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("UPDATE Eventuales SET Latitud=-34.603561, Longitud=-58.277087 WHERE Eventual=", dataTable.Rows[i]["Eventual"]), " "));
					val = new MySqlCommand(text2, Mod_Sentencias.cnn);
					val.ExecuteNonQuery();
				}
				Mod_Sentencias.cnn.Close();
				Interaction.MsgBox("FIN");
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

	public static object posicionarDireccion()
	{
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected O, but got Unknown
		Logger.i("Inicio Posicionamiento");
		int num = 0;
		string empty = string.Empty;
		string empty2 = string.Empty;
		string empty3 = string.Empty;
		int num2 = 0;
		double num3 = 0.0;
		double num4 = 0.0;
		int num5 = 0;
		num5 = Conversions.ToInteger(MyProject.Forms.Form2_AdmDB.TextBox20.Text);
		string text = Strings.Format(MyProject.Forms.Form1_Inicio.DateTimePicker1.Value, "yyyyMMdd");
		string text2 = "SELECT Domicilio, CP, Localidad, guia FROM Planchada WHERE fecha='" + text + "' and chofer=0 and cliente='ETRANS' and zona= " + Conversions.ToString(num5);
		DataTable dataTable = new DataTable("x");
		MySqlDataAdapter val = new MySqlDataAdapter(text2, Mod_Sentencias.cnn);
		((DbDataAdapter)(object)val).Fill(dataTable);
		int num6 = 0;
		int num7 = 0;
		MyProject.Forms.Loading.ProgressBar1.Maximum = dataTable.Rows.Count;
		MyProject.Forms.Loading.ProgressBar1.Value = 0;
		MyProject.Forms.Loading.Show();
		MyProject.Forms.Loading.ProgressBar1.Refresh();
		checked
		{
			int num8 = dataTable.Rows.Count - 1;
			for (int i = 0; i <= num8; i++)
			{
				num = Conversions.ToInteger(dataTable.Rows[i]["guia"]);
				empty = Conversions.ToString(dataTable.Rows[i]["Domicilio"]);
				num2 = Conversions.ToInteger(dataTable.Rows[i]["CP"]);
				empty2 = ((num2 <= 1599) ? "Buenos Aires, Ciudad Autonoma de Buenos Aires, Argentina " : Conversions.ToString(Operators.ConcatenateObject(dataTable.Rows[i]["Localidad"], ",Buenos Aires, Argentina")));
				empty3 = empty + "," + empty2;
				string text3 = Conversions.ToString(ObtenerCoordenadas(empty3));
				if (Operators.CompareString(text3, string.Empty, TextCompare: true) != 0)
				{
					string[] array = text3.Split('|');
					try
					{
						array[0] = Strings.Replace(array[0], "\"", "", 1, -1, CompareMethod.Text);
						array[0] = Strings.Replace(array[0], ".", ",", 1, -1, CompareMethod.Text);
						array[1] = Strings.Replace(array[1], "\"", "", 1, -1, CompareMethod.Text);
						array[1] = Strings.Replace(array[1], ".", ",", 1, -1, CompareMethod.Text);
						num3 = Conversions.ToDouble(array[0]);
						num4 = Conversions.ToDouble(array[1]);
						Mod_Rutearmodulo.localizar_punto(num3, num4, num);
						num6++;
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
				}
				MyProject.Forms.Loading.ProgressBar1.Value = MyProject.Forms.Loading.ProgressBar1.Value + 1;
				MyProject.Forms.Loading.ProgressBar1.Refresh();
			}
			MyProject.Forms.Loading.Close();
			Logger.i("Posicionadas: " + Conversions.ToString(num6) + " Centradas: " + Conversions.ToString(num7) + " Total Guias: " + Conversions.ToString(dataTable.Rows.Count));
			return num5;
		}
	}

	public static object ObtenerCoordenadas(string address)
	{
		string result = string.Empty;
		try
		{
			string empty = string.Empty;
			empty = $"https://nominatim.openstreetmap.org/?format=json&addressdetails=1&limit=1&q={address}";
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(empty);
			httpWebRequest.Credentials = CredentialCache.DefaultCredentials;
			httpWebRequest.ContentType = "application/json";
			httpWebRequest.Method = "GET";
			HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
			Stream responseStream = httpWebResponse.GetResponseStream();
			StreamReader streamReader = new StreamReader(responseStream);
			string text = streamReader.ReadToEnd();
			string text2 = text;
			Logger.e("Response:_ " + text2);
			if (Operators.CompareString(text2, "[]", TextCompare: true) != 0)
			{
				Console.WriteLine(text2);
				string[] array = text2.Split(',');
				result = array[6] + "|" + array[7];
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Logger.e("ObtenerCoordenadas:_ " + ex2.Message + " " + ex2.StackTrace);
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static object get_coord(string address)
	{
		string requestUriString = $"https://maps.googleapis.com/maps/api/geocode/xml?address={Uri.EscapeDataString(address)}&sensor=false&key=AIzaSyDTis0PAjq3FcaWunEOgdT8Yb64aMzZZv4";
		CookieContainer cookieContainer = new CookieContainer();
		HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(requestUriString);
		httpWebRequest.Method = "GET";
		httpWebRequest.KeepAlive = true;
		httpWebRequest.CookieContainer = cookieContainer;
		httpWebRequest.UserAgent = "Mozilla/5.0 (Windows; U; Windows NT 6.1; ru; rv:1.9.2.3) Gecko/20100401 Firefox/4.0 (.NET CLR 3.5.30729";
		httpWebRequest.ContentType = "application/x-www-form-urlencoded";
		httpWebRequest.Referer = "https://maps.googleapis.com";
		HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
		cookieContainer.Add(httpWebResponse.Cookies);
		StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream());
		string xml = streamReader.ReadToEnd();
		XmlDocument xmlDocument = new XmlDocument();
		xmlDocument.LoadXml(xml);
		string empty = string.Empty;
		string empty2 = string.Empty;
		string empty3 = string.Empty;
		List<string> list = new List<string>();
		foreach (XmlNode item in xmlDocument.DocumentElement.SelectSingleNode("result/geometry/location"))
		{
			if (Operators.CompareString(item.Name, "lat", TextCompare: true) == 0)
			{
				empty = item.InnerText;
				list.Add(empty);
			}
			if (Operators.CompareString(item.Name, "lng", TextCompare: true) == 0)
			{
				empty2 = item.InnerText;
				list.Add(empty2);
			}
		}
		empty3 = xmlDocument.DocumentElement.SelectSingleNode("result/formatted_address").InnerText;
		list.Add(empty3);
		return list;
	}

	public static void posicionarEventuales(int zonaP)
	{
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected O, but got Unknown
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Expected O, but got Unknown
		Logger.i("Inicio Proceso de posicionamiento");
		int num = 0;
		int num2 = 0;
		string empty = string.Empty;
		string empty2 = string.Empty;
		string empty3 = string.Empty;
		int num3 = 0;
		int num4 = 0;
		string text = null;
		string text2 = null;
		int num5 = 0;
		int num6 = 0;
		string text3 = "Select Cliente, Eventual, Domicilio, Localidad, CP, zona, Latitud, Longitud FROM eventuales where zona=" + Conversions.ToString(zonaP);
		DataTable dataTable = new DataTable("x");
		MySqlDataAdapter val = new MySqlDataAdapter(text3, Mod_Sentencias.cnn);
		((DbDataAdapter)(object)val).Fill(dataTable);
		num5 = dataTable.Rows.Count;
		checked
		{
			int num7 = dataTable.Rows.Count - 1;
			for (int i = 0; i <= num7; i++)
			{
				num = Conversions.ToInteger(dataTable.Rows[i]["Eventual"]);
				empty = Conversions.ToString(dataTable.Rows[i]["Domicilio"]);
				num3 = Conversions.ToInteger(dataTable.Rows[i]["CP"]);
				empty2 = ((num3 <= 1599) ? "Buenos Aires, Ciudad Autonoma de Buenos Aires, Argentina " : Conversions.ToString(Operators.ConcatenateObject(dataTable.Rows[i]["Localidad"], ", Buenos Aires, Argentina")));
				empty3 = empty + ", " + empty2;
				string text4 = Conversions.ToString(ObtenerCoordenadas(empty3));
				string[] array = text4.Split('|');
				try
				{
					array[0] = Strings.Replace(array[0], "\"", "", 1, -1, CompareMethod.Text);
					array[0] = Strings.Replace(array[0], ".", ",", 1, -1, CompareMethod.Text);
					array[1] = Strings.Replace(array[1], "\"", "", 1, -1, CompareMethod.Text);
					array[1] = Strings.Replace(array[1], ".", ",", 1, -1, CompareMethod.Text);
					text = array[0];
					text2 = array[1];
					try
					{
						string text5 = "Select DISTINCT zona FROM Dibujos ORDER BY zona";
						DataTable dataTable2 = new DataTable("x");
						MySqlDataAdapter val2 = new MySqlDataAdapter(text5, Mod_Sentencias.cnn);
						((DbDataAdapter)(object)val2).Fill(dataTable2);
						int num8 = dataTable2.Rows.Count - 1;
						for (int j = 0; j <= num8; j++)
						{
							int valorzona = Conversions.ToInteger(dataTable2.Rows[j]["Zona"]);
							if (Conversions.ToBoolean(Mod_Calculos.puntoenpoligono3(valorzona, Conversions.ToDouble(text), Conversions.ToDouble(text2))))
							{
								num4 = Conversions.ToInteger(dataTable2.Rows[j]["zona"]);
								text = Strings.Replace(text, ",", ".", 1, -1, CompareMethod.Text);
								text2 = Strings.Replace(text2, ",", ".", 1, -1, CompareMethod.Text);
								string sQL = "UPDATE eventuales Set zona=" + Conversions.ToString(num4) + ", latitud ='" + text + "', longitud='" + text2 + "', usuario='Posicionador' WHERE eventual = '" + Conversions.ToString(num) + "' LIMIT 1";
								Mod_ConeccionBD.BD_Sentencia(sQL);
							}
						}
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						ProjectData.ClearProjectError();
					}
					num6++;
				}
				catch (Exception ex3)
				{
					ProjectData.SetProjectError(ex3);
					Exception ex4 = ex3;
					ProjectData.ClearProjectError();
				}
				Logger.i("Eventual: " + Conversions.ToString(num) + " - zona: " + Conversions.ToString(num4));
			}
			Logger.i("Procesadas: " + Conversions.ToString(num5) + " - Posicionadas: " + Conversions.ToString(num6));
		}
	}

	public static object GetCoorFromBing()
	{
		string text = "AR";
		string empty = string.Empty;
		string text2 = "Burzaco";
		string text3 = "1852";
		string text4 = "Tomas Guido 2585";
		string empty2 = string.Empty;
		string text5 = "127.0.0.1";
		string empty3 = string.Empty;
		string text6 = "0";
		string text7 = "5";
		string text8 = "AgWz0rBatLVmNGTm_sOjgByBoQETwsXh58bflavGAH-sjXvZG-dcKY8Vb9bKJhMj";
		string text9 = "http://dev.virtualearth.net/REST/v1/Locations?";
		if ((object)text != string.Empty)
		{
			text9 = text9 + "countryRegion=" + text;
		}
		if ((object)empty != string.Empty)
		{
			text9 = text9 + "&adminDistrict=" + empty;
		}
		if ((object)text2 != string.Empty)
		{
			text9 = text9 + "&locality=" + text2;
		}
		if ((object)text3 != string.Empty)
		{
			text9 = text9 + "&postalCode=" + text3;
		}
		if ((object)text4 != string.Empty)
		{
			text9 = text9 + "&addressLine=" + text4;
		}
		if ((object)empty2 != string.Empty)
		{
			text9 = text9 + "&userLocation=" + empty2;
		}
		if ((object)text5 != string.Empty)
		{
			text9 = text9 + "&userIp=" + text5;
		}
		if ((object)empty3 != string.Empty)
		{
			text9 = text9 + "&usermapView=" + empty3;
		}
		if ((object)text6 != string.Empty)
		{
			text9 = text9 + "&inclnb=" + text6;
		}
		if ((object)text7 != string.Empty)
		{
			text9 = text9 + "&maxRes=" + text7;
		}
		if ((object)text8 != string.Empty)
		{
			text9 = text9 + "&key=" + text8;
		}
		return text9;
	}
}
