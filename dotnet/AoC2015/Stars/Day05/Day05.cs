namespace Stars.Day05;

public class Day05
{
    public int TestStringFromFile(int version)
    {
        var totalNiceStrings = 0;
        
        var day05DataFilePath = AppDomain.CurrentDomain.BaseDirectory + "assets/data/day05-data.txt";
        var fio = new FileIO();
        var stringListToTest = fio.LoadTextLinesFromFile(day05DataFilePath);

        foreach (var stringToTest in stringListToTest)
        {
            if (version == 1)
            {
                if (TestStringV1(stringToTest))
                {
                    totalNiceStrings++;
                }
            }
            else if (version == 2)
            {
                if (TestStringV2(stringToTest))
                {
                    totalNiceStrings++;
                }
            }
            else if (version == 3)
            {
                if (TestStringV3(stringToTest))
                {
                    totalNiceStrings++;
                }
            }
        }
        
        return totalNiceStrings;
    }
    
    public bool TestStringV1(string stringToTest)
    {
        var isNice = false;

        var vowelList = new List<char>{ 'a', 'e', 'i', 'o', 'u' };
        var forbiddenTextList = new List<string> { "ab", "cd", "pq", "xy"};
        
        var vowelCount = 0;
        var repeatedCharacterCount = 0;
        
        for (var i = 0; i < stringToTest.Length; i++)
        {
            if (vowelList.Contains(stringToTest[i]))
            {
                vowelCount++;
            }

            if (i > 0)
            {
                var  twoChars = stringToTest[i - 1] + "" + stringToTest[i];
                if (forbiddenTextList.Contains(twoChars))
                {
                    return false;
                }
                
                if (stringToTest[i] == stringToTest[i - 1])
                {
                    repeatedCharacterCount++;
                }
            }
        }
        
        if (vowelCount >= 3 && repeatedCharacterCount > 0)
        {
            isNice = true;
        }
        
        return isNice;
    }
    
    public bool TestStringV2(string stringToTest)
    {
        var isNice = false;

        var repeatedCharacterCount = 0;
        
        for (var i = 0; i < stringToTest.Length; i++)
        {
            if (i > 1)
            {
                if (stringToTest[i] == stringToTest[i - 2])
                {
                    repeatedCharacterCount++;
                }
            }
        }

        var pairCount = new Dictionary<string, int>();
        
        var index = 0;
        while (index < stringToTest.Length)
        {
            if (index > 0)
            {
                if (stringToTest[index - 1] == stringToTest[index])
                {
                    var pairString = stringToTest[index - 1] + "" + stringToTest[index];

                    if (!pairCount.TryAdd(pairString, 1))
                    {
                        pairCount[pairString]++;
                    }
                    
                    index++;
                }
            }
            
            index++;
        }
        
        if (pairCount.Count > 1 && repeatedCharacterCount > 0)
        {
            isNice = true;
        }
        
        if (stringToTest == "agbhxcijxjxerxyi")
        {
            Console.WriteLine("V2");
            Console.WriteLine($" text = {stringToTest}");
            Console.WriteLine($" PairCount = {pairCount.Count}, repeatedCharacterCount = {repeatedCharacterCount}, isNice = {isNice}");
        }
        return isNice;
    }

    public bool TestStringV3(string line)
    {
        var appearsTwice = Enumerable.Range(0, line.Length - 1).Any(i => line.IndexOf(line.Substring(i, 2), i+2) >= 0); 
        var repeats = Enumerable.Range(0, line.Length - 2).Any(i => line[i] == line[i + 2]);
        var result = appearsTwice && repeats;

        if (line == "agbhxcijxjxerxyi")
        {
            Console.WriteLine("V3");
            Console.WriteLine($" text = {line}");
            Console.WriteLine($" PairCount = {appearsTwice}, repeatedCharacterCount = {repeats}, isNice = {result}");
        }
        //Console.WriteLine(result ? $"[InlineData(\"{line}\", true)]" : $"[InlineData(\"{line}\", false)]");

        return result;
    }
}