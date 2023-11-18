using System.Security.Cryptography;
using System.Text;

namespace Stars.Day04;

public class Day04
{
    public int MineAdventCoinFromFile(int leadingZeroesRequired)
    {
        var day04DataFilePath = AppDomain.CurrentDomain.BaseDirectory + "assets/data/day04-data.txt";
        var fio = new FileIO();
        var secretKey = fio.LoadTextFromFile(day04DataFilePath);

        var results = MineAdventCoin(secretKey, leadingZeroesRequired);

        return results;
    }
    
    public int MineAdventCoin(string secretKey, int leadingZeroesRequired)
    {
        var sb = new StringBuilder();
        for (var i = 0; i < leadingZeroesRequired; i++)
        {
            sb.Append("0");
        }
        var leadingZeroString = sb.ToString();
        
        for (var i = 1; i < int.MaxValue; i++)
        {
            var md5Hash = ComputeMD5Hash(secretKey + i);

            if (md5Hash.Length >= leadingZeroesRequired)
            {
                if (md5Hash.Substring(0, leadingZeroesRequired) == leadingZeroString)
                {
                    return i;
                }
            }
        }

        return 0;
    }

    private string ComputeMD5Hash(string input)
    {
        var hash = string.Empty;
        
        using (var md5Hash = MD5.Create())
        {
            var data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            
            var sBuilder = new StringBuilder();
            foreach (var dataItem in data)
            {
                sBuilder.Append(dataItem.ToString("x2"));
            }
            hash = sBuilder.ToString();
        }
        
        return hash;
    }
}