using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Hermes.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Hermes;

[DesignerGenerated]
public class Descarga : Form
{
	public struct rolloId
	{
		public string rollo;

		public int pallet;

		public string observacion;

		public DateTime fecha;

		public string usuario;
	}

	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("TextBox1")]
	private TextBox _TextBox1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ListView1")]
	private ListView _ListView1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[field: AccessedThroughProperty("GroupBox1")]
	internal virtual GroupBox GroupBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual TextBox TextBox1
	{
		[CompilerGenerated]
		get
		{
			return _TextBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			KeyPressEventHandler value2 = TextBox1_KeyPress;
			TextBox textBox = _TextBox1;
			if (textBox != null)
			{
				textBox.KeyPress -= value2;
			}
			_TextBox1 = value;
			textBox = _TextBox1;
			if (textBox != null)
			{
				textBox.KeyPress += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
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
			EventHandler value3 = ListView1_DoubleClick;
			ListView listView = _ListView1;
			if (listView != null)
			{
				listView.ColumnClick -= value2;
				listView.DoubleClick -= value3;
			}
			_ListView1 = value;
			listView = _ListView1;
			if (listView != null)
			{
				listView.ColumnClick += value2;
				listView.DoubleClick += value3;
			}
		}
	}

	[field: AccessedThroughProperty("GroupBox3")]
	internal virtual GroupBox GroupBox3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("GroupBox4")]
	internal virtual GroupBox GroupBox4
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

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
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

	[field: AccessedThroughProperty("Label9")]
	internal virtual Label Label9
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

	public Descarga()
	{
		base.Load += Descarga_Load;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hermes.Descarga));
		this.GroupBox1 = new System.Windows.Forms.GroupBox();
		this.TextBox1 = new System.Windows.Forms.TextBox();
		this.Label1 = new System.Windows.Forms.Label();
		this.GroupBox2 = new System.Windows.Forms.GroupBox();
		this.ListView1 = new System.Windows.Forms.ListView();
		this.ColumnHeader1 = new System.Windows.Forms.ColumnHeader();
		this.ColumnHeader2 = new System.Windows.Forms.ColumnHeader();
		this.ColumnHeader3 = new System.Windows.Forms.ColumnHeader();
		this.GroupBox3 = new System.Windows.Forms.GroupBox();
		this.Label9 = new System.Windows.Forms.Label();
		this.Label8 = new System.Windows.Forms.Label();
		this.Label7 = new System.Windows.Forms.Label();
		this.Label6 = new System.Windows.Forms.Label();
		this.Label5 = new System.Windows.Forms.Label();
		this.Label4 = new System.Windows.Forms.Label();
		this.Label3 = new System.Windows.Forms.Label();
		this.Label2 = new System.Windows.Forms.Label();
		this.GroupBox4 = new System.Windows.Forms.GroupBox();
		this.Button1 = new System.Windows.Forms.Button();
		this.GroupBox1.SuspendLayout();
		this.GroupBox2.SuspendLayout();
		this.GroupBox3.SuspendLayout();
		this.GroupBox4.SuspendLayout();
		base.SuspendLayout();
		this.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.GroupBox1.Controls.Add(this.TextBox1);
		this.GroupBox1.Controls.Add(this.Label1);
		this.GroupBox1.Location = new System.Drawing.Point(12, 12);
		this.GroupBox1.Name = "GroupBox1";
		this.GroupBox1.Size = new System.Drawing.Size(639, 43);
		this.GroupBox1.TabIndex = 0;
		this.GroupBox1.TabStop = false;
		this.TextBox1.Location = new System.Drawing.Point(67, 13);
		this.TextBox1.Name = "TextBox1";
		this.TextBox1.Size = new System.Drawing.Size(158, 20);
		this.TextBox1.TabIndex = 1;
		this.Label1.AutoSize = true;
		this.Label1.Location = new System.Drawing.Point(15, 16);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(46, 13);
		this.Label1.TabIndex = 0;
		this.Label1.Text = "Código: ";
		this.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.GroupBox2.Controls.Add(this.ListView1);
		this.GroupBox2.Location = new System.Drawing.Point(12, 61);
		this.GroupBox2.Name = "GroupBox2";
		this.GroupBox2.Size = new System.Drawing.Size(322, 292);
		this.GroupBox2.TabIndex = 1;
		this.GroupBox2.TabStop = false;
		this.ListView1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.ListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[3] { this.ColumnHeader1, this.ColumnHeader2, this.ColumnHeader3 });
		this.ListView1.FullRowSelect = true;
		this.ListView1.GridLines = true;
		this.ListView1.Location = new System.Drawing.Point(6, 12);
		this.ListView1.Name = "ListView1";
		this.ListView1.Size = new System.Drawing.Size(310, 272);
		this.ListView1.TabIndex = 0;
		this.ListView1.UseCompatibleStateImageBehavior = false;
		this.ListView1.View = System.Windows.Forms.View.Details;
		this.ColumnHeader1.Text = "Lectura";
		this.ColumnHeader1.Width = 86;
		this.ColumnHeader2.Text = "Pallet";
		this.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		this.ColumnHeader3.Text = "Rollo";
		this.GroupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		this.GroupBox3.Controls.Add(this.Label9);
		this.GroupBox3.Controls.Add(this.Label8);
		this.GroupBox3.Controls.Add(this.Label7);
		this.GroupBox3.Controls.Add(this.Label6);
		this.GroupBox3.Controls.Add(this.Label5);
		this.GroupBox3.Controls.Add(this.Label4);
		this.GroupBox3.Controls.Add(this.Label3);
		this.GroupBox3.Controls.Add(this.Label2);
		this.GroupBox3.Location = new System.Drawing.Point(340, 61);
		this.GroupBox3.Name = "GroupBox3";
		this.GroupBox3.Size = new System.Drawing.Size(311, 292);
		this.GroupBox3.TabIndex = 2;
		this.GroupBox3.TabStop = false;
		this.Label9.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.Label9.AutoSize = true;
		this.Label9.Location = new System.Drawing.Point(88, 203);
		this.Label9.Name = "Label9";
		this.Label9.Size = new System.Drawing.Size(39, 13);
		this.Label9.TabIndex = 7;
		this.Label9.Text = "Label9";
		this.Label8.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.Label8.AutoSize = true;
		this.Label8.Location = new System.Drawing.Point(88, 176);
		this.Label8.Name = "Label8";
		this.Label8.Size = new System.Drawing.Size(39, 13);
		this.Label8.TabIndex = 6;
		this.Label8.Text = "Label8";
		this.Label7.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.Label7.AutoSize = true;
		this.Label7.Location = new System.Drawing.Point(88, 125);
		this.Label7.Name = "Label7";
		this.Label7.Size = new System.Drawing.Size(39, 13);
		this.Label7.TabIndex = 5;
		this.Label7.Text = "Label7";
		this.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.Label6.AutoSize = true;
		this.Label6.Location = new System.Drawing.Point(88, 53);
		this.Label6.Name = "Label6";
		this.Label6.Size = new System.Drawing.Size(39, 13);
		this.Label6.TabIndex = 4;
		this.Label6.Text = "Label6";
		this.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.Label5.AutoSize = true;
		this.Label5.Location = new System.Drawing.Point(7, 203);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(67, 13);
		this.Label5.TabIndex = 3;
		this.Label5.Text = "Observados:";
		this.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.Label4.AutoSize = true;
		this.Label4.Location = new System.Drawing.Point(7, 176);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(66, 13);
		this.Label4.TabIndex = 2;
		this.Label4.Text = "Excedentes:";
		this.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.Label3.AutoSize = true;
		this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label3.Location = new System.Drawing.Point(6, 120);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(60, 20);
		this.Label3.TabIndex = 1;
		this.Label3.Text = "Leidos:";
		this.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.Label2.AutoSize = true;
		this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label2.Location = new System.Drawing.Point(6, 48);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(52, 20);
		this.Label2.TabIndex = 0;
		this.Label2.Text = "Pallet:";
		this.GroupBox4.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.GroupBox4.Controls.Add(this.Button1);
		this.GroupBox4.Location = new System.Drawing.Point(12, 359);
		this.GroupBox4.Name = "GroupBox4";
		this.GroupBox4.Size = new System.Drawing.Size(639, 37);
		this.GroupBox4.TabIndex = 3;
		this.GroupBox4.TabStop = false;
		this.Button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		this.Button1.Location = new System.Drawing.Point(533, 10);
		this.Button1.Name = "Button1";
		this.Button1.Size = new System.Drawing.Size(75, 23);
		this.Button1.TabIndex = 0;
		this.Button1.Text = "Guardar";
		this.Button1.UseVisualStyleBackColor = true;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(663, 408);
		base.Controls.Add(this.GroupBox4);
		base.Controls.Add(this.GroupBox3);
		base.Controls.Add(this.GroupBox2);
		base.Controls.Add(this.GroupBox1);
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.Name = "Descarga";
		this.Text = "Descarga";
		this.GroupBox1.ResumeLayout(false);
		this.GroupBox1.PerformLayout();
		this.GroupBox2.ResumeLayout(false);
		this.GroupBox3.ResumeLayout(false);
		this.GroupBox3.PerformLayout();
		this.GroupBox4.ResumeLayout(false);
		base.ResumeLayout(false);
	}

	private void Descarga_Load(object sender, EventArgs e)
	{
		inicio();
	}

	private void inicio()
	{
		try
		{
			ListView1.Items.Clear();
			string text = Strings.Format(DateAndTime.Now, "yyyy-MM-dd");
			string sql = "SELECT max(pallet) as pallet from descarga where fecha like '%" + text + "%' LIMIT 1";
			DataTable dataTable = (DataTable)Mod_Sentencias.data(sql);
			if (dataTable.Rows.Count > 0)
			{
				if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["pallet"])))
				{
					Label6.Text = Conversions.ToString(1);
				}
				else
				{
					Label6.Text = Conversions.ToString(Operators.AddObject(dataTable.Rows[0]["pallet"], 1));
				}
			}
			else
			{
				Label6.Text = Conversions.ToString(1);
				Interaction.MsgBox("No hay detalle");
			}
			Label7.Text = Conversions.ToString(0);
			Label8.Text = Conversions.ToString(0);
			Label9.Text = Conversions.ToString(0);
			TextBox1.Focus();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox(ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (e.KeyChar != '\r')
		{
			return;
		}
		if (Operators.CompareString(TextBox1.Text, "", TextCompare: true) != 0)
		{
			string text = TextBox1.Text;
			if (Conversions.ToInteger(duplicado(text)) == 0)
			{
				int length = TextBox1.Text.Length;
				int startIndex = checked(length - 2);
				ListViewItem listViewItem = new ListViewItem();
				listViewItem.Text = text;
				listViewItem.SubItems.Add(Label6.Text);
				listViewItem.SubItems.Add(text.Remove(startIndex, 2));
				ListView1.Items.Add(listViewItem);
			}
			else
			{
				Interaction.MsgBox("El código ya fue ingresado");
			}
		}
		else
		{
			Interaction.MsgBox("Debe ingresar un codigo de barras.");
		}
		TextBox1.Clear();
		Label7.Text = Conversions.ToString(ListView1.Items.Count);
		TextBox1.Focus();
	}

	private object duplicado(string valorBuscado)
	{
		ListViewItem listViewItem = null;
		if (ListView1.Items.Count > 0)
		{
			listViewItem = ListView1.FindItemWithText(valorBuscado, includeSubItemsInSearch: true, 0);
		}
		if (listViewItem != null)
		{
			return 1;
		}
		return 0;
	}

	private void ListView1_ColumnClick(object sender, ColumnClickEventArgs e)
	{
		Mod_Ordenaclumnas.ordenar_columnas(ListView1, RuntimeHelpers.GetObjectValue(sender), e);
	}

	private void ListView1_DoubleClick(object sender, EventArgs e)
	{
		if (ListView1.SelectedItems.Count > 0)
		{
			int num = (int)MessageBox.Show("Desea Eliminar el item " + ListView1.SelectedItems[0].Text, "Atencion", MessageBoxButtons.YesNoCancel);
			if (num != 2 && num != 7 && num == 6)
			{
				ListView1.SelectedItems[0].Remove();
				Label7.Text = Conversions.ToString(ListView1.Items.Count);
			}
		}
		TextBox1.Focus();
	}

	private void descargaRollo()
	{
		List<rolloId> list = new List<rolloId>();
		foreach (ListViewItem item2 in ListView1.Items)
		{
			rolloId item = default(rolloId);
			item.rollo = item2.SubItems[2].Text;
			item.pallet = Conversions.ToInteger(item2.SubItems[1].Text);
			item.fecha = DateAndTime.Now;
			item.usuario = MySettingsProperty.Settings.Usuario;
			list.Add(item);
		}
		insertPallet(list);
		inicio();
	}

	private void insertPallet(List<rolloId> listRollos)
	{
		int num = 0;
		foreach (rolloId listRollo in listRollos)
		{
			try
			{
				string sQL = "INSERT INTO descarga (rollo, pallet, observaciones, fecha, usuario)\nVALUES ('" + listRollo.rollo + "', '" + Conversions.ToString(listRollo.pallet) + "', '" + listRollo.observacion + "', NULL, '" + listRollo.usuario + "')";
				Mod_ConeccionBD.BD_insert_ID(sQL);
				num = checked(num + 1);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Logger.e(ex2.Message);
				ProjectData.ClearProjectError();
			}
		}
		if (num == listRollos.Count)
		{
			Interaction.MsgBox("Guardado OK");
		}
		else
		{
			Interaction.MsgBox("Ocurrio un error: " + Conversions.ToString(num) + " distinto de: " + Conversions.ToString(listRollos.Count));
		}
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		descargaRollo();
	}
}
