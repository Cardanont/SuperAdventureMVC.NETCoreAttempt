using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperAdventure.Models
{
    public class Monster : LivingCreature
    {
        public Monster(int id, string name, int maxDamage, int rewardExp, int rewardGold, int currentHitPoints, int maximumHitPoints) : base(currentHitPoints, maximumHitPoints)
        {
            ID = id;
            Name = name;
            MaximumDamage = maxDamage;
            RewardExperiencePoints = rewardExp;
            RewardGold = rewardGold;

            LootTable = new List<LootItem>();
        }
        public int ID { get; set; }
        public string Name { get; set; }
        public int MaximumDamage { get; set; }
        public int RewardExperiencePoints { get; set; }
        public int RewardGold { get; set; }

        public List<LootItem> LootTable { get; set; }
    }
}
