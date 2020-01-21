using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ProvidersListApp.Controllers
{
    public class CompanysController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}