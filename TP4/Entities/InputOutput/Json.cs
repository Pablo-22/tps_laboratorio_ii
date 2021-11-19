using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks; 
using Entities.DataBaseActions;
using System.Xml;
using System.Xml.Serialization;
using Entities.WalletEntities;

namespace Entities.InputOutput
{
    public class Json<T>
    {
        public Json()
        { }

        public void Export(string path, string fileName, T entity)
        {
            try
            {
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                Path.Combine(path + fileName);

                if (path != null)
                {
                    JsonSerializerOptions options = new JsonSerializerOptions();
                    options.WriteIndented = true;
                    string serializedEntity = JsonSerializer.Serialize<T>(entity, options);
                    File.WriteAllText(path, serializedEntity);
                }
            }
            catch
            {
                throw new Exception($"Error al exportar la entidad.");
            }
        }

        public void Import(string path, string fileName, ref T entity)
        {
            try
            {
                if (File.Exists(Path.Combine(path + fileName)) )
                {
                    string dataCollected = File.ReadAllText(Path.Combine(path + fileName));
                    if (!string.IsNullOrEmpty(dataCollected))
                    {
                        entity = JsonSerializer.Deserialize<T>(dataCollected);
                    }
                    else
                    {
                        throw new ImportFailureException();
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
