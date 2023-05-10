using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OGBank.Controllers;

namespace OGBank.UnitTest._1
{
    [TestClass]
    public class ViewTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var controller = new TestController();
            var result = controller.Details(2) as ViewResult;
            Assert.AreEqual("Details", result.ViewName);
        }
    }
}