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
                context.Pages.Add(new Entity.Page { Title = "Home", Content = "Home Content", IsActive = true });
                context.Pages.Add(new Entity.Page { Title = "About", Content = "About Content", IsActive = true });
                context.Pages.Add(new Entity.Page { Title = "Services", Content = "Services Content", IsActive = true });
                context.Pages.Add(new Entity.Page { Title = "Department", Content = "Department Content", IsActive = true });
                context.Pages.Add(new Entity.Page { Title = "Doctors", Content = "Doctors Content", IsActive = true });
                context.Pages.Add(new Entity.Page { Title = "Blog", Content = "Blog Content", IsActive = true });
                context.Pages.Add(new Entity.Page { Title = "Contact", Content = "Contact Content", IsActive = true });
                                
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
            if (!context.Categories.Any())
            {
                context.Categories.Add(new Entity.Category { Name = "Opthomology", Description = "topbar location"});
                context.Categories.Add(new Entity.Category { Name = "Cardiology", Description = "topbar location"});
                context.Categories.Add(new Entity.Category { Name = "Dental Care", Description = "topbar location"});
                context.Categories.Add(new Entity.Category { Name = "Child Care", Description = "topbar location"});
                context.Categories.Add(new Entity.Category { Name = "Pulmology", Description = "topbar location"});
                context.Categories.Add(new Entity.Category { Name = "Gynecology", Description = "topbar location"});
                

            }
            if (!context.Sliders.Any())
            {
                context.Sliders.Add(new Entity.Slider { Title = "1Total Health care solution", H1Text = "1Your most trusted health partner", Description = "1A repudiandae ipsam labore ipsa voluptatum quidem quae laudantium quisquam aperiam maiores sunt fugit, deserunt rem suscipit placeat." , Image = "/template/images/bg/slider-bg-1.jpg" });

            }

            context.SaveChanges();
        }
    }
}
