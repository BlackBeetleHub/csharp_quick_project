using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.src
{
    enum RecordType
    {
        cost = 1, // Расходы
        income = 2 // Доходы
    }

    class Family
    {
        public int Id { get; set; }
        public string firts_name { get; set; }
        public string second_name { get; set; }
        public string details { get; set; }
    }

    class Record
    {
        public int id { get; set; }
        public int user_id { get; set; }
        public int type { get; set; }
        public string time { get; set; }
        public string purpose { get; set; }
        public int amount { get; set; }
    }

    class UserContext : DbContext
    {
        public UserContext()
            : base("DbConnection")
        { }

        public DbSet<Family> Users { get; set; }
        public DbSet<Record> Records { get; set; }
    }
}
