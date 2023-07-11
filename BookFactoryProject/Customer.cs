using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookFactoryProject
{
    internal class Customer
    {
        public string Firstname { get; set; }
        public int Age { get; set; }
        public List<Book> CustomerBookList = new List<Book>();

        public Customer(string firstname, int age)
        {
            Firstname = firstname;
            Age = age;
        }

        public void BuyBooks(Book book)
        {
            CustomerBookList.Add(book);            
            Console.WriteLine($"Customer {Firstname} buyed {CustomerBookList.Count} book(s) :");

            foreach (var b in CustomerBookList)
            {
                Console.WriteLine(b.Title);
            }
            
        }
    }
}
