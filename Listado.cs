using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Hermes.My;
using Hermes.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;
using Newtonsoft.Json.Linq;

namespace Hermes;

[DesignerGenerated]
public class Listado : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ListView1")]
	private ListView _ListView1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ImprimirToolStripButton")]
	private ToolStripButton _ImprimirToolStripButton;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStripTextBox1")]
	private ToolStripTextBox _ToolStripTextBox1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("PrintDocument1")]
	private PrintDocument _PrintDocument1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("NuevoToolStripMenuItem")]
	private ToolStripMenuItem _NuevoToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DetalleToolStripMenuItem")]
	private ToolStripMenuItem _DetalleToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("AnularToolStripMenuItem")]
	private ToolStripMenuItem _AnularToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ImprimirToolStripMenuItem")]
	private ToolStripMenuItem _ImprimirToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("MovimientosToolStripMenuItem")]
	private ToolStripMenuItem _MovimientosToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ExportarOrdenesToolStripMenuItem")]
	private ToolStripMenuItem _ExportarOrdenesToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("IngresoMasivoToolStripMenuItem")]
	private ToolStripMenuItem _IngresoMasivoToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStripButton1")]
	private ToolStripButton _ToolStripButton1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("RevertirNovedadToolStripMenuItem")]
	private ToolStripMenuItem _RevertirNovedadToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("GenerarHDRToolStripMenuItem")]
	private ToolStripMenuItem _GenerarHDRToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ExportarSeleccionToolStripMenuItem")]
	private ToolStripMenuItem _ExportarSeleccionToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ImpresionMasivaToolStripMenuItem")]
	private ToolStripMenuItem _ImpresionMasivaToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("PrintDocument2")]
	private PrintDocument _PrintDocument2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("PrintOrderPicking")]
	private PrintDocument _PrintOrderPicking;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("InformeKatalinaToolStripMenuItem")]
	private ToolStripMenuItem _InformeKatalinaToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("RollosXPosicionToolStripMenuItem")]
	private ToolStripMenuItem _RollosXPosicionToolStripMenuItem;

	private int modo;

	private int printOrder;

	private int dato_r;

	private DataTable dt2;

	private int pagina;

	private int bultosTotales;

	private double pesoTotal;

	private double metrosTotal;

	private int print_order;

	private string print_empresa;

	private Mod_Ordenes.ordendesalida selectedOrder;

	private List<Mod_Ordenes.orderDetallePrint> selectedOrderItems;

	private Mod_Ordenes.Destino selectedDestinatario;

	private List<Mod_interfas.CheckedOrdenes> checkedOrdenes;

	private int indiceOrdenes;

	private int hojaActual;

	[SpecialName]
	private int _0024STATIC_0024PrintDocument1_PrintPage_002420211C128195_0024CurrentYPosition;

	[SpecialName]
	private StaticLocalInitFlag _0024STATIC_0024PrintDocument1_PrintPage_002420211C128195_0024CurrentYPosition_0024Init;

	[SpecialName]
	private int _0024STATIC_0024PrintDetails1_0024201110128195_0024LastIndex;

	[SpecialName]
	private StaticLocalInitFlag _0024STATIC_0024PrintDetails1_0024201110128195_0024LastIndex_0024Init;

	[SpecialName]
	private int _0024STATIC_0024PrintDetails1_0024201110128195_0024CurrentPage;

	[SpecialName]
	private StaticLocalInitFlag _0024STATIC_0024PrintDetails1_0024201110128195_0024CurrentPage_0024Init;

	[SpecialName]
	private int _0024STATIC_0024NewPrintDetails_0024201110128195_0024LastIndex;

	[SpecialName]
	private StaticLocalInitFlag _0024STATIC_0024NewPrintDetails_0024201110128195_0024LastIndex_0024Init;

	[SpecialName]
	private int _0024STATIC_0024NewPrintDetails_0024201110128195_0024CurrentPage;

	[SpecialName]
	private StaticLocalInitFlag _0024STATIC_0024NewPrintDetails_0024201110128195_0024CurrentPage_0024Init;

	[SpecialName]
	private int _0024STATIC_0024OrderPicking_00242011128195_0024LastIndex;

	[SpecialName]
	private StaticLocalInitFlag _0024STATIC_0024OrderPicking_00242011128195_0024LastIndex_0024Init;

	internal virtual ListView ListView1
	{
		[CompilerGenerated]
		get
		{
			return _ListView1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			ColumnClickEventHandler value2 = ListView1_ColumnClick;
			ListView listView = _ListView1;
			if (listView != null)
			{
				listView.ColumnClick -= value2;
			}
			_ListView1 = value;
			listView = _ListView1;
			if (listView != null)
			{
				listView.ColumnClick += value2;
			}
		}
	}

	[field: AccessedThroughProperty("ToolStrip1")]
	internal virtual ToolStrip ToolStrip1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripButton ImprimirToolStripButton
	{
		[CompilerGenerated]
		get
		{
			return _ImprimirToolStripButton;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ImprimirToolStripButton_Click;
			ToolStripButton imprimirToolStripButton = _ImprimirToolStripButton;
			if (imprimirToolStripButton != null)
			{
				imprimirToolStripButton.Click -= value2;
			}
			_ImprimirToolStripButton = value;
			imprimirToolStripButton = _ImprimirToolStripButton;
			if (imprimirToolStripButton != null)
			{
				imprimirToolStripButton.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("StatusStrip1")]
	internal virtual StatusStrip StatusStrip1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ToolStripSeparator3")]
	internal virtual ToolStripSeparator ToolStripSeparator3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("controladorLbl")]
	internal virtual Label controladorLbl
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("contador")]
	internal virtual ToolStripStatusLabel contador
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

	[field: AccessedThroughProperty("ToolStripLabel1")]
	internal virtual ToolStripLabel ToolStripLabel1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripTextBox ToolStripTextBox1
	{
		[CompilerGenerated]
		get
		{
			return _ToolStripTextBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			KeyPressEventHandler value2 = ToolStripTextBox1_KeyPress;
			ToolStripTextBox toolStripTextBox = _ToolStripTextBox1;
			if (toolStripTextBox != null)
			{
				toolStripTextBox.KeyPress -= value2;
			}
			_ToolStripTextBox1 = value;
			toolStripTextBox = _ToolStripTextBox1;
			if (toolStripTextBox != null)
			{
				toolStripTextBox.KeyPress += value2;
			}
		}
	}

	[field: AccessedThroughProperty("ToolStripSeparator4")]
	internal virtual ToolStripSeparator ToolStripSeparator4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual PrintDocument PrintDocument1
	{
		[CompilerGenerated]
		get
		{
			return _PrintDocument1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			PrintPageEventHandler value2 = PrintDocument1_PrintPage;
			PrintDocument printDocument = _PrintDocument1;
			if (printDocument != null)
			{
				printDocument.PrintPage -= value2;
			}
			_PrintDocument1 = value;
			printDocument = _PrintDocument1;
			if (printDocument != null)
			{
				printDocument.PrintPage += value2;
			}
		}
	}

	[field: AccessedThroughProperty("ToolStripDropDownButton1")]
	internal virtual ToolStripDropDownButton ToolStripDropDownButton1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripMenuItem NuevoToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _NuevoToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = NuevoToolStripMenuItem_Click;
			ToolStripMenuItem nuevoToolStripMenuItem = _NuevoToolStripMenuItem;
			if (nuevoToolStripMenuItem != null)
			{
				nuevoToolStripMenuItem.Click -= value2;
			}
			_NuevoToolStripMenuItem = value;
			nuevoToolStripMenuItem = _NuevoToolStripMenuItem;
			if (nuevoToolStripMenuItem != null)
			{
				nuevoToolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem DetalleToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _DetalleToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DetalleToolStripMenuItem_Click;
			ToolStripMenuItem detalleToolStripMenuItem = _DetalleToolStripMenuItem;
			if (detalleToolStripMenuItem != null)
			{
				detalleToolStripMenuItem.Click -= value2;
			}
			_DetalleToolStripMenuItem = value;
			detalleToolStripMenuItem = _DetalleToolStripMenuItem;
			if (detalleToolStripMenuItem != null)
			{
				detalleToolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem AnularToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _AnularToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = AnularToolStripMenuItem_Click;
			ToolStripMenuItem anularToolStripMenuItem = _AnularToolStripMenuItem;
			if (anularToolStripMenuItem != null)
			{
				anularToolStripMenuItem.Click -= value2;
			}
			_AnularToolStripMenuItem = value;
			anularToolStripMenuItem = _AnularToolStripMenuItem;
			if (anularToolStripMenuItem != null)
			{
				anularToolStripMenuItem.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("ToolStripDropDownButton2")]
	internal virtual ToolStripDropDownButton ToolStripDropDownButton2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripMenuItem ImprimirToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _ImprimirToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ImprimirToolStripMenuItem_Click;
			ToolStripMenuItem imprimirToolStripMenuItem = _ImprimirToolStripMenuItem;
			if (imprimirToolStripMenuItem != null)
			{
				imprimirToolStripMenuItem.Click -= value2;
			}
			_ImprimirToolStripMenuItem = value;
			imprimirToolStripMenuItem = _ImprimirToolStripMenuItem;
			if (imprimirToolStripMenuItem != null)
			{
				imprimirToolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem MovimientosToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _MovimientosToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = MovimientosToolStripMenuItem_Click;
			ToolStripMenuItem movimientosToolStripMenuItem = _MovimientosToolStripMenuItem;
			if (movimientosToolStripMenuItem != null)
			{
				movimientosToolStripMenuItem.Click -= value2;
			}
			_MovimientosToolStripMenuItem = value;
			movimientosToolStripMenuItem = _MovimientosToolStripMenuItem;
			if (movimientosToolStripMenuItem != null)
			{
				movimientosToolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem ExportarOrdenesToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _ExportarOrdenesToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ExportarOrdenesToolStripMenuItem_Click;
			ToolStripMenuItem exportarOrdenesToolStripMenuItem = _ExportarOrdenesToolStripMenuItem;
			if (exportarOrdenesToolStripMenuItem != null)
			{
				exportarOrdenesToolStripMenuItem.Click -= value2;
			}
			_ExportarOrdenesToolStripMenuItem = value;
			exportarOrdenesToolStripMenuItem = _ExportarOrdenesToolStripMenuItem;
			if (exportarOrdenesToolStripMenuItem != null)
			{
				exportarOrdenesToolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem IngresoMasivoToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _IngresoMasivoToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = IngresoMasivoToolStripMenuItem_Click;
			ToolStripMenuItem ingresoMasivoToolStripMenuItem = _IngresoMasivoToolStripMenuItem;
			if (ingresoMasivoToolStripMenuItem != null)
			{
				ingresoMasivoToolStripMenuItem.Click -= value2;
			}
			_IngresoMasivoToolStripMenuItem = value;
			ingresoMasivoToolStripMenuItem = _IngresoMasivoToolStripMenuItem;
			if (ingresoMasivoToolStripMenuItem != null)
			{
				ingresoMasivoToolStripMenuItem.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("ToolStripSeparator1")]
	internal virtual ToolStripSeparator ToolStripSeparator1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ToolStripSeparator2")]
	internal virtual ToolStripSeparator ToolStripSeparator2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ToolStripSeparator5")]
	internal virtual ToolStripSeparator ToolStripSeparator5
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

	[field: AccessedThroughProperty("ToolStripStatusLabel2")]
	internal virtual ToolStripStatusLabel ToolStripStatusLabel2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ToolStripStatusLabel3")]
	internal virtual ToolStripStatusLabel ToolStripStatusLabel3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ToolStripSeparator6")]
	internal virtual ToolStripSeparator ToolStripSeparator6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("BusquedaHistoricaToolStripMenuItem")]
	internal virtual ToolStripMenuItem BusquedaHistoricaToolStripMenuItem
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

	[field: AccessedThroughProperty("ToolStripStatusLabel4")]
	internal virtual ToolStripStatusLabel ToolStripStatusLabel4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ToolStripStatusLabel5")]
	internal virtual ToolStripStatusLabel ToolStripStatusLabel5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ToolStripSeparator7")]
	internal virtual ToolStripSeparator ToolStripSeparator7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbEmpresas")]
	internal virtual ComboBox cmbEmpresas
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

	[field: AccessedThroughProperty("ToolStripSeparator8")]
	internal virtual ToolStripSeparator ToolStripSeparator8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripMenuItem RevertirNovedadToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _RevertirNovedadToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = RevertirNovedadToolStripMenuItem_Click;
			ToolStripMenuItem revertirNovedadToolStripMenuItem = _RevertirNovedadToolStripMenuItem;
			if (revertirNovedadToolStripMenuItem != null)
			{
				revertirNovedadToolStripMenuItem.Click -= value2;
			}
			_RevertirNovedadToolStripMenuItem = value;
			revertirNovedadToolStripMenuItem = _RevertirNovedadToolStripMenuItem;
			if (revertirNovedadToolStripMenuItem != null)
			{
				revertirNovedadToolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem GenerarHDRToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _GenerarHDRToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = GenerarHDRToolStripMenuItem_Click;
			ToolStripMenuItem generarHDRToolStripMenuItem = _GenerarHDRToolStripMenuItem;
			if (generarHDRToolStripMenuItem != null)
			{
				generarHDRToolStripMenuItem.Click -= value2;
			}
			_GenerarHDRToolStripMenuItem = value;
			generarHDRToolStripMenuItem = _GenerarHDRToolStripMenuItem;
			if (generarHDRToolStripMenuItem != null)
			{
				generarHDRToolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem ExportarSeleccionToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _ExportarSeleccionToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ExportarSeleccionToolStripMenuItem_Click;
			ToolStripMenuItem exportarSeleccionToolStripMenuItem = _ExportarSeleccionToolStripMenuItem;
			if (exportarSeleccionToolStripMenuItem != null)
			{
				exportarSeleccionToolStripMenuItem.Click -= value2;
			}
			_ExportarSeleccionToolStripMenuItem = value;
			exportarSeleccionToolStripMenuItem = _ExportarSeleccionToolStripMenuItem;
			if (exportarSeleccionToolStripMenuItem != null)
			{
				exportarSeleccionToolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem ImpresionMasivaToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _ImpresionMasivaToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ImpresionMasivaToolStripMenuItem_Click;
			ToolStripMenuItem impresionMasivaToolStripMenuItem = _ImpresionMasivaToolStripMenuItem;
			if (impresionMasivaToolStripMenuItem != null)
			{
				impresionMasivaToolStripMenuItem.Click -= value2;
			}
			_ImpresionMasivaToolStripMenuItem = value;
			impresionMasivaToolStripMenuItem = _ImpresionMasivaToolStripMenuItem;
			if (impresionMasivaToolStripMenuItem != null)
			{
				impresionMasivaToolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual PrintDocument PrintDocument2
	{
		[CompilerGenerated]
		get
		{
			return _PrintDocument2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			PrintPageEventHandler value2 = PrintDocument2_PrintPage;
			PrintDocument printDocument = _PrintDocument2;
			if (printDocument != null)
			{
				printDocument.PrintPage -= value2;
			}
			_PrintDocument2 = value;
			printDocument = _PrintDocument2;
			if (printDocument != null)
			{
				printDocument.PrintPage += value2;
			}
		}
	}

	internal virtual PrintDocument PrintOrderPicking
	{
		[CompilerGenerated]
		get
		{
			return _PrintOrderPicking;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			PrintPageEventHandler value2 = PrintOrderPicking_PrintPage;
			PrintDocument printOrderPicking = _PrintOrderPicking;
			if (printOrderPicking != null)
			{
				printOrderPicking.PrintPage -= value2;
			}
			_PrintOrderPicking = value;
			printOrderPicking = _PrintOrderPicking;
			if (printOrderPicking != null)
			{
				printOrderPicking.PrintPage += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem InformeKatalinaToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _InformeKatalinaToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = InformeKatalinaToolStripMenuItem_Click;
			ToolStripMenuItem informeKatalinaToolStripMenuItem = _InformeKatalinaToolStripMenuItem;
			if (informeKatalinaToolStripMenuItem != null)
			{
				informeKatalinaToolStripMenuItem.Click -= value2;
			}
			_InformeKatalinaToolStripMenuItem = value;
			informeKatalinaToolStripMenuItem = _InformeKatalinaToolStripMenuItem;
			if (informeKatalinaToolStripMenuItem != null)
			{
				informeKatalinaToolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem RollosXPosicionToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _RollosXPosicionToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = RollosXPosicionToolStripMenuItem_Click;
			ToolStripMenuItem rollosXPosicionToolStripMenuItem = _RollosXPosicionToolStripMenuItem;
			if (rollosXPosicionToolStripMenuItem != null)
			{
				rollosXPosicionToolStripMenuItem.Click -= value2;
			}
			_RollosXPosicionToolStripMenuItem = value;
			rollosXPosicionToolStripMenuItem = _RollosXPosicionToolStripMenuItem;
			if (rollosXPosicionToolStripMenuItem != null)
			{
				rollosXPosicionToolStripMenuItem.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("ToolStripSeparator9")]
	internal virtual ToolStripSeparator ToolStripSeparator9
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public Listado()
	{
		base.Load += Listado_Load;
		modo = 0;
		printOrder = 0;
		dato_r = 0;
		dt2 = new DataTable();
		pagina = 1;
		bultosTotales = 0;
		pesoTotal = 0.0;
		metrosTotal = 0.0;
		print_order = 0;
		selectedOrder = default(Mod_Ordenes.ordendesalida);
		selectedOrderItems = new List<Mod_Ordenes.orderDetallePrint>();
		selectedDestinatario = default(Mod_Ordenes.Destino);
		checkedOrdenes = new List<Mod_interfas.CheckedOrdenes>();
		indiceOrdenes = 0;
		hojaActual = 1;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hermes.Listado));
		this.ListView1 = new System.Windows.Forms.ListView();
		this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
		this.ToolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
		this.NuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.DetalleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
		this.AnularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.ToolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
		this.ImprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.ImpresionMasivaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.ToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
		this.InformeKatalinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.ExportarSeleccionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.GenerarHDRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.ToolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
		this.IngresoMasivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.ToolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
		this.MovimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.BusquedaHistoricaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.ToolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
		this.ExportarOrdenesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.RevertirNovedadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.ToolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
		this.ToolStripButton1 = new System.Windows.Forms.ToolStripButton();
		this.ImprimirToolStripButton = new System.Windows.Forms.ToolStripButton();
		this.ToolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
		this.ToolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
		this.ToolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
		this.ToolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
		this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
		this.ToolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
		this.contador = new System.Windows.Forms.ToolStripStatusLabel();
		this.ToolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
		this.ToolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
		this.ToolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
		this.ToolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
		this.controladorLbl = new System.Windows.Forms.Label();
		this.Label1 = new System.Windows.Forms.Label();
		this.PrintDocument1 = new System.Drawing.Printing.PrintDocument();
		this.cmbEmpresas = new System.Windows.Forms.ComboBox();
		this.Button1 = new System.Windows.Forms.Button();
		this.PrintDocument2 = new System.Drawing.Printing.PrintDocument();
		this.PrintOrderPicking = new System.Drawing.Printing.PrintDocument();
		this.ToolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
		this.RollosXPosicionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.ToolStrip1.SuspendLayout();
		this.StatusStrip1.SuspendLayout();
		base.SuspendLayout();
		this.ListView1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.ListView1.CheckBoxes = true;
		this.ListView1.FullRowSelect = true;
		this.ListView1.GridLines = true;
		this.ListView1.Location = new System.Drawing.Point(12, 28);
		this.ListView1.Name = "ListView1";
		this.ListView1.Size = new System.Drawing.Size(1146, 313);
		this.ListView1.TabIndex = 0;
		this.ListView1.UseCompatibleStateImageBehavior = false;
		this.ListView1.View = System.Windows.Forms.View.Details;
		this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[9] { this.ToolStripDropDownButton1, this.ToolStripDropDownButton2, this.ToolStripSeparator4, this.ToolStripButton1, this.ImprimirToolStripButton, this.ToolStripSeparator3, this.ToolStripLabel1, this.ToolStripTextBox1, this.ToolStripSeparator7 });
		this.ToolStrip1.Location = new System.Drawing.Point(0, 0);
		this.ToolStrip1.Name = "ToolStrip1";
		this.ToolStrip1.Size = new System.Drawing.Size(1170, 25);
		this.ToolStrip1.TabIndex = 1;
		this.ToolStrip1.Text = "ToolStrip1";
		this.ToolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[4] { this.NuevoToolStripMenuItem, this.DetalleToolStripMenuItem, this.ToolStripSeparator1, this.AnularToolStripMenuItem });
		this.ToolStripDropDownButton1.Image = Hermes.My.Resources.Resources.document_open_folder;
		this.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1";
		this.ToolStripDropDownButton1.Size = new System.Drawing.Size(65, 22);
		this.ToolStripDropDownButton1.Text = "Inicio";
		this.ToolStripDropDownButton1.ToolTipText = "Inicio";
		this.NuevoToolStripMenuItem.Image = Hermes.My.Resources.Resources.document_new;
		this.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem";
		this.NuevoToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
		this.NuevoToolStripMenuItem.Text = "Nuevo";
		this.DetalleToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("DetalleToolStripMenuItem.Image");
		this.DetalleToolStripMenuItem.Name = "DetalleToolStripMenuItem";
		this.DetalleToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
		this.DetalleToolStripMenuItem.Text = "Detalle";
		this.ToolStripSeparator1.Name = "ToolStripSeparator1";
		this.ToolStripSeparator1.Size = new System.Drawing.Size(107, 6);
		this.AnularToolStripMenuItem.Image = Hermes.My.Resources.Resources.close_32;
		this.AnularToolStripMenuItem.Name = "AnularToolStripMenuItem";
		this.AnularToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
		this.AnularToolStripMenuItem.Text = "Anular";
		this.ToolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[16]
		{
			this.ImprimirToolStripMenuItem, this.ImpresionMasivaToolStripMenuItem, this.ToolStripSeparator2, this.RollosXPosicionToolStripMenuItem, this.InformeKatalinaToolStripMenuItem, this.ToolStripSeparator9, this.ExportarSeleccionToolStripMenuItem, this.GenerarHDRToolStripMenuItem, this.ToolStripSeparator5, this.IngresoMasivoToolStripMenuItem,
			this.ToolStripSeparator6, this.MovimientosToolStripMenuItem, this.BusquedaHistoricaToolStripMenuItem, this.ToolStripSeparator8, this.ExportarOrdenesToolStripMenuItem, this.RevertirNovedadToolStripMenuItem
		});
		this.ToolStripDropDownButton2.Image = Hermes.My.Resources.Resources.run_build;
		this.ToolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.ToolStripDropDownButton2.Name = "ToolStripDropDownButton2";
		this.ToolStripDropDownButton2.Size = new System.Drawing.Size(86, 22);
		this.ToolStripDropDownButton2.Text = "Opciones";
		this.ImprimirToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("ImprimirToolStripMenuItem.Image");
		this.ImprimirToolStripMenuItem.Name = "ImprimirToolStripMenuItem";
		this.ImprimirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
		this.ImprimirToolStripMenuItem.Text = "Imprimir";
		this.ImpresionMasivaToolStripMenuItem.Image = Hermes.My.Resources.Resources.document_print_direct1;
		this.ImpresionMasivaToolStripMenuItem.Name = "ImpresionMasivaToolStripMenuItem";
		this.ImpresionMasivaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
		this.ImpresionMasivaToolStripMenuItem.Text = "Impresion Masiva";
		this.ToolStripSeparator2.Name = "ToolStripSeparator2";
		this.ToolStripSeparator2.Size = new System.Drawing.Size(177, 6);
		this.InformeKatalinaToolStripMenuItem.Image = Hermes.My.Resources.Resources.games_difficult;
		this.InformeKatalinaToolStripMenuItem.Name = "InformeKatalinaToolStripMenuItem";
		this.InformeKatalinaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
		this.InformeKatalinaToolStripMenuItem.Text = "Informe Katalina";
		this.ExportarSeleccionToolStripMenuItem.Image = Hermes.My.Resources.Resources.excel_1;
		this.ExportarSeleccionToolStripMenuItem.Name = "ExportarSeleccionToolStripMenuItem";
		this.ExportarSeleccionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
		this.ExportarSeleccionToolStripMenuItem.Text = "Exportar Seleccion";
		this.GenerarHDRToolStripMenuItem.Image = Hermes.My.Resources.Resources.document_edit;
		this.GenerarHDRToolStripMenuItem.Name = "GenerarHDRToolStripMenuItem";
		this.GenerarHDRToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
		this.GenerarHDRToolStripMenuItem.Text = "Generar HDR";
		this.ToolStripSeparator5.Name = "ToolStripSeparator5";
		this.ToolStripSeparator5.Size = new System.Drawing.Size(177, 6);
		this.IngresoMasivoToolStripMenuItem.Image = Hermes.My.Resources.Resources.go_up;
		this.IngresoMasivoToolStripMenuItem.Name = "IngresoMasivoToolStripMenuItem";
		this.IngresoMasivoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
		this.IngresoMasivoToolStripMenuItem.Text = "Ingreso Masivo";
		this.ToolStripSeparator6.Name = "ToolStripSeparator6";
		this.ToolStripSeparator6.Size = new System.Drawing.Size(177, 6);
		this.MovimientosToolStripMenuItem.Image = Hermes.My.Resources.Resources.ajuste_product;
		this.MovimientosToolStripMenuItem.Name = "MovimientosToolStripMenuItem";
		this.MovimientosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
		this.MovimientosToolStripMenuItem.Text = "Movimientos";
		this.BusquedaHistoricaToolStripMenuItem.Image = Hermes.My.Resources.Resources.document_preview_archive;
		this.BusquedaHistoricaToolStripMenuItem.Name = "BusquedaHistoricaToolStripMenuItem";
		this.BusquedaHistoricaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
		this.BusquedaHistoricaToolStripMenuItem.Text = "Busqueda Historica";
		this.ToolStripSeparator8.Name = "ToolStripSeparator8";
		this.ToolStripSeparator8.Size = new System.Drawing.Size(177, 6);
		this.ExportarOrdenesToolStripMenuItem.Image = Hermes.My.Resources.Resources.go_down;
		this.ExportarOrdenesToolStripMenuItem.Name = "ExportarOrdenesToolStripMenuItem";
		this.ExportarOrdenesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
		this.ExportarOrdenesToolStripMenuItem.Text = "Exportar Ordenes";
		this.RevertirNovedadToolStripMenuItem.Enabled = false;
		this.RevertirNovedadToolStripMenuItem.Image = Hermes.My.Resources.Resources.vcs_conflicting;
		this.RevertirNovedadToolStripMenuItem.Name = "RevertirNovedadToolStripMenuItem";
		this.RevertirNovedadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
		this.RevertirNovedadToolStripMenuItem.Text = "Revertir Novedad";
		this.ToolStripSeparator4.Name = "ToolStripSeparator4";
		this.ToolStripSeparator4.Size = new System.Drawing.Size(6, 25);
		this.ToolStripButton1.Image = Hermes.My.Resources.Resources.Button_White_Load;
		this.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.ToolStripButton1.Name = "ToolStripButton1";
		this.ToolStripButton1.Size = new System.Drawing.Size(79, 22);
		this.ToolStripButton1.Text = "Actualizar";
		this.ImprimirToolStripButton.Image = (System.Drawing.Image)resources.GetObject("ImprimirToolStripButton.Image");
		this.ImprimirToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.ImprimirToolStripButton.Name = "ImprimirToolStripButton";
		this.ImprimirToolStripButton.Size = new System.Drawing.Size(73, 22);
		this.ImprimirToolStripButton.Text = "&Imprimir";
		this.ToolStripSeparator3.Name = "ToolStripSeparator3";
		this.ToolStripSeparator3.Size = new System.Drawing.Size(6, 25);
		this.ToolStripLabel1.Name = "ToolStripLabel1";
		this.ToolStripLabel1.Size = new System.Drawing.Size(45, 22);
		this.ToolStripLabel1.Text = "Buscar:";
		this.ToolStripTextBox1.Name = "ToolStripTextBox1";
		this.ToolStripTextBox1.Size = new System.Drawing.Size(100, 25);
		this.ToolStripSeparator7.Name = "ToolStripSeparator7";
		this.ToolStripSeparator7.Size = new System.Drawing.Size(6, 25);
		this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[6] { this.ToolStripStatusLabel1, this.contador, this.ToolStripStatusLabel2, this.ToolStripStatusLabel3, this.ToolStripStatusLabel4, this.ToolStripStatusLabel5 });
		this.StatusStrip1.Location = new System.Drawing.Point(0, 344);
		this.StatusStrip1.Name = "StatusStrip1";
		this.StatusStrip1.Size = new System.Drawing.Size(1170, 22);
		this.StatusStrip1.TabIndex = 2;
		this.StatusStrip1.Text = "StatusStrip1";
		this.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
		this.ToolStripStatusLabel1.Size = new System.Drawing.Size(57, 17);
		this.ToolStripStatusLabel1.Text = "Ordenes: ";
		this.contador.Name = "contador";
		this.contador.Size = new System.Drawing.Size(13, 17);
		this.contador.Text = "0";
		this.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2";
		this.ToolStripStatusLabel2.Size = new System.Drawing.Size(68, 17);
		this.ToolStripStatusLabel2.Text = "Pendientes:";
		this.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3";
		this.ToolStripStatusLabel3.Size = new System.Drawing.Size(13, 17);
		this.ToolStripStatusLabel3.Text = "0";
		this.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4";
		this.ToolStripStatusLabel4.Size = new System.Drawing.Size(69, 17);
		this.ToolStripStatusLabel4.Text = "Preparados:";
		this.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5";
		this.ToolStripStatusLabel5.Size = new System.Drawing.Size(13, 17);
		this.ToolStripStatusLabel5.Text = "0";
		this.controladorLbl.AutoSize = true;
		this.controladorLbl.Location = new System.Drawing.Point(1145, 9);
		this.controladorLbl.Name = "controladorLbl";
		this.controladorLbl.Size = new System.Drawing.Size(13, 13);
		this.controladorLbl.TabIndex = 3;
		this.controladorLbl.Text = "0";
		this.controladorLbl.Visible = false;
		this.Label1.AutoSize = true;
		this.Label1.Location = new System.Drawing.Point(1100, 9);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(39, 13);
		this.Label1.TabIndex = 4;
		this.Label1.Text = "Label1";
		this.Label1.Visible = false;
		this.cmbEmpresas.FormattingEnabled = true;
		this.cmbEmpresas.Location = new System.Drawing.Point(495, 4);
		this.cmbEmpresas.Name = "cmbEmpresas";
		this.cmbEmpresas.Size = new System.Drawing.Size(200, 21);
		this.cmbEmpresas.TabIndex = 5;
		this.Button1.Location = new System.Drawing.Point(702, 3);
		this.Button1.Name = "Button1";
		this.Button1.Size = new System.Drawing.Size(75, 23);
		this.Button1.TabIndex = 6;
		this.Button1.Text = "Filtrar";
		this.Button1.UseVisualStyleBackColor = true;
		this.ToolStripSeparator9.Name = "ToolStripSeparator9";
		this.ToolStripSeparator9.Size = new System.Drawing.Size(177, 6);
		this.RollosXPosicionToolStripMenuItem.Image = Hermes.My.Resources.Resources.go_jump_definition;
		this.RollosXPosicionToolStripMenuItem.Name = "RollosXPosicionToolStripMenuItem";
		this.RollosXPosicionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
		this.RollosXPosicionToolStripMenuItem.Text = "Rollos X Posicion";
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(1170, 366);
		base.Controls.Add(this.Button1);
		base.Controls.Add(this.cmbEmpresas);
		base.Controls.Add(this.Label1);
		base.Controls.Add(this.controladorLbl);
		base.Controls.Add(this.StatusStrip1);
		base.Controls.Add(this.ToolStrip1);
		base.Controls.Add(this.ListView1);
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.Name = "Listado";
		this.Text = "Listado";
		this.ToolStrip1.ResumeLayout(false);
		this.ToolStrip1.PerformLayout();
		this.StatusStrip1.ResumeLayout(false);
		this.StatusStrip1.PerformLayout();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private void Listado_Load(object sender, EventArgs e)
	{
		if (Conversions.ToDouble(MySettingsProperty.Settings.Permiso) == 10.0)
		{
			RevertirNovedadToolStripMenuItem.Enabled = true;
		}
		modo = Conversions.ToInteger(controladorLbl.Text);
		Cursor = Cursors.WaitCursor;
		switch (modo)
		{
		case 1:
			loadData(1);
			loadEmpresasCombo();
			break;
		case 2:
			loadData(2);
			loadEmpresasCombo();
			break;
		}
		Cursor = Cursors.Default;
	}

	private void ImprimirToolStripButton_Click(object sender, EventArgs e)
	{
		if (ListView1.SelectedItems.Count > 0)
		{
			PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
			printPreviewDialog.Document = PrintDocument1;
			printPreviewDialog.ShowDialog();
		}
		else
		{
			Interaction.MsgBox("Seleccione una orden para imprimir");
		}
	}

	private void PrintDocument1_PrintPage(object sender, PrintPageEventArgs e)
	{
		if (_0024STATIC_0024PrintDocument1_PrintPage_002420211C128195_0024CurrentYPosition_0024Init == null)
		{
			Interlocked.CompareExchange(ref _0024STATIC_0024PrintDocument1_PrintPage_002420211C128195_0024CurrentYPosition_0024Init, new StaticLocalInitFlag(), null);
		}
		bool lockTaken = false;
		try
		{
			Monitor.Enter(_0024STATIC_0024PrintDocument1_PrintPage_002420211C128195_0024CurrentYPosition_0024Init, ref lockTaken);
			if (_0024STATIC_0024PrintDocument1_PrintPage_002420211C128195_0024CurrentYPosition_0024Init.State == 0)
			{
				_0024STATIC_0024PrintDocument1_PrintPage_002420211C128195_0024CurrentYPosition_0024Init.State = 2;
				_0024STATIC_0024PrintDocument1_PrintPage_002420211C128195_0024CurrentYPosition = 0;
			}
			else if (_0024STATIC_0024PrintDocument1_PrintPage_002420211C128195_0024CurrentYPosition_0024Init.State == 2)
			{
				throw new IncompleteInitialization();
			}
		}
		finally
		{
			_0024STATIC_0024PrintDocument1_PrintPage_002420211C128195_0024CurrentYPosition_0024Init.State = 1;
			if (lockTaken)
			{
				Monitor.Exit(_0024STATIC_0024PrintDocument1_PrintPage_002420211C128195_0024CurrentYPosition_0024Init);
			}
		}
		if (ListView1.SelectedItems.Count > 0)
		{
			print_order = int.Parse(ListView1.SelectedItems[0].Text);
			object orderById = Mod_Ordenes.getOrderById(print_order);
			selectedOrder = ((orderById != null) ? ((Mod_Ordenes.ordendesalida)orderById) : default(Mod_Ordenes.ordendesalida));
			if (selectedOrder.numero != null)
			{
				selectedOrderItems = (List<Mod_Ordenes.orderDetallePrint>)Mod_Ordenes.getOrderItemsByOrder(selectedOrder.id);
				object destinatario = Mod_Ordenes.getDestinatario(selectedOrder.destinatario);
				selectedDestinatario = ((destinatario != null) ? ((Mod_Ordenes.Destino)destinatario) : default(Mod_Ordenes.Destino));
				NewPrintDetails(ref e);
			}
			else
			{
				Interaction.MsgBox("Error al recuperar la orden");
			}
		}
	}

	private void ListView1_ColumnClick(object sender, ColumnClickEventArgs e)
	{
		Mod_Ordenaclumnas.ordenar_columnas(ListView1, RuntimeHelpers.GetObjectValue(sender), e);
	}

	private void PrintDetails1(ref PrintPageEventArgs e)
	{
		if (_0024STATIC_0024PrintDetails1_0024201110128195_0024LastIndex_0024Init == null)
		{
			Interlocked.CompareExchange(ref _0024STATIC_0024PrintDetails1_0024201110128195_0024LastIndex_0024Init, new StaticLocalInitFlag(), null);
		}
		bool lockTaken = false;
		try
		{
			Monitor.Enter(_0024STATIC_0024PrintDetails1_0024201110128195_0024LastIndex_0024Init, ref lockTaken);
			if (_0024STATIC_0024PrintDetails1_0024201110128195_0024LastIndex_0024Init.State == 0)
			{
				_0024STATIC_0024PrintDetails1_0024201110128195_0024LastIndex_0024Init.State = 2;
				_0024STATIC_0024PrintDetails1_0024201110128195_0024LastIndex = 0;
			}
			else if (_0024STATIC_0024PrintDetails1_0024201110128195_0024LastIndex_0024Init.State == 2)
			{
				throw new IncompleteInitialization();
			}
		}
		finally
		{
			_0024STATIC_0024PrintDetails1_0024201110128195_0024LastIndex_0024Init.State = 1;
			if (lockTaken)
			{
				Monitor.Exit(_0024STATIC_0024PrintDetails1_0024201110128195_0024LastIndex_0024Init);
			}
		}
		if (_0024STATIC_0024PrintDetails1_0024201110128195_0024CurrentPage_0024Init == null)
		{
			Interlocked.CompareExchange(ref _0024STATIC_0024PrintDetails1_0024201110128195_0024CurrentPage_0024Init, new StaticLocalInitFlag(), null);
		}
		bool lockTaken2 = false;
		try
		{
			Monitor.Enter(_0024STATIC_0024PrintDetails1_0024201110128195_0024CurrentPage_0024Init, ref lockTaken2);
			if (_0024STATIC_0024PrintDetails1_0024201110128195_0024CurrentPage_0024Init.State == 0)
			{
				_0024STATIC_0024PrintDetails1_0024201110128195_0024CurrentPage_0024Init.State = 2;
				_0024STATIC_0024PrintDetails1_0024201110128195_0024CurrentPage = 0;
			}
			else if (_0024STATIC_0024PrintDetails1_0024201110128195_0024CurrentPage_0024Init.State == 2)
			{
				throw new IncompleteInitialization();
			}
		}
		finally
		{
			_0024STATIC_0024PrintDetails1_0024201110128195_0024CurrentPage_0024Init.State = 1;
			if (lockTaken2)
			{
				Monitor.Exit(_0024STATIC_0024PrintDetails1_0024201110128195_0024CurrentPage_0024Init);
			}
		}
		Graphics graphics = CreateGraphics();
		checked
		{
			int num = (int)Math.Round(graphics.DpiX);
			int num2 = (int)Math.Round(graphics.DpiY);
			graphics.Dispose();
			Rectangle empty = Rectangle.Empty;
			float num3 = (float)(-4.0 * ((double)num / 96.0));
			float num4 = (float)((double)ListView1.Font.Height + 10.0 * ((double)num / 96.0));
			StringFormat stringFormat = new StringFormat();
			float num5 = e.Graphics.MeasureString(Conversions.ToString(_0024STATIC_0024PrintDetails1_0024201110128195_0024CurrentPage), ListView1.Font).Width;
			stringFormat.FormatFlags = StringFormatFlags.NoWrap;
			stringFormat.Trimming = StringTrimming.EllipsisCharacter;
			stringFormat.LineAlignment = StringAlignment.Center;
			_0024STATIC_0024PrintDetails1_0024201110128195_0024CurrentPage++;
			int num6 = e.MarginBounds.X;
			int num7 = e.MarginBounds.Y;
			int num8 = ListView1.Columns.Count - 1;
			for (int i = 0; i <= num8; i++)
			{
				empty.X = num6;
				empty.Y = num7;
				empty.Width = ListView1.Columns[i].Width;
				empty.Height = (int)Math.Round(num4);
				e.Graphics.FillRectangle(Brushes.LightGray, empty);
				e.Graphics.DrawRectangle(Pens.DarkGray, empty);
				empty.X = (int)Math.Round((float)empty.X + num3);
				empty.Width = (int)Math.Round((float)empty.Width - num3);
				e.Graphics.DrawString(ListView1.Columns[i].Text, ListView1.Font, Brushes.Black, empty, stringFormat);
				num6 = (int)Math.Round((float)num6 + ((float)empty.Width + num3));
			}
			num7 = (int)Math.Round((float)num7 + num4);
			int num9 = _0024STATIC_0024PrintDetails1_0024201110128195_0024LastIndex;
			int num10 = ListView1.Items.Count - 1;
			for (int j = num9; j <= num10; j++)
			{
				ListViewItem listViewItem = ListView1.Items[j];
				num6 = e.MarginBounds.X;
				if (num7 + listViewItem.Bounds.Height > e.MarginBounds.Bottom)
				{
					_0024STATIC_0024PrintDetails1_0024201110128195_0024LastIndex = j;
					e.HasMorePages = true;
					stringFormat.Dispose();
					e.Graphics.DrawString(Conversions.ToString(_0024STATIC_0024PrintDetails1_0024201110128195_0024CurrentPage), ListView1.Font, Brushes.Black, ((float)e.PageBounds.Width - num5) / 2f, e.PageBounds.Bottom - ListView1.Font.Height * 2);
					return;
				}
				int num11 = 0;
				if (ListView1.SmallImageList != null)
				{
					if (!string.IsNullOrEmpty(listViewItem.ImageKey))
					{
						e.Graphics.DrawImage(ListView1.SmallImageList.Images[listViewItem.ImageKey], num6, num7);
					}
					else if (listViewItem.ImageIndex >= 0)
					{
						e.Graphics.DrawImage(ListView1.SmallImageList.Images[listViewItem.ImageIndex], num6, num7);
					}
					num11 = ListView1.SmallImageList.ImageSize.Width;
				}
				int num12 = ListView1.Columns.Count - 1;
				for (int k = 0; k <= num12; k++)
				{
					empty.X = num6;
					empty.Y = num7;
					empty.Width = ListView1.Columns[k].Width;
					empty.Height = listViewItem.Bounds.Height;
					if (ListView1.GridLines)
					{
						e.Graphics.DrawRectangle(Pens.DarkGray, empty);
					}
					if (k == 0)
					{
						empty.X += num11;
					}
					empty.X = (int)Math.Round((float)empty.X + num3);
					empty.Width = (int)Math.Round((float)empty.Width - num3);
					if (k < listViewItem.SubItems.Count)
					{
						e.Graphics.DrawString(listViewItem.SubItems[k].Text, ListView1.Font, Brushes.Black, empty, stringFormat);
					}
					num6 = (int)Math.Round((float)num6 + ((float)empty.Width + num3));
				}
				num7 += listViewItem.Bounds.Height;
				listViewItem = null;
			}
			e.Graphics.DrawString(Conversions.ToString(_0024STATIC_0024PrintDetails1_0024201110128195_0024CurrentPage), ListView1.Font, Brushes.Black, ((float)e.PageBounds.Width - num5) / 2f, e.PageBounds.Bottom - ListView1.Font.Height * 2);
			stringFormat.Dispose();
			_0024STATIC_0024PrintDetails1_0024201110128195_0024LastIndex = 0;
			_0024STATIC_0024PrintDetails1_0024201110128195_0024CurrentPage = 0;
		}
	}

	public void loadData(int modo)
	{
		switch (modo)
		{
		case 0:
			break;
		case 1:
			try
			{
				ListView1.Columns.Clear();
				string sql2 = "SELECT o.id, e.nombre as empresa, t.descripcion as tipo, o.numero, d.nombre as destino, \r\n                                                o.prioridad, o.valor, s.descripcion as estado, o.fechaCreacion as Creado, \r\n                                                o.fechaPreparado as Preparado, o.fecha as UltimaModificacion \r\n                                                FROM ((((ORDENES o LEFT JOIN orderstatus s ON o.estado = s.id) \r\n                                                LEFT JOIN empresas e ON o.empresa = e.id) \r\n                                                LEFT JOIN ordertipo t ON o.tipo = t.id ) \r\n                                                LEFT JOIN destinos d ON o.eventual = d.id) \r\n                                                ORDER BY o.id desc LIMIT 5000";
				Mod_Sentencias.cargar_datos_lv_completa(ListView1, sql2, Label1);
				contador.Text = Label1.Text;
				int num3 = (from object item in ListView1.Items
					select (ListViewItem)item into item
					where Operators.CompareString(item.SubItems[7].Text, "PENDIENTE", TextCompare: true) == 0
					select (item)).Count();
				ToolStripStatusLabel3.Text = Conversions.ToString(num3);
				int num4 = (from object item in ListView1.Items
					select (ListViewItem)item into item
					where Operators.CompareString(item.SubItems[7].Text, "PREPARADO", TextCompare: true) == 0
					select (item)).Count();
				ToolStripStatusLabel5.Text = Conversions.ToString(num4);
				break;
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				Interaction.MsgBox("Ocurrio un error al recuperar los datos");
				ProjectData.ClearProjectError();
				break;
			}
		case 2:
			try
			{
				ListView1.Columns.Clear();
				string sql = "SELECT \r\n                    o.id, e.nombre as empresa,  o.prioridad, t.descripcion as tipo, \r\n                    o.numero, d.nombre as destino, o.valor, s.descripcion as estado, \r\n                    o.fechaCreacion as Creado, o.fechaPreparado as Preparado, \r\n                    o.fecha as UltimaModificacion \r\n                    FROM ((((ORDENES o LEFT JOIN orderstatus s ON o.estado = s.id) \r\n                    LEFT JOIN empresas e ON o.empresa = e.id) \r\n                    LEFT JOIN ordertipo t ON o.tipo = t.id )\r\n                    LEFT JOIN destinos d ON o.eventual = d.id) \r\n                    WHERE o.estado in (1,5)\r\n                    ORDER BY o.id desc LIMIT 5000";
				Mod_Sentencias.cargar_datos_lv_completa(ListView1, sql, Label1);
				contador.Text = Label1.Text;
				int num = (from object item in ListView1.Items
					select (ListViewItem)item into item
					where Operators.CompareString(item.SubItems[7].Text, "PENDIENTE", TextCompare: true) == 0
					select (item)).Count();
				ToolStripStatusLabel3.Text = Conversions.ToString(num);
				int num2 = (from object item in ListView1.Items
					select (ListViewItem)item into item
					where Operators.CompareString(item.SubItems[7].Text, "PREPARADO", TextCompare: true) == 0
					select (item)).Count();
				ToolStripStatusLabel5.Text = Conversions.ToString(num2);
				break;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				Interaction.MsgBox("Ocurrio un error al recuperar los datos");
				ProjectData.ClearProjectError();
				break;
			}
		}
	}

	private void PrintDetails(ref PrintPageEventArgs e)
	{
		string text = Strings.Format(MyProject.Forms.Form1_Inicio.DateTimePicker1.Value, "dd-MM-yyyy");
		string text2 = ListView1.SelectedItems[0].SubItems[3].Text;
		string text3 = ListView1.SelectedItems[0].SubItems[1].Text;
		string empty = string.Empty;
		string empty2 = string.Empty;
		string empty3 = string.Empty;
		string empty4 = string.Empty;
		string text4 = ListView1.SelectedItems[0].SubItems[2].Text;
		string text5 = ListView1.SelectedItems[0].SubItems[2].Text;
		string text6 = ListView1.SelectedItems[0].SubItems[2].Text;
		string text7 = ListView1.SelectedItems[0].SubItems[2].Text;
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		int num5 = 0;
		Font font = new Font("Arial", 6.75f, FontStyle.Italic, GraphicsUnit.Point, 0);
		Font font2 = new Font("Arial", 16.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		Font font3 = new Font("Arial", 14.75f, FontStyle.Italic, GraphicsUnit.Point, 0);
		Font font4 = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, 0);
		string text8 = MyProject.Forms.Form1_Inicio.nombreusuario.Text;
		e.Graphics.DrawLine(Pens.Brown, 2, 5, 750, 5);
		e.Graphics.DrawLine(Pens.Brown, 2, 5, 2, 1100);
		e.Graphics.DrawLine(Pens.Brown, 750, 5, 750, 1100);
		e.Graphics.DrawLine(Pens.Brown, 2, 1100, 750, 1100);
		e.Graphics.DrawLine(Pens.Brown, 2, 130, 750, 130);
		Image logoArea = Resources.logoArea1;
		e.Graphics.DrawImage(logoArea, 170, 30);
		e.Graphics.DrawString(text2, font4, Brushes.Black, 50f, 85f);
		e.Graphics.DrawString("ORDEN DE PICKING v:1.0", font2, Brushes.Black, 250f, 135f);
		e.Graphics.DrawLine(Pens.Brown, 2, 162, 750, 162);
		e.Graphics.DrawString("Empresa: " + text3, font4, Brushes.Black, 55f, 180f);
		e.Graphics.DrawString("Remito número: " + text2, font4, Brushes.Black, 55f, 200f);
		e.Graphics.DrawString("Fecha: " + text, font4, Brushes.Black, 55f, 220f);
		e.Graphics.DrawString("Tipo de orden: " + ListView1.SelectedItems[0].SubItems[2].Text, font4, Brushes.Black, 55f, 270f);
		e.Graphics.DrawString("Destinatario: " + text4, font4, Brushes.Black, 400f, 180f);
		e.Graphics.DrawString("Direccion: " + text5, font4, Brushes.Black, 400f, 200f);
		e.Graphics.DrawString("Localidad: " + text6, font4, Brushes.Black, 400f, 220f);
		e.Graphics.DrawString("Codigo Postal: " + text7, font4, Brushes.Black, 400f, 240f);
		e.Graphics.DrawLine(Pens.Brown, 2, 310, 750, 310);
		checked
		{
			while (dato_r < dt2.Rows.Count)
			{
				num4 = ((dato_r != 0) ? (num2 * 40 + 450) : 450);
				string s = dt2.Rows[dato_r]["CODIGO"].ToString();
				num += int.Parse(Conversions.ToString(dt2.Rows[dato_r]["UNIDADES"]));
				string s2 = dt2.Rows[dato_r]["UNIDADES"].ToString();
				string text9 = dt2.Rows[dato_r]["DESCRIPCION"].ToString();
				if (text9.Length > 20)
				{
					text9 = text9.Substring(0, 20);
				}
				e.Graphics.DrawString(s2, font, Brushes.Black, 50f, num4);
				e.Graphics.DrawString(s, font, Brushes.Black, 100f, num4);
				e.Graphics.DrawString(text9, font, Brushes.Black, 280f, num4);
				num2++;
				dato_r++;
				pagina++;
				if (num4 > 1000)
				{
					num2 = 0;
					pagina = 0;
					e.HasMorePages = true;
					return;
				}
				e.HasMorePages = false;
			}
			e.Graphics.DrawString("Bultos: " + Conversions.ToString(num), font4, Brushes.Black, 55f, 240f);
			e.Graphics.DrawString("Preparo:", font4, Brushes.Black, 100f, 1000f);
			e.Graphics.DrawString("____________________", font4, Brushes.Black, 170f, 1000f);
			e.Graphics.DrawString("Controlo:", font4, Brushes.Black, 350f, 1000f);
			e.Graphics.DrawString("____________________", font4, Brushes.Black, 420f, 1000f);
		}
	}

	private void NewPrintDetails(ref PrintPageEventArgs e)
	{
		string text = ListView1.SelectedItems[0].SubItems[1].Text;
		Font font = new Font("Arial", 6.75f, FontStyle.Italic, GraphicsUnit.Point, 0);
		Font font2 = new Font("Arial", 16.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		Font font3 = new Font("Arial", 14.75f, FontStyle.Italic, GraphicsUnit.Point, 0);
		Font font4 = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, 0);
		Font font5 = new Font("Arial", 46f, FontStyle.Bold, GraphicsUnit.Point, 0);
		int num = 0;
		e.Graphics.DrawLine(Pens.Brown, 2, 5, 750, 5);
		e.Graphics.DrawLine(Pens.Brown, 2, 5, 2, 1100);
		e.Graphics.DrawLine(Pens.Brown, 750, 5, 750, 1100);
		e.Graphics.DrawLine(Pens.Brown, 2, 1100, 750, 1100);
		e.Graphics.DrawString("Documento NO VALIDO como remito/factura.", font, Brushes.Black, 55f, 1110f);
		e.Graphics.DrawLine(Pens.Brown, 2, 130, 750, 130);
		Image logoArea = Resources.logoArea1;
		e.Graphics.DrawImage(logoArea, 170, 30);
		e.Graphics.DrawString("ORDEN DE PICKING v:1.1", font2, Brushes.Black, 250f, 135f);
		e.Graphics.DrawLine(Pens.Brown, 2, 162, 750, 162);
		e.Graphics.DrawString("Empresa: " + text, font4, Brushes.Black, 55f, 180f);
		e.Graphics.DrawString("Remito número: " + selectedOrder.numero, font4, Brushes.Black, 55f, 200f);
		e.Graphics.DrawString("Fecha: " + Conversions.ToString(selectedOrder.fecha), font4, Brushes.Black, 55f, 220f);
		switch (selectedOrder.tipo)
		{
		case 1:
			e.Graphics.DrawString("Tipo de orden: REMITO", font4, Brushes.Black, 55f, 270f);
			break;
		case 2:
			e.Graphics.DrawString("Tipo de orden: ASIGNACION", font4, Brushes.Black, 55f, 270f);
			break;
		case 3:
			e.Graphics.DrawString("Tipo de orden: OTRO", font4, Brushes.Black, 55f, 270f);
			break;
		}
		e.Graphics.DrawString("Destinatario: " + selectedDestinatario.nombre, font4, Brushes.Black, 400f, 180f);
		e.Graphics.DrawString("Direccion: " + selectedDestinatario.direccion, font4, Brushes.Black, 400f, 200f);
		e.Graphics.DrawString("Localidad: " + selectedDestinatario.localidad, font4, Brushes.Black, 400f, 220f);
		e.Graphics.DrawString("Codigo Postal: " + selectedDestinatario.postal, font4, Brushes.Black, 400f, 240f);
		e.Graphics.DrawLine(Pens.Brown, 2, 310, 750, 310);
		if (_0024STATIC_0024NewPrintDetails_0024201110128195_0024LastIndex_0024Init == null)
		{
			Interlocked.CompareExchange(ref _0024STATIC_0024NewPrintDetails_0024201110128195_0024LastIndex_0024Init, new StaticLocalInitFlag(), null);
		}
		bool lockTaken = false;
		try
		{
			Monitor.Enter(_0024STATIC_0024NewPrintDetails_0024201110128195_0024LastIndex_0024Init, ref lockTaken);
			if (_0024STATIC_0024NewPrintDetails_0024201110128195_0024LastIndex_0024Init.State == 0)
			{
				_0024STATIC_0024NewPrintDetails_0024201110128195_0024LastIndex_0024Init.State = 2;
				_0024STATIC_0024NewPrintDetails_0024201110128195_0024LastIndex = 0;
			}
			else if (_0024STATIC_0024NewPrintDetails_0024201110128195_0024LastIndex_0024Init.State == 2)
			{
				throw new IncompleteInitialization();
			}
		}
		finally
		{
			_0024STATIC_0024NewPrintDetails_0024201110128195_0024LastIndex_0024Init.State = 1;
			if (lockTaken)
			{
				Monitor.Exit(_0024STATIC_0024NewPrintDetails_0024201110128195_0024LastIndex_0024Init);
			}
		}
		if (_0024STATIC_0024NewPrintDetails_0024201110128195_0024CurrentPage_0024Init == null)
		{
			Interlocked.CompareExchange(ref _0024STATIC_0024NewPrintDetails_0024201110128195_0024CurrentPage_0024Init, new StaticLocalInitFlag(), null);
		}
		bool lockTaken2 = false;
		try
		{
			Monitor.Enter(_0024STATIC_0024NewPrintDetails_0024201110128195_0024CurrentPage_0024Init, ref lockTaken2);
			if (_0024STATIC_0024NewPrintDetails_0024201110128195_0024CurrentPage_0024Init.State == 0)
			{
				_0024STATIC_0024NewPrintDetails_0024201110128195_0024CurrentPage_0024Init.State = 2;
				_0024STATIC_0024NewPrintDetails_0024201110128195_0024CurrentPage = 0;
			}
			else if (_0024STATIC_0024NewPrintDetails_0024201110128195_0024CurrentPage_0024Init.State == 2)
			{
				throw new IncompleteInitialization();
			}
		}
		finally
		{
			_0024STATIC_0024NewPrintDetails_0024201110128195_0024CurrentPage_0024Init.State = 1;
			if (lockTaken2)
			{
				Monitor.Exit(_0024STATIC_0024NewPrintDetails_0024201110128195_0024CurrentPage_0024Init);
			}
		}
		Graphics graphics = CreateGraphics();
		checked
		{
			int num2 = (int)Math.Round(graphics.DpiX);
			int num3 = (int)Math.Round(graphics.DpiY);
			graphics.Dispose();
			Rectangle empty = Rectangle.Empty;
			float num4 = (float)(4.0 * ((double)num2 / 96.0));
			float num5 = (float)((double)ListView1.Font.Height + 10.0 * ((double)num2 / 96.0));
			StringFormat stringFormat = new StringFormat();
			float num6 = e.Graphics.MeasureString(Conversions.ToString(_0024STATIC_0024NewPrintDetails_0024201110128195_0024CurrentPage), ListView1.Font).Width;
			stringFormat.FormatFlags = StringFormatFlags.NoWrap;
			stringFormat.Trimming = StringTrimming.EllipsisCharacter;
			stringFormat.LineAlignment = StringAlignment.Center;
			_0024STATIC_0024NewPrintDetails_0024201110128195_0024CurrentPage++;
			int num7 = 15;
			int num8 = e.MarginBounds.Y + 260;
			empty.X = num7;
			empty.Y = num8;
			empty.Width = 40;
			empty.Height = 20;
			if (Operators.CompareString(text, "TEXTIL KATALINA S.A.", TextCompare: true) == 0)
			{
				int num9 = 0;
				do
				{
					switch (num9)
					{
					case 0:
						e.Graphics.FillRectangle(Brushes.LightGray, empty);
						e.Graphics.DrawRectangle(Pens.DarkGray, empty);
						empty.X = (int)Math.Round((float)empty.X + num4);
						empty.Width = (int)Math.Round((float)empty.Width - num4);
						e.Graphics.DrawString("Un.", ListView1.Font, Brushes.Black, empty, stringFormat);
						break;
					case 1:
						empty.Width = (int)Math.Round((float)empty.Width - num4);
						empty.Width = 170;
						e.Graphics.FillRectangle(Brushes.LightGray, empty);
						e.Graphics.DrawRectangle(Pens.DarkGray, empty);
						e.Graphics.DrawString("PRODUCTO", ListView1.Font, Brushes.Black, empty, stringFormat);
						break;
					case 2:
						empty.Width = (int)Math.Round((float)empty.Width - num4);
						empty.Width = 120;
						e.Graphics.FillRectangle(Brushes.LightGray, empty);
						e.Graphics.DrawRectangle(Pens.DarkGray, empty);
						e.Graphics.DrawString("CODIGO", ListView1.Font, Brushes.Black, empty, stringFormat);
						break;
					case 3:
						empty.Width = (int)Math.Round((float)empty.Width - num4);
						empty.Width = 120;
						e.Graphics.FillRectangle(Brushes.LightGray, empty);
						e.Graphics.DrawRectangle(Pens.DarkGray, empty);
						e.Graphics.DrawString("METROS", ListView1.Font, Brushes.Black, empty, stringFormat);
						break;
					case 4:
						empty.Width = (int)Math.Round((float)empty.Width - num4);
						empty.Width = 120;
						e.Graphics.FillRectangle(Brushes.LightGray, empty);
						e.Graphics.DrawRectangle(Pens.DarkGray, empty);
						e.Graphics.DrawString("KILOS", ListView1.Font, Brushes.Black, empty, stringFormat);
						break;
					case 5:
						empty.Width = (int)Math.Round((float)empty.Width - num4);
						empty.Width = 30;
						e.Graphics.FillRectangle(Brushes.LightGray, empty);
						e.Graphics.DrawRectangle(Pens.DarkGray, empty);
						e.Graphics.DrawString("Q.", ListView1.Font, Brushes.Black, empty, stringFormat);
						break;
					case 6:
						empty.Width = (int)Math.Round((float)empty.Width - num4);
						empty.Width = 120;
						e.Graphics.FillRectangle(Brushes.LightGray, empty);
						e.Graphics.DrawRectangle(Pens.DarkGray, empty);
						e.Graphics.DrawString("CODEEMPRESA", ListView1.Font, Brushes.Black, empty, stringFormat);
						break;
					}
					empty.X += empty.Width;
					num9++;
				}
				while (num9 <= 6);
			}
			else
			{
				int num10 = 0;
				do
				{
					switch (num10)
					{
					case 0:
						e.Graphics.FillRectangle(Brushes.LightGray, empty);
						e.Graphics.DrawRectangle(Pens.DarkGray, empty);
						empty.X = (int)Math.Round((float)empty.X + num4);
						empty.Width = (int)Math.Round((float)empty.Width - num4);
						e.Graphics.DrawString("Un.", ListView1.Font, Brushes.Black, empty, stringFormat);
						break;
					case 1:
						empty.Width = (int)Math.Round((float)empty.Width - num4);
						empty.Width = 410;
						e.Graphics.FillRectangle(Brushes.LightGray, empty);
						e.Graphics.DrawRectangle(Pens.DarkGray, empty);
						e.Graphics.DrawString("PRODUCTO", ListView1.Font, Brushes.Black, empty, stringFormat);
						break;
					case 2:
						empty.Width = (int)Math.Round((float)empty.Width - num4);
						empty.Width = 120;
						e.Graphics.FillRectangle(Brushes.LightGray, empty);
						e.Graphics.DrawRectangle(Pens.DarkGray, empty);
						e.Graphics.DrawString("CODIGO", ListView1.Font, Brushes.Black, empty, stringFormat);
						break;
					case 3:
						empty.Width = (int)Math.Round((float)empty.Width - num4);
						empty.Width = 30;
						e.Graphics.FillRectangle(Brushes.LightGray, empty);
						e.Graphics.DrawRectangle(Pens.DarkGray, empty);
						e.Graphics.DrawString("V.", ListView1.Font, Brushes.Black, empty, stringFormat);
						break;
					case 4:
						empty.Width = (int)Math.Round((float)empty.Width - num4);
						empty.Width = 120;
						e.Graphics.FillRectangle(Brushes.LightGray, empty);
						e.Graphics.DrawRectangle(Pens.DarkGray, empty);
						e.Graphics.DrawString("CODEEMPRESA", ListView1.Font, Brushes.Black, empty, stringFormat);
						break;
					}
					empty.X += empty.Width;
					num10++;
				}
				while (num10 <= 4);
			}
			num7 = 15;
			num8 += 20;
			empty.X = num7;
			empty.Y = num8;
			empty.Width = 40;
			empty.Height = 20;
			int num11 = 0;
			int num12 = _0024STATIC_0024NewPrintDetails_0024201110128195_0024LastIndex;
			int num13 = selectedOrderItems.Count - 1;
			for (int i = num12; i <= num13; i++)
			{
				if (num11 > 25)
				{
					num11 = 0;
					_0024STATIC_0024NewPrintDetails_0024201110128195_0024LastIndex = i;
					e.HasMorePages = true;
					stringFormat.Dispose();
					return;
				}
				bultosTotales += int.Parse(Conversions.ToString(selectedOrderItems[i].unidades));
				pesoTotal += double.Parse(selectedOrderItems[i].peso);
				metrosTotal += double.Parse(selectedOrderItems[i].ancho);
				num11++;
				e.Graphics.DrawRectangle(Pens.DarkGray, empty);
				empty.X = (int)Math.Round((float)empty.X + num4);
				empty.Width = (int)Math.Round((float)empty.Width - num4);
				e.Graphics.DrawString(Conversions.ToString(selectedOrderItems[i].unidades), ListView1.Font, Brushes.Black, empty, stringFormat);
				if (Operators.CompareString(text, "TEXTIL KATALINA S.A.", TextCompare: true) == 0)
				{
					empty.X += empty.Width;
					empty.Width = 170;
					e.Graphics.DrawRectangle(Pens.DarkGray, empty);
					empty.X = (int)Math.Round((float)empty.X + num4);
					empty.Width = (int)Math.Round((float)empty.Width - num4);
					e.Graphics.DrawString(selectedOrderItems[i].producto, ListView1.Font, Brushes.Black, empty, stringFormat);
					empty.X += empty.Width;
					empty.Width = 120;
					e.Graphics.DrawRectangle(Pens.DarkGray, empty);
					empty.X = (int)Math.Round((float)empty.X + num4);
					empty.Width = (int)Math.Round((float)empty.Width - num4);
					e.Graphics.DrawString(selectedOrderItems[i].codigo, ListView1.Font, Brushes.Black, empty, stringFormat);
					empty.X += empty.Width;
					empty.Width = 120;
					e.Graphics.DrawRectangle(Pens.DarkGray, empty);
					empty.X = (int)Math.Round((float)empty.X + num4);
					empty.Width = (int)Math.Round((float)empty.Width - num4);
					e.Graphics.DrawString(selectedOrderItems[i].ancho, ListView1.Font, Brushes.Black, empty, stringFormat);
					empty.X += empty.Width;
					empty.Width = 120;
					e.Graphics.DrawRectangle(Pens.DarkGray, empty);
					empty.X = (int)Math.Round((float)empty.X + num4);
					empty.Width = (int)Math.Round((float)empty.Width - num4);
					e.Graphics.DrawString(selectedOrderItems[i].peso, ListView1.Font, Brushes.Black, empty, stringFormat);
					empty.X += empty.Width;
					empty.Width = 30;
					e.Graphics.DrawRectangle(Pens.DarkGray, empty);
					empty.X = (int)Math.Round((float)empty.X + num4);
					empty.Width = (int)Math.Round((float)empty.Width - num4);
					e.Graphics.DrawString(selectedOrderItems[i].precio, ListView1.Font, Brushes.Black, empty, stringFormat);
				}
				else
				{
					empty.X += empty.Width;
					empty.Width = 410;
					e.Graphics.DrawRectangle(Pens.DarkGray, empty);
					empty.X = (int)Math.Round((float)empty.X + num4);
					empty.Width = (int)Math.Round((float)empty.Width - num4);
					e.Graphics.DrawString(selectedOrderItems[i].producto, ListView1.Font, Brushes.Black, empty, stringFormat);
					empty.X += empty.Width;
					empty.Width = 120;
					e.Graphics.DrawRectangle(Pens.DarkGray, empty);
					empty.X = (int)Math.Round((float)empty.X + num4);
					empty.Width = (int)Math.Round((float)empty.Width - num4);
					e.Graphics.DrawString(selectedOrderItems[i].codigo, ListView1.Font, Brushes.Black, empty, stringFormat);
					empty.X += empty.Width;
					empty.Width = 30;
					e.Graphics.DrawRectangle(Pens.DarkGray, empty);
					empty.X = (int)Math.Round((float)empty.X + num4);
					empty.Width = (int)Math.Round((float)empty.Width - num4);
					e.Graphics.DrawString(Conversions.ToString(selectedOrderItems[i].variacion), ListView1.Font, Brushes.Black, empty, stringFormat);
				}
				empty.X += empty.Width;
				empty.Width = 120;
				e.Graphics.DrawRectangle(Pens.DarkGray, empty);
				empty.X = (int)Math.Round((float)empty.X + num4);
				empty.Width = (int)Math.Round((float)empty.Width - num4);
				e.Graphics.DrawString(selectedOrderItems[i].codigoempresa, ListView1.Font, Brushes.Black, empty, stringFormat);
				empty.X = 15;
				empty.Y += 20;
				empty.Width = 40;
			}
			if (Operators.CompareString(text, "TEXTIL KATALINA S.A.", TextCompare: true) == 0)
			{
				e.Graphics.DrawString("Kilos TOTAL.: " + Conversions.ToString(pesoTotal), font4, Brushes.Black, 400f, 270f);
				e.Graphics.DrawString("Metros TOTAL.: " + Conversions.ToString(metrosTotal), font4, Brushes.Black, 400f, 290f);
			}
			stringFormat.Dispose();
			_0024STATIC_0024NewPrintDetails_0024201110128195_0024LastIndex = 0;
			_0024STATIC_0024NewPrintDetails_0024201110128195_0024CurrentPage = 0;
			e.Graphics.DrawString("Observación:", font4, Brushes.Black, 100f, 920f);
			if (selectedOrder.observacion.Length > 90)
			{
				string s = selectedOrder.observacion.Substring(0, 90);
				e.Graphics.DrawString(s, font, Brushes.Black, 100f, 940f);
				string s2 = selectedOrder.observacion.Substring(90);
				e.Graphics.DrawString(s2, font, Brushes.Black, 100f, 960f);
			}
			else
			{
				e.Graphics.DrawString(selectedOrder.observacion, font, Brushes.Black, 100f, 940f);
			}
			e.Graphics.DrawString("Bultos: " + Conversions.ToString(bultosTotales), font4, Brushes.Black, 55f, 240f);
			bultosTotales = 0;
			pesoTotal = 0.0;
			metrosTotal = 0.0;
			e.Graphics.DrawString("Preparo:", font4, Brushes.Black, 100f, 1000f);
			e.Graphics.DrawString("____________________", font4, Brushes.Black, 170f, 1000f);
			e.Graphics.DrawString("Controlo:", font4, Brushes.Black, 350f, 1000f);
			e.Graphics.DrawString("____________________", font4, Brushes.Black, 420f, 1000f);
			e.Graphics.DrawString("Valor CTR: $" + Conversions.ToString(selectedOrder.valorCtr), font4, Brushes.Black, 170f, 1050f);
			e.Graphics.DrawString("Valor Declarado: $" + Conversions.ToString(selectedOrder.valor), font4, Brushes.Black, 420f, 1050f);
			switch (selectedOrder.estado)
			{
			case 4:
				e.Graphics.DrawString("ANULADA", font5, Brushes.Black, 200f, 840f);
				break;
			case 3:
				e.Graphics.DrawString("EN DISTRIBUCION", font5, Brushes.Black, 110f, 840f);
				break;
			case 2:
				e.Graphics.DrawString("PREPARADA", font5, Brushes.Black, 200f, 840f);
				break;
			}
		}
	}

	private void AnularToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (ListView1.SelectedItems.Count <= 0)
		{
			return;
		}
		int num = (int)MessageBox.Show("Desea Eliminar la Orden " + ListView1.SelectedItems[0].SubItems[3].Text, "Atencion", MessageBoxButtons.YesNoCancel);
		if (num == 2 || num == 7 || num != 6)
		{
			return;
		}
		int num2 = int.Parse(ListView1.SelectedItems[0].Text);
		int num3 = 4;
		string left = ListView1.SelectedItems[0].SubItems[7].Text;
		if (Operators.CompareString(left, "PENDIENTE", TextCompare: true) == 0)
		{
			string sQL = "UPDATE ordenes SET numero = '" + ListView1.SelectedItems[0].SubItems[3].Text + "A' , estado = 4 , usuario='" + MySettingsProperty.Settings.Usuario + "' WHERE id=" + Conversions.ToString(num2);
			int num4 = Conversions.ToInteger(Mod_ConeccionBD.BD_Sentencia(sQL));
			if (num4 == 1)
			{
				loadData(1);
			}
			else
			{
				Interaction.MsgBox("ERROR: No se puede Anular la orden.");
			}
		}
		else
		{
			Interaction.MsgBox("No se puede Anular la orden Preparada");
		}
	}

	private void NuevoToolStripMenuItem_Click(object sender, EventArgs e)
	{
		switch (modo)
		{
		case 0:
			Interaction.MsgBox("Modo default");
			break;
		case 1:
			MyProject.Forms.New_Orden.Show();
			break;
		}
	}

	private void ImprimirToolStripMenuItem_Click(object sender, EventArgs e)
	{
		indiceOrdenes = 0;
		print_empresa = string.Empty;
		selectedOrder = default(Mod_Ordenes.ordendesalida);
		selectedOrderItems = new List<Mod_Ordenes.orderDetallePrint>();
		selectedDestinatario = default(Mod_Ordenes.Destino);
		checkedOrdenes = new List<Mod_interfas.CheckedOrdenes>();
		checked
		{
			if (ListView1.CheckedItems.Count > 0)
			{
				Mod_interfas.CheckedOrdenes item = default(Mod_interfas.CheckedOrdenes);
				foreach (ListViewItem checkedItem in ListView1.CheckedItems)
				{
					item.id = int.Parse(checkedItem.Text);
					checkedOrdenes.Add(item);
				}
				{
					foreach (Mod_interfas.CheckedOrdenes checkedOrdene in checkedOrdenes)
					{
						print_order = int.Parse(Conversions.ToString(checkedOrdene.id));
						object orderById = Mod_Ordenes.getOrderById(print_order);
						selectedOrder = ((orderById != null) ? ((Mod_Ordenes.ordendesalida)orderById) : default(Mod_Ordenes.ordendesalida));
						print_empresa = ListView1.CheckedItems[indiceOrdenes].SubItems[1].Text;
						if (selectedOrder.numero != null)
						{
							selectedOrderItems = (List<Mod_Ordenes.orderDetallePrint>)Mod_Ordenes.getOrderItemsByOrder(selectedOrder.id);
							object destinatario = Mod_Ordenes.getDestinatario(selectedOrder.destinatario);
							selectedDestinatario = ((destinatario != null) ? ((Mod_Ordenes.Destino)destinatario) : default(Mod_Ordenes.Destino));
							PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
							PrintOrderPicking.DefaultPageSettings.Landscape = true;
							PrintOrderPicking.Print();
							indiceOrdenes++;
							continue;
						}
						Interaction.MsgBox("Error al recuperar la orden");
						break;
					}
					return;
				}
			}
			Interaction.MsgBox("Debe marcar los items antes de Imprimir.");
		}
	}

	private void MovimientosToolStripMenuItem_Click(object sender, EventArgs e)
	{
		string fileName = "http://api-interna.area54sa.com.ar/Rollos/selector.php";
		Process.Start(fileName);
	}

	private void ExportarOrdenesToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (Operators.ConditionalCompareObjectGreater(cmbEmpresas.SelectedValue, 0, TextCompare: true))
		{
			if (ListView1.CheckedItems.Count > 0)
			{
				List<Mod_interfas.CheckedOrdenes> list = new List<Mod_interfas.CheckedOrdenes>();
				Mod_interfas.CheckedOrdenes item = default(Mod_interfas.CheckedOrdenes);
				foreach (ListViewItem checkedItem in ListView1.CheckedItems)
				{
					if (Operators.CompareString(checkedItem.SubItems[7].Text, "PREPARADO", TextCompare: true) == 0)
					{
						item.id = int.Parse(checkedItem.Text);
						list.Add(item);
						checkedItem.Checked = false;
						continue;
					}
					Interaction.MsgBox("La orden " + checkedItem.Text + " No esta en estado PREPARADO");
					return;
				}
				Mod_interfas.ADistribucionOrdenes(Conversions.ToInteger(cmbEmpresas.SelectedValue), list);
			}
			else
			{
				Interaction.MsgBox("Debe marcar los items antes de importar.");
			}
		}
		else
		{
			Interaction.MsgBox("Esta opcion solo se aplica cuando se filtra por cliente");
		}
	}

	private void IngresoMasivoToolStripMenuItem_Click(object sender, EventArgs e)
	{
		MyProject.Forms.ImportarOrdenes.Show();
	}

	private void ToolStripTextBox1_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (e.KeyChar == '\r')
		{
			string text = ToolStripTextBox1.Text;
			ListViewItem listViewItem = ListView1.FindItemWithText(text, includeSubItemsInSearch: true, 0, isPrefixSearch: false);
			if (listViewItem != null)
			{
				listViewItem.Selected = true;
				listViewItem.EnsureVisible();
				ListView1.FocusedItem = listViewItem;
			}
			else
			{
				Interaction.MsgBox("No se encontraron resultados.");
			}
		}
	}

	private void DetalleToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected O, but got Unknown
		if (ListView1.SelectedItems.Count > 0)
		{
			Mod_api_ordenes.SelectOrder ordenConsultada = default(Mod_api_ordenes.SelectOrder);
			string text = ListView1.SelectedItems[0].SubItems[1].Text;
			string sql = "SELECT e.id, e.password FROM empresas e WHERE e.nombre = '" + text + "'";
			DataTable dataTable = (DataTable)Mod_Sentencias.data(sql);
			if (dataTable.Rows.Count == 1)
			{
				ordenConsultada.user = int.Parse(Conversions.ToString(dataTable.Rows[0]["id"]));
				ordenConsultada.token = Conversions.ToString(Mod_api_ordenes.LoginApi(Conversions.ToString(int.Parse(Conversions.ToString(dataTable.Rows[0]["id"]))), Conversions.ToString(dataTable.Rows[0]["password"])));
				ordenConsultada.order = ListView1.SelectedItems[0].Text;
				Console.WriteLine(ordenConsultada.ToString());
				string value = Mod_api_ordenes.SelectOrdenJson(ordenConsultada).ToString();
				Console.WriteLine(value);
				Mod_api_ordenes.OrderDetalle((JObject)Mod_api_ordenes.SelectOrdenJson(ordenConsultada));
			}
		}
		else
		{
			Interaction.MsgBox("Seleccione una orden.");
		}
	}

	private void ToolStripButton1_Click(object sender, EventArgs e)
	{
		loadData(1);
	}

	private void loadEmpresasCombo()
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		if (Conversions.ToDouble(MySettingsProperty.Settings.Permiso) == 10.0)
		{
			cmbEmpresas.DropDownStyle = ComboBoxStyle.DropDown;
		}
		try
		{
			string text = "Select nombre, id FROM empresas WHERE estado=1 and tipo = 1";
			DataTable dataTable = new DataTable("x");
			MySqlDataAdapter val = new MySqlDataAdapter(text, Mod_Sentencias.cnn);
			((DbDataAdapter)(object)val).Fill(dataTable);
			if (dataTable.Rows.Count > 0)
			{
				cmbEmpresas.SelectedIndex = -1;
				Dictionary<string, string> dictionary = new Dictionary<string, string>();
				dictionary.Add(Conversions.ToString(0), "TODAS LAS EMPRESAS");
				foreach (DataRow row in dataTable.Rows)
				{
					dictionary.Add(row[1].ToString(), Conversions.ToString(row[0]));
				}
				cmbEmpresas.DataSource = new BindingSource(dictionary, null);
				cmbEmpresas.DisplayMember = "Value";
				cmbEmpresas.ValueMember = "Key";
				cmbEmpresas.SelectedIndex = -1;
			}
			else
			{
				cmbEmpresas.DataSource = null;
				cmbEmpresas.Items.Clear();
				cmbEmpresas.SelectedIndex = -1;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox(ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		Button1.Enabled = false;
		int num = Conversions.ToInteger(cmbEmpresas.SelectedValue);
		Interaction.MsgBox("Se mostraran solo los registros para la empresa: " + Conversions.ToString(num) + " - " + cmbEmpresas.Text);
		if (num > 0)
		{
			try
			{
				ListView1.Columns.Clear();
				string sql = "SELECT o.id, e.nombre as empresa, t.descripcion as tipo, o.numero, d.nombre as destino, o.prioridad, o.valor, s.descripcion as estado, o.fechaCreacion as Creado, o.fechaPreparado as Preparado, o.fecha as UltimaModificacion FROM ((((ORDENES o LEFT JOIN orderstatus s ON o.estado = s.id) LEFT JOIN empresas e ON o.empresa = e.id) LEFT JOIN ordertipo t ON o.tipo = t.id ) LEFT JOIN destinos d ON o.eventual = d.id) WHERE o.empresa = " + Conversions.ToString(num) + " ORDER BY o.id desc LIMIT 5000";
				Mod_Sentencias.cargar_datos_lv_completa(ListView1, sql, Label1);
				contador.Text = Label1.Text;
				int num2 = (from object item in ListView1.Items
					select (ListViewItem)item into item
					where Operators.CompareString(item.SubItems[7].Text, "PENDIENTE", TextCompare: true) == 0
					select (item)).Count();
				ToolStripStatusLabel3.Text = Conversions.ToString(num2);
				int num3 = (from object item in ListView1.Items
					select (ListViewItem)item into item
					where Operators.CompareString(item.SubItems[7].Text, "PREPARADO", TextCompare: true) == 0
					select (item)).Count();
				ToolStripStatusLabel5.Text = Conversions.ToString(num3);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				Interaction.MsgBox("Ocurrio un error al recuperar los datos");
				ProjectData.ClearProjectError();
			}
		}
		else if (num == 0)
		{
			loadData(1);
		}
		Button1.Enabled = true;
	}

	private void RevertirNovedadToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if ((ListView1.SelectedItems.Count > 0) & (Conversions.ToDouble(MySettingsProperty.Settings.Permiso) == 10.0))
		{
			string sQL = "UPDATE ordenes SET estado=2, usuario='" + MySettingsProperty.Settings.Usuario + "' WHERE id=" + ListView1.SelectedItems[0].Text + " and estado=3";
			int num = (int)MessageBox.Show("Se regresara a PREPARADO la orden seleccionada", "Atencion", MessageBoxButtons.YesNoCancel);
			if (num != 2 && num != 7 && num == 6)
			{
				int num2 = Conversions.ToInteger(Mod_ConeccionBD.BD_Sentencia(sQL));
				if (num2 == 1)
				{
					MessageBox.Show("Se actualizo el estado de la Orden");
				}
				else
				{
					Interaction.MsgBox("Ocurrio un error");
				}
			}
		}
		else
		{
			Interaction.MsgBox("Debes seleccionar una orden con estado: A DISTRIBUICION");
		}
	}

	private void GenerarHDRToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (Operators.ConditionalCompareObjectGreater(cmbEmpresas.SelectedValue, 0, TextCompare: true))
		{
			if (ListView1.CheckedItems.Count > 0)
			{
				List<Mod_interfas.CheckedOrdenes> list = new List<Mod_interfas.CheckedOrdenes>();
				Mod_interfas.CheckedOrdenes item = default(Mod_interfas.CheckedOrdenes);
				foreach (ListViewItem checkedItem in ListView1.CheckedItems)
				{
					if (Operators.CompareString(checkedItem.SubItems[7].Text, "PREPARADO", TextCompare: true) == 0)
					{
						item.id = int.Parse(checkedItem.Text);
						list.Add(item);
						checkedItem.Checked = false;
						continue;
					}
					Interaction.MsgBox("La orden " + checkedItem.Text + " No esta en estado PREPARADO");
					return;
				}
				Mod_interfas.ExportarCheckedOrdenes(Conversions.ToInteger(cmbEmpresas.SelectedValue), list);
			}
			else
			{
				Interaction.MsgBox("Debe marcar los items antes de importar.");
			}
		}
		else
		{
			Interaction.MsgBox("Esta opcion solo se aplica cuando se filtra por cliente");
		}
	}

	private void ExportarSeleccionToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (Operators.ConditionalCompareObjectGreater(cmbEmpresas.SelectedValue, 0, TextCompare: true))
		{
			if (ListView1.CheckedItems.Count > 0)
			{
				List<Mod_interfas.CheckedOrdenes> list = new List<Mod_interfas.CheckedOrdenes>();
				Mod_interfas.CheckedOrdenes item = default(Mod_interfas.CheckedOrdenes);
				foreach (ListViewItem checkedItem in ListView1.CheckedItems)
				{
					item.id = int.Parse(checkedItem.Text);
					list.Add(item);
					checkedItem.Checked = false;
				}
				Mod_interfas.ExportarOrdenesAExcel(Conversions.ToInteger(cmbEmpresas.SelectedValue), list);
			}
			else
			{
				Interaction.MsgBox("Debe marcar los items antes de importar.");
			}
		}
		else
		{
			Interaction.MsgBox("Esta opcion solo se aplica cuando se filtra por cliente");
		}
	}

	private void ImpresionMasivaToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (ListView1.CheckedItems.Count > 0)
		{
			Mod_interfas.CheckedOrdenes item = default(Mod_interfas.CheckedOrdenes);
			foreach (ListViewItem checkedItem in ListView1.CheckedItems)
			{
				item.id = int.Parse(checkedItem.Text);
				checkedOrdenes.Add(item);
				checkedItem.Checked = false;
			}
			try
			{
				foreach (Mod_interfas.CheckedOrdenes checkedOrdene in checkedOrdenes)
				{
					print_order = int.Parse(Conversions.ToString(checkedOrdene.id));
					object orderById = Mod_Ordenes.getOrderById(print_order);
					selectedOrder = ((orderById != null) ? ((Mod_Ordenes.ordendesalida)orderById) : default(Mod_Ordenes.ordendesalida));
					if (selectedOrder.numero != null)
					{
						selectedOrderItems = (List<Mod_Ordenes.orderDetallePrint>)Mod_Ordenes.getOrderItemsByOrder(selectedOrder.id);
						object destinatario = Mod_Ordenes.getDestinatario(selectedOrder.destinatario);
						selectedDestinatario = ((destinatario != null) ? ((Mod_Ordenes.Destino)destinatario) : default(Mod_Ordenes.Destino));
						PrintDocument2.Print();
						continue;
					}
					Interaction.MsgBox("Error al recuperar la orden");
					break;
				}
				return;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
				return;
			}
		}
		Interaction.MsgBox("Debe marcar los items antes de Imprimir.");
	}

	private void PrintDocument2_PrintPage(object sender, PrintPageEventArgs e)
	{
		NewPrintDetails(ref e);
	}

	private void PrintOrderPicking_PrintPage(object sender, PrintPageEventArgs e)
	{
		OrderPicking(e);
	}

	private void OrderPicking(PrintPageEventArgs e)
	{
		int num = 27;
		checked
		{
			int num2 = (int)Math.Ceiling((double)selectedOrderItems.Count / (double)num);
			Font font = new Font("Arial", 6.75f, FontStyle.Italic, GraphicsUnit.Point, 0);
			Font font2 = new Font("Arial", 16.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Font font3 = new Font("Arial", 14.75f, FontStyle.Italic, GraphicsUnit.Point, 0);
			Font font4 = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Font font5 = new Font("Arial", 26f, FontStyle.Bold, GraphicsUnit.Point, 0);
			if (_0024STATIC_0024OrderPicking_00242011128195_0024LastIndex_0024Init == null)
			{
				Interlocked.CompareExchange(ref _0024STATIC_0024OrderPicking_00242011128195_0024LastIndex_0024Init, new StaticLocalInitFlag(), null);
			}
			bool lockTaken = false;
			try
			{
				Monitor.Enter(_0024STATIC_0024OrderPicking_00242011128195_0024LastIndex_0024Init, ref lockTaken);
				if (_0024STATIC_0024OrderPicking_00242011128195_0024LastIndex_0024Init.State == 0)
				{
					_0024STATIC_0024OrderPicking_00242011128195_0024LastIndex_0024Init.State = 2;
					_0024STATIC_0024OrderPicking_00242011128195_0024LastIndex = 0;
				}
				else if (_0024STATIC_0024OrderPicking_00242011128195_0024LastIndex_0024Init.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				_0024STATIC_0024OrderPicking_00242011128195_0024LastIndex_0024Init.State = 1;
				if (lockTaken)
				{
					Monitor.Exit(_0024STATIC_0024OrderPicking_00242011128195_0024LastIndex_0024Init);
				}
			}
			int num3 = 5;
			int num4 = 20;
			e.Graphics.DrawLine(Pens.Brown, 1, 1, 1140 - num4, 1);
			e.Graphics.DrawLine(Pens.Brown, 1, 1, 1, 800 - num4);
			e.Graphics.DrawLine(Pens.Brown, 1, 800 - num4, 1140 - num4, 800 - num4);
			e.Graphics.DrawLine(Pens.Brown, 1140 - num4, 1, 1140 - num4, 800 - num4);
			int num5 = 0;
			int num6 = num4 * 9;
			int num7 = 0;
			do
			{
				num6 += 20;
				e.Graphics.DrawLine(Pens.Brown, 0, num6, 1140 - num4, num6);
				num7++;
			}
			while (num7 <= 26);
			Image logoArea = Resources.logoArea;
			e.Graphics.DrawImage(logoArea, num4, num4);
			e.Graphics.DrawString("ORDEN DE PICKING", font5, Brushes.Black, num4 * 14, num4);
			e.Graphics.DrawString("Número: " + Conversions.ToString(selectedOrder.id), font4, Brushes.Black, num4 * 15, num4 * 3);
			e.Graphics.DrawString("Remito número: " + selectedOrder.numero, font4, Brushes.Black, num4 * 44, num4);
			e.Graphics.DrawString("Hoja: " + Conversions.ToString(hojaActual) + "/" + Conversions.ToString(num2), font3, Brushes.Black, num4 * 44, num4 * 2);
			e.Graphics.DrawLine(Pens.Brown, 1, num4 * 4, 1140 - num4, num4 * 4);
			e.Graphics.DrawString("Empresa: " + print_empresa, font4, Brushes.Black, num4 + 4, num4 * 4 + num3);
			e.Graphics.DrawString("Fecha: " + Conversions.ToString(selectedOrder.fecha), font4, Brushes.Black, num4 + 4, num4 * 5 + num3);
			e.Graphics.DrawString("Observación:", font4, Brushes.Black, num4 + 4, num4 * 6 + num3);
			if (selectedOrder.observacion.Length > 90)
			{
				string s = selectedOrder.observacion.Substring(0, 90);
				e.Graphics.DrawString(s, font4, Brushes.Black, num4 * 7, num4 * 6 + num3);
			}
			else
			{
				e.Graphics.DrawString(selectedOrder.observacion, font4, Brushes.Black, num4 * 7, num4 * 6 + num3);
			}
			e.Graphics.DrawString("Valor CTR: $" + Conversions.ToString(selectedOrder.valorCtr), font4, Brushes.Black, num4 * 25, num4 * 4 + num3);
			e.Graphics.DrawString("Valor Declarado: $" + Conversions.ToString(selectedOrder.valor), font4, Brushes.Black, num4 * 25, num4 * 5 + num3);
			e.Graphics.DrawLine(Pens.Brown, 1, num4 * 8, 1140 - num4, num4 * 8);
			e.Graphics.DrawString("Tot. Unid.", font4, Brushes.Black, 5f, num4 * 8 + num3);
			e.Graphics.DrawString("Producto", font4, Brushes.Black, num4 * 5 + 4, num4 * 8 + num3);
			e.Graphics.DrawString("Cod. Emp.", font4, Brushes.Black, num4 * 25 + 4, num4 * 8 + num3);
			e.Graphics.DrawString("EAN", font4, Brushes.Black, num4 * 31 + 4, num4 * 8 + num3);
			e.Graphics.DrawString("Pos.", font4, Brushes.Black, num4 * 37 + 4, num4 * 8 + num3);
			e.Graphics.DrawString("Cajas", font4, Brushes.Black, num4 * 43 + 4, num4 * 8 + num3);
			e.Graphics.DrawString("Inner", font4, Brushes.Black, num4 * 47 + 4, num4 * 8 + num3);
			e.Graphics.DrawString("Unidades", font4, Brushes.Black, num4 * 51 + 4, num4 * 8 + num3);
			e.Graphics.DrawString("V.", font4, Brushes.Black, num4 * 55 + 4, num4 * 8 + num3);
			e.Graphics.DrawLine(Pens.Brown, 1, num4 * 9, 1140 - num4, num4 * 9);
			e.Graphics.DrawLine(Pens.Brown, num4 * 5, num4 * 8, num4 * 5, num4 * 36);
			e.Graphics.DrawLine(Pens.Brown, num4 * 25, num4 * 8, num4 * 25, num4 * 36);
			e.Graphics.DrawLine(Pens.Brown, num4 * 31, num4 * 8, num4 * 31, num4 * 36);
			e.Graphics.DrawLine(Pens.Brown, num4 * 37, num4 * 8, num4 * 37, num4 * 36);
			e.Graphics.DrawLine(Pens.Brown, num4 * 43, num4 * 8, num4 * 43, num4 * 36);
			e.Graphics.DrawLine(Pens.Brown, num4 * 47, num4 * 8, num4 * 47, num4 * 36);
			e.Graphics.DrawLine(Pens.Brown, num4 * 46, num4 * 8, num4 * 46, num4 * 36);
			e.Graphics.DrawLine(Pens.Brown, num4 * 51, num4 * 8, num4 * 51, num4 * 36);
			e.Graphics.DrawLine(Pens.Brown, num4 * 50, num4 * 8, num4 * 50, num4 * 36);
			e.Graphics.DrawLine(Pens.Brown, num4 * 55, num4 * 8, num4 * 55, num4 * 36);
			e.Graphics.DrawLine(Pens.Brown, num4 * 54, num4 * 8, num4 * 54, num4 * 36);
			e.Graphics.DrawLine(Pens.Brown, num4 * 56, num4 * 8, num4 * 56, num4 * 36);
			e.Graphics.DrawString("USUARIO IMPRESION: " + MySettingsProperty.Settings.Usuario, font, Brushes.Black, num4 * 32 + 4, num4 * 38 + num3);
			string text = DateAndTime.Now.ToString();
			e.Graphics.DrawString("FECHA IMPRESION: " + text, font, Brushes.Black, num4 * 44 + 4, num4 * 38 + num3);
			e.Graphics.DrawLine(Pens.Brown, 1, num4 * 38, 1140 - num4, num4 * 38);
			int num8 = 0;
			int num9 = _0024STATIC_0024OrderPicking_00242011128195_0024LastIndex;
			int num10 = selectedOrderItems.Count - 1;
			for (int i = num9; i <= num10; i++)
			{
				if (num8 > num)
				{
					num8 = 0;
					_0024STATIC_0024OrderPicking_00242011128195_0024LastIndex = i;
					hojaActual++;
					e.HasMorePages = true;
					return;
				}
				bultosTotales += int.Parse(Conversions.ToString(selectedOrderItems[i].unidades));
				pesoTotal += double.Parse(selectedOrderItems[i].peso);
				metrosTotal += double.Parse(selectedOrderItems[i].ancho);
				num8++;
				int id = selectedOrderItems[i].id;
				int unidades = selectedOrderItems[i].unidades;
				int num11 = Conversions.ToInteger(Mod_Calculos.CalculoDeCajas(id, unidades));
				int num12 = Conversions.ToInteger(Operators.SubtractObject(unidades, Mod_Calculos.UnidadesEnCajas(id, num11)));
				int num13 = Conversions.ToInteger(Mod_Calculos.CalculoDeInner(id, num12));
				num12 = Conversions.ToInteger(Operators.SubtractObject(num12, Mod_Calculos.UnidadesEnInner(id, num13)));
				e.Graphics.DrawString(Conversions.ToString(selectedOrderItems[i].unidades), ListView1.Font, Brushes.Black, num4 + 4, num4 * 7 + num4 * (num8 + 1) + num3);
				e.Graphics.DrawString(selectedOrderItems[i].producto, ListView1.Font, Brushes.Black, num4 * 5 + 4, num4 * 7 + num4 * (num8 + 1) + num3);
				string codigoempresa = selectedOrderItems[i].codigoempresa;
				string empty = string.Empty;
				if (Strings.Len(codigoempresa) > 17)
				{
					empty = codigoempresa.Substring(0, 16);
					e.Graphics.DrawString(empty, ListView1.Font, Brushes.Black, num4 * 25 + 4, num4 * 7 + num4 * (num8 + 1) + num3);
				}
				else
				{
					e.Graphics.DrawString(codigoempresa, ListView1.Font, Brushes.Black, num4 * 25 + 4, num4 * 7 + num4 * (num8 + 1) + num3);
				}
				string codigo = selectedOrderItems[i].codigo;
				string empty2 = string.Empty;
				if (Strings.Len(codigo) > 17)
				{
					empty2 = codigo.Substring(0, 16);
					e.Graphics.DrawString(empty2, ListView1.Font, Brushes.Black, num4 * 31 + 4, num4 * 7 + num4 * (num8 + 1) + num3);
				}
				else
				{
					e.Graphics.DrawString(codigo, ListView1.Font, Brushes.Black, num4 * 31 + 4, num4 * 7 + num4 * (num8 + 1) + num3);
				}
				e.Graphics.DrawString(selectedOrderItems[i].posicion, ListView1.Font, Brushes.Black, num4 * 37 + 4, num4 * 7 + num4 * (num8 + 1) + num3);
				e.Graphics.DrawString(Conversions.ToString(num11), ListView1.Font, Brushes.Black, num4 * 43 + 5, num4 * 7 + num4 * (num8 + 1) + num3);
				e.Graphics.DrawString(Conversions.ToString(num13), ListView1.Font, Brushes.Black, num4 * 47 + 5, num4 * 7 + num4 * (num8 + 1) + num3);
				e.Graphics.DrawString(Conversions.ToString(num12), ListView1.Font, Brushes.Black, num4 * 51 + 5, num4 * 7 + num4 * (num8 + 1) + num3);
				e.Graphics.DrawString(Conversions.ToString(selectedOrderItems[i].variacion), ListView1.Font, Brushes.Black, num4 * 55 + 4, num4 * 7 + num4 * (num8 + 1) + num3);
			}
			if (Operators.CompareString(print_empresa, "TEXTIL KATALINA S.A.", TextCompare: true) == 0)
			{
				e.Graphics.DrawString("Metros Totales: " + Conversions.ToString(metrosTotal) + " mts.", font4, Brushes.Black, num4 * 45, num4 * 6 + num3);
			}
			e.Graphics.DrawString("Kilos Totales: " + Conversions.ToString(pesoTotal) + " kgs.", font4, Brushes.Black, num4 * 45, num4 * 5 + num3);
			e.Graphics.DrawString("Bultos Totales: " + Conversions.ToString(bultosTotales), font4, Brushes.Black, num4 * 45, num4 * 4 + num3);
			_0024STATIC_0024OrderPicking_00242011128195_0024LastIndex = 0;
			bultosTotales = 0;
			pesoTotal = 0.0;
			metrosTotal = 0.0;
			e.Graphics.DrawString("Preparo:", font4, Brushes.Black, num4 * 2, num4 * 37 - num3);
			e.Graphics.DrawString("____________________", font4, Brushes.Black, num4 * 5, num4 * 37 - num3);
			e.Graphics.DrawString("Controlo:", font4, Brushes.Black, num4 * 14, num4 * 37 - num3);
			e.Graphics.DrawString("____________________", font4, Brushes.Black, num4 * 18, num4 * 37 - num3);
			e.Graphics.DrawLine(Pens.Brown, 1, num4 * 36, 1140 - num4, num4 * 36);
		}
	}

	private void InformeKatalinaToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (Operators.ConditionalCompareObjectGreater(cmbEmpresas.SelectedValue, 0, TextCompare: true))
		{
			if (ListView1.CheckedItems.Count > 0)
			{
				List<Mod_interfas.CheckedOrdenes> list = new List<Mod_interfas.CheckedOrdenes>();
				Mod_interfas.CheckedOrdenes item = default(Mod_interfas.CheckedOrdenes);
				foreach (ListViewItem checkedItem in ListView1.CheckedItems)
				{
					item.id = int.Parse(checkedItem.Text);
					list.Add(item);
					checkedItem.Checked = false;
				}
				Mod_interfas.ExportarInformeOrdenesAExcel(Conversions.ToInteger(cmbEmpresas.SelectedValue), list);
			}
			else
			{
				Interaction.MsgBox("Debe marcar los items antes de importar.");
			}
		}
		else
		{
			Interaction.MsgBox("Esta opcion solo se aplica cuando se filtra por cliente");
		}
	}

	private void RollosXPosicionToolStripMenuItem_Click(object sender, EventArgs e)
	{
		string expression = "RollosXPosicion_" + DateAndTime.Now.ToShortDateString();
		expression = Strings.Replace(expression, "/", "-", 1, -1, CompareMethod.Text);
		Interaction.MsgBox(expression);
		string sql = "SELECT COUNT(unidades), (SELECT descripcion FROM posiciones WHERE id=posicionId ) as pos FROM pos_prod WHERE productId IN (SELECT producto FROM stock WHERE empresa = '70' AND unidades != '0') AND existe = '0' GROUP BY posicionId";
		DataTable data = (DataTable)Mod_Sentencias.data(sql);
		Mod_Exportar.DataToExcelByName(data, expression);
	}
}
