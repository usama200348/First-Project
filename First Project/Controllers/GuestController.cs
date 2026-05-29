using Microsoft.AspNetCore.Mvc;


namespace First_Project.Controllers
{
    public class GuestController : Controller
    {
        public IActionResult Home()
        {
            return View();
        }
        public IActionResult AboutUs()
        {
            return View();
        }
        public IActionResult Gallery()
        {
            return View();
        }
        public IActionResult Services()
        {
            return View();
        }
        public IActionResult ContactUs()
        {
            return View();
        }
    }
}
