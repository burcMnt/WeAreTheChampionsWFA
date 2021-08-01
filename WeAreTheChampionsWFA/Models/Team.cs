using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeAreTheChampionsWFA.Models
{
    [Table("Teams")]
   public class Team
    {
        public int Id { get; set; }
        [Required,MaxLength(100)]
        public string TeamName { get; set; }
        public virtual ICollection<Player> Players { get; set; } = new HashSet<Player>();
        public virtual ICollection<Color> Colors { get; set; }= new HashSet<Color>();
        [InverseProperty("Team1")]
        public virtual ICollection<Match> Team1 { get; set; }= new HashSet<Match>();
        [InverseProperty("Team2")]
        public virtual ICollection<Match> Team2 { get; set; } = new HashSet<Match>();
    }
}
