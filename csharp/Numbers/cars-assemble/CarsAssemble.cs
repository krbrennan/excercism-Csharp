static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
        //throw new NotImplementedException("Please implement the (static) AssemblyLine.SuccessRate() method");
        if (speed <= 0)
        {
            return 0.0;
        } else if (speed > 0 && speed <= 4)
        {
            return 1.0;
        } else if (speed > 4 && speed <= 8)
        {
            return 0.9;
        } else if (speed == 9)
        {
            return 0.8;
        } else
        {
            return 0.77;
        }

    }
    
    public static double ProductionRatePerHour(int speed)
    {
        //throw new NotImplementedException("Please implement the (static) AssemblyLine.ProductionRatePerHour() method");
        // speed 1 == 221 cars
        // speed 4 == 4 * 221 = 884 (but consider failure rates)
        return ((221 * speed) * SuccessRate(speed));
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        //throw new NotImplementedException("Please implement the (static) AssemblyLine.WorkingItemsPerMinute() method");
        return (int)ProductionRatePerHour(speed) / 60;
    }
}
