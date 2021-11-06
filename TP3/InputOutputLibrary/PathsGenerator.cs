using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace InputOutputLibrary
{
    static class PathsGenerator<T> where T : DataEntity
    {
        private static string xmlPath;
        private static string txtPath;

        public static string XmlPath { get => xmlPath; }
        public static string TxtPath { get => txtPath; }

        static PathsGenerator()
        {
            PathsGenerator<T>.xmlPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\XmlFiles\");
            PathsGenerator<T>.txtPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\TxtFiles\");
        }


        public static string txtGeneratePath(T entity)
        {
            string fileName = PathsGenerator<T>.TxtPath + entity.Id.ToString() + ".txt";
            return fileName;
        }

        public static string xmlGeneratePath(T entity)
        {
            string fileName = PathsGenerator<T>.XmlPath + entity.Id.ToString() + ".xml";
            return fileName;
        }
    }
}
