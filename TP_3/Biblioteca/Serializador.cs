using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Biblioteca
{
	//ACA USO UNA CLASE GENERICA

	[XmlInclude(typeof(Pedido))]
	public static class Serializador<T>
	where T : class, new()
	{

		//GUARDAR
		public static void GuardarXml(T objeto, string path, bool agregar)
		{
            try
            {
				using (StreamWriter streamWriter = new StreamWriter(path,agregar))
				{
					XmlSerializer serializer = new XmlSerializer(typeof(T));
					serializer.Serialize(streamWriter, objeto);
				}
			}
			catch (Exception)
            {
				throw;
			}
		}
		//LEER
		public static T LeerXml(string path)
		{
            try
            {
				using (StreamReader streamReader = new StreamReader(path))
				{
					XmlSerializer serializer = new XmlSerializer(typeof(T));
					return serializer.Deserialize(streamReader) as T;
				}
			}
			catch(Exception)
            {
				throw;
			}
			
		}
		/////////////////////
		public static void GuardarJson(T objeto, string path, bool agregar)
        {

			try
			{
				JsonSerializerOptions opcion = new JsonSerializerOptions();
				opcion.WriteIndented = true;
				string json = JsonSerializer.Serialize(objeto,opcion);
				GestorArchivo.GuardarArchivo(path,json, true);
			}
			catch (Exception)
			{
				throw;
			}

		}

		public static T LeerJson(string path)
		{
			try
			{
				string json = GestorArchivo.LeerArchivo(path);
				return JsonSerializer.Deserialize<T>(json);
			}
			catch (Exception)
			{
				throw;
			}
		}


	}
}

