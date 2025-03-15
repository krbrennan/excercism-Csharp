using System.Collections.Generic;
public static class BinarySearch
{
    //A binary search algorithm finds an item in a list by repeatedly splitting it in half, only keeping the half which contains the item we're looking for. It allows us to quickly narrow down the possible locations of our item until we find it, or until we've eliminated all possible locations.
    //private static int midpointIndex;

    public static int Find(int[] input, int value)
    {
        int midpoint;

        if(input.Length == 0)
        {
            return -1;
        } else if(input.Length == 1)
        {
            return 0;
        }

        midpoint = input.Length / 2;

        if (input[midpoint] == value)
        {
            return midpoint;
        } else if


        


    }
       
}