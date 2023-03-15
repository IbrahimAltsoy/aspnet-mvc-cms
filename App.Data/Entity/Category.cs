using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace App.Data.Entity
{
    public class Category
    {
		public int Id { get; set; }
        [Required(ErrorMessage = "{0} This field is required!"), Display(Name = "Name"), Column(TypeName = "NVARCHAR(100)")]
        public string Name { get; set; }
        [Required(ErrorMessage = "{0} This field is required!"), Display(Name = "Description"), Column(TypeName = "NVARCHAR(200)")]
        public string Description { get; set; }
	}//branch denemesi
}
