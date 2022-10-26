using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public static class CryptoSquare
{
    private static int _chunkSize;
    private static int _chunkCount;
    
    private const char Space = ' ';

    private static string NormalizedPlaintext(string plaintext) =>
        Regex.Replace(plaintext, @"\W", string.Empty).ToLower();

    private static IEnumerable<string> PlaintextSegments(string plaintext) =>
        Enumerable.Range(0, _chunkCount).Select(x => plaintext[(x * _chunkSize)..].PadRight(_chunkSize, Space));

    private static string Encoded(string plaintext) =>
        string.Join(Space, Enumerable.Range(0, _chunkSize)
            .Select(x => string.Concat(PlaintextSegments(plaintext).Select(segment => segment[x]))));

    public static string Ciphertext(string plaintext)
    {
        var normalized = NormalizedPlaintext(plaintext);
        var length = Math.Sqrt(normalized.Length);
        
        _chunkCount = (int)(normalized.Length < 9 ? Math.Ceiling(length) : length);
        _chunkSize = (int)Math.Ceiling(length);
        
        return Encoded(normalized);
    }
}