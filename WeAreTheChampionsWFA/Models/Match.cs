using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeAreTheChampionsWFA.Models
{
    [Table("Matches")]
    public class Match
    {
        public int Id { get; set; }
        public DateTime MatchTime { get; set; }
        [Required]
        public int Team1Id { get; set; }
        [Required]
        public int Team2Id { get; set; }
        public int? Score1 { get; set; }
        public int? Score2 { get; set; }
        public MatchResult Result { get; set; }
        public virtual ICollection<Team> Teams { get; set; }
    }
}
