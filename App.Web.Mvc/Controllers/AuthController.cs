using Microsoft.AspNetCore.Mvc;

namespace App.Web.Mvc.Controllers
{
    public class AuthController : Controller
    {

        public IActionResult Register()
        {
            return View();
        }
        public IActionResult Login(string requestUrl)
        {

            return View();
        }
        public IActionResult ForgotPassword()
        {
            return View();
        }
    }
}
