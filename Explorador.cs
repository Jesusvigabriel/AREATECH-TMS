using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Hermes.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace Hermes;

[DesignerGenerated]
public class Explorador : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ListView1")]
	private ListView _ListView1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ComboBox1")]
	private ComboBox _ComboBox1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("verbtn")]
	private Button _verbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("buscarbtn")]
	private Button _buscarbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("borrarbtn")]
	private Button _borrarbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("insertarbtn")]
	private Button _insertarbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button1")]
	private Button _Button1;

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
			DrawListViewItemEventHandler value3 = ListView1_DrawItem;
			DrawListViewSubItemEventHandler value4 = lv1_DrawSubItem;
			DrawListViewColumnHeaderEventHandler value5 = ListView1_DrawColumnHeader;
			EventHandler value6 = ListView1_DoubleClick;
			ListView listView = _ListView1;
			if (listView != null)
			{
				listView.ColumnClick -= value2;
				listView.DrawItem -= value3;
				listView.DrawSubItem -= value4;
				listView.DrawColumnHeader -= value5;
				listView.DoubleClick -= value6;
			}
			_ListView1 = value;
			listView = _ListView1;
			if (listView != null)
			{
				listView.ColumnClick += value2;
				listView.DrawItem += value3;
				listView.DrawSubItem += value4;
				listView.DrawColumnHeader += value5;
				listView.DoubleClick += value6;
			}
		}
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
			EventHandler value2 = ComboBox1_SelectedIndexChanged;
			ComboBox comboBox = _ComboBox1;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged -= value2;
			}
			_ComboBox1 = value;
			comboBox = _ComboBox1;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged += value2;
			}
		}
	}

	internal virtual Button verbtn
	{
		[CompilerGenerated]
		get
		{
			return _verbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = verbtn_Click;
			Button button = _verbtn;
			if (button != null)
			{
				button.Click -= value2;
			}
			_verbtn = value;
			button = _verbtn;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("StatusStrip1")]
	internal virtual StatusStrip StatusStrip1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ToolStripStatusLabel1")]
	internal virtual ToolStripStatusLabel ToolStripStatusLabel1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ToolStripStatusLabel2")]
	internal virtual ToolStripStatusLabel ToolStripStatusLabel2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button buscarbtn
	{
		[CompilerGenerated]
		get
		{
			return _buscarbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = buscarbtn_Click;
			Button button = _buscarbtn;
			if (button != null)
			{
				button.Click -= value2;
			}
			_buscarbtn = value;
			button = _buscarbtn;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("editarbtn")]
	internal virtual Button editarbtn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button borrarbtn
	{
		[CompilerGenerated]
		get
		{
			return _borrarbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = borrarbtn_Click;
			Button button = _borrarbtn;
			if (button != null)
			{
				button.Click -= value2;
			}
			_borrarbtn = value;
			button = _borrarbtn;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button insertarbtn
	{
		[CompilerGenerated]
		get
		{
			return _insertarbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = insertarbtn_Click;
			Button button = _insertarbtn;
			if (button != null)
			{
				button.Click -= value2;
			}
			_insertarbtn = value;
			button = _insertarbtn;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("CheckBox1")]
	internal virtual CheckBox CheckBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DateTimePicker1")]
	internal virtual DateTimePicker DateTimePicker1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DateTimePicker2")]
	internal virtual DateTimePicker DateTimePicker2
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

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public Explorador()
	{
		base.Load += Explorador_Load;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hermes.Explorador));
		this.ListView1 = new System.Windows.Forms.ListView();
		this.ComboBox1 = new System.Windows.Forms.ComboBox();
		this.verbtn = new System.Windows.Forms.Button();
		this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
		this.ToolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
		this.ToolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
		this.buscarbtn = new System.Windows.Forms.Button();
		this.editarbtn = new System.Windows.Forms.Button();
		this.borrarbtn = new System.Windows.Forms.Button();
		this.insertarbtn = new System.Windows.Forms.Button();
		this.CheckBox1 = new System.Windows.Forms.CheckBox();
		this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
		this.DateTimePicker2 = new System.Windows.Forms.DateTimePicker();
		this.Button1 = new System.Windows.Forms.Button();
		this.Label1 = new System.Windows.Forms.Label();
		this.StatusStrip1.SuspendLayout();
		base.SuspendLayout();
		this.ListView1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.ListView1.FullRowSelect = true;
		this.ListView1.GridLines = true;
		this.ListView1.HideSelection = false;
		this.ListView1.Location = new System.Drawing.Point(12, 39);
		this.ListView1.MultiSelect = false;
		this.ListView1.Name = "ListView1";
		this.ListView1.OwnerDraw = true;
		this.ListView1.Size = new System.Drawing.Size(1003, 377);
		this.ListView1.TabIndex = 0;
		this.ListView1.UseCompatibleStateImageBehavior = false;
		this.ListView1.View = System.Windows.Forms.View.List;
		this.ComboBox1.FormattingEnabled = true;
		this.ComboBox1.Location = new System.Drawing.Point(12, 12);
		this.ComboBox1.Name = "ComboBox1";
		this.ComboBox1.Size = new System.Drawing.Size(121, 21);
		this.ComboBox1.TabIndex = 1;
		this.ComboBox1.Text = "Planchada";
		this.verbtn.Location = new System.Drawing.Point(139, 10);
		this.verbtn.Name = "verbtn";
		this.verbtn.Size = new System.Drawing.Size(75, 23);
		this.verbtn.TabIndex = 2;
		this.verbtn.Text = "Ver";
		this.verbtn.UseVisualStyleBackColor = true;
		this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[2] { this.ToolStripStatusLabel1, this.ToolStripStatusLabel2 });
		this.StatusStrip1.Location = new System.Drawing.Point(0, 419);
		this.StatusStrip1.Name = "StatusStrip1";
		this.StatusStrip1.Size = new System.Drawing.Size(1027, 22);
		this.StatusStrip1.TabIndex = 3;
		this.StatusStrip1.Text = "StatusStrip1";
		this.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
		this.ToolStripStatusLabel1.Size = new System.Drawing.Size(39, 17);
		this.ToolStripStatusLabel1.Text = "Items:";
		this.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2";
		this.ToolStripStatusLabel2.Size = new System.Drawing.Size(13, 17);
		this.ToolStripStatusLabel2.Text = "0";
		this.buscarbtn.Location = new System.Drawing.Point(220, 10);
		this.buscarbtn.Name = "buscarbtn";
		this.buscarbtn.Size = new System.Drawing.Size(75, 23);
		this.buscarbtn.TabIndex = 4;
		this.buscarbtn.Text = "Buscar";
		this.buscarbtn.UseVisualStyleBackColor = true;
		this.editarbtn.Location = new System.Drawing.Point(301, 10);
		this.editarbtn.Name = "editarbtn";
		this.editarbtn.Size = new System.Drawing.Size(75, 23);
		this.editarbtn.TabIndex = 5;
		this.editarbtn.Text = "Editar";
		this.editarbtn.UseVisualStyleBackColor = true;
		this.borrarbtn.Location = new System.Drawing.Point(382, 10);
		this.borrarbtn.Name = "borrarbtn";
		this.borrarbtn.Size = new System.Drawing.Size(75, 23);
		this.borrarbtn.TabIndex = 6;
		this.borrarbtn.Text = "Borrar";
		this.borrarbtn.UseVisualStyleBackColor = true;
		this.insertarbtn.Location = new System.Drawing.Point(463, 10);
		this.insertarbtn.Name = "insertarbtn";
		this.insertarbtn.Size = new System.Drawing.Size(75, 23);
		this.insertarbtn.TabIndex = 7;
		this.insertarbtn.Text = "Insertar";
		this.insertarbtn.UseVisualStyleBackColor = true;
		this.CheckBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.CheckBox1.AutoSize = true;
		this.CheckBox1.Location = new System.Drawing.Point(754, 14);
		this.CheckBox1.Name = "CheckBox1";
		this.CheckBox1.Size = new System.Drawing.Size(51, 17);
		this.CheckBox1.TabIndex = 8;
		this.CheckBox1.Text = "Filtrar";
		this.CheckBox1.UseVisualStyleBackColor = true;
		this.DateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
		this.DateTimePicker1.Location = new System.Drawing.Point(811, 11);
		this.DateTimePicker1.Name = "DateTimePicker1";
		this.DateTimePicker1.Size = new System.Drawing.Size(97, 20);
		this.DateTimePicker1.TabIndex = 9;
		this.DateTimePicker2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
		this.DateTimePicker2.Location = new System.Drawing.Point(914, 11);
		this.DateTimePicker2.Name = "DateTimePicker2";
		this.DateTimePicker2.Size = new System.Drawing.Size(101, 20);
		this.DateTimePicker2.TabIndex = 10;
		this.Button1.Location = new System.Drawing.Point(544, 11);
		this.Button1.Name = "Button1";
		this.Button1.Size = new System.Drawing.Size(75, 23);
		this.Button1.TabIndex = 11;
		this.Button1.Text = "Button1";
		this.Button1.UseVisualStyleBackColor = true;
		this.Label1.AutoSize = true;
		this.Label1.Location = new System.Drawing.Point(648, 19);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(39, 13);
		this.Label1.TabIndex = 12;
		this.Label1.Text = "Label1";
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(1027, 441);
		base.Controls.Add(this.Label1);
		base.Controls.Add(this.Button1);
		base.Controls.Add(this.DateTimePicker2);
		base.Controls.Add(this.DateTimePicker1);
		base.Controls.Add(this.CheckBox1);
		base.Controls.Add(this.insertarbtn);
		base.Controls.Add(this.borrarbtn);
		base.Controls.Add(this.editarbtn);
		base.Controls.Add(this.buscarbtn);
		base.Controls.Add(this.StatusStrip1);
		base.Controls.Add(this.verbtn);
		base.Controls.Add(this.ComboBox1);
		base.Controls.Add(this.ListView1);
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.Name = "Explorador";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Explorador";
		this.StatusStrip1.ResumeLayout(false);
		this.StatusStrip1.PerformLayout();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private void ListView1_ColumnClick(object sender, ColumnClickEventArgs e)
	{
		Mod_Ordenaclumnas.ordenar_columnas(ListView1, RuntimeHelpers.GetObjectValue(sender), e);
	}

	private void verbtn_Click(object sender, EventArgs e)
	{
		//IL_053d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0544: Expected O, but got Unknown
		//IL_056d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0574: Expected O, but got Unknown
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected O, but got Unknown
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected O, but got Unknown
		checked
		{
			if (CheckBox1.Checked)
			{
				try
				{
					string text = Strings.Format(DateTimePicker1.Value, "yyyyMMdd");
					string text2 = Strings.Format(DateTimePicker2.Value, "yyyyMMdd");
					string commandText = "SELECT * FROM " + ComboBox1.Text + " WHERE fecha BETWEEN '" + text + "' AND '" + text2 + "'";
					Interaction.MsgBox(("Se mostraran los datos entre " + DateTimePicker1.Text + " y " + DateTimePicker2.Text) ?? "");
					Mod_Sentencias.cnn.Open();
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
					int num4 = ListView1.Items.Count - 1;
					for (int l = 0; l <= num4; l++)
					{
						if (Operators.CompareString(ListView1.Items[l].SubItems[23].Text, "NO ENTREGADO", TextCompare: true) == 0)
						{
							ListView1.Items[l].ForeColor = Color.Red;
						}
						if (Operators.CompareString(ListView1.Items[l].SubItems[23].Text, "NO RECOLECTADO", TextCompare: true) == 0)
						{
							ListView1.Items[l].ForeColor = Color.Red;
						}
						if (Operators.CompareString(ListView1.Items[l].SubItems[23].Text, "ENTREGADO", TextCompare: true) == 0)
						{
							ListView1.Items[l].ForeColor = Color.Green;
						}
						if (Operators.CompareString(ListView1.Items[l].SubItems[23].Text, "RECOLECTADO", TextCompare: true) == 0)
						{
							ListView1.Items[l].ForeColor = Color.Green;
						}
						if (Operators.CompareString(ListView1.Items[l].SubItems[23].Text, "EN CD", TextCompare: true) == 0)
						{
							ListView1.Items[l].ForeColor = Color.Green;
						}
						if (Operators.CompareString(ListView1.Items[l].SubItems[23].Text, "PARCIAL", TextCompare: true) == 0)
						{
							ListView1.Items[l].ForeColor = Color.Orange;
						}
					}
					Mod_Sentencias.cnn.Close();
					ToolStripStatusLabel2.Text = Conversions.ToString(ListView1.Items.Count);
					ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
					return;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					Mod_Sentencias.cnn.Close();
					Interaction.MsgBox(ex2.Message);
					ProjectData.ClearProjectError();
					return;
				}
			}
			try
			{
				string commandText2 = "SELECT * FROM " + ComboBox1.Text;
				Mod_Sentencias.cnn.Open();
				MySqlCommand val4 = new MySqlCommand();
				MySqlCommand val5 = val4;
				val5.CommandType = CommandType.Text;
				val5.CommandText = commandText2;
				val5.Connection = Mod_Sentencias.cnn;
				val5 = null;
				MySqlDataAdapter val6 = new MySqlDataAdapter();
				DataSet dataSet2 = new DataSet();
				val6.SelectCommand = val4;
				((DbDataAdapter)(object)val6).Fill(dataSet2, "Tabla");
				ListView listView2 = ListView1;
				listView2.Items.Clear();
				listView2.Columns.Clear();
				listView2.View = View.Details;
				listView2.GridLines = true;
				listView2.FullRowSelect = true;
				int num5 = dataSet2.Tables["tabla"].Columns.Count - 1;
				for (int m = 0; m <= num5; m++)
				{
					listView2.Columns.Add(dataSet2.Tables["tabla"].Columns[m].Caption);
				}
				listView2 = null;
				DataTable dataTable2 = dataSet2.Tables["tabla"];
				int num6 = dataTable2.Rows.Count - 1;
				for (int n = 0; n <= num6; n++)
				{
					ListViewItem listViewItem2 = new ListViewItem(dataTable2.Rows[n][0].ToString());
					int num7 = dataTable2.Columns.Count - 1;
					for (int num8 = 1; num8 <= num7; num8++)
					{
						listViewItem2.SubItems.Add(dataTable2.Rows[n][num8].ToString());
					}
					ListView1.Items.Add(listViewItem2);
				}
				dataTable2 = null;
				int num9 = ListView1.Items.Count - 1;
				for (int num10 = 0; num10 <= num9; num10++)
				{
					if (Operators.CompareString(ListView1.Items[num10].SubItems[23].Text, "NO ENTREGADO", TextCompare: true) == 0)
					{
						ListView1.Items[num10].ForeColor = Color.Red;
					}
					if (Operators.CompareString(ListView1.Items[num10].SubItems[23].Text, "NO RECOLECTADO", TextCompare: true) == 0)
					{
						ListView1.Items[num10].ForeColor = Color.Red;
					}
					if (Operators.CompareString(ListView1.Items[num10].SubItems[23].Text, "ENTREGADO", TextCompare: true) == 0)
					{
						ListView1.Items[num10].ForeColor = Color.Green;
					}
					if (Operators.CompareString(ListView1.Items[num10].SubItems[23].Text, "RECOLECTADO", TextCompare: true) == 0)
					{
						ListView1.Items[num10].ForeColor = Color.Green;
					}
					if (Operators.CompareString(ListView1.Items[num10].SubItems[23].Text, "EN CD", TextCompare: true) == 0)
					{
						ListView1.Items[num10].ForeColor = Color.Green;
					}
					if (Operators.CompareString(ListView1.Items[num10].SubItems[23].Text, "PARCIAL", TextCompare: true) == 0)
					{
						ListView1.Items[num10].ForeColor = Color.Orange;
					}
				}
				Mod_Sentencias.cnn.Close();
				ToolStripStatusLabel2.Text = Conversions.ToString(ListView1.Items.Count);
				ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				Mod_Sentencias.cnn.Close();
				Interaction.MsgBox(ex4.Message);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void Explorador_Load(object sender, EventArgs e)
	{
		CheckBox1.Checked = true;
		ComboBox1.Items.Add("Planchada");
		ComboBox1.Items.Add("etransEnvios");
		Refresh();
		base.WindowState = FormWindowState.Maximized;
	}

	private void buscarbtn_Click(object sender, EventArgs e)
	{
		MyProject.Forms.Buscar.Show();
	}

	private void ListView1_DrawItem(object sender, DrawListViewItemEventArgs e)
	{
		e.DrawDefault = true;
	}

	private void lv1_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
	{
		e.DrawDefault = true;
	}

	private void ListView1_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
	{
		e.DrawBackground();
		e.Graphics.FillRectangle(Brushes.LimeGreen, e.Bounds);
		Font font = new Font("Microsoft Sans Serif", 8f, FontStyle.Bold);
		Point point = checked(new Point(e.Bounds.X + 3, e.Bounds.Y + 2));
		e.Graphics.DrawString(e.Header.Text, font, Brushes.White, point);
	}

	private void insertarbtn_Click(object sender, EventArgs e)
	{
		MyProject.Forms.Ingreso_manual.Show();
	}

	private void ListView1_DoubleClick(object sender, EventArgs e)
	{
		if (ListView1.SelectedItems.Count > 0)
		{
			int index = ListView1.SelectedIndices[0];
			Entregas entregas = MyProject.Forms.Entregas;
			entregas.Label18.Text = ListView1.Items[index].Text;
			entregas.Label2.Text = ListView1.Items[index].SubItems[1].Text;
			entregas.Label17.Text = ListView1.Items[index].SubItems[4].Text;
			entregas.Label19.Text = ListView1.Items[index].SubItems[5].Text;
			entregas.TextBox1.Text = ListView1.Items[index].SubItems[5].Text;
			entregas.Label21.Text = ListView1.Items[index].SubItems[6].Text;
			entregas.TextBox2.Text = ListView1.Items[index].SubItems[6].Text;
			entregas.Label20.Text = ListView1.Items[index].SubItems[7].Text;
			entregas.TextBox3.Text = ListView1.Items[index].SubItems[7].Text;
			entregas.Label22.Text = ListView1.Items[index].SubItems[17].Text;
			entregas.Label6.Text = ListView1.Items[index].SubItems[20].Text;
			entregas.Label23.Text = ListView1.Items[index].SubItems[23].Text;
			entregas.Label27.Text = ListView1.Items[index].SubItems[28].Text;
			entregas.TextBox6.Text = ListView1.Items[index].SubItems[12].Text;
			entregas.TextBox7.Text = ListView1.Items[index].SubItems[16].Text;
			entregas.TextBox4.Text = ListView1.Items[index].SubItems[8].Text;
			entregas.TextBox5.Text = ListView1.Items[index].SubItems[9].Text;
			entregas = null;
		}
		MyProject.Forms.Entregas.Show();
	}

	private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (Operators.CompareString(ComboBox1.Text, "etransEnvios", TextCompare: true) == 0)
		{
			CheckBox1.Checked = false;
			borrarbtn.Enabled = false;
			buscarbtn.Enabled = false;
			editarbtn.Enabled = false;
			insertarbtn.Enabled = false;
		}
		else
		{
			CheckBox1.Checked = true;
			borrarbtn.Enabled = true;
			buscarbtn.Enabled = true;
			editarbtn.Enabled = true;
			insertarbtn.Enabled = true;
		}
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		string text = Strings.Format(MyProject.Forms.Form1_Inicio.DateTimePicker1.Value, "yyyyMMdd");
		string sql = "SELECT id_hermes, Cliente, U_calle, U_numero_puerta, U_cp, U_localidad, sum(Declarado), sum(Bultos), sum(Kilos), numero_interno, sum(Volumen), U_fecha, sum(flete), U_ventana FROM etransenvios WHERE U_fecha=" + text + " GROUP BY Cliente, U_Calle";
		Mod_Sentencias.cargar_datos_lv_completa(ListView1, sql, Label1);
	}

	private void borrarbtn_Click(object sender, EventArgs e)
	{
	}
}
