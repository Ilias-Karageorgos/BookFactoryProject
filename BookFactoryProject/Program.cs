using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BookFactoryProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Synthetic Data

            BookFactory factory1 = new BookFactory();

            Book b1 = new HorrorBook("The Shining", 550, BookColor.Black);
            Book b2 = new HorrorBook("Conjuring", 654, BookColor.White);
            Book b3 = new HorrorBook("Anabelle", 354, BookColor.Black);
            Book b4 = new ComedyBook("Thank Life", 96, BookColor.Red);
            Book b5 = new ComedyBook("Life is funny", 103, BookColor.White);
            Book b6 = new ComedyBook("Funny is Thank", 757, BookColor.Red);

            Customer c1 = new Customer("Labros", 32);
            Customer c2 = new Customer("Panos", 32);
            Customer c3 = new Customer("Ilias", 29);
            Customer c4 = new Customer("Giorgos", 33);

            // Populate

            factory1.CreateBook(b1);
            factory1.CreateBook(b2);
            factory1.CreateBook(b3);
            factory1.CreateBook(b4);
            factory1.CreateBook(b5);
            factory1.CreateBook(b6);


            factory1.CustomerList.Add(c1);
            factory1.CustomerList.Add(c2);
            factory1.CustomerList.Add(c3);
            factory1.CustomerList.Add(c4);

            Console.WriteLine("SHOW BOOK INFO\n");


            factory1.ShowInfo();

            Console.WriteLine("------------------------------------------------------------------------\n");

            Console.WriteLine("CUSTOMER'S LIST\n");

            foreach (var customer in factory1.CustomerList)
            {
                Console.WriteLine($"Firstname: {customer.Firstname}\t Age: {customer.Age}");
            }

            Console.WriteLine("------------------------------------------------------------------------\n");

            Console.WriteLine("CUSTOMER BUYS 3 TIMES BOOK (REMOVED ALSO FROM FACTORY)\n");

            c1.BuyBooks(b1);
            factory1.RemoveBook(b1);

            Console.WriteLine("------------------------------------------------------------------------");
            c1.BuyBooks(b2);
            factory1.RemoveBook(b2);

            Console.WriteLine("------------------------------------------------------------------------");
            c1.BuyBooks(b3);
            factory1.RemoveBook(b3);
            Console.WriteLine("------------------------------------------------------------------------\n");

            Console.WriteLine("SHOW BOOKS BY COLOR\n");
            factory1.ShowBooksByColor(BookColor.Red);
            Console.WriteLine("------------------------------------------------------------------------");

            factory1.ShowBooksByType("horror");        
        }
    }
}
