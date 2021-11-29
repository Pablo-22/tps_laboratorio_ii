using System;
using System.IO;
using Entities.InputOutput;
using Entities.WalletEntities;
using Entities.SystemCore;
using Entities.DataBaseActions;
using System.Text.Json;

namespace ConsoleTests
{
    class Program
    {
        static void Main(string[] args)
        {
            BankSnapshot snapshot = new BankSnapshot(Bank.Users, Bank.Wallets);

            Json<BankSnapshot> snapshotIO = new Json<BankSnapshot>();
            try
            {
                snapshotIO.Import(PathsGenerator.JsonPath, snapshot.Id.ToString(), ref snapshot);
                Bank.LoadFromSnapshot(snapshot);
            }
            catch
            {
                try
                {
                    if (!File.Exists("-1.json"))
                    {
                        throw new PathDoNotExistException();
                    }
                    string dataCollected = File.ReadAllText("-1.json");
                    snapshot = JsonSerializer.Deserialize<BankSnapshot>(dataCollected);
                    Bank.LoadFromSnapshot(snapshot);
                }
                catch
                {
                    Bank.Hardcode();
                }
            }


            Core.LogIn("Pablo", "12345");

            Console.WriteLine("Usuario: " + Core.ActualUser.Name);
            Console.WriteLine("*********** Balance *********** ");
            Console.WriteLine("*********** $" + Core.UserWallet.Balance + " *********** \n");
            Console.WriteLine("*********** Movimientos *********** ");

            Core.UserWallet.MoneyMovements.ForEach(movement =>
            {
                Console.WriteLine(movement.ToString() + "\n");
            });

            Console.WriteLine("\n**** TOTAL POR CATEGORÍA **** \n");

            float monthTotal = 0;
            float previousMonthTotal = 0;
            float percentage = 0;
            bool nowIsMore;
            bool initialValueIsNull;

            Bank.ExpensesCategories.ForEach(category =>
            {
                monthTotal = Core.UserWallet.getMonthTotal(DateTime.Now, Movement.eType.Gasto, category);
                percentage = Core.UserWallet.CompareNowWithPreviousMonth(Movement.eType.Gasto, category, out nowIsMore, out initialValueIsNull);
                previousMonthTotal = Core.UserWallet.getMonthTotal(DateTime.Now.AddMonths(-1), Movement.eType.Gasto, category);
                Console.WriteLine("CATEGORÍA: " + category + " || TOTAL DEL MES: " + monthTotal + " || MES ANTERIOR: " + previousMonthTotal);
            });
        }
    }
}
