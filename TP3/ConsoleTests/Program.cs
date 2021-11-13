using System;
using System.IO;
using Entities;
using InputOutputLibrary;

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

            User test = new User();

            //file.Import(@"textFiles\0.txt",out test);

            Xml<User> xmlFile = new Xml<User>();

           //xmlFile.Export(test);

            xmlFile.Import(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\TextFilesInformation\2.xml"), ref test);

        }
    }
}
