using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entities.WalletEntities;
using Entities.SystemCore;
using Entities.InputOutput;

namespace Entities.DataBaseActions
{
    public static class DbService
    {
        public static SqlConnection connection;
        public static SqlCommand command;
        public static SqlDataReader reader;

        static DbService()
        {
            connection = new SqlConnection(Core.ConfigData.ConnectionString);
            command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.Connection = connection;
        }

        public static void newCommandType()
        {
            command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.Connection = connection;
        }


        public static List<User> GetUsers()
        {
            try
            {
                if (DbService.connection.State != ConnectionState.Open)
                {
                    DbService.connection.Open();
                }

                newCommandType();
                DbService.command.CommandText = "Select * from Users";


                DbService.reader = DbService.command.ExecuteReader();

                List<User> userList = new List<User>();
                while (DbService.reader.Read())
                {
                    User user = new User();
                    user.Id = (int)DbService.reader["Id"];
                    user.Name = Convert.ToString(DbService.reader["Name"]);
                    user.Password = Convert.ToString(DbService.reader["Password"]);
                    user.IdWallet = (int)DbService.reader["IdWallet"];
                    user.TextInfo = Convert.ToString(DbService.reader["TextInfo"]);

                    userList.Add(user);
                }
                return userList;

            }
            finally
            {
                DbService.connection.Close();
            }
        }

        public static User GetUserByCredentials(string name, string password)
        {
            try
            {
                if (DbService.connection.State != ConnectionState.Open)
                {
                    DbService.connection.Open();
                }

                newCommandType();
                DbService.command.CommandText = "Select * from Users where Name = @name and Password = @password";
                DbService.command.Parameters.AddWithValue("@name", name);
                DbService.command.Parameters.AddWithValue("@password", password);

                DbService.reader = DbService.command.ExecuteReader();

                User user = new User();
                while (DbService.reader.Read())
                {
                    user.Id = (int)DbService.reader["Id"];
                    user.Name = Convert.ToString(DbService.reader["Name"]);
                    user.Password = Convert.ToString(DbService.reader["Password"]);
                    user.IdWallet = (int)DbService.reader["WalletId"];
                    user.TextInfo = Convert.ToString(DbService.reader["TextInfo"]);
                }
                return user;
            }
            finally
            {
                DbService.connection.Close();
            }
        }


        public static Wallet GetWalletById(int id)
        {
            try
            {
                if (DbService.connection.State != ConnectionState.Open)
                {
                    DbService.connection.Open();
                }

                newCommandType();
                DbService.command.CommandText = "Select * from Wallets where Id = @id";
                DbService.command.Parameters.AddWithValue("@id", id);


                DbService.reader = DbService.command.ExecuteReader();
                Wallet wallet = new Wallet();

                while (DbService.reader.Read())
                {
                    wallet.Id = (int)DbService.reader["Id"];
                    wallet.Balance = Convert.ToSingle(DbService.reader["Balance"]);
                }
                return wallet;
            }
            finally
            {
                DbService.connection.Close();
            }
        }


        public static List<Wallet> GetWallets()
        {
            try
            {
                if (DbService.connection.State != ConnectionState.Open)
                {
                    DbService.connection.Open();
                }

                newCommandType();
                DbService.command.CommandText = "Select * from Wallets";


                DbService.reader = DbService.command.ExecuteReader();

                List<Wallet> walletList = new List<Wallet>();

                while (DbService.reader.Read())
                {
                    Wallet wallet = new Wallet();
                    wallet.Id = (int)DbService.reader["Id"];
                    wallet.Balance = Convert.ToSingle(DbService.reader["Balance"]);
                    walletList.Add(wallet);

                }
                return walletList;

            }
            finally
            {
                DbService.connection.Close();
            }
        }


        public static List<Movement> GetMovements(int idWallet)
        {
            try
            {
                if (DbService.connection.State != ConnectionState.Open)
                {
                    DbService.connection.Open();
                }

                newCommandType();
                DbService.command.CommandText = "Select * from Movements where IdWallet = @idWallet";
                DbService.command.Parameters.AddWithValue("@idWallet", idWallet);


                DbService.reader = DbService.command.ExecuteReader();

                List<Movement> listMovements = new List<Movement>();

                while (DbService.reader.Read())
                {
                    Movement movement = new Movement();

                    movement.Id = (int)DbService.reader["Id"];
                    movement.Amount = Convert.ToSingle(DbService.reader["Amount"]);
                    movement.Category = Convert.ToString(DbService.reader["Category"]);
                    movement.IdWallet = (int)DbService.reader["IdWallet"];
                    movement.TextInfo = Convert.ToString(DbService.reader["TextInfo"]);
                    movement.Type = (Movement.eType)DbService.reader["Type"];
                    movement.PurchaseDate = Convert.ToDateTime(DbService.reader["MovementDate"]);

                    listMovements.Add(movement);
                }
                return listMovements;
            }
            finally
            {
                DbService.connection.Close();
            }
        }


    }
}
