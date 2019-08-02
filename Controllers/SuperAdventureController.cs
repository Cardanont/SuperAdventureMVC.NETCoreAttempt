using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SuperAdventure.Models;

namespace SuperAdventure.Controllers
{
    public class SuperAdventureController : Controller
    {
        public SuperAdventureController()
        {
            
        }

        public IActionResult Index()
        {
            Player player = new Player();

            player.CurrentHitPoints = 10;
            player.MaximumHitPoints = 10;
            player.Gold = 20;
            player.ExperiencePoints = 0;
            player.Level = 1;

            return View(player);
        }
    }
}