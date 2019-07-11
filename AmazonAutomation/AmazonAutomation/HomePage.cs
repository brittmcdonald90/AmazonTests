using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AmazonAutomation
{
    public class HomePage
    {
        public static bool IsLoggedIn
        {
            get
            {
                var greeting = Driver.Instance.FindElement(By.CssSelector("[data-nav-role='signin'] .nav-line-1")).Text;
                return !greeting.ToLower().Contains("sign in");
            }
        }

        public static void GoTo()
        {
            Driver.Instance.Navigate().GoToUrl("https://www.amazon.com/");
        }

        public static void Search(string searchText)
        {
            var searchInput = Driver.Instance.FindElement(By.Id("twotabsearchtextbox"));
            searchInput.SendKeys(searchText);

            var searchButton = Driver.Instance.FindElement(By.ClassName("nav-input"));
            searchButton.Click();
        }
    }
}
