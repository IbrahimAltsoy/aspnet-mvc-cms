﻿using System;
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

        [Required(ErrorMessage = "{0} can not be blank!"), Column(TypeName = "VARCHAR(200)")]
        public string Email { get; set; }


        [Required(ErrorMessage = "{0} can not be blank!"), Column(TypeName = "NVARCHAR(100)")]
        public string Password { get; set; }


        [Required(ErrorMessage = "{0} can not be blank!"), Column(TypeName = "NVARCHAR(100)")]
        public string Name { get; set; }


        [Required(ErrorMessage = "{0} can not be blank!"), Column(TypeName = "NVARCHAR(100)")]
        public string City { get; set; }


        [Required(ErrorMessage = "{0} can not be blank!"), Column(TypeName = "VARCHAR(20)")]
        public string Phone { get; set; }


        [Required(ErrorMessage = "{0} can not be blank!"), Column(TypeName ="VARCHAR(200)")]
        public string PhotoFile { get; set; }

        public bool IsAdmin { get; set; }
    }
}
