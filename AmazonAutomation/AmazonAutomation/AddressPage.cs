using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace AmazonAutomation
{
    public class AddressPage
    {
        public static string FullName {
            get
            {
                return Driver.Instance.FindElement(By.Id("address-ui-widgets-FullName")).Text;
            }
        }

        public static string StreetAddress
        {
            get
            {
                return Driver.Instance.FindElement(By.Id("address-ui-widgets-AddressLineOne")).Text;
            }
        }

        public static string City {
            get
            {
                return Driver.Instance.FindElement(By.Id("address-ui-widgets-enterAddressCity")).Text;
            }
        }

        public static string State {
            get
            {
                return Driver.Instance.FindElement(By.Id("address-ui-widgets-enterAddressStateOrRegion")).Text;
            }
        }

        public static string ZipCode {
            get
            {
                return Driver.Instance.FindElement(By.Id("address-ui-widgets-enterAddressPostalCode")).Text;
            }
        }

        public static string PhoneNumber {
            get
            {
                return Driver.Instance.FindElement(By.Id("address-ui-widgets-PhoneNumber")).Text;
            }
        }

        public static void DeleteAddress()
        {
            Driver.Instance.FindElement(By.Id("ya-myab-address-delete-btn-0")).Click();
            Thread.Sleep(1000);
            Driver.Instance.FindElement(By.CssSelector("#deleteAddressModal-0-submit-btn input")).Click();
        }

        public static string FullAddress {
            get
            {
                return Driver.Instance.FindElement(By.Id("address-ui-widgets-CityStatePostalCode")).Text;
            }
        }

        public static bool IsEmpty {
            get
            {
                return Driver.Instance.FindElement(By.ClassName("a-alert-heading")).Text == "Address deleted";
            }
        }

        public static void AddAddress()
        {
            Driver.Instance.FindElement(By.Id("ya-myab-plus-address-icon")).Click();
        }

        public static void GoTo()
        {
            Driver.Instance.Navigate().GoToUrl("https://www.amazon.com/a/addresses?ref_=ya_d_c_addr");
        }
    }
}
