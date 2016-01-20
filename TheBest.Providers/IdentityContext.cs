using Business.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBest.EntityProviders.Providers
{
    public class IdentityContext : DbContext
    {
        public IdentityContext() : base("TheBestConnection")
        {

        }

        public DbSet<User> Users { get; set; }
    }
}
