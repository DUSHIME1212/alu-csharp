using System.Collections.Generic;

namespace Text
{
    public static class Str
{
    public static int UniqueChar(string input)
    {
        var charCount = new Dictionary<char, int>();

        
        foreach (var c in input)
        {
            if (charCount.ContainsKey(c))
            {
                charCount[c]++;
            }
            else
            {
                charCount[c] = 1;
            }
        }

        
        for (int i = 0; i < input.Length; i++)
        {
            if (charCount[input[i]] == 1)
            {
                return i; 
            }
        }

        return -1; 
    }
}

    }

