using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Student : BaseEntity
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string SocialUrl { get; set; }

        public string Group { get; set; }

        public string IconUrl { get; set; }

        public string ThumbnailUrl { get; set; }

        public decimal Rate { get; set; }
    }
}
