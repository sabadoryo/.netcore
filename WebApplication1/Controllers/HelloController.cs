using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            
            string[] students = { "Yernar Abilbay", "Orazalinov Askhat", "Fazylzhan Zheten" };
            ViewData["Students"] = students;
            return View("Index");
        }
    }
}