using System;
using System.Collections.Generic;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myDict)
    {
        string bestKey = "None";
        int bestValue = 0;

        foreach (var kvp in myDict)
        {
            if (kvp.Value > bestValue)
            {
                bestKey = kvp.Key;
                bestValue = kvp.Value;
            }
        }

        return bestKey;
    }
}