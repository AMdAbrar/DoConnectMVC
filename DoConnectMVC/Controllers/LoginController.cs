using DoConnectMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DoConnectMVC.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            Login login = new Login();
          
            return View();
        }
    }
}
