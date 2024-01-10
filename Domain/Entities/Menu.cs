
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Menu : Product
    {
        public Menu()
        {
            
        }

        public Domain.Enums.Size Size {  get; set; }
        public IEnumerable<Beverage> Beverages { get; set; }
		public IEnumerable<Burger> Burgers { get; set; }
		public IEnumerable<Condiment> Condiments { get; set; }
		public Order Order { get; set; }
        public int OrderId { get; set; }


    }
}
