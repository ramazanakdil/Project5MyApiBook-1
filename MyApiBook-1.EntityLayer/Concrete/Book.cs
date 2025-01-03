using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApiBook_1.EntityLayer.Concrete
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Stok { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }

        public int WriterId { get; set; }
        public Writer Writer { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
