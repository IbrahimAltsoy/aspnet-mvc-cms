using App.Data;
using App.Data.Entity;
using Microsoft.AspNetCore.Mvc;

namespace App.Web.Mvc.Controllers
{
    public class PostController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public PostController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IActionResult Search(string query, int page)
        {
            return View();
        }
        public IActionResult Detail(int id)
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SendContactForm(Contact model)
        {
            await _appDbContext.Contacts.AddAsync(model);
            await _appDbContext.SaveChangesAsync();
            return Redirect("/Page/Detail/7");
        }
    }
}
