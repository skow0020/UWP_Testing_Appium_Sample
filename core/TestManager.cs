using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UWPTests.UWPTests.core
{
    [TestClass]
    public class TestManager
    {

        public TestManager()
        {
        }

        [ClassInitialize]
        public static void Setup(TestContext context)
        {
        }

        [TestCleanup]
        public void TearDown()
        {
            DriverManager.KillDriver();
        }
    }
}
