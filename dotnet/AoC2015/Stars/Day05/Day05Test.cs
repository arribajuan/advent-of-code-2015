namespace Stars.Day05;

public class Day05Test
{
    
    [Theory]
    [InlineData("ugknbfddgicrmopn", true)]
    [InlineData("aaa", true)]
    [InlineData("jchzalrnumimnmhp", false)]
    [InlineData("haegwjzuvuyypxyu", false)]
    [InlineData("dvszwmarrgswjxmb", false)]
    public void Test_Day4_MineAdventCoin_SampleSecretKeys(string stringToTest, bool isNice)
    {
        var d05 = new Day05();
        var result = d05.TestString(stringToTest);

        Assert.Equal(isNice, result);
    }
    
}