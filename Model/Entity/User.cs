using SQLite.Net.Attributes;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entity
{
    [Table(nameof(User))]
    public class User
    {

        private int id;
        [Column(nameof(Id))]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string firstName;
        [Column(nameof(FirstName))]
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        private string lastName;
        [Column(nameof(LastName))]
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        private string password;
        [Column(nameof(Password))]
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        private string login;
        [Column(nameof(Login))]
        public string Login
        {
            get { return login; }
            set { login = value; }
        }

        private StatusUser status;
        [Column(nameof(Status))]
        public StatusUser Status
        {
            get { return status; }
            set { status = value; }
        }

        [OneToMany(CascadeOperations = CascadeOperation.All)]
        public List<Service> Services
        {
            get;
            set;
        }

    }


}
