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
        public static bool LogIn(string name, string password)
        {
            bool exit = false;

            foreach (User user in Bank.Users)
            {
                if (user.Name == name && user.Password == password)
                {
                    Core.ActualUser = user;
                    Core.UserWallet = Bank.Wallets[Bank.SearchWalletIndexById(user.IdWallet)];
                    exit = true;
                }
            }
            if (exit == false)
            {
                throw new InvalidUserException();
            }

            return exit;
        }


        /// <summary>
        /// Comprueba que no exista un usuario con el mismo nombre recibido por parámetro,
        /// y si no lo encuentra, lo crea y lo añade a la lista.
        /// </summary>
        /// <param name="nombreDeUsuario"></param>
        /// <param name="password"></param>
        /// <returns>devuelve true si puede registrar, y false si no puede.</returns>
        public static bool SignIn(string nombreDeUsuario, string password)
        {
            bool exit = false;
            User newUser = new User();
            newUser.Name = nombreDeUsuario;
            newUser.Password = password;

            if (HasNullFields(newUser) == false && !Core.UsuarioRepetido(newUser))
            {
                Core.SaveUser(newUser);
                exit = true;
            }
            return exit;
        }

        /// <summary>
        /// Comprueba que un usuario no contenga propiedades nulas
        /// </summary>
        /// <param name="user"></param>
        /// <returns> Devuelve true si tiene nombre o password nula, false si no. </returns>
        public static bool HasNullFields(User user)
        {
            if (user.Password == null || user.Name == null)
            {
                return true;
            }
            return false;
        }


        /// <summary>
        /// Comprueba si ya existe un usuario con el mismo nombre y diferente id
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns> Retorna true si el usuario está repetido, false si no. </returns>
        public static bool UsuarioRepetido(User usuario)
        {
            foreach (User item in Bank.Users)
            {
                if (item.Name == usuario.Name && item.Id != usuario.Id)
                {
                    return true;
                }
            }
            return false;
        }


        /// <summary>
        /// Guarda un usuario en la lista.
        /// </summary>
        /// <param name="user"></param>
        /// <returns>Retorna el índice donde se guardó.</returns>
        public static int SaveUser(User user)
        {
            Wallet wallet = new Wallet(0);
            user.IdWallet = wallet.Id;
            Bank.Users.Add(user);
            Bank.Wallets.Add(wallet);
            return Bank.Users.IndexOf(user);
        }



        public static void GetProjectConfig()
        {
            ProjectConfigurationData config = new ProjectConfigurationData("testeando");

            Json<ProjectConfigurationData> configDataSerializer = new Json<ProjectConfigurationData>();

            configDataSerializer.Import("", "config.json", ref config);

            Core.ConfigData = config;
        }


        public static DateTime RandomDay(Random gen)
        {
            DateTime start = new DateTime(2021, 10, 1);
            int range = (DateTime.Today - start).Days;
            return start.AddDays(gen.Next(range));
        }
    }
}
