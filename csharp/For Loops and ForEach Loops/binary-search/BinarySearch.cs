public static class BinarySearch
{
    //A binary search algorithm finds an item in a list by repeatedly splitting it in half, only keeping the half which contains the item we're looking for. It allows us to quickly narrow down the possible locations of our item until we find it, or until we've eliminated all possible locations.
    private static int midpointIndex;
    public static int Find(int[] input, int value)
    {
        if(input.Length == 1)
        {
            return midpointIndex;
        } else if(input.Length == 0)
        {
            return -1;
        }

            midpointIndex = input.Length / 2;

        if (input[midpointIndex] == value)
        {
            return midpointIndex;
        } else if (input[midpointIndex] < value)
        {
            ArraySegment<int> segment = new ArraySegment<int>(input, 0, midpointIndex);

            Find(segment.ToArray(), value);
        } else
        {
            int maxLength = input.Length;
            ArraySegment<int> segment = new ArraySegment<int>(input, midpointIndex, maxLength - midpointIndex);

            Find(segment.ToArray(), value);
        }

            return -1;
    }
}