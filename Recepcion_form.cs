using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Hermes.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace Hermes;

[DesignerGenerated]
public class Recepcion_form : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ListView1")]
	private ListView _ListView1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ComboBox1")]
	private ComboBox _ComboBox1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ComboBox2")]
	private ComboBox _ComboBox2;

	private string fecha1;

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

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
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

	internal virtual Label Label2
	{
		[CompilerGenerated]
		get
		{
			return _Label2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Label2_TextChanged;
			Label label = _Label2;
			if (label != null)
			{
				label.TextChanged -= value2;
			}
			_Label2 = value;
			label = _Label2;
			if (label != null)
			{
				label.TextChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("TextBox1")]
	internal virtual TextBox TextBox1
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

	[field: AccessedThroughProperty("Comprobante")]
	internal virtual ColumnHeader Comprobante
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("SubCuenta")]
	internal virtual ColumnHeader SubCuenta
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

	[field: AccessedThroughProperty("Remitos")]
	internal virtual ColumnHeader Remitos
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

	[field: AccessedThroughProperty("Estado")]
	internal virtual ColumnHeader Estado
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

	[field: AccessedThroughProperty("Observaciones")]
	internal virtual ColumnHeader Observaciones
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Comentario")]
	internal virtual ColumnHeader Comentario
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Novedad")]
	internal virtual ColumnHeader Novedad
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Usuario")]
	internal virtual ColumnHeader Usuario
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public Recepcion_form()
	{
		base.Load += Recepcion_form_Load;
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
		this.ListView1 = new System.Windows.Forms.ListView();
		this.Label1 = new System.Windows.Forms.Label();
		this.ComboBox1 = new System.Windows.Forms.ComboBox();
		this.Label2 = new System.Windows.Forms.Label();
		this.TextBox1 = new System.Windows.Forms.TextBox();
		this.Label3 = new System.Windows.Forms.Label();
		this.ComboBox2 = new System.Windows.Forms.ComboBox();
		this.Comprobante = new System.Windows.Forms.ColumnHeader();
		this.SubCuenta = new System.Windows.Forms.ColumnHeader();
		this.Destino = new System.Windows.Forms.ColumnHeader();
		this.Remitos = new System.Windows.Forms.ColumnHeader();
		this.Bultos = new System.Windows.Forms.ColumnHeader();
		this.Estado = new System.Windows.Forms.ColumnHeader();
		this.Fecha = new System.Windows.Forms.ColumnHeader();
		this.Observaciones = new System.Windows.Forms.ColumnHeader();
		this.Comentario = new System.Windows.Forms.ColumnHeader();
		this.Novedad = new System.Windows.Forms.ColumnHeader();
		this.Usuario = new System.Windows.Forms.ColumnHeader();
		base.SuspendLayout();
		this.ListView1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.ListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[11]
		{
			this.Comprobante, this.SubCuenta, this.Destino, this.Remitos, this.Bultos, this.Estado, this.Fecha, this.Observaciones, this.Comentario, this.Novedad,
			this.Usuario
		});
		this.ListView1.Location = new System.Drawing.Point(19, 111);
		this.ListView1.Name = "ListView1";
		this.ListView1.Size = new System.Drawing.Size(1152, 429);
		this.ListView1.TabIndex = 0;
		this.ListView1.UseCompatibleStateImageBehavior = false;
		this.Label1.AutoSize = true;
		this.Label1.Location = new System.Drawing.Point(16, 75);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(41, 13);
		this.Label1.TabIndex = 1;
		this.Label1.Text = "Chofer:";
		this.ComboBox1.FormattingEnabled = true;
		this.ComboBox1.Location = new System.Drawing.Point(72, 72);
		this.ComboBox1.Name = "ComboBox1";
		this.ComboBox1.Size = new System.Drawing.Size(251, 21);
		this.ComboBox1.TabIndex = 2;
		this.Label2.AutoSize = true;
		this.Label2.Location = new System.Drawing.Point(338, 75);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(73, 13);
		this.Label2.TabIndex = 3;
		this.Label2.Text = "numeroChofer";
		this.TextBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.TextBox1.Location = new System.Drawing.Point(1048, 75);
		this.TextBox1.Name = "TextBox1";
		this.TextBox1.Size = new System.Drawing.Size(123, 20);
		this.TextBox1.TabIndex = 4;
		this.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.Label3.AutoSize = true;
		this.Label3.Location = new System.Drawing.Point(1005, 78);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(37, 13);
		this.Label3.TabIndex = 5;
		this.Label3.Text = "Envio:";
		this.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.ComboBox2.FormattingEnabled = true;
		this.ComboBox2.Items.AddRange(new object[3] { "Preparar", "Despachar", "Recepcionar" });
		this.ComboBox2.Location = new System.Drawing.Point(438, 72);
		this.ComboBox2.Name = "ComboBox2";
		this.ComboBox2.Size = new System.Drawing.Size(121, 21);
		this.ComboBox2.TabIndex = 6;
		this.Comprobante.Text = "Comprobante";
		this.SubCuenta.Text = "SubCuenta";
		this.Destino.Text = "Destino";
		this.Remitos.Text = "Remitos";
		this.Bultos.Text = "Bultos";
		this.Estado.Text = "Estado";
		this.Fecha.Text = "Fecha";
		this.Observaciones.Text = "Observaciones";
		this.Comentario.Text = "Comentario";
		this.Novedad.Text = "Novedad";
		this.Usuario.Text = "Usuario";
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(1196, 576);
		base.Controls.Add(this.ComboBox2);
		base.Controls.Add(this.Label3);
		base.Controls.Add(this.TextBox1);
		base.Controls.Add(this.Label2);
		base.Controls.Add(this.ComboBox1);
		base.Controls.Add(this.Label1);
		base.Controls.Add(this.ListView1);
		base.Name = "Recepcion_form";
		this.Text = "Recepcion";
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private void Recepcion_form_Load(object sender, EventArgs e)
	{
		TextBox1.Text = "";
		TextBox1.Focus();
		cargar_chof();
	}

	private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
	{
		TextBox1.Text = "";
		TextBox1.Focus();
	}

	private void ListView1_ColumnClick(object sender, ColumnClickEventArgs e)
	{
		Mod_Ordenaclumnas.ordenar_columnas(ListView1, RuntimeHelpers.GetObjectValue(sender), e);
	}

	private void cargar_chof()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		DataTable dataTable = new DataTable("x");
		string text = "SELECT Chofer FROM Flota where Disponible='Si' and Estado='Activo' ORDER BY Chofer";
		MySqlDataAdapter val = new MySqlDataAdapter(text, Mod_Sentencias.cnn);
		DataSet dataSet = new DataSet();
		((DbDataAdapter)(object)val).Fill(dataSet, "tabla");
		ComboBox1.Items.Clear();
		DataTable dataTable2 = dataSet.Tables["tabla"];
		foreach (DataRow row in dataTable2.Rows)
		{
			ComboBox1.Items.Add(RuntimeHelpers.GetObjectValue(row["Chofer"]));
		}
	}

	private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		try
		{
			DataTable dataTable = new DataTable("x");
			string text = "SELECT Numero FROM Flota where chofer= '" + ComboBox1.Text + "'";
			MySqlDataAdapter val = new MySqlDataAdapter(text, Mod_Sentencias.cnn);
			DataSet dataSet = new DataSet();
			((DbDataAdapter)(object)val).Fill(dataTable);
			Label2.Text = dataTable.Rows[0]["Numero"].ToString();
			TextBox1.Text = "";
			TextBox1.Focus();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox(ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void Label2_TextChanged(object sender, EventArgs e)
	{
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected O, but got Unknown
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected O, but got Unknown
		checked
		{
			try
			{
				if (Operators.CompareString(Label2.Text, "numeroChofer", TextCompare: true) == 0)
				{
					return;
				}
				string commandText = ("SELECT Comprobante, Sub, Destino, Remitos, Bultos, Estado, Fecha, Observaciones, Comentario,(SELECT novedad from novedades where comprobante=.planchada.comprobante and fecha='" + fecha1 + "') as novedad, usuario  FROM Planchada WHERE fecha = '" + fecha1 + "' AND Ventana>0 AND Cliente='ETRANS' AND Chofer = " + Label2.Text) ?? "";
				Mod_Sentencias.cnn.Open();
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
				listView.View = View.Details;
				listView.GridLines = true;
				listView.FullRowSelect = true;
				listView = null;
				DataTable dataTable = dataSet.Tables["tabla"];
				int num = dataTable.Rows.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					ListViewItem listViewItem = new ListViewItem(dataTable.Rows[i][0].ToString());
					int num2 = dataTable.Columns.Count - 1;
					for (int j = 1; j <= num2; j++)
					{
						listViewItem.SubItems.Add(dataTable.Rows[i][j].ToString());
					}
					ListView1.Items.Add(listViewItem);
				}
				int num3 = ListView1.Items.Count - 1;
				for (int k = 0; k <= num3; k++)
				{
					if (Operators.CompareString(ListView1.Items[k].SubItems[9].Text, "NO ENTREGADO", TextCompare: true) == 0)
					{
						ListView1.Items[k].ForeColor = Color.Red;
					}
					if (Operators.CompareString(ListView1.Items[k].SubItems[9].Text, "NO RECOLECTADO", TextCompare: true) == 0)
					{
						ListView1.Items[k].ForeColor = Color.Red;
					}
					if (Operators.CompareString(ListView1.Items[k].SubItems[9].Text, "ENTREGADO", TextCompare: true) == 0)
					{
						ListView1.Items[k].ForeColor = Color.Green;
					}
					if (Operators.CompareString(ListView1.Items[k].SubItems[9].Text, "RECOLECTADO", TextCompare: true) == 0)
					{
						ListView1.Items[k].ForeColor = Color.Green;
					}
					if (Operators.CompareString(ListView1.Items[k].SubItems[9].Text, "EN CD", TextCompare: true) == 0)
					{
						ListView1.Items[k].ForeColor = Color.Green;
					}
					if (Operators.CompareString(ListView1.Items[k].SubItems[9].Text, "PARCIAL", TextCompare: true) == 0)
					{
						ListView1.Items[k].ForeColor = Color.Orange;
					}
				}
				dataTable = null;
				Mod_Sentencias.cnn.Close();
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
}
