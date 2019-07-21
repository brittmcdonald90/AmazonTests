using System;
using AmazonAutomation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AmazonTests
{
    [TestClass]
    public class AccountTests
    {
        [TestInitialize]
        public void Init()
        {
            Driver.Initialize();
        }
        [TestCleanup]
        public void Cleanup()
        {
            //Driver.Close();
        }
        [TestMethod]
        public void Add_Address_To_Account()
        {
            LoginPage.GoTo();
            LoginPage.LoginAs("brittmcdonald90@gmail.com").WithPassword("Testpassword1").Login();
            AddressPage.GoTo();
            AddressPage.AddAddress();
            AddAddressPage.AddDefaultAddress();

            // assert that the constants are on the page now
            Assert.AreEqual(AddressConstants.FULL_NAME, AddressPage.FullName);
            Assert.AreEqual(AddressConstants.STREET_ADDRESS.ToLower(), AddressPage.StreetAddress.ToLower());
            Assert.AreEqual($"Phone number: {AddressConstants.PHONE_NUMBER}", AddressPage.PhoneNumber);
            string fullAddress = $"{AddressConstants.CITY}, {AddressConstants.STATE} {AddressConstants.ZIP_CODE}";
            Assert.AreEqual(fullAddress.ToLower(), AddressPage.FullAddress.ToLower());

            AddressPage.DeleteAddress();

            Assert.IsTrue(AddressPage.IsEmpty);
        }
    }
}
