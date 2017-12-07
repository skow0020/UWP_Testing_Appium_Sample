using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Support.PageObjects;
using System;
using UWPTests.UWPTests.core;
using UWPTests.UWPTests.interfaces;
using UWPTests.UWPTests.pages;

namespace Wellbeats.UWPTest.pages
{
    public class ExamplePage : CommonPage, IPage
    {
        private WindowsDriver<WindowsElement> Driver;
        public ExamplePage(WindowsDriver<WindowsElement> Driver) : base(Driver)
        {
            this.Driver = Driver;
            PageFactory.InitElements(this.Driver, this);
        }

        public object VerifyPage()
        {
            // Implement this 
            return this;
            throw new NotImplementedException();
        }

        public void ExampleMethod()
        {
            // COMPLETE ME
        }

        // ----Decorated selectors --- //
        [FindsBy(How = How.Name, Using = "idname")]
        private IWebElement element;
    }
}
