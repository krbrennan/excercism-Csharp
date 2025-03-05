

using System.Net.NetworkInformation;
using System.Text;

public static class Identifier

{

    public static char[] ConvertToChars(string word)
    {
        return word.ToCharArray();
    }

    public static string CamelCase(string word)
    {
        char[] chars = ConvertToChars(word);
        int indexToChange = word.IndexOf("-") + 1;
        chars[indexToChange] = char.ToUpper(chars[indexToChange]);
        string camelCaseWord = new string(chars);
        camelCaseWord = camelCaseWord.Replace("-", "");
        return camelCaseWord;
    }

    public static string removeCtrl(string word)
    {
        string tempWord = "";
        char[] chars = ConvertToChars(word);

        foreach(char c in chars)
        {
            if (!char.IsControl(c))
            {
                tempWord += c;
            }
            else
            {
                tempWord += "CTRL";
            }
        }
            return tempWord;
    }

    public static string RemoveNums(string word)
    {
        char[] chars = ConvertToChars(word);
        string final = "";

        foreach (char c in chars)
        {
            if (c.ToString() == "_")
            {
                final += c;
            } else if (!char.IsDigit(c))
            {
                final += c;
            }
        }
        return final;
    }



    public static bool IsGreek(char c)
    {
        return c >= '\u03B1' && c <= '\u03C9';
    }

    public static string RemoveGreek(string word)
    {
        string final = "";
        foreach (var c in word.ToCharArray())
        {
            if (!IsGreek(c))
            {
                final += c;
            }
        }
        return final;
    }


    public static string Clean(string identifier)
    {
        string cleanedString = "";
        cleanedString = identifier.Replace(" ", "_");

        // make camelCase
        if (identifier.Contains("-"))
        {
            cleanedString = CamelCase(identifier);
        }
        // remove ctrl characters
        cleanedString = removeCtrl(cleanedString);
        cleanedString = RemoveNums(cleanedString);
        cleanedString = RemoveGreek(cleanedString);

        //cleanedString = LettersOnly(cleanedString);

        //cleanedString = RemoveNonLetters(cleanedString);


        return cleanedString;
    }
}
