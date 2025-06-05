using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Hermes;

[DesignerGenerated]
public class Clientes : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btn1")]
	private Button _btn1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btn3")]
	private Button _btn3;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("salirbtn")]
	private Button _salirbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ListView1")]
	private ListView _ListView1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btn2")]
	private Button _btn2;

	[field: AccessedThroughProperty("GroupBox1")]
	internal virtual GroupBox GroupBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button btn1
	{
		[CompilerGenerated]
		get
		{
			return _btn1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = btn1_Click;
			Button button = _btn1;
			if (button != null)
			{
				button.Click -= value2;
			}
			_btn1 = value;
			button = _btn1;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button btn3
	{
		[CompilerGenerated]
		get
		{
			return _btn3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = btn3_Click;
			Button button = _btn3;
			if (button != null)
			{
				button.Click -= value2;
			}
			_btn3 = value;
			button = _btn3;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button salirbtn
	{
		[CompilerGenerated]
		get
		{
			return _salirbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = salirbtn_Click;
			Button button = _salirbtn;
			if (button != null)
			{
				button.Click -= value2;
			}
			_salirbtn = value;
			button = _salirbtn;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
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
			EventHandler value3 = ListView1_SelectedIndexChanged;
			ListView listView = _ListView1;
			if (listView != null)
			{
				listView.ColumnClick -= value2;
				listView.SelectedIndexChanged -= value3;
			}
			_ListView1 = value;
			listView = _ListView1;
			if (listView != null)
			{
				listView.ColumnClick += value2;
				listView.SelectedIndexChanged += value3;
			}
		}
	}

	[field: AccessedThroughProperty("Id")]
	internal virtual ColumnHeader Id
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

	[field: AccessedThroughProperty("Retiro")]
	internal virtual ColumnHeader Retiro
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

	[field: AccessedThroughProperty("Label6")]
	internal virtual Label Label6
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

	[field: AccessedThroughProperty("Label8")]
	internal virtual Label Label8
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

	[field: AccessedThroughProperty("TextBox2")]
	internal virtual TextBox TextBox2
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

	[field: AccessedThroughProperty("TextBox4")]
	internal virtual TextBox TextBox4
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

	[field: AccessedThroughProperty("TextBox6")]
	internal virtual TextBox TextBox6
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

	[field: AccessedThroughProperty("TextBox8")]
	internal virtual TextBox TextBox8
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

	[field: AccessedThroughProperty("id_lbl")]
	internal virtual Label id_lbl
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

	internal virtual Button btn2
	{
		[CompilerGenerated]
		get
		{
			return _btn2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = btn2_Click;
			Button button = _btn2;
			if (button != null)
			{
				button.Click -= value2;
			}
			_btn2 = value;
			button = _btn2;
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

	public Clientes()
	{
		base.Load += Clientes_Load;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hermes.Clientes));
		this.GroupBox1 = new System.Windows.Forms.GroupBox();
		this.ListView1 = new System.Windows.Forms.ListView();
		this.Id = new System.Windows.Forms.ColumnHeader();
		this.Nombre = new System.Windows.Forms.ColumnHeader();
		this.Cuenta = new System.Windows.Forms.ColumnHeader();
		this.Domicilio = new System.Windows.Forms.ColumnHeader();
		this.CP = new System.Windows.Forms.ColumnHeader();
		this.Localidad = new System.Windows.Forms.ColumnHeader();
		this.Horario = new System.Windows.Forms.ColumnHeader();
		this.Contacto = new System.Windows.Forms.ColumnHeader();
		this.Retiro = new System.Windows.Forms.ColumnHeader();
		this.btn1 = new System.Windows.Forms.Button();
		this.btn2 = new System.Windows.Forms.Button();
		this.btn3 = new System.Windows.Forms.Button();
		this.Label1 = new System.Windows.Forms.Label();
		this.Label2 = new System.Windows.Forms.Label();
		this.Label3 = new System.Windows.Forms.Label();
		this.Label4 = new System.Windows.Forms.Label();
		this.Label5 = new System.Windows.Forms.Label();
		this.Label6 = new System.Windows.Forms.Label();
		this.Label7 = new System.Windows.Forms.Label();
		this.Label8 = new System.Windows.Forms.Label();
		this.TextBox1 = new System.Windows.Forms.TextBox();
		this.TextBox2 = new System.Windows.Forms.TextBox();
		this.TextBox3 = new System.Windows.Forms.TextBox();
		this.TextBox4 = new System.Windows.Forms.TextBox();
		this.TextBox5 = new System.Windows.Forms.TextBox();
		this.TextBox6 = new System.Windows.Forms.TextBox();
		this.TextBox7 = new System.Windows.Forms.TextBox();
		this.TextBox8 = new System.Windows.Forms.TextBox();
		this.Label9 = new System.Windows.Forms.Label();
		this.id_lbl = new System.Windows.Forms.Label();
		this.Label11 = new System.Windows.Forms.Label();
		this.salirbtn = new System.Windows.Forms.Button();
		this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
		this.GroupBox1.SuspendLayout();
		base.SuspendLayout();
		this.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.GroupBox1.Controls.Add(this.ListView1);
		this.GroupBox1.Location = new System.Drawing.Point(12, 151);
		this.GroupBox1.Name = "GroupBox1";
		this.GroupBox1.Size = new System.Drawing.Size(895, 267);
		this.GroupBox1.TabIndex = 0;
		this.GroupBox1.TabStop = false;
		this.GroupBox1.Text = "Clientes";
		this.ListView1.AllowColumnReorder = true;
		this.ListView1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.ListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[9] { this.Id, this.Nombre, this.Cuenta, this.Domicilio, this.CP, this.Localidad, this.Horario, this.Contacto, this.Retiro });
		this.ListView1.GridLines = true;
		this.ListView1.Location = new System.Drawing.Point(6, 19);
		this.ListView1.MultiSelect = false;
		this.ListView1.Name = "ListView1";
		this.ListView1.Size = new System.Drawing.Size(882, 242);
		this.ListView1.TabIndex = 0;
		this.ListView1.UseCompatibleStateImageBehavior = false;
		this.ListView1.View = System.Windows.Forms.View.Details;
		this.Id.Text = "ID";
		this.Id.Width = 40;
		this.Nombre.Text = "Nombre";
		this.Nombre.Width = 170;
		this.Cuenta.Text = "Cuenta";
		this.Domicilio.Text = "Domicilio";
		this.Domicilio.Width = 120;
		this.CP.Text = "CP";
		this.Localidad.Text = "Localidad";
		this.Localidad.Width = 120;
		this.Horario.Text = "Horario";
		this.Horario.Width = 100;
		this.Contacto.Text = "Contacto";
		this.Contacto.Width = 120;
		this.Retiro.Text = "Retiro";
		this.Retiro.Width = 80;
		this.btn1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.btn1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
		this.btn1.Location = new System.Drawing.Point(18, 427);
		this.btn1.Name = "btn1";
		this.btn1.Size = new System.Drawing.Size(75, 57);
		this.btn1.TabIndex = 0;
		this.btn1.Text = "Guardar";
		this.btn1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
		this.btn1.UseVisualStyleBackColor = true;
		this.btn2.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.btn2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
		this.btn2.Location = new System.Drawing.Point(99, 428);
		this.btn2.Name = "btn2";
		this.btn2.Size = new System.Drawing.Size(75, 57);
		this.btn2.TabIndex = 4;
		this.btn2.Text = "Editar";
		this.btn2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
		this.btn2.UseVisualStyleBackColor = true;
		this.btn3.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.btn3.Image = (System.Drawing.Image)resources.GetObject("btn3.Image");
		this.btn3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
		this.btn3.Location = new System.Drawing.Point(180, 427);
		this.btn3.Name = "btn3";
		this.btn3.Size = new System.Drawing.Size(75, 57);
		this.btn3.TabIndex = 2;
		this.btn3.Text = "Borrar";
		this.btn3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
		this.btn3.UseVisualStyleBackColor = true;
		this.Label1.AutoSize = true;
		this.Label1.Location = new System.Drawing.Point(12, 18);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(47, 13);
		this.Label1.TabIndex = 2;
		this.Label1.Text = "Nombre:";
		this.Label2.AutoSize = true;
		this.Label2.Location = new System.Drawing.Point(12, 44);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(44, 13);
		this.Label2.TabIndex = 3;
		this.Label2.Text = "Cuenta:";
		this.Label3.AutoSize = true;
		this.Label3.Location = new System.Drawing.Point(12, 70);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(52, 13);
		this.Label3.TabIndex = 4;
		this.Label3.Text = "Domicilio:";
		this.Label4.AutoSize = true;
		this.Label4.Location = new System.Drawing.Point(12, 96);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(24, 13);
		this.Label4.TabIndex = 5;
		this.Label4.Text = "CP:";
		this.Label5.AutoSize = true;
		this.Label5.Location = new System.Drawing.Point(12, 122);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(56, 13);
		this.Label5.TabIndex = 6;
		this.Label5.Text = "Localidad:";
		this.Label6.AutoSize = true;
		this.Label6.Location = new System.Drawing.Point(468, 18);
		this.Label6.Name = "Label6";
		this.Label6.Size = new System.Drawing.Size(44, 13);
		this.Label6.TabIndex = 7;
		this.Label6.Text = "Horario:";
		this.Label7.AutoSize = true;
		this.Label7.Location = new System.Drawing.Point(468, 44);
		this.Label7.Name = "Label7";
		this.Label7.Size = new System.Drawing.Size(53, 13);
		this.Label7.TabIndex = 8;
		this.Label7.Text = "Contacto:";
		this.Label8.AutoSize = true;
		this.Label8.Location = new System.Drawing.Point(468, 70);
		this.Label8.Name = "Label8";
		this.Label8.Size = new System.Drawing.Size(38, 13);
		this.Label8.TabIndex = 9;
		this.Label8.Text = "Retiro:";
		this.TextBox1.Location = new System.Drawing.Point(65, 15);
		this.TextBox1.Name = "TextBox1";
		this.TextBox1.Size = new System.Drawing.Size(350, 20);
		this.TextBox1.TabIndex = 10;
		this.TextBox2.Location = new System.Drawing.Point(65, 41);
		this.TextBox2.Name = "TextBox2";
		this.TextBox2.Size = new System.Drawing.Size(100, 20);
		this.TextBox2.TabIndex = 11;
		this.TextBox3.Location = new System.Drawing.Point(65, 67);
		this.TextBox3.Name = "TextBox3";
		this.TextBox3.Size = new System.Drawing.Size(350, 20);
		this.TextBox3.TabIndex = 12;
		this.TextBox4.Location = new System.Drawing.Point(65, 93);
		this.TextBox4.Name = "TextBox4";
		this.TextBox4.Size = new System.Drawing.Size(100, 20);
		this.TextBox4.TabIndex = 13;
		this.TextBox5.Location = new System.Drawing.Point(65, 119);
		this.TextBox5.Name = "TextBox5";
		this.TextBox5.Size = new System.Drawing.Size(350, 20);
		this.TextBox5.TabIndex = 14;
		this.TextBox6.Location = new System.Drawing.Point(537, 15);
		this.TextBox6.Name = "TextBox6";
		this.TextBox6.Size = new System.Drawing.Size(284, 20);
		this.TextBox6.TabIndex = 15;
		this.TextBox7.Location = new System.Drawing.Point(537, 41);
		this.TextBox7.Name = "TextBox7";
		this.TextBox7.Size = new System.Drawing.Size(284, 20);
		this.TextBox7.TabIndex = 16;
		this.TextBox8.Location = new System.Drawing.Point(537, 67);
		this.TextBox8.Name = "TextBox8";
		this.TextBox8.Size = new System.Drawing.Size(284, 20);
		this.TextBox8.TabIndex = 17;
		this.Label9.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		this.Label9.AutoSize = true;
		this.Label9.Location = new System.Drawing.Point(861, 421);
		this.Label9.Name = "Label9";
		this.Label9.Size = new System.Drawing.Size(39, 13);
		this.Label9.TabIndex = 18;
		this.Label9.Text = "Label9";
		this.id_lbl.AutoSize = true;
		this.id_lbl.Location = new System.Drawing.Point(534, 96);
		this.id_lbl.Name = "id_lbl";
		this.id_lbl.Size = new System.Drawing.Size(13, 13);
		this.id_lbl.TabIndex = 19;
		this.id_lbl.Text = "0";
		this.Label11.AutoSize = true;
		this.Label11.Location = new System.Drawing.Point(468, 96);
		this.Label11.Name = "Label11";
		this.Label11.Size = new System.Drawing.Size(21, 13);
		this.Label11.TabIndex = 20;
		this.Label11.Text = "ID:";
		this.salirbtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		this.salirbtn.Image = (System.Drawing.Image)resources.GetObject("salirbtn.Image");
		this.salirbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.salirbtn.Location = new System.Drawing.Point(834, 462);
		this.salirbtn.Name = "salirbtn";
		this.salirbtn.Size = new System.Drawing.Size(75, 23);
		this.salirbtn.TabIndex = 3;
		this.salirbtn.Text = "Salir";
		this.salirbtn.UseVisualStyleBackColor = true;
		this.StatusStrip1.Location = new System.Drawing.Point(0, 491);
		this.StatusStrip1.Name = "StatusStrip1";
		this.StatusStrip1.Size = new System.Drawing.Size(921, 22);
		this.StatusStrip1.TabIndex = 21;
		this.StatusStrip1.Text = "StatusStrip1";
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(921, 513);
		base.Controls.Add(this.btn3);
		base.Controls.Add(this.btn2);
		base.Controls.Add(this.btn1);
		base.Controls.Add(this.StatusStrip1);
		base.Controls.Add(this.Label11);
		base.Controls.Add(this.id_lbl);
		base.Controls.Add(this.Label9);
		base.Controls.Add(this.salirbtn);
		base.Controls.Add(this.TextBox8);
		base.Controls.Add(this.TextBox7);
		base.Controls.Add(this.TextBox6);
		base.Controls.Add(this.TextBox5);
		base.Controls.Add(this.TextBox4);
		base.Controls.Add(this.TextBox3);
		base.Controls.Add(this.TextBox2);
		base.Controls.Add(this.TextBox1);
		base.Controls.Add(this.Label8);
		base.Controls.Add(this.Label7);
		base.Controls.Add(this.Label6);
		base.Controls.Add(this.Label5);
		base.Controls.Add(this.Label4);
		base.Controls.Add(this.Label3);
		base.Controls.Add(this.Label2);
		base.Controls.Add(this.Label1);
		base.Controls.Add(this.GroupBox1);
		base.Name = "Clientes";
		this.Text = "Clientes";
		this.GroupBox1.ResumeLayout(false);
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private void Clientes_Load(object sender, EventArgs e)
	{
		llenar_clientes();
		if (Operators.CompareString(id_lbl.Text, "0", TextCompare: true) == 0)
		{
			btn1.Enabled = true;
			btn2.Enabled = false;
			btn3.Enabled = false;
		}
	}

	private void btn1_Click(object sender, EventArgs e)
	{
		string text = "INSERT INTO Clientes (";
		string text2 = ") VALUES (";
		if (Operators.CompareString(TextBox1.Text, "", TextCompare: true) != 0)
		{
			text += " Nombre";
			text2 = text2 + "'" + TextBox1.Text + "'";
			if (Operators.CompareString(TextBox2.Text, "", TextCompare: true) != 0)
			{
				text += ", Cuenta";
				text2 = (text2 + "," + TextBox2.Text) ?? "";
			}
			if (Operators.CompareString(TextBox3.Text, "", TextCompare: true) != 0)
			{
				text += ", Domicilio";
				text2 = text2 + ",'" + TextBox3.Text + "'";
			}
			if (Operators.CompareString(TextBox4.Text, "", TextCompare: true) != 0)
			{
				text += ", CP";
				text2 = (text2 + "," + TextBox4.Text) ?? "";
			}
			if (Operators.CompareString(TextBox5.Text, "", TextCompare: true) != 0)
			{
				text += ", Localidad";
				text2 = text2 + ",'" + TextBox5.Text + "'";
			}
			if (Operators.CompareString(TextBox6.Text, "", TextCompare: true) != 0)
			{
				text += ", Horario";
				text2 = text2 + ",'" + TextBox6.Text + "'";
			}
			if (Operators.CompareString(TextBox7.Text, "", TextCompare: true) != 0)
			{
				text += ", Contacto";
				text2 = text2 + ",'" + TextBox7.Text + "'";
			}
			if (Operators.CompareString(TextBox8.Text, "", TextCompare: true) != 0)
			{
				text += ", Retiro";
				text2 = (text2 + "," + Strings.Replace(TextBox8.Text, ",", ".", 1, -1, CompareMethod.Text)) ?? "";
			}
			if (Operators.CompareString(id_lbl.Text, "0", TextCompare: true) == 0)
			{
				string sql = text + text2 + " )";
				switch (Conversions.ToInteger(clientes_mod.nuevo_cliente(sql)))
				{
				case 1:
					Interaction.MsgBox("Cliente Creado");
					limpiar_campos();
					ListView1.Items.Clear();
					llenar_clientes();
					break;
				case 2:
					Interaction.MsgBox("Error al Crear Cliente");
					limpiar_campos();
					break;
				}
			}
			else
			{
				limpiar_campos();
				Interaction.MsgBox("Ingrese Nuevo Cliente");
				TextBox1.Focus();
			}
			id_lbl.Text = Conversions.ToString(0);
		}
		else
		{
			Interaction.MsgBox("El campo Nombre es Obligatorio");
			TextBox1.BackColor = Color.LimeGreen;
			TextBox1.Focus();
		}
	}

	private void btn2_Click(object sender, EventArgs e)
	{
		string text = "UPDATE Clientes SET";
		if (Operators.CompareString(TextBox1.Text, "", TextCompare: true) != 0)
		{
			text = text + " Nombre='" + TextBox1.Text + "'";
		}
		if (Operators.CompareString(TextBox2.Text, "", TextCompare: true) != 0)
		{
			text = (text + ", Cuenta=" + TextBox2.Text) ?? "";
		}
		if (Operators.CompareString(TextBox3.Text, "", TextCompare: true) != 0)
		{
			text = text + ", Domicilio='" + TextBox3.Text + "'";
		}
		if (Operators.CompareString(TextBox4.Text, "", TextCompare: true) != 0)
		{
			text = (text + ", CP=" + TextBox4.Text) ?? "";
		}
		if (Operators.CompareString(TextBox5.Text, "", TextCompare: true) != 0)
		{
			text = text + ", Localidad='" + TextBox5.Text + "'";
		}
		if (Operators.CompareString(TextBox6.Text, "", TextCompare: true) != 0)
		{
			text = text + ", Horario='" + TextBox6.Text + "'";
		}
		if (Operators.CompareString(TextBox7.Text, "", TextCompare: true) != 0)
		{
			text = text + ", Contacto='" + TextBox7.Text + "'";
		}
		if (Operators.CompareString(TextBox8.Text, "", TextCompare: true) != 0)
		{
			text = (text + ", Retiro=" + Strings.Replace(TextBox8.Text, ",", ".", 1, -1, CompareMethod.Text)) ?? "";
		}
		string sql = (text + " Where id=" + id_lbl.Text) ?? "";
		switch (Conversions.ToInteger(clientes_mod.editar_cliente(sql)))
		{
		case 1:
			Interaction.MsgBox("Cliente Editado");
			limpiar_campos();
			ListView1.Items.Clear();
			llenar_clientes();
			break;
		case 2:
			Interaction.MsgBox("Error al Editar Cliente");
			limpiar_campos();
			break;
		}
		id_lbl.Text = Conversions.ToString(0);
	}

	private void btn3_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(id_lbl.Text, "0", TextCompare: true) == 0)
		{
			Interaction.MsgBox("No se selecciono registro para Borrar");
			return;
		}
		DialogResult dialogResult = MessageBox.Show("Borrar Cliente", "Borrar", MessageBoxButtons.YesNo);
		if (dialogResult == DialogResult.Yes)
		{
			int id_cliente = Conversions.ToInteger(id_lbl.Text);
			switch (Conversions.ToInteger(clientes_mod.borrar_cliente(id_cliente)))
			{
			case 1:
				Interaction.MsgBox("Cliente Eliminado");
				limpiar_campos();
				ListView1.Items.Clear();
				llenar_clientes();
				break;
			case 2:
				Interaction.MsgBox("Error al Eliminar Cliente");
				limpiar_campos();
				break;
			}
		}
	}

	private void salirbtn_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void limpiar_campos()
	{
		id_lbl.Text = "0";
		TextBox1.Text = "";
		TextBox2.Text = "";
		TextBox3.Text = "";
		TextBox4.Text = "";
		TextBox5.Text = "";
		TextBox6.Text = "";
		TextBox7.Text = "";
		TextBox8.Text = "";
		TextBox1.BackColor = Color.White;
		btn1.Enabled = true;
		btn2.Enabled = false;
		btn3.Enabled = false;
	}

	private void llenar_clientes()
	{
		string sql = "SELECT id,Nombre,Cuenta,Domicilio,CP,Localidad,Horario,Contacto, Retiro FROM Clientes";
		Mod_Sentencias.cargar_datos_lv(ListView1, sql, Label9);
	}

	private void ListView1_ColumnClick(object sender, ColumnClickEventArgs e)
	{
		Mod_Ordenaclumnas.ordenar_columnas(ListView1, RuntimeHelpers.GetObjectValue(sender), e);
	}

	private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
	{
		Selected_item();
	}

	private void Selected_item()
	{
		limpiar_campos();
		if (ListView1.SelectedItems.Count > 0)
		{
			int index = ListView1.SelectedIndices[0];
			id_lbl.Text = ListView1.Items[index].Text;
			TextBox1.Text = ListView1.Items[index].SubItems[1].Text;
			TextBox2.Text = ListView1.Items[index].SubItems[2].Text;
			TextBox3.Text = ListView1.Items[index].SubItems[3].Text;
			TextBox4.Text = ListView1.Items[index].SubItems[4].Text;
			TextBox5.Text = ListView1.Items[index].SubItems[5].Text;
			TextBox6.Text = ListView1.Items[index].SubItems[6].Text;
			TextBox7.Text = ListView1.Items[index].SubItems[7].Text;
			TextBox8.Text = ListView1.Items[index].SubItems[8].Text;
			btn1.Enabled = true;
			btn2.Enabled = true;
			btn3.Enabled = true;
		}
		ListView1.Refresh();
	}
}
