using System;
using System.Text.RegularExpressions;

static class LogLine
{
    public static string Message(string logLine)
    {
        return Regex.Replace(logLine, "[[[A-Z]+]:", string.Empty).Trim();
    }

    public static string LogLevel(string logLine)
    {
        return Regex.Replace(logLine, @"(\[|\]|\:|\s(\w+))", string.Empty).Trim().ToLower();
    }

    public static string Reformat(string logLine)
    {
        return $"{Message(logLine)} ({LogLevel(logLine)})";
    }
}
