using System;
using System.Collections.Generic;
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
public class Selector : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ListView1")]
	private ListView _ListView1;

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
			EventHandler value2 = ListView1_DoubleClick;
			ListView listView = _ListView1;
			if (listView != null)
			{
				listView.DoubleClick -= value2;
			}
			_ListView1 = value;
			listView = _ListView1;
			if (listView != null)
			{
				listView.DoubleClick += value2;
			}
		}
	}

	[field: AccessedThroughProperty("idvar")]
	internal virtual ColumnHeader idvar
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("producvar")]
	internal virtual ColumnHeader producvar
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

	public Selector()
	{
		base.Load += Selector_Load;
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
		this.idvar = new System.Windows.Forms.ColumnHeader();
		this.producvar = new System.Windows.Forms.ColumnHeader();
		this.descripcion = new System.Windows.Forms.ColumnHeader();
		this.unidades = new System.Windows.Forms.ColumnHeader();
		this.Label1 = new System.Windows.Forms.Label();
		this.Label2 = new System.Windows.Forms.Label();
		this.Label3 = new System.Windows.Forms.Label();
		base.SuspendLayout();
		this.ListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[4] { this.idvar, this.producvar, this.descripcion, this.unidades });
		this.ListView1.FullRowSelect = true;
		this.ListView1.GridLines = true;
		this.ListView1.Location = new System.Drawing.Point(12, 21);
		this.ListView1.Name = "ListView1";
		this.ListView1.Size = new System.Drawing.Size(431, 119);
		this.ListView1.TabIndex = 0;
		this.ListView1.UseCompatibleStateImageBehavior = false;
		this.ListView1.View = System.Windows.Forms.View.Details;
		this.idvar.Text = "ID";
		this.idvar.Width = 27;
		this.producvar.Text = "Producto";
		this.producvar.Width = 55;
		this.descripcion.Text = "Descripcion";
		this.descripcion.Width = 283;
		this.unidades.Text = "Unidades";
		this.Label1.AutoSize = true;
		this.Label1.Location = new System.Drawing.Point(410, 5);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(33, 13);
		this.Label1.TabIndex = 1;
		this.Label1.Text = "modo";
		this.Label2.AutoSize = true;
		this.Label2.Location = new System.Drawing.Point(12, 5);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(39, 13);
		this.Label2.TabIndex = 2;
		this.Label2.Text = "Label2";
		this.Label3.AutoSize = true;
		this.Label3.Location = new System.Drawing.Point(186, 5);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(39, 13);
		this.Label3.TabIndex = 3;
		this.Label3.Text = "Label3";
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(455, 152);
		base.Controls.Add(this.Label3);
		base.Controls.Add(this.Label2);
		base.Controls.Add(this.Label1);
		base.Controls.Add(this.ListView1);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "Selector";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Selector";
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private void Selector_Load(object sender, EventArgs e)
	{
		List<Mod_Productos.variaciones_producto> list = (List<Mod_Productos.variaciones_producto>)Mod_Productos.variableSelection(Conversions.ToInteger(Label2.Text));
		ListViewItem listViewItem = null;
		checked
		{
			int num = list.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				listViewItem = new ListViewItem(Conversions.ToString(list[i].variacion_id));
				listViewItem.SubItems.Add(Conversions.ToString(list[i].variacion_producto));
				listViewItem.SubItems.Add(list[i].variacion_descripcion);
				listViewItem.SubItems.Add(Conversions.ToString(list[i].variacion_unidades));
				ListView1.Items.Add(listViewItem);
			}
		}
	}

	private void ListView1_DoubleClick(object sender, EventArgs e)
	{
		checked
		{
			switch (Conversions.ToInteger(Label1.Text))
			{
			case 1:
			{
				if (ListView1.SelectedItems.Count <= 0)
				{
					break;
				}
				int index2 = ListView1.SelectedIndices[0];
				New_Orden new_Orden = MyProject.Forms.New_Orden;
				ListViewItem listViewItem4 = null;
				int num4 = Conversions.ToInteger(new_Orden.TextBox6.Text);
				int num5 = (int)Math.Round(Conversions.ToDouble(new_Orden.Label6.Text) + 1.0);
				string text = "0.00";
				ListViewItem listViewItem5 = null;
				if (new_Orden.ListView1.Items.Count > 0)
				{
					listViewItem5 = new_Orden.ListView1.FindItemWithText(ListView1.Items[index2].SubItems[2].Text, includeSubItemsInSearch: true, 0);
				}
				if (listViewItem5 != null)
				{
					int num6 = (int)Math.Round(Conversions.ToDouble(listViewItem5.Text) + (double)num4);
					int num7 = int.Parse(ListView1.Items[index2].SubItems[1].Text);
					int num8 = int.Parse(ListView1.Items[index2].Text);
					if (num6 > int.Parse(ListView1.Items[index2].SubItems[3].Text))
					{
						Interaction.MsgBox("Se exedio la cantidad solicitada.");
						Close();
						return;
					}
					listViewItem5.Remove();
					listViewItem4 = new ListViewItem(num6.ToString());
					listViewItem4.SubItems.Add(listViewItem5.SubItems[1].Text);
					listViewItem4.SubItems.Add(listViewItem5.SubItems[2].Text);
					listViewItem4.SubItems.Add(listViewItem5.SubItems[3].Text);
					listViewItem4.SubItems.Add(listViewItem5.SubItems[4].Text);
					listViewItem4.SubItems.Add(listViewItem5.SubItems[5].Text);
					new_Orden.ListView1.Items.Add(listViewItem4);
				}
				else
				{
					int num9 = int.Parse(ListView1.Items[index2].SubItems[1].Text);
					int num10 = int.Parse(ListView1.Items[index2].Text);
					if (int.Parse(Conversions.ToString(num4)) > int.Parse(ListView1.Items[index2].SubItems[3].Text))
					{
						Interaction.MsgBox("Se exedio la cantidad solicitada.");
						Close();
						return;
					}
					listViewItem4 = new ListViewItem(num4.ToString());
					listViewItem4.SubItems.Add(Label2.Text);
					listViewItem4.SubItems.Add(ListView1.Items[index2].SubItems[2].Text);
					listViewItem4.SubItems.Add(Label3.Text);
					listViewItem4.SubItems.Add(Conversions.ToString(num10));
					listViewItem4.SubItems.Add("0");
					new_Orden.ListView1.Items.Add(listViewItem4);
				}
				new_Orden.Label6.Text = Conversions.ToString(new_Orden.ListView1.Items.Count);
				int num11 = 0;
				foreach (ListViewItem item in new_Orden.ListView1.Items)
				{
					num11 += int.Parse(item.Text);
				}
				new_Orden.Label8.Text = Conversions.ToString(num11);
				new_Orden.TextBox6.Text = "0";
				new_Orden.ComboBox1.Text = "";
				new_Orden.TextBox4.Text = "";
				new_Orden = null;
				break;
			}
			case 2:
			{
				if (ListView1.SelectedItems.Count <= 0)
				{
					break;
				}
				int index3 = ListView1.SelectedIndices[0];
				ProductosOut_Form productosOut_Form = MyProject.Forms.ProductosOut_Form;
				ListViewItem listViewItem7 = null;
				int num12 = 1;
				ListViewItem listViewItem8 = null;
				if (productosOut_Form.ListView1.Items.Count > 0)
				{
					listViewItem8 = productosOut_Form.ListView1.FindItemWithText(ListView1.Items[index3].SubItems[2].Text, includeSubItemsInSearch: true, 0);
				}
				if (listViewItem8 != null)
				{
					int units = (int)Math.Round(Conversions.ToDouble(listViewItem8.Text) + 1.0);
					int idproduct = int.Parse(ListView1.Items[index3].SubItems[1].Text);
					int idvariation = int.Parse(ListView1.Items[index3].Text);
					if (Conversions.ToInteger(productosOut_Form.validateunits(idproduct, idvariation, units)) == 0)
					{
						productosOut_Form.TextBox1.Clear();
						Interaction.MsgBox("Se exedio la cantidad solicitada.");
						Close();
						return;
					}
					listViewItem8.Remove();
					listViewItem7 = new ListViewItem(units.ToString());
					listViewItem7.SubItems.Add(listViewItem8.SubItems[1].Text);
					listViewItem7.SubItems.Add(listViewItem8.SubItems[2].Text);
					listViewItem7.SubItems.Add(listViewItem8.SubItems[3].Text);
					listViewItem7.SubItems.Add(listViewItem8.SubItems[4].Text);
					productosOut_Form.ListView1.Items.Add(listViewItem7);
				}
				else
				{
					int idproduct2 = int.Parse(ListView1.Items[index3].SubItems[1].Text);
					int idvariation2 = int.Parse(ListView1.Items[index3].Text);
					if (Conversions.ToInteger(productosOut_Form.validateunits(idproduct2, idvariation2, 1)) == 0)
					{
						productosOut_Form.TextBox1.Clear();
						Interaction.MsgBox("La variacion de articulo no coincide con la solicitada.");
						Close();
						return;
					}
					listViewItem7 = new ListViewItem(num12.ToString());
					listViewItem7.SubItems.Add(Label3.Text);
					listViewItem7.SubItems.Add(ListView1.Items[index3].SubItems[2].Text);
					listViewItem7.SubItems.Add(ListView1.Items[index3].SubItems[1].Text);
					listViewItem7.SubItems.Add(ListView1.Items[index3].Text);
					productosOut_Form.ListView1.Items.Add(listViewItem7);
				}
				productosOut_Form.Label7.Text = Conversions.ToString(productosOut_Form.ListView1.Items.Count);
				int num13 = 0;
				foreach (ListViewItem item2 in productosOut_Form.ListView1.Items)
				{
					num13 += int.Parse(item2.Text);
				}
				productosOut_Form.Label6.Text = Conversions.ToString(num13);
				productosOut_Form = null;
				break;
			}
			case 3:
			{
				if (ListView1.SelectedItems.Count <= 0)
				{
					break;
				}
				int index = ListView1.SelectedIndices[0];
				ProductosIn_Form productosIn_Form = MyProject.Forms.ProductosIn_Form;
				ListViewItem listViewItem = null;
				int num = 1;
				ListViewItem listViewItem2 = null;
				if (productosIn_Form.ListView1.Items.Count > 0)
				{
					listViewItem2 = productosIn_Form.ListView1.FindItemWithText(ListView1.Items[index].SubItems[2].Text, includeSubItemsInSearch: true, 0);
				}
				if (listViewItem2 != null)
				{
					int num2 = int.Parse(listViewItem2.Text) + int.Parse(productosIn_Form.TextBox3.Text);
					listViewItem2.Remove();
					listViewItem = new ListViewItem(num2.ToString());
					listViewItem.SubItems.Add(listViewItem2.SubItems[1].Text);
					listViewItem.SubItems.Add(listViewItem2.SubItems[2].Text);
					listViewItem.SubItems.Add(listViewItem2.SubItems[3].Text);
					listViewItem.SubItems.Add(listViewItem2.SubItems[4].Text);
					productosIn_Form.ListView1.Items.Add(listViewItem);
				}
				else
				{
					listViewItem = new ListViewItem(productosIn_Form.TextBox3.Text);
					listViewItem.SubItems.Add(Label3.Text);
					listViewItem.SubItems.Add(ListView1.Items[index].SubItems[2].Text);
					listViewItem.SubItems.Add(ListView1.Items[index].SubItems[1].Text);
					listViewItem.SubItems.Add(ListView1.Items[index].Text);
					productosIn_Form.ListView1.Items.Add(listViewItem);
				}
				productosIn_Form.Label6.Text = Conversions.ToString(productosIn_Form.ListView1.Items.Count);
				int num3 = 0;
				foreach (ListViewItem item3 in productosIn_Form.ListView1.Items)
				{
					num3 += int.Parse(item3.Text);
				}
				productosIn_Form.Label8.Text = Conversions.ToString(num3);
				productosIn_Form = null;
				break;
			}
			}
			Close();
		}
	}
}
