using System;
using System.Linq;
using AmazonAutomation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AmazonTests
{
    [TestClass]
    public class CartTests
    {
        [TestInitialize]
        public void Init()
        {
            Driver.Initialize();
        }

        [TestMethod]
        public void Add_Product_To_Cart()
        {
            ProductPage.GoTo();
            string productName = ProductPage.ProductName.Split(' ')[0].ToLower();
            ProductPage.AddToCart();

            CartPage.GoTo();
            Assert.IsTrue(CartPage.Products.Any(product => product.Text.ToLower().Contains(productName)));
            CartPage.DeleteProduct(productName);
            Assert.IsTrue(CartPage.IsEmpty);
        }
        [TestMethod]
        public void Change_Quantity()
        {
            ProductPage.GoTo();
            string productName = ProductPage.ProductName.Split(' ')[0].ToLower();
            ProductPage.AddToCart();

            CartPage.GoTo();
            CartPage.ChangeQuantity(productName, 2);
            // change productprice to afunction so price is up to date
            var cartTotal = CartPage.ProductPrice * 2;
            var subTotal = CartPage.SubTotal;
            Assert.AreEqual(subTotal, cartTotal);

            CartPage.DeleteProduct(productName);
            Assert.IsTrue(CartPage.IsEmpty);
        }

        [TestCleanup]
        public void Cleanup()
        {
            Driver.Close();
        }

    }
}
