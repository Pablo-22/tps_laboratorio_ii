using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
using Entities.WalletEntities;
using Entities.InputOutput;
using System.Data.SqlClient;

namespace Entities.SystemCore
{
    public class ProjectConfigurationData
    {
        private string connectionString;

        public string ConnectionString { get { return this.connectionString; }  set { this.connectionString = value; } }

        public ProjectConfigurationData(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public ProjectConfigurationData(): this(null)
        {  }
    }
}
