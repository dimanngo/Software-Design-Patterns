using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProxyPattern.Entities
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public string Description { get; set; }

    }
}
