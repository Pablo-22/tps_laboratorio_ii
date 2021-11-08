using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Entities;

namespace InputOutputLibrary
{
    public class Json<T> : IReadAndWriteFile<T> where T : DataEntity
    {
        public Json()
        { }

        public void Export(string path, T entity)
        {
            try
            {
                if (!Directory.Exists(PathsGenerator<T>.JsonPath))
                {
                    Directory.CreateDirectory(PathsGenerator<T>.JsonPath);
                }

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
                throw new Exception($"Error al exportar la entidad de ID: {entity.Id}.");
            }
        }

        public void Import(string path, out T entity)
        {
            entity = default;

            try
            {
                if (Directory.Exists(PathsGenerator<T>.JsonPath) && File.Exists(path))
                {
                    string dataCollected = File.ReadAllText(path);
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
