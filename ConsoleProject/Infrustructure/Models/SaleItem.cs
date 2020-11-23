using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleProject.Infrustructure.Models
{
    public class SaleItem
    {
        public int ItemNumber { get; set; }
        public Product Product { get; set; }
        public int ItemCount { get; set; }
    }
}
