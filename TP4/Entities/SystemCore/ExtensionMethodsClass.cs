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
