using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AmazonAutomation.PrimeVideo
{
    public class VideoWishlistPage
    {
        public static bool IsEmpty
        {
            get
            {
                try
                {
                    Driver.Instance.FindElement(By.CssSelector("div[data-automation-id='list-message']"));
                }
                catch (Exception)
                {
                    return false;
                };
                return true;
            }
        }

        public static void GoTo()
        {
            Driver.Instance.Navigate().GoToUrl("https://www.amazon.com/gp/video/watchlist/ref=sv_atv_8");
        }

        public static void Clear()
        {
            Driver.Instance.FindElement(By.LinkText("Remove")).Click();
        }
    }
}
