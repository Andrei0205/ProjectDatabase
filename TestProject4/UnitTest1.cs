using Microsoft.AspNetCore.Mvc;
using OGBank.Controllers;

namespace TestProject4
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var controller = new UnitTestController();
            var result = (RedirectToActionResult)controller.Details(-1);
            Assert.AreEqual("Index", result.ActionName);
        }
    }
}