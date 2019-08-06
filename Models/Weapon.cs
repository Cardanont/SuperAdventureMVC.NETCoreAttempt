using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperAdventure.Models
{
    public class Weapon : Item
    {
        public int MinimumDamage { get; set; }
        public int MaximumDamage { get; set; }
    }
}
