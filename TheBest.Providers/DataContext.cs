using Business.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBest.EntityProviders
{
    public class DataContext : DbContext
    {
        public DataContext() : base("TheBestConnection")
        {

        }

        public DbSet<Student> Students { get; set; }

        public DbSet<Evaluator> Evaluators { get; set; }
    }
}
