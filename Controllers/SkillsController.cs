using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace _10._6._Studio_SkillsTracker.Controllers
{
    public class SkillsController : Controller
    {
        // GET: /<controller>/
        [HttpGet]
        [HttpPost("/skills/form")]
        [Route("/skills")]
        public IActionResult Index(string date, string cSelect, string javaSelect, string javascriptSelect)
        {
            string html = "<h1>Skills Tracker:  " + date + "</h1>" +
                "<h2>Coding Skills to Learn</h2>" +
                "<h3>" +
                "<ol>1.  C#:          " + cSelect + "</ol>" +
                "<ol>2.  Java:        " + javaSelect + "</ol>" +
                "<ol>3.  JavaScript:  " + javascriptSelect + "</ol>" +
                "</h3>";
            return Content(html, "text/html");
        }
        // GET: /skills/form
        [HttpGet]
        //[HttpPost("/skills/form")]
        public IActionResult Form()
        {
            string html = "<form method='post' action='/skills/form'>" +
                    "<label>" +
                        "Date:" +
                        "<input type='date' name ='date'>" +
                    "</label>" +
                    "<br>" +
                    "<label>" +
                        "C#:" +
                    "</label>" +
                    "<br>" +
                    "<select name= 'cSelect'>" +
                        "<option value='Learning The Basics'>Learning The Basics</option>" +
                        "<option value='Creating Apps'>Creating Apps</option>" +
                        "<option value='Master Coder'>Master Coder</option>" +
                    "</select>" +
                    "<br>" +
                    "<label>" +
                    "Java:" +
                    "</label>" +
                    "<br>" +
                    "<select name= 'javaSelect'>" +
                        "<option value='Learning The Basics'>Learning The Basics</option>" +
                        "<option value='Creating Apps'>Creating Apps</option>" +
                        "<option value='Master Coder'>Master Coder</option>" +
                    "</select>" +
                    "<br>" +
                    "<label>" +
                    "JavaScript:" +
                    "</label>" +
                    "<br>" +
                    "<select name= 'javascriptSelect'>" +
                        "<option value='Learning The Basics'>Learning The Basics</option>" +
                        "<option value='Creating Apps'>Creating Apps</option>" +
                        "<option value='Master Coder'>Master Coder</option>" +
                    "</select>" +
                    "<br>" +
                    "<input type='submit' value='Submit' />" + 
                   "</form>";
            return Content(html, "text/html"); 
        }
    }
}
