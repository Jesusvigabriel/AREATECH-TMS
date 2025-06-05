using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Hermes.My;
using Hermes.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace Hermes;

[DesignerGenerated]
public class Localidades : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("guardarbtn")]
	private Button _guardarbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ListView1")]
	private ListView _ListView1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("nuevobtn")]
	private Button _nuevobtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("borrarbtn")]
	private Button _borrarbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("TextBox1")]
	private TextBox _TextBox1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("TextBox2")]
	private TextBox _TextBox2;

	private DataSet dataset;

	[field: AccessedThroughProperty("GroupBox1")]
	internal virtual GroupBox GroupBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("comboadicionales")]
	internal virtual ComboBox comboadicionales
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("adicionaltxt")]
	internal virtual Label adicionaltxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("adicionallbl")]
	internal virtual Label adicionallbl
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("combozonas")]
	internal virtual ComboBox combozonas
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("zonatxt")]
	internal virtual Label zonatxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("codigopostaltxt")]
	internal virtual TextBox codigopostaltxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("codigopostallbl")]
	internal virtual Label codigopostallbl
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("zonalbl")]
	internal virtual Label zonalbl
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("localidadtxt")]
	internal virtual TextBox localidadtxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("localidadlbl")]
	internal virtual Label localidadlbl
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("idtxt")]
	internal virtual Label idtxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("idlbl")]
	internal virtual Label idlbl
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("usuariotxt")]
	internal virtual Label usuariotxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("usuariolbl")]
	internal virtual Label usuariolbl
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("fechatxt")]
	internal virtual Label fechatxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("fechalbl")]
	internal virtual Label fechalbl
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
			ColumnClickEventHandler value3 = ListView1_ColumnClick;
			ListView listView = _ListView1;
			if (listView != null)
			{
				listView.SelectedIndexChanged -= value2;
				listView.ColumnClick -= value3;
			}
			_ListView1 = value;
			listView = _ListView1;
			if (listView != null)
			{
				listView.SelectedIndexChanged += value2;
				listView.ColumnClick += value3;
			}
		}
	}

	internal virtual Button nuevobtn
	{
		[CompilerGenerated]
		get
		{
			return _nuevobtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = nuevobtn_Click;
			Button button = _nuevobtn;
			if (button != null)
			{
				button.Click -= value2;
			}
			_nuevobtn = value;
			button = _nuevobtn;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button borrarbtn
	{
		[CompilerGenerated]
		get
		{
			return _borrarbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = borrarbtn_Click;
			Button button = _borrarbtn;
			if (button != null)
			{
				button.Click -= value2;
			}
			_borrarbtn = value;
			button = _borrarbtn;
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

	internal virtual TextBox TextBox1
	{
		[CompilerGenerated]
		get
		{
			return _TextBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = TextBox1_TextChanged;
			TextBox textBox = _TextBox1;
			if (textBox != null)
			{
				textBox.TextChanged -= value2;
			}
			_TextBox1 = value;
			textBox = _TextBox1;
			if (textBox != null)
			{
				textBox.TextChanged += value2;
			}
		}
	}

	internal virtual TextBox TextBox2
	{
		[CompilerGenerated]
		get
		{
			return _TextBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = TextBox2_TextChanged;
			TextBox textBox = _TextBox2;
			if (textBox != null)
			{
				textBox.TextChanged -= value2;
			}
			_TextBox2 = value;
			textBox = _TextBox2;
			if (textBox != null)
			{
				textBox.TextChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("GroupBox2")]
	internal virtual GroupBox GroupBox2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public Localidades()
	{
		base.Load += Localidades_Load;
		dataset = new DataSet();
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hermes.Localidades));
		this.GroupBox1 = new System.Windows.Forms.GroupBox();
		this.Button1 = new System.Windows.Forms.Button();
		this.borrarbtn = new System.Windows.Forms.Button();
		this.nuevobtn = new System.Windows.Forms.Button();
		this.guardarbtn = new System.Windows.Forms.Button();
		this.comboadicionales = new System.Windows.Forms.ComboBox();
		this.adicionaltxt = new System.Windows.Forms.Label();
		this.adicionallbl = new System.Windows.Forms.Label();
		this.combozonas = new System.Windows.Forms.ComboBox();
		this.zonatxt = new System.Windows.Forms.Label();
		this.codigopostaltxt = new System.Windows.Forms.TextBox();
		this.codigopostallbl = new System.Windows.Forms.Label();
		this.zonalbl = new System.Windows.Forms.Label();
		this.localidadtxt = new System.Windows.Forms.TextBox();
		this.localidadlbl = new System.Windows.Forms.Label();
		this.idtxt = new System.Windows.Forms.Label();
		this.idlbl = new System.Windows.Forms.Label();
		this.fechalbl = new System.Windows.Forms.Label();
		this.fechatxt = new System.Windows.Forms.Label();
		this.usuariolbl = new System.Windows.Forms.Label();
		this.usuariotxt = new System.Windows.Forms.Label();
		this.ListView1 = new System.Windows.Forms.ListView();
		this.Label1 = new System.Windows.Forms.Label();
		this.Label2 = new System.Windows.Forms.Label();
		this.TextBox1 = new System.Windows.Forms.TextBox();
		this.TextBox2 = new System.Windows.Forms.TextBox();
		this.GroupBox2 = new System.Windows.Forms.GroupBox();
		this.GroupBox1.SuspendLayout();
		this.GroupBox2.SuspendLayout();
		base.SuspendLayout();
		this.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.GroupBox1.Controls.Add(this.Button1);
		this.GroupBox1.Controls.Add(this.borrarbtn);
		this.GroupBox1.Controls.Add(this.nuevobtn);
		this.GroupBox1.Controls.Add(this.guardarbtn);
		this.GroupBox1.Controls.Add(this.comboadicionales);
		this.GroupBox1.Controls.Add(this.adicionaltxt);
		this.GroupBox1.Controls.Add(this.adicionallbl);
		this.GroupBox1.Controls.Add(this.combozonas);
		this.GroupBox1.Controls.Add(this.zonatxt);
		this.GroupBox1.Controls.Add(this.codigopostaltxt);
		this.GroupBox1.Controls.Add(this.codigopostallbl);
		this.GroupBox1.Controls.Add(this.zonalbl);
		this.GroupBox1.Controls.Add(this.localidadtxt);
		this.GroupBox1.Controls.Add(this.localidadlbl);
		this.GroupBox1.Controls.Add(this.idtxt);
		this.GroupBox1.Controls.Add(this.idlbl);
		this.GroupBox1.Location = new System.Drawing.Point(12, 12);
		this.GroupBox1.Name = "GroupBox1";
		this.GroupBox1.Size = new System.Drawing.Size(411, 384);
		this.GroupBox1.TabIndex = 0;
		this.GroupBox1.TabStop = false;
		this.GroupBox1.Text = "Seleccion";
		this.Button1.Image = (System.Drawing.Image)resources.GetObject("Button1.Image");
		this.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
		this.Button1.Location = new System.Drawing.Point(333, 312);
		this.Button1.Name = "Button1";
		this.Button1.Size = new System.Drawing.Size(75, 57);
		this.Button1.TabIndex = 15;
		this.Button1.Text = "Exportar";
		this.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
		this.Button1.UseVisualStyleBackColor = true;
		this.borrarbtn.Image = Hermes.My.Resources.Resources.close_32;
		this.borrarbtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
		this.borrarbtn.Location = new System.Drawing.Point(252, 312);
		this.borrarbtn.Name = "borrarbtn";
		this.borrarbtn.Size = new System.Drawing.Size(75, 57);
		this.borrarbtn.TabIndex = 14;
		this.borrarbtn.Text = "Borrar";
		this.borrarbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
		this.borrarbtn.UseVisualStyleBackColor = true;
		this.nuevobtn.Image = (System.Drawing.Image)resources.GetObject("nuevobtn.Image");
		this.nuevobtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
		this.nuevobtn.Location = new System.Drawing.Point(9, 312);
		this.nuevobtn.Name = "nuevobtn";
		this.nuevobtn.Size = new System.Drawing.Size(75, 57);
		this.nuevobtn.TabIndex = 13;
		this.nuevobtn.Text = "Nuevo";
		this.nuevobtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
		this.nuevobtn.UseVisualStyleBackColor = true;
		this.guardarbtn.Image = (System.Drawing.Image)resources.GetObject("guardarbtn.Image");
		this.guardarbtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
		this.guardarbtn.Location = new System.Drawing.Point(90, 312);
		this.guardarbtn.Name = "guardarbtn";
		this.guardarbtn.Size = new System.Drawing.Size(75, 57);
		this.guardarbtn.TabIndex = 12;
		this.guardarbtn.Text = "Editar";
		this.guardarbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
		this.guardarbtn.UseVisualStyleBackColor = true;
		this.comboadicionales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboadicionales.FormattingEnabled = true;
		this.comboadicionales.Items.AddRange(new object[6] { "0", "1", "2", "3", "4", "5" });
		this.comboadicionales.Location = new System.Drawing.Point(308, 148);
		this.comboadicionales.Name = "comboadicionales";
		this.comboadicionales.Size = new System.Drawing.Size(74, 21);
		this.comboadicionales.TabIndex = 11;
		this.adicionaltxt.AutoSize = true;
		this.adicionaltxt.Location = new System.Drawing.Point(228, 151);
		this.adicionaltxt.Name = "adicionaltxt";
		this.adicionaltxt.Size = new System.Drawing.Size(68, 13);
		this.adicionaltxt.TabIndex = 10;
		this.adicionaltxt.Text = "Sin Adicional";
		this.adicionallbl.AutoSize = true;
		this.adicionallbl.Location = new System.Drawing.Point(160, 151);
		this.adicionallbl.Name = "adicionallbl";
		this.adicionallbl.Size = new System.Drawing.Size(53, 13);
		this.adicionallbl.TabIndex = 9;
		this.adicionallbl.Text = "Adicional:";
		this.combozonas.FormattingEnabled = true;
		this.combozonas.Location = new System.Drawing.Point(308, 113);
		this.combozonas.Name = "combozonas";
		this.combozonas.Size = new System.Drawing.Size(74, 21);
		this.combozonas.TabIndex = 8;
		this.zonatxt.AutoSize = true;
		this.zonatxt.Location = new System.Drawing.Point(228, 116);
		this.zonatxt.Name = "zonatxt";
		this.zonatxt.Size = new System.Drawing.Size(50, 13);
		this.zonatxt.TabIndex = 7;
		this.zonatxt.Text = "Sin Zona";
		this.codigopostaltxt.Location = new System.Drawing.Point(241, 38);
		this.codigopostaltxt.Name = "codigopostaltxt";
		this.codigopostaltxt.Size = new System.Drawing.Size(86, 20);
		this.codigopostaltxt.TabIndex = 6;
		this.codigopostallbl.AutoSize = true;
		this.codigopostallbl.Location = new System.Drawing.Point(160, 41);
		this.codigopostallbl.Name = "codigopostallbl";
		this.codigopostallbl.Size = new System.Drawing.Size(75, 13);
		this.codigopostallbl.TabIndex = 5;
		this.codigopostallbl.Text = "Codigo Postal:";
		this.zonalbl.AutoSize = true;
		this.zonalbl.Location = new System.Drawing.Point(160, 116);
		this.zonalbl.Name = "zonalbl";
		this.zonalbl.Size = new System.Drawing.Size(35, 13);
		this.zonalbl.TabIndex = 4;
		this.zonalbl.Text = "Zona:";
		this.localidadtxt.Location = new System.Drawing.Point(87, 77);
		this.localidadtxt.Name = "localidadtxt";
		this.localidadtxt.Size = new System.Drawing.Size(295, 20);
		this.localidadtxt.TabIndex = 3;
		this.localidadlbl.AutoSize = true;
		this.localidadlbl.Location = new System.Drawing.Point(25, 80);
		this.localidadlbl.Name = "localidadlbl";
		this.localidadlbl.Size = new System.Drawing.Size(56, 13);
		this.localidadlbl.TabIndex = 2;
		this.localidadlbl.Text = "Localidad:";
		this.idtxt.AutoSize = true;
		this.idtxt.Location = new System.Drawing.Point(70, 41);
		this.idtxt.Name = "idtxt";
		this.idtxt.Size = new System.Drawing.Size(13, 13);
		this.idtxt.TabIndex = 1;
		this.idtxt.Text = "0";
		this.idlbl.AutoSize = true;
		this.idlbl.Location = new System.Drawing.Point(25, 41);
		this.idlbl.Name = "idlbl";
		this.idlbl.Size = new System.Drawing.Size(21, 13);
		this.idlbl.TabIndex = 0;
		this.idlbl.Text = "ID:";
		this.fechalbl.AutoSize = true;
		this.fechalbl.Location = new System.Drawing.Point(267, 464);
		this.fechalbl.Name = "fechalbl";
		this.fechalbl.Size = new System.Drawing.Size(102, 13);
		this.fechalbl.TabIndex = 12;
		this.fechalbl.Text = "Ultima Modificacion:";
		this.fechatxt.AutoSize = true;
		this.fechatxt.Location = new System.Drawing.Point(375, 464);
		this.fechatxt.Name = "fechatxt";
		this.fechatxt.Size = new System.Drawing.Size(65, 13);
		this.fechatxt.TabIndex = 13;
		this.fechatxt.Text = "21/09/2014";
		this.usuariolbl.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		this.usuariolbl.AutoSize = true;
		this.usuariolbl.Location = new System.Drawing.Point(819, 383);
		this.usuariolbl.Name = "usuariolbl";
		this.usuariolbl.Size = new System.Drawing.Size(46, 13);
		this.usuariolbl.TabIndex = 14;
		this.usuariolbl.Text = "Usuario:";
		this.usuariotxt.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		this.usuariotxt.AutoSize = true;
		this.usuariotxt.Location = new System.Drawing.Point(871, 383);
		this.usuariotxt.Name = "usuariotxt";
		this.usuariotxt.Size = new System.Drawing.Size(36, 13);
		this.usuariotxt.TabIndex = 15;
		this.usuariotxt.Text = "Admin";
		this.ListView1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom;
		this.ListView1.Location = new System.Drawing.Point(440, 89);
		this.ListView1.Name = "ListView1";
		this.ListView1.Size = new System.Drawing.Size(467, 292);
		this.ListView1.TabIndex = 1;
		this.ListView1.UseCompatibleStateImageBehavior = false;
		this.Label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.Label1.AutoSize = true;
		this.Label1.Location = new System.Drawing.Point(443, 383);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(35, 13);
		this.Label1.TabIndex = 16;
		this.Label1.Text = "Items:";
		this.Label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.Label2.AutoSize = true;
		this.Label2.Location = new System.Drawing.Point(484, 383);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(13, 13);
		this.Label2.TabIndex = 17;
		this.Label2.Text = "0";
		this.TextBox1.Location = new System.Drawing.Point(20, 35);
		this.TextBox1.Name = "TextBox1";
		this.TextBox1.Size = new System.Drawing.Size(114, 20);
		this.TextBox1.TabIndex = 18;
		this.TextBox2.Location = new System.Drawing.Point(154, 35);
		this.TextBox2.Name = "TextBox2";
		this.TextBox2.Size = new System.Drawing.Size(307, 20);
		this.TextBox2.TabIndex = 19;
		this.GroupBox2.Controls.Add(this.TextBox2);
		this.GroupBox2.Controls.Add(this.TextBox1);
		this.GroupBox2.Location = new System.Drawing.Point(440, 15);
		this.GroupBox2.Name = "GroupBox2";
		this.GroupBox2.Size = new System.Drawing.Size(467, 68);
		this.GroupBox2.TabIndex = 20;
		this.GroupBox2.TabStop = false;
		this.GroupBox2.Text = "Buscar";
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(920, 406);
		base.Controls.Add(this.GroupBox2);
		base.Controls.Add(this.Label2);
		base.Controls.Add(this.Label1);
		base.Controls.Add(this.usuariotxt);
		base.Controls.Add(this.usuariolbl);
		base.Controls.Add(this.ListView1);
		base.Controls.Add(this.fechatxt);
		base.Controls.Add(this.GroupBox1);
		base.Controls.Add(this.fechalbl);
		base.Name = "Localidades";
		base.ShowIcon = false;
		this.Text = "Localidades";
		this.GroupBox1.ResumeLayout(false);
		this.GroupBox1.PerformLayout();
		this.GroupBox2.ResumeLayout(false);
		this.GroupBox2.PerformLayout();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private void Localidades_Load(object sender, EventArgs e)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		comboadicionales.SelectedIndex = 0;
		checked
		{
			try
			{
				string commandText = "SELECT * FROM Localidades";
				Mod_Sentencias.cnn.Open();
				MySqlCommand val = new MySqlCommand();
				MySqlCommand val2 = val;
				val2.CommandType = CommandType.Text;
				val2.CommandText = commandText;
				val2.Connection = Mod_Sentencias.cnn;
				val2 = null;
				MySqlDataAdapter val3 = new MySqlDataAdapter();
				val3.SelectCommand = val;
				((DbDataAdapter)(object)val3).Fill(dataset, "Tabla");
				ListView listView = ListView1;
				listView.Items.Clear();
				listView.Columns.Clear();
				listView.View = View.Details;
				listView.GridLines = true;
				listView.FullRowSelect = true;
				int num = dataset.Tables["tabla"].Columns.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					listView.Columns.Add(dataset.Tables["tabla"].Columns[i].Caption);
				}
				listView = null;
				DataTable dataTable = dataset.Tables["tabla"];
				int num2 = dataTable.Rows.Count - 1;
				for (int j = 0; j <= num2; j++)
				{
					ListViewItem listViewItem = new ListViewItem(dataTable.Rows[j][0].ToString());
					int num3 = dataTable.Columns.Count - 1;
					for (int k = 1; k <= num3; k++)
					{
						listViewItem.SubItems.Add(dataTable.Rows[j][k].ToString());
					}
					ListView1.Items.Add(listViewItem);
				}
				dataTable = null;
				ListView listView2 = ListView1;
				int num4 = dataset.Tables["tabla"].Columns.Count - 1;
				for (int l = 0; l <= num4; l++)
				{
					listView2.AutoResizeColumn(l, ColumnHeaderAutoResizeStyle.ColumnContent);
				}
				listView2 = null;
				Mod_Sentencias.cargar_zonas_combo(combozonas);
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
	}

	private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
	{
		Selected_item();
	}

	private void Selected_item()
	{
		if (ListView1.SelectedItems.Count > 0)
		{
			int index = ListView1.SelectedIndices[0];
			idtxt.Text = ListView1.Items[index].Text;
			localidadtxt.Text = ListView1.Items[index].SubItems[1].Text;
			codigopostaltxt.Text = ListView1.Items[index].SubItems[2].Text;
			combozonas.SelectedIndex = checked((int)Math.Round(Conversions.ToDouble(ListView1.Items[index].SubItems[3].Text) - 1.0));
			comboadicionales.Text = ListView1.Items[index].SubItems[4].Text;
			fechatxt.Text = ListView1.Items[index].SubItems[5].Text;
			usuariotxt.Text = ListView1.Items[index].SubItems[6].Text;
		}
		ListView1.Refresh();
	}

	private void ListView1_ColumnClick(object sender, ColumnClickEventArgs e)
	{
		Mod_Ordenaclumnas.ordenar_columnas(ListView1, RuntimeHelpers.GetObjectValue(sender), e);
	}

	private void nuevobtn_Click(object sender, EventArgs e)
	{
		try
		{
			string sQL = "INSERT INTO Localidades (Localidad, CP, zona, Adicional, fecha, usuario) VALUES ('" + localidadtxt.Text + "' ," + codigopostaltxt.Text + "," + Conversions.ToString(checked(combozonas.SelectedIndex + 1)) + "," + comboadicionales.Text + ",'" + Strings.Format(MyProject.Forms.Form1_Inicio.DateTimePicker1.Value, "yyyyMMdd") + "','" + MyProject.Forms.Form1_Inicio.nombreusuario.Text + "')";
			string sql = "SELECT ID, Localidad , CP , zona  , Adicional , Fecha , Usuario  FROM Localidades";
			Mod_ConeccionBD.BD_Sentencia(sQL);
			Mod_Sentencias.cargar_datos_lv(ListView1, sql, Label2);
			limpiar_datos();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox(ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void guardarbtn_Click(object sender, EventArgs e)
	{
		checked
		{
			try
			{
				string sQL = ("UPDATE Localidades SET Localidad='" + localidadtxt.Text + "' ,CP=" + codigopostaltxt.Text + ",zona=" + Conversions.ToString(combozonas.SelectedIndex + 1) + ",Adicional=" + comboadicionales.Text + ",fecha='" + Strings.Format(MyProject.Forms.Form1_Inicio.DateTimePicker1.Value, "yyyyMMdd") + "',Usuario= '" + MyProject.Forms.Form1_Inicio.nombreusuario.Text + "' WHERE Id= " + idtxt.Text) ?? "";
				string sQL2 = "UPDATE Planchada Set Zona=" + Conversions.ToString(combozonas.SelectedIndex + 1) + ",Adicional=" + comboadicionales.Text + " WHERE CP =" + codigopostaltxt.Text + " AND Fecha='" + Strings.Format(MyProject.Forms.Form1_Inicio.DateTimePicker1.Value, "yyyyMMdd") + "'";
				Mod_ConeccionBD.BD_Sentencia(sQL);
				Mod_ConeccionBD.BD_Sentencia(sQL2);
				limpiar_datos();
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

	private void borrarbtn_Click(object sender, EventArgs e)
	{
		try
		{
			string sQL = ("DELETE FROM Localidades WHERE Id= " + idtxt.Text) ?? "";
			Mod_ConeccionBD.BD_Sentencia(sQL);
			Mod_Sentencias.cargar_datos_lv(ListView1, "Localidades", Label2);
			limpiar_datos();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void limpiar_datos()
	{
		idtxt.Text = Conversions.ToString(0);
		localidadtxt.Text = "";
		codigopostaltxt.Text = "";
		zonatxt.Text = "";
		combozonas.Text = Conversions.ToString(0);
		adicionaltxt.Text = Conversions.ToString(0);
		comboadicionales.Text = Conversions.ToString(0);
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		string sql = "select * from localidades";
		string destino = "Localidades";
		try
		{
			Mod_Exportar.exp_excel(sql, destino);
			Interaction.MsgBox("Localidades exportadas");
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox(ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void TextBox1_TextChanged(object sender, EventArgs e)
	{
		checked
		{
			if (Operators.CompareString(TextBox1.Text, "", TextCompare: true) != 0)
			{
				DataRow[] array = dataset.Tables["Tabla"].Select("CP  LIKE '" + TextBox1.Text + "%'");
				if (array.Length <= 0)
				{
					return;
				}
				ListView1.Items.Clear();
				DataRow[] array2 = array;
				foreach (DataRow dataRow in array2)
				{
					ListViewItem listViewItem = new ListViewItem(dataRow[0].ToString());
					int num = dataset.Tables["Tabla"].Columns.Count - 1;
					for (int j = 1; j <= num; j++)
					{
						listViewItem.SubItems.Add(dataRow[j].ToString());
					}
					ListView1.Items.Add(listViewItem);
				}
				return;
			}
			ListView listView = ListView1;
			listView.Items.Clear();
			listView.Columns.Clear();
			listView.View = View.Details;
			listView.GridLines = true;
			listView.FullRowSelect = true;
			int num2 = dataset.Tables["tabla"].Columns.Count - 1;
			for (int k = 0; k <= num2; k++)
			{
				listView.Columns.Add(dataset.Tables["tabla"].Columns[k].Caption);
			}
			listView = null;
			DataTable dataTable = dataset.Tables["tabla"];
			int num3 = dataTable.Rows.Count - 1;
			for (int l = 0; l <= num3; l++)
			{
				ListViewItem listViewItem2 = new ListViewItem(dataTable.Rows[l][0].ToString());
				int num4 = dataTable.Columns.Count - 1;
				for (int m = 1; m <= num4; m++)
				{
					listViewItem2.SubItems.Add(dataTable.Rows[l][m].ToString());
				}
				ListView1.Items.Add(listViewItem2);
			}
			dataTable = null;
			ListView listView2 = ListView1;
			int num5 = dataset.Tables["tabla"].Columns.Count - 1;
			for (int n = 0; n <= num5; n++)
			{
				listView2.AutoResizeColumn(n, ColumnHeaderAutoResizeStyle.ColumnContent);
			}
			listView2 = null;
		}
	}

	private void TextBox2_TextChanged(object sender, EventArgs e)
	{
		checked
		{
			if (Operators.CompareString(TextBox2.Text, "", TextCompare: true) != 0)
			{
				DataRow[] array = dataset.Tables["Tabla"].Select("Localidad  LIKE '" + TextBox2.Text + "%'");
				if (array.Length <= 0)
				{
					return;
				}
				ListView1.Items.Clear();
				DataRow[] array2 = array;
				foreach (DataRow dataRow in array2)
				{
					ListViewItem listViewItem = new ListViewItem(dataRow[0].ToString());
					int num = dataset.Tables["Tabla"].Columns.Count - 1;
					for (int j = 1; j <= num; j++)
					{
						listViewItem.SubItems.Add(dataRow[j].ToString());
					}
					ListView1.Items.Add(listViewItem);
				}
				return;
			}
			ListView listView = ListView1;
			listView.Items.Clear();
			listView.Columns.Clear();
			listView.View = View.Details;
			listView.GridLines = true;
			listView.FullRowSelect = true;
			int num2 = dataset.Tables["tabla"].Columns.Count - 1;
			for (int k = 0; k <= num2; k++)
			{
				listView.Columns.Add(dataset.Tables["tabla"].Columns[k].Caption);
			}
			listView = null;
			DataTable dataTable = dataset.Tables["tabla"];
			int num3 = dataTable.Rows.Count - 1;
			for (int l = 0; l <= num3; l++)
			{
				ListViewItem listViewItem2 = new ListViewItem(dataTable.Rows[l][0].ToString());
				int num4 = dataTable.Columns.Count - 1;
				for (int m = 1; m <= num4; m++)
				{
					listViewItem2.SubItems.Add(dataTable.Rows[l][m].ToString());
				}
				ListView1.Items.Add(listViewItem2);
			}
			dataTable = null;
			ListView listView2 = ListView1;
			int num5 = dataset.Tables["tabla"].Columns.Count - 1;
			for (int n = 0; n <= num5; n++)
			{
				listView2.AutoResizeColumn(n, ColumnHeaderAutoResizeStyle.ColumnContent);
			}
			listView2 = null;
		}
	}
}
