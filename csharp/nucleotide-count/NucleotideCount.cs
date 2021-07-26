using System;
using System.Collections.Generic;

public static class NucleotideCount
{
    public static IDictionary<char, int> Count(string sequence)
    {
        Dictionary<char, int> d = new Dictionary<char, int>{{'G', 0}, {'A', 0}, {'C', 0}, {'T', 0}};
        foreach (char c in sequence){
            if (d.ContainsKey(c)){ d[c] += 1; } else { throw new ArgumentException(); }
        }
        return d;
    }
}