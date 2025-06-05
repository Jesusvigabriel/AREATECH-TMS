using System;
using System.Collections.Generic;
using Microsoft.VisualBasic.CompilerServices;

namespace Hermes;

[StandardModule]
internal sealed class EmpresasMod
{
	public static void Main()
	{
		List<KeyValuePair<string, int>> list = new List<KeyValuePair<string, int>>();
		list.Add(new KeyValuePair<string, int>("dot", 1));
		list.Add(new KeyValuePair<string, int>("net", 2));
		list.Add(new KeyValuePair<string, int>("perls", 3));
		foreach (KeyValuePair<string, int> item in list)
		{
			string key = item.Key;
			int value = item.Value;
			Console.WriteLine("{0}, {1}", key, value);
		}
	}
}
