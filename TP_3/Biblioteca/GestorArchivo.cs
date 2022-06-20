using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
	public class GestorArchivo
	{
		public static void GuardarArchivo(string path, string contenido, bool agregar)
		{
			try
			{
				using (StreamWriter streamWriter = new StreamWriter(path, agregar))
				{
					streamWriter.WriteLine(contenido);
				}
			}
			catch (Exception)
			{
				throw;
			}
		}
		public static string LeerArchivo(string path)
		{
			try
			{
				using (StreamReader streamReader = new StreamReader(path))
				{
					return streamReader.ReadToEnd();
				}
			}
			catch (Exception)
			{
				throw;
			}
		}
	}
}
