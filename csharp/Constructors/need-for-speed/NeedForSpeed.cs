using System.Runtime.CompilerServices;

class RemoteControlCar
{
    // TODO: define the constructor for the 'RemoteControlCar' class
    //private int speed { get; set; }
    //private int batteryDrain { get; set; }
    private int speed;
    private int batteryDrain;

    private int distanceDriven = 0;
    private int batteryPercent = 100;

    public RemoteControlCar(int speed, int batteryDrain)
    {
        this.speed = speed;
        this.batteryDrain = batteryDrain;
    }

    public bool BatteryDrained()
    {
        return this.batteryPercent < this.batteryDrain;
    }

    public int DistanceDriven()
    {
        return this.distanceDriven;
    }

    public void Drive()
    {
        if (!BatteryDrained())
        {
            this.distanceDriven += this.speed;
            this.batteryPercent -= this.batteryDrain;
        }

    }


    public static RemoteControlCar Nitro()
    {
        return new RemoteControlCar(50, 4);
    }
}

class RaceTrack
{
    // TODO: define the constructor for the 'RaceTrack' class
    private int distance;

    public RaceTrack(int distance)
    {
        this.distance = distance;
    }


    public bool TryFinishTrack(RemoteControlCar car)
    {

        // if the car keep Drive() at speed x, will it have battery>0 once distance is met?
        while(!car.BatteryDrained() && car.DistanceDriven() < this.distance)
        {
            car.Drive();
        }

        return car.DistanceDriven() >= this.distance;
    }
}
