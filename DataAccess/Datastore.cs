using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Datastore: DbContext
    {
        public Datastore(string connectionString) : base(connectionString)
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Upload> Uploads { get; set; }
    }
}
