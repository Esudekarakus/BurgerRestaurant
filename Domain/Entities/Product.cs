using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public abstract class Product : BaseEntity
    {

      
   
        public double Price { get; set; }

        public Category Category { get; set; }
        public int CategoryId { get; set; }

      
    }
}
