using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;
using Newtonsoft.Json.Linq;

namespace Hermes;

[DesignerGenerated]
public class ImportarOrdenes : Form
{
	public delegate void SetTextCallback(int id, string texto);

	private struct ResponseFromExcelToOrder
	{
		public bool status;

		public Mod_Ordenes.OrdenAIngresar orden;
	}

	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ComboBox1")]
	private ComboBox _ComboBox1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button3")]
	private Button _Button3;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button5")]
	private Button _Button5;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("TestWorker")]
	private BackgroundWorker _TestWorker;

	private DataTable datosExcel;

	[field: AccessedThroughProperty("GroupBox1")]
	internal virtual GroupBox GroupBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Button1
	{
		[CompilerGenerated]
		get
		{
			return _Button1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button1_Click;
			Button button = _Button1;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button1 = value;
			button = _Button1;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button2
	{
		[CompilerGenerated]
		get
		{
			return _Button2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button2_Click;
			Button button = _Button2;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button2 = value;
			button = _Button2;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("GroupBox2")]
	internal virtual GroupBox GroupBox2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label4")]
	internal virtual Label Label4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label6")]
	internal virtual Label Label6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label5")]
	internal virtual Label Label5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label8")]
	internal virtual Label Label8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label7")]
	internal virtual Label Label7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label10")]
	internal virtual Label Label10
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label9")]
	internal virtual Label Label9
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ListView1")]
	internal virtual ListView ListView1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label11")]
	internal virtual Label Label11
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ComboBox ComboBox1
	{
		[CompilerGenerated]
		get
		{
			return _ComboBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ComboBox1_SelectionChangeCommitted;
			ComboBox comboBox = _ComboBox1;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value2;
			}
			_ComboBox1 = value;
			comboBox = _ComboBox1;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value2;
			}
		}
	}

	[field: AccessedThroughProperty("ColumnHeader1")]
	internal virtual ColumnHeader ColumnHeader1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ColumnHeader2")]
	internal virtual ColumnHeader ColumnHeader2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ColumnHeader3")]
	internal virtual ColumnHeader ColumnHeader3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ColumnHeader4")]
	internal virtual ColumnHeader ColumnHeader4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ColumnHeader5")]
	internal virtual ColumnHeader ColumnHeader5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ColumnHeader6")]
	internal virtual ColumnHeader ColumnHeader6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ColumnHeader7")]
	internal virtual ColumnHeader ColumnHeader7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Button3
	{
		[CompilerGenerated]
		get
		{
			return _Button3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button3_Click;
			Button button = _Button3;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button3 = value;
			button = _Button3;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label12")]
	internal virtual Label Label12
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Button4")]
	internal virtual Button Button4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Button5
	{
		[CompilerGenerated]
		get
		{
			return _Button5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button5_Click;
			Button button = _Button5;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button5 = value;
			button = _Button5;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	private virtual BackgroundWorker TestWorker
	{
		[CompilerGenerated]
		get
		{
			return _TestWorker;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			DoWorkEventHandler value2 = TestWorker_DoWork;
			ProgressChangedEventHandler value3 = TestWorker_ProgressChanged;
			RunWorkerCompletedEventHandler value4 = TestWorker_RunWorkerCompleted;
			BackgroundWorker testWorker = _TestWorker;
			if (testWorker != null)
			{
				testWorker.DoWork -= value2;
				testWorker.ProgressChanged -= value3;
				testWorker.RunWorkerCompleted -= value4;
			}
			_TestWorker = value;
			testWorker = _TestWorker;
			if (testWorker != null)
			{
				testWorker.DoWork += value2;
				testWorker.ProgressChanged += value3;
				testWorker.RunWorkerCompleted += value4;
			}
		}
	}

	public ImportarOrdenes()
	{
		base.Load += ImportarOrdenes_Load;
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			base.Dispose(disposing);
		}
	}

	[System.Diagnostics.DebuggerStepThrough]
	private void InitializeComponent()
	{
		this.GroupBox1 = new System.Windows.Forms.GroupBox();
		this.Label12 = new System.Windows.Forms.Label();
		this.Label11 = new System.Windows.Forms.Label();
		this.ComboBox1 = new System.Windows.Forms.ComboBox();
		this.Label10 = new System.Windows.Forms.Label();
		this.Label9 = new System.Windows.Forms.Label();
		this.Label2 = new System.Windows.Forms.Label();
		this.Label1 = new System.Windows.Forms.Label();
		this.Button1 = new System.Windows.Forms.Button();
		this.Button2 = new System.Windows.Forms.Button();
		this.GroupBox2 = new System.Windows.Forms.GroupBox();
		this.Label8 = new System.Windows.Forms.Label();
		this.Label7 = new System.Windows.Forms.Label();
		this.Label6 = new System.Windows.Forms.Label();
		this.Label5 = new System.Windows.Forms.Label();
		this.Label4 = new System.Windows.Forms.Label();
		this.Label3 = new System.Windows.Forms.Label();
		this.ListView1 = new System.Windows.Forms.ListView();
		this.ColumnHeader1 = new System.Windows.Forms.ColumnHeader();
		this.ColumnHeader2 = new System.Windows.Forms.ColumnHeader();
		this.ColumnHeader3 = new System.Windows.Forms.ColumnHeader();
		this.ColumnHeader4 = new System.Windows.Forms.ColumnHeader();
		this.ColumnHeader5 = new System.Windows.Forms.ColumnHeader();
		this.ColumnHeader6 = new System.Windows.Forms.ColumnHeader();
		this.ColumnHeader7 = new System.Windows.Forms.ColumnHeader();
		this.Button3 = new System.Windows.Forms.Button();
		this.Button4 = new System.Windows.Forms.Button();
		this.Button5 = new System.Windows.Forms.Button();
		this.GroupBox1.SuspendLayout();
		this.GroupBox2.SuspendLayout();
		base.SuspendLayout();
		this.GroupBox1.Controls.Add(this.Label12);
		this.GroupBox1.Controls.Add(this.Label11);
		this.GroupBox1.Controls.Add(this.ComboBox1);
		this.GroupBox1.Controls.Add(this.Label10);
		this.GroupBox1.Controls.Add(this.Label9);
		this.GroupBox1.Controls.Add(this.Label2);
		this.GroupBox1.Controls.Add(this.Label1);
		this.GroupBox1.Controls.Add(this.Button1);
		this.GroupBox1.Location = new System.Drawing.Point(12, 12);
		this.GroupBox1.Name = "GroupBox1";
		this.GroupBox1.Size = new System.Drawing.Size(534, 105);
		this.GroupBox1.TabIndex = 0;
		this.GroupBox1.TabStop = false;
		this.GroupBox1.Text = "Archivo";
		this.Label12.AutoSize = true;
		this.Label12.Location = new System.Drawing.Point(457, 58);
		this.Label12.Name = "Label12";
		this.Label12.Size = new System.Drawing.Size(45, 13);
		this.Label12.TabIndex = 7;
		this.Label12.Text = "Label12";
		this.Label11.AutoSize = true;
		this.Label11.Location = new System.Drawing.Point(43, 23);
		this.Label11.Name = "Label11";
		this.Label11.Size = new System.Drawing.Size(54, 13);
		this.Label11.TabIndex = 6;
		this.Label11.Text = "Empresa :";
		this.ComboBox1.FormattingEnabled = true;
		this.ComboBox1.Location = new System.Drawing.Point(137, 20);
		this.ComboBox1.Name = "ComboBox1";
		this.ComboBox1.Size = new System.Drawing.Size(365, 21);
		this.ComboBox1.TabIndex = 5;
		this.Label10.AutoSize = true;
		this.Label10.Location = new System.Drawing.Point(112, 84);
		this.Label10.Name = "Label10";
		this.Label10.Size = new System.Drawing.Size(86, 13);
		this.Label10.TabIndex = 4;
		this.Label10.Text = "Ruta al Archivo :";
		this.Label9.AutoSize = true;
		this.Label9.Location = new System.Drawing.Point(112, 58);
		this.Label9.Name = "Label9";
		this.Label9.Size = new System.Drawing.Size(104, 13);
		this.Label9.TabIndex = 3;
		this.Label9.Text = "Nombre de Archivo :";
		this.Label2.AutoSize = true;
		this.Label2.Location = new System.Drawing.Point(222, 58);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(39, 13);
		this.Label2.TabIndex = 2;
		this.Label2.Text = "Label2";
		this.Label1.AutoSize = true;
		this.Label1.Location = new System.Drawing.Point(222, 84);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(39, 13);
		this.Label1.TabIndex = 1;
		this.Label1.Text = "Label1";
		this.Button1.Location = new System.Drawing.Point(22, 65);
		this.Button1.Name = "Button1";
		this.Button1.Size = new System.Drawing.Size(75, 23);
		this.Button1.TabIndex = 1;
		this.Button1.Text = "Seleccionar";
		this.Button1.UseVisualStyleBackColor = true;
		this.Button2.Location = new System.Drawing.Point(12, 123);
		this.Button2.Name = "Button2";
		this.Button2.Size = new System.Drawing.Size(97, 27);
		this.Button2.TabIndex = 1;
		this.Button2.Text = "Leer Archivo";
		this.Button2.UseVisualStyleBackColor = true;
		this.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.GroupBox2.Controls.Add(this.Label8);
		this.GroupBox2.Controls.Add(this.Label7);
		this.GroupBox2.Controls.Add(this.Label6);
		this.GroupBox2.Controls.Add(this.Label5);
		this.GroupBox2.Controls.Add(this.Label4);
		this.GroupBox2.Controls.Add(this.Label3);
		this.GroupBox2.Location = new System.Drawing.Point(552, 12);
		this.GroupBox2.Name = "GroupBox2";
		this.GroupBox2.Size = new System.Drawing.Size(243, 105);
		this.GroupBox2.TabIndex = 2;
		this.GroupBox2.TabStop = false;
		this.GroupBox2.Text = "Informes";
		this.Label8.AutoSize = true;
		this.Label8.Location = new System.Drawing.Point(144, 23);
		this.Label8.Name = "Label8";
		this.Label8.Size = new System.Drawing.Size(13, 13);
		this.Label8.TabIndex = 5;
		this.Label8.Text = "0";
		this.Label7.AutoSize = true;
		this.Label7.Location = new System.Drawing.Point(16, 23);
		this.Label7.Name = "Label7";
		this.Label7.Size = new System.Drawing.Size(102, 13);
		this.Label7.TabIndex = 4;
		this.Label7.Text = "Lineas procesadas :";
		this.Label6.AutoSize = true;
		this.Label6.Location = new System.Drawing.Point(144, 75);
		this.Label6.Name = "Label6";
		this.Label6.Size = new System.Drawing.Size(13, 13);
		this.Label6.TabIndex = 3;
		this.Label6.Text = "0";
		this.Label5.AutoSize = true;
		this.Label5.Location = new System.Drawing.Point(16, 75);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(122, 13);
		this.Label5.TabIndex = 2;
		this.Label5.Text = "Depositos encontrados :";
		this.Label4.AutoSize = true;
		this.Label4.Location = new System.Drawing.Point(144, 49);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(13, 13);
		this.Label4.TabIndex = 1;
		this.Label4.Text = "0";
		this.Label3.AutoSize = true;
		this.Label3.Location = new System.Drawing.Point(16, 49);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(113, 13);
		this.Label3.TabIndex = 0;
		this.Label3.Text = "Remitos encontrados :";
		this.ListView1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.ListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[7] { this.ColumnHeader1, this.ColumnHeader2, this.ColumnHeader3, this.ColumnHeader4, this.ColumnHeader5, this.ColumnHeader6, this.ColumnHeader7 });
		this.ListView1.FullRowSelect = true;
		this.ListView1.GridLines = true;
		this.ListView1.Location = new System.Drawing.Point(12, 156);
		this.ListView1.Name = "ListView1";
		this.ListView1.Size = new System.Drawing.Size(783, 268);
		this.ListView1.TabIndex = 3;
		this.ListView1.UseCompatibleStateImageBehavior = false;
		this.ListView1.View = System.Windows.Forms.View.Details;
		this.ColumnHeader1.Text = "Id";
		this.ColumnHeader1.Width = 29;
		this.ColumnHeader2.Text = "Empresa";
		this.ColumnHeader2.Width = 69;
		this.ColumnHeader3.Text = "Tipo";
		this.ColumnHeader3.Width = 35;
		this.ColumnHeader4.Text = "Numero";
		this.ColumnHeader4.Width = 98;
		this.ColumnHeader5.Text = "Destino";
		this.ColumnHeader5.Width = 166;
		this.ColumnHeader6.Text = "Valor";
		this.ColumnHeader6.Width = 86;
		this.ColumnHeader7.Text = "Estado";
		this.ColumnHeader7.Width = 461;
		this.Button3.Location = new System.Drawing.Point(115, 123);
		this.Button3.Name = "Button3";
		this.Button3.Size = new System.Drawing.Size(97, 27);
		this.Button3.TabIndex = 4;
		this.Button3.Text = "Procesar";
		this.Button3.UseVisualStyleBackColor = true;
		this.Button4.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.Button4.Location = new System.Drawing.Point(720, 127);
		this.Button4.Name = "Button4";
		this.Button4.Size = new System.Drawing.Size(75, 23);
		this.Button4.TabIndex = 5;
		this.Button4.Text = "Eportar";
		this.Button4.UseVisualStyleBackColor = true;
		this.Button5.Enabled = false;
		this.Button5.Location = new System.Drawing.Point(218, 123);
		this.Button5.Name = "Button5";
		this.Button5.Size = new System.Drawing.Size(95, 27);
		this.Button5.TabIndex = 6;
		this.Button5.Text = "Cancelar";
		this.Button5.UseVisualStyleBackColor = true;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(807, 436);
		base.Controls.Add(this.Button5);
		base.Controls.Add(this.Button4);
		base.Controls.Add(this.Button3);
		base.Controls.Add(this.ListView1);
		base.Controls.Add(this.GroupBox2);
		base.Controls.Add(this.Button2);
		base.Controls.Add(this.GroupBox1);
		base.Name = "ImportarOrdenes";
		this.Text = "ImportarOrdenes";
		this.GroupBox1.ResumeLayout(false);
		this.GroupBox1.PerformLayout();
		this.GroupBox2.ResumeLayout(false);
		this.GroupBox2.PerformLayout();
		base.ResumeLayout(false);
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		try
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			OpenFileDialog openFileDialog2 = openFileDialog;
			openFileDialog2.Filter = "Soported files(*.xls, *.xlsx)|*.xls;*.xlsx;";
			openFileDialog2.FilterIndex = 1;
			openFileDialog2.Title = "Import data from Excel file";
			openFileDialog2 = null;
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				string fileName = openFileDialog.FileName;
				Label1.Text = fileName;
				int num = fileName.LastIndexOf('\\');
				string text = fileName.Substring(checked(num + 1));
				Label2.Text = text;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox(ex2.Message);
			Logger.e(ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		ListView1.Items.Clear();
		Label4.Text = "0";
		Label6.Text = "0";
		Label8.Text = "0";
		checked
		{
			try
			{
				datosExcel = (DataTable)Mod_excelReader.ExcelReader(Label2.Text, Label1.Text);
				int count = datosExcel.Rows.Count;
				int count2 = datosExcel.AsDataView().ToTable(true, "Comprobante").Rows.Count;
				int count3 = datosExcel.AsDataView().ToTable(true, "Depósito Origen").Rows.Count;
				string empty = string.Empty;
				int num = 1;
				foreach (object row in datosExcel.AsDataView().ToTable(true, "Comprobante").Rows)
				{
					object objectValue = RuntimeHelpers.GetObjectValue(row);
					ListViewItem listViewItem = new ListViewItem(Conversions.ToString(num));
					empty = Conversions.ToString(NewLateBinding.LateIndexGet(objectValue, new object[1] { "Comprobante" }, null));
					listViewItem.SubItems.Add(ComboBox1.Text);
					listViewItem.SubItems.Add("REMITO");
					listViewItem.SubItems.Add(empty);
					decimal num2 = default(decimal);
					string filterExpression = "Comprobante = '" + empty + "'";
					DataRow[] array = datosExcel.Select(filterExpression);
					int num3 = array.Count() - 1;
					for (int i = 0; i <= num3; i++)
					{
						if (i == 0)
						{
							ListViewItem.ListViewSubItemCollection subItems = listViewItem.SubItems;
							DataRow dataRow;
							object[] obj = new object[1] { (dataRow = array[0])["Cliente"] };
							object[] array2 = obj;
							bool[] obj2 = new bool[1] { true };
							bool[] array3 = obj2;
							NewLateBinding.LateCall(subItems, null, "Add", obj, null, null, obj2, IgnoreReturn: true);
							if (array3[0])
							{
								dataRow["Cliente"] = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array2[0]));
							}
						}
						string s = Conversions.ToString(array[i]["Importe"]);
						num2 = decimal.Add(num2, decimal.Parse(s));
					}
					listViewItem.SubItems.Add(Conversions.ToString(num2));
					switch (Conversions.ToInteger(Mod_Ordenes.CheckNumeroOrden(empty, Conversions.ToInteger(Label12.Text))))
					{
					case 0:
						listViewItem.SubItems.Add("ERROR 1");
						break;
					case 1:
						listViewItem.SubItems.Add("LA ORDEN YA FUE INGRESADA");
						break;
					case 2:
						listViewItem.SubItems.Add("OK");
						break;
					case 3:
						listViewItem.SubItems.Add("ERROR 2");
						break;
					}
					ListView1.Items.Add(listViewItem);
					num++;
				}
				Label4.Text = Conversions.ToString(count2);
				Label6.Text = Conversions.ToString(count3);
				Label8.Text = Conversions.ToString(count);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Logger.e("Mensage: " + ex2.Message.ToString());
				ProjectData.ClearProjectError();
			}
		}
	}

	private void ImportarOrdenes_Load(object sender, EventArgs e)
	{
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		Control.CheckForIllegalCrossThreadCalls = false;
		Label2.Text = "";
		Label1.Text = "";
		Label12.Text = "";
		string text = "SELECT  Nombre, id FROM empresas WHERE estado = 1 AND tipo = 1 ORDER BY nombre ASC";
		try
		{
			DataTable dataTable = new DataTable("x");
			MySqlDataAdapter val = new MySqlDataAdapter(text, Mod_Sentencias.cnn);
			((DbDataAdapter)(object)val).Fill(dataTable);
			if (dataTable.Rows.Count > 0)
			{
				ComboBox1.SelectedIndex = -1;
				Dictionary<string, string> dictionary = new Dictionary<string, string>();
				foreach (DataRow row in dataTable.Rows)
				{
					dictionary.Add(row[1].ToString(), Conversions.ToString(row[0]));
				}
				ComboBox1.DataSource = new BindingSource(dictionary, null);
				ComboBox1.DisplayMember = "Value";
				ComboBox1.ValueMember = "Key";
				ComboBox1.SelectedIndex = -1;
			}
			else
			{
				ComboBox1.DataSource = null;
				ComboBox1.Items.Clear();
				ComboBox1.SelectedIndex = -1;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox("Ocurrio un error al recuperar datos. " + ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void ComboBox1_SelectionChangeCommitted(object sender, EventArgs e)
	{
		Label12.Text = Conversions.ToString(ComboBox1.SelectedValue);
	}

	private void Button3_Click(object sender, EventArgs e)
	{
		Button3.Enabled = false;
		Button5.Enabled = true;
		TestWorker = new BackgroundWorker();
		TestWorker.WorkerReportsProgress = true;
		TestWorker.WorkerSupportsCancellation = true;
		TestWorker.RunWorkerAsync();
	}

	private object ResultDataExcel(string comprobante, decimal valor)
	{
		string number = Strings.Right(comprobante, 8);
		Mod_Ordenes.OrdenCompleta ordenCompleta = default(Mod_Ordenes.OrdenCompleta);
		Mod_Ordenes.Addressee addressee = default(Mod_Ordenes.Addressee);
		Mod_Ordenes.OrderItems items = default(Mod_Ordenes.OrderItems);
		List<Mod_Ordenes.OrderItem> list = new List<Mod_Ordenes.OrderItem>();
		Mod_Ordenes.OrderItem item = default(Mod_Ordenes.OrderItem);
		checked
		{
			try
			{
				ordenCompleta.doc = "REMITO";
				ordenCompleta.number = number;
				string filterExpression = "Comprobante = '" + comprobante + "'";
				DataRow[] array = datosExcel.Select(filterExpression);
				if (array.Count() > 0)
				{
					items.totalitems = array.Count();
					int num = array.Count() - 1;
					for (int i = 0; i <= num; i++)
					{
						if (i == 0)
						{
							addressee.name = Conversions.ToString(array[0]["Cliente"]);
							addressee.address = Conversions.ToString(array[0]["Direccion"]);
							addressee.postal = Conversions.ToString(array[0]["Prov# destino"]);
							ordenCompleta.addressee = addressee;
							ordenCompleta.ctr = Conversions.ToString(0);
							if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(array[0]["Descripción"])))
							{
								ordenCompleta.note = "";
							}
							else
							{
								ordenCompleta.note = Conversions.ToString(array[0]["Descripción"]);
							}
							ordenCompleta.value = Conversions.ToString(valor);
						}
						string codeEmpresa = array[i][9].ToString();
						Console.WriteLine(RuntimeHelpers.GetObjectValue(array[i][9]));
						string unidades = Conversions.ToString(array[i]["Cantidad"]);
						string barrcode = Conversions.ToString(Mod_Productos.GetBarrCodewithCodeEmpresa(codeEmpresa, Conversions.ToInteger(Label12.Text)));
						item.barrcode = barrcode;
						item.unidades = unidades;
						list.Add(item);
					}
					items.list = list;
					ordenCompleta.items = items;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Logger.e("ImportarOrdenes: " + ex2.Message);
				Logger.e(ex2.StackTrace);
				ProjectData.ClearProjectError();
			}
			return ordenCompleta;
		}
	}

	private void CrearOrdenThread(object data)
	{
		string texto = string.Empty;
		try
		{
			Console.WriteLine(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Inicio: ", NewLateBinding.LateGet(data, null, "id", new object[0], null, null, null)), " - "), DateTime.Now.ToString()));
			string requestUriString = "https://api.area54sa.com.ar/";
			WebRequest webRequest = WebRequest.Create(requestUriString);
			webRequest.Timeout = 300000;
			webRequest.Proxy = null;
			webRequest.Method = "POST";
			byte[] bytes = Encoding.UTF8.GetBytes(NewLateBinding.LateGet(data, null, "json", new object[0], null, null, null).ToString());
			webRequest.ContentType = "application/json";
			webRequest.ContentLength = bytes.Length;
			Stream requestStream = webRequest.GetRequestStream();
			requestStream.Write(bytes, 0, bytes.Length);
			requestStream.Close();
			WebResponse response = webRequest.GetResponse();
			string statusDescription = ((HttpWebResponse)response).StatusDescription;
			requestStream = response.GetResponseStream();
			StreamReader streamReader = new StreamReader(requestStream);
			string text = streamReader.ReadToEnd();
			streamReader.Close();
			requestStream.Close();
			response.Close();
			JObject val = JObject.Parse(text);
			int num = (int)val["status"];
			texto = ((num != 200) ? ((string)val["msg"]) : ((string)val["msg"]));
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox(ex2.Message);
			Logger.e(ex2.Message);
			Logger.e(ex2.StackTrace);
			int num = 0;
			ProjectData.ClearProjectError();
		}
		Console.WriteLine(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Fin: ", NewLateBinding.LateGet(data, null, "id", new object[0], null, null, null)), " - "), DateTime.Now.ToString()));
		updateStatusListview(Conversions.ToInteger(NewLateBinding.LateGet(data, null, "id", new object[0], null, null, null)), texto);
	}

	private void TestWorker_DoWork(object sender, DoWorkEventArgs e)
	{
		//IL_0200: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Expected O, but got Unknown
		string sql = "SELECT id, password FROM empresas WHERE id = " + Label12.Text + " limit 1";
		DataTable dataTable = (DataTable)Mod_Sentencias.data(sql);
		List<Thread> list = new List<Thread>();
		checked
		{
			if (dataTable.Rows.Count == 1)
			{
				if (ListView1.Items.Count > 0)
				{
					int num = ListView1.Items.Count - 1;
					for (int i = 0; i <= num; i++)
					{
						if (Operators.CompareString(ListView1.Items[i].SubItems[6].Text, "OK", TextCompare: true) != 0)
						{
							continue;
						}
						if (TestWorker.CancellationPending)
						{
							int num2 = list.Count - 1;
							for (int j = 0; j <= num2; j++)
							{
								list[j].Abort();
							}
							break;
						}
						ListView1.Items[i].SubItems[6].Text = "PROCESANDO";
						Mod_Ordenes.NuevaOrdenCompleta estructura = default(Mod_Ordenes.NuevaOrdenCompleta);
						estructura.action = "new";
						estructura.user = Conversions.ToInteger(Label12.Text);
						estructura.token = Conversions.ToString(Mod_api_ordenes.LoginApi(Conversions.ToString(dataTable.Rows[0]["id"]), Conversions.ToString(dataTable.Rows[0]["password"])));
						object obj = ResultDataExcel(ListView1.Items[i].SubItems[3].Text, Conversions.ToDecimal(ListView1.Items[i].SubItems[5].Text));
						estructura.order = ((obj != null) ? ((Mod_Ordenes.OrdenCompleta)obj) : default(Mod_Ordenes.OrdenCompleta));
						JObject json = (JObject)Mod_api_ordenes.StructureToJson(estructura);
						ObjetoSimpleClass objetoSimpleClass = new ObjetoSimpleClass();
						objetoSimpleClass.id = i;
						objetoSimpleClass.json = json;
						Thread thread = new Thread(CrearOrdenThread);
						thread.Start(objetoSimpleClass);
						list.Add(thread);
					}
				}
				else
				{
					Interaction.MsgBox("Debes Leer el archivo antes de Procesarlo.");
				}
			}
			else
			{
				Interaction.MsgBox("Error al obtener credenciales para la empresa");
			}
		}
	}

	private void Button5_Click(object sender, EventArgs e)
	{
		TestWorker.CancelAsync();
	}

	private void TestWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
	{
	}

	private void TestWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
	{
		Button3.Enabled = true;
		Button5.Enabled = false;
	}

	private void updateStatusListview(int id, string texto)
	{
		if (ListView1.InvokeRequired)
		{
			SetTextCallback method = updateStatusListview;
			Invoke(method, id, texto);
		}
		else
		{
			ListView1.Items[id].SubItems[6].Text = texto;
		}
	}

	private object ExcelToOrder(int indice, int empresa, string comprobante, decimal valor)
	{
		ResponseFromExcelToOrder responseFromExcelToOrder = default(ResponseFromExcelToOrder);
		responseFromExcelToOrder.status = false;
		string text = Strings.Right(comprobante, 8);
		Mod_Ordenes.OrdenAIngresar orden = default(Mod_Ordenes.OrdenAIngresar);
		Mod_Ordenes.EventualDestino eventual = default(Mod_Ordenes.EventualDestino);
		Mod_Ordenes.ListaProductosSolicitados productos = default(Mod_Ordenes.ListaProductosSolicitados);
		List<Mod_Ordenes.ProductoSolicitado> list = new List<Mod_Ordenes.ProductoSolicitado>();
		Mod_Ordenes.ProductoSolicitado productoSolicitado = default(Mod_Ordenes.ProductoSolicitado);
		checked
		{
			try
			{
				orden.empresa = empresa;
				orden.tipo = 1;
				orden.numero = text;
				string filterExpression = "Comprobante = '" + comprobante + "'";
				DataRow[] array = datosExcel.Select(filterExpression);
				if (array.Count() > 0)
				{
					productos.totalProductos = array.Count();
					int num = array.Count() - 1;
					for (int i = 0; i <= num; i++)
					{
						if (i == 0)
						{
							eventual.nombre = Conversions.ToString(array[0]["Cliente"]);
							eventual.direccion = Conversions.ToString(array[0]["Direccion"]);
							orden.eventual = eventual;
							orden.contraReembolso = default(decimal);
							if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(array[0]["Descripción"])))
							{
								orden.observaciones = "";
							}
							else
							{
								orden.observaciones = Conversions.ToString(array[0]["Descripción"]);
							}
							orden.valor = valor;
						}
						string text2 = array[i]["Cod# Producto"].ToString();
						string value = Conversions.ToString(array[i]["Cantidad"]);
						object productWithCodeEmpresa = Mod_Productos.GetProductWithCodeEmpresa(text2, empresa);
						Mod_Productos.Respuesta respuesta = ((productWithCodeEmpresa != null) ? ((Mod_Productos.Respuesta)productWithCodeEmpresa) : default(Mod_Productos.Respuesta));
						if (!respuesta.status)
						{
							updateStatusListview(indice, " No se encontro el producto especificado: " + text2);
							Logger.e("ImportarOrdenes: " + text + " No se encontro el producto especificado: " + text2);
							return responseFromExcelToOrder;
						}
						productoSolicitado = respuesta.producto;
						productoSolicitado.unidadesSolicitadas = Conversions.ToInteger(value);
						list.Add(productoSolicitado);
					}
					productos.listaProductos = list;
					orden.productos = productos;
					updateStatusListview(indice, "FINALIZADO");
					responseFromExcelToOrder.status = true;
					responseFromExcelToOrder.orden = orden;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Logger.e("ImportarOrdenes: " + ex2.Message);
				Logger.e(ex2.StackTrace);
				ProjectData.ClearProjectError();
			}
			return responseFromExcelToOrder;
		}
	}

	private object InsertNewOrder(Mod_Ordenes.OrdenAIngresar orden)
	{
		return true;
	}
}
