using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SuperAdventure.Models
{
    public class Player
    {
        [Display(Name = "Current Hit Points")]
        public int CurrentHitPoints { get; set; }
        [Display(Name = "Maximum Hit points")]
        public int MaximumHitPoints { get; set; }
        [Display(Name = "Gold")]
        public int Gold { get; set; }
        [Display(Name = "Experience Points")]
        public int ExperiencePoints { get; set; }
        [Display(Name = "Level")]
        public int Level { get; set; }
    }
}
