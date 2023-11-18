namespace Stars.Day04;

public class Day04Test
{
    [Theory]
    [InlineData("abcdef", 609043)]
    [InlineData("pqrstuv", 1048970)]
    public void Test_Day4_MineAdventCoin_SampleSecretKeys(string secretKey, int lowestPositiveNumber)
    {
        var d04 = new Day04();
        var result = d04.MineAdventCoin5(secretKey);

        Assert.Equal(lowestPositiveNumber, result);
    }
}