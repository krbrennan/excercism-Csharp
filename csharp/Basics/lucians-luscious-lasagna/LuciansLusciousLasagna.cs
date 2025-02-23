using System;
using System.Net.Http;
using System.Reflection.Metadata.Ecma335;

class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven()
    {
        return 40;
    }

    // TODO: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int time)
    {
        if (time >= 40) 
        {
            return 0;
        }
        return 40 - time;   
    }
    // TODO: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int layers)
    {
        return layers * 2;
    }


    
    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int layers, int minutesInOven)
    {
        return this.PreparationTimeInMinutes(layers) + minutesInOven;
    }

}
