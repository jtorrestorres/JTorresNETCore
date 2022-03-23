using Microsoft.AspNetCore.Mvc;

namespace PL.Controllers
{
    public class Materia : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
