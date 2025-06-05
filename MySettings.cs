using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;

namespace Hermes.My;

[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0")]
[EditorBrowsable(EditorBrowsableState.Advanced)]
internal sealed class MySettings : ApplicationSettingsBase
{
	private static MySettings defaultInstance = (MySettings)SettingsBase.Synchronized(new MySettings());

	private static bool addedHandler;

	private static object addedHandlerLockObject = RuntimeHelpers.GetObjectValue(new object());

	public static MySettings Default
	{
		get
		{
			if (!addedHandler)
			{
				object obj = addedHandlerLockObject;
				ObjectFlowControl.CheckForSyncLockOnValueType(obj);
				bool lockTaken = false;
				try
				{
					Monitor.Enter(obj, ref lockTaken);
					if (!addedHandler)
					{
						MyProject.Application.Shutdown += [DebuggerNonUserCode] [EditorBrowsable(EditorBrowsableState.Advanced)] (object sender, EventArgs e) =>
						{
							if (MyProject.Application.SaveMySettingsOnExit)
							{
								MySettingsProperty.Settings.Save();
							}
						};
						addedHandler = true;
					}
				}
				finally
				{
					if (lockTaken)
					{
						Monitor.Exit(obj);
					}
				}
			}
			return defaultInstance;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Admin")]
	public string Usuario
	{
		get
		{
			return Conversions.ToString(this["Usuario"]);
		}
		set
		{
			this["Usuario"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("root")]
	public string Password
	{
		get
		{
			return Conversions.ToString(this["Password"]);
		}
		set
		{
			this["Password"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("10")]
	public string Permiso
	{
		get
		{
			return Conversions.ToString(this["Permiso"]);
		}
		set
		{
			this["Permiso"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Admin")]
	public string Admin
	{
		get
		{
			return Conversions.ToString(this["Admin"]);
		}
		set
		{
			this["Admin"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("99")]
	public string ninguna
	{
		get
		{
			return Conversions.ToString(this["ninguna"]);
		}
		set
		{
			this["ninguna"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("99")]
	public string Baja
	{
		get
		{
			return Conversions.ToString(this["Baja"]);
		}
		set
		{
			this["Baja"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("55")]
	public string Razonable
	{
		get
		{
			return Conversions.ToString(this["Razonable"]);
		}
		set
		{
			this["Razonable"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("45")]
	public string Buena
	{
		get
		{
			return Conversions.ToString(this["Buena"]);
		}
		set
		{
			this["Buena"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("35")]
	public string MBuena
	{
		get
		{
			return Conversions.ToString(this["MBuena"]);
		}
		set
		{
			this["MBuena"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("25")]
	public string Excelente
	{
		get
		{
			return Conversions.ToString(this["Excelente"]);
		}
		set
		{
			this["Excelente"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("300000")]
	public string custodia
	{
		get
		{
			return Conversions.ToString(this["custodia"]);
		}
		set
		{
			this["custodia"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string sql
	{
		get
		{
			return Conversions.ToString(this["sql"]);
		}
		set
		{
			this["sql"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string columnsorden
	{
		get
		{
			return Conversions.ToString(this["columnsorden"]);
		}
		set
		{
			this["columnsorden"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Eventual")]
	public string Eventual
	{
		get
		{
			return Conversions.ToString(this["Eventual"]);
		}
		set
		{
			this["Eventual"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Comprobante")]
	public string Comprobante
	{
		get
		{
			return Conversions.ToString(this["Comprobante"]);
		}
		set
		{
			this["Comprobante"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Cliente")]
	public string Cliente
	{
		get
		{
			return Conversions.ToString(this["Cliente"]);
		}
		set
		{
			this["Cliente"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Remitos")]
	public string Remitos
	{
		get
		{
			return Conversions.ToString(this["Remitos"]);
		}
		set
		{
			this["Remitos"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Destino")]
	public string Destino
	{
		get
		{
			return Conversions.ToString(this["Destino"]);
		}
		set
		{
			this["Destino"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Domicilio")]
	public string Domicilio
	{
		get
		{
			return Conversions.ToString(this["Domicilio"]);
		}
		set
		{
			this["Domicilio"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string CP
	{
		get
		{
			return Conversions.ToString(this["CP"]);
		}
		set
		{
			this["CP"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string Localidad
	{
		get
		{
			return Conversions.ToString(this["Localidad"]);
		}
		set
		{
			this["Localidad"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string Declarado
	{
		get
		{
			return Conversions.ToString(this["Declarado"]);
		}
		set
		{
			this["Declarado"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string Bultos
	{
		get
		{
			return Conversions.ToString(this["Bultos"]);
		}
		set
		{
			this["Bultos"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string Kilos
	{
		get
		{
			return Conversions.ToString(this["Kilos"]);
		}
		set
		{
			this["Kilos"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string Subc
	{
		get
		{
			return Conversions.ToString(this["Subc"]);
		}
		set
		{
			this["Subc"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string Observaciones
	{
		get
		{
			return Conversions.ToString(this["Observaciones"]);
		}
		set
		{
			this["Observaciones"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string Volumen
	{
		get
		{
			return Conversions.ToString(this["Volumen"]);
		}
		set
		{
			this["Volumen"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string Atraso
	{
		get
		{
			return Conversions.ToString(this["Atraso"]);
		}
		set
		{
			this["Atraso"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string Diferida
	{
		get
		{
			return Conversions.ToString(this["Diferida"]);
		}
		set
		{
			this["Diferida"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string Flete
	{
		get
		{
			return Conversions.ToString(this["Flete"]);
		}
		set
		{
			this["Flete"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("ftp://ftp.officecore.com/Area54Tasks_.xlsx")]
	public string ftpupurl
	{
		get
		{
			return Conversions.ToString(this["ftpupurl"]);
		}
		set
		{
			this["ftpupurl"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("OfficeTrackImportFiles")]
	public string ftpupusuario
	{
		get
		{
			return Conversions.ToString(this["ftpupusuario"]);
		}
		set
		{
			this["ftpupusuario"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("odefrkOF3SMA89Ssdfd")]
	public string ftpuppass
	{
		get
		{
			return Conversions.ToString(this["ftpuppass"]);
		}
		set
		{
			this["ftpuppass"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string ftpuplink
	{
		get
		{
			return Conversions.ToString(this["ftpuplink"]);
		}
		set
		{
			this["ftpuplink"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1")]
	public int version
	{
		get
		{
			return Conversions.ToInteger(this["version"]);
		}
		set
		{
			this["version"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("ftp://zeozonetest.host22.com")]
	public string ftpupdateURL
	{
		get
		{
			return Conversions.ToString(this["ftpupdateURL"]);
		}
		set
		{
			this["ftpupdateURL"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("a1642402")]
	public string ftpupdateUSER
	{
		get
		{
			return Conversions.ToString(this["ftpupdateUSER"]);
		}
		set
		{
			this["ftpupdateUSER"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("FM40768959")]
	public string ftpupdatePASS
	{
		get
		{
			return Conversions.ToString(this["ftpupdatePASS"]);
		}
		set
		{
			this["ftpupdatePASS"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int pHvalor
	{
		get
		{
			return Conversions.ToInteger(this["pHvalor"]);
		}
		set
		{
			this["pHvalor"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int pVvalor
	{
		get
		{
			return Conversions.ToInteger(this["pVvalor"]);
		}
		set
		{
			this["pVvalor"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string Sqlinforme
	{
		get
		{
			return Conversions.ToString(this["Sqlinforme"]);
		}
		set
		{
			this["Sqlinforme"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("100000")]
	public string MontoInf
	{
		get
		{
			return Conversions.ToString(this["MontoInf"]);
		}
		set
		{
			this["MontoInf"] = value;
		}
	}

	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	private static void AutoSaveSettings(object sender, EventArgs e)
	{
		if (MyProject.Application.SaveMySettingsOnExit)
		{
			MySettingsProperty.Settings.Save();
		}
	}
}
