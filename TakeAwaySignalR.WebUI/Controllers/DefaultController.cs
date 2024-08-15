using Microsoft.AspNetCore.Mvc;

namespace TakeAwaySignalR.WebUI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult DeliveryList()
        {
            return View();
        }
    }
}
