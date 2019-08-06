using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperAdventure.Models
{
    public class Monster : LivingCreature
    {
        public Monster(int id, string name, int maxDamage, int rewardExp, int rewardGold, int currentHitP, int maxHitP) : base(currentHitP, maxHitP)
        {
            ID = id;
            Name = name;
            MaximumDamage = maxDamage;
            RewardExperiencePoints = rewardExp;
            RewardGold = rewardGold;
            CurrentHitPoints = currentHitP;
            MaximumHitPoints = maxHitP;
        }
        public int ID { get; set; }
        public string Name { get; set; }
        public int MaximumDamage { get; set; }
        public int RewardExperiencePoints { get; set; }
        public int RewardGold { get; set; }
    }
}
