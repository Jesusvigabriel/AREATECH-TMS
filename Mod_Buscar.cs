using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Hermes.My;
using Microsoft.VisualBasic.CompilerServices;

namespace Hermes;

[StandardModule]
internal sealed class Mod_Buscar
{
	public static object buscar_item(int mode, string Tabla, string campo, string value)
	{
		checked
		{
			if (mode != 0 && mode == 1)
			{
				string sql = "SELECT * FROM " + Tabla + " where " + campo + "='" + value + "'";
				DataTable dataTable = (DataTable)Mod_Sentencias.data(sql);
				try
				{
					Explorador explorador = MyProject.Forms.Explorador;
					ListView listView = MyProject.Forms.Explorador.ListView1;
					listView.Items.Clear();
					listView.Columns.Clear();
					listView.View = View.Details;
					listView.GridLines = true;
					listView.FullRowSelect = true;
					int num = dataTable.Columns.Count - 1;
					for (int i = 0; i <= num; i++)
					{
						listView.Columns.Add(dataTable.Columns[i].Caption);
					}
					listView = null;
					DataTable dataTable2 = dataTable;
					int num2 = dataTable2.Rows.Count - 1;
					for (int j = 0; j <= num2; j++)
					{
						ListViewItem listViewItem = new ListViewItem(dataTable2.Rows[j][0].ToString());
						int num3 = dataTable2.Columns.Count - 1;
						for (int k = 1; k <= num3; k++)
						{
							listViewItem.SubItems.Add(dataTable2.Rows[j][k].ToString());
						}
						MyProject.Forms.Explorador.ListView1.Items.Add(listViewItem);
					}
					dataTable2 = null;
					int num4 = explorador.ListView1.Items.Count - 1;
					for (int l = 0; l <= num4; l++)
					{
						if (Operators.CompareString(explorador.ListView1.Items[l].SubItems[23].Text, "NO ENTREGADO", TextCompare: true) == 0)
						{
							explorador.ListView1.Items[l].ForeColor = Color.Red;
						}
						if (Operators.CompareString(explorador.ListView1.Items[l].SubItems[23].Text, "NO RECOLECTADO", TextCompare: true) == 0)
						{
							explorador.ListView1.Items[l].ForeColor = Color.Red;
						}
						if (Operators.CompareString(explorador.ListView1.Items[l].SubItems[23].Text, "ENTREGADO", TextCompare: true) == 0)
						{
							explorador.ListView1.Items[l].ForeColor = Color.Green;
						}
						if (Operators.CompareString(explorador.ListView1.Items[l].SubItems[23].Text, "RECOLECTADO", TextCompare: true) == 0)
						{
							explorador.ListView1.Items[l].ForeColor = Color.Green;
						}
						if (Operators.CompareString(explorador.ListView1.Items[l].SubItems[23].Text, "EN CD", TextCompare: true) == 0)
						{
							explorador.ListView1.Items[l].ForeColor = Color.Green;
						}
						if (Operators.CompareString(explorador.ListView1.Items[l].SubItems[23].Text, "PARCIAL", TextCompare: true) == 0)
						{
							explorador.ListView1.Items[l].ForeColor = Color.Orange;
						}
					}
					explorador.ToolStripStatusLabel2.Text = Conversions.ToString(explorador.ListView1.Items.Count);
					MyProject.Forms.Explorador.ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
					explorador = null;
					MyProject.Forms.Explorador.Show();
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ProjectData.ClearProjectError();
				}
			}
			return mode;
		}
	}
}
