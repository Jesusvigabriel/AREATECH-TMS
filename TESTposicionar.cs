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
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace Hermes;

[DesignerGenerated]
public class TESTposicionar : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("GMapControl1")]
	private GMapControl _GMapControl1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("CheckBox1")]
	private CheckBox _CheckBox1;

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
	[AccessedThroughProperty("ComboBox1")]
	private ComboBox _ComboBox1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("CheckBox2")]
	private CheckBox _CheckBox2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("CheckBox3")]
	private CheckBox _CheckBox3;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button4")]
	private Button _Button4;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button5")]
	private Button _Button5;

	private Color colormapa;

	internal virtual GMapControl GMapControl1
	{
		[CompilerGenerated]
		get
		{
			return _GMapControl1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = [SpecialName] [DebuggerHidden] (object a0, EventArgs a1) =>
			{
				GMapControl1_MousedoubleClick(RuntimeHelpers.GetObjectValue(a0), (MouseEventArgs)a1);
			};
			GMapControl gMapControl = _GMapControl1;
			if (gMapControl != null)
			{
				((Control)(object)gMapControl).DoubleClick -= value2;
			}
			_GMapControl1 = value;
			gMapControl = _GMapControl1;
			if (gMapControl != null)
			{
				((Control)(object)gMapControl).DoubleClick += value2;
			}
		}
	}

	[field: AccessedThroughProperty("GroupBox1")]
	internal virtual GroupBox GroupBox1
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

	[field: AccessedThroughProperty("ListView1")]
	internal virtual ListView ListView1
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

	internal virtual CheckBox CheckBox2
	{
		[CompilerGenerated]
		get
		{
			return _CheckBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = CheckBox2_CheckedChanged;
			CheckBox checkBox = _CheckBox2;
			if (checkBox != null)
			{
				checkBox.CheckedChanged -= value2;
			}
			_CheckBox2 = value;
			checkBox = _CheckBox2;
			if (checkBox != null)
			{
				checkBox.CheckedChanged += value2;
			}
		}
	}

	internal virtual CheckBox CheckBox3
	{
		[CompilerGenerated]
		get
		{
			return _CheckBox3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = CheckBox3_CheckedChanged;
			CheckBox checkBox = _CheckBox3;
			if (checkBox != null)
			{
				checkBox.CheckedChanged -= value2;
			}
			_CheckBox3 = value;
			checkBox = _CheckBox3;
			if (checkBox != null)
			{
				checkBox.CheckedChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Button3")]
	internal virtual Button Button3
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

	[field: AccessedThroughProperty("Label5")]
	internal virtual Label Label5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CheckBox4")]
	internal virtual CheckBox CheckBox4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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

	public TESTposicionar()
	{
		base.Load += TESTposicionar_Load;
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
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		this.GMapControl1 = new GMapControl();
		this.GroupBox1 = new System.Windows.Forms.GroupBox();
		this.CheckBox4 = new System.Windows.Forms.CheckBox();
		this.Label5 = new System.Windows.Forms.Label();
		this.Button4 = new System.Windows.Forms.Button();
		this.Button3 = new System.Windows.Forms.Button();
		this.CheckBox3 = new System.Windows.Forms.CheckBox();
		this.CheckBox2 = new System.Windows.Forms.CheckBox();
		this.ComboBox1 = new System.Windows.Forms.ComboBox();
		this.Button2 = new System.Windows.Forms.Button();
		this.Button1 = new System.Windows.Forms.Button();
		this.CheckBox1 = new System.Windows.Forms.CheckBox();
		this.ListView1 = new System.Windows.Forms.ListView();
		this.Label4 = new System.Windows.Forms.Label();
		this.Label3 = new System.Windows.Forms.Label();
		this.Label2 = new System.Windows.Forms.Label();
		this.Label1 = new System.Windows.Forms.Label();
		this.Button5 = new System.Windows.Forms.Button();
		this.GroupBox1.SuspendLayout();
		base.SuspendLayout();
		((System.Windows.Forms.Control)(object)this.GMapControl1).Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.GMapControl1.Bearing = 0f;
		this.GMapControl1.CanDragMap = true;
		this.GMapControl1.GrayScaleMode = false;
		this.GMapControl1.LevelsKeepInMemmory = 5;
		((System.Windows.Forms.Control)(object)this.GMapControl1).Location = new System.Drawing.Point(12, 12);
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
		((System.Windows.Forms.Control)(object)this.GMapControl1).Size = new System.Drawing.Size(728, 453);
		((System.Windows.Forms.Control)(object)this.GMapControl1).TabIndex = 0;
		this.GMapControl1.Zoom = 0.0;
		this.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.GroupBox1.Controls.Add(this.Button5);
		this.GroupBox1.Controls.Add(this.CheckBox4);
		this.GroupBox1.Controls.Add(this.Label5);
		this.GroupBox1.Controls.Add(this.Button4);
		this.GroupBox1.Controls.Add(this.Button3);
		this.GroupBox1.Controls.Add(this.CheckBox3);
		this.GroupBox1.Controls.Add(this.CheckBox2);
		this.GroupBox1.Controls.Add(this.ComboBox1);
		this.GroupBox1.Controls.Add(this.Button2);
		this.GroupBox1.Controls.Add(this.Button1);
		this.GroupBox1.Controls.Add(this.CheckBox1);
		this.GroupBox1.Controls.Add(this.ListView1);
		this.GroupBox1.Controls.Add(this.Label4);
		this.GroupBox1.Controls.Add(this.Label3);
		this.GroupBox1.Controls.Add(this.Label2);
		this.GroupBox1.Controls.Add(this.Label1);
		this.GroupBox1.Location = new System.Drawing.Point(12, 291);
		this.GroupBox1.Name = "GroupBox1";
		this.GroupBox1.Size = new System.Drawing.Size(728, 174);
		this.GroupBox1.TabIndex = 1;
		this.GroupBox1.TabStop = false;
		this.GroupBox1.Text = "Menu";
		this.CheckBox4.AutoSize = true;
		this.CheckBox4.Location = new System.Drawing.Point(180, 74);
		this.CheckBox4.Name = "CheckBox4";
		this.CheckBox4.Size = new System.Drawing.Size(81, 17);
		this.CheckBox4.TabIndex = 15;
		this.CheckBox4.Text = "CheckBox4";
		this.CheckBox4.UseVisualStyleBackColor = true;
		this.Label5.AutoSize = true;
		this.Label5.Location = new System.Drawing.Point(391, 22);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(88, 13);
		this.Label5.TabIndex = 14;
		this.Label5.Text = "Seleccione Zona";
		this.Button4.Location = new System.Drawing.Point(333, 145);
		this.Button4.Name = "Button4";
		this.Button4.Size = new System.Drawing.Size(83, 23);
		this.Button4.TabIndex = 13;
		this.Button4.Text = "Colores";
		this.Button4.UseVisualStyleBackColor = true;
		this.Button3.Location = new System.Drawing.Point(252, 144);
		this.Button3.Name = "Button3";
		this.Button3.Size = new System.Drawing.Size(75, 23);
		this.Button3.TabIndex = 11;
		this.Button3.Text = "Button3";
		this.Button3.UseVisualStyleBackColor = true;
		this.CheckBox3.AutoSize = true;
		this.CheckBox3.Location = new System.Drawing.Point(9, 148);
		this.CheckBox3.Name = "CheckBox3";
		this.CheckBox3.Size = new System.Drawing.Size(75, 17);
		this.CheckBox3.TabIndex = 10;
		this.CheckBox3.Text = "Ver Todas";
		this.CheckBox3.UseVisualStyleBackColor = true;
		this.CheckBox2.AutoSize = true;
		this.CheckBox2.Location = new System.Drawing.Point(9, 125);
		this.CheckBox2.Name = "CheckBox2";
		this.CheckBox2.Size = new System.Drawing.Size(75, 17);
		this.CheckBox2.TabIndex = 9;
		this.CheckBox2.Text = "Ver Zonas";
		this.CheckBox2.UseVisualStyleBackColor = true;
		this.ComboBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		this.ComboBox1.FormattingEnabled = true;
		this.ComboBox1.Location = new System.Drawing.Point(485, 19);
		this.ComboBox1.Name = "ComboBox1";
		this.ComboBox1.Size = new System.Drawing.Size(121, 21);
		this.ComboBox1.TabIndex = 8;
		this.Button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		this.Button2.Location = new System.Drawing.Point(517, 145);
		this.Button2.Name = "Button2";
		this.Button2.Size = new System.Drawing.Size(89, 23);
		this.Button2.TabIndex = 7;
		this.Button2.Text = "Borrar";
		this.Button2.UseVisualStyleBackColor = true;
		this.Button1.Location = new System.Drawing.Point(422, 145);
		this.Button1.Name = "Button1";
		this.Button1.Size = new System.Drawing.Size(89, 23);
		this.Button1.TabIndex = 6;
		this.Button1.Text = "Guardar";
		this.Button1.UseVisualStyleBackColor = true;
		this.CheckBox1.AutoSize = true;
		this.CheckBox1.Location = new System.Drawing.Point(9, 102);
		this.CheckBox1.Name = "CheckBox1";
		this.CheckBox1.Size = new System.Drawing.Size(84, 17);
		this.CheckBox1.TabIndex = 5;
		this.CheckBox1.Text = "Definir Zona";
		this.CheckBox1.UseVisualStyleBackColor = true;
		this.ListView1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		this.ListView1.FullRowSelect = true;
		this.ListView1.GridLines = true;
		this.ListView1.Location = new System.Drawing.Point(612, 19);
		this.ListView1.Name = "ListView1";
		this.ListView1.Size = new System.Drawing.Size(110, 149);
		this.ListView1.TabIndex = 4;
		this.ListView1.UseCompatibleStateImageBehavior = false;
		this.ListView1.View = System.Windows.Forms.View.List;
		this.Label4.AutoSize = true;
		this.Label4.Location = new System.Drawing.Point(76, 48);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(39, 13);
		this.Label4.TabIndex = 3;
		this.Label4.Text = "Label4";
		this.Label3.AutoSize = true;
		this.Label3.Location = new System.Drawing.Point(6, 48);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(51, 13);
		this.Label3.TabIndex = 2;
		this.Label3.Text = "Longitud:";
		this.Label2.AutoSize = true;
		this.Label2.Location = new System.Drawing.Point(76, 19);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(39, 13);
		this.Label2.TabIndex = 1;
		this.Label2.Text = "Label2";
		this.Label1.AutoSize = true;
		this.Label1.Location = new System.Drawing.Point(6, 19);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(42, 13);
		this.Label1.TabIndex = 0;
		this.Label1.Text = "Latitud:";
		this.Button5.Location = new System.Drawing.Point(517, 46);
		this.Button5.Name = "Button5";
		this.Button5.Size = new System.Drawing.Size(75, 23);
		this.Button5.TabIndex = 16;
		this.Button5.Text = "Borrar Zona";
		this.Button5.UseVisualStyleBackColor = true;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(752, 477);
		base.Controls.Add(this.GroupBox1);
		base.Controls.Add((System.Windows.Forms.Control)(object)this.GMapControl1);
		base.Name = "TESTposicionar";
		this.Text = "TESTposicionar";
		this.GroupBox1.ResumeLayout(false);
		this.GroupBox1.PerformLayout();
		base.ResumeLayout(false);
	}

	private void GMapControl1_MousedoubleClick(object sender, MouseEventArgs e)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected O, but got Unknown
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Expected O, but got Unknown
		checked
		{
			try
			{
				if (e.Button == MouseButtons.Left)
				{
					Cursor.Current = Cursors.WaitCursor;
					PointLatLng val = GMapControl1.FromLocalToLatLng(e.X, e.Y);
					PointLatLng val2 = new PointLatLng(Conversions.ToDouble(((PointLatLng)(ref val)).Lat.ToString()), Conversions.ToDouble(((PointLatLng)(ref val)).Lng.ToString()));
					GMapMarkerGoogleGreen item = new GMapMarkerGoogleGreen(val2);
					GMapOverlay val3 = new GMapOverlay(GMapControl1, "current");
					GMapControl1.MarkersEnabled = true;
					((Collection<GMapMarker>)(object)val3.Markers).Add((GMapMarker)(object)item);
					((Collection<GMapOverlay>)(object)GMapControl1.Overlays).Add(val3);
					Label2.Text = ((PointLatLng)(ref val)).Lat.ToString();
					Label4.Text = ((PointLatLng)(ref val)).Lng.ToString();
					ListViewItem listViewItem = new ListViewItem(((PointLatLng)(ref val)).Lat.ToString());
					listViewItem.SubItems.Add(((PointLatLng)(ref val)).Lng.ToString());
					ListView1.Items.Add(listViewItem);
					if (CheckBox1.Checked && ListView1.Items.Count > 3)
					{
						dibujar_zona();
					}
				}
				if (CheckBox4.Checked)
				{
					string text = "SELECT DISTINCT Zona FROM dibujos";
					DataTable dataTable = new DataTable("x");
					MySqlDataAdapter val4 = new MySqlDataAdapter(text, Mod_Sentencias.cnn);
					((DbDataAdapter)(object)val4).Fill(dataTable);
					int num = dataTable.Rows.Count - 1;
					for (int i = 0; i <= num; i++)
					{
						Mod_Calculos.puntoenpoligono2(Conversions.ToInteger(dataTable.Rows[i]["zona"].ToString()), Label2, Label4);
					}
				}
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

	private void TESTposicionar_Load(object sender, EventArgs e)
	{
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Expected O, but got Unknown
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Expected O, but got Unknown
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Expected O, but got Unknown
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Expected O, but got Unknown
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			cargar_zonas();
			ListView listView = ListView1;
			listView.View = View.Details;
			listView.FullRowSelect = true;
			listView.GridLines = true;
			listView.LabelEdit = false;
			listView.HideSelection = false;
			listView.MultiSelect = false;
			listView.Columns.Add("Latitud");
			listView.Columns.Add("longitud");
			listView = null;
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
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox(ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	public void dibujar_zona()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected O, but got Unknown
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected O, but got Unknown
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Expected O, but got Unknown
		GMapControl1.MarkersEnabled = true;
		GMapProvider.Language = (LanguageType)11;
		Cursor.Current = Cursors.WaitCursor;
		PointLatLng position = GMapControl1.Position;
		double lat = ((PointLatLng)(ref position)).Lat;
		position = GMapControl1.Position;
		PointLatLng val = default(PointLatLng);
		((PointLatLng)(ref val))._002Ector(lat, ((PointLatLng)(ref position)).Lng);
		GMapOverlay item = new GMapOverlay(GMapControl1, "OverlayOne");
		GMapControl1.DragButton = MouseButtons.Left;
		GMapOverlay val2 = new GMapOverlay(GMapControl1, "Linea1");
		List<PointLatLng> list = new List<PointLatLng>();
		checked
		{
			if (ListView1.Items.Count > 0)
			{
				int num = ListView1.Items.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					double num2 = Conversions.ToDouble(ListView1.Items[i].Text);
					double num3 = Conversions.ToDouble(ListView1.Items[i].SubItems[1].Text);
					list.Add(new PointLatLng(num2, num3));
				}
				((Collection<GMapOverlay>)(object)GMapControl1.Overlays).Add(item);
				Cursor.Current = Cursors.Default;
				ResumeLayout(performLayout: true);
				GMapPolygon val3 = new GMapPolygon(list, "Linea");
				val3.Fill = new SolidBrush(Color.FromArgb(150, colormapa));
				val3.Stroke = new Pen(Color.Green, 1f);
				((Collection<GMapPolygon>)(object)val2.Polygons).Add(val3);
				((Collection<GMapOverlay>)(object)GMapControl1.Overlays).Add(val2);
			}
		}
	}

	private void CheckBox1_CheckedChanged(object sender, EventArgs e)
	{
		ListView1.Items.Clear();
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		if (ListView1.Items.Count > 3)
		{
			guardar_dibujo_zona();
			ListView1.Items.Clear();
		}
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		((Collection<GMapOverlay>)(object)GMapControl1.Overlays).Clear();
		ListView1.Items.Clear();
		GMapControl1.Refresh();
	}

	private void guardar_dibujo_zona()
	{
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected O, but got Unknown
		Mod_Sentencias.cnn.Open();
		checked
		{
			try
			{
				int num = ListView1.Items.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					string text = "INSERT INTO Dibujos(Zona, Punto, Descripcion, Latitud, Longitud,Color) VALUES (" + ComboBox1.Text + ", " + Conversions.ToString(i) + ",'nada'," + Strings.Replace(ListView1.Items[i].Text, ",", ".", 1, -1, CompareMethod.Text) + "," + Strings.Replace(ListView1.Items[i].SubItems[1].Text, ",", ".", 1, -1, CompareMethod.Text) + "," + Conversions.ToString(colormapa.ToArgb()) + ")";
					MySqlCommand val = new MySqlCommand(text, Mod_Sentencias.cnn);
					val.ExecuteNonQuery();
				}
				Mod_Sentencias.cnn.Close();
				base.Visible = true;
				Interaction.MsgBox("Se Guardaron los datos");
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

	private void cargar_zonas()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		DataTable dataTable = new DataTable("x");
		string text = "SELECT * FROM Zonas order by zona";
		MySqlDataAdapter val = new MySqlDataAdapter(text, Mod_Sentencias.cnn);
		DataSet dataSet = new DataSet();
		((DbDataAdapter)(object)val).Fill(dataSet, "tabla");
		ComboBox1.Items.Clear();
		DataTable dataTable2 = dataSet.Tables["tabla"];
		foreach (DataRow row in dataTable2.Rows)
		{
			ComboBox1.Items.Add(RuntimeHelpers.GetObjectValue(row["Zona"]));
		}
		ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
	}

	private void CheckBox2_CheckedChanged(object sender, EventArgs e)
	{
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected O, but got Unknown
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Expected O, but got Unknown
		if (!CheckBox2.Checked)
		{
			return;
		}
		try
		{
			Mod_Sentencias.cnn.Open();
			DataTable dataTable = new DataTable("x");
			string text = ("SELECT * FROM Dibujos WHERE Zona=" + ComboBox1.Text) ?? "";
			MySqlDataAdapter val = new MySqlDataAdapter(text, Mod_Sentencias.cnn);
			DataSet dataSet = new DataSet();
			((DbDataAdapter)(object)val).Fill(dataSet, "tabla");
			DataTable dataTable2 = dataSet.Tables["tabla"];
			GMapOverlay item = new GMapOverlay(GMapControl1, "OverlayOne");
			GMapControl1.DragButton = MouseButtons.Left;
			GMapOverlay val2 = new GMapOverlay(GMapControl1, "Linea1");
			List<PointLatLng> list = new List<PointLatLng>();
			((Collection<GMapOverlay>)(object)GMapControl1.Overlays).Clear();
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
			val3.Stroke = new Pen(Color.Green, 1f);
			((Collection<GMapPolygon>)(object)val2.Polygons).Add(val3);
			((Collection<GMapOverlay>)(object)GMapControl1.Overlays).Add(val2);
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

	private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
	{
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected O, but got Unknown
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Expected O, but got Unknown
		if (!CheckBox2.Checked)
		{
			return;
		}
		try
		{
			Mod_Sentencias.cnn.Open();
			DataTable dataTable = new DataTable("x");
			string text = ("SELECT * FROM Dibujos WHERE Zona=" + ComboBox1.Text) ?? "";
			MySqlDataAdapter val = new MySqlDataAdapter(text, Mod_Sentencias.cnn);
			DataSet dataSet = new DataSet();
			((DbDataAdapter)(object)val).Fill(dataSet, "tabla");
			DataTable dataTable2 = dataSet.Tables["tabla"];
			GMapOverlay item = new GMapOverlay(GMapControl1, "OverlayOne");
			GMapControl1.DragButton = MouseButtons.Left;
			GMapOverlay val2 = new GMapOverlay(GMapControl1, "Linea1");
			List<PointLatLng> list = new List<PointLatLng>();
			((Collection<GMapOverlay>)(object)GMapControl1.Overlays).Clear();
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
			val3.Stroke = new Pen(Color.Green, 1f);
			((Collection<GMapPolygon>)(object)val2.Polygons).Add(val3);
			((Collection<GMapOverlay>)(object)GMapControl1.Overlays).Add(val2);
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

	private void CheckBox3_CheckedChanged(object sender, EventArgs e)
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
		if (!CheckBox3.Checked)
		{
			return;
		}
		try
		{
			((Collection<GMapOverlay>)(object)GMapControl1.Overlays).Clear();
			Mod_Sentencias.cnn.Open();
			int count = ComboBox1.Items.Count;
			for (int i = 1; i <= count; i = checked(i + 1))
			{
				DataTable dataTable = new DataTable("x");
				string text = ("SELECT * FROM Dibujos WHERE Zona=" + Conversions.ToString(i)) ?? "";
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

	private void Button4_Click(object sender, EventArgs e)
	{
		ColorDialog colorDialog = new ColorDialog();
		colorDialog.Color = Label1.BackColor;
		if (colorDialog.ShowDialog() == DialogResult.OK)
		{
			colormapa = colorDialog.Color;
		}
	}

	private void Button5_Click(object sender, EventArgs e)
	{
		string sQL = ("DELETE FROM Dibujos WHERE Zona=" + ComboBox1.Text) ?? "";
		Mod_ConeccionBD.BD_Sentencia(sQL);
	}
}
