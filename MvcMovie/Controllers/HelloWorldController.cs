using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    // HelloWorldController
    public class HelloWorldController : Controller
    {
        //GET: /HelloWorld/
        //public string Index()
        public IActionResult Index()
        {
            //return "This is my default action...";
            return View();
        }

        //GET: /HelloWorld/Welcome?name=&numTimes=
        // Requires using Sytem.Text.Encodings.Web
        //public string Welcome(string name, int numTimes = 1)
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            //return "This is the Welcome action method...";
            //return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");

            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }

        //GET: /HelloWorld/Welcome/id?name=
        // public string Welcome(string name, int ID = 1)
        // {
        //     return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        // }
    }
}