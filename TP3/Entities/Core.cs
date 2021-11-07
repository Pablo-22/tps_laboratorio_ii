using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public static class Core
    {
        private static int lastId;

        public static int LastId
        {
            get { return lastId; }
            set { lastId = value; }
        }


        static Core()
        { }

        public static int GenerateId()
        {
            Core.LastId = Core.GetBiggestId();
            Core.LastId++;
            return Core.LastId;
        }

        public static int GetBiggestId()
        {
            int biggestId = Core.LastId;

            foreach (User user in Bank.Users)
            {
                if (user.Id > Core.LastId)
                {
                    biggestId = user.Id;
                }
            }

            foreach (Wallet wallet in Bank.Wallets)
            {
                if (wallet.Id > Core.LastId)
                {
                    biggestId = wallet.Id;
                }

                foreach (Movement movement in wallet.MoneyMovements)
                {
                    if (movement.Id > Core.LastId)
                    {
                        biggestId = movement.Id;
                    }
                }
            }

            return biggestId;
        }



        /// <summary>
        /// Verifica que la cadena recibida como parámetro sea un entero.
        /// </summary>
        /// <param name="strNumber"></param>
        /// <returns>Devuelve true si es un entero, false si no lo es.</returns>
        public static bool IsValidInt(string strNumber)
        {
            if (string.IsNullOrEmpty(strNumber) == false && int.TryParse(strNumber, out _) == true)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Verifica que la cadena recibida como parámetro sea un flotante.
        /// </summary>
        /// <param name="strNumber"></param>
        /// <returns>Devuelve true si es un flotante, false si no lo es.</returns>
        public static bool IsValidFloat(string strNumber)
        {
            if (string.IsNullOrEmpty(strNumber) == false && float.TryParse(strNumber, out _) == true)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Verifica que la cadena recibida como parámetro contenga solo letras.
        /// </summary>
        /// <param name="stringToEvaluate"></param>
        /// <returns>Devuelve true si la cadena contiene solo letras, false si no lo es.</returns>
        public static bool IsValidAlpha(string stringToEvaluate)
        {
            if (string.IsNullOrEmpty(stringToEvaluate) == false)
            {
                for (int i = 0; i < stringToEvaluate.Length; i++)
                {
                    if (char.IsLetter(stringToEvaluate[i]) == false)
                    {
                        return false;
                    }
                }
            }
            else
            {
                return false;
            }
            return true;
        }
    }
}
