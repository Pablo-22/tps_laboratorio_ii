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
    public class BankSnapshot : DataEntity
    {
        private List<User> users;
        private List<Wallet> wallets;

        public List<User> Users
        {
            get { return users; }
            set { users = value; }
        }

        public List<Wallet> Wallets
        {
            get { return wallets; }
            set { wallets = value; }
        }


        public BankSnapshot(List<User> users, List<Wallet> wallets) :base()
        {
            this.users = users;
            this.wallets = wallets;
        }
    }
}
