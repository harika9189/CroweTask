using Microsoft.VisualStudio.TestTools.UnitTesting;
using ServiveAPI;
namespace ServiceTest
{

    [TestClass]
    public class ServiceUnitTests
    {
        private static IService service;
        private static string message;
        private static string expectedResult = "Some value";

        [TestMethod]
        public void ConsoleServiceTest()
        {
            service = new ConsoleService();
            message = service.GetInfo();
            Assert.AreEqual(expectedResult, message);
        }

        [TestMethod]
        public void MobileServiceTest()
        {
            service = new MobileService();
            message = service.GetInfo();
            Assert.AreEqual(expectedResult, message);
        }


        [TestMethod]
        public void WebApplicationTest()
        {
            service = new WebApplicationService();
            message = service.GetInfo();
            Assert.AreEqual(expectedResult, message);
        }

        [TestMethod]
        public void WindowsApplicationTest()
        {
            service = new WindowsApplicationService();
            message = service.GetInfo();
            Assert.AreEqual(expectedResult, message);
        }
    }
}
