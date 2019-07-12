using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AmazonAutomation
{
    public class CartPage
    {
        public static IList<IWebElement> Products
        {
            get
            {
                return Driver.Instance.FindElements(By.ClassName("sc-product-title"));
            }
        }

        public static bool IsEmpty
        {
            get
            {
                return Driver.Instance.FindElement(By.CssSelector(".sc-price")).Text == "$0.00";
            }
        }

        public static void DeleteProduct(object productName)
        {
            var deleteButton = Driver.Instance.FindElement(By.CssSelector(".sc-action-delete input"));
            deleteButton.Click();
        }

        public static void GoTo()
        {
            Driver.Instance.Navigate().GoToUrl("https://www.amazon.com/gp/cart/view.html?ref_=nav_cart");
        }
    }
}
