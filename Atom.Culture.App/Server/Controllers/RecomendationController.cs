using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
