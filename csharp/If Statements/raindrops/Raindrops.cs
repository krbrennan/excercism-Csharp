using System.ComponentModel.Design;

public static class Raindrops
{
    public static string Convert(int number)
    {
        if( (number % 105 == 0)){
            return "PlingPlangPlong";

        }
        else if (number % 35 == 0)
        {
            return "PlangPlong";
        }
        else if (number % 15 == 0)
        {
            return "PlingPlang";
        } else if (number % 21 == 0)
        {
            return "PlingPlong";
        }
        else if (number % 3 == 0)
        {
            return "Pling";
        } else if (number % 5 == 0) {
            return "Plang";
        }
        else if (number % 7 == 0)
        {
            return "Plong";
        }
        else
        {
            return number.ToString();
        }
    }
}

//is divisible by 3, add "Pling" to the result.
//is divisible by 5, add "Plang" to the result.
//is divisible by 7, add "Plong" to the result.
//is not divisible by 3, 5, or 7, the result should be the number as a string.