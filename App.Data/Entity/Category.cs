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
        [Required(ErrorMessage = "{0} can not be blank!"), StringLength(30), Display(Name = "Name"), Column(TypeName = "VARCHAR(30)")]
        public string Name { get; set; }
        [Required(ErrorMessage = "{0} can not be blank!"), StringLength(500), Display(Name = "Description"), Column(TypeName = "VARCHAR(500)")]
        public string Description { get; set; }
	}
}
