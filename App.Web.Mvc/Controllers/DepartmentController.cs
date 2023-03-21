using App.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
            var model = await Db.Categories.ToListAsync();
            return View(model);
        }

    }
}
