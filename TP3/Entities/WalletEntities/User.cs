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
    public class User : Person
    {
        private int idWallet;
        private string password;



        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public int IdWallet
        {
            get { return idWallet; }
            set { idWallet = value; }
        }

        public User() : base()
        {
            this.IdWallet = -1;
        }

        public User(string name) : base(name)
        {
            this.IdWallet = -1;
        }

        public User(string name, int idWallet) : base(name)
        {
            this.IdWallet = idWallet;
        }


        public override string ToString()
        {
            StringBuilder userInfo = new StringBuilder();
            userInfo.Append(this.Id + " - ");
            userInfo.Append(this.Name);

            return userInfo.ToString();
        }
    }
}
