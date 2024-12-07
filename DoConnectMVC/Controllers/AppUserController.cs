using Microsoft.AspNetCore.Mvc;

namespace DoConnectMVC.Controllers
{
    public class AppUserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
