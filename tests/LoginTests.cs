using Microsoft.VisualStudio.TestTools.UnitTesting;
using UWPTests.UWPTests.core;
using UWPTests.UWPTests.interfaces;

namespace Wellbeats.UWPTest.pages
{
    [TestClass]
    public class LoginTests : TestManager, IBaseTest
    {
        private static DriverManager mgr = new DriverManager();
        LoginPage LoginPg;

        public LoginTests()
        {
        }

        [TestInitialize]
        public void Setup()
        {
            DriverManager.CreateDriver();
            LoginPg = new LoginPage(mgr.GetDriver());
        }

        [TestMethod]
        public void SuccessfulLogin()
        {
            LoginPg.Login();
        }
    }
}
