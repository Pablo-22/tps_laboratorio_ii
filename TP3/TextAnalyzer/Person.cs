using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Person : DataEntity
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }



        public Person()
        {
            name = null;
        }

        public Person(string name) : this()
        {
            this.name = name;
        }
    }
}
