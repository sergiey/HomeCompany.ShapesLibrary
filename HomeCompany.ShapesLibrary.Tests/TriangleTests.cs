namespace HomeCompany.ShapesLibrary.Tests;

public class TriangleTests
{
//  имя тестируемого метода;
// сценарий, в котором выполняется тестирование;
// ожидаемое поведение при вызове сценария.
// Add_SingleNumber_ReturnsSameNumber()

    [Fact]
    public void Instantiation_Side1LessThanOrEqualZero_ThrowException()
    {
        // Arrange
        var expectedException = new ArgumentOutOfRangeException("Side1");
        
        // Act
        var thrownException =
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(0, 1, 2));
       
        // Assert
        Assert.Equal(expectedException.Message, thrownException.Message);
    }
    
    [Fact]
    public void Instantiation_Side2LessThanOrEqualZero_ThrowException()
    {
        // Arrange
        var expectedException = new ArgumentOutOfRangeException("Side2");
        
        // Act
        var thrownException =
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(1, 0, 2));
       
        // Assert
        Assert.Equal(expectedException.Message, thrownException.Message);
    }
    
    [Fact]
    public void Instantiation_Side3LessThanOrEqualZero_ThrowException()
    {
        // Arrange
        var expectedException = new ArgumentOutOfRangeException("Side3");
        
        // Act
        var thrownException =
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(1, 2, 0));
       
        // Assert
        Assert.Equal(expectedException.Message, thrownException.Message);
    }
    
    [Fact]
    public void Instantiation_SidesLengthMismatch_ThrowException()
    {
        // Arrange
        var expectedException = new ArgumentOutOfRangeException("Еriangle sides length mismatch");
        
        // Act
        var thrownException =
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(1, 2, 3));
       
        // Assert
        Assert.Equal(expectedException.Message, thrownException.Message);
    }

    [Theory]
    [InlineData(1, 2, 2, 0.968)]
    [InlineData(1.5, 2.5, 2.5, 1.789)]
    [InlineData(3, 3, 1, 1.479)]
    public void GetArea_CalculateArea_ReturnsCorrectResults(
        double s1, double s2, double s3, double expectedResult)
    {
        // Arrange
        var triangle = new Triangle(s1, s2, s3);
        
        // Act
        var actualResult = triangle.GetArea();
        
        // Assert
        Assert.Equal(expectedResult, actualResult, 3);
    }

    [Theory]
    [InlineData(2, 3, 3.61, true)]
    [InlineData(1, 3, 3, false)]
    public void IsRightAngled_DefineRightAngle_ReturnsCorrectResult(
        double s1, double s2, double s3, bool expectedResult)
    {
        // Arrange
        var triangle = new Triangle(s1, s2, s3);
        
        // Act
        var actualResult = triangle.IsRightAngled();
        
        // Assert
        Assert.Equal(expectedResult, actualResult);
    }
}