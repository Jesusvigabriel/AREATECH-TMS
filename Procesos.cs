using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Hermes.My.Resources;
using Microsoft.VisualBasic.CompilerServices;

namespace Hermes;

[DesignerGenerated]
public class Procesos : Form
{
	private IContainer components;

	[field: AccessedThroughProperty("GroupBox1")]
	internal virtual GroupBox GroupBox1
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

	[field: AccessedThroughProperty("ProgressBar5")]
	internal virtual ProgressBar ProgressBar5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ProgressBar4")]
	internal virtual ProgressBar ProgressBar4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ProgressBar3")]
	internal virtual ProgressBar ProgressBar3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ProgressBar2")]
	internal virtual ProgressBar ProgressBar2
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

	[field: AccessedThroughProperty("ProgressBar1")]
	internal virtual ProgressBar ProgressBar1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public Procesos()
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hermes.Procesos));
		this.GroupBox1 = new System.Windows.Forms.GroupBox();
		this.Label5 = new System.Windows.Forms.Label();
		this.Label4 = new System.Windows.Forms.Label();
		this.Label3 = new System.Windows.Forms.Label();
		this.Label2 = new System.Windows.Forms.Label();
		this.ProgressBar5 = new System.Windows.Forms.ProgressBar();
		this.ProgressBar4 = new System.Windows.Forms.ProgressBar();
		this.ProgressBar3 = new System.Windows.Forms.ProgressBar();
		this.ProgressBar2 = new System.Windows.Forms.ProgressBar();
		this.Label1 = new System.Windows.Forms.Label();
		this.ProgressBar1 = new System.Windows.Forms.ProgressBar();
		this.PictureBox1 = new System.Windows.Forms.PictureBox();
		this.GroupBox1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
		base.SuspendLayout();
		this.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.GroupBox1.Controls.Add(this.Label5);
		this.GroupBox1.Controls.Add(this.Label4);
		this.GroupBox1.Controls.Add(this.Label3);
		this.GroupBox1.Controls.Add(this.Label2);
		this.GroupBox1.Controls.Add(this.ProgressBar5);
		this.GroupBox1.Controls.Add(this.ProgressBar4);
		this.GroupBox1.Controls.Add(this.ProgressBar3);
		this.GroupBox1.Controls.Add(this.ProgressBar2);
		this.GroupBox1.Controls.Add(this.Label1);
		this.GroupBox1.Controls.Add(this.ProgressBar1);
		this.GroupBox1.Location = new System.Drawing.Point(12, 120);
		this.GroupBox1.Name = "GroupBox1";
		this.GroupBox1.Size = new System.Drawing.Size(260, 173);
		this.GroupBox1.TabIndex = 0;
		this.GroupBox1.TabStop = false;
		this.GroupBox1.Text = "Procesos";
		this.Label5.AutoSize = true;
		this.Label5.Location = new System.Drawing.Point(228, 140);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(13, 13);
		this.Label5.TabIndex = 9;
		this.Label5.Text = "0";
		this.Label4.AutoSize = true;
		this.Label4.Location = new System.Drawing.Point(228, 111);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(13, 13);
		this.Label4.TabIndex = 8;
		this.Label4.Text = "0";
		this.Label3.AutoSize = true;
		this.Label3.Location = new System.Drawing.Point(228, 82);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(13, 13);
		this.Label3.TabIndex = 7;
		this.Label3.Text = "0";
		this.Label2.AutoSize = true;
		this.Label2.Location = new System.Drawing.Point(228, 53);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(13, 13);
		this.Label2.TabIndex = 6;
		this.Label2.Text = "0";
		this.ProgressBar5.Location = new System.Drawing.Point(6, 135);
		this.ProgressBar5.Name = "ProgressBar5";
		this.ProgressBar5.Size = new System.Drawing.Size(216, 23);
		this.ProgressBar5.TabIndex = 5;
		this.ProgressBar4.Location = new System.Drawing.Point(6, 106);
		this.ProgressBar4.Name = "ProgressBar4";
		this.ProgressBar4.Size = new System.Drawing.Size(216, 23);
		this.ProgressBar4.TabIndex = 4;
		this.ProgressBar3.Location = new System.Drawing.Point(6, 77);
		this.ProgressBar3.Name = "ProgressBar3";
		this.ProgressBar3.Size = new System.Drawing.Size(216, 23);
		this.ProgressBar3.TabIndex = 3;
		this.ProgressBar2.Location = new System.Drawing.Point(6, 48);
		this.ProgressBar2.Name = "ProgressBar2";
		this.ProgressBar2.Size = new System.Drawing.Size(216, 23);
		this.ProgressBar2.TabIndex = 2;
		this.Label1.AutoSize = true;
		this.Label1.Location = new System.Drawing.Point(228, 24);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(13, 13);
		this.Label1.TabIndex = 1;
		this.Label1.Text = "0";
		this.ProgressBar1.Location = new System.Drawing.Point(6, 19);
		this.ProgressBar1.Name = "ProgressBar1";
		this.ProgressBar1.Size = new System.Drawing.Size(216, 23);
		this.ProgressBar1.TabIndex = 0;
		this.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.PictureBox1.Image = Hermes.My.Resources.Resources.Logo_hermes_3;
		this.PictureBox1.Location = new System.Drawing.Point(12, 6);
		this.PictureBox1.Name = "PictureBox1";
		this.PictureBox1.Size = new System.Drawing.Size(260, 108);
		this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.PictureBox1.TabIndex = 1;
		this.PictureBox1.TabStop = false;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(284, 305);
		base.ControlBox = false;
		base.Controls.Add(this.PictureBox1);
		base.Controls.Add(this.GroupBox1);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.Name = "Procesos";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Procesos";
		this.GroupBox1.ResumeLayout(false);
		this.GroupBox1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
		base.ResumeLayout(false);
	}
}
