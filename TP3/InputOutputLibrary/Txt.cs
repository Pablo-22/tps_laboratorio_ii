using System;
using System.IO;
using Entities;

namespace InputOutputLibrary
{
    public class Txt<T> : IReadAndWriteFile<T> where T : DataEntity
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
                    throw new PathDoNotExistException("No existe la carpeta o el archivo.");
                }

                string body = File.ReadAllText(path);

                entity.TextInfo = body;
            }
            catch (Exception error)
            {
                throw new ImportFailureException($"Error al importar el archivo en: {path}.", error);
            }
        }
    }
}
