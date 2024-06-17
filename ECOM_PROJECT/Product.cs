using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECOM_PROJECT
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; }
        public decimal Price { get; }
        public int Stock { get; private set; }

        public Product(int productID, string productName, decimal price, int stock)
        {
            if (productID < 1 || productID > 1000)
                throw new ArgumentOutOfRangeException(nameof(productID), "ProductID must be between 1 and 1000.");
            if (price < 1 || price > 5000)
                throw new ArgumentOutOfRangeException(nameof(price), "Price must be between 1 and 5000.");
            if (stock < 1 || stock > 1000)
                throw new ArgumentOutOfRangeException(nameof(stock), "Stock must be between 1 and 1000.");

            ProductID = productID;
            ProductName = productName;
            Price = price;
            Stock = stock;
        }

        public void IncreaseStock(int amount)
        {
            if (amount > 0)
            {
                Stock += amount;
            }
            // Optionally, handle negative amounts
        }

        public void DecreaseStock(int amount)
        {
            if (amount > 0)
            {
                Stock = Math.Max(Stock - amount, 0);
            }
            // Optionally, handle negative amounts
        }
    }

}
