using App.Data;
using Microsoft.AspNetCore.Mvc;

namespace App.Web.Mvc.ViewComponents.SliderDir
{
    public class Slider : ViewComponent
    {
        private readonly AppDbContext _context;

        public Slider(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var model = _context.Sliders.FirstOrDefault(x => x.Id == 1);
            int a = 5;
            return View(model);
        }
    }
}
