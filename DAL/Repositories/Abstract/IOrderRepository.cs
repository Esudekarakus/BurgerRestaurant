using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Abstract
{
    public interface IOrderRepository : IRepository<Order>
    {
        IEnumerable<Order> GetAllByUserId(string id);
        Order GetByIdIncludeMenus(int id);
        Order GetByUserIdIncludeMenus(string id);

        IEnumerable<Order> GetAllOrderByCreatedDate();
        IEnumerable<Order> GetByUserIdOrderByCreatedDate(string id);
        IEnumerable<Order> GetByUserIdIncludeMenusOrderByCreatedDate(string id);

    }
}
