namespace Stars.Day03;

public class Day03
{
    public DeliveryResults ExecuteMovesFromFile(int roboSantaCount)
    {
        var day03DataFilePath = AppDomain.CurrentDomain.BaseDirectory + "assets/data/day03-data.txt";
        var fio = new FileIO();
        var moves = fio.LoadTextFromFile(day03DataFilePath);

        var results = ExecuteMoves(moves, roboSantaCount);

        return results;
    }

    public DeliveryResults ExecuteMoves(string moves, int roboSantaCount)
    {
        var deliveryLog = new Dictionary<string, int>();
        
        var totalDeliveryAgents = roboSantaCount + 1;   // Santa is always one delivery agent
        var coordinateList = new List<DeliveryCoordinate>();
        for (int i = 0; i < totalDeliveryAgents; i++)
        {
            coordinateList.Add(new DeliveryCoordinate());
        }
        
        // Everyone delivers in the initial location
        foreach (DeliveryCoordinate coordinate in coordinateList)
        {
            DeliverToCoordinate(coordinate.X, coordinate.Y, ref deliveryLog);
        }

        var index = 0;
        foreach (var c in moves)
        {
            switch (c)
            {
                case '<':
                    coordinateList[index].X--;
                    break;
                case '>':
                    coordinateList[index].X++;
                    break;
                case 'v':
                    coordinateList[index].Y--;
                    break;
                case '^':
                    coordinateList[index].Y++;
                    break;
            }
            
            DeliverToCoordinate(coordinateList[index].X, coordinateList[index].Y, ref deliveryLog);

            if (index == totalDeliveryAgents - 1)
            {
                index = 0;
            }
            else
            {
                index++;
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

public class DeliveryCoordinate
{
    public int X = 0;
    public int Y = 0;
}