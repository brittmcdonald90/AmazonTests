using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace AmazonAutomation.PrimeVideo
{
    public class VideoHomePage
    {
        public static void GoTo()
        {
            Driver.Instance.Navigate().GoToUrl("https://www.amazon.com/b/ref=lp_2858778011_nav_em_T1_0_4_5_1__aiv?rh=i%3Ainstant-video%2Cn%3A2858778011&ie=UTF8&node=2858778011");
            
        }

        public static void Search(string videoName)
        {
            Driver.Instance.FindElement(By.Id("twotabsearchtextbox")).SendKeys(videoName);
            Driver.Instance.FindElement(By.CssSelector("input[value='Go']")).Click();
        }

        public static void SelectFirstVideoInList()
        {
            var video = Driver.Instance.FindElements(By.CssSelector(".s-result-item a"));
            video[1].Click();
        }
    }
}
