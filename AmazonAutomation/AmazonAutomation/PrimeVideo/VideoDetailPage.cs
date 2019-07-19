using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AmazonAutomation.PrimeVideo
{
    public class VideoDetailPage
    {
        public static void AddToWatchlist()
        {
            Driver.Instance.FindElement(By.ClassName("dv-wl-toggle-add")).Click();
        }
    }
}
