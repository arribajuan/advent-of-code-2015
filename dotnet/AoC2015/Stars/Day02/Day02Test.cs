namespace Stars.Day02;

public class Day02Test
{
    
    [Theory]
    [InlineData(2, 3, 4, 58)]
    [InlineData(1, 1, 10, 43)]
    public void Test_Day2_CalculateFinalFloor_SampleDirections(int length, int width, int height, int totalPaper)
    {
        var d02 = new Day02();
        var packageInformation = d02.CalculateSquareFeet(length, width, height);

        Assert.Equal(totalPaper , packageInformation.SquareFootageNeededToWrap);
    } 
    
}