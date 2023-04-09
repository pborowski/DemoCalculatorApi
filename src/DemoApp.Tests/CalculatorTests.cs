using DemoApp.Api;
using Xunit;

namespace DemoApp.Tests;

public class CalculatorTests
{
    [Fact]
    public void Add_TwoPositiveIntegers_ReturnsCorrectResult()
    {
        // Arrange
        var a = 2;
        var b = 3;

        // Act
        var result = Calculator.Add(a, b);

        // Assert
        Assert.Equal(5, result);
    }

    [Fact]
    public void Subtract_TwoPositiveIntegers_ReturnsCorrectResult()
    {
        // Arrange
        var a = 5;
        var b = 2;

        // Act
        var result = Calculator.Subtract(a, b);

        // Assert
        Assert.Equal(3, result);
    }

    [Fact]
    public void Multiply_TwoPositiveIntegers_ReturnsCorrectResult()
    {
        // Arrange
        var a = 2;
        var b = 3;

        // Act
        var result = Calculator.Multiply(a, b);

        // Assert
        Assert.Equal(6, result);
    }

    [Fact]
    public void Divide_TwoPositiveIntegers_ReturnsCorrectResult()
    {
        // Arrange
        var a = 10;
        var b = 2;

        // Act
        var result = Calculator.Divide(a, b);

        // Assert
        Assert.Equal(5, result);
    }

    [Fact]
    public void Divide_ByZero_ThrowsDivideByZeroException()
    {
        // Arrange
        var a = 10;
        var b = 0;

        // Act and Assert
        Assert.Throws<DivideByZeroException>(() => Calculator.Divide(a, b));
    }
}