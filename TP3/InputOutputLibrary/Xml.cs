using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Entities;

namespace InputOutputLibrary
{
    public class Xml<T> : IReadableWritableFile<T> where T : DataEntity
    {
        public Xml()
        {
        }

        /// <summary>
        /// Exporta en xml los datos que entran por parámetro.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public void Export(string path, T entity)
        {
            try
            {
                if (!Directory.Exists(PathsGenerator<T>.XmlPath))
                {
                    Directory.CreateDirectory(PathsGenerator<T>.TxtPath);
                }

                if (path != null)
                {
                    using (XmlTextWriter writer = new XmlTextWriter(path, Encoding.UTF8))
                    {
                        XmlSerializer xmlTextFile = new XmlSerializer(typeof(T));
                        xmlTextFile.Serialize(writer, entity);
                    }
                }
            }
            catch (Exception)
            {
                throw new Exception($"Error al exportar la entidad de ID: {entity.Id}.");
            }
        }




        /// <summary>
        /// Importa los datos en xml que encuentra en la ruta que entra por parámetro.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="entity"></param>
        /// <returns></returns>
        public void Import(string path, out T entity)
        {
            entity = default;

            try
            {
                if (Directory.Exists(PathsGenerator<T>.XmlPath) && File.Exists(path))
                {
                    using (XmlTextReader Reader = new XmlTextReader(path))
                    {
                        XmlSerializer newXml = new XmlSerializer(typeof(T));
                        entity = (T)newXml.Deserialize(Reader);
                    }
                }
                else
                {
                    throw new Exception("No existe la carpeta o el archivo.");
                }
            }
            catch (Exception)
            {
                throw new Exception($"Error al importar el archivo en: {path}.");
            }
        }
    }
}
