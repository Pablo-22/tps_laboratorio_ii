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
    public static class Bank
    {
        private static List<User> users;
        private static List<Wallet> wallets;
        private static List<string> expensesCategories;
        private static List<string> incomesCategories;

        public static List<string> ExpensesCategories
        {
            get { return expensesCategories; }
            set { expensesCategories = value; }
        }

        public static List<string> IncomesCategories
        {
            get { return incomesCategories; }
            set { incomesCategories = value; }
        }



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
            Bank.incomesCategories = new List<string>();
            Bank.expensesCategories = new List<string>();
            setCategories();
        }

        /// <summary>
        /// Hardcodeo. Para el caso que sea necesario.
        /// </summary>
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

        private static void setCategories()
        {
            Bank.ExpensesCategories.Add("Varios");
            Bank.ExpensesCategories.Add("Indumentaria");
            Bank.ExpensesCategories.Add("Alimentos");
            Bank.ExpensesCategories.Add("Servicios");
            Bank.ExpensesCategories.Add("Entretenimiento");
            Bank.ExpensesCategories.Add("Viajes");


            Bank.IncomesCategories.Add("Varios");
            Bank.IncomesCategories.Add("Trabajo");
            Bank.IncomesCategories.Add("Préstamo");
            Bank.IncomesCategories.Add("Devolución");
            Bank.IncomesCategories.Add("Negocios");
            Bank.IncomesCategories.Add("Venta");
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

        public static int SearchUserIndexByWalletId(int id)
        {
            int userIndex = -1;
            for (int i = 0; i < Bank.Users.Count; i++)
            {
                if (Bank.Users[i].IdWallet == id)
                {
                    userIndex = i;
                }
            }
            return userIndex;
        }

        public static int SearchWalletIndexByUserId(int id)
        {
            Console.WriteLine(Bank.Users);
            Console.WriteLine(Bank.Wallets);
            int walletIndex = -1;
            int userIndex = Bank.SearchUserIndexById(id);
            if (userIndex > -1)
            {
                walletIndex = Bank.SearchWalletIndexById(Bank.Users[userIndex].IdWallet);
            }

            return walletIndex;
        }

        



        public static float GetTotalIncomesAmount()
        {
            float totalAmount = 0;

            Core.UserWallet.MoneyMovements.ForEach(movement =>
            {
                if (movement.Type == Movement.eType.Ingreso)
                {
                    totalAmount += movement.Amount;
                }
            });

            return totalAmount;
        }

        public static float GetTotalExpensesAmount()
        {
            float totalAmount = 0;

            Core.UserWallet.MoneyMovements.ForEach(movement =>
            {
                if (movement.Type == Movement.eType.Gasto)
                {
                    totalAmount += movement.Amount;
                }
            });

            return totalAmount;
        }

        public static int GetTodayMovements()
        {
            int movementsCount = 0;

            Bank.Wallets.ForEach(wallet =>
            {
                var movements = wallet.MoneyMovements.FindAll(x => { return x.PurchaseDate.Date == DateTime.Now.Date; });
                movementsCount += movements.Count;
            });
            return movementsCount;
        }

        public static float GetBiggestMovementAmount()
        {
            float biggestMovement = 0;

            Bank.Wallets.ForEach(wallet =>
            {
                wallet.MoneyMovements.ForEach(movement =>
                {
                    if (movement.Amount > biggestMovement)
                    {
                        biggestMovement = movement.Amount;
                    }
                });
            });
            return biggestMovement;
        }

        public static List<User> GetUsersWithBiggestMovementAmount()
        {
            List<User> usersWithbiggestMovements = new List<User>();
            float biggestAmount = GetBiggestMovementAmount();

            Bank.Wallets.ForEach(wallet =>
            {
                wallet.MoneyMovements.ForEach(movement =>
                {
                    if (movement.Amount == biggestAmount)
                    {
                        usersWithbiggestMovements.Add(Bank.Users[SearchUserIndexByWalletId(movement.IdWallet)]);
                    }
                });
            });
            return usersWithbiggestMovements;
        }

        public static int GetLargestAmountOfMovements()
        {
            int largestAmountOfMovements = 0;
            Bank.Wallets.ForEach(wallet =>
            {
                if (wallet.MoneyMovements.Count > largestAmountOfMovements)
                {
                    largestAmountOfMovements = wallet.MoneyMovements.Count;
                }
            });
            return largestAmountOfMovements;
        }

        public static List<User> GetUsersWithMoreMovements()
        {
            List<User> usersWithMoreMovements = new List<User>();
            float largestAmountOfMovements = GetLargestAmountOfMovements();

            Bank.Wallets.ForEach(wallet =>
            {
                if (wallet.MoneyMovements.Count == largestAmountOfMovements)
                {
                    usersWithMoreMovements.Add(Bank.Users[SearchUserIndexByWalletId(wallet.Id)]);
                }
            });
            return usersWithMoreMovements;
        }

        public static float getBiggestIncomeAmount()
        {
            float biggestIncome = 0;
            Bank.Wallets.ForEach(wallet =>
            {
                wallet.MoneyMovements.ForEach(movement =>
                {
                    if (movement.Amount > biggestIncome)
                    {
                        biggestIncome = movement.Amount;
                    }
                });
            });
            return biggestIncome;
        }
    }
}
