using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace davesPub.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

    }
}