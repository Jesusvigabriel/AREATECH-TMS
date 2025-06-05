using System;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Hermes.My;
using Microsoft.Office.Interop.Excel;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;
using SpreadsheetLight;

namespace Hermes;

[StandardModule]
internal sealed class Mod_Exportar
{
	public static void exportar_excel(string sql, string Destino)
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		checked
		{
			try
			{
				DataTable dataTable = new DataTable("x");
				string filename = (AppDomain.CurrentDomain.BaseDirectory ?? "") + Destino + ".xls";
				MySqlDataAdapter val = new MySqlDataAdapter(sql, Mod_Sentencias.cnn);
				DataSet dataSet = new DataSet();
				((DbDataAdapter)(object)val).Fill(dataTable);
				Microsoft.Office.Interop.Excel.Application application = (Microsoft.Office.Interop.Excel.Application)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("00024500-0000-0000-C000-000000000046")));
				Workbook workbook = application.Workbooks.Add(RuntimeHelpers.GetObjectValue(Missing.Value));
				Worksheet worksheet = (Worksheet)workbook.Worksheets.Add(RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value));
				int count = dataTable.Columns.Count;
				int count2 = dataTable.Rows.Count;
				MyProject.Forms.Loading.ProgressBar1.Maximum = count2;
				MyProject.Forms.Loading.ProgressBar1.Value = 0;
				MyProject.Forms.Loading.Show();
				MyProject.Forms.Loading.ProgressBar1.Refresh();
				int num = count;
				for (int i = 1; i <= num; i++)
				{
					worksheet.Cells.set_Item((object)1, (object)i, (object)dataTable.Columns[i - 1].ColumnName.ToString());
					worksheet.Cells.set_Item((object)1, (object)24, (object)"Duracion");
					worksheet.Cells.set_Item((object)1, (object)25, (object)"Nada");
					worksheet.Cells.set_Item((object)1, (object)26, (object)"Tipo");
					worksheet.Cells.set_Item((object)1, (object)27, (object)"items");
				}
				int num2 = count2 - 1;
				for (int j = 0; j <= num2; j++)
				{
					int num3 = count - 1;
					for (int k = 0; k <= num3; k++)
					{
						worksheet.Cells.set_Item((object)(j + 2), (object)(k + 1), (object)dataTable.Rows[j][k].ToString());
					}
					worksheet.Cells.set_Item((object)(j + 2), (object)24, (object)1);
					worksheet.Cells.set_Item((object)(j + 2), (object)25, (object)1);
					if (Operators.CompareString(dataTable.Rows[j][2].ToString(), "ETRANS", TextCompare: true) == 0)
					{
						worksheet.Cells.set_Item((object)(j + 2), (object)26, (object)0);
					}
					else
					{
						worksheet.Cells.set_Item((object)(j + 2), (object)26, (object)1);
					}
					worksheet.Cells.set_Item((object)(j + 2), (object)27, (object)dataTable.Rows[j][3].ToString());
					MyProject.Forms.Loading.ProgressBar1.Value = MyProject.Forms.Loading.ProgressBar1.Value + 1;
					MyProject.Forms.Loading.ProgressBar1.Refresh();
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(worksheet.Rows.get_Item((object)1, RuntimeHelpers.GetObjectValue(Missing.Value)), null, "Font", new object[0], null, null, null), null, "Bold", new object[1] { 1 }, null, null, OptimisticSet: false, RValueBase: true);
				NewLateBinding.LateSetComplex(worksheet.Rows.get_Item((object)1, RuntimeHelpers.GetObjectValue(Missing.Value)), null, "HorizontalAlignment", new object[1] { 3 }, null, null, OptimisticSet: false, RValueBase: true);
				worksheet.Columns.AutoFit();
				workbook.SaveAs(filename, 51, "", "", false, false, XlSaveAsAccessMode.xlNoChange, RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value));
				workbook.Close(RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value));
				MyProject.Forms.Loading.Close();
				worksheet = null;
				workbook = null;
				application = null;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception objExcepcion = ex;
				Interaction.MsgBox("Ocurrio un error en el proceso");
				Logger.e("Error con excepción y traza", objExcepcion, new StackFrame(fNeedFileInfo: true));
				ProjectData.ClearProjectError();
			}
		}
	}

	public static void exp_excel(string sql, string Destino)
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		checked
		{
			try
			{
				DataTable dataTable = new DataTable("x");
				string filename = (AppDomain.CurrentDomain.BaseDirectory ?? "") + Destino + ".xlsx";
				MySqlDataAdapter val = new MySqlDataAdapter(sql, Mod_Sentencias.cnn);
				DataSet dataSet = new DataSet();
				((DbDataAdapter)(object)val).Fill(dataTable);
				Microsoft.Office.Interop.Excel.Application application = (Microsoft.Office.Interop.Excel.Application)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("00024500-0000-0000-C000-000000000046")));
				Workbook workbook = application.Workbooks.Add(RuntimeHelpers.GetObjectValue(Missing.Value));
				Worksheet worksheet = (Worksheet)workbook.Worksheets.Add(RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value));
				int count = dataTable.Columns.Count;
				int count2 = dataTable.Rows.Count;
				MyProject.Forms.Loading.ProgressBar1.Maximum = count + count2;
				MyProject.Forms.Loading.ProgressBar1.Value = 0;
				MyProject.Forms.Loading.Show();
				MyProject.Forms.Loading.ProgressBar1.Refresh();
				int num = count;
				for (int i = 1; i <= num; i++)
				{
					worksheet.Cells.set_Item((object)1, (object)i, (object)dataTable.Columns[i - 1].ColumnName.ToString());
				}
				int num2 = count2 - 1;
				for (int j = 0; j <= num2; j++)
				{
					int num3 = count - 1;
					for (int k = 0; k <= num3; k++)
					{
						worksheet.Cells.set_Item((object)(j + 2), (object)(k + 1), (object)dataTable.Rows[j][k].ToString());
					}
					MyProject.Forms.Loading.ProgressBar1.Value = MyProject.Forms.Loading.ProgressBar1.Value + 1;
					MyProject.Forms.Loading.ProgressBar1.Refresh();
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(worksheet.Rows.get_Item((object)1, RuntimeHelpers.GetObjectValue(Missing.Value)), null, "Font", new object[0], null, null, null), null, "Bold", new object[1] { 1 }, null, null, OptimisticSet: false, RValueBase: true);
				NewLateBinding.LateSetComplex(worksheet.Rows.get_Item((object)1, RuntimeHelpers.GetObjectValue(Missing.Value)), null, "HorizontalAlignment", new object[1] { 3 }, null, null, OptimisticSet: false, RValueBase: true);
				worksheet.Columns.AutoFit();
				workbook.SaveAs(filename, 51, "", "", false, false, XlSaveAsAccessMode.xlNoChange, RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value));
				workbook.Close(RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value));
				MyProject.Forms.Loading.Close();
				worksheet = null;
				workbook = null;
				application = null;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception objExcepcion = ex;
				Interaction.MsgBox("Ocurrio un error en el proceso");
				Logger.e("Error con excepción y traza", objExcepcion, new StackFrame(fNeedFileInfo: true));
				ProjectData.ClearProjectError();
			}
		}
	}

	public static void exp_excel_dir(string sql, string Destino)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		checked
		{
			try
			{
				DataTable dataTable = new DataTable("x");
				string filename = Destino + ".xlsx";
				MySqlDataAdapter val = new MySqlDataAdapter(sql, Mod_Sentencias.cnn);
				DataSet dataSet = new DataSet();
				((DbDataAdapter)(object)val).Fill(dataTable);
				_Application application = (Microsoft.Office.Interop.Excel.Application)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("00024500-0000-0000-C000-000000000046")));
				_Workbook workbook = application.Workbooks.Add(RuntimeHelpers.GetObjectValue(Missing.Value));
				_Worksheet worksheet = (_Worksheet)workbook.Worksheets.Add(RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value));
				int count = dataTable.Columns.Count;
				int count2 = dataTable.Rows.Count;
				MyProject.Forms.Loading.ProgressBar1.Maximum = count + count2;
				MyProject.Forms.Loading.ProgressBar1.Value = 0;
				MyProject.Forms.Loading.Show();
				MyProject.Forms.Loading.ProgressBar1.Refresh();
				int num = count;
				for (int i = 1; i <= num; i++)
				{
					worksheet.Cells.set_Item((object)1, (object)i, (object)dataTable.Columns[i - 1].ColumnName.ToString());
				}
				int num2 = count2 - 1;
				for (int j = 0; j <= num2; j++)
				{
					int num3 = count - 1;
					for (int k = 0; k <= num3; k++)
					{
						worksheet.Cells.set_Item((object)(j + 2), (object)(k + 1), (object)dataTable.Rows[j][k].ToString());
					}
					MyProject.Forms.Loading.ProgressBar1.Value = MyProject.Forms.Loading.ProgressBar1.Value + 1;
					MyProject.Forms.Loading.ProgressBar1.Refresh();
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(worksheet.Rows.get_Item((object)1, RuntimeHelpers.GetObjectValue(Missing.Value)), null, "Font", new object[0], null, null, null), null, "Bold", new object[1] { 1 }, null, null, OptimisticSet: false, RValueBase: true);
				NewLateBinding.LateSetComplex(worksheet.Rows.get_Item((object)1, RuntimeHelpers.GetObjectValue(Missing.Value)), null, "HorizontalAlignment", new object[1] { 3 }, null, null, OptimisticSet: false, RValueBase: true);
				worksheet.Columns.AutoFit();
				workbook.SaveAs(filename, 51, "", "", false, false, XlSaveAsAccessMode.xlNoChange, RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value));
				workbook.Close(RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value));
				MyProject.Forms.Loading.Close();
				worksheet = null;
				workbook = null;
				application = null;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception objExcepcion = ex;
				Interaction.MsgBox("Ocurrio un error en el proceso");
				Logger.e("Error con excepción y traza", objExcepcion, new StackFrame(fNeedFileInfo: true));
				ProjectData.ClearProjectError();
			}
		}
	}

	public static void exp_excel_data(string Destino)
	{
		checked
		{
			try
			{
				DataTable dataTable = (DataTable)Mod_Informes.informeDiario();
				string filename = (AppDomain.CurrentDomain.BaseDirectory ?? "") + Destino + ".xlsx";
				Microsoft.Office.Interop.Excel.Application application = (Microsoft.Office.Interop.Excel.Application)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("00024500-0000-0000-C000-000000000046")));
				Workbook workbook = application.Workbooks.Add(RuntimeHelpers.GetObjectValue(Missing.Value));
				Worksheet worksheet = (Worksheet)workbook.Worksheets.Add(RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value));
				int count = dataTable.Columns.Count;
				int count2 = dataTable.Rows.Count;
				MyProject.Forms.Loading.ProgressBar1.Maximum = count + count2;
				MyProject.Forms.Loading.ProgressBar1.Value = 0;
				MyProject.Forms.Loading.Show();
				MyProject.Forms.Loading.ProgressBar1.Refresh();
				int num = count;
				for (int i = 1; i <= num; i++)
				{
					worksheet.Cells.set_Item((object)1, (object)i, (object)dataTable.Columns[i - 1].ColumnName.ToString());
				}
				int num2 = count2 - 1;
				for (int j = 0; j <= num2; j++)
				{
					int num3 = count - 1;
					for (int k = 0; k <= num3; k++)
					{
						worksheet.Cells.set_Item((object)(j + 2), (object)(k + 1), (object)dataTable.Rows[j][k].ToString());
					}
					MyProject.Forms.Loading.ProgressBar1.Value = MyProject.Forms.Loading.ProgressBar1.Value + 1;
					MyProject.Forms.Loading.ProgressBar1.Refresh();
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(worksheet.Rows.get_Item((object)1, RuntimeHelpers.GetObjectValue(Missing.Value)), null, "Font", new object[0], null, null, null), null, "Bold", new object[1] { 1 }, null, null, OptimisticSet: false, RValueBase: true);
				NewLateBinding.LateSetComplex(worksheet.Rows.get_Item((object)1, RuntimeHelpers.GetObjectValue(Missing.Value)), null, "HorizontalAlignment", new object[1] { 3 }, null, null, OptimisticSet: false, RValueBase: true);
				worksheet.Columns.AutoFit();
				workbook.SaveAs(filename, 51, "", "", false, false, XlSaveAsAccessMode.xlNoChange, RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value));
				workbook.Close(RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value));
				MyProject.Forms.Loading.Close();
				worksheet = null;
				workbook = null;
				application = null;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception objExcepcion = ex;
				Interaction.MsgBox("Ocurrio un error en el proceso");
				Logger.e("Error con excepción y traza", objExcepcion, new StackFrame(fNeedFileInfo: true));
				ProjectData.ClearProjectError();
			}
		}
	}

	public static void DataToExcel(DataTable Data)
	{
		checked
		{
			try
			{
				string filename = MyProject.Computer.FileSystem.SpecialDirectories.Desktop + "\\Ordenes_Exportadas_" + MySettingsProperty.Settings.Usuario + ".xlsx";
				Microsoft.Office.Interop.Excel.Application application = (Microsoft.Office.Interop.Excel.Application)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("00024500-0000-0000-C000-000000000046")));
				Workbook workbook = application.Workbooks.Add(RuntimeHelpers.GetObjectValue(Missing.Value));
				Worksheet worksheet = (Worksheet)workbook.Worksheets.Add(RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value));
				int count = Data.Columns.Count;
				int count2 = Data.Rows.Count;
				MyProject.Forms.Loading.ProgressBar1.Maximum = count + count2;
				MyProject.Forms.Loading.ProgressBar1.Value = 0;
				MyProject.Forms.Loading.Show();
				MyProject.Forms.Loading.ProgressBar1.Refresh();
				int num = count;
				for (int i = 1; i <= num; i++)
				{
					worksheet.Cells.set_Item((object)1, (object)i, (object)Data.Columns[i - 1].ColumnName.ToString());
				}
				int num2 = count2 - 1;
				for (int j = 0; j <= num2; j++)
				{
					int num3 = count - 1;
					for (int k = 0; k <= num3; k++)
					{
						worksheet.Cells.set_Item((object)(j + 2), (object)(k + 1), (object)Data.Rows[j][k].ToString());
					}
					MyProject.Forms.Loading.ProgressBar1.Value = MyProject.Forms.Loading.ProgressBar1.Value + 1;
					MyProject.Forms.Loading.ProgressBar1.Refresh();
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(worksheet.Rows.get_Item((object)1, RuntimeHelpers.GetObjectValue(Missing.Value)), null, "Font", new object[0], null, null, null), null, "Bold", new object[1] { 1 }, null, null, OptimisticSet: false, RValueBase: true);
				NewLateBinding.LateSetComplex(worksheet.Rows.get_Item((object)1, RuntimeHelpers.GetObjectValue(Missing.Value)), null, "HorizontalAlignment", new object[1] { 3 }, null, null, OptimisticSet: false, RValueBase: true);
				worksheet.Columns.AutoFit();
				workbook.SaveAs(filename, 51, "", "", false, false, XlSaveAsAccessMode.xlNoChange, RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value));
				workbook.Close(RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value));
				MyProject.Forms.Loading.Close();
				worksheet = null;
				workbook = null;
				application = null;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception objExcepcion = ex;
				Interaction.MsgBox("Ocurrio un error en el proceso");
				Logger.e("Error con excepción y traza", objExcepcion, new StackFrame(fNeedFileInfo: true));
				ProjectData.ClearProjectError();
			}
		}
	}

	public static void DataToExcelByName(DataTable Data, string nombre)
	{
		checked
		{
			try
			{
				string filename = MyProject.Computer.FileSystem.SpecialDirectories.Desktop + "\\" + nombre + "_" + MySettingsProperty.Settings.Usuario + ".xlsx";
				Microsoft.Office.Interop.Excel.Application application = (Microsoft.Office.Interop.Excel.Application)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("00024500-0000-0000-C000-000000000046")));
				Workbook workbook = application.Workbooks.Add(RuntimeHelpers.GetObjectValue(Missing.Value));
				Worksheet worksheet = (Worksheet)workbook.Worksheets.Add(RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value));
				int count = Data.Columns.Count;
				int count2 = Data.Rows.Count;
				MyProject.Forms.Loading.ProgressBar1.Maximum = count + count2;
				MyProject.Forms.Loading.ProgressBar1.Value = 0;
				MyProject.Forms.Loading.Show();
				MyProject.Forms.Loading.ProgressBar1.Refresh();
				int num = count;
				for (int i = 1; i <= num; i++)
				{
					worksheet.Cells.set_Item((object)1, (object)i, (object)Data.Columns[i - 1].ColumnName.ToString());
				}
				int num2 = count2 - 1;
				for (int j = 0; j <= num2; j++)
				{
					int num3 = count - 1;
					for (int k = 0; k <= num3; k++)
					{
						worksheet.Cells.set_Item((object)(j + 2), (object)(k + 1), (object)Data.Rows[j][k].ToString());
					}
					MyProject.Forms.Loading.ProgressBar1.Value = MyProject.Forms.Loading.ProgressBar1.Value + 1;
					MyProject.Forms.Loading.ProgressBar1.Refresh();
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(worksheet.Rows.get_Item((object)1, RuntimeHelpers.GetObjectValue(Missing.Value)), null, "Font", new object[0], null, null, null), null, "Bold", new object[1] { 1 }, null, null, OptimisticSet: false, RValueBase: true);
				NewLateBinding.LateSetComplex(worksheet.Rows.get_Item((object)1, RuntimeHelpers.GetObjectValue(Missing.Value)), null, "HorizontalAlignment", new object[1] { 3 }, null, null, OptimisticSet: false, RValueBase: true);
				worksheet.Columns.AutoFit();
				workbook.SaveAs(filename, 51, "", "", false, false, XlSaveAsAccessMode.xlNoChange, RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value));
				workbook.Close(RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value));
				MyProject.Forms.Loading.Close();
				worksheet = null;
				workbook = null;
				application = null;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception objExcepcion = ex;
				Interaction.MsgBox("Ocurrio un error en el proceso");
				Logger.e("Error con excepción y traza", objExcepcion, new StackFrame(fNeedFileInfo: true));
				ProjectData.ClearProjectError();
			}
		}
	}

	public static object ListviewToDatatable(ListView LV)
	{
		DataTable dataTable = new DataTable();
		foreach (object column in LV.Columns)
		{
			object objectValue = RuntimeHelpers.GetObjectValue(column);
			DataColumnCollection columns = dataTable.Columns;
			object[] array = new object[1];
			object instance = objectValue;
			array[0] = NewLateBinding.LateGet(instance, null, "text", new object[0], null, null, null);
			object[] array2 = array;
			bool[] array3;
			NewLateBinding.LateCall(columns, null, "Add", array, null, null, array3 = new bool[1] { true }, IgnoreReturn: true);
			if (array3[0])
			{
				NewLateBinding.LateSetComplex(instance, null, "text", new object[1] { array2[0] }, null, null, OptimisticSet: true, RValueBase: false);
			}
		}
		checked
		{
			int num = LV.Items.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				dataTable.Rows.Add(LV.Items[i].SubItems[0].Text, LV.Items[i].SubItems[1].Text, LV.Items[i].SubItems[2].Text, LV.Items[i].SubItems[3].Text, LV.Items[i].SubItems[4].Text, LV.Items[i].SubItems[5].Text, LV.Items[i].SubItems[6].Text, LV.Items[i].SubItems[7].Text, LV.Items[i].SubItems[8].Text, LV.Items[i].SubItems[9].Text, LV.Items[i].SubItems[10].Text);
			}
			return dataTable;
		}
	}

	public static void DatatableToExcelDir(DataTable Data, string Destino)
	{
		checked
		{
			try
			{
				string filename = Destino + ".xlsx";
				Microsoft.Office.Interop.Excel.Application application = (Microsoft.Office.Interop.Excel.Application)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("00024500-0000-0000-C000-000000000046")));
				Workbook workbook = application.Workbooks.Add(RuntimeHelpers.GetObjectValue(Missing.Value));
				Worksheet worksheet = (Worksheet)workbook.Worksheets.Add(RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value));
				int count = Data.Columns.Count;
				int count2 = Data.Rows.Count;
				MyProject.Forms.Loading.ProgressBar1.Maximum = count + count2;
				MyProject.Forms.Loading.ProgressBar1.Value = 0;
				MyProject.Forms.Loading.Show();
				MyProject.Forms.Loading.ProgressBar1.Refresh();
				int num = count;
				for (int i = 1; i <= num; i++)
				{
					worksheet.Cells.set_Item((object)1, (object)i, (object)Data.Columns[i - 1].ColumnName.ToString());
				}
				int num2 = count2 - 1;
				for (int j = 0; j <= num2; j++)
				{
					int num3 = count - 1;
					for (int k = 0; k <= num3; k++)
					{
						worksheet.Cells.set_Item((object)(j + 2), (object)(k + 1), (object)Data.Rows[j][k].ToString());
					}
					MyProject.Forms.Loading.ProgressBar1.Value = MyProject.Forms.Loading.ProgressBar1.Value + 1;
					MyProject.Forms.Loading.ProgressBar1.Refresh();
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(worksheet.Rows.get_Item((object)1, RuntimeHelpers.GetObjectValue(Missing.Value)), null, "Font", new object[0], null, null, null), null, "Bold", new object[1] { 1 }, null, null, OptimisticSet: false, RValueBase: true);
				NewLateBinding.LateSetComplex(worksheet.Rows.get_Item((object)1, RuntimeHelpers.GetObjectValue(Missing.Value)), null, "HorizontalAlignment", new object[1] { 3 }, null, null, OptimisticSet: false, RValueBase: true);
				worksheet.Columns.AutoFit();
				workbook.SaveAs(filename, 51, "", "", false, false, XlSaveAsAccessMode.xlNoChange, RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value));
				workbook.Close(RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value));
				MyProject.Forms.Loading.Close();
				worksheet = null;
				workbook = null;
				application = null;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception objExcepcion = ex;
				Interaction.MsgBox("Ocurrio un error en el proceso");
				Logger.e("Error con excepción y traza", objExcepcion, new StackFrame(fNeedFileInfo: true));
				ProjectData.ClearProjectError();
			}
		}
	}

	public static void Excel_export()
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected O, but got Unknown
		SaveFileDialog saveFileDialog = new SaveFileDialog();
		saveFileDialog.Filter = "Excel files(*.xlsx)|*xlsx";
		saveFileDialog.Title = "Guardar Archivo";
		saveFileDialog.ShowDialog();
		string fileName = saveFileDialog.FileName;
		if (Operators.CompareString(fileName, "", TextCompare: true) != 0)
		{
			SLDocument val = new SLDocument();
			val.SaveAs(fileName + ".xlsx");
		}
	}
}
