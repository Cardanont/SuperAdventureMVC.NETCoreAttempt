using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SuperAdventure.Models
{
    public class Player : LivingCreature
    {

        public Player(int gold, int experiencePoints, int level, int currentHitPoints, int maximumHitPoints) 
            : base(currentHitPoints, maximumHitPoints)
        {
            Gold = gold;
            ExperiencePoints = experiencePoints;
            Level = level;
        }

        [Display(Name = "Gold")]
        public int Gold { get; set; }
        [Display(Name = "Experience Points")]
        public int ExperiencePoints { get; set; }
        [Display(Name = "Level")]
        public int Level { get; set; }
    }
}
