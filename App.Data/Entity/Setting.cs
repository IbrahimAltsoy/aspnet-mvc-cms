using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Data.Entity
{
    public class Setting
    {
        public int Id { get; set; }


        [Required(ErrorMessage = "{0} This field is required!"), Column(TypeName = "NVARCHAR(200)")]
        public string Name { get; set; }


        [Required(ErrorMessage = "{0} This field is required!"), Column(TypeName = "NVARCHAR(400)")]
        public string Value { get; set; }
        public int? UserId { get; set; }
        public User? User { get; set; }
    }
}
