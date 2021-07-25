using System;

public static class Hamming
{
    public static int Distance(string firstStrand, string secondStrand)
    {
        int hamming_score = 0;
        if (firstStrand.Length != secondStrand.Length) {throw new ArgumentException();}
        for (int i = 0; i < firstStrand.Length; i++){ if (firstStrand[i] != secondStrand[i]) { hamming_score++; } };
        return hamming_score;
    }
}