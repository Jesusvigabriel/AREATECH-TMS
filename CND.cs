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
public class CND : Form
{
	private IContainer components;

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
	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	private string fecha1;

	[field: AccessedThroughProperty("Panel1")]
	internal virtual Panel Panel1
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

	[field: AccessedThroughProperty("Panel2")]
	internal virtual Panel Panel2
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

	[field: AccessedThroughProperty("TextBox1")]
	internal virtual TextBox TextBox1
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

	[field: AccessedThroughProperty("Comprobante")]
	internal virtual ColumnHeader Comprobante
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

	[field: AccessedThroughProperty("Diferida")]
	internal virtual ColumnHeader Diferida
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Atraso")]
	internal virtual ColumnHeader Atraso
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Observaciones")]
	internal virtual ColumnHeader Observaciones
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Declarado")]
	internal virtual ColumnHeader Declarado
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Bultos")]
	internal virtual ColumnHeader Bultos
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Kilos")]
	internal virtual ColumnHeader Kilos
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Volumen")]
	internal virtual ColumnHeader Volumen
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Flete")]
	internal virtual ColumnHeader Flete
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CP")]
	internal virtual ColumnHeader CP
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

	[field: AccessedThroughProperty("Subcuenta")]
	internal virtual ColumnHeader Subcuenta
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

