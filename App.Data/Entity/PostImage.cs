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
	public class PostImage
	{
		public int Id { get; set; }
		
        [Required(ErrorMessage = "{0} This field is required!"), Display(Name = "Image"), Column(TypeName = "NVARCHAR(200)")]
        public string ImagePath { get; set; }
        public int? PostId { get; set; }
        public Post? Post { get; set; }
	}
}
