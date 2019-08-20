using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SuperAdventure.Models;
using SuperAdventure.ViewModels;

namespace SuperAdventure.Controllers
{
    public class SuperAdventureController : Controller
    {
        public SuperAdventureController()
        {
            
        }

        public IActionResult Index()
        {

            var viewModel = new GameFormViewModel
            {
               Player = new Player(20, 0, 1, 10, 10),
               Location = new Location(1, "Home", "This is your house")
            };

            return View(viewModel);
        }
    }
}