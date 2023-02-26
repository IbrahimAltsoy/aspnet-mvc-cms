using Microsoft.AspNetCore.Mvc;

namespace App.Web.Mvc.Controllers
{
    public class ErrorPageController : Controller
    {
        public IActionResult ErrorNumber(int id)
        {
            return View();
        }
    }
}
