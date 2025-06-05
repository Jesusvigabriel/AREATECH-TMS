using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Hermes.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;
using Newtonsoft.Json.Linq;

namespace Hermes;

[DesignerGenerated]
public class Form2_AdmDB : Form
{
	public struct paddinEtiqueta
	{
		public int top;

		public int right;

		public int bottom;

		public int left;
	}

	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button3")]
	private Button _Button3;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ListView1")]
	private ListView _ListView1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button5")]
	private Button _Button5;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("creartablabtn")]
	private Button _creartablabtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("borrartablabtn")]
	private Button _borrartablabtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("impdatosbtn")]
	private Button _impdatosbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button4")]
	private Button _Button4;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button7")]
	private Button _Button7;

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
	[AccessedThroughProperty("ListView2")]
	private ListView _ListView2;

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
	[AccessedThroughProperty("Button19")]
	private Button _Button19;

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
	[AccessedThroughProperty("Button22")]
	private Button _Button22;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button23")]
	private Button _Button23;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button24")]
	private Button _Button24;

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
	[AccessedThroughProperty("Button29")]
	private Button _Button29;

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
	[AccessedThroughProperty("PrintDocument1")]
	private PrintDocument _PrintDocument1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button33")]
	private Button _Button33;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button34")]
	private Button _Button34;

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
	[AccessedThroughProperty("RuteoAbtn")]
	private Button _RuteoAbtn;

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
	[AccessedThroughProperty("testimprimir")]
	private Button _testimprimir;

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
	[AccessedThroughProperty("Button51")]
	private Button _Button51;

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
	[AccessedThroughProperty("Button56")]
	private Button _Button56;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button57")]
	private Button _Button57;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button58")]
	private Button _Button58;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("PrintDocument2")]
	private PrintDocument _PrintDocument2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button59")]
	private Button _Button59;

	private int print_order;

	private Mod_Ordenes.ordendesalida selectedOrder;

	private List<Mod_Ordenes.orderDetallePrint> selectedOrderItems;

	private Mod_Ordenes.Destino selectedDestinatario;

	private int EmpresaImprimirRetiro;

	[SpecialName]
	private int _0024STATIC_0024PrintDocument1_PrintPage_002420211C128195_0024CurrentYPosition;

	[SpecialName]
	private StaticLocalInitFlag _0024STATIC_0024PrintDocument1_PrintPage_002420211C128195_0024CurrentYPosition_0024Init;

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

	[field: AccessedThroughProperty("NewToolStripButton")]
	internal virtual ToolStripButton NewToolStripButton
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("OpenToolStripButton")]
	internal virtual ToolStripButton OpenToolStripButton
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("SaveToolStripButton")]
	internal virtual ToolStripButton SaveToolStripButton
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PrintToolStripButton")]
	internal virtual ToolStripButton PrintToolStripButton
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("toolStripSeparator")]
	internal virtual ToolStripSeparator toolStripSeparator
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CutToolStripButton")]
	internal virtual ToolStripButton CutToolStripButton
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CopyToolStripButton")]
	internal virtual ToolStripButton CopyToolStripButton
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PasteToolStripButton")]
	internal virtual ToolStripButton PasteToolStripButton
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("toolStripSeparator1")]
	internal virtual ToolStripSeparator toolStripSeparator1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("HelpToolStripButton")]
	internal virtual ToolStripButton HelpToolStripButton
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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

	[field: AccessedThroughProperty("ComboBox2")]
	internal virtual ComboBox ComboBox2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button creartablabtn
	{
		[CompilerGenerated]
		get
		{
			return _creartablabtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = creartablabtn_Click;
			Button button = _creartablabtn;
			if (button != null)
			{
				button.Click -= value2;
			}
			_creartablabtn = value;
			button = _creartablabtn;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button borrartablabtn
	{
		[CompilerGenerated]
		get
		{
			return _borrartablabtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = borrartablabtn_Click;
			Button button = _borrartablabtn;
			if (button != null)
			{
				button.Click -= value2;
			}
			_borrartablabtn = value;
			button = _borrartablabtn;
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

	[field: AccessedThroughProperty("GroupBox1")]
	internal virtual GroupBox GroupBox1
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

	[field: AccessedThroughProperty("TabPage4")]
	internal virtual TabPage TabPage4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TabPage5")]
	internal virtual TabPage TabPage5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TabPage6")]
	internal virtual TabPage TabPage6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ComboBox3")]
	internal virtual ComboBox ComboBox3
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

	internal virtual Button impdatosbtn
	{
		[CompilerGenerated]
		get
		{
			return _impdatosbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = impdatosbtn_Click;
			Button button = _impdatosbtn;
			if (button != null)
			{
				button.Click -= value2;
			}
			_impdatosbtn = value;
			button = _impdatosbtn;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("TabPage7")]
	internal virtual TabPage TabPage7
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

	[field: AccessedThroughProperty("GroupBox2")]
	internal virtual GroupBox GroupBox2
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

	[field: AccessedThroughProperty("Button6")]
	internal virtual Button Button6
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

	[field: AccessedThroughProperty("Button8")]
	internal virtual Button Button8
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

	[field: AccessedThroughProperty("TabPage8")]
	internal virtual TabPage TabPage8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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

	[field: AccessedThroughProperty("TextBox3")]
	internal virtual TextBox TextBox3
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

	[field: AccessedThroughProperty("TextBox2")]
	internal virtual TextBox TextBox2
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
			ItemCheckedEventHandler value2 = ListView2_ItemChecked;
			ListView listView = _ListView2;
			if (listView != null)
			{
				listView.ItemChecked -= value2;
			}
			_ListView2 = value;
			listView = _ListView2;
			if (listView != null)
			{
				listView.ItemChecked += value2;
			}
		}
	}

	[field: AccessedThroughProperty("ColumnHeader1")]
	internal virtual ColumnHeader ColumnHeader1
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

	[field: AccessedThroughProperty("Label4")]
	internal virtual Label Label4
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

	[field: AccessedThroughProperty("TabPage9")]
	internal virtual TabPage TabPage9
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

	[field: AccessedThroughProperty("Button18")]
	internal virtual Button Button18
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Button17")]
	internal virtual Button Button17
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Button16")]
	internal virtual Button Button16
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

	[field: AccessedThroughProperty("GroupBox3")]
	internal virtual GroupBox GroupBox3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Button15")]
	internal virtual Button Button15
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Button14")]
	internal virtual Button Button14
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

	[field: AccessedThroughProperty("Label6")]
	internal virtual Label Label6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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

	[field: AccessedThroughProperty("TextBox10")]
	internal virtual TextBox TextBox10
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

	[field: AccessedThroughProperty("TabPage10")]
	internal virtual TabPage TabPage10
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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

	[field: AccessedThroughProperty("TextBox11")]
	internal virtual TextBox TextBox11
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

	[field: AccessedThroughProperty("Label16")]
	internal virtual Label Label16
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TabPage11")]
	internal virtual TabPage TabPage11
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

	[field: AccessedThroughProperty("Label17")]
	internal virtual Label Label17
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox12")]
	internal virtual TextBox TextBox12
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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

	[field: AccessedThroughProperty("TabPage12")]
	internal virtual TabPage TabPage12
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ListView4")]
	internal virtual ListView ListView4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ListView3")]
	internal virtual ListView ListView3
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

	[field: AccessedThroughProperty("TextBox13")]
	internal virtual TextBox TextBox13
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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

	[field: AccessedThroughProperty("TabPage13")]
	internal virtual TabPage TabPage13
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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

	[field: AccessedThroughProperty("Button32")]
	internal virtual Button Button32
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

	[field: AccessedThroughProperty("TextBox14")]
	internal virtual TextBox TextBox14
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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

	[field: AccessedThroughProperty("TextBox15")]
	internal virtual TextBox TextBox15
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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

	[field: AccessedThroughProperty("TabPage14")]
	internal virtual TabPage TabPage14
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

	[field: AccessedThroughProperty("Label19")]
	internal virtual Label Label19
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

	[field: AccessedThroughProperty("TextBox18")]
	internal virtual TextBox TextBox18
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox17")]
	internal virtual TextBox TextBox17
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox16")]
	internal virtual TextBox TextBox16
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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

	internal virtual Button RuteoAbtn
	{
		[CompilerGenerated]
		get
		{
			return _RuteoAbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = RuteoAbtn_Click;
			Button ruteoAbtn = _RuteoAbtn;
			if (ruteoAbtn != null)
			{
				ruteoAbtn.Click -= value2;
			}
			_RuteoAbtn = value;
			ruteoAbtn = _RuteoAbtn;
			if (ruteoAbtn != null)
			{
				ruteoAbtn.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("TextBox19")]
	internal virtual TextBox TextBox19
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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

	[field: AccessedThroughProperty("TabPage15")]
	internal virtual TabPage TabPage15
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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

	[field: AccessedThroughProperty("Label21")]
	internal virtual Label Label21
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox20")]
	internal virtual TextBox TextBox20
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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

	[field: AccessedThroughProperty("DateTimePicker1")]
	internal virtual DateTimePicker DateTimePicker1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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

	[field: AccessedThroughProperty("TabPage16")]
	internal virtual TabPage TabPage16
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button testimprimir
	{
		[CompilerGenerated]
		get
		{
			return _testimprimir;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = testimprimir_Click;
			Button button = _testimprimir;
			if (button != null)
			{
				button.Click -= value2;
			}
			_testimprimir = value;
			button = _testimprimir;
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

	internal virtual Button Button51
	{
		[CompilerGenerated]
		get
		{
			return _Button51;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button51_Click;
			Button button = _Button51;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button51 = value;
			button = _Button51;
			if (button != null)
			{
				button.Click += value2;
			}
		}
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

	[field: AccessedThroughProperty("EcommerceTab")]
	internal virtual TabPage EcommerceTab
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox21")]
	internal virtual TextBox TextBox21
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

	[field: AccessedThroughProperty("ListView5")]
	internal virtual ListView ListView5
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

	[field: AccessedThroughProperty("Label22")]
	internal virtual Label Label22
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Button56
	{
		[CompilerGenerated]
		get
		{
			return _Button56;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button56_Click;
			Button button = _Button56;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button56 = value;
			button = _Button56;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button57
	{
		[CompilerGenerated]
		get
		{
			return _Button57;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button57_Click;
			Button button = _Button57;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button57 = value;
			button = _Button57;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button58
	{
		[CompilerGenerated]
		get
		{
			return _Button58;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button58_Click;
			Button button = _Button58;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button58 = value;
			button = _Button58;
			if (button != null)
			{
				button.Click += value2;
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

	internal virtual Button Button59
	{
		[CompilerGenerated]
		get
		{
			return _Button59;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button59_Click;
			Button button = _Button59;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button59 = value;
			button = _Button59;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("GroupBox5")]
	internal virtual GroupBox GroupBox5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label24")]
	internal virtual Label Label24
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label23")]
	internal virtual Label Label23
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox22")]
	internal virtual TextBox TextBox22
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label25")]
	internal virtual Label Label25
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public Form2_AdmDB()
	{
		base.Load += Form2_AdmDB_Load;
		print_order = 0;
		selectedOrder = default(Mod_Ordenes.ordendesalida);
		selectedOrderItems = new List<Mod_Ordenes.orderDetallePrint>();
		selectedDestinatario = default(Mod_Ordenes.Destino);
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hermes.Form2_AdmDB));
		this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
		this.ToolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
		this.Button3 = new System.Windows.Forms.Button();
		this.ListView1 = new System.Windows.Forms.ListView();
		this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
		this.NewToolStripButton = new System.Windows.Forms.ToolStripButton();
		this.OpenToolStripButton = new System.Windows.Forms.ToolStripButton();
		this.SaveToolStripButton = new System.Windows.Forms.ToolStripButton();
		this.PrintToolStripButton = new System.Windows.Forms.ToolStripButton();
		this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
		this.CutToolStripButton = new System.Windows.Forms.ToolStripButton();
		this.CopyToolStripButton = new System.Windows.Forms.ToolStripButton();
		this.PasteToolStripButton = new System.Windows.Forms.ToolStripButton();
		this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
		this.HelpToolStripButton = new System.Windows.Forms.ToolStripButton();
		this.Button5 = new System.Windows.Forms.Button();
		this.ComboBox2 = new System.Windows.Forms.ComboBox();
		this.creartablabtn = new System.Windows.Forms.Button();
		this.borrartablabtn = new System.Windows.Forms.Button();
		this.Label2 = new System.Windows.Forms.Label();
		this.GroupBox1 = new System.Windows.Forms.GroupBox();
		this.Panel1 = new System.Windows.Forms.Panel();
		this.TabControl1 = new System.Windows.Forms.TabControl();
		this.TabPage12 = new System.Windows.Forms.TabPage();
		this.ListView4 = new System.Windows.Forms.ListView();
		this.ColumnHeader4 = new System.Windows.Forms.ColumnHeader();
		this.ListView3 = new System.Windows.Forms.ListView();
		this.EcommerceTab = new System.Windows.Forms.TabPage();
		this.Button58 = new System.Windows.Forms.Button();
		this.Button57 = new System.Windows.Forms.Button();
		this.Button56 = new System.Windows.Forms.Button();
		this.Label22 = new System.Windows.Forms.Label();
		this.ListView5 = new System.Windows.Forms.ListView();
		this.Button55 = new System.Windows.Forms.Button();
		this.TextBox21 = new System.Windows.Forms.TextBox();
		this.Button54 = new System.Windows.Forms.Button();
		this.TabPage6 = new System.Windows.Forms.TabPage();
		this.Button22 = new System.Windows.Forms.Button();
		this.Button7 = new System.Windows.Forms.Button();
		this.ComboBox3 = new System.Windows.Forms.ComboBox();
		this.CheckBox1 = new System.Windows.Forms.CheckBox();
		this.TabPage1 = new System.Windows.Forms.TabPage();
		this.TabPage2 = new System.Windows.Forms.TabPage();
		this.Button49 = new System.Windows.Forms.Button();
		this.GroupBox2 = new System.Windows.Forms.GroupBox();
		this.Button50 = new System.Windows.Forms.Button();
		this.Button4 = new System.Windows.Forms.Button();
		this.Button2 = new System.Windows.Forms.Button();
		this.impdatosbtn = new System.Windows.Forms.Button();
		this.Button1 = new System.Windows.Forms.Button();
		this.TabPage3 = new System.Windows.Forms.TabPage();
		this.Button53 = new System.Windows.Forms.Button();
		this.RuteoAbtn = new System.Windows.Forms.Button();
		this.Button6 = new System.Windows.Forms.Button();
		this.TabPage4 = new System.Windows.Forms.TabPage();
		this.TextBox1 = new System.Windows.Forms.TextBox();
		this.Button8 = new System.Windows.Forms.Button();
		this.TabPage5 = new System.Windows.Forms.TabPage();
		this.TabPage7 = new System.Windows.Forms.TabPage();
		this.TextBox14 = new System.Windows.Forms.TextBox();
		this.Button32 = new System.Windows.Forms.Button();
		this.Button12 = new System.Windows.Forms.Button();
		this.TabPage8 = new System.Windows.Forms.TabPage();
		this.Button11 = new System.Windows.Forms.Button();
		this.Label5 = new System.Windows.Forms.Label();
		this.Label4 = new System.Windows.Forms.Label();
		this.ListView2 = new System.Windows.Forms.ListView();
		this.ColumnHeader1 = new System.Windows.Forms.ColumnHeader();
		this.ColumnHeader2 = new System.Windows.Forms.ColumnHeader();
		this.ColumnHeader3 = new System.Windows.Forms.ColumnHeader();
		this.TextBox3 = new System.Windows.Forms.TextBox();
		this.Label3 = new System.Windows.Forms.Label();
		this.TextBox2 = new System.Windows.Forms.TextBox();
		this.Label1 = new System.Windows.Forms.Label();
		this.Button10 = new System.Windows.Forms.Button();
		this.Button9 = new System.Windows.Forms.Button();
		this.TabPage9 = new System.Windows.Forms.TabPage();
		this.GroupBox4 = new System.Windows.Forms.GroupBox();
		this.Button18 = new System.Windows.Forms.Button();
		this.Button17 = new System.Windows.Forms.Button();
		this.Button16 = new System.Windows.Forms.Button();
		this.TextBox9 = new System.Windows.Forms.TextBox();
		this.TextBox8 = new System.Windows.Forms.TextBox();
		this.TextBox7 = new System.Windows.Forms.TextBox();
		this.Label11 = new System.Windows.Forms.Label();
		this.Label10 = new System.Windows.Forms.Label();
		this.Label9 = new System.Windows.Forms.Label();
		this.GroupBox3 = new System.Windows.Forms.GroupBox();
		this.Button19 = new System.Windows.Forms.Button();
		this.TextBox10 = new System.Windows.Forms.TextBox();
		this.Label12 = new System.Windows.Forms.Label();
		this.Button15 = new System.Windows.Forms.Button();
		this.Button14 = new System.Windows.Forms.Button();
		this.TextBox6 = new System.Windows.Forms.TextBox();
		this.Button13 = new System.Windows.Forms.Button();
		this.TextBox5 = new System.Windows.Forms.TextBox();
		this.TextBox4 = new System.Windows.Forms.TextBox();
		this.Label8 = new System.Windows.Forms.Label();
		this.Label7 = new System.Windows.Forms.Label();
		this.Label6 = new System.Windows.Forms.Label();
		this.TabPage10 = new System.Windows.Forms.TabPage();
		this.Label16 = new System.Windows.Forms.Label();
		this.Label15 = new System.Windows.Forms.Label();
		this.Label14 = new System.Windows.Forms.Label();
		this.Label13 = new System.Windows.Forms.Label();
		this.TextBox11 = new System.Windows.Forms.TextBox();
		this.Button20 = new System.Windows.Forms.Button();
		this.TabPage11 = new System.Windows.Forms.TabPage();
		this.Button52 = new System.Windows.Forms.Button();
		this.Button51 = new System.Windows.Forms.Button();
		this.Button48 = new System.Windows.Forms.Button();
		this.testimprimir = new System.Windows.Forms.Button();
		this.Button42 = new System.Windows.Forms.Button();
		this.TextBox19 = new System.Windows.Forms.TextBox();
		this.Button41 = new System.Windows.Forms.Button();
		this.Button35 = new System.Windows.Forms.Button();
		this.TextBox15 = new System.Windows.Forms.TextBox();
		this.Button34 = new System.Windows.Forms.Button();
		this.Button33 = new System.Windows.Forms.Button();
		this.Button30 = new System.Windows.Forms.Button();
		this.Button29 = new System.Windows.Forms.Button();
		this.Button28 = new System.Windows.Forms.Button();
		this.TextBox13 = new System.Windows.Forms.TextBox();
		this.Button27 = new System.Windows.Forms.Button();
		this.Button26 = new System.Windows.Forms.Button();
		this.Button25 = new System.Windows.Forms.Button();
		this.Button24 = new System.Windows.Forms.Button();
		this.Button23 = new System.Windows.Forms.Button();
		this.Label17 = new System.Windows.Forms.Label();
		this.TextBox12 = new System.Windows.Forms.TextBox();
		this.Button21 = new System.Windows.Forms.Button();
		this.TabPage13 = new System.Windows.Forms.TabPage();
		this.Button40 = new System.Windows.Forms.Button();
		this.Button38 = new System.Windows.Forms.Button();
		this.Button31 = new System.Windows.Forms.Button();
		this.TabPage14 = new System.Windows.Forms.TabPage();
		this.Button39 = new System.Windows.Forms.Button();
		this.Button37 = new System.Windows.Forms.Button();
		this.Button36 = new System.Windows.Forms.Button();
		this.Label20 = new System.Windows.Forms.Label();
		this.Label19 = new System.Windows.Forms.Label();
		this.Label18 = new System.Windows.Forms.Label();
		this.TextBox18 = new System.Windows.Forms.TextBox();
		this.TextBox17 = new System.Windows.Forms.TextBox();
		this.TextBox16 = new System.Windows.Forms.TextBox();
		this.TabPage15 = new System.Windows.Forms.TabPage();
		this.Button47 = new System.Windows.Forms.Button();
		this.Button46 = new System.Windows.Forms.Button();
		this.Button45 = new System.Windows.Forms.Button();
		this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
		this.Button44 = new System.Windows.Forms.Button();
		this.TextBox20 = new System.Windows.Forms.TextBox();
		this.Label21 = new System.Windows.Forms.Label();
		this.Button43 = new System.Windows.Forms.Button();
		this.TabPage16 = new System.Windows.Forms.TabPage();
		this.PictureBox1 = new System.Windows.Forms.PictureBox();
		this.PrintDocument1 = new System.Drawing.Printing.PrintDocument();
		this.PrintDocument2 = new System.Drawing.Printing.PrintDocument();
		this.Button59 = new System.Windows.Forms.Button();
		this.GroupBox5 = new System.Windows.Forms.GroupBox();
		this.Label23 = new System.Windows.Forms.Label();
		this.Label24 = new System.Windows.Forms.Label();
		this.Label25 = new System.Windows.Forms.Label();
		this.TextBox22 = new System.Windows.Forms.TextBox();
		this.GroupBox1.SuspendLayout();
		this.Panel1.SuspendLayout();
		this.TabControl1.SuspendLayout();
		this.TabPage12.SuspendLayout();
		this.EcommerceTab.SuspendLayout();
		this.TabPage6.SuspendLayout();
		this.TabPage1.SuspendLayout();
		this.TabPage2.SuspendLayout();
		this.GroupBox2.SuspendLayout();
		this.TabPage3.SuspendLayout();
		this.TabPage4.SuspendLayout();
		this.TabPage7.SuspendLayout();
		this.TabPage8.SuspendLayout();
		this.TabPage9.SuspendLayout();
		this.GroupBox4.SuspendLayout();
		this.GroupBox3.SuspendLayout();
		this.TabPage10.SuspendLayout();
		this.TabPage11.SuspendLayout();
		this.TabPage13.SuspendLayout();
		this.TabPage14.SuspendLayout();
		this.TabPage15.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
		this.GroupBox5.SuspendLayout();
		base.SuspendLayout();
		this.StatusStrip1.Location = new System.Drawing.Point(0, 395);
		this.StatusStrip1.Name = "StatusStrip1";
		this.StatusStrip1.Size = new System.Drawing.Size(851, 22);
		this.StatusStrip1.TabIndex = 0;
		this.StatusStrip1.Text = "StatusStrip1";
		this.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
		this.ToolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
		this.Button3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
		this.Button3.Location = new System.Drawing.Point(771, 371);
		this.Button3.Name = "Button3";
		this.Button3.Size = new System.Drawing.Size(75, 23);
		this.Button3.TabIndex = 4;
		this.Button3.Text = "Salir";
		this.Button3.UseVisualStyleBackColor = true;
		this.ListView1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.ListView1.FullRowSelect = true;
		this.ListView1.GridLines = true;
		this.ListView1.Location = new System.Drawing.Point(9, 104);
		this.ListView1.Name = "ListView1";
		this.ListView1.Size = new System.Drawing.Size(813, 176);
		this.ListView1.TabIndex = 6;
		this.ListView1.UseCompatibleStateImageBehavior = false;
		this.ToolStrip1.Location = new System.Drawing.Point(0, 0);
		this.ToolStrip1.Name = "ToolStrip1";
		this.ToolStrip1.Size = new System.Drawing.Size(851, 25);
		this.ToolStrip1.TabIndex = 8;
		this.ToolStrip1.Text = "ToolStrip1";
		this.NewToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
		this.NewToolStripButton.Image = (System.Drawing.Image)resources.GetObject("NewToolStripButton.Image");
		this.NewToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.NewToolStripButton.Name = "NewToolStripButton";
		this.NewToolStripButton.Size = new System.Drawing.Size(23, 22);
		this.NewToolStripButton.Text = "&New";
		this.OpenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
		this.OpenToolStripButton.Image = (System.Drawing.Image)resources.GetObject("OpenToolStripButton.Image");
		this.OpenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.OpenToolStripButton.Name = "OpenToolStripButton";
		this.OpenToolStripButton.Size = new System.Drawing.Size(23, 22);
		this.OpenToolStripButton.Text = "&Open";
		this.SaveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
		this.SaveToolStripButton.Image = (System.Drawing.Image)resources.GetObject("SaveToolStripButton.Image");
		this.SaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.SaveToolStripButton.Name = "SaveToolStripButton";
		this.SaveToolStripButton.Size = new System.Drawing.Size(23, 22);
		this.SaveToolStripButton.Text = "&Save";
		this.PrintToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
		this.PrintToolStripButton.Image = (System.Drawing.Image)resources.GetObject("PrintToolStripButton.Image");
		this.PrintToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.PrintToolStripButton.Name = "PrintToolStripButton";
		this.PrintToolStripButton.Size = new System.Drawing.Size(23, 22);
		this.PrintToolStripButton.Text = "&Print";
		this.toolStripSeparator.Name = "toolStripSeparator";
		this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
		this.CutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
		this.CutToolStripButton.Image = (System.Drawing.Image)resources.GetObject("CutToolStripButton.Image");
		this.CutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.CutToolStripButton.Name = "CutToolStripButton";
		this.CutToolStripButton.Size = new System.Drawing.Size(23, 22);
		this.CutToolStripButton.Text = "C&ut";
		this.CopyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
		this.CopyToolStripButton.Image = (System.Drawing.Image)resources.GetObject("CopyToolStripButton.Image");
		this.CopyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.CopyToolStripButton.Name = "CopyToolStripButton";
		this.CopyToolStripButton.Size = new System.Drawing.Size(23, 22);
		this.CopyToolStripButton.Text = "&Copy";
		this.PasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
		this.PasteToolStripButton.Image = (System.Drawing.Image)resources.GetObject("PasteToolStripButton.Image");
		this.PasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.PasteToolStripButton.Name = "PasteToolStripButton";
		this.PasteToolStripButton.Size = new System.Drawing.Size(23, 22);
		this.PasteToolStripButton.Text = "&Paste";
		this.toolStripSeparator1.Name = "toolStripSeparator1";
		this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
		this.HelpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
		this.HelpToolStripButton.Image = (System.Drawing.Image)resources.GetObject("HelpToolStripButton.Image");
		this.HelpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.HelpToolStripButton.Name = "HelpToolStripButton";
		this.HelpToolStripButton.Size = new System.Drawing.Size(23, 22);
		this.HelpToolStripButton.Text = "He&lp";
		this.Button5.Location = new System.Drawing.Point(287, 10);
		this.Button5.Name = "Button5";
		this.Button5.Size = new System.Drawing.Size(75, 23);
		this.Button5.TabIndex = 9;
		this.Button5.Text = "Ver";
		this.Button5.UseVisualStyleBackColor = true;
		this.ComboBox2.FormattingEnabled = true;
		this.ComboBox2.Location = new System.Drawing.Point(54, 12);
		this.ComboBox2.Name = "ComboBox2";
		this.ComboBox2.Size = new System.Drawing.Size(217, 21);
		this.ComboBox2.TabIndex = 11;
		this.creartablabtn.Location = new System.Drawing.Point(287, 37);
		this.creartablabtn.Name = "creartablabtn";
		this.creartablabtn.Size = new System.Drawing.Size(75, 23);
		this.creartablabtn.TabIndex = 12;
		this.creartablabtn.Text = "Crear Tablas";
		this.creartablabtn.UseVisualStyleBackColor = true;
		this.borrartablabtn.Location = new System.Drawing.Point(368, 37);
		this.borrartablabtn.Name = "borrartablabtn";
		this.borrartablabtn.Size = new System.Drawing.Size(75, 23);
		this.borrartablabtn.TabIndex = 13;
		this.borrartablabtn.Text = "Borrar Tabla";
		this.borrartablabtn.UseVisualStyleBackColor = true;
		this.Label2.AutoSize = true;
		this.Label2.Location = new System.Drawing.Point(6, 15);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(42, 13);
		this.Label2.TabIndex = 10;
		this.Label2.Text = "Tablas:";
		this.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.GroupBox1.Controls.Add(this.Panel1);
		this.GroupBox1.Location = new System.Drawing.Point(5, 28);
		this.GroupBox1.Name = "GroupBox1";
		this.GroupBox1.Size = new System.Drawing.Size(854, 343);
		this.GroupBox1.TabIndex = 15;
		this.GroupBox1.TabStop = false;
		this.GroupBox1.Text = "Configuración";
		this.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.Panel1.Controls.Add(this.TabControl1);
		this.Panel1.Location = new System.Drawing.Point(6, 19);
		this.Panel1.Name = "Panel1";
		this.Panel1.Size = new System.Drawing.Size(842, 318);
		this.Panel1.TabIndex = 0;
		this.TabControl1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.TabControl1.Controls.Add(this.TabPage12);
		this.TabControl1.Controls.Add(this.EcommerceTab);
		this.TabControl1.Controls.Add(this.TabPage6);
		this.TabControl1.Controls.Add(this.TabPage1);
		this.TabControl1.Controls.Add(this.TabPage2);
		this.TabControl1.Controls.Add(this.TabPage3);
		this.TabControl1.Controls.Add(this.TabPage4);
		this.TabControl1.Controls.Add(this.TabPage5);
		this.TabControl1.Controls.Add(this.TabPage7);
		this.TabControl1.Controls.Add(this.TabPage8);
		this.TabControl1.Controls.Add(this.TabPage9);
		this.TabControl1.Controls.Add(this.TabPage10);
		this.TabControl1.Controls.Add(this.TabPage11);
		this.TabControl1.Controls.Add(this.TabPage13);
		this.TabControl1.Controls.Add(this.TabPage14);
		this.TabControl1.Controls.Add(this.TabPage15);
		this.TabControl1.Controls.Add(this.TabPage16);
		this.TabControl1.Location = new System.Drawing.Point(3, 3);
		this.TabControl1.Name = "TabControl1";
		this.TabControl1.SelectedIndex = 0;
		this.TabControl1.Size = new System.Drawing.Size(836, 312);
		this.TabControl1.TabIndex = 0;
		this.TabControl1.Tag = "";
		this.TabPage12.Controls.Add(this.ListView4);
		this.TabPage12.Controls.Add(this.ListView3);
		this.TabPage12.Location = new System.Drawing.Point(4, 22);
		this.TabPage12.Name = "TabPage12";
		this.TabPage12.Size = new System.Drawing.Size(828, 286);
		this.TabPage12.TabIndex = 11;
		this.TabPage12.Text = "Tablas";
		this.TabPage12.UseVisualStyleBackColor = true;
		this.ListView4.Columns.AddRange(new System.Windows.Forms.ColumnHeader[1] { this.ColumnHeader4 });
		this.ListView4.GridLines = true;
		this.ListView4.Location = new System.Drawing.Point(429, 36);
		this.ListView4.Name = "ListView4";
		this.ListView4.Size = new System.Drawing.Size(380, 237);
		this.ListView4.TabIndex = 1;
		this.ListView4.UseCompatibleStateImageBehavior = false;
		this.ListView4.View = System.Windows.Forms.View.Details;
		this.ColumnHeader4.Text = "Tablas Para Crear";
		this.ListView3.Location = new System.Drawing.Point(24, 35);
		this.ListView3.Name = "ListView3";
		this.ListView3.Size = new System.Drawing.Size(357, 238);
		this.ListView3.TabIndex = 0;
		this.ListView3.UseCompatibleStateImageBehavior = false;
		this.EcommerceTab.Controls.Add(this.Button58);
		this.EcommerceTab.Controls.Add(this.Button57);
		this.EcommerceTab.Controls.Add(this.Button56);
		this.EcommerceTab.Controls.Add(this.Label22);
		this.EcommerceTab.Controls.Add(this.ListView5);
		this.EcommerceTab.Controls.Add(this.Button55);
		this.EcommerceTab.Controls.Add(this.TextBox21);
		this.EcommerceTab.Controls.Add(this.Button54);
		this.EcommerceTab.Location = new System.Drawing.Point(4, 22);
		this.EcommerceTab.Name = "EcommerceTab";
		this.EcommerceTab.Size = new System.Drawing.Size(828, 286);
		this.EcommerceTab.TabIndex = 16;
		this.EcommerceTab.Text = "Ecommerce";
		this.EcommerceTab.UseVisualStyleBackColor = true;
		this.Button58.Location = new System.Drawing.Point(146, 138);
		this.Button58.Name = "Button58";
		this.Button58.Size = new System.Drawing.Size(127, 30);
		this.Button58.TabIndex = 7;
		this.Button58.Text = "Imprimir Retiros";
		this.Button58.UseVisualStyleBackColor = true;
		this.Button57.Location = new System.Drawing.Point(18, 138);
		this.Button57.Name = "Button57";
		this.Button57.Size = new System.Drawing.Size(122, 30);
		this.Button57.TabIndex = 6;
		this.Button57.Text = "Hay Retiros?";
		this.Button57.UseVisualStyleBackColor = true;
		this.Button56.Location = new System.Drawing.Point(469, 14);
		this.Button56.Name = "Button56";
		this.Button56.Size = new System.Drawing.Size(145, 22);
		this.Button56.TabIndex = 5;
		this.Button56.Text = "Button56";
		this.Button56.UseVisualStyleBackColor = true;
		this.Label22.AutoSize = true;
		this.Label22.Location = new System.Drawing.Point(329, 225);
		this.Label22.Name = "Label22";
		this.Label22.Size = new System.Drawing.Size(45, 13);
		this.Label22.TabIndex = 4;
		this.Label22.Text = "Label22";
		this.ListView5.GridLines = true;
		this.ListView5.Location = new System.Drawing.Point(18, 43);
		this.ListView5.Name = "ListView5";
		this.ListView5.Size = new System.Drawing.Size(790, 78);
		this.ListView5.TabIndex = 3;
		this.ListView5.UseCompatibleStateImageBehavior = false;
		this.ListView5.View = System.Windows.Forms.View.Details;
		this.Button55.Location = new System.Drawing.Point(221, 14);
		this.Button55.Name = "Button55";
		this.Button55.Size = new System.Drawing.Size(75, 23);
		this.Button55.TabIndex = 2;
		this.Button55.Text = "Retiros";
		this.Button55.UseVisualStyleBackColor = true;
		this.TextBox21.Location = new System.Drawing.Point(18, 16);
		this.TextBox21.Name = "TextBox21";
		this.TextBox21.Size = new System.Drawing.Size(100, 20);
		this.TextBox21.TabIndex = 1;
		this.Button54.Location = new System.Drawing.Point(124, 14);
		this.Button54.Name = "Button54";
		this.Button54.Size = new System.Drawing.Size(75, 23);
		this.Button54.TabIndex = 0;
		this.Button54.Text = "Estado x Id";
		this.Button54.UseVisualStyleBackColor = true;
		this.TabPage6.BackColor = System.Drawing.SystemColors.Control;
		this.TabPage6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.TabPage6.Controls.Add(this.Button22);
		this.TabPage6.Controls.Add(this.Button7);
		this.TabPage6.Controls.Add(this.ComboBox3);
		this.TabPage6.Controls.Add(this.Button5);
		this.TabPage6.Controls.Add(this.ComboBox2);
		this.TabPage6.Controls.Add(this.borrartablabtn);
		this.TabPage6.Controls.Add(this.Label2);
		this.TabPage6.Controls.Add(this.ListView1);
		this.TabPage6.Controls.Add(this.creartablabtn);
		this.TabPage6.Controls.Add(this.CheckBox1);
		this.TabPage6.Location = new System.Drawing.Point(4, 22);
		this.TabPage6.Name = "TabPage6";
		this.TabPage6.Padding = new System.Windows.Forms.Padding(3);
		this.TabPage6.Size = new System.Drawing.Size(828, 286);
		this.TabPage6.TabIndex = 5;
		this.TabPage6.Text = "Administrador";
		this.Button22.Location = new System.Drawing.Point(9, 75);
		this.Button22.Name = "Button22";
		this.Button22.Size = new System.Drawing.Size(155, 23);
		this.Button22.TabIndex = 18;
		this.Button22.Text = "Optimizar tabla";
		this.Button22.UseVisualStyleBackColor = true;
		this.Button7.Location = new System.Drawing.Point(695, 75);
		this.Button7.Name = "Button7";
		this.Button7.Size = new System.Drawing.Size(123, 23);
		this.Button7.TabIndex = 17;
		this.Button7.Text = "Limpiar planchada";
		this.Button7.UseVisualStyleBackColor = true;
		this.Button7.Visible = false;
		this.ComboBox3.FormattingEnabled = true;
		this.ComboBox3.Location = new System.Drawing.Point(54, 39);
		this.ComboBox3.Name = "ComboBox3";
		this.ComboBox3.Size = new System.Drawing.Size(217, 21);
		this.ComboBox3.TabIndex = 15;
		this.CheckBox1.AutoSize = true;
		this.CheckBox1.Location = new System.Drawing.Point(449, 41);
		this.CheckBox1.Name = "CheckBox1";
		this.CheckBox1.Size = new System.Drawing.Size(84, 17);
		this.CheckBox1.TabIndex = 16;
		this.CheckBox1.Text = "Crear Todas";
		this.CheckBox1.UseVisualStyleBackColor = true;
		this.TabPage1.BackColor = System.Drawing.SystemColors.Control;
		this.TabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.TabPage1.Controls.Add(this.GroupBox5);
		this.TabPage1.Location = new System.Drawing.Point(4, 22);
		this.TabPage1.Name = "TabPage1";
		this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
		this.TabPage1.Size = new System.Drawing.Size(828, 286);
		this.TabPage1.TabIndex = 0;
		this.TabPage1.Text = "Filtrado";
		this.TabPage2.BackColor = System.Drawing.SystemColors.Control;
		this.TabPage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.TabPage2.Controls.Add(this.Button49);
		this.TabPage2.Controls.Add(this.GroupBox2);
		this.TabPage2.Location = new System.Drawing.Point(4, 22);
		this.TabPage2.Name = "TabPage2";
		this.TabPage2.Padding = new System.Windows.Forms.Padding(3);
		this.TabPage2.Size = new System.Drawing.Size(828, 286);
		this.TabPage2.TabIndex = 1;
		this.TabPage2.Text = "Importación";
		this.Button49.Location = new System.Drawing.Point(20, 25);
		this.Button49.Name = "Button49";
		this.Button49.Size = new System.Drawing.Size(75, 23);
		this.Button49.TabIndex = 2;
		this.Button49.Text = "Login API";
		this.Button49.UseVisualStyleBackColor = true;
		this.GroupBox2.Controls.Add(this.Button50);
		this.GroupBox2.Controls.Add(this.Button4);
		this.GroupBox2.Controls.Add(this.Button2);
		this.GroupBox2.Controls.Add(this.impdatosbtn);
		this.GroupBox2.Controls.Add(this.Button1);
		this.GroupBox2.Location = new System.Drawing.Point(420, 6);
		this.GroupBox2.Name = "GroupBox2";
		this.GroupBox2.Size = new System.Drawing.Size(383, 275);
		this.GroupBox2.TabIndex = 1;
		this.GroupBox2.TabStop = false;
		this.GroupBox2.Text = "Carga Masiva";
		this.Button50.Location = new System.Drawing.Point(6, 239);
		this.Button50.Name = "Button50";
		this.Button50.Size = new System.Drawing.Size(327, 30);
		this.Button50.TabIndex = 21;
		this.Button50.Text = "Exp. a Excel";
		this.Button50.UseVisualStyleBackColor = true;
		this.Button4.Location = new System.Drawing.Point(6, 106);
		this.Button4.Name = "Button4";
		this.Button4.Size = new System.Drawing.Size(147, 23);
		this.Button4.TabIndex = 20;
		this.Button4.Text = "Importar Flota";
		this.Button4.UseVisualStyleBackColor = true;
		this.Button2.Location = new System.Drawing.Point(6, 77);
		this.Button2.Name = "Button2";
		this.Button2.Size = new System.Drawing.Size(147, 23);
		this.Button2.TabIndex = 19;
		this.Button2.Text = "Importar Zonas";
		this.Button2.UseVisualStyleBackColor = true;
		this.impdatosbtn.Location = new System.Drawing.Point(6, 19);
		this.impdatosbtn.Name = "impdatosbtn";
		this.impdatosbtn.Size = new System.Drawing.Size(147, 23);
		this.impdatosbtn.TabIndex = 18;
		this.impdatosbtn.Text = "Importar Eventuales";
		this.impdatosbtn.UseVisualStyleBackColor = true;
		this.Button1.Location = new System.Drawing.Point(6, 48);
		this.Button1.Name = "Button1";
		this.Button1.Size = new System.Drawing.Size(147, 23);
		this.Button1.TabIndex = 0;
		this.Button1.Text = "Importar Localidades";
		this.Button1.UseVisualStyleBackColor = true;
		this.TabPage3.BackColor = System.Drawing.SystemColors.Control;
		this.TabPage3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.TabPage3.Controls.Add(this.Button53);
		this.TabPage3.Controls.Add(this.RuteoAbtn);
		this.TabPage3.Controls.Add(this.Button6);
		this.TabPage3.Location = new System.Drawing.Point(4, 22);
		this.TabPage3.Name = "TabPage3";
		this.TabPage3.Padding = new System.Windows.Forms.Padding(3);
		this.TabPage3.Size = new System.Drawing.Size(828, 286);
		this.TabPage3.TabIndex = 2;
		this.TabPage3.Text = "Ruteo";
		this.Button53.Location = new System.Drawing.Point(6, 64);
		this.Button53.Name = "Button53";
		this.Button53.Size = new System.Drawing.Size(189, 23);
		this.Button53.TabIndex = 2;
		this.Button53.Text = "Bing Coordenadas";
		this.Button53.UseVisualStyleBackColor = true;
		this.RuteoAbtn.Location = new System.Drawing.Point(6, 35);
		this.RuteoAbtn.Name = "RuteoAbtn";
		this.RuteoAbtn.Size = new System.Drawing.Size(189, 23);
		this.RuteoAbtn.TabIndex = 1;
		this.RuteoAbtn.Text = "Ruteo Automatico";
		this.RuteoAbtn.UseVisualStyleBackColor = true;
		this.Button6.Location = new System.Drawing.Point(6, 6);
		this.Button6.Name = "Button6";
		this.Button6.Size = new System.Drawing.Size(137, 23);
		this.Button6.TabIndex = 0;
		this.Button6.Text = "Dibujos Zonas";
		this.Button6.UseVisualStyleBackColor = true;
		this.TabPage4.BackColor = System.Drawing.SystemColors.Control;
		this.TabPage4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.TabPage4.Controls.Add(this.TextBox1);
		this.TabPage4.Controls.Add(this.Button8);
		this.TabPage4.Location = new System.Drawing.Point(4, 22);
		this.TabPage4.Name = "TabPage4";
		this.TabPage4.Padding = new System.Windows.Forms.Padding(3);
		this.TabPage4.Size = new System.Drawing.Size(828, 286);
		this.TabPage4.TabIndex = 3;
		this.TabPage4.Text = "Tarifas";
		this.TextBox1.Location = new System.Drawing.Point(216, 85);
		this.TextBox1.Name = "TextBox1";
		this.TextBox1.Size = new System.Drawing.Size(100, 20);
		this.TextBox1.TabIndex = 1;
		this.Button8.Location = new System.Drawing.Point(121, 59);
		this.Button8.Name = "Button8";
		this.Button8.Size = new System.Drawing.Size(75, 23);
		this.Button8.TabIndex = 0;
		this.Button8.Text = "Button8";
		this.Button8.UseVisualStyleBackColor = true;
		this.TabPage5.BackColor = System.Drawing.SystemColors.Control;
		this.TabPage5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.TabPage5.Location = new System.Drawing.Point(4, 22);
		this.TabPage5.Name = "TabPage5";
		this.TabPage5.Padding = new System.Windows.Forms.Padding(3);
		this.TabPage5.Size = new System.Drawing.Size(828, 286);
		this.TabPage5.TabIndex = 4;
		this.TabPage5.Text = "Adicionales";
		this.TabPage7.BackColor = System.Drawing.SystemColors.Control;
		this.TabPage7.Controls.Add(this.TextBox14);
		this.TabPage7.Controls.Add(this.Button32);
		this.TabPage7.Controls.Add(this.Button12);
		this.TabPage7.Location = new System.Drawing.Point(4, 22);
		this.TabPage7.Name = "TabPage7";
		this.TabPage7.Padding = new System.Windows.Forms.Padding(3);
		this.TabPage7.Size = new System.Drawing.Size(828, 286);
		this.TabPage7.TabIndex = 6;
		this.TabPage7.Text = "Depositos";
		this.TextBox14.Location = new System.Drawing.Point(249, 81);
		this.TextBox14.Name = "TextBox14";
		this.TextBox14.Size = new System.Drawing.Size(200, 20);
		this.TextBox14.TabIndex = 2;
		this.Button32.Location = new System.Drawing.Point(306, 123);
		this.Button32.Name = "Button32";
		this.Button32.Size = new System.Drawing.Size(75, 23);
		this.Button32.TabIndex = 1;
		this.Button32.Text = "Button32";
		this.Button32.UseVisualStyleBackColor = true;
		this.Button12.Location = new System.Drawing.Point(720, 6);
		this.Button12.Name = "Button12";
		this.Button12.Size = new System.Drawing.Size(75, 23);
		this.Button12.TabIndex = 0;
		this.Button12.Text = "Alter Table";
		this.Button12.UseVisualStyleBackColor = true;
		this.TabPage8.BackColor = System.Drawing.SystemColors.Control;
		this.TabPage8.Controls.Add(this.Button11);
		this.TabPage8.Controls.Add(this.Label5);
		this.TabPage8.Controls.Add(this.Label4);
		this.TabPage8.Controls.Add(this.ListView2);
		this.TabPage8.Controls.Add(this.TextBox3);
		this.TabPage8.Controls.Add(this.Label3);
		this.TabPage8.Controls.Add(this.TextBox2);
		this.TabPage8.Controls.Add(this.Label1);
		this.TabPage8.Controls.Add(this.Button10);
		this.TabPage8.Controls.Add(this.Button9);
		this.TabPage8.Location = new System.Drawing.Point(4, 22);
		this.TabPage8.Name = "TabPage8";
		this.TabPage8.Padding = new System.Windows.Forms.Padding(3);
		this.TabPage8.Size = new System.Drawing.Size(828, 286);
		this.TabPage8.TabIndex = 7;
		this.TabPage8.Text = "Mail";
		this.Button11.Location = new System.Drawing.Point(559, 202);
		this.Button11.Name = "Button11";
		this.Button11.Size = new System.Drawing.Size(75, 23);
		this.Button11.TabIndex = 9;
		this.Button11.Text = "Button11";
		this.Button11.UseVisualStyleBackColor = true;
		this.Label5.AutoSize = true;
		this.Label5.Location = new System.Drawing.Point(439, 232);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(39, 13);
		this.Label5.TabIndex = 8;
		this.Label5.Text = "Label5";
		this.Label4.AutoSize = true;
		this.Label4.Location = new System.Drawing.Point(436, 194);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(39, 13);
		this.Label4.TabIndex = 7;
		this.Label4.Text = "Label4";
		this.ListView2.CheckBoxes = true;
		this.ListView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[3] { this.ColumnHeader1, this.ColumnHeader2, this.ColumnHeader3 });
		this.ListView2.FullRowSelect = true;
		this.ListView2.GridLines = true;
		this.ListView2.Location = new System.Drawing.Point(31, 78);
		this.ListView2.Name = "ListView2";
		this.ListView2.Size = new System.Drawing.Size(330, 178);
		this.ListView2.TabIndex = 6;
		this.ListView2.UseCompatibleStateImageBehavior = false;
		this.TextBox3.Location = new System.Drawing.Point(544, 20);
		this.TextBox3.Name = "TextBox3";
		this.TextBox3.Size = new System.Drawing.Size(256, 20);
		this.TextBox3.TabIndex = 5;
		this.TextBox3.Text = "Novedades";
		this.Label3.AutoSize = true;
		this.Label3.Location = new System.Drawing.Point(495, 23);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(43, 13);
		this.Label3.TabIndex = 4;
		this.Label3.Text = "Asunto:";
		this.TextBox2.Location = new System.Drawing.Point(544, 53);
		this.TextBox2.Name = "TextBox2";
		this.TextBox2.Size = new System.Drawing.Size(256, 20);
		this.TextBox2.TabIndex = 3;
		this.TextBox2.Text = "operaciones@area54sa.com.ar;";
		this.Label1.AutoSize = true;
		this.Label1.Location = new System.Drawing.Point(514, 56);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(24, 13);
		this.Label1.TabIndex = 2;
		this.Label1.Text = "CC:";
		this.Button10.Location = new System.Drawing.Point(610, 98);
		this.Button10.Name = "Button10";
		this.Button10.Size = new System.Drawing.Size(75, 23);
		this.Button10.TabIndex = 1;
		this.Button10.Text = "otro mail";
		this.Button10.UseVisualStyleBackColor = true;
		this.Button9.Location = new System.Drawing.Point(508, 98);
		this.Button9.Name = "Button9";
		this.Button9.Size = new System.Drawing.Size(75, 23);
		this.Button9.TabIndex = 0;
		this.Button9.Text = "enviar mail";
		this.Button9.UseVisualStyleBackColor = true;
		this.TabPage9.BackColor = System.Drawing.SystemColors.Control;
		this.TabPage9.Controls.Add(this.GroupBox4);
		this.TabPage9.Controls.Add(this.GroupBox3);
		this.TabPage9.Location = new System.Drawing.Point(4, 22);
		this.TabPage9.Name = "TabPage9";
		this.TabPage9.Size = new System.Drawing.Size(828, 286);
		this.TabPage9.TabIndex = 8;
		this.TabPage9.Text = "FTP";
		this.GroupBox4.Controls.Add(this.Button18);
		this.GroupBox4.Controls.Add(this.Button17);
		this.GroupBox4.Controls.Add(this.Button16);
		this.GroupBox4.Controls.Add(this.TextBox9);
		this.GroupBox4.Controls.Add(this.TextBox8);
		this.GroupBox4.Controls.Add(this.TextBox7);
		this.GroupBox4.Controls.Add(this.Label11);
		this.GroupBox4.Controls.Add(this.Label10);
		this.GroupBox4.Controls.Add(this.Label9);
		this.GroupBox4.Location = new System.Drawing.Point(23, 137);
		this.GroupBox4.Name = "GroupBox4";
		this.GroupBox4.Size = new System.Drawing.Size(784, 131);
		this.GroupBox4.TabIndex = 3;
		this.GroupBox4.TabStop = false;
		this.GroupBox4.Text = "FTP DOWNLOAD:";
		this.Button18.Location = new System.Drawing.Point(665, 85);
		this.Button18.Name = "Button18";
		this.Button18.Size = new System.Drawing.Size(75, 23);
		this.Button18.TabIndex = 8;
		this.Button18.Text = "Test";
		this.Button18.UseVisualStyleBackColor = true;
		this.Button17.Location = new System.Drawing.Point(584, 85);
		this.Button17.Name = "Button17";
		this.Button17.Size = new System.Drawing.Size(75, 23);
		this.Button17.TabIndex = 7;
		this.Button17.Text = "Default";
		this.Button17.UseVisualStyleBackColor = true;
		this.Button16.Location = new System.Drawing.Point(503, 85);
		this.Button16.Name = "Button16";
		this.Button16.Size = new System.Drawing.Size(75, 23);
		this.Button16.TabIndex = 6;
		this.Button16.Text = "Guardar";
		this.Button16.UseVisualStyleBackColor = true;
		this.TextBox9.Location = new System.Drawing.Point(119, 87);
		this.TextBox9.Name = "TextBox9";
		this.TextBox9.Size = new System.Drawing.Size(316, 20);
		this.TextBox9.TabIndex = 5;
		this.TextBox8.Location = new System.Drawing.Point(119, 55);
		this.TextBox8.Name = "TextBox8";
		this.TextBox8.Size = new System.Drawing.Size(316, 20);
		this.TextBox8.TabIndex = 4;
		this.TextBox7.Location = new System.Drawing.Point(119, 27);
		this.TextBox7.Name = "TextBox7";
		this.TextBox7.Size = new System.Drawing.Size(316, 20);
		this.TextBox7.TabIndex = 3;
		this.Label11.AutoSize = true;
		this.Label11.Location = new System.Drawing.Point(29, 90);
		this.Label11.Name = "Label11";
		this.Label11.Size = new System.Drawing.Size(64, 13);
		this.Label11.TabIndex = 2;
		this.Label11.Text = "Contraseña:";
		this.Label10.AutoSize = true;
		this.Label10.Location = new System.Drawing.Point(29, 58);
		this.Label10.Name = "Label10";
		this.Label10.Size = new System.Drawing.Size(46, 13);
		this.Label10.TabIndex = 1;
		this.Label10.Text = "Usuario:";
		this.Label9.AutoSize = true;
		this.Label9.Location = new System.Drawing.Point(29, 30);
		this.Label9.Name = "Label9";
		this.Label9.Size = new System.Drawing.Size(32, 13);
		this.Label9.TabIndex = 0;
		this.Label9.Text = "URL:";
		this.GroupBox3.Controls.Add(this.Button19);
		this.GroupBox3.Controls.Add(this.TextBox10);
		this.GroupBox3.Controls.Add(this.Label12);
		this.GroupBox3.Controls.Add(this.Button15);
		this.GroupBox3.Controls.Add(this.Button14);
		this.GroupBox3.Controls.Add(this.TextBox6);
		this.GroupBox3.Controls.Add(this.Button13);
		this.GroupBox3.Controls.Add(this.TextBox5);
		this.GroupBox3.Controls.Add(this.TextBox4);
		this.GroupBox3.Controls.Add(this.Label8);
		this.GroupBox3.Controls.Add(this.Label7);
		this.GroupBox3.Controls.Add(this.Label6);
		this.GroupBox3.Location = new System.Drawing.Point(23, 20);
		this.GroupBox3.Name = "GroupBox3";
		this.GroupBox3.Size = new System.Drawing.Size(784, 111);
		this.GroupBox3.TabIndex = 2;
		this.GroupBox3.TabStop = false;
		this.GroupBox3.Text = "FTP UPLOAD:";
		this.Button19.Location = new System.Drawing.Point(703, 30);
		this.Button19.Name = "Button19";
		this.Button19.Size = new System.Drawing.Size(75, 23);
		this.Button19.TabIndex = 9;
		this.Button19.Text = "Explorar";
		this.Button19.UseVisualStyleBackColor = true;
		this.TextBox10.Location = new System.Drawing.Point(456, 32);
		this.TextBox10.Name = "TextBox10";
		this.TextBox10.Size = new System.Drawing.Size(241, 20);
		this.TextBox10.TabIndex = 8;
		this.Label12.AutoSize = true;
		this.Label12.Location = new System.Drawing.Point(453, 16);
		this.Label12.Name = "Label12";
		this.Label12.Size = new System.Drawing.Size(82, 13);
		this.Label12.TabIndex = 7;
		this.Label12.Text = "Ruta al archivo:";
		this.Button15.Location = new System.Drawing.Point(665, 76);
		this.Button15.Name = "Button15";
		this.Button15.Size = new System.Drawing.Size(75, 23);
		this.Button15.TabIndex = 6;
		this.Button15.Text = "Test";
		this.Button15.UseVisualStyleBackColor = true;
		this.Button14.Location = new System.Drawing.Point(584, 76);
		this.Button14.Name = "Button14";
		this.Button14.Size = new System.Drawing.Size(75, 23);
		this.Button14.TabIndex = 5;
		this.Button14.Text = "Default";
		this.Button14.UseVisualStyleBackColor = true;
		this.TextBox6.Location = new System.Drawing.Point(119, 78);
		this.TextBox6.Name = "TextBox6";
		this.TextBox6.Size = new System.Drawing.Size(316, 20);
		this.TextBox6.TabIndex = 5;
		this.Button13.Location = new System.Drawing.Point(503, 76);
		this.Button13.Name = "Button13";
		this.Button13.Size = new System.Drawing.Size(75, 23);
		this.Button13.TabIndex = 4;
		this.Button13.Text = "Guardar";
		this.Button13.UseVisualStyleBackColor = true;
		this.TextBox5.Location = new System.Drawing.Point(119, 49);
		this.TextBox5.Name = "TextBox5";
		this.TextBox5.Size = new System.Drawing.Size(316, 20);
		this.TextBox5.TabIndex = 4;
		this.TextBox4.Location = new System.Drawing.Point(119, 20);
		this.TextBox4.Name = "TextBox4";
		this.TextBox4.Size = new System.Drawing.Size(316, 20);
		this.TextBox4.TabIndex = 3;
		this.Label8.AutoSize = true;
		this.Label8.Location = new System.Drawing.Point(29, 81);
		this.Label8.Name = "Label8";
		this.Label8.Size = new System.Drawing.Size(64, 13);
		this.Label8.TabIndex = 2;
		this.Label8.Text = "Contraseña:";
		this.Label7.AutoSize = true;
		this.Label7.Location = new System.Drawing.Point(29, 52);
		this.Label7.Name = "Label7";
		this.Label7.Size = new System.Drawing.Size(46, 13);
		this.Label7.TabIndex = 1;
		this.Label7.Text = "Usuario:";
		this.Label6.AutoSize = true;
		this.Label6.Location = new System.Drawing.Point(29, 23);
		this.Label6.Name = "Label6";
		this.Label6.Size = new System.Drawing.Size(32, 13);
		this.Label6.TabIndex = 0;
		this.Label6.Text = "URL:";
		this.TabPage10.Controls.Add(this.Label16);
		this.TabPage10.Controls.Add(this.Label15);
		this.TabPage10.Controls.Add(this.Label14);
		this.TabPage10.Controls.Add(this.Label13);
		this.TabPage10.Controls.Add(this.TextBox11);
		this.TabPage10.Controls.Add(this.Button20);
		this.TabPage10.Location = new System.Drawing.Point(4, 22);
		this.TabPage10.Name = "TabPage10";
		this.TabPage10.Padding = new System.Windows.Forms.Padding(3);
		this.TabPage10.Size = new System.Drawing.Size(828, 286);
		this.TabPage10.TabIndex = 9;
		this.TabPage10.Text = "Version";
		this.TabPage10.UseVisualStyleBackColor = true;
		this.Label16.AutoSize = true;
		this.Label16.Location = new System.Drawing.Point(554, 122);
		this.Label16.Name = "Label16";
		this.Label16.Size = new System.Drawing.Size(45, 13);
		this.Label16.TabIndex = 5;
		this.Label16.Text = "Label16";
		this.Label15.AutoSize = true;
		this.Label15.Location = new System.Drawing.Point(17, 80);
		this.Label15.Name = "Label15";
		this.Label15.Size = new System.Drawing.Size(37, 13);
		this.Label15.TabIndex = 4;
		this.Label15.Text = "Clave:";
		this.Label14.AutoSize = true;
		this.Label14.Location = new System.Drawing.Point(17, 46);
		this.Label14.Name = "Label14";
		this.Label14.Size = new System.Drawing.Size(46, 13);
		this.Label14.TabIndex = 3;
		this.Label14.Text = "Usuario:";
		this.Label13.AutoSize = true;
		this.Label13.Location = new System.Drawing.Point(17, 17);
		this.Label13.Name = "Label13";
		this.Label13.Size = new System.Drawing.Size(55, 13);
		this.Label13.TabIndex = 2;
		this.Label13.Text = "FTP URL:";
		this.TextBox11.Location = new System.Drawing.Point(295, 135);
		this.TextBox11.Name = "TextBox11";
		this.TextBox11.Size = new System.Drawing.Size(100, 20);
		this.TextBox11.TabIndex = 1;
		this.Button20.Location = new System.Drawing.Point(358, 42);
		this.Button20.Name = "Button20";
		this.Button20.Size = new System.Drawing.Size(166, 21);
		this.Button20.TabIndex = 0;
		this.Button20.Text = "Check Updates";
		this.Button20.UseVisualStyleBackColor = true;
		this.TabPage11.Controls.Add(this.Button52);
		this.TabPage11.Controls.Add(this.Button51);
		this.TabPage11.Controls.Add(this.Button48);
		this.TabPage11.Controls.Add(this.testimprimir);
		this.TabPage11.Controls.Add(this.Button42);
		this.TabPage11.Controls.Add(this.TextBox19);
		this.TabPage11.Controls.Add(this.Button41);
		this.TabPage11.Controls.Add(this.Button35);
		this.TabPage11.Controls.Add(this.TextBox15);
		this.TabPage11.Controls.Add(this.Button34);
		this.TabPage11.Controls.Add(this.Button33);
		this.TabPage11.Controls.Add(this.Button30);
		this.TabPage11.Controls.Add(this.Button29);
		this.TabPage11.Controls.Add(this.Button28);
		this.TabPage11.Controls.Add(this.TextBox13);
		this.TabPage11.Controls.Add(this.Button27);
		this.TabPage11.Controls.Add(this.Button26);
		this.TabPage11.Controls.Add(this.Button25);
		this.TabPage11.Controls.Add(this.Button24);
		this.TabPage11.Controls.Add(this.Button23);
		this.TabPage11.Controls.Add(this.Label17);
		this.TabPage11.Controls.Add(this.TextBox12);
		this.TabPage11.Controls.Add(this.Button21);
		this.TabPage11.Location = new System.Drawing.Point(4, 22);
		this.TabPage11.Name = "TabPage11";
		this.TabPage11.Padding = new System.Windows.Forms.Padding(3);
		this.TabPage11.Size = new System.Drawing.Size(828, 286);
		this.TabPage11.TabIndex = 10;
		this.TabPage11.Text = "Varios";
		this.TabPage11.UseVisualStyleBackColor = true;
		this.Button52.Location = new System.Drawing.Point(191, 146);
		this.Button52.Name = "Button52";
		this.Button52.Size = new System.Drawing.Size(206, 27);
		this.Button52.TabIndex = 22;
		this.Button52.Text = "Posicionar Facu";
		this.Button52.UseVisualStyleBackColor = true;
		this.Button51.Location = new System.Drawing.Point(20, 126);
		this.Button51.Name = "Button51";
		this.Button51.Size = new System.Drawing.Size(75, 23);
		this.Button51.TabIndex = 21;
		this.Button51.Text = "Hilos";
		this.Button51.UseVisualStyleBackColor = true;
		this.Button48.Location = new System.Drawing.Point(191, 230);
		this.Button48.Name = "Button48";
		this.Button48.Size = new System.Drawing.Size(213, 23);
		this.Button48.TabIndex = 20;
		this.Button48.Text = "OrdenesPreparadas";
		this.Button48.UseVisualStyleBackColor = true;
		this.testimprimir.Location = new System.Drawing.Point(36, 230);
		this.testimprimir.Name = "testimprimir";
		this.testimprimir.Size = new System.Drawing.Size(75, 23);
		this.testimprimir.TabIndex = 19;
		this.testimprimir.Text = "TestImprimir";
		this.testimprimir.UseVisualStyleBackColor = true;
		this.Button42.Location = new System.Drawing.Point(82, 63);
		this.Button42.Name = "Button42";
		this.Button42.Size = new System.Drawing.Size(245, 40);
		this.Button42.TabIndex = 18;
		this.Button42.Text = "Button42";
		this.Button42.UseVisualStyleBackColor = true;
		this.TextBox19.AccessibleDescription = "";
		this.TextBox19.Location = new System.Drawing.Point(500, 19);
		this.TextBox19.Name = "TextBox19";
		this.TextBox19.Size = new System.Drawing.Size(156, 20);
		this.TextBox19.TabIndex = 17;
		this.TextBox19.Text = "id_envio (int)";
		this.Button41.Location = new System.Drawing.Point(662, 16);
		this.Button41.Name = "Button41";
		this.Button41.Size = new System.Drawing.Size(133, 24);
		this.Button41.TabIndex = 16;
		this.Button41.Text = "Test Cambia Fechas";
		this.Button41.UseVisualStyleBackColor = true;
		this.Button35.Location = new System.Drawing.Point(500, 126);
		this.Button35.Name = "Button35";
		this.Button35.Size = new System.Drawing.Size(214, 23);
		this.Button35.TabIndex = 15;
		this.Button35.Text = "Proxima Fecha Habil";
		this.Button35.UseVisualStyleBackColor = true;
		this.TextBox15.Location = new System.Drawing.Point(500, 45);
		this.TextBox15.Name = "TextBox15";
		this.TextBox15.Size = new System.Drawing.Size(100, 20);
		this.TextBox15.TabIndex = 14;
		this.Button34.Location = new System.Drawing.Point(603, 43);
		this.Button34.Name = "Button34";
		this.Button34.Size = new System.Drawing.Size(75, 23);
		this.Button34.TabIndex = 13;
		this.Button34.Text = "Aprobado";
		this.Button34.UseVisualStyleBackColor = true;
		this.Button33.Location = new System.Drawing.Point(720, 126);
		this.Button33.Name = "Button33";
		this.Button33.Size = new System.Drawing.Size(75, 23);
		this.Button33.TabIndex = 12;
		this.Button33.Text = "Etrans POS";
		this.Button33.UseVisualStyleBackColor = true;
		this.Button30.Location = new System.Drawing.Point(500, 245);
		this.Button30.Name = "Button30";
		this.Button30.Size = new System.Drawing.Size(295, 23);
		this.Button30.TabIndex = 11;
		this.Button30.Text = "Limpiar id_retiros";
		this.Button30.UseVisualStyleBackColor = true;
		this.Button29.Location = new System.Drawing.Point(500, 186);
		this.Button29.Name = "Button29";
		this.Button29.Size = new System.Drawing.Size(201, 23);
		this.Button29.TabIndex = 10;
		this.Button29.Text = "Insertar retiros etrans";
		this.Button29.UseVisualStyleBackColor = true;
		this.Button28.Location = new System.Drawing.Point(707, 186);
		this.Button28.Name = "Button28";
		this.Button28.Size = new System.Drawing.Size(88, 23);
		this.Button28.TabIndex = 9;
		this.Button28.Text = "Print";
		this.Button28.UseVisualStyleBackColor = true;
		this.TextBox13.Location = new System.Drawing.Point(500, 100);
		this.TextBox13.Name = "TextBox13";
		this.TextBox13.Size = new System.Drawing.Size(100, 20);
		this.TextBox13.TabIndex = 8;
		this.Button27.Location = new System.Drawing.Point(500, 71);
		this.Button27.Name = "Button27";
		this.Button27.Size = new System.Drawing.Size(229, 23);
		this.Button27.TabIndex = 7;
		this.Button27.Text = "Button27";
		this.Button27.UseVisualStyleBackColor = true;
		this.Button26.Location = new System.Drawing.Point(603, 98);
		this.Button26.Name = "Button26";
		this.Button26.Size = new System.Drawing.Size(192, 23);
		this.Button26.TabIndex = 6;
		this.Button26.Text = "sql insert etrans";
		this.Button26.UseVisualStyleBackColor = true;
		this.Button25.Location = new System.Drawing.Point(707, 215);
		this.Button25.Name = "Button25";
		this.Button25.Size = new System.Drawing.Size(88, 23);
		this.Button25.TabIndex = 5;
		this.Button25.Text = "chat";
		this.Button25.UseVisualStyleBackColor = true;
		this.Button24.Location = new System.Drawing.Point(500, 213);
		this.Button24.Name = "Button24";
		this.Button24.Size = new System.Drawing.Size(201, 27);
		this.Button24.TabIndex = 4;
		this.Button24.Text = "Boton test tablas .. INSERT";
		this.Button24.UseVisualStyleBackColor = true;
		this.Button23.Location = new System.Drawing.Point(675, 155);
		this.Button23.Name = "Button23";
		this.Button23.Size = new System.Drawing.Size(120, 23);
		this.Button23.TabIndex = 3;
		this.Button23.Text = "Calculos";
		this.Button23.UseVisualStyleBackColor = true;
		this.Label17.AutoSize = true;
		this.Label17.Location = new System.Drawing.Point(497, 160);
		this.Label17.Name = "Label17";
		this.Label17.Size = new System.Drawing.Size(66, 13);
		this.Label17.TabIndex = 2;
		this.Label17.Text = "Num Chofer:";
		this.TextBox12.Location = new System.Drawing.Point(569, 157);
		this.TextBox12.Name = "TextBox12";
		this.TextBox12.Size = new System.Drawing.Size(100, 20);
		this.TextBox12.TabIndex = 1;
		this.Button21.Location = new System.Drawing.Point(735, 71);
		this.Button21.Name = "Button21";
		this.Button21.Size = new System.Drawing.Size(60, 23);
		this.Button21.TabIndex = 0;
		this.Button21.Text = "Contar";
		this.Button21.UseVisualStyleBackColor = true;
		this.TabPage13.BackColor = System.Drawing.SystemColors.Control;
		this.TabPage13.Controls.Add(this.Button40);
		this.TabPage13.Controls.Add(this.Button38);
		this.TabPage13.Controls.Add(this.Button31);
		this.TabPage13.Location = new System.Drawing.Point(4, 22);
		this.TabPage13.Name = "TabPage13";
		this.TabPage13.Padding = new System.Windows.Forms.Padding(3);
		this.TabPage13.Size = new System.Drawing.Size(828, 286);
		this.TabPage13.TabIndex = 12;
		this.TabPage13.Text = "CSV";
		this.Button40.Location = new System.Drawing.Point(120, 48);
		this.Button40.Name = "Button40";
		this.Button40.Size = new System.Drawing.Size(75, 23);
		this.Button40.TabIndex = 2;
		this.Button40.Text = "Button40";
		this.Button40.UseVisualStyleBackColor = true;
		this.Button38.Location = new System.Drawing.Point(506, 129);
		this.Button38.Name = "Button38";
		this.Button38.Size = new System.Drawing.Size(228, 23);
		this.Button38.TabIndex = 1;
		this.Button38.Text = "Borrar dup";
		this.Button38.UseVisualStyleBackColor = true;
		this.Button31.Location = new System.Drawing.Point(506, 53);
		this.Button31.Name = "Button31";
		this.Button31.Size = new System.Drawing.Size(228, 23);
		this.Button31.TabIndex = 0;
		this.Button31.Text = "Crear CSV";
		this.Button31.UseVisualStyleBackColor = true;
		this.TabPage14.Controls.Add(this.Button39);
		this.TabPage14.Controls.Add(this.Button37);
		this.TabPage14.Controls.Add(this.Button36);
		this.TabPage14.Controls.Add(this.Label20);
		this.TabPage14.Controls.Add(this.Label19);
		this.TabPage14.Controls.Add(this.Label18);
		this.TabPage14.Controls.Add(this.TextBox18);
		this.TabPage14.Controls.Add(this.TextBox17);
		this.TabPage14.Controls.Add(this.TextBox16);
		this.TabPage14.Location = new System.Drawing.Point(4, 22);
		this.TabPage14.Name = "TabPage14";
		this.TabPage14.Padding = new System.Windows.Forms.Padding(3);
		this.TabPage14.Size = new System.Drawing.Size(828, 286);
		this.TabPage14.TabIndex = 13;
		this.TabPage14.Text = "EQUIPOS";
		this.TabPage14.UseVisualStyleBackColor = true;
		this.Button39.Location = new System.Drawing.Point(556, 192);
		this.Button39.Name = "Button39";
		this.Button39.Size = new System.Drawing.Size(164, 23);
		this.Button39.TabIndex = 8;
		this.Button39.Text = "Button39";
		this.Button39.UseVisualStyleBackColor = true;
		this.Button37.Location = new System.Drawing.Point(31, 38);
		this.Button37.Name = "Button37";
		this.Button37.Size = new System.Drawing.Size(232, 23);
		this.Button37.TabIndex = 7;
		this.Button37.Text = "Cancelar Envios Facu WEB";
		this.Button37.UseVisualStyleBackColor = true;
		this.Button36.Location = new System.Drawing.Point(387, 199);
		this.Button36.Name = "Button36";
		this.Button36.Size = new System.Drawing.Size(75, 23);
		this.Button36.TabIndex = 6;
		this.Button36.Text = "Insertar";
		this.Button36.UseVisualStyleBackColor = true;
		this.Label20.AutoSize = true;
		this.Label20.Location = new System.Drawing.Point(387, 141);
		this.Label20.Name = "Label20";
		this.Label20.Size = new System.Drawing.Size(33, 13);
		this.Label20.TabIndex = 5;
		this.Label20.Text = "Linea";
		this.Label19.AutoSize = true;
		this.Label19.Location = new System.Drawing.Point(387, 98);
		this.Label19.Name = "Label19";
		this.Label19.Size = new System.Drawing.Size(29, 13);
		this.Label19.TabIndex = 4;
		this.Label19.Text = "IMEI";
		this.Label18.AutoSize = true;
		this.Label18.Location = new System.Drawing.Point(382, 63);
		this.Label18.Name = "Label18";
		this.Label18.Size = new System.Drawing.Size(38, 13);
		this.Label18.TabIndex = 3;
		this.Label18.Text = "Chofer";
		this.TextBox18.Location = new System.Drawing.Point(437, 138);
		this.TextBox18.Name = "TextBox18";
		this.TextBox18.Size = new System.Drawing.Size(100, 20);
		this.TextBox18.TabIndex = 2;
		this.TextBox17.Location = new System.Drawing.Point(434, 95);
		this.TextBox17.Name = "TextBox17";
		this.TextBox17.Size = new System.Drawing.Size(100, 20);
		this.TextBox17.TabIndex = 1;
		this.TextBox16.Location = new System.Drawing.Point(432, 60);
		this.TextBox16.Name = "TextBox16";
		this.TextBox16.Size = new System.Drawing.Size(100, 20);
		this.TextBox16.TabIndex = 0;
		this.TabPage15.Controls.Add(this.Button47);
		this.TabPage15.Controls.Add(this.Button46);
		this.TabPage15.Controls.Add(this.Button45);
		this.TabPage15.Controls.Add(this.DateTimePicker1);
		this.TabPage15.Controls.Add(this.Button44);
		this.TabPage15.Controls.Add(this.TextBox20);
		this.TabPage15.Controls.Add(this.Label21);
		this.TabPage15.Controls.Add(this.Button43);
		this.TabPage15.Location = new System.Drawing.Point(4, 22);
		this.TabPage15.Name = "TabPage15";
		this.TabPage15.Size = new System.Drawing.Size(828, 286);
		this.TabPage15.TabIndex = 14;
		this.TabPage15.Text = "Posicionar";
		this.TabPage15.UseVisualStyleBackColor = true;
		this.Button47.Location = new System.Drawing.Point(466, 18);
		this.Button47.Name = "Button47";
		this.Button47.Size = new System.Drawing.Size(330, 23);
		this.Button47.TabIndex = 7;
		this.Button47.Text = "RePosicionar Eventuales";
		this.Button47.UseVisualStyleBackColor = true;
		this.Button46.Location = new System.Drawing.Point(29, 158);
		this.Button46.Name = "Button46";
		this.Button46.Size = new System.Drawing.Size(288, 23);
		this.Button46.TabIndex = 6;
		this.Button46.Text = "A CD";
		this.Button46.UseVisualStyleBackColor = true;
		this.Button45.Location = new System.Drawing.Point(29, 201);
		this.Button45.Name = "Button45";
		this.Button45.Size = new System.Drawing.Size(288, 23);
		this.Button45.TabIndex = 5;
		this.Button45.Text = "Devolver Al Remitente";
		this.Button45.UseVisualStyleBackColor = true;
		this.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
		this.DateTimePicker1.Location = new System.Drawing.Point(526, 130);
		this.DateTimePicker1.Name = "DateTimePicker1";
		this.DateTimePicker1.Size = new System.Drawing.Size(119, 20);
		this.DateTimePicker1.TabIndex = 4;
		this.Button44.Location = new System.Drawing.Point(377, 201);
		this.Button44.Name = "Button44";
		this.Button44.Size = new System.Drawing.Size(396, 23);
		this.Button44.TabIndex = 3;
		this.Button44.Text = "Devueltos";
		this.Button44.UseVisualStyleBackColor = true;
		this.TextBox20.Location = new System.Drawing.Point(105, 40);
		this.TextBox20.Name = "TextBox20";
		this.TextBox20.Size = new System.Drawing.Size(100, 20);
		this.TextBox20.TabIndex = 2;
		this.Label21.AutoSize = true;
		this.Label21.Location = new System.Drawing.Point(243, 40);
		this.Label21.Name = "Label21";
		this.Label21.Size = new System.Drawing.Size(45, 13);
		this.Label21.TabIndex = 1;
		this.Label21.Text = "Label21";
		this.Button43.Location = new System.Drawing.Point(29, 121);
		this.Button43.Name = "Button43";
		this.Button43.Size = new System.Drawing.Size(288, 29);
		this.Button43.TabIndex = 0;
		this.Button43.Text = "Posicionar";
		this.Button43.UseVisualStyleBackColor = true;
		this.TabPage16.Location = new System.Drawing.Point(4, 22);
		this.TabPage16.Name = "TabPage16";
		this.TabPage16.Padding = new System.Windows.Forms.Padding(3);
		this.TabPage16.Size = new System.Drawing.Size(828, 286);
		this.TabPage16.TabIndex = 15;
		this.TabPage16.Text = "Estadistico";
		this.TabPage16.UseVisualStyleBackColor = true;
		this.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.PictureBox1.Location = new System.Drawing.Point(820, 0);
		this.PictureBox1.Name = "PictureBox1";
		this.PictureBox1.Size = new System.Drawing.Size(35, 25);
		this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.PictureBox1.TabIndex = 29;
		this.PictureBox1.TabStop = false;
		this.PictureBox1.Visible = false;
		this.Button59.Location = new System.Drawing.Point(119, 137);
		this.Button59.Name = "Button59";
		this.Button59.Size = new System.Drawing.Size(75, 23);
		this.Button59.TabIndex = 0;
		this.Button59.Text = "Calcular";
		this.Button59.UseVisualStyleBackColor = true;
		this.GroupBox5.Controls.Add(this.TextBox22);
		this.GroupBox5.Controls.Add(this.Label25);
		this.GroupBox5.Controls.Add(this.Label24);
		this.GroupBox5.Controls.Add(this.Button59);
		this.GroupBox5.Controls.Add(this.Label23);
		this.GroupBox5.Location = new System.Drawing.Point(6, 6);
		this.GroupBox5.Name = "GroupBox5";
		this.GroupBox5.Size = new System.Drawing.Size(200, 166);
		this.GroupBox5.TabIndex = 1;
		this.GroupBox5.TabStop = false;
		this.GroupBox5.Text = "Calculo de Pedido";
		this.Label23.AutoSize = true;
		this.Label23.Location = new System.Drawing.Point(67, 30);
		this.Label23.Name = "Label23";
		this.Label23.Size = new System.Drawing.Size(70, 13);
		this.Label23.TabIndex = 0;
		this.Label23.Text = "18 Un X Caja";
		this.Label24.AutoSize = true;
		this.Label24.Location = new System.Drawing.Point(67, 52);
		this.Label24.Name = "Label24";
		this.Label24.Size = new System.Drawing.Size(67, 13);
		this.Label24.TabIndex = 1;
		this.Label24.Text = "3 Un X Inner";
		this.Label25.AutoSize = true;
		this.Label25.Location = new System.Drawing.Point(6, 95);
		this.Label25.Name = "Label25";
		this.Label25.Size = new System.Drawing.Size(78, 13);
		this.Label25.TabIndex = 2;
		this.Label25.Text = "Un Solicitadas:";
		this.TextBox22.Location = new System.Drawing.Point(90, 92);
		this.TextBox22.Name = "TextBox22";
		this.TextBox22.Size = new System.Drawing.Size(100, 20);
		this.TextBox22.TabIndex = 3;
		base.AcceptButton = this.Button3;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.AutoSize = true;
		base.CancelButton = this.Button3;
		base.ClientSize = new System.Drawing.Size(851, 417);
		base.Controls.Add(this.PictureBox1);
		base.Controls.Add(this.GroupBox1);
		base.Controls.Add(this.ToolStrip1);
		base.Controls.Add(this.Button3);
		base.Controls.Add(this.StatusStrip1);
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.Name = "Form2_AdmDB";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Administrador de Base de Datos";
		this.GroupBox1.ResumeLayout(false);
		this.Panel1.ResumeLayout(false);
		this.TabControl1.ResumeLayout(false);
		this.TabPage12.ResumeLayout(false);
		this.EcommerceTab.ResumeLayout(false);
		this.EcommerceTab.PerformLayout();
		this.TabPage6.ResumeLayout(false);
		this.TabPage6.PerformLayout();
		this.TabPage1.ResumeLayout(false);
		this.TabPage2.ResumeLayout(false);
		this.GroupBox2.ResumeLayout(false);
		this.TabPage3.ResumeLayout(false);
		this.TabPage4.ResumeLayout(false);
		this.TabPage4.PerformLayout();
		this.TabPage7.ResumeLayout(false);
		this.TabPage7.PerformLayout();
		this.TabPage8.ResumeLayout(false);
		this.TabPage8.PerformLayout();
		this.TabPage9.ResumeLayout(false);
		this.GroupBox4.ResumeLayout(false);
		this.GroupBox4.PerformLayout();
		this.GroupBox3.ResumeLayout(false);
		this.GroupBox3.PerformLayout();
		this.TabPage10.ResumeLayout(false);
		this.TabPage10.PerformLayout();
		this.TabPage11.ResumeLayout(false);
		this.TabPage11.PerformLayout();
		this.TabPage13.ResumeLayout(false);
		this.TabPage14.ResumeLayout(false);
		this.TabPage14.PerformLayout();
		this.TabPage15.ResumeLayout(false);
		this.TabPage15.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
		this.GroupBox5.ResumeLayout(false);
		this.GroupBox5.PerformLayout();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private void Form2_AdmDB_Load(object sender, EventArgs e)
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		ComboBox2.Items.Clear();
		Label16.Text = Conversions.ToString(MySettingsProperty.Settings.version);
		Mod_Tareas_comunes.lista_de_tablas(ComboBox3);
		Mod_Tareas_comunes.lv_de_tablas(ListView4);
		loadchoferes();
		checked
		{
			try
			{
				string commandText = "SHOW TABLES FROM " + Mod_Sentencias.baseDD;
				Mod_Sentencias.cnn.Open();
				PictureBox1.Visible = true;
				MySqlCommand val = new MySqlCommand();
				MySqlCommand val2 = val;
				val2.CommandType = CommandType.Text;
				val2.CommandText = commandText;
				val2.Connection = Mod_Sentencias.cnn;
				val2 = null;
				MySqlDataAdapter val3 = new MySqlDataAdapter();
				DataSet dataSet = new DataSet();
				val3.SelectCommand = val;
				((DbDataAdapter)(object)val3).Fill(dataSet, "Tabla");
				ListView listView = ListView3;
				listView.Items.Clear();
				listView.Columns.Clear();
				listView.View = View.Details;
				listView.GridLines = true;
				listView.FullRowSelect = true;
				int num = dataSet.Tables["tabla"].Columns.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					listView.Columns.Add(dataSet.Tables["tabla"].Columns[i].Caption);
				}
				listView = null;
				DataTable dataTable = dataSet.Tables["tabla"];
				int num2 = dataTable.Rows.Count - 1;
				for (int j = 0; j <= num2; j++)
				{
					ListViewItem listViewItem = new ListViewItem(dataTable.Rows[j][0].ToString());
					int num3 = dataTable.Columns.Count - 1;
					for (int k = 1; k <= num3; k++)
					{
						listViewItem.SubItems.Add(dataTable.Rows[j][k].ToString());
					}
					ListView3.Items.Add(listViewItem);
					ComboBox2.Items.Add(dataTable.Rows[j][0].ToString());
				}
				dataTable = null;
				ListView listView2 = ListView3;
				int num4 = dataSet.Tables["tabla"].Columns.Count - 1;
				for (int l = 0; l <= num4; l++)
				{
					listView2.AutoResizeColumn(l, ColumnHeaderAutoResizeStyle.ColumnContent);
				}
				listView2 = null;
				Mod_Sentencias.cnn.Close();
				PictureBox1.Visible = false;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				PictureBox1.Visible = false;
				Mod_Sentencias.cnn.Close();
				Interaction.MsgBox(ex2.Message);
				ProjectData.ClearProjectError();
			}
			TextBox4.Text = MySettingsProperty.Settings.ftpupurl;
			TextBox5.Text = MySettingsProperty.Settings.ftpupusuario;
			TextBox6.Text = MySettingsProperty.Settings.ftpuppass;
			TextBox10.Text = MySettingsProperty.Settings.ftpuplink;
		}
	}

	private void Button3_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void Button5_Click(object sender, EventArgs e)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		checked
		{
			try
			{
				string commandText = "SELECT * FROM " + ComboBox2.Text;
				Mod_Sentencias.cnn.Open();
				PictureBox1.Visible = true;
				MySqlCommand val = new MySqlCommand();
				MySqlCommand val2 = val;
				val2.CommandType = CommandType.Text;
				val2.CommandText = commandText;
				val2.Connection = Mod_Sentencias.cnn;
				val2 = null;
				MySqlDataAdapter val3 = new MySqlDataAdapter();
				DataSet dataSet = new DataSet();
				val3.SelectCommand = val;
				((DbDataAdapter)(object)val3).Fill(dataSet, "Tabla");
				ListView listView = ListView1;
				listView.Items.Clear();
				listView.Columns.Clear();
				listView.View = View.Details;
				listView.GridLines = true;
				listView.FullRowSelect = true;
				int num = dataSet.Tables["tabla"].Columns.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					listView.Columns.Add(dataSet.Tables["tabla"].Columns[i].Caption);
				}
				listView = null;
				DataTable dataTable = dataSet.Tables["tabla"];
				int num2 = dataTable.Rows.Count - 1;
				for (int j = 0; j <= num2; j++)
				{
					ListViewItem listViewItem = new ListViewItem(dataTable.Rows[j][0].ToString());
					int num3 = dataTable.Columns.Count - 1;
					for (int k = 1; k <= num3; k++)
					{
						listViewItem.SubItems.Add(dataTable.Rows[j][k].ToString());
					}
					ListView1.Items.Add(listViewItem);
				}
				dataTable = null;
				ListView listView2 = ListView1;
				int num4 = dataSet.Tables["tabla"].Columns.Count - 1;
				for (int l = 0; l <= num4; l++)
				{
					listView2.AutoResizeColumn(l, ColumnHeaderAutoResizeStyle.ColumnContent);
				}
				listView2 = null;
				ToolStripStatusLabel1.Text = Conversions.ToString(ListView1.Items.Count);
				Mod_Sentencias.cnn.Close();
				PictureBox1.Visible = false;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				PictureBox1.Visible = false;
				Mod_Sentencias.cnn.Close();
				Interaction.MsgBox(ex2.Message);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void creartablabtn_Click(object sender, EventArgs e)
	{
		checked
		{
			if (CheckBox1.Checked)
			{
				int num = ComboBox3.Items.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					try
					{
						ToolStripStatusLabel1.Text = "Creando tablas....";
						string methodName = ComboBox3.Items[i].ToString();
						Versioned.CallByName(this, methodName, CallType.Method);
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						Interaction.MsgBox("No se pudo crear la Tabla " + ComboBox3.Items[i].ToString() + ", es probable que ya exista");
						ProjectData.ClearProjectError();
					}
				}
				Interaction.MsgBox("Las tablas fueron creadas correctamente");
			}
			else
			{
				string methodName2 = ComboBox3.Text;
				Versioned.CallByName(this, methodName2, CallType.Method);
				Interaction.MsgBox("Tabla " + ComboBox3.Text + " Creada");
			}
		}
	}

	private void borrartablabtn_Click(object sender, EventArgs e)
	{
		try
		{
			ToolStripStatusLabel1.Text = "Borrando Tabla...";
			string text = ComboBox3.Text;
			string sQL = "DROP TABLE " + text;
			Mod_ConeccionBD.BD_Sentencia(sQL);
			Interaction.MsgBox("Tabla " + text + " Eliminada");
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox(ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	public void Usuarios()
	{
		try
		{
			string sQL = "CREATE TABLE Usuarios (ID bigint not null unique auto_increment, Usuario  VARCHAR(255), Password  VARCHAR(255), Permiso  int, Imports VARCHAR(255)) ";
			Mod_ConeccionBD.BD_Sentencia(sQL);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox(ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	public void Novedades()
	{
		try
		{
			string sQL = "CREATE TABLE Novedades (ID bigint not null unique auto_increment, Comprobante char(255) unique, Novedad CHAR(255), Estado CHAR(255), Fecha Date, Comentario CHAR(255),Usuario char(255))";
			Mod_ConeccionBD.BD_Sentencia(sQL);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox(ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	public void Historial()
	{
		try
		{
			string sQL = "CREATE TABLE Historial (ID bigint not null unique auto_increment, Comprobante char(255), Novedad CHAR(255), Estado CHAR(255), Fecha TIMESTAMP, Comentario CHAR(255), Usuario char(255))";
			Mod_ConeccionBD.BD_Sentencia(sQL);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox(ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	public void Logg()
	{
		try
		{
			string sQL = "CREATE TABLE Logger (ID bigint Not null unique auto_increment, Sentencia char(255), Error CHAR(255), Fecha Date, Usuario char(255))";
			Mod_ConeccionBD.BD_Sentencia(sQL);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox(ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	public void Estados()
	{
		try
		{
			string sQL = "CREATE TABLE Estados (ID int Not null unique auto_increment, Motivo  int, Estado  CHAR(255), Comentario CHAR(255))";
			Mod_ConeccionBD.BD_Sentencia(sQL);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox(ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	public void chat()
	{
		try
		{
			string sQL = "CREATE TABLE chat (ID int Not null unique auto_increment, comentario  varchar(255), usuario varchar(25), fecha datetime)";
			Mod_ConeccionBD.BD_Sentencia(sQL);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox(ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	public void Viajes()
	{
		try
		{
			string sQL = "CREATE TABLE viajes (ID int Not null unique auto_increment, Chofer  int, Categoria int, Ventana int, Puntos int, Bultos int, Peso float, Declarado float, Flete float, Costo float, usuario varchar(25), fecha datetime)";
			Mod_ConeccionBD.BD_Sentencia(sQL);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox(ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	public void Clientes()
	{
		try
		{
			string sQL = "CREATE TABLE Clientes (ID int Not null unique auto_increment, Nombre  CHAR(255), Cuenta  int, Sub  int, Domicilio  CHAR(255), CP  int, Localidad  CHAR(255), Alto float, Largo  float, Ancho  float, Peso  float, Volumen  float, Pallet  float, BxP  float, Calcular bit, Horario CHAR(255), Contacto CHAR(255), Retiro float) ";
			Mod_ConeccionBD.BD_Sentencia(sQL);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox(ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	public void Planchada()
	{
		try
		{
			string sQL = "CREATE TABLE Planchada(Eventual int, Comprobante char(255), Cliente char(255), Remitos char(255), Destino char(255), Domicilio char(255), CP char(255), Localidad char(255), Declarado float, Bultos int, Kilos float, Sub char(255), Observaciones char(255), Volumen float, Atraso int, Diferida char(255), Flete float, Zona int, Adicional int, Prioridad int, Chofer int, Latitud float, Longitud float, Estado char(255), Fecha Date, Ventana int, Comentario char(255), Usuario char(255), Guia int UNSIGNED ZEROFILL Not NULL AUTO_INCREMENT,PRIMARY KEY (Guia))";
			Mod_ConeccionBD.BD_Sentencia(sQL);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox(ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	public void Flota()
	{
		try
		{
			string sQL = "CREATE TABLE Flota(ID bigint Not null unique auto_increment, Numero int, Categoria int, Chofer varchar(255), Disponible varchar(255), Tarifa float, Peso float, Volumen float, Estado varchar(255), GPS Varchar(255))";
			Mod_ConeccionBD.BD_Sentencia(sQL);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox(ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	public void estadoEnvio()
	{
		try
		{
			string sQL = "CREATE TABLE estadoEnvio(ID bigint Not null unique auto_increment, Numero Varchar(55), Estado Varchar(55), Fecha date)";
			Mod_ConeccionBD.BD_Sentencia(sQL);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox(ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	public void Equipos()
	{
		try
		{
			string sQL = "CREATE TABLE equipos(idEquipo bigint Not null unique auto_increment, chofer int, imei bigint(15), linea int,PRIMARY KEY (idEquipo))";
			switch (Conversions.ToInteger(Mod_ConeccionBD.BD_Sentencia(sQL)))
			{
			case 1:
				Interaction.MsgBox("Creado");
				break;
			case 2:
				Interaction.MsgBox("Existe un error");
				break;
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

	public void Retiros()
	{
		try
		{
			string sQL = "CREATE TABLE Retiros(ID int Not null unique auto_increment, Chofer VARCHAR(255), Cliente VARCHAR(255), Adicional int, Peajes float, Observaciones VARCHAR(255), Pallets int, Retiro float, Segunda int, Fecha date, Estado VARCHAR(255))";
			Mod_ConeccionBD.BD_Sentencia(sQL);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox(ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	public void Eventuales()
	{
		try
		{
			string sQL = "CREATE TABLE Eventuales(Cliente varchar(255), Eventual int Not null unique, Zona int, Domicilio varchar(255), Localidad varchar(255), CP varchar(255), Adicional int, Prioridad int, Sub varchar(255), Normalizada varchar(255), Latitud float, Longitud float, Franja int, Fecha date, Usuario varchar(55))";
			Mod_ConeccionBD.BD_Sentencia(sQL);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox(ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	public void Categorias()
	{
		try
		{
			string sQL = "CREATE TABLE Categorias(Categoria bigint Not null unique auto_increment, Descripcion Varchar(255), Tarifa_fija float, A_modelo float, otro float, Peso float, Volumen float, Valorbulto float, Valorpe float, BultosMaximo int, PuntosMaximo int, Rentabilidad float, Adicional_1 float, Adicional_2 float, Adicional_3 float, Adicional_4 float, Adicional_5 float, Retiro float)";
			Mod_ConeccionBD.BD_Sentencia(sQL);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox(ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	public void Adicionales()
	{
		try
		{
			string sQL = "CREATE TABLE Adicionales(Adicional bigint Not null unique auto_increment, Descripcion Varchar(255))";
			string sQL2 = "INSERT INTO Adicionales (Descripcion) VALUES ('Adicional')";
			Mod_ConeccionBD.BD_Sentencia(sQL);
			int num = 0;
			do
			{
				Mod_ConeccionBD.BD_Sentencia(sQL2);
				num = checked(num + 1);
			}
			while (num <= 4);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox(ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	public void Localidades()
	{
		try
		{
			string sQL = "CREATE TABLE Localidades (ID bigint not null unique auto_increment, Localidad  VARCHAR(255), CP  VARCHAR(255) not null unique, zona  int, Adicional int, Fecha date, Usuario VARCHAR (55)) ";
			Mod_ConeccionBD.BD_Sentencia(sQL);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox(ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	public void zonas()
	{
		try
		{
			string sQL = "CREATE TABLE Zonas (Zona bigint not null unique auto_increment, Descripcion  VARCHAR(255)) ";
			Mod_ConeccionBD.BD_Sentencia(sQL);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox(ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	public void planificado()
	{
		try
		{
			string sQL = "CREATE TABLE Planificado(id_planificado int UNSIGNED ZEROFILL NOT NULL AUTO_INCREMENT, Nombre char(255), Cat int, Puntos int, Bultos int, VD float, Peso float, Volumen float, Flete float, Tarifa float, Costo float, Fecha Date, Chofer int, Ventana int, Despachado int, PRIMARY KEY (id_planificado))";
			Mod_ConeccionBD.BD_Sentencia(sQL);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox(ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	public void etransEnvios()
	{
		try
		{
			string sQL = "CREATE TABLE etransEnvios(id_hermes int UNSIGNED ZEROFILL NOT NULL AUTO_INCREMENT, id_envio int NOT NULL UNIQUE, Bultos int, Volumen float, Kilos float, Flete float, Declarado float, Cliente varchar(125), U_mail varchar(125), U_telefono varchar(125), U_cel varchar(125), U_fecha Date, U_ventana int, U_calle varchar(125), U_numero_puerta varchar(125), U_piso varchar(25), U_dpto_oficina varchar(25), U_bloque_torre varchar(25), U_cp int, U_localidad varchar(125), U_provincia varchar(125), Destinatario varchar(125), D_mail varchar(125), D_telefono varchar(125), D_cel varchar(125), D_fecha Date, D_ventana int, D_calle varchar(125), D_numero_puerta varchar(125), D_piso varchar(25), D_dpto_oficina varchar(25), D_bloque_torre varchar(25), D_cp int, D_localidad varchar(125), D_provincia varchar(125), Observaciones varchar(125), numero_interno varchar(50), id_retiro int, estado varchar(125),PRIMARY KEY (id_hermes))";
			Mod_ConeccionBD.BD_Sentencia(sQL);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox(ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	public void Recepcion()
	{
		try
		{
			string sQL = "CREATE TABLE Recepcion (guia int NOT NULL UNIQUE, id_envio int NOT NULL UNIQUE, BultosTotal int, BultosRecep int, Estado VARCHAR(255), Observaciones VARCHAR(255), Fecha date, Usuario VARCHAR (55), PRIMARY KEY (guia)) ";
			Mod_ConeccionBD.BD_Sentencia(sQL);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox(ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	public void CSV()
	{
		try
		{
			string sQL = "CREATE TABLE CSV (guia int UNSIGNED ZEROFILL NOT NULL AUTO_INCREMENT, REMITO char(12), FECHA char(8), RS1_DEST char(25), DOM_DEST char(25), LOC_DEST char(4), DESCRIP char(20), KILOS decimal(9,3), BULTOS char(5), MT3 decimal(7,3), VALOR_DECL decimal(10,2), VALOR_CR decimal(10,2), PRIMARY KEY (guia)) ";
			Mod_ConeccionBD.BD_Sentencia(sQL);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox(ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void impdatosbtn_Click(object sender, EventArgs e)
	{
		//IL_0478: Unknown result type (might be due to invalid IL or missing references)
		//IL_047f: Expected O, but got Unknown
		OpenFileDialog openFileDialog = new OpenFileDialog();
		OpenFileDialog openFileDialog2 = openFileDialog;
		openFileDialog2.Filter = "Excel files(*.xls)|*xls|All files (*.*)|*.*";
		openFileDialog2.FilterIndex = 1;
		openFileDialog2.Title = "Import data from Excel file";
		openFileDialog2 = null;
		if (openFileDialog.ShowDialog() != DialogResult.OK)
		{
			return;
		}
		string fileName = openFileDialog.FileName;
		OleDbConnection oleDbConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source='" + fileName + " '; Extended Properties=Excel 8.0;");
		OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("select * from [Eventuales$]", oleDbConnection);
		oleDbDataAdapter.TableMappings.Add("Table", "Test");
		DataSet dataSet = new DataSet();
		oleDbDataAdapter.Fill(dataSet);
		oleDbConnection.Close();
		MyProject.Forms.Form1_Inicio.DateTimePicker1.Format = DateTimePickerFormat.Short;
		DateTime dateTime = Conversions.ToDate(MyProject.Forms.Form1_Inicio.DateTimePicker1.Text);
		Interaction.MsgBox(dateTime);
		base.Visible = false;
		MyProject.Forms.Loading.MdiParent = MyProject.Forms.Form1_Inicio;
		MyProject.Forms.Loading.Show();
		MyProject.Forms.Loading.Refresh();
		Mod_Sentencias.cnn.Open();
		MyProject.Forms.Loading.ProgressBar1.Maximum = dataSet.Tables[0].Rows.Count;
		checked
		{
			try
			{
				int num = dataSet.Tables[0].Rows.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					string text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("INSERT INTO Eventuales(Cliente, Eventual, Zona, Domicilio, Localidad, CP, Adicional, Prioridad, Sub, Normalizada, Latitud, Longitud, Franja, Fecha, Usuario) VALUES ('" + Strings.Replace(Conversions.ToString(dataSet.Tables[0].Rows[i][0]), "'", " ", 1, -1, CompareMethod.Text) + "', ", dataSet.Tables[0].Rows[i][1]), ","), dataSet.Tables[0].Rows[i][2]), ",'"), dataSet.Tables[0].Rows[i][3]), "','"), dataSet.Tables[0].Rows[i][4]), "','"), dataSet.Tables[0].Rows[i][5]), "',"), dataSet.Tables[0].Rows[i][6]), ","), dataSet.Tables[0].Rows[i][7]), ",'"), dataSet.Tables[0].Rows[i][8]), "','"), dataSet.Tables[0].Rows[i][9]), "',"), Strings.Replace(Conversions.ToString(dataSet.Tables[0].Rows[i][10]), ",", ".", 1, -1, CompareMethod.Text)), ","), Strings.Replace(Conversions.ToString(dataSet.Tables[0].Rows[i][11]), ",", ".", 1, -1, CompareMethod.Text)), ","), dataSet.Tables[0].Rows[i][12]), ",'"), Strings.Format(MyProject.Forms.Form1_Inicio.DateTimePicker1.Value, "yyyy/MM/dd")), "', '"), MyProject.Forms.Form1_Inicio.nombreusuario.Text), "')"));
					MySqlCommand val = new MySqlCommand(text, Mod_Sentencias.cnn);
					val.ExecuteNonQuery();
					MyProject.Forms.Loading.ProgressBar1.Value = MyProject.Forms.Loading.ProgressBar1.Value + 1;
				}
				Mod_Sentencias.cnn.Close();
				MyProject.Forms.Loading.Close();
				base.Visible = true;
				Interaction.MsgBox("Se importaron los datos");
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Mod_Sentencias.cnn.Close();
				MyProject.Forms.Loading.Close();
				base.Visible = true;
				Interaction.MsgBox(ex2.Message);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void ListView1_ColumnClick(object sender, ColumnClickEventArgs e)
	{
		Mod_Ordenaclumnas.ordenar_columnas(ListView1, RuntimeHelpers.GetObjectValue(sender), e);
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		//IL_0296: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Expected O, but got Unknown
		OpenFileDialog openFileDialog = new OpenFileDialog();
		OpenFileDialog openFileDialog2 = openFileDialog;
		openFileDialog2.Filter = "Excel files(*.xls)|*xls|All files (*.*)|*.*";
		openFileDialog2.FilterIndex = 1;
		openFileDialog2.Title = "Import data from Excel file";
		openFileDialog2 = null;
		if (openFileDialog.ShowDialog() != DialogResult.OK)
		{
			return;
		}
		string fileName = openFileDialog.FileName;
		OleDbConnection oleDbConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source='" + fileName + " '; Extended Properties=Excel 8.0;");
		OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("select * from [Localidades$]", oleDbConnection);
		oleDbDataAdapter.TableMappings.Add("Table", "Test");
		DataSet dataSet = new DataSet();
		oleDbDataAdapter.Fill(dataSet);
		oleDbConnection.Close();
		MyProject.Forms.Form1_Inicio.DateTimePicker1.Format = DateTimePickerFormat.Short;
		DateTime dateTime = Conversions.ToDate(MyProject.Forms.Form1_Inicio.DateTimePicker1.Text);
		Interaction.MsgBox(dateTime);
		base.Visible = false;
		MyProject.Forms.Loading.MdiParent = MyProject.Forms.Form1_Inicio;
		MyProject.Forms.Loading.Show();
		MyProject.Forms.Loading.Refresh();
		Mod_Sentencias.cnn.Open();
		MyProject.Forms.Loading.ProgressBar1.Maximum = dataSet.Tables[0].Rows.Count;
		checked
		{
			try
			{
				int num = dataSet.Tables[0].Rows.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					string text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("INSERT INTO Localidades(Localidad,CP,zona,Adicional,Fecha, Usuario) VALUES ('", dataSet.Tables[0].Rows[i][0]), "', "), dataSet.Tables[0].Rows[i][1]), ","), dataSet.Tables[0].Rows[i][2]), ",'"), dataSet.Tables[0].Rows[i][3]), "','"), Strings.Format(MyProject.Forms.Form1_Inicio.DateTimePicker1.Value, "yyyy/MM/dd")), "', '"), MyProject.Forms.Form1_Inicio.nombreusuario.Text), "')"));
					MySqlCommand val = new MySqlCommand(text, Mod_Sentencias.cnn);
					val.ExecuteNonQuery();
					MyProject.Forms.Loading.ProgressBar1.Value = MyProject.Forms.Loading.ProgressBar1.Value + 1;
				}
				Mod_Sentencias.cnn.Close();
				MyProject.Forms.Loading.Close();
				base.Visible = true;
				Interaction.MsgBox("Se importaron los datos");
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Mod_Sentencias.cnn.Close();
				MyProject.Forms.Loading.Close();
				base.Visible = true;
				Interaction.MsgBox(ex2.Message);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Expected O, but got Unknown
		checked
		{
			try
			{
				OpenFileDialog openFileDialog = new OpenFileDialog();
				OpenFileDialog openFileDialog2 = openFileDialog;
				openFileDialog2.Filter = "Excel files(*.xls)|*xls|All files (*.*)|*.*";
				openFileDialog2.FilterIndex = 1;
				openFileDialog2.Title = "Import data from Excel file";
				openFileDialog2 = null;
				if (openFileDialog.ShowDialog() != DialogResult.OK)
				{
					return;
				}
				string fileName = openFileDialog.FileName;
				OleDbConnection oleDbConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source='" + fileName + " '; Extended Properties=Excel 8.0;");
				OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("select * from [Zonas$]", oleDbConnection);
				oleDbDataAdapter.TableMappings.Add("Table", "Test");
				DataSet dataSet = new DataSet();
				oleDbDataAdapter.Fill(dataSet);
				oleDbConnection.Close();
				MyProject.Forms.Form1_Inicio.DateTimePicker1.Format = DateTimePickerFormat.Short;
				DateTime dateTime = Conversions.ToDate(MyProject.Forms.Form1_Inicio.DateTimePicker1.Text);
				Interaction.MsgBox(dateTime);
				base.Visible = false;
				MyProject.Forms.Loading.MdiParent = MyProject.Forms.Form1_Inicio;
				MyProject.Forms.Loading.Show();
				MyProject.Forms.Loading.Refresh();
				Mod_Sentencias.cnn.Open();
				MyProject.Forms.Loading.ProgressBar1.Maximum = dataSet.Tables[0].Rows.Count;
				try
				{
					int num = dataSet.Tables[0].Rows.Count - 1;
					for (int i = 0; i <= num; i++)
					{
						string text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("INSERT INTO Zonas(Descripcion) VALUES ('", dataSet.Tables[0].Rows[i][0]), "')"));
						MySqlCommand val = new MySqlCommand(text, Mod_Sentencias.cnn);
						val.ExecuteNonQuery();
						MyProject.Forms.Loading.ProgressBar1.Value = MyProject.Forms.Loading.ProgressBar1.Value + 1;
					}
					Mod_Sentencias.cnn.Close();
					MyProject.Forms.Loading.Close();
					base.Visible = true;
					Interaction.MsgBox("Se importaron los datos");
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					Mod_Sentencias.cnn.Close();
					MyProject.Forms.Loading.Close();
					base.Visible = true;
					Interaction.MsgBox(ex2.Message);
					ProjectData.ClearProjectError();
				}
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				Interaction.MsgBox(ex4.Message);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void Button4_Click(object sender, EventArgs e)
	{
		//IL_036d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0374: Expected O, but got Unknown
		checked
		{
			try
			{
				OpenFileDialog openFileDialog = new OpenFileDialog();
				OpenFileDialog openFileDialog2 = openFileDialog;
				openFileDialog2.Filter = "Excel files(*.xls)|*xls|All files (*.*)|*.*";
				openFileDialog2.FilterIndex = 1;
				openFileDialog2.Title = "Import data from Excel file";
				openFileDialog2 = null;
				if (openFileDialog.ShowDialog() != DialogResult.OK)
				{
					return;
				}
				string fileName = openFileDialog.FileName;
				OleDbConnection oleDbConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source='" + fileName + " '; Extended Properties=Excel 8.0;");
				OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("select * from [Flota$]", oleDbConnection);
				oleDbDataAdapter.TableMappings.Add("Table", "Test");
				DataSet dataSet = new DataSet();
				oleDbDataAdapter.Fill(dataSet);
				oleDbConnection.Close();
				MyProject.Forms.Form1_Inicio.DateTimePicker1.Format = DateTimePickerFormat.Short;
				DateTime dateTime = Conversions.ToDate(MyProject.Forms.Form1_Inicio.DateTimePicker1.Text);
				Interaction.MsgBox(dateTime);
				base.Visible = false;
				MyProject.Forms.Loading.MdiParent = MyProject.Forms.Form1_Inicio;
				MyProject.Forms.Loading.Show();
				MyProject.Forms.Loading.Refresh();
				Mod_Sentencias.cnn.Open();
				MyProject.Forms.Loading.ProgressBar1.Maximum = dataSet.Tables[0].Rows.Count;
				try
				{
					int num = dataSet.Tables[0].Rows.Count - 1;
					for (int i = 0; i <= num; i++)
					{
						string text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("INSERT INTO Flota(Numero,Categoria,Chofer,Disponible,Tarifa, Peso, Volumen, Estado, GPS) VALUES (", dataSet.Tables[0].Rows[i][0]), ","), dataSet.Tables[0].Rows[i][1]), ",'"), dataSet.Tables[0].Rows[i][2]), "','"), dataSet.Tables[0].Rows[i][3]), "',"), Strings.Replace(Conversions.ToString(dataSet.Tables[0].Rows[i][4]), ",", ".", 1, -1, CompareMethod.Text)), ","), Strings.Replace(Conversions.ToString(dataSet.Tables[0].Rows[i][5]), ",", ".", 1, -1, CompareMethod.Text)), ","), Strings.Replace(Conversions.ToString(dataSet.Tables[0].Rows[i][6]), ",", ".", 1, -1, CompareMethod.Text)), ",'"), dataSet.Tables[0].Rows[i][7]), "','"), dataSet.Tables[0].Rows[i][8]), "')"));
						MySqlCommand val = new MySqlCommand(text, Mod_Sentencias.cnn);
						val.ExecuteNonQuery();
						MyProject.Forms.Loading.ProgressBar1.Value = MyProject.Forms.Loading.ProgressBar1.Value + 1;
					}
					Mod_Sentencias.cnn.Close();
					MyProject.Forms.Loading.Close();
					base.Visible = true;
					Interaction.MsgBox("Se importaron los datos");
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					Mod_Sentencias.cnn.Close();
					MyProject.Forms.Loading.Close();
					base.Visible = true;
					Interaction.MsgBox(ex2.Message);
					ProjectData.ClearProjectError();
				}
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				Interaction.MsgBox(ex4.Message);
				ProjectData.ClearProjectError();
			}
		}
	}

	public void Dibujos()
	{
		try
		{
			string sQL = "CREATE TABLE Dibujos(ID int not null unique auto_increment, Zona int, Punto int, Descripcion varchar(255), Latitud float, Longitud float, Color int)";
			Mod_ConeccionBD.BD_Sentencia(sQL);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox(ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	public void Vehiculos()
	{
		try
		{
			string sQL = "CREATE TABLE Vehiculos(ID int not null unique auto_increment, Numero int, Patente char(255),Categoria int, Chofer char(255), Disponible char(255), Tarifa float, Peso float, Volumen float, Estado char(255), Ano int, Marca char(255),Modelo char(255),Adicional int,GPS char(255),Tipo char(255),zona int,seguro date,senasa date,vtv date,ruta date,Alta date,Baja date,Modificacion date,Usuario char(255))";
			Mod_ConeccionBD.BD_Sentencia(sQL);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox(ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	public void Choferes()
	{
		try
		{
			string sQL = "CREATE TABLE Choferes(ID int not null unique auto_increment, Numero int, Nombre char(255), Patente char(255),dni char(255),cel char(255),registro char(255),nextel char(255),telefono char(255),vencregistro date,venlicencia date,venart date,vencargagen date,venapto date,ven931 date,Alta date,Baja date,Modificado date, Usuario char(255))";
			Mod_ConeccionBD.BD_Sentencia(sQL);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox(ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	public void feriados()
	{
		try
		{
			string sQL = "CREATE TABLE Feriados(ID int not null unique auto_increment, fecha DATE,descripcion VARCHAR(255),Usuario char(255))";
			Mod_ConeccionBD.BD_Sentencia(sQL);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox(ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void Button7_Click(object sender, EventArgs e)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		string text = "select COUNT(Guia) as total from planchada";
		DataTable dataTable = new DataTable("x");
		MySqlDataAdapter val = new MySqlDataAdapter(text, Mod_Sentencias.cnn);
		((DbDataAdapter)(object)val).Fill(dataTable);
		int num = Conversions.ToInteger(dataTable.Rows[0]["total"]);
		Interaction.MsgBox(RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["total"]));
	}

	private void Button9_Click(object sender, EventArgs e)
	{
		Mod_Enviar_mails.enviar_mail();
	}

	private void Button10_Click(object sender, EventArgs e)
	{
		string subject = TextBox3.Text.ToString();
		string text = "Prueba";
		string body = text + "\rEnviado desde HERMES";
		string emailAddress = TextBox2.Text.ToString();
		Mod_Enviar_mails.OpenEmail(emailAddress, subject, body);
	}

	private void loadchoferes()
	{
		string sql = "select * from usuarios";
		Mod_Sentencias.cargar_datos_lv_completa(ListView2, sql, Label4);
	}

	private void ListView2_ItemChecked(object sender, ItemCheckedEventArgs e)
	{
		Label5.Text = Conversions.ToString(ListView2.CheckedItems.Count);
	}

	private void Button11_Click(object sender, EventArgs e)
	{
		checked
		{
			int num = ListView2.CheckedItems.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				Interaction.MsgBox(ListView2.CheckedItems[i].SubItems[1].Text);
			}
		}
	}

	private void Button12_Click(object sender, EventArgs e)
	{
	}

	private void Button13_Click(object sender, EventArgs e)
	{
		try
		{
			MySettingsProperty.Settings.ftpupurl = TextBox4.Text;
			MySettingsProperty.Settings.ftpupusuario = TextBox5.Text;
			MySettingsProperty.Settings.ftpuppass = TextBox6.Text;
			MySettingsProperty.Settings.ftpuplink = TextBox10.Text;
			MySettingsProperty.Settings.Save();
			Interaction.MsgBox("Configuración almacenada");
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objExcepcion = ex;
			Interaction.MsgBox("Error al almacenar los datos");
			Logger.e("Error con excepción y traza", objExcepcion, new StackFrame(fNeedFileInfo: true));
			ProjectData.ClearProjectError();
		}
	}

	private void Button19_Click(object sender, EventArgs e)
	{
		OpenFileDialog openFileDialog = new OpenFileDialog();
		OpenFileDialog openFileDialog2 = openFileDialog;
		openFileDialog2.Filter = "Excel files(*.xlsx)|*xlsx|All files (*.*)|*.*";
		openFileDialog2.FilterIndex = 1;
		openFileDialog2.Title = "Import data from Excel file";
		openFileDialog2 = null;
		try
		{
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				string fileName = openFileDialog.FileName;
				TextBox10.Text = fileName;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objExcepcion = ex;
			Logger.e("Error con excepción y traza", objExcepcion, new StackFrame(fNeedFileInfo: true));
			ProjectData.ClearProjectError();
		}
	}

	private void Button20_Click(object sender, EventArgs e)
	{
		Mod_Update.UpdateHermes();
	}

	private void Button21_Click(object sender, EventArgs e)
	{
		string text = Strings.Format(MyProject.Forms.Form1_Inicio.DateTimePicker1.Value, "yyyyMMdd");
		string sql = "SELECT COUNT(guia) as total FROM PLANCHADA WHERE CHOFER=1075 AND FECHA=" + text + " AND Ventana=1";
		int num = Conversions.ToInteger(Mod_Funciones.contar_(sql));
		Interaction.MsgBox(num);
	}

	private void Button22_Click(object sender, EventArgs e)
	{
	}

	private void Button23_Click(object sender, EventArgs e)
	{
		try
		{
			object obj = Mod_Rutearmodulo.calculos_ruta(TextBox12.Text);
			Mod_Rutearmodulo.datos_ruta datos_ruta = ((obj != null) ? ((Mod_Rutearmodulo.datos_ruta)obj) : default(Mod_Rutearmodulo.datos_ruta));
			Interaction.MsgBox("Remitos: " + Conversions.ToString(datos_ruta.Guias));
			Interaction.MsgBox("Puntos: " + Conversions.ToString(datos_ruta.Puntos));
			Interaction.MsgBox("Volumen: " + Conversions.ToString(datos_ruta.Volumen));
			Interaction.MsgBox("Flete: " + Conversions.ToString(datos_ruta.Flete));
			Interaction.MsgBox("Kilos: " + Conversions.ToString(datos_ruta.Kilos));
			Interaction.MsgBox("Declarado: " + Conversions.ToString(datos_ruta.Declarado));
			Interaction.MsgBox("Bultos: " + Conversions.ToString(datos_ruta.Bultos));
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objExcepcion = ex;
			Logger.e("Error con excepción y traza", objExcepcion, new StackFrame(fNeedFileInfo: true));
			Interaction.MsgBox("Error");
			ProjectData.ClearProjectError();
		}
	}

	private void Button24_Click(object sender, EventArgs e)
	{
		string sQL = "INSERT INTO etransenvios(id_envio,Bultos,Volumen,Kilos,Flete,Cliente,U_mail,U_telefono,U_fecha,U_ventana,U_calle,U_numero_puerta, U_piso,U_dpto_oficina,U_bloque_torre,U_cp,U_localidad,U_provincia,Destinatario,D_mail,D_telefono,D_fecha,D_ventana,D_calle,D_numero_puerta, D_piso,D_dpto_oficina,D_bloque_torre,D_cp,D_localidad,D_provincia,Observaciones,numero_interno)values(2535,1,0.32,1,35.99, 'Facundo Millan','fmillan@area54sa.com.ar','1111111111',15/05/2016,1,'Tomas Guido','2585','','','','1865','Burzaco','Buenos Aires','Gabriel Frontan','gfrontan@gmail.com','14562875',16/05/2016,3,'av. cabildo','656','9','3','a',1025,'Caba','Buenos Aires',' doblando la esquina','1233')";
		Mod_ConeccionBD.BD_Sentencia(sQL);
	}

	private void Button25_Click(object sender, EventArgs e)
	{
		MyProject.Forms.Chatform.Show();
	}

	private void Button26_Click(object sender, EventArgs e)
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		int num = 0;
		string text = Strings.Format(MyProject.Forms.Form1_Inicio.DateTimePicker1.Value, "yyyyMMdd");
		DataTable dataTable = new DataTable("X1");
		string text2 = "SELECT id_envio FROM etransEnvios WHERE U_fecha='" + text + "' AND Estado='APROBADO'";
		MySqlDataAdapter val = new MySqlDataAdapter(text2, Mod_Sentencias.cnn);
		((DbDataAdapter)(object)val).Fill(dataTable);
		string text3 = Conversions.ToString(Mod_Etrans_Retiros.agrupar_retiros());
		checked
		{
			int num2 = dataTable.Rows.Count - 1;
			for (int i = 0; i <= num2; i++)
			{
				int num3 = Conversions.ToInteger(dataTable.Rows[i]["id_envio"]);
				switch (Conversions.ToInteger(Mod_Etrans.estado_web_etrans(num3)))
				{
				case 2:
				{
					string sQL2 = Conversions.ToString(Mod_Etrans_Retiros.armar_retiro(num3));
					Mod_ConeccionBD.BD_Sentencia(sQL2);
					break;
				}
				case 12:
				{
					string sQL = ("UPDATE etransEnvios SET id_retiro=0, estado='DESCARTADO' WHERE id_envio=" + Conversions.ToString(num3)) ?? "";
					Mod_ConeccionBD.BD_Sentencia(sQL);
					break;
				}
				}
			}
		}
	}

	private void Button27_Click(object sender, EventArgs e)
	{
		Mod_Etrans_Retiros.llenar_tabla_etrans();
	}

	private void Button28_Click(object sender, EventArgs e)
	{
	}

	private void Button29_Click(object sender, EventArgs e)
	{
		string prompt = Conversions.ToString(Mod_Etrans_Retiros.agrupar_retiros());
		Interaction.MsgBox(prompt);
	}

	private void Button30_Click(object sender, EventArgs e)
	{
		string sQL = "UPDATE etransEnvios SET id_retiro='0', estado='APROBADO'";
		Mod_ConeccionBD.BD_Sentencia(sQL);
	}

	private void Button31_Click(object sender, EventArgs e)
	{
	}

	private void Button33_Click(object sender, EventArgs e)
	{
		Mod_Rutearmodulo.etrans_pos();
	}

	private void Button34_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(TextBox15.Text, "", TextCompare: true) != 0)
		{
			string prompt = Conversions.ToString(Mod_Etrans.actualizar_estado_web(Conversions.ToInteger(TextBox15.Text), 2));
			Interaction.MsgBox(prompt);
		}
	}

	private void Button35_Click(object sender, EventArgs e)
	{
		DateTime value = MyProject.Forms.Form1_Inicio.DateTimePicker1.Value;
		DateTime dateTime = Conversions.ToDate(Mod_calendario.proxima_fecha(value));
		string prompt = Strings.Format(dateTime, "yyyyMMdd");
		Interaction.MsgBox(prompt);
	}

	private void Button36_Click(object sender, EventArgs e)
	{
		insertarEquipo();
	}

	private void insertarEquipo()
	{
		string sQL = "INSERT INTO equipos (chofer,imei,linea) VALUES (" + TextBox16.Text + "," + TextBox17.Text + "," + TextBox18.Text + ")";
		switch (Conversions.ToInteger(Mod_ConeccionBD.BD_Sentencia(sQL)))
		{
		case 1:
			Interaction.MsgBox("INSERTADO");
			break;
		case 2:
			Interaction.MsgBox("Existe un error");
			break;
		}
	}

	private void Button37_Click(object sender, EventArgs e)
	{
		string text = "SELECT id_envio FROM etransEnvios WHERE Cliente='Facundo'";
		DataTable dataTable = (DataTable)Mod_Sentencias.data(text);
		Logger.i(text + " - " + MySettingsProperty.Settings.Usuario);
		Interaction.MsgBox("ENVIOS: " + Conversions.ToString(dataTable.Rows.Count));
		checked
		{
			try
			{
				int num = dataTable.Rows.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					int num2 = Conversions.ToInteger(dataTable.Rows[i]["id_envio"]);
					Logger.i(Conversions.ToString(num2) + " - " + MySettingsProperty.Settings.Usuario);
					Mod_Etrans.actualizar_estado_web(num2, 12);
				}
				Interaction.MsgBox("END");
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

	private void Button38_Click(object sender, EventArgs e)
	{
		string sQL = "DELETE FROM PLANCHADA WHERE chofer=9898 and fecha='20151106'";
		int num = Conversions.ToInteger(Mod_ConeccionBD.BD_Sentencia(sQL));
		Interaction.MsgBox(num);
	}

	private void Button39_Click(object sender, EventArgs e)
	{
		string prompt = Conversions.ToString(Mod_Json.datosVehiculoPHP(1254));
		Interaction.MsgBox(prompt);
	}

	private void Button40_Click(object sender, EventArgs e)
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		int num = 0;
		int num2 = 10788;
		checked
		{
			do
			{
				DataTable dataTable = new DataTable("x");
				string text = ("Select id_hermes from etransEnvios where id_envio=" + Conversions.ToString(num2)) ?? "";
				MySqlDataAdapter val = new MySqlDataAdapter(text, Mod_Sentencias.cnn);
				((DbDataAdapter)(object)val).Fill(dataTable);
				if (dataTable.Rows.Count > 0)
				{
					Interaction.MsgBox(Conversions.ToString(num2) + " Ya Existe");
				}
				else
				{
					Mod_Etrans.get_envio_etrans(num2);
					num++;
				}
				num2++;
			}
			while (num2 <= 10995);
			Interaction.MsgBox(num);
		}
	}

	private void RuteoAbtn_Click(object sender, EventArgs e)
	{
	}

	private void Button41_Click(object sender, EventArgs e)
	{
		int num = Conversions.ToInteger(Mod_calendario.cambios_fecha(Conversions.ToInteger(TextBox19.Text)));
		Interaction.MsgBox(num);
	}

	private void Button42_Click(object sender, EventArgs e)
	{
		int num = 23462;
		do
		{
			try
			{
				Mod_Etrans.get_envio_etrans(num);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception objExcepcion = ex;
				Logger.e("Error obteniendo envio " + Conversions.ToString(num), objExcepcion, new StackFrame(fNeedFileInfo: true));
				ProjectData.ClearProjectError();
			}
			num = checked(num + 1);
		}
		while (num <= 23702);
	}

	private void Button43_Click(object sender, EventArgs e)
	{
		int num = Conversions.ToInteger(Mod_Posicionador.posicionarDireccion());
	}

	private void Button44_Click(object sender, EventArgs e)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		string text = "";
		string text2 = "SELECT id_envio from etransenvios where id_envio in (" + text + ")";
		DataTable dataTable = new DataTable("x");
		MySqlDataAdapter val = new MySqlDataAdapter(text2, Mod_Sentencias.cnn);
		((DbDataAdapter)(object)val).Fill(dataTable);
		int num = 0;
		string empty = string.Empty;
		int num2 = 0;
		int num3 = 14;
		checked
		{
			int num4 = dataTable.Rows.Count - 1;
			for (int i = 0; i <= num4; i++)
			{
				num2 = Conversions.ToInteger(dataTable.Rows[i]["id_envio"]);
				empty = Conversions.ToString(Mod_Etrans.actualizar_estados(num2, "DEVUELTO"));
				num++;
			}
			Interaction.MsgBox(num);
		}
	}

	private void Button45_Click(object sender, EventArgs e)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		string text = "40887,45106,34837,38691,43664,36257,43674,45175,31555,40190,44935,40079,38342";
		string text2 = "Select id_envio, cliente, U_calle, U_numero_puerta, U_piso, U_dpto_oficina, U_bloque_torre, U_cp, U_localidad, U_provincia from etransenvios where id_envio in (" + text + ") order by id_envio desc";
		DataTable dataTable = new DataTable("x");
		MySqlDataAdapter val = new MySqlDataAdapter(text2, Mod_Sentencias.cnn);
		((DbDataAdapter)(object)val).Fill(dataTable);
		string empty = string.Empty;
		int num = 0;
		int num2 = 5;
		string text3 = "DEVOLUCION AL REMITENTE";
		checked
		{
			int num3 = dataTable.Rows.Count - 1;
			for (int i = 0; i <= num3; i++)
			{
				num = Conversions.ToInteger(dataTable.Rows[i]["id_envio"]);
				string text4 = Conversions.ToString(dataTable.Rows[0]["Cliente"]);
				string text5 = Conversions.ToString(dataTable.Rows[0]["U_calle"]);
				string text6 = Conversions.ToString(dataTable.Rows[0]["U_numero_puerta"]);
				string text7 = Conversions.ToString(dataTable.Rows[0]["U_piso"]);
				string text8 = Conversions.ToString(dataTable.Rows[0]["U_dpto_oficina"]);
				string text9 = Conversions.ToString(dataTable.Rows[0]["U_bloque_torre"]);
				int num4 = Conversions.ToInteger(dataTable.Rows[0]["U_cp"]);
				string text10 = Conversions.ToString(dataTable.Rows[0]["U_localidad"]);
				string text11 = Conversions.ToString(dataTable.Rows[0]["U_provincia"]);
				string sQL = ("UPDATE etransenvios SET destinatario = '" + text4 + "',d_calle= '" + text5 + "',D_numero_puerta= '" + text6 + "',D_piso= '" + text7 + "',D_dpto_oficina= '" + text8 + "',D_bloque_torre= '" + text9 + "', D_cp= '" + Conversions.ToString(num4) + "', D_localidad= '" + text10 + "', D_provincia= '" + text11 + "', Observaciones=' " + text3 + "' WHERE id_envio=" + Conversions.ToString(num)) ?? "";
				Mod_ConeccionBD.BD_Sentencia(sQL);
				empty = Conversions.ToString(Mod_Etrans.actualizar_estado_web(num, 5));
			}
		}
	}

	private void Button46_Click(object sender, EventArgs e)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		string text = Strings.Format(DateTimePicker1.Value, "yyyyMMdd");
		string text2 = "";
		DataTable dataTable = new DataTable("x");
		MySqlDataAdapter val = new MySqlDataAdapter(text2, Mod_Sentencias.cnn);
		((DbDataAdapter)(object)val).Fill(dataTable);
		Interaction.MsgBox(dataTable.Rows.Count);
		checked
		{
			int num = dataTable.Rows.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				int num2 = Conversions.ToInteger(dataTable.Rows[i]["id_envio"]);
				string text3 = ("UPDATE etransenvios SET estado='EN CD', D_fecha='20160621' WHERE id_envio=" + Conversions.ToString(num2)) ?? "";
				string text4 = Conversions.ToString(Mod_Etrans.actualizar_estado_web(num2, 5));
			}
			Interaction.MsgBox("fin");
		}
	}

	private void Button47_Click(object sender, EventArgs e)
	{
		Mod_Posicionador.posicionarEventuales(Conversions.ToInteger(TextBox20.Text));
	}

	public void Empresas()
	{
		try
		{
			string sQL = "CREATE TABLE Empresas (ID int Not null unique auto_increment, RazonSocial  VARCHAR(255), Nombre  VARCHAR(255), Iva int(1), CuitCuil VARCHAR(255),Ingresosbrutos VARCHAR(255),DireccionOficina  int(11), DireccionDeposito  int(11), ContactoOficina  int(11), ContactoDeposito  int(11), Estado int(11), Tarifa int(11), Seguro int(11), Alta datetime, Baja datetime) ";
			Mod_ConeccionBD.BD_Sentencia(sQL);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox(ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	public void IVA()
	{
		try
		{
			string sQL = "CREATE TABLE iva (ID int Not null unique auto_increment, Descripcion  VARCHAR(255))";
			Mod_ConeccionBD.BD_Sentencia(sQL);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox(ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	public void Contactos()
	{
		try
		{
			string sQL = "CREATE TABLE Contactos (ID int Not null unique auto_increment, NombreApellido  VARCHAR(255), Email VARCHAR(255), Telefono  int(11), Celular  int(11), Tipo  int(11), Comentario  VARCHAR(255)) ";
			Mod_ConeccionBD.BD_Sentencia(sQL);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox(ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	public void Direccion()
	{
		try
		{
			string sQL = "CREATE TABLE Direccion(id int Not null unique, Calle varchar(255), Altura varchar(255), Piso varchar(255), DeptoOficina varchar(255), Bloque varchar(255), CP varchar(255), Localidad varchar(255), Provincia varchar(255), Pais varchar(255), Observacion varchar(255), Normalizada varchar(255), Latitud float, Longitud float, Zona int(11), Fecha datetime, LastUpdate datetime, Usuario varchar(55))";
			Mod_ConeccionBD.BD_Sentencia(sQL);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox(ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	public void Tarifas()
	{
		try
		{
			string sQL = "CREATE TABLE Tarifas (ID int Not null unique auto_increment, Recepcion  float, Almacenaje float, Preparacion float, Despacho float, usuario varchar(25), fecha datetime)";
			Mod_ConeccionBD.BD_Sentencia(sQL);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox(ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	public void Seguro()
	{
		try
		{
			string sQL = "CREATE TABLE Seguro (ID int Not null unique auto_increment, Descripcion varchar(255), Costo float, usuario varchar(25), fecha datetime)";
			Mod_ConeccionBD.BD_Sentencia(sQL);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox(ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void testimprimir_Click(object sender, EventArgs e)
	{
		PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
		printPreviewDialog.Document = PrintDocument1;
		printPreviewDialog.ShowDialog();
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
		print_order = int.Parse(Conversions.ToString(181));
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

	private void NewPrintDetails(ref PrintPageEventArgs e)
	{
		int pHvalor = MySettingsProperty.Settings.pHvalor;
		int pVvalor = MySettingsProperty.Settings.pVvalor;
		paddinEtiqueta paddinEtiqueta = default(paddinEtiqueta);
		checked
		{
			paddinEtiqueta.top = pVvalor + 2;
			paddinEtiqueta.bottom = pVvalor + 150 - 2;
			paddinEtiqueta.right = pHvalor + 300 - 2;
			paddinEtiqueta.left = pHvalor + 2;
			Font font = new Font("Arial", 6.75f, FontStyle.Italic, GraphicsUnit.Point, 0);
			Font font2 = new Font("Arial", 16.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Font font3 = new Font("Arial", 14.75f, FontStyle.Italic, GraphicsUnit.Point, 0);
			Font font4 = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Rectangle empty = Rectangle.Empty;
			empty.X = pHvalor + 2;
			empty.Y = pVvalor;
			empty.Width = 300 - pHvalor;
			empty.Height = 150 - pVvalor;
			e.Graphics.DrawRectangle(Pens.Black, empty);
			string s = "SANTANA TEXTILES";
			e.Graphics.DrawString(s, font2, Brushes.Black, empty.X + 10, empty.Y + 10);
			e.Graphics.DrawString("Remito: 123456789", font2, Brushes.Black, empty.X + 10, empty.Y + 40);
			e.Graphics.DrawString("Exp. Oliva Hermanos", font4, Brushes.Black, empty.X + 10, empty.Y + 80);
			e.Graphics.DrawString("San Fernando", font4, Brushes.Black, empty.X + 10, empty.Y + 100);
			string s2 = "Bulto 1000 de 2000";
			e.Graphics.DrawString(s2, font2, Brushes.Black, empty.X + 10, empty.Y + 120);
		}
	}

	private void Button48_Click(object sender, EventArgs e)
	{
		Mod_interfas.distribucionOrdenes(5);
	}

	private void Button49_Click(object sender, EventArgs e)
	{
		Mod_api_ordenes.LoginApi("10", "moovingdps2017");
	}

	private void Button50_Click(object sender, EventArgs e)
	{
	}

	private void Button51_Click(object sender, EventArgs e)
	{
		Thread thread = new Thread([SpecialName] [DebuggerHidden] (object a0) =>
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			Mod_Async.MyBackgroundThread((JObject)a0);
		});
		thread.IsBackground = true;
		thread.Start();
	}

	private void Button52_Click(object sender, EventArgs e)
	{
		Mod_Posicionador.posicionar_facu();
	}

	private void Button53_Click(object sender, EventArgs e)
	{
		string text = Conversions.ToString(Mod_Posicionador.GetCoorFromBing());
		Interaction.MsgBox(text);
		Interaction.InputBox("URL", "URL", text);
		Mod_WebRequest.ResponseFromPost responseFromPost = default(Mod_WebRequest.ResponseFromPost);
		object data = Mod_WebRequest.GetData(text);
		responseFromPost = ((data != null) ? ((Mod_WebRequest.ResponseFromPost)data) : default(Mod_WebRequest.ResponseFromPost));
		Interaction.MsgBox(responseFromPost.status);
		Interaction.MsgBox(responseFromPost.mensaje);
	}

	private void Button54_Click(object sender, EventArgs e)
	{
		if ((object)TextBox21.Text != string.Empty)
		{
			string text = TextBox21.Text;
			string empty = string.Empty;
			Interaction.MsgBox(TextBox21.Text);
			empty = ((!Conversions.ToBoolean(Mod_ecommerce.CambiarEstados(Conversions.ToInteger(TextBox21.Text), 2))) ? "Error" : "Correcto");
			Interaction.MsgBox(empty);
		}
	}

	private void Button55_Click(object sender, EventArgs e)
	{
		DataTable dataTable = (DataTable)Mod_ecommerce.ObtenerRetiros(16);
		ListView5.Items.Clear();
		ListView5.Columns.Clear();
		foreach (DataColumn column in dataTable.Columns)
		{
			ListView5.Columns.Add(column.ColumnName, column.ColumnName);
		}
		checked
		{
			foreach (DataRow row in dataTable.Rows)
			{
				ListViewItem listViewItem = new ListViewItem();
				listViewItem.Text = row[0].ToString();
				int num = dataTable.Columns.Count - 1;
				for (int i = 1; i <= num; i++)
				{
					listViewItem.SubItems.Add(row[i].ToString());
				}
				ListView5.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
				ListView5.Items.Add(listViewItem);
			}
			Label22.Text = Conversions.ToString(dataTable.Rows.Count);
		}
	}

	private void Button56_Click(object sender, EventArgs e)
	{
		MyProject.Forms.RecepcionEnvios.Show();
	}

	private void Button57_Click(object sender, EventArgs e)
	{
		List<Mod_empresas.EmpresasStructure> list = (List<Mod_empresas.EmpresasStructure>)Mod_ecommerce.ObtenerEmpresasRetiro();
		checked
		{
			if (list.Count > 0)
			{
				int num = list.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					int idempresa = list[i].idempresa;
					Interaction.MsgBox(Operators.ConcatenateObject(Operators.ConcatenateObject("La empresa " + Conversions.ToString(idempresa) + " tiene ", Mod_ecommerce.ContarRetiroEnvios(idempresa)), " retiros"));
				}
			}
		}
	}

	private void Button58_Click(object sender, EventArgs e)
	{
		List<Mod_empresas.EmpresasStructure> list = (List<Mod_empresas.EmpresasStructure>)Mod_ecommerce.ObtenerEmpresasRetiro();
		checked
		{
			if (list.Count > 0)
			{
				int num = list.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					int idempresa = list[i].idempresa;
					ImprimirRetiroEmpresa(idempresa);
				}
			}
		}
	}

	private void ImprimirRetiroEmpresa(int empresa)
	{
		EmpresaImprimirRetiro = empresa;
		PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
		PrintDocument2.DefaultPageSettings.Landscape = false;
		printPreviewDialog.WindowState = FormWindowState.Maximized;
		printPreviewDialog.Document = PrintDocument2;
		PrintDocument2.Print();
		PrintDocument2.Dispose();
	}

	private void PrintDocument2_PrintPage(object sender, PrintPageEventArgs e)
	{
		DataTable dataTable = (DataTable)Mod_ecommerce.GenerarRetiroEnvios(EmpresaImprimirRetiro);
		Font font = new Font("Arial", 8f, FontStyle.Italic, GraphicsUnit.Point, 0);
		Font font2 = new Font("Arial", 16f, FontStyle.Italic, GraphicsUnit.Point, 0);
		e.Graphics.DrawLine(Pens.Brown, 2, 5, 790, 5);
		e.Graphics.DrawLine(Pens.Brown, 2, 5, 2, 1040);
		e.Graphics.DrawLine(Pens.Brown, 790, 5, 790, 1040);
		e.Graphics.DrawLine(Pens.Brown, 2, 1040, 790, 1040);
		e.Graphics.DrawLine(Pens.Brown, 2, 130, 790, 130);
		int num = 10;
		int num2 = 135;
		e.Graphics.DrawString("RETIRO ", font2, Brushes.Black, 30f, 70f);
		int num3 = 0;
		checked
		{
			int num4 = dataTable.Rows.Count - 1;
			for (int i = 0; i <= num4; i++)
			{
				num2 += 10;
				e.Graphics.DrawString((i + 1).ToString(), font, Brushes.Black, num, num2);
				num += 30;
				e.Graphics.DrawString(dataTable.Rows[i]["id"].ToString(), font, Brushes.Black, num, num2);
				num += 70;
				string s = Strings.Format(RuntimeHelpers.GetObjectValue(dataTable.Rows[i]["FECHA"]), "dd-MM-yyyy");
				e.Graphics.DrawString(s, font, Brushes.Black, num, num2);
				num += 70;
				e.Graphics.DrawString(dataTable.Rows[i]["RS1_DEST"].ToString(), font, Brushes.Black, num, num2);
				num += 200;
				e.Graphics.DrawString(dataTable.Rows[i]["DOM_DEST"].ToString(), font, Brushes.Black, num, num2);
				num += 250;
				e.Graphics.DrawString(dataTable.Rows[i]["LOC_DEST"].ToString(), font, Brushes.Black, num, num2);
				num += 30;
				e.Graphics.DrawString(dataTable.Rows[i]["BULTOS"].ToString(), font, Brushes.Black, num, num2);
				int result = 0;
				try
				{
					int.TryParse(Conversions.ToString(dataTable.Rows[i]["BULTOS"]), out result);
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
				num3 += result;
				num += 30;
				e.Graphics.DrawString(dataTable.Rows[i]["OBSERV"].ToString(), font, Brushes.Black, num, num2);
				num = 10;
			}
			e.Graphics.DrawString("TOTAL BULTOS: " + Conversions.ToString(num3), font2, Brushes.Black, 200f, 70f);
		}
	}

	private void Button59_Click(object sender, EventArgs e)
	{
		int productId = 7781;
		int.TryParse(TextBox22.Text, out var result);
		int num = Conversions.ToInteger(Mod_Calculos.CalculoDeCajas(productId, result));
		int num2 = Conversions.ToInteger(Operators.SubtractObject(result, Mod_Calculos.UnidadesEnCajas(productId, num)));
		int num3 = Conversions.ToInteger(Mod_Calculos.CalculoDeInner(productId, num2));
		num2 = Conversions.ToInteger(Operators.SubtractObject(num2, Mod_Calculos.UnidadesEnInner(productId, num3)));
		Interaction.MsgBox("Se solicitan: " + Conversions.ToString(result) + ", se enviaran: " + Conversions.ToString(num) + " cajas, " + Conversions.ToString(num3) + " inners y " + Conversions.ToString(num2));
	}
}
