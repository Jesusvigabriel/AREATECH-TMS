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
public class NuevoProducto_Form : Form
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

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("nombreEmpresaLbl")]
	internal virtual Label nombreEmpresaLbl
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

	[field: AccessedThroughProperty("numeroEmpresaLbl")]
	internal virtual Label numeroEmpresaLbl
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

	[field: AccessedThroughProperty("Label4")]
	internal virtual Label Label4
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

	[field: AccessedThroughProperty("TextBox2")]
	internal virtual TextBox TextBox2
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

	[field: AccessedThroughProperty("TextBox3")]
	internal virtual TextBox TextBox3
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

	[field: AccessedThroughProperty("TextBox4")]
	internal virtual TextBox TextBox4
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

	[field: AccessedThroughProperty("TextBox5")]
	internal virtual TextBox TextBox5
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

	[field: AccessedThroughProperty("TextBox6")]
	internal virtual TextBox TextBox6
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

	[field: AccessedThroughProperty("ComboBox1")]
	internal virtual ComboBox ComboBox1
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

	[field: AccessedThroughProperty("TextBox7")]
	internal virtual TextBox TextBox7
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

	[field: AccessedThroughProperty("GroupBox1")]
	internal virtual GroupBox GroupBox1
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

	[field: AccessedThroughProperty("CheckBox1")]
	internal virtual CheckBox CheckBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public NuevoProducto_Form()
	{
		base.Load += NuevoProducto_Form_Load;
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
		this.nombreEmpresaLbl = new System.Windows.Forms.Label();
		this.Label2 = new System.Windows.Forms.Label();
		this.numeroEmpresaLbl = new System.Windows.Forms.Label();
		this.Label3 = new System.Windows.Forms.Label();
		this.Label4 = new System.Windows.Forms.Label();
		this.TextBox1 = new System.Windows.Forms.TextBox();
		this.TextBox2 = new System.Windows.Forms.TextBox();
		this.Label5 = new System.Windows.Forms.Label();
		this.TextBox3 = new System.Windows.Forms.TextBox();
		this.Label6 = new System.Windows.Forms.Label();
		this.TextBox4 = new System.Windows.Forms.TextBox();
		this.Label7 = new System.Windows.Forms.Label();
		this.TextBox5 = new System.Windows.Forms.TextBox();
		this.Label8 = new System.Windows.Forms.Label();
		this.TextBox6 = new System.Windows.Forms.TextBox();
		this.Label9 = new System.Windows.Forms.Label();
		this.ComboBox1 = new System.Windows.Forms.ComboBox();
		this.Label10 = new System.Windows.Forms.Label();
		this.TextBox7 = new System.Windows.Forms.TextBox();
		this.Button1 = new System.Windows.Forms.Button();
		this.Button2 = new System.Windows.Forms.Button();
		this.GroupBox1 = new System.Windows.Forms.GroupBox();
		this.GroupBox2 = new System.Windows.Forms.GroupBox();
		this.CheckBox1 = new System.Windows.Forms.CheckBox();
		this.GroupBox1.SuspendLayout();
		this.GroupBox2.SuspendLayout();
		base.SuspendLayout();
		this.Label1.AutoSize = true;
		this.Label1.Location = new System.Drawing.Point(20, 33);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(51, 13);
		this.Label1.TabIndex = 0;
		this.Label1.Text = "Empresa:";
		this.nombreEmpresaLbl.AutoSize = true;
		this.nombreEmpresaLbl.Location = new System.Drawing.Point(93, 33);
		this.nombreEmpresaLbl.Name = "nombreEmpresaLbl";
		this.nombreEmpresaLbl.Size = new System.Drawing.Size(85, 13);
		this.nombreEmpresaLbl.TabIndex = 1;
		this.nombreEmpresaLbl.Text = "EmpresaNombre";
		this.Label2.AutoSize = true;
		this.Label2.Location = new System.Drawing.Point(432, 33);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(47, 13);
		this.Label2.TabIndex = 2;
		this.Label2.Text = "Número:";
		this.numeroEmpresaLbl.AutoSize = true;
		this.numeroEmpresaLbl.Location = new System.Drawing.Point(505, 33);
		this.numeroEmpresaLbl.Name = "numeroEmpresaLbl";
		this.numeroEmpresaLbl.Size = new System.Drawing.Size(44, 13);
		this.numeroEmpresaLbl.TabIndex = 3;
		this.numeroEmpresaLbl.Text = "Numero";
		this.Label3.AutoSize = true;
		this.Label3.Location = new System.Drawing.Point(17, 32);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(79, 13);
		this.Label3.TabIndex = 4;
		this.Label3.Text = "Codigo Interno:";
		this.Label4.AutoSize = true;
		this.Label4.Location = new System.Drawing.Point(17, 61);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(66, 13);
		this.Label4.TabIndex = 5;
		this.Label4.Text = "Descripción:";
		this.TextBox1.Location = new System.Drawing.Point(102, 29);
		this.TextBox1.Name = "TextBox1";
		this.TextBox1.Size = new System.Drawing.Size(162, 20);
		this.TextBox1.TabIndex = 6;
		this.TextBox2.Location = new System.Drawing.Point(102, 58);
		this.TextBox2.Name = "TextBox2";
		this.TextBox2.Size = new System.Drawing.Size(561, 20);
		this.TextBox2.TabIndex = 7;
		this.Label5.AutoSize = true;
		this.Label5.Location = new System.Drawing.Point(17, 91);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(28, 13);
		this.Label5.TabIndex = 8;
		this.Label5.Text = "Alto:";
		this.TextBox3.Location = new System.Drawing.Point(51, 88);
		this.TextBox3.Name = "TextBox3";
		this.TextBox3.Size = new System.Drawing.Size(116, 20);
		this.TextBox3.TabIndex = 9;
		this.TextBox3.Text = "0.01";
		this.Label6.AutoSize = true;
		this.Label6.Location = new System.Drawing.Point(173, 91);
		this.Label6.Name = "Label6";
		this.Label6.Size = new System.Drawing.Size(37, 13);
		this.Label6.TabIndex = 10;
		this.Label6.Text = "Largo:";
		this.TextBox4.Location = new System.Drawing.Point(216, 88);
		this.TextBox4.Name = "TextBox4";
		this.TextBox4.Size = new System.Drawing.Size(116, 20);
		this.TextBox4.TabIndex = 11;
		this.TextBox4.Text = "0.01";
		this.Label7.AutoSize = true;
		this.Label7.Location = new System.Drawing.Point(338, 91);
		this.Label7.Name = "Label7";
		this.Label7.Size = new System.Drawing.Size(41, 13);
		this.Label7.TabIndex = 12;
		this.Label7.Text = "Ancho:";
		this.TextBox5.Location = new System.Drawing.Point(385, 88);
		this.TextBox5.Name = "TextBox5";
		this.TextBox5.Size = new System.Drawing.Size(116, 20);
		this.TextBox5.TabIndex = 13;
		this.TextBox5.Text = "0.01";
		this.Label8.AutoSize = true;
		this.Label8.Location = new System.Drawing.Point(507, 91);
		this.Label8.Name = "Label8";
		this.Label8.Size = new System.Drawing.Size(34, 13);
		this.Label8.TabIndex = 14;
		this.Label8.Text = "Peso:";
		this.TextBox6.Location = new System.Drawing.Point(547, 88);
		this.TextBox6.Name = "TextBox6";
		this.TextBox6.Size = new System.Drawing.Size(116, 20);
		this.TextBox6.TabIndex = 15;
		this.TextBox6.Text = "0.001";
		this.Label9.AutoSize = true;
		this.Label9.Location = new System.Drawing.Point(491, 141);
		this.Label9.Name = "Label9";
		this.Label9.Size = new System.Drawing.Size(40, 13);
		this.Label9.TabIndex = 16;
		this.Label9.Text = "Estado";
		this.ComboBox1.FormattingEnabled = true;
		this.ComboBox1.Items.AddRange(new object[2] { "Activo", "Inactivo" });
		this.ComboBox1.Location = new System.Drawing.Point(537, 138);
		this.ComboBox1.Name = "ComboBox1";
		this.ComboBox1.Size = new System.Drawing.Size(121, 21);
		this.ComboBox1.TabIndex = 17;
		this.Label10.AutoSize = true;
		this.Label10.Location = new System.Drawing.Point(34, 284);
		this.Label10.Name = "Label10";
		this.Label10.Size = new System.Drawing.Size(76, 13);
		this.Label10.TabIndex = 18;
		this.Label10.Text = "Código Barras:";
		this.TextBox7.Location = new System.Drawing.Point(116, 280);
		this.TextBox7.Name = "TextBox7";
		this.TextBox7.Size = new System.Drawing.Size(192, 20);
		this.TextBox7.TabIndex = 19;
		this.Button1.Location = new System.Drawing.Point(524, 278);
		this.Button1.Name = "Button1";
		this.Button1.Size = new System.Drawing.Size(75, 23);
		this.Button1.TabIndex = 20;
		this.Button1.Text = "Crear";
		this.Button1.UseVisualStyleBackColor = true;
		this.Button2.Location = new System.Drawing.Point(605, 278);
		this.Button2.Name = "Button2";
		this.Button2.Size = new System.Drawing.Size(75, 23);
		this.Button2.TabIndex = 21;
		this.Button2.Text = "Cancelar";
		this.Button2.UseVisualStyleBackColor = true;
		this.GroupBox1.Controls.Add(this.nombreEmpresaLbl);
		this.GroupBox1.Controls.Add(this.Label1);
		this.GroupBox1.Controls.Add(this.numeroEmpresaLbl);
		this.GroupBox1.Controls.Add(this.Label2);
		this.GroupBox1.Location = new System.Drawing.Point(17, 14);
		this.GroupBox1.Name = "GroupBox1";
		this.GroupBox1.Size = new System.Drawing.Size(681, 72);
		this.GroupBox1.TabIndex = 22;
		this.GroupBox1.TabStop = false;
		this.GroupBox1.Text = "Datos Empresa";
		this.GroupBox2.Controls.Add(this.CheckBox1);
		this.GroupBox2.Controls.Add(this.TextBox1);
		this.GroupBox2.Controls.Add(this.Label3);
		this.GroupBox2.Controls.Add(this.TextBox2);
		this.GroupBox2.Controls.Add(this.Label4);
		this.GroupBox2.Controls.Add(this.TextBox3);
		this.GroupBox2.Controls.Add(this.Label5);
		this.GroupBox2.Controls.Add(this.ComboBox1);
		this.GroupBox2.Controls.Add(this.Label9);
		this.GroupBox2.Controls.Add(this.Label6);
		this.GroupBox2.Controls.Add(this.TextBox4);
		this.GroupBox2.Controls.Add(this.TextBox6);
		this.GroupBox2.Controls.Add(this.Label8);
		this.GroupBox2.Controls.Add(this.Label7);
		this.GroupBox2.Controls.Add(this.TextBox5);
		this.GroupBox2.Location = new System.Drawing.Point(17, 92);
		this.GroupBox2.Name = "GroupBox2";
		this.GroupBox2.Size = new System.Drawing.Size(681, 171);
		this.GroupBox2.TabIndex = 23;
		this.GroupBox2.TabStop = false;
		this.GroupBox2.Text = "Dato Producto";
		this.CheckBox1.AutoSize = true;
		this.CheckBox1.Location = new System.Drawing.Point(298, 32);
		this.CheckBox1.Name = "CheckBox1";
		this.CheckBox1.Size = new System.Drawing.Size(81, 17);
		this.CheckBox1.TabIndex = 18;
		this.CheckBox1.Text = "Variaciones";
		this.CheckBox1.UseVisualStyleBackColor = true;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(718, 317);
		base.Controls.Add(this.GroupBox2);
		base.Controls.Add(this.GroupBox1);
		base.Controls.Add(this.Button2);
		base.Controls.Add(this.Button1);
		base.Controls.Add(this.TextBox7);
		base.Controls.Add(this.Label10);
		base.Name = "NuevoProducto_Form";
		this.Text = "Alta Producto";
		this.GroupBox1.ResumeLayout(false);
		this.GroupBox1.PerformLayout();
		this.GroupBox2.ResumeLayout(false);
		this.GroupBox2.PerformLayout();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private void NuevoProducto_Form_Load(object sender, EventArgs e)
	{
		numeroEmpresaLbl.Text = Conversions.ToString(MyProject.Forms.Productos_Form.ComboBox1.SelectedValue);
		nombreEmpresaLbl.Text = MyProject.Forms.Productos_Form.ComboBox1.Text;
		ComboBox1.SelectedIndex = 0;
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		int num = Conversions.ToInteger(numeroEmpresaLbl.Text);
		string text = TextBox7.Text;
		string text2 = TextBox1.Text;
		string text3 = TextBox2.Text;
		string text4 = ((!TextBox3.Text.Contains(",")) ? TextBox3.Text : Strings.Replace(TextBox3.Text, ",", ".", 1, -1, CompareMethod.Text));
		string text5 = ((!TextBox4.Text.Contains(",")) ? TextBox4.Text : Strings.Replace(TextBox4.Text, ",", ".", 1, -1, CompareMethod.Text));
		string text6 = ((!TextBox5.Text.Contains(",")) ? TextBox5.Text : Strings.Replace(TextBox5.Text, ",", ".", 1, -1, CompareMethod.Text));
		string text7 = ((!TextBox6.Text.Contains(",")) ? TextBox6.Text : Strings.Replace(TextBox6.Text, ",", ".", 1, -1, CompareMethod.Text));
		checked
		{
			int num2 = ComboBox1.SelectedIndex + 1;
			string text8 = Strings.Format(MyProject.Forms.Form1_Inicio.DateTimePicker1.Text, "yyyyMMdd");
			string usuario = MySettingsProperty.Settings.Usuario;
			int num3 = 0;
			if (CheckBox1.Checked)
			{
				num3 = 1;
			}
			string sQL = "INSERT INTO productos (empresa, barrCode, codeEmpresa, descripcion, variaciones, alto, ancho, largo, peso, fechaAlta, usuarioAlta, fechaModificacion, usuarioModificacion, estado)\r\nVALUES('" + Conversions.ToString(num) + "', '" + text + "', '" + text2 + "', '" + text3 + "', '" + Conversions.ToString(num3) + "' ,'" + text4 + "', '" + text5 + "', '" + text6 + "', '" + text7 + "', now(), '" + usuario + "', now(), '" + usuario + "', '" + Conversions.ToString(num2) + "')";
			try
			{
				int num4 = Conversions.ToInteger(Mod_ConeccionBD.BD_Sentencia(sQL));
				if (num4 == 1)
				{
					string sql = "Select id from productos where empresa='" + Conversions.ToString(num) + "' and barrCode='" + text + "' Limit 1";
					int num5 = (int)Math.Round(Conversions.ToDouble(Mod_Sentencias.dataValue(sql, "id")));
					string sQL2 = "INSERT INTO stock (producto, unidades, empresa)\r\nVALUES('" + Conversions.ToString(num5) + "', '0', '" + Conversions.ToString(num) + "');";
					int num6 = Conversions.ToInteger(Mod_ConeccionBD.BD_Sentencia(sQL2));
					if (num6 == 1)
					{
						Interaction.MsgBox("Producto creado correctamente.");
						if (CheckBox1.Checked)
						{
							Variaciones variaciones = MyProject.Forms.Variaciones;
							variaciones.idproductolbl.Text = Conversions.ToString(num5);
							variaciones.descripcionlbl.Text = text3;
							variaciones.empresalbl.Text = Conversions.ToString(num);
							variaciones.codigolbl.Text = text2;
							variaciones = null;
							MyProject.Forms.Variaciones.Show();
						}
					}
					else
					{
						Interaction.MsgBox("Ocurrio un error al actualizar el stock.");
					}
				}
				else
				{
					Interaction.MsgBox("Ocurrio un error al crear el producto.");
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
}
