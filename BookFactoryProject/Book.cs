using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BookFactoryProject
{
    internal class Book
    {      
        public BookColor Color { get; set; }
        public string Title { get; set; }
        public int Pages { get; set; }
        public BookFactory BookFactory { get; set; }

        public Book(string title, int pages, BookColor color)
        {
            Title = title;
            Pages = pages;
            Color = color;
        }
    }
    enum BookColor
    {
        Black,
        White,
        Red
    }
}
