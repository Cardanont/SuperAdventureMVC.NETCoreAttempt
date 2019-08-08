using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperAdventure.Models
{
    public class PlayerQuest
    {
        public PlayerQuest(Quest details)
        {
            Details = details;
            IsCompleted = false;
        }

        public Quest Details { get; set; }
        public bool IsCompleted { get; set; }
    }
}
