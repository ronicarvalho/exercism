using System;
using System.Text;
using System.Text.RegularExpressions;

public static class Acronym
{
    public static string Abbreviate(string phrase)
    {
        var acronym = new StringBuilder();
        var splitted = phrase.Split(new[] { ' ', '-', '_' }, StringSplitOptions.RemoveEmptyEntries);

        for (var i = 0; i < splitted.Length; i++)
        {
            if (char.IsLetter(splitted[i][0])) 
                acronym.Append(splitted[i][0]);
        }

        return acronym.ToString().ToUpper();
    }
}