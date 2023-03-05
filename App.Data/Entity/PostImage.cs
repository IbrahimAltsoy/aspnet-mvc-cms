using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.Entity
{
	public class PostImage
	{
		public int Id { get; set; }
		public int PostId { get; set; }
		public string ImagePath { get; set; }

		public Post Post { get; set; }
	}
}
