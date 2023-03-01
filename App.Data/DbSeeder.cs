﻿using Microsoft.Extensions.DependencyInjection;

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
                context.Settings.Add(new Entity.Setting { Name = "Telefon", Value = "03122223366" });
                context.Settings.Add(new Entity.Setting { Name = "Email", Value = "test@email.com" });
            }

            if (!context.Pages.Any())
            {
				context.Pages.Add(new Entity.Page { Title = "About", Content = "About Content", IsActive = true });

				for (int i = 1; i <= 10; i++)
                {
                    context.Pages.Add(new Entity.Page { Title = "Page " + i, Content = "Content " + i, IsActive = true });
                }
            }

            context.SaveChanges();
        }
    }
}