using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Data.Entity
{
    public class Post
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} This field is required!"), Column(TypeName = "NVARCHAR(200)")]
        public string Title { get; set; }
        public string Content { get; set; }
        public bool IsActive { get; set; }

        public int? UserId { get; set; }
        public User? User { get; set; }

    }
}
