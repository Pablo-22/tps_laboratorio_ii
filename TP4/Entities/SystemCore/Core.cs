using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
using Entities.DataBaseActions;
using Entities.WalletEntities;
using Entities.InputOutput;
using System.Data.SqlClient;

namespace Entities.SystemCore
{
    public static class Core
    {
        private static int lastId;
        private static Wallet userWallet;
        private static User actualUser;
        private static ProjectConfigurationData configData;

        public static ProjectConfigurationData ConfigData
        {
            get { return configData; }
            set { configData = value; }
        }


        public static Wallet UserWallet
        {
            get { return userWallet; }
            set { userWallet = value; }
        }


        public static User ActualUser
        {
            get { return actualUser; }
            set { actualUser = value; }
        }



        public static int LastId
        {
            get { return lastId; }
            set { lastId = value; }
        }


        static Core()
        {
            configData = new ProjectConfigurationData();
        }

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

        public static void LogOut()
        {
            Core.ActualUser = null;
            Core.UserWallet = null;
        }


        /// <summary>
        /// Recibe los datos de un usuario y los busca en la lista.
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="password"></param>
        /// <returns>Devuelve true si lo encuentra y false si no lo encuentra.
        /// Si puede loguear, cambia el estado del atributo UsuarioLogueado, por el usuario encontrado.</returns>
        public static void LoguearUsuario(string name, string password)
        {
            Core.ActualUser = null;
            Core.UserWallet = null;

            Core.ActualUser = DbService.GetUserByCredentials(name, password);
            if (ActualUser != null)
            {
                Core.UserWallet = DbService.GetWalletById(Core.ActualUser.Id);
                if (UserWallet != null)
                {
                    Core.UserWallet.MoneyMovements = DbService.GetMovements(Core.UserWallet.Id);
                }
            }
            else
            {
                throw new InvalidUserException();
            }
        }


        public static void GetProjectConfig()
        {
            ProjectConfigurationData config = new ProjectConfigurationData("testeando");

            Json<ProjectConfigurationData> configDataSerializer = new Json<ProjectConfigurationData>();

            configDataSerializer.Import(@"..\..\..\..\", "config.json", ref config);

            Core.ConfigData = config;
        }
    }
}
