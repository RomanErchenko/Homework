using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ5
{
    public class BooksWithImages : Book
    {
        public byte? Images { get; set; }
        public BooksWithImages(string Name, string Author) : base(Name, Author)
        {

        }
    }
}
