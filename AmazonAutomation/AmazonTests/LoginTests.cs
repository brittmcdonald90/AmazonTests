using System;
using AmazonAutomation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AmazonTests
{
    [TestClass]
    public class LoginTests
    {
        [TestInitialize]
        public void Init()
        {
            Driver.Initialize();
        }

        [TestMethod]
        public void User_Is_Logged_Out()
        {
            HomePage.GoTo();
            var test = !HomePage.IsLoggedIn;
            Assert.IsTrue(test, "Should not be logged in");
        }

        [TestMethod]
        public void Customer_Can_Login()
        {
            LoginPage.GoTo();

            LoginPage.LoginAs("brittmcdonald90@gmail.com").WithPassword("Testpassword1").Login();

            Assert.IsTrue(HomePage.IsLoggedIn, "Could not login");
        }
    }
}
