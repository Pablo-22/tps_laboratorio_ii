using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace InputOutputLibrary
{
    public class PathDoNotExistException : Exception
    {
        public PathDoNotExistException() : base("No se encontró el archivo en la ruta especificada.")
        {
        }

        public PathDoNotExistException(string message) : base(message)
        {
        }

        public PathDoNotExistException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
