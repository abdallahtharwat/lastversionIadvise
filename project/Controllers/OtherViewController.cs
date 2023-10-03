using Microsoft.AspNetCore.Mvc;

namespace project.Controllers
{
    public class OtherViewController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }



        public IActionResult  FAQ()
        {
            return View();
        }



    }
}
