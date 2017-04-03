using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProxyPattern.Entities;
using ProxyPattern.SubjectBase;

namespace ProxyPattern.RealSubject
{
    public class RealOrderRepository:OrderRepositoryBase
    {
        private List<Order> _orders = new List<Order>
                                          {
                                              new Order(){Id=1, OrderDate = new DateTime(2012,7,17)},
                                              new Order(){Id=2, OrderDate = new DateTime(2012,6,16)}
                                          };

        private List<OrderDetail> _orderDetails = new List<OrderDetail>
                                                      {
                                                          new OrderDetail(){Description = "Order Item #1",Id = 1,OrderId = 1},
                                                          new OrderDetail(){Description = "Order Item #2",Id = 2,OrderId = 1},
                                                          new OrderDetail(){Description = "Order Item #1",Id = 3,OrderId = 2}
                                                      };

        private List<Customer> _customers = new List<Customer>()
                                                {
                                                    new Customer(){FirstName = "John",LastName = "Doe",Id=1},
                                                    new Customer(){FirstName = "Jane",LastName = "Doe",Id=2}
                                                };

        private Dictionary<int, int> _orderCustomers = new Dictionary<int, int>();


        public RealOrderRepository()
        {
            _orderCustomers.Add(1, 1);
            _orderCustomers.Add(2, 2);
        }

        public override Order GetOrder(int id)
        {
            var order = (from o in _orders where o.Id == id select o).SingleOrDefault();
            return order;
        }

        public override IEnumerable<OrderDetail> GetOrderDetails(int orderId)
        {
            var orderDetails = 
                from o in _orderDetails 
                where o.OrderId == orderId 
                select o;
            return orderDetails;
        }

        public override Customer GetOrderCustomer(int orderId)
        {
            int cutomerId = _orderCustomers[orderId];
            var customer = (from c in _customers where c.Id == cutomerId select c).SingleOrDefault();
            return customer;
        }
    }
}
