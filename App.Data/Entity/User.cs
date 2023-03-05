using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.Entity
{
    public class User
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} can not be blank!"), Column(TypeName = "VARCHAR(50)")]
        public string Email { get; set; }


        [Required(ErrorMessage = "{0} can not be blank!"), Column(TypeName = "VARCHAR(16)")]
        public string Password { get; set; }


        [Required(ErrorMessage = "{0} can not be blank!"), Column(TypeName = "VARCHAR(40)")]
        public string Name { get; set; }


        [Required(ErrorMessage = "{0} can not be blank!"), Column(TypeName = "VARCHAR(30)")]
        public string City { get; set; }


        [Required(ErrorMessage = "{0} can not be blank!"), Column(TypeName = "VARCHAR(16)")]
        public string Phone { get; set; }


        [Required(ErrorMessage = "{0} can not be blank!"), Column(TypeName ="VARCHAR(80)")]
        public string PhotoFile { get; set; }

        public bool IsAdmin { get; set; }
    }
}
