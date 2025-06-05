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
public class Retiros : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ListView1")]
	private ListView _ListView1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("guardarbtn")]
	private Button _guardarbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("editarbtn")]
	private Button _editarbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("borrarbtn")]
	private Button _borrarbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Salirbtn")]
	private Button _Salirbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	private string fecha1;

	[field: AccessedThroughProperty("choferlbl")]
	internal virtual Label choferlbl
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Combochof")]
	internal virtual ComboBox Combochof
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
			EventHandler value2 = ListView1_SelectedIndexChanged;
			ListView listView = _ListView1;
			if (listView != null)
			{
				listView.SelectedIndexChanged -= value2;
			}
			_ListView1 = value;
			listView = _ListView1;
			if (listView != null)
			{
				listView.SelectedIndexChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
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

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ComboBox2")]
	internal virtual ComboBox ComboBox2
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

	[field: AccessedThroughProperty("Label4")]
	internal virtual Label Label4
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

	[field: AccessedThroughProperty("GroupBox2")]
	internal virtual GroupBox GroupBox2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ListView2")]
	internal virtual ListView ListView2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button guardarbtn
	{
		[CompilerGenerated]
		get
		{
			return _guardarbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = guardarbtn_Click;
			Button button = _guardarbtn;
			if (button != null)
			{
				button.Click -= value2;
			}
			_guardarbtn = value;
			button = _guardarbtn;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button editarbtn
	{
		[CompilerGenerated]
		get
		{
			return _editarbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = editarbtn_Click;
			Button button = _editarbtn;
			if (button != null)
			{
				button.Click -= value2;
			}
			_editarbtn = value;
			button = _editarbtn;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button borrarbtn
	{
		[CompilerGenerated]
		get
		{
			return _borrarbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = borrarbtn_Click;
			Button button = _borrarbtn;
			if (button != null)
			{
				button.Click -= value2;
			}
			_borrarbtn = value;
			button = _borrarbtn;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label5")]
	internal virtual Label Label5
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

	[field: AccessedThroughProperty("Label6")]
	internal virtual Label Label6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("id")]
	internal virtual ColumnHeader id
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Nombre")]
	internal virtual ColumnHeader Nombre
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Cuenta")]
	internal virtual ColumnHeader Cuenta
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

	[field: AccessedThroughProperty("Horario")]
	internal virtual ColumnHeader Horario
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Contacto")]
	internal virtual ColumnHeader Contacto
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Id_")]
	internal virtual ColumnHeader Id_
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Chofer")]
	internal virtual ColumnHeader Chofer
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

	[field: AccessedThroughProperty("Adicional")]
	internal virtual ColumnHeader Adicional
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Peajes")]
	internal virtual ColumnHeader Peajes
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

	[field: AccessedThroughProperty("Pallets")]
	internal virtual ColumnHeader Pallets
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Retiro")]
	internal virtual ColumnHeader Retiro
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Segunda")]
	internal virtual ColumnHeader Segunda
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Otro")]
	internal virtual ColumnHeader Otro
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Fecha")]
	internal virtual ColumnHeader Fecha
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Salirbtn
	{
		[CompilerGenerated]
		get
		{
			return _Salirbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Salirbtn_Click;
			Button salirbtn = _Salirbtn;
			if (salirbtn != null)
			{
				salirbtn.Click -= value2;
			}
			_Salirbtn = value;
			salirbtn = _Salirbtn;
			if (salirbtn != null)
			{
				salirbtn.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label7")]
	internal virtual Label Label7
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

	public Retiros()
	{
		base.Load += Retiros_Load;
		fecha1 = Strings.Format(MyProject.Forms.Form1_Inicio.DateTimePicker1.Value, "yyyyMMdd");
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hermes.Retiros));
		this.choferlbl = new System.Windows.Forms.Label();
		this.Combochof = new System.Windows.Forms.ComboBox();
		this.GroupBox1 = new System.Windows.Forms.GroupBox();
		this.Button1 = new System.Windows.Forms.Button();
		this.Salirbtn = new System.Windows.Forms.Button();
		this.ListView1 = new System.Windows.Forms.ListView();
		this.Fecha = new System.Windows.Forms.ColumnHeader();
		this.Chofer = new System.Windows.Forms.ColumnHeader();
		this.Cliente = new System.Windows.Forms.ColumnHeader();
		this.Adicional = new System.Windows.Forms.ColumnHeader();
		this.Peajes = new System.Windows.Forms.ColumnHeader();
		this.Observaciones = new System.Windows.Forms.ColumnHeader();
		this.Pallets = new System.Windows.Forms.ColumnHeader();
		this.Retiro = new System.Windows.Forms.ColumnHeader();
		this.Segunda = new System.Windows.Forms.ColumnHeader();
		this.Otro = new System.Windows.Forms.ColumnHeader();
		this.Id_ = new System.Windows.Forms.ColumnHeader();
		this.borrarbtn = new System.Windows.Forms.Button();
		this.editarbtn = new System.Windows.Forms.Button();
		this.guardarbtn = new System.Windows.Forms.Button();
		this.Label1 = new System.Windows.Forms.Label();
		this.ComboBox1 = new System.Windows.Forms.ComboBox();
		this.Label2 = new System.Windows.Forms.Label();
		this.ComboBox2 = new System.Windows.Forms.ComboBox();
		this.Label3 = new System.Windows.Forms.Label();
		this.TextBox1 = new System.Windows.Forms.TextBox();
		this.Label4 = new System.Windows.Forms.Label();
		this.TextBox2 = new System.Windows.Forms.TextBox();
		this.GroupBox2 = new System.Windows.Forms.GroupBox();
		this.ListView2 = new System.Windows.Forms.ListView();
		this.id = new System.Windows.Forms.ColumnHeader();
		this.Nombre = new System.Windows.Forms.ColumnHeader();
		this.Cuenta = new System.Windows.Forms.ColumnHeader();
		this.Domicilio = new System.Windows.Forms.ColumnHeader();
		this.CP = new System.Windows.Forms.ColumnHeader();
		this.Localidad = new System.Windows.Forms.ColumnHeader();
		this.Horario = new System.Windows.Forms.ColumnHeader();
		this.Contacto = new System.Windows.Forms.ColumnHeader();
		this.Label6 = new System.Windows.Forms.Label();
		this.Label5 = new System.Windows.Forms.Label();
		this.ComboBox3 = new System.Windows.Forms.ComboBox();
		this.Label7 = new System.Windows.Forms.Label();
		this.GroupBox1.SuspendLayout();
		this.GroupBox2.SuspendLayout();
		base.SuspendLayout();
		this.choferlbl.AutoSize = true;
		this.choferlbl.Location = new System.Drawing.Point(12, 36);
		this.choferlbl.Name = "choferlbl";
		this.choferlbl.Size = new System.Drawing.Size(41, 13);
		this.choferlbl.TabIndex = 0;
		this.choferlbl.Text = "Chofer:";
		this.Combochof.FormattingEnabled = true;
		this.Combochof.Location = new System.Drawing.Point(99, 33);
		this.Combochof.Name = "Combochof";
		this.Combochof.Size = new System.Drawing.Size(315, 21);
		this.Combochof.TabIndex = 1;
		this.Combochof.Text = "Seleccione Chofer";
		this.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.GroupBox1.Controls.Add(this.Button1);
		this.GroupBox1.Controls.Add(this.Salirbtn);
		this.GroupBox1.Controls.Add(this.ListView1);
		this.GroupBox1.Controls.Add(this.borrarbtn);
		this.GroupBox1.Controls.Add(this.editarbtn);
		this.GroupBox1.Controls.Add(this.guardarbtn);
		this.GroupBox1.Location = new System.Drawing.Point(12, 235);
		this.GroupBox1.Name = "GroupBox1";
		this.GroupBox1.Size = new System.Drawing.Size(1048, 277);
		this.GroupBox1.TabIndex = 2;
		this.GroupBox1.TabStop = false;
		this.GroupBox1.Text = "Retiros";
		this.Button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.Button1.Location = new System.Drawing.Point(168, 248);
		this.Button1.Name = "Button1";
		this.Button1.Size = new System.Drawing.Size(75, 23);
		this.Button1.TabIndex = 15;
		this.Button1.Text = "Exportar";
		this.Button1.UseVisualStyleBackColor = true;
		this.Salirbtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		this.Salirbtn.Location = new System.Drawing.Point(967, 248);
		this.Salirbtn.Name = "Salirbtn";
		this.Salirbtn.Size = new System.Drawing.Size(75, 23);
		this.Salirbtn.TabIndex = 17;
		this.Salirbtn.Text = "Salir";
		this.Salirbtn.UseVisualStyleBackColor = true;
		this.ListView1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.ListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[11]
		{
			this.Fecha, this.Chofer, this.Cliente, this.Adicional, this.Peajes, this.Observaciones, this.Pallets, this.Retiro, this.Segunda, this.Otro,
			this.Id_
		});
		this.ListView1.FullRowSelect = true;
		this.ListView1.GridLines = true;
		this.ListView1.Location = new System.Drawing.Point(6, 19);
		this.ListView1.Name = "ListView1";
		this.ListView1.Size = new System.Drawing.Size(1036, 200);
		this.ListView1.TabIndex = 0;
		this.ListView1.UseCompatibleStateImageBehavior = false;
		this.ListView1.View = System.Windows.Forms.View.Details;
		this.Fecha.Text = "Fecha";
		this.Chofer.Text = "Chofer";
		this.Chofer.Width = 120;
		this.Cliente.Text = "Cliente";
		this.Cliente.Width = 120;
		this.Adicional.Text = "Adicional";
		this.Peajes.Text = "Peajes";
		this.Observaciones.Text = "Observaciones";
		this.Observaciones.Width = 255;
		this.Pallets.Text = "Pallets";
		this.Retiro.Text = "Retiro";
		this.Segunda.Text = "Segunda";
		this.Otro.Text = "Estado";
		this.Id_.Text = "ID";
		this.borrarbtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.borrarbtn.Location = new System.Drawing.Point(249, 248);
		this.borrarbtn.Name = "borrarbtn";
		this.borrarbtn.Size = new System.Drawing.Size(75, 23);
		this.borrarbtn.TabIndex = 14;
		this.borrarbtn.Text = "Borrar";
		this.borrarbtn.UseVisualStyleBackColor = true;
		this.editarbtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.editarbtn.Location = new System.Drawing.Point(87, 248);
		this.editarbtn.Name = "editarbtn";
		this.editarbtn.Size = new System.Drawing.Size(75, 23);
		this.editarbtn.TabIndex = 13;
		this.editarbtn.Text = "Editar";
		this.editarbtn.UseVisualStyleBackColor = true;
		this.guardarbtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.guardarbtn.Location = new System.Drawing.Point(6, 248);
		this.guardarbtn.Name = "guardarbtn";
		this.guardarbtn.Size = new System.Drawing.Size(75, 23);
		this.guardarbtn.TabIndex = 12;
		this.guardarbtn.Text = "Guardar";
		this.guardarbtn.UseVisualStyleBackColor = true;
		this.Label1.AutoSize = true;
		this.Label1.Location = new System.Drawing.Point(12, 70);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(42, 13);
		this.Label1.TabIndex = 3;
		this.Label1.Text = "Cliente:";
		this.ComboBox1.FormattingEnabled = true;
		this.ComboBox1.Location = new System.Drawing.Point(99, 67);
		this.ComboBox1.Name = "ComboBox1";
		this.ComboBox1.Size = new System.Drawing.Size(315, 21);
		this.ComboBox1.TabIndex = 4;
		this.ComboBox1.Text = "Seleccione Cliente";
		this.Label2.AutoSize = true;
		this.Label2.Location = new System.Drawing.Point(12, 104);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(53, 13);
		this.Label2.TabIndex = 5;
		this.Label2.Text = "Adicional:";
		this.ComboBox2.FormattingEnabled = true;
		this.ComboBox2.Location = new System.Drawing.Point(99, 101);
		this.ComboBox2.Name = "ComboBox2";
		this.ComboBox2.Size = new System.Drawing.Size(78, 21);
		this.ComboBox2.TabIndex = 6;
		this.ComboBox2.Text = "0";
		this.Label3.AutoSize = true;
		this.Label3.Location = new System.Drawing.Point(12, 135);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(42, 13);
		this.Label3.TabIndex = 7;
		this.Label3.Text = "Peajes:";
		this.TextBox1.Location = new System.Drawing.Point(99, 135);
		this.TextBox1.Name = "TextBox1";
		this.TextBox1.Size = new System.Drawing.Size(100, 20);
		this.TextBox1.TabIndex = 8;
		this.TextBox1.Text = "0";
		this.Label4.AutoSize = true;
		this.Label4.Location = new System.Drawing.Point(12, 176);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(81, 13);
		this.Label4.TabIndex = 9;
		this.Label4.Text = "Observaciones:";
		this.TextBox2.Location = new System.Drawing.Point(99, 173);
		this.TextBox2.Name = "TextBox2";
		this.TextBox2.Size = new System.Drawing.Size(315, 20);
		this.TextBox2.TabIndex = 10;
		this.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.GroupBox2.Controls.Add(this.ListView2);
		this.GroupBox2.Location = new System.Drawing.Point(433, 12);
		this.GroupBox2.Name = "GroupBox2";
		this.GroupBox2.Size = new System.Drawing.Size(627, 217);
		this.GroupBox2.TabIndex = 11;
		this.GroupBox2.TabStop = false;
		this.GroupBox2.Text = "Clientes:";
		this.ListView2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.ListView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[8] { this.id, this.Nombre, this.Cuenta, this.Domicilio, this.CP, this.Localidad, this.Horario, this.Contacto });
		this.ListView2.FullRowSelect = true;
		this.ListView2.GridLines = true;
		this.ListView2.Location = new System.Drawing.Point(6, 19);
		this.ListView2.MultiSelect = false;
		this.ListView2.Name = "ListView2";
		this.ListView2.Size = new System.Drawing.Size(615, 192);
		this.ListView2.TabIndex = 0;
		this.ListView2.UseCompatibleStateImageBehavior = false;
		this.ListView2.View = System.Windows.Forms.View.Details;
		this.id.Text = "id";
		this.Nombre.Text = "Nombre";
		this.Nombre.Width = 120;
		this.Cuenta.Text = "Cuenta";
		this.Domicilio.Text = "Domicilio";
		this.Domicilio.Width = 120;
		this.CP.Text = "CP";
		this.Localidad.Text = "Localidad";
		this.Localidad.Width = 100;
		this.Horario.Text = "Horario";
		this.Horario.Width = 100;
		this.Contacto.Text = "Contacto";
		this.Contacto.Width = 120;
		this.Label6.AutoSize = true;
		this.Label6.Location = new System.Drawing.Point(370, 9);
		this.Label6.Name = "Label6";
		this.Label6.Size = new System.Drawing.Size(39, 13);
		this.Label6.TabIndex = 1;
		this.Label6.Text = "Label6";
		this.Label5.AutoSize = true;
		this.Label5.Location = new System.Drawing.Point(270, 104);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(41, 13);
		this.Label5.TabIndex = 15;
		this.Label5.Text = "Pallets:";
		this.ComboBox3.FormattingEnabled = true;
		this.ComboBox3.Location = new System.Drawing.Point(336, 101);
		this.ComboBox3.Name = "ComboBox3";
		this.ComboBox3.Size = new System.Drawing.Size(78, 21);
		this.ComboBox3.TabIndex = 16;
		this.ComboBox3.Text = "0";
		this.Label7.AutoSize = true;
		this.Label7.Location = new System.Drawing.Point(12, 12);
		this.Label7.Name = "Label7";
		this.Label7.Size = new System.Drawing.Size(13, 13);
		this.Label7.TabIndex = 18;
		this.Label7.Text = "0";
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(1072, 524);
		base.Controls.Add(this.Label6);
		base.Controls.Add(this.Label7);
		base.Controls.Add(this.ComboBox3);
		base.Controls.Add(this.Label5);
		base.Controls.Add(this.GroupBox2);
		base.Controls.Add(this.TextBox2);
		base.Controls.Add(this.Label4);
		base.Controls.Add(this.TextBox1);
		base.Controls.Add(this.Label3);
		base.Controls.Add(this.ComboBox2);
		base.Controls.Add(this.Label2);
		base.Controls.Add(this.ComboBox1);
		base.Controls.Add(this.Label1);
		base.Controls.Add(this.GroupBox1);
		base.Controls.Add(this.Combochof);
		base.Controls.Add(this.choferlbl);
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.Name = "Retiros";
		this.Text = "Retiros";
		base.WindowState = System.Windows.Forms.FormWindowState.Maximized;
		this.GroupBox1.ResumeLayout(false);
		this.GroupBox2.ResumeLayout(false);
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private void Retiros_Load(object sender, EventArgs e)
	{
		if (Operators.CompareString(Label7.Text, "0", TextCompare: true) == 0)
		{
			guardarbtn.Enabled = true;
			editarbtn.Enabled = false;
			borrarbtn.Enabled = false;
		}
		string sql = "SELECT Chofer FROM Flota where Estado='Activo' order by chofer";
		Mod_Sentencias.cargar_cbb(Combochof, sql);
		string sql2 = "SELECT Nombre FROM Clientes order by nombre";
		Mod_Sentencias.cargar_cbb(ComboBox1, sql2);
		llenar_clientes();
		llenar_retiros();
	}

	private void llenar_clientes()
	{
		string sql = "SELECT id,Nombre,Cuenta,Domicilio,CP,Localidad,Horario,Contacto FROM Clientes";
		Mod_Sentencias.cargar_datos_lv(ListView2, sql, Label6);
	}

	private void llenar_retiros()
	{
		string sql = "SELECT Fecha,Chofer,Cliente,Adicional,Peajes,Observaciones,Pallets,Retiro,Segunda,Estado,id FROM Retiros WHERE Fecha='" + fecha1 + "'";
		Mod_Sentencias.cargar_datos_lv(ListView1, sql, Label6);
	}

	private void guardarbtn_Click(object sender, EventArgs e)
	{
		string sQL = "INSERT INTO Retiros (Chofer,Cliente,Adicional,Peajes,Observaciones,Pallets,Fecha) VALUES ('" + Combochof.Text + "','" + ComboBox1.Text + "'," + ComboBox2.Text + "," + Strings.Replace(TextBox1.Text, ",", ".", 1, -1, CompareMethod.Text) + ",'" + TextBox2.Text + "'," + ComboBox3.Text + ",'" + fecha1 + "')";
		if (Operators.CompareString(Label7.Text, "0", TextCompare: true) == 0)
		{
			switch (Conversions.ToInteger(Mod_ConeccionBD.BD_Sentencia(sQL)))
			{
			case 1:
				Interaction.MsgBox("Retiro Asignado");
				limpiar_campos();
				llenar_retiros();
				break;
			case 2:
				Interaction.MsgBox("Error al Asignar Retiro");
				break;
			}
		}
		else
		{
			Label7.Text = "0";
			limpiar_campos();
		}
	}

	private void editarbtn_Click(object sender, EventArgs e)
	{
		string sQL = ("UPDATE Retiros SET Chofer='" + Combochof.Text + "',Cliente='" + ComboBox1.Text + "',Adicional=" + ComboBox2.Text + ",Peajes=" + Strings.Replace(TextBox1.Text, ",", ".", 1, -1, CompareMethod.Text) + ",Observaciones='" + TextBox2.Text + "',Pallets=" + ComboBox3.Text + " where ID= " + Label7.Text) ?? "";
		switch (Conversions.ToInteger(Mod_ConeccionBD.BD_Sentencia(sQL)))
		{
		case 1:
			Interaction.MsgBox("Retiro Editado");
			limpiar_campos();
			llenar_retiros();
			break;
		case 2:
			Interaction.MsgBox("Error al Editar Retiro");
			break;
		}
		llenar_retiros();
	}

	private void borrarbtn_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(Label7.Text, "0", TextCompare: true) != 0)
		{
			DialogResult dialogResult = MessageBox.Show("Borrar", "Borrar registro", MessageBoxButtons.YesNo);
			if (dialogResult == DialogResult.Yes)
			{
				string sQL = ("DELETE FROM Retiros WHERE id=" + Label7.Text) ?? "";
				int num = Conversions.ToInteger(Mod_ConeccionBD.BD_Sentencia(sQL));
				if (num == 1)
				{
					limpiar_campos();
					llenar_retiros();
					Label7.Text = "0";
				}
				if (num == 2)
				{
					Label7.Text = "0";
				}
			}
		}
		else
		{
			Interaction.MsgBox("Seleccione un registro para borrar");
		}
	}

	private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (ListView1.SelectedItems.Count > 0)
		{
			int index = ListView1.SelectedIndices[0];
			Label7.Text = ListView1.Items[index].SubItems[10].Text;
			Combochof.Text = ListView1.Items[index].SubItems[1].Text;
			ComboBox1.Text = ListView1.Items[index].SubItems[2].Text;
			ComboBox2.Text = ListView1.Items[index].SubItems[3].Text;
			TextBox1.Text = ListView1.Items[index].SubItems[4].Text;
			TextBox2.Text = ListView1.Items[index].SubItems[5].Text;
			ComboBox3.Text = ListView1.Items[index].SubItems[6].Text;
			editarbtn.Enabled = true;
			borrarbtn.Enabled = true;
		}
	}

	private void Salirbtn_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		SaveFileDialog saveFileDialog = new SaveFileDialog();
		saveFileDialog.Filter = "Excel files(*.xlsx)|*xlsx";
		saveFileDialog.Title = "Guardar Archivo";
		saveFileDialog.ShowDialog();
		string fileName = saveFileDialog.FileName;
		if (Operators.CompareString(fileName, "", TextCompare: true) != 0)
		{
			string sql = "SELECT Fecha,Chofer,Cliente,Adicional,Peajes,Observaciones,Pallets,Retiro,Segunda,Estado,id FROM Retiros WHERE Fecha='" + fecha1 + "'";
			Mod_Exportar.exp_excel_dir(sql, fileName);
		}
	}

	private void limpiar_campos()
	{
		Combochof.Text = "Seleccione Chofer";
		ComboBox1.Text = "Seleccione Cliente";
		ComboBox2.Text = "0";
		ComboBox3.Text = "0";
		TextBox1.Text = "0";
		TextBox2.Text = "";
		Label7.Text = "0";
	}
}
