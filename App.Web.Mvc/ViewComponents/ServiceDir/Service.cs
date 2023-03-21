using App.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace App.Web.Mvc.ViewComponents.ServiceDir
{
    public class Service : ViewComponent
    {
        private readonly AppDbContext _appDbContext;

        public Service(AppDbContext appDbContext)
        {
            this._appDbContext = appDbContext;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var model = await _appDbContext.Services.ToListAsync();

            return View(model);
        }
    }
}
