using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AmazonTests
{
    [TestClass]
    public class QuantityTest
    {
        [TestMethod]
        public void Change_Product_Quantity()
        {
            //ProductPage.GoTo();
            //string productName = ProductPage.ProductName.Split(' ')[0].ToLower();
            //ProductPage.AddToCart();

            //CartPage.GoTo();
            //Change quantity from 1 to 2
            //CartPage.DeleteProduct(productName);
            //Assert that quantity has changed from 1 to 2
        }

        [TestCleanup]
        public void Cleanup()
        {
            //Driver.Close();
        }

    }
}
