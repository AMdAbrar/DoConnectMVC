using DoConnectMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DoConnectMVC.Controllers
{
    public class RegisterController : Controller
    {
        public static List<Register> registerList = new List<Register>();
        public IActionResult Index()
        {
            Register register = new Register();
            
            return View();
        }
        [HttpPost]
        public IActionResult Index(Register register)
        {
            if (registerList.Count == 0)
            {
                register.Password = "1";
            }
            else
            {
                register.Password= registerList[registerList.Count - 1].Password + 1;
            }

            registerList.Add(register);
            return View(register);
        }
    }
}
