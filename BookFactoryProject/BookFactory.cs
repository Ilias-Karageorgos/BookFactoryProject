using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BookFactoryProject
{
    internal class BookFactory
    {
        public int BookQuantity { get; set; }
        public List<Book> BookList { get; set; }
        public List<Customer> CustomerList { get; set; }

        public BookFactory()
        {
            BookList = new List<Book>();
            CustomerList = new List<Customer>();
        }

        public void CreateBook(Book book)
        {
            BookList.Add(book);
        }
        public void RemoveBook(Book book)
        {
            BookList.Remove(book);
            Console.WriteLine($"Book: {book.Title} is now out of stock");
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Current number of Books: {BookList.Count}\nSpecifically:\n");
            foreach (var book in BookList)
            {
                Console.WriteLine($"Title: {book.Title} \t No of pages: {book.Pages}\tColor: {book.Color}");
                Console.WriteLine(book.GetType().Name);
            }
        }
        public void ShowBooksByColor(BookColor color)
        {           
                var filteredBookColors = BookList.Where(x => x.Color == color);

                Console.WriteLine("count apo ta vivlia me to sugkekrimeno xroma");
                Console.WriteLine(filteredBookColors.Count()); //2
                Console.WriteLine("\n");

                foreach (var givenbookcolor in filteredBookColors)
                {
                    Console.WriteLine($"Color: {color} \t|\tTitle: {givenbookcolor.Title}");
                }            
        }

        //public void ShowBooksByType((HorrorBook,ComedyBook)Book )
        //{
        //    foreach (var Book in BookList)
        //    {
        //        var filteredBookTypes =BookList.Where(x => x.GetType() == );

        //        foreach (var item in filteredBookTypes)
        //        {
        //            Console.WriteLine(item.Title);
        //        }

        //    }
        //}
    }
}

