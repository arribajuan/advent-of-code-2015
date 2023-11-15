using Xunit;

namespace Stars.Day01;

public class Day01Test
{
    [Fact]
    public void TestEmptyDirections()
    {
        var d01 = new Day01();
        var finalFloor = d01.CalculateFinalFloor("");
        
        Assert.Equal(0, finalFloor);
    }
    
    [Theory]
    [InlineData("(())", 0)]
    [InlineData("()()", 0)]
    [InlineData("(((", 3)]
    [InlineData("(()(()(", 3)]
    [InlineData("))(((((", 3)]
    [InlineData("())", -1)]
    [InlineData("))(", -1)]
    [InlineData(")))", -3)]
    [InlineData(")())())", -3)]
    public void TestSampleDirections(string directions, int finalFloor)
    {
        var d01 = new Day01();
        Assert.True(finalFloor == d01.CalculateFinalFloor(directions));
    }
}