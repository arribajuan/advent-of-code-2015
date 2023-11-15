using System.Text;

namespace Helpers;

public class FileIO
{
    public List<string> LoadTextLinesFromFile(string fileLocation)
    {
        List<string> result = new List<string>();

        if (File.Exists(fileLocation))
        {
            var fileLines = File.ReadAllLines(fileLocation, Encoding.Default);
            result.AddRange(fileLines);
        }

        return result;
    }
}