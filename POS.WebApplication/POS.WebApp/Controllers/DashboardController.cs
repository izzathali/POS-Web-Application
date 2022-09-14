using Microsoft.AspNetCore.Mvc;

namespace POS.WebApp.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
