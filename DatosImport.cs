using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Hermes.My;
using Microsoft.VisualBasic.CompilerServices;

namespace Hermes;

[DesignerGenerated]
public class DatosImport : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("OK_Button")]
	private Button _OK_Button;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Cancel_Button")]
	private Button _Cancel_Button;

	[field: AccessedThroughProperty("TableLayoutPanel1")]
	internal virtual TableLayoutPanel TableLayoutPanel1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button OK_Button
	{
		[CompilerGenerated]
		get
		{
			return _OK_Button;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = OK_Button_Click;
			Button oK_Button = _OK_Button;
			if (oK_Button != null)
			{
				oK_Button.Click -= value2;
			}
			_OK_Button = value;
			oK_Button = _OK_Button;
			if (oK_Button != null)
			{
				oK_Button.Click += value2;
			}
		}
	}

	internal virtual Button Cancel_Button
	{
		[CompilerGenerated]
		get
		{
			return _Cancel_Button;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Cancel_Button_Click;
			Button cancel_Button = _Cancel_Button;
			if (cancel_Button != null)
			{
				cancel_Button.Click -= value2;
			}
			_Cancel_Button = value;
			cancel_Button = _Cancel_Button;
			if (cancel_Button != null)
			{
				cancel_Button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("GroupBox1")]
	internal virtual GroupBox GroupBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DateTimePicker1")]
	internal virtual DateTimePicker DateTimePicker1
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

	[field: AccessedThroughProperty("ComboBox1")]
	internal virtual ComboBox ComboBox1
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

	public DatosImport()
	{
		base.Load += DatosImport_Load;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hermes.DatosImport));
		this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
		this.OK_Button = new System.Windows.Forms.Button();
		this.Cancel_Button = new System.Windows.Forms.Button();
		this.GroupBox1 = new System.Windows.Forms.GroupBox();
		this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
		this.Label2 = new System.Windows.Forms.Label();
		this.ComboBox1 = new System.Windows.Forms.ComboBox();
		this.Label1 = new System.Windows.Forms.Label();
		this.TableLayoutPanel1.SuspendLayout();
		this.GroupBox1.SuspendLayout();
		base.SuspendLayout();
		this.TableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		this.TableLayoutPanel1.ColumnCount = 2;
		this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50f));
		this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50f));
		this.TableLayoutPanel1.Controls.Add(this.OK_Button, 0, 0);
		this.TableLayoutPanel1.Controls.Add(this.Cancel_Button, 1, 0);
		this.TableLayoutPanel1.Location = new System.Drawing.Point(97, 132);
		this.TableLayoutPanel1.Name = "TableLayoutPanel1";
		this.TableLayoutPanel1.RowCount = 1;
		this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50f));
		this.TableLayoutPanel1.Size = new System.Drawing.Size(146, 29);
		this.TableLayoutPanel1.TabIndex = 0;
		this.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
		this.OK_Button.Location = new System.Drawing.Point(3, 3);
		this.OK_Button.Name = "OK_Button";
		this.OK_Button.Size = new System.Drawing.Size(67, 23);
		this.OK_Button.TabIndex = 0;
		this.OK_Button.Text = "OK";
		this.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
		this.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
		this.Cancel_Button.Location = new System.Drawing.Point(76, 3);
		this.Cancel_Button.Name = "Cancel_Button";
		this.Cancel_Button.Size = new System.Drawing.Size(67, 23);
		this.Cancel_Button.TabIndex = 1;
		this.Cancel_Button.Text = "Cancel";
		this.GroupBox1.Controls.Add(this.DateTimePicker1);
		this.GroupBox1.Controls.Add(this.Label2);
		this.GroupBox1.Controls.Add(this.ComboBox1);
		this.GroupBox1.Controls.Add(this.Label1);
		this.GroupBox1.Location = new System.Drawing.Point(12, 12);
		this.GroupBox1.Name = "GroupBox1";
		this.GroupBox1.Size = new System.Drawing.Size(231, 111);
		this.GroupBox1.TabIndex = 1;
		this.GroupBox1.TabStop = false;
		this.GroupBox1.Text = "Datos";
		this.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
		this.DateTimePicker1.Location = new System.Drawing.Point(120, 66);
		this.DateTimePicker1.Name = "DateTimePicker1";
		this.DateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.No;
		this.DateTimePicker1.Size = new System.Drawing.Size(99, 20);
		this.DateTimePicker1.TabIndex = 3;
		this.Label2.AutoSize = true;
		this.Label2.Location = new System.Drawing.Point(18, 72);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(92, 13);
		this.Label2.TabIndex = 2;
		this.Label2.Text = "Fecha Despacho:";
		this.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.ComboBox1.FormattingEnabled = true;
		this.ComboBox1.Items.AddRange(new object[3] { "1", "2", "3" });
		this.ComboBox1.Location = new System.Drawing.Point(123, 29);
		this.ComboBox1.Name = "ComboBox1";
		this.ComboBox1.Size = new System.Drawing.Size(48, 21);
		this.ComboBox1.TabIndex = 1;
		this.ComboBox1.Visible = false;
		this.Label1.AutoSize = true;
		this.Label1.Location = new System.Drawing.Point(18, 32);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(50, 13);
		this.Label1.TabIndex = 0;
		this.Label1.Text = "Ventana:";
		this.Label1.Visible = false;
		base.AcceptButton = this.OK_Button;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.CancelButton = this.Cancel_Button;
		base.ClientSize = new System.Drawing.Size(255, 173);
		base.Controls.Add(this.GroupBox1);
		base.Controls.Add(this.TableLayoutPanel1);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "DatosImport";
		base.ShowInTaskbar = false;
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Importacion";
		this.TableLayoutPanel1.ResumeLayout(false);
		this.GroupBox1.ResumeLayout(false);
		this.GroupBox1.PerformLayout();
		base.ResumeLayout(false);
	}

	private void OK_Button_Click(object sender, EventArgs e)
	{
		MyProject.Forms.Form1_Inicio.DateTimePicker1.Value = DateTimePicker1.Value;
		MyProject.Forms.Form1_Inicio.ComboBox1.SelectedIndex = ComboBox1.SelectedIndex;
		base.DialogResult = DialogResult.OK;
		base.Visible = false;
		Mod_Importar.importar_mysql_sin_duplicados();
		Close();
	}

	private void Cancel_Button_Click(object sender, EventArgs e)
	{
		base.DialogResult = DialogResult.Cancel;
		Close();
	}

	private void DatosImport_Load(object sender, EventArgs e)
	{
		DateTimePicker1.Value = MyProject.Forms.Form1_Inicio.DateTimePicker1.Value;
		ComboBox1.SelectedIndex = 0;
	}
}
