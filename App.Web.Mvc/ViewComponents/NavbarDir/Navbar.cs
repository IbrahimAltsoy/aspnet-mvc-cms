using App.Data;
using App.Data.Entity.Yedek;
using Microsoft.AspNetCore.Mvc;

namespace App.Web.Mvc.ViewComponents.NavbarDir
{
    public class navbar:ViewComponent
    {
        private readonly AppDbContext _appDbContext;

        public navbar(AppDbContext appDbContext)
        {
            this._appDbContext = appDbContext;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            
            return View();
        }
    }
}
