namespace Stars.Day03;

public class Day03
{

    
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