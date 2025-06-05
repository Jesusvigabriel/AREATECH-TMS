using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Hermes.My;
using Hermes.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Hermes;

[DesignerGenerated]
public class ImprimirConfig : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("HScrollBar1")]
	private HScrollBar _HScrollBar1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("VScrollBar1")]
	private VScrollBar _VScrollBar1;

	internal virtual HScrollBar HScrollBar1
	{
		[CompilerGenerated]
		get
		{
			return _HScrollBar1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			ScrollEventHandler value2 = HScrollBar1_Scroll;
			HScrollBar hScrollBar = _HScrollBar1;
			if (hScrollBar != null)
			{
				hScrollBar.Scroll -= value2;
			}
			_HScrollBar1 = value;
			hScrollBar = _HScrollBar1;
			if (hScrollBar != null)
			{
				hScrollBar.Scroll += value2;
			}
		}
	}

	internal virtual VScrollBar VScrollBar1
	{
		[CompilerGenerated]
		get
		{
			return _VScrollBar1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			ScrollEventHandler value2 = VScrollBar1_Scroll;
			VScrollBar vScrollBar = _VScrollBar1;
			if (vScrollBar != null)
			{
				vScrollBar.Scroll -= value2;
			}
			_VScrollBar1 = value;
			vScrollBar = _VScrollBar1;
			if (vScrollBar != null)
			{
				vScrollBar.Scroll += value2;
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

	[field: AccessedThroughProperty("PictureBox1")]
	internal virtual PictureBox PictureBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public ImprimirConfig()
	{
		base.Load += ImprimirConfig_Load;
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
		this.HScrollBar1 = new System.Windows.Forms.HScrollBar();
		this.VScrollBar1 = new System.Windows.Forms.VScrollBar();
		this.Label1 = new System.Windows.Forms.Label();
		this.Label2 = new System.Windows.Forms.Label();
		this.Label3 = new System.Windows.Forms.Label();
		this.Label4 = new System.Windows.Forms.Label();
		this.PictureBox1 = new System.Windows.Forms.PictureBox();
		((System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
		base.SuspendLayout();
		this.HScrollBar1.Location = new System.Drawing.Point(46, 273);
		this.HScrollBar1.Name = "HScrollBar1";
		this.HScrollBar1.Size = new System.Drawing.Size(303, 15);
		this.HScrollBar1.TabIndex = 0;
		this.VScrollBar1.Location = new System.Drawing.Point(15, 45);
		this.VScrollBar1.Name = "VScrollBar1";
		this.VScrollBar1.Size = new System.Drawing.Size(15, 215);
		this.VScrollBar1.TabIndex = 1;
		this.Label1.AutoSize = true;
		this.Label1.Location = new System.Drawing.Point(313, 20);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(13, 13);
		this.Label1.TabIndex = 2;
		this.Label1.Text = "0";
		this.Label2.AutoSize = true;
		this.Label2.Location = new System.Drawing.Point(140, 20);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(13, 13);
		this.Label2.TabIndex = 3;
		this.Label2.Text = "0";
		this.Label3.AutoSize = true;
		this.Label3.Location = new System.Drawing.Point(53, 20);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(45, 13);
		this.Label3.TabIndex = 4;
		this.Label3.Text = "Vertical:";
		this.Label4.AutoSize = true;
		this.Label4.Location = new System.Drawing.Point(226, 20);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(57, 13);
		this.Label4.TabIndex = 5;
		this.Label4.Text = "Horizontal:";
		this.PictureBox1.BackColor = System.Drawing.Color.White;
		this.PictureBox1.Location = new System.Drawing.Point(46, 45);
		this.PictureBox1.Name = "PictureBox1";
		this.PictureBox1.Size = new System.Drawing.Size(303, 215);
		this.PictureBox1.TabIndex = 6;
		this.PictureBox1.TabStop = false;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(375, 301);
		base.Controls.Add(this.PictureBox1);
		base.Controls.Add(this.Label4);
		base.Controls.Add(this.Label3);
		base.Controls.Add(this.Label2);
		base.Controls.Add(this.Label1);
		base.Controls.Add(this.VScrollBar1);
		base.Controls.Add(this.HScrollBar1);
		base.Name = "ImprimirConfig";
		this.Text = "ImprimirConfig";
		((System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private void HScrollBar1_Scroll(object sender, ScrollEventArgs e)
	{
		MySettingsProperty.Settings.pHvalor = HScrollBar1.Value;
		Label1.Text = Conversions.ToString(MySettingsProperty.Settings.pHvalor);
		MySettingsProperty.Settings.Save();
		dibujar();
	}

	private void ImprimirConfig_Load(object sender, EventArgs e)
	{
		HScrollBar1.Value = MySettingsProperty.Settings.pHvalor;
		Label1.Text = Conversions.ToString(MySettingsProperty.Settings.pHvalor);
		VScrollBar1.Value = MySettingsProperty.Settings.pVvalor;
		Label2.Text = Conversions.ToString(MySettingsProperty.Settings.pVvalor);
	}

	private void VScrollBar1_Scroll(object sender, ScrollEventArgs e)
	{
		MySettingsProperty.Settings.pVvalor = VScrollBar1.Value;
		Label2.Text = Conversions.ToString(MySettingsProperty.Settings.pVvalor);
		MySettingsProperty.Settings.Save();
		dibujar();
	}

	private void dibujar()
	{
		checked
		{
			try
			{
				PictureBox1.CreateGraphics().Clear(Color.White);
				Graphics graphics = PictureBox1.CreateGraphics();
				Font font = new Font("Arial", 6.75f, FontStyle.Italic, GraphicsUnit.Point, 0);
				Font font2 = new Font("Arial", 8.75f, FontStyle.Italic, GraphicsUnit.Point, 0);
				Font font3 = new Font("Arial", 10.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
				int num = 0;
				int num2 = 0 + MySettingsProperty.Settings.pHvalor;
				int num3 = 0 + MySettingsProperty.Settings.pVvalor;
				string text = MyProject.Forms.Form1_Inicio.nombreusuario.Text;
				graphics.DrawLine(Pens.Brown, num2 + 2, num3 + 5, num2 + 300, num3 + 5);
				graphics.DrawLine(Pens.Brown, num2 + 2, num3 + 5, num2 + 2, num3 + 185);
				graphics.DrawLine(Pens.Brown, num2 + 300, num3 + 5, num2 + 300, num3 + 185);
				graphics.DrawLine(Pens.Brown, num2 + 2, num3 + 185, num2 + 300, num3 + 185);
				string text2 = "Comprobante";
				string text3 = "Cliente";
				string text4 = "Destino";
				string text5 = "Domicilio";
				string s = "Bulto: 1/1";
				string s2 = "N° Trans: ";
				string text6 = "Observaciones";
				string s3 = "Cp: ";
				string s4 = "Loc: ";
				string s5 = "Zona: ";
				Image image = (Image)Mod_QR.qrcodegen("123456");
				Image etrans = Resources.etrans2;
				graphics.DrawImage(image, num2 + 10, num3 + 70);
				graphics.DrawImage(etrans, num2 + 10, num3 + 10);
				int num4 = default(int);
				graphics.DrawString(s2, font3, Brushes.Black, num2 + 150, num3 + num4 + 10);
				graphics.DrawString(s, font3, Brushes.Black, num2 + 110, num3 + num4 + 70);
				graphics.DrawString(s4, font3, Brushes.Black, num2 + 110, num3 + num4 + 90);
				graphics.DrawString(s3, font3, Brushes.Black, num2 + 110, num3 + num4 + 110);
				graphics.DrawString(s5, font3, Brushes.Black, num2 + 110, num3 + num4 + 130);
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
