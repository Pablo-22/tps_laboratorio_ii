using System;
using System.IO;
using Entities.InputOutput;
using Entities.WalletEntities;
using Entities.SystemCore;
using Entities.DataBaseActions;

namespace ConsoleTests
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Core.GetProjectConfig();
            }
            catch
            {
                Console.WriteLine("No se ha podido cargar exitosamente el archivo config.json con la ruta de la base de datos.");
            }
            string userName = "Pablo";
            string password = "12345";

            try
            {
                User user = DbService.GetUserByCredentials(userName, password);
                if (user.Name == userName && user.Password == password)
                {
                    Wallet wallet = DbService.GetWalletById(user.IdWallet);
                    if (wallet.Id != -1)
                    {
                        wallet.MoneyMovements = DbService.GetMovements(wallet.Id);

                        Console.WriteLine("Usuario: " + user.Name);
                        Console.WriteLine("*********** Balance *********** ");
                        Console.WriteLine("*********** $" + wallet.Balance + " *********** \n");
                        Console.WriteLine("*********** Movimientos *********** ");

                        wallet.MoneyMovements.ForEach(movement =>
                        {
                            Console.WriteLine(movement.ToString() + "\n");
                        });

                        Console.WriteLine("\n**** INFORMES **** \n");

                        float monthTotal = 0;
                        float previousMonthTotal = 0;
                        float percentage = 0;
                        bool nowIsMore;
                        bool initialValueIsNull;

                        Bank.ExpensesCategories.ForEach(category =>
                        {
                            monthTotal = wallet.getMonthTotal(DateTime.Now, Movement.eType.Gasto, category);
                            percentage = wallet.CompareNowWithPreviousMonth(Movement.eType.Gasto, category, out nowIsMore, out initialValueIsNull);
                            previousMonthTotal = wallet.getMonthTotal(DateTime.Now.AddMonths(-1), Movement.eType.Gasto, category);
                            Console.WriteLine("CATEGORÍA: " + category + " || TOTAL DEL MES: " + monthTotal + " || MES ANTERIOR: " + previousMonthTotal);
                        });
                    }
                    else
                    {
                        Console.WriteLine("El usuario no tiene una wallet válida");
                    }
                }
                else
                {
                    Console.WriteLine("Credenciales incorrectas.");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Ha habido un error al conectarse a la base de datos.");
            }
        }
    }
}
