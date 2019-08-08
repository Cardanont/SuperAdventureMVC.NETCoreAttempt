using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperAdventure.Models
{
    public class HealingPotion : Item
    {

        public HealingPotion(int id, string name, string namePlural, int amountHeal):base(id, name, namePlural)
        {
            AmountToHeal = amountHeal;
        }
        public int  AmountToHeal { get; set; }
    }
}
