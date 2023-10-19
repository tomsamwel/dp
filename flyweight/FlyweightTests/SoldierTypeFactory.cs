using Flyweight_Pattern_Example_Redcoats;
using NUnit.Framework;

namespace FlyweightTests
{
    public class SoldierTypeFactoryTests
    {
        [Test]
        public void GetSoldierType_SameInput_returnsSameSoldierType()
        {
            // Arrange
            SoldierTypeFactory factory = new SoldierTypeFactory();
            // Act 
            var result1 = factory.GetSoldierType("Specialist", 3, 3);
            var result2 = factory.GetSoldierType("Specialist", 3, 3);
            //Assert
            Assert.AreEqual(result1, result2);
        }

        [Test]
        public void GetSoldierType_DifferentInput_returnsDifferentSoldierType()
        {
            // Arrange
            SoldierTypeFactory factory = new SoldierTypeFactory();
            // Act 
            var result1 = factory.GetSoldierType("Specialist", 3, 3);
            var result2 = factory.GetSoldierType("Specialist", 3, 4);
            //Assert
            Assert.AreNotEqual(result1, result2);
        }
    }
}