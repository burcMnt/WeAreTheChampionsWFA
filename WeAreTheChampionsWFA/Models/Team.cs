﻿using System;
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
    }
}