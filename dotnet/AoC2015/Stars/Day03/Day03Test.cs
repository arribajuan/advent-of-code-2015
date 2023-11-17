namespace Stars.Day03;

public class Day03Test
{
    
    [Theory]
    [InlineData(">", 2)]
    [InlineData("^>v<", 4)]
    [InlineData("^v^v^v^v^v", 2)]
    public void Test_Day2_CalculateFinalFloor_SampleDirections(string moves, int housesWithAtLeastOnePresent)
    {
        var d03 = new Day03();
        var result = d03.ExecuteMoves(moves);

        Assert.Equal(housesWithAtLeastOnePresent , result.HousesWithAtLeastOnePresent);
    } 
    
}