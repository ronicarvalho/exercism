using System;
using System.Collections.Generic;
using System.Linq;

public static class Pangram
{
    public static bool IsPangram(string input)
    {
        // Validate the input

        if (input.Length < 26)
            return false;

        // Prepare the dictionary

        var dictionary = new Dictionary<char, bool>();

        for (var c = 65; c <= 90; c++)
            dictionary.Add((char)c, false);

        // Execute the validation

        var sentence = input.Trim().ToUpper();

        foreach (var c in sentence.ToCharArray())
        {
            if (!dictionary.ContainsKey(c))
                continue;

            dictionary[c] = true;
        }

        return dictionary.Values.All(x => x == true);
    }
}