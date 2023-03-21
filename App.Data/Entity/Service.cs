using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.Entity
{
    public class Service
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Subject { get; set; }
        public string? Image { get; set; }
    }
}
