using Microsoft.AspNetCore.Mvc;
using OGBank.Controllers;
using OGBank.Models;

namespace Unit_Test_2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var controller = new TestController();
            var result = controller.Details(2) as ViewResult;
            var admin = (Admin)result.ViewData.Model;
            Assert.AreEqual("George", admin.Name);
        }
    }
}