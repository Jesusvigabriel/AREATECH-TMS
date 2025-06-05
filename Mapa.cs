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
public class Mapa : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ComboBox1")]
	private ComboBox _ComboBox1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ListView1")]
	private ListView _ListView1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("CheckBox1")]
	private CheckBox _CheckBox1;

	private Color colormapa;

	private string fecha1;

	private string choferselec;

	[field: AccessedThroughProperty("GroupBox1")]
	internal virtual GroupBox GroupBox1
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

	[field: AccessedThroughProperty("ComboBox2")]
	internal virtual ComboBox ComboBox2
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

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
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
			ListView listView = _ListView1;
			if (listView != null)
			{
				listView.ColumnClick -= value2;
			}
			_ListView1 = value;
			listView = _ListView1;
			if (listView != null)
			{
				listView.ColumnClick += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Panel1")]
	internal virtual Panel Panel1
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

	[field: AccessedThroughProperty("Comprobante")]
	internal virtual ColumnHeader Comprobante
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

	[field: AccessedThroughProperty("Cliente")]
	internal virtual ColumnHeader Cliente
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

	[field: AccessedThroughProperty("TextBox1")]
	internal virtual TextBox TextBox1
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

	internal virtual CheckBox CheckBox1
	{
		[CompilerGenerated]
		get
		{
			return _CheckBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = CheckBox1_CheckedChanged;
			CheckBox checkBox = _CheckBox1;
			if (checkBox != null)
			{
				checkBox.CheckedChanged -= value2;
			}
			_CheckBox1 = value;
			checkBox = _CheckBox1;
			if (checkBox != null)
			{
				checkBox.CheckedChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Domilicio")]
	internal virtual ColumnHeader Domilicio
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public Mapa()
	{
		base.Load += Mapa_Load;
		fecha1 = Strings.Format(MyProject.Forms.Form1_Inicio.DateTimePicker1.Value, "yyyyMMdd");
		choferselec = Conversions.ToString(0);
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
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Expected O, but got Unknown
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hermes.Mapa));
		this.GroupBox1 = new System.Windows.Forms.GroupBox();
		this.CheckBox1 = new System.Windows.Forms.CheckBox();
		this.Button3 = new System.Windows.Forms.Button();
		this.TextBox1 = new System.Windows.Forms.TextBox();
		this.Label3 = new System.Windows.Forms.Label();
		this.Button2 = new System.Windows.Forms.Button();
		this.ComboBox2 = new System.Windows.Forms.ComboBox();
		this.Label2 = new System.Windows.Forms.Label();
		this.Button1 = new System.Windows.Forms.Button();
		this.ComboBox1 = new System.Windows.Forms.ComboBox();
		this.Label1 = new System.Windows.Forms.Label();
		this.GroupBox2 = new System.Windows.Forms.GroupBox();
		this.Label5 = new System.Windows.Forms.Label();
		this.Label4 = new System.Windows.Forms.Label();
		this.ListView1 = new System.Windows.Forms.ListView();
		this.Comprobante = new System.Windows.Forms.ColumnHeader();
		this.Destino = new System.Windows.Forms.ColumnHeader();
		this.Cliente = new System.Windows.Forms.ColumnHeader();
		this.Panel1 = new System.Windows.Forms.Panel();
		this.GMapControl1 = new GMapControl();
		this.Domilicio = new System.Windows.Forms.ColumnHeader();
		this.GroupBox1.SuspendLayout();
		this.GroupBox2.SuspendLayout();
		this.Panel1.SuspendLayout();
		base.SuspendLayout();
		this.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.GroupBox1.Controls.Add(this.CheckBox1);
		this.GroupBox1.Controls.Add(this.Button3);
		this.GroupBox1.Controls.Add(this.TextBox1);
		this.GroupBox1.Controls.Add(this.Label3);
		this.GroupBox1.Controls.Add(this.Button2);
		this.GroupBox1.Controls.Add(this.ComboBox2);
		this.GroupBox1.Controls.Add(this.Label2);
		this.GroupBox1.Controls.Add(this.Button1);
		this.GroupBox1.Controls.Add(this.ComboBox1);
		this.GroupBox1.Controls.Add(this.Label1);
		this.GroupBox1.Location = new System.Drawing.Point(12, 12);
		this.GroupBox1.Name = "GroupBox1";
		this.GroupBox1.Size = new System.Drawing.Size(867, 96);
		this.GroupBox1.TabIndex = 0;
		this.GroupBox1.TabStop = false;
		this.GroupBox1.Text = "Seleccion:";
		this.CheckBox1.AutoSize = true;
		this.CheckBox1.Location = new System.Drawing.Point(272, 60);
		this.CheckBox1.Name = "CheckBox1";
		this.CheckBox1.Size = new System.Drawing.Size(120, 17);
		this.CheckBox1.TabIndex = 9;
		this.CheckBox1.Text = "Ver Mapa de Zonas";
		this.CheckBox1.UseVisualStyleBackColor = true;
		this.Button3.Location = new System.Drawing.Point(786, 17);
		this.Button3.Name = "Button3";
		this.Button3.Size = new System.Drawing.Size(75, 23);
		this.Button3.TabIndex = 8;
		this.Button3.Text = "Buscar";
		this.Button3.UseVisualStyleBackColor = true;
		this.TextBox1.Location = new System.Drawing.Point(577, 19);
		this.TextBox1.Name = "TextBox1";
		this.TextBox1.Size = new System.Drawing.Size(203, 20);
		this.TextBox1.TabIndex = 7;
		this.Label3.AutoSize = true;
		this.Label3.Location = new System.Drawing.Point(528, 22);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(43, 13);
		this.Label3.TabIndex = 6;
		this.Label3.Text = "Buscar:";
		this.Button2.Location = new System.Drawing.Point(178, 56);
		this.Button2.Name = "Button2";
		this.Button2.Size = new System.Drawing.Size(75, 23);
		this.Button2.TabIndex = 5;
		this.Button2.Text = "Ver Zona";
		this.Button2.UseVisualStyleBackColor = true;
		this.ComboBox2.FormattingEnabled = true;
		this.ComboBox2.Location = new System.Drawing.Point(51, 58);
		this.ComboBox2.Name = "ComboBox2";
		this.ComboBox2.Size = new System.Drawing.Size(121, 21);
		this.ComboBox2.TabIndex = 4;
		this.Label2.AutoSize = true;
		this.Label2.Location = new System.Drawing.Point(6, 61);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(35, 13);
		this.Label2.TabIndex = 3;
		this.Label2.Text = "Zona:";
		this.Button1.Location = new System.Drawing.Point(178, 17);
		this.Button1.Name = "Button1";
		this.Button1.Size = new System.Drawing.Size(75, 23);
		this.Button1.TabIndex = 2;
		this.Button1.Text = "Ver Ruta";
		this.Button1.UseVisualStyleBackColor = true;
		this.ComboBox1.FormattingEnabled = true;
		this.ComboBox1.Location = new System.Drawing.Point(51, 19);
		this.ComboBox1.Name = "ComboBox1";
		this.ComboBox1.Size = new System.Drawing.Size(121, 21);
		this.ComboBox1.TabIndex = 1;
		this.Label1.AutoSize = true;
		this.Label1.Location = new System.Drawing.Point(6, 22);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(41, 13);
		this.Label1.TabIndex = 0;
		this.Label1.Text = "Chofer:";
		this.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		this.GroupBox2.Controls.Add(this.Label5);
		this.GroupBox2.Controls.Add(this.Label4);
		this.GroupBox2.Controls.Add(this.ListView1);
		this.GroupBox2.Location = new System.Drawing.Point(621, 114);
		this.GroupBox2.Name = "GroupBox2";
		this.GroupBox2.Size = new System.Drawing.Size(258, 352);
		this.GroupBox2.TabIndex = 1;
		this.GroupBox2.TabStop = false;
		this.GroupBox2.Text = "Comprobantes:";
		this.Label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		this.Label5.AutoSize = true;
		this.Label5.Location = new System.Drawing.Point(57, 333);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(13, 13);
		this.Label5.TabIndex = 2;
		this.Label5.Text = "0";
		this.Label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		this.Label4.AutoSize = true;
		this.Label4.Location = new System.Drawing.Point(6, 333);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(35, 13);
		this.Label4.TabIndex = 1;
		this.Label4.Text = "Items:";
		this.ListView1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.ListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[4] { this.Comprobante, this.Destino, this.Domilicio, this.Cliente });
		this.ListView1.FullRowSelect = true;
		this.ListView1.GridLines = true;
		this.ListView1.Location = new System.Drawing.Point(6, 19);
		this.ListView1.Name = "ListView1";
		this.ListView1.Size = new System.Drawing.Size(246, 299);
		this.ListView1.TabIndex = 0;
		this.ListView1.UseCompatibleStateImageBehavior = false;
		this.ListView1.View = System.Windows.Forms.View.Details;
		this.Comprobante.Text = "Comprobante";
		this.Comprobante.Width = 79;
		this.Destino.Text = "Destino";
		this.Destino.Width = 55;
		this.Cliente.Text = "Cliente";
		this.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.Panel1.Controls.Add((System.Windows.Forms.Control)(object)this.GMapControl1);
		this.Panel1.Location = new System.Drawing.Point(12, 114);
		this.Panel1.Name = "Panel1";
		this.Panel1.Size = new System.Drawing.Size(603, 352);
		this.Panel1.TabIndex = 2;
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
		((System.Windows.Forms.Control)(object)this.GMapControl1).Size = new System.Drawing.Size(597, 343);
		((System.Windows.Forms.Control)(object)this.GMapControl1).TabIndex = 0;
		this.GMapControl1.Zoom = 0.0;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(891, 478);
		base.Controls.Add(this.Panel1);
		base.Controls.Add(this.GroupBox2);
		base.Controls.Add(this.GroupBox1);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.Name = "Mapa";
		this.Text = "Mapa";
		this.GroupBox1.ResumeLayout(false);
		this.GroupBox1.PerformLayout();
		this.GroupBox2.ResumeLayout(false);
		this.GroupBox2.PerformLayout();
		this.Panel1.ResumeLayout(false);
		base.ResumeLayout(false);
	}

	private void Mapa_Load(object sender, EventArgs e)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected O, but got Unknown
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Expected O, but got Unknown
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Expected O, but got Unknown
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Expected O, but got Unknown
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Mod_Sentencias.cnn.Open();
			cargar_datos();
			cargar_datos1();
			GMapControl1.Manager.Mode = (AccessMode)1;
			GMapControl1.MapProvider = (GMapProvider)(object)GMapProviders.OpenStreetMap;
			GMapControl1.Position = new PointLatLng(Conversions.ToDouble("-34,8414045305668"), Conversions.ToDouble("-58,412783459045"));
			GMapControl1.MinZoom = 1;
			GMapControl1.MaxZoom = 19;
			GMapControl1.Zoom = 10.0;
			((Control)(object)GMapControl1).Dock = DockStyle.Fill;
			GMapControl1.MarkersEnabled = true;
			GMapProvider.Language = (LanguageType)11;
			Cursor.Current = Cursors.WaitCursor;
			PointLatLng position = GMapControl1.Position;
			double lat = ((PointLatLng)(ref position)).Lat;
			position = GMapControl1.Position;
			PointLatLng val = new PointLatLng(lat, ((PointLatLng)(ref position)).Lng);
			GMapMarkerGoogleGreen item = new GMapMarkerGoogleGreen(val);
			GMapOverlay val2 = new GMapOverlay(GMapControl1, "current");
			((Collection<GMapMarker>)(object)val2.Markers).Add((GMapMarker)(object)item);
			((Collection<GMapOverlay>)(object)GMapControl1.Overlays).Add(val2);
			Cursor.Current = Cursors.Default;
			ResumeLayout(performLayout: true);
			GMapOverlay item2 = new GMapOverlay(GMapControl1, "objects");
			((Collection<GMapOverlay>)(object)GMapControl1.Overlays).Add(item2);
			GMapMarkerGoogleGreen val3 = new GMapMarkerGoogleGreen(GMapControl1.Position);
			((GMapMarker)val3).Size = new Size(0, 0);
			((GMapMarker)val3).ToolTipText = "Area 54 S.A.";
			((GMapMarker)val3).ToolTipMode = (MarkerTooltipMode)2;
			((Collection<GMapMarker>)(object)val2.Markers).Add((GMapMarker)(object)val3);
			GMapControl1.DragButton = MouseButtons.Left;
			Mod_Sentencias.cnn.Close();
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

	private void cargar_datos()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		try
		{
			DataTable dataTable = new DataTable("x");
			string text = "SELECT DISTINCT (chofer) as numero, (SELECT Chofer FROM Flota WHERE numero=planchada.chofer) as chofer from planchada where fecha='" + fecha1 + "' and chofer>0 ORDER BY Chofer asc";
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
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox(ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void cargar_datos1()
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		try
		{
			DataTable dataTable = new DataTable("x");
			string text = "SELECT DISTINCT Zona FROM Planchada order by Zona asc";
			MySqlDataAdapter val = new MySqlDataAdapter(text, Mod_Sentencias.cnn);
			DataSet dataSet = new DataSet();
			((DbDataAdapter)(object)val).Fill(dataSet, "tabla");
			ComboBox2.Items.Clear();
			DataTable dataTable2 = dataSet.Tables["tabla"];
			foreach (DataRow row in dataTable2.Rows)
			{
				ComboBox2.Items.Add(RuntimeHelpers.GetObjectValue(row["Zona"]));
			}
			ComboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox(ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void ver_zona()
	{
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected O, but got Unknown
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected O, but got Unknown
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Expected O, but got Unknown
		checked
		{
			try
			{
				if (Operators.CompareString(ComboBox2.Text, "", TextCompare: true) == 0)
				{
					Interaction.MsgBox("Seleccione una zona");
				}
				else
				{
					((Collection<GMapOverlay>)(object)GMapControl1.Overlays).Clear();
					ListView1.Items.Clear();
					Mod_Sentencias.cnn.Open();
					DataTable dataTable = new DataTable("x");
					MySqlDataAdapter val = new MySqlDataAdapter();
					DataSet dataSet = new DataSet();
					int num = 0;
					string text = "SELECT Latitud, Longitud, Comprobante, Destino, Domicilio, Cliente FROM Planchada WHERE fecha='" + fecha1 + "' AND Zona=" + ComboBox2.Text + " order by eventual";
					MySqlDataAdapter val2 = new MySqlDataAdapter(text, Mod_Sentencias.cnn);
					((DbDataAdapter)(object)val2).Fill(dataTable);
					GMapControl1.Manager.Mode = (AccessMode)1;
					GMapControl1.MapProvider = (GMapProvider)(object)GMapProviders.OpenStreetMap;
					GMapControl1.MinZoom = 1;
					GMapControl1.MaxZoom = 19;
					GMapControl1.Zoom = 10.0;
					GMapControl1.MarkersEnabled = true;
					GMapProvider.Language = (LanguageType)11;
					Cursor.Current = Cursors.WaitCursor;
					PointLatLng position = GMapControl1.Position;
					double lat = ((PointLatLng)(ref position)).Lat;
					position = GMapControl1.Position;
					PointLatLng val3 = new PointLatLng(lat, ((PointLatLng)(ref position)).Lng);
					GMapOverlay item = new GMapOverlay(GMapControl1, "OverlayOne");
					if (dataTable.Rows.Count > 0)
					{
						int num2 = dataTable.Rows.Count - 1;
						for (int i = 0; i <= num2; i++)
						{
							if (!Operators.ConditionalCompareObjectEqual(dataTable.Rows[i]["Latitud"], 0, TextCompare: true))
							{
								double num3 = Conversions.ToDouble(dataTable.Rows[i]["latitud"]);
								double num4 = Conversions.ToDouble(dataTable.Rows[i]["longitud"]);
								ListViewItem listViewItem = new ListViewItem(dataTable.Rows[i]["Comprobante"].ToString());
								listViewItem.SubItems.Add(dataTable.Rows[i]["Destino"].ToString());
								listViewItem.SubItems.Add(dataTable.Rows[i]["Domicilio"].ToString());
								listViewItem.SubItems.Add(dataTable.Rows[i]["Cliente"].ToString());
								ListView1.Items.Add(listViewItem);
							}
						}
						((Collection<GMapOverlay>)(object)GMapControl1.Overlays).Add(item);
						Cursor.Current = Cursors.Default;
						ResumeLayout(performLayout: true);
						GMapControl1.DragButton = MouseButtons.Left;
					}
				}
				ListView listView = ListView1;
				int num5 = ListView1.Columns.Count - 1;
				for (int j = 0; j <= num5; j++)
				{
					listView.AutoResizeColumn(j, ColumnHeaderAutoResizeStyle.ColumnContent);
				}
				Label5.Text = Conversions.ToString(ListView1.Items.Count);
				listView = null;
				Mod_Sentencias.cnn.Close();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Mod_Sentencias.cnn.Close();
				Interaction.MsgBox(ex2.Message, MsgBoxStyle.Critical, "Error");
				ProjectData.ClearProjectError();
			}
		}
	}

	private void ver_ruta()
	{
		//IL_056c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0573: Expected O, but got Unknown
		//IL_05bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c2: Expected O, but got Unknown
		//IL_05d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0644: Unknown result type (might be due to invalid IL or missing references)
		//IL_0649: Unknown result type (might be due to invalid IL or missing references)
		//IL_0658: Unknown result type (might be due to invalid IL or missing references)
		//IL_065d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0666: Unknown result type (might be due to invalid IL or missing references)
		//IL_066b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0678: Unknown result type (might be due to invalid IL or missing references)
		//IL_067f: Expected O, but got Unknown
		//IL_068a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0691: Expected O, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected O, but got Unknown
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Expected O, but got Unknown
		//IL_0781: Unknown result type (might be due to invalid IL or missing references)
		//IL_0786: Unknown result type (might be due to invalid IL or missing references)
		//IL_078d: Expected O, but got Unknown
		//IL_0246: Unknown result type (might be due to invalid IL or missing references)
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Expected O, but got Unknown
		//IL_0877: Unknown result type (might be due to invalid IL or missing references)
		//IL_087c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0883: Expected O, but got Unknown
		//IL_0808: Unknown result type (might be due to invalid IL or missing references)
		//IL_080d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0814: Expected O, but got Unknown
		//IL_0338: Unknown result type (might be due to invalid IL or missing references)
		//IL_033d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0344: Expected O, but got Unknown
		//IL_02cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d7: Expected O, but got Unknown
		//IL_091d: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dc: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			try
			{
				PointLatLng position;
				if (Operators.CompareString(ComboBox1.Text, "", TextCompare: true) == 0)
				{
					ListView1.Items.Clear();
					((Collection<GMapOverlay>)(object)GMapControl1.Overlays).Clear();
					Mod_Sentencias.cnn.Open();
					DataTable dataTable = new DataTable("x");
					MySqlDataAdapter val = new MySqlDataAdapter();
					DataSet dataSet = new DataSet();
					int num = 0;
					string text = "SELECT Latitud, Longitud, Comprobante, Destino, Domicilio, Cliente, Estado FROM Planchada WHERE fecha='" + fecha1 + "' order by Cliente";
					MySqlDataAdapter val2 = new MySqlDataAdapter(text, Mod_Sentencias.cnn);
					((DbDataAdapter)(object)val2).Fill(dataTable);
					GMapControl1.Manager.Mode = (AccessMode)1;
					GMapControl1.MapProvider = (GMapProvider)(object)GMapProviders.OpenStreetMap;
					GMapControl1.MinZoom = 1;
					GMapControl1.MaxZoom = 19;
					GMapControl1.Zoom = 10.0;
					GMapControl1.MarkersEnabled = true;
					GMapProvider.Language = (LanguageType)11;
					Cursor.Current = Cursors.WaitCursor;
					position = GMapControl1.Position;
					double lat = ((PointLatLng)(ref position)).Lat;
					position = GMapControl1.Position;
					PointLatLng val3 = new PointLatLng(lat, ((PointLatLng)(ref position)).Lng);
					GMapOverlay val4 = new GMapOverlay(GMapControl1, "OverlayOne");
					GMapOverlay val5 = new GMapOverlay(GMapControl1, "Linea1");
					List<PointLatLng> list = new List<PointLatLng>();
					if (dataTable.Rows.Count > 0)
					{
						int num2 = dataTable.Rows.Count - 1;
						for (int i = 0; i <= num2; i++)
						{
							if (!Operators.ConditionalCompareObjectEqual(dataTable.Rows[i]["Latitud"], 0, TextCompare: true))
							{
								double num3 = Conversions.ToDouble(dataTable.Rows[i]["latitud"]);
								double num4 = Conversions.ToDouble(dataTable.Rows[i]["longitud"]);
								string left = Conversions.ToString(dataTable.Rows[i]["Estado"]);
								if ((Operators.CompareString(left, "ENTREGADO", TextCompare: true) == 0) | (Operators.CompareString(left, "RECOLECTADO", TextCompare: true) == 0))
								{
									GMapMarkerGoogleGreen val6 = new GMapMarkerGoogleGreen(new PointLatLng(num3, num4));
									((GMapMarker)val6).ToolTipText = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(dataTable.Rows[i]["comprobante"], " - "), dataTable.Rows[i]["Domicilio"]));
									((Collection<GMapMarker>)(object)val4.Markers).Add((GMapMarker)(object)val6);
								}
								else if (Operators.CompareString(left, "PARCIAL", TextCompare: true) == 0)
								{
									GMapMarkerGoogleGreen val7 = new GMapMarkerGoogleGreen(new PointLatLng(num3, num4));
									((GMapMarker)val7).ToolTipText = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(dataTable.Rows[i]["comprobante"], " - "), dataTable.Rows[i]["Domicilio"]));
									((Collection<GMapMarker>)(object)val4.Markers).Add((GMapMarker)(object)val7);
								}
								else
								{
									GMapMarkerGoogleRed val8 = new GMapMarkerGoogleRed(new PointLatLng(num3, num4));
									((GMapMarker)val8).ToolTipText = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(dataTable.Rows[i]["comprobante"], " - "), dataTable.Rows[i]["Domicilio"]));
									((Collection<GMapMarker>)(object)val4.Markers).Add((GMapMarker)(object)val8);
								}
								list.Add(new PointLatLng(Conversions.ToDouble((Conversions.ToString(num3) ?? "") ?? ""), Conversions.ToDouble((Conversions.ToString(num4) ?? "") ?? "")));
								ListViewItem listViewItem = new ListViewItem(dataTable.Rows[i]["Comprobante"].ToString());
								listViewItem.SubItems.Add(dataTable.Rows[i]["Destino"].ToString());
								listViewItem.SubItems.Add(dataTable.Rows[i]["Domicilio"].ToString());
								listViewItem.SubItems.Add(dataTable.Rows[i]["Cliente"].ToString());
								if ((Operators.CompareString(left, "ENTREGADO", TextCompare: true) == 0) | (Operators.CompareString(left, "RECOLECTADO", TextCompare: true) == 0))
								{
									ListView1.Items.Add(listViewItem).ForeColor = Color.Green;
								}
								else
								{
									ListView1.Items.Add(listViewItem);
								}
							}
						}
						((Collection<GMapOverlay>)(object)GMapControl1.Overlays).Add(val4);
						Cursor.Current = Cursors.Default;
						ResumeLayout(performLayout: true);
						GMapControl1.DragButton = MouseButtons.Left;
					}
				}
				else
				{
					ListView1.Items.Clear();
					((Collection<GMapOverlay>)(object)GMapControl1.Overlays).Clear();
					Mod_Sentencias.cnn.Open();
					DataTable dataTable2 = new DataTable("x");
					MySqlDataAdapter val9 = new MySqlDataAdapter();
					DataSet dataSet2 = new DataSet();
					int num5 = 0;
					string text2 = "SELECT Latitud, Longitud, Comprobante, Destino, Domicilio, Cliente, Estado FROM Planchada WHERE fecha='" + fecha1 + "' AND Chofer=" + choferselec + " order by Cliente";
					MySqlDataAdapter val10 = new MySqlDataAdapter(text2, Mod_Sentencias.cnn);
					((DbDataAdapter)(object)val10).Fill(dataTable2);
					GMapControl1.Manager.Mode = (AccessMode)1;
					GMapControl1.MapProvider = (GMapProvider)(object)GMapProviders.OpenStreetMap;
					GMapControl1.MinZoom = 1;
					GMapControl1.MaxZoom = 19;
					GMapControl1.Zoom = 10.0;
					GMapControl1.MarkersEnabled = true;
					GMapProvider.Language = (LanguageType)11;
					Cursor.Current = Cursors.WaitCursor;
					position = GMapControl1.Position;
					double lat2 = ((PointLatLng)(ref position)).Lat;
					position = GMapControl1.Position;
					PointLatLng val11 = new PointLatLng(lat2, ((PointLatLng)(ref position)).Lng);
					GMapOverlay val12 = new GMapOverlay(GMapControl1, "OverlayOne");
					GMapOverlay val13 = new GMapOverlay(GMapControl1, "Linea1");
					List<PointLatLng> list2 = new List<PointLatLng>();
					if (dataTable2.Rows.Count > 0)
					{
						int num6 = dataTable2.Rows.Count - 1;
						for (int j = 0; j <= num6; j++)
						{
							if (!Operators.ConditionalCompareObjectEqual(dataTable2.Rows[j]["Latitud"], 0, TextCompare: true))
							{
								double num7 = Conversions.ToDouble(dataTable2.Rows[j]["latitud"]);
								double num8 = Conversions.ToDouble(dataTable2.Rows[j]["longitud"]);
								string left2 = Conversions.ToString(dataTable2.Rows[j]["Estado"]);
								if ((Operators.CompareString(left2, "ENTREGADO", TextCompare: true) == 0) | (Operators.CompareString(left2, "RECOLECTADO", TextCompare: true) == 0))
								{
									GMapMarkerGoogleGreen val14 = new GMapMarkerGoogleGreen(new PointLatLng(num7, num8));
									((GMapMarker)val14).ToolTipText = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(dataTable2.Rows[j]["comprobante"], " - "), dataTable2.Rows[j]["Domicilio"]));
									((Collection<GMapMarker>)(object)val12.Markers).Add((GMapMarker)(object)val14);
								}
								else if (Operators.CompareString(left2, "PARCIAL", TextCompare: true) == 0)
								{
									GMapMarkerGoogleGreen val15 = new GMapMarkerGoogleGreen(new PointLatLng(num7, num8));
									((GMapMarker)val15).ToolTipText = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(dataTable2.Rows[j]["comprobante"], " - "), dataTable2.Rows[j]["Domicilio"]));
									((Collection<GMapMarker>)(object)val12.Markers).Add((GMapMarker)(object)val15);
								}
								else
								{
									GMapMarkerGoogleRed val16 = new GMapMarkerGoogleRed(new PointLatLng(num7, num8));
									((GMapMarker)val16).ToolTipText = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(dataTable2.Rows[j]["comprobante"], " - "), dataTable2.Rows[j]["Domicilio"]));
									((Collection<GMapMarker>)(object)val12.Markers).Add((GMapMarker)(object)val16);
								}
								list2.Add(new PointLatLng(Conversions.ToDouble((Conversions.ToString(num7) ?? "") ?? ""), Conversions.ToDouble((Conversions.ToString(num8) ?? "") ?? "")));
								ListViewItem listViewItem2 = new ListViewItem(dataTable2.Rows[j]["Comprobante"].ToString());
								listViewItem2.SubItems.Add(dataTable2.Rows[j]["Destino"].ToString());
								listViewItem2.SubItems.Add(dataTable2.Rows[j]["Domicilio"].ToString());
								listViewItem2.SubItems.Add(dataTable2.Rows[j]["Cliente"].ToString());
								if ((Operators.CompareString(left2, "ENTREGADO", TextCompare: true) == 0) | (Operators.CompareString(left2, "RECOLECTADO", TextCompare: true) == 0))
								{
									ListView1.Items.Add(listViewItem2).ForeColor = Color.Green;
								}
								else
								{
									ListView1.Items.Add(listViewItem2);
								}
							}
						}
						((Collection<GMapOverlay>)(object)GMapControl1.Overlays).Add(val12);
						Cursor.Current = Cursors.Default;
						ResumeLayout(performLayout: true);
						GMapControl1.DragButton = MouseButtons.Left;
					}
				}
				ListView listView = ListView1;
				int num9 = ListView1.Columns.Count - 1;
				for (int k = 0; k <= num9; k++)
				{
					listView.AutoResizeColumn(k, ColumnHeaderAutoResizeStyle.ColumnContent);
				}
				Label5.Text = Conversions.ToString(ListView1.Items.Count);
				listView = null;
				Mod_Sentencias.cnn.Close();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Mod_Sentencias.cnn.Close();
				Interaction.MsgBox(ex2.Message, MsgBoxStyle.Critical, "Error");
				ProjectData.ClearProjectError();
			}
		}
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		((Collection<GMapOverlay>)(object)GMapControl1.Overlays).Clear();
		ver_ruta();
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		((Collection<GMapOverlay>)(object)GMapControl1.Overlays).Clear();
		ver_zona();
	}

	private void ListView1_ColumnClick(object sender, ColumnClickEventArgs e)
	{
		Mod_Ordenaclumnas.ordenar_columnas(ListView1, RuntimeHelpers.GetObjectValue(sender), e);
	}

	private void CheckBox1_CheckedChanged(object sender, EventArgs e)
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected O, but got Unknown
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Expected O, but got Unknown
		if (CheckBox1.Checked)
		{
			try
			{
				((Collection<GMapOverlay>)(object)GMapControl1.Overlays).Clear();
				Mod_Sentencias.cnn.Open();
				int count = ComboBox2.Items.Count;
				for (int i = 1; i <= count; i = checked(i + 1))
				{
					DataTable dataTable = new DataTable("x");
					string text = ("SELECT latitud, longitud, color FROM Dibujos WHERE Zona=" + Conversions.ToString(i)) ?? "";
					MySqlDataAdapter val = new MySqlDataAdapter(text, Mod_Sentencias.cnn);
					GMapOverlay item = new GMapOverlay(GMapControl1, Conversions.ToString(i));
					GMapControl1.DragButton = MouseButtons.Left;
					GMapOverlay val2 = new GMapOverlay(GMapControl1, Conversions.ToString(i));
					List<PointLatLng> list = new List<PointLatLng>();
					DataSet dataSet = new DataSet();
					((DbDataAdapter)(object)val).Fill(dataSet, "tabla");
					DataTable dataTable2 = dataSet.Tables["tabla"];
					foreach (DataRow row in dataTable2.Rows)
					{
						double num = Conversions.ToDouble(row["Latitud"]);
						double num2 = Conversions.ToDouble(row["Longitud"]);
						colormapa = Color.FromArgb(Conversions.ToInteger(row["Color"]));
						list.Add(new PointLatLng(num, num2));
					}
					((Collection<GMapOverlay>)(object)GMapControl1.Overlays).Add(item);
					Cursor.Current = Cursors.Default;
					ResumeLayout(performLayout: true);
					GMapPolygon val3 = new GMapPolygon(list, "Linea");
					val3.Fill = new SolidBrush(Color.FromArgb(150, colormapa));
					val3.Stroke = new Pen(Color.Red, 1f);
					((Collection<GMapPolygon>)(object)val2.Polygons).Add(val3);
					((Collection<GMapOverlay>)(object)GMapControl1.Overlays).Add(val2);
				}
				Mod_Sentencias.cnn.Close();
				return;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Mod_Sentencias.cnn.Close();
				Interaction.MsgBox(ex2.Message);
				ProjectData.ClearProjectError();
				return;
			}
		}
		((Collection<GMapOverlay>)(object)GMapControl1.Overlays).Clear();
		GMapControl1.Refresh();
	}

	private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		DataTable dataTable = new DataTable("x");
		string text = "SELECT Numero FROM Flota WHERE Chofer='" + ComboBox1.Text + "'";
		MySqlDataAdapter val = new MySqlDataAdapter(text, Mod_Sentencias.cnn);
		((DbDataAdapter)(object)val).Fill(dataTable);
		choferselec = Conversions.ToString(dataTable.Rows[0]["Numero"]);
	}
}
