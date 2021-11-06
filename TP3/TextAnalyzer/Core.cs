using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public static class Core
    {
        static private int lastId;

        public static int Id { get => lastId; }

        static Core()
        {
            Core.lastId = 0;
        }

        public static int GenerateId()
        {
            return Core.lastId++;
        }
    }
}
