using NUnit.Framework;

namespace ECOM_PROJECT
{
    [TestFixture]
    public class ProductTests
    {
        // Tests for ProductID
        [Test]
        public void ProductID_WithinValidRange()
        {
            // Arrange
            int productID = 500;
            string productName = "Test Product";
            decimal price = 100;
            int stock = 50;

            // Act
            Product product = new Product(productID, productName, price, stock);

            // Assert
            Assert.That(product.ProductID, Is.EqualTo(500));
        }

        [Test]
        public void ProductID_MinimumBoundary()
        {
            // Arrange
            int productID = 1;
            string productName = "Test Product";
            decimal price = 100;
            int stock = 50;

            // Act
            Product product = new Product(productID, productName, price, stock);

            // Assert
            Assert.That(product.ProductID, Is.EqualTo(1));
        }

        [Test]
        public void ProductID_MaximumBoundary()
        {
            // Arrange
            int productID = 1000;
            string productName = "Test Product";
            decimal price = 100;
            int stock = 50;

            // Act
            Product product = new Product(productID, productName, price, stock);

            // Assert
            Assert.That(product.ProductID, Is.EqualTo(1000));
        }

        // Tests for ProductName
        [Test]
        public void ProductName_SetCorrectly()
        {
            // Arrange
            int productID = 500;
            string productName = "Test Product";
            decimal price = 100;
            int stock = 50;

            // Act
            Product product = new Product(productID, productName, price, stock);

            // Assert
            Assert.That(product.ProductName, Is.EqualTo("Test Product"));
        }

        [Test]
        public void ProductName_EmptyString()
        {
            // Arrange
            int productID = 500;
            string productName = "";
            decimal price = 100;
            int stock = 50;

            // Act
            Product product = new Product(productID, productName, price, stock);

            // Assert
            Assert.That(product.ProductName, Is.EqualTo(""));
        }

        [Test]
        public void ProductName_Null()
        {
            // Arrange
            int productID = 500;
            string productName = null;
            decimal price = 100;
            int stock = 50;

            // Act
            Product product = new Product(productID, productName, price, stock);

            // Assert
            Assert.That(product.ProductName, Is.Null);
        }

        // Tests for Price
        [Test]
        public void Price_WithinValidRange()
        {
            // Arrange
            int productID = 500;
            string productName = "Test Product";
            decimal price = 100;
            int stock = 50;

            // Act
            Product product = new Product(productID, productName, price, stock);

            // Assert
            Assert.That(product.Price, Is.EqualTo(100));
        }

        [Test]
        public void Price_MinimumBoundary()
        {
            // Arrange
            int productID = 500;
            string productName = "Test Product";
            decimal price = 1;
            int stock = 50;

            // Act
            Product product = new Product(productID, productName, price, stock);

            // Assert
            Assert.That(product.Price, Is.EqualTo(1));
        }

        [Test]
        public void Price_MaximumBoundary()
        {
            // Arrange
            int productID = 500;
            string productName = "Test Product";
            decimal price = 5000;
            int stock = 50;

            // Act
            Product product = new Product(productID, productName, price, stock);

            // Assert
            Assert.That(product.Price, Is.EqualTo(5000));
        }

        // Tests for Stock
        [Test]
        public void Stock_WithinValidRange()
        {
            // Arrange
            int productID = 500;
            string productName = "Test Product";
            decimal price = 100;
            int stock = 50;

            // Act
            Product product = new Product(productID, productName, price, stock);

            // Assert
            Assert.That(product.Stock, Is.EqualTo(50));
        }

        [Test]
        public void Stock_MinimumBoundary()
        {
            // Arrange
            int productID = 500;
            string productName = "Test Product";
            decimal price = 100;
            int stock = 1;

            // Act
            Product product = new Product(productID, productName, price, stock);

            // Assert
            Assert.That(product.Stock, Is.EqualTo(1));
        }

        [Test]
        public void Stock_MaximumBoundary()
        {
            // Arrange
            int productID = 500;
            string productName = "Test Product";
            decimal price = 100;
            int stock = 1000;

            // Act
            Product product = new Product(productID, productName, price, stock);

            // Assert
            Assert.That(product.Stock, Is.EqualTo(1000));
        }

        // Tests for IncreaseStock method
        [Test]
        public void IncreaseStock_ValidAmount()
        {
            // Arrange
            int productID = 500;
            string productName = "Test Product";
            decimal price = 100;
            int stock = 50;
            Product product = new Product(productID, productName, price, stock);

            // Act
            product.IncreaseStock(10);

            // Assert
            Assert.That(product.Stock, Is.EqualTo(60));
        }

        [Test]
        public void IncreaseStock_ZeroAmount()
        {
            // Arrange
            int productID = 500;
            string productName = "Test Product";
            decimal price = 100;
            int stock = 50;
            Product product = new Product(productID, productName, price, stock);

            // Act
            product.IncreaseStock(0);

            // Assert
            Assert.That(product.Stock, Is.EqualTo(50));
        }

        [Test]
        public void IncreaseStock_NegativeAmount()
        {
            // Arrange
            int productID = 500;
            string productName = "Test Product";
            decimal price = 100;
            int stock = 50;
            Product product = new Product(productID, productName, price, stock);

            // Act
            product.IncreaseStock(-10);

            // Assert
            Assert.That(product.Stock, Is.EqualTo(50));  // Assuming negative values are ignored
        }

        // Tests for DecreaseStock method
        [Test]
        public void DecreaseStock_ValidAmount()
        {
            // Arrange
            int productID = 500;
            string productName = "Test Product";
            decimal price = 100;
            int stock = 50;
            Product product = new Product(productID, productName, price, stock);

            // Act
            product.DecreaseStock(10);

            // Assert
            Assert.That(product.Stock, Is.EqualTo(40));
        }

        [Test]
        public void DecreaseStock_AmountExceedsStock()
        {
            // Arrange
            int productID = 500;
            string productName = "Test Product";
            decimal price = 100;
            int stock = 50;
            Product product = new Product(productID, productName, price, stock);

            // Act
            product.DecreaseStock(60);

            // Assert
            Assert.That(product.Stock, Is.EqualTo(0)); // Assuming stock can't go below 0
        }

        [Test]
        public void DecreaseStock_ZeroAmount()
        {
            // Arrange
            int productID = 500;
            string productName = "Test Product";
            decimal price = 100;
            int stock = 50;
            Product product = new Product(productID, productName, price, stock);

            // Act
            product.DecreaseStock(0);

            // Assert
            Assert.That(product.Stock, Is.EqualTo(50));
        }
    }

}
