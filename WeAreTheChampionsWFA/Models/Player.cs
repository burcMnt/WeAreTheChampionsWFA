using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeAreTheChampionsWFA.Models
{
    [Table("Players")]
    public class Player
    {
        public int Id { get; set; }
        [ForeignKey("Team")]
        public int? TeamId { get; set; }
        [Required,MaxLength(100)]
        public string PlayerName { get; set; }

    }
}
