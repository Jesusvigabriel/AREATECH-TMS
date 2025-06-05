using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Hermes.My;
using Hermes.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace Hermes;

[DesignerGenerated]
public class Form1_Inicio : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Importarbtn")]
	private Button _Importarbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Disponibilidadbtn")]
	private Button _Disponibilidadbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Ruteobtn")]
	private Button _Ruteobtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("CNDbtn")]
	private Button _CNDbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("mapabtn")]
	private Button _mapabtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("filtrarbtn")]
	private Button _filtrarbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("eventualesbtn")]
	private Button _eventualesbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("verexcelbtn")]
	private Button _verexcelbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("choferesbtn")]
	private Button _choferesbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("vehiculosbtn")]
	private Button _vehiculosbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("tablasbtn")]
	private Button _tablasbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Usuariobtn")]
	private Button _Usuariobtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Categoriasbtn")]
	private Button _Categoriasbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("posicionarbtn")]
	private Button _posicionarbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Exploradorbtn")]
	private Button _Exploradorbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("localidadesbtn")]
	private Button _localidadesbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("zonasbtn")]
	private Button _zonasbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button11")]
	private Button _Button11;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button12")]
	private Button _Button12;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button13")]
	private Button _Button13;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button14")]
	private Button _Button14;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button15")]
	private Button _Button15;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("rutasbtn")]
	private Button _rutasbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button6")]
	private Button _Button6;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button7")]
	private Button _Button7;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("retirosbtn")]
	private Button _retirosbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("clientesbtn")]
	private Button _clientesbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button8")]
	private Button _Button8;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button9")]
	private Button _Button9;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button10")]
	private Button _Button10;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button16")]
	private Button _Button16;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button18")]
	private Button _Button18;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button19")]
	private Button _Button19;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button22")]
	private Button _Button22;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button23")]
	private Button _Button23;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button25")]
	private Button _Button25;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button26")]
	private Button _Button26;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button27")]
	private Button _Button27;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button28")]
	private Button _Button28;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button3")]
	private Button _Button3;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button4")]
	private Button _Button4;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button5")]
	private Button _Button5;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button17")]
	private Button _Button17;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button20")]
	private Button _Button20;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button21")]
	private Button _Button21;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button29")]
	private Button _Button29;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button24")]
	private Button _Button24;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button30")]
	private Button _Button30;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button31")]
	private Button _Button31;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("importEtrans")]
	private Button _importEtrans;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button32")]
	private Button _Button32;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button33")]
	private Button _Button33;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("helpBtn")]
	private Button _helpBtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button34")]
	private Button _Button34;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btn_despacho_etrans")]
	private Button _btn_despacho_etrans;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button35")]
	private Button _Button35;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button36")]
	private Button _Button36;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button37")]
	private Button _Button37;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button38")]
	private Button _Button38;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button39")]
	private Button _Button39;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button40")]
	private Button _Button40;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button41")]
	private Button _Button41;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button42")]
	private Button _Button42;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button43")]
	private Button _Button43;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button44")]
	private Button _Button44;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button45")]
	private Button _Button45;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button46")]
	private Button _Button46;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button47")]
	private Button _Button47;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ordenesBtn")]
	private Button _ordenesBtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button48")]
	private Button _Button48;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button49")]
	private Button _Button49;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button50")]
	private Button _Button50;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button52")]
	private Button _Button52;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button53")]
	private Button _Button53;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button54")]
	private Button _Button54;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button55")]
	private Button _Button55;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("BtnEtiquetas")]
	private Button _BtnEtiquetas;

	[field: AccessedThroughProperty("DateTimePicker1")]
	internal virtual DateTimePicker DateTimePicker1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Importarbtn
	{
		[CompilerGenerated]
		get
		{
			return _Importarbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Importarbtn_Click;
			Button importarbtn = _Importarbtn;
			if (importarbtn != null)
			{
				importarbtn.Click -= value2;
			}
			_Importarbtn = value;
			importarbtn = _Importarbtn;
			if (importarbtn != null)
			{
				importarbtn.Click += value2;
			}
		}
	}

	internal virtual Button Disponibilidadbtn
	{
		[CompilerGenerated]
		get
		{
			return _Disponibilidadbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Disponibilidadbtn_Click;
			Button disponibilidadbtn = _Disponibilidadbtn;
			if (disponibilidadbtn != null)
			{
				disponibilidadbtn.Click -= value2;
			}
			_Disponibilidadbtn = value;
			disponibilidadbtn = _Disponibilidadbtn;
			if (disponibilidadbtn != null)
			{
				disponibilidadbtn.Click += value2;
			}
		}
	}

	internal virtual Button Ruteobtn
	{
		[CompilerGenerated]
		get
		{
			return _Ruteobtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Ruteobtn_Click;
			Button ruteobtn = _Ruteobtn;
			if (ruteobtn != null)
			{
				ruteobtn.Click -= value2;
			}
			_Ruteobtn = value;
			ruteobtn = _Ruteobtn;
			if (ruteobtn != null)
			{
				ruteobtn.Click += value2;
			}
		}
	}

	internal virtual Button CNDbtn
	{
		[CompilerGenerated]
		get
		{
			return _CNDbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = CNDbtn_Click;
			Button cNDbtn = _CNDbtn;
			if (cNDbtn != null)
			{
				cNDbtn.Click -= value2;
			}
			_CNDbtn = value;
			cNDbtn = _CNDbtn;
			if (cNDbtn != null)
			{
				cNDbtn.Click += value2;
			}
		}
	}

	internal virtual Button mapabtn
	{
		[CompilerGenerated]
		get
		{
			return _mapabtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = mapabtn_Click;
			Button button = _mapabtn;
			if (button != null)
			{
				button.Click -= value2;
			}
			_mapabtn = value;
			button = _mapabtn;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button filtrarbtn
	{
		[CompilerGenerated]
		get
		{
			return _filtrarbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = filtrarbtn_Click;
			Button button = _filtrarbtn;
			if (button != null)
			{
				button.Click -= value2;
			}
			_filtrarbtn = value;
			button = _filtrarbtn;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Splitter2")]
	internal virtual Splitter Splitter2
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

	[field: AccessedThroughProperty("Inicio")]
	internal virtual TabPage Inicio
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Operaciones")]
	internal virtual TabPage Operaciones
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Transporte")]
	internal virtual TabPage Transporte
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Reportes")]
	internal virtual TabPage Reportes
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Administrador")]
	internal virtual TabPage Administrador
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button eventualesbtn
	{
		[CompilerGenerated]
		get
		{
			return _eventualesbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = eventualesbtn_Click;
			Button button = _eventualesbtn;
			if (button != null)
			{
				button.Click -= value2;
			}
			_eventualesbtn = value;
			button = _eventualesbtn;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button verexcelbtn
	{
		[CompilerGenerated]
		get
		{
			return _verexcelbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = verexcelbtn_Click;
			Button button = _verexcelbtn;
			if (button != null)
			{
				button.Click -= value2;
			}
			_verexcelbtn = value;
			button = _verexcelbtn;
			if (button != null)
			{
				button.Click += value2;
			}
		}
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

	[field: AccessedThroughProperty("nombreusuario")]
	internal virtual ToolStripStatusLabel nombreusuario
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

	internal virtual Button choferesbtn
	{
		[CompilerGenerated]
		get
		{
			return _choferesbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = choferesbtn_Click;
			Button button = _choferesbtn;
			if (button != null)
			{
				button.Click -= value2;
			}
			_choferesbtn = value;
			button = _choferesbtn;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button vehiculosbtn
	{
		[CompilerGenerated]
		get
		{
			return _vehiculosbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = vehiculosbtn_Click;
			Button button = _vehiculosbtn;
			if (button != null)
			{
				button.Click -= value2;
			}
			_vehiculosbtn = value;
			button = _vehiculosbtn;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Eventuales")]
	internal virtual TabPage Eventuales
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button tablasbtn
	{
		[CompilerGenerated]
		get
		{
			return _tablasbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = tablasbtn_Click;
			Button button = _tablasbtn;
			if (button != null)
			{
				button.Click -= value2;
			}
			_tablasbtn = value;
			button = _tablasbtn;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Usuariobtn
	{
		[CompilerGenerated]
		get
		{
			return _Usuariobtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Usuariobtn_Click;
			Button usuariobtn = _Usuariobtn;
			if (usuariobtn != null)
			{
				usuariobtn.Click -= value2;
			}
			_Usuariobtn = value;
			usuariobtn = _Usuariobtn;
			if (usuariobtn != null)
			{
				usuariobtn.Click += value2;
			}
		}
	}

	internal virtual Button Categoriasbtn
	{
		[CompilerGenerated]
		get
		{
			return _Categoriasbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Categoriasbtn_Click;
			Button categoriasbtn = _Categoriasbtn;
			if (categoriasbtn != null)
			{
				categoriasbtn.Click -= value2;
			}
			_Categoriasbtn = value;
			categoriasbtn = _Categoriasbtn;
			if (categoriasbtn != null)
			{
				categoriasbtn.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("tarifasbtn")]
	internal virtual Button tarifasbtn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button posicionarbtn
	{
		[CompilerGenerated]
		get
		{
			return _posicionarbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = posicionarbtn_Click;
			Button button = _posicionarbtn;
			if (button != null)
			{
				button.Click -= value2;
			}
			_posicionarbtn = value;
			button = _posicionarbtn;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Exploradorbtn
	{
		[CompilerGenerated]
		get
		{
			return _Exploradorbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Exploradorbtn_Click;
			Button exploradorbtn = _Exploradorbtn;
			if (exploradorbtn != null)
			{
				exploradorbtn.Click -= value2;
			}
			_Exploradorbtn = value;
			exploradorbtn = _Exploradorbtn;
			if (exploradorbtn != null)
			{
				exploradorbtn.Click += value2;
			}
		}
	}

	internal virtual Button localidadesbtn
	{
		[CompilerGenerated]
		get
		{
			return _localidadesbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = localidadesbtn_Click;
			Button button = _localidadesbtn;
			if (button != null)
			{
				button.Click -= value2;
			}
			_localidadesbtn = value;
			button = _localidadesbtn;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button zonasbtn
	{
		[CompilerGenerated]
		get
		{
			return _zonasbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = zonasbtn_Click;
			Button button = _zonasbtn;
			if (button != null)
			{
				button.Click -= value2;
			}
			_zonasbtn = value;
			button = _zonasbtn;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button11
	{
		[CompilerGenerated]
		get
		{
			return _Button11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button11_Click;
			Button button = _Button11;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button11 = value;
			button = _Button11;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button12
	{
		[CompilerGenerated]
		get
		{
			return _Button12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button12_Click;
			Button button = _Button12;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button12 = value;
			button = _Button12;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button13
	{
		[CompilerGenerated]
		get
		{
			return _Button13;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button13_Click;
			Button button = _Button13;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button13 = value;
			button = _Button13;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button14
	{
		[CompilerGenerated]
		get
		{
			return _Button14;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button14_Click;
			Button button = _Button14;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button14 = value;
			button = _Button14;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button15
	{
		[CompilerGenerated]
		get
		{
			return _Button15;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button15_Click;
			Button button = _Button15;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button15 = value;
			button = _Button15;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Tracking")]
	internal virtual TabPage Tracking
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button rutasbtn
	{
		[CompilerGenerated]
		get
		{
			return _rutasbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = rutasbtn_Click;
			Button button = _rutasbtn;
			if (button != null)
			{
				button.Click -= value2;
			}
			_rutasbtn = value;
			button = _rutasbtn;
			if (button != null)
			{
				button.Click += value2;
			}
		}
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

	internal virtual Button Button6
	{
		[CompilerGenerated]
		get
		{
			return _Button6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button6_Click;
			Button button = _Button6;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button6 = value;
			button = _Button6;
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

	internal virtual Button Button7
	{
		[CompilerGenerated]
		get
		{
			return _Button7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button7_Click;
			Button button = _Button7;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button7 = value;
			button = _Button7;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button retirosbtn
	{
		[CompilerGenerated]
		get
		{
			return _retirosbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = retirosbtn_Click;
			Button button = _retirosbtn;
			if (button != null)
			{
				button.Click -= value2;
			}
			_retirosbtn = value;
			button = _retirosbtn;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("rotacionbtn")]
	internal virtual Button rotacionbtn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button clientesbtn
	{
		[CompilerGenerated]
		get
		{
			return _clientesbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = clientesbtn_Click;
			Button button = _clientesbtn;
			if (button != null)
			{
				button.Click -= value2;
			}
			_clientesbtn = value;
			button = _clientesbtn;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button8
	{
		[CompilerGenerated]
		get
		{
			return _Button8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button8_Click;
			Button button = _Button8;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button8 = value;
			button = _Button8;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button9
	{
		[CompilerGenerated]
		get
		{
			return _Button9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button9_Click;
			Button button = _Button9;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button9 = value;
			button = _Button9;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button10
	{
		[CompilerGenerated]
		get
		{
			return _Button10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button10_Click;
			Button button = _Button10;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button10 = value;
			button = _Button10;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button16
	{
		[CompilerGenerated]
		get
		{
			return _Button16;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button16_Click;
			Button button = _Button16;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button16 = value;
			button = _Button16;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button18
	{
		[CompilerGenerated]
		get
		{
			return _Button18;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button18_Click;
			Button button = _Button18;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button18 = value;
			button = _Button18;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button19
	{
		[CompilerGenerated]
		get
		{
			return _Button19;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button19_Click;
			Button button = _Button19;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button19 = value;
			button = _Button19;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button22
	{
		[CompilerGenerated]
		get
		{
			return _Button22;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button22_Click;
			Button button = _Button22;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button22 = value;
			button = _Button22;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button23
	{
		[CompilerGenerated]
		get
		{
			return _Button23;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button23_Click;
			Button button = _Button23;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button23 = value;
			button = _Button23;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Planificacion")]
	internal virtual TabPage Planificacion
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Importación")]
	internal virtual TabPage Importación
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Button25
	{
		[CompilerGenerated]
		get
		{
			return _Button25;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button25_Click;
			Button button = _Button25;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button25 = value;
			button = _Button25;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button26
	{
		[CompilerGenerated]
		get
		{
			return _Button26;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button26_Click;
			Button button = _Button26;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button26 = value;
			button = _Button26;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button27
	{
		[CompilerGenerated]
		get
		{
			return _Button27;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button27_Click;
			Button button = _Button27;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button27 = value;
			button = _Button27;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button28
	{
		[CompilerGenerated]
		get
		{
			return _Button28;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button28_Click;
			Button button = _Button28;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button28 = value;
			button = _Button28;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button3
	{
		[CompilerGenerated]
		get
		{
			return _Button3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button3_Click;
			Button button = _Button3;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button3 = value;
			button = _Button3;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button4
	{
		[CompilerGenerated]
		get
		{
			return _Button4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button4_Click;
			Button button = _Button4;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button4 = value;
			button = _Button4;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button5
	{
		[CompilerGenerated]
		get
		{
			return _Button5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button5_Click;
			Button button = _Button5;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button5 = value;
			button = _Button5;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button17
	{
		[CompilerGenerated]
		get
		{
			return _Button17;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button17_Click;
			Button button = _Button17;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button17 = value;
			button = _Button17;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button20
	{
		[CompilerGenerated]
		get
		{
			return _Button20;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button20_Click;
			Button button = _Button20;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button20 = value;
			button = _Button20;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Deposito")]
	internal virtual TabPage Deposito
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Button21
	{
		[CompilerGenerated]
		get
		{
			return _Button21;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button21_Click;
			Button button = _Button21;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button21 = value;
			button = _Button21;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Etrans")]
	internal virtual TabPage Etrans
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Button29
	{
		[CompilerGenerated]
		get
		{
			return _Button29;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button29_Click;
			Button button = _Button29;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button29 = value;
			button = _Button29;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button24
	{
		[CompilerGenerated]
		get
		{
			return _Button24;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button24_Click;
			Button button = _Button24;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button24 = value;
			button = _Button24;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button30
	{
		[CompilerGenerated]
		get
		{
			return _Button30;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button30_Click;
			Button button = _Button30;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button30 = value;
			button = _Button30;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button31
	{
		[CompilerGenerated]
		get
		{
			return _Button31;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button31_Click;
			Button button = _Button31;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button31 = value;
			button = _Button31;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button importEtrans
	{
		[CompilerGenerated]
		get
		{
			return _importEtrans;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = importEtrans_Click;
			Button button = _importEtrans;
			if (button != null)
			{
				button.Click -= value2;
			}
			_importEtrans = value;
			button = _importEtrans;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button32
	{
		[CompilerGenerated]
		get
		{
			return _Button32;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button32_Click;
			Button button = _Button32;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button32 = value;
			button = _Button32;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button33
	{
		[CompilerGenerated]
		get
		{
			return _Button33;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button33_Click;
			Button button = _Button33;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button33 = value;
			button = _Button33;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button helpBtn
	{
		[CompilerGenerated]
		get
		{
			return _helpBtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = helpBtn_Click;
			Button button = _helpBtn;
			if (button != null)
			{
				button.Click -= value2;
			}
			_helpBtn = value;
			button = _helpBtn;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button34
	{
		[CompilerGenerated]
		get
		{
			return _Button34;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button34_Click;
			Button button = _Button34;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button34 = value;
			button = _Button34;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button btn_despacho_etrans
	{
		[CompilerGenerated]
		get
		{
			return _btn_despacho_etrans;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = btn_despacho_etrans_Click;
			Button button = _btn_despacho_etrans;
			if (button != null)
			{
				button.Click -= value2;
			}
			_btn_despacho_etrans = value;
			button = _btn_despacho_etrans;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button35
	{
		[CompilerGenerated]
		get
		{
			return _Button35;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button35_Click;
			Button button = _Button35;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button35 = value;
			button = _Button35;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button36
	{
		[CompilerGenerated]
		get
		{
			return _Button36;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button36_Click;
			Button button = _Button36;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button36 = value;
			button = _Button36;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button37
	{
		[CompilerGenerated]
		get
		{
			return _Button37;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button37_Click;
			Button button = _Button37;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button37 = value;
			button = _Button37;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button38
	{
		[CompilerGenerated]
		get
		{
			return _Button38;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button38_Click;
			Button button = _Button38;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button38 = value;
			button = _Button38;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button39
	{
		[CompilerGenerated]
		get
		{
			return _Button39;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button39_Click;
			Button button = _Button39;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button39 = value;
			button = _Button39;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("TextBox1")]
	internal virtual TextBox TextBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Button40
	{
		[CompilerGenerated]
		get
		{
			return _Button40;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button40_Click;
			Button button = _Button40;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button40 = value;
			button = _Button40;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button41
	{
		[CompilerGenerated]
		get
		{
			return _Button41;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button41_Click;
			Button button = _Button41;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button41 = value;
			button = _Button41;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button42
	{
		[CompilerGenerated]
		get
		{
			return _Button42;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button42_Click;
			Button button = _Button42;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button42 = value;
			button = _Button42;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button43
	{
		[CompilerGenerated]
		get
		{
			return _Button43;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button43_Click;
			Button button = _Button43;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button43 = value;
			button = _Button43;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button44
	{
		[CompilerGenerated]
		get
		{
			return _Button44;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button44_Click;
			Button button = _Button44;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button44 = value;
			button = _Button44;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button45
	{
		[CompilerGenerated]
		get
		{
			return _Button45;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button45_Click;
			Button button = _Button45;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button45 = value;
			button = _Button45;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button46
	{
		[CompilerGenerated]
		get
		{
			return _Button46;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button46_Click;
			Button button = _Button46;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button46 = value;
			button = _Button46;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button47
	{
		[CompilerGenerated]
		get
		{
			return _Button47;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button47_Click;
			Button button = _Button47;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button47 = value;
			button = _Button47;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button ordenesBtn
	{
		[CompilerGenerated]
		get
		{
			return _ordenesBtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ordenesBtn_Click;
			Button button = _ordenesBtn;
			if (button != null)
			{
				button.Click -= value2;
			}
			_ordenesBtn = value;
			button = _ordenesBtn;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button48
	{
		[CompilerGenerated]
		get
		{
			return _Button48;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button48_Click;
			Button button = _Button48;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button48 = value;
			button = _Button48;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button49
	{
		[CompilerGenerated]
		get
		{
			return _Button49;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button49_Click;
			Button button = _Button49;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button49 = value;
			button = _Button49;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button50
	{
		[CompilerGenerated]
		get
		{
			return _Button50;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button50_Click;
			Button button = _Button50;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button50 = value;
			button = _Button50;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Button51")]
	internal virtual Button Button51
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Button52
	{
		[CompilerGenerated]
		get
		{
			return _Button52;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button52_Click;
			Button button = _Button52;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button52 = value;
			button = _Button52;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button53
	{
		[CompilerGenerated]
		get
		{
			return _Button53;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button53_Click;
			Button button = _Button53;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button53 = value;
			button = _Button53;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Button54
	{
		[CompilerGenerated]
		get
		{
			return _Button54;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button54_Click;
			Button button = _Button54;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button54 = value;
			button = _Button54;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("TabTelas")]
	internal virtual TabPage TabTelas
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Button63")]
	internal virtual Button Button63
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Button62")]
	internal virtual Button Button62
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Button61")]
	internal virtual Button Button61
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Button60")]
	internal virtual Button Button60
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Button59")]
	internal virtual Button Button59
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Button58")]
	internal virtual Button Button58
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Button57")]
	internal virtual Button Button57
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Button56")]
	internal virtual Button Button56
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Button55
	{
		[CompilerGenerated]
		get
		{
			return _Button55;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button55_Click;
			Button button = _Button55;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button55 = value;
			button = _Button55;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button BtnEtiquetas
	{
		[CompilerGenerated]
		get
		{
			return _BtnEtiquetas;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = BtnEtiquetas_Click;
			Button btnEtiquetas = _BtnEtiquetas;
			if (btnEtiquetas != null)
			{
				btnEtiquetas.Click -= value2;
			}
			_BtnEtiquetas = value;
			btnEtiquetas = _BtnEtiquetas;
			if (btnEtiquetas != null)
			{
				btnEtiquetas.Click += value2;
			}
		}
	}

	public Form1_Inicio()
	{
		base.Load += Form1_Inicio_Load;
		InitializeComponent();
	}

	private void Form1_Inicio_Load(object sender, EventArgs e)
	{
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(executingAssembly.Location);
		string fileVersion = versionInfo.FileVersion;
		Label2.Text = "V. " + fileVersion;
		if (Application.StartupPath.Contains("E:\\NET\\Area54"))
		{
			MySettingsProperty.Settings.Usuario = "Victor";
			MySettingsProperty.Settings.Permiso = Conversions.ToString(10);
			nombreusuario.Text = MySettingsProperty.Settings.Usuario;
			base.WindowState = FormWindowState.Maximized;
		}
		else
		{
			Login login = new Login();
			login.Owner = this;
			login.ShowDialog();
		}
		if (Operators.CompareString(Mod_Sentencias.baseDD, "hermes", TextCompare: true) == 0)
		{
			Label3.Visible = false;
		}
		else
		{
			Label3.Text = "DESARROLLO";
		}
		ComboBox1.SelectedIndex = 0;
		if (Conversions.ToDouble(MySettingsProperty.Settings.Permiso) >= 5.0)
		{
			filtrarbtn.Enabled = true;
			verexcelbtn.Enabled = true;
			Importarbtn.Enabled = true;
			Disponibilidadbtn.Enabled = true;
			Ruteobtn.Enabled = true;
			CNDbtn.Enabled = true;
			rutasbtn.Enabled = true;
			Categoriasbtn.Enabled = true;
			vehiculosbtn.Enabled = true;
			choferesbtn.Enabled = true;
			tarifasbtn.Enabled = true;
			eventualesbtn.Enabled = true;
			posicionarbtn.Enabled = true;
		}
		else
		{
			Button4.Enabled = false;
			filtrarbtn.Enabled = false;
			verexcelbtn.Enabled = false;
			Importarbtn.Enabled = false;
			Disponibilidadbtn.Enabled = false;
			Ruteobtn.Enabled = false;
			CNDbtn.Enabled = false;
			Categoriasbtn.Enabled = false;
			vehiculosbtn.Enabled = false;
			choferesbtn.Enabled = false;
			tarifasbtn.Enabled = false;
			eventualesbtn.Enabled = false;
			posicionarbtn.Enabled = false;
		}
		if (Conversions.ToDouble(MySettingsProperty.Settings.Permiso) >= 10.0)
		{
			Usuariobtn.Enabled = true;
			tablasbtn.Enabled = true;
			Button13.Enabled = true;
			Button14.Enabled = true;
			Button10.Enabled = true;
			Button15.Enabled = true;
			Button4.Enabled = true;
			Button37.Enabled = true;
			Button8.Enabled = true;
			Button52.Enabled = true;
		}
	}

	private void Importarbtn_Click(object sender, EventArgs e)
	{
		if (Conversions.ToDouble(MySettingsProperty.Settings.Permiso) >= 7.0)
		{
			MyProject.Forms.DatosImport.Show();
		}
		else
		{
			Interaction.MsgBox("no tienes los permisos necesarios");
		}
	}

	private void filtrarbtn_Click(object sender, EventArgs e)
	{
		if (Conversions.ToDouble(MySettingsProperty.Settings.Permiso) >= 7.0)
		{
			filtrarbtn.Enabled = false;
			Mod_Filtrado.Filtrar();
			filtrarbtn.Enabled = true;
		}
		else
		{
			Interaction.MsgBox("no tienes los permisos necesarios");
		}
	}

	private void Categoriasbtn_Click(object sender, EventArgs e)
	{
		if (Conversions.ToDouble(MySettingsProperty.Settings.Permiso) >= 5.0)
		{
			MyProject.Forms.Categorias.MdiParent = this;
			MyProject.Forms.Categorias.Show();
		}
		else
		{
			Interaction.MsgBox("no tienes los permisos necesarios");
		}
	}

	private void Usuariobtn_Click(object sender, EventArgs e)
	{
		if (Conversions.ToDouble(MySettingsProperty.Settings.Permiso) == 10.0)
		{
			MyProject.Forms.Form2_Usuario.MdiParent = this;
			MyProject.Forms.Form2_Usuario.Show();
		}
		else
		{
			Interaction.MsgBox("no tienes los permisos necesarios");
		}
	}

	private void tablasbtn_Click(object sender, EventArgs e)
	{
		if (Conversions.ToDouble(MySettingsProperty.Settings.Permiso) >= 10.0)
		{
			MyProject.Forms.Form2_AdmDB.MdiParent = this;
			MyProject.Forms.Form2_AdmDB.Show();
		}
		else
		{
			Interaction.MsgBox("no tienes los permisos necesarios");
		}
	}

	private void Exploradorbtn_Click(object sender, EventArgs e)
	{
		MyProject.Forms.Explorador.MdiParent = this;
		MyProject.Forms.Explorador.Show();
	}

	private void eventualesbtn_Click(object sender, EventArgs e)
	{
		MyProject.Forms.Eventuales_form.MdiParent = this;
		MyProject.Forms.Eventuales_form.Show();
	}

	private void posicionarbtn_Click(object sender, EventArgs e)
	{
		MyProject.Forms.Posicionar.MdiParent = this;
		MyProject.Forms.Posicionar.Show();
	}

	private void Ruteobtn_Click(object sender, EventArgs e)
	{
		int num = Conversions.ToInteger(MySettingsProperty.Settings.Permiso);
		if (num > 7)
		{
			DialogResult dialogResult = MessageBox.Show("Iniciar Ruteo", "Iniciar Planificacion", MessageBoxButtons.YesNo);
			if (dialogResult == DialogResult.Yes)
			{
				MyProject.Forms.Procesos.Show();
				Mod_Rutearmodulo.busca_eve();
				Mod_Rutearmodulo.eventuales_gba();
				Mod_Rutearmodulo.eventuales_caba();
				Mod_Rutearmodulo.etrans_pos();
				Mod_Rutearmodulo.localidades_s();
			}
			if (dialogResult != DialogResult.No)
			{
			}
		}
		else
		{
			Interaction.MsgBox("No tienes los permisos necesarios.");
		}
	}

	private void localidadesbtn_Click(object sender, EventArgs e)
	{
		MyProject.Forms.Localidades.MdiParent = this;
		MyProject.Forms.Localidades.Show();
	}

	private void zonasbtn_Click(object sender, EventArgs e)
	{
		MyProject.Forms.zonas.Show();
	}

	private void vehiculosbtn_Click(object sender, EventArgs e)
	{
		MyProject.Forms.Vehiculos.MdiParent = this;
		MyProject.Forms.Vehiculos.Show();
	}

	private void rutasbtn_Click(object sender, EventArgs e)
	{
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		DialogResult dialogResult = MessageBox.Show("Planificar distribucion para el dia " + DateTimePicker1.Text + ", Ventana: " + ComboBox1.Text + ".", "Iniciar Planificacion", MessageBoxButtons.YesNo);
		checked
		{
			if (dialogResult == DialogResult.Yes)
			{
				try
				{
					string sql = "SELECT Numero FROM Flota where Disponible='Si' and Estado = 'Activo' order by Numero";
					Mod_Sentencias.cargar_datos_lv(MyProject.Forms.Rutas.ListView1, sql, MyProject.Forms.Rutas.Label1);
					Mod_Sentencias.cargar_zonas_combo(MyProject.Forms.Rutas.ComboBox1);
					Mod_Sentencias.cargar_zonas_combo(MyProject.Forms.Rutas.ComboBox2);
					string text = Strings.Format(DateTimePicker1.Value, "yyyyMMdd");
					DataTable dataTable = new DataTable("x");
					string text2 = ("SELECT DISTINCT Chofer FROM Planchada WHERE Fecha='" + text + "' AND Ventana=" + ComboBox1.Text) ?? "";
					MySqlDataAdapter val = new MySqlDataAdapter(text2, Mod_Sentencias.cnn);
					((DbDataAdapter)(object)val).Fill(dataTable);
					MyProject.Forms.Loading.Show();
					MyProject.Forms.Loading.Refresh();
					Rutas rutas = MyProject.Forms.Rutas;
					MyProject.Forms.Loading.ProgressBar1.Maximum = rutas.ListView1.Items.Count;
					MyProject.Forms.Loading.ProgressBar1.Value = 0;
					int num = rutas.ListView1.Items.Count - 1;
					for (int i = 0; i <= num; i++)
					{
						MyProject.Forms.Loading.ProgressBar1.Value = MyProject.Forms.Loading.ProgressBar1.Value + 1;
						if (dataTable.Rows.Count <= 0)
						{
							continue;
						}
						int num2 = dataTable.Rows.Count - 1;
						for (int j = 0; j <= num2; j++)
						{
							if (Operators.ConditionalCompareObjectEqual(dataTable.Rows[j]["Chofer"], rutas.ListView1.Items[i].Text, TextCompare: true))
							{
								rutas.ListView1.Items[i].ForeColor = Color.DarkGreen;
							}
						}
					}
					rutas = null;
					MyProject.Forms.Loading.Close();
					MyProject.Forms.Rutas.Show();
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					Interaction.MsgBox(ex2.Message);
					ProjectData.ClearProjectError();
					return;
				}
			}
			if (dialogResult != DialogResult.No)
			{
			}
		}
	}

	private void mapabtn_Click(object sender, EventArgs e)
	{
		MyProject.Forms.Mapa.Show();
	}

	private void CNDbtn_Click(object sender, EventArgs e)
	{
		MyProject.Forms.CND.MdiParent = this;
		MyProject.Forms.CND.Show();
	}

	private void Disponibilidadbtn_Click(object sender, EventArgs e)
	{
		MyProject.Forms.Disponibilidad.MdiParent = this;
		MyProject.Forms.Disponibilidad.Show();
	}

	private void verexcelbtn_Click(object sender, EventArgs e)
	{
		Mod_Filtrado.Ver_archivo("Temp.xls");
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		int num = Conversions.ToInteger(MySettingsProperty.Settings.Permiso);
		if (num >= 10)
		{
			MyProject.Forms.TESTposicionar.Show();
		}
		else
		{
			Interaction.MsgBox("No tienes los permisos necesarios.");
		}
	}

	private void Button6_Click(object sender, EventArgs e)
	{
		MyProject.Forms.Eventos.MdiParent = this;
		MyProject.Forms.Eventos.Show();
	}

	private void Button7_Click(object sender, EventArgs e)
	{
		Interaction.MsgBox("La funcion fue desactivada por el administrador.");
	}

	private void Button11_Click(object sender, EventArgs e)
	{
		MyProject.Forms.Infimportacion.Show();
	}

	private void Button12_Click(object sender, EventArgs e)
	{
		MyProject.Forms.Procesos.Show();
	}

	private void Button13_Click(object sender, EventArgs e)
	{
		Mod_Rutearmodulo.algoritmo_facu();
		Interaction.MsgBox("Fin");
	}

	private void Button14_Click(object sender, EventArgs e)
	{
	}

	private void Button15_Click(object sender, EventArgs e)
	{
	}

	private void retirosbtn_Click(object sender, EventArgs e)
	{
		MyProject.Forms.Retiros.MdiParent = this;
		MyProject.Forms.Retiros.Show();
	}

	private void clientesbtn_Click(object sender, EventArgs e)
	{
		MyProject.Forms.Clientes.MdiParent = this;
		MyProject.Forms.Clientes.Show();
	}

	private void Button8_Click(object sender, EventArgs e)
	{
		MyProject.Forms.calcularkm.Show();
	}

	private void Button9_Click(object sender, EventArgs e)
	{
		MyProject.Forms.Pruebas.MdiParent = this;
		MyProject.Forms.Pruebas.Show();
	}

	private void choferesbtn_Click(object sender, EventArgs e)
	{
		MyProject.Forms.Choferes.MdiParent = this;
		MyProject.Forms.Choferes.Show();
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		int num = Conversions.ToInteger(MySettingsProperty.Settings.Permiso);
		if (num > 9)
		{
			string text = Strings.Format(DateTimePicker1.Value, "yyyyMMdd");
			string sql = ("Select Eventual, Comprobante, cliente, remitos, destino, domicilio, cp, localidad, declarado, bultos, kilos, sub, observaciones, volumen, atraso, fecha, flete, zona, adicional, prioridad, chofer, latitud, longitud FROM planchada where fecha='" + text + "' AND Chofer>0 AND Ventana=" + ComboBox1.Text) ?? "";
			string destino = "Exportacion";
			Mod_Exportar.exportar_excel(sql, destino);
		}
		else
		{
			Interaction.MsgBox("No tienes los permisos necesarios.");
		}
	}

	private void Button10_Click(object sender, EventArgs e)
	{
		int num = Conversions.ToInteger(MySettingsProperty.Settings.Permiso);
		if (num > 5)
		{
			Mod_Canalizador.buscar_eventual_bd();
		}
		else
		{
			Interaction.MsgBox("No tienes los permisos necesarios.");
		}
	}

	private void Button16_Click(object sender, EventArgs e)
	{
		int num = Conversions.ToInteger(MySettingsProperty.Settings.Permiso);
		if (num > 5)
		{
			MyProject.Forms.Informes.MdiParent = this;
			MyProject.Forms.Informes.Show();
		}
		else
		{
			Interaction.MsgBox("No tienes los permisos necesarios.");
		}
	}

	private void Button18_Click(object sender, EventArgs e)
	{
		MyProject.Forms.Novedades.MdiParent = this;
		MyProject.Forms.Novedades.Show();
	}

	private void Button19_Click(object sender, EventArgs e)
	{
		MyProject.Forms.EstadosConfig.Show();
	}

	private void Button22_Click(object sender, EventArgs e)
	{
		Buscar buscar = MyProject.Forms.Buscar;
		buscar.CheckBox1.Checked = true;
		buscar = null;
		MyProject.Forms.Buscar.Show();
	}

	private void Button23_Click(object sender, EventArgs e)
	{
		int num = Conversions.ToInteger(MySettingsProperty.Settings.Permiso);
		if (num > 5)
		{
			MyProject.Forms.Ingreso_manual.Show();
		}
		else
		{
			Interaction.MsgBox("No tienes los permisos necesarios.");
		}
	}

	private void Button25_Click(object sender, EventArgs e)
	{
		MyProject.Forms.Cierre_Guias.Show();
	}

	private void Button26_Click(object sender, EventArgs e)
	{
		int num = Conversions.ToInteger(MySettingsProperty.Settings.Permiso);
		if (num > 5)
		{
			MyProject.Forms.Despachos.Show();
		}
		else
		{
			Interaction.MsgBox("No tienes los permisos necesarios.");
		}
	}

	private void Button27_Click(object sender, EventArgs e)
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected O, but got Unknown
		string text = Strings.Format(DateTimePicker1.Value, "yyyyMMdd");
		Interaction.MsgBox(text);
		string text2 = "SELECT id_envio, estado from etransenvios where D_fecha='" + text + "'";
		Interaction.MsgBox(text2);
		DataTable dataTable = new DataTable("x");
		MySqlDataAdapter val = new MySqlDataAdapter(text2, Mod_Sentencias.cnn);
		((DbDataAdapter)(object)val).Fill(dataTable);
		Interaction.MsgBox(dataTable.Rows.Count);
		checked
		{
			int num = dataTable.Rows.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				int num2 = Conversions.ToInteger(Mod_Etrans.estado_web_etrans(Conversions.ToInteger(dataTable.Rows[i]["id_envio"])));
				int num3 = Conversions.ToInteger(Mod_Etrans.estado_web_int(Conversions.ToString(dataTable.Rows[i]["estado"])));
				if (num2 == num3)
				{
					Logger.i(Conversions.ToString(Operators.ConcatenateObject("Estados OK - ", dataTable.Rows[i]["id_envio"])));
				}
				else
				{
					Logger.i(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Estados Diferentes - ", dataTable.Rows[i]["id_envio"]), " - WEB: "), num2), "-LOCAL: "), num3)));
				}
			}
		}
	}

	private void Button28_Click(object sender, EventArgs e)
	{
		MyProject.Forms.ImportarConfig.Show();
	}

	private void Button3_Click(object sender, EventArgs e)
	{
	}

	private void Button4_Click(object sender, EventArgs e)
	{
		if (Conversions.ToDouble(MySettingsProperty.Settings.Permiso) >= 7.0)
		{
			MyProject.Forms.EtransAdmin.Show();
		}
		else
		{
			Interaction.MsgBox("no tienes los permisos necesarios");
		}
	}

	private void Button5_Click(object sender, EventArgs e)
	{
		if (Conversions.ToDouble(MySettingsProperty.Settings.Permiso) > 7.0)
		{
			MyProject.Forms.RutasConfig.MdiParent = this;
			MyProject.Forms.RutasConfig.Show();
		}
		else
		{
			Interaction.MsgBox("no tienes los permisos necesarios");
		}
	}

	private void Button17_Click(object sender, EventArgs e)
	{
		MyProject.Forms.InfOperaciones.Show();
	}

	private void Button20_Click(object sender, EventArgs e)
	{
		MyProject.Forms.ImprimirConfig.MdiParent = this;
		MyProject.Forms.ImprimirConfig.Show();
	}

	private void Button21_Click(object sender, EventArgs e)
	{
		MyProject.Forms.RecepcionEnvios.MdiParent = this;
		MyProject.Forms.RecepcionEnvios.Show();
	}

	private void Button29_Click(object sender, EventArgs e)
	{
		int num = Conversions.ToInteger(MySettingsProperty.Settings.Permiso);
		if (num > 5)
		{
			MyProject.Forms.EdicionEtrans.Show();
		}
		else
		{
			Interaction.MsgBox("No tienes los permisos necesarios.");
		}
	}

	private void Button24_Click(object sender, EventArgs e)
	{
		int num = Conversions.ToInteger(MySettingsProperty.Settings.Permiso);
		if (num <= 7)
		{
			return;
		}
		try
		{
			if (!Operators.ConditionalCompareObjectEqual(Mod_Etrans.sincronizar_etrans(), 1, TextCompare: true))
			{
				Interaction.MsgBox("Ocurrio un Error sincronizando estados en la web");
			}
			Mod_Etrans_Retiros.retiros_v1();
			Mod_Etrans_Retiros.retiros_v2();
			Mod_Etrans_Retiros.entregas_v1();
			Mod_Etrans_Retiros.entregas_v2();
			Mod_Etrans_Retiros.entregas_v3();
			Interaction.MsgBox("Se generaron los DBF");
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox(ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void Button30_Click(object sender, EventArgs e)
	{
		int num = Conversions.ToInteger(MySettingsProperty.Settings.Permiso);
		if (num > 5)
		{
			MyProject.Forms.Feriados.MdiParent = this;
			MyProject.Forms.Feriados.Show();
		}
		else
		{
			Interaction.MsgBox("No tienes los permisos necesarios.");
		}
	}

	private void Button31_Click(object sender, EventArgs e)
	{
		int num = Conversions.ToInteger(MySettingsProperty.Settings.Permiso);
		if (num > 7)
		{
			MyProject.Forms.V_Tareas.MdiParent = this;
			MyProject.Forms.V_Tareas.Show();
		}
		else
		{
			Interaction.MsgBox("No tienes los permisos necesarios.");
		}
	}

	private void importEtrans_Click(object sender, EventArgs e)
	{
		try
		{
			Mod_Etrans_Retiros.recolecciones();
			Mod_Etrans_Retiros.etrans_entregas();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void Button32_Click(object sender, EventArgs e)
	{
		string text = Strings.Format(DateTimePicker1.Value, "yyyyMMdd");
		string sQL = "UPDATE etransEnvios SET estado = 'APROBADO' WHERE U_fecha='" + text + "'";
		Mod_ConeccionBD.BD_Sentencia(sQL);
		string sQL2 = "UPDATE etransEnvios SET estado ='EN CD' WHERE D_fecha='" + text + "'";
		Mod_ConeccionBD.BD_Sentencia(sQL2);
	}

	private void Button33_Click(object sender, EventArgs e)
	{
		int num = Conversions.ToInteger(Mod_logger.historialenter("11", "algo", "ok", "nose"));
	}

	private void helpBtn_Click(object sender, EventArgs e)
	{
		string fileName = "http://api-interna.area54sa.com.ar/hermesaplicacionweb/index.php";
		Process.Start(fileName);
	}

	private void Button34_Click(object sender, EventArgs e)
	{
		MyProject.Forms.Recepcion_form.Show();
	}

	private void btn_despacho_etrans_Click(object sender, EventArgs e)
	{
		MyProject.Forms.E_Despachos.MdiParent = this;
		MyProject.Forms.E_Despachos.Show();
	}

	private void Button35_Click(object sender, EventArgs e)
	{
		MyProject.Forms.Liquidacion.MdiParent = this;
		MyProject.Forms.Liquidacion.Show();
	}

	private void Button36_Click(object sender, EventArgs e)
	{
		if (Conversions.ToDouble(MySettingsProperty.Settings.Permiso) >= 9.0)
		{
			string prompt = Conversions.ToString(Mod_WebRequest.post_w());
			Interaction.MsgBox(prompt);
		}
		else
		{
			Interaction.MsgBox("no tienes los permisos necesarios");
		}
	}

	private void Button37_Click(object sender, EventArgs e)
	{
		if (Conversions.ToDouble(MySettingsProperty.Settings.Permiso) >= 10.0)
		{
			MyProject.Forms.masivoEtiquetas.MdiParent = this;
			MyProject.Forms.masivoEtiquetas.Show();
		}
		else
		{
			Interaction.MsgBox("no tienes los permisos necesarios");
		}
	}

	private void Button38_Click(object sender, EventArgs e)
	{
		if (Conversions.ToDouble(MySettingsProperty.Settings.Permiso) >= 10.0)
		{
			string prompt = Conversions.ToString(Mod_Etrans_Retiros.agrupar_retiros());
			Interaction.MsgBox(prompt);
		}
		else
		{
			Interaction.MsgBox("no tienes los permisos necesarios");
		}
	}

	private void Button39_Click(object sender, EventArgs e)
	{
	}

	private void Button40_Click(object sender, EventArgs e)
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		checked
		{
			if (Operators.CompareString(MySettingsProperty.Settings.Usuario, "Facu", TextCompare: true) == 0)
			{
				string text = "SELECT comprobante from planchada where cliente='ETRANS' and sub<11 and fecha='2016-05-19'";
				DataTable dataTable = new DataTable("x");
				MySqlDataAdapter val = new MySqlDataAdapter(text, Mod_Sentencias.cnn);
				((DbDataAdapter)(object)val).Fill(dataTable);
				int num = dataTable.Rows.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					Mod_Etrans_Retiros.fleteRealFinal(Conversions.ToInteger(dataTable.Rows[i]["comprobante"]));
				}
			}
		}
	}

	private void Button41_Click(object sender, EventArgs e)
	{
		MyProject.Forms.Empresas.MdiParent = this;
		MyProject.Forms.Empresas.Show();
	}

	private void Button42_Click(object sender, EventArgs e)
	{
		if (Conversions.ToDouble(MySettingsProperty.Settings.Permiso) >= 7.0)
		{
			MyProject.Forms.Productos_Form.MdiParent = this;
			MyProject.Forms.Productos_Form.Show();
		}
		else
		{
			Interaction.MsgBox("No posee los permisos necesarios.");
		}
	}

	private void Button43_Click(object sender, EventArgs e)
	{
		if (Conversions.ToDouble(MySettingsProperty.Settings.Permiso) >= 7.0)
		{
			MyProject.Forms.ProductosIn_Form.MdiParent = this;
			MyProject.Forms.ProductosIn_Form.Show();
		}
		else
		{
			Interaction.MsgBox("No posee los permisos necesarios.");
		}
	}

	private void Button44_Click(object sender, EventArgs e)
	{
		if (Conversions.ToDouble(MySettingsProperty.Settings.Permiso) >= 7.0)
		{
			MyProject.Forms.ProductosOut_Form.MdiParent = this;
			MyProject.Forms.ProductosOut_Form.Show();
		}
		else
		{
			Interaction.MsgBox("No posee los permisos necesarios.");
		}
	}

	private void Button45_Click(object sender, EventArgs e)
	{
		MyProject.Forms.ConsultaEstado.MdiParent = this;
		MyProject.Forms.ConsultaEstado.Show();
	}

	private void Button46_Click(object sender, EventArgs e)
	{
	}

	private void Button47_Click(object sender, EventArgs e)
	{
	}

	private void ordenesBtn_Click(object sender, EventArgs e)
	{
		Listado listado = MyProject.Forms.Listado;
		listado.controladorLbl.Text = Conversions.ToString(1);
		listado = null;
		MyProject.Forms.Listado.MdiParent = this;
		MyProject.Forms.Listado.Show();
	}

	private void Button48_Click(object sender, EventArgs e)
	{
		MyProject.Forms.Almacen.MdiParent = this;
		MyProject.Forms.Almacen.Show();
	}

	private void Button49_Click(object sender, EventArgs e)
	{
		MyProject.Forms.Descarga.MdiParent = this;
		MyProject.Forms.Descarga.Show();
	}

	private void Button50_Click(object sender, EventArgs e)
	{
		if (Conversions.ToDouble(MySettingsProperty.Settings.Permiso) >= 7.0)
		{
			MyProject.Forms.Movimientos_A.MdiParent = this;
			MyProject.Forms.Movimientos_A.Show();
		}
		else
		{
			Interaction.MsgBox("No posee los permisos necesarios.");
		}
	}

	private void Button52_Click(object sender, EventArgs e)
	{
		MyProject.Forms.InformeAlmacen.Show();
	}

	private void Button53_Click(object sender, EventArgs e)
	{
		Listado listado = MyProject.Forms.Listado;
		listado.controladorLbl.Text = Conversions.ToString(2);
		listado = null;
		MyProject.Forms.Listado.MdiParent = this;
		MyProject.Forms.Listado.Show();
	}

	private void Button54_Click(object sender, EventArgs e)
	{
		MyProject.Forms.Inf_seguimiento.MdiParent = this;
		MyProject.Forms.Inf_seguimiento.Show();
	}

	private void Button55_Click(object sender, EventArgs e)
	{
		MyProject.Forms.Telas_in.MdiParent = this;
		MyProject.Forms.Telas_in.Show();
	}

	private void BtnEtiquetas_Click(object sender, EventArgs e)
	{
		MyProject.Forms.Etiquetas_Form.MdiParent = this;
		MyProject.Forms.Etiquetas_Form.Show();
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hermes.Form1_Inicio));
		this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
		this.Splitter2 = new System.Windows.Forms.Splitter();
		this.TabControl1 = new System.Windows.Forms.TabControl();
		this.Inicio = new System.Windows.Forms.TabPage();
		this.helpBtn = new System.Windows.Forms.Button();
		this.Label3 = new System.Windows.Forms.Label();
		this.Exploradorbtn = new System.Windows.Forms.Button();
		this.Button22 = new System.Windows.Forms.Button();
		this.Importación = new System.Windows.Forms.TabPage();
		this.Button23 = new System.Windows.Forms.Button();
		this.filtrarbtn = new System.Windows.Forms.Button();
		this.GroupBox1 = new System.Windows.Forms.GroupBox();
		this.Button7 = new System.Windows.Forms.Button();
		this.verexcelbtn = new System.Windows.Forms.Button();
		this.Importarbtn = new System.Windows.Forms.Button();
		this.Planificacion = new System.Windows.Forms.TabPage();
		this.Button54 = new System.Windows.Forms.Button();
		this.Button5 = new System.Windows.Forms.Button();
		this.Ruteobtn = new System.Windows.Forms.Button();
		this.rutasbtn = new System.Windows.Forms.Button();
		this.CNDbtn = new System.Windows.Forms.Button();
		this.Button13 = new System.Windows.Forms.Button();
		this.Tracking = new System.Windows.Forms.TabPage();
		this.Button2 = new System.Windows.Forms.Button();
		this.mapabtn = new System.Windows.Forms.Button();
		this.Operaciones = new System.Windows.Forms.TabPage();
		this.Button17 = new System.Windows.Forms.Button();
		this.Button19 = new System.Windows.Forms.Button();
		this.Button18 = new System.Windows.Forms.Button();
		this.rotacionbtn = new System.Windows.Forms.Button();
		this.retirosbtn = new System.Windows.Forms.Button();
		this.Button26 = new System.Windows.Forms.Button();
		this.Button25 = new System.Windows.Forms.Button();
		this.clientesbtn = new System.Windows.Forms.Button();
		this.Etrans = new System.Windows.Forms.TabPage();
		this.importEtrans = new System.Windows.Forms.Button();
		this.Button37 = new System.Windows.Forms.Button();
		this.Button31 = new System.Windows.Forms.Button();
		this.Button29 = new System.Windows.Forms.Button();
		this.Button24 = new System.Windows.Forms.Button();
		this.Button4 = new System.Windows.Forms.Button();
		this.Deposito = new System.Windows.Forms.TabPage();
		this.BtnEtiquetas = new System.Windows.Forms.Button();
		this.Button53 = new System.Windows.Forms.Button();
		this.Button50 = new System.Windows.Forms.Button();
		this.ordenesBtn = new System.Windows.Forms.Button();
		this.Button45 = new System.Windows.Forms.Button();
		this.Button44 = new System.Windows.Forms.Button();
		this.Button43 = new System.Windows.Forms.Button();
		this.Button42 = new System.Windows.Forms.Button();
		this.btn_despacho_etrans = new System.Windows.Forms.Button();
		this.Button21 = new System.Windows.Forms.Button();
		this.Transporte = new System.Windows.Forms.TabPage();
		this.Button35 = new System.Windows.Forms.Button();
		this.Button9 = new System.Windows.Forms.Button();
		this.choferesbtn = new System.Windows.Forms.Button();
		this.Categoriasbtn = new System.Windows.Forms.Button();
		this.vehiculosbtn = new System.Windows.Forms.Button();
		this.Disponibilidadbtn = new System.Windows.Forms.Button();
		this.tarifasbtn = new System.Windows.Forms.Button();
		this.Eventuales = new System.Windows.Forms.TabPage();
		this.Button6 = new System.Windows.Forms.Button();
		this.eventualesbtn = new System.Windows.Forms.Button();
		this.localidadesbtn = new System.Windows.Forms.Button();
		this.zonasbtn = new System.Windows.Forms.Button();
		this.posicionarbtn = new System.Windows.Forms.Button();
		this.TabTelas = new System.Windows.Forms.TabPage();
		this.Button63 = new System.Windows.Forms.Button();
		this.Button62 = new System.Windows.Forms.Button();
		this.Button61 = new System.Windows.Forms.Button();
		this.Button60 = new System.Windows.Forms.Button();
		this.Button59 = new System.Windows.Forms.Button();
		this.Button58 = new System.Windows.Forms.Button();
		this.Button57 = new System.Windows.Forms.Button();
		this.Button56 = new System.Windows.Forms.Button();
		this.Button55 = new System.Windows.Forms.Button();
		this.Button48 = new System.Windows.Forms.Button();
		this.Button49 = new System.Windows.Forms.Button();
		this.Reportes = new System.Windows.Forms.TabPage();
		this.Button52 = new System.Windows.Forms.Button();
		this.Button51 = new System.Windows.Forms.Button();
		this.Button47 = new System.Windows.Forms.Button();
		this.Button34 = new System.Windows.Forms.Button();
		this.Button3 = new System.Windows.Forms.Button();
		this.Button11 = new System.Windows.Forms.Button();
		this.Button20 = new System.Windows.Forms.Button();
		this.Button16 = new System.Windows.Forms.Button();
		this.Button1 = new System.Windows.Forms.Button();
		this.Button12 = new System.Windows.Forms.Button();
		this.Administrador = new System.Windows.Forms.TabPage();
		this.Button46 = new System.Windows.Forms.Button();
		this.Button41 = new System.Windows.Forms.Button();
		this.Button40 = new System.Windows.Forms.Button();
		this.TextBox1 = new System.Windows.Forms.TextBox();
		this.Button39 = new System.Windows.Forms.Button();
		this.Button38 = new System.Windows.Forms.Button();
		this.Button36 = new System.Windows.Forms.Button();
		this.Button33 = new System.Windows.Forms.Button();
		this.Button32 = new System.Windows.Forms.Button();
		this.Button27 = new System.Windows.Forms.Button();
		this.Button28 = new System.Windows.Forms.Button();
		this.Button10 = new System.Windows.Forms.Button();
		this.Button8 = new System.Windows.Forms.Button();
		this.Button15 = new System.Windows.Forms.Button();
		this.Button14 = new System.Windows.Forms.Button();
		this.Button30 = new System.Windows.Forms.Button();
		this.tablasbtn = new System.Windows.Forms.Button();
		this.Usuariobtn = new System.Windows.Forms.Button();
		this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
		this.ToolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
		this.nombreusuario = new System.Windows.Forms.ToolStripStatusLabel();
		this.ComboBox1 = new System.Windows.Forms.ComboBox();
		this.Label1 = new System.Windows.Forms.Label();
		this.Label2 = new System.Windows.Forms.Label();
		this.TabControl1.SuspendLayout();
		this.Inicio.SuspendLayout();
		this.Importación.SuspendLayout();
		this.GroupBox1.SuspendLayout();
		this.Planificacion.SuspendLayout();
		this.Tracking.SuspendLayout();
		this.Operaciones.SuspendLayout();
		this.Etrans.SuspendLayout();
		this.Deposito.SuspendLayout();
		this.Transporte.SuspendLayout();
		this.Eventuales.SuspendLayout();
		this.TabTelas.SuspendLayout();
		this.Reportes.SuspendLayout();
		this.Administrador.SuspendLayout();
		this.StatusStrip1.SuspendLayout();
		base.SuspendLayout();
		this.DateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
		this.DateTimePicker1.Location = new System.Drawing.Point(928, 12);
		this.DateTimePicker1.Name = "DateTimePicker1";
		this.DateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.No;
		this.DateTimePicker1.Size = new System.Drawing.Size(95, 20);
		this.DateTimePicker1.TabIndex = 9;
		this.Splitter2.BackColor = System.Drawing.SystemColors.Control;
		this.Splitter2.Cursor = System.Windows.Forms.Cursors.VSplit;
		this.Splitter2.Dock = System.Windows.Forms.DockStyle.Top;
		this.Splitter2.Location = new System.Drawing.Point(0, 0);
		this.Splitter2.Name = "Splitter2";
		this.Splitter2.Size = new System.Drawing.Size(1032, 99);
		this.Splitter2.TabIndex = 22;
		this.Splitter2.TabStop = false;
		this.TabControl1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.TabControl1.Controls.Add(this.Inicio);
		this.TabControl1.Controls.Add(this.Importación);
		this.TabControl1.Controls.Add(this.Planificacion);
		this.TabControl1.Controls.Add(this.Tracking);
		this.TabControl1.Controls.Add(this.Operaciones);
		this.TabControl1.Controls.Add(this.Etrans);
		this.TabControl1.Controls.Add(this.Deposito);
		this.TabControl1.Controls.Add(this.Transporte);
		this.TabControl1.Controls.Add(this.Eventuales);
		this.TabControl1.Controls.Add(this.TabTelas);
		this.TabControl1.Controls.Add(this.Reportes);
		this.TabControl1.Controls.Add(this.Administrador);
		this.TabControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
		this.TabControl1.Location = new System.Drawing.Point(5, 4);
		this.TabControl1.Name = "TabControl1";
		this.TabControl1.SelectedIndex = 0;
		this.TabControl1.Size = new System.Drawing.Size(917, 91);
		this.TabControl1.TabIndex = 0;
		this.Inicio.BackColor = System.Drawing.SystemColors.Control;
		this.Inicio.Controls.Add(this.helpBtn);
		this.Inicio.Controls.Add(this.Label3);
		this.Inicio.Controls.Add(this.Exploradorbtn);
		this.Inicio.Controls.Add(this.Button22);
		this.Inicio.Location = new System.Drawing.Point(4, 22);
		this.Inicio.Name = "Inicio";
		this.Inicio.Padding = new System.Windows.Forms.Padding(3);
		this.Inicio.Size = new System.Drawing.Size(909, 65);
		this.Inicio.TabIndex = 0;
		this.Inicio.Text = "Inicio";
		this.helpBtn.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.helpBtn.Image = Hermes.My.Resources.Resources.info_button_321;
		this.helpBtn.Location = new System.Drawing.Point(973, 6);
		this.helpBtn.Name = "helpBtn";
		this.helpBtn.Size = new System.Drawing.Size(34, 33);
		this.helpBtn.TabIndex = 35;
		this.helpBtn.UseVisualStyleBackColor = true;
		this.Label3.AutoSize = true;
		this.Label3.Location = new System.Drawing.Point(581, 26);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(39, 13);
		this.Label3.TabIndex = 40;
		this.Label3.Text = "Label3";
		this.Exploradorbtn.Image = (System.Drawing.Image)resources.GetObject("Exploradorbtn.Image");
		this.Exploradorbtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
		this.Exploradorbtn.Location = new System.Drawing.Point(6, 5);
		this.Exploradorbtn.Name = "Exploradorbtn";
		this.Exploradorbtn.Size = new System.Drawing.Size(70, 57);
		this.Exploradorbtn.TabIndex = 8;
		this.Exploradorbtn.Text = "Explorador";
		this.Exploradorbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
		this.Exploradorbtn.UseVisualStyleBackColor = true;
		this.Button22.Image = (System.Drawing.Image)resources.GetObject("Button22.Image");
		this.Button22.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
		this.Button22.Location = new System.Drawing.Point(82, 5);
		this.Button22.Name = "Button22";
		this.Button22.Size = new System.Drawing.Size(70, 57);
		this.Button22.TabIndex = 39;
		this.Button22.Text = "Buscar";
		this.Button22.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
		this.Button22.UseVisualStyleBackColor = true;
		this.Importación.BackColor = System.Drawing.SystemColors.Control;
		this.Importación.Controls.Add(this.Button23);
		this.Importación.Controls.Add(this.filtrarbtn);
		this.Importación.Controls.Add(this.GroupBox1);
		this.Importación.Controls.Add(this.verexcelbtn);
		this.Importación.Controls.Add(this.Importarbtn);
		this.Importación.Location = new System.Drawing.Point(4, 22);
		this.Importación.Name = "Importación";
		this.Importación.Padding = new System.Windows.Forms.Padding(3);
		this.Importación.Size = new System.Drawing.Size(909, 65);
		this.Importación.TabIndex = 9;
		this.Importación.Text = "Importación";
		this.Button23.Image = (System.Drawing.Image)resources.GetObject("Button23.Image");
		this.Button23.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
		this.Button23.Location = new System.Drawing.Point(234, 5);
		this.Button23.Name = "Button23";
		this.Button23.Size = new System.Drawing.Size(70, 57);
		this.Button23.TabIndex = 35;
		this.Button23.Text = "Ingreso";
		this.Button23.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
		this.Button23.UseVisualStyleBackColor = true;
		this.filtrarbtn.Enabled = false;
		this.filtrarbtn.Image = (System.Drawing.Image)resources.GetObject("filtrarbtn.Image");
		this.filtrarbtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
		this.filtrarbtn.Location = new System.Drawing.Point(6, 5);
		this.filtrarbtn.Name = "filtrarbtn";
		this.filtrarbtn.Size = new System.Drawing.Size(70, 57);
		this.filtrarbtn.TabIndex = 1;
		this.filtrarbtn.Text = "Filtrar";
		this.filtrarbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
		this.filtrarbtn.UseVisualStyleBackColor = true;
		this.GroupBox1.Controls.Add(this.Button7);
		this.GroupBox1.Location = new System.Drawing.Point(659, 6);
		this.GroupBox1.Name = "GroupBox1";
		this.GroupBox1.Size = new System.Drawing.Size(95, 57);
		this.GroupBox1.TabIndex = 35;
		this.GroupBox1.TabStop = false;
		this.GroupBox1.Text = "Planchada";
		this.Button7.Location = new System.Drawing.Point(6, 19);
		this.Button7.Name = "Button7";
		this.Button7.Size = new System.Drawing.Size(83, 32);
		this.Button7.TabIndex = 35;
		this.Button7.Text = "Borrar";
		this.Button7.UseVisualStyleBackColor = true;
		this.verexcelbtn.Enabled = false;
		this.verexcelbtn.Image = (System.Drawing.Image)resources.GetObject("verexcelbtn.Image");
		this.verexcelbtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
		this.verexcelbtn.Location = new System.Drawing.Point(82, 5);
		this.verexcelbtn.Name = "verexcelbtn";
		this.verexcelbtn.Size = new System.Drawing.Size(70, 57);
		this.verexcelbtn.TabIndex = 2;
		this.verexcelbtn.Text = "Ver";
		this.verexcelbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
		this.verexcelbtn.UseVisualStyleBackColor = true;
		this.Importarbtn.Enabled = false;
		this.Importarbtn.Image = (System.Drawing.Image)resources.GetObject("Importarbtn.Image");
		this.Importarbtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
		this.Importarbtn.Location = new System.Drawing.Point(158, 5);
		this.Importarbtn.Name = "Importarbtn";
		this.Importarbtn.Size = new System.Drawing.Size(70, 57);
		this.Importarbtn.TabIndex = 3;
		this.Importarbtn.Text = "Importar";
		this.Importarbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
		this.Importarbtn.UseVisualStyleBackColor = true;
		this.Planificacion.BackColor = System.Drawing.SystemColors.Control;
		this.Planificacion.Controls.Add(this.Button54);
		this.Planificacion.Controls.Add(this.Button5);
		this.Planificacion.Controls.Add(this.Ruteobtn);
		this.Planificacion.Controls.Add(this.rutasbtn);
		this.Planificacion.Controls.Add(this.CNDbtn);
		this.Planificacion.Controls.Add(this.Button13);
		this.Planificacion.Location = new System.Drawing.Point(4, 22);
		this.Planificacion.Name = "Planificacion";
		this.Planificacion.Padding = new System.Windows.Forms.Padding(3);
		this.Planificacion.Size = new System.Drawing.Size(909, 65);
		this.Planificacion.TabIndex = 8;
		this.Planificacion.Text = "Planificacion";
		this.Button54.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Button54.Image = Hermes.My.Resources.Resources.activity_monitor_warning;
		this.Button54.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
		this.Button54.Location = new System.Drawing.Point(158, 5);
		this.Button54.Name = "Button54";
		this.Button54.Size = new System.Drawing.Size(70, 57);
		this.Button54.TabIndex = 36;
		this.Button54.Text = "Informe";
		this.Button54.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
		this.Button54.UseVisualStyleBackColor = true;
		this.Button5.Image = (System.Drawing.Image)resources.GetObject("Button5.Image");
		this.Button5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
		this.Button5.Location = new System.Drawing.Point(833, 5);
		this.Button5.Name = "Button5";
		this.Button5.Size = new System.Drawing.Size(70, 57);
		this.Button5.TabIndex = 8;
		this.Button5.Text = "Config.";
		this.Button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
		this.Button5.UseVisualStyleBackColor = true;
		this.Ruteobtn.Enabled = false;
		this.Ruteobtn.Image = (System.Drawing.Image)resources.GetObject("Ruteobtn.Image");
		this.Ruteobtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
		this.Ruteobtn.Location = new System.Drawing.Point(684, 5);
		this.Ruteobtn.Name = "Ruteobtn";
		this.Ruteobtn.Size = new System.Drawing.Size(70, 57);
		this.Ruteobtn.TabIndex = 4;
		this.Ruteobtn.Text = "Ruteo";
		this.Ruteobtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
		this.Ruteobtn.UseVisualStyleBackColor = true;
		this.rutasbtn.Enabled = false;
		this.rutasbtn.Image = Hermes.My.Resources.Resources.Light_Bulb_On;
		this.rutasbtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
		this.rutasbtn.Location = new System.Drawing.Point(6, 5);
		this.rutasbtn.Name = "rutasbtn";
		this.rutasbtn.Size = new System.Drawing.Size(70, 57);
		this.rutasbtn.TabIndex = 7;
		this.rutasbtn.Text = "Planificar";
		this.rutasbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
		this.rutasbtn.UseVisualStyleBackColor = true;
		this.CNDbtn.Enabled = false;
		this.CNDbtn.Image = (System.Drawing.Image)resources.GetObject("CNDbtn.Image");
		this.CNDbtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
		this.CNDbtn.Location = new System.Drawing.Point(82, 5);
		this.CNDbtn.Name = "CNDbtn";
		this.CNDbtn.Size = new System.Drawing.Size(70, 57);
		this.CNDbtn.TabIndex = 6;
		this.CNDbtn.Text = "CND";
		this.CNDbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
		this.CNDbtn.UseVisualStyleBackColor = true;
		this.Button13.Enabled = false;
		this.Button13.Location = new System.Drawing.Point(760, 6);
		this.Button13.Name = "Button13";
		this.Button13.Size = new System.Drawing.Size(70, 56);
		this.Button13.TabIndex = 35;
		this.Button13.Text = "posicionar facu";
		this.Button13.UseVisualStyleBackColor = true;
		this.Button13.Visible = false;
		this.Tracking.BackColor = System.Drawing.SystemColors.Control;
		this.Tracking.Controls.Add(this.Button2);
		this.Tracking.Controls.Add(this.mapabtn);
		this.Tracking.Location = new System.Drawing.Point(4, 22);
		this.Tracking.Name = "Tracking";
		this.Tracking.Size = new System.Drawing.Size(909, 65);
		this.Tracking.TabIndex = 7;
		this.Tracking.Text = "Tracking";
		this.Button2.Image = Hermes.My.Resources.Resources.Ruler;
		this.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
		this.Button2.Location = new System.Drawing.Point(79, 5);
		this.Button2.Name = "Button2";
		this.Button2.Size = new System.Drawing.Size(66, 57);
		this.Button2.TabIndex = 11;
		this.Button2.Text = "Diseñar";
		this.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
		this.Button2.UseVisualStyleBackColor = true;
		this.mapabtn.Image = (System.Drawing.Image)resources.GetObject("mapabtn.Image");
		this.mapabtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
		this.mapabtn.Location = new System.Drawing.Point(3, 5);
		this.mapabtn.Name = "mapabtn";
		this.mapabtn.Size = new System.Drawing.Size(70, 57);
		this.mapabtn.TabIndex = 10;
		this.mapabtn.Text = "Mapa";
		this.mapabtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
		this.mapabtn.UseVisualStyleBackColor = true;
		this.Operaciones.BackColor = System.Drawing.SystemColors.Control;
		this.Operaciones.Controls.Add(this.Button17);
		this.Operaciones.Controls.Add(this.Button19);
		this.Operaciones.Controls.Add(this.Button18);
		this.Operaciones.Controls.Add(this.rotacionbtn);
		this.Operaciones.Controls.Add(this.retirosbtn);
		this.Operaciones.Controls.Add(this.Button26);
		this.Operaciones.Controls.Add(this.Button25);
		this.Operaciones.Controls.Add(this.clientesbtn);
		this.Operaciones.Location = new System.Drawing.Point(4, 22);
		this.Operaciones.Name = "Operaciones";
		this.Operaciones.Padding = new System.Windows.Forms.Padding(3);
		this.Operaciones.Size = new System.Drawing.Size(909, 65);
		this.Operaciones.TabIndex = 1;
		this.Operaciones.Text = "Operaciones";
		this.Button17.Image = Hermes.My.Resources.Resources.games_difficult;
		this.Button17.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
		this.Button17.Location = new System.Drawing.Point(544, 6);
		this.Button17.Name = "Button17";
		this.Button17.Size = new System.Drawing.Size(73, 53);
		this.Button17.TabIndex = 35;
		this.Button17.Text = "Informe";
		this.Button17.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
		this.Button17.UseVisualStyleBackColor = true;
		this.Button19.Image = Hermes.My.Resources.Resources.Document_Checklist;
		this.Button19.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
		this.Button19.Location = new System.Drawing.Point(310, 6);
		this.Button19.Name = "Button19";
		this.Button19.Size = new System.Drawing.Size(70, 53);
		this.Button19.TabIndex = 38;
		this.Button19.Text = "Estados";
		this.Button19.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
		this.Button19.UseVisualStyleBackColor = true;
		this.Button18.Image = Hermes.My.Resources.Resources.Button_Check;
		this.Button18.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
		this.Button18.Location = new System.Drawing.Point(234, 6);
		this.Button18.Name = "Button18";
		this.Button18.Size = new System.Drawing.Size(70, 53);
		this.Button18.TabIndex = 37;
		this.Button18.Text = "Novedades";
		this.Button18.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
		this.Button18.UseVisualStyleBackColor = true;
		this.rotacionbtn.Image = Hermes.My.Resources.Resources.Button_White_Load;
		this.rotacionbtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
		this.rotacionbtn.Location = new System.Drawing.Point(82, 6);
		this.rotacionbtn.Name = "rotacionbtn";
		this.rotacionbtn.Size = new System.Drawing.Size(70, 53);
		this.rotacionbtn.TabIndex = 35;
		this.rotacionbtn.Text = "Rotacion";
		this.rotacionbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
		this.rotacionbtn.UseVisualStyleBackColor = true;
		this.retirosbtn.Image = Hermes.My.Resources.Resources.Box_Add;
		this.retirosbtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
		this.retirosbtn.Location = new System.Drawing.Point(6, 6);
		this.retirosbtn.Name = "retirosbtn";
		this.retirosbtn.Size = new System.Drawing.Size(70, 53);
		this.retirosbtn.TabIndex = 35;
		this.retirosbtn.Text = "Retiros";
		this.retirosbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
		this.retirosbtn.UseVisualStyleBackColor = true;
		this.Button26.Image = (System.Drawing.Image)resources.GetObject("Button26.Image");
		this.Button26.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
		this.Button26.Location = new System.Drawing.Point(465, 6);
		this.Button26.Name = "Button26";
		this.Button26.Size = new System.Drawing.Size(73, 53);
		this.Button26.TabIndex = 35;
		this.Button26.Text = "Despachos";
		this.Button26.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
		this.Button26.UseVisualStyleBackColor = true;
		this.Button25.Image = (System.Drawing.Image)resources.GetObject("Button25.Image");
		this.Button25.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
		this.Button25.Location = new System.Drawing.Point(386, 6);
		this.Button25.Name = "Button25";
		this.Button25.Size = new System.Drawing.Size(73, 53);
		this.Button25.TabIndex = 35;
		this.Button25.Text = "Cierre Guias";
		this.Button25.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
		this.Button25.UseVisualStyleBackColor = true;
		this.clientesbtn.Image = Hermes.My.Resources.Resources.address_book_add_32;
		this.clientesbtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
		this.clientesbtn.Location = new System.Drawing.Point(158, 6);
		this.clientesbtn.Name = "clientesbtn";
		this.clientesbtn.Size = new System.Drawing.Size(70, 53);
		this.clientesbtn.TabIndex = 35;
		this.clientesbtn.Text = "Clientes";
		this.clientesbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
		this.clientesbtn.UseVisualStyleBackColor = true;
		this.Etrans.BackColor = System.Drawing.SystemColors.Control;
		this.Etrans.Controls.Add(this.importEtrans);
		this.Etrans.Controls.Add(this.Button37);
		this.Etrans.Controls.Add(this.Button31);
		this.Etrans.Controls.Add(this.Button29);
		this.Etrans.Controls.Add(this.Button24);
		this.Etrans.Controls.Add(this.Button4);
		this.Etrans.Location = new System.Drawing.Point(4, 22);
		this.Etrans.Name = "Etrans";
		this.Etrans.Padding = new System.Windows.Forms.Padding(3);
		this.Etrans.Size = new System.Drawing.Size(909, 65);
		this.Etrans.TabIndex = 11;
		this.Etrans.Text = "Etrans";
		this.importEtrans.Location = new System.Drawing.Point(234, 6);
		this.importEtrans.Name = "importEtrans";
		this.importEtrans.Size = new System.Drawing.Size(70, 56);
		this.importEtrans.TabIndex = 37;
		this.importEtrans.Text = "Importar Etrans";
		this.importEtrans.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
		this.importEtrans.UseVisualStyleBackColor = true;
		this.Button37.Enabled = false;
		this.Button37.Location = new System.Drawing.Point(533, 8);
		this.Button37.Name = "Button37";
		this.Button37.Size = new System.Drawing.Size(70, 54);
		this.Button37.TabIndex = 45;
		this.Button37.Text = "Etiquetas masiva";
		this.Button37.UseVisualStyleBackColor = true;
		this.Button31.Location = new System.Drawing.Point(158, 5);
		this.Button31.Name = "Button31";
		this.Button31.Size = new System.Drawing.Size(70, 57);
		this.Button31.TabIndex = 36;
		this.Button31.Text = "Listar";
		this.Button31.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
		this.Button31.UseVisualStyleBackColor = true;
		this.Button29.Image = (System.Drawing.Image)resources.GetObject("Button29.Image");
		this.Button29.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
		this.Button29.Location = new System.Drawing.Point(82, 5);
		this.Button29.Name = "Button29";
		this.Button29.Size = new System.Drawing.Size(70, 57);
		this.Button29.TabIndex = 35;
		this.Button29.Text = "Editar";
		this.Button29.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
		this.Button29.UseVisualStyleBackColor = true;
		this.Button24.Image = (System.Drawing.Image)resources.GetObject("Button24.Image");
		this.Button24.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
		this.Button24.Location = new System.Drawing.Point(6, 5);
		this.Button24.Name = "Button24";
		this.Button24.Size = new System.Drawing.Size(70, 57);
		this.Button24.TabIndex = 35;
		this.Button24.Text = "Volcar";
		this.Button24.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
		this.Button24.UseVisualStyleBackColor = true;
		this.Button4.Image = (System.Drawing.Image)resources.GetObject("Button4.Image");
		this.Button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
		this.Button4.Location = new System.Drawing.Point(805, 5);
		this.Button4.Name = "Button4";
		this.Button4.Size = new System.Drawing.Size(70, 57);
		this.Button4.TabIndex = 35;
		this.Button4.Text = "Admin";
		this.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
		this.Button4.UseVisualStyleBackColor = true;
		this.Deposito.BackColor = System.Drawing.SystemColors.Control;
		this.Deposito.Controls.Add(this.BtnEtiquetas);
		this.Deposito.Controls.Add(this.Button53);
		this.Deposito.Controls.Add(this.Button50);
		this.Deposito.Controls.Add(this.ordenesBtn);
		this.Deposito.Controls.Add(this.Button45);
		this.Deposito.Controls.Add(this.Button44);
		this.Deposito.Controls.Add(this.Button43);
		this.Deposito.Controls.Add(this.Button42);
		this.Deposito.Controls.Add(this.btn_despacho_etrans);
		this.Deposito.Controls.Add(this.Button21);
		this.Deposito.Location = new System.Drawing.Point(4, 22);
		this.Deposito.Name = "Deposito";
		this.Deposito.Padding = new System.Windows.Forms.Padding(3);
		this.Deposito.Size = new System.Drawing.Size(909, 65);
		this.Deposito.TabIndex = 10;
		this.Deposito.Text = "Deposito";
		this.BtnEtiquetas.Location = new System.Drawing.Point(654, 7);
		this.BtnEtiquetas.Name = "BtnEtiquetas";
		this.BtnEtiquetas.Size = new System.Drawing.Size(75, 52);
		this.BtnEtiquetas.TabIndex = 43;
		this.BtnEtiquetas.Text = "Etiquetas";
		this.BtnEtiquetas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
		this.BtnEtiquetas.UseVisualStyleBackColor = true;
		this.Button53.Image = Hermes.My.Resources.Resources.go_jump_definition;
		this.Button53.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
		this.Button53.Location = new System.Drawing.Point(573, 7);
		this.Button53.Name = "Button53";
		this.Button53.Size = new System.Drawing.Size(75, 52);
		this.Button53.TabIndex = 42;
		this.Button53.Text = "Pendientes";
		this.Button53.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
		this.Button53.UseVisualStyleBackColor = true;
		this.Button50.Image = Hermes.My.Resources.Resources.ajuste_product;
		this.Button50.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
		this.Button50.Location = new System.Drawing.Point(816, 7);
		this.Button50.Name = "Button50";
		this.Button50.Size = new System.Drawing.Size(75, 52);
		this.Button50.TabIndex = 41;
		this.Button50.Text = "Ajustes";
		this.Button50.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
		this.Button50.UseVisualStyleBackColor = true;
		this.ordenesBtn.Image = Hermes.My.Resources.Resources.view_calendar_tasks;
		this.ordenesBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
		this.ordenesBtn.Location = new System.Drawing.Point(492, 7);
		this.ordenesBtn.Name = "ordenesBtn";
		this.ordenesBtn.Size = new System.Drawing.Size(75, 53);
		this.ordenesBtn.TabIndex = 35;
		this.ordenesBtn.Text = "Ordenes";
		this.ordenesBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
		this.ordenesBtn.UseVisualStyleBackColor = true;
		this.Button45.Image = Hermes.My.Resources.Resources.document_preview_archive;
		this.Button45.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
		this.Button45.Location = new System.Drawing.Point(168, 7);
		this.Button45.Name = "Button45";
		this.Button45.Size = new System.Drawing.Size(75, 53);
		this.Button45.TabIndex = 35;
		this.Button45.Text = "Estado";
		this.Button45.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
		this.Button45.UseVisualStyleBackColor = true;
		this.Button44.Image = Hermes.My.Resources.Resources.out_product;
		this.Button44.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
		this.Button44.Location = new System.Drawing.Point(411, 7);
		this.Button44.Name = "Button44";
		this.Button44.Size = new System.Drawing.Size(75, 53);
		this.Button44.TabIndex = 38;
		this.Button44.Text = "Salida";
		this.Button44.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
		this.Button44.UseVisualStyleBackColor = true;
		this.Button43.Image = Hermes.My.Resources.Resources.enter_product;
		this.Button43.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
		this.Button43.Location = new System.Drawing.Point(330, 7);
		this.Button43.Name = "Button43";
		this.Button43.Size = new System.Drawing.Size(75, 53);
		this.Button43.TabIndex = 35;
		this.Button43.Text = "Entrada";
		this.Button43.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
		this.Button43.UseVisualStyleBackColor = true;
		this.Button42.Image = Hermes.My.Resources.Resources.utilities_file_archiver;
		this.Button42.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
		this.Button42.Location = new System.Drawing.Point(249, 7);
		this.Button42.Name = "Button42";
		this.Button42.Size = new System.Drawing.Size(75, 53);
		this.Button42.TabIndex = 37;
		this.Button42.Text = "Productos";
		this.Button42.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
		this.Button42.UseVisualStyleBackColor = true;
		this.btn_despacho_etrans.Image = Hermes.My.Resources.Resources.home_go_32;
		this.btn_despacho_etrans.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
		this.btn_despacho_etrans.Location = new System.Drawing.Point(87, 7);
		this.btn_despacho_etrans.Name = "btn_despacho_etrans";
		this.btn_despacho_etrans.Size = new System.Drawing.Size(75, 53);
		this.btn_despacho_etrans.TabIndex = 36;
		this.btn_despacho_etrans.Text = "Despacho";
		this.btn_despacho_etrans.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
		this.btn_despacho_etrans.UseVisualStyleBackColor = true;
		this.Button21.Image = (System.Drawing.Image)resources.GetObject("Button21.Image");
		this.Button21.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
		this.Button21.Location = new System.Drawing.Point(6, 7);
		this.Button21.Name = "Button21";
		this.Button21.Size = new System.Drawing.Size(75, 53);
		this.Button21.TabIndex = 35;
		this.Button21.Text = "Recepción";
		this.Button21.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
		this.Button21.UseVisualStyleBackColor = true;
		this.Transporte.BackColor = System.Drawing.SystemColors.Control;
		this.Transporte.Controls.Add(this.Button35);
		this.Transporte.Controls.Add(this.Button9);
		this.Transporte.Controls.Add(this.choferesbtn);
		this.Transporte.Controls.Add(this.Categoriasbtn);
		this.Transporte.Controls.Add(this.vehiculosbtn);
		this.Transporte.Controls.Add(this.Disponibilidadbtn);
		this.Transporte.Controls.Add(this.tarifasbtn);
		this.Transporte.Location = new System.Drawing.Point(4, 22);
		this.Transporte.Name = "Transporte";
		this.Transporte.Size = new System.Drawing.Size(909, 65);
		this.Transporte.TabIndex = 2;
		this.Transporte.Text = "Transportes";
		this.Button35.Location = new System.Drawing.Point(464, 5);
		this.Button35.Name = "Button35";
		this.Button35.Size = new System.Drawing.Size(70, 57);
		this.Button35.TabIndex = 36;
		this.Button35.Text = "Viajes";
		this.Button35.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
		this.Button35.UseVisualStyleBackColor = true;
		this.Button35.Visible = false;
		this.Button9.Location = new System.Drawing.Point(388, 5);
		this.Button9.Name = "Button9";
		this.Button9.Size = new System.Drawing.Size(70, 57);
		this.Button9.TabIndex = 35;
		this.Button9.Text = "Vehiculos N";
		this.Button9.UseVisualStyleBackColor = true;
		this.Button9.Visible = false;
		this.choferesbtn.Enabled = false;
		this.choferesbtn.Image = (System.Drawing.Image)resources.GetObject("choferesbtn.Image");
		this.choferesbtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
		this.choferesbtn.Location = new System.Drawing.Point(160, 5);
		this.choferesbtn.Name = "choferesbtn";
		this.choferesbtn.Size = new System.Drawing.Size(70, 57);
		this.choferesbtn.TabIndex = 29;
		this.choferesbtn.Text = "Choferes";
		this.choferesbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
		this.choferesbtn.UseVisualStyleBackColor = true;
		this.Categoriasbtn.Enabled = false;
		this.Categoriasbtn.Image = (System.Drawing.Image)resources.GetObject("Categoriasbtn.Image");
		this.Categoriasbtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
		this.Categoriasbtn.Location = new System.Drawing.Point(312, 5);
		this.Categoriasbtn.Name = "Categoriasbtn";
		this.Categoriasbtn.Size = new System.Drawing.Size(70, 57);
		this.Categoriasbtn.TabIndex = 29;
		this.Categoriasbtn.Text = "Categorias";
		this.Categoriasbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
		this.Categoriasbtn.UseVisualStyleBackColor = true;
		this.vehiculosbtn.Enabled = false;
		this.vehiculosbtn.Image = (System.Drawing.Image)resources.GetObject("vehiculosbtn.Image");
		this.vehiculosbtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
		this.vehiculosbtn.Location = new System.Drawing.Point(84, 5);
		this.vehiculosbtn.Name = "vehiculosbtn";
		this.vehiculosbtn.Size = new System.Drawing.Size(70, 57);
		this.vehiculosbtn.TabIndex = 28;
		this.vehiculosbtn.Text = "Vehiculos";
		this.vehiculosbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
		this.vehiculosbtn.UseVisualStyleBackColor = true;
		this.Disponibilidadbtn.Enabled = false;
		this.Disponibilidadbtn.Image = (System.Drawing.Image)resources.GetObject("Disponibilidadbtn.Image");
		this.Disponibilidadbtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
		this.Disponibilidadbtn.Location = new System.Drawing.Point(8, 5);
		this.Disponibilidadbtn.Name = "Disponibilidadbtn";
		this.Disponibilidadbtn.Size = new System.Drawing.Size(70, 57);
		this.Disponibilidadbtn.TabIndex = 5;
		this.Disponibilidadbtn.Text = "Disponibles";
		this.Disponibilidadbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
		this.Disponibilidadbtn.UseVisualStyleBackColor = true;
		this.tarifasbtn.Enabled = false;
		this.tarifasbtn.Image = (System.Drawing.Image)resources.GetObject("tarifasbtn.Image");
		this.tarifasbtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
		this.tarifasbtn.Location = new System.Drawing.Point(236, 5);
		this.tarifasbtn.Name = "tarifasbtn";
		this.tarifasbtn.Size = new System.Drawing.Size(70, 57);
		this.tarifasbtn.TabIndex = 28;
		this.tarifasbtn.Text = "Tarifas";
		this.tarifasbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
		this.tarifasbtn.UseVisualStyleBackColor = true;
		this.Eventuales.Controls.Add(this.Button6);
		this.Eventuales.Controls.Add(this.eventualesbtn);
		this.Eventuales.Controls.Add(this.localidadesbtn);
		this.Eventuales.Controls.Add(this.zonasbtn);
		this.Eventuales.Controls.Add(this.posicionarbtn);
		this.Eventuales.Location = new System.Drawing.Point(4, 22);
		this.Eventuales.Name = "Eventuales";
		this.Eventuales.Size = new System.Drawing.Size(909, 65);
		this.Eventuales.TabIndex = 6;
		this.Eventuales.Text = "Eventuales";
		this.Button6.Image = (System.Drawing.Image)resources.GetObject("Button6.Image");
		this.Button6.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
		this.Button6.Location = new System.Drawing.Point(307, 5);
		this.Button6.Name = "Button6";
		this.Button6.Size = new System.Drawing.Size(70, 57);
		this.Button6.TabIndex = 35;
		this.Button6.Text = "Eventos";
		this.Button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
		this.Button6.UseVisualStyleBackColor = true;
		this.eventualesbtn.Image = Hermes.My.Resources.Resources.flag_red;
		this.eventualesbtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
		this.eventualesbtn.Location = new System.Drawing.Point(3, 5);
		this.eventualesbtn.Name = "eventualesbtn";
		this.eventualesbtn.Size = new System.Drawing.Size(70, 57);
		this.eventualesbtn.TabIndex = 0;
		this.eventualesbtn.Text = "Eventuales";
		this.eventualesbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
		this.eventualesbtn.UseVisualStyleBackColor = true;
		this.localidadesbtn.Image = Hermes.My.Resources.Resources.flag_blue;
		this.localidadesbtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
		this.localidadesbtn.Location = new System.Drawing.Point(79, 5);
		this.localidadesbtn.Name = "localidadesbtn";
		this.localidadesbtn.Size = new System.Drawing.Size(70, 57);
		this.localidadesbtn.TabIndex = 31;
		this.localidadesbtn.Text = "Localidad";
		this.localidadesbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
		this.localidadesbtn.UseVisualStyleBackColor = true;
		this.zonasbtn.Image = Hermes.My.Resources.Resources.flag_yellow;
		this.zonasbtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
		this.zonasbtn.Location = new System.Drawing.Point(155, 5);
		this.zonasbtn.Name = "zonasbtn";
		this.zonasbtn.Size = new System.Drawing.Size(70, 57);
		this.zonasbtn.TabIndex = 32;
		this.zonasbtn.Text = "Zonas";
		this.zonasbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
		this.zonasbtn.UseVisualStyleBackColor = true;
		this.posicionarbtn.Image = Hermes.My.Resources.Resources.edit_guides;
		this.posicionarbtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
		this.posicionarbtn.Location = new System.Drawing.Point(231, 5);
		this.posicionarbtn.Name = "posicionarbtn";
		this.posicionarbtn.Size = new System.Drawing.Size(70, 57);
		this.posicionarbtn.TabIndex = 29;
		this.posicionarbtn.Text = "Posicionar";
		this.posicionarbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
		this.posicionarbtn.UseVisualStyleBackColor = true;
		this.TabTelas.BackColor = System.Drawing.SystemColors.Control;
		this.TabTelas.Controls.Add(this.Button63);
		this.TabTelas.Controls.Add(this.Button62);
		this.TabTelas.Controls.Add(this.Button61);
		this.TabTelas.Controls.Add(this.Button60);
		this.TabTelas.Controls.Add(this.Button59);
		this.TabTelas.Controls.Add(this.Button58);
		this.TabTelas.Controls.Add(this.Button57);
		this.TabTelas.Controls.Add(this.Button56);
		this.TabTelas.Controls.Add(this.Button55);
		this.TabTelas.Controls.Add(this.Button48);
		this.TabTelas.Controls.Add(this.Button49);
		this.TabTelas.Location = new System.Drawing.Point(4, 22);
		this.TabTelas.Name = "TabTelas";
		this.TabTelas.Padding = new System.Windows.Forms.Padding(3);
		this.TabTelas.Size = new System.Drawing.Size(909, 65);
		this.TabTelas.TabIndex = 12;
		this.TabTelas.Text = "Telas";
		this.Button63.Location = new System.Drawing.Point(654, 7);
		this.Button63.Name = "Button63";
		this.Button63.Size = new System.Drawing.Size(75, 52);
		this.Button63.TabIndex = 49;
		this.Button63.Text = "Button63";
		this.Button63.UseVisualStyleBackColor = true;
		this.Button63.Visible = false;
		this.Button62.Location = new System.Drawing.Point(573, 7);
		this.Button62.Name = "Button62";
		this.Button62.Size = new System.Drawing.Size(75, 52);
		this.Button62.TabIndex = 48;
		this.Button62.Text = "Button62";
		this.Button62.UseVisualStyleBackColor = true;
		this.Button62.Visible = false;
		this.Button61.Location = new System.Drawing.Point(492, 7);
		this.Button61.Name = "Button61";
		this.Button61.Size = new System.Drawing.Size(75, 52);
		this.Button61.TabIndex = 47;
		this.Button61.Text = "Button61";
		this.Button61.UseVisualStyleBackColor = true;
		this.Button61.Visible = false;
		this.Button60.Location = new System.Drawing.Point(411, 7);
		this.Button60.Name = "Button60";
		this.Button60.Size = new System.Drawing.Size(75, 52);
		this.Button60.TabIndex = 46;
		this.Button60.Text = "Button60";
		this.Button60.UseVisualStyleBackColor = true;
		this.Button60.Visible = false;
		this.Button59.Location = new System.Drawing.Point(330, 7);
		this.Button59.Name = "Button59";
		this.Button59.Size = new System.Drawing.Size(75, 52);
		this.Button59.TabIndex = 45;
		this.Button59.Text = "Button59";
		this.Button59.UseVisualStyleBackColor = true;
		this.Button59.Visible = false;
		this.Button58.Location = new System.Drawing.Point(249, 7);
		this.Button58.Name = "Button58";
		this.Button58.Size = new System.Drawing.Size(75, 52);
		this.Button58.TabIndex = 44;
		this.Button58.Text = "Button58";
		this.Button58.UseVisualStyleBackColor = true;
		this.Button58.Visible = false;
		this.Button57.Image = Hermes.My.Resources.Resources.document_preview_archive;
		this.Button57.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
		this.Button57.Location = new System.Drawing.Point(168, 7);
		this.Button57.Name = "Button57";
		this.Button57.Size = new System.Drawing.Size(75, 52);
		this.Button57.TabIndex = 43;
		this.Button57.Text = "Posiciones";
		this.Button57.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
		this.Button57.UseVisualStyleBackColor = true;
		this.Button56.Image = Hermes.My.Resources.Resources.out_product;
		this.Button56.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
		this.Button56.Location = new System.Drawing.Point(87, 7);
		this.Button56.Name = "Button56";
		this.Button56.Size = new System.Drawing.Size(75, 52);
		this.Button56.TabIndex = 42;
		this.Button56.Text = "Salida";
		this.Button56.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
		this.Button56.UseVisualStyleBackColor = true;
		this.Button55.Image = Hermes.My.Resources.Resources.enter_product;
		this.Button55.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
		this.Button55.Location = new System.Drawing.Point(6, 7);
		this.Button55.Name = "Button55";
		this.Button55.Size = new System.Drawing.Size(75, 52);
		this.Button55.TabIndex = 41;
		this.Button55.Text = "Entrada";
		this.Button55.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
		this.Button55.UseVisualStyleBackColor = true;
		this.Button48.Image = Hermes.My.Resources.Resources.utilities_file_archiver;
		this.Button48.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
		this.Button48.Location = new System.Drawing.Point(735, 7);
		this.Button48.Name = "Button48";
		this.Button48.Size = new System.Drawing.Size(75, 52);
		this.Button48.TabIndex = 39;
		this.Button48.Text = "Almacen";
		this.Button48.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
		this.Button48.UseVisualStyleBackColor = true;
		this.Button48.Visible = false;
		this.Button49.Image = Hermes.My.Resources.Resources.Antrepo_Container_2_Cargo_1;
		this.Button49.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
		this.Button49.Location = new System.Drawing.Point(816, 7);
		this.Button49.Name = "Button49";
		this.Button49.Size = new System.Drawing.Size(75, 52);
		this.Button49.TabIndex = 40;
		this.Button49.Text = "Descarga";
		this.Button49.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
		this.Button49.UseVisualStyleBackColor = true;
		this.Button49.Visible = false;
		this.Reportes.BackColor = System.Drawing.SystemColors.Control;
		this.Reportes.Controls.Add(this.Button52);
		this.Reportes.Controls.Add(this.Button51);
		this.Reportes.Controls.Add(this.Button47);
		this.Reportes.Controls.Add(this.Button34);
		this.Reportes.Controls.Add(this.Button3);
		this.Reportes.Controls.Add(this.Button11);
		this.Reportes.Controls.Add(this.Button20);
		this.Reportes.Controls.Add(this.Button16);
		this.Reportes.Controls.Add(this.Button1);
		this.Reportes.Controls.Add(this.Button12);
		this.Reportes.Location = new System.Drawing.Point(4, 22);
		this.Reportes.Name = "Reportes";
		this.Reportes.Size = new System.Drawing.Size(909, 65);
		this.Reportes.TabIndex = 3;
		this.Reportes.Text = "Reportes";
		this.Button52.Enabled = false;
		this.Button52.Image = Hermes.My.Resources.Resources.almacenInf;
		this.Button52.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
		this.Button52.Location = new System.Drawing.Point(377, 3);
		this.Button52.Name = "Button52";
		this.Button52.Size = new System.Drawing.Size(75, 57);
		this.Button52.TabIndex = 42;
		this.Button52.Text = "Inf. Almacen";
		this.Button52.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
		this.Button52.UseVisualStyleBackColor = true;
		this.Button51.Image = Hermes.My.Resources.Resources.games_difficult;
		this.Button51.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
		this.Button51.Location = new System.Drawing.Point(303, 3);
		this.Button51.Name = "Button51";
		this.Button51.Size = new System.Drawing.Size(68, 57);
		this.Button51.TabIndex = 41;
		this.Button51.Text = "Graficos";
		this.Button51.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
		this.Button51.UseVisualStyleBackColor = true;
		this.Button47.Location = new System.Drawing.Point(646, 3);
		this.Button47.Name = "Button47";
		this.Button47.Size = new System.Drawing.Size(75, 57);
		this.Button47.TabIndex = 40;
		this.Button47.Text = "Button47";
		this.Button47.UseVisualStyleBackColor = true;
		this.Button47.Visible = false;
		this.Button34.Location = new System.Drawing.Point(803, 37);
		this.Button34.Name = "Button34";
		this.Button34.Size = new System.Drawing.Size(75, 23);
		this.Button34.TabIndex = 39;
		this.Button34.Text = "Button34";
		this.Button34.UseVisualStyleBackColor = true;
		this.Button34.Visible = false;
		this.Button3.Location = new System.Drawing.Point(803, 3);
		this.Button3.Name = "Button3";
		this.Button3.Size = new System.Drawing.Size(75, 28);
		this.Button3.TabIndex = 38;
		this.Button3.Text = "Enviar FTP";
		this.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
		this.Button3.UseVisualStyleBackColor = true;
		this.Button3.Visible = false;
		this.Button11.Image = Hermes.My.Resources.Resources.go_jump_definition;
		this.Button11.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
		this.Button11.Location = new System.Drawing.Point(3, 3);
		this.Button11.Name = "Button11";
		this.Button11.Size = new System.Drawing.Size(70, 57);
		this.Button11.TabIndex = 33;
		this.Button11.Text = "Importacion";
		this.Button11.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
		this.Button11.UseVisualStyleBackColor = true;
		this.Button20.Image = (System.Drawing.Image)resources.GetObject("Button20.Image");
		this.Button20.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
		this.Button20.Location = new System.Drawing.Point(229, 3);
		this.Button20.Name = "Button20";
		this.Button20.Size = new System.Drawing.Size(68, 57);
		this.Button20.TabIndex = 35;
		this.Button20.Text = "Conf. Impr.";
		this.Button20.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
		this.Button20.UseVisualStyleBackColor = true;
		this.Button16.Image = (System.Drawing.Image)resources.GetObject("Button16.Image");
		this.Button16.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
		this.Button16.Location = new System.Drawing.Point(155, 3);
		this.Button16.Name = "Button16";
		this.Button16.Size = new System.Drawing.Size(68, 57);
		this.Button16.TabIndex = 37;
		this.Button16.Text = "Reporte";
		this.Button16.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
		this.Button16.UseVisualStyleBackColor = true;
		this.Button1.Image = (System.Drawing.Image)resources.GetObject("Button1.Image");
		this.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
		this.Button1.Location = new System.Drawing.Point(727, 3);
		this.Button1.Name = "Button1";
		this.Button1.Size = new System.Drawing.Size(70, 57);
		this.Button1.TabIndex = 28;
		this.Button1.Text = "Officetrack";
		this.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
		this.Button1.UseVisualStyleBackColor = true;
		this.Button1.Visible = false;
		this.Button12.Image = Hermes.My.Resources.Resources.activity_monitor_warning;
		this.Button12.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
		this.Button12.Location = new System.Drawing.Point(79, 3);
		this.Button12.Name = "Button12";
		this.Button12.Size = new System.Drawing.Size(70, 57);
		this.Button12.TabIndex = 34;
		this.Button12.Text = "Procesos";
		this.Button12.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
		this.Button12.UseVisualStyleBackColor = true;
		this.Administrador.BackColor = System.Drawing.SystemColors.Control;
		this.Administrador.Controls.Add(this.Button46);
		this.Administrador.Controls.Add(this.Button41);
		this.Administrador.Controls.Add(this.Button40);
		this.Administrador.Controls.Add(this.TextBox1);
		this.Administrador.Controls.Add(this.Button39);
		this.Administrador.Controls.Add(this.Button38);
		this.Administrador.Controls.Add(this.Button36);
		this.Administrador.Controls.Add(this.Button33);
		this.Administrador.Controls.Add(this.Button32);
		this.Administrador.Controls.Add(this.Button27);
		this.Administrador.Controls.Add(this.Button28);
		this.Administrador.Controls.Add(this.Button10);
		this.Administrador.Controls.Add(this.Button8);
		this.Administrador.Controls.Add(this.Button15);
		this.Administrador.Controls.Add(this.Button14);
		this.Administrador.Controls.Add(this.Button30);
		this.Administrador.Controls.Add(this.tablasbtn);
		this.Administrador.Controls.Add(this.Usuariobtn);
		this.Administrador.Location = new System.Drawing.Point(4, 22);
		this.Administrador.Name = "Administrador";
		this.Administrador.Size = new System.Drawing.Size(909, 65);
		this.Administrador.TabIndex = 4;
		this.Administrador.Text = "Administrador";
		this.Button46.Location = new System.Drawing.Point(716, 7);
		this.Button46.Name = "Button46";
		this.Button46.Size = new System.Drawing.Size(75, 23);
		this.Button46.TabIndex = 50;
		this.Button46.Text = "Button46";
		this.Button46.UseVisualStyleBackColor = true;
		this.Button41.Location = new System.Drawing.Point(236, 5);
		this.Button41.Name = "Button41";
		this.Button41.Size = new System.Drawing.Size(70, 55);
		this.Button41.TabIndex = 35;
		this.Button41.Text = "Empresas";
		this.Button41.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
		this.Button41.UseVisualStyleBackColor = true;
		this.Button40.Location = new System.Drawing.Point(563, 37);
		this.Button40.Name = "Button40";
		this.Button40.Size = new System.Drawing.Size(75, 23);
		this.Button40.TabIndex = 49;
		this.Button40.Text = "Flete";
		this.Button40.UseVisualStyleBackColor = true;
		this.Button40.Visible = false;
		this.TextBox1.Location = new System.Drawing.Point(327, 10);
		this.TextBox1.Name = "TextBox1";
		this.TextBox1.Size = new System.Drawing.Size(75, 20);
		this.TextBox1.TabIndex = 48;
		this.Button39.Location = new System.Drawing.Point(327, 38);
		this.Button39.Name = "Button39";
		this.Button39.Size = new System.Drawing.Size(75, 23);
		this.Button39.TabIndex = 47;
		this.Button39.Text = "Retiros aun";
		this.Button39.UseVisualStyleBackColor = true;
		this.Button38.Location = new System.Drawing.Point(797, 5);
		this.Button38.Name = "Button38";
		this.Button38.Size = new System.Drawing.Size(75, 27);
		this.Button38.TabIndex = 46;
		this.Button38.Text = "Agrupar Retiros";
		this.Button38.UseVisualStyleBackColor = true;
		this.Button38.Visible = false;
		this.Button36.Location = new System.Drawing.Point(717, 37);
		this.Button36.Name = "Button36";
		this.Button36.Size = new System.Drawing.Size(75, 23);
		this.Button36.TabIndex = 44;
		this.Button36.Text = "$_POST";
		this.Button36.UseVisualStyleBackColor = true;
		this.Button33.Location = new System.Drawing.Point(565, 8);
		this.Button33.Name = "Button33";
		this.Button33.Size = new System.Drawing.Size(75, 23);
		this.Button33.TabIndex = 43;
		this.Button33.Text = "historial";
		this.Button33.UseVisualStyleBackColor = true;
		this.Button33.Visible = false;
		this.Button32.Location = new System.Drawing.Point(408, 8);
		this.Button32.Name = "Button32";
		this.Button32.Size = new System.Drawing.Size(75, 23);
		this.Button32.TabIndex = 42;
		this.Button32.Text = "A CD";
		this.Button32.UseVisualStyleBackColor = true;
		this.Button32.Visible = false;
		this.Button27.Location = new System.Drawing.Point(408, 38);
		this.Button27.Name = "Button27";
		this.Button27.Size = new System.Drawing.Size(75, 23);
		this.Button27.TabIndex = 40;
		this.Button27.Text = "Sincro";
		this.Button27.UseVisualStyleBackColor = true;
		this.Button27.Visible = false;
		this.Button28.Location = new System.Drawing.Point(797, 37);
		this.Button28.Name = "Button28";
		this.Button28.Size = new System.Drawing.Size(70, 25);
		this.Button28.TabIndex = 41;
		this.Button28.Text = "Configurar Importacion";
		this.Button28.UseVisualStyleBackColor = true;
		this.Button10.Enabled = false;
		this.Button10.Location = new System.Drawing.Point(489, 38);
		this.Button10.Name = "Button10";
		this.Button10.Size = new System.Drawing.Size(73, 23);
		this.Button10.TabIndex = 35;
		this.Button10.Text = "Canalizador";
		this.Button10.UseVisualStyleBackColor = true;
		this.Button10.Visible = false;
		this.Button8.Enabled = false;
		this.Button8.Location = new System.Drawing.Point(641, 8);
		this.Button8.Name = "Button8";
		this.Button8.Size = new System.Drawing.Size(74, 24);
		this.Button8.TabIndex = 35;
		this.Button8.Text = "distancia";
		this.Button8.UseVisualStyleBackColor = true;
		this.Button8.Visible = false;
		this.Button15.Enabled = false;
		this.Button15.Location = new System.Drawing.Point(641, 37);
		this.Button15.Name = "Button15";
		this.Button15.Size = new System.Drawing.Size(70, 24);
		this.Button15.TabIndex = 37;
		this.Button15.Text = "fuera limites";
		this.Button15.UseVisualStyleBackColor = true;
		this.Button15.Visible = false;
		this.Button14.Enabled = false;
		this.Button14.Location = new System.Drawing.Point(489, 8);
		this.Button14.Name = "Button14";
		this.Button14.Size = new System.Drawing.Size(70, 24);
		this.Button14.TabIndex = 36;
		this.Button14.Text = "Posicionar 0";
		this.Button14.UseVisualStyleBackColor = true;
		this.Button14.Visible = false;
		this.Button30.Image = (System.Drawing.Image)resources.GetObject("Button30.Image");
		this.Button30.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
		this.Button30.Location = new System.Drawing.Point(160, 5);
		this.Button30.Name = "Button30";
		this.Button30.Size = new System.Drawing.Size(70, 57);
		this.Button30.TabIndex = 35;
		this.Button30.Text = "Feriados";
		this.Button30.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
		this.Button30.UseVisualStyleBackColor = true;
		this.tablasbtn.Enabled = false;
		this.tablasbtn.Image = (System.Drawing.Image)resources.GetObject("tablasbtn.Image");
		this.tablasbtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
		this.tablasbtn.Location = new System.Drawing.Point(84, 5);
		this.tablasbtn.Name = "tablasbtn";
		this.tablasbtn.Size = new System.Drawing.Size(70, 57);
		this.tablasbtn.TabIndex = 28;
		this.tablasbtn.Text = "Tablas";
		this.tablasbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
		this.tablasbtn.UseVisualStyleBackColor = true;
		this.Usuariobtn.Enabled = false;
		this.Usuariobtn.Image = (System.Drawing.Image)resources.GetObject("Usuariobtn.Image");
		this.Usuariobtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
		this.Usuariobtn.Location = new System.Drawing.Point(8, 5);
		this.Usuariobtn.Name = "Usuariobtn";
		this.Usuariobtn.Size = new System.Drawing.Size(70, 57);
		this.Usuariobtn.TabIndex = 28;
		this.Usuariobtn.Text = "Usuarios";
		this.Usuariobtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
		this.Usuariobtn.UseVisualStyleBackColor = true;
		this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[2] { this.ToolStripStatusLabel1, this.nombreusuario });
		this.StatusStrip1.Location = new System.Drawing.Point(0, 698);
		this.StatusStrip1.Name = "StatusStrip1";
		this.StatusStrip1.Size = new System.Drawing.Size(1032, 22);
		this.StatusStrip1.TabIndex = 26;
		this.StatusStrip1.Text = "StatusStrip1";
		this.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
		this.ToolStripStatusLabel1.Size = new System.Drawing.Size(69, 17);
		this.ToolStripStatusLabel1.Text = "Bienvenido:";
		this.nombreusuario.Name = "nombreusuario";
		this.nombreusuario.Size = new System.Drawing.Size(47, 17);
		this.nombreusuario.Text = "Usuario";
		this.ComboBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.ComboBox1.FormattingEnabled = true;
		this.ComboBox1.Items.AddRange(new object[3] { "1", "2", "3" });
		this.ComboBox1.Location = new System.Drawing.Point(984, 70);
		this.ComboBox1.Name = "ComboBox1";
		this.ComboBox1.Size = new System.Drawing.Size(39, 21);
		this.ComboBox1.TabIndex = 32;
		this.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.Label1.AutoSize = true;
		this.Label1.Location = new System.Drawing.Point(928, 73);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(50, 13);
		this.Label1.TabIndex = 33;
		this.Label1.Text = "Ventana:";
		this.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.Label2.AutoSize = true;
		this.Label2.Location = new System.Drawing.Point(925, 45);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(45, 13);
		this.Label2.TabIndex = 41;
		this.Label2.Text = "Versión:";
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(1032, 720);
		base.Controls.Add(this.Label2);
		base.Controls.Add(this.Label1);
		base.Controls.Add(this.ComboBox1);
		base.Controls.Add(this.StatusStrip1);
		base.Controls.Add(this.DateTimePicker1);
		base.Controls.Add(this.TabControl1);
		base.Controls.Add(this.Splitter2);
		this.DoubleBuffered = true;
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.IsMdiContainer = true;
		base.Name = "Form1_Inicio";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Hermes 2020";
		base.TransparencyKey = System.Drawing.Color.Transparent;
		base.WindowState = System.Windows.Forms.FormWindowState.Maximized;
		this.TabControl1.ResumeLayout(false);
		this.Inicio.ResumeLayout(false);
		this.Inicio.PerformLayout();
		this.Importación.ResumeLayout(false);
		this.GroupBox1.ResumeLayout(false);
		this.Planificacion.ResumeLayout(false);
		this.Tracking.ResumeLayout(false);
		this.Operaciones.ResumeLayout(false);
		this.Etrans.ResumeLayout(false);
		this.Deposito.ResumeLayout(false);
		this.Transporte.ResumeLayout(false);
		this.Eventuales.ResumeLayout(false);
		this.TabTelas.ResumeLayout(false);
		this.Reportes.ResumeLayout(false);
		this.Administrador.ResumeLayout(false);
		this.Administrador.PerformLayout();
		this.StatusStrip1.ResumeLayout(false);
		this.StatusStrip1.PerformLayout();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
