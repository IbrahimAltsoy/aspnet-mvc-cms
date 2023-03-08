using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace App.Data.Entity
{
    public class Topbar
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "{0} This field is required!"), Display(Name = "Email"), Column(TypeName = "NVARCHAR(100)")]
        public string Email { get; set; }

        [Required(ErrorMessage = "{0} This field is required!"), Display(Name = "Location"), Column(TypeName = "NVARCHAR(250)")]
        public string Location { get; set; }

        [Required(ErrorMessage = "{0} This field is required!"), Display(Name = "Phone"), Column(TypeName = "NVARCHAR(16)")]
        public string Phone { get; set; }
        [Display(Name = "Image"), Column(TypeName = "NVARCHAR(300)")]
        public string? Image { get; set; }
        //
    }
}
