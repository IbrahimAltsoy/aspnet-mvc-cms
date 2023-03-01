using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.Entitiy
{
    public class DoctorEducation
    {
        public int Id { get; set; }
        public Doctor Doctor { get; set; }
        public int DoctorId { get; set; }
        public string Year { get; set; }  
        public string School { get; set; }
        public string Detail { get;}
    }
}
