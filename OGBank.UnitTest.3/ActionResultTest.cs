using Microsoft.AspNetCore.Mvc;
using OGBank.Controllers;

namespace OGBank.UnitTest._3
{
    [TestClass]
    public class ActionResultTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var controller = new TestController();
            var result = (RedirectToActionResult) controller.Details(-1);
            Assert.AreEqual("Index", result.ActionName);
        }
    }
}