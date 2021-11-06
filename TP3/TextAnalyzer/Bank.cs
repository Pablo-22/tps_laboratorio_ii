using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public static class Bank
    {
        private static List<User> users;
        private static List<Wallet> wallets;

        public static List<User> Users
        {
            get { return Users; }
            set { Users = value; }
        }

        public static List<Wallet> Wallets
        {
            get { return wallets; }
            set { wallets = value; }
        }


        static Bank()
        {
            Bank.users = new List<User>();
            Bank.wallets = new List<Wallet>();
        }
        private static void Hardcodeo()
        {
            Bank.Users.Add(new User("Pablo"));
            Bank.Users.Add(new User("Juana"));
            Bank.Users.Add(new User("Jose"));
            Bank.Users.Add(new User("Pepe"));
            Bank.Users.Add(new User("Ramiro"));
            Bank.Users.Add(new User("Luciana"));


            Bank.Wallets.Add(new Wallet());
        }
    }
}
