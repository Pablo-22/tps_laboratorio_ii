using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
using Entities.DataBaseActions;
using Entities.WalletEntities;
using Entities.InputOutput;

namespace Entities.SystemCore
{
    public class InvalidUserException : Exception
    {
        public InvalidUserException() : base("Credenciales inválidas.")
        { }

        public InvalidUserException(string message) : base(message)
        {
        }

        public InvalidUserException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
