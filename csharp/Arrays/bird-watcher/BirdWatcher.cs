class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        //int totalBirdsLastWeek = 0;
        //   for(int i = _birdsPerDay.Length - 1; i >= 0; i--)
        //   {

        //   }
        //This exercise isn't designed very well. It should populate the private birdsPerDay array so that I can iterate over it here, but the exercise wants me to hard-code last weeks values? That is nonsensical, I must be missing something...This seems bass ackwards
        int[] birdsLastWeek = { 0, 2, 5, 3, 7, 8, 4 };
        return birdsLastWeek;
    }

    public int Today()
    {
        return this.birdsPerDay[birdsPerDay.Length - 1];

    }

    public void IncrementTodaysCount()
    {
        int today = Today();
        int newToday = today+=1;
        this.birdsPerDay[birdsPerDay.Length - 1] = newToday;
    }

    public bool HasDayWithoutBirds()
    {
        for(int i = 0; i < birdsPerDay.Length - 1; i++)
        {
            if (birdsPerDay[i] == 0)
            {
                return true;
            }
        }
        return false;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int birdsSeen = 0;
        for(int i = 0; i < numberOfDays; i++)
        {
            birdsSeen += birdsPerDay[i];
        }
        return birdsSeen;
    }

    public int BusyDays()
    {
        int numberBusyDays = 0;
        for (int i = 0; i <= birdsPerDay.Length - 1; i++)
        {
            if (birdsPerDay[i] >= 5) { numberBusyDays += 1; }
        }
        return numberBusyDays;
    }
}
