using System.Reflection.Metadata.Ecma335;

public class Anagram
{

    // cant i just lowercase, sort everything, and compare equality?
    // new string(input.OrderBy(c => c).ToArray();
    private static string _originalWord = "";
    private static string _referenceWord = "";
    public Anagram(string baseWord)
    {
        _originalWord = baseWord;
        _referenceWord = stringifySort(baseWord);
    }

    public string stringifySort(string word)
    {
        // handle the case where the ref word and word are the same
  
        string lowercaseWord = word.ToLower();
        return new string(lowercaseWord.OrderBy(c => c).ToArray());
    }

    public string[] FindAnagrams(string[] potentialMatches)
    {

        List<string> final = [];
        foreach (var word in potentialMatches)
        {
            //stringifySort(word) == _referenceWord ? final.Add(word) : continue;
            if (word != _originalWord)
            {
                if (stringifySort(word) == _referenceWord)
                {
                    final.Add(word);
                }
            }
        }
        return final.ToArray();
    }
}