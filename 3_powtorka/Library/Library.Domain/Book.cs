﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Domain
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int PublicationYear { get; set; }
        public string ISBN { get; set; }

        public int ProductAvailable { get; set; }
        public decimal Price { get; set; }

        public Book() { }

        public Book(string title, string author, int publicationYear, string isbn, int productsAvailable, decimal price) 
        {
            Title = title;
            Author = author;
            PublicationYear = publicationYear;
            ISBN = isbn;
            ProductAvailable = productsAvailable;
            Price = price;
        }

        public override string ToString()
        {
            return $"Title: {Title} Author: {Author} ProductsAvailable: {ProductAvailable}";
        }
    }
}