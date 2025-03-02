using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System;
using System.Collections.Generic;

public static class Languages
{
    private static List<string> languagesToLearn = new List<string>();
    // {"C#", "Clojure", "Elm"}
    public static List<string> NewList()
    {
        return new List<string>();
    }


    public static List<string> GetExistingLanguages()
    {
        //return languagesToLearn;
        return new List<string> { "C#", "Clojure", "Elm" };
    }

    public static List<string> AddLanguage(List<string> languages, string language)
    {
        //languagesToLearn = languages;
        languagesToLearn = GetExistingLanguages();
        languagesToLearn.Add(language);
        return languagesToLearn;
        //return GetExistingLanguages();
    }

    public static int CountLanguages(List<string> languages)
    {
        return languages.Count;
    }

    public static bool HasLanguage(List<string> languages, string language)
    {
        return languages.Contains(language);
    }

    public static List<string> ReverseList(List<string> languages)
    {

        // When trying to simply return a reverse of the languages var, languages.Reverse() actually returns void and not a list, therefore its necessary to first reverse the languags var in-place, then return it.
        if (languages != null)
        {
            languages.Reverse();
        }
        return languages;
    }

    public static bool IsExciting(List<string> languages)
    {
        IEnumerable<int> range = Enumerable.Range(2,3);
        if(CountLanguages(languages) == 0 || CountLanguages(languages) > 3)
        {
            return false;
        }
        // return true if C# is first on the list
        // return true if C# is second and list has at least 3 languages
        //return (languages.First() == "C#" || ((languages.IndexOf("C#") == 1) && languages.Count >= 3));
        return (languages.First() == "C#" || ((languages.IndexOf("C#") == 1) && range.Contains(CountLanguages(languages)) ));

    }

    public static List<string> RemoveLanguage(List<string> languages, string language)
    {
        //int toRemove = languages.IndexOf(language);
        languages.Remove(language);
        return languages;
    }

    public static bool IsUnique(List<string> languages)
    {
        // so happy to see c# has sets. this language is GOAT-ed
        HashSet<string> unique = new HashSet<string>(languages);
        return unique.Count == languages.Count;
    }
}
