using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSystem.Models
{
    public class Result
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public int Scores { get; set; }
        public int MaxScores { get; set; }
    }
}
