using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace App.Data.Entity
{
    public class Navbar
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "{0} can not be blank!"), Display(Name = "Category"), Column(TypeName = "NVARCHAR(20)")]
        public string Category { get; set; }

    }
}
