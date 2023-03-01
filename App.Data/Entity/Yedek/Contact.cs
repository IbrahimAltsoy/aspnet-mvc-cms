using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.Entity.Yedek
{
    public class Contact
    {
        public int Id { get; set; }

        public DateTime AppoinmentTime { get; set; }
        public string Hours { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Message { get; set; }

        //public int ServicesId { get; set; }
        //public Services Services { get; set; }
        //public int DoctorId { get; set; }
        //public Doctor Doctor { get; set; }

    }
}
