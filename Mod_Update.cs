using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Xml;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Hermes;

[StandardModule]
internal sealed class Mod_Update
{
	public static void UpdateHermes()
	{
		try
		{
			string text = Strings.Format(DateAndTime.Today, "dd/MM/yyyy");
			string url = "http://api-interna.area54sa.com.ar/Hermes/version/version.xml";
			XmlTextReader xmlTextReader = new XmlTextReader(url);
			string empty = string.Empty;
			while (xmlTextReader.Read())
			{
				if (Operators.CompareString(xmlTextReader.Name, "Version", TextCompare: true) != 0)
				{
					continue;
				}
				int num = xmlTextReader.ReadElementContentAsInt();
				if (num > Mod_Sentencias.versionActual)
				{
					DialogResult dialogResult = MessageBox.Show("Existe una nueva version, desea actualizar?", "Hermes Update", MessageBoxButtons.YesNo);
					if (dialogResult == DialogResult.Yes)
					{
						Process process = new Process();
						string fileName = AppDomain.CurrentDomain.BaseDirectory + "HermesUpdate.exe";
						Process.Start(fileName);
					}
				}
			}
			xmlTextReader.Close();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Logger.i("Error: " + ex2.Message);
			ProjectData.ClearProjectError();
		}
	}
}
