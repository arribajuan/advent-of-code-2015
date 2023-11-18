namespace Stars.Day03;

public class Day03
{
    public DeliveryResults ExecuteMovesFromFile()
    {
        var day03DataFilePath = AppDomain.CurrentDomain.BaseDirectory + "assets/data/day03-data.txt";
        var fio = new FileIO();
        var moves = fio.LoadTextFromFile(day03DataFilePath);

        var results = ExecuteMoves(moves);

        return results;
    }
    
    public DeliveryResults ExecuteMovesRoboSantaFromFile()
    {
        var day03DataFilePath = AppDomain.CurrentDomain.BaseDirectory + "assets/data/day03-data.txt";
        var fio = new FileIO();
        var moves = fio.LoadTextFromFile(day03DataFilePath);

        var results = ExecuteMovesRoboSanta(moves);

        return results;
    }
    
    public DeliveryResults ExecuteMoves(string moves)
    {
        var xCoordinate = 0;
        var yCoordinate = 0;
        var deliveryLog = new Dictionary<string, int>();

        DeliverToCoordinate(xCoordinate, yCoordinate, ref deliveryLog);
        
        foreach (var c in moves)
        {
            switch (c)
            {
                case '<':
                    xCoordinate--;
                    break;
                case '>':
                    xCoordinate++;
                    break;
                case 'v':
                    yCoordinate--;
                    break;
                case '^':
                    yCoordinate++;
                    break;
            }
            
            DeliverToCoordinate(xCoordinate, yCoordinate, ref deliveryLog);
        }

        var results = new DeliveryResults()
        {
            HousesWithAtLeastOnePresent = deliveryLog.Count
        };
        
        return results;
    }
    
    public DeliveryResults ExecuteMovesRoboSanta(string moves)
    {
        var xCoordinateSanta = 0;
        var yCoordinateSanta = 0;
        var xCoordinateRoboSanta = 0;
        var yCoordinateRoboSanta = 0;
        var deliveryLog = new Dictionary<string, int>();

        DeliverToCoordinate(xCoordinateSanta, yCoordinateSanta, ref deliveryLog);
        DeliverToCoordinate(xCoordinateRoboSanta, yCoordinateRoboSanta, ref deliveryLog);

        bool flag = true;
        foreach (var c in moves)
        {
            if (flag)
            {
                switch (c)
                {
                    case '<':
                        xCoordinateSanta--;
                        break;
                    case '>':
                        xCoordinateSanta++;
                        break;
                    case 'v':
                        yCoordinateSanta--;
                        break;
                    case '^':
                        yCoordinateSanta++;
                        break;
                }
                
                DeliverToCoordinate(xCoordinateSanta, yCoordinateSanta, ref deliveryLog);
                flag = false;
            }
            else
            {
                switch (c)
                {
                    case '<':
                        xCoordinateRoboSanta--;
                        break;
                    case '>':
                        xCoordinateRoboSanta++;
                        break;
                    case 'v':
                        yCoordinateRoboSanta--;
                        break;
                    case '^':
                        yCoordinateRoboSanta++;
                        break;
                }
                
                DeliverToCoordinate(xCoordinateRoboSanta, yCoordinateRoboSanta, ref deliveryLog);
                flag = true;
            }
        }

        var results = new DeliveryResults()
        {
            HousesWithAtLeastOnePresent = deliveryLog.Count
        };
        
        return results;
    }
    
    private void DeliverToCoordinate(int xCoordinate, int yCoordinate, ref Dictionary<string, int> deliveryLog)
    {
        var coordinateString = xCoordinate + "-" + yCoordinate;

        if (!deliveryLog.TryAdd(coordinateString, 1))
        {
            deliveryLog[coordinateString]++;
        }
    }
}

public class DeliveryResults
{
    public int HousesWithAtLeastOnePresent = 0;
}