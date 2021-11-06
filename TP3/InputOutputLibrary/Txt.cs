using System;
using System.IO;
using Entities;

namespace InputOutputLibrary
{
    public class Txt<T> : IReadableWritableFile<T> where T : DataEntity
    {
        public void Export(string path, T entity)
        {
            try
            {
                if (!Directory.Exists(PathsGenerator<T>.TxtPath))
                {
                    Directory.CreateDirectory(PathsGenerator<T>.TxtPath);
                }

                File.WriteAllText(path, entity.TextInfo);
            }
            catch
            {
                throw new Exception($"Error al exportar a texto la entidad de ID: {entity.Id}.");
            }
        }

        public void Import(string path, out T entity)
        {
            entity = default;
            try
            {
                if (!Directory.Exists(PathsGenerator<T>.TxtPath) || !File.Exists(path))
                {
                    throw new Exception("No existe la carpeta o el archivo.");
                }

                string body = File.ReadAllText(path);

                entity.TextInfo = body;
            }
            catch
            {
                throw new Exception($"Error al importar el archivo de texto en : {path}.");
            }
        }
    }
}
