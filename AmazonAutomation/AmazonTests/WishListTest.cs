using System;
using AmazonAutomation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AmazonTests
{
    [TestClass]
    public class WishListTest
    {
        [TestInitialize]
        public void Init()
        {
            Driver.Initialize();
        }

        [TestMethod]
        public void Create_Wish_List()
        {
            LoginPage.GoTo();
            LoginPage.LoginAs("brittmcdonald90@gmail.com").WithPassword("Testpassword1").Login();
            WishListPage.GoTo();

            string wishListName = "Auto Test Wish List";
            WishListPage.CreateList(wishListName);
            Assert.AreEqual(wishListName, WishListPage.WishListName);
        }

        [TestCleanup]
        public void Cleanup()
        {
            Driver.Close();
        }

    }
}
