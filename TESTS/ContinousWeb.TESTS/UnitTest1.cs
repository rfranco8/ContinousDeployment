using Microsoft.VisualStudio.TestTools.UnitTesting;
using ContinousWeb.Controllers;

namespace ContinousWeb.TESTS
{
    [TestClass]
    public class HomeControllersTests
    {
        [TestMethod]
        public void AboutPageTest()
        {
            var homeController = new HomeController();
            var result = homeController.About();
        }
    }
}
