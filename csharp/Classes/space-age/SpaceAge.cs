public class SpaceAge
{
    Dictionary<string, double> timeDict = new Dictionary<string, double>
    {
        {"Mercury", 0.2408467 },
        {"Venus", 0.61519726 },
        {"Earth", 1.0 },
        {"Mars", 1.8808158 },
        {"Jupiter", 11.862615 },
        {"Saturn", 29.447498 },
        {"Uranus", 84.016846 },
        {"Neptune", 164.79132 }
    };
    
    private static int _seconds;
    public SpaceAge(int seconds)
    {
        // create date object
        _seconds = seconds;
    }

    public double GetTimeSpan(double relativeRatio)
    {
        //double 
        TimeSpan ts = TimeSpan.FromSeconds(_seconds);
        double age = ts.TotalDays / 365.25;
        double relativeAge = age * 1/relativeRatio;

        return Math.Round(relativeAge, 2);
    }

    public double OnEarth()
    {
        return GetTimeSpan(timeDict["Earth"]);
    }

    public double OnMercury()
    {
        return GetTimeSpan(timeDict["Mercury"]);
    }

    public double OnVenus()
    {
        return GetTimeSpan(timeDict["Venus"]);
    }

    public double OnMars()
    {
        return GetTimeSpan(timeDict["Mars"]);
    }

    public double OnJupiter()
    {
        return GetTimeSpan(timeDict["Jupiter"]);
    }

    public double OnSaturn()
    {
        return GetTimeSpan(timeDict["Saturn"]);
    }

    public double OnUranus()
    {
        return GetTimeSpan(timeDict["Uranus"]);
    }

    public double OnNeptune()
    {
        return GetTimeSpan(timeDict["Neptune"]);
    }
}