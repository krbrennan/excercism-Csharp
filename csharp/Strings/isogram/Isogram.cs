public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        // create a dictionary, iterate over chars, if val exists, return false
        Dictionary<char, int> solutionDict = new Dictionary<char, int>();
        char[] charWord = word.Where(char.IsLetter)
                              .Select(char.ToLower)
                              .ToArray();
        bool isIsogram = true;

        for (int i = 0; i < charWord.Length; i++)
        {
            if (solutionDict.ContainsKey(charWord[i]))
            {
                isIsogram = false;
                return isIsogram;
            } else
            {
                solutionDict[charWord[i]] = 1;
            }
        }
        return isIsogram;
    }
}
