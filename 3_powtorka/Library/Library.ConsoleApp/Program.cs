using System;
using Library.Domain;
using Library.Persistence;

namespace Library.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Czysty kod", "Robert C. Martin", 2014, "978-83-283-0234-1", 3, (decimal)52.55);
            BooksRepository repository = new BooksRepository();

            Console.WriteLine("Login: ");
            string login = Console.ReadLine();
            Console.WriteLine("Hasło: ");
            string password = Console.ReadLine();

            if(login == "Admin" && password == "password")
            {
                Console.Clear();
                Console.WriteLine("Access Granted");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Access Denied");
                Environment.Exit(0);
            }
            OrderRepository orderRepository = new OrderRepository();
            OrderService orderService = new OrderService(orderRepository);
            BooksService bookService = new BooksService(repository);
            string command = "";
            do
            {
                
                Console.Write("\n\tLISTA KOMEND:\n\r- dodaj\n\r- usun\n\r- wypisz\n\r- zmien\n\r- dodaj zamowienie\n\r- lista zamowien\n- wyjdz\n\n\r#>");
                command = Console.ReadLine();
                switch(command)
                {
                    case "dodaj":
                        bookService.AddBook();
                        Console.WriteLine("Press AnyKey...");
                        Console.ReadKey();
                        break;
                    case "usun":
                        bookService.RemoveBook();
                        Console.WriteLine("Press AnyKey...");
                        Console.ReadKey();
                        break;
                    case "wypisz":
                        bookService.ListBooks();
                        Console.WriteLine("Press AnyKey...");
                        Console.ReadKey();
                        break;
                    case "zmien":
                        bookService.ChangeState();
                        Console.WriteLine("Press AnyKey...");
                        Console.ReadKey();
                        break;
                    case "dodaj zamowienie":
                        Console.WriteLine("Proba dodania nowego zamowienia");
                        orderService.PlaceOrder();
                        Console.WriteLine("Press AnyKey...");
                        Console.ReadKey();
                        break;
                    case "lista zamowien":
                        Console.WriteLine("\nProba wypisania wszystkich zamowien\n\n");
                        orderService.ListAll();
                        Console.WriteLine("Press AnyKey...");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("\r\n\r\r\nKomenda nie wspierana");
                        break;
                }
                Console.Clear();
            } while (command != "wyjdz");
        }
    }
}
