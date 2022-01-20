using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library_of_Technology.Models
{
    public class Books
    {

        public int Id { get; set; }

        public string Title{ get; set; }

        public string Author { get; set; }

        public int Rating { get; set; }

        public string ISBN { get; set; }

        public string Image { get; set; }

        public double Cost { get; set; }

        public string Published { get; set; }
    }
}
