using Microsoft.AspNetCore.Mvc;
using SklepNet_MVC.Data;

namespace SklepNet_MVC.Controllers
{
    public class AktualnosciController : Controller
    {
        private readonly SklepNetDBContext _context;

        public AktualnosciController(SklepNetDBContext context)
          => _context = context;

        public IActionResult Index()
        {
            var data = _context.Aktualnosci.ToList();
            return View();
        }
    }
}
