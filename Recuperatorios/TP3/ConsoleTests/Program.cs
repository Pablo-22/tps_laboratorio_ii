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
            /*
            TextFile test = new TextFile("mi nombre es Pablo");
            Txt file = new Txt();

            file.Export(test);
            */

            //User test = new User();

            //file.Import(@"textFiles\0.txt",out test);

            //Xml<User> xmlFile = new Xml<User>();

            //xmlFile.Export(test);

            //xmlFile.Import(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\TextFilesInformation\2.xml"), ref test);

            Core.GetProjectConfig();

            //DbService.getUsers();
            //Wallet wallet = DbService.GetWalletById(1);
            //wallet.MoneyMovements = DbService.GetMovements(wallet.Id);

            User user = DbService.GetUserByCredentials("gjhgfh", "54354rtfd");


            Console.WriteLine("fin");
            //DbService.getMovements(5);
        
        }
    }
}
