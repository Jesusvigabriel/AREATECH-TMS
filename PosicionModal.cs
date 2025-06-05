using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Hermes.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Hermes;

[DesignerGenerated]
public class PosicionModal : Form
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

	public int mode;

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

	[field: AccessedThroughProperty("ComboBox3")]
	internal virtual ComboBox ComboBox3
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

	public PosicionModal()
	{
		base.Load += PosicionModal_Load;
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
		this.Label1 = new System.Windows.Forms.Label();
		this.ComboBox1 = new System.Windows.Forms.ComboBox();
		this.Label2 = new System.Windows.Forms.Label();
		this.ComboBox2 = new System.Windows.Forms.ComboBox();
		this.Label3 = new System.Windows.Forms.Label();
		this.ComboBox3 = new System.Windows.Forms.ComboBox();
		this.Button1 = new System.Windows.Forms.Button();
		this.Button2 = new System.Windows.Forms.Button();
		base.SuspendLayout();
		this.Label1.AutoSize = true;
		this.Label1.Location = new System.Drawing.Point(18, 29);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(77, 13);
		this.Label1.TabIndex = 0;
		this.Label1.Text = "Letra Posicion:";
		this.ComboBox1.FormattingEnabled = true;
		this.ComboBox1.Location = new System.Drawing.Point(151, 26);
		this.ComboBox1.Name = "ComboBox1";
		this.ComboBox1.Size = new System.Drawing.Size(121, 21);
		this.ComboBox1.TabIndex = 1;
		this.Label2.AutoSize = true;
		this.Label2.Location = new System.Drawing.Point(18, 56);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(111, 13);
		this.Label2.TabIndex = 2;
		this.Label2.Text = "Numero de Columnas:";
		this.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.ComboBox2.FormattingEnabled = true;
		this.ComboBox2.Location = new System.Drawing.Point(151, 53);
		this.ComboBox2.Name = "ComboBox2";
		this.ComboBox2.Size = new System.Drawing.Size(121, 21);
		this.ComboBox2.TabIndex = 3;
		this.Label3.AutoSize = true;
		this.Label3.Location = new System.Drawing.Point(18, 83);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(90, 13);
		this.Label3.TabIndex = 4;
		this.Label3.Text = "Número Posicion:";
		this.ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.ComboBox3.FormattingEnabled = true;
		this.ComboBox3.Location = new System.Drawing.Point(151, 80);
		this.ComboBox3.Name = "ComboBox3";
		this.ComboBox3.Size = new System.Drawing.Size(121, 21);
		this.ComboBox3.TabIndex = 5;
		this.Button1.Location = new System.Drawing.Point(12, 119);
		this.Button1.Name = "Button1";
		this.Button1.Size = new System.Drawing.Size(75, 23);
		this.Button1.TabIndex = 6;
		this.Button1.Text = "Crear";
		this.Button1.UseVisualStyleBackColor = true;
		this.Button2.Location = new System.Drawing.Point(197, 119);
		this.Button2.Name = "Button2";
		this.Button2.Size = new System.Drawing.Size(75, 23);
		this.Button2.TabIndex = 7;
		this.Button2.Text = "Cancelar";
		this.Button2.UseVisualStyleBackColor = true;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(284, 154);
		base.Controls.Add(this.Button2);
		base.Controls.Add(this.Button1);
		base.Controls.Add(this.ComboBox3);
		base.Controls.Add(this.Label3);
		base.Controls.Add(this.ComboBox2);
		base.Controls.Add(this.Label2);
		base.Controls.Add(this.ComboBox1);
		base.Controls.Add(this.Label1);
		base.Name = "PosicionModal";
		this.Text = "PosicionModal";
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		if ((Operators.CompareString(ComboBox1.Text, string.Empty, TextCompare: true) == 0) | (Operators.CompareString(ComboBox2.Text, string.Empty, TextCompare: true) == 0))
		{
			Interaction.MsgBox("Los campos no pueden estar vacios");
			return;
		}
		switch (mode)
		{
		case 0:
		{
			string rollo = ComboBox1.Text;
			string left = ComboBox1.Text;
			string text4 = ComboBox2.Text;
			if (Operators.CompareString(left, text4, TextCompare: true) == 0)
			{
				Interaction.MsgBox("La posicion Destino no puede ser igual a la de Origen");
			}
			else
			{
				mudarRollo(rollo, text4);
			}
			break;
		}
		case 1:
		{
			string text3 = ComboBox1.Text;
			int num = Conversions.ToInteger(ComboBox2.Text);
			int num2 = Conversions.ToInteger(ComboBox3.Text);
			int num3 = (int)MessageBox.Show("Se Crearan todas las posiciones hasta " + text3 + "-" + Conversions.ToString(num) + "-" + Conversions.ToString(num2), "Atencion", MessageBoxButtons.YesNoCancel);
			if (num3 != 2 && num3 != 7 && num3 == 6)
			{
				try
				{
					crearPosiciones(Strings.UCase(text3), num, num2);
					Almacen almacen = MyProject.Forms.Almacen;
					almacen.mode = 1;
					almacen.ListView1.Clear();
					string sql = "select id, descripcion FROM posicion";
					Mod_Sentencias.cargar_datos_lv_completa(almacen.ListView1, sql, almacen.Label1);
					almacen = null;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					Logger.e(ex2.Message);
					ProjectData.ClearProjectError();
				}
			}
			break;
		}
		case 2:
		{
			string text5 = Strings.Format(MyProject.Forms.Almacen.DateTimePicker1.Value, "yyyy-MM-dd");
			int num4 = Conversions.ToInteger(ComboBox1.Text);
			string text6 = ComboBox2.Text;
			if (Operators.CompareString(text6, string.Empty, TextCompare: true) == 0)
			{
				Interaction.MsgBox("Seleccione una posicion");
				return;
			}
			string sql2 = "SELECT id from posicion where descripcion='" + text6 + "' limit 1";
			DataTable dataTable = (DataTable)Mod_Sentencias.data(sql2);
			checked
			{
				if (dataTable.Rows.Count > 0)
				{
					int num5 = int.Parse(Conversions.ToString(dataTable.Rows[0]["id"]));
					string sql3 = "SELECT rollo from descarga where fecha like '%" + text5 + "%' AND pallet='" + Conversions.ToString(num4) + "'";
					DataTable dataTable2 = (DataTable)Mod_Sentencias.data(sql3);
					string text7 = string.Empty;
					int num6 = dataTable2.Rows.Count - 1;
					for (int i = 0; i <= num6; i++)
					{
						text7 = ((i != 0) ? Conversions.ToString(Operators.ConcatenateObject(text7 + "', '", dataTable2.Rows[i]["rollo"])) : Conversions.ToString(dataTable2.Rows[i]["rollo"]));
					}
					string sql4 = "SELECT id from productos where barrcode in ('" + text7 + "')";
					DataTable dataTable3 = (DataTable)Mod_Sentencias.data(sql4);
					int num7 = dataTable3.Rows.Count - 1;
					for (int j = 0; j <= num7; j++)
					{
						string sQL = "UPDATE Stock set unidades=1 where producto='" + Conversions.ToString(int.Parse(Conversions.ToString(dataTable3.Rows[j]["id"]))) + "'";
						Mod_ConeccionBD.BD_insert_ID(sQL);
						string sQL2 = "INSERT INTO ubicacion (codprod, posActual, posAnterior, fecha) values ('" + Conversions.ToString(int.Parse(Conversions.ToString(dataTable3.Rows[j]["id"]))) + "', '" + Conversions.ToString(num5) + "', '0', now()) ON DUPLICATE KEY UPDATE posActual ='" + Conversions.ToString(num5) + "',posAnterior='" + Conversions.ToString(num4) + "', fecha = now()";
						Mod_ConeccionBD.BD_insert_ID(sQL2);
					}
					break;
				}
				Interaction.MsgBox("No existe la posicion");
				return;
			}
		}
		case 3:
		{
			string text = ComboBox1.Text;
			string text2 = ComboBox2.Text;
			if (Operators.CompareString(text, text2, TextCompare: true) == 0)
			{
				Interaction.MsgBox("La posicion Destino no puede ser igual a la de Origen");
			}
			else
			{
				mudarPosicion(text, text2);
			}
			break;
		}
		}
		Close();
	}

	private void PosicionModal_Load(object sender, EventArgs e)
	{
		switch (mode)
		{
		case 1:
		{
			int num = 1;
			do
			{
				ComboBox2.Items.Add(num);
				ComboBox3.Items.Add(num);
				num = checked(num + 1);
			}
			while (num <= 999);
			break;
		}
		}
	}

	private void crearPosiciones(string letra, int columna, int pos)
	{
		string empty = string.Empty;
		checked
		{
			try
			{
				for (int i = 1; i <= columna; i++)
				{
					string text = string.Empty;
					switch (i.ToString().Length)
					{
					case 1:
						text = "00" + Conversions.ToString(i);
						break;
					case 2:
						text = "0" + Conversions.ToString(i);
						break;
					case 3:
						text = Conversions.ToString(i) ?? "";
						break;
					}
					for (int j = 1; j <= pos; j++)
					{
						string text2 = string.Empty;
						switch (j.ToString().Length)
						{
						case 1:
							text2 = "00" + Conversions.ToString(j);
							break;
						case 2:
							text2 = "0" + Conversions.ToString(j);
							break;
						case 3:
							text2 = Conversions.ToString(j);
							break;
						}
						string sQL = "INSERT INTO posicion (descripcion) Values ('" + letra + "-" + text + "-" + text2 + "')";
						Mod_ConeccionBD.BD_insert_ID(sQL);
					}
				}
				Interaction.MsgBox("Se crearon todas las posiciones para " + letra);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Logger.e(ex2.Message);
				ProjectData.ClearProjectError();
			}
		}
	}

	public void mudarPosicion(string origen, string destino)
	{
		checked
		{
			try
			{
				string sql = "select id from posicion where descripcion='" + origen + "' LIMIT 1";
				int num = int.Parse(Conversions.ToString(Mod_Sentencias.dataValue(sql, "id")));
				string sql2 = "select codprod from ubicacion where posActual=" + Conversions.ToString(num);
				DataTable dataTable = (DataTable)Mod_Sentencias.data(sql2);
				string sql3 = "select id from posicion where descripcion='" + destino + "' LIMIT 1";
				int num2 = int.Parse(Conversions.ToString(Mod_Sentencias.dataValue(sql3, "id")));
				string sql4 = "select codprod from ubicacion where posActual=" + Conversions.ToString(num2);
				DataTable dataTable2 = (DataTable)Mod_Sentencias.data(sql4);
				int num3 = dataTable.Rows.Count - 1;
				for (int i = 0; i <= num3; i++)
				{
					string sQL = "Update ubicacion set  posActual='" + Conversions.ToString(num2) + "' ,posAnterior='" + Conversions.ToString(num) + "' where codprod=" + Conversions.ToString(int.Parse(Conversions.ToString(dataTable.Rows[i]["codprod"])));
					int num4 = Conversions.ToInteger(Mod_ConeccionBD.BD_Sentencia(sQL));
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Logger.e(ex2.Message);
				ProjectData.ClearProjectError();
			}
		}
	}

	public void mudarRollo(string rollo, string destino)
	{
		try
		{
			string sql = "select id from posicion where descripcion='" + destino + "' LIMIT 1";
			int num = int.Parse(Conversions.ToString(Mod_Sentencias.dataValue(sql, "id")));
			string sql2 = "select p.id, u.posActual from productos p LEFT JOIN ubicacion u ON p.id = u.codprod where p.barrcode='" + rollo + "' LIMIT 1";
			DataTable dataTable = (DataTable)Mod_Sentencias.data(sql2);
			string text = "Update ubicacion set  posActual='" + Conversions.ToString(num) + "' , posAnterior='" + Conversions.ToString(int.Parse(Conversions.ToString(dataTable.Rows[0]["posActual"]))) + "' where codprod=" + Conversions.ToString(int.Parse(Conversions.ToString(dataTable.Rows[0]["id"])));
			Interaction.MsgBox(text);
			int num2 = Conversions.ToInteger(Mod_ConeccionBD.BD_Sentencia(text));
			Logger.i(text);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Logger.e(ex2.Message);
			ProjectData.ClearProjectError();
		}
	}
}
