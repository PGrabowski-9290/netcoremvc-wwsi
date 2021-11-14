using Library.Domain;
using Library.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.ConsoleApp
{
    public class BooksService
    {
        private BooksRepository _repository;
        public BooksService(BooksRepository booksRepository)
        {
            _repository = booksRepository;
        }
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
            book.Price = Convert.ToDecimal(Console.ReadLine().Replace('.',','));
            
            _repository.Insert(book);
        }

        public void RemoveBook()
        {
            string bookToRemove = "";
            Console.WriteLine("Podaj tytul ksiazki do usuniecia:");
            bookToRemove = Console.ReadLine();
            _repository.RemoveByTitle(bookToRemove);
        }

        public void ListBooks()
        {
            Console.WriteLine("\nLista ksiazek\n");
            var repo = _repository.GetAll();
            foreach (var book in repo)
            {
                Console.WriteLine(book.ToString());
            }
        }

        public void ChangeState()
        {
            string title;
            int state;
            Console.WriteLine("Podaj tytul ksiazki ktorej chcesz zmienic stan (ile dodac/odjac od obecnego stanu)");
            title = Console.ReadLine();
            Console.WriteLine("Podaj o ile zmienic stan magazynowy");
            state = Convert.ToInt32(Console.ReadLine());
            _repository.ChangeState(title, state);
        }
    }
}
