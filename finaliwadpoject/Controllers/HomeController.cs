using finaliwadpoject.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace finaliwadpoject.Controllers
{
    public class HomeController : Controller
    {

       

        public IActionResult Index()
        {
            ViewBag.Title = "Welcome to Estate Sale";
            ViewBag.Message = "Our Features";
                      
            return View();
            
        }

        public IActionResult Privacy()
        {
            return View();
        }

    }
}
