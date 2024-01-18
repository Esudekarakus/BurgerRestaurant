using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL.Repositories.Concrete;
using Domain.Entities;

namespace BLL.Services
{
    public class OrderService
    {
        private readonly OrderRepository order;
        public OrderService(OrderRepository order)
        {
            this.order = order;
            
        }

        public List<Order> GetOrderListByUserId(string id)
        {
            return (List<Order>)order.GetByUserIdIncludeMenusOrderByCreatedDate(id);
        }
    }
}