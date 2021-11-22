using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.InputOutput
{
    public interface IReadAndWriteFile<T>
    {
        /// <summary>
        /// Exporta un archivo a la ruta deseada.
        /// Lanza una excepción si no es posible.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="entity"></param>
        public void Export(string path, T entity);

        /// <summary>
        /// Importa un archivo a la ruta deseada.
        /// Lanza una excepción si no es posible.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="entity"></param>
        public void Import(string path, ref T entity);
    }
}
