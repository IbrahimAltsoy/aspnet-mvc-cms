using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Data.Entity
{
    public class PostComment
    {
        public int Id { get; set; }



        [Required(ErrorMessage = "{0} This field is required!"), Display(Name = "Comment"), Column(TypeName = "TEXT")]
        public string Comment { get; set; }

        public bool IsActive { get; set; }

        public int? UserId { get; set; }
        public User? User { get; set; }
        public int? PostId { get; set; }
        public Post? Post { get; set; }
    }
}

