using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperAdventure.Models
{
    public class QuestCompletionItem
    {
        public QuestCompletionItem(Item details, int quantity)
        {
            Details = details;
            Quantity = quantity;
        }
        
        
        public Item Details { get; set; }
        public int Quantity { get; set; }
    }
}
