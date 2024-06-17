using ECOM_PROJECT;

namespace ECOM_Project_nunitTests
{
    public class ProductTests 
    {
        private Product _product;

        [SetUp]
        public void Setup()
        {
            _product = new Product(1, "Shourya", 123.45m, 500);
        }

        [Test]
        public void MinimumProductID()
        {
            //Arrange
            _product.ProductID = 1;

            //Act
            int expectedProductId = 1;

            //Assert
            Assert.That(_product.ProductID, Is.EqualTo(expectedProductId));
        }
        [Test]
        public void MaximumProductID()
        {
            //Arrange
            _product.ProductID = 1000;

            //Act
            int expectedProductId = 1000;

            //Assert
            Assert.That(_product.ProductID, Is.EqualTo(expectedProductId));
        }
    }
}