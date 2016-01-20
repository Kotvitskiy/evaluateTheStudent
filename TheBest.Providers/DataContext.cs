using Business.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBest.Business.Entities;

namespace TheBest.EntityProviders
{
    public class DataContext : DbContext
    {
        public DataContext() : base("TheBestConnection")
        {

        }

        public DbSet<Student> Students { get; set; }

        public DbSet<Evaluator> Evaluators { get; set; }

        public DbSet<Question> Questions { get; set; }

        public DbSet<Answer> Answers { get; set; }
    }
}
