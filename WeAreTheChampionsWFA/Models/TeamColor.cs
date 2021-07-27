using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeAreTheChampionsWFA.Models
{
    [Table("TeamColors")]
    public class TeamColor
    {
       [ForeignKey("Team")]
        public int TeamId { get; set; }
        [ForeignKey("Color")]
        public int ColorId { get; set; }
    }
}
