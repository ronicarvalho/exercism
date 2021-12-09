using System;

public enum Classification
{
    Perfect,
    Abundant,
    Deficient
}

public static class PerfectNumbers
{
    public static Classification Classify(int number)
    {
        if (number < 1)
            throw new ArgumentOutOfRangeException();

        var aliquotSum = AliquotSum(number);

        if (aliquotSum > number)
            return Classification.Abundant;
            
        if (aliquotSum < number)
            return Classification.Deficient;

        return Classification.Perfect;
    }

    private static int AliquotSum(int number)
    {
        var sum = 0;

        for (var x = number -1; x > 0; x--)
            sum += (number % x == 0) ? x : 0;

        return sum;
    }
}