using System;

static class AssemblyLine
{
    private const int productionPerHour = 221;

    public static double SuccessRate(int speed) => speed switch
    {
        var _speed when (_speed >= 1 && _speed <= 4) => 1.0,
        var _speed when (_speed >= 5 && _speed <= 8) => 0.9,
        var _speed when (_speed == 9) => 0.8,
        var _speed when (_speed == 10) => 0.77,
        _ => 0.0
    };
    
    public static double ProductionRatePerHour(int speed)
    {
        return (speed * productionPerHour) * SuccessRate(speed);
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        return (int) ProductionRatePerHour(speed) / 60;
    }
}
