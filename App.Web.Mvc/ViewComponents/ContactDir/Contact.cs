using App.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace App.Web.Mvc.ViewComponents.ContactDir
{
    public class Contact: ViewComponent
    {
        private readonly AppDbContext _appDbContext;
        public Contact(AppDbContext appDbContext)
            {
                this._appDbContext = appDbContext;
            }
            public async Task<IViewComponentResult> InvokeAsync()
            {
                var model = await _appDbContext.Contacts.ToListAsync();

                return View(model);
            }
        }
}


