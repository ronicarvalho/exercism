using System;

public static class CollatzConjecture
{
    public static int Steps(int number)
    {
        if (number <= 0) throw new ArgumentOutOfRangeException();
        if (number == 1) return 0;

        var steps = 1;

        while ((number = ((number ^ 1) == number + 1) ? (number / 2) : ((number * 3) + 1)) != 1) 
            steps++;

        return steps;
    }
}