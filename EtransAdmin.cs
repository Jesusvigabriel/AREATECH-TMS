using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace Hermes;

[DesignerGenerated]
public class EtransAdmin : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button2")]
	private Button _Button2;

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
	[AccessedThroughProperty("Button11")]
	private Button _Button11;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button12")]
	private Button _Button12;

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

	[field: AccessedThroughProperty("DateTimePicker1")]
	internal virtual DateTimePicker DateTimePicker1
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

	[field: AccessedThroughProperty("TextBox1")]
	internal virtual TextBox TextBox1
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

	public EtransAdmin()
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
		this.Button1 = new System.Windows.Forms.Button();
		this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
		this.Label1 = new System.Windows.Forms.Label();
		this.Label2 = new System.Windows.Forms.Label();
		this.Label3 = new System.Windows.Forms.Label();
		this.Label4 = new System.Windows.Forms.Label();
		this.Label5 = new System.Windows.Forms.Label();
		this.Label6 = new System.Windows.Forms.Label();
		this.Button2 = new System.Windows.Forms.Button();
		this.Button3 = new System.Windows.Forms.Button();
		this.Button4 = new System.Windows.Forms.Button();
		this.Button5 = new System.Windows.Forms.Button();
		this.Button6 = new System.Windows.Forms.Button();
		this.Button7 = new System.Windows.Forms.Button();
		this.Button8 = new System.Windows.Forms.Button();
		this.Button9 = new System.Windows.Forms.Button();
		this.Button10 = new System.Windows.Forms.Button();
		this.Button11 = new System.Windows.Forms.Button();
		this.TextBox1 = new System.Windows.Forms.TextBox();
		this.Label7 = new System.Windows.Forms.Label();
		this.Button12 = new System.Windows.Forms.Button();
		base.SuspendLayout();
		this.Button1.Location = new System.Drawing.Point(12, 12);
		this.Button1.Name = "Button1";
		this.Button1.Size = new System.Drawing.Size(75, 23);
		this.Button1.TabIndex = 0;
		this.Button1.Text = "Ingresar";
		this.Button1.UseVisualStyleBackColor = true;
		this.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
		this.DateTimePicker1.Location = new System.Drawing.Point(222, 15);
		this.DateTimePicker1.Name = "DateTimePicker1";
		this.DateTimePicker1.Size = new System.Drawing.Size(103, 20);
		this.DateTimePicker1.TabIndex = 1;
		this.Label1.AutoSize = true;
		this.Label1.Location = new System.Drawing.Point(16, 51);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(69, 13);
		this.Label1.TabIndex = 2;
		this.Label1.Text = "Transaccion:";
		this.Label2.AutoSize = true;
		this.Label2.Location = new System.Drawing.Point(16, 87);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(73, 13);
		this.Label2.TabIndex = 3;
		this.Label2.Text = "Comprobante:";
		this.Label3.AutoSize = true;
		this.Label3.Location = new System.Drawing.Point(16, 122);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(43, 13);
		this.Label3.TabIndex = 4;
		this.Label3.Text = "Estado:";
		this.Label4.AutoSize = true;
		this.Label4.Location = new System.Drawing.Point(116, 51);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(13, 13);
		this.Label4.TabIndex = 5;
		this.Label4.Text = "0";
		this.Label5.AutoSize = true;
		this.Label5.Location = new System.Drawing.Point(116, 87);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(13, 13);
		this.Label5.TabIndex = 6;
		this.Label5.Text = "0";
		this.Label6.AutoSize = true;
		this.Label6.Location = new System.Drawing.Point(116, 122);
		this.Label6.Name = "Label6";
		this.Label6.Size = new System.Drawing.Size(13, 13);
		this.Label6.TabIndex = 7;
		this.Label6.Text = "0";
		this.Button2.Location = new System.Drawing.Point(12, 222);
		this.Button2.Name = "Button2";
		this.Button2.Size = new System.Drawing.Size(143, 23);
		this.Button2.TabIndex = 8;
		this.Button2.Text = "Ruteado";
		this.Button2.UseVisualStyleBackColor = true;
		this.Button3.Location = new System.Drawing.Point(12, 251);
		this.Button3.Name = "Button3";
		this.Button3.Size = new System.Drawing.Size(143, 23);
		this.Button3.TabIndex = 9;
		this.Button3.Text = "En Recoleccion";
		this.Button3.UseVisualStyleBackColor = true;
		this.Button4.Location = new System.Drawing.Point(12, 280);
		this.Button4.Name = "Button4";
		this.Button4.Size = new System.Drawing.Size(143, 23);
		this.Button4.TabIndex = 10;
		this.Button4.Text = "Recolectado";
		this.Button4.UseVisualStyleBackColor = true;
		this.Button5.Location = new System.Drawing.Point(12, 309);
		this.Button5.Name = "Button5";
		this.Button5.Size = new System.Drawing.Size(143, 23);
		this.Button5.TabIndex = 11;
		this.Button5.Text = "No Recolectado";
		this.Button5.UseVisualStyleBackColor = true;
		this.Button6.Location = new System.Drawing.Point(182, 222);
		this.Button6.Name = "Button6";
		this.Button6.Size = new System.Drawing.Size(143, 23);
		this.Button6.TabIndex = 12;
		this.Button6.Text = "En CD";
		this.Button6.UseVisualStyleBackColor = true;
		this.Button7.Location = new System.Drawing.Point(182, 251);
		this.Button7.Name = "Button7";
		this.Button7.Size = new System.Drawing.Size(143, 23);
		this.Button7.TabIndex = 13;
		this.Button7.Text = "Despachado";
		this.Button7.UseVisualStyleBackColor = true;
		this.Button8.Location = new System.Drawing.Point(182, 280);
		this.Button8.Name = "Button8";
		this.Button8.Size = new System.Drawing.Size(143, 23);
		this.Button8.TabIndex = 14;
		this.Button8.Text = "Entregado";
		this.Button8.UseVisualStyleBackColor = true;
		this.Button9.Location = new System.Drawing.Point(182, 309);
		this.Button9.Name = "Button9";
		this.Button9.Size = new System.Drawing.Size(143, 23);
		this.Button9.TabIndex = 15;
		this.Button9.Text = "No Entregado";
		this.Button9.UseVisualStyleBackColor = true;
		this.Button10.Location = new System.Drawing.Point(12, 367);
		this.Button10.Name = "Button10";
		this.Button10.Size = new System.Drawing.Size(143, 23);
		this.Button10.TabIndex = 16;
		this.Button10.Text = "Sincronizar Web";
		this.Button10.UseVisualStyleBackColor = true;
		this.Button11.Location = new System.Drawing.Point(250, 367);
		this.Button11.Name = "Button11";
		this.Button11.Size = new System.Drawing.Size(75, 23);
		this.Button11.TabIndex = 17;
		this.Button11.Text = "Salir";
		this.Button11.UseVisualStyleBackColor = true;
		this.TextBox1.Location = new System.Drawing.Point(141, 157);
		this.TextBox1.Name = "TextBox1";
		this.TextBox1.Size = new System.Drawing.Size(160, 20);
		this.TextBox1.TabIndex = 18;
		this.Label7.AutoSize = true;
		this.Label7.Location = new System.Drawing.Point(15, 160);
		this.Label7.Name = "Label7";
		this.Label7.Size = new System.Drawing.Size(120, 13);
		this.Label7.TabIndex = 19;
		this.Label7.Text = "Actualizar envios viejos:";
		this.Button12.Location = new System.Drawing.Point(119, 183);
		this.Button12.Name = "Button12";
		this.Button12.Size = new System.Drawing.Size(75, 23);
		this.Button12.TabIndex = 20;
		this.Button12.Text = "Entregado";
		this.Button12.UseVisualStyleBackColor = true;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(339, 402);
		base.Controls.Add(this.Button12);
		base.Controls.Add(this.Label7);
		base.Controls.Add(this.TextBox1);
		base.Controls.Add(this.Button11);
		base.Controls.Add(this.Button10);
		base.Controls.Add(this.Button9);
		base.Controls.Add(this.Button8);
		base.Controls.Add(this.Button7);
		base.Controls.Add(this.Button6);
		base.Controls.Add(this.Button5);
		base.Controls.Add(this.Button4);
		base.Controls.Add(this.Button3);
		base.Controls.Add(this.Button2);
		base.Controls.Add(this.Label6);
		base.Controls.Add(this.Label5);
		base.Controls.Add(this.Label4);
		base.Controls.Add(this.Label3);
		base.Controls.Add(this.Label2);
		base.Controls.Add(this.Label1);
		base.Controls.Add(this.DateTimePicker1);
		base.Controls.Add(this.Button1);
		base.Name = "EtransAdmin";
		this.Text = "Etrans";
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private void Button11_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		try
		{
			string text = Interaction.InputBox("Transaccion", "Transaccion");
			if (Operators.CompareString(text, "", TextCompare: true) == 0)
			{
				Interaction.MsgBox("Ingrese un numero de Transaccion");
				return;
			}
			string text2 = Strings.Format(DateTimePicker1.Value, "yyyyMMdd");
			string sql = "Select Remitos,Comprobante,Estado from Planchada where remitos=" + text + " AND cliente='ETRANS' AND Fecha='" + text2 + "'";
			consulta_db(sql);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objExcepcion = ex;
			Logger.e("Error con excepción y traza", objExcepcion, new StackFrame(fNeedFileInfo: true));
			ProjectData.ClearProjectError();
		}
	}

	private void consulta_db(string sql)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		try
		{
			DataTable dataTable = new DataTable("x");
			MySqlDataAdapter val = new MySqlDataAdapter(sql, Mod_Sentencias.cnn);
			((DbDataAdapter)(object)val).Fill(dataTable);
			string text = dataTable.Rows[0]["Remitos"].ToString();
			string text2 = dataTable.Rows[0]["Comprobante"].ToString();
			string text3 = dataTable.Rows[0]["Estado"].ToString();
			Label4.Text = text;
			Label5.Text = text2;
			Label6.Text = text3;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox(ex2.Message);
			Logger.e("Error con excepción y traza", ex2, new StackFrame(fNeedFileInfo: true));
			ProjectData.ClearProjectError();
		}
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		try
		{
			string text = Strings.Format(DateTimePicker1.Value, "yyyyMMdd");
			string sQL = "UPDATE Planchada SET Estado = 'Ruteado' WHERE Comprobante= " + Label5.Text + " AND cliente='ETRANS' AND Fecha = '" + text + "'";
			Mod_ConeccionBD.BD_Sentencia(sQL);
			string sql = "Select Remitos,Comprobante,Estado from Planchada where remitos=" + Label4.Text + " AND cliente='ETRANS' AND Fecha='" + text + "'";
			consulta_db(sql);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox(ex2.Message);
			Logger.e("Error con excepción y traza", ex2, new StackFrame(fNeedFileInfo: true));
			ProjectData.ClearProjectError();
		}
	}

	private void Button3_Click(object sender, EventArgs e)
	{
		try
		{
			string text = Strings.Format(DateTimePicker1.Value, "yyyyMMdd");
			string sQL = "UPDATE Planchada SET Estado = 'EN RECOLECCION' WHERE Comprobante= " + Label5.Text + " AND cliente='ETRANS' AND Fecha = '" + text + "'";
			Mod_ConeccionBD.BD_Sentencia(sQL);
			string sql = "Select Remitos,Comprobante,Estado from Planchada where remitos=" + Label4.Text + " AND cliente='ETRANS' AND Fecha='" + text + "'";
			consulta_db(sql);
			Mod_Etrans.actualizar_estado_web(Conversions.ToInteger(Label4.Text), 3);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox(ex2.Message);
			Logger.e("Error con excepción y traza", ex2, new StackFrame(fNeedFileInfo: true));
			ProjectData.ClearProjectError();
		}
	}

	private void Button4_Click(object sender, EventArgs e)
	{
		try
		{
			string text = Strings.Format(DateTimePicker1.Value, "yyyyMMdd");
			string sQL = "UPDATE Planchada SET Estado = 'RECOLECTADO' WHERE Comprobante= " + Label5.Text + " AND cliente='ETRANS' AND Fecha = '" + text + "'";
			Mod_ConeccionBD.BD_Sentencia(sQL);
			string sql = "Select Remitos,Comprobante,Estado from Planchada where remitos=" + Label4.Text + " AND cliente='ETRANS' AND Fecha='" + text + "'";
			consulta_db(sql);
			Mod_Etrans.actualizar_estado_web(Conversions.ToInteger(Label4.Text), 4);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox(ex2.Message);
			Logger.e("Error con excepción y traza", ex2, new StackFrame(fNeedFileInfo: true));
			ProjectData.ClearProjectError();
		}
	}

	private void Button5_Click(object sender, EventArgs e)
	{
		try
		{
			string text = Strings.Format(DateTimePicker1.Value, "yyyyMMdd");
			string sQL = "UPDATE Planchada SET Estado = 'NO RECOLECTADO' WHERE Comprobante= " + Label5.Text + " AND cliente='ETRANS' AND Fecha = '" + text + "'";
			Mod_ConeccionBD.BD_Sentencia(sQL);
			string sql = "Select Remitos,Comprobante,Estado from Planchada where remitos=" + Label4.Text + " AND cliente='ETRANS' AND Fecha='" + text + "'";
			consulta_db(sql);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox(ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void Button6_Click(object sender, EventArgs e)
	{
		try
		{
			string text = Strings.Format(DateTimePicker1.Value, "yyyyMMdd");
			string sQL = "UPDATE Planchada SET Estado = 'EN CD' WHERE Comprobante= " + Label5.Text + " AND cliente='ETRANS' AND Fecha = '" + text + "'";
			Mod_ConeccionBD.BD_Sentencia(sQL);
			string sql = "Select Remitos,Comprobante,Estado from Planchada where remitos=" + Label4.Text + " AND cliente='ETRANS' AND Fecha='" + text + "'";
			consulta_db(sql);
			Mod_Etrans.actualizar_estados(Conversions.ToInteger(Label4.Text), "EN CD");
			Mod_Etrans.actualizar_estado_web(Conversions.ToInteger(Label4.Text), 5);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox(ex2.Message);
			Logger.e("Error con excepción y traza", ex2, new StackFrame(fNeedFileInfo: true));
			ProjectData.ClearProjectError();
		}
	}

	private void Button7_Click(object sender, EventArgs e)
	{
		try
		{
			string text = Strings.Format(DateTimePicker1.Value, "yyyyMMdd");
			string sQL = "UPDATE Planchada SET Estado = 'DESPACHADO' WHERE Comprobante= " + Label5.Text + " AND cliente='ETRANS' AND Fecha = '" + text + "'";
			Mod_ConeccionBD.BD_Sentencia(sQL);
			string sql = "Select Remitos,Comprobante,Estado from Planchada where remitos=" + Label4.Text + " AND cliente='ETRANS' AND Fecha='" + text + "'";
			consulta_db(sql);
			Mod_Etrans.actualizar_estado_web(Conversions.ToInteger(Label4.Text), 6);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox(ex2.Message);
			Logger.e("Error con excepción y traza", ex2, new StackFrame(fNeedFileInfo: true));
			ProjectData.ClearProjectError();
		}
	}

	private void Button8_Click(object sender, EventArgs e)
	{
		try
		{
			string text = Strings.Format(DateTimePicker1.Value, "yyyyMMdd");
			string sQL = "UPDATE Planchada SET Estado = 'ENTREGADO' WHERE Comprobante= " + Label5.Text + " AND cliente='ETRANS' AND Fecha = '" + text + "'";
			Mod_ConeccionBD.BD_Sentencia(sQL);
			string sql = "Select Remitos,Comprobante,Estado from Planchada where remitos=" + Label4.Text + " AND cliente='ETRANS' AND Fecha='" + text + "'";
			consulta_db(sql);
			Mod_Etrans.actualizar_estado_web(Conversions.ToInteger(Label4.Text), 8);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox(ex2.Message);
			Logger.e("Error con excepción y traza", ex2, new StackFrame(fNeedFileInfo: true));
			ProjectData.ClearProjectError();
		}
	}

	private void Button9_Click(object sender, EventArgs e)
	{
		try
		{
			string text = Strings.Format(DateTimePicker1.Value, "yyyyMMdd");
			string sQL = "UPDATE Planchada SET Estado = 'NO ENTREGADO' WHERE Comprobante= " + Label5.Text + " AND cliente='ETRANS' AND Fecha = '" + text + "'";
			Mod_ConeccionBD.BD_Sentencia(sQL);
			string sql = "Select Remitos,Comprobante,Estado from Planchada where remitos=" + Label4.Text + " AND cliente='ETRANS' AND Fecha='" + text + "'";
			consulta_db(sql);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox(ex2.Message);
			Logger.e("Error con excepción y traza", ex2, new StackFrame(fNeedFileInfo: true));
			ProjectData.ClearProjectError();
		}
	}

	private void Button10_Click(object sender, EventArgs e)
	{
		try
		{
			string requestUriString = string.Empty;
			if (Operators.CompareString(Mod_Sentencias.baseDD, "hermes", TextCompare: true) == 0)
			{
				requestUriString = "http://www.etrans.com.ar/admin/cronServiceEstados.php";
			}
			else if (Operators.CompareString(Mod_Sentencias.baseDD, "hermesDev", TextCompare: true) == 0)
			{
				requestUriString = "http://h8000127.ferozo.com/admin/cronServiceEstados.php";
			}
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(requestUriString);
			httpWebRequest.Credentials = CredentialCache.DefaultCredentials;
			HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
			Stream responseStream = httpWebResponse.GetResponseStream();
			StreamReader streamReader = new StreamReader(responseStream);
			string text = streamReader.ReadToEnd();
			Interaction.MsgBox("Actualizado");
			string text2 = text;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objExcepcion = ex;
			Interaction.MsgBox("No se puede conectar al servicio");
			Logger.e("Error con excepción y traza", objExcepcion, new StackFrame(fNeedFileInfo: true));
			ProjectData.ClearProjectError();
		}
	}

	private void Button12_Click(object sender, EventArgs e)
	{
		string prompt = Conversions.ToString(Mod_Etrans.actualizar_estado_web(Conversions.ToInteger(TextBox1.Text), 8));
		Interaction.MsgBox(prompt);
	}
}
