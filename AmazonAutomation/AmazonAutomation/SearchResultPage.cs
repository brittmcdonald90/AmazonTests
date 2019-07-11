using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AmazonAutomation
{
    public class SearchResultPage
    {
        public static string SearchText
        {
            get
            {
                return Driver.Instance.FindElement(By.CssSelector(".a-color-state.a-text-bold")).Text;
            }
        }
    }
}
