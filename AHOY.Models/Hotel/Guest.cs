using AHOY.Models.Hotel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHOY.Models.Hotel
{
    public class Guest
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int IdType { get; set; }
        public string IdNumber { get; set; }
    }
}
