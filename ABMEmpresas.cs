using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Hermes;

[DesignerGenerated]
public class ABMEmpresas : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("TbxNombreFantasia")]
	private TextBox _TbxNombreFantasia;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("TbxRazonSocial")]
	private TextBox _TbxRazonSocial;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("TbxNumero")]
	private TextBox _TbxNumero;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("CboEstado")]
	private ComboBox _CboEstado;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	[field: AccessedThroughProperty("GroupBox1")]
	internal virtual GroupBox GroupBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TbxCuil")]
	internal virtual TextBox TbxCuil
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("LblCuit")]
	internal virtual Label LblCuit
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CboTipoContribuyente")]
	internal virtual ComboBox CboTipoContribuyente
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("LblContribuyente")]
	internal virtual Label LblContribuyente
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual TextBox TbxNombreFantasia
	{
		[CompilerGenerated]
		get
		{
			return _TbxNombreFantasia;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			KeyEventHandler value2 = TbxNombreFantasia_KeyUp;
			TextBox tbxNombreFantasia = _TbxNombreFantasia;
			if (tbxNombreFantasia != null)
			{
				tbxNombreFantasia.KeyUp -= value2;
			}
			_TbxNombreFantasia = value;
			tbxNombreFantasia = _TbxNombreFantasia;
			if (tbxNombreFantasia != null)
			{
				tbxNombreFantasia.KeyUp += value2;
			}
		}
	}

	[field: AccessedThroughProperty("LblNombreFantasia")]
	internal virtual Label LblNombreFantasia
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual TextBox TbxRazonSocial
	{
		[CompilerGenerated]
		get
		{
			return _TbxRazonSocial;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = TbxRazonSocial_GotFocus;
			TextBox tbxRazonSocial = _TbxRazonSocial;
			if (tbxRazonSocial != null)
			{
				tbxRazonSocial.GotFocus -= value2;
			}
			_TbxRazonSocial = value;
			tbxRazonSocial = _TbxRazonSocial;
			if (tbxRazonSocial != null)
			{
				tbxRazonSocial.GotFocus += value2;
			}
		}
	}

	[field: AccessedThroughProperty("LblRazonSocial")]
	internal virtual Label LblRazonSocial
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual TextBox TbxNumero
	{
		[CompilerGenerated]
		get
		{
			return _TbxNumero;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = TbxNumero_GotFocus;
			TextBox tbxNumero = _TbxNumero;
			if (tbxNumero != null)
			{
				tbxNumero.GotFocus -= value2;
			}
			_TbxNumero = value;
			tbxNumero = _TbxNumero;
			if (tbxNumero != null)
			{
				tbxNumero.GotFocus += value2;
			}
		}
	}

	[field: AccessedThroughProperty("LblNumero")]
	internal virtual Label LblNumero
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TbxIngresos")]
	internal virtual TextBox TbxIngresos
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("LblIngresosBrutos")]
	internal virtual Label LblIngresosBrutos
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TabControl1")]
	internal virtual TabControl TabControl1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TabPage1")]
	internal virtual TabPage TabPage1
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

	[field: AccessedThroughProperty("TabPage2")]
	internal virtual TabPage TabPage2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TabPage3")]
	internal virtual TabPage TabPage3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("GroupBox4")]
	internal virtual GroupBox GroupBox4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TbxObservacionesD")]
	internal virtual TextBox TbxObservacionesD
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

	[field: AccessedThroughProperty("TbxPaisD")]
	internal virtual TextBox TbxPaisD
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

	[field: AccessedThroughProperty("TbxProvinciaD")]
	internal virtual TextBox TbxProvinciaD
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

	[field: AccessedThroughProperty("TbxLocalidadD")]
	internal virtual TextBox TbxLocalidadD
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

	[field: AccessedThroughProperty("TbxCodigoPostalD")]
	internal virtual TextBox TbxCodigoPostalD
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

	[field: AccessedThroughProperty("TbxBloqueD")]
	internal virtual TextBox TbxBloqueD
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

	[field: AccessedThroughProperty("TbxDeptoD")]
	internal virtual TextBox TbxDeptoD
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

	[field: AccessedThroughProperty("TbxPisoD")]
	internal virtual TextBox TbxPisoD
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

	[field: AccessedThroughProperty("TbxAlturaD")]
	internal virtual TextBox TbxAlturaD
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

	[field: AccessedThroughProperty("TbxCalleD")]
	internal virtual TextBox TbxCalleD
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

	[field: AccessedThroughProperty("TbxObservacionesO")]
	internal virtual TextBox TbxObservacionesO
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("LblObservaciones")]
	internal virtual Label LblObservaciones
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TbxPaisO")]
	internal virtual TextBox TbxPaisO
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("LblPais")]
	internal virtual Label LblPais
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TbxProvinciaO")]
	internal virtual TextBox TbxProvinciaO
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("LblProvincia")]
	internal virtual Label LblProvincia
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TbxLocalidadO")]
	internal virtual TextBox TbxLocalidadO
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("LblLocalidad")]
	internal virtual Label LblLocalidad
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TbxCodigoPostalO")]
	internal virtual TextBox TbxCodigoPostalO
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("LblCodigoPostal")]
	internal virtual Label LblCodigoPostal
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TbxBloqueO")]
	internal virtual TextBox TbxBloqueO
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("LblBloque")]
	internal virtual Label LblBloque
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TbxDeptoO")]
	internal virtual TextBox TbxDeptoO
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("LableDepto")]
	internal virtual Label LableDepto
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TbxPisoO")]
	internal virtual TextBox TbxPisoO
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Lblpiso")]
	internal virtual Label Lblpiso
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TbxAlturaO")]
	internal virtual TextBox TbxAlturaO
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("LblAltura")]
	internal virtual Label LblAltura
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TbxCalleO")]
	internal virtual TextBox TbxCalleO
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("LblCalle")]
	internal virtual Label LblCalle
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ComboBox CboEstado
	{
		[CompilerGenerated]
		get
		{
			return _CboEstado;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = CboEstado_GotFocus;
			ComboBox cboEstado = _CboEstado;
			if (cboEstado != null)
			{
				cboEstado.GotFocus -= value2;
			}
			_CboEstado = value;
			cboEstado = _CboEstado;
			if (cboEstado != null)
			{
				cboEstado.GotFocus += value2;
			}
		}
	}

	[field: AccessedThroughProperty("LblEstado")]
	internal virtual Label LblEstado
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Button1
	{
		[CompilerGenerated]
		get
		{
			return _Button1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button1_Click;
			Button button = _Button1;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button1 = value;
			button = _Button1;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button2
	{
		[CompilerGenerated]
		get
		{
			return _Button2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button2_Click;
			Button button = _Button2;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button2 = value;
			button = _Button2;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("GroupBox3")]
	internal virtual GroupBox GroupBox3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TbxComentarioContactoC")]
	internal virtual TextBox TbxComentarioContactoC
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("LblComentarioContacto")]
	internal virtual Label LblComentarioContacto
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TbxCelularContactoC")]
	internal virtual TextBox TbxCelularContactoC
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("LblCelularContacto")]
	internal virtual Label LblCelularContacto
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TbxTelefonoContactoC")]
	internal virtual TextBox TbxTelefonoContactoC
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("LblTelefonoContacto")]
	internal virtual Label LblTelefonoContacto
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TbxEmailContactoC")]
	internal virtual TextBox TbxEmailContactoC
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("LblEmailContacto")]
	internal virtual Label LblEmailContacto
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TbxNombreContactoC")]
	internal virtual TextBox TbxNombreContactoC
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("LblNombreContacto")]
	internal virtual Label LblNombreContacto
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("LblIdContactoC")]
	internal virtual Label LblIdContactoC
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("GroupBox5")]
	internal virtual GroupBox GroupBox5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TbxComentarioContactoO")]
	internal virtual TextBox TbxComentarioContactoO
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("LblContactoO")]
	internal virtual Label LblContactoO
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

	[field: AccessedThroughProperty("TbxCelularContactoO")]
	internal virtual TextBox TbxCelularContactoO
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

	[field: AccessedThroughProperty("TbxTelefonoContactoO")]
	internal virtual TextBox TbxTelefonoContactoO
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

	[field: AccessedThroughProperty("TbxEmailContactoO")]
	internal virtual TextBox TbxEmailContactoO
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

	[field: AccessedThroughProperty("TbxNombreContactoO")]
	internal virtual TextBox TbxNombreContactoO
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

	[field: AccessedThroughProperty("GroupBox8")]
	internal virtual GroupBox GroupBox8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("GroupBox7")]
	internal virtual GroupBox GroupBox7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("GroupBox6")]
	internal virtual GroupBox GroupBox6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("StatusStrip1")]
	internal virtual StatusStrip StatusStrip1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ToolStripStatusLabel1")]
	internal virtual ToolStripStatusLabel ToolStripStatusLabel1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public ABMEmpresas()
	{
		base.Load += ABMEmpresas_Load;
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
		this.CboEstado = new System.Windows.Forms.ComboBox();
		this.LblEstado = new System.Windows.Forms.Label();
		this.TbxIngresos = new System.Windows.Forms.TextBox();
		this.LblIngresosBrutos = new System.Windows.Forms.Label();
		this.TbxCuil = new System.Windows.Forms.TextBox();
		this.LblCuit = new System.Windows.Forms.Label();
		this.CboTipoContribuyente = new System.Windows.Forms.ComboBox();
		this.LblContribuyente = new System.Windows.Forms.Label();
		this.TbxNombreFantasia = new System.Windows.Forms.TextBox();
		this.LblNombreFantasia = new System.Windows.Forms.Label();
		this.TbxRazonSocial = new System.Windows.Forms.TextBox();
		this.LblRazonSocial = new System.Windows.Forms.Label();
		this.TbxNumero = new System.Windows.Forms.TextBox();
		this.LblNumero = new System.Windows.Forms.Label();
		this.TabControl1 = new System.Windows.Forms.TabControl();
		this.TabPage1 = new System.Windows.Forms.TabPage();
		this.GroupBox4 = new System.Windows.Forms.GroupBox();
		this.TbxObservacionesD = new System.Windows.Forms.TextBox();
		this.Label1 = new System.Windows.Forms.Label();
		this.TbxPaisD = new System.Windows.Forms.TextBox();
		this.Label2 = new System.Windows.Forms.Label();
		this.TbxProvinciaD = new System.Windows.Forms.TextBox();
		this.Label3 = new System.Windows.Forms.Label();
		this.TbxLocalidadD = new System.Windows.Forms.TextBox();
		this.Label4 = new System.Windows.Forms.Label();
		this.TbxCodigoPostalD = new System.Windows.Forms.TextBox();
		this.Label5 = new System.Windows.Forms.Label();
		this.TbxBloqueD = new System.Windows.Forms.TextBox();
		this.Label6 = new System.Windows.Forms.Label();
		this.TbxDeptoD = new System.Windows.Forms.TextBox();
		this.Label7 = new System.Windows.Forms.Label();
		this.TbxPisoD = new System.Windows.Forms.TextBox();
		this.Label8 = new System.Windows.Forms.Label();
		this.TbxAlturaD = new System.Windows.Forms.TextBox();
		this.Label9 = new System.Windows.Forms.Label();
		this.TbxCalleD = new System.Windows.Forms.TextBox();
		this.Label10 = new System.Windows.Forms.Label();
		this.GroupBox2 = new System.Windows.Forms.GroupBox();
		this.TbxObservacionesO = new System.Windows.Forms.TextBox();
		this.LblObservaciones = new System.Windows.Forms.Label();
		this.TbxPaisO = new System.Windows.Forms.TextBox();
		this.LblPais = new System.Windows.Forms.Label();
		this.TbxProvinciaO = new System.Windows.Forms.TextBox();
		this.LblProvincia = new System.Windows.Forms.Label();
		this.TbxLocalidadO = new System.Windows.Forms.TextBox();
		this.LblLocalidad = new System.Windows.Forms.Label();
		this.TbxCodigoPostalO = new System.Windows.Forms.TextBox();
		this.LblCodigoPostal = new System.Windows.Forms.Label();
		this.TbxBloqueO = new System.Windows.Forms.TextBox();
		this.LblBloque = new System.Windows.Forms.Label();
		this.TbxDeptoO = new System.Windows.Forms.TextBox();
		this.LableDepto = new System.Windows.Forms.Label();
		this.TbxPisoO = new System.Windows.Forms.TextBox();
		this.Lblpiso = new System.Windows.Forms.Label();
		this.TbxAlturaO = new System.Windows.Forms.TextBox();
		this.LblAltura = new System.Windows.Forms.Label();
		this.TbxCalleO = new System.Windows.Forms.TextBox();
		this.LblCalle = new System.Windows.Forms.Label();
		this.TabPage2 = new System.Windows.Forms.TabPage();
		this.GroupBox5 = new System.Windows.Forms.GroupBox();
		this.TbxComentarioContactoO = new System.Windows.Forms.TextBox();
		this.LblContactoO = new System.Windows.Forms.Label();
		this.Label12 = new System.Windows.Forms.Label();
		this.TbxCelularContactoO = new System.Windows.Forms.TextBox();
		this.Label13 = new System.Windows.Forms.Label();
		this.TbxTelefonoContactoO = new System.Windows.Forms.TextBox();
		this.Label14 = new System.Windows.Forms.Label();
		this.TbxEmailContactoO = new System.Windows.Forms.TextBox();
		this.Label15 = new System.Windows.Forms.Label();
		this.TbxNombreContactoO = new System.Windows.Forms.TextBox();
		this.Label16 = new System.Windows.Forms.Label();
		this.GroupBox3 = new System.Windows.Forms.GroupBox();
		this.TbxComentarioContactoC = new System.Windows.Forms.TextBox();
		this.LblIdContactoC = new System.Windows.Forms.Label();
		this.LblComentarioContacto = new System.Windows.Forms.Label();
		this.TbxCelularContactoC = new System.Windows.Forms.TextBox();
		this.LblCelularContacto = new System.Windows.Forms.Label();
		this.TbxTelefonoContactoC = new System.Windows.Forms.TextBox();
		this.LblTelefonoContacto = new System.Windows.Forms.Label();
		this.TbxEmailContactoC = new System.Windows.Forms.TextBox();
		this.LblEmailContacto = new System.Windows.Forms.Label();
		this.TbxNombreContactoC = new System.Windows.Forms.TextBox();
		this.LblNombreContacto = new System.Windows.Forms.Label();
		this.TabPage3 = new System.Windows.Forms.TabPage();
		this.GroupBox8 = new System.Windows.Forms.GroupBox();
		this.GroupBox7 = new System.Windows.Forms.GroupBox();
		this.GroupBox6 = new System.Windows.Forms.GroupBox();
		this.Button1 = new System.Windows.Forms.Button();
		this.Button2 = new System.Windows.Forms.Button();
		this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
		this.ToolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
		this.GroupBox1.SuspendLayout();
		this.TabControl1.SuspendLayout();
		this.TabPage1.SuspendLayout();
		this.GroupBox4.SuspendLayout();
		this.GroupBox2.SuspendLayout();
		this.TabPage2.SuspendLayout();
		this.GroupBox5.SuspendLayout();
		this.GroupBox3.SuspendLayout();
		this.TabPage3.SuspendLayout();
		this.StatusStrip1.SuspendLayout();
		base.SuspendLayout();
		this.GroupBox1.Controls.Add(this.CboEstado);
		this.GroupBox1.Controls.Add(this.LblEstado);
		this.GroupBox1.Controls.Add(this.TbxIngresos);
		this.GroupBox1.Controls.Add(this.LblIngresosBrutos);
		this.GroupBox1.Controls.Add(this.TbxCuil);
		this.GroupBox1.Controls.Add(this.LblCuit);
		this.GroupBox1.Controls.Add(this.CboTipoContribuyente);
		this.GroupBox1.Controls.Add(this.LblContribuyente);
		this.GroupBox1.Controls.Add(this.TbxNombreFantasia);
		this.GroupBox1.Controls.Add(this.LblNombreFantasia);
		this.GroupBox1.Controls.Add(this.TbxRazonSocial);
		this.GroupBox1.Controls.Add(this.LblRazonSocial);
		this.GroupBox1.Controls.Add(this.TbxNumero);
		this.GroupBox1.Controls.Add(this.LblNumero);
		this.GroupBox1.Location = new System.Drawing.Point(12, 12);
		this.GroupBox1.Name = "GroupBox1";
		this.GroupBox1.Size = new System.Drawing.Size(700, 104);
		this.GroupBox1.TabIndex = 0;
		this.GroupBox1.TabStop = false;
		this.CboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.CboEstado.Enabled = false;
		this.CboEstado.FormattingEnabled = true;
		this.CboEstado.Items.AddRange(new object[2] { "Activo", "Inactivo" });
		this.CboEstado.Location = new System.Drawing.Point(284, 22);
		this.CboEstado.Name = "CboEstado";
		this.CboEstado.RightToLeft = System.Windows.Forms.RightToLeft.No;
		this.CboEstado.Size = new System.Drawing.Size(97, 21);
		this.CboEstado.TabIndex = 13;
		this.LblEstado.AutoSize = true;
		this.LblEstado.Location = new System.Drawing.Point(235, 25);
		this.LblEstado.Name = "LblEstado";
		this.LblEstado.Size = new System.Drawing.Size(43, 13);
		this.LblEstado.TabIndex = 12;
		this.LblEstado.Text = "Estado:";
		this.TbxIngresos.Enabled = false;
		this.TbxIngresos.Location = new System.Drawing.Point(504, 73);
		this.TbxIngresos.Name = "TbxIngresos";
		this.TbxIngresos.Size = new System.Drawing.Size(182, 20);
		this.TbxIngresos.TabIndex = 11;
		this.LblIngresosBrutos.AutoSize = true;
		this.LblIngresosBrutos.Location = new System.Drawing.Point(399, 76);
		this.LblIngresosBrutos.Name = "LblIngresosBrutos";
		this.LblIngresosBrutos.Size = new System.Drawing.Size(83, 13);
		this.LblIngresosBrutos.TabIndex = 10;
		this.LblIngresosBrutos.Text = "Ingresos Brutos:";
		this.TbxCuil.Enabled = false;
		this.TbxCuil.Location = new System.Drawing.Point(504, 47);
		this.TbxCuil.Name = "TbxCuil";
		this.TbxCuil.Size = new System.Drawing.Size(182, 20);
		this.TbxCuil.TabIndex = 9;
		this.LblCuit.AutoSize = true;
		this.LblCuit.Location = new System.Drawing.Point(399, 50);
		this.LblCuit.Name = "LblCuit";
		this.LblCuit.Size = new System.Drawing.Size(85, 13);
		this.LblCuit.TabIndex = 8;
		this.LblCuit.Text = "C.U.I.L./C.U.I.T.";
		this.CboTipoContribuyente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.CboTipoContribuyente.Enabled = false;
		this.CboTipoContribuyente.FormattingEnabled = true;
		this.CboTipoContribuyente.Items.AddRange(new object[3] { "Monotributista", "Responsable Inscripto", "Consumidor Final" });
		this.CboTipoContribuyente.Location = new System.Drawing.Point(504, 21);
		this.CboTipoContribuyente.Name = "CboTipoContribuyente";
		this.CboTipoContribuyente.Size = new System.Drawing.Size(182, 21);
		this.CboTipoContribuyente.TabIndex = 7;
		this.LblContribuyente.AutoSize = true;
		this.LblContribuyente.Location = new System.Drawing.Point(399, 24);
		this.LblContribuyente.Name = "LblContribuyente";
		this.LblContribuyente.Size = new System.Drawing.Size(99, 13);
		this.LblContribuyente.TabIndex = 6;
		this.LblContribuyente.Text = "Tipo Contribuyente:";
		this.TbxNombreFantasia.Enabled = false;
		this.TbxNombreFantasia.Location = new System.Drawing.Point(110, 73);
		this.TbxNombreFantasia.Name = "TbxNombreFantasia";
		this.TbxNombreFantasia.Size = new System.Drawing.Size(271, 20);
		this.TbxNombreFantasia.TabIndex = 5;
		this.LblNombreFantasia.AutoSize = true;
		this.LblNombreFantasia.Location = new System.Drawing.Point(14, 76);
		this.LblNombreFantasia.Name = "LblNombreFantasia";
		this.LblNombreFantasia.Size = new System.Drawing.Size(90, 13);
		this.LblNombreFantasia.TabIndex = 4;
		this.LblNombreFantasia.Text = "Nombre Fantasia:";
		this.TbxRazonSocial.Enabled = false;
		this.TbxRazonSocial.Location = new System.Drawing.Point(110, 47);
		this.TbxRazonSocial.Name = "TbxRazonSocial";
		this.TbxRazonSocial.Size = new System.Drawing.Size(271, 20);
		this.TbxRazonSocial.TabIndex = 3;
		this.LblRazonSocial.AutoSize = true;
		this.LblRazonSocial.Location = new System.Drawing.Point(14, 50);
		this.LblRazonSocial.Name = "LblRazonSocial";
		this.LblRazonSocial.Size = new System.Drawing.Size(73, 13);
		this.LblRazonSocial.TabIndex = 2;
		this.LblRazonSocial.Text = "Razón Social:";
		this.TbxNumero.Enabled = false;
		this.TbxNumero.Location = new System.Drawing.Point(110, 22);
		this.TbxNumero.Name = "TbxNumero";
		this.TbxNumero.Size = new System.Drawing.Size(119, 20);
		this.TbxNumero.TabIndex = 1;
		this.LblNumero.AutoSize = true;
		this.LblNumero.Location = new System.Drawing.Point(14, 24);
		this.LblNumero.Name = "LblNumero";
		this.LblNumero.Size = new System.Drawing.Size(47, 13);
		this.LblNumero.TabIndex = 0;
		this.LblNumero.Text = "Número:";
		this.TabControl1.Controls.Add(this.TabPage1);
		this.TabControl1.Controls.Add(this.TabPage2);
		this.TabControl1.Controls.Add(this.TabPage3);
		this.TabControl1.Location = new System.Drawing.Point(12, 122);
		this.TabControl1.Name = "TabControl1";
		this.TabControl1.SelectedIndex = 0;
		this.TabControl1.Size = new System.Drawing.Size(700, 309);
		this.TabControl1.TabIndex = 1;
		this.TabPage1.BackColor = System.Drawing.SystemColors.Control;
		this.TabPage1.Controls.Add(this.GroupBox4);
		this.TabPage1.Controls.Add(this.GroupBox2);
		this.TabPage1.Location = new System.Drawing.Point(4, 22);
		this.TabPage1.Name = "TabPage1";
		this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
		this.TabPage1.Size = new System.Drawing.Size(692, 283);
		this.TabPage1.TabIndex = 0;
		this.TabPage1.Text = "Direcciónes";
		this.GroupBox4.Controls.Add(this.TbxObservacionesD);
		this.GroupBox4.Controls.Add(this.Label1);
		this.GroupBox4.Controls.Add(this.TbxPaisD);
		this.GroupBox4.Controls.Add(this.Label2);
		this.GroupBox4.Controls.Add(this.TbxProvinciaD);
		this.GroupBox4.Controls.Add(this.Label3);
		this.GroupBox4.Controls.Add(this.TbxLocalidadD);
		this.GroupBox4.Controls.Add(this.Label4);
		this.GroupBox4.Controls.Add(this.TbxCodigoPostalD);
		this.GroupBox4.Controls.Add(this.Label5);
		this.GroupBox4.Controls.Add(this.TbxBloqueD);
		this.GroupBox4.Controls.Add(this.Label6);
		this.GroupBox4.Controls.Add(this.TbxDeptoD);
		this.GroupBox4.Controls.Add(this.Label7);
		this.GroupBox4.Controls.Add(this.TbxPisoD);
		this.GroupBox4.Controls.Add(this.Label8);
		this.GroupBox4.Controls.Add(this.TbxAlturaD);
		this.GroupBox4.Controls.Add(this.Label9);
		this.GroupBox4.Controls.Add(this.TbxCalleD);
		this.GroupBox4.Controls.Add(this.Label10);
		this.GroupBox4.Location = new System.Drawing.Point(11, 145);
		this.GroupBox4.Name = "GroupBox4";
		this.GroupBox4.Size = new System.Drawing.Size(671, 127);
		this.GroupBox4.TabIndex = 20;
		this.GroupBox4.TabStop = false;
		this.GroupBox4.Text = "Deposito";
		this.TbxObservacionesD.Enabled = false;
		this.TbxObservacionesD.Location = new System.Drawing.Point(99, 97);
		this.TbxObservacionesD.Name = "TbxObservacionesD";
		this.TbxObservacionesD.Size = new System.Drawing.Size(547, 20);
		this.TbxObservacionesD.TabIndex = 19;
		this.Label1.AutoSize = true;
		this.Label1.Location = new System.Drawing.Point(12, 100);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(81, 13);
		this.Label1.TabIndex = 18;
		this.Label1.Text = "Observaciones:";
		this.TbxPaisD.Enabled = false;
		this.TbxPaisD.Location = new System.Drawing.Point(539, 71);
		this.TbxPaisD.Name = "TbxPaisD";
		this.TbxPaisD.Size = new System.Drawing.Size(100, 20);
		this.TbxPaisD.TabIndex = 17;
		this.Label2.AutoSize = true;
		this.Label2.Location = new System.Drawing.Point(501, 74);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(30, 13);
		this.Label2.TabIndex = 16;
		this.Label2.Text = "Pais:";
		this.TbxProvinciaD.Enabled = false;
		this.TbxProvinciaD.Location = new System.Drawing.Point(320, 71);
		this.TbxProvinciaD.Name = "TbxProvinciaD";
		this.TbxProvinciaD.Size = new System.Drawing.Size(165, 20);
		this.TbxProvinciaD.TabIndex = 15;
		this.Label3.AutoSize = true;
		this.Label3.Location = new System.Drawing.Point(260, 74);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(54, 13);
		this.Label3.TabIndex = 14;
		this.Label3.Text = "Provincia:";
		this.TbxLocalidadD.Enabled = false;
		this.TbxLocalidadD.Location = new System.Drawing.Point(83, 71);
		this.TbxLocalidadD.Name = "TbxLocalidadD";
		this.TbxLocalidadD.Size = new System.Drawing.Size(166, 20);
		this.TbxLocalidadD.TabIndex = 13;
		this.Label4.AutoSize = true;
		this.Label4.Location = new System.Drawing.Point(17, 74);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(56, 13);
		this.Label4.TabIndex = 12;
		this.Label4.Text = "Localidad:";
		this.TbxCodigoPostalD.Enabled = false;
		this.TbxCodigoPostalD.Location = new System.Drawing.Point(527, 45);
		this.TbxCodigoPostalD.Name = "TbxCodigoPostalD";
		this.TbxCodigoPostalD.Size = new System.Drawing.Size(119, 20);
		this.TbxCodigoPostalD.TabIndex = 11;
		this.Label5.AutoSize = true;
		this.Label5.Location = new System.Drawing.Point(446, 48);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(75, 13);
		this.Label5.TabIndex = 10;
		this.Label5.Text = "Codigo Postal:";
		this.TbxBloqueD.Enabled = false;
		this.TbxBloqueD.Location = new System.Drawing.Point(284, 45);
		this.TbxBloqueD.Name = "TbxBloqueD";
		this.TbxBloqueD.Size = new System.Drawing.Size(100, 20);
		this.TbxBloqueD.TabIndex = 9;
		this.Label6.AutoSize = true;
		this.Label6.Location = new System.Drawing.Point(235, 48);
		this.Label6.Name = "Label6";
		this.Label6.Size = new System.Drawing.Size(43, 13);
		this.Label6.TabIndex = 8;
		this.Label6.Text = "Bloque:";
		this.TbxDeptoD.Enabled = false;
		this.TbxDeptoD.Location = new System.Drawing.Point(95, 45);
		this.TbxDeptoD.Name = "TbxDeptoD";
		this.TbxDeptoD.Size = new System.Drawing.Size(100, 20);
		this.TbxDeptoD.TabIndex = 7;
		this.Label7.AutoSize = true;
		this.Label7.Location = new System.Drawing.Point(12, 48);
		this.Label7.Name = "Label7";
		this.Label7.Size = new System.Drawing.Size(77, 13);
		this.Label7.TabIndex = 6;
		this.Label7.Text = "Depto/Oficina:";
		this.TbxPisoD.Enabled = false;
		this.TbxPisoD.Location = new System.Drawing.Point(585, 19);
		this.TbxPisoD.Name = "TbxPisoD";
		this.TbxPisoD.Size = new System.Drawing.Size(61, 20);
		this.TbxPisoD.TabIndex = 5;
		this.Label8.AutoSize = true;
		this.Label8.Location = new System.Drawing.Point(549, 22);
		this.Label8.Name = "Label8";
		this.Label8.Size = new System.Drawing.Size(30, 13);
		this.Label8.TabIndex = 4;
		this.Label8.Text = "Piso:";
		this.TbxAlturaD.Enabled = false;
		this.TbxAlturaD.Location = new System.Drawing.Point(440, 19);
		this.TbxAlturaD.Name = "TbxAlturaD";
		this.TbxAlturaD.Size = new System.Drawing.Size(100, 20);
		this.TbxAlturaD.TabIndex = 3;
		this.Label9.AutoSize = true;
		this.Label9.Location = new System.Drawing.Point(397, 22);
		this.Label9.Name = "Label9";
		this.Label9.Size = new System.Drawing.Size(37, 13);
		this.Label9.TabIndex = 2;
		this.Label9.Text = "Altura:";
		this.TbxCalleD.Enabled = false;
		this.TbxCalleD.Location = new System.Drawing.Point(45, 19);
		this.TbxCalleD.Name = "TbxCalleD";
		this.TbxCalleD.Size = new System.Drawing.Size(339, 20);
		this.TbxCalleD.TabIndex = 1;
		this.Label10.AutoSize = true;
		this.Label10.Location = new System.Drawing.Point(6, 22);
		this.Label10.Name = "Label10";
		this.Label10.Size = new System.Drawing.Size(33, 13);
		this.Label10.TabIndex = 0;
		this.Label10.Text = "Calle:";
		this.GroupBox2.Controls.Add(this.TbxObservacionesO);
		this.GroupBox2.Controls.Add(this.LblObservaciones);
		this.GroupBox2.Controls.Add(this.TbxPaisO);
		this.GroupBox2.Controls.Add(this.LblPais);
		this.GroupBox2.Controls.Add(this.TbxProvinciaO);
		this.GroupBox2.Controls.Add(this.LblProvincia);
		this.GroupBox2.Controls.Add(this.TbxLocalidadO);
		this.GroupBox2.Controls.Add(this.LblLocalidad);
		this.GroupBox2.Controls.Add(this.TbxCodigoPostalO);
		this.GroupBox2.Controls.Add(this.LblCodigoPostal);
		this.GroupBox2.Controls.Add(this.TbxBloqueO);
		this.GroupBox2.Controls.Add(this.LblBloque);
		this.GroupBox2.Controls.Add(this.TbxDeptoO);
		this.GroupBox2.Controls.Add(this.LableDepto);
		this.GroupBox2.Controls.Add(this.TbxPisoO);
		this.GroupBox2.Controls.Add(this.Lblpiso);
		this.GroupBox2.Controls.Add(this.TbxAlturaO);
		this.GroupBox2.Controls.Add(this.LblAltura);
		this.GroupBox2.Controls.Add(this.TbxCalleO);
		this.GroupBox2.Controls.Add(this.LblCalle);
		this.GroupBox2.Location = new System.Drawing.Point(11, 11);
		this.GroupBox2.Name = "GroupBox2";
		this.GroupBox2.Size = new System.Drawing.Size(671, 128);
		this.GroupBox2.TabIndex = 0;
		this.GroupBox2.TabStop = false;
		this.GroupBox2.Text = "Facturación";
		this.TbxObservacionesO.Enabled = false;
		this.TbxObservacionesO.Location = new System.Drawing.Point(99, 97);
		this.TbxObservacionesO.Name = "TbxObservacionesO";
		this.TbxObservacionesO.Size = new System.Drawing.Size(547, 20);
		this.TbxObservacionesO.TabIndex = 19;
		this.LblObservaciones.AutoSize = true;
		this.LblObservaciones.Location = new System.Drawing.Point(12, 100);
		this.LblObservaciones.Name = "LblObservaciones";
		this.LblObservaciones.Size = new System.Drawing.Size(81, 13);
		this.LblObservaciones.TabIndex = 18;
		this.LblObservaciones.Text = "Observaciones:";
		this.TbxPaisO.Enabled = false;
		this.TbxPaisO.Location = new System.Drawing.Point(539, 71);
		this.TbxPaisO.Name = "TbxPaisO";
		this.TbxPaisO.Size = new System.Drawing.Size(100, 20);
		this.TbxPaisO.TabIndex = 17;
		this.LblPais.AutoSize = true;
		this.LblPais.Location = new System.Drawing.Point(501, 74);
		this.LblPais.Name = "LblPais";
		this.LblPais.Size = new System.Drawing.Size(30, 13);
		this.LblPais.TabIndex = 16;
		this.LblPais.Text = "Pais:";
		this.TbxProvinciaO.Enabled = false;
		this.TbxProvinciaO.Location = new System.Drawing.Point(320, 71);
		this.TbxProvinciaO.Name = "TbxProvinciaO";
		this.TbxProvinciaO.Size = new System.Drawing.Size(165, 20);
		this.TbxProvinciaO.TabIndex = 15;
		this.LblProvincia.AutoSize = true;
		this.LblProvincia.Location = new System.Drawing.Point(260, 74);
		this.LblProvincia.Name = "LblProvincia";
		this.LblProvincia.Size = new System.Drawing.Size(54, 13);
		this.LblProvincia.TabIndex = 14;
		this.LblProvincia.Text = "Provincia:";
		this.TbxLocalidadO.Enabled = false;
		this.TbxLocalidadO.Location = new System.Drawing.Point(83, 71);
		this.TbxLocalidadO.Name = "TbxLocalidadO";
		this.TbxLocalidadO.Size = new System.Drawing.Size(166, 20);
		this.TbxLocalidadO.TabIndex = 13;
		this.LblLocalidad.AutoSize = true;
		this.LblLocalidad.Location = new System.Drawing.Point(17, 74);
		this.LblLocalidad.Name = "LblLocalidad";
		this.LblLocalidad.Size = new System.Drawing.Size(56, 13);
		this.LblLocalidad.TabIndex = 12;
		this.LblLocalidad.Text = "Localidad:";
		this.TbxCodigoPostalO.Enabled = false;
		this.TbxCodigoPostalO.Location = new System.Drawing.Point(527, 45);
		this.TbxCodigoPostalO.Name = "TbxCodigoPostalO";
		this.TbxCodigoPostalO.Size = new System.Drawing.Size(119, 20);
		this.TbxCodigoPostalO.TabIndex = 11;
		this.LblCodigoPostal.AutoSize = true;
		this.LblCodigoPostal.Location = new System.Drawing.Point(446, 48);
		this.LblCodigoPostal.Name = "LblCodigoPostal";
		this.LblCodigoPostal.Size = new System.Drawing.Size(75, 13);
		this.LblCodigoPostal.TabIndex = 10;
		this.LblCodigoPostal.Text = "Codigo Postal:";
		this.TbxBloqueO.Enabled = false;
		this.TbxBloqueO.Location = new System.Drawing.Point(284, 45);
		this.TbxBloqueO.Name = "TbxBloqueO";
		this.TbxBloqueO.Size = new System.Drawing.Size(100, 20);
		this.TbxBloqueO.TabIndex = 9;
		this.LblBloque.AutoSize = true;
		this.LblBloque.Location = new System.Drawing.Point(235, 48);
		this.LblBloque.Name = "LblBloque";
		this.LblBloque.Size = new System.Drawing.Size(43, 13);
		this.LblBloque.TabIndex = 8;
		this.LblBloque.Text = "Bloque:";
		this.TbxDeptoO.Enabled = false;
		this.TbxDeptoO.Location = new System.Drawing.Point(95, 45);
		this.TbxDeptoO.Name = "TbxDeptoO";
		this.TbxDeptoO.Size = new System.Drawing.Size(100, 20);
		this.TbxDeptoO.TabIndex = 7;
		this.LableDepto.AutoSize = true;
		this.LableDepto.Location = new System.Drawing.Point(12, 48);
		this.LableDepto.Name = "LableDepto";
		this.LableDepto.Size = new System.Drawing.Size(77, 13);
		this.LableDepto.TabIndex = 6;
		this.LableDepto.Text = "Depto/Oficina:";
		this.TbxPisoO.Enabled = false;
		this.TbxPisoO.Location = new System.Drawing.Point(585, 19);
		this.TbxPisoO.Name = "TbxPisoO";
		this.TbxPisoO.Size = new System.Drawing.Size(61, 20);
		this.TbxPisoO.TabIndex = 5;
		this.Lblpiso.AutoSize = true;
		this.Lblpiso.Location = new System.Drawing.Point(549, 22);
		this.Lblpiso.Name = "Lblpiso";
		this.Lblpiso.Size = new System.Drawing.Size(30, 13);
		this.Lblpiso.TabIndex = 4;
		this.Lblpiso.Text = "Piso:";
		this.TbxAlturaO.Enabled = false;
		this.TbxAlturaO.Location = new System.Drawing.Point(440, 19);
		this.TbxAlturaO.Name = "TbxAlturaO";
		this.TbxAlturaO.Size = new System.Drawing.Size(100, 20);
		this.TbxAlturaO.TabIndex = 3;
		this.LblAltura.AutoSize = true;
		this.LblAltura.Location = new System.Drawing.Point(397, 22);
		this.LblAltura.Name = "LblAltura";
		this.LblAltura.Size = new System.Drawing.Size(37, 13);
		this.LblAltura.TabIndex = 2;
		this.LblAltura.Text = "Altura:";
		this.TbxCalleO.Enabled = false;
		this.TbxCalleO.Location = new System.Drawing.Point(45, 19);
		this.TbxCalleO.Name = "TbxCalleO";
		this.TbxCalleO.Size = new System.Drawing.Size(339, 20);
		this.TbxCalleO.TabIndex = 1;
		this.LblCalle.AutoSize = true;
		this.LblCalle.Location = new System.Drawing.Point(6, 22);
		this.LblCalle.Name = "LblCalle";
		this.LblCalle.Size = new System.Drawing.Size(33, 13);
		this.LblCalle.TabIndex = 0;
		this.LblCalle.Text = "Calle:";
		this.TabPage2.BackColor = System.Drawing.SystemColors.Control;
		this.TabPage2.Controls.Add(this.GroupBox5);
		this.TabPage2.Controls.Add(this.GroupBox3);
		this.TabPage2.Location = new System.Drawing.Point(4, 22);
		this.TabPage2.Name = "TabPage2";
		this.TabPage2.Padding = new System.Windows.Forms.Padding(3);
		this.TabPage2.Size = new System.Drawing.Size(692, 283);
		this.TabPage2.TabIndex = 1;
		this.TabPage2.Text = "Contacto";
		this.GroupBox5.Controls.Add(this.TbxComentarioContactoO);
		this.GroupBox5.Controls.Add(this.LblContactoO);
		this.GroupBox5.Controls.Add(this.Label12);
		this.GroupBox5.Controls.Add(this.TbxCelularContactoO);
		this.GroupBox5.Controls.Add(this.Label13);
		this.GroupBox5.Controls.Add(this.TbxTelefonoContactoO);
		this.GroupBox5.Controls.Add(this.Label14);
		this.GroupBox5.Controls.Add(this.TbxEmailContactoO);
		this.GroupBox5.Controls.Add(this.Label15);
		this.GroupBox5.Controls.Add(this.TbxNombreContactoO);
		this.GroupBox5.Controls.Add(this.Label16);
		this.GroupBox5.Location = new System.Drawing.Point(11, 153);
		this.GroupBox5.Name = "GroupBox5";
		this.GroupBox5.Size = new System.Drawing.Size(669, 100);
		this.GroupBox5.TabIndex = 12;
		this.GroupBox5.TabStop = false;
		this.GroupBox5.Text = "Operativo";
		this.TbxComentarioContactoO.Enabled = false;
		this.TbxComentarioContactoO.Location = new System.Drawing.Point(92, 63);
		this.TbxComentarioContactoO.Name = "TbxComentarioContactoO";
		this.TbxComentarioContactoO.Size = new System.Drawing.Size(556, 20);
		this.TbxComentarioContactoO.TabIndex = 11;
		this.LblContactoO.AutoSize = true;
		this.LblContactoO.Location = new System.Drawing.Point(6, 16);
		this.LblContactoO.Name = "LblContactoO";
		this.LblContactoO.Size = new System.Drawing.Size(13, 13);
		this.LblContactoO.TabIndex = 0;
		this.LblContactoO.Text = "0";
		this.Label12.AutoSize = true;
		this.Label12.Location = new System.Drawing.Point(23, 66);
		this.Label12.Name = "Label12";
		this.Label12.Size = new System.Drawing.Size(63, 13);
		this.Label12.TabIndex = 10;
		this.Label12.Text = "Comentario:";
		this.TbxCelularContactoO.Enabled = false;
		this.TbxCelularContactoO.Location = new System.Drawing.Point(416, 39);
		this.TbxCelularContactoO.Name = "TbxCelularContactoO";
		this.TbxCelularContactoO.Size = new System.Drawing.Size(232, 20);
		this.TbxCelularContactoO.TabIndex = 9;
		this.Label13.AutoSize = true;
		this.Label13.Location = new System.Drawing.Point(358, 42);
		this.Label13.Name = "Label13";
		this.Label13.Size = new System.Drawing.Size(42, 13);
		this.Label13.TabIndex = 8;
		this.Label13.Text = "Celular:";
		this.TbxTelefonoContactoO.Enabled = false;
		this.TbxTelefonoContactoO.Location = new System.Drawing.Point(416, 13);
		this.TbxTelefonoContactoO.Name = "TbxTelefonoContactoO";
		this.TbxTelefonoContactoO.Size = new System.Drawing.Size(232, 20);
		this.TbxTelefonoContactoO.TabIndex = 7;
		this.Label14.AutoSize = true;
		this.Label14.Location = new System.Drawing.Point(358, 16);
		this.Label14.Name = "Label14";
		this.Label14.Size = new System.Drawing.Size(52, 13);
		this.Label14.TabIndex = 5;
		this.Label14.Text = "Telefono:";
		this.TbxEmailContactoO.Enabled = false;
		this.TbxEmailContactoO.Location = new System.Drawing.Point(76, 39);
		this.TbxEmailContactoO.Name = "TbxEmailContactoO";
		this.TbxEmailContactoO.Size = new System.Drawing.Size(267, 20);
		this.TbxEmailContactoO.TabIndex = 4;
		this.Label15.AutoSize = true;
		this.Label15.Location = new System.Drawing.Point(23, 42);
		this.Label15.Name = "Label15";
		this.Label15.Size = new System.Drawing.Size(35, 13);
		this.Label15.TabIndex = 3;
		this.Label15.Text = "Email:";
		this.TbxNombreContactoO.Enabled = false;
		this.TbxNombreContactoO.Location = new System.Drawing.Point(76, 13);
		this.TbxNombreContactoO.Name = "TbxNombreContactoO";
		this.TbxNombreContactoO.Size = new System.Drawing.Size(267, 20);
		this.TbxNombreContactoO.TabIndex = 2;
		this.Label16.AutoSize = true;
		this.Label16.Location = new System.Drawing.Point(23, 16);
		this.Label16.Name = "Label16";
		this.Label16.Size = new System.Drawing.Size(47, 13);
		this.Label16.TabIndex = 1;
		this.Label16.Text = "Nombre:";
		this.GroupBox3.Controls.Add(this.TbxComentarioContactoC);
		this.GroupBox3.Controls.Add(this.LblIdContactoC);
		this.GroupBox3.Controls.Add(this.LblComentarioContacto);
		this.GroupBox3.Controls.Add(this.TbxCelularContactoC);
		this.GroupBox3.Controls.Add(this.LblCelularContacto);
		this.GroupBox3.Controls.Add(this.TbxTelefonoContactoC);
		this.GroupBox3.Controls.Add(this.LblTelefonoContacto);
		this.GroupBox3.Controls.Add(this.TbxEmailContactoC);
		this.GroupBox3.Controls.Add(this.LblEmailContacto);
		this.GroupBox3.Controls.Add(this.TbxNombreContactoC);
		this.GroupBox3.Controls.Add(this.LblNombreContacto);
		this.GroupBox3.Location = new System.Drawing.Point(11, 12);
		this.GroupBox3.Name = "GroupBox3";
		this.GroupBox3.Size = new System.Drawing.Size(669, 100);
		this.GroupBox3.TabIndex = 0;
		this.GroupBox3.TabStop = false;
		this.GroupBox3.Text = "Comercial";
		this.TbxComentarioContactoC.Enabled = false;
		this.TbxComentarioContactoC.Location = new System.Drawing.Point(92, 63);
		this.TbxComentarioContactoC.Name = "TbxComentarioContactoC";
		this.TbxComentarioContactoC.Size = new System.Drawing.Size(556, 20);
		this.TbxComentarioContactoC.TabIndex = 11;
		this.LblIdContactoC.AutoSize = true;
		this.LblIdContactoC.Location = new System.Drawing.Point(6, 16);
		this.LblIdContactoC.Name = "LblIdContactoC";
		this.LblIdContactoC.Size = new System.Drawing.Size(13, 13);
		this.LblIdContactoC.TabIndex = 0;
		this.LblIdContactoC.Text = "0";
		this.LblComentarioContacto.AutoSize = true;
		this.LblComentarioContacto.Location = new System.Drawing.Point(23, 66);
		this.LblComentarioContacto.Name = "LblComentarioContacto";
		this.LblComentarioContacto.Size = new System.Drawing.Size(63, 13);
		this.LblComentarioContacto.TabIndex = 10;
		this.LblComentarioContacto.Text = "Comentario:";
		this.TbxCelularContactoC.Enabled = false;
		this.TbxCelularContactoC.Location = new System.Drawing.Point(416, 39);
		this.TbxCelularContactoC.Name = "TbxCelularContactoC";
		this.TbxCelularContactoC.Size = new System.Drawing.Size(232, 20);
		this.TbxCelularContactoC.TabIndex = 9;
		this.LblCelularContacto.AutoSize = true;
		this.LblCelularContacto.Location = new System.Drawing.Point(358, 42);
		this.LblCelularContacto.Name = "LblCelularContacto";
		this.LblCelularContacto.Size = new System.Drawing.Size(42, 13);
		this.LblCelularContacto.TabIndex = 8;
		this.LblCelularContacto.Text = "Celular:";
		this.TbxTelefonoContactoC.Enabled = false;
		this.TbxTelefonoContactoC.Location = new System.Drawing.Point(416, 13);
		this.TbxTelefonoContactoC.Name = "TbxTelefonoContactoC";
		this.TbxTelefonoContactoC.Size = new System.Drawing.Size(232, 20);
		this.TbxTelefonoContactoC.TabIndex = 7;
		this.LblTelefonoContacto.AutoSize = true;
		this.LblTelefonoContacto.Location = new System.Drawing.Point(358, 16);
		this.LblTelefonoContacto.Name = "LblTelefonoContacto";
		this.LblTelefonoContacto.Size = new System.Drawing.Size(52, 13);
		this.LblTelefonoContacto.TabIndex = 5;
		this.LblTelefonoContacto.Text = "Telefono:";
		this.TbxEmailContactoC.Enabled = false;
		this.TbxEmailContactoC.Location = new System.Drawing.Point(76, 39);
		this.TbxEmailContactoC.Name = "TbxEmailContactoC";
		this.TbxEmailContactoC.Size = new System.Drawing.Size(267, 20);
		this.TbxEmailContactoC.TabIndex = 4;
		this.LblEmailContacto.AutoSize = true;
		this.LblEmailContacto.Location = new System.Drawing.Point(23, 42);
		this.LblEmailContacto.Name = "LblEmailContacto";
		this.LblEmailContacto.Size = new System.Drawing.Size(35, 13);
		this.LblEmailContacto.TabIndex = 3;
		this.LblEmailContacto.Text = "Email:";
		this.TbxNombreContactoC.Enabled = false;
		this.TbxNombreContactoC.Location = new System.Drawing.Point(76, 13);
		this.TbxNombreContactoC.Name = "TbxNombreContactoC";
		this.TbxNombreContactoC.Size = new System.Drawing.Size(267, 20);
		this.TbxNombreContactoC.TabIndex = 2;
		this.LblNombreContacto.AutoSize = true;
		this.LblNombreContacto.Location = new System.Drawing.Point(23, 16);
		this.LblNombreContacto.Name = "LblNombreContacto";
		this.LblNombreContacto.Size = new System.Drawing.Size(47, 13);
		this.LblNombreContacto.TabIndex = 1;
		this.LblNombreContacto.Text = "Nombre:";
		this.TabPage3.BackColor = System.Drawing.SystemColors.Control;
		this.TabPage3.Controls.Add(this.GroupBox8);
		this.TabPage3.Controls.Add(this.GroupBox7);
		this.TabPage3.Controls.Add(this.GroupBox6);
		this.TabPage3.Location = new System.Drawing.Point(4, 22);
		this.TabPage3.Name = "TabPage3";
		this.TabPage3.Size = new System.Drawing.Size(692, 283);
		this.TabPage3.TabIndex = 2;
		this.TabPage3.Text = "Configuración";
		this.GroupBox8.Location = new System.Drawing.Point(465, 12);
		this.GroupBox8.Name = "GroupBox8";
		this.GroupBox8.Size = new System.Drawing.Size(212, 259);
		this.GroupBox8.TabIndex = 2;
		this.GroupBox8.TabStop = false;
		this.GroupBox8.Text = "SubCuentas";
		this.GroupBox7.Location = new System.Drawing.Point(240, 12);
		this.GroupBox7.Name = "GroupBox7";
		this.GroupBox7.Size = new System.Drawing.Size(212, 259);
		this.GroupBox7.TabIndex = 1;
		this.GroupBox7.TabStop = false;
		this.GroupBox7.Text = "Seguro";
		this.GroupBox6.Location = new System.Drawing.Point(16, 12);
		this.GroupBox6.Name = "GroupBox6";
		this.GroupBox6.Size = new System.Drawing.Size(212, 259);
		this.GroupBox6.TabIndex = 0;
		this.GroupBox6.TabStop = false;
		this.GroupBox6.Text = "Tarifa";
		this.Button1.Location = new System.Drawing.Point(12, 437);
		this.Button1.Name = "Button1";
		this.Button1.Size = new System.Drawing.Size(75, 23);
		this.Button1.TabIndex = 2;
		this.Button1.Text = "Guardar";
		this.Button1.UseVisualStyleBackColor = true;
		this.Button2.Location = new System.Drawing.Point(93, 437);
		this.Button2.Name = "Button2";
		this.Button2.Size = new System.Drawing.Size(75, 23);
		this.Button2.TabIndex = 3;
		this.Button2.Text = "Editar";
		this.Button2.UseVisualStyleBackColor = true;
		this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[1] { this.ToolStripStatusLabel1 });
		this.StatusStrip1.Location = new System.Drawing.Point(0, 465);
		this.StatusStrip1.Name = "StatusStrip1";
		this.StatusStrip1.Size = new System.Drawing.Size(724, 22);
		this.StatusStrip1.TabIndex = 4;
		this.StatusStrip1.Text = "StatusStrip1";
		this.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
		this.ToolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(724, 487);
		base.Controls.Add(this.StatusStrip1);
		base.Controls.Add(this.Button2);
		base.Controls.Add(this.Button1);
		base.Controls.Add(this.TabControl1);
		base.Controls.Add(this.GroupBox1);
		base.Name = "ABMEmpresas";
		this.Text = "ABM Empresas";
		this.GroupBox1.ResumeLayout(false);
		this.GroupBox1.PerformLayout();
		this.TabControl1.ResumeLayout(false);
		this.TabPage1.ResumeLayout(false);
		this.GroupBox4.ResumeLayout(false);
		this.GroupBox4.PerformLayout();
		this.GroupBox2.ResumeLayout(false);
		this.GroupBox2.PerformLayout();
		this.TabPage2.ResumeLayout(false);
		this.GroupBox5.ResumeLayout(false);
		this.GroupBox5.PerformLayout();
		this.GroupBox3.ResumeLayout(false);
		this.GroupBox3.PerformLayout();
		this.TabPage3.ResumeLayout(false);
		this.StatusStrip1.ResumeLayout(false);
		this.StatusStrip1.PerformLayout();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private void ABMEmpresas_Load(object sender, EventArgs e)
	{
		CboEstado.SelectedIndex = 0;
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		if (CboTipoContribuyente.SelectedIndex >= 0)
		{
			if (TbxCuil.Text.Length != 11)
			{
				Interaction.MsgBox("Error, deben ser 11 digitos, usted ingreso: " + Conversions.ToString(TbxCuil.Text.Length));
				TbxCuil.Clear();
				TbxCuil.Focus();
			}
			else if (Operators.ConditionalCompareObjectEqual(comprobarDatos(), 1, TextCompare: true))
			{
				deshabilitarEdicion();
			}
		}
		else
		{
			Interaction.MsgBox("ATENCION: debes seleccionar un tipo de contribuyente");
			CboTipoContribuyente.Focus();
		}
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		habilitarEdicion();
	}

	private void habilitarEdicion()
	{
		TbxNumero.Enabled = true;
		CboEstado.Enabled = true;
		TbxRazonSocial.Enabled = true;
		TbxNombreFantasia.Enabled = true;
		CboTipoContribuyente.Enabled = true;
		TbxCuil.Enabled = true;
		TbxIngresos.Enabled = true;
		TbxCalleO.Enabled = true;
		TbxAlturaO.Enabled = true;
		TbxPisoO.Enabled = true;
		TbxDeptoO.Enabled = true;
		TbxBloqueO.Enabled = true;
		TbxCodigoPostalO.Enabled = true;
		TbxLocalidadO.Enabled = true;
		TbxProvinciaO.Enabled = true;
		TbxPaisO.Enabled = true;
		TbxObservacionesO.Enabled = true;
		TbxCalleD.Enabled = true;
		TbxAlturaD.Enabled = true;
		TbxPisoD.Enabled = true;
		TbxDeptoD.Enabled = true;
		TbxBloqueD.Enabled = true;
		TbxCodigoPostalD.Enabled = true;
		TbxLocalidadD.Enabled = true;
		TbxProvinciaD.Enabled = true;
		TbxPaisD.Enabled = true;
		TbxObservacionesD.Enabled = true;
		TbxNombreContactoC.Enabled = true;
		TbxCelularContactoC.Enabled = true;
		TbxEmailContactoC.Enabled = true;
		TbxTelefonoContactoC.Enabled = true;
		TbxCelularContactoC.Enabled = true;
		TbxComentarioContactoC.Enabled = true;
		TbxNombreContactoO.Enabled = true;
		TbxCelularContactoO.Enabled = true;
		TbxEmailContactoO.Enabled = true;
		TbxTelefonoContactoO.Enabled = true;
		TbxCelularContactoO.Enabled = true;
		TbxComentarioContactoO.Enabled = true;
	}

	private void deshabilitarEdicion()
	{
		TbxNumero.Enabled = false;
		CboEstado.Enabled = false;
		TbxRazonSocial.Enabled = false;
		TbxNombreFantasia.Enabled = false;
		CboTipoContribuyente.Enabled = false;
		TbxCuil.Enabled = false;
		TbxIngresos.Enabled = false;
		TbxCalleO.Enabled = false;
		TbxAlturaO.Enabled = false;
		TbxPisoO.Enabled = false;
		TbxDeptoO.Enabled = false;
		TbxBloqueO.Enabled = false;
		TbxCodigoPostalO.Enabled = false;
		TbxLocalidadO.Enabled = false;
		TbxProvinciaO.Enabled = false;
		TbxPaisO.Enabled = false;
		TbxObservacionesO.Enabled = false;
		TbxCalleD.Enabled = false;
		TbxAlturaD.Enabled = false;
		TbxPisoD.Enabled = false;
		TbxDeptoD.Enabled = false;
		TbxBloqueD.Enabled = false;
		TbxCodigoPostalD.Enabled = false;
		TbxLocalidadD.Enabled = false;
		TbxProvinciaD.Enabled = false;
		TbxPaisD.Enabled = false;
		TbxObservacionesD.Enabled = false;
		TbxNombreContactoC.Enabled = false;
		TbxCelularContactoC.Enabled = false;
		TbxEmailContactoC.Enabled = false;
		TbxTelefonoContactoC.Enabled = false;
		TbxCelularContactoC.Enabled = false;
		TbxComentarioContactoC.Enabled = false;
		TbxNombreContactoO.Enabled = false;
		TbxCelularContactoO.Enabled = false;
		TbxEmailContactoO.Enabled = false;
		TbxTelefonoContactoO.Enabled = false;
		TbxCelularContactoO.Enabled = false;
		TbxComentarioContactoO.Enabled = false;
	}

	private void TbxNumero_GotFocus(object sender, EventArgs e)
	{
		ToolStripStatusLabel1.Text = "AYUDA: Número de identificacion interna";
	}

	private void CboEstado_GotFocus(object sender, EventArgs e)
	{
		ToolStripStatusLabel1.Text = "AYUDA: Seleccione el estado de actividad de esta empresa";
	}

	private void TbxRazonSocial_GotFocus(object sender, EventArgs e)
	{
		ToolStripStatusLabel1.Text = "AYUDA: Nombre registrado como persona jurídica.";
	}

	private void TbxNombreFantasia_KeyUp(object sender, KeyEventArgs e)
	{
		ToolStripStatusLabel1.Text = "AYUDA: Nombre corto para uso interno.";
	}

	public object comprobarDatos()
	{
		int num = 0;
		try
		{
			List<KeyValuePair<string, string>> list = new List<KeyValuePair<string, string>>();
			if (CboEstado.SelectedIndex >= 0)
			{
				string text = string.Empty;
				switch (CboEstado.SelectedIndex)
				{
				case 0:
					text = "Activo";
					break;
				case 1:
					text = "Inactivo";
					break;
				}
				list.Add(new KeyValuePair<string, string>("Estado", text.ToString()));
			}
			if (Operators.CompareString(TbxRazonSocial.Text, "", TextCompare: true) == 0)
			{
				completarCampos("Razón Social");
				return num;
			}
			string text2 = TbxRazonSocial.Text;
			list.Add(new KeyValuePair<string, string>("RazonSocial", text2.ToString()));
			if (Operators.CompareString(TbxNombreFantasia.Text, "", TextCompare: true) == 0)
			{
				completarCampos("Nombre Fantasia");
				return num;
			}
			string text3 = TbxNombreFantasia.Text;
			list.Add(new KeyValuePair<string, string>("NombreFantasia", text3.ToString()));
			if (CboTipoContribuyente.SelectedIndex >= 0)
			{
				string text4 = string.Empty;
				switch (CboTipoContribuyente.SelectedIndex)
				{
				case 0:
					text4 = "Monotributista";
					break;
				case 1:
					text4 = "Responsable Inscripto";
					break;
				case 2:
					text4 = "Consumidor Final";
					break;
				}
				list.Add(new KeyValuePair<string, string>("Iva", text4.ToString()));
			}
			if (Operators.CompareString(TbxCuil.Text, "", TextCompare: true) == 0)
			{
				completarCampos("C.U.I.L/C.U.I.T");
				return num;
			}
			string text5 = TbxCuil.Text;
			list.Add(new KeyValuePair<string, string>("Cuil", text5.ToString()));
			if (Operators.CompareString(TbxIngresos.Text, "", TextCompare: true) == 0)
			{
				completarCampos("Ingresos Brutos");
				return num;
			}
			string text6 = TbxIngresos.Text;
			list.Add(new KeyValuePair<string, string>("Ingresos", text6.ToString()));
			foreach (KeyValuePair<string, string> item in list)
			{
				string key = item.Key;
				string value = item.Value;
				Interaction.MsgBox(key + " = " + value);
			}
			List<KeyValuePair<string, string>> list2 = new List<KeyValuePair<string, string>>();
			TbxCalleO.Enabled = true;
			TbxAlturaO.Enabled = true;
			TbxPisoO.Enabled = true;
			TbxDeptoO.Enabled = true;
			TbxBloqueO.Enabled = true;
			TbxCodigoPostalO.Enabled = true;
			TbxLocalidadO.Enabled = true;
			TbxProvinciaO.Enabled = true;
			TbxPaisO.Enabled = true;
			TbxObservacionesO.Enabled = true;
			List<KeyValuePair<string, string>> list3 = new List<KeyValuePair<string, string>>();
			TbxCalleD.Enabled = true;
			TbxAlturaD.Enabled = true;
			TbxPisoD.Enabled = true;
			TbxDeptoD.Enabled = true;
			TbxBloqueD.Enabled = true;
			TbxCodigoPostalD.Enabled = true;
			TbxLocalidadD.Enabled = true;
			TbxProvinciaD.Enabled = true;
			TbxPaisD.Enabled = true;
			TbxObservacionesD.Enabled = true;
			List<KeyValuePair<string, string>> list4 = new List<KeyValuePair<string, string>>();
			TbxNombreContactoC.Enabled = true;
			TbxCelularContactoC.Enabled = true;
			TbxEmailContactoC.Enabled = true;
			TbxTelefonoContactoC.Enabled = true;
			TbxCelularContactoC.Enabled = true;
			TbxComentarioContactoC.Enabled = true;
			List<KeyValuePair<string, string>> list5 = new List<KeyValuePair<string, string>>();
			TbxNombreContactoO.Enabled = true;
			TbxCelularContactoO.Enabled = true;
			TbxEmailContactoO.Enabled = true;
			TbxTelefonoContactoO.Enabled = true;
			TbxCelularContactoO.Enabled = true;
			TbxComentarioContactoO.Enabled = true;
			if (Operators.CompareString(TbxNumero.Text, "0", TextCompare: true) == 0)
			{
				num = 1;
			}
			else
			{
				num = 2;
				string text7 = TbxNumero.Text;
				list.Add(new KeyValuePair<string, string>("IdEmpresa", text7.ToString()));
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			num = 0;
			ProjectData.ClearProjectError();
		}
		return num;
	}

	public void completarCampos(string campo)
	{
		Interaction.MsgBox("Debe completar el siguiente campo: " + campo);
	}
}
