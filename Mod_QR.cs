using System.Drawing;
using Microsoft.VisualBasic.CompilerServices;
using ThoughtWorks.QRCode.Codec;

namespace Hermes;

[StandardModule]
internal sealed class Mod_QR
{
	public static object qrcodegen(string codigo)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		QRCodeEncoder val = new QRCodeEncoder();
		val.QRCodeEncodeMode = (ENCODE_MODE)2;
		val.QRCodeScale = 4;
		val.QRCodeVersion = 1;
		val.QRCodeErrorCorrect = (ERROR_CORRECTION)1;
		Image original = val.Encode(codigo);
		return new Bitmap(original);
	}
}
