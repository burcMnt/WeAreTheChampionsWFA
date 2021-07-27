using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeAreTheChampionsWFA.Models
{
    [Table("Colors")]
    public class Color
    {
        public int Id { get; set; }
        [Required,MaxLength(50)]
        public string ColorName { get; set; }
        public int Red { get; set; }
        public int Green { get; set; }
        public int Blue { get; set; }

    }
}
