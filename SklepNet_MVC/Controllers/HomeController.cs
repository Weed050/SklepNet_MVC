using Microsoft.AspNetCore.Mvc;
using SklepNet_MVC.Data;
using SklepNet_MVC.Models;
using SklepNet_MVC.Models.CMS;
using System.Diagnostics;

namespace SklepNet_MVC.Controllers
{
    public class HomeController : Controller
    {
        private SklepNetDBContext db = new SklepNetDBContext("SklepNetMVC_ConnectionString");
        public ActionResult _Aktualnosci()
        {
            List<Aktualnosci> listaAktualnosci = db.Aktualnosci.OrderBy(x => x.Pozycja).ToList();
            return PartialView(listaAktualnosci);
        }
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}