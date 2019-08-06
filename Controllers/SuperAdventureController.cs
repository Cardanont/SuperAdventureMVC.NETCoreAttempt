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
            // Player initial data
            Player player = new Player(20, 0, 1, 10, 10);

            // Player Initial location
            Location location = new Location(1, "Home", "This is your house");

            return View(player);
        }
    }
}