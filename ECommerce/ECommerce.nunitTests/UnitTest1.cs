namespace ECommerce.nunitTests
{
    public class Tests
    {
        private Product? Product { get; set; } = null;
        [SetUp]
        public void Setup()
        {
            Product = new Product(1, "Rice", 20, 3000);
        }
        [TestCase(-1)]
        [TestCase(1)]
        [TestCase(5001)]
        public void ProductId_Limit_Test(int productId)
        {
            // Test the different values of productIDs
            Product.ProductID = productId;
            //Assert
            Assert.That(Product.ProductID, Is.AtLeast(1));
            Assert.That(Product.ProductID, Is.AtMost(5000));
        }

        [TestCase(-10)]
        [TestCase(10500)]
        [TestCase(5001)]
        public void Price_Limit_Test(int price)
        {
            // Test the different values of productIDs
            Product.Price = price;
            //Assert
            Assert.That(Product.Price, Is.AtLeast(1));
            Assert.That(Product.Price, Is.AtMost(10000));
        }

        [TestCase(-10)]
        [TestCase(10500)]
        [TestCase(600)]
        public void Stock_Limit_Test(int price)
        {
            // Test the different values of productIDs
            Product.Price = price;
            //Assert
            Assert.That(Product.Price, Is.AtLeast(1));
            Assert.That(Product.Price, Is.AtMost(5000));
        }

        [TestCase(2000)]
        [TestCase(3000)]
        [TestCase(2002)]
        public void IncreaseCount_Test(int stock)
        {
            Product.Stock = stock;
            // Test whether increasin stock increases beyond 5000
            Product.IncreaseStock(stock);
            //Assert
            Assert.That(Product.Stock, Is.AtLeast(1));
            Assert.That(Product.Stock, Is.AtMost(5000));
        }
        
        [TestCase(1)]
        [TestCase(5000)]
        [TestCase(700)]
        public void DecreaseCount_Test(int stock)
        {
            Product.Stock = stock;
            // Test whether decreasing stock falls below 1
            Product.DecreaseStock(stock);
            //Assert
            Assert.That(Product.Stock, Is.AtLeast(1));
            Assert.That(Product.Stock, Is.AtMost(5000));
        }

        [TestCase("Arthur")]
        [TestCase("Fish")]
        [TestCase("2000")]
        public void CheckProductNameValidity_Test(string name)
        {
            Product.ProductName = name;            
            //Assert
            Assert.That(Product.ProductName, Is.AnyOf("Rice","Fish","Vegetable"));
        }
    }
}