using Microsoft.AspNetCore.Mvc;

namespace BookRegistrationMVC.Controllers
{
    public class BookRegistrationController : Controller
    {
        [HttpGet]
        public IActionResult Book_Registration()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Book_Registration(BookRegistration r)
        {
            if (ModelState.IsValid)
            {
                // Add to database
                // BookRegistration.Add(p);

                // Return a view
                return RedirectToAction("Index", "Home");
            }

            // If the Model State is not valid show the user the same web page,
            // with validation errors
            return View(r);
        }
    }
}
