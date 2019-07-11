using AmazonAutomation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonTests
{
    [TestClass]
    public class SearchTests
    {
        [TestInitialize]
        public void Init()
        {
            Driver.Initialize();
        }

        [TestMethod]
        public void Can_Search_Results()
        {
            var searchText = "battery";
            HomePage.GoTo();
            HomePage.Search(searchText);

            Assert.IsTrue(SearchResultPage.SearchText.Contains(searchText));
        }
        [TestCleanup]
        public void Cleanup()
        {
            Driver.Close();
        }
    }
}
