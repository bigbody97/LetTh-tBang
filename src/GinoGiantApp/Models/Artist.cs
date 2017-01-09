using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GinoGiantApp.Models
{
    public class Artist
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Location { get; set; }
        public string Genre { get; set; }
    }
}
