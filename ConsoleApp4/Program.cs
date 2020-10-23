using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {

            Book book1 = new Book();
            book1.title = "Harry Poter";
            book1.author = "J.K Rowling";
            book1.pages = 400;
            Console.WriteLine(book1.title);

            Console.ReadLine();
        }       
    }
}