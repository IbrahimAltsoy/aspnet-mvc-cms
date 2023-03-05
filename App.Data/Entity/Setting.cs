using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace App.Data.Entity
{
    public class Setting
    {
        public int Id { get; set; }
        public int? UserId { get; set; }

        [Required(ErrorMessage = "{0} can not be blank!"), Column(TypeName = "VARCHAR(50)")]
        public string Name { get; set; }


        [Required(ErrorMessage = "{0} can not be blank!"), Column(TypeName = "VARCHAR(10)")]
        public string Value { get; set; }

        public User User { get; set; }
    }
}
