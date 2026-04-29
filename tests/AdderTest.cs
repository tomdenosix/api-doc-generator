using FluentAssertions;

namespace ApiDoc.Generator.Tests;

public class AdderTest
{
    [Fact]
    public void AddingTwoPositiveIntegersReturnsCorrectResult()
    {
        // Arrange
        int expectedResult = 4, first = 1, second = 3;
        Adder adder = new Adder();

        // Act
        var actualResult = adder.Add(first, second);

        // Assert
        actualResult.Should().Be(expectedResult,$"{first} + {second} is {expectedResult}");
    }
}
