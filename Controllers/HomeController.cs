using Microsoft.AspNetCore.Mvc;

namespace bringYourEasel.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

    }
}
