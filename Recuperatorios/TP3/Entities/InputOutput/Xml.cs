using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
using System.Xml;
using System.Xml.Serialization;
using Entities.WalletEntities;

namespace Entities.InputOutput
{
    public class Xml<T> : IReadAndWriteFile<T> where T : DataEntity
    {
        public Xml()
        {
        }

        public void Export(string path, T entity)
        {
            try
            {
                if (!Directory.Exists(PathsGenerator.XmlPath))
                {
                    Directory.CreateDirectory(PathsGenerator.XmlPath);
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

        public void Import(string path, ref T entity)
        {
            try
            {
                if (Directory.Exists(PathsGenerator.XmlPath) && File.Exists(path))
                {
                    using (XmlTextReader Reader = new XmlTextReader(path))
                    {
                        XmlSerializer newXml = new XmlSerializer(typeof(T));
                        entity = (T)newXml.Deserialize(Reader);
                    }
                }
                else
                {
                    throw new PathDoNotExistException("No existe la carpeta o el archivo.");
                }
            }
            catch (Exception error)
            {
                throw new ImportFailureException($"Error al importar el archivo en: {path}.", error);
            }
        }
    }
}
