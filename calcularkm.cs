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
public class calcularkm : Form
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
	[AccessedThroughProperty("Button3")]
	private Button _Button3;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button4")]
	private Button _Button4;

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

	[field: AccessedThroughProperty("TextBox4")]
	internal virtual TextBox TextBox4
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

	public calcularkm()
	{
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
		this.TextBox2 = new System.Windows.Forms.TextBox();
		this.TextBox3 = new System.Windows.Forms.TextBox();
		this.TextBox4 = new System.Windows.Forms.TextBox();
		this.Button3 = new System.Windows.Forms.Button();
		this.Button4 = new System.Windows.Forms.Button();
		base.SuspendLayout();
		this.Button1.Location = new System.Drawing.Point(12, 227);
		this.Button1.Name = "Button1";
		this.Button1.Size = new System.Drawing.Size(75, 23);
		this.Button1.TabIndex = 0;
		this.Button1.Text = "Button1";
		this.Button1.UseVisualStyleBackColor = true;
		this.Button2.Location = new System.Drawing.Point(197, 227);
		this.Button2.Name = "Button2";
		this.Button2.Size = new System.Drawing.Size(75, 23);
		this.Button2.TabIndex = 1;
		this.Button2.Text = "Button2";
		this.Button2.UseVisualStyleBackColor = true;
		this.TextBox1.Location = new System.Drawing.Point(12, 43);
		this.TextBox1.Name = "TextBox1";
		this.TextBox1.Size = new System.Drawing.Size(100, 20);
		this.TextBox1.TabIndex = 2;
		this.TextBox2.Location = new System.Drawing.Point(155, 43);
		this.TextBox2.Name = "TextBox2";
		this.TextBox2.Size = new System.Drawing.Size(100, 20);
		this.TextBox2.TabIndex = 3;
		this.TextBox3.Location = new System.Drawing.Point(12, 106);
		this.TextBox3.Name = "TextBox3";
		this.TextBox3.Size = new System.Drawing.Size(100, 20);
		this.TextBox3.TabIndex = 4;
		this.TextBox4.Location = new System.Drawing.Point(155, 106);
		this.TextBox4.Name = "TextBox4";
		this.TextBox4.Size = new System.Drawing.Size(100, 20);
		this.TextBox4.TabIndex = 5;
		this.Button3.Location = new System.Drawing.Point(105, 168);
		this.Button3.Name = "Button3";
		this.Button3.Size = new System.Drawing.Size(75, 23);
		this.Button3.TabIndex = 6;
		this.Button3.Text = "Button3";
		this.Button3.UseVisualStyleBackColor = true;
		this.Button4.Location = new System.Drawing.Point(24, 168);
		this.Button4.Name = "Button4";
		this.Button4.Size = new System.Drawing.Size(75, 23);
		this.Button4.TabIndex = 7;
		this.Button4.Text = "Button4";
		this.Button4.UseVisualStyleBackColor = true;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(284, 262);
		base.Controls.Add(this.Button4);
		base.Controls.Add(this.Button3);
		base.Controls.Add(this.TextBox4);
		base.Controls.Add(this.TextBox3);
		base.Controls.Add(this.TextBox2);
		base.Controls.Add(this.TextBox1);
		base.Controls.Add(this.Button2);
		base.Controls.Add(this.Button1);
		base.Name = "calcularkm";
		this.Text = "calcularkm";
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		km(Conversions.ToDouble(TextBox1.Text), Conversions.ToDouble(TextBox2.Text), Conversions.ToDouble(TextBox3.Text), Conversions.ToDouble(TextBox4.Text));
	}

	private void km(double lat1, double long1, double lat2, double long2)
	{
		Interaction.MsgBox(RuntimeHelpers.GetObjectValue(Mod_Calculos.getDistance(lat1, long1, lat2, long2)));
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void Button3_Click(object sender, EventArgs e)
	{
		Interaction.MsgBox(RuntimeHelpers.GetObjectValue(Mod_Calculos.getAngulo(0.0, 0.0, 0.0, 6.0, 3.0, 3.0)));
	}

	private void Button4_Click(object sender, EventArgs e)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		string text = "SELECT Latitud,Longitud FROM Dibujos where Zona=1";
		DataTable dataTable = new DataTable("x");
		MySqlDataAdapter val = new MySqlDataAdapter(text, Mod_Sentencias.cnn);
		DataSet dataSet = new DataSet();
		((DbDataAdapter)(object)val).Fill(dataTable);
		double ax = Conversions.ToDouble(TextBox1.Text);
		double ay = Conversions.ToDouble(TextBox2.Text);
		int count = dataTable.Rows.Count;
		double num = 0.0;
		checked
		{
			int num2 = (int)Math.Round((double)count / 2.0);
			num = Conversions.ToDouble(Mod_Calculos.getAngulo(ax, ay, Conversions.ToDouble(Strings.Replace(Conversions.ToString(dataTable.Rows[count - 1]["Latitud"]), ".", ",", 1, -1, CompareMethod.Text)), Conversions.ToDouble(Strings.Replace(Conversions.ToString(dataTable.Rows[count - 1]["Longitud"]), ".", ",", 1, -1, CompareMethod.Text)), Conversions.ToDouble(Strings.Replace(Conversions.ToString(dataTable.Rows[0]["Latitud"]), ".", ",", 1, -1, CompareMethod.Text)), Conversions.ToDouble(Strings.Replace(Conversions.ToString(dataTable.Rows[0]["Longitud"]), ".", ",", 1, -1, CompareMethod.Text))));
			int num3 = dataTable.Rows.Count - 2;
			for (int i = 0; i <= num3; i++)
			{
				double num4 = Conversions.ToDouble(Mod_Calculos.getAngulo(ax, ay, Conversions.ToDouble(Strings.Replace(Conversions.ToString(dataTable.Rows[i]["Latitud"]), ".", ",", 1, -1, CompareMethod.Text)), Conversions.ToDouble(Strings.Replace(Conversions.ToString(dataTable.Rows[i]["Longitud"]), ".", ",", 1, -1, CompareMethod.Text)), Conversions.ToDouble(Strings.Replace(Conversions.ToString(dataTable.Rows[i + 1]["Latitud"]), ".", ",", 1, -1, CompareMethod.Text)), Conversions.ToDouble(Strings.Replace(Conversions.ToString(dataTable.Rows[i + 1]["Longitud"]), ".", ",", 1, -1, CompareMethod.Text))));
				num += num4;
			}
			Interaction.MsgBox(Math.Abs(num) > 1E-06);
		}
	}
}
