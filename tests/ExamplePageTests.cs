using Microsoft.VisualStudio.TestTools.UnitTesting;
using UWPTests.UWPTests.core;
using UWPTests.UWPTests.interfaces;

namespace Wellbeats.UWPTest.pages
{
    [TestClass]
    public class ExamplePageTests : TestManager, IBaseTest
    {
        private static DriverManager mgr = new DriverManager();
        ExamplePage ExamplePg;
        LoginPage LoginPg;

        public ExamplePageTests()
        {
        }

        [TestInitialize]
        public void Setup()
        {
            DriverManager.CreateDriver();
            ExamplePg = new ExamplePage(mgr.GetDriver());
            LoginPg = new LoginPage(mgr.GetDriver());
            LoginPg.Login();
        }

        [TestMethod]
        public void ExampleTest() 
        {
            ExamplePg.ExampleMethod();
        }
    }
}
