using System;
using System.Data;
using System.Data.OleDb;
using Hermes.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Hermes;

[StandardModule]
internal sealed class Mod_excelReader
{
	private static object SelectController(string extencion, string filePath)
	{
		string result = string.Empty;
		if (Conversions.ToDouble(extencion) == 1.0)
		{
			result = "Provider=Microsoft.Jet.OLEDB.4.0; Extended Properties='Excel 8.0;HDR=Yes'; Data Source='" + filePath + "'";
		}
		else if (Conversions.ToDouble(extencion) == 2.0)
		{
			result = "Provider=Microsoft.ACE.OLEDB.12.0; Extended Properties='Excel 12.0 Xml;HDR=Yes'; Data Source='" + filePath + "'";
		}
		return result;
	}

	public static object ExcelReader(string fileName, string filePath)
	{
		DataTable dataTable = new DataTable();
		OleDbConnection oleDbConnection = new OleDbConnection();
		checked
		{
			object result;
			try
			{
				int num = fileName.LastIndexOf(".");
				int length = fileName.Length - (num + 1);
				string text = fileName.Substring(num + 1, length);
				int num2 = 0;
				string left = text;
				if (Operators.CompareString(left, "xls", TextCompare: true) == 0)
				{
					num2 = 1;
				}
				else if (Operators.CompareString(left, "xlsx", TextCompare: true) == 0)
				{
					num2 = 2;
				}
				string connectionString = Conversions.ToString(SelectController(Conversions.ToString(num2), filePath));
				oleDbConnection = new OleDbConnection(connectionString);
				oleDbConnection.Open();
				string text2 = "hoja1$";
				string selectCommandText = $"SELECT * FROM [hoja1$]";
				OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(selectCommandText, oleDbConnection);
				oleDbDataAdapter.Fill(dataTable);
				dataTable.Columns[4].ColumnName = "Cantidad";
				oleDbConnection.Close();
				result = dataTable;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Logger.e(ex2.Message);
				oleDbConnection.Close();
				result = dataTable;
				ProjectData.ClearProjectError();
			}
			return result;
		}
	}

	public static object ExcelWrite(DataTable data)
	{
		string text = AppDomain.CurrentDomain.BaseDirectory + "Ordenes_Exportadas_" + MyProject.Forms.Form1_Inicio.nombreusuario.Text + ".xls";
		string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + text + ";Extended Properties=Excel 8.0;";
		OleDbConnection oleDbConnection = new OleDbConnection(connectionString);
		int count = data.Columns.Count;
		int count2 = data.Rows.Count;
		checked
		{
			object result;
			try
			{
				oleDbConnection.Open();
				OleDbCommand oleDbCommand = new OleDbCommand();
				oleDbCommand.Connection = oleDbConnection;
				int num = count2 - 1;
				for (int i = 0; i <= num; i++)
				{
					oleDbCommand.CommandText = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Insert into [hoja1$] (id, remitos, fecha, destino, domicilio, localidad, descripcion, kilos, bultos, mt3, valor, valorctr, observacion) values (", data.Rows[i]["id"]), ",'"), data.Rows[i]["remitos"].ToString()), "','"), data.Rows[i]["fecha"].ToString()), "','"), data.Rows[i]["destino"].ToString()), "','"), data.Rows[i]["domicilio"].ToString()), "','"), data.Rows[i]["localidad"].ToString()), "','"), data.Rows[i]["descripcion"].ToString()), "','"), Strings.Replace(data.Rows[i]["kilos"].ToString(), ",", ".", 1, -1, CompareMethod.Text)), "','"), data.Rows[i]["bultos"].ToString()), "','"), Strings.Replace(data.Rows[i]["mt3"].ToString(), ",", ".", 1, -1, CompareMethod.Text)), "','"), Strings.Replace(data.Rows[i]["valor"].ToString(), ",", ".", 1, -1, CompareMethod.Text)), "','"), Strings.Replace(data.Rows[i]["valorctr"].ToString(), ",", ".", 1, -1, CompareMethod.Text)), "','"), data.Rows[i]["observacion"].ToString()), "')"));
					oleDbCommand.ExecuteNonQuery();
					MyProject.Forms.Loading.ProgressBar1.Value = MyProject.Forms.Loading.ProgressBar1.Value + 1;
					MyProject.Forms.Loading.ProgressBar1.Refresh();
				}
				oleDbConnection.Close();
				result = true;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Logger.e(ex2.Message);
				oleDbConnection.Close();
				result = false;
				ProjectData.ClearProjectError();
			}
			return result;
		}
	}
}
