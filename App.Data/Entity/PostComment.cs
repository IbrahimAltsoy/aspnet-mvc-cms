using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Data.Entity
{
    public class PostComment
    {
        public int Id { get; set; }
        public int PostId { get; set; }

        public int UserId { get; set; }
        [Required(ErrorMessage = "{0} can not be blankz!"), StringLength(250), Display(Name = "Comment"), Column(TypeName = "VARCHAR(250)")]
        public string Comment { get; set; }

        public bool IsActive { get; set; }


        public User User { get; set; }
        public Post Post { get; set; }
    }
}

