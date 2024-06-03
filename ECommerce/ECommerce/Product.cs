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
        private int ProductID { get; set; }
        private string ProductName { get; set; }
        private double Price { get; set; }
        private int Stock { get; set; }

        public void increaseStock(int count)
        {
            Stock += count;
        }
        public void decreaseStock(int count)
        {
            increaseStock(-count);
        }
    }
}
