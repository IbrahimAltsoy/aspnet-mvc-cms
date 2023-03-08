using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace App.Data.Entity
{
    public class Slider
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "{0}This field is required!"), StringLength(50), Display(Name = "Başlık")]
        public string Title { get; set; }

        [Required(ErrorMessage = "{0} This field is required!"), StringLength(50), Display(Name = "H1 Başlık")]
        public string H1Text { get; set; }

        [StringLength(1000), Display(Name = "Açıklama")]
        public string? Description { get; set; }

        [Required(ErrorMessage = "{0} This field is required!"), StringLength(250), Display(Name = "Resim")]
        public string? Image { get; set; }

        [Required(ErrorMessage = "{0} This field is required!")]
        public bool IsActive { get; set; } = false;


    }

}
