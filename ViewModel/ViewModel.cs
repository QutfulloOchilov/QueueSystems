using QueuSystems.Model;
using SQLite.Net.Interop;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace QueuSystems.ViewModel
{
    public class ViewModel : INotifyPropertyChanged
    {

        public ViewModel(ISQLitePlatform litePlatform, string databasePath, bool fileExists)
        {
            if (fileExists)
            {

                HelperDatabase.ConnectionToDataBase(ref connection, litePlatform, databasePath);
            }
            else
            {
                HelperDatabase.CreateDataBase(ref connection, litePlatform, databasePath);
            }
        }

        private Connection connection;

        public Connection Connection
        {
            get { return connection; }
            set { connection = value; }
        }

        #region Notify

        /// <summary>
        /// Property Changed event
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Fire the PropertyChanged event
        /// </summary>
        /// <param name="propertyName">Name of the property that changed (defaults from CallerMemberName)</param>
        protected void NotifyPropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion
    }
}
