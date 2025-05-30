using System;
using System.Collections.Generic;

public class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        
        if (myList == null || myList.Count == 0)
            return "None";

        
        string bestKey = null;
        int highestValue = int.MinValue;

        
        foreach (var entry in myList)
        {
            if (entry.Value > highestValue || bestKey == null)
            {
                highestValue = entry.Value;
                bestKey = entry.Key;
            }
        }

        return bestKey ?? "None";
    }
}
