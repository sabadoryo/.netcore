using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    
    [Route("[controller]/[action]")]
    public class GradeBookController : Controller
    {
        Dictionary<string, int> students =
    new Dictionary<string, int>();

        [HttpGet]
        public IActionResult Index()
        {
            students.Add("Yernar Abilbay", 100);
            students.Add("Orazalinov Askhat", 100);
            students.Add("Fazylzhan Zheten", 100);
            ViewData["Students"] = students;
            
            return View("Index");
        }

        [HttpPost]
        public IActionResult setMark(string s_name, int new_mark)
        {
            students.Add("Yernar Abilbay", 100);
            students.Add("Orazalinov Askhat", 100);
            students.Add("Fazylzhan Zheten", 100);
            students[s_name] = new_mark;

            ViewData["Students"] = students;
            return RedirectToPage("Index", students);
        }
    }   
}