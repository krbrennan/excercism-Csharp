using System.Reflection.Metadata.Ecma335;

public static class Hamming
{
    public static int Distance(string firstStrand, string secondStrand)
    {

        if(firstStrand.Length != secondStrand.Length)
        {
            throw new ArgumentException();
        }
        // for loop looking at index of each strand, adding to an aggregator

        int numDifferences = 0;

        for (int i = 0; i < firstStrand.Length; i++)
        {
            if(!(firstStrand[i] == secondStrand[i]))
            {
                numDifferences += 1;
            }
            
        }
        return numDifferences;
    }
}