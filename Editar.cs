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
public class Editar : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("aceptarBtn")]
	private Button _aceptarBtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("cerrarBtn")]
	private Button _cerrarBtn;

	private int modo;

	[field: AccessedThroughProperty("controladorLbl")]
	internal virtual Label controladorLbl
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

	[field: AccessedThroughProperty("idlbl")]
	internal virtual Label idlbl
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("barrCodeTxt")]
	internal virtual TextBox barrCodeTxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("codeEmpresaTxt")]
	internal virtual TextBox codeEmpresaTxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("descripcionTxt")]
	internal virtual TextBox descripcionTxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("altoTxt")]
	internal virtual TextBox altoTxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("anchoTxt")]
	internal virtual TextBox anchoTxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("largoTxt")]
	internal virtual TextBox largoTxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pesotxt")]
	internal virtual TextBox pesotxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("estadoCombo")]
	internal virtual ComboBox estadoCombo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button aceptarBtn
	{
		[CompilerGenerated]
		get
		{
			return _aceptarBtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = aceptarBtn_Click;
			Button button = _aceptarBtn;
			if (button != null)
			{
				button.Click -= value2;
			}
			_aceptarBtn = value;
			button = _aceptarBtn;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button cerrarBtn
	{
		[CompilerGenerated]
		get
		{
			return _cerrarBtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = cerrarBtn_Click;
			Button button = _cerrarBtn;
			if (button != null)
			{
				button.Click -= value2;
			}
			_cerrarBtn = value;
			button = _cerrarBtn;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("CheckBox1")]
	internal virtual CheckBox CheckBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("precioTxt")]
	internal virtual TextBox precioTxt
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

	[field: AccessedThroughProperty("TextBox1")]
	internal virtual TextBox TextBox1
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

	[field: AccessedThroughProperty("TextBox2")]
	internal virtual TextBox TextBox2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public Editar()
	{
		base.Load += Editar_Load;
		modo = 0;
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
		this.controladorLbl = new System.Windows.Forms.Label();
		this.Label1 = new System.Windows.Forms.Label();
		this.Label2 = new System.Windows.Forms.Label();
		this.Label3 = new System.Windows.Forms.Label();
		this.Label4 = new System.Windows.Forms.Label();
		this.Label5 = new System.Windows.Forms.Label();
		this.Label6 = new System.Windows.Forms.Label();
		this.Label7 = new System.Windows.Forms.Label();
		this.Label8 = new System.Windows.Forms.Label();
		this.Label9 = new System.Windows.Forms.Label();
		this.idlbl = new System.Windows.Forms.Label();
		this.barrCodeTxt = new System.Windows.Forms.TextBox();
		this.codeEmpresaTxt = new System.Windows.Forms.TextBox();
		this.descripcionTxt = new System.Windows.Forms.TextBox();
		this.altoTxt = new System.Windows.Forms.TextBox();
		this.anchoTxt = new System.Windows.Forms.TextBox();
		this.largoTxt = new System.Windows.Forms.TextBox();
		this.pesotxt = new System.Windows.Forms.TextBox();
		this.estadoCombo = new System.Windows.Forms.ComboBox();
		this.aceptarBtn = new System.Windows.Forms.Button();
		this.cerrarBtn = new System.Windows.Forms.Button();
		this.CheckBox1 = new System.Windows.Forms.CheckBox();
		this.precioTxt = new System.Windows.Forms.TextBox();
		this.Label10 = new System.Windows.Forms.Label();
		this.Label11 = new System.Windows.Forms.Label();
		this.TextBox1 = new System.Windows.Forms.TextBox();
		this.Label12 = new System.Windows.Forms.Label();
		this.TextBox2 = new System.Windows.Forms.TextBox();
		base.SuspendLayout();
		this.controladorLbl.AutoSize = true;
		this.controladorLbl.Location = new System.Drawing.Point(519, 15);
		this.controladorLbl.Name = "controladorLbl";
		this.controladorLbl.Size = new System.Drawing.Size(13, 13);
		this.controladorLbl.TabIndex = 0;
		this.controladorLbl.Text = "0";
		this.controladorLbl.Visible = false;
		this.Label1.AutoSize = true;
		this.Label1.Location = new System.Drawing.Point(18, 15);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(19, 13);
		this.Label1.TabIndex = 1;
		this.Label1.Text = "Id:";
		this.Label2.AutoSize = true;
		this.Label2.Location = new System.Drawing.Point(66, 45);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(91, 13);
		this.Label2.TabIndex = 2;
		this.Label2.Text = "Codigo de Barras:";
		this.Label3.AutoSize = true;
		this.Label3.Location = new System.Drawing.Point(66, 85);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(87, 13);
		this.Label3.TabIndex = 3;
		this.Label3.Text = "Codigo Empresa:";
		this.Label4.AutoSize = true;
		this.Label4.Location = new System.Drawing.Point(66, 122);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(66, 13);
		this.Label4.TabIndex = 4;
		this.Label4.Text = "Descripción:";
		this.Label5.AutoSize = true;
		this.Label5.Location = new System.Drawing.Point(18, 163);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(54, 13);
		this.Label5.TabIndex = 5;
		this.Label5.Text = "Alto (Mts):";
		this.Label6.AutoSize = true;
		this.Label6.Location = new System.Drawing.Point(365, 163);
		this.Label6.Name = "Label6";
		this.Label6.Size = new System.Drawing.Size(67, 13);
		this.Label6.TabIndex = 6;
		this.Label6.Text = "Ancho (Mts):";
		this.Label7.AutoSize = true;
		this.Label7.Location = new System.Drawing.Point(184, 163);
		this.Label7.Name = "Label7";
		this.Label7.Size = new System.Drawing.Size(63, 13);
		this.Label7.TabIndex = 7;
		this.Label7.Text = "Largo (Mts):";
		this.Label8.AutoSize = true;
		this.Label8.Location = new System.Drawing.Point(365, 193);
		this.Label8.Name = "Label8";
		this.Label8.Size = new System.Drawing.Size(61, 13);
		this.Label8.TabIndex = 8;
		this.Label8.Text = "Peso (Kgs):";
		this.Label9.AutoSize = true;
		this.Label9.Location = new System.Drawing.Point(29, 222);
		this.Label9.Name = "Label9";
		this.Label9.Size = new System.Drawing.Size(43, 13);
		this.Label9.TabIndex = 9;
		this.Label9.Text = "Estado:";
		this.idlbl.AutoSize = true;
		this.idlbl.Location = new System.Drawing.Point(64, 15);
		this.idlbl.Name = "idlbl";
		this.idlbl.Size = new System.Drawing.Size(13, 13);
		this.idlbl.TabIndex = 10;
		this.idlbl.Text = "0";
		this.barrCodeTxt.Location = new System.Drawing.Point(163, 42);
		this.barrCodeTxt.Name = "barrCodeTxt";
		this.barrCodeTxt.Size = new System.Drawing.Size(299, 20);
		this.barrCodeTxt.TabIndex = 11;
		this.codeEmpresaTxt.Location = new System.Drawing.Point(159, 82);
		this.codeEmpresaTxt.Name = "codeEmpresaTxt";
		this.codeEmpresaTxt.Size = new System.Drawing.Size(303, 20);
		this.codeEmpresaTxt.TabIndex = 12;
		this.descripcionTxt.Location = new System.Drawing.Point(138, 119);
		this.descripcionTxt.Name = "descripcionTxt";
		this.descripcionTxt.Size = new System.Drawing.Size(324, 20);
		this.descripcionTxt.TabIndex = 13;
		this.altoTxt.Location = new System.Drawing.Point(78, 160);
		this.altoTxt.Name = "altoTxt";
		this.altoTxt.Size = new System.Drawing.Size(100, 20);
		this.altoTxt.TabIndex = 14;
		this.anchoTxt.Location = new System.Drawing.Point(432, 160);
		this.anchoTxt.Name = "anchoTxt";
		this.anchoTxt.Size = new System.Drawing.Size(100, 20);
		this.anchoTxt.TabIndex = 15;
		this.largoTxt.Location = new System.Drawing.Point(253, 160);
		this.largoTxt.Name = "largoTxt";
		this.largoTxt.Size = new System.Drawing.Size(100, 20);
		this.largoTxt.TabIndex = 16;
		this.pesotxt.Location = new System.Drawing.Point(432, 190);
		this.pesotxt.Name = "pesotxt";
		this.pesotxt.Size = new System.Drawing.Size(100, 20);
		this.pesotxt.TabIndex = 17;
		this.estadoCombo.FormattingEnabled = true;
		this.estadoCombo.Items.AddRange(new object[10] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" });
		this.estadoCombo.Location = new System.Drawing.Point(78, 219);
		this.estadoCombo.Name = "estadoCombo";
		this.estadoCombo.Size = new System.Drawing.Size(100, 21);
		this.estadoCombo.TabIndex = 18;
		this.estadoCombo.Text = "1";
		this.aceptarBtn.Location = new System.Drawing.Point(12, 285);
		this.aceptarBtn.Name = "aceptarBtn";
		this.aceptarBtn.Size = new System.Drawing.Size(75, 23);
		this.aceptarBtn.TabIndex = 19;
		this.aceptarBtn.Text = "Aceptar";
		this.aceptarBtn.UseVisualStyleBackColor = true;
		this.cerrarBtn.Location = new System.Drawing.Point(463, 285);
		this.cerrarBtn.Name = "cerrarBtn";
		this.cerrarBtn.Size = new System.Drawing.Size(75, 23);
		this.cerrarBtn.TabIndex = 20;
		this.cerrarBtn.Text = "Cerrar";
		this.cerrarBtn.UseVisualStyleBackColor = true;
		this.CheckBox1.AutoSize = true;
		this.CheckBox1.Location = new System.Drawing.Point(253, 221);
		this.CheckBox1.Name = "CheckBox1";
		this.CheckBox1.Size = new System.Drawing.Size(81, 17);
		this.CheckBox1.TabIndex = 21;
		this.CheckBox1.Text = "Variaciones";
		this.CheckBox1.UseVisualStyleBackColor = true;
		this.precioTxt.Location = new System.Drawing.Point(432, 216);
		this.precioTxt.Name = "precioTxt";
		this.precioTxt.Size = new System.Drawing.Size(100, 20);
		this.precioTxt.TabIndex = 22;
		this.precioTxt.Text = "0";
		this.Label10.AutoSize = true;
		this.Label10.Location = new System.Drawing.Point(365, 222);
		this.Label10.Name = "Label10";
		this.Label10.Size = new System.Drawing.Size(40, 13);
		this.Label10.TabIndex = 23;
		this.Label10.Text = "Precio:";
		this.Label11.AutoSize = true;
		this.Label11.Location = new System.Drawing.Point(189, 193);
		this.Label11.Name = "Label11";
		this.Label11.Size = new System.Drawing.Size(58, 13);
		this.Label11.TabIndex = 24;
		this.Label11.Text = "Un X Caja:";
		this.TextBox1.Location = new System.Drawing.Point(253, 190);
		this.TextBox1.Name = "TextBox1";
		this.TextBox1.Size = new System.Drawing.Size(100, 20);
		this.TextBox1.TabIndex = 25;
		this.Label12.AutoSize = true;
		this.Label12.Location = new System.Drawing.Point(14, 193);
		this.Label12.Name = "Label12";
		this.Label12.Size = new System.Drawing.Size(61, 13);
		this.Label12.TabIndex = 26;
		this.Label12.Text = "Un X Inner:";
		this.TextBox2.Location = new System.Drawing.Point(78, 190);
		this.TextBox2.Name = "TextBox2";
		this.TextBox2.Size = new System.Drawing.Size(100, 20);
		this.TextBox2.TabIndex = 27;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(550, 320);
		base.Controls.Add(this.TextBox2);
		base.Controls.Add(this.Label12);
		base.Controls.Add(this.TextBox1);
		base.Controls.Add(this.Label11);
		base.Controls.Add(this.Label10);
		base.Controls.Add(this.precioTxt);
		base.Controls.Add(this.CheckBox1);
		base.Controls.Add(this.cerrarBtn);
		base.Controls.Add(this.aceptarBtn);
		base.Controls.Add(this.estadoCombo);
		base.Controls.Add(this.pesotxt);
		base.Controls.Add(this.largoTxt);
		base.Controls.Add(this.anchoTxt);
		base.Controls.Add(this.altoTxt);
		base.Controls.Add(this.descripcionTxt);
		base.Controls.Add(this.codeEmpresaTxt);
		base.Controls.Add(this.barrCodeTxt);
		base.Controls.Add(this.idlbl);
		base.Controls.Add(this.Label9);
		base.Controls.Add(this.Label8);
		base.Controls.Add(this.Label7);
		base.Controls.Add(this.Label6);
		base.Controls.Add(this.Label5);
		base.Controls.Add(this.Label4);
		base.Controls.Add(this.Label3);
		base.Controls.Add(this.Label2);
		base.Controls.Add(this.Label1);
		base.Controls.Add(this.controladorLbl);
		base.Name = "Editar";
		this.Text = "Editar";
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private void Editar_Load(object sender, EventArgs e)
	{
		modo = Conversions.ToInteger(controladorLbl.Text);
		switch (modo)
		{
		}
	}

	private void cerrarBtn_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void aceptarBtn_Click(object sender, EventArgs e)
	{
		string text = string.Empty;
		foreach (Control control in base.Controls)
		{
			if (control is TextBox && Operators.CompareString(control.Text, "", TextCompare: true) == 0)
			{
				control.Focus();
				string left = control.Name.ToString();
				if (Operators.CompareString(left, "barrCodeTxt", TextCompare: true) == 0)
				{
					text = "Codigo de Barras";
				}
				else if (Operators.CompareString(left, "codeEmpresaTxt", TextCompare: true) == 0)
				{
					text = "Codigo Empresa";
				}
				else if (Operators.CompareString(left, "descripcionTxt", TextCompare: true) == 0)
				{
					text = "Descripcion";
				}
				else if (Operators.CompareString(left, "altoTxt", TextCompare: true) == 0)
				{
					text = "Alto";
				}
				else if (Operators.CompareString(left, "largoTxt", TextCompare: true) == 0)
				{
					text = "Largo";
				}
				else if (Operators.CompareString(left, "anchoTxt", TextCompare: true) == 0)
				{
					text = "Ancho";
				}
				else if (Operators.CompareString(left, "pesotxt", TextCompare: true) == 0)
				{
					text = "Peso";
				}
				else if (Operators.CompareString(left, "preciotxt", TextCompare: true) == 0)
				{
					text = "Precio";
				}
				else if (Operators.CompareString(left, "estadoCombo", TextCompare: true) == 0)
				{
					text = "Estado";
				}
				else if (Operators.CompareString(left, "TextBox1", TextCompare: true) == 0)
				{
					text = "Un X Bulto";
					TextBox1.Text = Conversions.ToString(1);
				}
				else if (Operators.CompareString(left, "TextBox2", TextCompare: true) == 0)
				{
					text = "Un x Inner";
					TextBox2.Text = Conversions.ToString(1);
				}
				Interaction.MsgBox(text + " no puede estar Vacio.");
				return;
			}
		}
		string text2 = Strings.Replace(altoTxt.Text, ",", ".", 1, -1, CompareMethod.Text);
		string text3 = Strings.Replace(largoTxt.Text, ",", ".", 1, -1, CompareMethod.Text);
		string text4 = Strings.Replace(anchoTxt.Text, ",", ".", 1, -1, CompareMethod.Text);
		string text5 = Strings.Replace(pesotxt.Text, ",", ".", 1, -1, CompareMethod.Text);
		string text6 = Strings.Replace(precioTxt.Text, ",", ".", 1, -1, CompareMethod.Text);
		string usuario = MySettingsProperty.Settings.Usuario;
		string sQL = "UPDATE productos SET barrCode='" + barrCodeTxt.Text + "', codeEmpresa='" + codeEmpresaTxt.Text + "', descripcion='" + descripcionTxt.Text + "', unXcaja=" + TextBox1.Text + ", unXinner= " + TextBox2.Text + ", alto='" + text2 + "', ancho='" + text4 + "', largo='" + text3 + "', peso='" + text5 + "', precio='" + text6 + "', usuarioModificacion='" + usuario + "', estado='" + estadoCombo.Text + "' WHERE id=" + idlbl.Text;
		int num = Conversions.ToInteger(Mod_ConeccionBD.BD_Sentencia(sQL));
		if (num == 1)
		{
			Productos_Form productos_Form = MyProject.Forms.Productos_Form;
			productos_Form.ListView1.Clear();
			productos_Form.BuscarProducto(2);
			productos_Form = null;
			Close();
		}
		else
		{
			Interaction.MsgBox("Ocurrio un error al editar.");
		}
	}
}
