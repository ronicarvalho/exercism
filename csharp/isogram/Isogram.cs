using System;
using System.Collections.Generic;

public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        var list = new List<char>();
        var sentence = word.ToUpper().Replace(" ", "").Replace("-", "");

        foreach (var c in sentence)
        {
            if (list.Contains(c))
                return false;

            list.Add(c);
        }

        return true;
    }
}