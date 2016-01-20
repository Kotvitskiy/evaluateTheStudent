using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Evaluator : BaseEntity
    {
        public string Name { get; set; }

        public string ImageUrl { get; set; }

        public List<string> Groups { get; set; }
    }
}
