using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class User : BaseEntity
    {
        public UserRoles Role { get; set; }

        public Evaluator Evaluator { get; set; }

        public string Password { get; set; }
    }
}
