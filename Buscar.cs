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
public class Buscar : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("buscarbtn")]
	private Button _buscarbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("cancelbtn")]
	private Button _cancelbtn;

	internal virtual Button buscarbtn
	{
		[CompilerGenerated]
		get
		{
			return _buscarbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = buscarbtn_Click;
			Button button = _buscarbtn;
			if (button != null)
			{
				button.Click -= value2;
			}
			_buscarbtn = value;
			button = _buscarbtn;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button cancelbtn
	{
		[CompilerGenerated]
		get
		{
			return _cancelbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = cancelbtn_Click;
			Button button = _cancelbtn;
			if (button != null)
			{
				button.Click -= value2;
			}
			_cancelbtn = value;
			button = _cancelbtn;
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

	[field: AccessedThroughProperty("ComboBox1")]
	internal virtual ComboBox ComboBox1
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

	[field: AccessedThroughProperty("TextBox1")]
	internal virtual TextBox TextBox1
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

	public Buscar()
	{
		base.Load += Buscar_Load;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hermes.Buscar));
		this.buscarbtn = new System.Windows.Forms.Button();
		this.cancelbtn = new System.Windows.Forms.Button();
		this.GroupBox1 = new System.Windows.Forms.GroupBox();
		this.ComboBox1 = new System.Windows.Forms.ComboBox();
		this.GroupBox2 = new System.Windows.Forms.GroupBox();
		this.TextBox1 = new System.Windows.Forms.TextBox();
		this.CheckBox1 = new System.Windows.Forms.CheckBox();
		this.GroupBox1.SuspendLayout();
		this.GroupBox2.SuspendLayout();
		base.SuspendLayout();
		this.buscarbtn.Location = new System.Drawing.Point(12, 136);
		this.buscarbtn.Name = "buscarbtn";
		this.buscarbtn.Size = new System.Drawing.Size(75, 23);
		this.buscarbtn.TabIndex = 0;
		this.buscarbtn.Text = "Buscar";
		this.buscarbtn.UseVisualStyleBackColor = true;
		this.cancelbtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
		this.cancelbtn.Location = new System.Drawing.Point(197, 136);
		this.cancelbtn.Name = "cancelbtn";
		this.cancelbtn.Size = new System.Drawing.Size(75, 23);
		this.cancelbtn.TabIndex = 1;
		this.cancelbtn.Text = "Salir";
		this.cancelbtn.UseVisualStyleBackColor = true;
		this.GroupBox1.Controls.Add(this.ComboBox1);
		this.GroupBox1.Location = new System.Drawing.Point(13, 12);
		this.GroupBox1.Name = "GroupBox1";
		this.GroupBox1.Size = new System.Drawing.Size(259, 56);
		this.GroupBox1.TabIndex = 2;
		this.GroupBox1.TabStop = false;
		this.GroupBox1.Text = "Campo a Buscar";
		this.ComboBox1.FormattingEnabled = true;
		this.ComboBox1.Location = new System.Drawing.Point(6, 19);
		this.ComboBox1.Name = "ComboBox1";
		this.ComboBox1.Size = new System.Drawing.Size(247, 21);
		this.ComboBox1.TabIndex = 0;
		this.GroupBox2.Controls.Add(this.TextBox1);
		this.GroupBox2.Location = new System.Drawing.Point(13, 74);
		this.GroupBox2.Name = "GroupBox2";
		this.GroupBox2.Size = new System.Drawing.Size(259, 56);
		this.GroupBox2.TabIndex = 3;
		this.GroupBox2.TabStop = false;
		this.GroupBox2.Text = "Dato Buscado";
		this.TextBox1.Location = new System.Drawing.Point(6, 19);
		this.TextBox1.Name = "TextBox1";
		this.TextBox1.Size = new System.Drawing.Size(247, 20);
		this.TextBox1.TabIndex = 0;
		this.CheckBox1.AutoSize = true;
		this.CheckBox1.Location = new System.Drawing.Point(93, 140);
		this.CheckBox1.Name = "CheckBox1";
		this.CheckBox1.Size = new System.Drawing.Size(81, 17);
		this.CheckBox1.TabIndex = 4;
		this.CheckBox1.Text = "CheckBox1";
		this.CheckBox1.UseVisualStyleBackColor = true;
		this.CheckBox1.Visible = false;
		base.AcceptButton = this.buscarbtn;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.CancelButton = this.cancelbtn;
		base.ClientSize = new System.Drawing.Size(283, 165);
		base.Controls.Add(this.CheckBox1);
		base.Controls.Add(this.GroupBox2);
		base.Controls.Add(this.GroupBox1);
		base.Controls.Add(this.cancelbtn);
		base.Controls.Add(this.buscarbtn);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.Name = "Buscar";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Buscar";
		this.GroupBox1.ResumeLayout(false);
		this.GroupBox2.ResumeLayout(false);
		this.GroupBox2.PerformLayout();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private void Buscar_Load(object sender, EventArgs e)
	{
		string sql = "SELECT * FROM Planchada LIMIT 1";
		Mod_Sentencias.cargar_datos_combo(sql, ComboBox1);
	}

	private void cancelbtn_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void buscarbtn_Click(object sender, EventArgs e)
	{
		checked
		{
			if (!CheckBox1.Checked)
			{
				try
				{
					if (ComboBox1.SelectedIndex > 0)
					{
						int selectedIndex = ComboBox1.SelectedIndex;
						Explorador explorador = MyProject.Forms.Explorador;
						explorador.ListView1.Items.Find(TextBox1.Text, searchAllSubItems: true);
						explorador.ListView1.Items[0].Focused = true;
						explorador.ListView1.Items[0].Selected = true;
						int num = explorador.ListView1.Items.Count - 1;
						for (int i = 0; i <= num; i++)
						{
							if (Operators.CompareString(explorador.ListView1.Items[i].SubItems[selectedIndex].Text, TextBox1.Text, TextCompare: true) == 0)
							{
								explorador.ListView1.Items[i].Focused = true;
								explorador.ListView1.Items[i].Selected = true;
								explorador.ListView1.Items[i].EnsureVisible();
								Close();
								return;
							}
						}
						explorador = null;
						Interaction.MsgBox("No se encontro el dato");
					}
					else
					{
						Explorador explorador2 = MyProject.Forms.Explorador;
						explorador2.ListView1.Items.Find(TextBox1.Text, searchAllSubItems: true);
						explorador2.ListView1.Items[0].Focused = true;
						explorador2.ListView1.Items[0].Selected = true;
						int num2 = explorador2.ListView1.Items.Count - 1;
						for (int j = 0; j <= num2; j++)
						{
							if (Operators.CompareString(explorador2.ListView1.Items[j].Text, TextBox1.Text, TextCompare: true) == 0)
							{
								explorador2.ListView1.Items[j].Focused = true;
								explorador2.ListView1.Items[j].Selected = true;
								explorador2.ListView1.Items[j].EnsureVisible();
								Close();
								return;
							}
						}
						explorador2 = null;
						Interaction.MsgBox("No se encontro el dato");
					}
					return;
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
					return;
				}
			}
			int num3 = Conversions.ToInteger(Mod_Buscar.buscar_item(1, "planchada", ComboBox1.Text, TextBox1.Text));
		}
	}
}
