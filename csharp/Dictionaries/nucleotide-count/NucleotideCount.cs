
public static class NucleotideCount
{
    public static IDictionary<char, int> Count(string sequence)
    {
        Dictionary<char, int> solutionDict = new Dictionary<char, int>()
        {
            { 'A', 0 },
            { 'C', 0 },
            { 'G', 0 },
            { 'T', 0 },
        };

        char[] splitSequence = sequence.ToCharArray();

        // all dictionary keys
        var dictKeys = solutionDict.Keys;


        foreach (char nucleotide in splitSequence)
        {
            if(!dictKeys.Contains(nucleotide))
            {
                throw new ArgumentException();
            } else
            {
                solutionDict[nucleotide] += 1;
            }
        }

        return solutionDict;

    }
}