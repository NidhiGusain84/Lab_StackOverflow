using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace StackOverflow.Models
{
    public class QuestionWithAnswers
    {
        public Question Question { get; set; }
        public List<Question> Questions { get; set; }
        public List<Answer> Answers { get; set; }

    }
}
