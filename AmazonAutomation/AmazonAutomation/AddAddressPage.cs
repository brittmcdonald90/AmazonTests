using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AmazonAutomation
{
    public class AddressConstants
    {
        public const string FULL_NAME = "B Mac";
        public const string STREET_ADDRESS = "291 E Tremaine Ave";
        public const string CITY = "Gilbert";
        public const string STATE = "Az";
        public const string ZIP_CODE = "85234-4586";
        public const string PHONE_NUMBER = "480-316-1653";
    }    
    public class AddAddressPage
    {

        public static void ClickAddAddress()
        {
            var buttons = Driver.Instance.FindElements(By.CssSelector("input[type='submit']"));
            buttons[1].Click();
        }

        public static void AddDefaultAddress()
        {
            AddFullName();
            AddStreetAddress();
            AddCity();
            AddState();
            AddZipCode();
            AddPhoneNumber();
            ClickAddAddress();
        }

        public static void AddPhoneNumber(string phoneNumber = AddressConstants.PHONE_NUMBER)
        {
            Driver.Instance.FindElement(By.Id("address-ui-widgets-enterAddressPhoneNumber")).SendKeys(phoneNumber);

        }

        public static void AddZipCode(string zipCode = AddressConstants.ZIP_CODE)
        {
            Driver.Instance.FindElement(By.Id("address-ui-widgets-enterAddressPostalCode")).SendKeys(zipCode);
        }

        public static void AddState(string state = AddressConstants.STATE)
        {
            Driver.Instance.FindElement(By.Id("address-ui-widgets-enterAddressStateOrRegion")).SendKeys(state);
        }

        public static void AddCity(string city = AddressConstants.CITY)
        {
            Driver.Instance.FindElement(By.Id("address-ui-widgets-enterAddressCity")).SendKeys(city);

        }

        public static void AddStreetAddress(string streetAddress = AddressConstants.STREET_ADDRESS)
        {
            Driver.Instance.FindElement(By.Id("address-ui-widgets-enterAddressLine1")).SendKeys(streetAddress);

        }

        public static void AddFullName(string fullName = AddressConstants.FULL_NAME)
        {
            Driver.Instance.FindElement(By.Id("address-ui-widgets-enterAddressFullName")).SendKeys(fullName);
        }
    }
}
