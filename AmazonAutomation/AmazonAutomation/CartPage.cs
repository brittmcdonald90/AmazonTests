using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

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
                return Subtotal == 0.00;
            }
        }

        public static float Subtotal
        {
            get
            {
                return float.Parse(Driver.Instance.FindElement(
                    By.CssSelector(".sc-price-sign")).Text.Replace("$", "")
                );
            } 
        }

        public static float ProductPrice
        {
            get
            {
                return float.Parse(Driver.Instance.FindElement(
                    By.CssSelector(".sc-product-price")).Text.Replace("$", "")
                );
            }
        }

        public static void DeleteProduct(object productName)
        {
            Driver.Instance.FindElement(By.CssSelector(".sc-action-delete input")).Click();
            Thread.Sleep(2000);
        }

        public static object GetSubtotal()
        {
            return float.Parse(Driver.Instance.FindElement(
                By.CssSelector(".sc-price-sign")).Text.Replace("$", "")
            );
        }

        public static void GoTo()
        {
            Driver.Instance.Navigate().GoToUrl("https://www.amazon.com/gp/cart/view.html?ref_=nav_cart");
        }

        public static void ChangeQuantity(string productName, int quantity)
        {
            Thread.Sleep(3000);
            Driver.Instance.FindElement(By.Id("a-autoid-0-announce")).Click();
            Driver.Instance.FindElement(By.Id("dropdown1_" + (quantity - 1))).Click();
            Thread.Sleep(2000);
        }
    }
}
