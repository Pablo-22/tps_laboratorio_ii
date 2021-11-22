using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
using Entities.DataBaseActions;
using Entities.WalletEntities;

namespace Entities.InputOutput
{
    public static class PathsGenerator
    {
        private static string xmlPath;
        private static string txtPath;
        private static string jsonPath;

        public static string XmlPath { get => xmlPath; }
        public static string TxtPath { get => txtPath; }
        public static string JsonPath { get => jsonPath; }

        static PathsGenerator()
        {
            PathsGenerator.xmlPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Wallet\XmlFiles\");
            PathsGenerator.txtPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Wallet\TxtFiles\");
            PathsGenerator.jsonPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Wallet\JsonFiles\");
        }


        /// <summary>
        /// Genera un path para archivos de texto combinando el 
        /// path por defecto seleccionado para los archivos de texto
        /// y el nombre pasado por parámetro más la extensión .txt
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns>Path creado</returns>
        public static string txtGeneratePath(string fileName)
        {
            string finalFileName = PathsGenerator.TxtPath + fileName + ".txt";
            return fileName;
        }

        /// <summary>
        /// Genera un path para archivos xml combinando el 
        /// path por defecto seleccionado para los archivos de texto
        /// y el nombre pasado por parámetro más la extensión .xml
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns>Path creado</returns>
        public static string xmlGeneratePath(string fileName)
        {
            string finalFileName = PathsGenerator.XmlPath + fileName + ".xml";
            return finalFileName;
        }

        /// <summary>
        /// Genera un path para archivos json combinando el 
        /// path por defecto seleccionado para los archivos de texto
        /// y el nombre pasado por parámetro más la extensión .json
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns>Path creado</returns>
        public static string jsonGeneratePath(string fileName)
        {
            string finalFileName = PathsGenerator.JsonPath + fileName + ".json";
            return finalFileName;
        }
    }
}
