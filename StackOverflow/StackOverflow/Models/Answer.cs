using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;


namespace StackOverflow.Models
{
    [Table("answers")]
    public class Answer
    {
        [Key]
        public int Id { get; set; }
        public string Username { get; set; }
        public string Detail { get; set; }
        public int QuestionId { get; set; }
        public DateTime Posted { get; set; }
        public int Upvotes { get; set; }
        
    }
}
