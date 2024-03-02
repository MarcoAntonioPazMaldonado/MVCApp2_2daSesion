using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;



namespace MVCApp2.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }



        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;
            return View();
        }



        //Get: /helloWorld
        //public string Index()
        //{
        //    return "Esta es mi accion default";
        //}

        //Get: /helloWorld/Welcome
        //requiere de using System.text.Encoding.Web
        //Get: /helloWorld/Welcome?name=Marco&numTimes=5
        //public string Welcome(string name, int numTimes = 1)
        //{
        //    // return "metodo accion welcome";
        //    return HtmlEncoder.Default.Encode($"Hello {name}, Numtimes is: {numTimes}");

        //}
    }
}

