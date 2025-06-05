using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Hermes;

[DesignerGenerated]
public class Variaciones : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[field: AccessedThroughProperty("GroupBox1")]
	internal virtual GroupBox GroupBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("empresalbl")]
	internal virtual Label empresalbl
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

	[field: AccessedThroughProperty("codigolbl")]
	internal virtual Label codigolbl
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

	[field: AccessedThroughProperty("descripcionlbl")]
	internal virtual Label descripcionlbl
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

	[field: AccessedThroughProperty("idproductolbl")]
	internal virtual Label idproductolbl
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

	[field: AccessedThroughProperty("GroupBox2")]
	internal virtual GroupBox GroupBox2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ListView1")]
	internal virtual ListView ListView1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Button3")]
	internal virtual Button Button3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Button2")]
	internal virtual Button Button2
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

	[field: AccessedThroughProperty("descripciontxt")]
	internal virtual TextBox descripciontxt
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

	[field: AccessedThroughProperty("Id")]
	internal virtual ColumnHeader Id
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("productid")]
	internal virtual ColumnHeader productid
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("descripcion")]
	internal virtual ColumnHeader descripcion
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("unidades")]
	internal virtual ColumnHeader unidades
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

	public Variaciones()
	{
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
		this.Label1 = new System.Windows.Forms.Label();
		this.idproductolbl = new System.Windows.Forms.Label();
		this.Label2 = new System.Windows.Forms.Label();
		this.descripcionlbl = new System.Windows.Forms.Label();
		this.Label3 = new System.Windows.Forms.Label();
		this.codigolbl = new System.Windows.Forms.Label();
		this.Label4 = new System.Windows.Forms.Label();
		this.empresalbl = new System.Windows.Forms.Label();
		this.GroupBox2 = new System.Windows.Forms.GroupBox();
		this.Label5 = new System.Windows.Forms.Label();
		this.descripciontxt = new System.Windows.Forms.TextBox();
		this.Button1 = new System.Windows.Forms.Button();
		this.Button2 = new System.Windows.Forms.Button();
		this.Button3 = new System.Windows.Forms.Button();
		this.ListView1 = new System.Windows.Forms.ListView();
		this.Id = new System.Windows.Forms.ColumnHeader();
		this.productid = new System.Windows.Forms.ColumnHeader();
		this.descripcion = new System.Windows.Forms.ColumnHeader();
		this.unidades = new System.Windows.Forms.ColumnHeader();
		this.Label6 = new System.Windows.Forms.Label();
		this.GroupBox1.SuspendLayout();
		this.GroupBox2.SuspendLayout();
		base.SuspendLayout();
		this.GroupBox1.Controls.Add(this.empresalbl);
		this.GroupBox1.Controls.Add(this.Label4);
		this.GroupBox1.Controls.Add(this.codigolbl);
		this.GroupBox1.Controls.Add(this.Label3);
		this.GroupBox1.Controls.Add(this.descripcionlbl);
		this.GroupBox1.Controls.Add(this.Label2);
		this.GroupBox1.Controls.Add(this.idproductolbl);
		this.GroupBox1.Controls.Add(this.Label1);
		this.GroupBox1.Location = new System.Drawing.Point(12, 12);
		this.GroupBox1.Name = "GroupBox1";
		this.GroupBox1.Size = new System.Drawing.Size(567, 101);
		this.GroupBox1.TabIndex = 0;
		this.GroupBox1.TabStop = false;
		this.GroupBox1.Text = "Producto";
		this.Label1.AutoSize = true;
		this.Label1.Location = new System.Drawing.Point(17, 25);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(19, 13);
		this.Label1.TabIndex = 0;
		this.Label1.Text = "Id:";
		this.idproductolbl.AutoSize = true;
		this.idproductolbl.Location = new System.Drawing.Point(42, 25);
		this.idproductolbl.Name = "idproductolbl";
		this.idproductolbl.Size = new System.Drawing.Size(39, 13);
		this.idproductolbl.TabIndex = 1;
		this.idproductolbl.Text = "Label2";
		this.Label2.AutoSize = true;
		this.Label2.Location = new System.Drawing.Point(17, 47);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(66, 13);
		this.Label2.TabIndex = 2;
		this.Label2.Text = "Descripción:";
		this.descripcionlbl.AutoSize = true;
		this.descripcionlbl.Location = new System.Drawing.Point(89, 47);
		this.descripcionlbl.Name = "descripcionlbl";
		this.descripcionlbl.Size = new System.Drawing.Size(39, 13);
		this.descripcionlbl.TabIndex = 3;
		this.descripcionlbl.Text = "Label3";
		this.Label3.AutoSize = true;
		this.Label3.Location = new System.Drawing.Point(373, 25);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(43, 13);
		this.Label3.TabIndex = 4;
		this.Label3.Text = "Código:";
		this.codigolbl.AutoSize = true;
		this.codigolbl.Location = new System.Drawing.Point(422, 25);
		this.codigolbl.Name = "codigolbl";
		this.codigolbl.Size = new System.Drawing.Size(39, 13);
		this.codigolbl.TabIndex = 5;
		this.codigolbl.Text = "Label4";
		this.Label4.AutoSize = true;
		this.Label4.Location = new System.Drawing.Point(17, 72);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(51, 13);
		this.Label4.TabIndex = 6;
		this.Label4.Text = "Empresa:";
		this.empresalbl.AutoSize = true;
		this.empresalbl.Location = new System.Drawing.Point(89, 72);
		this.empresalbl.Name = "empresalbl";
		this.empresalbl.Size = new System.Drawing.Size(39, 13);
		this.empresalbl.TabIndex = 7;
		this.empresalbl.Text = "Label5";
		this.GroupBox2.Controls.Add(this.Label6);
		this.GroupBox2.Controls.Add(this.ListView1);
		this.GroupBox2.Controls.Add(this.Button3);
		this.GroupBox2.Controls.Add(this.Button2);
		this.GroupBox2.Controls.Add(this.Button1);
		this.GroupBox2.Controls.Add(this.descripciontxt);
		this.GroupBox2.Controls.Add(this.Label5);
		this.GroupBox2.Location = new System.Drawing.Point(12, 119);
		this.GroupBox2.Name = "GroupBox2";
		this.GroupBox2.Size = new System.Drawing.Size(567, 304);
		this.GroupBox2.TabIndex = 1;
		this.GroupBox2.TabStop = false;
		this.GroupBox2.Text = "Variacion";
		this.Label5.AutoSize = true;
		this.Label5.Location = new System.Drawing.Point(34, 40);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(66, 13);
		this.Label5.TabIndex = 0;
		this.Label5.Text = "Descripción:";
		this.descripciontxt.Location = new System.Drawing.Point(106, 37);
		this.descripciontxt.Name = "descripciontxt";
		this.descripciontxt.Size = new System.Drawing.Size(441, 20);
		this.descripciontxt.TabIndex = 1;
		this.Button1.Location = new System.Drawing.Point(118, 81);
		this.Button1.Name = "Button1";
		this.Button1.Size = new System.Drawing.Size(75, 23);
		this.Button1.TabIndex = 2;
		this.Button1.Text = "Agregar";
		this.Button1.UseVisualStyleBackColor = true;
		this.Button2.Location = new System.Drawing.Point(229, 81);
		this.Button2.Name = "Button2";
		this.Button2.Size = new System.Drawing.Size(75, 23);
		this.Button2.TabIndex = 3;
		this.Button2.Text = "Editar";
		this.Button2.UseVisualStyleBackColor = true;
		this.Button3.Location = new System.Drawing.Point(340, 81);
		this.Button3.Name = "Button3";
		this.Button3.Size = new System.Drawing.Size(75, 23);
		this.Button3.TabIndex = 4;
		this.Button3.Text = "Eliminar";
		this.Button3.UseVisualStyleBackColor = true;
		this.ListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[4] { this.Id, this.productid, this.descripcion, this.unidades });
		this.ListView1.FullRowSelect = true;
		this.ListView1.GridLines = true;
		this.ListView1.Location = new System.Drawing.Point(7, 110);
		this.ListView1.Name = "ListView1";
		this.ListView1.Size = new System.Drawing.Size(554, 188);
		this.ListView1.TabIndex = 5;
		this.ListView1.UseCompatibleStateImageBehavior = false;
		this.ListView1.View = System.Windows.Forms.View.Details;
		this.Id.Text = "Id";
		this.productid.Text = "Producto";
		this.productid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		this.descripcion.Text = "Descripcion";
		this.unidades.Text = "Unidades";
		this.unidades.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		this.Label6.AutoSize = true;
		this.Label6.Location = new System.Drawing.Point(17, 86);
		this.Label6.Name = "Label6";
		this.Label6.Size = new System.Drawing.Size(39, 13);
		this.Label6.TabIndex = 6;
		this.Label6.Text = "Label6";
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(591, 435);
		base.Controls.Add(this.GroupBox2);
		base.Controls.Add(this.GroupBox1);
		base.Name = "Variaciones";
		this.Text = "Variaciones";
		this.GroupBox1.ResumeLayout(false);
		this.GroupBox1.PerformLayout();
		this.GroupBox2.ResumeLayout(false);
		this.GroupBox2.PerformLayout();
		base.ResumeLayout(false);
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		string sQL = "INSERT INTO Variaciones (producto_id, descripcion, unidades) VALUES (" + idproductolbl.Text + ",'" + descripciontxt.Text + "', 0)";
		Mod_ConeccionBD.BD_Sentencia(sQL);
		ListView1.Items.Clear();
		string sql = "SELECT * FROM Variaciones WHERE producto_id=" + idproductolbl.Text;
		Mod_Sentencias.cargar_datos_lv_completa(ListView1, sql, Label6);
	}
}
