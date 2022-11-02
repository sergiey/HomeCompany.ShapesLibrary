namespace HomeCompany.ShapesLibrary.Tests;

public class CirlceTests
{
    [Fact]
    public void Instantiation_Radius_LessThanOrEqualZero_ThrowException()
    {
        // Arrange
        var expectedException = new ArgumentOutOfRangeException("Radius");
    
        // Act
        var thrownException = 
            Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(0));
        
        // Assert
        Assert.Equal(expectedException.Message, thrownException.Message);
    }

    [Theory]
    [InlineData(1, 3.142)]
    [InlineData(2, 12.566)]
    [InlineData(3, 28.274)]
    public void GetArea_CalculateArea_ReturnsCorrectResult(
        double radius, double expectedResult)
    {
        // Arrange
        var circle = new Circle(radius);
        
        // Act
        var actualResult = circle.GetArea();
        
        // Assert
        Assert.Equal(expectedResult, actualResult, 3);
    }
    
    [Theory]
    [InlineData(1, 6.283)]
    [InlineData(2, 12.566)]
    [InlineData(3, 18.850)]
    public void GetPerimeter_CalculateArea_ReturnsCorrectResult(
        double radius, double expectedResult)
    {
        // Arrange
        var circle = new Circle(radius);
        
        // Act
        var actualResult = circle.GetPerimeter();
        
        // Assert
        Assert.Equal(expectedResult, actualResult, 3);
    }
}