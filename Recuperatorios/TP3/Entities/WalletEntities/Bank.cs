using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
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
                Random random = new Random();
                for (int j = 0; j < 30; j++)
                {
                    int type = random.Next(0, 1);
                    string category;
                    if (type == 0)
                    {
                        category = Bank.expensesCategories[random.Next(0, 5)];
                    }
                    else
                    {
                        category = Bank.incomesCategories[random.Next(0, 5)];
                    }
                    Bank.ConnectUserWithWallet(Users[i].Id, Wallets[i].Id);
                    Wallets[i].MoneyMovements.Add(new Movement(random.Next(100, 25000), Wallets[i].Id, Core.RandomDay(random), (Movement.eType)random.Next(0, 1), category));
                }
            }
        }

        /// <summary>
        /// Setea las categorías para los movimientos de dinero.
        /// </summary>
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


        /// <summary>
        /// Carga los datos del snapshot recibido por parámetro en los datos del banco.
        /// </summary>
        /// <param name="snapshot"></param>
        public static void LoadFromSnapshot(BankSnapshot snapshot)
        {
            Bank.Users = snapshot.Users;
            Bank.Wallets = snapshot.Wallets;
        }


        /// <summary>
        /// Conecta el ID del usuario recibido con el ID de la wallet recibida
        /// </summary>
        /// <param name="idUser"></param>
        /// <param name="idWallet"></param>
        /// <returns>true si OK, false si alguno de los id no es válido.</returns>
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

        /// <summary>
        /// Busca en la lista de usuarios, el índice del usuario con el id recibido por parámetro.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Indice del usuario encontrado, o -1 si no existe.</returns>
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

        /// <summary>
        /// Busca en la lista de wallets, el índice de la wallet con el id recibido por parámetro.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Indice de la wallet encontrada, o -1 si no existe.</returns>
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

        /// <summary>
        /// Busca en la lista de usuarios, el índice del usuario con el walletId recibido por parámetro.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Indice del usuario encontrado, o -1 si no existe.</returns>
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

        /// <summary>
        /// Busca la wallet del usuario con el id recibido por parámetro
        /// </summary>
        /// <param name="id"></param>
        /// <returns> Indice de la wallet encontrada, o -1 si no existe.</returns>
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

        


        /// <summary>
        /// Obtiene el total de ingresos del banco.
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Obtiene el total de gastos del banco.
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Obtiene la cantidad de movimientos del día de hoy
        /// </summary>
        /// <returns>La cantidad de movimientos el día de hoy.</returns>
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

        /// <summary>
        /// Busca el movimiento con el mayor monto.
        /// </summary>
        /// <returns>El monto</returns>
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

        /// <summary>
        /// Obtiene los usuarios con uno o más movimientos con el monto igual al mayor monto
        /// </summary>
        /// <returns>Lista con los usuarios que responden a la condición.</returns>
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

        /// <summary>
        /// Obtiene la mayor cantidad de movimientos de un usuario del banco
        /// </summary>
        /// <returns>Cantidad de movimientos del usuario con más movimientos</returns>
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

        /// <summary>
        /// Busca a los usuarios con una cantidad de movimientos igual a la mayor cantidad de movimientos.
        /// </summary>
        /// <returns>Lista con los usuarios encontrados.</returns>
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

        /// <summary>
        /// Obtiene el mayor monto de un ingreso.
        /// </summary>
        /// <returns>monto encontrado.</returns>
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
