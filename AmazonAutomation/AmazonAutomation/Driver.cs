﻿using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Text;

namespace AmazonAutomation
{
    public class Driver
    {
        public static IWebDriver Instance { get; internal set; }
        public static void Initialize()
        {
            Instance = new FirefoxDriver();
            Instance.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            Instance.Manage().Timeouts().AsynchronousJavaScript = TimeSpan.FromSeconds(5);
            Instance.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);
        }

        public static void Close()
        {
            Instance.Close();

        }
    }
}
