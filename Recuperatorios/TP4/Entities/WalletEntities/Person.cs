using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
using Entities.DataBaseActions;
using Entities.SystemCore;
using Entities.InputOutput;

namespace Entities.WalletEntities
{
    public class Person : DataEntity
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        public Person(): this(null)
        {  }

        public Person(string name) : base()
        {
            this.name = name;
        }
    }
}
