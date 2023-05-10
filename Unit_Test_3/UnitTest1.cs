using Microsoft.AspNetCore.Mvc;
using OGBank.Controllers;

namespace Unit_Test_3
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var controller = new TestController();
            var result = (RedirectToActionResult)controller.Details(-1);
            Assert.AreEqual("Index", result.ActionName);
        }
    }
}