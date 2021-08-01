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

        [ForeignKey("Team1")]
        public int? Team1Id { get; set; }

        [ForeignKey("Team2")]
        public int? Team2Id { get; set; }
        public int? Score1 { get; set; }
        public int? Score2 { get; set; }
        public MatchResult Result { get; set; }
        public virtual Team Team1 { get; set; }
        public virtual Team Team2 { get; set; }
    }
}
