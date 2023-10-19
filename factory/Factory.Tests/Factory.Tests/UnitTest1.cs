using Factory.Factories;
using NUnit.Framework;
using System;
using System.IO;
using System.Text;

namespace Factory.Tests
{
    [TestFixture]
    public class LogisticsTests
    {
        private StringWriter consoleOutput;

        [SetUp]
        public void Setup()
        {
            consoleOutput = new StringWriter();
            Console.SetOut(consoleOutput);
        }

        [Test]
        public void RoadLogistics_PlanDelivery_DeliversByTruck()
        {
            // Arrange
            Logistics roadLogistics = new RoadLogistics();

            // Act
            roadLogistics.PlanDelivery();

            // Assert
            string expectedOutput = "Planning delivery..." + Environment.NewLine + "Cargo delivered by land (Truck)." + Environment.NewLine;
            Assert.AreEqual(expectedOutput, consoleOutput.ToString());
        }

        [Test]
        public void SeaLogistics_PlanDelivery_DeliversByShip()
        {
            // Arrange
            Logistics seaLogistics = new SeaLogistics();

            // Act
            seaLogistics.PlanDelivery();

            // Assert
            string expectedOutput = "Planning delivery..." + Environment.NewLine + "Cargo delivered by sea (Ship)." + Environment.NewLine;
            Assert.AreEqual(expectedOutput, consoleOutput.ToString());
        }
    }
}