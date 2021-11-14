using Library.Persistence;
using Library.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.ConsoleApp
{
    public class OrderService
    {
        private OrderRepository _repository;
        public OrderService(OrderRepository orderRepository)
        {
            _repository = orderRepository;
        }

        public void PlaceOrder()
        {
            string menucmd = "";
            Console.Clear();
            Order order = new Order();
            do
            {
                Console.WriteLine("\n\tZamowienia menu:\n- add :dodaj pozycje do zamowienia \n- end :zamknij zamowienie\n\n#>");
                menucmd = Console.ReadLine();
                

                switch (menucmd)
                {
                    case "add":
                        BookOrdered bookOrdered = new BookOrdered();

                        Console.WriteLine("\n\nPodaj id ksiazki: ");
                        bookOrdered.BookId = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("\n\nPodaj ilosc: ");
                        bookOrdered.NumberOrdered = Convert.ToInt32(Console.ReadLine());

                        order.BooksOrderedList.Add(bookOrdered);         
                        
                        break;
                    case "end":
                        _repository.Insert(order);
                        break;
                    default:
                        Console.WriteLine("\n\n\nKomenda nieznana\n\n");
                        break;
                }
            } while (menucmd != "end");
        }

        public void ListAll()
        {
            foreach(Order order in _repository.GetAll())
            {
                Console.WriteLine(order.ToString());
            }
        }
    }
}
