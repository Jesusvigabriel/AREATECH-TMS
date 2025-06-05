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
public class Estados : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("RadioButton1")]
	private RadioButton _RadioButton1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("RadioButton2")]
	private RadioButton _RadioButton2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("RadioButton3")]
	private RadioButton _RadioButton3;

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

	private string fecha1;

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual RadioButton RadioButton1
	{
		[CompilerGenerated]
		get
		{
			return _RadioButton1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = RadioButton1_CheckedChanged;
			RadioButton radioButton = _RadioButton1;
			if (radioButton != null)
			{
				radioButton.CheckedChanged -= value2;
			}
			_RadioButton1 = value;
			radioButton = _RadioButton1;
			if (radioButton != null)
			{
				radioButton.CheckedChanged += value2;
			}
		}
	}

	internal virtual RadioButton RadioButton2
	{
		[CompilerGenerated]
		get
		{
			return _RadioButton2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = RadioButton2_CheckedChanged;
			RadioButton radioButton = _RadioButton2;
			if (radioButton != null)
			{
				radioButton.CheckedChanged -= value2;
			}
			_RadioButton2 = value;
			radioButton = _RadioButton2;
			if (radioButton != null)
			{
				radioButton.CheckedChanged += value2;
			}
		}
	}

	internal virtual RadioButton RadioButton3
	{
		[CompilerGenerated]
		get
		{
			return _RadioButton3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = RadioButton3_CheckedChanged;
			RadioButton radioButton = _RadioButton3;
			if (radioButton != null)
			{
				radioButton.CheckedChanged -= value2;
			}
			_RadioButton3 = value;
			radioButton = _RadioButton3;
			if (radioButton != null)
			{
				radioButton.CheckedChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ComboBox1")]
	internal virtual ComboBox ComboBox1
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

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
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

	[field: AccessedThroughProperty("GroupBox1")]
	internal virtual GroupBox GroupBox1
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

	[field: AccessedThroughProperty("Label15")]
	internal virtual Label Label15
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

	[field: AccessedThroughProperty("Label18")]
	internal virtual Label Label18
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

	[field: AccessedThroughProperty("Label20")]
	internal virtual Label Label20
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label21")]
	internal virtual Label Label21
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

	[field: AccessedThroughProperty("Label22")]
	internal virtual Label Label22
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label23")]
	internal virtual Label Label23
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label24")]
	internal virtual Label Label24
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label25")]
	internal virtual Label Label25
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public Estados()
	{
		base.Load += Estados_Load;
		fecha1 = Strings.Format(MyProject.Forms.Novedades.DateTimePicker1.Value, "yyyyMMdd");
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
		this.Label1 = new System.Windows.Forms.Label();
		this.RadioButton1 = new System.Windows.Forms.RadioButton();
		this.RadioButton2 = new System.Windows.Forms.RadioButton();
		this.RadioButton3 = new System.Windows.Forms.RadioButton();
		this.Label2 = new System.Windows.Forms.Label();
		this.ComboBox1 = new System.Windows.Forms.ComboBox();
		this.Label4 = new System.Windows.Forms.Label();
		this.Label5 = new System.Windows.Forms.Label();
		this.Button1 = new System.Windows.Forms.Button();
		this.Button2 = new System.Windows.Forms.Button();
		this.Label6 = new System.Windows.Forms.Label();
		this.Label7 = new System.Windows.Forms.Label();
		this.Label8 = new System.Windows.Forms.Label();
		this.Label9 = new System.Windows.Forms.Label();
		this.Label3 = new System.Windows.Forms.Label();
		this.Label10 = new System.Windows.Forms.Label();
		this.Label11 = new System.Windows.Forms.Label();
		this.Label12 = new System.Windows.Forms.Label();
		this.Label13 = new System.Windows.Forms.Label();
		this.Label14 = new System.Windows.Forms.Label();
		this.GroupBox1 = new System.Windows.Forms.GroupBox();
		this.Label19 = new System.Windows.Forms.Label();
		this.Label18 = new System.Windows.Forms.Label();
		this.Label17 = new System.Windows.Forms.Label();
		this.Label16 = new System.Windows.Forms.Label();
		this.CheckBox1 = new System.Windows.Forms.CheckBox();
		this.Label15 = new System.Windows.Forms.Label();
		this.Button3 = new System.Windows.Forms.Button();
		this.Button4 = new System.Windows.Forms.Button();
		this.Label20 = new System.Windows.Forms.Label();
		this.Label21 = new System.Windows.Forms.Label();
		this.ComboBox2 = new System.Windows.Forms.ComboBox();
		this.Label22 = new System.Windows.Forms.Label();
		this.Label23 = new System.Windows.Forms.Label();
		this.Label24 = new System.Windows.Forms.Label();
		this.Label25 = new System.Windows.Forms.Label();
		this.GroupBox1.SuspendLayout();
		base.SuspendLayout();
		this.Label1.AutoSize = true;
		this.Label1.Location = new System.Drawing.Point(12, 9);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(57, 13);
		this.Label1.TabIndex = 0;
		this.Label1.Text = "Realizado:";
		this.RadioButton1.AutoSize = true;
		this.RadioButton1.Location = new System.Drawing.Point(87, 14);
		this.RadioButton1.Name = "RadioButton1";
		this.RadioButton1.Size = new System.Drawing.Size(34, 17);
		this.RadioButton1.TabIndex = 1;
		this.RadioButton1.TabStop = true;
		this.RadioButton1.Text = "Si";
		this.RadioButton1.UseVisualStyleBackColor = true;
		this.RadioButton2.AutoSize = true;
		this.RadioButton2.Location = new System.Drawing.Point(87, 43);
		this.RadioButton2.Name = "RadioButton2";
		this.RadioButton2.Size = new System.Drawing.Size(57, 17);
		this.RadioButton2.TabIndex = 2;
		this.RadioButton2.TabStop = true;
		this.RadioButton2.Text = "Parcial";
		this.RadioButton2.UseVisualStyleBackColor = true;
		this.RadioButton3.AutoSize = true;
		this.RadioButton3.Location = new System.Drawing.Point(87, 70);
		this.RadioButton3.Name = "RadioButton3";
		this.RadioButton3.Size = new System.Drawing.Size(39, 17);
		this.RadioButton3.TabIndex = 3;
		this.RadioButton3.TabStop = true;
		this.RadioButton3.Text = "No";
		this.RadioButton3.UseVisualStyleBackColor = true;
		this.Label2.AutoSize = true;
		this.Label2.Location = new System.Drawing.Point(177, 16);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(42, 13);
		this.Label2.TabIndex = 4;
		this.Label2.Text = "Motivo:";
		this.ComboBox1.FormattingEnabled = true;
		this.ComboBox1.Location = new System.Drawing.Point(276, 13);
		this.ComboBox1.Name = "ComboBox1";
		this.ComboBox1.Size = new System.Drawing.Size(372, 21);
		this.ComboBox1.TabIndex = 5;
		this.Label4.AutoSize = true;
		this.Label4.Location = new System.Drawing.Point(322, 96);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(24, 13);
		this.Label4.TabIndex = 8;
		this.Label4.Text = "CP:";
		this.Label5.AutoSize = true;
		this.Label5.Location = new System.Drawing.Point(416, 96);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(39, 13);
		this.Label5.TabIndex = 9;
		this.Label5.Text = "Label5";
		this.Button1.Location = new System.Drawing.Point(12, 224);
		this.Button1.Name = "Button1";
		this.Button1.Size = new System.Drawing.Size(75, 23);
		this.Button1.TabIndex = 10;
		this.Button1.Text = "Guardar";
		this.Button1.UseVisualStyleBackColor = true;
		this.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
		this.Button2.Location = new System.Drawing.Point(576, 224);
		this.Button2.Name = "Button2";
		this.Button2.Size = new System.Drawing.Size(75, 23);
		this.Button2.TabIndex = 11;
		this.Button2.Text = "Salir";
		this.Button2.UseVisualStyleBackColor = true;
		this.Label6.AutoSize = true;
		this.Label6.Location = new System.Drawing.Point(84, 29);
		this.Label6.Name = "Label6";
		this.Label6.Size = new System.Drawing.Size(39, 13);
		this.Label6.TabIndex = 12;
		this.Label6.Text = "Label6";
		this.Label7.AutoSize = true;
		this.Label7.Location = new System.Drawing.Point(84, 63);
		this.Label7.Name = "Label7";
		this.Label7.Size = new System.Drawing.Size(39, 13);
		this.Label7.TabIndex = 13;
		this.Label7.Text = "Label7";
		this.Label8.AutoSize = true;
		this.Label8.Location = new System.Drawing.Point(15, 96);
		this.Label8.Name = "Label8";
		this.Label8.Size = new System.Drawing.Size(55, 13);
		this.Label8.TabIndex = 14;
		this.Label8.Text = "Dirección:";
		this.Label9.AutoSize = true;
		this.Label9.Location = new System.Drawing.Point(322, 29);
		this.Label9.Name = "Label9";
		this.Label9.Size = new System.Drawing.Size(56, 13);
		this.Label9.TabIndex = 15;
		this.Label9.Text = "Localidad:";
		this.Label3.AutoSize = true;
		this.Label3.Location = new System.Drawing.Point(15, 29);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(42, 13);
		this.Label3.TabIndex = 16;
		this.Label3.Text = "Cliente:";
		this.Label10.AutoSize = true;
		this.Label10.Location = new System.Drawing.Point(15, 63);
		this.Label10.Name = "Label10";
		this.Label10.Size = new System.Drawing.Size(63, 13);
		this.Label10.TabIndex = 17;
		this.Label10.Text = "SubCuenta:";
		this.Label11.AutoSize = true;
		this.Label11.Location = new System.Drawing.Point(84, 96);
		this.Label11.Name = "Label11";
		this.Label11.Size = new System.Drawing.Size(45, 13);
		this.Label11.TabIndex = 18;
		this.Label11.Text = "Label11";
		this.Label12.AutoSize = true;
		this.Label12.Location = new System.Drawing.Point(322, 63);
		this.Label12.Name = "Label12";
		this.Label12.Size = new System.Drawing.Size(48, 13);
		this.Label12.TabIndex = 19;
		this.Label12.Text = "Remitos:";
		this.Label13.AutoSize = true;
		this.Label13.Location = new System.Drawing.Point(416, 29);
		this.Label13.Name = "Label13";
		this.Label13.Size = new System.Drawing.Size(45, 13);
		this.Label13.TabIndex = 20;
		this.Label13.Text = "Label13";
		this.Label14.AutoSize = true;
		this.Label14.Location = new System.Drawing.Point(573, 16);
		this.Label14.Name = "Label14";
		this.Label14.Size = new System.Drawing.Size(45, 13);
		this.Label14.TabIndex = 21;
		this.Label14.Text = "Label14";
		this.Label14.Visible = false;
		this.GroupBox1.Controls.Add(this.Label25);
		this.GroupBox1.Controls.Add(this.Label24);
		this.GroupBox1.Controls.Add(this.Label19);
		this.GroupBox1.Controls.Add(this.Label18);
		this.GroupBox1.Controls.Add(this.Label17);
		this.GroupBox1.Controls.Add(this.Label16);
		this.GroupBox1.Controls.Add(this.Label12);
		this.GroupBox1.Controls.Add(this.Label14);
		this.GroupBox1.Controls.Add(this.Label4);
		this.GroupBox1.Controls.Add(this.Label13);
		this.GroupBox1.Controls.Add(this.Label5);
		this.GroupBox1.Controls.Add(this.Label6);
		this.GroupBox1.Controls.Add(this.Label11);
		this.GroupBox1.Controls.Add(this.Label7);
		this.GroupBox1.Controls.Add(this.Label10);
		this.GroupBox1.Controls.Add(this.Label8);
		this.GroupBox1.Controls.Add(this.Label3);
		this.GroupBox1.Controls.Add(this.Label9);
		this.GroupBox1.Location = new System.Drawing.Point(15, 93);
		this.GroupBox1.Name = "GroupBox1";
		this.GroupBox1.Size = new System.Drawing.Size(636, 125);
		this.GroupBox1.TabIndex = 22;
		this.GroupBox1.TabStop = false;
		this.GroupBox1.Text = "Información:";
		this.Label19.AutoSize = true;
		this.Label19.Location = new System.Drawing.Point(573, 96);
		this.Label19.Name = "Label19";
		this.Label19.Size = new System.Drawing.Size(37, 13);
		this.Label19.TabIndex = 25;
		this.Label19.Text = "chofer";
		this.Label19.Visible = false;
		this.Label18.AutoSize = true;
		this.Label18.Location = new System.Drawing.Point(573, 73);
		this.Label18.Name = "Label18";
		this.Label18.Size = new System.Drawing.Size(45, 13);
		this.Label18.TabIndex = 24;
		this.Label18.Text = "Label18";
		this.Label18.Visible = false;
		this.Label17.AutoSize = true;
		this.Label17.Location = new System.Drawing.Point(416, 63);
		this.Label17.Name = "Label17";
		this.Label17.Size = new System.Drawing.Size(45, 13);
		this.Label17.TabIndex = 23;
		this.Label17.Text = "Label17";
		this.Label16.AutoSize = true;
		this.Label16.Location = new System.Drawing.Point(573, 46);
		this.Label16.Name = "Label16";
		this.Label16.Size = new System.Drawing.Size(45, 13);
		this.Label16.TabIndex = 22;
		this.Label16.Text = "Label16";
		this.Label16.Visible = false;
		this.CheckBox1.AutoSize = true;
		this.CheckBox1.Enabled = false;
		this.CheckBox1.Location = new System.Drawing.Point(170, 71);
		this.CheckBox1.Name = "CheckBox1";
		this.CheckBox1.Size = new System.Drawing.Size(126, 17);
		this.CheckBox1.TabIndex = 22;
		this.CheckBox1.Text = "Aplicar a toda la ruta.";
		this.CheckBox1.UseVisualStyleBackColor = true;
		this.CheckBox1.Visible = false;
		this.Label15.AutoSize = true;
		this.Label15.Location = new System.Drawing.Point(177, 45);
		this.Label15.Name = "Label15";
		this.Label15.Size = new System.Drawing.Size(68, 13);
		this.Label15.TabIndex = 24;
		this.Label15.Text = "Obs. Interna:";
		this.Button3.Location = new System.Drawing.Point(207, 224);
		this.Button3.Name = "Button3";
		this.Button3.Size = new System.Drawing.Size(75, 23);
		this.Button3.TabIndex = 25;
		this.Button3.Text = "Mail";
		this.Button3.UseVisualStyleBackColor = true;
		this.Button4.Location = new System.Drawing.Point(368, 224);
		this.Button4.Name = "Button4";
		this.Button4.Size = new System.Drawing.Size(75, 23);
		this.Button4.TabIndex = 26;
		this.Button4.Text = "Informacion";
		this.Button4.UseVisualStyleBackColor = true;
		this.Label20.AutoSize = true;
		this.Label20.Location = new System.Drawing.Point(316, 74);
		this.Label20.Name = "Label20";
		this.Label20.Size = new System.Drawing.Size(45, 13);
		this.Label20.TabIndex = 27;
		this.Label20.Text = "Label20";
		this.Label20.Visible = false;
		this.Label21.AutoSize = true;
		this.Label21.Location = new System.Drawing.Point(588, 75);
		this.Label21.Name = "Label21";
		this.Label21.Size = new System.Drawing.Size(45, 13);
		this.Label21.TabIndex = 28;
		this.Label21.Text = "Label21";
		this.Label21.Visible = false;
		this.ComboBox2.FormattingEnabled = true;
		this.ComboBox2.Location = new System.Drawing.Point(276, 42);
		this.ComboBox2.Name = "ComboBox2";
		this.ComboBox2.Size = new System.Drawing.Size(372, 21);
		this.ComboBox2.TabIndex = 29;
		this.Label22.AutoSize = true;
		this.Label22.Location = new System.Drawing.Point(431, 74);
		this.Label22.Name = "Label22";
		this.Label22.Size = new System.Drawing.Size(45, 13);
		this.Label22.TabIndex = 30;
		this.Label22.Text = "Label22";
		this.Label22.Visible = false;
		this.Label23.AutoSize = true;
		this.Label23.Location = new System.Drawing.Point(505, 80);
		this.Label23.Name = "Label23";
		this.Label23.Size = new System.Drawing.Size(45, 13);
		this.Label23.TabIndex = 31;
		this.Label23.Text = "Label23";
		this.Label23.Visible = false;
		this.Label24.AutoSize = true;
		this.Label24.Location = new System.Drawing.Point(502, 45);
		this.Label24.Name = "Label24";
		this.Label24.Size = new System.Drawing.Size(45, 13);
		this.Label24.TabIndex = 26;
		this.Label24.Text = "Label24";
		this.Label24.Visible = false;
		this.Label25.AutoSize = true;
		this.Label25.Location = new System.Drawing.Point(197, 40);
		this.Label25.Name = "Label25";
		this.Label25.Size = new System.Drawing.Size(45, 13);
		this.Label25.TabIndex = 27;
		this.Label25.Text = "Label25";
		this.Label25.Visible = false;
		base.AcceptButton = this.Button1;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.CancelButton = this.Button2;
		base.ClientSize = new System.Drawing.Size(660, 259);
		base.ControlBox = false;
		base.Controls.Add(this.Label23);
		base.Controls.Add(this.Label22);
		base.Controls.Add(this.ComboBox2);
		base.Controls.Add(this.Label21);
		base.Controls.Add(this.Label20);
		base.Controls.Add(this.Button4);
		base.Controls.Add(this.Button3);
		base.Controls.Add(this.Label15);
		base.Controls.Add(this.CheckBox1);
		base.Controls.Add(this.GroupBox1);
		base.Controls.Add(this.Button2);
		base.Controls.Add(this.Button1);
		base.Controls.Add(this.ComboBox1);
		base.Controls.Add(this.Label2);
		base.Controls.Add(this.RadioButton3);
		base.Controls.Add(this.RadioButton2);
		base.Controls.Add(this.RadioButton1);
		base.Controls.Add(this.Label1);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
		base.Name = "Estados";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Estados";
		this.GroupBox1.ResumeLayout(false);
		this.GroupBox1.PerformLayout();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private void Estados_Load(object sender, EventArgs e)
	{
		Label20.ForeColor = Color.Red;
		string sql = "SELECT estado From planchada WHERE remitos=" + Label17.Text + " AND cliente='ETRANS' AND fecha=" + fecha1;
		string left = Conversions.ToString(Mod_Sentencias.dataValue(sql, "estado"));
		if (Operators.CompareString(left, "PARCIAL", TextCompare: true) == 0)
		{
			RadioButton2.Checked = true;
		}
		if ((Operators.CompareString(left, "NO ENTREGADO", TextCompare: true) == 0) | (Operators.CompareString(left, "NO RECOLECTADO", TextCompare: true) == 0))
		{
			RadioButton3.Checked = true;
		}
		string sql2 = "SELECT comentario FROM estados WHERE motivo=0 order by comentario asc";
		Mod_Sentencias.cargar_cbb(ComboBox1, sql2);
		ComboBox2.Items.Clear();
		ComboBox2.Items.Add("VUELVE A RUTA");
		ComboBox2.Items.Add("STAND BY");
		ComboBox2.Items.Add("A DEVOLUCION");
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		//IL_0405: Unknown result type (might be due to invalid IL or missing references)
		//IL_040c: Expected O, but got Unknown
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Expected O, but got Unknown
		checked
		{
			try
			{
				Mod_Ordenes.envioArea envioA = default(Mod_Ordenes.envioArea);
				if (!CheckBox1.Checked)
				{
					string text = Conversions.ToString(set_estado_2(Label6.Text, Conversions.ToInteger(Label7.Text)));
					string sql = "UPDATE Planchada SET Estado='" + text + "', Comentario='" + ComboBox1.Text + "', Usuario='" + MySettingsProperty.Settings.Usuario + "' WHERE Comprobante= '" + Label21.Text + "' AND Fecha='" + fecha1 + "'";
					int num = Conversions.ToInteger(Mod_novedades.guardar_novedades(sql));
					if (Operators.CompareString(ComboBox2.Text, "", TextCompare: true) != 0)
					{
						string text2 = "select id from novedades where comprobante='" + Label21.Text + "' and fecha='" + fecha1 + "'";
						DataTable dataTable = new DataTable("x");
						MySqlDataAdapter val = new MySqlDataAdapter(text2, Mod_Sentencias.cnn);
						((DbDataAdapter)(object)val).Fill(dataTable);
						if (dataTable.Rows.Count == 1)
						{
							string sql2 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("UPDATE novedades set comentario='" + ComboBox1.Text + "',estado='NO ENTREGADO',novedad='" + ComboBox2.Text + "',usuario='" + MySettingsProperty.Settings.Usuario + "' where id = '", dataTable.Rows[0]["id"]), "'"));
							num = Conversions.ToInteger(Mod_novedades.guardar_novedades(sql2));
						}
						else
						{
							string sql3 = "insert into Novedades (comprobante,comentario,estado,novedad,usuario,fecha) values('" + Label21.Text + "','" + ComboBox1.Text + "','" + text + "','" + ComboBox2.Text + "','" + MySettingsProperty.Settings.Usuario + "','" + fecha1 + "')";
							num = Conversions.ToInteger(Mod_novedades.guardar_novedades(sql3));
						}
						int num2 = Conversions.ToInteger(Mod_logger.historialenter(Label21.Text, ComboBox1.Text, text, ""));
					}
					envioA.estado = text;
					envioA.guia = Label22.Text;
					envioA.comprobante = Label21.Text;
					envioA.cliente = Label6.Text;
					envioA.destino = Label16.Text;
					envioA.remito = Label17.Text;
					envioA.bultos = Label23.Text;
					envioA.atraso = Label24.Text;
					envioA.observaciones = Label25.Text;
					envioA.fecha = fecha1;
					envioA.comentario = ComboBox1.Text;
					try
					{
						int num3 = int.Parse(Conversions.ToString(Mod_Ordenes.actualizarEnvioArea(envioA)));
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception objExcepcion = ex;
						Logger.e("Error con excepción y traza", objExcepcion, new StackFrame(fNeedFileInfo: true));
						ProjectData.ClearProjectError();
					}
				}
				else
				{
					string text3 = "select comprobante, cliente, sub, Remitos from planchada where chofer='" + Label19.Text + "' and fecha='" + fecha1 + "'";
					DataTable dataTable2 = new DataTable("x");
					MySqlDataAdapter val2 = new MySqlDataAdapter(text3, Mod_Sentencias.cnn);
					((DbDataAdapter)(object)val2).Fill(dataTable2);
					int num4 = dataTable2.Rows.Count - 1;
					for (int i = 0; i <= num4; i++)
					{
						string text4 = dataTable2.Rows[i]["cliente"].ToString();
						int subcuenta = Conversions.ToInteger(dataTable2.Rows[i]["Sub"]);
						string text5 = Conversions.ToString(dataTable2.Rows[i]["Comprobante"]);
						string text6 = Conversions.ToString(dataTable2.Rows[i]["Remitos"]);
						string text7 = Conversions.ToString(set_estado_2(text4, subcuenta));
						string sql4 = "UPDATE Planchada SET Estado='" + text7 + "', Comentario='" + ComboBox1.Text + "', Usuario='" + MySettingsProperty.Settings.Usuario + "' WHERE Comprobante= '" + text5 + "' AND Fecha='" + fecha1 + "'";
						int num5 = Conversions.ToInteger(Mod_novedades.guardar_novedades(sql4));
						if (Operators.CompareString(text4, "ETRANS", TextCompare: true) == 0)
						{
							Mod_Etrans.actualizar_estados(Conversions.ToInteger(text6), text7);
						}
						int num6 = Conversions.ToInteger(Mod_logger.historialenter(text5, ComboBox1.Text, text7, text6));
					}
				}
				Close();
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception objExcepcion2 = ex2;
				Logger.e("Error con excepción y traza", objExcepcion2, new StackFrame(fNeedFileInfo: true));
				ProjectData.ClearProjectError();
			}
		}
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void Button3_Click(object sender, EventArgs e)
	{
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Expected O, but got Unknown
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Expected O, but got Unknown
		string text = "";
		string left = Label6.Text;
		int num = Conversions.ToInteger(Label7.Text);
		if (RadioButton1.Checked)
		{
			text = "ENTREGADO";
		}
		if (RadioButton2.Checked)
		{
			text = "ENTREGADO PARCIAL";
		}
		if (RadioButton3.Checked)
		{
			text = ((!(Operators.CompareString(left, "ETRANS", TextCompare: true) == 0 && num == 11)) ? "NO ENTREGADO" : "NO RECOLECTADO");
		}
		try
		{
			string empty = string.Empty;
			string empty2 = string.Empty;
			string empty3 = string.Empty;
			if (Operators.CompareString(Label6.Text, "ETRANS", TextCompare: true) == 0)
			{
				empty = "select U_mail, D_mail from etransEnvios where id_envio='" + Label17.Text + "'";
				DataTable dataTable = new DataTable("x");
				MySqlDataAdapter val = new MySqlDataAdapter(empty, Mod_Sentencias.cnn);
				((DbDataAdapter)(object)val).Fill(dataTable);
				empty3 = Conversions.ToString(dataTable.Rows[0]["U_mail"]);
				empty3 = Conversions.ToString(Operators.AddObject(empty3 + "; ", dataTable.Rows[0]["D_mail"]));
				empty2 = empty3 + "; info@etrans.com.ar";
			}
			else
			{
				empty = "select contacto from clientes where nombre='" + Label6.Text + "'";
				DataTable dataTable2 = new DataTable("x");
				MySqlDataAdapter val2 = new MySqlDataAdapter(empty, Mod_Sentencias.cnn);
				((DbDataAdapter)(object)val2).Fill(dataTable2);
				empty3 = Conversions.ToString(dataTable2.Rows[0]["contacto"]);
				empty2 = empty3 + "; operaciones@area54sa.com.ar";
			}
			string body = Label17.Text + " - " + Label6.Text + " - " + Label16.Text + " - " + Label11.Text + " - " + Label13.Text + " - " + text + " - " + ComboBox1.Text;
			string subject = "Novedades: REF: " + Label17.Text;
			Mod_Enviar_mails.OpenEmail(empty2, subject, body);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			string body2 = Label17.Text + " - " + Label6.Text + " - " + Label16.Text + " - " + Label11.Text + " - " + Label13.Text + " - " + text + " - " + ComboBox1.Text;
			string emailAddress = "operaciones@area54sa.com.ar";
			string subject2 = "Novedades: REF: " + Label17.Text;
			Mod_Enviar_mails.OpenEmail(emailAddress, subject2, body2);
			ProjectData.ClearProjectError();
		}
	}

	private void Button4_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(Label6.Text, "ETRANS", TextCompare: true) == 0)
		{
			int num = Conversions.ToInteger(Label17.Text);
			E_Envio e_Envio = MyProject.Forms.E_Envio;
			e_Envio.Label22.Text = Conversions.ToString(num);
			e_Envio = null;
			MyProject.Forms.E_Envio.Show();
		}
		else
		{
			Interaction.MsgBox("Esta funcion no esta disponible para el cliente consultado.");
		}
	}

	private void RadioButton1_CheckedChanged(object sender, EventArgs e)
	{
		Label20.Visible = false;
	}

	private void RadioButton2_CheckedChanged(object sender, EventArgs e)
	{
		Label20.Visible = false;
		string sql = "SELECT comentario FROM estados WHERE motivo=2 order by comentario asc";
		Mod_Sentencias.cargar_cbb(ComboBox1, sql);
	}

	private void RadioButton3_CheckedChanged(object sender, EventArgs e)
	{
		string text = Strings.Format(MyProject.Forms.Form1_Inicio.DateTimePicker1.Value, "yyyyMMdd");
		string sql = "SELECT U_fecha From etransEnvios WHERE id_envio=" + Label17.Text;
		string left = Conversions.ToString(Mod_Sentencias.dataValue(sql, "U_fecha"));
		string right = Strings.Format(MyProject.Forms.Novedades.DateTimePicker1.Value, "dd/MM/yyyy");
		if ((Operators.CompareString(left, right, TextCompare: true) == 0) & (Operators.CompareString(Label6.Text, "ETRANS", TextCompare: true) == 0) & (Conversions.ToDouble(Label7.Text) == 11.0))
		{
			Label20.Visible = true;
			Label20.Text = "SE CAMBIARAN LAS FECHAS DE RECOLECCION Y ENTREGA";
		}
		else
		{
			Label20.Visible = false;
		}
		string sql2 = "SELECT comentario FROM estados WHERE motivo=1 order by comentario asc";
		Mod_Sentencias.cargar_cbb(ComboBox1, sql2);
	}

	private object set_estado_2(string cliente, int subcuenta)
	{
		string result = "";
		if (RadioButton1.Checked)
		{
			result = Conversions.ToString(NovedadPositiva(cliente, subcuenta));
		}
		if (RadioButton2.Checked)
		{
			result = "PARCIAL";
		}
		if (RadioButton3.Checked)
		{
			result = Conversions.ToString(NovedadNegativa(cliente, subcuenta));
		}
		return result;
	}

	private void cambiarFechaEntreg(int id_envio)
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		string text = ("SELECT D_fecha, Estado FROM etransEnvios WHERE id_envio=" + Conversions.ToString(id_envio)) ?? "";
		DataTable dataTable = new DataTable("x");
		MySqlDataAdapter val = new MySqlDataAdapter(text, Mod_Sentencias.cnn);
		((DbDataAdapter)(object)val).Fill(dataTable);
		DateTime t = Conversions.ToDate(Strings.Format(DateAndTime.Today, "dd/MM/yyyy"));
		string estado = Conversions.ToString(dataTable.Rows[0]["Estado"]);
		DateTime dateTime = Conversions.ToDate(dataTable.Rows[0]["D_fecha"]);
		if (DateTime.Compare(dateTime, t) == 0)
		{
			DateTime dateTime2 = Conversions.ToDate(Mod_calendario.proxima_fecha(dateTime));
			string text2 = Strings.Format(dateTime2, "yyyyMMdd");
			string empty = string.Empty;
			string sQL = ("UPDATE etransEnvios SET D_fecha='" + text2 + "' WHERE id_envio=" + Conversions.ToString(id_envio)) ?? "";
			Mod_ConeccionBD.BD_Sentencia(sQL);
			int num = Conversions.ToInteger(Mod_logger.historialenter(Conversions.ToString(id_envio), "Fecha Entrega: " + Conversions.ToString(dateTime), estado, "Nueva Fecha Entrega: " + Conversions.ToString(dateTime2)));
		}
	}

	private void cambiarFechaRetiro(int id_envio)
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		string text = ("SELECT U_fecha, Estado FROM etransEnvios WHERE id_envio=" + Conversions.ToString(id_envio)) ?? "";
		DataTable dataTable = new DataTable("x");
		MySqlDataAdapter val = new MySqlDataAdapter(text, Mod_Sentencias.cnn);
		((DbDataAdapter)(object)val).Fill(dataTable);
		DateTime t = Conversions.ToDate(Strings.Format(DateAndTime.Today, "dd/MM/yyyy"));
		string estado = Conversions.ToString(dataTable.Rows[0]["Estado"]);
		DateTime dateTime = Conversions.ToDate(dataTable.Rows[0]["U_fecha"]);
		if (DateTime.Compare(dateTime, t) == 0)
		{
			DateTime dateTime2 = Conversions.ToDate(Mod_calendario.proxima_fecha(dateTime));
			string text2 = Strings.Format(dateTime2, "yyyyMMdd");
			string empty = string.Empty;
			string sQL = ("UPDATE etransEnvios SET U_fecha='" + text2 + "' WHERE id_envio=" + Conversions.ToString(id_envio)) ?? "";
			Mod_ConeccionBD.BD_Sentencia(sQL);
			int num = Conversions.ToInteger(Mod_logger.historialenter(Conversions.ToString(id_envio), "Fecha Retiro: " + Conversions.ToString(dateTime), estado, "Nueva Fecha Retiro: " + Conversions.ToString(dateTime2)));
		}
	}

	private object NovedadPositiva(string cliente, int subcuenta)
	{
		string result = "ENTREGADO";
		if (Operators.CompareString(cliente, "DABRA SOCIEDAD ANONIMA", TextCompare: true) == 0)
		{
			if ((double)subcuenta == Conversions.ToDouble("01"))
			{
				result = "RECOLECTADO";
			}
			else if ((double)subcuenta == Conversions.ToDouble("02"))
			{
				result = "RECOLECTADO";
			}
			else if ((double)subcuenta == Conversions.ToDouble("10"))
			{
				result = "ENTREGADO";
				Mod_ecommerce.CambiarEstados(Conversions.ToInteger(Label17.Text), 5);
			}
			else
			{
				result = "ENTREGADO";
			}
		}
		else if (Operators.CompareString(cliente, "TRANS GON S.R.L.", TextCompare: true) == 0)
		{
			result = (((double)subcuenta == Conversions.ToDouble("01")) ? "RECOLECTADO" : (((double)subcuenta != Conversions.ToDouble("02")) ? "ENTREGADO" : "RECOLECTADO"));
		}
		else if (Operators.CompareString(cliente, "LANNOT S.A", TextCompare: true) == 0)
		{
			result = (((double)subcuenta != Conversions.ToDouble("01")) ? "ENTREGADO" : "RECOLECTADO");
		}
		return result;
	}

	private object NovedadNegativa(string cliente, int subcuenta)
	{
		string result = "NO ENTREGADO";
		if (Operators.CompareString(cliente, "DABRA SOCIEDAD ANONIMA", TextCompare: true) == 0)
		{
			if ((double)subcuenta == Conversions.ToDouble("01"))
			{
				result = "NO RECOLECTADO";
			}
			else if ((double)subcuenta == Conversions.ToDouble("02"))
			{
				result = "NO RECOLECTADO";
			}
			else if ((double)subcuenta == Conversions.ToDouble("10"))
			{
				result = "NO ENTREGADO";
				Mod_ecommerce.CambiarEstados(Conversions.ToInteger(Label17.Text), 5);
			}
			else
			{
				result = "NO ENTREGADO";
			}
		}
		else if (Operators.CompareString(cliente, "TRANS GON S.R.L.", TextCompare: true) == 0)
		{
			result = (((double)subcuenta == Conversions.ToDouble("01")) ? "NO RECOLECTADO" : (((double)subcuenta != Conversions.ToDouble("02")) ? "NO ENTREGADO" : "NO RECOLECTADO"));
		}
		else if (Operators.CompareString(cliente, "LANNOT S.A", TextCompare: true) == 0)
		{
			result = (((double)subcuenta != Conversions.ToDouble("01")) ? "NO ENTREGADO" : "NO RECOLECTADO");
		}
		return result;
	}
}
