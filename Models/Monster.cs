using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperAdventure.Models
{
    public class Monster : LivingCreature
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int MaximumDamage { get; set; }
        public int RewardExperiencePoints { get; set; }
        public int RewardGold { get; set; }
    }
}
