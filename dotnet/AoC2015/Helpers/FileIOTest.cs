namespace Helpers;

public class FileIOTest
{
    [Fact]
    public void TestNonExistentFile()
    {
        List<string> emptyData = new List<string>();
        
        FileIO fio = new FileIO();
        List<string> resultData = fio.LoadTextLinesFromFile("");
    }

    [Fact]
    public void TestFile()
    {
        string testDataPath = AppDomain.CurrentDomain.BaseDirectory + "assets/data/test-data.txt";
        
        FileIO fio = new FileIO();
        List<string> resultData = fio.LoadTextLinesFromFile(testDataPath);
        
        Assert.NotEmpty(resultData);
    }


}