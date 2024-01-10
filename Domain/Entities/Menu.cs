
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
            Condiments= new List<Condiment>();
            Burgers= new List<Burger>();
            Beverages= new List<Beverage>();
        }

        public Domain.Enums.Size Size {  get; set; }
        public ICollection<Condiment> Condiments { get; set; }
        public ICollection<Burger> Burgers { get; set;}
        public ICollection<Beverage> Beverages { get; set; }
        public Order Order { get; set; }
        public int OrderId { get; set; }


    }
}
