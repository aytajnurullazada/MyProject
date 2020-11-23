using ConsoleProject.Infrustructure.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleProject.Infrustructure.Models
{
    public class Product
    {
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        public int ProductCount { get; set; }
        public string ProductCode { get; set; }
        public Category Category { get; set; }
    }
}
