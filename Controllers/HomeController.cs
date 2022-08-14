using davesPub.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace davesPub.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationContext db;

        public HomeController(ApplicationContext context)
        {
            db = context;
        }

        

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> create(mainPageItem mainPageItem)
        {
            db.MainPageItems.Add(mainPageItem);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }



        [HttpGet]
        public IActionResult strongAlchoAdd()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> strongAlchoAdd(strongAlchogol strongAlchogol)
        {
            db.StrongAlchogols.Add(strongAlchogol);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }






        public async Task<IActionResult> Pub()
        {
            return View(await db.MainPageItems.ToListAsync());
        }

        public async Task<IActionResult> HardDrinks()
        {
            return View(await db.StrongAlchogols.ToListAsync());
        }






    }
}