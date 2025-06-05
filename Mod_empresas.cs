using Microsoft.VisualBasic.CompilerServices;

namespace Hermes;

[StandardModule]
internal sealed class Mod_empresas
{
	public struct EmpresasStructure
	{
		public int idempresa;

		public string razonSocial;

		public string nombre;
	}

	public static object ListadoEmpresasActivas()
	{
		return true;
	}

	public static object ObtenerDatosEmpresa(int empresa)
	{
		return true;
	}

	public static object AltaEmpresa()
	{
		return true;
	}

	public static object EdicionEmpresa(int empresa)
	{
		return true;
	}

	public static object BajaEmpresa(int empresa)
	{
		return true;
	}
}
