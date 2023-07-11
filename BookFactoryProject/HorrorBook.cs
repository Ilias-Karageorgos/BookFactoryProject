using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookFactoryProject
{
    internal class HorrorBook : Book
    {
        public HorrorBook(string title, int pages, BookColor color) : base(title, pages, color)
        {
        }
    }
}
