using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }

        public Product(int ProductID, string ProductName, double Price, int Stock)
        {
            this.ProductID = ProductID;
            this.ProductName = ProductName;
            this.Price = Price;
            this.Stock = Stock;
        }
        public void IncreaseStock(int count)
        {
            Stock += count;
        }
        public void DecreaseStock(int count)
        {
            Stock -= count;
        }
    }
}
