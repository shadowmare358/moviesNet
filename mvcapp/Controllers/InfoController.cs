using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace mvcapp.Controllers
{
    public class InfoController : Controller
    {
        public string Info()
        {
            return "Info from info controller";
        }
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}