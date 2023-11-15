namespace Stars.Day02;

public class Day02
{
    public PackageInformation CalculateSquareFeetFromDataFile()
    {
        var totalArea = 0;
        var totalLength = 0;

        var day02DataFilePath = AppDomain.CurrentDomain.BaseDirectory + "assets/data/day02-data.txt";
        var fio = new FileIO();
        var packages = fio.LoadTextLinesFromFile(day02DataFilePath);

        foreach (string packageDimensions in packages)
        {
            string[] dimensions = packageDimensions.Split("x");
            var length = Convert.ToInt32(dimensions[0]);
            var width = Convert.ToInt32(dimensions[1]);
            var height = Convert.ToInt32(dimensions[2]);

            var pi = CalculateSquareFeet(length, width, height);
            totalArea += pi.TotalPaper;
            totalLength += pi.TotalRibbon;
        }

        var piTotal = new PackageInformation()
        {
            TotalPaper = totalArea,
            TotalRibbon = totalLength
        };
        
        return piTotal;
    }
    
    public PackageInformation CalculateSquareFeet(int length, int width, int height)
    {
        var sides = new List<int>();
        sides.Add(length * width);
        sides.Add(width * height);
        sides.Add(height * length);

        var packageArea = sides.Sum() * 2;
        var slackArea = sides.Min();

        var dimensions = new List<int>();
        dimensions.Add(length);
        dimensions.Add(width);
        dimensions.Add(height);

        dimensions.Sort();
        var smallestPerimeter = (dimensions[0] * 2) + (dimensions[1] * 2);
        var packageVolume = dimensions.Aggregate((a, x) => a * x);

        var pi = new PackageInformation()
        {
            TotalPaper = packageArea + slackArea,
            TotalRibbon = smallestPerimeter + packageVolume
        };
        
        return pi;
    }
}

public class PackageInformation
{
    public int TotalPaper = 0;
    public int TotalRibbon = 0;
}