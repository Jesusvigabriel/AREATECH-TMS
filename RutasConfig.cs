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
public class RutasConfig : Form
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

	private int excelente;

	private int muybuena;

	private int buena;

	private int razonable;

	private int baja;

	private int ninguna;

	[field: AccessedThroughProperty("GroupBox1")]
	internal virtual GroupBox GroupBox1
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

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
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

	[field: AccessedThroughProperty("GroupBox2")]
	internal virtual GroupBox GroupBox2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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

	[field: AccessedThroughProperty("TextBox7")]
	internal virtual TextBox TextBox7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox6")]
	internal virtual TextBox TextBox6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox5")]
	internal virtual TextBox TextBox5
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

	[field: AccessedThroughProperty("TextBox3")]
	internal virtual TextBox TextBox3
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

	[field: AccessedThroughProperty("Label17")]
	internal virtual Label Label17
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label16")]
	internal virtual Label Label16
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label15")]
	internal virtual Label Label15
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label14")]
	internal virtual Label Label14
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label13")]
	internal virtual Label Label13
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label12")]
	internal virtual Label Label12
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label11")]
	internal virtual Label Label11
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label10")]
	internal virtual Label Label10
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

	[field: AccessedThroughProperty("Label4")]
	internal virtual Label Label4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label19")]
	internal virtual Label Label19
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label18")]
	internal virtual Label Label18
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public RutasConfig()
	{
		base.Load += RutasConfig_Load;
		excelente = 0;
		muybuena = 0;
		buena = 0;
		razonable = 0;
		baja = 0;
		ninguna = 0;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hermes.RutasConfig));
		this.GroupBox1 = new System.Windows.Forms.GroupBox();
		this.GroupBox2 = new System.Windows.Forms.GroupBox();
		this.TextBox1 = new System.Windows.Forms.TextBox();
		this.Label1 = new System.Windows.Forms.Label();
		this.Label2 = new System.Windows.Forms.Label();
		this.Label3 = new System.Windows.Forms.Label();
		this.Button1 = new System.Windows.Forms.Button();
		this.Label4 = new System.Windows.Forms.Label();
		this.Label5 = new System.Windows.Forms.Label();
		this.Label6 = new System.Windows.Forms.Label();
		this.Label7 = new System.Windows.Forms.Label();
		this.Label8 = new System.Windows.Forms.Label();
		this.Label9 = new System.Windows.Forms.Label();
		this.Label10 = new System.Windows.Forms.Label();
		this.Label11 = new System.Windows.Forms.Label();
		this.Label12 = new System.Windows.Forms.Label();
		this.Label13 = new System.Windows.Forms.Label();
		this.Label14 = new System.Windows.Forms.Label();
		this.Label15 = new System.Windows.Forms.Label();
		this.Label16 = new System.Windows.Forms.Label();
		this.Label17 = new System.Windows.Forms.Label();
		this.TextBox2 = new System.Windows.Forms.TextBox();
		this.TextBox3 = new System.Windows.Forms.TextBox();
		this.TextBox4 = new System.Windows.Forms.TextBox();
		this.TextBox5 = new System.Windows.Forms.TextBox();
		this.TextBox6 = new System.Windows.Forms.TextBox();
		this.TextBox7 = new System.Windows.Forms.TextBox();
		this.Button2 = new System.Windows.Forms.Button();
		this.Label18 = new System.Windows.Forms.Label();
		this.Label19 = new System.Windows.Forms.Label();
		this.GroupBox1.SuspendLayout();
		this.GroupBox2.SuspendLayout();
		base.SuspendLayout();
		this.GroupBox1.Controls.Add(this.Button1);
		this.GroupBox1.Controls.Add(this.Label3);
		this.GroupBox1.Controls.Add(this.Label2);
		this.GroupBox1.Controls.Add(this.Label1);
		this.GroupBox1.Controls.Add(this.TextBox1);
		this.GroupBox1.Location = new System.Drawing.Point(12, 12);
		this.GroupBox1.Name = "GroupBox1";
		this.GroupBox1.Size = new System.Drawing.Size(377, 100);
		this.GroupBox1.TabIndex = 0;
		this.GroupBox1.TabStop = false;
		this.GroupBox1.Text = "Custodia:";
		this.GroupBox2.Controls.Add(this.Label19);
		this.GroupBox2.Controls.Add(this.Button2);
		this.GroupBox2.Controls.Add(this.TextBox7);
		this.GroupBox2.Controls.Add(this.TextBox6);
		this.GroupBox2.Controls.Add(this.TextBox5);
		this.GroupBox2.Controls.Add(this.TextBox4);
		this.GroupBox2.Controls.Add(this.TextBox3);
		this.GroupBox2.Controls.Add(this.TextBox2);
		this.GroupBox2.Controls.Add(this.Label17);
		this.GroupBox2.Controls.Add(this.Label16);
		this.GroupBox2.Controls.Add(this.Label15);
		this.GroupBox2.Controls.Add(this.Label14);
		this.GroupBox2.Controls.Add(this.Label13);
		this.GroupBox2.Controls.Add(this.Label12);
		this.GroupBox2.Controls.Add(this.Label11);
		this.GroupBox2.Controls.Add(this.Label10);
		this.GroupBox2.Controls.Add(this.Label9);
		this.GroupBox2.Controls.Add(this.Label8);
		this.GroupBox2.Controls.Add(this.Label7);
		this.GroupBox2.Controls.Add(this.Label6);
		this.GroupBox2.Controls.Add(this.Label5);
		this.GroupBox2.Controls.Add(this.Label4);
		this.GroupBox2.Location = new System.Drawing.Point(12, 118);
		this.GroupBox2.Name = "GroupBox2";
		this.GroupBox2.Size = new System.Drawing.Size(377, 288);
		this.GroupBox2.TabIndex = 1;
		this.GroupBox2.TabStop = false;
		this.GroupBox2.Text = "Rentabilidad:";
		this.TextBox1.Location = new System.Drawing.Point(97, 61);
		this.TextBox1.Name = "TextBox1";
		this.TextBox1.Size = new System.Drawing.Size(167, 20);
		this.TextBox1.TabIndex = 0;
		this.Label1.AutoSize = true;
		this.Label1.Location = new System.Drawing.Point(16, 31);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(73, 13);
		this.Label1.TabIndex = 1;
		this.Label1.Text = "Monto Actual:";
		this.Label2.AutoSize = true;
		this.Label2.Location = new System.Drawing.Point(225, 31);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(39, 13);
		this.Label2.TabIndex = 2;
		this.Label2.Text = "Label2";
		this.Label3.AutoSize = true;
		this.Label3.Location = new System.Drawing.Point(16, 64);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(75, 13);
		this.Label3.TabIndex = 3;
		this.Label3.Text = "Nuevo Monto:";
		this.Button1.Location = new System.Drawing.Point(281, 59);
		this.Button1.Name = "Button1";
		this.Button1.Size = new System.Drawing.Size(75, 23);
		this.Button1.TabIndex = 4;
		this.Button1.Text = "Guardar";
		this.Button1.UseVisualStyleBackColor = true;
		this.Label4.AutoSize = true;
		this.Label4.Location = new System.Drawing.Point(16, 33);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(89, 13);
		this.Label4.TabIndex = 0;
		this.Label4.Text = "Valores Actuales:";
		this.Label5.AutoSize = true;
		this.Label5.Location = new System.Drawing.Point(32, 64);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(57, 13);
		this.Label5.TabIndex = 1;
		this.Label5.Text = "Excelente:";
		this.Label6.AutoSize = true;
		this.Label6.Location = new System.Drawing.Point(32, 95);
		this.Label6.Name = "Label6";
		this.Label6.Size = new System.Drawing.Size(64, 13);
		this.Label6.TabIndex = 2;
		this.Label6.Text = "Muy Buena:";
		this.Label7.AutoSize = true;
		this.Label7.Location = new System.Drawing.Point(32, 126);
		this.Label7.Name = "Label7";
		this.Label7.Size = new System.Drawing.Size(41, 13);
		this.Label7.TabIndex = 3;
		this.Label7.Text = "Buena:";
		this.Label8.AutoSize = true;
		this.Label8.Location = new System.Drawing.Point(32, 157);
		this.Label8.Name = "Label8";
		this.Label8.Size = new System.Drawing.Size(61, 13);
		this.Label8.TabIndex = 4;
		this.Label8.Text = "Razonable:";
		this.Label9.AutoSize = true;
		this.Label9.Location = new System.Drawing.Point(32, 188);
		this.Label9.Name = "Label9";
		this.Label9.Size = new System.Drawing.Size(31, 13);
		this.Label9.TabIndex = 5;
		this.Label9.Text = "Baja:";
		this.Label10.AutoSize = true;
		this.Label10.Location = new System.Drawing.Point(32, 219);
		this.Label10.Name = "Label10";
		this.Label10.Size = new System.Drawing.Size(50, 13);
		this.Label10.TabIndex = 6;
		this.Label10.Text = "Ninguna:";
		this.Label11.AutoSize = true;
		this.Label11.Location = new System.Drawing.Point(143, 64);
		this.Label11.Name = "Label11";
		this.Label11.Size = new System.Drawing.Size(45, 13);
		this.Label11.TabIndex = 7;
		this.Label11.Text = "Label11";
		this.Label12.AutoSize = true;
		this.Label12.Location = new System.Drawing.Point(143, 95);
		this.Label12.Name = "Label12";
		this.Label12.Size = new System.Drawing.Size(45, 13);
		this.Label12.TabIndex = 8;
		this.Label12.Text = "Label12";
		this.Label13.AutoSize = true;
		this.Label13.Location = new System.Drawing.Point(143, 126);
		this.Label13.Name = "Label13";
		this.Label13.Size = new System.Drawing.Size(45, 13);
		this.Label13.TabIndex = 9;
		this.Label13.Text = "Label13";
		this.Label14.AutoSize = true;
		this.Label14.Location = new System.Drawing.Point(143, 157);
		this.Label14.Name = "Label14";
		this.Label14.Size = new System.Drawing.Size(45, 13);
		this.Label14.TabIndex = 10;
		this.Label14.Text = "Label14";
		this.Label15.AutoSize = true;
		this.Label15.Location = new System.Drawing.Point(143, 188);
		this.Label15.Name = "Label15";
		this.Label15.Size = new System.Drawing.Size(45, 13);
		this.Label15.TabIndex = 11;
		this.Label15.Text = "Label15";
		this.Label16.AutoSize = true;
		this.Label16.Location = new System.Drawing.Point(143, 219);
		this.Label16.Name = "Label16";
		this.Label16.Size = new System.Drawing.Size(45, 13);
		this.Label16.TabIndex = 12;
		this.Label16.Text = "Label16";
		this.Label17.AutoSize = true;
		this.Label17.Location = new System.Drawing.Point(220, 33);
		this.Label17.Name = "Label17";
		this.Label17.Size = new System.Drawing.Size(85, 13);
		this.Label17.TabIndex = 13;
		this.Label17.Text = "Nuevos Valores:";
		this.TextBox2.Location = new System.Drawing.Point(249, 61);
		this.TextBox2.Name = "TextBox2";
		this.TextBox2.Size = new System.Drawing.Size(100, 20);
		this.TextBox2.TabIndex = 14;
		this.TextBox3.Location = new System.Drawing.Point(249, 92);
		this.TextBox3.Name = "TextBox3";
		this.TextBox3.Size = new System.Drawing.Size(100, 20);
		this.TextBox3.TabIndex = 15;
		this.TextBox4.Location = new System.Drawing.Point(249, 123);
		this.TextBox4.Name = "TextBox4";
		this.TextBox4.Size = new System.Drawing.Size(100, 20);
		this.TextBox4.TabIndex = 16;
		this.TextBox5.Location = new System.Drawing.Point(249, 154);
		this.TextBox5.Name = "TextBox5";
		this.TextBox5.Size = new System.Drawing.Size(100, 20);
		this.TextBox5.TabIndex = 17;
		this.TextBox6.Location = new System.Drawing.Point(249, 185);
		this.TextBox6.Name = "TextBox6";
		this.TextBox6.Size = new System.Drawing.Size(100, 20);
		this.TextBox6.TabIndex = 18;
		this.TextBox7.Location = new System.Drawing.Point(249, 216);
		this.TextBox7.Name = "TextBox7";
		this.TextBox7.Size = new System.Drawing.Size(100, 20);
		this.TextBox7.TabIndex = 19;
		this.Button2.Location = new System.Drawing.Point(281, 255);
		this.Button2.Name = "Button2";
		this.Button2.Size = new System.Drawing.Size(75, 23);
		this.Button2.TabIndex = 20;
		this.Button2.Text = "Guardar";
		this.Button2.UseVisualStyleBackColor = true;
		this.Label18.AutoSize = true;
		this.Label18.Location = new System.Drawing.Point(28, 420);
		this.Label18.Name = "Label18";
		this.Label18.Size = new System.Drawing.Size(182, 13);
		this.Label18.TabIndex = 21;
		this.Label18.Text = "*El % indica el costo para cada caso.";
		this.Label19.AutoSize = true;
		this.Label19.Location = new System.Drawing.Point(143, 33);
		this.Label19.Name = "Label19";
		this.Label19.Size = new System.Drawing.Size(37, 13);
		this.Label19.TabIndex = 21;
		this.Label19.Text = "Costo:";
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(405, 451);
		base.Controls.Add(this.Label18);
		base.Controls.Add(this.GroupBox2);
		base.Controls.Add(this.GroupBox1);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.Name = "RutasConfig";
		this.Text = "Configuración";
		this.GroupBox1.ResumeLayout(false);
		this.GroupBox1.PerformLayout();
		this.GroupBox2.ResumeLayout(false);
		this.GroupBox2.PerformLayout();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private void RutasConfig_Load(object sender, EventArgs e)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		DataTable dataTable = new DataTable("C");
		string text = "SELECT * FROM configuracion LIMIT 1";
		MySqlDataAdapter val = new MySqlDataAdapter(text, Mod_Sentencias.cnn);
		((DbDataAdapter)(object)val).Fill(dataTable);
		excelente = Conversions.ToInteger(dataTable.Rows[0]["excelente"]);
		muybuena = Conversions.ToInteger(dataTable.Rows[0]["muybuena"]);
		buena = Conversions.ToInteger(dataTable.Rows[0]["buena"]);
		razonable = Conversions.ToInteger(dataTable.Rows[0]["razonable"]);
		baja = Conversions.ToInteger(dataTable.Rows[0]["baja"]);
		ninguna = Conversions.ToInteger(dataTable.Rows[0]["ninguna"]);
		Label2.Text = Conversions.ToString(Operators.ConcatenateObject("$ ", dataTable.Rows[0]["custodia"]));
		Label11.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("<= ", dataTable.Rows[0]["excelente"]), " % "));
		Label12.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("<= ", dataTable.Rows[0]["muybuena"]), " % "));
		Label13.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("<= ", dataTable.Rows[0]["buena"]), " % "));
		Label14.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("<= ", dataTable.Rows[0]["razonable"]), " % "));
		Label15.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("<= ", dataTable.Rows[0]["baja"]), " % "));
		Label16.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("> ", dataTable.Rows[0]["ninguna"]), " % "));
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(TextBox1.Text, "", TextCompare: true) != 0)
		{
			int num = Conversions.ToInteger(Strings.Replace(TextBox1.Text, ",", ".", 1, -1, CompareMethod.Text));
			string sQL = "UPDATE configuracion set custodia=" + Conversions.ToString(num) + ", fecha='" + Strings.Format(DateTime.Now, "yyyy/MM/dd HH:mm:ss") + "' where id=1 ";
			int num2 = Conversions.ToInteger(Mod_ConeccionBD.BD_Sentencia(sQL));
			if (num2 == 1)
			{
				Interaction.MsgBox("Se actualizaron correctamente los valores");
				Label2.Text = "$ " + Conversions.ToString(num);
				TextBox1.Text = "";
			}
			else
			{
				Interaction.MsgBox("error");
			}
		}
		else
		{
			Interaction.MsgBox("Debe indicar un monto");
			TextBox1.Focus();
		}
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(TextBox2.Text, "", TextCompare: true) != 0)
		{
			excelente = Conversions.ToInteger(Strings.Replace(TextBox2.Text, ",", ".", 1, -1, CompareMethod.Text));
		}
		if (Operators.CompareString(TextBox3.Text, "", TextCompare: true) != 0)
		{
			muybuena = Conversions.ToInteger(Strings.Replace(TextBox3.Text, ",", ".", 1, -1, CompareMethod.Text));
		}
		if (Operators.CompareString(TextBox4.Text, "", TextCompare: true) != 0)
		{
			buena = Conversions.ToInteger(Strings.Replace(TextBox4.Text, ",", ".", 1, -1, CompareMethod.Text));
		}
		if (Operators.CompareString(TextBox5.Text, "", TextCompare: true) != 0)
		{
			razonable = Conversions.ToInteger(Strings.Replace(TextBox5.Text, ",", ".", 1, -1, CompareMethod.Text));
		}
		if (Operators.CompareString(TextBox6.Text, "", TextCompare: true) != 0)
		{
			baja = Conversions.ToInteger(Strings.Replace(TextBox6.Text, ",", ".", 1, -1, CompareMethod.Text));
		}
		if (Operators.CompareString(TextBox7.Text, "", TextCompare: true) != 0)
		{
			ninguna = Conversions.ToInteger(Strings.Replace(TextBox7.Text, ",", ".", 1, -1, CompareMethod.Text));
		}
		string sQL = "UPDATE configuracion set ninguna=" + Conversions.ToString(ninguna) + ",baja=" + Conversions.ToString(baja) + ",razonable=" + Conversions.ToString(razonable) + ",buena=" + Conversions.ToString(buena) + ",muybuena=" + Conversions.ToString(muybuena) + ", excelente=" + Conversions.ToString(excelente) + ", fecha='" + Strings.Format(DateTime.Now, "yyyy/MM/dd HH:mm:ss") + "' where id=1 ";
		int num = Conversions.ToInteger(Mod_ConeccionBD.BD_Sentencia(sQL));
		if (num == 1)
		{
			Interaction.MsgBox("Se actualizaron correctamente los valores");
			Label11.Text = "<= " + Conversions.ToString(excelente) + " % ";
			Label12.Text = "<= " + Conversions.ToString(muybuena) + " % ";
			Label13.Text = "<= " + Conversions.ToString(buena) + " % ";
			Label14.Text = "<= " + Conversions.ToString(razonable) + " % ";
			Label15.Text = "<= " + Conversions.ToString(baja) + " % ";
			Label16.Text = "> " + Conversions.ToString(ninguna) + " % ";
			TextBox2.Text = "";
			TextBox3.Text = "";
			TextBox4.Text = "";
			TextBox5.Text = "";
			TextBox6.Text = "";
			TextBox7.Text = "";
		}
		else
		{
			Interaction.MsgBox("error");
		}
	}
}
