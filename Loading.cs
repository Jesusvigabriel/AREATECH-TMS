using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Hermes;

[DesignerGenerated]
public class Loading : Form
{
	private IContainer components;

	[field: AccessedThroughProperty("ProgressBar1")]
	internal virtual ProgressBar ProgressBar1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel1")]
	internal virtual Panel Panel1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public Loading()
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hermes.Loading));
		this.ProgressBar1 = new System.Windows.Forms.ProgressBar();
		this.Panel1 = new System.Windows.Forms.Panel();
		base.SuspendLayout();
		this.ProgressBar1.Location = new System.Drawing.Point(12, 128);
		this.ProgressBar1.Name = "ProgressBar1";
		this.ProgressBar1.Size = new System.Drawing.Size(237, 23);
		this.ProgressBar1.TabIndex = 0;
		this.Panel1.BackgroundImage = (System.Drawing.Image)resources.GetObject("Panel1.BackgroundImage");
		this.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
		this.Panel1.Location = new System.Drawing.Point(12, 12);
		this.Panel1.Name = "Panel1";
		this.Panel1.Size = new System.Drawing.Size(237, 110);
		this.Panel1.TabIndex = 2;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(261, 160);
		base.Controls.Add(this.Panel1);
		base.Controls.Add(this.ProgressBar1);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "Loading";
		base.ShowInTaskbar = false;
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Proceso";
		base.ResumeLayout(false);
	}
}
