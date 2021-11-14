using Library.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.ConsoleApp
{
    internal class BooksService
    {
        public void AddBook()
        {
            Book book = new Book();
            Console.Write("\n\n\n \tPodaj danne książki:");
            Console.WriteLine("Tytul");
            book.Title = Console.ReadLine();
            Console.WriteLine("Autor");
            book.Author = Console.ReadLine();
            Console.WriteLine("Rok publikacji");
            book.PublicationYear = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ISBN");
            book.ISBN = Console.ReadLine();
            Console.WriteLine("Ilosc magazynowa");
            book.ProductAvailable = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Cena");
            book.Price = Convert.ToDecimal(Console.ReadLine());
        }

        public void RemoveBook()
        {
            string bookToRemove = "";
            Console.WriteLine("Podaj tytul ksiazki do usuniecia:");
            bookToRemove = Console.ReadLine();
        }

        public void ListBooks()
        {
            Console.WriteLine("Tutaj pojawi sie lista ksiazek");

        }

        public void ChangeState()
        {
            string title;
            int state;
            Console.WriteLine("Podaj tytul ksiazki ktorej chcesz zmienic stan (ile dodac/odjac od obecnego stanu)");
            title = Console.ReadLine();
            Console.WriteLine("Podaj o ile zmienic stan magazynowy");
            state = Convert.ToInt32(Console.ReadLine());

        }
    }
}
