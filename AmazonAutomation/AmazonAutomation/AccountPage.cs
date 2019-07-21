using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AmazonAutomation
{
    public class AccountPage
    {
        public static void GoTo()
        {
            Driver.Instance.Navigate().GoToUrl("https://www.amazon.com/gp/css/homepage.html?ie=UTF8&ref_=nav_youraccount_ya");
        }

        public static void SelectYourAddresses()
        {
            IWebElement address = null;

            try
            {
                address = Driver.Instance.FindElement(By.LinkText("Your addresses"));
            }
            catch (Exception e){}

            if (address == null)
            {
                try
                {
                    address = Driver.Instance.FindElement(By.ClassName("ya-card__whole-card-link"));
                }
                catch (Exception)
                {
                    throw;
                }
            }
            address.Click();
        }
    }
}
