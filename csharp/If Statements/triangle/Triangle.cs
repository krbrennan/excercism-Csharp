public static class Triangle
{
    public static bool hasSides(double side1, double side2, double side3)
    {
        return side1 > 0 && side2 > 0 && side3 > 0;
    }
    public static bool IsTriangle(double side1, double side2, double side3)
    {
        double[] sorted = { side1, side2, side3 };
        Array.Sort(sorted);
        // the sum of the 2 smallest sides better be larger than the largest side
        if (sorted[0] + sorted[1] >= sorted[2])
        {
            return true;
        }
        else return false;
        
    }
    public static bool IsScalene(double side1, double side2, double side3)
    {
        if (hasSides(side1, side2, side3) && IsTriangle(side1, side2, side3))
        {
            return ((side1 != side2) && (side2 != side3) && (side1 != side3));
        }
        else return false;
    }

    public static bool IsIsosceles(double side1, double side2, double side3) 
    {
        //first check if the sides violate basic triangle rules of side lengths

        if ((hasSides(side1, side2, side3)) && IsTriangle(side1, side2, side3))
        {
            return ((side1 == side2) || (side2 == side3) || (side1 == side3));
        }
        else return false;
    }

    public static bool IsEquilateral(double side1, double side2, double side3) 
    {
        if (hasSides(side1, side2, side3))
        {
            return ((side1 == side2) && (side2 == side3) && (side1 == side3));
        }
        else return false;
    }
}