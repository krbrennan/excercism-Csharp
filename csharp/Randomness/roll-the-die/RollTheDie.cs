using System;

public class Player
{
    public int RollDie()
    {
        Random randoNum = new Random();
        int randomNumRange = randoNum.Next(1, 18);
        return randomNumRange;
    }

    public double GenerateSpellStrength()
    {
        Random spellStrength = new Random();
        double randomStrength = spellStrength.NextDouble();

        return randomStrength * 100;

    }
}
