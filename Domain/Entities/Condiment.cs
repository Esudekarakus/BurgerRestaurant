﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Condiment:Product_BaseEntity
    {
        public int MenuId { get; set; }
    }
}