using App.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace App.Web.Mvc.ViewComponents.DepartmentDir
{
    public class DeparmentPage : ViewComponent
    {
        private readonly AppDbContext _appDbContext;

        public DeparmentPage(AppDbContext appDbContext)
        {
            this._appDbContext = appDbContext;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var model = await _appDbContext.Categories.ToListAsync();

            return View(model);
        }

    }
}
