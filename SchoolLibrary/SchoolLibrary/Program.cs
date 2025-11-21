using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLibrary
{
    internal class Program
    {
        // Commento Bello
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Library!");
            Console.WriteLine("What would you like to do today?");
            char choice;
            do
            {
                Console.WriteLine("1. View Books");
                Console.WriteLine("2. Add Book");
                Console.WriteLine("3. Search Book By Title");
                Console.WriteLine("4. Search Book By Author");
                Console.WriteLine("5. Exit");
                choice = Console.ReadKey().KeyChar;
                Console.WriteLine();
                switch (choice)
                {
                    case '1':
                        Console.WriteLine("Viewing Books...");
                        break;
                    case '2':
                        Console.WriteLine("Adding a Book...");
                        break;
                    case '3':
                        Console.WriteLine("Searching Book By Title...");
                        break;
                    case '4':
                        Console.WriteLine("Searching Book By Author...");
                        
                        break;
                    case '5':
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }
            } while (choice != '5');
        }
    }
}
