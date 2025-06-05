using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace Hermes;

[DesignerGenerated]
public class Disponibilidad : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ListView1")]
	private ListView _ListView1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ListView2")]
	private ListView _ListView2;

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
	[AccessedThroughProperty("Button3")]
	private Button _Button3;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button4")]
	private Button _Button4;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button7")]
	private Button _Button7;

	[field: AccessedThroughProperty("GroupBox1")]
	internal virtual GroupBox GroupBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("disponiblestxt")]
	internal virtual Label disponiblestxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("disponibleslbl")]
	internal virtual Label disponibleslbl
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ListView ListView1
	{
		[CompilerGenerated]
		get
		{
			return _ListView1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			ColumnClickEventHandler value2 = ListView1_ColumnClick;
			EventHandler value3 = ListView1_SelectedIndexChanged;
			ListView listView = _ListView1;
			if (listView != null)
			{
				listView.ColumnClick -= value2;
				listView.SelectedIndexChanged -= value3;
			}
			_ListView1 = value;
			listView = _ListView1;
			if (listView != null)
			{
				listView.ColumnClick += value2;
				listView.SelectedIndexChanged += value3;
			}
		}
	}

	[field: AccessedThroughProperty("GroupBox2")]
	internal virtual GroupBox GroupBox2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("vehiculostxt")]
	internal virtual Label vehiculostxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("vehiculoslbl")]
	internal virtual Label vehiculoslbl
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ListView ListView2
	{
		[CompilerGenerated]
		get
		{
			return _ListView2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			ColumnClickEventHandler value2 = ListView2_ColumnClick;
			EventHandler value3 = ListView2_SelectedIndexChanged;
			ListView listView = _ListView2;
			if (listView != null)
			{
				listView.ColumnClick -= value2;
				listView.SelectedIndexChanged -= value3;
			}
			_ListView2 = value;
			listView = _ListView2;
			if (listView != null)
			{
				listView.ColumnClick += value2;
				listView.SelectedIndexChanged += value3;
			}
		}
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

	internal virtual Button Button4
	{
		[CompilerGenerated]
		get
		{
			return _Button4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button4_Click;
			Button button = _Button4;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button4 = value;
			button = _Button4;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Button5")]
	internal virtual Button Button5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Button6")]
	internal virtual Button Button6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Button7
	{
		[CompilerGenerated]
		get
		{
			return _Button7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button7_Click;
			Button button = _Button7;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button7 = value;
			button = _Button7;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public Disponibilidad()
	{
		base.Load += Disponibilidad_Load;
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
		this.disponiblestxt = new System.Windows.Forms.Label();
		this.disponibleslbl = new System.Windows.Forms.Label();
		this.ListView1 = new System.Windows.Forms.ListView();
		this.GroupBox2 = new System.Windows.Forms.GroupBox();
		this.vehiculostxt = new System.Windows.Forms.Label();
		this.vehiculoslbl = new System.Windows.Forms.Label();
		this.ListView2 = new System.Windows.Forms.ListView();
		this.Button1 = new System.Windows.Forms.Button();
		this.Button2 = new System.Windows.Forms.Button();
		this.Button3 = new System.Windows.Forms.Button();
		this.Button4 = new System.Windows.Forms.Button();
		this.Button5 = new System.Windows.Forms.Button();
		this.Button6 = new System.Windows.Forms.Button();
		this.Button7 = new System.Windows.Forms.Button();
		this.Label1 = new System.Windows.Forms.Label();
		this.GroupBox1.SuspendLayout();
		this.GroupBox2.SuspendLayout();
		base.SuspendLayout();
		this.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.GroupBox1.Controls.Add(this.disponiblestxt);
		this.GroupBox1.Controls.Add(this.disponibleslbl);
		this.GroupBox1.Controls.Add(this.ListView1);
		this.GroupBox1.Location = new System.Drawing.Point(12, 12);
		this.GroupBox1.Name = "GroupBox1";
		this.GroupBox1.Size = new System.Drawing.Size(318, 425);
		this.GroupBox1.TabIndex = 0;
		this.GroupBox1.TabStop = false;
		this.disponiblestxt.AutoSize = true;
		this.disponiblestxt.Location = new System.Drawing.Point(76, 30);
		this.disponiblestxt.Name = "disponiblestxt";
		this.disponiblestxt.Size = new System.Drawing.Size(13, 13);
		this.disponiblestxt.TabIndex = 2;
		this.disponiblestxt.Text = "0";
		this.disponibleslbl.AutoSize = true;
		this.disponibleslbl.Location = new System.Drawing.Point(6, 30);
		this.disponibleslbl.Name = "disponibleslbl";
		this.disponibleslbl.Size = new System.Drawing.Size(64, 13);
		this.disponibleslbl.TabIndex = 1;
		this.disponibleslbl.Text = "Disponibles:";
		this.ListView1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.ListView1.Location = new System.Drawing.Point(6, 61);
		this.ListView1.Name = "ListView1";
		this.ListView1.Size = new System.Drawing.Size(306, 358);
		this.ListView1.TabIndex = 0;
		this.ListView1.UseCompatibleStateImageBehavior = false;
		this.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		this.GroupBox2.Controls.Add(this.vehiculostxt);
		this.GroupBox2.Controls.Add(this.vehiculoslbl);
		this.GroupBox2.Controls.Add(this.ListView2);
		this.GroupBox2.Location = new System.Drawing.Point(439, 12);
		this.GroupBox2.Name = "GroupBox2";
		this.GroupBox2.Size = new System.Drawing.Size(318, 425);
		this.GroupBox2.TabIndex = 1;
		this.GroupBox2.TabStop = false;
		this.vehiculostxt.AutoSize = true;
		this.vehiculostxt.Location = new System.Drawing.Point(65, 30);
		this.vehiculostxt.Name = "vehiculostxt";
		this.vehiculostxt.Size = new System.Drawing.Size(13, 13);
		this.vehiculostxt.TabIndex = 2;
		this.vehiculostxt.Text = "0";
		this.vehiculoslbl.AutoSize = true;
		this.vehiculoslbl.Location = new System.Drawing.Point(6, 30);
		this.vehiculoslbl.Name = "vehiculoslbl";
		this.vehiculoslbl.Size = new System.Drawing.Size(56, 13);
		this.vehiculoslbl.TabIndex = 1;
		this.vehiculoslbl.Text = "Vehiculos:";
		this.ListView2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.ListView2.Location = new System.Drawing.Point(6, 61);
		this.ListView2.Name = "ListView2";
		this.ListView2.Size = new System.Drawing.Size(306, 358);
		this.ListView2.TabIndex = 0;
		this.ListView2.UseCompatibleStateImageBehavior = false;
		this.Button1.Location = new System.Drawing.Point(346, 73);
		this.Button1.Name = "Button1";
		this.Button1.Size = new System.Drawing.Size(75, 23);
		this.Button1.TabIndex = 2;
		this.Button1.Text = "<";
		this.Button1.UseVisualStyleBackColor = true;
		this.Button2.Location = new System.Drawing.Point(346, 102);
		this.Button2.Name = "Button2";
		this.Button2.Size = new System.Drawing.Size(75, 23);
		this.Button2.TabIndex = 3;
		this.Button2.Text = ">";
		this.Button2.UseVisualStyleBackColor = true;
		this.Button3.Location = new System.Drawing.Point(346, 131);
		this.Button3.Name = "Button3";
		this.Button3.Size = new System.Drawing.Size(75, 23);
		this.Button3.TabIndex = 4;
		this.Button3.Text = ">>";
		this.Button3.UseVisualStyleBackColor = true;
		this.Button4.Location = new System.Drawing.Point(346, 160);
		this.Button4.Name = "Button4";
		this.Button4.Size = new System.Drawing.Size(75, 23);
		this.Button4.TabIndex = 5;
		this.Button4.Text = "<<";
		this.Button4.UseVisualStyleBackColor = true;
		this.Button5.Location = new System.Drawing.Point(346, 189);
		this.Button5.Name = "Button5";
		this.Button5.Size = new System.Drawing.Size(75, 23);
		this.Button5.TabIndex = 6;
		this.Button5.Text = "Button5";
		this.Button5.UseVisualStyleBackColor = true;
		this.Button5.Visible = false;
		this.Button6.Location = new System.Drawing.Point(346, 218);
		this.Button6.Name = "Button6";
		this.Button6.Size = new System.Drawing.Size(75, 23);
		this.Button6.TabIndex = 7;
		this.Button6.Text = "Button6";
		this.Button6.UseVisualStyleBackColor = true;
		this.Button6.Visible = false;
		this.Button7.Location = new System.Drawing.Point(346, 408);
		this.Button7.Name = "Button7";
		this.Button7.Size = new System.Drawing.Size(75, 23);
		this.Button7.TabIndex = 8;
		this.Button7.Text = "Cerrar";
		this.Button7.UseVisualStyleBackColor = true;
		this.Label1.AutoSize = true;
		this.Label1.Location = new System.Drawing.Point(357, 34);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(39, 13);
		this.Label1.TabIndex = 9;
		this.Label1.Text = "Label1";
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(769, 449);
		base.Controls.Add(this.Label1);
		base.Controls.Add(this.Button7);
		base.Controls.Add(this.Button6);
		base.Controls.Add(this.Button5);
		base.Controls.Add(this.Button4);
		base.Controls.Add(this.Button3);
		base.Controls.Add(this.Button2);
		base.Controls.Add(this.Button1);
		base.Controls.Add(this.GroupBox2);
		base.Controls.Add(this.GroupBox1);
		base.Name = "Disponibilidad";
		this.Text = "Disponibilidad";
		this.GroupBox1.ResumeLayout(false);
		this.GroupBox1.PerformLayout();
		this.GroupBox2.ResumeLayout(false);
		this.GroupBox2.PerformLayout();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private void Disponibilidad_Load(object sender, EventArgs e)
	{
		si_disponibles();
		no_disponibles();
	}

	private void ListView1_ColumnClick(object sender, ColumnClickEventArgs e)
	{
		Mod_Ordenaclumnas.ordenar_columnas(ListView1, RuntimeHelpers.GetObjectValue(sender), e);
	}

	private void ListView2_ColumnClick(object sender, ColumnClickEventArgs e)
	{
		Mod_Ordenaclumnas.ordenar_columnas(ListView2, RuntimeHelpers.GetObjectValue(sender), e);
	}

	private void no_disponibles()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		checked
		{
			try
			{
				string commandText = "SELECT Numero, Chofer, Categoria FROM Flota WHERE Disponible='NO' AND Estado='Activo'";
				MySqlCommand val = new MySqlCommand();
				MySqlCommand val2 = val;
				val2.CommandType = CommandType.Text;
				val2.CommandText = commandText;
				val2.Connection = Mod_Sentencias.cnn;
				val2 = null;
				MySqlDataAdapter val3 = new MySqlDataAdapter();
				DataSet dataSet = new DataSet();
				val3.SelectCommand = val;
				((DbDataAdapter)(object)val3).Fill(dataSet, "Tabla");
				ListView listView = ListView2;
				listView.Items.Clear();
				listView.Columns.Clear();
				listView.View = View.Details;
				listView.GridLines = true;
				listView.FullRowSelect = true;
				int num = dataSet.Tables["tabla"].Columns.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					listView.Columns.Add(dataSet.Tables["tabla"].Columns[i].Caption);
				}
				listView = null;
				DataTable dataTable = dataSet.Tables["tabla"];
				int num2 = dataTable.Rows.Count - 1;
				for (int j = 0; j <= num2; j++)
				{
					ListViewItem listViewItem = new ListViewItem(dataTable.Rows[j][0].ToString());
					int num3 = dataTable.Columns.Count - 1;
					for (int k = 1; k <= num3; k++)
					{
						listViewItem.SubItems.Add(dataTable.Rows[j][k].ToString());
					}
					ListView2.Items.Add(listViewItem);
				}
				dataTable = null;
				ListView listView2 = ListView2;
				int num4 = dataSet.Tables["tabla"].Columns.Count - 1;
				for (int l = 0; l <= num4; l++)
				{
					listView2.AutoResizeColumn(l, ColumnHeaderAutoResizeStyle.ColumnContent);
				}
				listView2 = null;
				vehiculostxt.Text = Conversions.ToString(ListView2.Items.Count);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Interaction.MsgBox(ex2.Message);
				Logger.e("Error con excepción", ex2);
				Logger.d("Debug con traza", new StackFrame(fNeedFileInfo: true));
				Logger.i("Info sin traza", new StackFrame(fNeedFileInfo: true));
				Logger.e("Error con excepción y traza", ex2, new StackFrame(fNeedFileInfo: true));
				ProjectData.ClearProjectError();
			}
		}
	}

	private void si_disponibles()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		checked
		{
			try
			{
				string commandText = "SELECT Numero, Chofer, Categoria FROM Flota WHERE Disponible='Si' AND Estado='Activo'";
				MySqlCommand val = new MySqlCommand();
				MySqlCommand val2 = val;
				val2.CommandType = CommandType.Text;
				val2.CommandText = commandText;
				val2.Connection = Mod_Sentencias.cnn;
				val2 = null;
				MySqlDataAdapter val3 = new MySqlDataAdapter();
				DataSet dataSet = new DataSet();
				val3.SelectCommand = val;
				((DbDataAdapter)(object)val3).Fill(dataSet, "Tabla");
				ListView listView = ListView1;
				listView.Items.Clear();
				listView.Columns.Clear();
				listView.View = View.Details;
				listView.GridLines = true;
				listView.FullRowSelect = true;
				int num = dataSet.Tables["tabla"].Columns.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					listView.Columns.Add(dataSet.Tables["tabla"].Columns[i].Caption);
				}
				listView = null;
				DataTable dataTable = dataSet.Tables["tabla"];
				int num2 = dataTable.Rows.Count - 1;
				for (int j = 0; j <= num2; j++)
				{
					ListViewItem listViewItem = new ListViewItem(dataTable.Rows[j][0].ToString());
					int num3 = dataTable.Columns.Count - 1;
					for (int k = 1; k <= num3; k++)
					{
						listViewItem.SubItems.Add(dataTable.Rows[j][k].ToString());
					}
					ListView1.Items.Add(listViewItem);
				}
				dataTable = null;
				ListView listView2 = ListView1;
				int num4 = dataSet.Tables["tabla"].Columns.Count - 1;
				for (int l = 0; l <= num4; l++)
				{
					listView2.AutoResizeColumn(l, ColumnHeaderAutoResizeStyle.ColumnContent);
				}
				listView2 = null;
				disponiblestxt.Text = Conversions.ToString(ListView1.Items.Count);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Interaction.MsgBox(ex2.Message);
				Logger.e("Error con excepción", ex2);
				Logger.d("Debug con traza", new StackFrame(fNeedFileInfo: true));
				Logger.i("Info sin traza", new StackFrame(fNeedFileInfo: true));
				Logger.e("Error con excepción y traza", ex2, new StackFrame(fNeedFileInfo: true));
				ProjectData.ClearProjectError();
			}
		}
	}

	private void Button7_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
	{
		Selected_item(ListView1);
	}

	private void ListView2_SelectedIndexChanged(object sender, EventArgs e)
	{
		Selected_item(ListView2);
	}

	private void Selected_item(ListView Listview1)
	{
		if (Listview1.SelectedItems.Count > 0)
		{
			int index = Listview1.SelectedIndices[0];
			Label1.Text = Listview1.Items[index].Text;
		}
		Listview1.Refresh();
	}

	private void nodisp()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		string text = "UPDATE Flota SET Disponible='No' WHERE Numero= '" + Label1.Text + "' ";
		MySqlCommand val = new MySqlCommand(text, Mod_Sentencias.cnn);
		val.ExecuteNonQuery();
	}

	private void sidisp()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		string text = "UPDATE Flota SET Disponible='Si' WHERE Numero= '" + Label1.Text + "' ";
		MySqlCommand val = new MySqlCommand(text, Mod_Sentencias.cnn);
		val.ExecuteNonQuery();
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		try
		{
			Mod_Sentencias.cnn.Open();
			nodisp();
			si_disponibles();
			no_disponibles();
			Mod_Sentencias.cnn.Close();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Logger.e("Error con excepción", ex2);
			Logger.d("Debug con traza", new StackFrame(fNeedFileInfo: true));
			Logger.i("Info sin traza", new StackFrame(fNeedFileInfo: true));
			Logger.e("Error con excepción y traza", ex2, new StackFrame(fNeedFileInfo: true));
			Mod_Sentencias.cnn.Close();
			Interaction.MsgBox(ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		try
		{
			Mod_Sentencias.cnn.Open();
			sidisp();
			si_disponibles();
			no_disponibles();
			Mod_Sentencias.cnn.Close();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Mod_Sentencias.cnn.Close();
			Logger.e("Error con excepción", ex2);
			Logger.d("Debug con traza", new StackFrame(fNeedFileInfo: true));
			Logger.i("Info sin traza", new StackFrame(fNeedFileInfo: true));
			Logger.e("Error con excepción y traza", ex2, new StackFrame(fNeedFileInfo: true));
			Interaction.MsgBox(ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void todos_no()
	{
		checked
		{
			try
			{
				ListView1.Items[0].Selected = true;
				int num = ListView1.Items.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					Label1.Text = ListView1.Items[i].Text;
					nodisp();
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Logger.e("Error con excepción", ex2);
				Logger.d("Debug con traza", new StackFrame(fNeedFileInfo: true));
				Logger.i("Info sin traza", new StackFrame(fNeedFileInfo: true));
				Logger.e("Error con excepción y traza", ex2, new StackFrame(fNeedFileInfo: true));
				Interaction.MsgBox(ex2.Message);
				ProjectData.ClearProjectError();
			}
		}
	}

	public void todos_si()
	{
		checked
		{
			try
			{
				ListView2.Items[0].Selected = true;
				int num = ListView2.Items.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					Label1.Text = ListView2.Items[i].Text;
					nodisp();
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Logger.e("Error con excepción", ex2);
				Logger.d("Debug con traza", new StackFrame(fNeedFileInfo: true));
				Logger.i("Info sin traza", new StackFrame(fNeedFileInfo: true));
				Logger.e("Error con excepción y traza", ex2, new StackFrame(fNeedFileInfo: true));
				Interaction.MsgBox(ex2.Message);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void Button3_Click(object sender, EventArgs e)
	{
		try
		{
			Mod_Sentencias.cnn.Open();
			todos_no();
			si_disponibles();
			no_disponibles();
			Mod_Sentencias.cnn.Close();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Mod_Sentencias.cnn.Close();
			Logger.e("Error con excepción", ex2);
			Logger.d("Debug con traza", new StackFrame(fNeedFileInfo: true));
			Logger.i("Info sin traza", new StackFrame(fNeedFileInfo: true));
			Logger.e("Error con excepción y traza", ex2, new StackFrame(fNeedFileInfo: true));
			Interaction.MsgBox(ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void Button4_Click(object sender, EventArgs e)
	{
		try
		{
			Mod_Sentencias.cnn.Open();
			todos_si();
			si_disponibles();
			no_disponibles();
			Mod_Sentencias.cnn.Close();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Mod_Sentencias.cnn.Close();
			Logger.e("Error con excepción", ex2);
			Logger.d("Debug con traza", new StackFrame(fNeedFileInfo: true));
			Logger.i("Info sin traza", new StackFrame(fNeedFileInfo: true));
			Logger.e("Error con excepción y traza", ex2, new StackFrame(fNeedFileInfo: true));
			Interaction.MsgBox(ex2.Message);
			ProjectData.ClearProjectError();
		}
	}
}
