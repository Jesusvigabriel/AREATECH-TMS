using Hermes.My;
using Microsoft.VisualBasic.CompilerServices;

namespace Hermes;

[StandardModule]
internal sealed class Mod_logger
{
	public static object historialenter(string Comprobante, string Novedad, string Estado, string Comentario)
	{
		int num = 0;
		string sQL = "INSERT INTO Historial (Comprobante, Novedad, Estado, Comentario, Usuario) VALUES ('" + Comprobante + "', '" + Novedad + "', '" + Estado + "', '" + Comentario + "', '" + MySettingsProperty.Settings.Usuario + "')";
		num = Conversions.ToInteger(Mod_ConeccionBD.BD_Sentencia(sQL));
		return num;
	}
}
