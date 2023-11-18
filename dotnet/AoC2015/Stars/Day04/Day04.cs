using System.Security.Cryptography;
using System.Text;

namespace Stars.Day04;

public class Day04
{
    public int MineAdventCoin(string secretKey)
    {
        for (var i = 1; i < int.MaxValue; i++)
        {
            var md5Hash = ComputeMD5Hash(secretKey + i);

            if (md5Hash.Length >= 5)
            {
                if (md5Hash.Substring(0, 5) == "00000")
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