using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Hermes.My;
using Microsoft.VisualBasic.CompilerServices;

namespace Hermes;

[DesignerGenerated]
public class ImportarConfig : Form
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

	[field: AccessedThroughProperty("ComboBox1")]
	internal virtual ComboBox ComboBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ComboBox2")]
	internal virtual ComboBox ComboBox2
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

	[field: AccessedThroughProperty("ComboBox3")]
	internal virtual ComboBox ComboBox3
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

	[field: AccessedThroughProperty("Label9")]
	internal virtual Label Label9
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

	[field: AccessedThroughProperty("Label11")]
	internal virtual Label Label11
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

	[field: AccessedThroughProperty("Label13")]
	internal virtual Label Label13
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

	[field: AccessedThroughProperty("Label15")]
	internal virtual Label Label15
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

	[field: AccessedThroughProperty("Label17")]
	internal virtual Label Label17
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ComboBox4")]
	internal virtual ComboBox ComboBox4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ComboBox5")]
	internal virtual ComboBox ComboBox5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ComboBox6")]
	internal virtual ComboBox ComboBox6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ComboBox7")]
	internal virtual ComboBox ComboBox7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ComboBox8")]
	internal virtual ComboBox ComboBox8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ComboBox9")]
	internal virtual ComboBox ComboBox9
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ComboBox10")]
	internal virtual ComboBox ComboBox10
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ComboBox11")]
	internal virtual ComboBox ComboBox11
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ComboBox12")]
	internal virtual ComboBox ComboBox12
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ComboBox13")]
	internal virtual ComboBox ComboBox13
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ComboBox14")]
	internal virtual ComboBox ComboBox14
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ComboBox15")]
	internal virtual ComboBox ComboBox15
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ComboBox16")]
	internal virtual ComboBox ComboBox16
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ComboBox17")]
	internal virtual ComboBox ComboBox17
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

	[field: AccessedThroughProperty("Label18")]
	internal virtual Label Label18
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public ImportarConfig()
	{
		base.Load += ImportarConfig_Load;
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
		this.ComboBox1 = new System.Windows.Forms.ComboBox();
		this.ComboBox2 = new System.Windows.Forms.ComboBox();
		this.Button1 = new System.Windows.Forms.Button();
		this.Button2 = new System.Windows.Forms.Button();
		this.Label1 = new System.Windows.Forms.Label();
		this.Label2 = new System.Windows.Forms.Label();
		this.Label3 = new System.Windows.Forms.Label();
		this.ComboBox3 = new System.Windows.Forms.ComboBox();
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
		this.ComboBox4 = new System.Windows.Forms.ComboBox();
		this.ComboBox5 = new System.Windows.Forms.ComboBox();
		this.ComboBox6 = new System.Windows.Forms.ComboBox();
		this.ComboBox7 = new System.Windows.Forms.ComboBox();
		this.ComboBox8 = new System.Windows.Forms.ComboBox();
		this.ComboBox9 = new System.Windows.Forms.ComboBox();
		this.ComboBox10 = new System.Windows.Forms.ComboBox();
		this.ComboBox11 = new System.Windows.Forms.ComboBox();
		this.ComboBox12 = new System.Windows.Forms.ComboBox();
		this.ComboBox13 = new System.Windows.Forms.ComboBox();
		this.ComboBox14 = new System.Windows.Forms.ComboBox();
		this.ComboBox15 = new System.Windows.Forms.ComboBox();
		this.ComboBox16 = new System.Windows.Forms.ComboBox();
		this.ComboBox17 = new System.Windows.Forms.ComboBox();
		this.Button3 = new System.Windows.Forms.Button();
		this.Label18 = new System.Windows.Forms.Label();
		base.SuspendLayout();
		this.ComboBox1.FormattingEnabled = true;
		this.ComboBox1.Location = new System.Drawing.Point(101, 46);
		this.ComboBox1.Name = "ComboBox1";
		this.ComboBox1.Size = new System.Drawing.Size(121, 21);
		this.ComboBox1.TabIndex = 0;
		this.ComboBox2.FormattingEnabled = true;
		this.ComboBox2.Location = new System.Drawing.Point(101, 85);
		this.ComboBox2.Name = "ComboBox2";
		this.ComboBox2.Size = new System.Drawing.Size(121, 21);
		this.ComboBox2.TabIndex = 1;
		this.Button1.Location = new System.Drawing.Point(497, 241);
		this.Button1.Name = "Button1";
		this.Button1.Size = new System.Drawing.Size(75, 23);
		this.Button1.TabIndex = 2;
		this.Button1.Text = "Guardar";
		this.Button1.UseVisualStyleBackColor = true;
		this.Button2.Location = new System.Drawing.Point(638, 241);
		this.Button2.Name = "Button2";
		this.Button2.Size = new System.Drawing.Size(75, 23);
		this.Button2.TabIndex = 3;
		this.Button2.Text = "Mostrar";
		this.Button2.UseVisualStyleBackColor = true;
		this.Label1.AutoSize = true;
		this.Label1.Location = new System.Drawing.Point(12, 49);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(52, 13);
		this.Label1.TabIndex = 4;
		this.Label1.Text = "Eventual:";
		this.Label2.AutoSize = true;
		this.Label2.Location = new System.Drawing.Point(12, 88);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(73, 13);
		this.Label2.TabIndex = 5;
		this.Label2.Text = "Comprobante:";
		this.Label3.AutoSize = true;
		this.Label3.Location = new System.Drawing.Point(12, 127);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(42, 13);
		this.Label3.TabIndex = 6;
		this.Label3.Text = "Cliente:";
		this.ComboBox3.FormattingEnabled = true;
		this.ComboBox3.Location = new System.Drawing.Point(101, 124);
		this.ComboBox3.Name = "ComboBox3";
		this.ComboBox3.Size = new System.Drawing.Size(121, 21);
		this.ComboBox3.TabIndex = 7;
		this.Label4.AutoSize = true;
		this.Label4.Location = new System.Drawing.Point(12, 166);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(48, 13);
		this.Label4.TabIndex = 8;
		this.Label4.Text = "Remitos:";
		this.Label5.AutoSize = true;
		this.Label5.Location = new System.Drawing.Point(12, 205);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(46, 13);
		this.Label5.TabIndex = 9;
		this.Label5.Text = "Destino:";
		this.Label6.AutoSize = true;
		this.Label6.Location = new System.Drawing.Point(12, 244);
		this.Label6.Name = "Label6";
		this.Label6.Size = new System.Drawing.Size(52, 13);
		this.Label6.TabIndex = 10;
		this.Label6.Text = "Domicilio:";
		this.Label7.AutoSize = true;
		this.Label7.Location = new System.Drawing.Point(259, 49);
		this.Label7.Name = "Label7";
		this.Label7.Size = new System.Drawing.Size(24, 13);
		this.Label7.TabIndex = 11;
		this.Label7.Text = "CP:";
		this.Label8.AutoSize = true;
		this.Label8.Location = new System.Drawing.Point(259, 88);
		this.Label8.Name = "Label8";
		this.Label8.Size = new System.Drawing.Size(56, 13);
		this.Label8.TabIndex = 12;
		this.Label8.Text = "Localidad:";
		this.Label9.AutoSize = true;
		this.Label9.Location = new System.Drawing.Point(259, 127);
		this.Label9.Name = "Label9";
		this.Label9.Size = new System.Drawing.Size(59, 13);
		this.Label9.TabIndex = 13;
		this.Label9.Text = "Declarado:";
		this.Label10.AutoSize = true;
		this.Label10.Location = new System.Drawing.Point(259, 166);
		this.Label10.Name = "Label10";
		this.Label10.Size = new System.Drawing.Size(39, 13);
		this.Label10.TabIndex = 14;
		this.Label10.Text = "Bultos:";
		this.Label11.AutoSize = true;
		this.Label11.Location = new System.Drawing.Point(259, 205);
		this.Label11.Name = "Label11";
		this.Label11.Size = new System.Drawing.Size(32, 13);
		this.Label11.TabIndex = 15;
		this.Label11.Text = "Kilos:";
		this.Label12.AutoSize = true;
		this.Label12.Location = new System.Drawing.Point(259, 244);
		this.Label12.Name = "Label12";
		this.Label12.Size = new System.Drawing.Size(29, 13);
		this.Label12.TabIndex = 16;
		this.Label12.Text = "Sub:";
		this.Label13.AutoSize = true;
		this.Label13.Location = new System.Drawing.Point(494, 49);
		this.Label13.Name = "Label13";
		this.Label13.Size = new System.Drawing.Size(81, 13);
		this.Label13.TabIndex = 17;
		this.Label13.Text = "Observaciones:";
		this.Label14.AutoSize = true;
		this.Label14.Location = new System.Drawing.Point(494, 88);
		this.Label14.Name = "Label14";
		this.Label14.Size = new System.Drawing.Size(51, 13);
		this.Label14.TabIndex = 18;
		this.Label14.Text = "Volumen:";
		this.Label15.AutoSize = true;
		this.Label15.Location = new System.Drawing.Point(494, 127);
		this.Label15.Name = "Label15";
		this.Label15.Size = new System.Drawing.Size(40, 13);
		this.Label15.TabIndex = 19;
		this.Label15.Text = "Atraso:";
		this.Label16.AutoSize = true;
		this.Label16.Location = new System.Drawing.Point(494, 166);
		this.Label16.Name = "Label16";
		this.Label16.Size = new System.Drawing.Size(46, 13);
		this.Label16.TabIndex = 20;
		this.Label16.Text = "Diferida:";
		this.Label17.AutoSize = true;
		this.Label17.Location = new System.Drawing.Point(494, 205);
		this.Label17.Name = "Label17";
		this.Label17.Size = new System.Drawing.Size(33, 13);
		this.Label17.TabIndex = 21;
		this.Label17.Text = "Flete:";
		this.ComboBox4.FormattingEnabled = true;
		this.ComboBox4.Location = new System.Drawing.Point(101, 163);
		this.ComboBox4.Name = "ComboBox4";
		this.ComboBox4.Size = new System.Drawing.Size(121, 21);
		this.ComboBox4.TabIndex = 22;
		this.ComboBox5.FormattingEnabled = true;
		this.ComboBox5.Location = new System.Drawing.Point(101, 202);
		this.ComboBox5.Name = "ComboBox5";
		this.ComboBox5.Size = new System.Drawing.Size(121, 21);
		this.ComboBox5.TabIndex = 23;
		this.ComboBox6.FormattingEnabled = true;
		this.ComboBox6.Location = new System.Drawing.Point(101, 241);
		this.ComboBox6.Name = "ComboBox6";
		this.ComboBox6.Size = new System.Drawing.Size(121, 21);
		this.ComboBox6.TabIndex = 24;
		this.ComboBox7.FormattingEnabled = true;
		this.ComboBox7.Location = new System.Drawing.Point(337, 46);
		this.ComboBox7.Name = "ComboBox7";
		this.ComboBox7.Size = new System.Drawing.Size(121, 21);
		this.ComboBox7.TabIndex = 25;
		this.ComboBox8.FormattingEnabled = true;
		this.ComboBox8.Location = new System.Drawing.Point(337, 85);
		this.ComboBox8.Name = "ComboBox8";
		this.ComboBox8.Size = new System.Drawing.Size(121, 21);
		this.ComboBox8.TabIndex = 26;
		this.ComboBox9.FormattingEnabled = true;
		this.ComboBox9.Location = new System.Drawing.Point(337, 124);
		this.ComboBox9.Name = "ComboBox9";
		this.ComboBox9.Size = new System.Drawing.Size(121, 21);
		this.ComboBox9.TabIndex = 27;
		this.ComboBox10.FormattingEnabled = true;
		this.ComboBox10.Location = new System.Drawing.Point(337, 163);
		this.ComboBox10.Name = "ComboBox10";
		this.ComboBox10.Size = new System.Drawing.Size(121, 21);
		this.ComboBox10.TabIndex = 28;
		this.ComboBox11.FormattingEnabled = true;
		this.ComboBox11.Location = new System.Drawing.Point(337, 202);
		this.ComboBox11.Name = "ComboBox11";
		this.ComboBox11.Size = new System.Drawing.Size(121, 21);
		this.ComboBox11.TabIndex = 29;
		this.ComboBox12.FormattingEnabled = true;
		this.ComboBox12.Location = new System.Drawing.Point(337, 241);
		this.ComboBox12.Name = "ComboBox12";
		this.ComboBox12.Size = new System.Drawing.Size(121, 21);
		this.ComboBox12.TabIndex = 30;
		this.ComboBox13.FormattingEnabled = true;
		this.ComboBox13.Location = new System.Drawing.Point(592, 46);
		this.ComboBox13.Name = "ComboBox13";
		this.ComboBox13.Size = new System.Drawing.Size(121, 21);
		this.ComboBox13.TabIndex = 31;
		this.ComboBox14.FormattingEnabled = true;
		this.ComboBox14.Location = new System.Drawing.Point(592, 85);
		this.ComboBox14.Name = "ComboBox14";
		this.ComboBox14.Size = new System.Drawing.Size(121, 21);
		this.ComboBox14.TabIndex = 32;
		this.ComboBox15.FormattingEnabled = true;
		this.ComboBox15.Location = new System.Drawing.Point(592, 124);
		this.ComboBox15.Name = "ComboBox15";
		this.ComboBox15.Size = new System.Drawing.Size(121, 21);
		this.ComboBox15.TabIndex = 33;
		this.ComboBox16.FormattingEnabled = true;
		this.ComboBox16.Location = new System.Drawing.Point(592, 163);
		this.ComboBox16.Name = "ComboBox16";
		this.ComboBox16.Size = new System.Drawing.Size(121, 21);
		this.ComboBox16.TabIndex = 34;
		this.ComboBox17.FormattingEnabled = true;
		this.ComboBox17.Location = new System.Drawing.Point(592, 202);
		this.ComboBox17.Name = "ComboBox17";
		this.ComboBox17.Size = new System.Drawing.Size(121, 21);
		this.ComboBox17.TabIndex = 35;
		this.Button3.Location = new System.Drawing.Point(10, 12);
		this.Button3.Name = "Button3";
		this.Button3.Size = new System.Drawing.Size(75, 23);
		this.Button3.TabIndex = 36;
		this.Button3.Text = "Seleccionar";
		this.Button3.UseVisualStyleBackColor = true;
		this.Label18.AutoSize = true;
		this.Label18.Location = new System.Drawing.Point(110, 17);
		this.Label18.Name = "Label18";
		this.Label18.Size = new System.Drawing.Size(58, 13);
		this.Label18.TabIndex = 37;
		this.Label18.Text = "Archivo.xls";
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(735, 280);
		base.Controls.Add(this.Label18);
		base.Controls.Add(this.Button3);
		base.Controls.Add(this.ComboBox17);
		base.Controls.Add(this.ComboBox16);
		base.Controls.Add(this.ComboBox15);
		base.Controls.Add(this.ComboBox14);
		base.Controls.Add(this.ComboBox13);
		base.Controls.Add(this.ComboBox12);
		base.Controls.Add(this.ComboBox11);
		base.Controls.Add(this.ComboBox10);
		base.Controls.Add(this.ComboBox9);
		base.Controls.Add(this.ComboBox8);
		base.Controls.Add(this.ComboBox7);
		base.Controls.Add(this.ComboBox6);
		base.Controls.Add(this.ComboBox5);
		base.Controls.Add(this.ComboBox4);
		base.Controls.Add(this.Label17);
		base.Controls.Add(this.Label16);
		base.Controls.Add(this.Label15);
		base.Controls.Add(this.Label14);
		base.Controls.Add(this.Label13);
		base.Controls.Add(this.Label12);
		base.Controls.Add(this.Label11);
		base.Controls.Add(this.Label10);
		base.Controls.Add(this.Label9);
		base.Controls.Add(this.Label8);
		base.Controls.Add(this.Label7);
		base.Controls.Add(this.Label6);
		base.Controls.Add(this.Label5);
		base.Controls.Add(this.Label4);
		base.Controls.Add(this.ComboBox3);
		base.Controls.Add(this.Label3);
		base.Controls.Add(this.Label2);
		base.Controls.Add(this.Label1);
		base.Controls.Add(this.Button2);
		base.Controls.Add(this.Button1);
		base.Controls.Add(this.ComboBox2);
		base.Controls.Add(this.ComboBox1);
		base.Name = "ImportarConfig";
		this.Text = "ImportarConfig";
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private void ImportarConfig_Load(object sender, EventArgs e)
	{
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		MySettingsProperty.Settings.Eventual = ComboBox1.Text;
		MySettingsProperty.Settings.Comprobante = ComboBox2.Text;
		MySettingsProperty.Settings.Cliente = ComboBox3.Text;
		MySettingsProperty.Settings.Remitos = ComboBox4.Text;
		MySettingsProperty.Settings.Destino = ComboBox5.Text;
		MySettingsProperty.Settings.Domicilio = ComboBox6.Text;
		MySettingsProperty.Settings.CP = ComboBox7.Text;
		MySettingsProperty.Settings.Localidad = ComboBox8.Text;
		MySettingsProperty.Settings.Declarado = ComboBox9.Text;
		MySettingsProperty.Settings.Bultos = ComboBox10.Text;
		MySettingsProperty.Settings.Kilos = ComboBox11.Text;
		MySettingsProperty.Settings.Subc = ComboBox12.Text;
		MySettingsProperty.Settings.Observaciones = ComboBox13.Text;
		MySettingsProperty.Settings.Volumen = ComboBox14.Text;
		MySettingsProperty.Settings.Atraso = ComboBox15.Text;
		MySettingsProperty.Settings.Diferida = ComboBox16.Text;
		MySettingsProperty.Settings.Flete = ComboBox17.Text;
		MySettingsProperty.Settings.Save();
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		ComboBox1.Text = MySettingsProperty.Settings.Eventual;
		ComboBox2.Text = MySettingsProperty.Settings.Comprobante;
		ComboBox3.Text = MySettingsProperty.Settings.Cliente;
		ComboBox4.Text = MySettingsProperty.Settings.Remitos;
		ComboBox5.Text = MySettingsProperty.Settings.Destino;
		ComboBox6.Text = MySettingsProperty.Settings.Domicilio;
		ComboBox7.Text = MySettingsProperty.Settings.CP;
		ComboBox8.Text = MySettingsProperty.Settings.Localidad;
		ComboBox9.Text = MySettingsProperty.Settings.Declarado;
		ComboBox10.Text = MySettingsProperty.Settings.Bultos;
		ComboBox11.Text = MySettingsProperty.Settings.Kilos;
		ComboBox12.Text = MySettingsProperty.Settings.Subc;
		ComboBox13.Text = MySettingsProperty.Settings.Observaciones;
		ComboBox14.Text = MySettingsProperty.Settings.Volumen;
		ComboBox15.Text = MySettingsProperty.Settings.Atraso;
		ComboBox16.Text = MySettingsProperty.Settings.Diferida;
		ComboBox17.Text = MySettingsProperty.Settings.Flete;
	}

	private void Button3_Click(object sender, EventArgs e)
	{
		try
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			OpenFileDialog openFileDialog2 = openFileDialog;
			openFileDialog2.Filter = "Excel files(*.xls)|*xls|All files (*.*)|*.*";
			openFileDialog2.FilterIndex = 1;
			openFileDialog2.Title = "Import data from Excel file";
			openFileDialog2 = null;
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				string fileName = openFileDialog.FileName;
				Label18.Text = fileName;
				LoadFile(fileName);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void LoadFile(string path)
	{
		OleDbConnection oleDbConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source='" + path + "'; Extended Properties=Excel 8.0;");
		OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("select * from [Planchada$]", oleDbConnection);
		oleDbDataAdapter.TableMappings.Add("Table", "Test");
		DataSet dataSet = new DataSet();
		oleDbDataAdapter.Fill(dataSet);
		oleDbConnection.Close();
		checked
		{
			int num = dataSet.Tables[0].Columns.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				ComboBox1.Items.Add(dataSet.Tables[0].Columns[i].Caption);
				ComboBox2.Items.Add(dataSet.Tables[0].Columns[i].Caption);
				ComboBox3.Items.Add(dataSet.Tables[0].Columns[i].Caption);
				ComboBox4.Items.Add(dataSet.Tables[0].Columns[i].Caption);
				ComboBox5.Items.Add(dataSet.Tables[0].Columns[i].Caption);
				ComboBox6.Items.Add(dataSet.Tables[0].Columns[i].Caption);
				ComboBox7.Items.Add(dataSet.Tables[0].Columns[i].Caption);
				ComboBox8.Items.Add(dataSet.Tables[0].Columns[i].Caption);
				ComboBox9.Items.Add(dataSet.Tables[0].Columns[i].Caption);
				ComboBox10.Items.Add(dataSet.Tables[0].Columns[i].Caption);
				ComboBox11.Items.Add(dataSet.Tables[0].Columns[i].Caption);
				ComboBox12.Items.Add(dataSet.Tables[0].Columns[i].Caption);
				ComboBox13.Items.Add(dataSet.Tables[0].Columns[i].Caption);
				ComboBox14.Items.Add(dataSet.Tables[0].Columns[i].Caption);
				ComboBox15.Items.Add(dataSet.Tables[0].Columns[i].Caption);
				ComboBox16.Items.Add(dataSet.Tables[0].Columns[i].Caption);
				ComboBox17.Items.Add(dataSet.Tables[0].Columns[i].Caption);
			}
			Label2.Text = MySettingsProperty.Settings.Comprobante.ToString();
		}
	}
}
