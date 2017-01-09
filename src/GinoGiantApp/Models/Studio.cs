using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GinoGiantApp.Models
{
    public class Studio
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public  string Address { get; set; }
        public decimal Price { get; set; }
    }
}
