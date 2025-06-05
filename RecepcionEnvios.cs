using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Hermes.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Hermes;

[DesignerGenerated]
public class RecepcionEnvios : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("TextBox1")]
	private TextBox _TextBox1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ComboBox1")]
	private ComboBox _ComboBox1;

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
			KeyPressEventHandler value2 = TextBox1_KeyPress;
			TextBox textBox = _TextBox1;
			if (textBox != null)
			{
				textBox.KeyPress -= value2;
			}
			_TextBox1 = value;
			textBox = _TextBox1;
			if (textBox != null)
			{
				textBox.KeyPress += value2;
			}
		}
	}

	[field: AccessedThroughProperty("ListView1")]
	internal virtual ListView ListView1
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

	[field: AccessedThroughProperty("ColumnHeader1")]
	internal virtual ColumnHeader ColumnHeader1
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

	public RecepcionEnvios()
	{
		base.Load += RecepcionEnvios_Load;
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
		this.TextBox1 = new System.Windows.Forms.TextBox();
		this.ListView1 = new System.Windows.Forms.ListView();
		this.ColumnHeader1 = new System.Windows.Forms.ColumnHeader();
		this.Label1 = new System.Windows.Forms.Label();
		this.Label2 = new System.Windows.Forms.Label();
		this.ComboBox1 = new System.Windows.Forms.ComboBox();
		this.Label3 = new System.Windows.Forms.Label();
		base.SuspendLayout();
		this.TextBox1.Location = new System.Drawing.Point(154, 40);
		this.TextBox1.Name = "TextBox1";
		this.TextBox1.Size = new System.Drawing.Size(183, 20);
		this.TextBox1.TabIndex = 0;
		this.ListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[1] { this.ColumnHeader1 });
		this.ListView1.FullRowSelect = true;
		this.ListView1.GridLines = true;
		this.ListView1.Location = new System.Drawing.Point(593, 12);
		this.ListView1.Name = "ListView1";
		this.ListView1.Size = new System.Drawing.Size(337, 364);
		this.ListView1.TabIndex = 1;
		this.ListView1.UseCompatibleStateImageBehavior = false;
		this.ListView1.View = System.Windows.Forms.View.Details;
		this.ColumnHeader1.Text = "Envio";
		this.Label1.AutoSize = true;
		this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label1.Location = new System.Drawing.Point(162, 149);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(175, 55);
		this.Label1.TabIndex = 2;
		this.Label1.Text = "Label1";
		this.Label2.AutoSize = true;
		this.Label2.Location = new System.Drawing.Point(604, 396);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(39, 13);
		this.Label2.TabIndex = 3;
		this.Label2.Text = "Label2";
		this.ComboBox1.FormattingEnabled = true;
		this.ComboBox1.Items.AddRange(new object[9] { "0", "1", "2", "3", "4", "5", "6", "7", "8" });
		this.ComboBox1.Location = new System.Drawing.Point(360, 40);
		this.ComboBox1.Name = "ComboBox1";
		this.ComboBox1.Size = new System.Drawing.Size(121, 21);
		this.ComboBox1.TabIndex = 4;
		this.Label3.AutoSize = true;
		this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label3.Location = new System.Drawing.Point(357, 77);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(66, 24);
		this.Label3.TabIndex = 5;
		this.Label3.Text = "Label3";
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(942, 487);
		base.Controls.Add(this.Label3);
		base.Controls.Add(this.ComboBox1);
		base.Controls.Add(this.Label2);
		base.Controls.Add(this.Label1);
		base.Controls.Add(this.ListView1);
		base.Controls.Add(this.TextBox1);
		base.Name = "RecepcionEnvios";
		this.Text = "RecepcionEnvios";
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (e.KeyChar != '\r')
		{
			return;
		}
		try
		{
			string text = TextBox1.Text;
			int length = text.Length;
			Label1.Text = text.Remove(checked(text.Length - 1));
			int.TryParse(Label1.Text, out var result);
			int num = Conversions.ToInteger(get_estado(result));
			Console.WriteLine(num);
			if (ComboBox1.Enabled)
			{
				int.TryParse(ComboBox1.Text, out var result2);
				Mod_ecommerce.CambiarEstados(Conversions.ToInteger(Label1.Text), result2);
			}
			else if (num != 5)
			{
				int result2 = 3;
				Mod_ecommerce.CambiarEstados(Conversions.ToInteger(Label1.Text), result2);
			}
			else
			{
				Interaction.MsgBox("El envio: " + TextBox1.Text + " ya fue entregado.");
			}
			LvlAddItem(Conversions.ToInteger(Label1.Text));
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox("Error de lectura: " + TextBox1.Text + " No es un envio valido.");
			ProjectData.ClearProjectError();
		}
		finally
		{
			TextBox1.Text = string.Empty;
			TextBox1.Focus();
		}
	}

	private void LvlAddItem(int numero)
	{
		ListView1.Items.Add(Conversions.ToString(numero));
		Label2.Text = Conversions.ToString(ListView1.Items.Count);
	}

	private void RecepcionEnvios_Load(object sender, EventArgs e)
	{
		if (Operators.CompareString(MySettingsProperty.Settings.Usuario, "Facu", TextCompare: true) == 0)
		{
			ComboBox1.Enabled = true;
			ComboBox1.Visible = true;
			Label3.Visible = true;
			if (int.TryParse(ComboBox1.Text, out var result))
			{
				Label3.Text = Conversions.ToString(EstadoFromInt(result));
			}
		}
		else
		{
			ComboBox1.Enabled = false;
			ComboBox1.Visible = false;
			Label3.Visible = false;
		}
	}

	private object EstadoFromInt(int estadoInt)
	{
		string result = string.Empty;
		switch (estadoInt)
		{
		case 0:
			result = "PENDIENTE";
			break;
		case 1:
			result = "APROBADO";
			break;
		case 2:
			result = "EN RECOLECCION";
			break;
		case 3:
			result = "EN CD";
			break;
		case 4:
			result = "DESPACHADO";
			break;
		case 5:
			result = "ENTREGADO";
			break;
		case 6:
			result = "NO ENTREGADO";
			break;
		case 7:
			result = "ENT. PARCIAL";
			break;
		case 8:
			result = "ANULADO";
			break;
		}
		return result;
	}

	private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
	{
		Label3.Text = Conversions.ToString(EstadoFromInt(Conversions.ToInteger(ComboBox1.Text)));
	}

	private object get_estado(int envio)
	{
		int num = 0;
		string text = "SELECT estado FROM envios WHERE id=" + Conversions.ToString(envio);
		Console.WriteLine(text);
		DataTable dataTable = (DataTable)Mod_Sentencias.data(text);
		if (dataTable.Rows.Count > 0)
		{
			num = Conversions.ToInteger(dataTable.Rows[0]["estado"]);
		}
		else
		{
			Console.WriteLine("No hay datos");
		}
		return num;
	}
}
