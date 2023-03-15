using App.Data;
using App.Data.Entity.Yedek;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace App.Web.Mvc.ViewComponents.NavbarDir
{
    public class Navbar:ViewComponent
    {
        private readonly AppDbContext _appDbContext;

        public Navbar(AppDbContext appDbContext)
        {
            this._appDbContext = appDbContext;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var model = await _appDbContext.Pages.ToListAsync();
            
            return View(model);
        }
    }
}
