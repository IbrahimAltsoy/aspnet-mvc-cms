using App.Data;
using Microsoft.AspNetCore.Mvc;

namespace App.Web.Mvc.Controllers
{
    public class PageController : Controller
    {
        public PageController(AppDbContext db)
        {
            Db = db;
        }

        public AppDbContext Db { get; }

        public IActionResult Detail(int id)
        {
            var page = Db.Pages.FirstOrDefault(x => x.Id == id);    
            return View(page);
        }
    }
}
