using Microsoft.EntityFrameworkCore;
using Moq;
using OGBank.Areas.Identity.Data;
using OGBank.Models;

namespace TestProject5

{
    [TestClass]
    public class UnitTest1
    {
        private Mock<AuthenticationContext> mockContext;
        private Mock<DbSet<User>> mockDbSet;

        [TestInitialize]
        public void Setup()
        {
            var options = new DbContextOptions<AuthenticationContext>();
            mockContext = new Mock<AuthenticationContext>(options);
            mockDbSet = new();

            mockContext.Setup(c => c.Set<User>()).Returns(mockDbSet.Object); 
        }

        [TestMethod]
        public void TestMethod1()
        {
            var user = new User
            {
                Id = 123,
                Email = "Dutescu@gmail.com"
            };
        }
    }
}