	[field: AccessedThroughProperty("Remito")]
	internal virtual ColumnHeader Remito
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Adicional")]
	internal virtual ColumnHeader Adicional
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Prioridad")]
	internal virtual ColumnHeader Prioridad
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public CND()
	{
		base.Load += CND_Load;
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
		this.Panel1 = new System.Windows.Forms.Panel();
		this.Label4 = new System.Windows.Forms.Label();
		this.Label3 = new System.Windows.Forms.Label();
		this.Label2 = new System.Windows.Forms.Label();
		this.Label1 = new System.Windows.Forms.Label();
		this.ComboBox1 = new System.Windows.Forms.ComboBox();
		this.Panel2 = new System.Windows.Forms.Panel();
		this.ListView1 = new System.Windows.Forms.ListView();
		this.Panel3 = new System.Windows.Forms.Panel();
		this.Button1 = new System.Windows.Forms.Button();
		this.Label13 = new System.Windows.Forms.Label();
		this.Label12 = new System.Windows.Forms.Label();
		this.Label11 = new System.Windows.Forms.Label();
		this.TextBox5 = new System.Windows.Forms.TextBox();
		this.TextBox4 = new System.Windows.Forms.TextBox();
		this.TextBox3 = new System.Windows.Forms.TextBox();
		this.TextBox2 = new System.Windows.Forms.TextBox();
		this.TextBox1 = new System.Windows.Forms.TextBox();
		this.Label10 = new System.Windows.Forms.Label();
		this.Label9 = new System.Windows.Forms.Label();
		this.Label8 = new System.Windows.Forms.Label();
		this.Label7 = new System.Windows.Forms.Label();
		this.Label6 = new System.Windows.Forms.Label();
		this.Label5 = new System.Windows.Forms.Label();
		this.Comprobante = new System.Windows.Forms.ColumnHeader();
		this.Cliente = new System.Windows.Forms.ColumnHeader();
		this.Destino = new System.Windows.Forms.ColumnHeader();
		this.Domicilio = new System.Windows.Forms.ColumnHeader();
		this.Diferida = new System.Windows.Forms.ColumnHeader();
		this.Atraso = new System.Windows.Forms.ColumnHeader();
		this.Observaciones = new System.Windows.Forms.ColumnHeader();
		this.Declarado = new System.Windows.Forms.ColumnHeader();
		this.Bultos = new System.Windows.Forms.ColumnHeader();
		this.Kilos = new System.Windows.Forms.ColumnHeader();
		this.Volumen = new System.Windows.Forms.ColumnHeader();
		this.Flete = new System.Windows.Forms.ColumnHeader();
		this.CP = new System.Windows.Forms.ColumnHeader();
		this.Localidad = new System.Windows.Forms.ColumnHeader();
		this.Subcuenta = new System.Windows.Forms.ColumnHeader();
		this.Eventual = new System.Windows.Forms.ColumnHeader();
		this.Remito = new System.Windows.Forms.ColumnHeader();
		this.Adicional = new System.Windows.Forms.ColumnHeader();
		this.Prioridad = new System.Windows.Forms.ColumnHeader();
		this.Panel1.SuspendLayout();
		this.Panel2.SuspendLayout();
		this.Panel3.SuspendLayout();
		base.SuspendLayout();
		this.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.Panel1.Controls.Add(this.Label4);
		this.Panel1.Controls.Add(this.Label3);
		this.Panel1.Controls.Add(this.Label2);
		this.Panel1.Controls.Add(this.Label1);
		this.Panel1.Controls.Add(this.ComboBox1);
		this.Panel1.Location = new System.Drawing.Point(12, 12);
		this.Panel1.Name = "Panel1";
		this.Panel1.Size = new System.Drawing.Size(852, 42);
		this.Panel1.TabIndex = 0;
		this.Label4.AutoSize = true;
		this.Label4.Location = new System.Drawing.Point(763, 14);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(39, 13);
		this.Label4.TabIndex = 4;
		this.Label4.Text = "Label4";
		this.Label3.AutoSize = true;
		this.Label3.Location = new System.Drawing.Point(660, 14);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(97, 13);
		this.Label3.TabIndex = 3;
		this.Label3.Text = "Cantidad de Guias:";
		this.Label2.AutoSize = true;
		this.Label2.Location = new System.Drawing.Point(239, 14);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(39, 13);
		this.Label2.TabIndex = 2;
		this.Label2.Text = "Label2";
		this.Label1.AutoSize = true;
		this.Label1.Location = new System.Drawing.Point(140, 14);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(93, 13);
		this.Label1.TabIndex = 1;
		this.Label1.Text = "Cantidad de CND:";
		this.ComboBox1.FormattingEnabled = true;
		this.ComboBox1.Location = new System.Drawing.Point(13, 11);
		this.ComboBox1.Name = "ComboBox1";
		this.ComboBox1.Size = new System.Drawing.Size(121, 21);
		this.ComboBox1.TabIndex = 0;
		this.Panel2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.Panel2.Controls.Add(this.ListView1);
		this.Panel2.Location = new System.Drawing.Point(12, 60);
		this.Panel2.Name = "Panel2";
		this.Panel2.Size = new System.Drawing.Size(852, 268);
		this.Panel2.TabIndex = 1;
		this.ListView1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.ListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[19]
		{
			this.Comprobante, this.Cliente, this.Destino, this.Domicilio, this.Diferida, this.Atraso, this.Observaciones, this.Declarado, this.Bultos, this.Kilos,
			this.Volumen, this.Flete, this.CP, this.Localidad, this.Subcuenta, this.Eventual, this.Remito, this.Adicional, this.Prioridad
		});
		this.ListView1.FullRowSelect = true;
		this.ListView1.GridLines = true;
		this.ListView1.Location = new System.Drawing.Point(3, 3);
		this.ListView1.Name = "ListView1";
		this.ListView1.Size = new System.Drawing.Size(846, 262);
		this.ListView1.TabIndex = 0;
		this.ListView1.UseCompatibleStateImageBehavior = false;
		this.ListView1.View = System.Windows.Forms.View.Details;
		this.Panel3.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.Panel3.Controls.Add(this.Button1);
		this.Panel3.Controls.Add(this.Label13);
		this.Panel3.Controls.Add(this.Label12);
		this.Panel3.Controls.Add(this.Label11);
		this.Panel3.Controls.Add(this.TextBox5);
		this.Panel3.Controls.Add(this.TextBox4);
		this.Panel3.Controls.Add(this.TextBox3);
		this.Panel3.Controls.Add(this.TextBox2);
		this.Panel3.Controls.Add(this.TextBox1);
		this.Panel3.Controls.Add(this.Label10);
		this.Panel3.Controls.Add(this.Label9);
		this.Panel3.Controls.Add(this.Label8);
		this.Panel3.Controls.Add(this.Label7);
		this.Panel3.Controls.Add(this.Label6);
		this.Panel3.Controls.Add(this.Label5);
		this.Panel3.Location = new System.Drawing.Point(12, 334);
		this.Panel3.Name = "Panel3";
		this.Panel3.Size = new System.Drawing.Size(852, 100);
		this.Panel3.TabIndex = 2;
		this.Button1.Location = new System.Drawing.Point(766, 68);
		this.Button1.Name = "Button1";
		this.Button1.Size = new System.Drawing.Size(75, 23);
		this.Button1.TabIndex = 14;
		this.Button1.Text = "Button1";
		this.Button1.UseVisualStyleBackColor = true;
		this.Label13.AutoSize = true;
		this.Label13.Location = new System.Drawing.Point(626, 31);
		this.Label13.Name = "Label13";
		this.Label13.Size = new System.Drawing.Size(45, 13);
		this.Label13.TabIndex = 13;
		this.Label13.Text = "Label13";
		this.Label12.AutoSize = true;
		this.Label12.Location = new System.Drawing.Point(564, 31);
		this.Label12.Name = "Label12";
		this.Label12.Size = new System.Drawing.Size(43, 13);
		this.Label12.TabIndex = 12;
		this.Label12.Text = "Estado:";
		this.Label11.AutoSize = true;
		this.Label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label11.ForeColor = System.Drawing.Color.Red;
		this.Label11.Location = new System.Drawing.Point(10, 62);
		this.Label11.Name = "Label11";
		this.Label11.Size = new System.Drawing.Size(92, 18);
		this.Label11.TabIndex = 11;
		this.Label11.Text = "CUSTODIA";
		this.TextBox5.Location = new System.Drawing.Point(437, 28);
		this.TextBox5.Name = "TextBox5";
		this.TextBox5.Size = new System.Drawing.Size(100, 20);
		this.TextBox5.TabIndex = 10;
		this.TextBox4.Location = new System.Drawing.Point(331, 28);
		this.TextBox4.Name = "TextBox4";
		this.TextBox4.Size = new System.Drawing.Size(100, 20);
		this.TextBox4.TabIndex = 9;
		this.TextBox3.Location = new System.Drawing.Point(225, 28);
		this.TextBox3.Name = "TextBox3";
		this.TextBox3.Size = new System.Drawing.Size(100, 20);
		this.TextBox3.TabIndex = 8;
		this.TextBox2.Location = new System.Drawing.Point(119, 28);
		this.TextBox2.Name = "TextBox2";
		this.TextBox2.Size = new System.Drawing.Size(100, 20);
		this.TextBox2.TabIndex = 7;
		this.TextBox1.Location = new System.Drawing.Point(13, 28);
		this.TextBox1.Name = "TextBox1";
		this.TextBox1.Size = new System.Drawing.Size(100, 20);
		this.TextBox1.TabIndex = 6;
		this.Label10.AutoSize = true;
		this.Label10.Location = new System.Drawing.Point(562, 68);
		this.Label10.Name = "Label10";
		this.Label10.Size = new System.Drawing.Size(45, 13);
		this.Label10.TabIndex = 5;
		this.Label10.Text = "Label10";
		this.Label9.AutoSize = true;
		this.Label9.Location = new System.Drawing.Point(434, 9);
		this.Label9.Name = "Label9";
		this.Label9.Size = new System.Drawing.Size(33, 13);
		this.Label9.TabIndex = 4;
		this.Label9.Text = "Flete:";
		this.Label8.AutoSize = true;
		this.Label8.Location = new System.Drawing.Point(328, 9);
		this.Label8.Name = "Label8";
		this.Label8.Size = new System.Drawing.Size(51, 13);
		this.Label8.TabIndex = 3;
		this.Label8.Text = "Volumen:";
		this.Label7.AutoSize = true;
		this.Label7.Location = new System.Drawing.Point(222, 9);
		this.Label7.Name = "Label7";
		this.Label7.Size = new System.Drawing.Size(34, 13);
		this.Label7.TabIndex = 2;
		this.Label7.Text = "Peso:";
		this.Label6.AutoSize = true;
		this.Label6.Location = new System.Drawing.Point(116, 9);
		this.Label6.Name = "Label6";
		this.Label6.Size = new System.Drawing.Size(39, 13);
		this.Label6.TabIndex = 1;
		this.Label6.Text = "Bultos:";
		this.Label5.AutoSize = true;
		this.Label5.Location = new System.Drawing.Point(10, 9);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(86, 13);
		this.Label5.TabIndex = 0;
		this.Label5.Text = "Valor Declarado:";
		this.Comprobante.Text = "Comprobante";
		this.Comprobante.Width = 90;
		this.Cliente.Text = "Cliente";
		this.Cliente.Width = 130;
		this.Destino.Text = "Destino";
		this.Destino.Width = 150;
		this.Domicilio.Text = "Domicilio";
		this.Domicilio.Width = 150;
		this.Diferida.Text = "Diferida";
		this.Diferida.Width = 100;
		this.Atraso.Text = "Atraso";
		this.Observaciones.Text = "Observaciones";
		this.Observaciones.Width = 160;
		this.Declarado.Text = "Declarado";
		this.Declarado.Width = 70;
		this.Bultos.Text = "Bultos";
		this.Bultos.Width = 50;
		this.Kilos.Text = "Kilos";
		this.Kilos.Width = 70;
		this.Volumen.Text = "Volumen";
		this.Volumen.Width = 50;
		this.Flete.Text = "Flete";
		this.Flete.Width = 70;
		this.CP.Text = "CP";
		this.CP.Width = 40;
		this.Localidad.Text = "Localidad";
		this.Localidad.Width = 90;
		this.Subcuenta.Text = "Sub";
		this.Eventual.Text = "Eventual";
		this.Eventual.Width = 50;
		this.Remito.Text = "Remito";
		this.Remito.Width = 50;
		this.Adicional.Text = "Adicional";
		this.Adicional.Width = 50;
		this.Prioridad.Text = "Prioridad";
		this.Prioridad.Width = 50;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(876, 453);
		base.Controls.Add(this.Panel3);
		base.Controls.Add(this.Panel2);
		base.Controls.Add(this.Panel1);
		base.Name = "CND";
		this.Text = "CND";
		this.Panel1.ResumeLayout(false);
		this.Panel1.PerformLayout();
		this.Panel2.ResumeLayout(false);
		this.Panel3.ResumeLayout(false);
		this.Panel3.PerformLayout();
		base.ResumeLayout(false);
	}

	private void CND_Load(object sender, EventArgs e)
	{
		Button1.Text = "Salir";
		cargar_cnd();
		sumas_cnd();
		contar_cnd();
		if (ComboBox1.Items.Count > 0)
		{
			ComboBox1.SelectedIndex = 0;
		}
		Refresh();
		base.WindowState = FormWindowState.Maximized;
	}

	private void sumas_cnd()
	{
		double num = 0.0;
		double num2 = 0.0;
		double num3 = 0.0;
		double num4 = 0.0;
		double num5 = 0.0;
		string text = MySettingsProperty.Settings.custodia.ToString();
		Label11.Text = text;
		Label4.Text = Conversions.ToString(ListView1.Items.Count);
		checked
		{
			int num6 = ListView1.Items.Count - 1;
			for (int i = 0; i <= num6; i++)
			{
				num += Conversions.ToDouble(ListView1.Items[i].SubItems[7].Text);
			}
			int num7 = ListView1.Items.Count - 1;
			for (int j = 0; j <= num7; j++)
			{
				num2 += Conversions.ToDouble(ListView1.Items[j].SubItems[8].Text);
			}
			int num8 = ListView1.Items.Count - 1;
			for (int k = 0; k <= num8; k++)
			{
				num3 += Conversions.ToDouble(ListView1.Items[k].SubItems[9].Text);
			}
			int num9 = ListView1.Items.Count - 1;
			for (int l = 0; l <= num9; l++)
			{
				num4 += Conversions.ToDouble(ListView1.Items[l].SubItems[10].Text);
			}
			int num10 = ListView1.Items.Count - 1;
			for (int m = 0; m <= num10; m++)
			{
				num5 += Conversions.ToDouble(ListView1.Items[m].SubItems[11].Text);
			}
			if (num >= Conversions.ToDouble(Label11.Text))
			{
				Label11.Text = "CUSTODIA";
			}
			else
			{
				Label11.Text = "";
			}
			TextBox1.Text = Conversions.ToString(num);
			TextBox2.Text = Conversions.ToString(num2);
			TextBox3.Text = Conversions.ToString(num3);
			TextBox4.Text = Conversions.ToString(num4);
			TextBox5.Text = Conversions.ToString(num5);
		}
	}

	private void cargar_cnd()
	{
		string sql = "SELECT DISTINCT Eventual FROM Planchada Where sub>='30' AND sub<'40' AND Fecha='" + fecha1 + "'";
		Mod_Sentencias.cargar_eventuales_combo(sql, ComboBox1, Label2);
		ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
	}

	private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
	{
		Label13.Text = "";
		string sql = "SELECT Comprobante,Cliente,Destino,Domicilio,Diferida,Atraso,Observaciones,Declarado,Bultos,Kilos,Volumen,Flete,CP,Localidad,Sub,Eventual,Remitos,Adicional,Prioridad From Planchada WHERE Eventual = " + ComboBox1.Text + " AND Fecha='" + fecha1 + "'";
		Mod_Sentencias.cargar_datos_lv(ListView1, sql, Label13);
		sumas_cnd();
	}

	private void contar_cnd()
	{
		string sql = "SELECT DISTINCT Eventual FROM Planchada where Sub='30'AND Fecha='" + fecha1 + "' UNION ALL SELECT DISTINCT Eventual FROM Planchada where Sub='31'AND Fecha='" + fecha1 + "'";
		Mod_Sentencias.contar_items(sql, Label2);
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
	{
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		if (ListView1.SelectedItems.Count > 0)
		{
			DataTable dataTable = new DataTable("x");
			string text = "SELECT * FROM Planchada where Comprobante='" + ListView1.SelectedItems[0].Text + "' AND Fecha='" + fecha1 + "'";
			MySqlDataAdapter val = new MySqlDataAdapter(text, Mod_Sentencias.cnn);
			((DbDataAdapter)(object)val).Fill(dataTable);
			if (Conversions.ToDouble(dataTable.Rows[0]["Chofer"].ToString()) > 0.0)
			{
				Label13.Text = "Despachado";
			}
			else
			{
				Label13.Text = "En Planchada";
			}
		}
	}
}
