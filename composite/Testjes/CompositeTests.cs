using NUnit.Framework;

namespace Testjes;

public class Tests
{
    [Test]
    public void EmptyContainerReturnsZero()
    {
        // Arrange
        var expected = 0;
        var c = CompsiteBuilder.CreateEmptyContainer();
        
        // Act
        var actual = c.Weight;
        
        // Assert
        Assert.AreEqual(expected, actual);
    }
    
    [Test]
    public void ContainerWithOneLeafReturnsOne()
    {
        // Arrange
        var expected = 1;
        var c = CompsiteBuilder.CreateContainerWithOneLeaves();
        
        // Act
        var actual = c.Weight;

        // Assert
        Assert.AreEqual(expected, actual);
    }
    
    [Test]
    public void ContainerWithTwoLeafsReturnsTwo()
    {
        // Arrange
        var expected = 2;
        var c = CompsiteBuilder.CreateContainerWithTwoLeaves();
        
        // Act
        var actual = c.Weight;

        // Assert
        Assert.AreEqual(expected, actual);
    }
    
    [Test]
    public void ContainerWithThreeLeafsReturnsThree()
    {
        // Arrange
        var expected = 3;
        var c = CompsiteBuilder.CreateContainerWithThreeLeaves();
        
        // Act
        var actual = c.Weight;

        // Assert
        Assert.AreEqual(expected, actual);
    }
    
    [Test]
    public void ContainerWithSimpleNestingReturnsThree()
    {
        // Arrange
        var expected = 3;
        var c = CompsiteBuilder.CreateContainerWithSimpleNesting();
        
        // Act
        var actual = c.Weight;

        // Assert
        Assert.AreEqual(expected, actual);
    }
    
    [Test]
    public void ContainerWithComplexNestingReturnsFourteen()
    {
        // Arrange
        var expected = 14;
        var c = CompsiteBuilder.CreateContainerWithComplexNesting();
        
        // Act
        var actual = c.Weight;

        // Assert
        Assert.AreEqual(expected, actual);
    }
}