﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace AmazonAutomation
{
    public class WishListPage
    {
        public static string WishListName
        {
            get
            {
                return Driver.Instance.FindElement(By.Id("profile-list-name")).Text;
            }
        }

        public static void GoTo()
        {
            Driver.Instance.Navigate().GoToUrl("https://www.amazon.com/gp/registry/wishlist/?ie=UTF8&ref_=topnav_storetab_wl");
            Thread.Sleep(1500);
        }

        public static void CreateList(string listName)
        {
            Driver.Instance.FindElement(By.Id("createList")).Click();
            Thread.Sleep(2500);
            var test = Driver.Instance.FindElements(By.CssSelector(".a-box-inner"));
            test[13].Click();
            Driver.Instance.FindElement(By.Id("WLNEW_list_name")).Clear();
            Driver.Instance.FindElement(By.Id("WLNEW_list_name")).SendKeys(listName);
            Driver.Instance.FindElement(By.Id("WLNEW_create")).Click();
            Thread.Sleep(2500);
        }
    }
}
