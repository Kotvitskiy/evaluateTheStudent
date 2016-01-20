using Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBest.Business.Entities
{
    public class Answer : BaseEntity
    {
        public int StudentId { get; set; }

        public int EvaluatorId { get; set; }

        public int QuestionId { get; set; }

        public bool Result { get; set; }

        public DateTime LastVoteDate { get; set; }
    }
}
