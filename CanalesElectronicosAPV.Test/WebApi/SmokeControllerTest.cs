using CanalesElectronicosAPV.Controllers;
using NUnit.Framework;

namespace CanalesElectronicosAPV.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void SmokeTest()
        {
            //Arrange
            string response = "Is running...";
            //Act
            SmokeController controller = new SmokeController();
            string isRunning = controller.Test();
            //Assert
            Assert.AreEqual(isRunning, response);
        }
    }
}