using System;
using System.IO;
using Entities.WalletEntities;

namespace Entities.InputOutput
{
    public class Txt<T> : IReadAndWriteFile<T> where T : DataEntity
    {
        public void Export(string path, T entity)
        {
            try
            {
                if (!Directory.Exists(PathsGenerator.TxtPath))
                {
                    Directory.CreateDirectory(PathsGenerator.TxtPath);
                }

                File.WriteAllText(path, entity.TextInfo);
            }
            catch
            {
                throw new Exception($"Error al exportar a texto la entidad de ID: {entity.Id}.");
            }
        }

        public void Import(string path, ref T entity)
        {
            try
            {
                if (!Directory.Exists(PathsGenerator.TxtPath) || !File.Exists(path))
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
