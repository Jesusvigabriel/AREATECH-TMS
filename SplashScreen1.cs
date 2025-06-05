using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Hermes;

[DesignerGenerated]
public sealed class SplashScreen1 : Form
{
	private IContainer components;

	[field: AccessedThroughProperty("Version")]
	internal virtual Label Version
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("MainLayoutPanel")]
	internal virtual TableLayoutPanel MainLayoutPanel
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DetailsLayoutPanel")]
	internal virtual TableLayoutPanel DetailsLayoutPanel
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public SplashScreen1()
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hermes.SplashScreen1));
		this.MainLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
		this.DetailsLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
		this.Version = new System.Windows.Forms.Label();
		this.MainLayoutPanel.SuspendLayout();
		this.DetailsLayoutPanel.SuspendLayout();
		base.SuspendLayout();
		this.MainLayoutPanel.BackgroundImage = (System.Drawing.Image)resources.GetObject("MainLayoutPanel.BackgroundImage");
		this.MainLayoutPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
		this.MainLayoutPanel.ColumnCount = 2;
		this.MainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 243f));
		this.MainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100f));
		this.MainLayoutPanel.Controls.Add(this.DetailsLayoutPanel, 1, 1);
		this.MainLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
		this.MainLayoutPanel.Location = new System.Drawing.Point(0, 0);
		this.MainLayoutPanel.Name = "MainLayoutPanel";
		this.MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
		this.MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
		this.MainLayoutPanel.Size = new System.Drawing.Size(496, 218);
		this.MainLayoutPanel.TabIndex = 0;
		this.DetailsLayoutPanel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		this.DetailsLayoutPanel.BackColor = System.Drawing.Color.Transparent;
		this.DetailsLayoutPanel.ColumnCount = 1;
		this.DetailsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 247f));
		this.DetailsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 142f));
		this.DetailsLayoutPanel.Controls.Add(this.Version, 0, 1);
		this.DetailsLayoutPanel.Location = new System.Drawing.Point(280, 118);
		this.DetailsLayoutPanel.Name = "DetailsLayoutPanel";
		this.DetailsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.35052f));
		this.DetailsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.64948f));
		this.DetailsLayoutPanel.Size = new System.Drawing.Size(213, 97);
		this.DetailsLayoutPanel.TabIndex = 1;
		this.Version.Anchor = System.Windows.Forms.AnchorStyles.None;
		this.Version.BackColor = System.Drawing.Color.Transparent;
		this.Version.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Version.ForeColor = System.Drawing.Color.Black;
		this.Version.Location = new System.Drawing.Point(37, 76);
		this.Version.Name = "Version";
		this.Version.Size = new System.Drawing.Size(173, 20);
		this.Version.TabIndex = 1;
		this.Version.Text = "Version {0}.{1:00}";
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(496, 218);
		base.ControlBox = false;
		base.Controls.Add(this.MainLayoutPanel);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "SplashScreen1";
		base.ShowInTaskbar = false;
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.MainLayoutPanel.ResumeLayout(false);
		this.DetailsLayoutPanel.ResumeLayout(false);
		base.ResumeLayout(false);
	}
}
