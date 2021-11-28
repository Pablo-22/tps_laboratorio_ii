using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks; 

namespace Entities.InputOutput
{
    public class ExportFailureException : Exception
    {
        public ExportFailureException() : base("Fallo al importar el archivo.")
        {
        }

        public ExportFailureException(string message) : base(message)
        {
        }

        public ExportFailureException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
