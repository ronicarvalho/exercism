using System;

class RemoteControlCar
{
    private ushort _distance = 0;
    private ushort _battery = 100;

    public static RemoteControlCar Buy()
    {
        return new();
    }

    public string DistanceDisplay()
    {
        return $"Driven {_distance} meters";
    }

    public string BatteryDisplay()
    {
        return (_battery == 0) ? "Battery empty" : $"Battery at {_battery}%";
    }

    public void Drive()
    {
        if (_battery == 0) return;

        _battery--;
        _distance += 20;
    }
}
