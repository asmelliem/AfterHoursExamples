using System;
using System.Collections.Generic;
using System.Text;

namespace BookStoreDAL.Models
{
    public class Author
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Country { get; set; }

        public List<Book> Books { get; set; }

    }
}
