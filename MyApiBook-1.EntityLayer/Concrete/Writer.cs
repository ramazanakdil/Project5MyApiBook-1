using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApiBook_1.EntityLayer.Concrete
{
    public class Writer
    {
        public int WriterId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Detail { get; set; }
        public string ImageUrl { get; set; }

        public ICollection<Book>? Books { get; set; }
    }
}
