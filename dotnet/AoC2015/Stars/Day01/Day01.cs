using Helpers;

namespace Stars.Day01;

public class Day01
{
    public int CalculateFinalFloorFromDataFile()
    {
        var finalFloor = 0;
        
        var day01DataFilePath = AppDomain.CurrentDomain.BaseDirectory + "assets/data/day01-data.txt";
        var fio = new FileIO();
        var directions = fio.LoadTextFromFile(day01DataFilePath);

        finalFloor = CalculateFinalFloor(directions);

        return finalFloor;
    }
    
    public int FindIndexWhenReachingBasementFromDataFile()
    {
        var indexReachingBasement = 0;
        var basementLevel = -1;
        
        var day01DataFilePath = AppDomain.CurrentDomain.BaseDirectory + "assets/data/day01-data.txt";
        var fio = new FileIO();
        var directions = fio.LoadTextFromFile(day01DataFilePath);

        indexReachingBasement = FindIndexWhenReachingBasement(directions, basementLevel);

        return indexReachingBasement;
    }
    
    public int CalculateFinalFloor(string directions)
    {
        var currentFloor = 0;

        foreach (var c in directions)
        {
            switch (c)
            {
                case '(':
                    currentFloor++;
                    break;
                case ')':
                    currentFloor--;
                    break;
            }
        }
        
        return currentFloor;
    }
    
    public int FindIndexWhenReachingBasement(string directions, int basementLevel)
    {
        var currentFloor = 0;
        var directionIndex = 1;

        foreach (var c in directions)
        {
            switch (c)
            {
                case '(':
                    currentFloor++;
                    break;
                case ')':
                    currentFloor--;
                    break;
            }

            if (basementLevel == currentFloor)
            {
                break;
            }

            directionIndex++;
        }
        
        return directionIndex;
    }
}