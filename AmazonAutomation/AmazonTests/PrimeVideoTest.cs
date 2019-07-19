using System;
using AmazonAutomation;
using AmazonAutomation.PrimeVideo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AmazonTests
{
    [TestClass]
    public class PrimeVideoTest
    {
        [TestInitialize]
        public void Init()
        {
            Driver.Initialize();
        }
        [TestMethod]
        public void Add_Show_To_Watchlist()
        {
            LoginPage.GoTo();
            LoginPage.LoginAs("brittmcdonald90@gmail.com").WithPassword("Testpassword1").Login();

            VideoHomePage.GoTo();
            VideoHomePage.Search("Jack Ryan");
            VideoHomePage.SelectFirstVideoInList();
            VideoDetailPage.AddToWatchlist();
            VideoWishlistPage.GoTo();
            Assert.IsTrue(!VideoWishlistPage.IsEmpty);
            VideoWishlistPage.Clear();
            VideoWishlistPage.GoTo();
            Assert.IsTrue(VideoWishlistPage.IsEmpty);
        }
        [TestCleanup]
        public void Cleanup()
        {
            Driver.Close();
        }
    }
}
