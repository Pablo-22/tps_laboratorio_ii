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
            get { return users; }
            set { users = value; }
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

            //Hardcode();
        }
        public static void Hardcode()
        {
            Bank.Users.Add(new User("Pablo"));
            Bank.Users.Add(new User("Juana"));
            Bank.Users.Add(new User("Jose"));
            Bank.Users.Add(new User("Pepe"));
            Bank.Users.Add(new User("Ramiro"));
            Bank.Users.Add(new User("Luciana"));


            Bank.Wallets.Add(new Wallet(45800));
            Bank.Wallets.Add(new Wallet(32430));
            Bank.Wallets.Add(new Wallet(27842));
            Bank.Wallets.Add(new Wallet(12354));
            Bank.Wallets.Add(new Wallet(23450));
            Bank.Wallets.Add(new Wallet(22000));

            for (int i = 0; i < Bank.Users.Count; i++)
            {
                Bank.ConnectUserWithWallet(Users[i].Id, Wallets[i].Id);
            }
        }


        public static void LoadFromSnapshot(BankSnapshot snapshot)
        {
            Bank.Users = snapshot.Users;
            Bank.Wallets = snapshot.Wallets;
        }


        public static bool ConnectUserWithWallet(int idUser, int idWallet)
        {
            int userIndex = SearchUserIndexById(idUser);
            int walletIndex = SearchWalletIndexById(idWallet);
            if (userIndex > -1 && walletIndex > -1)
            {
                Bank.Users[userIndex].IdWallet = idWallet;
                return true;
            }
            return false;
        }


        public static int SearchUserIndexById(int id)
        {
            int userIndex = -1;
            for (int i = 0; i < Bank.Users.Count; i++)
            {
                if (Bank.Users[i].Id == id)
                {
                    userIndex = i;
                    break;
                }
            }
            return userIndex;
        }
        public static int SearchWalletIndexById(int id)
        {
            int walletIndex = -1;
            for (int i = 0; i < Bank.Wallets.Count; i++)
            {
                if (Bank.Wallets[i].Id == id)
                {
                    walletIndex = i;
                    break;
                }
            }
            return walletIndex;
        }

        public static int SearchWalletIndexByUserId(int id)
        {
            int userIndex = Bank.SearchUserIndexById(id);
            int walletIndex = Bank.SearchWalletIndexById(Bank.Users[userIndex].IdWallet);

            return walletIndex;
        }
        



        public static void getUserWithBiggestMovement(Movement.eType type)
        {

        }


    }
}
