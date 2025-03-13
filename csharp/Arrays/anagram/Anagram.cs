using System.Diagnostics.Tracing;
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

    public bool AlreadyContained(string word, List<string> combinations)
    {
        // this takes in a word and checks to make sure it isn't already in the list of other combinations. Returns true if reversed copy is spotted. The test case I'm trying to pass is specifically: "γβα", "αβγ"
        bool alreadyContained = false;
        foreach (var thing in combinations)
        {
            if (new string(thing.Reverse().ToArray()) == word)
            {
                alreadyContained = true;
            }
        }
        return alreadyContained;
    }

    public bool isSameWord(string word)
    {
        string lowerWord = new string(word.ToLower().ToArray());
        string lowerRef = new string(_originalWord.ToLower().ToArray());

        return lowerWord == lowerRef;
    }

    public string[] FindAnagrams(string[] potentialMatches)
    {
        List<string> final = [];
        foreach (var word in potentialMatches)
        {
            if ((word != _originalWord))
            {
                // check if word == reference word AND that final doesn't already have that word
                if ((stringifySort(word) == _referenceWord) && !AlreadyContained(word, final) && !isSameWord(word))
                {
                    final.Add(word);
                }
            }
        }
        return final.ToArray();
    }
}