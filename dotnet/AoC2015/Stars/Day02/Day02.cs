namespace Stars.Day02;

public class Day02
{
    public PackageInformation CalculateSquareFeetFromDataFile()
    {
        var piTotal = new PackageInformation();
        
        var totalArea = 0;
        
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
            totalArea += pi.SquareFootageNeededToWrap;
        }

        piTotal.SquareFootageNeededToWrap = totalArea;
        
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
        var totalArea = packageArea + slackArea;

        var pi = new PackageInformation();
        pi.SquareFootageNeededToWrap = totalArea;
        
        return pi;
    }
}

public class PackageInformation
{
    public int SquareFootageNeededToWrap = 0;
    public int LengthFeetNeededForRibbon = 0;
    public int PackageVolume = 0;
}