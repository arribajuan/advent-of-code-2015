namespace Stars.Day03;

public class Day03Test
{

    [Theory]
    [InlineData(">", 2)]
    [InlineData("^>v<", 4)]
    [InlineData("^v^v^v^v^v", 2)]
    public void Test_Day3_ExecuteMoves_SampleNoves(string moves, int housesWithAtLeastOnePresent)
    {
        var d03 = new Day03();
        var result = d03.ExecuteMoves(moves);

        Assert.Equal(housesWithAtLeastOnePresent, result.HousesWithAtLeastOnePresent);
    }

    [Theory]
    [InlineData("^v", 3)]
    [InlineData("^>v<", 3)]
    [InlineData("^v^v^v^v^v", 11)]
    public void Test_Day3_ExecuteMovesRoboSanta_SampleNoves(string moves, int housesWithAtLeastOnePresent)
    {
        var d03 = new Day03();
        var result = d03.ExecuteMovesRoboSanta(moves);

        Assert.Equal(housesWithAtLeastOnePresent, result.HousesWithAtLeastOnePresent);
    }
    
}