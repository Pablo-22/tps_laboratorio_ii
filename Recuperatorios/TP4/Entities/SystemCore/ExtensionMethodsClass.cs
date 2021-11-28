using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.DataBaseActions;
using Entities.WalletEntities;
using Entities.InputOutput;
using System.Data.SqlClient;

namespace Entities.SystemCore
{
    public static class ExtensionMethodsClass
    {
        /// <summary>
        /// Se extendió la clase DataEntity con un método que recibe 
        /// una cadena de caracteres, y un delegado que funcionará como 
        /// data accesor para acceder a campos de la entidad. El método 
        /// busca la cadena en la propiedad de la entidad y devuelve un 
        /// valor booleano que representa si la encuentra o no.
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="searchString"></param>
        /// <param name="dataAccesor"></param>
        /// <returns></returns>
        public static bool SearchStringOnEntity(this DataEntity entity, string searchString, Func<DataEntity, string> dataAccesor)
        {
            if (dataAccesor(entity).Contains(searchString))
            {
                return true;
            }
            return false;
        }
    }
}
