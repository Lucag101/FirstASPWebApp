using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstASPWebApp.Models;

namespace FirstASPWebApp.Controllers
{
    public class CalcController : Controller
    {
        public IActionResult Index()
        {
            // throw new IndexOutOfRangeException();      
            return View();
        }

        [HttpGet]
        public IActionResult Calculator()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Calculator( CalculatorModel model)
        {
            return View();
        }
    }
}
