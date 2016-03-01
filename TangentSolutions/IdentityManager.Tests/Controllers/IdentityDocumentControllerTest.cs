using IdentityManager.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IdentityManager.Tests.Controllers
{
    [TestClass]
    public class IdentityDocumentControllerTest
    {
        [TestMethod]
        public void GetRandomRsaId()
        {
            // Arrange
            var controller = new IdentityDocumentController();

            // Act
            var randomIdA = controller.GetRandomRsaId();
            var randomIdB = controller.GetRandomRsaId();

            // Assert
            Assert.IsTrue(!string.IsNullOrEmpty(randomIdA));
            Assert.IsTrue(!string.IsNullOrEmpty(randomIdB));
            Assert.AreNotEqual(randomIdA, randomIdB);
        }
    }
}
