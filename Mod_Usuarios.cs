using Microsoft.VisualBasic.CompilerServices;

namespace Hermes;

[StandardModule]
internal sealed class Mod_Usuarios
{
	public static object nuevo_usuario(string usuario, string pass, int permiso)
	{
		string sQL = "INSERT INTO Usuarios(Usuario,Password,Permiso) Values('" + usuario + "','" + pass + "'," + Conversions.ToString(permiso) + ")";
		return Conversions.ToString(Mod_ConeccionBD.BD_Sentencia(sQL));
	}

	public static object editar_usuario(int id_usuario, string usuario, string pass, int permiso)
	{
		string sQL = ("UPDATE Usuarios SET usuario='" + usuario + "', password='" + pass + "', permiso=" + Conversions.ToString(permiso) + " WHERE id=" + Conversions.ToString(id_usuario)) ?? "";
		return Conversions.ToString(Mod_ConeccionBD.BD_Sentencia(sQL));
	}

	public static object borrar_usuario(int id_usuario)
	{
		string sQL = ("DELETE FROM Usuarios WHERE id=" + Conversions.ToString(id_usuario)) ?? "";
		return Conversions.ToString(Mod_ConeccionBD.BD_Sentencia(sQL));
	}
}
