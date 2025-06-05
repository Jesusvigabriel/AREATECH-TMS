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
public class Empresas : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("NuevoToolStripButton")]
	private ToolStripButton _NuevoToolStripButton;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStripButton1")]
	private ToolStripButton _ToolStripButton1;

	[field: AccessedThroughProperty("ToolStrip1")]
	internal virtual ToolStrip ToolStrip1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripButton NuevoToolStripButton
	{
		[CompilerGenerated]
		get
		{
			return _NuevoToolStripButton;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = NuevoToolStripButton_Click;
			ToolStripButton nuevoToolStripButton = _NuevoToolStripButton;
			if (nuevoToolStripButton != null)
			{
				nuevoToolStripButton.Click -= value2;
			}
			_NuevoToolStripButton = value;
			nuevoToolStripButton = _NuevoToolStripButton;
			if (nuevoToolStripButton != null)
			{
				nuevoToolStripButton.Click += value2;
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

	internal virtual ToolStripButton ToolStripButton1
	{
		[CompilerGenerated]
		get
		{
			return _ToolStripButton1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ToolStripButton1_Click;
			ToolStripButton toolStripButton = _ToolStripButton1;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value2;
			}
			_ToolStripButton1 = value;
			toolStripButton = _ToolStripButton1;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value2;
			}
		}
	}

	public Empresas()
	{
		base.Load += Empresas_Load;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hermes.Empresas));
		this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
		this.ListView1 = new System.Windows.Forms.ListView();
		this.Label1 = new System.Windows.Forms.Label();
		this.NuevoToolStripButton = new System.Windows.Forms.ToolStripButton();
		this.ToolStripButton1 = new System.Windows.Forms.ToolStripButton();
		this.ToolStrip1.SuspendLayout();
		base.SuspendLayout();
		this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[2] { this.NuevoToolStripButton, this.ToolStripButton1 });
		this.ToolStrip1.Location = new System.Drawing.Point(0, 0);
		this.ToolStrip1.Name = "ToolStrip1";
		this.ToolStrip1.Size = new System.Drawing.Size(951, 25);
		this.ToolStrip1.TabIndex = 0;
		this.ToolStrip1.Text = "ToolStrip1";
		this.ListView1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.ListView1.Location = new System.Drawing.Point(12, 28);
		this.ListView1.Name = "ListView1";
		this.ListView1.Size = new System.Drawing.Size(927, 373);
		this.ListView1.TabIndex = 1;
		this.ListView1.UseCompatibleStateImageBehavior = false;
		this.Label1.AutoSize = true;
		this.Label1.Location = new System.Drawing.Point(900, 9);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(39, 13);
		this.Label1.TabIndex = 2;
		this.Label1.Text = "Label1";
		this.NuevoToolStripButton.Image = (System.Drawing.Image)resources.GetObject("NuevoToolStripButton.Image");
		this.NuevoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.NuevoToolStripButton.Name = "NuevoToolStripButton";
		this.NuevoToolStripButton.Size = new System.Drawing.Size(109, 22);
		this.NuevoToolStripButton.Text = "&Nueva Empresa";
		this.ToolStripButton1.Image = Hermes.My.Resources.Resources.document_edit;
		this.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.ToolStripButton1.Name = "ToolStripButton1";
		this.ToolStripButton1.Size = new System.Drawing.Size(105, 22);
		this.ToolStripButton1.Text = "&Editar Empresa";
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(951, 413);
		base.Controls.Add(this.Label1);
		base.Controls.Add(this.ListView1);
		base.Controls.Add(this.ToolStrip1);
		base.Name = "Empresas";
		this.Text = "Empresas";
		this.ToolStrip1.ResumeLayout(false);
		this.ToolStrip1.PerformLayout();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private void Empresas_Load(object sender, EventArgs e)
	{
		string sql = "Select * from empresas";
		Mod_Sentencias.cargar_datos_lv_completa(ListView1, sql, Label1);
	}

	private void NuevoToolStripButton_Click(object sender, EventArgs e)
	{
		MyProject.Forms.ABMEmpresas.Show(nueva());
	}

	private void ToolStripButton1_Click(object sender, EventArgs e)
	{
		if (ListView1.SelectedItems.Count > 0)
		{
			MyProject.Forms.ABMEmpresas.Show(editar());
		}
		else
		{
			Interaction.MsgBox("Debe seleccionar al menos un registro para editar.");
		}
	}

	private IWin32Window nueva()
	{
		Interaction.MsgBox("Modo nueva");
		return null;
	}

	private IWin32Window editar()
	{
		Interaction.MsgBox("Modo Editar");
		ABMEmpresas aBMEmpresas = MyProject.Forms.ABMEmpresas;
		aBMEmpresas.TbxNumero.Enabled = true;
		aBMEmpresas.CboEstado.Enabled = true;
		aBMEmpresas.TbxRazonSocial.Enabled = true;
		aBMEmpresas.TbxNombreFantasia.Enabled = true;
		aBMEmpresas.CboTipoContribuyente.Enabled = true;
		aBMEmpresas.TbxCuil.Enabled = true;
		aBMEmpresas.TbxIngresos.Enabled = true;
		aBMEmpresas.TbxCalleO.Enabled = true;
		aBMEmpresas.TbxAlturaO.Enabled = true;
		aBMEmpresas.TbxPisoO.Enabled = true;
		aBMEmpresas.TbxDeptoO.Enabled = true;
		aBMEmpresas.TbxBloqueO.Enabled = true;
		aBMEmpresas.TbxCodigoPostalO.Enabled = true;
		aBMEmpresas.TbxLocalidadO.Enabled = true;
		aBMEmpresas.TbxProvinciaO.Enabled = true;
		aBMEmpresas.TbxPaisO.Enabled = true;
		aBMEmpresas.TbxObservacionesO.Enabled = true;
		aBMEmpresas.TbxCalleD.Enabled = true;
		aBMEmpresas.TbxAlturaD.Enabled = true;
		aBMEmpresas.TbxPisoD.Enabled = true;
		aBMEmpresas.TbxDeptoD.Enabled = true;
		aBMEmpresas.TbxBloqueD.Enabled = true;
		aBMEmpresas.TbxCodigoPostalD.Enabled = true;
		aBMEmpresas.TbxLocalidadD.Enabled = true;
		aBMEmpresas.TbxProvinciaD.Enabled = true;
		aBMEmpresas.TbxPaisD.Enabled = true;
		aBMEmpresas.TbxObservacionesD.Enabled = true;
		aBMEmpresas.TbxNombreContactoC.Enabled = true;
		aBMEmpresas.TbxCelularContactoC.Enabled = true;
		aBMEmpresas.TbxEmailContactoC.Enabled = true;
		aBMEmpresas.TbxTelefonoContactoC.Enabled = true;
		aBMEmpresas.TbxCelularContactoC.Enabled = true;
		aBMEmpresas.TbxComentarioContactoC.Enabled = true;
		aBMEmpresas.TbxNombreContactoO.Enabled = true;
		aBMEmpresas.TbxCelularContactoO.Enabled = true;
		aBMEmpresas.TbxEmailContactoO.Enabled = true;
		aBMEmpresas.TbxTelefonoContactoO.Enabled = true;
		aBMEmpresas.TbxCelularContactoO.Enabled = true;
		aBMEmpresas.TbxComentarioContactoO.Enabled = true;
		aBMEmpresas = null;
		return null;
	}
}
