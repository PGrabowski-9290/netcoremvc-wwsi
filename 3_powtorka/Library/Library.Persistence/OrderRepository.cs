﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Domain;

namespace Library.Persistence
{
    public class OrderRepository
    {
        private List<Order> _database = new List<Order>();
        public void Insert(Order order)
        {
            _database.Add(order);
        }

        public List<Order> GetAll()
        {
            return _database;
        }
    }
}
