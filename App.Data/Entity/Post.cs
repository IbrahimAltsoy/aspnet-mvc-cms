using System.ComponentModel.DataAnnotations;

namespace App.Data.Entity
{
    public class Post
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        [Required]
        public string Title { get; set; }
        public string Content { get; set; }
        public bool IsActive { get; set; }
    }
}
