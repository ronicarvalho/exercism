using System;
using System.Collections.Generic;

public class Lasagna
{
    public int ExpectedMinutesInOven() => 40;

    public int RemainingMinutesInOven(int time) => ExpectedMinutesInOven() - time;

    public int PreparationTimeInMinutes(int layer) => layer * 2;

    public int ElapsedTimeInMinutes(int layers, int time) => PreparationTimeInMinutes(layers) + time;
}
