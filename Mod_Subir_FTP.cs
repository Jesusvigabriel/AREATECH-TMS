using System;
using System.Diagnostics;
using Hermes.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Hermes;

[StandardModule]
internal sealed class Mod_Subir_FTP
{
	public static object subir_ftp()
	{
		object result;
		try
		{
			string ftpupurl = MySettingsProperty.Settings.ftpupurl;
			string ftpupusuario = MySettingsProperty.Settings.ftpupusuario;
			string ftpuppass = MySettingsProperty.Settings.ftpuppass;
			string ftpuplink = MySettingsProperty.Settings.ftpuplink;
			MyProject.Computer.Network.UploadFile(ftpuplink, ftpupurl, ftpupusuario, ftpuppass, showUI: true, 500);
			result = 1;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objExcepcion = ex;
			Logger.e("Error con excepción y traza", objExcepcion, new StackFrame(fNeedFileInfo: true));
			result = 2;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static void crear_xlsx_ftp(int numero)
	{
		string text = Strings.Format(MyProject.Forms.Form1_Inicio.DateTimePicker1.Value, "yyyyMMdd");
		string text2 = MyProject.Forms.Form1_Inicio.ComboBox1.Text;
		string destino = "Exportacion";
		string text3 = "";
		checked
		{
			if (numero > 0)
			{
				string text4 = ("Select Eventual, Comprobante, cliente, remitos, destino, domicilio, cp, localidad, declarado, bultos, kilos, sub, observaciones, volumen, atraso, fecha, flete, zona, adicional, prioridad, chofer, latitud, longitud FROM planchada where fecha='" + text + "' AND Chofer=" + text3 + " AND Ventana=" + text2) ?? "";
				int num = numero - 1;
				for (int i = 0; i <= num; i++)
				{
					string text5 = ("UNION ALL Select Eventual, Comprobante, cliente, remitos, destino, domicilio, cp, localidad, declarado, bultos, kilos, sub, observaciones, volumen, atraso, fecha, flete, zona, adicional, prioridad, chofer, latitud, longitud FROM planchada where fecha='" + text + "' AND Chofer=1075 AND Ventana=" + text2) ?? "";
					text4 = text4 + " " + text5;
				}
				Mod_Exportar.exportar_excel(text4, destino);
			}
		}
	}
}
