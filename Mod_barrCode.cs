using System;
using System.Drawing;
using System.Drawing.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace Hermes;

[StandardModule]
internal sealed class Mod_barrCode
{
	public static object CargarFuente()
	{
		PrivateFontCollection privateFontCollection = new PrivateFontCollection();
		privateFontCollection.AddFontFile(AppDomain.CurrentDomain.BaseDirectory + "\\Code39.ttf");
		FontFamily family = privateFontCollection.Families[0];
		return new Font(family, 20f);
	}
}
