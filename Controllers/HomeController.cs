using Brute_Force.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Brute_Force.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View("Index", new CrackMe() { });
        }
        [HttpPost]
        public IActionResult Index(CrackMe cM)
        {
            return View("Index",cM.StartMe(cM));
        }


    }
}
