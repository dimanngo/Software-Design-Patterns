using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProxyPattern.Entities;
using ProxyPattern.Proxy;

namespace ProxyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ProxyOrderRepository repository = new ProxyOrderRepository();

            Order order = repository.GetOrder(1);

            Console.WriteLine("Order Id: {0}",order.Id );
            Console.WriteLine("Date: {0}", order.OrderDate);
            Console.WriteLine("Customer: {0}, {1}", order.Customer.LastName, order.Customer.FirstName);
            Console.WriteLine("# of items: {0}",order.Details.Count());
        }
    }
}
