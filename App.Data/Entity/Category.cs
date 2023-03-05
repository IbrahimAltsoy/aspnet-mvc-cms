using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.Entity
{
	public class Category
    {
		public int Id { get; set; }
        [Required(ErrorMessage = "{0} alanı boş geçilemez!"), StringLength(30), Display(Name = "Name")]
        public string Name { get; set; }
		public string Description { get; set; }
	}
}
