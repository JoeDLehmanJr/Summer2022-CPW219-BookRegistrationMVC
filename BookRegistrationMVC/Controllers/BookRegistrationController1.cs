using Microsoft.AspNetCore.Mvc;

namespace BookRegistrationMVC.Controllers
{
    public class BookRegistrationController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
