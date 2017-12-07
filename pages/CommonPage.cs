using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Threading;

namespace UWPTests.UWPTests.pages
{
    public class CommonPage
    {
        
        private WindowsDriver<WindowsElement> Driver;
        public CommonPage(WindowsDriver<WindowsElement> Driver)
        {
            this.Driver = Driver;
            PageFactory.InitElements(this.Driver, this);
        }

        public bool ElementExists(IWebElement element)
        {
            try
            {
                if (element.Displayed) { return true; }
                return false;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public IWebElement WaitForElement(IWebElement element)
        {
            int i = 0;
            while (!ElementExists(element) && i <= 10)
            {
                Thread.Sleep(1000);
                i++;
            }
            Assert.IsTrue(i < 10, "Element was not found on the page");
            return element;
        }

        public IWebElement VerifyElementText(IWebElement element, String text)
        {
            WaitForElement(element);
            Assert.AreEqual(element.Text, text);
            return element;
        }

        public void VerifyErrorMessage(String message)
        {
            WaitForElement(ErrorMessage());
            VerifyElementText(ErrorTitle(), "Errors Occurred");
            VerifyElementText(ErrorMessage(), message);
        }

        public IWebElement EnterText(IWebElement element, String text)
        {
            WaitForElement(element);
            element.SendKeys(text);
            return element;
        }

        public void ClickNHold(WindowsElement element, int time)
        {
            Actions action = new Actions(Driver);
            element.Click();
            action.ClickAndHold().Build().Perform();
            Thread.Sleep(time);
            action.Release().Perform();
            Thread.Sleep(1500);
        }

        // ----Decorated selectors --- //
        [FindsBy(How = How.Name, Using = "Register Person")]
        public IWebElement registerPersonPageTitle;

        // ----Other selectors --- //
        public IWebElement ErrorMessage(){ return  Driver.FindElementByAccessibilityId("MessageTextBlock"); }
        public IWebElement ErrorTitle() { return Driver.FindElementByAccessibilityId("TitleTextBlock"); }
    }
}
