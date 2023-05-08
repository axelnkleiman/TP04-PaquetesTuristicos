using Microsoft.AspNetCore.Mvc;

namespace PaquetesTuristicos.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
