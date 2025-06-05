using System;
using System.Collections.Generic;
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
public class ProductosIn_Form : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ComboBox1")]
	private ComboBox _ComboBox1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("TextBox3")]
	private TextBox _TextBox3;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("TextBox2")]
	private TextBox _TextBox2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ListView1")]
	private ListView _ListView1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button2")]
	private Button _Button2;

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

	[field: AccessedThroughProperty("GroupBox2")]
	internal virtual GroupBox GroupBox2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox1")]
	internal virtual TextBox TextBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("GroupBox3")]
	internal virtual GroupBox GroupBox3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual TextBox TextBox3
	{
		[CompilerGenerated]
		get
		{
			return _TextBox3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			KeyPressEventHandler value2 = TextBox3_KeyPress;
			TextBox textBox = _TextBox3;
			if (textBox != null)
			{
				textBox.KeyPress -= value2;
			}
			_TextBox3 = value;
			textBox = _TextBox3;
			if (textBox != null)
			{
				textBox.KeyPress += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label4")]
	internal virtual Label Label4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual TextBox TextBox2
	{
		[CompilerGenerated]
		get
		{
			return _TextBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			KeyPressEventHandler value2 = TextBox2_KeyPress;
			TextBox textBox = _TextBox2;
			if (textBox != null)
			{
				textBox.KeyPress -= value2;
			}
			_TextBox2 = value;
			textBox = _TextBox2;
			if (textBox != null)
			{
				textBox.KeyPress += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
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
			EventHandler value2 = ListView1_DoubleClick;
			ColumnClickEventHandler value3 = ListView1_ColumnClick;
			ListView listView = _ListView1;
			if (listView != null)
			{
				listView.DoubleClick -= value2;
				listView.ColumnClick -= value3;
			}
			_ListView1 = value;
			listView = _ListView1;
			if (listView != null)
			{
				listView.DoubleClick += value2;
				listView.ColumnClick += value3;
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

	[field: AccessedThroughProperty("Cantidad")]
	internal virtual ColumnHeader Cantidad
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Codigo")]
	internal virtual ColumnHeader Codigo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Descripcion")]
	internal virtual ColumnHeader Descripcion
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

	[field: AccessedThroughProperty("idProducto")]
	internal virtual ColumnHeader idProducto
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("variacion")]
	internal virtual ColumnHeader variacion
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

	[field: AccessedThroughProperty("dtpIngreso")]
	internal virtual DateTimePicker dtpIngreso
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CodeEmpresa")]
	internal virtual ColumnHeader CodeEmpresa
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public ProductosIn_Form()
	{
		base.Load += ProductosIn_Form_Load;
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
		this.Label9 = new System.Windows.Forms.Label();
		this.dtpIngreso = new System.Windows.Forms.DateTimePicker();
		this.Label1 = new System.Windows.Forms.Label();
		this.ComboBox1 = new System.Windows.Forms.ComboBox();
		this.GroupBox2 = new System.Windows.Forms.GroupBox();
		this.TextBox1 = new System.Windows.Forms.TextBox();
		this.Label2 = new System.Windows.Forms.Label();
		this.GroupBox3 = new System.Windows.Forms.GroupBox();
		this.Label8 = new System.Windows.Forms.Label();
		this.TextBox3 = new System.Windows.Forms.TextBox();
		this.Label7 = new System.Windows.Forms.Label();
		this.Label6 = new System.Windows.Forms.Label();
		this.Label4 = new System.Windows.Forms.Label();
		this.Label5 = new System.Windows.Forms.Label();
		this.TextBox2 = new System.Windows.Forms.TextBox();
		this.Label3 = new System.Windows.Forms.Label();
		this.ListView1 = new System.Windows.Forms.ListView();
		this.Cantidad = new System.Windows.Forms.ColumnHeader();
		this.Codigo = new System.Windows.Forms.ColumnHeader();
		this.Descripcion = new System.Windows.Forms.ColumnHeader();
		this.idProducto = new System.Windows.Forms.ColumnHeader();
		this.variacion = new System.Windows.Forms.ColumnHeader();
		this.Button1 = new System.Windows.Forms.Button();
		this.Button2 = new System.Windows.Forms.Button();
		this.CodeEmpresa = new System.Windows.Forms.ColumnHeader();
		this.GroupBox1.SuspendLayout();
		this.GroupBox2.SuspendLayout();
		this.GroupBox3.SuspendLayout();
		base.SuspendLayout();
		this.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.GroupBox1.Controls.Add(this.Label9);
		this.GroupBox1.Controls.Add(this.dtpIngreso);
		this.GroupBox1.Controls.Add(this.Label1);
		this.GroupBox1.Controls.Add(this.ComboBox1);
		this.GroupBox1.Location = new System.Drawing.Point(9, 12);
		this.GroupBox1.Name = "GroupBox1";
		this.GroupBox1.Size = new System.Drawing.Size(763, 54);
		this.GroupBox1.TabIndex = 0;
		this.GroupBox1.TabStop = false;
		this.GroupBox1.Text = "Empresa";
		this.Label9.AutoSize = true;
		this.Label9.Location = new System.Drawing.Point(543, 22);
		this.Label9.Name = "Label9";
		this.Label9.Size = new System.Drawing.Size(78, 13);
		this.Label9.TabIndex = 3;
		this.Label9.Text = "Fecha Ingreso:";
		this.dtpIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
		this.dtpIngreso.Location = new System.Drawing.Point(638, 19);
		this.dtpIngreso.Name = "dtpIngreso";
		this.dtpIngreso.Size = new System.Drawing.Size(100, 20);
		this.dtpIngreso.TabIndex = 2;
		this.dtpIngreso.Value = new System.DateTime(2017, 12, 7, 0, 0, 0, 0);
		this.Label1.AutoSize = true;
		this.Label1.Location = new System.Drawing.Point(303, 22);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(39, 13);
		this.Label1.TabIndex = 1;
		this.Label1.Text = "Label1";
		this.ComboBox1.FormattingEnabled = true;
		this.ComboBox1.Location = new System.Drawing.Point(6, 19);
		this.ComboBox1.Name = "ComboBox1";
		this.ComboBox1.Size = new System.Drawing.Size(291, 21);
		this.ComboBox1.TabIndex = 0;
		this.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.GroupBox2.Controls.Add(this.TextBox1);
		this.GroupBox2.Controls.Add(this.Label2);
		this.GroupBox2.Location = new System.Drawing.Point(9, 71);
		this.GroupBox2.Name = "GroupBox2";
		this.GroupBox2.Size = new System.Drawing.Size(763, 45);
		this.GroupBox2.TabIndex = 1;
		this.GroupBox2.TabStop = false;
		this.GroupBox2.Text = "Orden";
		this.TextBox1.Location = new System.Drawing.Point(74, 15);
		this.TextBox1.Name = "TextBox1";
		this.TextBox1.Size = new System.Drawing.Size(312, 20);
		this.TextBox1.TabIndex = 1;
		this.Label2.AutoSize = true;
		this.Label2.Location = new System.Drawing.Point(21, 18);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(47, 13);
		this.Label2.TabIndex = 0;
		this.Label2.Text = "Número:";
		this.GroupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.GroupBox3.Controls.Add(this.Label8);
		this.GroupBox3.Controls.Add(this.TextBox3);
		this.GroupBox3.Controls.Add(this.Label7);
		this.GroupBox3.Controls.Add(this.Label6);
		this.GroupBox3.Controls.Add(this.Label4);
		this.GroupBox3.Controls.Add(this.Label5);
		this.GroupBox3.Controls.Add(this.TextBox2);
		this.GroupBox3.Controls.Add(this.Label3);
		this.GroupBox3.Controls.Add(this.ListView1);
		this.GroupBox3.Location = new System.Drawing.Point(9, 117);
		this.GroupBox3.Name = "GroupBox3";
		this.GroupBox3.Size = new System.Drawing.Size(763, 326);
		this.GroupBox3.TabIndex = 2;
		this.GroupBox3.TabStop = false;
		this.GroupBox3.Text = "Productos";
		this.Label8.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.Label8.AutoSize = true;
		this.Label8.Location = new System.Drawing.Point(725, 22);
		this.Label8.Name = "Label8";
		this.Label8.Size = new System.Drawing.Size(13, 13);
		this.Label8.TabIndex = 8;
		this.Label8.Text = "0";
		this.TextBox3.Location = new System.Drawing.Point(68, 19);
		this.TextBox3.Name = "TextBox3";
		this.TextBox3.Size = new System.Drawing.Size(40, 20);
		this.TextBox3.TabIndex = 4;
		this.TextBox3.Text = "1";
		this.Label7.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.Label7.AutoSize = true;
		this.Label7.Location = new System.Drawing.Point(635, 22);
		this.Label7.Name = "Label7";
		this.Label7.Size = new System.Drawing.Size(55, 13);
		this.Label7.TabIndex = 7;
		this.Label7.Text = "Unidades:";
		this.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.Label6.AutoSize = true;
		this.Label6.Location = new System.Drawing.Point(589, 22);
		this.Label6.Name = "Label6";
		this.Label6.Size = new System.Drawing.Size(13, 13);
		this.Label6.TabIndex = 6;
		this.Label6.Text = "0";
		this.Label4.AutoSize = true;
		this.Label4.Location = new System.Drawing.Point(7, 22);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(55, 13);
		this.Label4.TabIndex = 3;
		this.Label4.Text = "Unidades:";
		this.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.Label5.AutoSize = true;
		this.Label5.Location = new System.Drawing.Point(505, 22);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(58, 13);
		this.Label5.TabIndex = 5;
		this.Label5.Text = "Productos:";
		this.TextBox2.Location = new System.Drawing.Point(224, 19);
		this.TextBox2.Name = "TextBox2";
		this.TextBox2.Size = new System.Drawing.Size(250, 20);
		this.TextBox2.TabIndex = 2;
		this.Label3.AutoSize = true;
		this.Label3.Location = new System.Drawing.Point(183, 22);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(35, 13);
		this.Label3.TabIndex = 1;
		this.Label3.Text = "Code:";
		this.ListView1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.ListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[6] { this.Cantidad, this.Codigo, this.Descripcion, this.CodeEmpresa, this.idProducto, this.variacion });
		this.ListView1.FullRowSelect = true;
		this.ListView1.GridLines = true;
		this.ListView1.Location = new System.Drawing.Point(6, 55);
		this.ListView1.Name = "ListView1";
		this.ListView1.Size = new System.Drawing.Size(751, 265);
		this.ListView1.TabIndex = 0;
		this.ListView1.UseCompatibleStateImageBehavior = false;
		this.ListView1.View = System.Windows.Forms.View.Details;
		this.Cantidad.Text = "Cantidad";
		this.Cantidad.Width = 91;
		this.Codigo.Text = "Codigo";
		this.Codigo.Width = 186;
		this.Descripcion.Text = "Descripcion";
		this.Descripcion.Width = 237;
		this.idProducto.Text = "Id Producto";
		this.variacion.Text = "variacion";
		this.Button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		this.Button1.Location = new System.Drawing.Point(600, 449);
		this.Button1.Name = "Button1";
		this.Button1.Size = new System.Drawing.Size(75, 23);
		this.Button1.TabIndex = 3;
		this.Button1.Text = "Ingresar";
		this.Button1.UseVisualStyleBackColor = true;
		this.Button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		this.Button2.Location = new System.Drawing.Point(681, 449);
		this.Button2.Name = "Button2";
		this.Button2.Size = new System.Drawing.Size(75, 23);
		this.Button2.TabIndex = 4;
		this.Button2.Text = "Cancelar";
		this.Button2.UseVisualStyleBackColor = true;
		this.CodeEmpresa.Text = "CodeEmpresa";
		this.CodeEmpresa.Width = 278;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(784, 482);
		base.Controls.Add(this.Button2);
		base.Controls.Add(this.Button1);
		base.Controls.Add(this.GroupBox3);
		base.Controls.Add(this.GroupBox2);
		base.Controls.Add(this.GroupBox1);
		base.Name = "ProductosIn_Form";
		this.Text = "Ingreso de Productos";
		this.GroupBox1.ResumeLayout(false);
		this.GroupBox1.PerformLayout();
		this.GroupBox2.ResumeLayout(false);
		this.GroupBox2.PerformLayout();
		this.GroupBox3.ResumeLayout(false);
		this.GroupBox3.PerformLayout();
		base.ResumeLayout(false);
	}

	private void ProductosIn_Form_Load(object sender, EventArgs e)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		dtpIngreso.Value = DateAndTime.Now;
		string text = "SELECT  Nombre, id FROM empresas WHERE estado = 1 AND tipo = 1 ORDER BY Nombre ASC";
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
		Label1.Text = Conversions.ToString(ComboBox1.SelectedValue);
	}

	private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (e.KeyChar != '\r')
		{
			return;
		}
		checked
		{
			if (Operators.CompareString(TextBox2.Text, "", TextCompare: true) != 0)
			{
				if (TextBox2.Text.Contains("'"))
				{
					TextBox2.Text = Strings.Replace(TextBox2.Text, "'", "-", 1, -1, CompareMethod.Text);
				}
				double num = 0.0;
				string empty = string.Empty;
				empty = ((Operators.CompareString(Label1.Text, "70", TextCompare: true) != 0) ? TextBox2.Text : TextBox2.Text.Remove(TextBox2.Text.Length - 1));
				int num2 = 0;
				string empty2 = string.Empty;
				ListViewItem listViewItem = null;
				string empty3 = string.Empty;
				ListViewItem listViewItem2 = null;
				int num3 = 0;
				string sql = "Select descripcion, id, variaciones, codeEmpresa from productos where empresa='" + Label1.Text + "' and barrCode='" + empty + "' Limit 1";
				empty2 = Conversions.ToString(Mod_Sentencias.dataValue(sql, "descripcion"));
				num3 = Conversions.ToInteger(Mod_Sentencias.dataValue(sql, "id"));
				int num4 = Conversions.ToInteger(Mod_Sentencias.dataValue(sql, "variaciones"));
				empty3 = Conversions.ToString(Mod_Sentencias.dataValue(sql, "codeEmpresa"));
				switch (num4)
				{
				case 0:
					if (ListView1.Items.Count > 0)
					{
						listViewItem2 = ListView1.FindItemWithText(empty, includeSubItemsInSearch: true, 0);
					}
					if (listViewItem2 != null)
					{
						if (Operators.CompareString(Label1.Text, "70", TextCompare: true) == 0)
						{
							break;
						}
						num2 = Conversions.ToInteger(listViewItem2.Text);
						empty2 = listViewItem2.SubItems[2].Text;
						num3 = Conversions.ToInteger(listViewItem2.SubItems[4].Text);
						num2 = (int)Math.Round((double)num2 + Conversions.ToDouble(TextBox3.Text));
						listViewItem2.Remove();
						listViewItem = new ListViewItem(num2.ToString());
						listViewItem.SubItems.Add(empty);
						listViewItem.SubItems.Add(empty2);
						listViewItem.SubItems.Add(empty3);
						listViewItem.SubItems.Add(Conversions.ToString(num3));
						listViewItem.SubItems.Add(Conversions.ToString(0));
						ListView1.Items.Add(listViewItem);
						listViewItem.EnsureVisible();
						Label6.Text = Conversions.ToString(ListView1.Items.Count);
						foreach (ListViewItem item in ListView1.Items)
						{
							num += (double)int.Parse(item.Text);
						}
						Label8.Text = Conversions.ToString(num);
					}
					else if (num3 > 0)
					{
						listViewItem = new ListViewItem(((int)Math.Round((double)num2 + Conversions.ToDouble(TextBox3.Text))).ToString());
						listViewItem.SubItems.Add(empty);
						listViewItem.SubItems.Add(empty2);
						listViewItem.SubItems.Add(empty3);
						listViewItem.SubItems.Add(Conversions.ToString(num3));
						listViewItem.SubItems.Add(Conversions.ToString(0));
						ListView1.Items.Add(listViewItem);
						listViewItem.EnsureVisible();
						Label6.Text = Conversions.ToString(ListView1.Items.Count);
						foreach (ListViewItem item2 in ListView1.Items)
						{
							num += (double)int.Parse(item2.Text);
						}
						Label8.Text = Conversions.ToString(num);
					}
					else
					{
						Interaction.MsgBox("El Codigo ingresado no tiene un producto relacionado.");
					}
					break;
				case 1:
				{
					Selector selector = MyProject.Forms.Selector;
					selector.Label1.Text = Conversions.ToString(3);
					selector.Label2.Text = Conversions.ToString(num3);
					selector.Label3.Text = empty;
					selector.ListView1.Items.Clear();
					selector = null;
					MyProject.Forms.Selector.ShowDialog();
					break;
				}
				}
				TextBox2.Text = "";
				TextBox3.Text = Conversions.ToString(1);
			}
			else
			{
				Interaction.MsgBox("Debe ingresar un codigo de barras.");
			}
		}
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		int empresa = Conversions.ToInteger(Label1.Text);
		List<Mod_ActualizacionStock.abmStock> list = new List<Mod_ActualizacionStock.abmStock>();
		foreach (ListViewItem item2 in ListView1.Items)
		{
			num = int.Parse(item2.SubItems[4].Text);
			num2 = int.Parse(item2.Text);
			num3 = int.Parse(item2.SubItems[5].Text);
			Mod_ActualizacionStock.abmStock item = default(Mod_ActualizacionStock.abmStock);
			item.id = num;
			item.unidades = num2;
			item.variacion = num3;
			list.Add(item);
		}
		int num5 = Conversions.ToInteger(Mod_ActualizacionStock.ingresoStock2(list, empresa));
		if (num5 == 1)
		{
			Interaction.MsgBox("actualizacion correcta");
			string sQL = Conversions.ToString(ingresoDeProductos());
			int num6 = Conversions.ToInteger(Mod_ConeccionBD.BD_Sentencia(sQL));
			if (num6 == 1)
			{
				TextBox1.Clear();
				ListView1.Items.Clear();
				Interaction.MsgBox("Se guardo el movimiento.");
			}
			else
			{
				Interaction.MsgBox("Error al guardar el movimiento.");
			}
		}
		else
		{
			Interaction.MsgBox("algo fallo");
		}
	}

	private object ingresoDeProductos()
	{
		int num = Conversions.ToInteger(Label1.Text);
		string usuario = MySettingsProperty.Settings.Usuario;
		string text = TextBox1.Text;
		string text2 = Strings.Format(dtpIngreso.Value, "yyyyMMdd");
		string text3 = "INSERT INTO movimientos (orden, codprod, variacion, unidades, tipo, id_empresa, estado, fecha, usuario)\r\nVALUES";
		checked
		{
			int num2 = ListView1.Items.Count - 1;
			for (int i = 0; i <= num2; i++)
			{
				string text4 = ListView1.Items[i].Text;
				string text5 = ListView1.Items[i].SubItems[1].Text;
				int num3 = int.Parse(ListView1.Items[i].SubItems[4].Text);
				text3 = ((i != 0) ? (text3 + ", ('" + text + "', '" + text5 + "', '" + Conversions.ToString(num3) + "', '" + text4 + "', '0', '" + Conversions.ToString(num) + "', '0', '" + text2 + "', '" + usuario + "')") : (text3 + "('" + text + "', '" + text5 + "', '" + Conversions.ToString(num3) + "', '" + text4 + "', '0', '" + Conversions.ToString(num) + "', '0', '" + text2 + "', '" + usuario + "')"));
			}
			return text3;
		}
	}

	private void ListView1_DoubleClick(object sender, EventArgs e)
	{
		if (ListView1.SelectedItems.Count <= 0)
		{
			return;
		}
		double num = 0.0;
		int num2 = (int)MessageBox.Show("Desea Eliminar el item " + ListView1.SelectedItems[0].SubItems[2].Text, "Atencion", MessageBoxButtons.YesNoCancel);
		if (num2 == 2 || num2 == 7 || num2 != 6)
		{
			return;
		}
		ListView1.SelectedItems[0].Remove();
		Label6.Text = Conversions.ToString(ListView1.Items.Count);
		foreach (object item in ListView1.Items)
		{
			object objectValue = RuntimeHelpers.GetObjectValue(item);
			num += Conversions.ToDouble(NewLateBinding.LateGet(objectValue, null, "Text", new object[0], null, null, null));
		}
		Label8.Text = Conversions.ToString(num);
	}

	private void ListView1_ColumnClick(object sender, ColumnClickEventArgs e)
	{
		Mod_Ordenaclumnas.ordenar_columnas(ListView1, RuntimeHelpers.GetObjectValue(sender), e);
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void TextBox3_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (e.KeyChar == '\r')
		{
			TextBox2.Focus();
		}
	}
}
