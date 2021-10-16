using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace fashion_store.Models
{

    public class DBstore: DbContext
    {
        public DbSet<User> users { get; set; }
    }
}