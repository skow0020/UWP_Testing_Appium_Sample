using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Support.PageObjects;
using System;
using UWPTests.UWPTests.core;
using UWPTests.UWPTests.interfaces;
using UWPTests.UWPTests.pages;

namespace Wellbeats.UWPTest.pages
{
    public class LoginPage : CommonPage, IPage
    {
        private WindowsDriver<WindowsElement> Driver;
        public LoginPage(WindowsDriver<WindowsElement> Driver) : base(Driver)
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

        public LoginPage Login()
        {
            EnterLoginCredentials(Constants.USERNAME, Constants.PASSWORD);
            ClickAndVerifyLogin();
            return this;
        }

        public LoginPage TryToLogin(String usernameText, String passwordText)
        {
            EnterLoginCredentials(usernameText, passwordText);
            loginButton.Click();
            return this;
        }

        private LoginPage EnterLoginCredentials(String usernameText, String passwordText)
        {
            WaitForElement(usernameField);
            EnterText(usernameField, usernameText);
            EnterText(passwordField, passwordText);
            return this;
        }

        public LoginPage ClickAndVerifyLogin()
        {
            loginButton.Click();
            // VERIFY SUCCESSFUL LOGIN
            return this;
        }

        // ----Decorated selectors --- //
        [FindsBy(How = How.Name, Using = "Enter Username")]
        private IWebElement usernameField;

        [FindsBy(How = How.Name, Using = "Enter Password")]
        private IWebElement passwordField;

        [FindsBy(How = How.Name, Using = "Login")]
        private IWebElement loginButton;
    }
}
