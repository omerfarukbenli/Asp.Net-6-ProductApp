﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Entity.Dto
{
    public class ProductCreateDto
    {
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public int ProductPrice { get; set; }
    }
}
