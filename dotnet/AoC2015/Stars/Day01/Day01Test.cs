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
    public void Test_CalculateFinalFloor_SampleDirections(string directions, int finalFloor)
    {
        var d01 = new Day01();
        Assert.Equal(finalFloor , d01.CalculateFinalFloor(directions));
    }
    
    [Theory]
    [InlineData(")", 1)]
    [InlineData("()())", 5)]
    public void Test_FindIndexWhenReachingBasement_SampleDirections(string directions, int basementIndex)
    {
        var basementLevel = -1;
        
        var d01 = new Day01();
        Assert.Equal(basementIndex, d01.FindIndexWhenReachingBasement(directions, basementLevel));
    }
    
}