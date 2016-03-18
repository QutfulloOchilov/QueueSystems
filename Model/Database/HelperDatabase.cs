using SQLite.Net;
using SQLite.Net.Platform.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Entity;

namespace Model.Database
{
    public class HelperDatabase
    {
        public const string DatabaseName = "DataBase.db";
        public static bool ConnectionToDataBase(ref Connection connection)
        {
            bool result = false;
            try
            {
                if (File.Exists(DatabaseName))
                {
                    connection = new Connection(new SQLitePlatformWin32());
                }
                else
                {
                    connection = new Connection(new SQLitePlatformWin32());
                    connection.CreateTable<Service>();
                    connection.CreateTable<User>();
                    connection.CreateTable<TurnSystem>();
                    connection.SaveTransactionPoint();
                    result = true;
                }
            }
            catch (Exception)
            {
                result = false;
            }

            return result;
        }
    }
}
