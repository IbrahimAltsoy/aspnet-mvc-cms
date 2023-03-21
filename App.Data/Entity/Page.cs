﻿using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace App.Data.Entity
{
    public class Page
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} This field is required!"), Column(TypeName = "NVARCHAR(200)")]
        public string Title { get; set; }
        public string Content { get; set; }
        public bool IsActive { get; set; } // Burçin
                                           // hdhjkhdfj cfghjklgh ghjklhghj sgffjgk




    }
}
