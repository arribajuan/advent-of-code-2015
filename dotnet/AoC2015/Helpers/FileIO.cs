namespace Helpers;

public class FileIO
{
    public List<string> LoadTextLinesFromFile(string fileLocation)
    {
        List<string> result = new List<string>();

        if (fileLocation != "")
        {
            result.Add("Test");
        }

        return result;
    }
}