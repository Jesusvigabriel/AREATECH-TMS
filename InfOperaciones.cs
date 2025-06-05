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
public class InfOperaciones : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ComboBox1")]
	private ComboBox _ComboBox1;

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

	[field: AccessedThroughProperty("TextBox1")]
	internal virtual TextBox TextBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox2")]
	internal virtual TextBox TextBox2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox3")]
	internal virtual TextBox TextBox3
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

	public InfOperaciones()
	{
		base.Load += InfOperaciones_Load;
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
		this.Label1 = new System.Windows.Forms.Label();
		this.Label2 = new System.Windows.Forms.Label();
		this.Label3 = new System.Windows.Forms.Label();
		this.Label4 = new System.Windows.Forms.Label();
		this.ComboBox1 = new System.Windows.Forms.ComboBox();
		this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
		this.DateTimePicker2 = new System.Windows.Forms.DateTimePicker();
		this.TextBox1 = new System.Windows.Forms.TextBox();
		this.TextBox2 = new System.Windows.Forms.TextBox();
		this.TextBox3 = new System.Windows.Forms.TextBox();
		this.Label6 = new System.Windows.Forms.Label();
		base.SuspendLayout();
		this.Button1.Location = new System.Drawing.Point(302, 285);
		this.Button1.Name = "Button1";
		this.Button1.Size = new System.Drawing.Size(75, 23);
		this.Button1.TabIndex = 1;
		this.Button1.Text = "Calcular";
		this.Button1.UseVisualStyleBackColor = true;
		this.Label1.AutoSize = true;
		this.Label1.Location = new System.Drawing.Point(338, 125);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(39, 13);
		this.Label1.TabIndex = 4;
		this.Label1.Text = "Label1";
		this.Label2.AutoSize = true;
		this.Label2.Location = new System.Drawing.Point(338, 164);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(39, 13);
		this.Label2.TabIndex = 5;
		this.Label2.Text = "Label2";
		this.Label3.AutoSize = true;
		this.Label3.Location = new System.Drawing.Point(338, 206);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(39, 13);
		this.Label3.TabIndex = 6;
		this.Label3.Text = "Label3";
		this.Label4.AutoSize = true;
		this.Label4.Location = new System.Drawing.Point(338, 239);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(39, 13);
		this.Label4.TabIndex = 7;
		this.Label4.Text = "Label4";
		this.ComboBox1.FormattingEnabled = true;
		this.ComboBox1.Location = new System.Drawing.Point(67, 81);
		this.ComboBox1.Name = "ComboBox1";
		this.ComboBox1.Size = new System.Drawing.Size(310, 21);
		this.ComboBox1.TabIndex = 8;
		this.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
		this.DateTimePicker1.Location = new System.Drawing.Point(12, 12);
		this.DateTimePicker1.Name = "DateTimePicker1";
		this.DateTimePicker1.Size = new System.Drawing.Size(102, 20);
		this.DateTimePicker1.TabIndex = 9;
		this.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
		this.DateTimePicker2.Location = new System.Drawing.Point(12, 38);
		this.DateTimePicker2.Name = "DateTimePicker2";
		this.DateTimePicker2.Size = new System.Drawing.Size(102, 20);
		this.DateTimePicker2.TabIndex = 10;
		this.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.TextBox1.Enabled = false;
		this.TextBox1.ForeColor = System.Drawing.Color.White;
		this.TextBox1.Location = new System.Drawing.Point(22, 123);
		this.TextBox1.Name = "TextBox1";
		this.TextBox1.Size = new System.Drawing.Size(310, 20);
		this.TextBox1.TabIndex = 12;
		this.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.TextBox2.Enabled = false;
		this.TextBox2.ForeColor = System.Drawing.Color.White;
		this.TextBox2.Location = new System.Drawing.Point(22, 162);
		this.TextBox2.Name = "TextBox2";
		this.TextBox2.Size = new System.Drawing.Size(310, 20);
		this.TextBox2.TabIndex = 13;
		this.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.TextBox3.Enabled = false;
		this.TextBox3.ForeColor = System.Drawing.Color.White;
		this.TextBox3.Location = new System.Drawing.Point(22, 204);
		this.TextBox3.Name = "TextBox3";
		this.TextBox3.Size = new System.Drawing.Size(310, 20);
		this.TextBox3.TabIndex = 14;
		this.Label6.AutoSize = true;
		this.Label6.Location = new System.Drawing.Point(19, 84);
		this.Label6.Name = "Label6";
		this.Label6.Size = new System.Drawing.Size(42, 13);
		this.Label6.TabIndex = 15;
		this.Label6.Text = "Cliente:";
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(401, 322);
		base.Controls.Add(this.Label6);
		base.Controls.Add(this.TextBox3);
		base.Controls.Add(this.TextBox2);
		base.Controls.Add(this.TextBox1);
		base.Controls.Add(this.DateTimePicker2);
		base.Controls.Add(this.DateTimePicker1);
		base.Controls.Add(this.ComboBox1);
		base.Controls.Add(this.Label4);
		base.Controls.Add(this.Label3);
		base.Controls.Add(this.Label2);
		base.Controls.Add(this.Label1);
		base.Controls.Add(this.Button1);
		base.Name = "InfOperaciones";
		this.Text = "InfOperaciones";
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private void InfOperaciones_Load(object sender, EventArgs e)
	{
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		string text = Strings.Format(DateTimePicker1.Value, "yyyyMMdd");
		string text2 = Strings.Format(DateTimePicker2.Value, "yyyyMMdd");
		DataTable dataTable = new DataTable("x");
		string text3 = "SELECT DISTINCT Cliente FROM Planchada where fecha BETWEEN '" + text + "' AND '" + text2 + "' AND Ventana>0 order by Cliente";
		MySqlDataAdapter val = new MySqlDataAdapter(text3, Mod_Sentencias.cnn);
		DataSet dataSet = new DataSet();
		((DbDataAdapter)(object)val).Fill(dataSet, "tabla");
		ComboBox1.Items.Clear();
		DataTable dataTable2 = dataSet.Tables["tabla"];
		foreach (DataRow row in dataTable2.Rows)
		{
			ComboBox1.Items.Add(RuntimeHelpers.GetObjectValue(row["Cliente"]));
		}
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		consulta();
	}

	private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
	{
		consulta();
	}

	private void consulta()
	{
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected O, but got Unknown
		TextBox1.Width = 0;
		TextBox1.BackColor = Color.Green;
		TextBox2.Width = 0;
		TextBox2.BackColor = Color.Orange;
		TextBox3.Width = 0;
		TextBox3.BackColor = Color.Red;
		string text = Strings.Format(DateTimePicker1.Value, "yyyyMMdd");
		string text2 = Strings.Format(DateTimePicker2.Value, "yyyyMMdd");
		string text3 = Strings.Format(MyProject.Forms.Form1_Inicio.DateTimePicker1.Value, "yyyyMMdd");
		string text4 = "SELECT DISTINCT Comprobante, Estado, sub FROM Planchada WHERE FECHA BETWEEN '" + text + "' AND '" + text2 + "' AND estado<>'Ruteado' AND estado<>'En Planchada'";
		if (ComboBox1.SelectedIndex > 0)
		{
			text4 = text4 + " AND Cliente='" + ComboBox1.Text + "'";
		}
		DataTable dataTable = new DataTable("x");
		MySqlDataAdapter val = new MySqlDataAdapter(text4, Mod_Sentencias.cnn);
		((DbDataAdapter)(object)val).Fill(dataTable);
		Label1.Text = Conversions.ToString(0);
		Label2.Text = Conversions.ToString(0);
		Label3.Text = Conversions.ToString(0);
		Label4.Text = Conversions.ToString(0);
		Label4.Text = Conversions.ToString(dataTable.Rows.Count);
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		checked
		{
			int num4 = dataTable.Rows.Count - 1;
			for (int i = 0; i <= num4; i++)
			{
				if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(dataTable.Rows[i]["Estado"], "ENTREGADO", TextCompare: true), Operators.CompareObjectEqual(dataTable.Rows[i]["Estado"], "RECOLECTADO", TextCompare: true))))
				{
					num++;
					TextBox1.Width = (int)Math.Round((double)(num * 310) / (double)dataTable.Rows.Count);
					Label1.Text = Conversions.ToString(Math.Round((double)(num * 100) / (double)dataTable.Rows.Count, 2)) + " %";
				}
				if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(dataTable.Rows[i]["Estado"], "EN CD", TextCompare: true), Operators.CompareObjectEqual(dataTable.Rows[i]["sub"], 11, TextCompare: true))))
				{
					num++;
					TextBox1.Width = (int)Math.Round((double)(num * 310) / (double)dataTable.Rows.Count);
					Label1.Text = Conversions.ToString(Math.Round((double)(num * 100) / (double)dataTable.Rows.Count, 2)) + " %";
				}
				if (Operators.ConditionalCompareObjectEqual(dataTable.Rows[i]["Estado"], "PARCIAL", TextCompare: true))
				{
					num2++;
					TextBox2.Width = (int)Math.Round((double)(num2 * 310) / (double)dataTable.Rows.Count);
					Label2.Text = Conversions.ToString(Math.Round((double)(num2 * 100) / (double)dataTable.Rows.Count, 2)) + " %";
				}
				if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(dataTable.Rows[i]["Estado"], "NO ENTREGADO", TextCompare: true), Operators.CompareObjectEqual(dataTable.Rows[i]["Estado"], "NO RECOLECTADO", TextCompare: true))))
				{
					num3++;
					TextBox3.Width = (int)Math.Round((double)(num3 * 310) / (double)dataTable.Rows.Count);
					Label3.Text = Conversions.ToString(Math.Round((double)(num3 * 100) / (double)dataTable.Rows.Count, 2)) + " %";
				}
				if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(dataTable.Rows[i]["Estado"], "EN CD", TextCompare: true), Operators.CompareObjectLess(dataTable.Rows[i]["sub"], 11, TextCompare: true))))
				{
					num3++;
					TextBox3.Width = (int)Math.Round((double)(num3 * 310) / (double)dataTable.Rows.Count);
					Label3.Text = Conversions.ToString(Math.Round((double)(num3 * 100) / (double)dataTable.Rows.Count, 2)) + " %";
				}
			}
		}
	}
}
