using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Hermes.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Hermes;

[DesignerGenerated]
public class V_Tareas : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ListView1")]
	private ListView _ListView1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button4")]
	private Button _Button4;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button9")]
	private Button _Button9;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button8")]
	private Button _Button8;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button7")]
	private Button _Button7;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button6")]
	private Button _Button6;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button5")]
	private Button _Button5;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button12")]
	private Button _Button12;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button14")]
	private Button _Button14;

	[field: AccessedThroughProperty("GroupBox1")]
	internal virtual GroupBox GroupBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Button3")]
	internal virtual Button Button3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Button1")]
	internal virtual Button Button1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Button2")]
	internal virtual Button Button2
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
			ColumnClickEventHandler value2 = ListView1_ColumnClick;
			EventHandler value3 = ListView1_SelectedIndexChanged;
			EventHandler value4 = ListView1_DoubleClick;
			ListView listView = _ListView1;
			if (listView != null)
			{
				listView.ColumnClick -= value2;
				listView.SelectedIndexChanged -= value3;
				listView.DoubleClick -= value4;
			}
			_ListView1 = value;
			listView = _ListView1;
			if (listView != null)
			{
				listView.ColumnClick += value2;
				listView.SelectedIndexChanged += value3;
				listView.DoubleClick += value4;
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

	[field: AccessedThroughProperty("DateTimePicker1")]
	internal virtual DateTimePicker DateTimePicker1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("GroupBox3")]
	internal virtual GroupBox GroupBox3
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

	[field: AccessedThroughProperty("GroupBox4")]
	internal virtual GroupBox GroupBox4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Button9
	{
		[CompilerGenerated]
		get
		{
			return _Button9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button9_Click;
			Button button = _Button9;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button9 = value;
			button = _Button9;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button8
	{
		[CompilerGenerated]
		get
		{
			return _Button8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button8_Click;
			Button button = _Button8;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button8 = value;
			button = _Button8;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button7
	{
		[CompilerGenerated]
		get
		{
			return _Button7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button7_Click;
			Button button = _Button7;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button7 = value;
			button = _Button7;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button6
	{
		[CompilerGenerated]
		get
		{
			return _Button6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button6_Click;
			Button button = _Button6;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button6 = value;
			button = _Button6;
			if (button != null)
			{
				button.Click += value2;
			}
		}
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

	[field: AccessedThroughProperty("Button11")]
	internal virtual Button Button11
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Button10")]
	internal virtual Button Button10
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

	[field: AccessedThroughProperty("Label18")]
	internal virtual Label Label18
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label20")]
	internal virtual Label Label20
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

	[field: AccessedThroughProperty("Label21")]
	internal virtual Label Label21
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Button12
	{
		[CompilerGenerated]
		get
		{
			return _Button12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button12_Click;
			Button button = _Button12;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button12 = value;
			button = _Button12;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Button13")]
	internal virtual Button Button13
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Button14
	{
		[CompilerGenerated]
		get
		{
			return _Button14;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button14_Click;
			Button button = _Button14;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button14 = value;
			button = _Button14;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	public V_Tareas()
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
		this.Button13 = new System.Windows.Forms.Button();
		this.Button12 = new System.Windows.Forms.Button();
		this.Button11 = new System.Windows.Forms.Button();
		this.Button10 = new System.Windows.Forms.Button();
		this.Button3 = new System.Windows.Forms.Button();
		this.Button1 = new System.Windows.Forms.Button();
		this.Button2 = new System.Windows.Forms.Button();
		this.GroupBox2 = new System.Windows.Forms.GroupBox();
		this.Label21 = new System.Windows.Forms.Label();
		this.Label12 = new System.Windows.Forms.Label();
		this.Label11 = new System.Windows.Forms.Label();
		this.ListView1 = new System.Windows.Forms.ListView();
		this.Button4 = new System.Windows.Forms.Button();
		this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
		this.GroupBox3 = new System.Windows.Forms.GroupBox();
		this.Button9 = new System.Windows.Forms.Button();
		this.Button8 = new System.Windows.Forms.Button();
		this.Button7 = new System.Windows.Forms.Button();
		this.Button6 = new System.Windows.Forms.Button();
		this.Button5 = new System.Windows.Forms.Button();
		this.Label10 = new System.Windows.Forms.Label();
		this.Label9 = new System.Windows.Forms.Label();
		this.Label8 = new System.Windows.Forms.Label();
		this.Label7 = new System.Windows.Forms.Label();
		this.Label6 = new System.Windows.Forms.Label();
		this.Label5 = new System.Windows.Forms.Label();
		this.Label4 = new System.Windows.Forms.Label();
		this.Label3 = new System.Windows.Forms.Label();
		this.Label2 = new System.Windows.Forms.Label();
		this.Label1 = new System.Windows.Forms.Label();
		this.GroupBox4 = new System.Windows.Forms.GroupBox();
		this.Label20 = new System.Windows.Forms.Label();
		this.Label19 = new System.Windows.Forms.Label();
		this.Label18 = new System.Windows.Forms.Label();
		this.Label17 = new System.Windows.Forms.Label();
		this.Label16 = new System.Windows.Forms.Label();
		this.Label15 = new System.Windows.Forms.Label();
		this.Label14 = new System.Windows.Forms.Label();
		this.Label13 = new System.Windows.Forms.Label();
		this.Button14 = new System.Windows.Forms.Button();
		this.GroupBox1.SuspendLayout();
		this.GroupBox2.SuspendLayout();
		this.GroupBox3.SuspendLayout();
		this.GroupBox4.SuspendLayout();
		base.SuspendLayout();
		this.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.GroupBox1.Controls.Add(this.Button14);
		this.GroupBox1.Controls.Add(this.Button13);
		this.GroupBox1.Controls.Add(this.Button12);
		this.GroupBox1.Controls.Add(this.Button11);
		this.GroupBox1.Controls.Add(this.Button10);
		this.GroupBox1.Controls.Add(this.Button3);
		this.GroupBox1.Controls.Add(this.Button1);
		this.GroupBox1.Controls.Add(this.Button2);
		this.GroupBox1.Location = new System.Drawing.Point(12, 12);
		this.GroupBox1.Name = "GroupBox1";
		this.GroupBox1.Size = new System.Drawing.Size(87, 479);
		this.GroupBox1.TabIndex = 0;
		this.GroupBox1.TabStop = false;
		this.GroupBox1.Text = "Acciones:";
		this.Button13.Location = new System.Drawing.Point(6, 204);
		this.Button13.Name = "Button13";
		this.Button13.Size = new System.Drawing.Size(75, 23);
		this.Button13.TabIndex = 6;
		this.Button13.Text = "Filtros";
		this.Button13.UseVisualStyleBackColor = true;
		this.Button12.Location = new System.Drawing.Point(6, 175);
		this.Button12.Name = "Button12";
		this.Button12.Size = new System.Drawing.Size(75, 23);
		this.Button12.TabIndex = 6;
		this.Button12.Text = "Informacion";
		this.Button12.UseVisualStyleBackColor = true;
		this.Button11.Location = new System.Drawing.Point(6, 146);
		this.Button11.Name = "Button11";
		this.Button11.Size = new System.Drawing.Size(75, 23);
		this.Button11.TabIndex = 5;
		this.Button11.Text = "Devolver";
		this.Button11.UseVisualStyleBackColor = true;
		this.Button10.Location = new System.Drawing.Point(6, 114);
		this.Button10.Name = "Button10";
		this.Button10.Size = new System.Drawing.Size(75, 23);
		this.Button10.TabIndex = 5;
		this.Button10.Text = "Cancelar";
		this.Button10.UseVisualStyleBackColor = true;
		this.Button3.Location = new System.Drawing.Point(6, 84);
		this.Button3.Name = "Button3";
		this.Button3.Size = new System.Drawing.Size(75, 23);
		this.Button3.TabIndex = 1;
		this.Button3.Text = "Imprimir";
		this.Button3.UseVisualStyleBackColor = true;
		this.Button1.Location = new System.Drawing.Point(6, 26);
		this.Button1.Name = "Button1";
		this.Button1.Size = new System.Drawing.Size(75, 23);
		this.Button1.TabIndex = 0;
		this.Button1.Text = "Buscar";
		this.Button1.UseVisualStyleBackColor = true;
		this.Button2.Location = new System.Drawing.Point(6, 55);
		this.Button2.Name = "Button2";
		this.Button2.Size = new System.Drawing.Size(75, 23);
		this.Button2.TabIndex = 0;
		this.Button2.Text = "Editar";
		this.Button2.UseVisualStyleBackColor = true;
		this.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.GroupBox2.Controls.Add(this.Label21);
		this.GroupBox2.Controls.Add(this.Label12);
		this.GroupBox2.Controls.Add(this.Label11);
		this.GroupBox2.Controls.Add(this.ListView1);
		this.GroupBox2.Controls.Add(this.Button4);
		this.GroupBox2.Controls.Add(this.DateTimePicker1);
		this.GroupBox2.Location = new System.Drawing.Point(105, 12);
		this.GroupBox2.Name = "GroupBox2";
		this.GroupBox2.Size = new System.Drawing.Size(823, 479);
		this.GroupBox2.TabIndex = 1;
		this.GroupBox2.TabStop = false;
		this.GroupBox2.Text = "Lista:";
		this.Label21.AutoSize = true;
		this.Label21.Location = new System.Drawing.Point(263, 30);
		this.Label21.Name = "Label21";
		this.Label21.Size = new System.Drawing.Size(72, 13);
		this.Label21.TabIndex = 5;
		this.Label21.Text = "Estas Viendo:";
		this.Label12.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.Label12.AutoSize = true;
		this.Label12.Location = new System.Drawing.Point(737, 31);
		this.Label12.Name = "Label12";
		this.Label12.Size = new System.Drawing.Size(13, 13);
		this.Label12.TabIndex = 4;
		this.Label12.Text = "0";
		this.Label11.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.Label11.AutoSize = true;
		this.Label11.Location = new System.Drawing.Point(607, 30);
		this.Label11.Name = "Label11";
		this.Label11.Size = new System.Drawing.Size(114, 13);
		this.Label11.TabIndex = 3;
		this.Label11.Text = "Transacciones totales:";
		this.ListView1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.ListView1.Location = new System.Drawing.Point(6, 55);
		this.ListView1.Name = "ListView1";
		this.ListView1.Size = new System.Drawing.Size(811, 418);
		this.ListView1.TabIndex = 2;
		this.ListView1.UseCompatibleStateImageBehavior = false;
		this.Button4.Location = new System.Drawing.Point(114, 25);
		this.Button4.Name = "Button4";
		this.Button4.Size = new System.Drawing.Size(75, 23);
		this.Button4.TabIndex = 1;
		this.Button4.Text = "Cargar";
		this.Button4.UseVisualStyleBackColor = true;
		this.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
		this.DateTimePicker1.Location = new System.Drawing.Point(6, 26);
		this.DateTimePicker1.Name = "DateTimePicker1";
		this.DateTimePicker1.Size = new System.Drawing.Size(102, 20);
		this.DateTimePicker1.TabIndex = 0;
		this.GroupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.GroupBox3.Controls.Add(this.Button9);
		this.GroupBox3.Controls.Add(this.Button8);
		this.GroupBox3.Controls.Add(this.Button7);
		this.GroupBox3.Controls.Add(this.Button6);
		this.GroupBox3.Controls.Add(this.Button5);
		this.GroupBox3.Controls.Add(this.Label10);
		this.GroupBox3.Controls.Add(this.Label9);
		this.GroupBox3.Controls.Add(this.Label8);
		this.GroupBox3.Controls.Add(this.Label7);
		this.GroupBox3.Controls.Add(this.Label6);
		this.GroupBox3.Controls.Add(this.Label5);
		this.GroupBox3.Controls.Add(this.Label4);
		this.GroupBox3.Controls.Add(this.Label3);
		this.GroupBox3.Controls.Add(this.Label2);
		this.GroupBox3.Controls.Add(this.Label1);
		this.GroupBox3.Location = new System.Drawing.Point(934, 12);
		this.GroupBox3.Name = "GroupBox3";
		this.GroupBox3.Size = new System.Drawing.Size(275, 203);
		this.GroupBox3.TabIndex = 2;
		this.GroupBox3.TabStop = false;
		this.GroupBox3.Text = "Transacciones:";
		this.Button9.Location = new System.Drawing.Point(213, 151);
		this.Button9.Name = "Button9";
		this.Button9.Size = new System.Drawing.Size(53, 23);
		this.Button9.TabIndex = 14;
		this.Button9.Text = "Ver";
		this.Button9.UseVisualStyleBackColor = true;
		this.Button8.Location = new System.Drawing.Point(213, 119);
		this.Button8.Name = "Button8";
		this.Button8.Size = new System.Drawing.Size(53, 23);
		this.Button8.TabIndex = 13;
		this.Button8.Text = "Ver";
		this.Button8.UseVisualStyleBackColor = true;
		this.Button7.Location = new System.Drawing.Point(213, 89);
		this.Button7.Name = "Button7";
		this.Button7.Size = new System.Drawing.Size(53, 23);
		this.Button7.TabIndex = 12;
		this.Button7.Text = "Ver";
		this.Button7.UseVisualStyleBackColor = true;
		this.Button6.Location = new System.Drawing.Point(213, 60);
		this.Button6.Name = "Button6";
		this.Button6.Size = new System.Drawing.Size(53, 23);
		this.Button6.TabIndex = 11;
		this.Button6.Text = "Ver";
		this.Button6.UseVisualStyleBackColor = true;
		this.Button5.Location = new System.Drawing.Point(213, 31);
		this.Button5.Name = "Button5";
		this.Button5.Size = new System.Drawing.Size(53, 23);
		this.Button5.TabIndex = 10;
		this.Button5.Text = "Ver";
		this.Button5.UseVisualStyleBackColor = true;
		this.Label10.AutoSize = true;
		this.Label10.Location = new System.Drawing.Point(91, 156);
		this.Label10.Name = "Label10";
		this.Label10.Size = new System.Drawing.Size(13, 13);
		this.Label10.TabIndex = 9;
		this.Label10.Text = "0";
		this.Label9.AutoSize = true;
		this.Label9.Location = new System.Drawing.Point(91, 124);
		this.Label9.Name = "Label9";
		this.Label9.Size = new System.Drawing.Size(13, 13);
		this.Label9.TabIndex = 8;
		this.Label9.Text = "0";
		this.Label8.AutoSize = true;
		this.Label8.Location = new System.Drawing.Point(91, 94);
		this.Label8.Name = "Label8";
		this.Label8.Size = new System.Drawing.Size(13, 13);
		this.Label8.TabIndex = 7;
		this.Label8.Text = "0";
		this.Label7.AutoSize = true;
		this.Label7.Location = new System.Drawing.Point(91, 65);
		this.Label7.Name = "Label7";
		this.Label7.Size = new System.Drawing.Size(13, 13);
		this.Label7.TabIndex = 6;
		this.Label7.Text = "0";
		this.Label6.AutoSize = true;
		this.Label6.Location = new System.Drawing.Point(91, 36);
		this.Label6.Name = "Label6";
		this.Label6.Size = new System.Drawing.Size(13, 13);
		this.Label6.TabIndex = 5;
		this.Label6.Text = "0";
		this.Label5.AutoSize = true;
		this.Label5.Location = new System.Drawing.Point(17, 156);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(68, 13);
		this.Label5.TabIndex = 4;
		this.Label5.Text = "Entregas V3:";
		this.Label4.AutoSize = true;
		this.Label4.Location = new System.Drawing.Point(17, 124);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(68, 13);
		this.Label4.TabIndex = 3;
		this.Label4.Text = "Entregas V2:";
		this.Label3.AutoSize = true;
		this.Label3.Location = new System.Drawing.Point(17, 94);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(68, 13);
		this.Label3.TabIndex = 2;
		this.Label3.Text = "Entregas V1:";
		this.Label2.AutoSize = true;
		this.Label2.Location = new System.Drawing.Point(17, 65);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(59, 13);
		this.Label2.TabIndex = 1;
		this.Label2.Text = "Retiros V2:";
		this.Label1.AutoSize = true;
		this.Label1.Location = new System.Drawing.Point(17, 36);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(59, 13);
		this.Label1.TabIndex = 0;
		this.Label1.Text = "Retiros V1:";
		this.GroupBox4.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		this.GroupBox4.Controls.Add(this.Label20);
		this.GroupBox4.Controls.Add(this.Label19);
		this.GroupBox4.Controls.Add(this.Label18);
		this.GroupBox4.Controls.Add(this.Label17);
		this.GroupBox4.Controls.Add(this.Label16);
		this.GroupBox4.Controls.Add(this.Label15);
		this.GroupBox4.Controls.Add(this.Label14);
		this.GroupBox4.Controls.Add(this.Label13);
		this.GroupBox4.Location = new System.Drawing.Point(934, 221);
		this.GroupBox4.Name = "GroupBox4";
		this.GroupBox4.Size = new System.Drawing.Size(275, 270);
		this.GroupBox4.TabIndex = 3;
		this.GroupBox4.TabStop = false;
		this.GroupBox4.Text = "Envio:";
		this.Label20.AutoSize = true;
		this.Label20.Location = new System.Drawing.Point(91, 116);
		this.Label20.Name = "Label20";
		this.Label20.Size = new System.Drawing.Size(13, 13);
		this.Label20.TabIndex = 7;
		this.Label20.Text = "0";
		this.Label19.AutoSize = true;
		this.Label19.Location = new System.Drawing.Point(91, 88);
		this.Label19.Name = "Label19";
		this.Label19.Size = new System.Drawing.Size(13, 13);
		this.Label19.TabIndex = 6;
		this.Label19.Text = "0";
		this.Label18.AutoSize = true;
		this.Label18.Location = new System.Drawing.Point(91, 62);
		this.Label18.Name = "Label18";
		this.Label18.Size = new System.Drawing.Size(13, 13);
		this.Label18.TabIndex = 5;
		this.Label18.Text = "0";
		this.Label17.AutoSize = true;
		this.Label17.Location = new System.Drawing.Point(91, 39);
		this.Label17.Name = "Label17";
		this.Label17.Size = new System.Drawing.Size(13, 13);
		this.Label17.TabIndex = 4;
		this.Label17.Text = "0";
		this.Label16.AutoSize = true;
		this.Label16.Location = new System.Drawing.Point(17, 116);
		this.Label16.Name = "Label16";
		this.Label16.Size = new System.Drawing.Size(43, 13);
		this.Label16.TabIndex = 3;
		this.Label16.Text = "Estado:";
		this.Label15.AutoSize = true;
		this.Label15.Location = new System.Drawing.Point(17, 88);
		this.Label15.Name = "Label15";
		this.Label15.Size = new System.Drawing.Size(66, 13);
		this.Label15.TabIndex = 2;
		this.Label15.Text = "Destinatario:";
		this.Label14.AutoSize = true;
		this.Label14.Location = new System.Drawing.Point(17, 62);
		this.Label14.Name = "Label14";
		this.Label14.Size = new System.Drawing.Size(42, 13);
		this.Label14.TabIndex = 1;
		this.Label14.Text = "Cliente:";
		this.Label13.AutoSize = true;
		this.Label13.Location = new System.Drawing.Point(17, 39);
		this.Label13.Name = "Label13";
		this.Label13.Size = new System.Drawing.Size(52, 13);
		this.Label13.TabIndex = 0;
		this.Label13.Text = "N° Envio:";
		this.Button14.Location = new System.Drawing.Point(6, 233);
		this.Button14.Name = "Button14";
		this.Button14.Size = new System.Drawing.Size(75, 23);
		this.Button14.TabIndex = 7;
		this.Button14.Text = "StandBy";
		this.Button14.UseVisualStyleBackColor = true;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(1221, 503);
		base.Controls.Add(this.GroupBox4);
		base.Controls.Add(this.GroupBox3);
		base.Controls.Add(this.GroupBox2);
		base.Controls.Add(this.GroupBox1);
		base.Name = "V_Tareas";
		this.Text = "Monitor de Envios ";
		this.GroupBox1.ResumeLayout(false);
		this.GroupBox2.ResumeLayout(false);
		this.GroupBox2.PerformLayout();
		this.GroupBox3.ResumeLayout(false);
		this.GroupBox3.PerformLayout();
		this.GroupBox4.ResumeLayout(false);
		this.GroupBox4.PerformLayout();
		base.ResumeLayout(false);
	}

	private void Button4_Click(object sender, EventArgs e)
	{
		Label21.Text = "Estas Viendo: GENERAL";
		string text = Strings.Format(DateTimePicker1.Value, "yyyyMMdd");
		ListView1.Clear();
		string sql = ("Select id_envio, Estado, Cliente, Destinatario, D_cp, D_localidad, Bultos, numero_interno, U_fecha,U_ventana, D_fecha, D_ventana FROM etransenvios WHERE U_fecha=" + text + " OR D_fecha=" + text) ?? "";
		Mod_Sentencias.cargar_lv_etrans(ListView1, sql, Label12);
		string sql2 = "SELECT id_envio FROM etransenvios WHERE U_fecha=" + text + " AND U_ventana=1";
		Mod_Sentencias.contar_items(sql2, Label6);
		string sql3 = "SELECT id_envio FROM etransenvios WHERE U_fecha=" + text + " AND U_ventana=2";
		Mod_Sentencias.contar_items(sql3, Label7);
		string sql4 = "SELECT id_envio FROM etransenvios WHERE D_fecha=" + text + " AND D_ventana=1";
		Mod_Sentencias.contar_items(sql4, Label8);
		string sql5 = "SELECT id_envio FROM etransenvios WHERE D_fecha=" + text + " AND D_ventana=2";
		Mod_Sentencias.contar_items(sql5, Label9);
		string sql6 = "SELECT id_envio FROM etransenvios WHERE D_fecha=" + text + " AND D_ventana=3";
		Mod_Sentencias.contar_items(sql6, Label10);
	}

	private void ListView1_ColumnClick(object sender, ColumnClickEventArgs e)
	{
		Mod_Ordenaclumnas.ordenar_columnas(ListView1, RuntimeHelpers.GetObjectValue(sender), e);
	}

	private void Button5_Click(object sender, EventArgs e)
	{
		Label21.Text = "Estas Viendo: Retiros V1";
		string text = Strings.Format(DateTimePicker1.Value, "yyyyMMdd");
		ListView1.Clear();
		string sql = "Select id_envio, Estado, Cliente, Destinatario, U_cp, U_localidad, Bultos, numero_interno, U_fecha,U_ventana, D_fecha, D_ventana FROM etransenvios WHERE U_fecha=" + text + " AND U_ventana=1";
		Mod_Sentencias.cargar_lv_etrans(ListView1, sql, Label12);
	}

	private void Button6_Click(object sender, EventArgs e)
	{
		Label21.Text = "Estas Viendo: Retiros V2";
		string text = Strings.Format(DateTimePicker1.Value, "yyyyMMdd");
		ListView1.Clear();
		string sql = "Select id_envio, Estado, Cliente, Destinatario, U_cp, U_localidad, Bultos, numero_interno, U_fecha,U_ventana, D_fecha, D_ventana FROM etransenvios WHERE U_fecha=" + text + " AND U_ventana=2";
		Mod_Sentencias.cargar_lv_etrans(ListView1, sql, Label12);
	}

	private void Button7_Click(object sender, EventArgs e)
	{
		Label21.Text = "Estas Viendo: Entregas V1";
		string text = Strings.Format(DateTimePicker1.Value, "yyyyMMdd");
		ListView1.Clear();
		string sql = "Select id_envio, Estado, Cliente, Destinatario, D_cp, D_localidad, Bultos, numero_interno, U_fecha,U_ventana, D_fecha, D_ventana FROM etransenvios WHERE D_fecha=" + text + " AND D_ventana=1";
		Mod_Sentencias.cargar_lv_etrans(ListView1, sql, Label12);
	}

	private void Button8_Click(object sender, EventArgs e)
	{
		Label21.Text = "Estas Viendo: Entregas V2";
		string text = Strings.Format(DateTimePicker1.Value, "yyyyMMdd");
		ListView1.Clear();
		string sql = "Select id_envio, Estado, Cliente, Destinatario, D_cp, D_localidad, Bultos, numero_interno, U_fecha,U_ventana, D_fecha, D_ventana FROM etransenvios WHERE D_fecha=" + text + " AND D_ventana=2";
		Mod_Sentencias.cargar_lv_etrans(ListView1, sql, Label12);
	}

	private void Button9_Click(object sender, EventArgs e)
	{
		Label21.Text = "Estas Viendo: Entregas V3";
		string text = Strings.Format(DateTimePicker1.Value, "yyyyMMdd");
		ListView1.Clear();
		string sql = "Select id_envio, Estado, Cliente, Destinatario, D_cp, D_localidad, Bultos, numero_interno, U_fecha,U_ventana, D_fecha, D_ventana FROM etransenvios WHERE D_fecha=" + text + " AND D_ventana=3";
		Mod_Sentencias.cargar_lv_etrans(ListView1, sql, Label12);
	}

	private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (ListView1.SelectedItems.Count > 0)
		{
			int index = ListView1.SelectedIndices[0];
			Label17.Text = ListView1.Items[index].Text;
			Label20.Text = ListView1.Items[index].SubItems[1].Text;
			Label18.Text = ListView1.Items[index].SubItems[2].Text;
			Label19.Text = ListView1.Items[index].SubItems[3].Text;
		}
	}

	private void ListView1_DoubleClick(object sender, EventArgs e)
	{
		if (ListView1.SelectedItems.Count > 0)
		{
			int num = ListView1.SelectedIndices[0];
			E_Envio e_Envio = MyProject.Forms.E_Envio;
			e_Envio.Label22.Text = Label17.Text;
			e_Envio = null;
		}
		MyProject.Forms.E_Envio.Show();
	}

	private void Button12_Click(object sender, EventArgs e)
	{
		E_Envio e_Envio = MyProject.Forms.E_Envio;
		e_Envio.Label22.Text = Label17.Text;
		e_Envio = null;
		MyProject.Forms.E_Envio.Show();
	}

	private void Button14_Click(object sender, EventArgs e)
	{
		Label21.Text = "Estas Viendo: ENVIOS A REPROGRAMAR";
		string text = Strings.Format(DateTimePicker1.Value, "yyyyMMdd");
		ListView1.Clear();
		string sql = "Select id_envio, Estado, Cliente, Destinatario, D_cp, D_localidad, Bultos, numero_interno, U_fecha,U_ventana, D_fecha, D_ventana FROM etransenvios WHERE Estado='A REPROGRAMAR'";
		Mod_Sentencias.cargar_lv_etrans(ListView1, sql, Label12);
	}
}
