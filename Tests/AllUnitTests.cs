using Assignment2_Grp_07;
using NUnit.Framework;
using System;
namespace Tests
{
    [TestFixture]
    public class AllTests
    {
        ///Harsh Patel Test Cases
        //Test case 1 : for product ID
        [Test]
        public void ProductID_maximumID_SetCoorectly()
        {
            //arrange
            var product = new ProductClass(50000, "Gaming PC", 2000m, 100);

            //act amd assert
            Assert.That(product.ProductID, Is.EqualTo(50000));
        }
        //Test case 2 : for ItemPrice 
        [Test]
        public void ItemPrice_MaxPrice()
        {
            //arrange
            var product = new ProductClass(200, "4K Television", 5000m, 50);

            //act and assert
            Assert.That(product.ItemPrice, Is.EqualTo(5000m));
        }
        //Test case 3 : for stock amount (minimum stock)
        [Test]
        public void StockAmount_MinimumStock()
        {
            //arrange
            var product = new ProductClass(300, "WebCams", 49.99m, 5);

            //act and assert
            Assert.That(product.StockAmount, Is.EqualTo(5));
        }
        //Test case 4 : for stock increase by 1
        [Test]
        public void IncreaseStock_ByOne()
        {
            //arrange
            var product = new ProductClass(400, "Microphone", 99.99m, 10);

            //act
            product.IncreaseStock(1);

            //assert
            Assert.That(product.StockAmount, Is.EqualTo(11));
        }
        //Test case 5 : for stock decrease by 1
        [Test]
        public void DecreaseStock_ByOne()
        {
            //arrange
            var product = new ProductClass(500, "Keyboard", 29.99m, 10);

            //act
            product.DecreaseStock(1);

            //assert
            Assert.That(product.StockAmount, Is.EqualTo(9));
        }
        //Test case 6 : for decreasestock method 
        [Test]
        public void DecreaseStock_ToMinimumStock()
        {
            //arrange
            var product = new ProductClass(600, "Mouse", 19.99m, 10);

            //act
            product.DecreaseStock(5);

            //assert
            Assert.That(product.StockAmount, Is.EqualTo(5));
        }
    }
}