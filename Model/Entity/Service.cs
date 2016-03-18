using SQLite.Net.Attributes;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entity
{
    [Table("Service")]
    public class Service
    {
        private int id;
        [Column("Id")]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string name;
        [Column("Name")]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private User whoAdd;
        [ManyToOne(CascadeOperations = CascadeOperation.All)]
        public User WhoAdd
        {
            get { return whoAdd; }
            set { whoAdd = value; }
        }

        private int userId;
        [ForeignKey(typeof(User)), Column("UserId")]
        public int UserId
        {
            get { return userId; }
            set { userId = value; }
        }

        [OneToMany(CascadeOperations = CascadeOperation.All)]
        public List<TurnSystem> TurnSystems { get; set; }

    }
}
