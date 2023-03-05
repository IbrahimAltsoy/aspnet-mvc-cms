using Microsoft.Extensions.DependencyInjection;

namespace App.Data
{
    public class DbSeeder
    {
        public static void Seed(IServiceProvider serviceProvider)
        {
            var context = serviceProvider.GetRequiredService<AppDbContext>();

            if (!context.Settings.Any())
            {
                context.Settings.Add(new Entity.Setting { Name = "Adres", Value = "Ankara" });
               
            }

            if (!context.Pages.Any())
            {
                context.Pages.Add(new Entity.Page { Title = "About", Content = "About Content", IsActive = true });

                for (int i = 1; i <= 10; i++)
                {
                    context.Pages.Add(new Entity.Page { Title = "Page " + i, Content = "Content " + i, IsActive = true });
                }
            }

            if (!context.Posts.Any())
            {
                context.Posts.Add(new Entity.Post { Title = "Post Varsayılan", Content = "Post Content", IsActive = true });

                for (int i = 1; i <= 10; i++)
                {
                    context.Posts.Add(new Entity.Post { Title = "Post " + i, Content = "Content " + i, IsActive = true });
                }
            }
            if (!context.Topbars.Any())
            {
                context.Topbars.Add(new Entity.Topbar { Email = "topbar@gmail.com", Location = "topbar location", Phone = "55555555" });

            }
            if (!context.Sliders.Any())
            {
                context.Sliders.Add(new Entity.Slider { Title = "1Total Health care solution", H1Text = "1Your most trusted health partner", Description = "1A repudiandae ipsam labore ipsa voluptatum quidem quae laudantium quisquam aperiam maiores sunt fugit, deserunt rem suscipit placeat." , Image = "/template/images/bg/slider-bg-1.jpg" });

            }

            context.SaveChanges();
        }
    }
}
