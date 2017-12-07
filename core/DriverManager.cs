using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Remote;
using System;

namespace UWPTests.UWPTests.core
{
    public class DriverManager
    {
        protected const string WindowsApplicationDriverUrl = "http://127.0.0.1:4723";
        protected static WindowsDriver<WindowsElement> Driver;

        public static void CreateDriver()
        {
            DesiredCapabilities appCapabilities = new DesiredCapabilities();
            appCapabilities.SetCapability("app", "[APPNAME]!App");

            Driver = new WindowsDriver<WindowsElement>(new Uri(WindowsApplicationDriverUrl), appCapabilities);
            Assert.IsNotNull(Driver);
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
        }

        public WindowsDriver<WindowsElement> GetDriver()
        {
            return Driver;
        }

        public static void KillDriver()
        {
            Driver.Quit();
            Driver = null;
        }
    }
}
