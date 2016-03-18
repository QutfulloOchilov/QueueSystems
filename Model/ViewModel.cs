using Model.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Database
{
    public class ViewModel : INotifyPropertyChanged
    {
        public ViewModel() {

        }

        #region Filds

        private User currentUser;
        private Connection currentConnection;

        #endregion

        #region Properties

        public User CurrentUser
        {
            get { return currentUser; }
            set { currentUser = value; NotifyPropertyChanged(); }
        }


        public Connection CurrentConnection
        {
            get { return currentConnection; }
            set { currentConnection = value; }
        }

        #endregion





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
