using System;
using System.Data;
using System.Data.OleDb;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Hermes.My;
using Microsoft.Office.Interop.Excel;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Hermes;

[StandardModule]
internal sealed class Mod_Filtrado
{
	public static void Filtrar()
	{
		checked
		{
			try
			{
				OpenFileDialog openFileDialog = new OpenFileDialog();
				OpenFileDialog openFileDialog2 = openFileDialog;
				openFileDialog2.Filter = "Excel files(*.xls)|*xls|All files (*.*)|*.*";
				openFileDialog2.FilterIndex = 1;
				openFileDialog2.Title = "Import data from Excel file";
				openFileDialog2 = null;
				if (openFileDialog.ShowDialog() != DialogResult.OK)
				{
					return;
				}
				string fileName = openFileDialog.FileName;
				MyProject.Forms.Loading.MdiParent = MyProject.Forms.Form1_Inicio;
				MyProject.Forms.Loading.Show();
				MyProject.Forms.Loading.Refresh();
				int num = 0;
				string text = fileName;
				string text2 = AppDomain.CurrentDomain.BaseDirectory + "Temp.xls";
				object obj = (Microsoft.Office.Interop.Excel.Application)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("00024500-0000-0000-C000-000000000046")));
				object instance = NewLateBinding.LateGet(obj, null, "workbooks", new object[0], null, null, null);
				object[] obj2 = new object[1] { text };
				object[] array = obj2;
				bool[] obj3 = new bool[1] { true };
				bool[] array2 = obj3;
				object obj4 = NewLateBinding.LateGet(instance, null, "open", obj2, null, null, obj3);
				if (array2[0])
				{
					text = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
				}
				object objectValue = RuntimeHelpers.GetObjectValue(obj4);
				object objectValue2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, null, "activesheet", new object[0], null, null, null));
				object instance2 = obj;
				NewLateBinding.LateSet(instance2, null, "Visible", new object[1] { false }, null, null);
				NewLateBinding.LateCall(NewLateBinding.LateGet(instance2, null, "cells", new object[2] { 1, 1 }, null, null, null), null, "Select", new object[0], null, null, null, IgnoreReturn: true);
				NewLateBinding.LateCall(NewLateBinding.LateGet(NewLateBinding.LateGet(instance2, null, "Selection", new object[0], null, null, null), null, "EntireRow", new object[0], null, null, null), null, "Delete", new object[0], null, null, null, IgnoreReturn: true);
				NewLateBinding.LateCall(NewLateBinding.LateGet(instance2, null, "cells", new object[2] { 1, 1 }, null, null, null), null, "Select", new object[0], null, null, null, IgnoreReturn: true);
				instance2 = null;
				MyProject.Forms.Loading.ProgressBar1.Maximum = 100;
				MyProject.Forms.Loading.ProgressBar1.Value = 10;
				object instance3 = obj;
				while (Operators.ConditionalCompareObjectNotEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(instance3, null, "ActiveCell", new object[0], null, null, null), null, "Value", new object[0], null, null, null), "", TextCompare: true))
				{
					if (Operators.ConditionalCompareObjectNotEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(instance3, null, "ActiveCell", new object[0], null, null, null), null, "Value", new object[0], null, null, null), "Entregado", TextCompare: true))
					{
						NewLateBinding.LateCall(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(instance3, null, "ActiveCell", new object[0], null, null, null), null, "Offset", new object[2] { 1, 0 }, null, null, null), null, "Range", new object[1] { "A1" }, null, null, null), null, "Select", new object[0], null, null, null, IgnoreReturn: true);
					}
					else
					{
						NewLateBinding.LateCall(NewLateBinding.LateGet(NewLateBinding.LateGet(instance3, null, "Selection", new object[0], null, null, null), null, "EntireRow", new object[0], null, null, null), null, "Delete", new object[0], null, null, null, IgnoreReturn: true);
					}
				}
				instance3 = null;
				MyProject.Forms.Loading.ProgressBar1.Value = MyProject.Forms.Loading.ProgressBar1.Value + 10;
				object instance4 = obj;
				NewLateBinding.LateCall(NewLateBinding.LateGet(instance4, null, "cells", new object[2] { 1, 1 }, null, null, null), null, "Select", new object[0], null, null, null, IgnoreReturn: true);
				while (Operators.ConditionalCompareObjectNotEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(instance4, null, "ActiveCell", new object[0], null, null, null), null, "Value", new object[0], null, null, null), "", TextCompare: true))
				{
					if (Operators.ConditionalCompareObjectNotEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(instance4, null, "ActiveCell", new object[0], null, null, null), null, "Value", new object[0], null, null, null), "Despachado", TextCompare: true))
					{
						NewLateBinding.LateCall(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(instance4, null, "ActiveCell", new object[0], null, null, null), null, "Offset", new object[2] { 1, 0 }, null, null, null), null, "Range", new object[1] { "A1" }, null, null, null), null, "Select", new object[0], null, null, null, IgnoreReturn: true);
					}
					else
					{
						NewLateBinding.LateCall(NewLateBinding.LateGet(NewLateBinding.LateGet(instance4, null, "Selection", new object[0], null, null, null), null, "EntireRow", new object[0], null, null, null), null, "Delete", new object[0], null, null, null, IgnoreReturn: true);
					}
				}
				instance4 = null;
				MyProject.Forms.Loading.ProgressBar1.Value = MyProject.Forms.Loading.ProgressBar1.Value + 10;
				object instance5 = obj;
				NewLateBinding.LateCall(NewLateBinding.LateGet(instance5, null, "cells", new object[2] { 1, 1 }, null, null, null), null, "Select", new object[0], null, null, null, IgnoreReturn: true);
				while (Operators.ConditionalCompareObjectNotEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(instance5, null, "ActiveCell", new object[0], null, null, null), null, "Value", new object[0], null, null, null), "", TextCompare: true))
				{
					if (Operators.ConditionalCompareObjectNotEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(instance5, null, "ActiveCell", new object[0], null, null, null), null, "Value", new object[0], null, null, null), "Reemplazado", TextCompare: true))
					{
						NewLateBinding.LateCall(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(instance5, null, "ActiveCell", new object[0], null, null, null), null, "Offset", new object[2] { 1, 0 }, null, null, null), null, "Range", new object[1] { "A1" }, null, null, null), null, "Select", new object[0], null, null, null, IgnoreReturn: true);
					}
					else
					{
						NewLateBinding.LateCall(NewLateBinding.LateGet(NewLateBinding.LateGet(instance5, null, "Selection", new object[0], null, null, null), null, "EntireRow", new object[0], null, null, null), null, "Delete", new object[0], null, null, null, IgnoreReturn: true);
					}
				}
				instance5 = null;
				MyProject.Forms.Loading.ProgressBar1.Value = MyProject.Forms.Loading.ProgressBar1.Value + 10;
				object instance6 = obj;
				NewLateBinding.LateCall(NewLateBinding.LateGet(instance6, null, "cells", new object[2] { 1, 1 }, null, null, null), null, "Select", new object[0], null, null, null, IgnoreReturn: true);
				while (Operators.ConditionalCompareObjectNotEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(instance6, null, "ActiveCell", new object[0], null, null, null), null, "Value", new object[0], null, null, null), "", TextCompare: true))
				{
					if (Operators.ConditionalCompareObjectNotEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(instance6, null, "ActiveCell", new object[0], null, null, null), null, "Value", new object[0], null, null, null), "Anulado", TextCompare: true))
					{
						NewLateBinding.LateCall(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(instance6, null, "ActiveCell", new object[0], null, null, null), null, "Offset", new object[2] { 1, 0 }, null, null, null), null, "Range", new object[1] { "A1" }, null, null, null), null, "Select", new object[0], null, null, null, IgnoreReturn: true);
					}
					else
					{
						NewLateBinding.LateCall(NewLateBinding.LateGet(NewLateBinding.LateGet(instance6, null, "Selection", new object[0], null, null, null), null, "EntireRow", new object[0], null, null, null), null, "Delete", new object[0], null, null, null, IgnoreReturn: true);
					}
				}
				instance6 = null;
				MyProject.Forms.Loading.ProgressBar1.Value = MyProject.Forms.Loading.ProgressBar1.Value + 10;
				object instance7 = obj;
				NewLateBinding.LateCall(NewLateBinding.LateGet(instance7, null, "cells", new object[2] { 1, 13 }, null, null, null), null, "Select", new object[0], null, null, null, IgnoreReturn: true);
				while (Operators.ConditionalCompareObjectNotEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(instance7, null, "ActiveCell", new object[0], null, null, null), null, "Value", new object[0], null, null, null), "", TextCompare: true))
				{
					if (Operators.ConditionalCompareObjectNotEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(instance7, null, "ActiveCell", new object[0], null, null, null), null, "Value", new object[0], null, null, null), "40", TextCompare: true))
					{
						NewLateBinding.LateCall(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(instance7, null, "ActiveCell", new object[0], null, null, null), null, "Offset", new object[2] { 1, 0 }, null, null, null), null, "Range", new object[1] { "A1" }, null, null, null), null, "Select", new object[0], null, null, null, IgnoreReturn: true);
					}
					else
					{
						NewLateBinding.LateCall(NewLateBinding.LateGet(NewLateBinding.LateGet(instance7, null, "Selection", new object[0], null, null, null), null, "EntireRow", new object[0], null, null, null), null, "Delete", new object[0], null, null, null, IgnoreReturn: true);
					}
				}
				instance7 = null;
				MyProject.Forms.Loading.ProgressBar1.Value = MyProject.Forms.Loading.ProgressBar1.Value + 10;
				object instance8 = obj;
				NewLateBinding.LateCall(NewLateBinding.LateGet(instance8, null, "cells", new object[2] { 1, 13 }, null, null, null), null, "Select", new object[0], null, null, null, IgnoreReturn: true);
				while (Operators.ConditionalCompareObjectNotEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(instance8, null, "ActiveCell", new object[0], null, null, null), null, "Value", new object[0], null, null, null), "", TextCompare: true))
				{
					if (Operators.ConditionalCompareObjectNotEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(instance8, null, "ActiveCell", new object[0], null, null, null), null, "Value", new object[0], null, null, null), "41", TextCompare: true))
					{
						NewLateBinding.LateCall(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(instance8, null, "ActiveCell", new object[0], null, null, null), null, "Offset", new object[2] { 1, 0 }, null, null, null), null, "Range", new object[1] { "A1" }, null, null, null), null, "Select", new object[0], null, null, null, IgnoreReturn: true);
					}
					else
					{
						NewLateBinding.LateCall(NewLateBinding.LateGet(NewLateBinding.LateGet(instance8, null, "Selection", new object[0], null, null, null), null, "EntireRow", new object[0], null, null, null), null, "Delete", new object[0], null, null, null, IgnoreReturn: true);
					}
				}
				instance8 = null;
				MyProject.Forms.Loading.ProgressBar1.Value = MyProject.Forms.Loading.ProgressBar1.Value + 10;
				object instance9 = obj;
				NewLateBinding.LateCall(NewLateBinding.LateGet(instance9, null, "cells", new object[2] { 1, 13 }, null, null, null), null, "Select", new object[0], null, null, null, IgnoreReturn: true);
				while (Operators.ConditionalCompareObjectNotEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(instance9, null, "ActiveCell", new object[0], null, null, null), null, "Value", new object[0], null, null, null), "", TextCompare: true))
				{
					if (Operators.ConditionalCompareObjectNotEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(instance9, null, "ActiveCell", new object[0], null, null, null), null, "Value", new object[0], null, null, null), "50", TextCompare: true))
					{
						num++;
						NewLateBinding.LateCall(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(instance9, null, "ActiveCell", new object[0], null, null, null), null, "Offset", new object[2] { 1, 0 }, null, null, null), null, "Range", new object[1] { "A1" }, null, null, null), null, "Select", new object[0], null, null, null, IgnoreReturn: true);
					}
					else
					{
						NewLateBinding.LateCall(NewLateBinding.LateGet(NewLateBinding.LateGet(instance9, null, "Selection", new object[0], null, null, null), null, "EntireRow", new object[0], null, null, null), null, "Delete", new object[0], null, null, null, IgnoreReturn: true);
					}
				}
				instance9 = null;
				MyProject.Forms.Loading.ProgressBar1.Value = MyProject.Forms.Loading.ProgressBar1.Value + 10;
				object instance10 = obj;
				NewLateBinding.LateCall(NewLateBinding.LateGet(instance10, null, "Columns", new object[1] { "A:A" }, null, null, null), null, "Select", new object[0], null, null, null, IgnoreReturn: true);
				NewLateBinding.LateCall(NewLateBinding.LateGet(instance10, null, "Selection", new object[0], null, null, null), null, "Delete", new object[0], null, null, null, IgnoreReturn: true);
				instance10 = null;
				MyProject.Forms.Loading.ProgressBar1.Value = MyProject.Forms.Loading.ProgressBar1.Value + 10;
				object instance11 = obj;
				NewLateBinding.LateCall(NewLateBinding.LateGet(instance11, null, "cells", new object[2] { 2, 1 }, null, null, null), null, "Select", new object[0], null, null, null, IgnoreReturn: true);
				int num2 = num - 1;
				for (int i = 1; i <= num2; i++)
				{
					if (Operators.ConditionalCompareObjectNotEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(instance11, null, "activecell", new object[0], null, null, null), null, "value", new object[0], null, null, null), "", TextCompare: true))
					{
						NewLateBinding.LateSetComplex(NewLateBinding.LateGet(instance11, null, "activecell", new object[0], null, null, null), null, "Value", new object[1] { Operators.MultiplyObject(NewLateBinding.LateGet(NewLateBinding.LateGet(instance11, null, "activecell", new object[0], null, null, null), null, "Value", new object[0], null, null, null), 1) }, null, null, OptimisticSet: false, RValueBase: true);
						NewLateBinding.LateCall(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(instance11, null, "ActiveCell", new object[0], null, null, null), null, "Offset", new object[2] { 1, 0 }, null, null, null), null, "Range", new object[1] { "A1" }, null, null, null), null, "Select", new object[0], null, null, null, IgnoreReturn: true);
					}
					else
					{
						NewLateBinding.LateSetComplex(NewLateBinding.LateGet(instance11, null, "ActiveCell", new object[0], null, null, null), null, "FormulaR1C1", new object[1] { "0" }, null, null, OptimisticSet: false, RValueBase: true);
						NewLateBinding.LateCall(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(instance11, null, "ActiveCell", new object[0], null, null, null), null, "Offset", new object[2] { 1, 0 }, null, null, null), null, "Range", new object[1] { "A1" }, null, null, null), null, "Select", new object[0], null, null, null, IgnoreReturn: true);
					}
				}
				instance11 = null;
				bool flag = false;
				string especArch = AppDomain.CurrentDomain.BaseDirectory + "Temp.xls";
				DeleteAFile(especArch);
				NewLateBinding.LateCall(objectValue, null, "Close", array = new object[2] { true, text2 }, null, null, array2 = new bool[2] { false, true }, IgnoreReturn: true);
				if (array2[1])
				{
					text2 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(string));
				}
				objectValue = null;
				text = null;
				text2 = null;
				NewLateBinding.LateCall(obj, null, "Quit", new object[0], null, null, null, IgnoreReturn: true);
				obj = null;
				MyProject.Forms.Loading.ProgressBar1.Value = 0;
				MyProject.Forms.Loading.Close();
				DialogResult dialogResult = MessageBox.Show("Desea ver el archivo?", "Filtrado Finalizado", MessageBoxButtons.YesNo);
				if (dialogResult == DialogResult.Yes)
				{
					Ver_archivo("Temp.xls");
				}
				if (dialogResult != DialogResult.No)
				{
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				MyProject.Forms.Loading.ProgressBar1.Value = 0;
				MyProject.Forms.Loading.Close();
				Interaction.MsgBox(ex2.Message);
				ProjectData.ClearProjectError();
			}
		}
	}

	public static void eventual_0(int lineas)
	{
		string text = AppDomain.CurrentDomain.BaseDirectory + "orden.xls";
		string text2 = AppDomain.CurrentDomain.BaseDirectory + "Temp.xls";
		object obj = (Microsoft.Office.Interop.Excel.Application)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("00024500-0000-0000-C000-000000000046")));
		object instance = NewLateBinding.LateGet(obj, null, "workbooks", new object[0], null, null, null);
		object[] obj2 = new object[1] { text };
		object[] array = obj2;
		bool[] obj3 = new bool[1] { true };
		bool[] array2 = obj3;
		object obj4 = NewLateBinding.LateGet(instance, null, "open", obj2, null, null, obj3);
		if (array2[0])
		{
			text = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
		}
		object objectValue = RuntimeHelpers.GetObjectValue(obj4);
		object objectValue2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, null, "activesheet", new object[0], null, null, null));
		object instance2 = obj;
		NewLateBinding.LateSet(instance2, null, "Visible", new object[1] { true }, null, null);
		NewLateBinding.LateCall(NewLateBinding.LateGet(instance2, null, "cells", new object[2] { 1, 1 }, null, null, null), null, "Select", new object[0], null, null, null, IgnoreReturn: true);
		NewLateBinding.LateCall(NewLateBinding.LateGet(NewLateBinding.LateGet(instance2, null, "Selection", new object[0], null, null, null), null, "EntireRow", new object[0], null, null, null), null, "Delete", new object[0], null, null, null, IgnoreReturn: true);
		NewLateBinding.LateCall(NewLateBinding.LateGet(instance2, null, "cells", new object[2] { 1, 1 }, null, null, null), null, "Select", new object[0], null, null, null, IgnoreReturn: true);
		instance2 = null;
		object instance3 = obj;
		NewLateBinding.LateCall(NewLateBinding.LateGet(instance3, null, "cells", new object[2] { 2, 1 }, null, null, null), null, "Select", new object[0], null, null, null, IgnoreReturn: true);
		checked
		{
			int num = lineas - 1;
			for (int i = 1; i <= num; i++)
			{
				if (Operators.ConditionalCompareObjectNotEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(instance3, null, "activecell", new object[0], null, null, null), null, "value", new object[0], null, null, null), "", TextCompare: true))
				{
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(instance3, null, "activecell", new object[0], null, null, null), null, "Value", new object[1] { Operators.MultiplyObject(NewLateBinding.LateGet(NewLateBinding.LateGet(instance3, null, "activecell", new object[0], null, null, null), null, "Value", new object[0], null, null, null), 1) }, null, null, OptimisticSet: false, RValueBase: true);
					NewLateBinding.LateCall(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(instance3, null, "ActiveCell", new object[0], null, null, null), null, "Offset", new object[2] { 1, 0 }, null, null, null), null, "Range", new object[1] { "A1" }, null, null, null), null, "Select", new object[0], null, null, null, IgnoreReturn: true);
				}
				else
				{
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(instance3, null, "ActiveCell", new object[0], null, null, null), null, "FormulaR1C1", new object[1] { "0" }, null, null, OptimisticSet: false, RValueBase: true);
					NewLateBinding.LateCall(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(instance3, null, "ActiveCell", new object[0], null, null, null), null, "Offset", new object[2] { 1, 0 }, null, null, null), null, "Range", new object[1] { "A1" }, null, null, null), null, "Select", new object[0], null, null, null, IgnoreReturn: true);
				}
			}
			instance3 = null;
		}
	}

	public static void DeleteAFile(object EspecArch)
	{
		int try0001_dispatch = -1;
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
				{
					ProjectData.ClearProjectError();
					num2 = 2;
					object objectValue = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("Scripting.FileSystemObject"));
					object[] obj = new object[1] { EspecArch };
					object[] array = obj;
					bool[] obj2 = new bool[1] { true };
					bool[] array2 = obj2;
					NewLateBinding.LateCall(objectValue, null, "deletefile", obj, null, null, obj2, IgnoreReturn: true);
					if (array2[0])
					{
						EspecArch = RuntimeHelpers.GetObjectValue(array[0]);
					}
					goto end_IL_0001;
				}
				case 108:
					num = -1;
					switch (num2)
					{
					case 2:
						Interaction.MsgBox("No se Puede Borrar");
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj3) when (obj3 is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj3);
				try0001_dispatch = 108;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001:
			break;
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public static void Ver_archivo(object Archivo)
	{
		try
		{
			string text = Conversions.ToString(Operators.ConcatenateObject(AppDomain.CurrentDomain.BaseDirectory ?? "", Archivo));
			object instance = (Microsoft.Office.Interop.Excel.Application)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("00024500-0000-0000-C000-000000000046")));
			object[] array;
			bool[] array2;
			object obj = NewLateBinding.LateGet(NewLateBinding.LateGet(instance, null, "workbooks", new object[0], null, null, null), null, "open", array = new object[1] { text }, null, null, array2 = new bool[1] { true });
			if (array2[0])
			{
				text = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
			}
			object objectValue = RuntimeHelpers.GetObjectValue(obj);
			NewLateBinding.LateSet(instance, null, "visible", new object[1] { true }, null, null);
			objectValue = null;
			instance = null;
			text = null;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox(ex2.Message, MsgBoxStyle.Critical, "Error");
			ProjectData.ClearProjectError();
		}
	}

	public static void importar_test()
	{
		MyProject.Forms.Form1_Inicio.DateTimePicker1.Format = DateTimePickerFormat.Short;
		DateTime dateTime = Conversions.ToDate(MyProject.Forms.Form1_Inicio.DateTimePicker1.Text);
		OleDbConnection oleDbConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source='Temp.xls'; Extended Properties=Excel 8.0;");
		OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("select * from [Planchada$]", oleDbConnection);
		DataTable dataTable = new DataTable();
		oleDbDataAdapter.Fill(dataTable);
		oleDbConnection.Close();
		dataTable.Columns["Cte# Eventual Dest#"].SetOrdinal(0);
		dataTable.Columns["Nº Comprobante"].SetOrdinal(1);
		dataTable.Columns["Razón Social Cliente"].SetOrdinal(2);
		dataTable.Columns["Números de Remitos"].SetOrdinal(3);
		dataTable.Columns["Razon Social Ent/Ret"].SetOrdinal(4);
		dataTable.Columns["Domicilio Cliente"].SetOrdinal(5);
		dataTable.Columns["Cód# Loc# Final"].SetOrdinal(6);
		dataTable.Columns["Localidad Destino"].SetOrdinal(7);
		dataTable.Columns["Imp# Val# Declarado"].SetOrdinal(8);
		dataTable.Columns["Tot# Bultos"].SetOrdinal(9);
		dataTable.Columns["Tot# Kilos"].SetOrdinal(10);
		dataTable.Columns["Sub"].SetOrdinal(11);
		dataTable.Columns["Observaciones"].SetOrdinal(12);
		dataTable.Columns["Tot# MT3"].SetOrdinal(13);
		dataTable.Columns["Dias Atraso Dif#"].SetOrdinal(14);
		dataTable.Columns["Diferida al"].SetOrdinal(15);
		dataTable.Columns["Imp# Flete"].SetOrdinal(16);
		MyProject.Forms.Loading.Show();
		MyProject.Forms.Loading.Refresh();
		MyProject.Forms.Loading.ProgressBar1.Maximum = dataTable.Rows.Count;
		checked
		{
			try
			{
				int num = dataTable.Rows.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					string sQL = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("INSERT INTO Planchada(Eventual, Comprobante, Cliente, Remitos, Destino, Domicilio, CP, Localidad, Declarado, Bultos, Kilos, Sub, Observaciones, Volumen, Atraso, Diferida, Flete, Zona, Adicional, Prioridad, Chofer, Latitud, Longitud, Estado, Fecha, Ventana, Usuario) VALUES (", dataTable.Rows[i][0]), ", "), dataTable.Rows[i][1]), ",'"), dataTable.Rows[i][2]), "','"), dataTable.Rows[i][3]), "','"), dataTable.Rows[i][4]), "','"), Strings.Replace(Conversions.ToString(dataTable.Rows[i][5]), "'", " ", 1, -1, CompareMethod.Text)), "','"), dataTable.Rows[i][6]), "','"), dataTable.Rows[i][7]), "',"), Strings.Replace(Conversions.ToString(dataTable.Rows[i][8]), ",", ".", 1, -1, CompareMethod.Text)), ","), dataTable.Rows[i][9]), ","), Strings.Replace(Conversions.ToString(dataTable.Rows[i][10]), ",", ".", 1, -1, CompareMethod.Text)), ",'"), dataTable.Rows[i][11]), "','"), dataTable.Rows[i][12]), "',"), Strings.Replace(Conversions.ToString(dataTable.Rows[i][13]), ",", ".", 1, -1, CompareMethod.Text)), ","), dataTable.Rows[i][14]), ",'"), dataTable.Rows[i][15]), "',"), Strings.Replace(Conversions.ToString(dataTable.Rows[i][16]), ",", ".", 1, -1, CompareMethod.Text)), ",0,0,0,0,0,0,'En Planchada','"), Strings.Format(MyProject.Forms.Form1_Inicio.DateTimePicker1.Value, "yyyy/MM/dd")), "', 0,'"), MyProject.Forms.Form1_Inicio.nombreusuario.Text), "')"));
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
	}
}
