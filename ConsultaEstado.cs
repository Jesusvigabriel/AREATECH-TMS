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
public class ConsultaEstado : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("TextBox1")]
	private TextBox _TextBox1;

	[field: AccessedThroughProperty("GroupBox1")]
	internal virtual GroupBox GroupBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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

	[field: AccessedThroughProperty("GroupBox3")]
	internal virtual GroupBox GroupBox3
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

	public ConsultaEstado()
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
		this.TextBox1 = new System.Windows.Forms.TextBox();
		this.Label1 = new System.Windows.Forms.Label();
		this.GroupBox2 = new System.Windows.Forms.GroupBox();
		this.Label7 = new System.Windows.Forms.Label();
		this.Label6 = new System.Windows.Forms.Label();
		this.Label5 = new System.Windows.Forms.Label();
		this.Label4 = new System.Windows.Forms.Label();
		this.Label3 = new System.Windows.Forms.Label();
		this.Label2 = new System.Windows.Forms.Label();
		this.GroupBox3 = new System.Windows.Forms.GroupBox();
		this.Label9 = new System.Windows.Forms.Label();
		this.Label8 = new System.Windows.Forms.Label();
		this.Label10 = new System.Windows.Forms.Label();
		this.Label11 = new System.Windows.Forms.Label();
		this.Label12 = new System.Windows.Forms.Label();
		this.Label13 = new System.Windows.Forms.Label();
		this.Label14 = new System.Windows.Forms.Label();
		this.Label15 = new System.Windows.Forms.Label();
		this.Label16 = new System.Windows.Forms.Label();
		this.Label17 = new System.Windows.Forms.Label();
		this.GroupBox1.SuspendLayout();
		this.GroupBox2.SuspendLayout();
		this.GroupBox3.SuspendLayout();
		base.SuspendLayout();
		this.GroupBox1.Controls.Add(this.TextBox1);
		this.GroupBox1.Controls.Add(this.Label1);
		this.GroupBox1.Location = new System.Drawing.Point(12, 12);
		this.GroupBox1.Name = "GroupBox1";
		this.GroupBox1.Size = new System.Drawing.Size(394, 51);
		this.GroupBox1.TabIndex = 0;
		this.GroupBox1.TabStop = false;
		this.GroupBox1.Text = "Guia:";
		this.TextBox1.Location = new System.Drawing.Point(121, 19);
		this.TextBox1.Name = "TextBox1";
		this.TextBox1.Size = new System.Drawing.Size(252, 20);
		this.TextBox1.TabIndex = 1;
		this.Label1.AutoSize = true;
		this.Label1.Location = new System.Drawing.Point(24, 22);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(91, 13);
		this.Label1.TabIndex = 0;
		this.Label1.Text = "Código de Barras:";
		this.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.GroupBox2.Controls.Add(this.Label11);
		this.GroupBox2.Controls.Add(this.Label10);
		this.GroupBox2.Controls.Add(this.Label7);
		this.GroupBox2.Controls.Add(this.Label6);
		this.GroupBox2.Controls.Add(this.Label5);
		this.GroupBox2.Controls.Add(this.Label4);
		this.GroupBox2.Controls.Add(this.Label3);
		this.GroupBox2.Controls.Add(this.Label2);
		this.GroupBox2.Location = new System.Drawing.Point(12, 69);
		this.GroupBox2.Name = "GroupBox2";
		this.GroupBox2.Size = new System.Drawing.Size(694, 347);
		this.GroupBox2.TabIndex = 1;
		this.GroupBox2.TabStop = false;
		this.GroupBox2.Text = "Novedades:";
		this.Label7.AutoSize = true;
		this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label7.Location = new System.Drawing.Point(251, 209);
		this.Label7.Name = "Label7";
		this.Label7.Size = new System.Drawing.Size(137, 42);
		this.Label7.TabIndex = 5;
		this.Label7.Text = "Label7";
		this.Label6.AutoSize = true;
		this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label6.Location = new System.Drawing.Point(14, 209);
		this.Label6.Name = "Label6";
		this.Label6.Size = new System.Drawing.Size(231, 42);
		this.Label6.TabIndex = 4;
		this.Label6.Text = "Comentario:";
		this.Label5.AutoSize = true;
		this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label5.Location = new System.Drawing.Point(319, 131);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(137, 42);
		this.Label5.TabIndex = 3;
		this.Label5.Text = "Label5";
		this.Label4.AutoSize = true;
		this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label4.Location = new System.Drawing.Point(20, 131);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(293, 42);
		this.Label4.TabIndex = 2;
		this.Label4.Text = "Observaciones:";
		this.Label3.AutoSize = true;
		this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label3.Location = new System.Drawing.Point(176, 50);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(137, 42);
		this.Label3.TabIndex = 1;
		this.Label3.Text = "Label3";
		this.Label2.AutoSize = true;
		this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label2.Location = new System.Drawing.Point(20, 50);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(152, 42);
		this.Label2.TabIndex = 0;
		this.Label2.Text = "Estado:";
		this.GroupBox3.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.GroupBox3.Controls.Add(this.Label17);
		this.GroupBox3.Controls.Add(this.Label16);
		this.GroupBox3.Controls.Add(this.Label15);
		this.GroupBox3.Controls.Add(this.Label14);
		this.GroupBox3.Controls.Add(this.Label13);
		this.GroupBox3.Controls.Add(this.Label12);
		this.GroupBox3.Controls.Add(this.Label9);
		this.GroupBox3.Controls.Add(this.Label8);
		this.GroupBox3.Location = new System.Drawing.Point(12, 422);
		this.GroupBox3.Name = "GroupBox3";
		this.GroupBox3.Size = new System.Drawing.Size(694, 107);
		this.GroupBox3.TabIndex = 2;
		this.GroupBox3.TabStop = false;
		this.GroupBox3.Text = "Información:";
		this.Label9.AutoSize = true;
		this.Label9.Location = new System.Drawing.Point(393, 37);
		this.Label9.Name = "Label9";
		this.Label9.Size = new System.Drawing.Size(39, 13);
		this.Label9.TabIndex = 1;
		this.Label9.Text = "Bultos:";
		this.Label8.AutoSize = true;
		this.Label8.Location = new System.Drawing.Point(24, 37);
		this.Label8.Name = "Label8";
		this.Label8.Size = new System.Drawing.Size(42, 13);
		this.Label8.TabIndex = 0;
		this.Label8.Text = "Cliente:";
		this.Label10.AutoSize = true;
		this.Label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label10.Location = new System.Drawing.Point(20, 286);
		this.Label10.Name = "Label10";
		this.Label10.Size = new System.Drawing.Size(187, 42);
		this.Label10.TabIndex = 6;
		this.Label10.Text = "Novedad:";
		this.Label11.AutoSize = true;
		this.Label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label11.Location = new System.Drawing.Point(213, 286);
		this.Label11.Name = "Label11";
		this.Label11.Size = new System.Drawing.Size(159, 42);
		this.Label11.TabIndex = 7;
		this.Label11.Text = "Label11";
		this.Label12.AutoSize = true;
		this.Label12.Location = new System.Drawing.Point(76, 37);
		this.Label12.Name = "Label12";
		this.Label12.Size = new System.Drawing.Size(45, 13);
		this.Label12.TabIndex = 2;
		this.Label12.Text = "Label12";
		this.Label13.AutoSize = true;
		this.Label13.Location = new System.Drawing.Point(447, 37);
		this.Label13.Name = "Label13";
		this.Label13.Size = new System.Drawing.Size(45, 13);
		this.Label13.TabIndex = 3;
		this.Label13.Text = "Label13";
		this.Label14.AutoSize = true;
		this.Label14.Location = new System.Drawing.Point(393, 70);
		this.Label14.Name = "Label14";
		this.Label14.Size = new System.Drawing.Size(48, 13);
		this.Label14.TabIndex = 4;
		this.Label14.Text = "Remitos:";
		this.Label15.AutoSize = true;
		this.Label15.Location = new System.Drawing.Point(24, 70);
		this.Label15.Name = "Label15";
		this.Label15.Size = new System.Drawing.Size(46, 13);
		this.Label15.TabIndex = 5;
		this.Label15.Text = "Destino:";
		this.Label16.AutoSize = true;
		this.Label16.Location = new System.Drawing.Point(447, 70);
		this.Label16.Name = "Label16";
		this.Label16.Size = new System.Drawing.Size(45, 13);
		this.Label16.TabIndex = 6;
		this.Label16.Text = "Label16";
		this.Label17.AutoSize = true;
		this.Label17.Location = new System.Drawing.Point(76, 70);
		this.Label17.Name = "Label17";
		this.Label17.Size = new System.Drawing.Size(45, 13);
		this.Label17.TabIndex = 7;
		this.Label17.Text = "Label17";
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(721, 555);
		base.Controls.Add(this.GroupBox3);
		base.Controls.Add(this.GroupBox2);
		base.Controls.Add(this.GroupBox1);
		base.Name = "ConsultaEstado";
		this.Text = "ConsultaEstado";
		this.GroupBox1.ResumeLayout(false);
		this.GroupBox1.PerformLayout();
		this.GroupBox2.ResumeLayout(false);
		this.GroupBox2.PerformLayout();
		this.GroupBox3.ResumeLayout(false);
		this.GroupBox3.PerformLayout();
		base.ResumeLayout(false);
	}

	private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (e.KeyChar == '\r' && Operators.CompareString(TextBox1.Text, "", TextCompare: true) != 0)
		{
			string text = Strings.Format(MyProject.Forms.Form1_Inicio.DateTimePicker1.Value, "yyyyMMdd");
			string text2 = TextBox1.Text;
			text2 = Strings.Mid(text2, 1, checked(Strings.Len(text2) - 1));
			text2 = text2.Remove(0, 7);
			string sql = "SELECT  Ventana, Cliente, Sub, Atraso, Destino, Remitos, Bultos, Estado, Fecha, Observaciones, Comentario,(SELECT novedad from novedades where comprobante='" + text2 + "' and fecha='" + text + "') as novedad, Usuario FROM Planchada WHERE fecha = '" + text + "' AND Comprobante= '" + text2 + "'";
			Label3.Text = Conversions.ToString(Mod_Sentencias.dataValue(sql, "Estado"));
			if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(Mod_Sentencias.dataValue(sql, "Observaciones"))))
			{
				Label5.Text = "";
			}
			else
			{
				Label5.Text = Conversions.ToString(Mod_Sentencias.dataValue(sql, "Observaciones"));
			}
			if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(Mod_Sentencias.dataValue(sql, "Comentario"))))
			{
				Label7.Text = "";
			}
			else
			{
				Label7.Text = Conversions.ToString(Mod_Sentencias.dataValue(sql, "Comentario"));
			}
			if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(Mod_Sentencias.dataValue(sql, "Novedad"))))
			{
				Label11.Text = "";
			}
			else
			{
				Label11.Text = Conversions.ToString(Mod_Sentencias.dataValue(sql, "Novedad"));
			}
			Label12.Text = Conversions.ToString(Mod_Sentencias.dataValue(sql, "Cliente"));
			Label13.Text = Conversions.ToString(Mod_Sentencias.dataValue(sql, "Bultos"));
			Label16.Text = Conversions.ToString(Mod_Sentencias.dataValue(sql, "Remitos"));
			Label17.Text = Conversions.ToString(Mod_Sentencias.dataValue(sql, "Destino"));
			TextBox1.Text = "";
			TextBox1.Focus();
		}
	}
}
