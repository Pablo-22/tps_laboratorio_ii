using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace InputOutputLibrary
{
    public class ImportFailureException : Exception
    {
        public ImportFailureException() : base("Fallo al importar el archivo.")
        {
        }

        public ImportFailureException(string message) : base(message)
        {
        }

        public ImportFailureException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
