using SQLite.Net.Attributes;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entity
{
    [Table(nameof(TurnSystem))]
    public class TurnSystem
    {
        private int id;

        [Column(nameof(Id)), PrimaryKey, AutoIncrement]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string date;
        [Column(nameof(Date))]
        public string Date
        {
            get { return date; }
            set { date = value; }
        }

        private int serviceId;
        [ForeignKey(typeof(Service)), Column(nameof(ServiceId))]
        public int ServiceId
        {
            get { return serviceId; }
            set { serviceId = value; }
        }

        private Service service;
        [OneToMany(CascadeOperations =CascadeOperation.All)]
        public Service Service
        {
            get { return service; }
            set { service = value; }
        }


    }
}
