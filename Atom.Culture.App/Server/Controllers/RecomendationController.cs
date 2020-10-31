using Microsoft.AspNetCore.Mvc;

namespace Atom.Culture.App.Server.Controllers
{
    public class RecomendationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
