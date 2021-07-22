using System;
using System.Collections.Generic;
using System.Linq;

public class HighScores
{
    private List<int> temp;
    public HighScores(List<int> list) { temp = list; }
    public List<int> Scores() { return temp; }
    public int Latest() { return temp.Last(); } 
    public int PersonalBest() { return temp.Max(); } 
    public List<int> PersonalTopThree() { return temp.OrderByDescending(x => x).Take(3).ToList(); }
}