using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
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


        public BankSnapshot(List<User> users, List<Wallet> wallets)
        {
            this.users = users;
            this.wallets = wallets;
            this.Id = -1;
        }
    }
}
