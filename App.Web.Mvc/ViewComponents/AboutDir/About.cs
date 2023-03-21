using App.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace App.Web.Mvc.ViewComponents.AboutDir
{
    public class About : ViewComponent
    {
        private readonly AppDbContext _appDbContext;

        public About(AppDbContext appDbContext)
        {
            this._appDbContext = appDbContext;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var model = await _appDbContext.Partners.ToListAsync();

            return View(model);
        }
    }
}
