using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Hermes.My;
using Hermes.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace Hermes;

[DesignerGenerated]
public class masivoEtiquetas : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("PrintDocument1")]
	private PrintDocument _PrintDocument1;

	private string Et_bultos;

	private string Et_remitos;

	private string Et_cp;

	private string Et_localidad;

	private string Et_zona;

	private string Et_des;

	private string Et_qrCode;

	[field: AccessedThroughProperty("DateTimePicker1")]
	internal virtual DateTimePicker DateTimePicker1
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

	internal virtual PrintDocument PrintDocument1
	{
		[CompilerGenerated]
		get
		{
			return _PrintDocument1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			PrintPageEventHandler value2 = PrintDocument1_PrintPage;
			PrintDocument printDocument = _PrintDocument1;
			if (printDocument != null)
			{
				printDocument.PrintPage -= value2;
			}
			_PrintDocument1 = value;
			printDocument = _PrintDocument1;
			if (printDocument != null)
			{
				printDocument.PrintPage += value2;
			}
		}
	}

	[field: AccessedThroughProperty("PrintDialog1")]
	internal virtual PrintDialog PrintDialog1
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

	[field: AccessedThroughProperty("ComboBox1")]
	internal virtual ComboBox ComboBox1
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

	public masivoEtiquetas()
	{
		base.Load += masivoEtiquetas_Load;
		Et_bultos = Conversions.ToString(0);
		Et_remitos = Conversions.ToString(0);
		Et_cp = string.Empty;
		Et_localidad = string.Empty;
		Et_zona = string.Empty;
		Et_des = string.Empty;
		Et_qrCode = string.Empty;
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
		this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
		this.Button1 = new System.Windows.Forms.Button();
		this.PrintDocument1 = new System.Drawing.Printing.PrintDocument();
		this.PrintDialog1 = new System.Windows.Forms.PrintDialog();
		this.Label1 = new System.Windows.Forms.Label();
		this.ComboBox1 = new System.Windows.Forms.ComboBox();
		this.Label2 = new System.Windows.Forms.Label();
		base.SuspendLayout();
		this.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
		this.DateTimePicker1.Location = new System.Drawing.Point(98, 73);
		this.DateTimePicker1.Name = "DateTimePicker1";
		this.DateTimePicker1.Size = new System.Drawing.Size(97, 20);
		this.DateTimePicker1.TabIndex = 0;
		this.Button1.Location = new System.Drawing.Point(341, 73);
		this.Button1.Name = "Button1";
		this.Button1.Size = new System.Drawing.Size(75, 23);
		this.Button1.TabIndex = 1;
		this.Button1.Text = "Imprimir";
		this.Button1.UseVisualStyleBackColor = true;
		this.PrintDialog1.UseEXDialog = true;
		this.Label1.AutoSize = true;
		this.Label1.Location = new System.Drawing.Point(12, 78);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(80, 13);
		this.Label1.TabIndex = 2;
		this.Label1.Text = "Fecha Entrega:";
		this.ComboBox1.FormattingEnabled = true;
		this.ComboBox1.Location = new System.Drawing.Point(12, 44);
		this.ComboBox1.Name = "ComboBox1";
		this.ComboBox1.Size = new System.Drawing.Size(404, 21);
		this.ComboBox1.TabIndex = 3;
		this.Label2.AutoSize = true;
		this.Label2.Location = new System.Drawing.Point(12, 18);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(42, 13);
		this.Label2.TabIndex = 4;
		this.Label2.Text = "Cliente:";
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(432, 104);
		base.Controls.Add(this.Label2);
		base.Controls.Add(this.ComboBox1);
		base.Controls.Add(this.Label1);
		base.Controls.Add(this.Button1);
		base.Controls.Add(this.DateTimePicker1);
		base.Name = "masivoEtiquetas";
		this.Text = "masivoEtiquetas";
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected O, but got Unknown
		checked
		{
			try
			{
				if (Operators.ConditionalCompareObjectNotEqual(ComboBox1.SelectedItem, "", TextCompare: true))
				{
					string right = Strings.Format(DateTimePicker1.Value, "yyyyMMdd");
					string sql = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("SELECT id_envio, cliente, D_fecha FROM etransenvios WHERE cliente ='", ComboBox1.SelectedItem), "' AND D_fecha='"), right), "'"));
					DataTable dataTable = (DataTable)Mod_Sentencias.data(sql);
					int num = dataTable.Rows.Count - 1;
					for (int i = 0; i <= num; i++)
					{
						string text = Conversions.ToString(dataTable.Rows[i]["id_envio"]);
						DataTable dataTable2 = new DataTable("x1");
						string text2 = "Select D_cp,D_localidad,Bultos, (Select (SELECT z.Descripcion FROM Zonas z WHERE z.Zona=l.zona) AS Descripcion from localidades l where l.CP=e.D_cp) AS zonaD From etransEnvios e WHERE e.id_envio='" + text + "'";
						MySqlDataAdapter val = new MySqlDataAdapter(text2, Mod_Sentencias.cnn);
						DataSet dataSet = new DataSet();
						((DbDataAdapter)(object)val).Fill(dataTable2);
						Et_remitos = text;
						Et_cp = Conversions.ToString(Operators.ConcatenateObject("Cp: ", dataTable2.Rows[0]["D_cp"]));
						Et_localidad = Conversions.ToString(Operators.ConcatenateObject("Loc: ", dataTable2.Rows[0]["D_localidad"]));
						Et_des = "N° Trans: ";
						Et_zona = Conversions.ToString(Operators.ConcatenateObject("Zona: ", dataTable2.Rows[0]["zonaD"]));
						int num2 = Conversions.ToInteger(dataTable2.Rows[0]["Bultos"]);
						for (int j = 1; j <= num2; j++)
						{
							Et_bultos = Conversions.ToString(Operators.ConcatenateObject("Bulto: " + Conversions.ToString(j) + "/", dataTable2.Rows[0]["Bultos"]));
							Et_qrCode = text + Conversions.ToString(j);
							PrintDocument1.Print();
							PrintDocument1.Dispose();
						}
					}
				}
				else
				{
					Interaction.MsgBox("Selecciona un Cliente");
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void PrintDocument1_PrintPage(object sender, PrintPageEventArgs e)
	{
		Font font = new Font("Arial", 6.75f, FontStyle.Italic, GraphicsUnit.Point, 0);
		Font font2 = new Font("Arial", 8.75f, FontStyle.Italic, GraphicsUnit.Point, 0);
		Font font3 = new Font("Arial", 10.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		Font font4 = new Font("Arial", 24.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		int num = 0;
		checked
		{
			int num2 = 0 + MySettingsProperty.Settings.pHvalor;
			int num3 = 0 + MySettingsProperty.Settings.pVvalor;
			string text = MyProject.Forms.Form1_Inicio.nombreusuario.Text;
			e.Graphics.DrawLine(Pens.Brown, num2 + 2, num3 + 5, num2 + 300, num3 + 5);
			e.Graphics.DrawLine(Pens.Brown, num2 + 2, num3 + 5, num2 + 2, num3 + 185);
			e.Graphics.DrawLine(Pens.Brown, num2 + 300, num3 + 5, num2 + 300, num3 + 185);
			e.Graphics.DrawLine(Pens.Brown, num2 + 2, num3 + 185, num2 + 300, num3 + 185);
			Image image = (Image)Mod_QR.qrcodegen(Et_qrCode);
			Image etrans = Resources.etrans2;
			e.Graphics.DrawImage(image, num2 + 10, num3 + 70);
			e.Graphics.DrawImage(etrans, num2 + 10, num3 + 10);
			int num4 = default(int);
			e.Graphics.DrawString(Et_des, font3, Brushes.Black, num2 + 150, num3 + num4 + 10);
			e.Graphics.DrawString(Et_remitos, font4, Brushes.Black, num2 + 150, num3 + num4 + 30);
			e.Graphics.DrawString(Et_bultos, font3, Brushes.Black, num2 + 110, num3 + num4 + 70);
			e.Graphics.DrawString(Et_localidad, font3, Brushes.Black, num2 + 110, num3 + num4 + 90);
			e.Graphics.DrawString(Et_cp, font3, Brushes.Black, num2 + 110, num3 + num4 + 110);
			e.Graphics.DrawString(Et_zona, font3, Brushes.Black, num2 + 110, num3 + num4 + 130);
		}
	}

	private void masivoEtiquetas_Load(object sender, EventArgs e)
	{
		string sql = "select distinct cliente from etransenvios order by cliente asc";
		Mod_Sentencias.cargar_cbb(ComboBox1, sql);
	}
}
