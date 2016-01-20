using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TheBest.Models.Entities
{
    public class StudentViewModel : BaseViewModel
    {
        public string Name { get; set; }

        public string IconUrl { get; set; }

        public string ThumbnailUrl { get; set; }

        public string Description { get; set; }

        public decimal Rate { get; set; }

        public string SocialUrl { get; set; }

        public string Group { get; set; }
    }
}