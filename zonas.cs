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
public class zonas : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ComboBox1")]
	private ComboBox _ComboBox1;

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
	[AccessedThroughProperty("ComboBox2")]
	private ComboBox _ComboBox2;

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
	[AccessedThroughProperty("Button5")]
	private Button _Button5;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("salirbtn")]
	private Button _salirbtn;

	private string fecha1;

	[field: AccessedThroughProperty("GroupBox1")]
	internal virtual GroupBox GroupBox1
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
			ListView listView = _ListView1;
			if (listView != null)
			{
				listView.SelectedIndexChanged -= value2;
			}
			_ListView1 = value;
			listView = _ListView1;
			if (listView != null)
			{
				listView.SelectedIndexChanged += value2;
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
			ListView listView = _ListView2;
			if (listView != null)
			{
				listView.SelectedIndexChanged -= value2;
			}
			_ListView2 = value;
			listView = _ListView2;
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

	internal virtual ComboBox ComboBox2
	{
		[CompilerGenerated]
		get
		{
			return _ComboBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ComboBox2_SelectedIndexChanged;
			ComboBox comboBox = _ComboBox2;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged -= value2;
			}
			_ComboBox2 = value;
			comboBox = _ComboBox2;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged += value2;
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

	[field: AccessedThroughProperty("Button3")]
	internal virtual Button Button3
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

	[field: AccessedThroughProperty("Button6")]
	internal virtual Button Button6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button salirbtn
	{
		[CompilerGenerated]
		get
		{
			return _salirbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = salirbtn_Click;
			Button button = _salirbtn;
			if (button != null)
			{
				button.Click -= value2;
			}
			_salirbtn = value;
			button = _salirbtn;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
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

	[field: AccessedThroughProperty("Label5")]
	internal virtual Label Label5
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

	[field: AccessedThroughProperty("Label7")]
	internal virtual Label Label7
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

	public zonas()
	{
		base.Load += zonas_Load;
		fecha1 = Strings.Format(MyProject.Forms.Form1_Inicio.DateTimePicker1.Value, "yyyyMMdd");
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
		this.ListView1 = new System.Windows.Forms.ListView();
		this.Label1 = new System.Windows.Forms.Label();
		this.ComboBox1 = new System.Windows.Forms.ComboBox();
		this.GroupBox2 = new System.Windows.Forms.GroupBox();
		this.Label4 = new System.Windows.Forms.Label();
		this.ListView2 = new System.Windows.Forms.ListView();
		this.ComboBox2 = new System.Windows.Forms.ComboBox();
		this.Label2 = new System.Windows.Forms.Label();
		this.Button1 = new System.Windows.Forms.Button();
		this.Button2 = new System.Windows.Forms.Button();
		this.Button3 = new System.Windows.Forms.Button();
		this.Button4 = new System.Windows.Forms.Button();
		this.Button5 = new System.Windows.Forms.Button();
		this.Button6 = new System.Windows.Forms.Button();
		this.salirbtn = new System.Windows.Forms.Button();
		this.Label3 = new System.Windows.Forms.Label();
		this.Label5 = new System.Windows.Forms.Label();
		this.Label6 = new System.Windows.Forms.Label();
		this.Label7 = new System.Windows.Forms.Label();
		this.Label8 = new System.Windows.Forms.Label();
		this.GroupBox1.SuspendLayout();
		this.GroupBox2.SuspendLayout();
		base.SuspendLayout();
		this.GroupBox1.Controls.Add(this.Label7);
		this.GroupBox1.Controls.Add(this.ListView1);
		this.GroupBox1.Controls.Add(this.Label1);
		this.GroupBox1.Controls.Add(this.ComboBox1);
		this.GroupBox1.Location = new System.Drawing.Point(12, 12);
		this.GroupBox1.Name = "GroupBox1";
		this.GroupBox1.Size = new System.Drawing.Size(370, 450);
		this.GroupBox1.TabIndex = 0;
		this.GroupBox1.TabStop = false;
		this.GroupBox1.Text = "Zonas";
		this.ListView1.Location = new System.Drawing.Point(9, 46);
		this.ListView1.Name = "ListView1";
		this.ListView1.Size = new System.Drawing.Size(351, 393);
		this.ListView1.TabIndex = 2;
		this.ListView1.UseCompatibleStateImageBehavior = false;
		this.Label1.AutoSize = true;
		this.Label1.Location = new System.Drawing.Point(136, 22);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(63, 13);
		this.Label1.TabIndex = 1;
		this.Label1.Text = "Descripcion";
		this.ComboBox1.FormattingEnabled = true;
		this.ComboBox1.Location = new System.Drawing.Point(9, 19);
		this.ComboBox1.Name = "ComboBox1";
		this.ComboBox1.Size = new System.Drawing.Size(121, 21);
		this.ComboBox1.TabIndex = 0;
		this.GroupBox2.Controls.Add(this.Label8);
		this.GroupBox2.Controls.Add(this.Label4);
		this.GroupBox2.Controls.Add(this.ListView2);
		this.GroupBox2.Controls.Add(this.ComboBox2);
		this.GroupBox2.Location = new System.Drawing.Point(469, 12);
		this.GroupBox2.Name = "GroupBox2";
		this.GroupBox2.Size = new System.Drawing.Size(370, 450);
		this.GroupBox2.TabIndex = 1;
		this.GroupBox2.TabStop = false;
		this.GroupBox2.Text = "Localidades";
		this.Label4.AutoSize = true;
		this.Label4.Location = new System.Drawing.Point(137, 22);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(63, 13);
		this.Label4.TabIndex = 3;
		this.Label4.Text = "Descripcion";
		this.ListView2.Location = new System.Drawing.Point(10, 46);
		this.ListView2.Name = "ListView2";
		this.ListView2.Size = new System.Drawing.Size(351, 393);
		this.ListView2.TabIndex = 2;
		this.ListView2.UseCompatibleStateImageBehavior = false;
		this.ComboBox2.FormattingEnabled = true;
		this.ComboBox2.Location = new System.Drawing.Point(10, 19);
		this.ComboBox2.Name = "ComboBox2";
		this.ComboBox2.Size = new System.Drawing.Size(121, 21);
		this.ComboBox2.TabIndex = 0;
		this.Label2.AutoSize = true;
		this.Label2.Location = new System.Drawing.Point(393, 222);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(39, 13);
		this.Label2.TabIndex = 1;
		this.Label2.Text = "Label2";
		this.Button1.Location = new System.Drawing.Point(388, 58);
		this.Button1.Name = "Button1";
		this.Button1.Size = new System.Drawing.Size(75, 23);
		this.Button1.TabIndex = 2;
		this.Button1.Text = "<< Agregar";
		this.Button1.UseVisualStyleBackColor = true;
		this.Button2.Location = new System.Drawing.Point(388, 87);
		this.Button2.Name = "Button2";
		this.Button2.Size = new System.Drawing.Size(75, 23);
		this.Button2.TabIndex = 3;
		this.Button2.Text = "Quitar >>";
		this.Button2.UseVisualStyleBackColor = true;
		this.Button3.Location = new System.Drawing.Point(388, 116);
		this.Button3.Name = "Button3";
		this.Button3.Size = new System.Drawing.Size(75, 23);
		this.Button3.TabIndex = 4;
		this.Button3.Text = "Button3";
		this.Button3.UseVisualStyleBackColor = true;
		this.Button3.Visible = false;
		this.Button4.Location = new System.Drawing.Point(388, 145);
		this.Button4.Name = "Button4";
		this.Button4.Size = new System.Drawing.Size(75, 23);
		this.Button4.TabIndex = 5;
		this.Button4.Text = "Button4";
		this.Button4.UseVisualStyleBackColor = true;
		this.Button4.Visible = false;
		this.Button5.Location = new System.Drawing.Point(388, 370);
		this.Button5.Name = "Button5";
		this.Button5.Size = new System.Drawing.Size(75, 23);
		this.Button5.TabIndex = 6;
		this.Button5.Text = "Localidades";
		this.Button5.UseVisualStyleBackColor = true;
		this.Button6.Location = new System.Drawing.Point(388, 399);
		this.Button6.Name = "Button6";
		this.Button6.Size = new System.Drawing.Size(75, 23);
		this.Button6.TabIndex = 7;
		this.Button6.Text = "Button6";
		this.Button6.UseVisualStyleBackColor = true;
		this.Button6.Visible = false;
		this.salirbtn.Location = new System.Drawing.Point(388, 428);
		this.salirbtn.Name = "salirbtn";
		this.salirbtn.Size = new System.Drawing.Size(75, 23);
		this.salirbtn.TabIndex = 8;
		this.salirbtn.Text = "Salir";
		this.salirbtn.UseVisualStyleBackColor = true;
		this.Label3.AutoSize = true;
		this.Label3.Location = new System.Drawing.Point(393, 245);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(39, 13);
		this.Label3.TabIndex = 9;
		this.Label3.Text = "Label3";
		this.Label5.AutoSize = true;
		this.Label5.Location = new System.Drawing.Point(393, 273);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(39, 13);
		this.Label5.TabIndex = 10;
		this.Label5.Text = "Label5";
		this.Label6.AutoSize = true;
		this.Label6.Location = new System.Drawing.Point(404, 34);
		this.Label6.Name = "Label6";
		this.Label6.Size = new System.Drawing.Size(39, 13);
		this.Label6.TabIndex = 11;
		this.Label6.Text = "Label6";
		this.Label7.AutoSize = true;
		this.Label7.Location = new System.Drawing.Point(321, 22);
		this.Label7.Name = "Label7";
		this.Label7.Size = new System.Drawing.Size(39, 13);
		this.Label7.TabIndex = 3;
		this.Label7.Text = "Label7";
		this.Label8.AutoSize = true;
		this.Label8.Location = new System.Drawing.Point(322, 22);
		this.Label8.Name = "Label8";
		this.Label8.Size = new System.Drawing.Size(39, 13);
		this.Label8.TabIndex = 4;
		this.Label8.Text = "Label8";
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(852, 469);
		base.Controls.Add(this.Label6);
		base.Controls.Add(this.Label5);
		base.Controls.Add(this.Label3);
		base.Controls.Add(this.Label2);
		base.Controls.Add(this.salirbtn);
		base.Controls.Add(this.Button6);
		base.Controls.Add(this.Button5);
		base.Controls.Add(this.Button4);
		base.Controls.Add(this.Button3);
		base.Controls.Add(this.Button2);
		base.Controls.Add(this.Button1);
		base.Controls.Add(this.GroupBox2);
		base.Controls.Add(this.GroupBox1);
		base.Name = "zonas";
		base.ShowIcon = false;
		this.Text = "zonas";
		this.GroupBox1.ResumeLayout(false);
		this.GroupBox1.PerformLayout();
		this.GroupBox2.ResumeLayout(false);
		this.GroupBox2.PerformLayout();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private void zonas_Load(object sender, EventArgs e)
	{
		string sql = "SELECT * FROM Localidades  where zona=0 order by CP";
		Mod_Sentencias.cargar_datos_lv_completa(ListView2, sql, Label8);
		Mod_Sentencias.cargar_zonas_combo(ComboBox1);
		Mod_Sentencias.cargar_zonas_combo(ComboBox2);
		ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
		ComboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		checked
		{
			if (ListView2.SelectedItems.Count > 0)
			{
				string sQL = "UPDATE Localidades SET Zona= " + Conversions.ToString(ComboBox1.SelectedIndex + 1) + " WHERE CP= '" + Label2.Text + "' ";
				Mod_ConeccionBD.BD_Sentencia(sQL);
				string sQL2 = "UPDATE Eventuales SET Zona=" + Conversions.ToString(ComboBox1.SelectedIndex + 1) + " WHERE CP='" + Label2.Text + "' ";
				Mod_ConeccionBD.BD_Sentencia(sQL2);
				string sQL3 = ("UPDATE Planchada SET Zona=" + Conversions.ToString(ComboBox1.SelectedIndex + 1) + " WHERE CP='" + Label2.Text + "' And Fecha=" + fecha1) ?? "";
				Mod_ConeccionBD.BD_Sentencia(sQL3);
				string sql = "SELECT * FROM Localidades  where zona=" + Conversions.ToString(ComboBox1.SelectedIndex + 1) + " order by CP";
				Mod_Sentencias.cargar_datos_lv(ListView1, sql, Label7);
				ListView2.Items.Remove(ListView2.SelectedItems[0]);
				if (Conversions.ToDouble(Label8.Text) > 0.0)
				{
					Label8.Text = Conversions.ToString(Conversions.ToDouble(Label8.Text) - 1.0);
				}
				else
				{
					Label8.Text = Conversions.ToString(0);
				}
			}
			else
			{
				Interaction.MsgBox("Seleccione una Localidad");
			}
		}
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		checked
		{
			if (ListView1.SelectedItems.Count > 0)
			{
				string sQL = "UPDATE Localidades SET Zona=" + Conversions.ToString(ComboBox2.SelectedIndex + 1) + " WHERE CP= '" + Label2.Text + "' ";
				Mod_ConeccionBD.BD_Sentencia(sQL);
				string sQL2 = "UPDATE Eventuales SET Zona=" + Conversions.ToString(ComboBox2.SelectedIndex + 1) + " WHERE CP='" + Label2.Text + "' ";
				Mod_ConeccionBD.BD_Sentencia(sQL2);
				string sQL3 = ("UPDATE Planchada SET Zona=" + Conversions.ToString(ComboBox2.SelectedIndex + 1) + " WHERE CP='" + Label2.Text + "' And Fecha=" + fecha1) ?? "";
				Mod_ConeccionBD.BD_Sentencia(sQL3);
				string sql = "SELECT * FROM Localidades  where zona=" + Conversions.ToString(ComboBox2.SelectedIndex + 1) + " order by CP";
				Mod_Sentencias.cargar_datos_lv(ListView2, sql, Label8);
				ListView1.Items.Remove(ListView1.SelectedItems[0]);
				if (Conversions.ToDouble(Label7.Text) > 0.0)
				{
					Label7.Text = Conversions.ToString(Conversions.ToDouble(Label7.Text) - 1.0);
				}
				else
				{
					Label7.Text = Conversions.ToString(0);
				}
			}
			else
			{
				Interaction.MsgBox("Seleccione una Localidad");
			}
		}
	}

	private void salirbtn_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void Button5_Click(object sender, EventArgs e)
	{
		MyProject.Forms.Localidades.MdiParent = MyProject.Forms.Form1_Inicio;
		MyProject.Forms.Localidades.Show();
	}

	private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		DataTable dataTable = new DataTable("x");
		checked
		{
			string text = ("SELECT Descripcion FROM Zonas where Zona=" + Conversions.ToString(ComboBox1.SelectedIndex + 1)) ?? "";
			MySqlDataAdapter val = new MySqlDataAdapter(text, Mod_Sentencias.cnn);
			((DbDataAdapter)(object)val).Fill(dataTable);
			Label1.Text = dataTable.Rows[0]["Descripcion"].ToString();
			Label2.Text = Conversions.ToString(ComboBox1.SelectedIndex + 1);
			string sql = "SELECT * FROM Localidades where Zona=" + Conversions.ToString(ComboBox1.SelectedIndex + 1) + " order by CP";
			Mod_Sentencias.cargar_datos_lv_completa(ListView1, sql, Label7);
		}
	}

	private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		DataTable dataTable = new DataTable("x");
		checked
		{
			string text = ("SELECT Descripcion FROM Zonas where Zona=" + Conversions.ToString(ComboBox2.SelectedIndex + 1)) ?? "";
			MySqlDataAdapter val = new MySqlDataAdapter(text, Mod_Sentencias.cnn);
			((DbDataAdapter)(object)val).Fill(dataTable);
			Label4.Text = dataTable.Rows[0]["Descripcion"].ToString();
			Label5.Text = ComboBox2.Text;
			string sql = "SELECT * FROM Localidades where Zona=" + Conversions.ToString(ComboBox2.SelectedIndex + 1) + " order by CP";
			Mod_Sentencias.cargar_datos_lv_completa(ListView2, sql, Label8);
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

	private void Selected_item(ListView Listview1)
	{
		if (Listview1.SelectedItems.Count > 0)
		{
			int index = Listview1.SelectedIndices[0];
			Label2.Text = Listview1.Items[index].SubItems[2].Text;
			Label3.Text = Listview1.Items[index].SubItems[3].Text;
		}
		Listview1.Refresh();
	}
}
