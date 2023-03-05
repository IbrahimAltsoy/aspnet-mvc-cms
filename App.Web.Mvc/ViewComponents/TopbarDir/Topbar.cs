using App.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace App.Web.Mvc.ViewComponents.TopbarDir
{
    public class Topbar:ViewComponent
    {
        private readonly AppDbContext _context;

        public Topbar(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var model = _context.Topbars.FirstOrDefault(x=>x.Id==1);
            return View(model);
        }
    }
}
