using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SuperAdventure.Models
{
    public class Player : LivingCreature
    {
        [Display(Name = "Gold")]
        public int Gold { get; set; }
        [Display(Name = "Experience Points")]
        public int ExperiencePoints { get; set; }
        [Display(Name = "Level")]
        public int Level { get; set; }
    }
}
