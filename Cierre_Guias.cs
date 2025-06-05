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
public class Cierre_Guias : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("TextBox1")]
	private TextBox _TextBox1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	private string fecha1;

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
			EventHandler value2 = TextBox1_TextChanged;
			TextBox textBox = _TextBox1;
			if (textBox != null)
			{
				textBox.TextChanged -= value2;
			}
			_TextBox1 = value;
			textBox = _TextBox1;
			if (textBox != null)
			{
				textBox.TextChanged += value2;
			}
		}
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

	[field: AccessedThroughProperty("ComboBox1")]
	internal virtual ComboBox ComboBox1
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

	[field: AccessedThroughProperty("Label5")]
	internal virtual Label Label5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CheckBox1")]
	internal virtual CheckBox CheckBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public Cierre_Guias()
	{
		base.Load += Cierre_Guias_Load;
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
		this.TextBox1 = new System.Windows.Forms.TextBox();
		this.Label1 = new System.Windows.Forms.Label();
		this.Button1 = new System.Windows.Forms.Button();
		this.Button2 = new System.Windows.Forms.Button();
		this.ComboBox1 = new System.Windows.Forms.ComboBox();
		this.Label2 = new System.Windows.Forms.Label();
		this.Label3 = new System.Windows.Forms.Label();
		this.Label4 = new System.Windows.Forms.Label();
		this.Label5 = new System.Windows.Forms.Label();
		this.CheckBox1 = new System.Windows.Forms.CheckBox();
		base.SuspendLayout();
		this.TextBox1.Location = new System.Drawing.Point(43, 31);
		this.TextBox1.Name = "TextBox1";
		this.TextBox1.Size = new System.Drawing.Size(100, 20);
		this.TextBox1.TabIndex = 0;
		this.Label1.AutoSize = true;
		this.Label1.Location = new System.Drawing.Point(239, 34);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(39, 13);
		this.Label1.TabIndex = 1;
		this.Label1.Text = "Label1";
		this.Button1.Location = new System.Drawing.Point(27, 217);
		this.Button1.Name = "Button1";
		this.Button1.Size = new System.Drawing.Size(75, 23);
		this.Button1.TabIndex = 2;
		this.Button1.Text = "Guardar";
		this.Button1.UseVisualStyleBackColor = true;
		this.Button2.Location = new System.Drawing.Point(253, 217);
		this.Button2.Name = "Button2";
		this.Button2.Size = new System.Drawing.Size(75, 23);
		this.Button2.TabIndex = 3;
		this.Button2.Text = "Salir";
		this.Button2.UseVisualStyleBackColor = true;
		this.ComboBox1.FormattingEnabled = true;
		this.ComboBox1.Items.AddRange(new object[7] { "ENTREGADO", "DESPACHADO", "EN CD", "EN RECOLECCION", "RECOLECTADO", "NO ENTREGADO", "A REPROGRAMAR" });
		this.ComboBox1.Location = new System.Drawing.Point(108, 102);
		this.ComboBox1.Name = "ComboBox1";
		this.ComboBox1.Size = new System.Drawing.Size(220, 21);
		this.ComboBox1.TabIndex = 4;
		this.Label2.AutoSize = true;
		this.Label2.Location = new System.Drawing.Point(160, 34);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(73, 13);
		this.Label2.TabIndex = 5;
		this.Label2.Text = "Comprobante:";
		this.Label3.AutoSize = true;
		this.Label3.Location = new System.Drawing.Point(160, 61);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(43, 13);
		this.Label3.TabIndex = 6;
		this.Label3.Text = "Estado:";
		this.Label4.AutoSize = true;
		this.Label4.Location = new System.Drawing.Point(239, 61);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(39, 13);
		this.Label4.TabIndex = 7;
		this.Label4.Text = "Label4";
		this.Label5.AutoSize = true;
		this.Label5.Location = new System.Drawing.Point(24, 105);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(78, 13);
		this.Label5.TabIndex = 8;
		this.Label5.Text = "Nuevo Estado:";
		this.CheckBox1.AutoSize = true;
		this.CheckBox1.Location = new System.Drawing.Point(27, 181);
		this.CheckBox1.Name = "CheckBox1";
		this.CheckBox1.Size = new System.Drawing.Size(89, 17);
		this.CheckBox1.TabIndex = 9;
		this.CheckBox1.Text = "Auto Guardar";
		this.CheckBox1.UseVisualStyleBackColor = true;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(360, 262);
		base.Controls.Add(this.CheckBox1);
		base.Controls.Add(this.Label5);
		base.Controls.Add(this.Label4);
		base.Controls.Add(this.Label3);
		base.Controls.Add(this.Label2);
		base.Controls.Add(this.ComboBox1);
		base.Controls.Add(this.Button2);
		base.Controls.Add(this.Button1);
		base.Controls.Add(this.Label1);
		base.Controls.Add(this.TextBox1);
		base.Name = "Cierre_Guias";
		this.Text = "Cierre_Guias";
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void TextBox1_TextChanged(object sender, EventArgs e)
	{
		if (TextBox1.TextLength > 13)
		{
			Label1.Text = TextBox1.Text.Substring(7, 6);
			busca_comprobante(Label1.Text);
		}
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		TextBox1.Text = "";
	}

	private void busca_comprobante(string comprobante)
	{
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected O, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected O, but got Unknown
		if (CheckBox1.Checked)
		{
			if (Operators.CompareString(comprobante, "", TextCompare: true) != 0)
			{
				DataTable dataTable = new DataTable("x");
				string text = "SELECT estado FROM PLANCHADA WHERE COMPROBANTE = " + comprobante + " and fecha='" + fecha1 + "'";
				MySqlDataAdapter val = new MySqlDataAdapter(text, Mod_Sentencias.cnn);
				DataSet dataSet = new DataSet();
				((DbDataAdapter)(object)val).Fill(dataTable);
				Label4.Text = dataTable.Rows[0]["Estado"].ToString();
				TextBox1.Text = "";
				TextBox1.Focus();
				string estado = ComboBox1.Text;
				update_estado_guia(comprobante, estado);
			}
		}
		else if (Operators.CompareString(comprobante, "", TextCompare: true) != 0)
		{
			DataTable dataTable2 = new DataTable("x");
			string text2 = "SELECT estado FROM PLANCHADA WHERE COMPROBANTE = " + comprobante + " and fecha='" + fecha1 + "'";
			MySqlDataAdapter val2 = new MySqlDataAdapter(text2, Mod_Sentencias.cnn);
			DataSet dataSet2 = new DataSet();
			((DbDataAdapter)(object)val2).Fill(dataTable2);
			Label4.Text = dataTable2.Rows[0]["Estado"].ToString();
			TextBox1.Text = "";
			TextBox1.Focus();
		}
	}

	private void Cierre_Guias_Load(object sender, EventArgs e)
	{
		Label1.Text = "";
		Label4.Text = "";
	}

	private void update_estado_guia(string comprobante, string estado)
	{
		try
		{
			string sQL = "UPDATE Planchada SET Estado='" + estado + "' WHERE Comprobante=" + comprobante + " AND Fecha='" + fecha1 + "'";
			Mod_ConeccionBD.BD_Sentencia(sQL);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox(ex2.Message);
			ProjectData.ClearProjectError();
		}
	}
}
