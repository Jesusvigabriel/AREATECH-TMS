using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Hermes.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Hermes;

[DesignerGenerated]
public class VerTabla : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	[field: AccessedThroughProperty("Button1")]
	internal virtual Button Button1
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

	[field: AccessedThroughProperty("Button3")]
	internal virtual Button Button3
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

	public VerTabla()
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
		this.Button2 = new System.Windows.Forms.Button();
		this.Button3 = new System.Windows.Forms.Button();
		this.ListView1 = new System.Windows.Forms.ListView();
		base.SuspendLayout();
		this.Button1.Location = new System.Drawing.Point(24, 17);
		this.Button1.Name = "Button1";
		this.Button1.Size = new System.Drawing.Size(75, 23);
		this.Button1.TabIndex = 0;
		this.Button1.Text = "Button1";
		this.Button1.UseVisualStyleBackColor = true;
		this.Button2.Location = new System.Drawing.Point(123, 18);
		this.Button2.Name = "Button2";
		this.Button2.Size = new System.Drawing.Size(75, 23);
		this.Button2.TabIndex = 1;
		this.Button2.Text = "Button2";
		this.Button2.UseVisualStyleBackColor = true;
		this.Button3.Location = new System.Drawing.Point(221, 19);
		this.Button3.Name = "Button3";
		this.Button3.Size = new System.Drawing.Size(75, 23);
		this.Button3.TabIndex = 2;
		this.Button3.Text = "Button3";
		this.Button3.UseVisualStyleBackColor = true;
		this.ListView1.Location = new System.Drawing.Point(20, 66);
		this.ListView1.Name = "ListView1";
		this.ListView1.Size = new System.Drawing.Size(830, 419);
		this.ListView1.TabIndex = 3;
		this.ListView1.UseCompatibleStateImageBehavior = false;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(875, 497);
		base.Controls.Add(this.ListView1);
		base.Controls.Add(this.Button3);
		base.Controls.Add(this.Button2);
		base.Controls.Add(this.Button1);
		base.Name = "VerTabla";
		this.Text = "VerTabla";
		base.ResumeLayout(false);
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		checked
		{
			try
			{
				MyProject.Forms.Form1_Inicio.DateTimePicker1.Format = DateTimePickerFormat.Short;
				DateTime dateTime = Conversions.ToDate(MyProject.Forms.Form1_Inicio.DateTimePicker1.Text);
				OleDbConnection oleDbConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source='Temp.xls'; Extended Properties=Excel 8.0;");
				OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("select * from [Planchada$]", oleDbConnection);
				oleDbDataAdapter.TableMappings.Add("Table", "Test");
				DataSet dataSet = new DataSet();
				oleDbDataAdapter.Fill(dataSet);
				oleDbConnection.Close();
				try
				{
					ListView listView = ListView1;
					listView.Items.Clear();
					listView.View = View.Details;
					listView.GridLines = true;
					listView.FullRowSelect = true;
					listView.MultiSelect = false;
					listView.LabelEdit = false;
					listView.HideSelection = false;
					int num = dataSet.Tables[0].Columns.Count - 1;
					for (int i = 0; i <= num; i++)
					{
						listView.Columns.Add(dataSet.Tables[0].Columns[i].Caption);
					}
					listView = null;
					DataTable dataTable = dataSet.Tables[0];
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
						if (j == 0)
						{
						}
					}
					dataTable = null;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					Mod_Sentencias.cnn.Close();
					Interaction.MsgBox("Error llenando lv " + ex2.Message);
					ProjectData.ClearProjectError();
				}
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				Mod_Sentencias.cnn.Close();
				Interaction.MsgBox("Error " + ex4.Message);
				ProjectData.ClearProjectError();
			}
		}
	}
}
