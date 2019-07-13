using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace AmazonAutomation
{
    public class ProductPage
    {
        public static string ProductName
        {
            get
            {
                return Driver.Instance.FindElement(By.Id("productTitle")).Text;
            }
        }

        public static void GoTo()
        {
            Driver.Instance.Navigate().GoToUrl("https://www.amazon.com/Wilson-Super-Grip-Official-Football/dp/B0012SNLJG/ref=sr_1_5?keywords=football&qid=1562886536&s=gateway&sr=8-5");
        }

        public static void AddToCart()
        {
            Thread.Sleep(3000);
            Driver.Instance.FindElement(By.Id("add-to-cart-button")).Click();
        }
    }
}
