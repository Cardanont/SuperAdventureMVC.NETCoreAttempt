using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SuperAdventure.Models
{
    public class LivingCreature
    {

        public LivingCreature(int currentHitPoints, int maximumHitPoints)
        {
            CurrentHitPoints = currentHitPoints;
            MaximumHitPoints = maximumHitPoints;
        }

        [Display(Name = "Maximum Hit points")]
        public int MaximumHitPoints { get; set; }

        [Display(Name = "Current Hit Points")]
        public int CurrentHitPoints { get; set; }
    }
}
