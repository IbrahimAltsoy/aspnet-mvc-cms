using App.Data;
using App.Data.Entity;
using Microsoft.AspNetCore.Mvc;

namespace App.Web.Mvc.Controllers
{
    public class DepartmentController : Controller
    {
        public DepartmentController(AppDbContext db)
        {
            Db = db;
        }

        public AppDbContext Db { get; }
        public async Task<IActionResult> Departments()
        {
            //var model = await Db.Categories
            return View();
        }
    }
}
