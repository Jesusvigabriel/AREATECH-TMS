using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using Hermes.My;
using Hermes.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace Hermes;

[DesignerGenerated]
public class Rutas : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ListView2")]
	private ListView _ListView2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ListView3")]
	private ListView _ListView3;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ListView1")]
	private ListView _ListView1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ComboBox1")]
	private ComboBox _ComboBox1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ComboBox2")]
	private ComboBox _ComboBox2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button4")]
	private Button _Button4;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button3")]
	private Button _Button3;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button5")]
	private Button _Button5;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("HojadeRuta")]
	private PrintDocument _HojadeRuta;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("PrintDocument2")]
	private PrintDocument _PrintDocument2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("PrintDocument3")]
	private PrintDocument _PrintDocument3;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Comprobantes")]
	private PrintDocument _Comprobantes;

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
	[AccessedThroughProperty("Button8")]
	private Button _Button8;

	private string fecha1;

	private int hoja;

	private int datohdr;

	private string print_comprobante;

	private string print_cliente;

	private string print_destino;

	private string print_direccion;

	private string print_piso;

	private string print_ofi;

	private string print_bloq;

	private string print_bultos;

	private string print_remitos;

	private string print_observaciones;

	private string print_cp;

	private string print_localidad;

	private string print_zona;

	private string print_qrcode;

	private int print_subCuenta;

	private int print_ventana;

	private string print_chofer;

	private string print_fecha;

	private int compro_retiro;

	private string print_numerochofer;

	private int print_guia;

	private string print_cel;

	private string print_tel;

	private string print_voucher;

	private int dato;

	private int pagina;

	private int dato_r;

	private int bultosTotales;

	[field: AccessedThroughProperty("GroupBox1")]
	internal virtual GroupBox GroupBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ListView ListView2
	{
		[CompilerGenerated]
		get
		{
			return _ListView2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			ColumnClickEventHandler value2 = ListView2_ColumnClick;
			DrawListViewItemEventHandler value3 = ListView2_DrawItem;
			DrawListViewSubItemEventHandler value4 = lv2_DrawSubItem;
			DrawListViewColumnHeaderEventHandler value5 = ListView2_DrawColumnHeader;
			EventHandler value6 = ListView2_SelectedIndexChanged;
			ListView listView = _ListView2;
			if (listView != null)
			{
				listView.ColumnClick -= value2;
				listView.DrawItem -= value3;
				listView.DrawSubItem -= value4;
				listView.DrawColumnHeader -= value5;
				listView.SelectedIndexChanged -= value6;
			}
			_ListView2 = value;
			listView = _ListView2;
			if (listView != null)
			{
				listView.ColumnClick += value2;
				listView.DrawItem += value3;
				listView.DrawSubItem += value4;
				listView.DrawColumnHeader += value5;
				listView.SelectedIndexChanged += value6;
			}
		}
	}

	[field: AccessedThroughProperty("GroupBox2")]
	internal virtual GroupBox GroupBox2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("GroupBox3")]
	internal virtual GroupBox GroupBox3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ListView ListView3
	{
		[CompilerGenerated]
		get
		{
			return _ListView3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			ColumnClickEventHandler value2 = ListView3_ColumnClick;
			EventHandler value3 = ListView3_DoubleClick;
			EventHandler value4 = ListView3_SelectedIndexChanged;
			ListView listView = _ListView3;
			if (listView != null)
			{
				listView.ColumnClick -= value2;
				listView.DoubleClick -= value3;
				listView.SelectedIndexChanged -= value4;
			}
			_ListView3 = value;
			listView = _ListView3;
			if (listView != null)
			{
				listView.ColumnClick += value2;
				listView.DoubleClick += value3;
				listView.SelectedIndexChanged += value4;
			}
		}
	}

	[field: AccessedThroughProperty("GroupBox4")]
	internal virtual GroupBox GroupBox4
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
			EventHandler value2 = ListView1_click;
			DrawListViewItemEventHandler value3 = ListView1_DrawItem;
			DrawListViewSubItemEventHandler value4 = lv1_DrawSubItem;
			DrawListViewColumnHeaderEventHandler value5 = ListView1_DrawColumnHeader;
			EventHandler value6 = ListView1_SelectedIndexChanged;
			ListView listView = _ListView1;
			if (listView != null)
			{
				listView.Click -= value2;
				listView.DrawItem -= value3;
				listView.DrawSubItem -= value4;
				listView.DrawColumnHeader -= value5;
				listView.SelectedIndexChanged -= value6;
			}
			_ListView1 = value;
			listView = _ListView1;
			if (listView != null)
			{
				listView.Click += value2;
				listView.DrawItem += value3;
				listView.DrawSubItem += value4;
				listView.DrawColumnHeader += value5;
				listView.SelectedIndexChanged += value6;
			}
		}
	}

	[field: AccessedThroughProperty("GroupBox6")]
	internal virtual GroupBox GroupBox6
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

	[field: AccessedThroughProperty("Label6")]
	internal virtual Label Label6
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

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
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

	[field: AccessedThroughProperty("TextBox1")]
	internal virtual TextBox TextBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox11")]
	internal virtual TextBox TextBox11
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox10")]
	internal virtual TextBox TextBox10
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox9")]
	internal virtual TextBox TextBox9
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox8")]
	internal virtual TextBox TextBox8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox7")]
	internal virtual TextBox TextBox7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox6")]
	internal virtual TextBox TextBox6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox5")]
	internal virtual TextBox TextBox5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox4")]
	internal virtual TextBox TextBox4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox3")]
	internal virtual TextBox TextBox3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox2")]
	internal virtual TextBox TextBox2
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

	[field: AccessedThroughProperty("Label15")]
	internal virtual Label Label15
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

	[field: AccessedThroughProperty("Label13")]
	internal virtual Label Label13
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label11")]
	internal virtual Label Label11
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

	[field: AccessedThroughProperty("Label9")]
	internal virtual Label Label9
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

	[field: AccessedThroughProperty("Label7")]
	internal virtual Label Label7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ComboBox ComboBox1
	{
		[CompilerGenerated]
		get
		{
			return _ComboBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ComboBox1_SelectedIndexChanged;
			ComboBox comboBox = _ComboBox1;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged -= value2;
			}
			_ComboBox1 = value;
			comboBox = _ComboBox1;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged += value2;
			}
		}
	}

	internal virtual ComboBox ComboBox2
	{
		[CompilerGenerated]
		get
		{
			return _ComboBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ComboBox2_SelectedIndexChanged;
			ComboBox comboBox = _ComboBox2;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged -= value2;
			}
			_ComboBox2 = value;
			comboBox = _ComboBox2;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label24")]
	internal virtual Label Label24
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ColumnHeader1")]
	internal virtual ColumnHeader ColumnHeader1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("GMapControl1")]
	internal virtual GMapControl GMapControl1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CheckBox3")]
	internal virtual CheckBox CheckBox3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label22")]
	internal virtual Label Label22
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label21")]
	internal virtual Label Label21
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label19")]
	internal virtual Label Label19
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

	[field: AccessedThroughProperty("Comprobante")]
	internal virtual ColumnHeader Comprobante
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Cliente")]
	internal virtual ColumnHeader Cliente
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Destino")]
	internal virtual ColumnHeader Destino
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Domicilio")]
	internal virtual ColumnHeader Domicilio
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Diferida")]
	internal virtual ColumnHeader Diferida
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Atraso")]
	internal virtual ColumnHeader Atraso
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Observaciones")]
	internal virtual ColumnHeader Observaciones
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Declarado")]
	internal virtual ColumnHeader Declarado
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Bultos")]
	internal virtual ColumnHeader Bultos
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Kilos")]
	internal virtual ColumnHeader Kilos
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Volumen")]
	internal virtual ColumnHeader Volumen
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Flete")]
	internal virtual ColumnHeader Flete
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CP")]
	internal virtual ColumnHeader CP
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Localidad")]
	internal virtual ColumnHeader Localidad
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Subcuenta")]
	internal virtual ColumnHeader Subcuenta
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Eventual")]
	internal virtual ColumnHeader Eventual
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Remito")]
	internal virtual ColumnHeader Remito
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Adicional")]
	internal virtual ColumnHeader Adicional
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Prioridad")]
	internal virtual ColumnHeader Prioridad
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ColumnHeader2")]
	internal virtual ColumnHeader ColumnHeader2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ColumnHeader3")]
	internal virtual ColumnHeader ColumnHeader3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ColumnHeader4")]
	internal virtual ColumnHeader ColumnHeader4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ColumnHeader5")]
	internal virtual ColumnHeader ColumnHeader5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ColumnHeader6")]
	internal virtual ColumnHeader ColumnHeader6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ColumnHeader7")]
	internal virtual ColumnHeader ColumnHeader7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ColumnHeader8")]
	internal virtual ColumnHeader ColumnHeader8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ColumnHeader9")]
	internal virtual ColumnHeader ColumnHeader9
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ColumnHeader10")]
	internal virtual ColumnHeader ColumnHeader10
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ColumnHeader11")]
	internal virtual ColumnHeader ColumnHeader11
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ColumnHeader12")]
	internal virtual ColumnHeader ColumnHeader12
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ColumnHeader13")]
	internal virtual ColumnHeader ColumnHeader13
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ColumnHeader14")]
	internal virtual ColumnHeader ColumnHeader14
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ColumnHeader15")]
	internal virtual ColumnHeader ColumnHeader15
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ColumnHeader16")]
	internal virtual ColumnHeader ColumnHeader16
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ColumnHeader17")]
	internal virtual ColumnHeader ColumnHeader17
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ColumnHeader18")]
	internal virtual ColumnHeader ColumnHeader18
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ColumnHeader19")]
	internal virtual ColumnHeader ColumnHeader19
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ColumnHeader20")]
	internal virtual ColumnHeader ColumnHeader20
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label20")]
	internal virtual Label Label20
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label17")]
	internal virtual Label Label17
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label18")]
	internal virtual Label Label18
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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

	internal virtual PrintDocument HojadeRuta
	{
		[CompilerGenerated]
		get
		{
			return _HojadeRuta;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			PrintPageEventHandler value2 = HojadeRuta_PrintPage;
			PrintDocument hojadeRuta = _HojadeRuta;
			if (hojadeRuta != null)
			{
				hojadeRuta.PrintPage -= value2;
			}
			_HojadeRuta = value;
			hojadeRuta = _HojadeRuta;
			if (hojadeRuta != null)
			{
				hojadeRuta.PrintPage += value2;
			}
		}
	}

	[field: AccessedThroughProperty("guialbl")]
	internal virtual Label guialbl
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Guia")]
	internal virtual ColumnHeader Guia
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ColumnHeader21")]
	internal virtual ColumnHeader ColumnHeader21
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

	internal virtual PrintDocument PrintDocument3
	{
		[CompilerGenerated]
		get
		{
			return _PrintDocument3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			PrintPageEventHandler value2 = PrintDocument3_PrintPage;
			PrintDocument printDocument = _PrintDocument3;
			if (printDocument != null)
			{
				printDocument.PrintPage -= value2;
			}
			_PrintDocument3 = value;
			printDocument = _PrintDocument3;
			if (printDocument != null)
			{
				printDocument.PrintPage += value2;
			}
		}
	}

	internal virtual PrintDocument Comprobantes
	{
		[CompilerGenerated]
		get
		{
			return _Comprobantes;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			PrintPageEventHandler value2 = Comprobantes_PrintPage;
			PrintDocument comprobantes = _Comprobantes;
			if (comprobantes != null)
			{
				comprobantes.PrintPage -= value2;
			}
			_Comprobantes = value;
			comprobantes = _Comprobantes;
			if (comprobantes != null)
			{
				comprobantes.PrintPage += value2;
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

	public Rutas()
	{
		base.Load += Rutas_Load;
		fecha1 = Strings.Format(MyProject.Forms.Form1_Inicio.DateTimePicker1.Value, "yyyyMMdd");
		hoja = 1;
		datohdr = 0;
		print_comprobante = Conversions.ToString(0);
		print_cliente = string.Empty;
		print_destino = string.Empty;
		print_direccion = string.Empty;
		print_piso = string.Empty;
		print_ofi = string.Empty;
		print_bloq = string.Empty;
		print_bultos = Conversions.ToString(0);
		print_remitos = Conversions.ToString(0);
		print_observaciones = string.Empty;
		print_cp = string.Empty;
		print_localidad = string.Empty;
		print_zona = string.Empty;
		print_qrcode = string.Empty;
		print_subCuenta = 0;
		print_ventana = 0;
		print_chofer = string.Empty;
		print_fecha = string.Empty;
		compro_retiro = 0;
		print_numerochofer = string.Empty;
		print_guia = 0;
		print_cel = string.Empty;
		print_tel = string.Empty;
		print_voucher = string.Empty;
		dato = 0;
		pagina = 0;
		dato_r = 0;
		bultosTotales = 0;
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
		//IL_034a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0354: Expected O, but got Unknown
		this.GroupBox1 = new System.Windows.Forms.GroupBox();
		this.ComboBox1 = new System.Windows.Forms.ComboBox();
		this.TextBox1 = new System.Windows.Forms.TextBox();
		this.ListView2 = new System.Windows.Forms.ListView();
		this.Comprobante = new System.Windows.Forms.ColumnHeader();
		this.Cliente = new System.Windows.Forms.ColumnHeader();
		this.Destino = new System.Windows.Forms.ColumnHeader();
		this.Domicilio = new System.Windows.Forms.ColumnHeader();
		this.Diferida = new System.Windows.Forms.ColumnHeader();
		this.Atraso = new System.Windows.Forms.ColumnHeader();
		this.Observaciones = new System.Windows.Forms.ColumnHeader();
		this.Declarado = new System.Windows.Forms.ColumnHeader();
		this.Bultos = new System.Windows.Forms.ColumnHeader();
		this.Kilos = new System.Windows.Forms.ColumnHeader();
		this.Volumen = new System.Windows.Forms.ColumnHeader();
		this.Flete = new System.Windows.Forms.ColumnHeader();
		this.CP = new System.Windows.Forms.ColumnHeader();
		this.Localidad = new System.Windows.Forms.ColumnHeader();
		this.Subcuenta = new System.Windows.Forms.ColumnHeader();
		this.Eventual = new System.Windows.Forms.ColumnHeader();
		this.Remito = new System.Windows.Forms.ColumnHeader();
		this.Adicional = new System.Windows.Forms.ColumnHeader();
		this.Prioridad = new System.Windows.Forms.ColumnHeader();
		this.Guia = new System.Windows.Forms.ColumnHeader();
		this.Label2 = new System.Windows.Forms.Label();
		this.GroupBox2 = new System.Windows.Forms.GroupBox();
		this.CheckBox3 = new System.Windows.Forms.CheckBox();
		this.TextBox11 = new System.Windows.Forms.TextBox();
		this.TextBox10 = new System.Windows.Forms.TextBox();
		this.TextBox9 = new System.Windows.Forms.TextBox();
		this.Label16 = new System.Windows.Forms.Label();
		this.TextBox8 = new System.Windows.Forms.TextBox();
		this.TextBox7 = new System.Windows.Forms.TextBox();
		this.TextBox6 = new System.Windows.Forms.TextBox();
		this.TextBox5 = new System.Windows.Forms.TextBox();
		this.TextBox4 = new System.Windows.Forms.TextBox();
		this.TextBox3 = new System.Windows.Forms.TextBox();
		this.TextBox2 = new System.Windows.Forms.TextBox();
		this.Button2 = new System.Windows.Forms.Button();
		this.Button1 = new System.Windows.Forms.Button();
		this.Label3 = new System.Windows.Forms.Label();
		this.Label5 = new System.Windows.Forms.Label();
		this.Label6 = new System.Windows.Forms.Label();
		this.Label7 = new System.Windows.Forms.Label();
		this.Label8 = new System.Windows.Forms.Label();
		this.GroupBox3 = new System.Windows.Forms.GroupBox();
		this.ComboBox2 = new System.Windows.Forms.ComboBox();
		this.ListView3 = new System.Windows.Forms.ListView();
		this.ColumnHeader2 = new System.Windows.Forms.ColumnHeader();
		this.ColumnHeader3 = new System.Windows.Forms.ColumnHeader();
		this.ColumnHeader4 = new System.Windows.Forms.ColumnHeader();
		this.ColumnHeader5 = new System.Windows.Forms.ColumnHeader();
		this.ColumnHeader6 = new System.Windows.Forms.ColumnHeader();
		this.ColumnHeader7 = new System.Windows.Forms.ColumnHeader();
		this.ColumnHeader8 = new System.Windows.Forms.ColumnHeader();
		this.ColumnHeader9 = new System.Windows.Forms.ColumnHeader();
		this.ColumnHeader10 = new System.Windows.Forms.ColumnHeader();
		this.ColumnHeader11 = new System.Windows.Forms.ColumnHeader();
		this.ColumnHeader12 = new System.Windows.Forms.ColumnHeader();
		this.ColumnHeader13 = new System.Windows.Forms.ColumnHeader();
		this.ColumnHeader14 = new System.Windows.Forms.ColumnHeader();
		this.ColumnHeader15 = new System.Windows.Forms.ColumnHeader();
		this.ColumnHeader16 = new System.Windows.Forms.ColumnHeader();
		this.ColumnHeader17 = new System.Windows.Forms.ColumnHeader();
		this.ColumnHeader18 = new System.Windows.Forms.ColumnHeader();
		this.ColumnHeader19 = new System.Windows.Forms.ColumnHeader();
		this.ColumnHeader20 = new System.Windows.Forms.ColumnHeader();
		this.ColumnHeader21 = new System.Windows.Forms.ColumnHeader();
		this.Label24 = new System.Windows.Forms.Label();
		this.GroupBox4 = new System.Windows.Forms.GroupBox();
		this.GMapControl1 = new GMapControl();
		this.GroupBox5 = new System.Windows.Forms.GroupBox();
		this.ListView1 = new System.Windows.Forms.ListView();
		this.ColumnHeader1 = new System.Windows.Forms.ColumnHeader();
		this.Label1 = new System.Windows.Forms.Label();
		this.GroupBox6 = new System.Windows.Forms.GroupBox();
		this.Button7 = new System.Windows.Forms.Button();
		this.Button6 = new System.Windows.Forms.Button();
		this.CheckBox1 = new System.Windows.Forms.CheckBox();
		this.guialbl = new System.Windows.Forms.Label();
		this.Button5 = new System.Windows.Forms.Button();
		this.Button4 = new System.Windows.Forms.Button();
		this.Button3 = new System.Windows.Forms.Button();
		this.Label18 = new System.Windows.Forms.Label();
		this.Label20 = new System.Windows.Forms.Label();
		this.Label17 = new System.Windows.Forms.Label();
		this.Label12 = new System.Windows.Forms.Label();
		this.Label22 = new System.Windows.Forms.Label();
		this.Label21 = new System.Windows.Forms.Label();
		this.Label19 = new System.Windows.Forms.Label();
		this.Label14 = new System.Windows.Forms.Label();
		this.Label15 = new System.Windows.Forms.Label();
		this.Label13 = new System.Windows.Forms.Label();
		this.Label10 = new System.Windows.Forms.Label();
		this.Label11 = new System.Windows.Forms.Label();
		this.Label9 = new System.Windows.Forms.Label();
		this.Label4 = new System.Windows.Forms.Label();
		this.HojadeRuta = new System.Drawing.Printing.PrintDocument();
		this.PrintDocument2 = new System.Drawing.Printing.PrintDocument();
		this.PrintDocument3 = new System.Drawing.Printing.PrintDocument();
		this.Comprobantes = new System.Drawing.Printing.PrintDocument();
		this.Button8 = new System.Windows.Forms.Button();
		this.GroupBox1.SuspendLayout();
		this.GroupBox2.SuspendLayout();
		this.GroupBox3.SuspendLayout();
		this.GroupBox4.SuspendLayout();
		this.GroupBox5.SuspendLayout();
		this.GroupBox6.SuspendLayout();
		base.SuspendLayout();
		this.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.GroupBox1.Controls.Add(this.ComboBox1);
		this.GroupBox1.Controls.Add(this.TextBox1);
		this.GroupBox1.Controls.Add(this.ListView2);
		this.GroupBox1.Controls.Add(this.Label2);
		this.GroupBox1.Location = new System.Drawing.Point(96, 12);
		this.GroupBox1.Name = "GroupBox1";
		this.GroupBox1.Size = new System.Drawing.Size(810, 200);
		this.GroupBox1.TabIndex = 0;
		this.GroupBox1.TabStop = false;
		this.GroupBox1.Text = "Vehiculo";
		this.ComboBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.ComboBox1.FormattingEnabled = true;
		this.ComboBox1.Location = new System.Drawing.Point(683, 11);
		this.ComboBox1.Name = "ComboBox1";
		this.ComboBox1.Size = new System.Drawing.Size(121, 21);
		this.ComboBox1.TabIndex = 2;
		this.TextBox1.Location = new System.Drawing.Point(6, 16);
		this.TextBox1.Name = "TextBox1";
		this.TextBox1.Size = new System.Drawing.Size(161, 20);
		this.TextBox1.TabIndex = 1;
		this.ListView2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.ListView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[20]
		{
			this.Comprobante, this.Cliente, this.Destino, this.Domicilio, this.Diferida, this.Atraso, this.Observaciones, this.Declarado, this.Bultos, this.Kilos,
			this.Volumen, this.Flete, this.CP, this.Localidad, this.Subcuenta, this.Eventual, this.Remito, this.Adicional, this.Prioridad, this.Guia
		});
		this.ListView2.FullRowSelect = true;
		this.ListView2.GridLines = true;
		this.ListView2.Location = new System.Drawing.Point(6, 42);
		this.ListView2.Name = "ListView2";
		this.ListView2.OwnerDraw = true;
		this.ListView2.Size = new System.Drawing.Size(798, 152);
		this.ListView2.TabIndex = 0;
		this.ListView2.UseCompatibleStateImageBehavior = false;
		this.ListView2.View = System.Windows.Forms.View.Details;
		this.Comprobante.Text = "Comprobante";
		this.Comprobante.Width = 90;
		this.Cliente.Text = "Cliente";
		this.Cliente.Width = 130;
		this.Destino.Text = "Destino";
		this.Destino.Width = 150;
		this.Domicilio.Text = "Domicilio";
		this.Domicilio.Width = 150;
		this.Diferida.Text = "Diferida";
		this.Diferida.Width = 100;
		this.Atraso.Text = "Atraso";
		this.Observaciones.Text = "Observaciones";
		this.Observaciones.Width = 160;
		this.Declarado.Text = "Declarado";
		this.Declarado.Width = 70;
		this.Bultos.Text = "Bultos";
		this.Bultos.Width = 50;
		this.Kilos.Text = "Kilos";
		this.Kilos.Width = 70;
		this.Volumen.Text = "Volumen";
		this.Volumen.Width = 50;
		this.Flete.Text = "Flete";
		this.Flete.Width = 70;
		this.CP.Text = "CP";
		this.CP.Width = 40;
		this.Localidad.Text = "Localidad";
		this.Localidad.Width = 90;
		this.Subcuenta.Text = "Sub";
		this.Eventual.Text = "Eventual";
		this.Eventual.Width = 50;
		this.Remito.Text = "Remito";
		this.Remito.Width = 50;
		this.Adicional.Text = "Adicional";
		this.Adicional.Width = 50;
		this.Prioridad.Text = "Prioridad";
		this.Prioridad.Width = 50;
		this.Guia.Text = "Guia Hermes";
		this.Guia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		this.Label2.AutoSize = true;
		this.Label2.Location = new System.Drawing.Point(173, 19);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(39, 13);
		this.Label2.TabIndex = 3;
		this.Label2.Text = "Label2";
		this.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.GroupBox2.Controls.Add(this.CheckBox3);
		this.GroupBox2.Controls.Add(this.TextBox11);
		this.GroupBox2.Controls.Add(this.TextBox10);
		this.GroupBox2.Controls.Add(this.TextBox9);
		this.GroupBox2.Controls.Add(this.Label16);
		this.GroupBox2.Controls.Add(this.TextBox8);
		this.GroupBox2.Controls.Add(this.TextBox7);
		this.GroupBox2.Controls.Add(this.TextBox6);
		this.GroupBox2.Controls.Add(this.TextBox5);
		this.GroupBox2.Controls.Add(this.TextBox4);
		this.GroupBox2.Controls.Add(this.TextBox3);
		this.GroupBox2.Controls.Add(this.TextBox2);
		this.GroupBox2.Controls.Add(this.Button2);
		this.GroupBox2.Controls.Add(this.Button1);
		this.GroupBox2.Controls.Add(this.Label3);
		this.GroupBox2.Controls.Add(this.Label5);
		this.GroupBox2.Controls.Add(this.Label6);
		this.GroupBox2.Controls.Add(this.Label7);
		this.GroupBox2.Controls.Add(this.Label8);
		this.GroupBox2.Location = new System.Drawing.Point(96, 212);
		this.GroupBox2.Name = "GroupBox2";
		this.GroupBox2.Size = new System.Drawing.Size(810, 86);
		this.GroupBox2.TabIndex = 1;
		this.GroupBox2.TabStop = false;
		this.GroupBox2.Text = "Totales:";
		this.CheckBox3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.CheckBox3.AutoSize = true;
		this.CheckBox3.Location = new System.Drawing.Point(634, 55);
		this.CheckBox3.Name = "CheckBox3";
		this.CheckBox3.Size = new System.Drawing.Size(55, 17);
		this.CheckBox3.TabIndex = 20;
		this.CheckBox3.Text = "Grupo";
		this.CheckBox3.UseVisualStyleBackColor = true;
		this.TextBox11.Location = new System.Drawing.Point(430, 60);
		this.TextBox11.Name = "TextBox11";
		this.TextBox11.Size = new System.Drawing.Size(100, 20);
		this.TextBox11.TabIndex = 11;
		this.TextBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		this.TextBox10.Location = new System.Drawing.Point(324, 60);
		this.TextBox10.Name = "TextBox10";
		this.TextBox10.Size = new System.Drawing.Size(100, 20);
		this.TextBox10.TabIndex = 10;
		this.TextBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		this.TextBox9.Location = new System.Drawing.Point(218, 60);
		this.TextBox9.Name = "TextBox9";
		this.TextBox9.Size = new System.Drawing.Size(100, 20);
		this.TextBox9.TabIndex = 9;
		this.TextBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		this.Label16.AutoSize = true;
		this.Label16.Location = new System.Drawing.Point(547, 37);
		this.Label16.Name = "Label16";
		this.Label16.Size = new System.Drawing.Size(45, 13);
		this.Label16.TabIndex = 17;
		this.Label16.Text = "Label16";
		this.TextBox8.Location = new System.Drawing.Point(112, 60);
		this.TextBox8.Name = "TextBox8";
		this.TextBox8.Size = new System.Drawing.Size(100, 20);
		this.TextBox8.TabIndex = 8;
		this.TextBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		this.TextBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.TextBox7.ForeColor = System.Drawing.Color.Red;
		this.TextBox7.Location = new System.Drawing.Point(6, 60);
		this.TextBox7.Name = "TextBox7";
		this.TextBox7.Size = new System.Drawing.Size(100, 20);
		this.TextBox7.TabIndex = 7;
		this.TextBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.TextBox6.Location = new System.Drawing.Point(430, 34);
		this.TextBox6.Name = "TextBox6";
		this.TextBox6.Size = new System.Drawing.Size(100, 20);
		this.TextBox6.TabIndex = 6;
		this.TextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		this.TextBox5.Location = new System.Drawing.Point(324, 34);
		this.TextBox5.Name = "TextBox5";
		this.TextBox5.Size = new System.Drawing.Size(100, 20);
		this.TextBox5.TabIndex = 5;
		this.TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		this.TextBox4.Location = new System.Drawing.Point(218, 34);
		this.TextBox4.Name = "TextBox4";
		this.TextBox4.Size = new System.Drawing.Size(100, 20);
		this.TextBox4.TabIndex = 4;
		this.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		this.TextBox3.Location = new System.Drawing.Point(112, 34);
		this.TextBox3.Name = "TextBox3";
		this.TextBox3.Size = new System.Drawing.Size(100, 20);
		this.TextBox3.TabIndex = 3;
		this.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		this.TextBox2.Location = new System.Drawing.Point(6, 34);
		this.TextBox2.Name = "TextBox2";
		this.TextBox2.Size = new System.Drawing.Size(100, 20);
		this.TextBox2.TabIndex = 2;
		this.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		this.Button2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.Button2.Location = new System.Drawing.Point(695, 51);
		this.Button2.Name = "Button2";
		this.Button2.Size = new System.Drawing.Size(109, 23);
		this.Button2.TabIndex = 1;
		this.Button2.Text = "Subir";
		this.Button2.UseVisualStyleBackColor = true;
		this.Button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.Button1.Location = new System.Drawing.Point(695, 16);
		this.Button1.Name = "Button1";
		this.Button1.Size = new System.Drawing.Size(109, 23);
		this.Button1.TabIndex = 0;
		this.Button1.Text = "Bajar";
		this.Button1.UseVisualStyleBackColor = true;
		this.Label3.AutoSize = true;
		this.Label3.Location = new System.Drawing.Point(6, 18);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(86, 13);
		this.Label3.TabIndex = 4;
		this.Label3.Text = "Valor Declarado:";
		this.Label5.AutoSize = true;
		this.Label5.Location = new System.Drawing.Point(112, 18);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(39, 13);
		this.Label5.TabIndex = 6;
		this.Label5.Text = "Bultos:";
		this.Label6.AutoSize = true;
		this.Label6.Location = new System.Drawing.Point(215, 18);
		this.Label6.Name = "Label6";
		this.Label6.Size = new System.Drawing.Size(32, 13);
		this.Label6.TabIndex = 7;
		this.Label6.Text = "Kilos:";
		this.Label7.AutoSize = true;
		this.Label7.Location = new System.Drawing.Point(321, 18);
		this.Label7.Name = "Label7";
		this.Label7.Size = new System.Drawing.Size(51, 13);
		this.Label7.TabIndex = 8;
		this.Label7.Text = "Volumen:";
		this.Label8.AutoSize = true;
		this.Label8.Location = new System.Drawing.Point(427, 18);
		this.Label8.Name = "Label8";
		this.Label8.Size = new System.Drawing.Size(33, 13);
		this.Label8.TabIndex = 9;
		this.Label8.Text = "Flete:";
		this.GroupBox3.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.GroupBox3.Controls.Add(this.ComboBox2);
		this.GroupBox3.Controls.Add(this.ListView3);
		this.GroupBox3.Location = new System.Drawing.Point(96, 298);
		this.GroupBox3.Name = "GroupBox3";
		this.GroupBox3.Size = new System.Drawing.Size(810, 246);
		this.GroupBox3.TabIndex = 2;
		this.GroupBox3.TabStop = false;
		this.GroupBox3.Text = "Zonas";
		this.ComboBox2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.ComboBox2.FormattingEnabled = true;
		this.ComboBox2.Location = new System.Drawing.Point(683, 16);
		this.ComboBox2.Name = "ComboBox2";
		this.ComboBox2.Size = new System.Drawing.Size(121, 21);
		this.ComboBox2.TabIndex = 1;
		this.ListView3.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.ListView3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[20]
		{
			this.ColumnHeader2, this.ColumnHeader3, this.ColumnHeader4, this.ColumnHeader5, this.ColumnHeader6, this.ColumnHeader7, this.ColumnHeader8, this.ColumnHeader9, this.ColumnHeader10, this.ColumnHeader11,
			this.ColumnHeader12, this.ColumnHeader13, this.ColumnHeader14, this.ColumnHeader15, this.ColumnHeader16, this.ColumnHeader17, this.ColumnHeader18, this.ColumnHeader19, this.ColumnHeader20, this.ColumnHeader21
		});
		this.ListView3.GridLines = true;
		this.ListView3.Location = new System.Drawing.Point(6, 43);
		this.ListView3.Name = "ListView3";
		this.ListView3.Size = new System.Drawing.Size(798, 197);
		this.ListView3.TabIndex = 0;
		this.ListView3.UseCompatibleStateImageBehavior = false;
		this.ListView3.View = System.Windows.Forms.View.Details;
		this.ColumnHeader2.Text = "Comprobante";
		this.ColumnHeader2.Width = 90;
		this.ColumnHeader3.Text = "Cliente";
		this.ColumnHeader3.Width = 130;
		this.ColumnHeader4.Text = "Destino";
		this.ColumnHeader4.Width = 150;
		this.ColumnHeader5.Text = "Domicilio";
		this.ColumnHeader5.Width = 150;
		this.ColumnHeader6.Text = "Diferida";
		this.ColumnHeader6.Width = 100;
		this.ColumnHeader7.Text = "Atraso";
		this.ColumnHeader8.Text = "Observaciones";
		this.ColumnHeader8.Width = 160;
		this.ColumnHeader9.Text = "Declarado";
		this.ColumnHeader9.Width = 70;
		this.ColumnHeader10.Text = "Bultos";
		this.ColumnHeader10.Width = 50;
		this.ColumnHeader11.Text = "Kilos";
		this.ColumnHeader11.Width = 70;
		this.ColumnHeader12.Text = "Volumen";
		this.ColumnHeader13.Text = "Flete";
		this.ColumnHeader13.Width = 70;
		this.ColumnHeader14.Text = "CP";
		this.ColumnHeader14.Width = 40;
		this.ColumnHeader15.Text = "Localidad";
		this.ColumnHeader15.Width = 90;
		this.ColumnHeader16.Text = "Sub";
		this.ColumnHeader16.Width = 30;
		this.ColumnHeader17.Text = "Eventual";
		this.ColumnHeader17.Width = 50;
		this.ColumnHeader18.Text = "Remito";
		this.ColumnHeader19.Text = "Adicional";
		this.ColumnHeader20.Text = "Prioridad";
		this.ColumnHeader21.Text = "Guia Hermes";
		this.ColumnHeader21.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		this.Label24.AutoSize = true;
		this.Label24.Location = new System.Drawing.Point(62, 86);
		this.Label24.Name = "Label24";
		this.Label24.Size = new System.Drawing.Size(45, 13);
		this.Label24.TabIndex = 2;
		this.Label24.Text = "Label24";
		this.GroupBox4.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		this.GroupBox4.Controls.Add((System.Windows.Forms.Control)(object)this.GMapControl1);
		this.GroupBox4.Location = new System.Drawing.Point(912, 12);
		this.GroupBox4.Name = "GroupBox4";
		this.GroupBox4.Size = new System.Drawing.Size(354, 286);
		this.GroupBox4.TabIndex = 3;
		this.GroupBox4.TabStop = false;
		this.GroupBox4.Text = "Mapa";
		((System.Windows.Forms.Control)(object)this.GMapControl1).Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		((System.Windows.Forms.UserControl)(object)this.GMapControl1).AutoSize = true;
		this.GMapControl1.Bearing = 0f;
		this.GMapControl1.CanDragMap = true;
		this.GMapControl1.GrayScaleMode = false;
		this.GMapControl1.LevelsKeepInMemmory = 5;
		((System.Windows.Forms.Control)(object)this.GMapControl1).Location = new System.Drawing.Point(6, 11);
		this.GMapControl1.MarkersEnabled = true;
		this.GMapControl1.MaxZoom = 2;
		this.GMapControl1.MinZoom = 2;
		this.GMapControl1.MouseWheelZoomType = (MouseWheelZoomType)0;
		((System.Windows.Forms.Control)(object)this.GMapControl1).Name = "GMapControl1";
		this.GMapControl1.NegativeMode = false;
		this.GMapControl1.PolygonsEnabled = true;
		this.GMapControl1.RetryLoadTile = 0;
		this.GMapControl1.RoutesEnabled = true;
		this.GMapControl1.ShowTileGridLines = false;
		((System.Windows.Forms.Control)(object)this.GMapControl1).Size = new System.Drawing.Size(342, 269);
		((System.Windows.Forms.Control)(object)this.GMapControl1).TabIndex = 0;
		this.GMapControl1.Zoom = 0.0;
		this.GroupBox5.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.GroupBox5.Controls.Add(this.ListView1);
		this.GroupBox5.Controls.Add(this.Label1);
		this.GroupBox5.Location = new System.Drawing.Point(12, 12);
		this.GroupBox5.Name = "GroupBox5";
		this.GroupBox5.Size = new System.Drawing.Size(78, 532);
		this.GroupBox5.TabIndex = 4;
		this.GroupBox5.TabStop = false;
		this.GroupBox5.Text = "Disponibles";
		this.ListView1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.ListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[1] { this.ColumnHeader1 });
		this.ListView1.ForeColor = System.Drawing.Color.Blue;
		this.ListView1.GridLines = true;
		this.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
		this.ListView1.Location = new System.Drawing.Point(8, 42);
		this.ListView1.Name = "ListView1";
		this.ListView1.OwnerDraw = true;
		this.ListView1.Size = new System.Drawing.Size(62, 484);
		this.ListView1.TabIndex = 0;
		this.ListView1.UseCompatibleStateImageBehavior = false;
		this.ListView1.View = System.Windows.Forms.View.Details;
		this.ColumnHeader1.Text = "Vehiculos";
		this.Label1.AutoSize = true;
		this.Label1.Location = new System.Drawing.Point(16, 23);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(39, 13);
		this.Label1.TabIndex = 2;
		this.Label1.Text = "Label1";
		this.GroupBox6.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		this.GroupBox6.Controls.Add(this.Button8);
		this.GroupBox6.Controls.Add(this.Button7);
		this.GroupBox6.Controls.Add(this.Button6);
		this.GroupBox6.Controls.Add(this.CheckBox1);
		this.GroupBox6.Controls.Add(this.guialbl);
		this.GroupBox6.Controls.Add(this.Button5);
		this.GroupBox6.Controls.Add(this.Button4);
		this.GroupBox6.Controls.Add(this.Button3);
		this.GroupBox6.Controls.Add(this.Label18);
		this.GroupBox6.Controls.Add(this.Label20);
		this.GroupBox6.Controls.Add(this.Label17);
		this.GroupBox6.Controls.Add(this.Label12);
		this.GroupBox6.Controls.Add(this.Label22);
		this.GroupBox6.Controls.Add(this.Label21);
		this.GroupBox6.Controls.Add(this.Label19);
		this.GroupBox6.Controls.Add(this.Label24);
		this.GroupBox6.Controls.Add(this.Label14);
		this.GroupBox6.Controls.Add(this.Label15);
		this.GroupBox6.Controls.Add(this.Label13);
		this.GroupBox6.Controls.Add(this.Label10);
		this.GroupBox6.Controls.Add(this.Label11);
		this.GroupBox6.Controls.Add(this.Label9);
		this.GroupBox6.Controls.Add(this.Label4);
		this.GroupBox6.Location = new System.Drawing.Point(912, 304);
		this.GroupBox6.Name = "GroupBox6";
		this.GroupBox6.Size = new System.Drawing.Size(354, 240);
		this.GroupBox6.TabIndex = 5;
		this.GroupBox6.TabStop = false;
		this.GroupBox6.Text = "Datos";
		this.Button7.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		this.Button7.Location = new System.Drawing.Point(239, 99);
		this.Button7.Name = "Button7";
		this.Button7.Size = new System.Drawing.Size(109, 23);
		this.Button7.TabIndex = 34;
		this.Button7.Text = "Exportar";
		this.Button7.UseVisualStyleBackColor = true;
		this.Button6.Location = new System.Drawing.Point(146, 139);
		this.Button6.Name = "Button6";
		this.Button6.Size = new System.Drawing.Size(75, 23);
		this.Button6.TabIndex = 33;
		this.Button6.Text = "Button6";
		this.Button6.UseVisualStyleBackColor = true;
		this.Button6.Visible = false;
		this.CheckBox1.AutoSize = true;
		this.CheckBox1.Location = new System.Drawing.Point(239, 146);
		this.CheckBox1.Name = "CheckBox1";
		this.CheckBox1.Size = new System.Drawing.Size(94, 17);
		this.CheckBox1.TabIndex = 32;
		this.CheckBox1.Text = "Comprobantes";
		this.CheckBox1.UseVisualStyleBackColor = true;
		this.guialbl.AutoSize = true;
		this.guialbl.Location = new System.Drawing.Point(266, 122);
		this.guialbl.Name = "guialbl";
		this.guialbl.Size = new System.Drawing.Size(27, 13);
		this.guialbl.TabIndex = 31;
		this.guialbl.Text = "guia";
		this.guialbl.Visible = false;
		this.Button5.Location = new System.Drawing.Point(239, 14);
		this.Button5.Name = "Button5";
		this.Button5.Size = new System.Drawing.Size(109, 23);
		this.Button5.TabIndex = 30;
		this.Button5.Text = "Imprimir HDR";
		this.Button5.UseVisualStyleBackColor = true;
		this.Button4.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		this.Button4.Location = new System.Drawing.Point(239, 70);
		this.Button4.Name = "Button4";
		this.Button4.Size = new System.Drawing.Size(109, 23);
		this.Button4.TabIndex = 29;
		this.Button4.Text = "Cambiar Chofer";
		this.Button4.UseVisualStyleBackColor = true;
		this.Button3.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		this.Button3.Location = new System.Drawing.Point(239, 41);
		this.Button3.Name = "Button3";
		this.Button3.Size = new System.Drawing.Size(109, 23);
		this.Button3.TabIndex = 28;
		this.Button3.Text = "Bajar Todo";
		this.Button3.UseVisualStyleBackColor = true;
		this.Label18.AutoSize = true;
		this.Label18.Location = new System.Drawing.Point(155, 19);
		this.Label18.Name = "Label18";
		this.Label18.Size = new System.Drawing.Size(45, 13);
		this.Label18.TabIndex = 27;
		this.Label18.Text = "Label18";
		this.Label18.Visible = false;
		this.Label20.AutoSize = true;
		this.Label20.Location = new System.Drawing.Point(62, 63);
		this.Label20.Name = "Label20";
		this.Label20.Size = new System.Drawing.Size(45, 13);
		this.Label20.TabIndex = 26;
		this.Label20.Text = "Label20";
		this.Label17.AutoSize = true;
		this.Label17.Location = new System.Drawing.Point(62, 173);
		this.Label17.Name = "Label17";
		this.Label17.Size = new System.Drawing.Size(45, 13);
		this.Label17.TabIndex = 25;
		this.Label17.Text = "Label17";
		this.Label17.Visible = false;
		this.Label12.AutoSize = true;
		this.Label12.Location = new System.Drawing.Point(62, 122);
		this.Label12.Name = "Label12";
		this.Label12.Size = new System.Drawing.Size(45, 13);
		this.Label12.TabIndex = 24;
		this.Label12.Text = "Label12";
		this.Label12.Visible = false;
		this.Label22.AutoSize = true;
		this.Label22.Location = new System.Drawing.Point(155, 86);
		this.Label22.Name = "Label22";
		this.Label22.Size = new System.Drawing.Size(45, 13);
		this.Label22.TabIndex = 23;
		this.Label22.Text = "Label22";
		this.Label22.Visible = false;
		this.Label21.AutoSize = true;
		this.Label21.Location = new System.Drawing.Point(155, 63);
		this.Label21.Name = "Label21";
		this.Label21.Size = new System.Drawing.Size(45, 13);
		this.Label21.TabIndex = 22;
		this.Label21.Text = "Label21";
		this.Label21.Visible = false;
		this.Label19.AutoSize = true;
		this.Label19.Location = new System.Drawing.Point(155, 41);
		this.Label19.Name = "Label19";
		this.Label19.Size = new System.Drawing.Size(45, 13);
		this.Label19.TabIndex = 21;
		this.Label19.Text = "Label19";
		this.Label19.Visible = false;
		this.Label14.AutoSize = true;
		this.Label14.Location = new System.Drawing.Point(62, 41);
		this.Label14.Name = "Label14";
		this.Label14.Size = new System.Drawing.Size(45, 13);
		this.Label14.TabIndex = 15;
		this.Label14.Text = "Label14";
		this.Label15.AutoSize = true;
		this.Label15.Location = new System.Drawing.Point(62, 146);
		this.Label15.Name = "Label15";
		this.Label15.Size = new System.Drawing.Size(45, 13);
		this.Label15.TabIndex = 16;
		this.Label15.Text = "Label15";
		this.Label15.Visible = false;
		this.Label13.AutoSize = true;
		this.Label13.Location = new System.Drawing.Point(62, 19);
		this.Label13.Name = "Label13";
		this.Label13.Size = new System.Drawing.Size(45, 13);
		this.Label13.TabIndex = 14;
		this.Label13.Text = "Label13";
		this.Label10.AutoSize = true;
		this.Label10.Location = new System.Drawing.Point(8, 41);
		this.Label10.Name = "Label10";
		this.Label10.Size = new System.Drawing.Size(30, 13);
		this.Label10.TabIndex = 11;
		this.Label10.Text = "P.E.:";
		this.Label11.AutoSize = true;
		this.Label11.Location = new System.Drawing.Point(8, 63);
		this.Label11.Name = "Label11";
		this.Label11.Size = new System.Drawing.Size(37, 13);
		this.Label11.TabIndex = 12;
		this.Label11.Text = "Costo:";
		this.Label9.AutoSize = true;
		this.Label9.Location = new System.Drawing.Point(8, 19);
		this.Label9.Name = "Label9";
		this.Label9.Size = new System.Drawing.Size(48, 13);
		this.Label9.TabIndex = 10;
		this.Label9.Text = "Remitos:";
		this.Label4.AutoSize = true;
		this.Label4.Location = new System.Drawing.Point(8, 86);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(53, 13);
		this.Label4.TabIndex = 5;
		this.Label4.Text = "Adicional:";
		this.Button8.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		this.Button8.Location = new System.Drawing.Point(210, 186);
		this.Button8.Name = "Button8";
		this.Button8.Size = new System.Drawing.Size(138, 27);
		this.Button8.TabIndex = 35;
		this.Button8.Text = "Ruteo Experimental";
		this.Button8.UseVisualStyleBackColor = true;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(1278, 556);
		base.Controls.Add(this.GroupBox6);
		base.Controls.Add(this.GroupBox5);
		base.Controls.Add(this.GroupBox4);
		base.Controls.Add(this.GroupBox3);
		base.Controls.Add(this.GroupBox2);
		base.Controls.Add(this.GroupBox1);
		base.Name = "Rutas";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Rutas";
		base.WindowState = System.Windows.Forms.FormWindowState.Maximized;
		this.GroupBox1.ResumeLayout(false);
		this.GroupBox1.PerformLayout();
		this.GroupBox2.ResumeLayout(false);
		this.GroupBox2.PerformLayout();
		this.GroupBox3.ResumeLayout(false);
		this.GroupBox4.ResumeLayout(false);
		this.GroupBox4.PerformLayout();
		this.GroupBox5.ResumeLayout(false);
		this.GroupBox5.PerformLayout();
		this.GroupBox6.ResumeLayout(false);
		this.GroupBox6.PerformLayout();
		base.ResumeLayout(false);
	}

	private void Rutas_Load(object sender, EventArgs e)
	{
		Control.CheckForIllegalCrossThreadCalls = false;
		Label2.Text = "";
		Label13.Text = Conversions.ToString(0);
		Label14.Text = Conversions.ToString(0);
		Label15.Text = Conversions.ToString(0);
		Label16.Text = Conversions.ToString(0);
		Label20.Text = Conversions.ToString(0);
		ListView1.ForeColor = Color.Blue;
		ComboBox1.Text = "Zonas";
		ComboBox2.Text = "Zonas";
		mini_mapa();
	}

	private void Pintar_chofer2()
	{
		if (ListView2.Items.Count == 0)
		{
			ListView1.SelectedItems[0].ForeColor = Color.Blue;
			return;
		}
		ListView1.SelectedItems[0].ForeColor = Color.DarkGreen;
		ListView1.Refresh();
	}

	private void ListView1_click(object sender, EventArgs e)
	{
		Label13.Text = Conversions.ToString(0);
		if (ListView1.SelectedItems.Count <= 0)
		{
			return;
		}
		ComboBox1.Text = "Zonas";
		int index = ListView1.SelectedIndices[0];
		Label2.Text = ListView1.Items[index].Text;
		Label2.Refresh();
		string chofer = ListView1.Items[index].Text;
		ruta_chofer(chofer);
		datos_chofer(chofer);
		sumas(chofer);
		if (ListView2.Items.Count > 0)
		{
			Thread thread = new Thread([SpecialName] () =>
			{
				costo_nuevo();
			});
			thread.Start();
			thread.Join();
			Thread thread2 = new Thread([SpecialName] () =>
			{
				Pintar_chofer2();
			});
			thread2.Start();
			thread2.Join();
			Thread thread3 = new Thread([SpecialName] () =>
			{
				adicionales_n();
			});
			thread3.Start();
			thread3.Join();
			Thread thread4 = new Thread([SpecialName] () =>
			{
				rentabilidad();
			});
			thread4.Start();
			thread4.Join();
			trazar_ruta(chofer);
		}
	}

	private void ruta_chofer(string chofer)
	{
		string sql = ("SELECT Comprobante,Cliente,Destino,Domicilio,Diferida,Atraso,Observaciones,Declarado,Bultos,Kilos,Volumen,Flete,CP,Localidad,Sub,Eventual,Remitos,Adicional,Prioridad,guia FROM Planchada WHERE Chofer=" + chofer + " AND Fecha='" + fecha1 + "' AND Ventana=" + MyProject.Forms.Form1_Inicio.ComboBox1.Text) ?? "";
		Mod_Sentencias.cargar_datos_lv(ListView2, sql, Label13);
		ListView2.Refresh();
	}

	private void datos_chofer(string chofer)
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected O, but got Unknown
		try
		{
			object obj = Mod_Json.datosVehiculoPHP(Conversions.ToInteger(chofer));
			Mod_Json.datos_vehiculo datos_vehiculo = ((obj != null) ? ((Mod_Json.datos_vehiculo)obj) : default(Mod_Json.datos_vehiculo));
			DataTable dataTable = new DataTable("x");
			string text = "select tarifa from flota where numero=" + chofer;
			MySqlDataAdapter val = new MySqlDataAdapter(text, Mod_Sentencias.cnn);
			((DbDataAdapter)(object)val).Fill(dataTable);
			double num = Conversions.ToDouble(dataTable.Rows[0]["tarifa"]);
			double num2 = num + Conversions.ToDouble(datos_vehiculo.V_Tarifa);
			ComboBox1.Text = "Zonas";
			TextBox1.Text = datos_vehiculo.V_Chofer;
			TextBox1.Refresh();
			TextBox8.Text = Conversions.ToString(datos_vehiculo.V_Categoria);
			TextBox8.Refresh();
			TextBox9.Text = Conversions.ToString(Conversions.ToDouble(datos_vehiculo.V_Peso));
			TextBox9.Refresh();
			TextBox10.Text = Conversions.ToString(Conversions.ToDouble(datos_vehiculo.V_Volumen));
			TextBox10.Refresh();
			if (Conversions.ToDouble(MyProject.Forms.Form1_Inicio.ComboBox1.Text) == 1.0)
			{
				TextBox11.Text = Conversions.ToString(Math.Round(num2, 0));
				TextBox11.Refresh();
			}
			else
			{
				TextBox11.Text = Conversions.ToString(Math.Round(num2 * Conversions.ToDouble(datos_vehiculo.V_Otro), 0));
				TextBox11.Refresh();
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ComboBox1.Text = "Zonas";
			TextBox1.Text = Conversions.ToString(0);
			TextBox1.Refresh();
			TextBox8.Text = Conversions.ToString(0);
			TextBox8.Refresh();
			TextBox9.Text = Conversions.ToString(0);
			TextBox9.Refresh();
			TextBox10.Text = Conversions.ToString(0);
			TextBox10.Refresh();
			TextBox11.Text = Conversions.ToString(0);
			ProjectData.ClearProjectError();
		}
	}

	private void sumas(string chofer)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		DataTable dataTable = new DataTable("C");
		string text = "SELECT * FROM configuracion LIMIT 1";
		MySqlDataAdapter val = new MySqlDataAdapter(text, Mod_Sentencias.cnn);
		((DbDataAdapter)(object)val).Fill(dataTable);
		int num = Conversions.ToInteger(dataTable.Rows[0]["custodia"]);
		try
		{
			object obj = Mod_Rutearmodulo.calculos_ruta(chofer);
			Mod_Rutearmodulo.datos_ruta datos_ruta = ((obj != null) ? ((Mod_Rutearmodulo.datos_ruta)obj) : default(Mod_Rutearmodulo.datos_ruta));
			Label13.Text = Conversions.ToString(datos_ruta.Guias);
			Label14.Text = Conversions.ToString(datos_ruta.Puntos);
			TextBox5.Text = Conversions.ToString(datos_ruta.Volumen);
			TextBox6.Text = Conversions.ToString(datos_ruta.Flete);
			TextBox4.Text = Conversions.ToString(datos_ruta.Kilos);
			TextBox2.Text = Conversions.ToString(datos_ruta.Declarado);
			TextBox3.Text = Conversions.ToString(datos_ruta.Bultos);
			if (datos_ruta.Declarado >= (double)num)
			{
				TextBox7.Text = "CUSTODIA";
				TextBox7.Refresh();
			}
			else
			{
				TextBox7.Text = "";
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Label13.Text = Conversions.ToString(0);
			Label14.Text = Conversions.ToString(0);
			TextBox5.Text = Conversions.ToString(0);
			TextBox6.Text = Conversions.ToString(0);
			TextBox4.Text = Conversions.ToString(0);
			TextBox2.Text = Conversions.ToString(0);
			TextBox3.Text = Conversions.ToString(0);
			ProjectData.ClearProjectError();
		}
	}

	private void sumas_zona(int Zona)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		DataTable dataTable = new DataTable("C");
		string text = "SELECT * FROM configuracion LIMIT 1";
		MySqlDataAdapter val = new MySqlDataAdapter(text, Mod_Sentencias.cnn);
		((DbDataAdapter)(object)val).Fill(dataTable);
		int num = Conversions.ToInteger(dataTable.Rows[0]["custodia"]);
		try
		{
			object obj = Mod_Rutearmodulo.calculos_zona(Zona);
			Mod_Rutearmodulo.datos_ruta datos_ruta = ((obj != null) ? ((Mod_Rutearmodulo.datos_ruta)obj) : default(Mod_Rutearmodulo.datos_ruta));
			Label13.Text = Conversions.ToString(datos_ruta.Guias);
			Label14.Text = Conversions.ToString(datos_ruta.Puntos);
			TextBox5.Text = Conversions.ToString(datos_ruta.Volumen);
			TextBox6.Text = Conversions.ToString(datos_ruta.Flete);
			TextBox4.Text = Conversions.ToString(datos_ruta.Kilos);
			TextBox2.Text = Conversions.ToString(datos_ruta.Declarado);
			TextBox3.Text = Conversions.ToString(datos_ruta.Bultos);
			if (datos_ruta.Declarado >= (double)num)
			{
				TextBox7.Text = "CUSTODIA";
				TextBox7.Refresh();
			}
			else
			{
				TextBox7.Text = "";
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Label13.Text = Conversions.ToString(0);
			Label14.Text = Conversions.ToString(0);
			TextBox5.Text = Conversions.ToString(0);
			TextBox6.Text = Conversions.ToString(0);
			TextBox4.Text = Conversions.ToString(0);
			TextBox2.Text = Conversions.ToString(0);
			TextBox3.Text = Conversions.ToString(0);
			ProjectData.ClearProjectError();
		}
	}

	private void costo_nuevo()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		try
		{
			int num = Conversions.ToInteger(TextBox8.Text);
			DataTable dataTable = new DataTable("x");
			string text = ("SELECT Valorbulto,ValorPE FROM Categorias where Categoria= " + Conversions.ToString(num)) ?? "";
			MySqlDataAdapter val = new MySqlDataAdapter(text, Mod_Sentencias.cnn);
			((DbDataAdapter)(object)val).Fill(dataTable);
			double num2 = Conversions.ToDouble(dataTable.Rows[0]["Valorbulto"]);
			double num3 = Conversions.ToDouble(dataTable.Rows[0]["ValorPE"]);
			double value = Conversions.ToDouble(TextBox11.Text) + Conversions.ToDouble(TextBox3.Text) * num2 + Conversions.ToDouble(Label14.Text) * num3;
			Label15.Text = Conversions.ToString(Math.Round(value, 2));
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox(ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void adicionales_n()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		checked
		{
			try
			{
				int num = Conversions.ToInteger(TextBox8.Text);
				DataTable dataTable = new DataTable("x");
				string text = ("SELECT Adicional_1,Adicional_2,Adicional_3,Adicional_4,Adicional_5 FROM Categorias where Categoria= " + Conversions.ToString(num)) ?? "";
				MySqlDataAdapter val = new MySqlDataAdapter(text, Mod_Sentencias.cnn);
				((DbDataAdapter)(object)val).Fill(dataTable);
				double num2 = Conversions.ToDouble(dataTable.Rows[0]["Adicional_1"]);
				double num3 = Conversions.ToDouble(dataTable.Rows[0]["Adicional_2"]);
				double num4 = Conversions.ToDouble(dataTable.Rows[0]["Adicional_3"]);
				double num5 = Conversions.ToDouble(dataTable.Rows[0]["Adicional_4"]);
				double num6 = Conversions.ToDouble(dataTable.Rows[0]["Adicional_5"]);
				int num7 = 0;
				int num8 = ListView2.Items.Count - 1;
				for (int i = 0; i <= num8; i++)
				{
					if (Conversions.ToDouble(ListView2.Items[i].SubItems[17].Text) > (double)num7)
					{
						num7 = Conversions.ToInteger(ListView2.Items[i].SubItems[17].Text);
					}
				}
				if (num7 == 0)
				{
					Label20.Text = Label15.Text;
				}
				if (num7 == 1)
				{
					Label20.Text = Conversions.ToString(Math.Round(Conversions.ToDouble(Label15.Text) * num2, 2));
				}
				if (num7 == 2)
				{
					Label20.Text = Conversions.ToString(Math.Round(Conversions.ToDouble(Label15.Text) * num3, 2));
				}
				if (num7 == 3)
				{
					Label20.Text = Conversions.ToString(Math.Round(Conversions.ToDouble(Label15.Text) * num4, 2));
				}
				if (num7 == 4)
				{
					Label20.Text = Conversions.ToString(Math.Round(Conversions.ToDouble(Label15.Text) * num5, 2));
				}
				if (num7 == 5)
				{
					Label20.Text = Conversions.ToString(Math.Round(Conversions.ToDouble(Label15.Text) * num6, 2));
				}
				Label24.Text = Conversions.ToString(num7);
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

	private void rentabilidad()
	{
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		Label16.Text = "";
		double num = Conversion.Val(Label20.Text);
		double num2 = Conversion.Val(TextBox6.Text);
		int num3 = 0;
		int num4 = 0;
		int num5 = 0;
		int num6 = 0;
		int num7 = 0;
		int num8 = 0;
		int num9 = 0;
		DataTable dataTable = new DataTable("C");
		string text = "SELECT * FROM configuracion LIMIT 1";
		MySqlDataAdapter val = new MySqlDataAdapter(text, Mod_Sentencias.cnn);
		((DbDataAdapter)(object)val).Fill(dataTable);
		num4 = Conversions.ToInteger(dataTable.Rows[0]["excelente"]);
		num5 = Conversions.ToInteger(dataTable.Rows[0]["muybuena"]);
		num6 = Conversions.ToInteger(dataTable.Rows[0]["buena"]);
		num7 = Conversions.ToInteger(dataTable.Rows[0]["razonable"]);
		num8 = Conversions.ToInteger(dataTable.Rows[0]["baja"]);
		num9 = Conversions.ToInteger(dataTable.Rows[0]["ninguna"]);
		num3 = Conversions.ToInteger(dataTable.Rows[0]["custodia"]);
		double num10 = num2 - num;
		double num11 = num10 / num * 100.0;
		if (num11 < (double)num9)
		{
			Label16.Text = "NO SACAR";
			Label16.ForeColor = Color.Red;
		}
		else if (num11 >= (double)num8 && num11 < (double)num7)
		{
			Label16.Text = "BAJA";
			Label16.ForeColor = Color.Orange;
		}
		else if (num11 >= (double)num7 && num11 < (double)num6)
		{
			Label16.Text = "RAZONABLE";
			Label16.ForeColor = Color.Blue;
		}
		else if (num11 >= (double)num6 && num11 < (double)num5)
		{
			Label16.Text = "BUENA";
			Label16.ForeColor = Color.DarkBlue;
		}
		else if (num11 >= (double)num5 && num11 < (double)num4)
		{
			Label16.Text = "MUY BUENA";
			Label16.ForeColor = Color.Green;
		}
		else if (num11 >= (double)num4)
		{
			Label16.Text = "EXCELENTE";
			Label16.ForeColor = Color.DarkGreen;
		}
		else
		{
			Label16.Text = "";
		}
	}

	private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
	{
		checked
		{
			string sql = "SELECT Comprobante,Cliente,Destino,Domicilio,Diferida,Atraso,Observaciones,Declarado,Bultos,Kilos,Volumen,Flete,CP,Localidad,Sub,Eventual,Remitos,Adicional,Prioridad, guia FROM Planchada WHERE Zona= " + Conversions.ToString(ComboBox1.SelectedIndex + 1) + " and Chofer=0 AND Fecha='" + fecha1 + "'";
			Mod_Sentencias.cargar_datos_lv(ListView2, sql, Label13);
			trazar_zona();
			ListView2.Refresh();
			int zona = ComboBox1.SelectedIndex + 1;
			sumas_zona(zona);
			if (ListView1.SelectedItems.Count != 0)
			{
				costo_nuevo();
				adicionales_n();
				rentabilidad();
			}
		}
	}

	private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
	{
		string sql = "SELECT Comprobante,Cliente,Destino,Domicilio,Diferida,Atraso,Observaciones,Declarado,Bultos,Kilos,Volumen,Flete,CP,Localidad,Sub,Eventual,Remitos,Adicional,Prioridad, guia FROM Planchada where zona= " + Conversions.ToString(checked(ComboBox2.SelectedIndex + 1)) + " and chofer=0 AND Fecha='" + fecha1 + "'";
		Mod_Sentencias.cargar_datos_lv(ListView3, sql, Label22);
		ListView3.Refresh();
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(ComboBox2.Text, "Zonas", TextCompare: true) == 0)
		{
			Interaction.MsgBox("Selecciona una Zona");
		}
		else if (Operators.CompareString(ComboBox1.Text, "Zonas", TextCompare: true) == 0)
		{
			Bajar_item();
		}
		else
		{
			Interaction.MsgBox("No puedes hacer eso");
		}
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(TextBox1.Text, "", TextCompare: true) == 0)
		{
			Interaction.MsgBox("Selecciona una Zona");
		}
		else if (Operators.CompareString(ComboBox1.Text, "Zonas", TextCompare: true) == 0)
		{
			if (!CheckBox3.Checked)
			{
				subir_item();
			}
			else
			{
				subir_grupo();
			}
		}
		else
		{
			Interaction.MsgBox("No puedes hacer eso");
		}
	}

	private void Bajar_item()
	{
		if (ListView2.SelectedItems.Count > 0)
		{
			string chofer = Label2.Text;
			int index = ListView2.SelectedIndices[0];
			string sQL = "UPDATE Planchada SET Chofer=0, Estado='En Planchada', Ventana=0 WHERE Guia= '" + guialbl.Text + "'";
			Mod_ConeccionBD.BD_Sentencia(sQL);
			string text = "SELECT Comprobante,Cliente,Destino,Domicilio,Diferida,Atraso,Observaciones,Declarado,Bultos,Kilos,Volumen,Flete,CP,Localidad,Sub,Eventual,Remitos,Adicional,Prioridad, guia FROM Planchada where zona= " + Conversions.ToString(checked(ComboBox2.SelectedIndex + 1)) + " and chofer=0 AND Fecha='" + fecha1 + "'";
			ListView2.Items[index].Remove();
			ListView2.Refresh();
			ListView3.Refresh();
			sumas(chofer);
			Thread thread = new Thread([SpecialName] () =>
			{
				costo_nuevo();
			});
			thread.Start();
			thread.Join();
			Thread thread2 = new Thread([SpecialName] () =>
			{
				Pintar_chofer2();
			});
			thread2.Start();
			thread2.Join();
			Thread thread3 = new Thread([SpecialName] () =>
			{
				adicionales_n();
			});
			thread3.Start();
			thread3.Join();
			Thread thread4 = new Thread([SpecialName] () =>
			{
				rentabilidad();
			});
			thread4.Start();
			thread4.Join();
			trazar_ruta(chofer);
		}
	}

	private void subir_item()
	{
		if (ListView3.SelectedItems.Count > 0)
		{
			string text = Label2.Text;
			int index = ListView3.SelectedIndices[0];
			string sQL = "UPDATE Planchada SET Chofer=" + text + ", Estado='Ruteado', Ventana=" + MyProject.Forms.Form1_Inicio.ComboBox1.Text + " WHERE  Guia= '" + guialbl.Text + "'";
			Mod_ConeccionBD.BD_Sentencia(sQL);
			string sql = ("SELECT Comprobante,Cliente,Destino,Domicilio,Diferida,Atraso,Observaciones,Declarado,Bultos,Kilos,Volumen,Flete,CP,Localidad,Sub,Eventual,Remitos,Adicional,Prioridad,guia FROM Planchada WHERE Chofer=" + Label2.Text + " AND Fecha='" + fecha1 + "' AND Ventana=" + MyProject.Forms.Form1_Inicio.ComboBox1.Text) ?? "";
			Mod_Sentencias.cargar_datos_lv(ListView2, sql, Label13);
			ListView2.Refresh();
			ListView3.Items[index].Remove();
			ListView2.Refresh();
			ListView3.Refresh();
			sumas(text);
			Thread thread = new Thread([SpecialName] () =>
			{
				costo_nuevo();
			});
			thread.Start();
			thread.Join();
			Thread thread2 = new Thread([SpecialName] () =>
			{
				Pintar_chofer2();
			});
			thread2.Start();
			thread2.Join();
			Thread thread3 = new Thread([SpecialName] () =>
			{
				adicionales_n();
			});
			thread3.Start();
			thread3.Join();
			Thread thread4 = new Thread([SpecialName] () =>
			{
				rentabilidad();
			});
			thread4.Start();
			thread4.Join();
			trazar_ruta(text);
		}
	}

	private void subir_grupo()
	{
		if (Operators.CompareString(Label17.Text, "0", TextCompare: true) != 0 && ListView3.SelectedItems.Count > 0)
		{
			int index = ListView3.SelectedIndices[0];
			Label17.Text = ListView3.Items[index].SubItems[15].Text;
			string chofer = Label2.Text;
			string sQL = "UPDATE Planchada SET Chofer=" + Label2.Text + ", Estado='Ruteado', Ventana=" + MyProject.Forms.Form1_Inicio.ComboBox1.Text + " WHERE Eventual= " + Label17.Text + " and Chofer=0 AND Fecha='" + fecha1 + "' AND Ventana=0";
			Mod_ConeccionBD.BD_Sentencia(sQL);
			string sql = "SELECT Comprobante,Cliente,Destino,Domicilio,Diferida,Atraso,Observaciones,Declarado,Bultos,Kilos,Volumen,Flete,CP,Localidad,Sub,Eventual,Remitos,Adicional,Prioridad, guia FROM Planchada where zona= " + Conversions.ToString(checked(ComboBox2.SelectedIndex + 1)) + " and chofer=0 AND Fecha='" + fecha1 + "' ";
			Mod_Sentencias.cargar_datos_lv(ListView3, sql, Label13);
			string sql2 = ("SELECT DISTINCT Destino FROM Planchada where Chofer= " + Label2.Text + " AND Fecha='" + fecha1 + "' AND Ventana=" + MyProject.Forms.Form1_Inicio.ComboBox1.Text) ?? "";
			Mod_Sentencias.contar_items(sql2, Label14);
			datos_chofer(chofer);
			ruta_chofer(chofer);
			trazar_ruta(chofer);
			ListView2.Refresh();
			ListView3.Refresh();
			sumas(chofer);
			costo_nuevo();
			Pintar_chofer2();
			adicionales_n();
			rentabilidad();
			trazar_ruta(chofer);
			CheckBox3.Checked = false;
		}
	}

	private void Button3_Click(object sender, EventArgs e)
	{
	}

	private void mini_mapa()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected O, but got Unknown
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Expected O, but got Unknown
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Expected O, but got Unknown
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Expected O, but got Unknown
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		GMapControl1.Manager.Mode = (AccessMode)1;
		GMapControl1.MapProvider = (GMapProvider)(object)GMapProviders.OpenStreetMap;
		GMapControl1.Position = new PointLatLng(Conversions.ToDouble("-34,8414045305668"), Conversions.ToDouble("-58,412783459045"));
		GMapControl1.MinZoom = 1;
		GMapControl1.MaxZoom = 19;
		GMapControl1.Zoom = 11.0;
		GMapControl1.MarkersEnabled = true;
		GMapProvider.Language = (LanguageType)11;
		Cursor.Current = Cursors.WaitCursor;
		PointLatLng position = GMapControl1.Position;
		double lat = ((PointLatLng)(ref position)).Lat;
		position = GMapControl1.Position;
		PointLatLng val = default(PointLatLng);
		((PointLatLng)(ref val))._002Ector(lat, ((PointLatLng)(ref position)).Lng);
		GMapMarkerGoogleGreen item = new GMapMarkerGoogleGreen(val);
		GMapOverlay val2 = new GMapOverlay(GMapControl1, "current");
		((Collection<GMapMarker>)(object)val2.Markers).Add((GMapMarker)(object)item);
		((Collection<GMapOverlay>)(object)GMapControl1.Overlays).Add(val2);
		Cursor.Current = Cursors.Default;
		ResumeLayout(performLayout: true);
		GMapOverlay item2 = new GMapOverlay(GMapControl1, "objects");
		((Collection<GMapOverlay>)(object)GMapControl1.Overlays).Add(item2);
		GMapMarkerGoogleGreen val3 = new GMapMarkerGoogleGreen(GMapControl1.Position);
		((GMapMarker)val3).Size = new Size(0, 0);
		((GMapMarker)val3).ToolTipText = "Area 54 S.A.";
		((GMapMarker)val3).ToolTipMode = (MarkerTooltipMode)2;
		((Collection<GMapMarker>)(object)val2.Markers).Add((GMapMarker)(object)val3);
		GMapControl1.DragButton = MouseButtons.Left;
		GMapControl1.Refresh();
	}

	private void trazar_ruta(string chofer)
	{
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Expected O, but got Unknown
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Expected O, but got Unknown
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		DataTable dataTable = new DataTable("x");
		checked
		{
			try
			{
				string text = ("select comprobante,latitud, longitud from Planchada where Chofer= " + chofer + " AND Fecha='" + fecha1 + "' AND Ventana=" + MyProject.Forms.Form1_Inicio.ComboBox1.Text) ?? "";
				MySqlDataAdapter val = new MySqlDataAdapter(text, Mod_Sentencias.cnn);
				((DbDataAdapter)(object)val).Fill(dataTable);
				if (dataTable.Rows.Count <= 0)
				{
					return;
				}
				GMapControl1.Manager.Mode = (AccessMode)1;
				GMapControl1.MapProvider = (GMapProvider)(object)GMapProviders.OpenStreetMap;
				GMapControl1.MinZoom = 1;
				GMapControl1.MaxZoom = 19;
				GMapControl1.Zoom = 13.0;
				GMapControl1.MarkersEnabled = true;
				GMapProvider.Language = (LanguageType)11;
				Cursor.Current = Cursors.WaitCursor;
				PointLatLng position = GMapControl1.Position;
				double lat = ((PointLatLng)(ref position)).Lat;
				position = GMapControl1.Position;
				PointLatLng val2 = new PointLatLng(lat, ((PointLatLng)(ref position)).Lng);
				GMapOverlay val3 = new GMapOverlay(GMapControl1, "OverlayOne");
				((Collection<GMapOverlay>)(object)GMapControl1.Overlays).Clear();
				if (dataTable.Rows.Count > 0)
				{
					int num = dataTable.Rows.Count - 1;
					for (int i = 0; i <= num; i++)
					{
						double num2 = Conversions.ToDouble(dataTable.Rows[i]["latitud"]);
						double num3 = Conversions.ToDouble(dataTable.Rows[i]["longitud"]);
						GMapMarkerGoogleRed val4 = new GMapMarkerGoogleRed(new PointLatLng(num2, num3));
						((GMapMarker)val4).ToolTipText = Conversions.ToString(dataTable.Rows[i]["comprobante"]);
						((Collection<GMapMarker>)(object)val3.Markers).Add((GMapMarker)(object)val4);
					}
					((Collection<GMapOverlay>)(object)GMapControl1.Overlays).Add(val3);
					Cursor.Current = Cursors.Default;
					ResumeLayout(performLayout: true);
					GMapControl1.DragButton = MouseButtons.Left;
					GMapControl1.Position = new PointLatLng(Conversions.ToDouble(dataTable.Rows[0]["latitud"]), Conversions.ToDouble(dataTable.Rows[0]["longitud"]));
					GMapControl1.Refresh();
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Interaction.MsgBox(ex2.Message, MsgBoxStyle.Critical, "No se puede Mostrar la ruta");
				mini_mapa();
				ProjectData.ClearProjectError();
			}
		}
	}

	private void trazar_zona()
	{
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Expected O, but got Unknown
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Expected O, but got Unknown
		//IL_02c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0292: Unknown result type (might be due to invalid IL or missing references)
		DataTable dataTable = new DataTable("x");
		checked
		{
			try
			{
				string text = "select comprobante, latitud, longitud from Planchada where zona= " + Conversions.ToString(ComboBox1.SelectedIndex + 1) + " AND Fecha='" + fecha1 + "' AND Chofer=0";
				MySqlDataAdapter val = new MySqlDataAdapter(text, Mod_Sentencias.cnn);
				((DbDataAdapter)(object)val).Fill(dataTable);
				if (dataTable.Rows.Count <= 0)
				{
					return;
				}
				GMapControl1.Manager.Mode = (AccessMode)1;
				GMapControl1.MapProvider = (GMapProvider)(object)GMapProviders.OpenStreetMap;
				GMapControl1.MinZoom = 1;
				GMapControl1.MaxZoom = 19;
				GMapControl1.Zoom = 11.0;
				GMapControl1.MarkersEnabled = true;
				GMapProvider.Language = (LanguageType)11;
				Cursor.Current = Cursors.WaitCursor;
				PointLatLng position = GMapControl1.Position;
				double lat = ((PointLatLng)(ref position)).Lat;
				position = GMapControl1.Position;
				PointLatLng val2 = new PointLatLng(lat, ((PointLatLng)(ref position)).Lng);
				GMapOverlay val3 = new GMapOverlay(GMapControl1, "OverlayOne");
				((Collection<GMapOverlay>)(object)GMapControl1.Overlays).Clear();
				if (dataTable.Rows.Count > 0)
				{
					int num = dataTable.Rows.Count - 1;
					for (int i = 0; i <= num; i++)
					{
						double num2 = Conversions.ToDouble(dataTable.Rows[i]["latitud"]);
						double num3 = Conversions.ToDouble(dataTable.Rows[i]["longitud"]);
						GMapMarkerGoogleRed val4 = new GMapMarkerGoogleRed(new PointLatLng(num2, num3));
						((GMapMarker)val4).ToolTipText = Conversions.ToString(dataTable.Rows[i]["comprobante"]);
						((Collection<GMapMarker>)(object)val3.Markers).Add((GMapMarker)(object)val4);
					}
					((Collection<GMapOverlay>)(object)GMapControl1.Overlays).Add(val3);
					Cursor.Current = Cursors.Default;
					ResumeLayout(performLayout: true);
					GMapControl1.DragButton = MouseButtons.Left;
					if (Operators.ConditionalCompareObjectLess(dataTable.Rows[0]["latitud"], 0, TextCompare: true))
					{
						GMapControl1.Position = new PointLatLng(Conversions.ToDouble(dataTable.Rows[0]["latitud"]), Conversions.ToDouble(dataTable.Rows[0]["longitud"]));
						GMapControl1.Refresh();
					}
					else
					{
						GMapControl1.Position = new PointLatLng(Conversions.ToDouble("-34,5551523"), Conversions.ToDouble("-58,4618645"));
						GMapControl1.Refresh();
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Interaction.MsgBox(ex2.Message, MsgBoxStyle.Critical, "No se puede Mostrar la zona");
				mini_mapa();
				ProjectData.ClearProjectError();
			}
		}
	}

	private void ListView3_ColumnClick(object sender, ColumnClickEventArgs e)
	{
		Mod_Ordenaclumnas.ordenar_columnas(ListView3, RuntimeHelpers.GetObjectValue(sender), e);
	}

	private void ListView2_ColumnClick(object sender, ColumnClickEventArgs e)
	{
		Mod_Ordenaclumnas.ordenar_columnas(ListView2, RuntimeHelpers.GetObjectValue(sender), e);
	}

	private void ListView3_DoubleClick(object sender, EventArgs e)
	{
		if (ListView3.SelectedItems.Count > 0)
		{
			int index = ListView3.SelectedIndices[0];
			Entregas entregas = MyProject.Forms.Entregas;
			entregas.Label2.Text = ListView3.Items[index].Text;
			entregas.Label17.Text = ListView3.Items[index].SubItems[2].Text;
			entregas.Label18.Text = ListView3.Items[index].SubItems[15].Text;
			entregas.Label19.Text = ListView3.Items[index].SubItems[3].Text;
			entregas.Label20.Text = ListView3.Items[index].SubItems[13].Text;
			entregas.Label21.Text = ListView3.Items[index].SubItems[12].Text;
			entregas = null;
		}
		MyProject.Forms.Entregas.Show();
	}

	private void ListView1_DrawItem(object sender, DrawListViewItemEventArgs e)
	{
		e.DrawDefault = true;
	}

	private void lv1_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
	{
		e.DrawDefault = true;
	}

	private void ListView1_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
	{
		e.DrawBackground();
		e.Graphics.FillRectangle(Brushes.LimeGreen, e.Bounds);
		Font font = new Font("Microsoft Sans Serif", 8f, FontStyle.Bold);
		Point point = checked(new Point(e.Bounds.X + 3, e.Bounds.Y + 2));
		e.Graphics.DrawString(e.Header.Text, font, Brushes.White, point);
	}

	private void ListView2_DrawItem(object sender, DrawListViewItemEventArgs e)
	{
		e.DrawDefault = true;
	}

	private void lv2_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
	{
		e.DrawDefault = true;
	}

	private void ListView2_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
	{
		e.DrawBackground();
		e.Graphics.FillRectangle(Brushes.LimeGreen, e.Bounds);
		Font font = new Font("Microsoft Sans Serif", 8f, FontStyle.Bold);
		Point point = checked(new Point(e.Bounds.X + 3, e.Bounds.Y + 2));
		e.Graphics.DrawString(e.Header.Text, font, Brushes.White, point);
	}

	private void Button4_Click(object sender, EventArgs e)
	{
		Cambiar_Ch cambiar_Ch = MyProject.Forms.Cambiar_Ch;
		cambiar_Ch.Label3.Text = Label2.Text;
		cambiar_Ch.TextBox1.Text = TextBox1.Text;
		cambiar_Ch.ComboBox2.SelectedIndex = 0;
		cambiar_Ch = null;
		MyProject.Forms.Cambiar_Ch.Show();
	}

	private void HojadeRuta_PrintPage(object sender, PrintPageEventArgs e)
	{
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		DataTable dataTable = new DataTable("X1");
		string text = ("SELECT Fecha,Comprobante,Observaciones, Remitos,Cliente, Destino, Domicilio, Bultos, Kilos, Volumen,(SELECT Chofer FROM FLOTA Where Numero=" + Label2.Text + ") AS Chof, Atraso, Declarado FROM Planchada WHERE Chofer=" + Label2.Text + " AND Fecha='" + fecha1 + "' AND Ventana=" + MyProject.Forms.Form1_Inicio.ComboBox1.Text) ?? "";
		MySqlDataAdapter val = new MySqlDataAdapter(text, Mod_Sentencias.cnn);
		((DbDataAdapter)(object)val).Fill(dataTable);
		Font font = new Font("Arial", 6.75f, FontStyle.Italic, GraphicsUnit.Point, 0);
		Font font2 = new Font("Arial", 8.75f, FontStyle.Italic, GraphicsUnit.Point, 0);
		Font font3 = new Font("Arial", 10.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		int num = 0;
		int num2 = 0;
		string s = MyProject.Forms.Form1_Inicio.nombreusuario.Text;
		string s2 = dataTable.Rows[0]["Fecha"].ToString();
		string s3 = dataTable.Rows[0]["Chof"].ToString();
		checked
		{
			int num3 = default(int);
			e.Graphics.DrawString(s2, font2, Brushes.Blue, 950f, num3 + 30);
			e.Graphics.DrawString("HOJA DE RUTA", font2, Brushes.Blue, 30f, num3 + 30);
			e.Graphics.DrawString(s3, font3, Brushes.Blue, 480f, num3 + 50);
			e.Graphics.DrawString(s, font2, Brushes.Blue, 950f, num3 + 50);
			e.Graphics.DrawString("Numero de hoja: " + Conversions.ToString(hoja), font2, Brushes.Blue, 30f, num3 + 50);
			e.Graphics.DrawLine(Pens.Brown, 20, 79, 1100, 79);
			e.Graphics.DrawLine(Pens.Brown, 20, 79, 20, 95);
			e.Graphics.DrawLine(Pens.Brown, 20, 95, 1100, 95);
			e.Graphics.DrawLine(Pens.Brown, 1100, 79, 1100, 95);
			e.Graphics.DrawString("CP", font2, Brushes.Blue, 30f, num3 + 80);
			e.Graphics.DrawString("CLIENTE", font2, Brushes.Blue, 100f, num3 + 80);
			e.Graphics.DrawString("DESTINO", font2, Brushes.Blue, 300f, num3 + 80);
			e.Graphics.DrawString("DIRECCION", font2, Brushes.Blue, 500f, num3 + 80);
			e.Graphics.DrawString("BULTOS", font2, Brushes.Blue, 700f, num3 + 80);
			e.Graphics.DrawString("REMITOS", font2, Brushes.Blue, 780f, num3 + 80);
			e.Graphics.DrawString("ATRASO", font, Brushes.Blue, 890f, num3 + 80);
			e.Graphics.DrawString("OBSERVACIONES", font2, Brushes.Blue, 950f, num3 + 80);
			double num4 = Conversions.ToDouble(dataTable.Compute("Sum(declarado)", ""));
			double num5 = Math.Round(num4, 2);
			double num6 = Conversions.ToDouble(dataTable.Compute("sum(bultos)", ""));
			double num7 = dataTable.Rows.Count;
			double value = Conversions.ToDouble(dataTable.Compute("sum(kilos)", ""));
			double num8 = Math.Round(value, 2);
			double value2 = Conversions.ToDouble(dataTable.Compute("sum(volumen)", ""));
			double num9 = Math.Round(value2, 3);
			while (datohdr < dataTable.Rows.Count)
			{
				num3 = ((datohdr != 0) ? (num * 20 + 100) : 100);
				string s4 = dataTable.Rows[datohdr]["Comprobante"].ToString();
				string s5 = dataTable.Rows[datohdr]["Remitos"].ToString();
				string s6 = dataTable.Rows[datohdr]["Destino"].ToString();
				string text2 = dataTable.Rows[datohdr]["Declarado"].ToString();
				string s7 = dataTable.Rows[datohdr]["Bultos"].ToString();
				string text3 = dataTable.Rows[datohdr]["Kilos"].ToString();
				string text4 = dataTable.Rows[datohdr]["Volumen"].ToString();
				string s8 = dataTable.Rows[datohdr]["Domicilio"].ToString();
				string s9 = dataTable.Rows[datohdr]["Observaciones"].ToString();
				string s10 = dataTable.Rows[datohdr]["Atraso"].ToString();
				string s11 = dataTable.Rows[datohdr]["Cliente"].ToString();
				e.Graphics.DrawString(s4, font, Brushes.Black, 30f, num3);
				e.Graphics.DrawString(s11, font, Brushes.Black, 100f, num3);
				e.Graphics.DrawString(s6, font, Brushes.Black, 300f, num3);
				e.Graphics.DrawString(s8, font, Brushes.Black, 500f, num3);
				e.Graphics.DrawString(s7, font, Brushes.Black, 700f, num3);
				e.Graphics.DrawString(s5, font, Brushes.Black, 780f, num3);
				e.Graphics.DrawString(s10, font, Brushes.Black, 890f, num3);
				e.Graphics.DrawString(s9, font, Brushes.Black, 920f, num3);
				datohdr++;
				num++;
				pagina++;
				if (num3 > 750)
				{
					num3 = 100;
					pagina = 0;
					hoja++;
					e.HasMorePages = true;
					return;
				}
				e.HasMorePages = false;
			}
			e.Graphics.DrawLine(Pens.Brown, 120, num3 + 19, 1100, num3 + 19);
			e.Graphics.DrawLine(Pens.Brown, 120, num3 + 19, 120, num3 + 38);
			e.Graphics.DrawLine(Pens.Brown, 120, num3 + 38, 1100, num3 + 38);
			e.Graphics.DrawLine(Pens.Brown, 1100, num3 + 19, 1100, num3 + 38);
			e.Graphics.DrawString("TOTALES: ", font2, Brushes.Black, 30f, num3 + 20);
			e.Graphics.DrawString("Valor Declarado", font2, Brushes.Black, 130f, num3 + 20);
			e.Graphics.DrawString(Conversions.ToString(num5), font2, Brushes.Black, 130f, num3 + 40);
			e.Graphics.DrawString("Guias", font2, Brushes.Black, 330f, num3 + 20);
			e.Graphics.DrawString(Conversions.ToString(num7), font2, Brushes.Black, 330f, num3 + 40);
			e.Graphics.DrawString("Kilos", font2, Brushes.Black, 430f, num3 + 20);
			e.Graphics.DrawString(Conversions.ToString(num8), font2, Brushes.Black, 430f, num3 + 40);
			e.Graphics.DrawString("Mts. Cubicos", font2, Brushes.Black, 530f, num3 + 20);
			e.Graphics.DrawString(Conversions.ToString(num9), font2, Brushes.Black, 530f, num3 + 40);
			e.Graphics.DrawString("Bultos", font2, Brushes.Black, 630f, num3 + 20);
			e.Graphics.DrawString(Conversions.ToString(num6), font2, Brushes.Black, 630f, num3 + 40);
			if (num4 > Conversions.ToDouble(MySettingsProperty.Settings.custodia))
			{
				e.Graphics.DrawString("CUSTODIA", font3, Brushes.Black, 950f, num3 + 20);
			}
			hoja = 0;
		}
	}

	private void Button5_Click(object sender, EventArgs e)
	{
		PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
		HojadeRuta.DefaultPageSettings.Landscape = true;
		printPreviewDialog.WindowState = FormWindowState.Maximized;
		printPreviewDialog.Document = HojadeRuta;
		HojadeRuta.Print();
		HojadeRuta.Dispose();
		datohdr = 0;
		string text = Conversions.ToString(Mod_Etrans_Retiros.agrupar_retiros());
		if (CheckBox1.Checked)
		{
			PrintPreviewDialog printPreviewDialog2 = new PrintPreviewDialog();
			Comprobantes.DefaultPageSettings.Landscape = false;
			printPreviewDialog2.WindowState = FormWindowState.Maximized;
			printPreviewDialog2.Document = Comprobantes;
			Comprobantes.Print();
			Comprobantes.Dispose();
			dato = 0;
			dato_r = 0;
		}
	}

	private void ListView2_SelectedIndexChanged(object sender, EventArgs e)
	{
		guialbl.Text = Conversions.ToString(obtener_guia_lv2());
	}

	private object obtener_guia_lv2()
	{
		int num = default(int);
		if (ListView2.SelectedItems.Count > 0)
		{
			int index = ListView2.SelectedIndices[0];
			num = Conversions.ToInteger(ListView2.Items[index].SubItems[19].Text);
		}
		return num;
	}

	private void ListView3_SelectedIndexChanged(object sender, EventArgs e)
	{
		guialbl.Text = Conversions.ToString(obtener_guia_lv3());
	}

	private object obtener_guia_lv3()
	{
		int num = default(int);
		if (ListView3.SelectedItems.Count > 0)
		{
			int index = ListView3.SelectedIndices[0];
			num = Conversions.ToInteger(ListView3.Items[index].SubItems[19].Text);
		}
		return num;
	}

	private void sumas_()
	{
		double num = 0.0;
		double num2 = 0.0;
		double num3 = 0.0;
		double num4 = 0.0;
		double num5 = 0.0;
		checked
		{
			int num6 = ListView2.Items.Count - 1;
			for (int i = 0; i <= num6; i++)
			{
				num += Conversions.ToDouble(ListView2.Items[i].SubItems[7].Text);
			}
			int num7 = ListView2.Items.Count - 1;
			for (int j = 0; j <= num7; j++)
			{
				num2 += Conversions.ToDouble(ListView2.Items[j].SubItems[8].Text);
			}
			int num8 = ListView2.Items.Count - 1;
			for (int k = 0; k <= num8; k++)
			{
				num3 += Conversions.ToDouble(ListView2.Items[k].SubItems[9].Text);
			}
			int num9 = ListView2.Items.Count - 1;
			for (int l = 0; l <= num9; l++)
			{
				num4 += Conversions.ToDouble(ListView2.Items[l].SubItems[10].Text);
			}
			int num10 = ListView2.Items.Count - 1;
			for (int m = 0; m <= num10; m++)
			{
				num5 += Conversions.ToDouble(ListView2.Items[m].SubItems[11].Text);
			}
			TextBox2.Text = Conversions.ToString(num);
			TextBox2.Refresh();
			TextBox3.Text = Conversions.ToString(num2);
			TextBox3.Refresh();
			TextBox4.Text = Conversions.ToString(num3);
			TextBox4.Refresh();
			TextBox5.Text = Conversions.ToString(num4);
			TextBox5.Refresh();
			TextBox6.Text = Conversions.ToString(num5);
			TextBox6.Refresh();
			if (num >= Conversions.ToDouble(MySettingsProperty.Settings.custodia))
			{
				TextBox7.Text = "CUSTODIA";
				TextBox7.Refresh();
			}
			else
			{
				TextBox7.Text = "";
			}
		}
	}

	private void datos_chofer_(string chofer)
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		DataTable dataTable = new DataTable("x");
		DataTable dataTable2 = new DataTable("x1");
		string text = ("SELECT Chofer,Categoria,Peso,Volumen,Tarifa FROM Flota WHERE Numero=" + chofer) ?? "";
		MySqlDataAdapter val = new MySqlDataAdapter(text, Mod_Sentencias.cnn);
		((DbDataAdapter)(object)val).Fill(dataTable);
		string text2 = ("SELECT Otro FROM Categorias WHERE Categoria=" + dataTable.Rows[0]["Categoria"].ToString()) ?? "";
		MySqlDataAdapter val2 = new MySqlDataAdapter(text2, Mod_Sentencias.cnn);
		((DbDataAdapter)(object)val2).Fill(dataTable2);
		ComboBox1.Text = "Zonas";
		TextBox1.Text = dataTable.Rows[0]["Chofer"].ToString();
		TextBox1.Refresh();
		TextBox8.Text = dataTable.Rows[0]["Categoria"].ToString();
		TextBox8.Refresh();
		TextBox9.Text = dataTable.Rows[0]["Peso"].ToString();
		TextBox9.Refresh();
		TextBox10.Text = dataTable.Rows[0]["Volumen"].ToString();
		TextBox10.Refresh();
		if (Conversions.ToDouble(MyProject.Forms.Form1_Inicio.ComboBox1.Text) == 1.0)
		{
			TextBox11.Text = dataTable.Rows[0]["Tarifa"].ToString();
			TextBox11.Refresh();
		}
		else
		{
			TextBox11.Text = Operators.MultiplyObject(dataTable.Rows[0]["Tarifa"], dataTable2.Rows[0]["otro"]).ToString();
			TextBox11.Refresh();
		}
	}

	private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
	{
		Label13.Text = Conversions.ToString(0);
		if (ListView1.SelectedItems.Count <= 0)
		{
			return;
		}
		ComboBox1.Text = "Zonas";
		int index = ListView1.SelectedIndices[0];
		Label2.Text = ListView1.Items[index].Text;
		Label2.Refresh();
		string chofer = ListView1.Items[index].Text;
		ruta_chofer(chofer);
		datos_chofer(chofer);
		sumas(chofer);
		if (ListView2.Items.Count > 0)
		{
			Thread thread = new Thread([SpecialName] () =>
			{
				costo_nuevo();
			});
			thread.Start();
			thread.Join();
			Thread thread2 = new Thread([SpecialName] () =>
			{
				Pintar_chofer2();
			});
			thread2.Start();
			thread2.Join();
			Thread thread3 = new Thread([SpecialName] () =>
			{
				adicionales_n();
			});
			thread3.Start();
			thread3.Join();
			Thread thread4 = new Thread([SpecialName] () =>
			{
				rentabilidad();
			});
			thread4.Start();
			thread4.Join();
			trazar_ruta(chofer);
		}
	}

	private void PrintDocument2_PrintPage(object sender, PrintPageEventArgs e)
	{
		Font font = new Font("Arial", 6.75f, FontStyle.Italic, GraphicsUnit.Point, 0);
		Font font2 = new Font("Arial", 16.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		Font font3 = new Font("Arial", 14.75f, FontStyle.Italic, GraphicsUnit.Point, 0);
		Font font4 = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, 0);
		int num = 0;
		string text = MyProject.Forms.Form1_Inicio.nombreusuario.Text;
		e.Graphics.DrawLine(Pens.Brown, 2, 5, 750, 5);
		e.Graphics.DrawLine(Pens.Brown, 2, 5, 2, 1100);
		e.Graphics.DrawLine(Pens.Brown, 750, 5, 750, 1100);
		e.Graphics.DrawLine(Pens.Brown, 2, 1100, 750, 1100);
		e.Graphics.DrawLine(Pens.Brown, 2, 130, 750, 130);
		e.Graphics.DrawString("ORDEN DE ENTREGA", font2, Brushes.Black, 250f, 135f);
		e.Graphics.DrawLine(Pens.Brown, 2, 162, 750, 162);
		checked
		{
			int num2 = default(int);
			e.Graphics.DrawString("Fecha: " + print_fecha, font2, Brushes.Black, 110f, num2 + 180);
			e.Graphics.DrawString("Chofer: " + print_chofer, font2, Brushes.Black, 110f, num2 + 220);
			Image image = (Image)Mod_QR.qrcodegen(print_qrcode);
			Image logo_etrans = Resources.logo_etrans;
			e.Graphics.DrawImage(image, 650, 30);
			e.Graphics.DrawImage(logo_etrans, 30, 30);
			e.Graphics.DrawString("Comprobante:", font4, Brushes.Black, 110f, num2 + 280);
			e.Graphics.DrawString(print_comprobante, font4, Brushes.Black, 310f, num2 + 280);
			e.Graphics.DrawString("Cliente:", font4, Brushes.Black, 110f, num2 + 320);
			e.Graphics.DrawString(print_cliente, font4, Brushes.Black, 310f, num2 + 320);
			e.Graphics.DrawString("Entregar a:", font4, Brushes.Black, 110f, num2 + 360);
			e.Graphics.DrawString(print_destino, font4, Brushes.Black, 310f, num2 + 360);
			e.Graphics.DrawString("Numero Trans:", font4, Brushes.Black, 110f, num2 + 400);
			e.Graphics.DrawString(print_remitos, font4, Brushes.Black, 310f, num2 + 400);
			e.Graphics.DrawString("Direccion:", font4, Brushes.Black, 110f, num2 + 440);
			e.Graphics.DrawString(print_direccion, font4, Brushes.Black, 310f, num2 + 440);
			e.Graphics.DrawString("Bultos:", font4, Brushes.Black, 110f, num2 + 480);
			e.Graphics.DrawString(print_bultos, font4, Brushes.Black, 310f, num2 + 480);
			e.Graphics.DrawString("Localidad:", font4, Brushes.Black, 110f, num2 + 520);
			e.Graphics.DrawString(print_localidad, font4, Brushes.Black, 310f, num2 + 520);
			e.Graphics.DrawString("Codigo Postal:", font4, Brushes.Black, 110f, num2 + 560);
			e.Graphics.DrawString(print_cp, font4, Brushes.Black, 310f, num2 + 560);
			e.Graphics.DrawString("Observaciones:", font4, Brushes.Black, 110f, num2 + 600);
			e.Graphics.DrawString(print_observaciones, font4, Brushes.Black, 310f, num2 + 600);
			e.Graphics.DrawString("Firma:", font2, Brushes.Black, 110f, num2 + 680);
			e.Graphics.DrawString("____________________", font2, Brushes.Black, 310f, num2 + 680);
			e.Graphics.DrawString("Aclaracion:", font2, Brushes.Black, 110f, num2 + 720);
			e.Graphics.DrawString("____________________", font2, Brushes.Black, 310f, num2 + 720);
			e.Graphics.DrawString("D.N.I.:", font2, Brushes.Black, 110f, num2 + 760);
			e.Graphics.DrawString("____________________", font2, Brushes.Black, 310f, num2 + 760);
			e.Graphics.DrawString(print_comprobante, font3, Brushes.Black, 110f, num2 + 800);
		}
	}

	private void PrintDocument3_PrintPage(object sender, PrintPageEventArgs e)
	{
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		DataTable dataTable = new DataTable("X12");
		string text = ("SELECT id_envio, Destinatario, D_cp, D_Localidad, Bultos, numero_interno, (SELECT Comprobante FROM Planchada WHERE remitos=etransEnvios.id_envio and fecha='" + fecha1 + "' And Ventana=" + MyProject.Forms.Form1_Inicio.ComboBox1.Text + ") AS Comprobante FROM etransenvios WHERE id_retiro=" + Conversions.ToString(compro_retiro)) ?? "";
		MySqlDataAdapter val = new MySqlDataAdapter(text, Mod_Sentencias.cnn);
		((DbDataAdapter)(object)val).Fill(dataTable);
		Font font = new Font("Arial", 6.75f, FontStyle.Italic, GraphicsUnit.Point, 0);
		Font font2 = new Font("Arial", 16.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		Font font3 = new Font("Arial", 14.75f, FontStyle.Italic, GraphicsUnit.Point, 0);
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		string text2 = MyProject.Forms.Form1_Inicio.nombreusuario.Text;
		e.Graphics.DrawLine(Pens.Brown, 2, 5, 750, 5);
		e.Graphics.DrawLine(Pens.Brown, 2, 5, 2, 1100);
		e.Graphics.DrawLine(Pens.Brown, 750, 5, 750, 1100);
		e.Graphics.DrawLine(Pens.Brown, 2, 1100, 750, 1100);
		e.Graphics.DrawLine(Pens.Brown, 2, 130, 750, 130);
		e.Graphics.DrawString("ORDEN DE RECOLECCION", font2, Brushes.Black, 250f, 135f);
		e.Graphics.DrawLine(Pens.Brown, 2, 162, 750, 162);
		checked
		{
			int num4 = default(int);
			e.Graphics.DrawString("Fecha: " + print_fecha, font2, Brushes.Black, 110f, num4 + 180);
			e.Graphics.DrawString("Chofer: " + print_chofer, font2, Brushes.Black, 110f, num4 + 220);
			Image logo_etrans = Resources.logo_etrans;
			e.Graphics.DrawImage(logo_etrans, 30, 30);
			e.Graphics.DrawString("Retirar de:", font2, Brushes.Black, 50f, 280f);
			e.Graphics.DrawString(print_destino, font3, Brushes.Black, 250f, 280f);
			e.Graphics.DrawString("Direccion:", font2, Brushes.Black, 50f, 320f);
			e.Graphics.DrawString(print_direccion, font3, Brushes.Black, 250f, 320f);
			e.Graphics.DrawString("Localidad:", font2, Brushes.Black, 50f, 360f);
			e.Graphics.DrawString(print_localidad, font3, Brushes.Black, 250f, 360f);
			e.Graphics.DrawString("Numero Trans", font, Brushes.Black, 35f, 400f);
			e.Graphics.DrawString("Destinatario", font, Brushes.Black, 140f, 400f);
			e.Graphics.DrawString("Codigo Postal", font, Brushes.Black, 245f, 400f);
			e.Graphics.DrawString("Localidad", font, Brushes.Black, 350f, 400f);
			e.Graphics.DrawString("Bultos", font, Brushes.Black, 455f, 400f);
			int num5 = dataTable.Rows.Count - 1;
			for (int i = 0; i <= num5; i++)
			{
				num4 = ((i != 0) ? (i * 40 + 430) : 430);
				string text3 = dataTable.Rows[i]["Comprobante"].ToString();
				string s = dataTable.Rows[i]["id_envio"].ToString();
				string text4 = dataTable.Rows[i]["Destinatario"].ToString();
				string s2 = dataTable.Rows[i]["D_cp"].ToString();
				string s3 = dataTable.Rows[i]["D_Localidad"].ToString();
				string s4 = dataTable.Rows[i]["Bultos"].ToString();
				string text5 = dataTable.Rows[i]["numero_interno"].ToString();
				e.Graphics.DrawString(s, font, Brushes.Black, 35f, num4);
				if (text4.Length > 20)
				{
					text4 = text4.Substring(0, 20);
				}
				e.Graphics.DrawString(text4, font, Brushes.Black, 140f, num4);
				e.Graphics.DrawString(s2, font, Brushes.Black, 245f, num4);
				e.Graphics.DrawString(s3, font, Brushes.Black, 350f, num4);
				e.Graphics.DrawString(s4, font, Brushes.Black, 455f, num4);
			}
		}
	}

	private void Comprobantes_PrintPage(object sender, PrintPageEventArgs e)
	{
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_02cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d4: Expected O, but got Unknown
		//IL_0fd2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fd9: Expected O, but got Unknown
		//IL_10c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_10d0: Expected O, but got Unknown
		DataTable dataTable = new DataTable("X1");
		string text = ("SELECT P.Comprobante, P.Cliente, P.Bultos, P.Destino, P.Domicilio, P.Ventana, P.Localidad, P.CP, P.Remitos, P.Observaciones, P.sub, P.fecha, (SELECT F.Chofer FROM FLOTA F Where F.Numero=P.Chofer) AS Chof  FROM Planchada P WHERE  P.Chofer=" + Label2.Text + " AND P.Fecha='" + fecha1 + "' AND P.Cliente='ETRANS' AND P.Ventana=" + MyProject.Forms.Form1_Inicio.ComboBox1.Text) ?? "";
		MySqlDataAdapter val = new MySqlDataAdapter(text, Mod_Sentencias.cnn);
		((DbDataAdapter)(object)val).Fill(dataTable);
		checked
		{
			while (dato < dataTable.Rows.Count)
			{
				print_comprobante = Conversions.ToString(dataTable.Rows[dato]["Comprobante"]);
				print_chofer = Conversions.ToString(dataTable.Rows[dato]["chof"]);
				print_fecha = Conversions.ToString(dataTable.Rows[dato]["fecha"]);
				print_cliente = Conversions.ToString(dataTable.Rows[dato]["Cliente"]);
				print_destino = Conversions.ToString(dataTable.Rows[dato]["Destino"]);
				print_direccion = Conversions.ToString(dataTable.Rows[dato]["Domicilio"]);
				print_ventana = Conversions.ToInteger(dataTable.Rows[dato]["Ventana"]);
				print_remitos = Conversions.ToString(dataTable.Rows[dato]["Remitos"]);
				print_observaciones = Conversions.ToString(dataTable.Rows[dato]["Observaciones"]);
				print_cp = Conversions.ToString(dataTable.Rows[dato]["Cp"]);
				print_localidad = Conversions.ToString(dataTable.Rows[dato]["Localidad"]);
				print_bultos = Conversions.ToString(dataTable.Rows[dato]["Bultos"]);
				print_qrcode = dataTable.Rows[dato]["Remitos"].ToString() + Conversions.ToString(1);
				if (Operators.ConditionalCompareObjectLess(dataTable.Rows[dato]["sub"], 11, TextCompare: true))
				{
					DataTable dataTable2 = new DataTable("X2");
					string text2 = "SELECT id_envio,Cliente, Destinatario, D_calle, D_numero_puerta,D_piso, D_dpto_oficina, D_bloque_torre, D_cp, D_localidad, Bultos, numero_interno, D_ventana, D_Cel, D_telefono, Observaciones FROM etransenvios WHERE id_envio=" + print_remitos;
					MySqlDataAdapter val2 = new MySqlDataAdapter(text2, Mod_Sentencias.cnn);
					((DbDataAdapter)(object)val2).Fill(dataTable2);
					print_cliente = Conversions.ToString(dataTable2.Rows[0]["Cliente"]);
					print_destino = Conversions.ToString(dataTable2.Rows[0]["Destinatario"]);
					print_qrcode = dataTable2.Rows[0]["id_envio"].ToString() + Conversions.ToString(1);
					print_remitos = Conversions.ToString(dataTable2.Rows[0]["id_envio"]);
					print_direccion = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(dataTable2.Rows[0]["D_calle"], " "), dataTable2.Rows[0]["D_numero_puerta"]));
					print_piso = Conversions.ToString(dataTable2.Rows[0]["D_piso"]);
					print_ofi = Conversions.ToString(dataTable2.Rows[0]["D_dpto_oficina"]);
					print_bloq = Conversions.ToString(dataTable2.Rows[0]["D_bloque_torre"]);
					print_localidad = Conversions.ToString(dataTable2.Rows[0]["D_localidad"]);
					print_cp = Conversions.ToString(dataTable2.Rows[0]["D_cp"]);
					print_ventana = Conversions.ToInteger(dataTable2.Rows[0]["D_ventana"]);
					print_observaciones = Conversions.ToString(dataTable2.Rows[0]["Observaciones"]);
					print_bultos = Conversions.ToString(dataTable2.Rows[0]["Bultos"]);
					print_cel = Conversions.ToString(dataTable2.Rows[0]["D_Cel"]);
					print_tel = Conversions.ToString(dataTable2.Rows[0]["D_telefono"]);
					Font font = new Font("Arial", 6.75f, FontStyle.Italic, GraphicsUnit.Point, 0);
					Font font2 = new Font("Arial", 16.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
					Font font3 = new Font("Arial", 14.75f, FontStyle.Italic, GraphicsUnit.Point, 0);
					Font font4 = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, 0);
					Font font5 = new Font("Arial", 50f, FontStyle.Regular, GraphicsUnit.Point, 0);
					int num = 0;
					string text3 = MyProject.Forms.Form1_Inicio.nombreusuario.Text;
					e.Graphics.DrawLine(Pens.Brown, 2, 5, 750, 5);
					e.Graphics.DrawLine(Pens.Brown, 2, 5, 2, 1040);
					e.Graphics.DrawLine(Pens.Brown, 750, 5, 750, 1040);
					e.Graphics.DrawLine(Pens.Brown, 2, 1040, 750, 1040);
					e.Graphics.DrawLine(Pens.Brown, 2, 130, 750, 130);
					Image image = (Image)Mod_QR.qrcodegen(print_qrcode);
					Image logo_etrans = Resources.logo_etrans;
					e.Graphics.DrawImage(image, 650, 30);
					e.Graphics.DrawImage(logo_etrans, 30, 30);
					e.Graphics.DrawLine(Pens.Red, 350, 30, 350, 90);
					e.Graphics.DrawLine(Pens.Red, 350, 30, 400, 30);
					e.Graphics.DrawString("R", font5, Brushes.Black, 338f, 22f);
					e.Graphics.DrawLine(Pens.Red, 400, 30, 400, 90);
					e.Graphics.DrawLine(Pens.Red, 400, 90, 350, 90);
					e.Graphics.DrawString("Dicho envio viaja por cuenta y orden del vendedor. Etrans (AREA54 s.a.) no es propietaria de las mercaderias que transporta.", font, Brushes.Black, 105f, 1050f);
					e.Graphics.DrawString("ORDEN DE ENTREGA", font2, Brushes.Black, 55f, 135f);
					e.Graphics.DrawString("VENTANA: ", font2, Brushes.Black, 385f, 135f);
					switch (print_ventana)
					{
					case 1:
						e.Graphics.DrawString(Conversions.ToString(print_ventana) + " (8:00 a 13:00 hs)", font2, Brushes.Black, 525f, 135f);
						break;
					case 2:
						e.Graphics.DrawString(Conversions.ToString(print_ventana) + " (13:00 a 18:00 hs)", font2, Brushes.Black, 525f, 135f);
						break;
					case 3:
						e.Graphics.DrawString(Conversions.ToString(print_ventana) + " (18:00 a 21:00 hs)", font2, Brushes.Black, 525f, 135f);
						break;
					}
					e.Graphics.DrawLine(Pens.Brown, 2, 162, 750, 162);
					e.Graphics.DrawLine(Pens.Brown, 375, 162, 375, 236);
					e.Graphics.DrawString("Fecha: " + print_fecha, font4, Brushes.Black, 500f, 180f);
					e.Graphics.DrawString("Chofer: " + print_chofer, font4, Brushes.Black, 500f, 200f);
					e.Graphics.DrawString("Numero Trans:", font4, Brushes.Black, 55f, 180f);
					e.Graphics.DrawString(print_remitos, font4, Brushes.Black, 155f, 180f);
					e.Graphics.DrawString("Ventana:", font4, Brushes.Black, 55f, 200f);
					e.Graphics.DrawString(Conversions.ToString(print_ventana), font4, Brushes.Black, 155f, 200f);
					e.Graphics.DrawLine(Pens.Brown, 2, 236, 750, 236);
					e.Graphics.DrawString("Cliente:", font4, Brushes.Black, 55f, 244f);
					e.Graphics.DrawString(print_cliente, font4, Brushes.Black, 155f, 244f);
					e.Graphics.DrawString("Entregar a:", font4, Brushes.Black, 55f, 274f);
					e.Graphics.DrawString(print_destino, font4, Brushes.Black, 155f, 274f);
					e.Graphics.DrawLine(Pens.Brown, 2, 310, 750, 310);
					e.Graphics.DrawLine(Pens.Brown, 375, 310, 375, 490);
					e.Graphics.DrawLine(Pens.Brown, 2, 490, 750, 490);
					e.Graphics.DrawString("Direccion:", font4, Brushes.Black, 400f, 340f);
					e.Graphics.DrawString(print_direccion, font4, Brushes.Black, 480f, 340f);
					e.Graphics.DrawString("Piso:", font4, Brushes.Black, 400f, 370f);
					e.Graphics.DrawString(print_piso, font4, Brushes.Black, 480f, 370f);
					e.Graphics.DrawString("Ofi/Dpto:", font4, Brushes.Black, 400f, 400f);
					e.Graphics.DrawString(print_ofi, font4, Brushes.Black, 480f, 400f);
					e.Graphics.DrawString("Bloque:", font4, Brushes.Black, 400f, 430f);
					e.Graphics.DrawString(print_bloq, font4, Brushes.Black, 480f, 430f);
					e.Graphics.DrawString("Bultos:", font4, Brushes.Black, 55f, 340f);
					e.Graphics.DrawString(print_bultos, font4, Brushes.Black, 155f, 340f);
					e.Graphics.DrawString("Localidad:", font4, Brushes.Black, 55f, 370f);
					e.Graphics.DrawString(print_localidad, font4, Brushes.Black, 155f, 370f);
					e.Graphics.DrawString("Codigo Postal:", font4, Brushes.Black, 55f, 400f);
					e.Graphics.DrawString(print_cp, font4, Brushes.Black, 155f, 400f);
					e.Graphics.DrawString("Celular:", font4, Brushes.Black, 55f, 430f);
					e.Graphics.DrawString(print_cel, font4, Brushes.Black, 155f, 430f);
					e.Graphics.DrawString("Fijo:", font4, Brushes.Black, 55f, 460f);
					e.Graphics.DrawString(print_tel, font4, Brushes.Black, 155f, 460f);
					if (print_observaciones.Length > 0)
					{
						if (print_observaciones.Length > 90)
						{
							e.Graphics.DrawString("Observaciones:", font4, Brushes.Black, 55f, 540f);
							string s = print_observaciones.Substring(0, 90);
							e.Graphics.DrawString(s, font4, Brushes.Black, 155f, 540f);
							string s2 = print_observaciones.Substring(90);
							e.Graphics.DrawString(s2, font4, Brushes.Black, 155f, 540f);
						}
						else
						{
							e.Graphics.DrawString("Observaciones:", font4, Brushes.Black, 55f, 540f);
							e.Graphics.DrawString(print_observaciones, font4, Brushes.Black, 155f, 540f);
						}
					}
					e.Graphics.DrawString("Firma:", font4, Brushes.Black, 55f, 890f);
					e.Graphics.DrawString("____________________", font4, Brushes.Black, 200f, 890f);
					e.Graphics.DrawString("Aclaracion:", font4, Brushes.Black, 55f, 930f);
					e.Graphics.DrawString("____________________", font4, Brushes.Black, 200f, 930f);
					e.Graphics.DrawString("D.N.I.:", font4, Brushes.Black, 55f, 970f);
					e.Graphics.DrawString("____________________", font4, Brushes.Black, 200f, 970f);
					e.Graphics.DrawString("1 - Direccion Erronea/Fatan Datos.", font4, Brushes.Black, 400f, 890f);
					e.Graphics.DrawString("2 - Zona Peligrosa/Inaccesible.", font4, Brushes.Black, 400f, 920f);
					e.Graphics.DrawString("3 - No responden en domicilio.", font4, Brushes.Black, 400f, 950f);
					e.Graphics.DrawString("4 - No lo quiere / No firma", font4, Brushes.Black, 400f, 980f);
					e.Graphics.DrawString("5 - Otros:_________________________", font4, Brushes.Black, 400f, 1010f);
					num++;
					dato++;
					pagina++;
					if (dato < dataTable.Rows.Count)
					{
						pagina = 0;
						e.HasMorePages = true;
						break;
					}
					e.HasMorePages = false;
					continue;
				}
				DataTable dataTable3 = new DataTable("X1");
				string text4 = ("SELECT id_hermes, id_retiro FROM etransEnvios WHERE id_envio= " + print_remitos) ?? "";
				MySqlDataAdapter val3 = new MySqlDataAdapter(text4, Mod_Sentencias.cnn);
				((DbDataAdapter)(object)val3).Fill(dataTable3);
				if (Operators.ConditionalCompareObjectEqual(dataTable3.Rows[0]["id_hermes"], dataTable3.Rows[0]["id_retiro"], TextCompare: true))
				{
					if (dataTable3.Rows.Count > 0)
					{
						compro_retiro = Conversions.ToInteger(dataTable3.Rows[0]["id_retiro"]);
						DataTable dataTable4 = new DataTable("X12");
						string text5 = ("SELECT id_envio, Cliente, Destinatario, U_calle,U_ventana, U_numero_puerta, U_piso, U_dpto_oficina, U_bloque_torre, U_cp, U_localidad, D_cp, D_Localidad, Bultos, numero_interno, (SELECT Comprobante FROM Planchada WHERE remitos=etransEnvios.id_envio and fecha='" + fecha1 + "' And Ventana=" + MyProject.Forms.Form1_Inicio.ComboBox1.Text + " AND sub=11) AS Comprobante FROM etransenvios WHERE id_retiro=" + Conversions.ToString(compro_retiro)) ?? "";
						MySqlDataAdapter val4 = new MySqlDataAdapter(text5, Mod_Sentencias.cnn);
						((DbDataAdapter)(object)val4).Fill(dataTable4);
						print_cliente = Conversions.ToString(dataTable4.Rows[0]["Cliente"]);
						print_direccion = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(dataTable4.Rows[0]["U_calle"], " "), dataTable4.Rows[0]["U_numero_puerta"]));
						print_piso = Conversions.ToString(dataTable4.Rows[0]["U_piso"]);
						print_ofi = Conversions.ToString(dataTable4.Rows[0]["U_dpto_oficina"]);
						print_bloq = Conversions.ToString(dataTable4.Rows[0]["U_bloque_torre"]);
						print_localidad = Conversions.ToString(dataTable4.Rows[0]["U_localidad"]);
						print_cp = Conversions.ToString(dataTable4.Rows[0]["U_cp"]);
						print_ventana = Conversions.ToInteger(dataTable4.Rows[0]["U_ventana"]);
						Font font6 = new Font("Arial", 6.75f, FontStyle.Italic, GraphicsUnit.Point, 0);
						Font font7 = new Font("Arial", 16.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
						Font font8 = new Font("Arial", 6.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
						Font font9 = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, 0);
						Font font10 = new Font("Arial", 50f, FontStyle.Regular, GraphicsUnit.Point, 0);
						e.Graphics.DrawLine(Pens.Red, 350, 30, 350, 90);
						e.Graphics.DrawLine(Pens.Red, 350, 30, 400, 30);
						e.Graphics.DrawString("R", font10, Brushes.Black, 338f, 22f);
						e.Graphics.DrawLine(Pens.Red, 400, 30, 400, 90);
						e.Graphics.DrawLine(Pens.Red, 400, 90, 350, 90);
						e.Graphics.DrawString("Dicho envio viaja por cuenta y orden del vendedor. Etrans (AREA54 s.a.) no es propietaria de las mercaderias que transporta.", font6, Brushes.Black, 105f, 1050f);
						int num2 = 0;
						int num3 = 0;
						int num4 = 0;
						int num5 = 0;
						string text6 = MyProject.Forms.Form1_Inicio.nombreusuario.Text;
						e.Graphics.DrawLine(Pens.Brown, 2, 5, 750, 5);
						e.Graphics.DrawLine(Pens.Brown, 2, 5, 2, 1040);
						e.Graphics.DrawLine(Pens.Brown, 750, 5, 750, 1040);
						e.Graphics.DrawLine(Pens.Brown, 2, 1040, 750, 1040);
						e.Graphics.DrawLine(Pens.Brown, 2, 130, 750, 130);
						e.Graphics.DrawString("ORDEN DE RECOLECCION", font7, Brushes.Black, 55f, 135f);
						e.Graphics.DrawString("VENTANA: ", font7, Brushes.Black, 385f, 135f);
						switch (print_ventana)
						{
						case 1:
							e.Graphics.DrawString(Conversions.ToString(print_ventana) + " (8:00 a 13:00 hs)", font7, Brushes.Black, 525f, 135f);
							break;
						case 2:
							e.Graphics.DrawString(Conversions.ToString(print_ventana) + " (13:00 a 18:00 hs)", font7, Brushes.Black, 525f, 135f);
							break;
						case 3:
							e.Graphics.DrawString(Conversions.ToString(print_ventana) + " (18:00 a 21:00 hs)", font7, Brushes.Black, 525f, 135f);
							break;
						}
						e.Graphics.DrawLine(Pens.Brown, 2, 162, 750, 162);
						e.Graphics.DrawString("Fecha: " + print_fecha, font9, Brushes.Black, 55f, 180f);
						e.Graphics.DrawString("Chofer: " + print_chofer, font9, Brushes.Black, 500f, 180f);
						e.Graphics.DrawLine(Pens.Brown, 2, 244, 750, 244);
						Image logo_etrans2 = Resources.logo_etrans;
						e.Graphics.DrawImage(logo_etrans2, 30, 30);
						e.Graphics.DrawString("Retirar de:", font9, Brushes.Black, 50f, 264f);
						e.Graphics.DrawString(print_destino, font9, Brushes.Black, 155f, 264f);
						e.Graphics.DrawString("Direccion:", font9, Brushes.Black, 50f, 294f);
						e.Graphics.DrawString(print_direccion, font9, Brushes.Black, 155f, 294f);
						e.Graphics.DrawString("Piso:", font9, Brushes.Black, 50f, 324f);
						e.Graphics.DrawString(print_piso, font9, Brushes.Black, 155f, 324f);
						e.Graphics.DrawString("Ofi/Dpto:", font9, Brushes.Black, 300f, 324f);
						e.Graphics.DrawString(print_ofi, font9, Brushes.Black, 380f, 324f);
						e.Graphics.DrawString("Bloque:", font9, Brushes.Black, 500f, 324f);
						e.Graphics.DrawString(print_bloq, font9, Brushes.Black, 540f, 324f);
						e.Graphics.DrawString("Localidad:", font9, Brushes.Black, 250f, 354f);
						e.Graphics.DrawString(print_localidad, font9, Brushes.Black, 355f, 354f);
						e.Graphics.DrawString("Codigo Postal:", font9, Brushes.Black, 50f, 354f);
						e.Graphics.DrawString(print_cp, font9, Brushes.Black, 155f, 354f);
						e.Graphics.DrawLine(Pens.Brown, 2, 400, 750, 400);
						e.Graphics.DrawString("Numero Trans", font6, Brushes.Black, 35f, 410f);
						e.Graphics.DrawString("Destinatario", font6, Brushes.Black, 125f, 410f);
						e.Graphics.DrawString("Codigo Postal", font6, Brushes.Black, 245f, 410f);
						e.Graphics.DrawString("Localidad", font6, Brushes.Black, 310f, 410f);
						e.Graphics.DrawString("Bultos", font6, Brushes.Black, 400f, 410f);
						e.Graphics.DrawString("Numero Interno", font6, Brushes.Black, 560f, 410f);
						while (dato_r < dataTable4.Rows.Count)
						{
							string text7 = dataTable4.Rows[dato_r]["id_envio"].ToString();
							if (Operators.ConditionalCompareObjectEqual(Mod_Etrans.estado_web_etrans(Conversions.ToInteger(text7)), 2, TextCompare: true))
							{
								num4 = ((dato_r != 0) ? (num2 * 40 + 450) : 450);
								string text8 = dataTable4.Rows[dato_r]["Comprobante"].ToString();
								string text9 = dataTable4.Rows[dato_r]["Destinatario"].ToString();
								string s3 = dataTable4.Rows[dato_r]["D_cp"].ToString();
								string s4 = dataTable4.Rows[dato_r]["D_Localidad"].ToString();
								string text10 = dataTable4.Rows[dato_r]["Bultos"].ToString();
								bultosTotales = (int)Math.Round((double)bultosTotales + Conversions.ToDouble(text10));
								string s5 = dataTable4.Rows[dato_r]["numero_interno"].ToString();
								e.Graphics.DrawString(text7, font6, Brushes.Black, 35f, num4);
								if (text9.Length > 20)
								{
									text9 = text9.Substring(0, 20);
								}
								e.Graphics.DrawString(text9, font6, Brushes.Black, 100f, num4);
								e.Graphics.DrawString(s3, font6, Brushes.Black, 245f, num4);
								e.Graphics.DrawString(s4, font6, Brushes.Black, 280f, num4);
								e.Graphics.DrawString(text10, font8, Brushes.Black, 410f, num4);
								e.Graphics.DrawString(s5, font6, Brushes.Black, 560f, num4);
								num2++;
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
							dato_r++;
						}
						e.Graphics.DrawString("Bultos totales a retirar: " + Conversions.ToString(bultosTotales), font7, Brushes.Black, 400f, 264f);
						dato++;
						pagina++;
						dato_r = 0;
						if (dato < dataTable.Rows.Count)
						{
							pagina = 0;
							bultosTotales = 0;
							e.HasMorePages = true;
							break;
						}
						bultosTotales = 0;
						e.HasMorePages = false;
					}
					else
					{
						dato++;
						pagina++;
						if (dato < dataTable.Rows.Count)
						{
							pagina = 0;
							e.HasMorePages = true;
							break;
						}
						e.HasMorePages = false;
					}
				}
				else
				{
					dato++;
					pagina++;
				}
			}
		}
	}

	private void Button6_Click(object sender, EventArgs e)
	{
		PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
		Comprobantes.DefaultPageSettings.Landscape = false;
		printPreviewDialog.WindowState = FormWindowState.Maximized;
		printPreviewDialog.Document = Comprobantes;
		printPreviewDialog.Show();
		dato = 0;
		dato_r = 0;
	}

	private void Button7_Click(object sender, EventArgs e)
	{
		try
		{
			string text = Strings.Format(MyProject.Forms.Form1_Inicio.DateTimePicker1.Value, "yyyyMMdd");
			string sql = "SELECT * FROM PLANCHADA WHERE chofer=" + Label2.Text + " AND fecha='" + text + "'";
			string destino = "RutaChofer" + Label2.Text;
			Mod_Exportar.exp_excel(sql, destino);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox(ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void Button8_Click(object sender, EventArgs e)
	{
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Expected O, but got Unknown
		string text = Label2.Text;
		string text2 = Strings.Format(MyProject.Forms.Form1_Inicio.DateTimePicker1.Value, "yyyyMMdd");
		string text3 = "SELECT  planchada.latitud AS lat, planchada.longitud AS lng FROM  planchada WHERE chofer=" + text + " AND fecha='" + text2 + "' and ventana=" + MyProject.Forms.Form1_Inicio.ComboBox1.Text + " ORDER BY comprobante asc";
		DataTable dataTable = new DataTable("X0");
		MySqlDataAdapter val = new MySqlDataAdapter(text3, Mod_Sentencias.cnn);
		((DbDataAdapter)(object)val).Fill(dataTable);
		double num = Conversions.ToDouble(dataTable.Rows[0]["lat"]);
		double num2 = Conversions.ToDouble(dataTable.Rows[0]["lng"]);
		checked
		{
			int num3 = ComboBox2.SelectedIndex + 1;
			string text4 = "SELECT  latitud, longitud , guia, ( 6371 * acos(cos( radians('" + Conversions.ToString(num) + "') )*cos( radians( latitud ) )*cos( radians( longitud ) - radians('" + Conversions.ToString(num2) + "') )+sin( radians('" + Conversions.ToString(num) + "') )*sin( radians( latitud ) ))) AS distancia FROM  planchada WHERE zona=" + Conversions.ToString(num3) + " AND fecha=" + text2 + " AND chofer=0 ORDER by distancia Asc";
			DataTable dataTable2 = new DataTable("X");
			MySqlDataAdapter val2 = new MySqlDataAdapter(text4, Mod_Sentencias.cnn);
			((DbDataAdapter)(object)val2).Fill(dataTable2);
			int num4 = 0;
			int num5 = dataTable2.Rows.Count - 1;
			for (int i = 0; i <= num5; i++)
			{
				num4 = i + 1;
				string sQL = Conversions.ToString(Operators.ConcatenateObject("UPDATE Planchada SET Chofer=" + text + ", Estado='Ruteado', Ventana=" + MyProject.Forms.Form1_Inicio.ComboBox1.Text + " , prioridad=" + Conversions.ToString(num4) + " WHERE guia= ", dataTable2.Rows[i]["guia"]));
				Mod_ConeccionBD.BD_Sentencia(sQL);
			}
		}
	}
}
