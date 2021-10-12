using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Razor_Hundo.Controllers
{
    public class HundoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}