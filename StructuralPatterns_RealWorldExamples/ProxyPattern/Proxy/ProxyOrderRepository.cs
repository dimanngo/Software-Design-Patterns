using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProxyPattern.Entities;
using ProxyPattern.RealSubject;
using ProxyPattern.SubjectBase;

namespace ProxyPattern.Proxy
{
    public class ProxyOrderRepository:OrderRepositoryBase
    {
        private RealOrderRepository _repository;

        public ProxyOrderRepository()
        {
            _repository = new RealOrderRepository();
        }

        public override Order GetOrder(int id)
        {
            var order = _repository.GetOrder(id);
            order.Customer = GetOrderCustomer(order.Id);
            order.Details = GetOrderDetails(order.Id);
            return order;
        }

        public override IEnumerable<OrderDetail> GetOrderDetails(int orderId)
        {
            return _repository.GetOrderDetails(orderId);
        }

        public override Customer GetOrderCustomer(int orderId)
        {
            return _repository.GetOrderCustomer(orderId);
        }
    }
}
