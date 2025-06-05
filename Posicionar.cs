using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using Hermes.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace Hermes;

[DesignerGenerated]
public class Posicionar : Form
{
	private enum ServiceResponse
	{
		Unknown,
		Ok,
		InvalidRequest,
		ZeroResults,
		OverQueryLimit,
		RequestDenied
	}

	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ListView1")]
	private ListView _ListView1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ComboBox1")]
	private ComboBox _ComboBox1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button4")]
	private Button _Button4;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button3")]
	private Button _Button3;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	private string fecha1;

	[field: AccessedThroughProperty("Panel1")]
	internal virtual Panel Panel1
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

	[field: AccessedThroughProperty("GroupBox1")]
	internal virtual GroupBox GroupBox1
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

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
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

	[field: AccessedThroughProperty("Panel2")]
	internal virtual Panel Panel2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("GMapControl1")]
	internal virtual GMapControl GMapControl1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel3")]
	internal virtual Panel Panel3
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

	[field: AccessedThroughProperty("ComboBox2")]
	internal virtual ComboBox ComboBox2
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

	[field: AccessedThroughProperty("Label4")]
	internal virtual Label Label4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Destino")]
	internal virtual ColumnHeader Destino
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Domicilio")]
	internal virtual ColumnHeader Domicilio
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Localidad")]
	internal virtual ColumnHeader Localidad
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Eventual")]
	internal virtual ColumnHeader Eventual
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Zona")]
	internal virtual ColumnHeader Zona
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Comprobante")]
	internal virtual ColumnHeader Comprobante
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

	public Posicionar()
	{
		base.Load += Posicionar_Load;
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
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Expected O, but got Unknown
		this.Panel1 = new System.Windows.Forms.Panel();
		this.ListView1 = new System.Windows.Forms.ListView();
		this.Destino = new System.Windows.Forms.ColumnHeader();
		this.Domicilio = new System.Windows.Forms.ColumnHeader();
		this.Localidad = new System.Windows.Forms.ColumnHeader();
		this.Eventual = new System.Windows.Forms.ColumnHeader();
		this.Zona = new System.Windows.Forms.ColumnHeader();
		this.Comprobante = new System.Windows.Forms.ColumnHeader();
		this.Label2 = new System.Windows.Forms.Label();
		this.Label1 = new System.Windows.Forms.Label();
		this.GroupBox1 = new System.Windows.Forms.GroupBox();
		this.TextBox1 = new System.Windows.Forms.TextBox();
		this.Label3 = new System.Windows.Forms.Label();
		this.ComboBox2 = new System.Windows.Forms.ComboBox();
		this.ComboBox1 = new System.Windows.Forms.ComboBox();
		this.GroupBox2 = new System.Windows.Forms.GroupBox();
		this.Label15 = new System.Windows.Forms.Label();
		this.Label4 = new System.Windows.Forms.Label();
		this.Label14 = new System.Windows.Forms.Label();
		this.Label13 = new System.Windows.Forms.Label();
		this.Label12 = new System.Windows.Forms.Label();
		this.Label11 = new System.Windows.Forms.Label();
		this.Label10 = new System.Windows.Forms.Label();
		this.TextBox5 = new System.Windows.Forms.TextBox();
		this.TextBox4 = new System.Windows.Forms.TextBox();
		this.TextBox3 = new System.Windows.Forms.TextBox();
		this.TextBox2 = new System.Windows.Forms.TextBox();
		this.Label9 = new System.Windows.Forms.Label();
		this.Label8 = new System.Windows.Forms.Label();
		this.Label7 = new System.Windows.Forms.Label();
		this.Label6 = new System.Windows.Forms.Label();
		this.Label5 = new System.Windows.Forms.Label();
		this.Panel2 = new System.Windows.Forms.Panel();
		this.GMapControl1 = new GMapControl();
		this.Panel3 = new System.Windows.Forms.Panel();
		this.Button4 = new System.Windows.Forms.Button();
		this.Button3 = new System.Windows.Forms.Button();
		this.Button2 = new System.Windows.Forms.Button();
		this.Button1 = new System.Windows.Forms.Button();
		this.Label16 = new System.Windows.Forms.Label();
		this.Panel1.SuspendLayout();
		this.GroupBox1.SuspendLayout();
		this.GroupBox2.SuspendLayout();
		this.Panel2.SuspendLayout();
		this.Panel3.SuspendLayout();
		base.SuspendLayout();
		this.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.Panel1.Controls.Add(this.ListView1);
		this.Panel1.Controls.Add(this.Label2);
		this.Panel1.Controls.Add(this.Label1);
		this.Panel1.Location = new System.Drawing.Point(13, 8);
		this.Panel1.Name = "Panel1";
		this.Panel1.Size = new System.Drawing.Size(377, 212);
		this.Panel1.TabIndex = 0;
		this.ListView1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.ListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[6] { this.Destino, this.Domicilio, this.Localidad, this.Eventual, this.Zona, this.Comprobante });
		this.ListView1.Location = new System.Drawing.Point(6, 17);
		this.ListView1.Name = "ListView1";
		this.ListView1.Size = new System.Drawing.Size(361, 192);
		this.ListView1.TabIndex = 2;
		this.ListView1.UseCompatibleStateImageBehavior = false;
		this.ListView1.View = System.Windows.Forms.View.Details;
		this.Destino.Text = "Destino";
		this.Domicilio.Text = "Domicilio";
		this.Localidad.Text = "Localidad";
		this.Eventual.Text = "Eventual";
		this.Zona.Text = "Zona";
		this.Comprobante.Text = "Comprobante";
		this.Label2.AutoSize = true;
		this.Label2.Location = new System.Drawing.Point(48, 1);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(13, 13);
		this.Label2.TabIndex = 1;
		this.Label2.Text = "0";
		this.Label1.AutoSize = true;
		this.Label1.Location = new System.Drawing.Point(3, 1);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(35, 13);
		this.Label1.TabIndex = 0;
		this.Label1.Text = "Items:";
		this.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.GroupBox1.Controls.Add(this.Label16);
		this.GroupBox1.Controls.Add(this.TextBox1);
		this.GroupBox1.Controls.Add(this.Label3);
		this.GroupBox1.Controls.Add(this.ComboBox2);
		this.GroupBox1.Controls.Add(this.Label9);
		this.GroupBox1.Location = new System.Drawing.Point(12, 226);
		this.GroupBox1.Name = "GroupBox1";
		this.GroupBox1.Size = new System.Drawing.Size(377, 103);
		this.GroupBox1.TabIndex = 1;
		this.GroupBox1.TabStop = false;
		this.GroupBox1.Text = "Direccion:";
		this.TextBox1.Location = new System.Drawing.Point(6, 72);
		this.TextBox1.Name = "TextBox1";
		this.TextBox1.Size = new System.Drawing.Size(365, 20);
		this.TextBox1.TabIndex = 2;
		this.Label3.AutoSize = true;
		this.Label3.Location = new System.Drawing.Point(3, 16);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(128, 13);
		this.Label3.TabIndex = 0;
		this.Label3.Text = "Direcciónes encontradas:";
		this.ComboBox2.FormattingEnabled = true;
		this.ComboBox2.Location = new System.Drawing.Point(6, 32);
		this.ComboBox2.Name = "ComboBox2";
		this.ComboBox2.Size = new System.Drawing.Size(365, 21);
		this.ComboBox2.TabIndex = 0;
		this.ComboBox1.FormattingEnabled = true;
		this.ComboBox1.Location = new System.Drawing.Point(3, 5);
		this.ComboBox1.Name = "ComboBox1";
		this.ComboBox1.Size = new System.Drawing.Size(121, 21);
		this.ComboBox1.TabIndex = 1;
		this.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.GroupBox2.Controls.Add(this.Label15);
		this.GroupBox2.Controls.Add(this.Label4);
		this.GroupBox2.Controls.Add(this.Label14);
		this.GroupBox2.Controls.Add(this.Label13);
		this.GroupBox2.Controls.Add(this.Label12);
		this.GroupBox2.Controls.Add(this.Label11);
		this.GroupBox2.Controls.Add(this.Label10);
		this.GroupBox2.Controls.Add(this.TextBox5);
		this.GroupBox2.Controls.Add(this.TextBox4);
		this.GroupBox2.Controls.Add(this.TextBox3);
		this.GroupBox2.Controls.Add(this.TextBox2);
		this.GroupBox2.Controls.Add(this.Label8);
		this.GroupBox2.Controls.Add(this.Label7);
		this.GroupBox2.Controls.Add(this.Label6);
		this.GroupBox2.Controls.Add(this.Label5);
		this.GroupBox2.Location = new System.Drawing.Point(13, 335);
		this.GroupBox2.Name = "GroupBox2";
		this.GroupBox2.Size = new System.Drawing.Size(377, 150);
		this.GroupBox2.TabIndex = 2;
		this.GroupBox2.TabStop = false;
		this.GroupBox2.Text = "Detalles";
		this.Label15.AutoSize = true;
		this.Label15.Location = new System.Drawing.Point(207, 63);
		this.Label15.Name = "Label15";
		this.Label15.Size = new System.Drawing.Size(51, 13);
		this.Label15.TabIndex = 15;
		this.Label15.Text = "Longitud:";
		this.Label4.AutoSize = true;
		this.Label4.Location = new System.Drawing.Point(207, 32);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(42, 13);
		this.Label4.TabIndex = 14;
		this.Label4.Text = "Latitud:";
		this.Label14.AutoSize = true;
		this.Label14.Location = new System.Drawing.Point(207, 94);
		this.Label14.Name = "Label14";
		this.Label14.Size = new System.Drawing.Size(70, 13);
		this.Label14.TabIndex = 13;
		this.Label14.Text = "Comprobante";
		this.Label14.Visible = false;
		this.Label13.AutoSize = true;
		this.Label13.Location = new System.Drawing.Point(322, 16);
		this.Label13.Name = "Label13";
		this.Label13.Size = new System.Drawing.Size(45, 13);
		this.Label13.TabIndex = 12;
		this.Label13.Text = "Label13";
		this.Label13.Visible = false;
		this.Label12.AutoSize = true;
		this.Label12.Location = new System.Drawing.Point(280, 63);
		this.Label12.Name = "Label12";
		this.Label12.Size = new System.Drawing.Size(13, 13);
		this.Label12.TabIndex = 11;
		this.Label12.Text = "0";
		this.Label11.AutoSize = true;
		this.Label11.Location = new System.Drawing.Point(278, 36);
		this.Label11.Name = "Label11";
		this.Label11.Size = new System.Drawing.Size(13, 13);
		this.Label11.TabIndex = 10;
		this.Label11.Text = "0";
		this.Label10.AutoSize = true;
		this.Label10.Location = new System.Drawing.Point(283, 94);
		this.Label10.Name = "Label10";
		this.Label10.Size = new System.Drawing.Size(45, 13);
		this.Label10.TabIndex = 9;
		this.Label10.Text = "Label10";
		this.Label10.Visible = false;
		this.TextBox5.Location = new System.Drawing.Point(61, 120);
		this.TextBox5.Name = "TextBox5";
		this.TextBox5.Size = new System.Drawing.Size(117, 20);
		this.TextBox5.TabIndex = 8;
		this.TextBox5.Visible = false;
		this.TextBox4.Location = new System.Drawing.Point(61, 91);
		this.TextBox4.Name = "TextBox4";
		this.TextBox4.Size = new System.Drawing.Size(117, 20);
		this.TextBox4.TabIndex = 7;
		this.TextBox3.Location = new System.Drawing.Point(61, 60);
		this.TextBox3.Name = "TextBox3";
		this.TextBox3.Size = new System.Drawing.Size(117, 20);
		this.TextBox3.TabIndex = 6;
		this.TextBox2.Location = new System.Drawing.Point(61, 29);
		this.TextBox2.Name = "TextBox2";
		this.TextBox2.Size = new System.Drawing.Size(117, 20);
		this.TextBox2.TabIndex = 5;
		this.Label9.AutoSize = true;
		this.Label9.Location = new System.Drawing.Point(138, 16);
		this.Label9.Name = "Label9";
		this.Label9.Size = new System.Drawing.Size(13, 13);
		this.Label9.TabIndex = 4;
		this.Label9.Text = "0";
		this.Label8.AutoSize = true;
		this.Label8.Location = new System.Drawing.Point(3, 123);
		this.Label8.Name = "Label8";
		this.Label8.Size = new System.Drawing.Size(39, 13);
		this.Label8.TabIndex = 3;
		this.Label8.Text = "Label8";
		this.Label8.Visible = false;
		this.Label7.AutoSize = true;
		this.Label7.Location = new System.Drawing.Point(3, 94);
		this.Label7.Name = "Label7";
		this.Label7.Size = new System.Drawing.Size(56, 13);
		this.Label7.TabIndex = 2;
		this.Label7.Text = "Localidad:";
		this.Label6.AutoSize = true;
		this.Label6.Location = new System.Drawing.Point(3, 63);
		this.Label6.Name = "Label6";
		this.Label6.Size = new System.Drawing.Size(42, 13);
		this.Label6.TabIndex = 1;
		this.Label6.Text = "Cliente:";
		this.Label5.AutoSize = true;
		this.Label5.Location = new System.Drawing.Point(3, 32);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(52, 13);
		this.Label5.TabIndex = 0;
		this.Label5.Text = "Eventual:";
		this.Panel2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.Panel2.Controls.Add((System.Windows.Forms.Control)(object)this.GMapControl1);
		this.Panel2.Location = new System.Drawing.Point(396, 8);
		this.Panel2.Name = "Panel2";
		this.Panel2.Size = new System.Drawing.Size(477, 441);
		this.Panel2.TabIndex = 3;
		((System.Windows.Forms.Control)(object)this.GMapControl1).Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.GMapControl1.Bearing = 0f;
		this.GMapControl1.CanDragMap = true;
		this.GMapControl1.GrayScaleMode = false;
		this.GMapControl1.LevelsKeepInMemmory = 5;
		((System.Windows.Forms.Control)(object)this.GMapControl1).Location = new System.Drawing.Point(3, 3);
		this.GMapControl1.MarkersEnabled = true;
		this.GMapControl1.MaxZoom = 2;
		this.GMapControl1.MinZoom = 2;
		this.GMapControl1.MouseWheelZoomType = (MouseWheelZoomType)0;
		((System.Windows.Forms.Control)(object)this.GMapControl1).Name = "GMapControl1";
		this.GMapControl1.NegativeMode = false;
		this.GMapControl1.PolygonsEnabled = true;
		this.GMapControl1.RetryLoadTile = 0;
		this.GMapControl1.RoutesEnabled = true;
		this.GMapControl1.ShowTileGridLines = false;
		((System.Windows.Forms.Control)(object)this.GMapControl1).Size = new System.Drawing.Size(471, 435);
		((System.Windows.Forms.Control)(object)this.GMapControl1).TabIndex = 0;
		this.GMapControl1.Zoom = 0.0;
		this.Panel3.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		this.Panel3.Controls.Add(this.Button4);
		this.Panel3.Controls.Add(this.Button3);
		this.Panel3.Controls.Add(this.ComboBox1);
		this.Panel3.Controls.Add(this.Button2);
		this.Panel3.Controls.Add(this.Button1);
		this.Panel3.Location = new System.Drawing.Point(396, 455);
		this.Panel3.Name = "Panel3";
		this.Panel3.Size = new System.Drawing.Size(477, 30);
		this.Panel3.TabIndex = 4;
		this.Button4.Location = new System.Drawing.Point(373, 3);
		this.Button4.Name = "Button4";
		this.Button4.Size = new System.Drawing.Size(75, 23);
		this.Button4.TabIndex = 4;
		this.Button4.Text = "Salir";
		this.Button4.UseVisualStyleBackColor = true;
		this.Button3.Location = new System.Drawing.Point(292, 3);
		this.Button3.Name = "Button3";
		this.Button3.Size = new System.Drawing.Size(75, 23);
		this.Button3.TabIndex = 3;
		this.Button3.Text = "Eventual 0";
		this.Button3.UseVisualStyleBackColor = true;
		this.Button2.Location = new System.Drawing.Point(211, 3);
		this.Button2.Name = "Button2";
		this.Button2.Size = new System.Drawing.Size(75, 23);
		this.Button2.TabIndex = 2;
		this.Button2.Text = "Guardar";
		this.Button2.UseVisualStyleBackColor = true;
		this.Button1.Location = new System.Drawing.Point(130, 3);
		this.Button1.Name = "Button1";
		this.Button1.Size = new System.Drawing.Size(75, 23);
		this.Button1.TabIndex = 1;
		this.Button1.Text = "Buscar";
		this.Button1.UseVisualStyleBackColor = true;
		this.Label16.AutoSize = true;
		this.Label16.Location = new System.Drawing.Point(6, 56);
		this.Label16.Name = "Label16";
		this.Label16.Size = new System.Drawing.Size(43, 13);
		this.Label16.TabIndex = 5;
		this.Label16.Text = "Buscar:";
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(885, 497);
		base.Controls.Add(this.Panel3);
		base.Controls.Add(this.Panel2);
		base.Controls.Add(this.GroupBox2);
		base.Controls.Add(this.GroupBox1);
		base.Controls.Add(this.Panel1);
		base.Name = "Posicionar";
		this.Text = "Posicionar";
		this.Panel1.ResumeLayout(false);
		this.Panel1.PerformLayout();
		this.GroupBox1.ResumeLayout(false);
		this.GroupBox1.PerformLayout();
		this.GroupBox2.ResumeLayout(false);
		this.GroupBox2.PerformLayout();
		this.Panel2.ResumeLayout(false);
		this.Panel3.ResumeLayout(false);
		base.ResumeLayout(false);
	}

	private void Posicionar_Load(object sender, EventArgs e)
	{
		if (ListView1.Items.Count == 0)
		{
			string sql = ("SELECT Destino,Domicilio,Localidad,Eventual,Zona,Comprobante FROM Planchada Where zona=0 AND Fecha=" + fecha1) ?? "";
			Mod_Sentencias.cargar_datos_lv(ListView1, sql, Label2);
			Mod_Sentencias.cargar_zonas_combo(ComboBox1);
			if (ListView1.Items.Count > 0)
			{
				mapa_ver();
			}
		}
		else
		{
			Mod_Sentencias.cargar_zonas_combo(ComboBox1);
			if (ListView1.Items.Count > 0)
			{
				mapa_ver();
			}
		}
	}

	private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
	{
		Selected_item();
		coordenadas();
	}

	private void Selected_item()
	{
		ComboBox1.SelectedIndex = -1;
		if (ListView1.SelectedItems.Count > 0)
		{
			TextBox2.Clear();
			ComboBox2.Text = "";
			ComboBox2.Items.Clear();
			int index = ListView1.SelectedIndices[0];
			TextBox2.Text = ListView1.Items[index].SubItems[3].Text;
			TextBox3.Text = ListView1.Items[index].Text;
			TextBox1.Text = ListView1.Items[index].SubItems[1].Text;
			TextBox4.Text = ListView1.Items[index].SubItems[2].Text;
			Label13.Text = ListView1.Items[index].SubItems[4].Text;
			try
			{
				Label14.Text = ListView1.Items[index].SubItems[5].Text;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				Label14.Text = "";
				ProjectData.ClearProjectError();
			}
		}
		ListView1.Refresh();
	}

	private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
	{
		Label13.Text = Conversions.ToString(checked(ComboBox1.SelectedIndex + 1));
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		string text = TextBox1.Text;
		string text2 = TextBox4.Text;
		string address = text + " " + text2 + " Buenos Aires Argentina";
		List<string> list = new List<string>();
		list = (List<string>)Mod_Posicionador.get_coord(address);
		if (list.Count > 0)
		{
			string text3 = list[0].ToString();
			string text4 = list[1].ToString();
			string text5 = list[2].ToString();
			TextBox1.Text = text5;
			Label11.Text = text3.Replace(".", ",");
			Label12.Text = text4.Replace(".", ",");
			mapa_ver();
		}
		else
		{
			Interaction.MsgBox("faltan datos");
		}
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		if (ListView1.SelectedItems.Count > 0)
		{
			if (Conversions.ToDouble(TextBox2.Text) > 0.0)
			{
				string sQL = "UPDATE Eventuales SET Zona=" + Label13.Text + " ,Latitud= '" + Strings.Replace(Label11.Text, ",", ".", 1, -1, CompareMethod.Text) + "',Longitud='" + Strings.Replace(Label12.Text, ",", ".", 1, -1, CompareMethod.Text) + "' WHERE Eventual=" + TextBox2.Text + " ";
				Mod_ConeccionBD.BD_Sentencia(sQL);
				string sQL2 = ("UPDATE Planchada SET Zona=" + Label13.Text + ",Latitud= '" + Strings.Replace(Label11.Text, ",", ".", 1, -1, CompareMethod.Text) + "',Longitud='" + Strings.Replace(Label12.Text, ",", ".", 1, -1, CompareMethod.Text) + "' WHERE Eventual=" + TextBox2.Text + " AND Fecha=" + fecha1) ?? "";
				Mod_ConeccionBD.BD_Sentencia(sQL2);
				if (ListView1.SelectedItems.Count > 0)
				{
					int index = ListView1.SelectedIndices[0];
					ListView1.Items[index].Remove();
					ListView1.Refresh();
				}
				string sql = ("SELECT Destino,Domicilio,Localidad,Eventual,Zona,Comprobante FROM Planchada Where Zona=0 AND Fecha=" + fecha1) ?? "";
				Mod_Sentencias.cargar_datos_lv(ListView1, sql, Label2);
			}
			else
			{
				string sQL3 = ("UPDATE Planchada SET Zona=" + Label13.Text + ",Latitud= '" + Strings.Replace(Label11.Text, ",", ".", 1, -1, CompareMethod.Text) + "',Longitud= '" + Strings.Replace(Label12.Text, ",", ".", 1, -1, CompareMethod.Text) + "' WHERE Domicilio = '" + ListView1.SelectedItems[0].SubItems[1].Text + "' AND Fecha=" + fecha1) ?? "";
				Mod_ConeccionBD.BD_Sentencia(sQL3);
				if (ListView1.SelectedItems.Count > 0)
				{
					int index2 = ListView1.SelectedIndices[0];
					ListView1.Items[index2].Remove();
					ListView1.Refresh();
				}
				string sql2 = ("SELECT Destino,Domicilio,Localidad,Eventual,Zona,Comprobante FROM Planchada Where Zona=0 AND Fecha=" + fecha1) ?? "";
				Mod_Sentencias.cargar_datos_lv(ListView1, sql2, Label2);
			}
			Label9.Text = Conversions.ToString(0);
			Label11.Text = Conversions.ToString(0);
			Label12.Text = Conversions.ToString(0);
			Label13.Text = Conversions.ToString(0);
			ComboBox1.Text = "";
			TextBox1.Text = "";
			TextBox2.Text = "";
			TextBox3.Text = "";
			TextBox4.Text = "";
		}
		else
		{
			Interaction.MsgBox("No se a seleccionado ninguno", MsgBoxStyle.Critical, "Datos incompletos");
		}
	}

	private void Button4_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void mapa_ver()
	{
		//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cd: Expected O, but got Unknown
		//IL_02d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02df: Expected O, but got Unknown
		//IL_031f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0326: Expected O, but got Unknown
		//IL_033f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0344: Unknown result type (might be due to invalid IL or missing references)
		//IL_034b: Expected O, but got Unknown
		//IL_036a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Expected O, but got Unknown
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected O, but got Unknown
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Expected O, but got Unknown
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected O, but got Unknown
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		PointLatLng position;
		if (Conversions.ToDouble(Label11.Text) != 0.0)
		{
			((Collection<GMapOverlay>)(object)GMapControl1.Overlays).Clear();
			GMapControl1.Manager.Mode = (AccessMode)1;
			GMapControl1.MapProvider = (GMapProvider)(object)GMapProviders.OpenStreetMap;
			GMapControl1.Position = new PointLatLng(Conversions.ToDouble(Label11.Text), Conversions.ToDouble(Label12.Text));
			GMapControl1.MinZoom = 1;
			GMapControl1.MaxZoom = 19;
			GMapControl1.Zoom = 13.0;
			((Control)(object)GMapControl1).Dock = DockStyle.Fill;
			GMapControl1.MarkersEnabled = true;
			GMapProvider.Language = (LanguageType)11;
			Cursor.Current = Cursors.WaitCursor;
			position = GMapControl1.Position;
			double lat = ((PointLatLng)(ref position)).Lat;
			position = GMapControl1.Position;
			PointLatLng val = default(PointLatLng);
			((PointLatLng)(ref val))._002Ector(lat, ((PointLatLng)(ref position)).Lng);
			GMapMarkerGoogleGreen item = new GMapMarkerGoogleGreen(val);
			GMapOverlay val2 = new GMapOverlay(GMapControl1, "current");
			((Collection<GMapMarker>)(object)val2.Markers).Add((GMapMarker)(object)item);
			((Collection<GMapOverlay>)(object)GMapControl1.Overlays).Add(val2);
			Cursor.Current = Cursors.Default;
			ResumeLayout(performLayout: true);
			GMapOverlay item2 = new GMapOverlay(GMapControl1, "objects");
			((Collection<GMapOverlay>)(object)GMapControl1.Overlays).Add(item2);
			GMapMarkerGoogleRed val3 = new GMapMarkerGoogleRed(GMapControl1.Position);
			((GMapMarker)val3).Size = new Size(0, 0);
			((GMapMarker)val3).ToolTipText = "Tu Ubicacion";
			((GMapMarker)val3).ToolTipMode = (MarkerTooltipMode)0;
			((Collection<GMapMarker>)(object)val2.Markers).Add((GMapMarker)(object)val3);
			GMapControl1.DragButton = MouseButtons.Left;
		}
		else
		{
			((Collection<GMapOverlay>)(object)GMapControl1.Overlays).Clear();
			GMapControl1.Manager.Mode = (AccessMode)1;
			GMapControl1.MapProvider = (GMapProvider)(object)GMapProviders.OpenStreetMap;
			GMapControl1.Position = new PointLatLng(Conversions.ToDouble("-34,600"), Conversions.ToDouble("-58,400"));
			GMapControl1.MinZoom = 1;
			GMapControl1.MaxZoom = 19;
			GMapControl1.Zoom = 13.0;
			((Control)(object)GMapControl1).Dock = DockStyle.Fill;
			GMapControl1.MarkersEnabled = true;
			GMapProvider.Language = (LanguageType)11;
			Cursor.Current = Cursors.WaitCursor;
			position = GMapControl1.Position;
			double lat2 = ((PointLatLng)(ref position)).Lat;
			position = GMapControl1.Position;
			PointLatLng val4 = default(PointLatLng);
			((PointLatLng)(ref val4))._002Ector(lat2, ((PointLatLng)(ref position)).Lng);
			GMapMarkerGoogleGreen item3 = new GMapMarkerGoogleGreen(val4);
			GMapOverlay val5 = new GMapOverlay(GMapControl1, "current");
			((Collection<GMapMarker>)(object)val5.Markers).Add((GMapMarker)(object)item3);
			((Collection<GMapOverlay>)(object)GMapControl1.Overlays).Add(val5);
			Cursor.Current = Cursors.Default;
			ResumeLayout(performLayout: true);
			GMapOverlay item4 = new GMapOverlay(GMapControl1, "objects");
			((Collection<GMapOverlay>)(object)GMapControl1.Overlays).Add(item4);
			GMapMarkerGoogleRed val6 = new GMapMarkerGoogleRed(GMapControl1.Position);
			((GMapMarker)val6).Size = new Size(0, 0);
			((GMapMarker)val6).ToolTipText = "Sin Coordenadas";
			((GMapMarker)val6).ToolTipMode = (MarkerTooltipMode)2;
			((Collection<GMapMarker>)(object)val5.Markers).Add((GMapMarker)(object)val6);
			GMapControl1.DragButton = MouseButtons.Left;
		}
	}

	private void coordenadas()
	{
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Expected O, but got Unknown
		int try0001_dispatch = -1;
		int num = default(int);
		int num2 = default(int);
		int num3 = default(int);
		int num5 = default(int);
		int num6 = default(int);
		string text = default(string);
		string text2 = default(string);
		string text3 = default(string);
		string text4 = default(string);
		string text5 = default(string);
		string empty = default(string);
		string text6 = default(string);
		string address = default(string);
		List<string> list = default(List<string>);
		string text7 = default(string);
		DataTable dataTable = default(DataTable);
		MySqlDataAdapter val = default(MySqlDataAdapter);
		int num7 = default(int);
		string[] array = default(string[]);
		string[] array2 = default(string[]);
		int length = default(int);
		int num8 = default(int);
		int num9 = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				checked
				{
					string text8;
					switch (try0001_dispatch)
					{
					default:
						num = 1;
						ComboBox2.Items.Clear();
						goto IL_0015;
					case 1584:
						{
							num2 = num;
							switch ((num3 <= -2) ? 1 : num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0001;
							}
							int num4 = unchecked(num2 + 1);
							num2 = 0;
							switch (num4)
							{
							case 1:
								break;
							case 2:
								goto IL_0015;
							case 3:
								goto IL_001e;
							case 4:
								goto IL_0027;
							case 5:
								goto IL_0030;
							case 6:
								goto IL_0039;
							case 7:
								goto IL_0057;
							case 8:
								goto IL_006b;
							case 9:
								goto IL_0074;
							case 10:
								goto IL_007e;
							case 11:
								goto IL_0088;
							case 12:
								goto IL_00c0;
							case 14:
								goto IL_00ce;
							case 13:
							case 15:
							case 16:
								goto IL_00f5;
							case 17:
								goto IL_011b;
							case 18:
								goto IL_0122;
							case 19:
								goto IL_013a;
							case 20:
								goto IL_0144;
							case 21:
								goto IL_0155;
							case 22:
								goto IL_016b;
							case 23:
								goto IL_017d;
							case 24:
								goto IL_018f;
							case 25:
								goto IL_01a1;
							case 26:
								goto IL_01b2;
							case 27:
								goto IL_01d2;
							case 28:
								goto IL_01f2;
							case 29:
								goto IL_01fc;
							case 30:
								goto IL_020b;
							case 31:
								goto IL_021c;
							case 32:
								goto IL_0229;
							case 33:
								goto IL_023e;
							case 34:
								goto IL_024e;
							case 35:
								goto IL_0269;
							case 36:
								goto IL_028b;
							case 38:
								goto IL_02eb;
							case 39:
								goto IL_0317;
							case 37:
							case 40:
							case 41:
								goto IL_0347;
							case 42:
								goto IL_0359;
							case 43:
								goto IL_03c8;
							case 44:
								goto IL_0437;
							case 45:
								goto IL_0443;
							case 46:
								goto IL_0451;
							case 47:
								goto IL_0468;
							case 48:
								goto IL_0477;
							case 49:
								goto IL_0488;
							case 50:
							case 51:
								goto IL_0494;
							case 52:
								goto IL_04b6;
							case 53:
							case 54:
								goto IL_04e8;
							case 55:
								goto end_IL_0001_2;
							default:
								goto end_IL_0001;
							case 56:
							case 57:
							case 58:
							case 59:
								goto end_IL_0001_3;
							}
							goto default;
						}
						IL_0494:
						num = 51;
						if (Operators.CompareString(ComboBox2.Text, "", TextCompare: true) == 0)
						{
							goto IL_04b6;
						}
						goto IL_04e8;
						IL_04b6:
						num = 52;
						TextBox1.Text = ListView1.Items[num5].SubItems[1].Text;
						goto IL_04e8;
						IL_0347:
						num = 41;
						num6++;
						goto IL_0350;
						IL_04e8:
						num = 54;
						if (ComboBox2.Items.Count <= 0)
						{
							goto end_IL_0001_3;
						}
						break;
						IL_0015:
						num = 2;
						text = string.Empty;
						goto IL_001e;
						IL_001e:
						num = 3;
						text2 = string.Empty;
						goto IL_0027;
						IL_0027:
						num = 4;
						text3 = string.Empty;
						goto IL_0030;
						IL_0030:
						num = 5;
						text4 = string.Empty;
						goto IL_0039;
						IL_0039:
						num = 6;
						if (ListView1.SelectedItems.Count <= 0)
						{
							goto end_IL_0001_3;
						}
						goto IL_0057;
						IL_0057:
						num = 7;
						num5 = ListView1.SelectedIndices[0];
						goto IL_006b;
						IL_006b:
						ProjectData.ClearProjectError();
						num3 = -2;
						goto IL_0074;
						IL_0074:
						num = 9;
						text5 = string.Empty;
						goto IL_007e;
						IL_007e:
						num = 10;
						empty = string.Empty;
						goto IL_0088;
						IL_0088:
						num = 11;
						if (Operators.CompareString(ListView1.Items[num5].SubItems[2].Text, "CIUDAD AUTONOMA DE BS.AS", TextCompare: true) == 0)
						{
							goto IL_00c0;
						}
						goto IL_00ce;
						IL_00c0:
						num = 12;
						text5 = "ciudad autonoma de buenos aires";
						goto IL_00f5;
						IL_00ce:
						num = 14;
						text5 = ListView1.Items[num5].SubItems[2].Text;
						goto IL_00f5;
						IL_00f5:
						num = 16;
						empty = ListView1.Items[num5].SubItems[1].Text;
						goto IL_011b;
						IL_011b:
						num = 17;
						text6 = text5;
						goto IL_0122;
						IL_0122:
						num = 18;
						address = empty + " " + text6 + " Buenos Aires Argentina";
						goto IL_013a;
						IL_013a:
						num = 19;
						list = new List<string>();
						goto IL_0144;
						IL_0144:
						num = 20;
						list = (List<string>)Mod_Posicionador.get_coord(address);
						goto IL_0155;
						IL_0155:
						num = 21;
						if (list.Count > 0)
						{
							goto IL_016b;
						}
						goto IL_0494;
						IL_016b:
						num = 22;
						text = list[0].ToString();
						goto IL_017d;
						IL_017d:
						num = 23;
						text2 = list[1].ToString();
						goto IL_018f;
						IL_018f:
						num = 24;
						text4 = list[2].ToString();
						goto IL_01a1;
						IL_01a1:
						num = 25;
						TextBox1.Text = text4;
						goto IL_01b2;
						IL_01b2:
						num = 26;
						Label11.Text = text.Replace(".", ",");
						goto IL_01d2;
						IL_01d2:
						num = 27;
						Label12.Text = text2.Replace(".", ",");
						goto IL_01f2;
						IL_01f2:
						num = 28;
						text7 = "SELECT DISTINCT Zona FROM dibujos";
						goto IL_01fc;
						IL_01fc:
						num = 29;
						dataTable = new DataTable("x");
						goto IL_020b;
						IL_020b:
						num = 30;
						val = new MySqlDataAdapter(text7, Mod_Sentencias.cnn);
						goto IL_021c;
						IL_021c:
						num = 31;
						((DbDataAdapter)(object)val).Fill(dataTable);
						goto IL_0229;
						IL_0229:
						num = 32;
						Label13.Text = Conversions.ToString(0);
						goto IL_023e;
						IL_023e:
						num = 33;
						ComboBox1.SelectedIndex = -1;
						goto IL_024e;
						IL_024e:
						num = 34;
						num7 = dataTable.Rows.Count - 1;
						num6 = 0;
						goto IL_0350;
						IL_0350:
						if (num6 <= num7)
						{
							goto IL_0269;
						}
						goto IL_0359;
						IL_0359:
						num = 42;
						array = new string[12]
						{
							"á", "é", "í", "ó", "ú", "ñ", "Á", "É", "Í", "Ó",
							"Ú", "Ñ"
						};
						goto IL_03c8;
						IL_03c8:
						num = 43;
						array2 = new string[12]
						{
							"a", "e", "i", "o", "u", "n", "A", "E", "I", "O",
							"U", "N"
						};
						goto IL_0437;
						IL_0437:
						num = 44;
						length = text4.Length;
						goto IL_0443;
						IL_0443:
						num = 45;
						num8 = length - 1;
						num9 = 0;
						goto IL_0471;
						IL_0471:
						if (num9 <= num8)
						{
							goto IL_0451;
						}
						goto IL_0477;
						IL_0477:
						num = 48;
						ComboBox2.Text = text3;
						goto IL_0488;
						IL_0488:
						num = 49;
						mapa_ver();
						goto IL_0494;
						IL_0451:
						num = 46;
						text3 = Strings.Replace(text4, array[num5], array2[num5], 1, -1, CompareMethod.Text);
						goto IL_0468;
						IL_0468:
						num = 47;
						num9++;
						goto IL_0471;
						IL_0269:
						num = 35;
						text8 = dataTable.Rows[num6]["zona"].ToString();
						goto IL_028b;
						IL_028b:
						num = 36;
						if (!Operators.ConditionalCompareObjectEqual(Mod_Calculos.puntoenpoligono3(Conversions.ToInteger(dataTable.Rows[num6]["zona"].ToString()), Conversions.ToDouble(Label11.Text), Conversions.ToDouble(Label12.Text)), false, TextCompare: true))
						{
							goto IL_02eb;
						}
						goto IL_0347;
						IL_02eb:
						num = 38;
						Label13.Text = dataTable.Rows[num6]["zona"].ToString();
						goto IL_0317;
						IL_0317:
						num = 39;
						ComboBox1.SelectedIndex = (int)Math.Round(Conversions.ToDouble(Label13.Text) - 1.0);
						goto IL_0347;
						end_IL_0001_2:
						break;
					}
					num = 55;
					Label9.Text = Conversions.ToString(ComboBox2.Items.Count);
					break;
				}
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 1584;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void Button3_Click(object sender, EventArgs e)
	{
		if (ListView1.Items.Count == 0)
		{
			string sql = "SELECT Cliente,Domicilio,Localidad,Eventual,Zona FROM Eventuales Where zona=0";
			Mod_Sentencias.cargar_datos_lv(ListView1, sql, Label2);
			Mod_Sentencias.cargar_zonas_combo(ComboBox1);
			if (ListView1.Items.Count > 0)
			{
				mapa_ver();
			}
		}
		else
		{
			Mod_Sentencias.cargar_zonas_combo(ComboBox1);
			if (ListView1.Items.Count > 0)
			{
				mapa_ver();
			}
		}
	}
}
