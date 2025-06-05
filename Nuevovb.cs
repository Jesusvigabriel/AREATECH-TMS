using System;
using System.ComponentModel;
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
public class Nuevovb : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("guardarbtn")]
	private Button _guardarbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("salirbtn")]
	private Button _salirbtn;

	[field: AccessedThroughProperty("GroupBox1")]
	internal virtual GroupBox GroupBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox8")]
	internal virtual TextBox TextBox8
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

	[field: AccessedThroughProperty("TextBox7")]
	internal virtual TextBox TextBox7
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

	[field: AccessedThroughProperty("TextBox6")]
	internal virtual TextBox TextBox6
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

	[field: AccessedThroughProperty("TextBox5")]
	internal virtual TextBox TextBox5
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

	[field: AccessedThroughProperty("TextBox4")]
	internal virtual TextBox TextBox4
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

	[field: AccessedThroughProperty("TextBox3")]
	internal virtual TextBox TextBox3
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

	[field: AccessedThroughProperty("TextBox2")]
	internal virtual TextBox TextBox2
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

	internal virtual Button guardarbtn
	{
		[CompilerGenerated]
		get
		{
			return _guardarbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = guardarbtn_Click;
			Button button = _guardarbtn;
			if (button != null)
			{
				button.Click -= value2;
			}
			_guardarbtn = value;
			button = _guardarbtn;
			if (button != null)
			{
				button.Click += value2;
			}
		}
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
			EventHandler value2 = Button2_Click;
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

	[field: AccessedThroughProperty("tablalbl")]
	internal virtual Label tablalbl
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox9")]
	internal virtual TextBox TextBox9
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

	[field: AccessedThroughProperty("classlbl")]
	internal virtual Label classlbl
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public Nuevovb()
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
		this.GroupBox1 = new System.Windows.Forms.GroupBox();
		this.Label1 = new System.Windows.Forms.Label();
		this.TextBox1 = new System.Windows.Forms.TextBox();
		this.Label2 = new System.Windows.Forms.Label();
		this.TextBox2 = new System.Windows.Forms.TextBox();
		this.Label3 = new System.Windows.Forms.Label();
		this.TextBox3 = new System.Windows.Forms.TextBox();
		this.Label4 = new System.Windows.Forms.Label();
		this.TextBox4 = new System.Windows.Forms.TextBox();
		this.Label5 = new System.Windows.Forms.Label();
		this.TextBox5 = new System.Windows.Forms.TextBox();
		this.Label6 = new System.Windows.Forms.Label();
		this.TextBox6 = new System.Windows.Forms.TextBox();
		this.Label7 = new System.Windows.Forms.Label();
		this.TextBox7 = new System.Windows.Forms.TextBox();
		this.Label8 = new System.Windows.Forms.Label();
		this.TextBox8 = new System.Windows.Forms.TextBox();
		this.guardarbtn = new System.Windows.Forms.Button();
		this.salirbtn = new System.Windows.Forms.Button();
		this.tablalbl = new System.Windows.Forms.Label();
		this.Label9 = new System.Windows.Forms.Label();
		this.TextBox9 = new System.Windows.Forms.TextBox();
		this.classlbl = new System.Windows.Forms.Label();
		this.GroupBox1.SuspendLayout();
		base.SuspendLayout();
		this.GroupBox1.Controls.Add(this.classlbl);
		this.GroupBox1.Controls.Add(this.TextBox9);
		this.GroupBox1.Controls.Add(this.Label9);
		this.GroupBox1.Controls.Add(this.tablalbl);
		this.GroupBox1.Controls.Add(this.TextBox8);
		this.GroupBox1.Controls.Add(this.Label8);
		this.GroupBox1.Controls.Add(this.TextBox7);
		this.GroupBox1.Controls.Add(this.Label7);
		this.GroupBox1.Controls.Add(this.TextBox6);
		this.GroupBox1.Controls.Add(this.Label6);
		this.GroupBox1.Controls.Add(this.TextBox5);
		this.GroupBox1.Controls.Add(this.Label5);
		this.GroupBox1.Controls.Add(this.TextBox4);
		this.GroupBox1.Controls.Add(this.Label4);
		this.GroupBox1.Controls.Add(this.TextBox3);
		this.GroupBox1.Controls.Add(this.Label3);
		this.GroupBox1.Controls.Add(this.TextBox2);
		this.GroupBox1.Controls.Add(this.Label2);
		this.GroupBox1.Controls.Add(this.TextBox1);
		this.GroupBox1.Controls.Add(this.Label1);
		this.GroupBox1.Location = new System.Drawing.Point(12, 12);
		this.GroupBox1.Name = "GroupBox1";
		this.GroupBox1.Size = new System.Drawing.Size(451, 390);
		this.GroupBox1.TabIndex = 0;
		this.GroupBox1.TabStop = false;
		this.GroupBox1.Text = "GroupBox1";
		this.Label1.AutoSize = true;
		this.Label1.Location = new System.Drawing.Point(24, 23);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(39, 13);
		this.Label1.TabIndex = 0;
		this.Label1.Text = "Label1";
		this.TextBox1.Location = new System.Drawing.Point(120, 20);
		this.TextBox1.Name = "TextBox1";
		this.TextBox1.Size = new System.Drawing.Size(100, 20);
		this.TextBox1.TabIndex = 1;
		this.Label2.AutoSize = true;
		this.Label2.Location = new System.Drawing.Point(24, 59);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(39, 13);
		this.Label2.TabIndex = 2;
		this.Label2.Text = "Label2";
		this.TextBox2.Location = new System.Drawing.Point(120, 56);
		this.TextBox2.Name = "TextBox2";
		this.TextBox2.Size = new System.Drawing.Size(100, 20);
		this.TextBox2.TabIndex = 3;
		this.Label3.AutoSize = true;
		this.Label3.Location = new System.Drawing.Point(24, 95);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(39, 13);
		this.Label3.TabIndex = 4;
		this.Label3.Text = "Label3";
		this.TextBox3.Location = new System.Drawing.Point(120, 92);
		this.TextBox3.Name = "TextBox3";
		this.TextBox3.Size = new System.Drawing.Size(100, 20);
		this.TextBox3.TabIndex = 5;
		this.Label4.AutoSize = true;
		this.Label4.Location = new System.Drawing.Point(24, 131);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(39, 13);
		this.Label4.TabIndex = 6;
		this.Label4.Text = "Label4";
		this.TextBox4.Location = new System.Drawing.Point(120, 128);
		this.TextBox4.Name = "TextBox4";
		this.TextBox4.Size = new System.Drawing.Size(100, 20);
		this.TextBox4.TabIndex = 7;
		this.Label5.AutoSize = true;
		this.Label5.Location = new System.Drawing.Point(24, 167);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(39, 13);
		this.Label5.TabIndex = 8;
		this.Label5.Text = "Label5";
		this.TextBox5.Location = new System.Drawing.Point(120, 164);
		this.TextBox5.Name = "TextBox5";
		this.TextBox5.Size = new System.Drawing.Size(100, 20);
		this.TextBox5.TabIndex = 9;
		this.Label6.AutoSize = true;
		this.Label6.Location = new System.Drawing.Point(24, 203);
		this.Label6.Name = "Label6";
		this.Label6.Size = new System.Drawing.Size(39, 13);
		this.Label6.TabIndex = 10;
		this.Label6.Text = "Label6";
		this.TextBox6.Location = new System.Drawing.Point(120, 200);
		this.TextBox6.Name = "TextBox6";
		this.TextBox6.Size = new System.Drawing.Size(100, 20);
		this.TextBox6.TabIndex = 11;
		this.Label7.AutoSize = true;
		this.Label7.Location = new System.Drawing.Point(24, 239);
		this.Label7.Name = "Label7";
		this.Label7.Size = new System.Drawing.Size(39, 13);
		this.Label7.TabIndex = 12;
		this.Label7.Text = "Label7";
		this.TextBox7.Location = new System.Drawing.Point(120, 236);
		this.TextBox7.Name = "TextBox7";
		this.TextBox7.Size = new System.Drawing.Size(100, 20);
		this.TextBox7.TabIndex = 13;
		this.Label8.AutoSize = true;
		this.Label8.Location = new System.Drawing.Point(24, 275);
		this.Label8.Name = "Label8";
		this.Label8.Size = new System.Drawing.Size(39, 13);
		this.Label8.TabIndex = 14;
		this.Label8.Text = "Label8";
		this.TextBox8.Location = new System.Drawing.Point(120, 272);
		this.TextBox8.Name = "TextBox8";
		this.TextBox8.Size = new System.Drawing.Size(100, 20);
		this.TextBox8.TabIndex = 15;
		this.guardarbtn.Location = new System.Drawing.Point(12, 414);
		this.guardarbtn.Name = "guardarbtn";
		this.guardarbtn.Size = new System.Drawing.Size(75, 23);
		this.guardarbtn.TabIndex = 1;
		this.guardarbtn.Text = "Guardar";
		this.guardarbtn.UseVisualStyleBackColor = true;
		this.salirbtn.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.salirbtn.Location = new System.Drawing.Point(380, 414);
		this.salirbtn.Name = "salirbtn";
		this.salirbtn.Size = new System.Drawing.Size(75, 23);
		this.salirbtn.TabIndex = 2;
		this.salirbtn.Text = "Salir";
		this.salirbtn.UseVisualStyleBackColor = true;
		this.tablalbl.AutoSize = true;
		this.tablalbl.Location = new System.Drawing.Point(363, 23);
		this.tablalbl.Name = "tablalbl";
		this.tablalbl.Size = new System.Drawing.Size(34, 13);
		this.tablalbl.TabIndex = 16;
		this.tablalbl.Text = "Tabla";
		this.tablalbl.Visible = false;
		this.Label9.AutoSize = true;
		this.Label9.Location = new System.Drawing.Point(24, 316);
		this.Label9.Name = "Label9";
		this.Label9.Size = new System.Drawing.Size(39, 13);
		this.Label9.TabIndex = 17;
		this.Label9.Text = "Label9";
		this.TextBox9.Location = new System.Drawing.Point(120, 313);
		this.TextBox9.Name = "TextBox9";
		this.TextBox9.Size = new System.Drawing.Size(100, 20);
		this.TextBox9.TabIndex = 18;
		this.classlbl.AutoSize = true;
		this.classlbl.Location = new System.Drawing.Point(366, 47);
		this.classlbl.Name = "classlbl";
		this.classlbl.Size = new System.Drawing.Size(31, 13);
		this.classlbl.TabIndex = 19;
		this.classlbl.Text = "class";
		this.classlbl.Visible = false;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(475, 449);
		base.ControlBox = false;
		base.Controls.Add(this.salirbtn);
		base.Controls.Add(this.guardarbtn);
		base.Controls.Add(this.GroupBox1);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
		base.Name = "Nuevovb";
		base.ShowIcon = false;
		this.Text = "Nuevo";
		this.GroupBox1.ResumeLayout(false);
		this.GroupBox1.PerformLayout();
		base.ResumeLayout(false);
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		try
		{
			Mod_Sentencias.cnn.Close();
			Close();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Close();
			ProjectData.ClearProjectError();
		}
	}

	private void guardarbtn_Click(object sender, EventArgs e)
	{
		try
		{
			string methodName = tablalbl.Text;
			Versioned.CallByName(this, methodName, CallType.Method);
			Close();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Close();
			Interaction.MsgBox(ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	public void Eventual_insert()
	{
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Expected O, but got Unknown
		try
		{
			string text = "INSERT INTO Eventuales(Cliente, Eventual, Zona, Domicilio, Localidad, CP, Adicional, Prioridad, Sub, Normalizada, Latitud, Longitud, Franja, Fecha, Usuario) VALUES ('" + Strings.Replace(TextBox1.Text, "'", " ", 1, -1, CompareMethod.Text) + "', " + TextBox2.Text + "," + TextBox3.Text + ",'" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "'," + TextBox7.Text + "," + TextBox8.Text + ",'','',-34.5,-54.5," + TextBox7.Text + ",'" + Strings.Format(MyProject.Forms.Form1_Inicio.DateTimePicker1.Value, "yyyy/MM/dd") + "', '" + MyProject.Forms.Form1_Inicio.nombreusuario.Text + "')";
			Mod_Sentencias.cnn.Open();
			MySqlCommand val = new MySqlCommand(text, Mod_Sentencias.cnn);
			val.ExecuteNonQuery();
			Mod_Sentencias.cnn.Close();
			Interaction.MsgBox("Eventual Creado");
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Mod_Sentencias.cnn.Close();
			Interaction.MsgBox(ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	public void flota_insert()
	{
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected O, but got Unknown
		try
		{
			string text = "INSERT INTO Flota(Numero,Categoria,Chofer,Disponible,Tarifa, Peso, Volumen, Estado, GPS) VALUES (" + TextBox1.Text + "," + TextBox2.Text + ",'" + TextBox3.Text + "','" + TextBox4.Text + "'," + Strings.Replace(TextBox5.Text, ",", ".", 1, -1, CompareMethod.Text) + "," + Strings.Replace(TextBox6.Text, ",", ".", 1, -1, CompareMethod.Text) + "," + Strings.Replace(TextBox7.Text, ",", ".", 1, -1, CompareMethod.Text) + ",'" + TextBox8.Text + "','" + TextBox9.Text + "')";
			Mod_Sentencias.cnn.Open();
			MySqlCommand val = new MySqlCommand(text, Mod_Sentencias.cnn);
			val.ExecuteNonQuery();
			Mod_Sentencias.cnn.Close();
			Interaction.MsgBox("Vehiculo Creado");
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Mod_Sentencias.cnn.Close();
			Interaction.MsgBox(ex2.Message);
			ProjectData.ClearProjectError();
		}
	}
}
