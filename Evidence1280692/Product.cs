﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Category_Model
{
    internal class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductNumber { get; set; }
        public string Color { get; set; }
        public double StandardCost { get; set;  }
        public double ListPrice { get; set; }
        public int Size { get; set; }
        public double Weight { get; set;  }
        public int CategoryId { get; set; }
        public int ModelId { get; set; }
    }
}