using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Data.Entity
{
    public class Navbar
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "{0}This field is required!"), Display(Name = "Category"), Column(TypeName = "NVARCHAR(20)")]
        public string Category { get; set; }

    }
}
