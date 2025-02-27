using System.Numerics;
using System.Transactions;

public static class Darts
{
    public static int Score(double x, double y)
    {
        //throw new NotImplementedException("You need to implement this function");


        //double xAbs = Math.Abs(x);
        //double yAbs = Math.Abs(y);

        //int total = 0;

        //if ((xAbs > 10 || yAbs > 10))
        //{
        //    return total;
        //} else if (xAbs < 1 && yAbs < 1)
        //{
        //    total = 10;
        //} else if (xAbs < 5 && yAbs < 5)
        //{
        //    total = 5;
        //}
        //else { 
        //    total = 1;
        //}
        //return total;

         //this isnt working, what about all the negative values and combinations? what about getting the square root of their combined squares? Thanks euclid, you the real mvp here.

        int score = 0;
        double totalCombined = Math.Sqrt(x * x + y * y);
        if (totalCombined > 10 )
        {
            return score;
        }else if(totalCombined > 5)
        {
            score = 1;
        }else if(totalCombined > 1) {
            score = 5;
        }else
        {
            score = 10;
        }
        
        return score;
    }
}
