public static class Series
{
    public static string[] Slices(string numbers, int sliceLength)
    {
        // if slice length is greater than numbers length throw exception
        if ((sliceLength >= numbers.Length + 1) || sliceLength <= 0)
        {
            throw new ArgumentException();
        } else if (numbers.Length == 1)
        {
            return new List<string>() { numbers }.ToArray();
        }

        List<string> final = new List<string>() { };

        for (int i = 0; i <= numbers.Length - sliceLength; i++)
        {

            string tempString = "";
            tempString += numbers[i];
            int timesSliced = 1;

            // this was neat. I was having issues with a nested for-loop but I found an equivalent to "n times do". All it took beyond that was solving for the Range and for the limits of the i= for loop
            foreach(var _ in Enumerable.Range(0, sliceLength - 1))
            {
                tempString += numbers[i + timesSliced];
                timesSliced += 1;
            }

            final.Add(tempString);
            tempString = "";
        }

        return final.ToArray();
    }
}