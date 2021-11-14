using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Domain
{
    public class Order
    {
        public DateTime Date { get; set; }
        public List<BookOrdered> BooksOrderedList { get; set; }
        public Order()
        {
            Date = DateTime.Now;
            BooksOrderedList = new List<BookOrdered>();

          
        }
        public override string ToString()
        {
            string str = $"\n\nOrder: {Date}";
            foreach(BookOrdered book in BooksOrderedList)
            {
                str += $"\nBook: {book.BookId} Count: {book.NumberOrdered}";
            }

            return str;
        }
    }
}
