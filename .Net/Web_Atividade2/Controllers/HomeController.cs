using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Web_Atividade2.Models;

namespace Web_Atividade2.Controllers
{
    public class HomeController : Controller
    {
            

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Pagina1()
        {
            return View();
        }
        public IActionResult Pagina2()
        {

            return View();
        }

        public IActionResult Pagina3()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}