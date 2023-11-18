namespace Stars.Day05;

public class Day05
{
    public bool TestString(string stringToTest)
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
}