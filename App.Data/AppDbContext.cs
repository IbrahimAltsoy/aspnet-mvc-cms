using App.Data.Entity;
using Microsoft.EntityFrameworkCore;


namespace App.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Page> Pages { get; set; }
        public DbSet<Post> Posts { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<PostComment> PostComments { get; set; }
		public DbSet<PostImage> PostImages { get; set; }
		public DbSet<CategoryPost> CategoryPosts { get; set; }
        //aşağı entitiler componentsler için eklendi
        public DbSet<Navbar> Navbars { get; set; }
        public DbSet<Topbar> Topbars { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        

	}
}
