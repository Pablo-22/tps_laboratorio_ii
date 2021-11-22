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

        static DbService()
        { }

        public static SqlCommand newCommand(SqlConnection connection)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.Connection = connection;
            return command;
        }


        public static List<User> GetUsers()
        {
            SqlConnection connection = new SqlConnection();
            try
            {
                connection.ConnectionString = Core.ConfigData.ConnectionString;
                List<User> userList = new List<User>();

                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                SqlCommand command = newCommand(connection);
                command.CommandText = "Select * from Users";


                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    User user = new User();
                    user.Id = (int)reader["Id"];
                    user.Name = Convert.ToString(reader["Name"]);
                    user.Password = Convert.ToString(reader["Password"]);
                    user.IdWallet = (int)reader["WalletId"];
                    user.TextInfo = Convert.ToString(reader["TextInfo"]);

                    userList.Add(user);
                }
                return userList;

            }
            catch
            {
                return null;
            }
            finally
            {
                connection.Close();
            }
        }

        public static User GetUserByCredentials(string name, string password)
        {
            SqlConnection connection = new SqlConnection();
            try
            {
                User user = new User();
                connection.ConnectionString = Core.ConfigData.ConnectionString;

                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                SqlCommand command = newCommand(connection);
                command.CommandText = "Select * from Users where Name = @name and Password = @password";
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@password", password);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    user.Id = (int)reader["Id"];
                    user.Name = Convert.ToString(reader["Name"]);
                    user.Password = Convert.ToString(reader["Password"]);
                    user.IdWallet = (int)reader["WalletId"];
                    user.TextInfo = Convert.ToString(reader["TextInfo"]);
                }
                return user;
            }
            catch
            {
                return null;
            }
            finally
            {
                connection.Close();
            }
        }

        public static User GetUserByName(string name)
        {
            SqlConnection connection = new SqlConnection();
            try
            {
                User user = new User();
                connection.ConnectionString = Core.ConfigData.ConnectionString;

                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                SqlCommand command = newCommand(connection);
                command.CommandText = "Select * from Users where Name = @name";
                command.Parameters.AddWithValue("@name", name);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    user.Id = (int)reader["Id"];
                    user.Name = Convert.ToString(reader["Name"]);
                    user.Password = Convert.ToString(reader["Password"]);
                    user.IdWallet = (int)reader["WalletId"];
                    user.TextInfo = Convert.ToString(reader["TextInfo"]);
                }
                return user;
            }
            catch
            {
                return null;
            }
            finally
            {
                connection.Close();
            }
        }

        public static User GetUserById(int id)
        {
            SqlConnection connection = new SqlConnection();
            try
            {
                User user = new User();
                connection.ConnectionString = Core.ConfigData.ConnectionString;

                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                SqlCommand command = newCommand(connection);
                command.CommandText = "Select * from Users where Id = @id";
                command.Parameters.AddWithValue("@id", id);


                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    user.Id = (int)reader["Id"];
                    user.Name = Convert.ToString(reader["Name"]);
                    user.Password = Convert.ToString(reader["Password"]);
                    user.IdWallet = (int)reader["WalletId"];
                    user.TextInfo = Convert.ToString(reader["TextInfo"]);
                }
                return user;
            }
            catch
            {
                return null;
            }
            finally
            {
                connection.Close();
            }
        }


        public static Wallet GetWalletById(int id)
        {
            SqlConnection connection = new SqlConnection();
            try
            {
                Wallet wallet = new Wallet();
                connection.ConnectionString = Core.ConfigData.ConnectionString;

                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                SqlCommand command = newCommand(connection);
                command.CommandText = "Select * from Wallets where Id = @id";
                command.Parameters.AddWithValue("@id", id);


                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    wallet.Id = (int)reader["Id"];
                    wallet.Balance = !string.IsNullOrEmpty(reader["Balance"].ToString()) ? Convert.ToSingle(reader["Balance"]) : 0;
                }
                return wallet;
            }
            catch
            {
                return null;
            }
            finally
            {
                connection.Close();
            }
        }


        public static List<Wallet> GetWallets()
        {
            SqlConnection connection = new SqlConnection();
            try
            {
                connection.ConnectionString = Core.ConfigData.ConnectionString;
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                SqlCommand command = newCommand(connection);
                command.CommandText = "Select * from Wallets";


                SqlDataReader reader = command.ExecuteReader();

                List<Wallet> walletList = new List<Wallet>();

                while (reader.Read())
                {
                    Wallet wallet = new Wallet();
                    wallet.Id = (int)reader["Id"];
                    wallet.Balance = !string.IsNullOrEmpty(reader["Balance"].ToString()) ? Convert.ToSingle(reader["Balance"]) : 0;
                    walletList.Add(wallet);

                }
                return walletList;

            }
            catch
            {
                return null;
            }
            finally
            {
                connection.Close();
            }
        }


        public static List<Movement> GetMovements(int idWallet)
        {
            SqlConnection connection = new SqlConnection();
            try
            {
                connection.ConnectionString = Core.ConfigData.ConnectionString;
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                SqlCommand command = newCommand(connection);
                command.CommandText = "Select * from Movements where IdWallet = @idWallet";
                command.Parameters.AddWithValue("@idWallet", idWallet);


                SqlDataReader reader = command.ExecuteReader();

                List<Movement> listMovements = new List<Movement>();

                while (reader.Read())
                {
                    Movement movement = new Movement();

                    movement.Id = (int)reader["Id"];
                    movement.Amount = Convert.ToSingle(reader["Amount"]);
                    movement.Category = Convert.ToString(reader["Category"]);
                    movement.IdWallet = (int)reader["IdWallet"];
                    movement.TextInfo = Convert.ToString(reader["TextInfo"]);
                    movement.Type = (Movement.eType)reader["Type"];
                    movement.PurchaseDate = Convert.ToDateTime(reader["MovementDate"]);

                    listMovements.Add(movement);
                }
                return listMovements;
            }
            catch
            {
                return null;
            }
            finally
            {
                connection.Close();
            }
        }

        public static Movement GetMovement(int idMovement)
        {
            SqlConnection connection = new SqlConnection();
            try
            {
                connection.ConnectionString = Core.ConfigData.ConnectionString;
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                SqlCommand command = newCommand(connection);
                command.CommandText = "Select * from Movements where Id = @idMovement";
                command.Parameters.AddWithValue("@idMovement", idMovement);


                SqlDataReader reader = command.ExecuteReader();

                Movement movement = new Movement();

                while (reader.Read())
                {

                    movement.Id = (int)reader["Id"];
                    movement.Amount = Convert.ToSingle(reader["Amount"]);
                    movement.Category = Convert.ToString(reader["Category"]);
                    movement.IdWallet = (int)reader["IdWallet"];
                    movement.TextInfo = Convert.ToString(reader["TextInfo"]);
                    movement.Type = (Movement.eType)reader["Type"];
                    movement.PurchaseDate = Convert.ToDateTime(reader["MovementDate"]);
                }
                return movement;
            }
            catch
            {
                return null;
            }
            finally
            {
                connection.Close();
            }
        }

        public static void RefreshMovements()
        {
            Core.UserWallet.MoneyMovements = GetMovements(Core.UserWallet.Id);
        }


        public static bool InsertMovement(Movement movement)
        {
            SqlConnection connection = new SqlConnection();
            try
            {
                connection.ConnectionString = Core.ConfigData.ConnectionString;
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                SqlCommand command = newCommand(connection);
                command.CommandText = "INSERT INTO Movements " +

                                                "([Amount]," +
                                                "[IdWallet]," +
                                                "[MovementDate]," +
                                                "[Type]," +
                                                "[Category])  " +

                                                "VALUES " +

                                                "(@Amount," +
                                                "@IdWallet," +
                                                "@MovementDate," +
                                                "@Type," +
                                                "@Category) ";

                command.Parameters.AddWithValue("@Amount", movement.Amount);
                command.Parameters.AddWithValue("@idWallet", movement.IdWallet);
                command.Parameters.AddWithValue("@MovementDate", movement.PurchaseDate);
                command.Parameters.AddWithValue("@Type", (int)movement.Type);
                command.Parameters.AddWithValue("@Category", movement.Category);

                if (command.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }

        }

        public static void SaveMovements(Wallet wallet)
        {
            wallet.MoneyMovements.ForEach(movement =>
            {
                if (GetMovement(movement.Id).Id == -1)
                {
                    InsertMovement(movement);
                }
            });
        }

        public static int getBiggestIdMovement()
        {
            SqlConnection connection = new SqlConnection();

            try
            {
                connection.ConnectionString = Core.ConfigData.ConnectionString;
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                SqlCommand command = newCommand(connection);
                command.CommandText = "SELECT TOP (1) [Id] FROM Movements order by [Id] desc";

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    return (int)reader["Id"];
                }
                return -1;
            }
            catch
            {
                return -1;
            }
            finally
            {
                connection.Close();
            }
        }

        public static int getBiggestIdWallet()
        {
            SqlConnection connection = new SqlConnection();

            try
            {
                connection.ConnectionString = Core.ConfigData.ConnectionString;
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                SqlCommand command = newCommand(connection);
                command.CommandText = "SELECT TOP (1) [Id] FROM Wallets order by [Id] desc";

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    return (int)reader["Id"];
                }
                return -1;
            }
            catch
            {
                return -1;
            }
            finally
            {
                connection.Close();
            }
        }

        public static int getBiggestIdUser()
        {
            SqlConnection connection = new SqlConnection();

            try
            {
                connection.ConnectionString = Core.ConfigData.ConnectionString;
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                SqlCommand command = newCommand(connection);
                command.CommandText = "SELECT TOP(1) [Id] FROM Users order by[Id] desc";

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    return (int)reader["Id"];
                }
                return -1;
            }
            catch
            {
                return -1;
            }
            finally
            {
                connection.Close();
            }
        }
        public static bool UpdateWalletBalance(Wallet wallet)
        {
            SqlConnection connection = new SqlConnection();
            try
            {
                connection.ConnectionString = Core.ConfigData.ConnectionString;

                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                SqlCommand command = newCommand(connection);
                command.CommandText = " Update Wallets set Balance = @balance  where Id = @id";
                command.Parameters.AddWithValue("@balance", wallet.Balance);
                command.Parameters.AddWithValue("@id", wallet.Id);


                if (command.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        public static bool UpdateUserWalletId(User user)
        {
            SqlConnection connection = new SqlConnection();
            try
            {
                connection.ConnectionString = Core.ConfigData.ConnectionString;

                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                SqlCommand command = newCommand(connection);
                command.CommandText = "Update Users set WalletId = @WalletId  where Id = @id";
                command.Parameters.AddWithValue("@WalletId", user.IdWallet);
                command.Parameters.AddWithValue("@id", user.Id);


                if (command.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        public static bool InsertUser(User user)
        {
            SqlConnection connection = new SqlConnection();
            try
            {
                connection.ConnectionString = Core.ConfigData.ConnectionString;

                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                SqlCommand command = newCommand(connection);
                command.CommandText = "INSERT INTO Users " +

                                                "([Name]," +
                                                "[TextInfo]," +
                                                "[Password]," +
                                                "[WalletId])" +

                                                "VALUES " +

                                                "(@Name," +
                                                "@TextInfo," +
                                                "@Password," +
                                                "@WalletId) ";


                command.Parameters.AddWithValue("@Name", user.Name);
                command.Parameters.AddWithValue("@TextInfo", !string.IsNullOrEmpty(user.TextInfo) ? user.TextInfo : "-");
                command.Parameters.AddWithValue("@Password", user.Password);
                command.Parameters.AddWithValue("@WalletId", user.IdWallet);


                if (command.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        public static bool InsertWallet(Wallet wallet)
        {
            SqlConnection connection = new SqlConnection();
            try
            {
                connection.ConnectionString = Core.ConfigData.ConnectionString;

                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                SqlCommand command = newCommand(connection);
                command.CommandText = "INSERT INTO Wallets " +

                                                "([TextInfo]," +
                                                "[Balance])" +

                                                "VALUES " +

                                                "(@TextInfo," +
                                                "@Balance) ";


                command.Parameters.AddWithValue("@TextInfo", !string.IsNullOrEmpty(wallet.TextInfo) ? wallet.TextInfo : "-");
                command.Parameters.AddWithValue("@Balance", wallet.Balance);


                if (command.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
