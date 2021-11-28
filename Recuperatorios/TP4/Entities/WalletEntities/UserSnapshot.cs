using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.WalletEntities
{
    public class UserSnapshot
    {
        private string name;
        private Wallet wallet;

        public UserSnapshot(string name, Wallet wallet)
        {
            this.name = name;
            this.wallet = wallet;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Wallet UserWallet
        {
            get { return wallet; }
            set { wallet = value; }
        }
    }
}
