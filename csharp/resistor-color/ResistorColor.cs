using System;

public static class ResistorColor
{
    private static string[] mnemonics = {"black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white"};

    public static int ColorCode(string color)
    {
        return Array.IndexOf(mnemonics, color);
    }

    public static string[] Colors()
    {
        return mnemonics;
    }
}