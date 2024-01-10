using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Category : BaseEntity
    {
        public IEnumerable<Condiment> Condiments { get; set; }
        public IEnumerable<Burger> Burgers { get; set; }
        public IEnumerable<Beverage> Beverages { get; set; }
    }
}
