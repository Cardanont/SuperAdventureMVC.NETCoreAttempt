using SuperAdventure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperAdventure.ViewModels
{
    public class GameFormViewModel
    {
        public Player Player { get; set; }
        public Location Location { get; set; }
    }
}
