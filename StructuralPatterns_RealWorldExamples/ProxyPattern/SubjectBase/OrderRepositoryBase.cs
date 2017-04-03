using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProxyPattern.Entities;

namespace ProxyPattern.SubjectBase
{
    public abstract class OrderRepositoryBase
    {
        public abstract Order GetOrder(int id);

        public abstract IEnumerable<OrderDetail> GetOrderDetails(int orderId);

        public abstract Customer GetOrderCustomer(int orderId);
    }
}
