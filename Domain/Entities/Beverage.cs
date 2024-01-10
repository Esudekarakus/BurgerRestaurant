﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Beverage:Product
    {
		public Menu Menu { get; set; }
		public int MenuId { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
    }
}
