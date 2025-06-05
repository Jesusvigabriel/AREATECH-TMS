using System;
using System.Collections;
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
public class Eventos : Form
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
	[AccessedThroughProperty("ListView3")]
	private ListView _ListView3;

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
			EventHandler value2 = ListView1_SelectedIndexChanged;
			ColumnClickEventHandler value3 = ListView1_ColumnClick;
			ListView listView = _ListView1;
			if (listView != null)
			{
				listView.SelectedIndexChanged -= value2;
				listView.ColumnClick -= value3;
			}
			_ListView1 = value;
			listView = _ListView1;
			if (listView != null)
			{
				listView.SelectedIndexChanged += value2;
				listView.ColumnClick += value3;
			}
		}
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
			EventHandler value2 = ListView2_SelectedIndexChanged;
			ColumnClickEventHandler value3 = ListView2_ColumnClick;
			ListView listView = _ListView2;
			if (listView != null)
			{
				listView.SelectedIndexChanged -= value2;
				listView.ColumnClick -= value3;
			}
			_ListView2 = value;
			listView = _ListView2;
			if (listView != null)
			{
				listView.SelectedIndexChanged += value2;
				listView.ColumnClick += value3;
			}
		}
	}

	[field: AccessedThroughProperty("GroupBox1")]
	internal virtual GroupBox GroupBox1
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

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ListView ListView3
	{
		[CompilerGenerated]
		get
		{
			return _ListView3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ListView3_SelectedIndexChanged;
			ListView listView = _ListView3;
			if (listView != null)
			{
				listView.SelectedIndexChanged -= value2;
			}
			_ListView3 = value;
			listView = _ListView3;
			if (listView != null)
			{
				listView.SelectedIndexChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
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

	public Eventos()
	{
		base.Load += Eventos_Load;
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
		this.ListView1 = new System.Windows.Forms.ListView();
		this.ColumnHeader1 = new System.Windows.Forms.ColumnHeader();
		this.ListView2 = new System.Windows.Forms.ListView();
		this.GroupBox1 = new System.Windows.Forms.GroupBox();
		this.GroupBox2 = new System.Windows.Forms.GroupBox();
		this.Label1 = new System.Windows.Forms.Label();
		this.ListView3 = new System.Windows.Forms.ListView();
		this.Label2 = new System.Windows.Forms.Label();
		this.Label3 = new System.Windows.Forms.Label();
		this.ColumnHeader2 = new System.Windows.Forms.ColumnHeader();
		this.ColumnHeader3 = new System.Windows.Forms.ColumnHeader();
		this.ColumnHeader4 = new System.Windows.Forms.ColumnHeader();
		this.GroupBox1.SuspendLayout();
		this.GroupBox2.SuspendLayout();
		base.SuspendLayout();
		this.ListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[1] { this.ColumnHeader1 });
		this.ListView1.FullRowSelect = true;
		this.ListView1.GridLines = true;
		this.ListView1.Location = new System.Drawing.Point(6, 19);
		this.ListView1.Name = "ListView1";
		this.ListView1.Size = new System.Drawing.Size(286, 201);
		this.ListView1.TabIndex = 0;
		this.ListView1.UseCompatibleStateImageBehavior = false;
		this.ListView1.View = System.Windows.Forms.View.Details;
		this.ListView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[3] { this.ColumnHeader2, this.ColumnHeader3, this.ColumnHeader4 });
		this.ListView2.FullRowSelect = true;
		this.ListView2.GridLines = true;
		this.ListView2.Location = new System.Drawing.Point(6, 19);
		this.ListView2.Name = "ListView2";
		this.ListView2.Size = new System.Drawing.Size(286, 201);
		this.ListView2.TabIndex = 1;
		this.ListView2.UseCompatibleStateImageBehavior = false;
		this.ListView2.View = System.Windows.Forms.View.Details;
		this.GroupBox1.Controls.Add(this.ListView2);
		this.GroupBox1.Location = new System.Drawing.Point(12, 28);
		this.GroupBox1.Name = "GroupBox1";
		this.GroupBox1.Size = new System.Drawing.Size(298, 226);
		this.GroupBox1.TabIndex = 2;
		this.GroupBox1.TabStop = false;
		this.GroupBox1.Text = "Difiere Nombre:";
		this.GroupBox2.Controls.Add(this.ListView1);
		this.GroupBox2.Location = new System.Drawing.Point(12, 260);
		this.GroupBox2.Name = "GroupBox2";
		this.GroupBox2.Size = new System.Drawing.Size(298, 226);
		this.GroupBox2.TabIndex = 3;
		this.GroupBox2.TabStop = false;
		this.GroupBox2.Text = "Difiere Direccion:";
		this.Label1.AutoSize = true;
		this.Label1.Location = new System.Drawing.Point(333, 28);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(39, 13);
		this.Label1.TabIndex = 4;
		this.Label1.Text = "Label1";
		this.ListView3.Location = new System.Drawing.Point(316, 47);
		this.ListView3.Name = "ListView3";
		this.ListView3.Size = new System.Drawing.Size(556, 201);
		this.ListView3.TabIndex = 5;
		this.ListView3.UseCompatibleStateImageBehavior = false;
		this.ListView3.View = System.Windows.Forms.View.Details;
		this.Label2.AutoSize = true;
		this.Label2.Location = new System.Drawing.Point(371, 325);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(39, 13);
		this.Label2.TabIndex = 6;
		this.Label2.Text = "Label2";
		this.Label3.AutoSize = true;
		this.Label3.Location = new System.Drawing.Point(374, 365);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(39, 13);
		this.Label3.TabIndex = 7;
		this.Label3.Text = "Label3";
		this.ColumnHeader2.Text = "Compobante";
		this.ColumnHeader3.Text = "Nombre";
		this.ColumnHeader4.Text = "Direccion";
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(884, 498);
		base.Controls.Add(this.Label3);
		base.Controls.Add(this.Label2);
		base.Controls.Add(this.ListView3);
		base.Controls.Add(this.Label1);
		base.Controls.Add(this.GroupBox2);
		base.Controls.Add(this.GroupBox1);
		base.Name = "Eventos";
		this.Text = "Posicionar";
		this.GroupBox1.ResumeLayout(false);
		this.GroupBox2.ResumeLayout(false);
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private void Eventos_Load(object sender, EventArgs e)
	{
		checked
		{
			try
			{
				ArrayList dir_error = Mod_Rutearmodulo.dir_error;
				int num = Mod_Rutearmodulo.dir_error.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					ListViewItem value = new ListViewItem(dir_error[i].ToString());
					ListView1.Items.Add(value);
				}
				dir_error = null;
				ArrayList nom_error = Mod_Rutearmodulo.nom_error;
				int num2 = Mod_Rutearmodulo.nom_error.Count - 1;
				for (int j = 0; j <= num2; j++)
				{
					ListViewItem value2 = new ListViewItem(nom_error[j].ToString());
					ListView2.Items.Add(value2);
				}
				nom_error = null;
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

	private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
	{
		Selected_item(ListView1);
	}

	private void ListView2_SelectedIndexChanged(object sender, EventArgs e)
	{
		Selected_item(ListView2);
	}

	private void ListView3_SelectedIndexChanged(object sender, EventArgs e)
	{
		Selected_item2(ListView3);
	}

	private void Selected_item(ListView Listview1)
	{
		if (Listview1.SelectedItems.Count > 0)
		{
			int index = Listview1.SelectedIndices[0];
			Label1.Text = Listview1.Items[index].Text;
		}
		Listview1.Refresh();
		cargar_lista_items(Label1.Text);
	}

	private void Selected_item2(ListView Listview1)
	{
		if (Listview1.SelectedItems.Count > 0)
		{
			int index = Listview1.SelectedIndices[0];
			Label2.Text = Listview1.Items[index].Text;
			Label3.Text = Listview1.Items[index].SubItems[1].Text;
		}
		Listview1.Refresh();
	}

	private void cargar_lista_items(string nombre)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected O, but got Unknown
		checked
		{
			try
			{
				string commandText = "SELECT * FROM Planchada WHERE Comprobante='" + nombre + "'";
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
				ListView listView = ListView3;
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
					ListView3.Items.Add(listViewItem);
				}
				dataTable = null;
				ListView listView2 = ListView3;
				int num4 = dataSet.Tables["tabla"].Columns.Count - 1;
				for (int l = 0; l <= num4; l++)
				{
					listView2.AutoResizeColumn(l, ColumnHeaderAutoResizeStyle.ColumnContent);
				}
				listView2 = null;
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

	private void ListView1_ColumnClick(object sender, ColumnClickEventArgs e)
	{
		Mod_Ordenaclumnas.ordenar_columnas(ListView1, RuntimeHelpers.GetObjectValue(sender), e);
	}

	private void ListView2_ColumnClick(object sender, ColumnClickEventArgs e)
	{
		Mod_Ordenaclumnas.ordenar_columnas(ListView2, RuntimeHelpers.GetObjectValue(sender), e);
	}
}
