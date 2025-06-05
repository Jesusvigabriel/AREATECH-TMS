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
public class Cambiar_Ch : Form
{
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

	private string fecha1;

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

	[field: AccessedThroughProperty("TextBox1")]
	internal virtual TextBox TextBox1
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

	[field: AccessedThroughProperty("Label4")]
	internal virtual Label Label4
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

	[field: AccessedThroughProperty("ComboBox2")]
	internal virtual ComboBox ComboBox2
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

	public Cambiar_Ch()
	{
		base.Load += Cambiar_Ch_Load;
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
		this.Button1 = new System.Windows.Forms.Button();
		this.Button2 = new System.Windows.Forms.Button();
		this.TextBox1 = new System.Windows.Forms.TextBox();
		this.Label1 = new System.Windows.Forms.Label();
		this.Label2 = new System.Windows.Forms.Label();
		this.Label3 = new System.Windows.Forms.Label();
		this.Label4 = new System.Windows.Forms.Label();
		this.ComboBox1 = new System.Windows.Forms.ComboBox();
		this.ComboBox2 = new System.Windows.Forms.ComboBox();
		this.Label5 = new System.Windows.Forms.Label();
		base.SuspendLayout();
		this.Button1.Location = new System.Drawing.Point(12, 115);
		this.Button1.Name = "Button1";
		this.Button1.Size = new System.Drawing.Size(75, 23);
		this.Button1.TabIndex = 0;
		this.Button1.Text = "Button1";
		this.Button1.UseVisualStyleBackColor = true;
		this.Button2.Location = new System.Drawing.Point(287, 115);
		this.Button2.Name = "Button2";
		this.Button2.Size = new System.Drawing.Size(75, 23);
		this.Button2.TabIndex = 1;
		this.Button2.Text = "Button2";
		this.Button2.UseVisualStyleBackColor = true;
		this.TextBox1.Location = new System.Drawing.Point(77, 21);
		this.TextBox1.Name = "TextBox1";
		this.TextBox1.Size = new System.Drawing.Size(218, 20);
		this.TextBox1.TabIndex = 2;
		this.Label1.AutoSize = true;
		this.Label1.Location = new System.Drawing.Point(17, 24);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(40, 13);
		this.Label1.TabIndex = 3;
		this.Label1.Text = "Actual:";
		this.Label2.AutoSize = true;
		this.Label2.Location = new System.Drawing.Point(15, 58);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(42, 13);
		this.Label2.TabIndex = 4;
		this.Label2.Text = "Nuevo:";
		this.Label3.AutoSize = true;
		this.Label3.Location = new System.Drawing.Point(104, 120);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(39, 13);
		this.Label3.TabIndex = 5;
		this.Label3.Text = "Label3";
		this.Label3.Visible = false;
		this.Label4.AutoSize = true;
		this.Label4.Location = new System.Drawing.Point(228, 120);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(39, 13);
		this.Label4.TabIndex = 6;
		this.Label4.Text = "Label4";
		this.Label4.Visible = false;
		this.ComboBox1.FormattingEnabled = true;
		this.ComboBox1.Location = new System.Drawing.Point(77, 55);
		this.ComboBox1.Name = "ComboBox1";
		this.ComboBox1.Size = new System.Drawing.Size(218, 21);
		this.ComboBox1.TabIndex = 7;
		this.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.ComboBox2.FormattingEnabled = true;
		this.ComboBox2.Items.AddRange(new object[3] { "1", "2", "3" });
		this.ComboBox2.Location = new System.Drawing.Point(155, 86);
		this.ComboBox2.Name = "ComboBox2";
		this.ComboBox2.Size = new System.Drawing.Size(43, 21);
		this.ComboBox2.TabIndex = 8;
		this.Label5.AutoSize = true;
		this.Label5.Location = new System.Drawing.Point(17, 89);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(50, 13);
		this.Label5.TabIndex = 9;
		this.Label5.Text = "Ventana:";
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(374, 150);
		base.Controls.Add(this.Label5);
		base.Controls.Add(this.ComboBox2);
		base.Controls.Add(this.ComboBox1);
		base.Controls.Add(this.Label4);
		base.Controls.Add(this.Label3);
		base.Controls.Add(this.Label2);
		base.Controls.Add(this.Label1);
		base.Controls.Add(this.TextBox1);
		base.Controls.Add(this.Button2);
		base.Controls.Add(this.Button1);
		base.Name = "Cambiar_Ch";
		this.Text = "Cambiar Chofer";
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private void Cambiar_Ch_Load(object sender, EventArgs e)
	{
		Button1.Text = "Cambiar";
		Button2.Text = "Cancelar";
		cargar_chof();
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(TextBox1.Text, ComboBox1.Text, TextCompare: true) == 0)
		{
			Interaction.MsgBox("No se puede cambiar al mismo chofer");
		}
		else
		{
			cambiar_chofer();
		}
	}

	private void cambiar_chofer()
	{
		string sQL = "UPDATE Planchada SET Chofer=200 WHERE Chofer= " + Label3.Text + " And Ventana= " + MyProject.Forms.Form1_Inicio.ComboBox1.Text + " And Fecha='" + fecha1 + "'";
		Mod_ConeccionBD.BD_Sentencia(sQL);
		string sQL2 = "UPDATE Planchada SET Chofer=" + Label3.Text + ", Ventana= " + MyProject.Forms.Form1_Inicio.ComboBox1.Text + " WHERE Chofer= " + Label4.Text + " And Ventana= " + ComboBox2.Text + "  And Fecha='" + fecha1 + "'";
		Mod_ConeccionBD.BD_Sentencia(sQL2);
		string sQL3 = "UPDATE Planchada SET Chofer=" + Label4.Text + ", Ventana= " + ComboBox2.Text + " WHERE Chofer= 200  And Fecha='" + fecha1 + "'";
		Mod_ConeccionBD.BD_Sentencia(sQL3);
		Rutas rutas = MyProject.Forms.Rutas;
		rutas.ListView1.SelectedItems[0].ForeColor = Color.Blue;
		rutas.ListView2.Items.Clear();
		rutas.Refresh();
		rutas = null;
		Close();
	}

	private void cargar_chof()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		DataTable dataTable = new DataTable("x");
		string text = "SELECT Chofer FROM Flota where Disponible='Si' and Estado='Activo' ORDER BY Chofer";
		MySqlDataAdapter val = new MySqlDataAdapter(text, Mod_Sentencias.cnn);
		DataSet dataSet = new DataSet();
		((DbDataAdapter)(object)val).Fill(dataSet, "tabla");
		ComboBox1.Items.Clear();
		DataTable dataTable2 = dataSet.Tables["tabla"];
		foreach (DataRow row in dataTable2.Rows)
		{
			ComboBox1.Items.Add(RuntimeHelpers.GetObjectValue(row["Chofer"]));
		}
		ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
	}

	private void segundo_chof()
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		DataTable dataTable = new DataTable("x");
		string text = "SELECT numero FROM FLota where Chofer = '" + ComboBox1.Text + "'";
		MySqlDataAdapter val = new MySqlDataAdapter(text, Mod_Sentencias.cnn);
		((DbDataAdapter)(object)val).Fill(dataTable);
		Label4.Text = dataTable.Rows[0]["numero"].ToString();
	}

	private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
	{
		segundo_chof();
	}
}
