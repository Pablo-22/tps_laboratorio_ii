using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InputOutputLibrary;

namespace Entities
{
    public static class Core
    {

        static Core()
        { }

        public static int GenerateId()
        {
            int biggestId = Core.GetBiggestId();
            return biggestId++;
        }

        public static int GetBiggestId()
        {
            int biggestId = -1;

            foreach (var user in Bank.Users)
            {
                if (user.Id > biggestId)
                {
                    biggestId = user.Id;
                }
            }

            foreach (var wallet in Bank.Wallets)
            {
                if (wallet.Id > biggestId)
                {
                    biggestId = wallet.Id;
                }

                foreach (var movement in wallet.MoneyMovements)
                {
                    if (movement.Id > biggestId)
                    {
                        biggestId = movement.Id;
                    }
                }
            }

            return biggestId;
        }
    }
}
