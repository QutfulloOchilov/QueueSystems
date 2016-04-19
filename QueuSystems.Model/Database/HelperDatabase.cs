using SQLite.Net;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net.Interop;

namespace QueuSystems.Model
{
    public class HelperDatabase
    {

        public static bool ConnectionToDataBase(ref Connection connection, ISQLitePlatform litePlatform, string databasePath)
        {
            try
            {
                connection = new Connection(litePlatform, databasePath);
                return true;
            }

            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool CreateDataBase(ref Connection connection, ISQLitePlatform litePlatform, string databasePath)
        {
            try
            {
                connection = new Connection(litePlatform, databasePath);
                connection.CreateTable<Service>();
                connection.CreateTable<User>();
                connection.CreateTable<TurnSystem>();
                connection.SaveTransactionPoint();
                return true;
            }
            catch (Exception ex)
            {
                return false;

            }
        }

        public static User CheckCredentials(string login, string password, Connection connection) => connection.Table<User>().FirstOrDefault(u => u.Login == login && u.Password == password);
    }
}
